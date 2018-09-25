const express = require('express');
const path = require('path');
const mongoose = require('mongoose');
const bodyParser = require('body-parser');
mongoose.connect('mongodb://localhost/nodekb');
let db = mongoose.connection;

//check connection
db.once('open',function(){
    console.log('connected to mongodb');
    
});
//check for db errors
db.on('error',function(err){
    console.log(err);
});

//init app
const app = express();


//load view engine
app.set('views',path.join(__dirname,'views'));
app.set('view engine','pug');

//bring in models
let Teacher = require('./models/teacher');


//set public folder
app.use(express.static(path.join(__dirname,'public')));

//Home Route
app.get('/',function(req,res){
    
    Teacher.find({},function(err,teachers){
        if(err){
            console.log(err);
        }
        else{
                res.render('index',{
                title :'Teachers Details',
                art:teachers
            });    
        }    
    });
    
})

//get teacher details
app.get('/teacher/:id',function(req,res){
     Teacher.findById(req.params.id,function(err,teacher){
         /*console.log(teacher);
         return;*/
         res.render('teacher_details',{
            teacher : teacher
        });
     });
});

//update teacher details 
app.get('/teacher/edit/:id',function(req,res){
     Teacher.findById(req.params.id,function(err,teacher){
         res.render('edit_teacher',{
            teacher : teacher
        });
     });
});

//add route
app.get('/teachers/add',function(req,res){
    res.render('add_articles',{
        title : 'Add Teachers'
    });
});

//body-parser
// parse application/x-www-form-urlencoded
app.use(bodyParser.urlencoded({ extended: false }))
// parse application/json
app.use(bodyParser.json())

//add submit POST Route
app.post('/teachers/add',function(req,res){
     
     
     let teacher =new Teacher();
     teacher.f_name=req.body.f_name;
     teacher.l_name=req.body.l_name;
     teacher.age=req.body.age;
     teacher.subject=req.body.subject;
    
     teacher.save(function(err){
         if(err){
             console.log(err);
             return;
         }
         else{
             res.redirect('/');
         }
     });
    /*console.log(req.body.f_name);
     return;*/
});

//update submit POST Route
app.post('/teachers/edit/:id',function(req,res){
     
     
     let teacher ={};
     teacher.f_name=req.body.f_name;
     teacher.l_name=req.body.l_name;
     teacher.age=req.body.age;
     teacher.subject=req.body.subject;
     
     let query = {_id:req.params.id};
     Teacher.update(query,teacher,function(err){
         if(err){
             console.log(err);
             return;
         }
         else{
             res.redirect('/');
         }
     });
    /*console.log(req.body.f_name);
     return;*/
});

//delete teacher
app.delete('/teacher/:id',function(req,res){
    let query = {_id:req.params.id};
    Teacher.remove(query,function(err){
        if(err){
            console.log(err);
        }
        res.send('Success');
    });
    
});

//server start
app.listen(3000,function(){
    console.log('server started on port 3000...');
});