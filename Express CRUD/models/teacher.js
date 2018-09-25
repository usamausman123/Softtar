let mongoose = require('mongoose');

//teacher schema
let teacherSchema = mongoose.Schema({
    f_name:{
        type: String,
        required: true
    },
    l_name:{
        type: String,
        required: true
    },
    age:{
        type: String,
        required: true
    },
    subject:{
        type: String,
        required: true
    }
});

let Teacher = module.exports = mongoose.model('Teacher',teacherSchema);