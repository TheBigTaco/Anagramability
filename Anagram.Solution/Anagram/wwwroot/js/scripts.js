$(document).ready(function(){
    var counter = 1;
    $("#addAnagram").click(function(){
        counter++;
        $("#anagramability").append("<input type='text' name='list-items[]'><br>");
    });
});
