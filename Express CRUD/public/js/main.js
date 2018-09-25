$(document).ready(function(){
    $('.delete-teacher').on('click',function(e){
        $target = $(e.target);
        const id = ($target.attr('data-id'));
        $.ajax({
            type: 'DELETE',
            url: '/teacher/'+id,
            success: function(response){
            alert('Deleting Teacher!!');
            window.location.href='/';
        },
        error: function(err){
            console.log(err);
         }
        });
    });
});