// JavaScript source code
//document.getElementById('ok').onclick = function () {
//    var name = document.getElementById('name').value
//    var age = document.getElementById('age').value;

//    var text = "Your name is " + name;
//    text += " and you are " + age + " old";

//    document.getElementById('result').innerHTML = text;       //inner HTML - between <> <>tags
//    document.getElementById('ok').style.display = 'none';     //Fn + F12 = Web INSPECTOR

//};

$(function () {                                //$ means that JQuery lib is used; to execute only if all html is loaded
    $("#ok").click(function () {               //$("#ok") corresponds to document.getElementById('ok')
        var name = $("#name").val();           // var name = document.getElementById('name').value
        var age = parseInt($("#age").val());         // var age = $("#age").val(); 
        age += 5;

        var text = "Your name is " + name;
        text += " and you are " + age + " years old";

        $("#result").html(text);
        $("#ok").hide();
    });                                    



    $("#plus").click(function () {
        var number1 = parseInt($("#digit1").val());
        var number2 = parseInt($("#digit2").val());
        var result = number1 + number2;

        $("#result").html(result);
    });

    $("#minus").click(function () {
        var number1 = parseInt($("#digit1").val());
        var number2 = parseInt($("#digit2").val());
        var result = number1 - number2;

        $("#result").html(result);          //after (.) call out HTML and write what we put in HTML 
    });
});
