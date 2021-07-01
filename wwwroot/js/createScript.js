let count = 0;
let index = 1;

const listOptions = ["Hanshansennytral.gif", "hissighansen.gif", "Hanshansenglad.gif"
    ,"Karstein.gif", "Karsteinglad.gif", "Karsteinsur.gif", "Lindaglad.gif", "Lindanytral.gif", "lindasur.gif",
    "Merethe.gif", "Toreglad.gif", "ToreHansen.gif", "Toresure.gif"];
const descriptions = ["Snakk med Hans Hansen", "Snakk med Hans Hansen", "Snakk med Hans Hansen", "Snakk med Karstein",
    "Snakk med Karstein", "Snakk med Karstein", "Snakk med Linda", "Snakk med Linda", "Snakk med Linda", "Snakk med Merethe", "Snakk med Tore",
    "Snakk med Tore", "Snakk med Tore"]


// Create a break line element 
var br = document.createElement("br");
function addForm() {

    // Create a form synamically
    let form = document.createElement("div");


    var displayNr = document.createElement("input");
    displayNr.setAttribute("type", "text");
    displayNr.setAttribute("size", "3");
    displayNr.setAttribute("value", count+1);
    displayNr.setAttribute("readonly", "true");
    displayNr.setAttribute("class", "form-control-sm");
    displayNr.setAttribute("name", "QuestionList[" +count+ "].Nr");


    



    //question
    var QUE = document.createElement("input");
    QUE.setAttribute("type", "text");
    //QUE.setAttribute("name", "Question"); 
    QUE.setAttribute("placeholder", "Question");
    QUE.setAttribute("size", "60")
    QUE.setAttribute("name", "QuestionList[" +count+ "].Question");
    QUE.setAttribute("class", "form-control-sm");
    QUE.required = true;

    //answer 1
    var ANSW1 = document.createElement("input");
    ANSW1.setAttribute("type", "text");
    //ANSW1.setAttribute("name", "Answer1"); 
    ANSW1.setAttribute("placeholder", "Answer1");
    ANSW1.setAttribute("size", "50");
    ANSW1.setAttribute("name", "QuestionList[" +count+ "].Answer1");
    ANSW1.setAttribute("id", "QuestionList[" +count+ "].Answer1");
    ANSW1.setAttribute("class", "form-control-sm");
    ANSW1.required = true;

    // where answer 1 goes
    var ANSW1T = document.createElement("input");
    ANSW1T.setAttribute("type", "text");
    //ANSW1T.setAttribute("name", "Answer1to"); 
    ANSW1T.setAttribute("placeholder", "Go to");
    ANSW1T.setAttribute("size", "3");
    ANSW1T.setAttribute("name", "QuestionList[" +count+ "].Next1");
    ANSW1T.setAttribute("class", "form-control-sm");
    ANSW1T.required = true;

    var ANSW1P = document.createElement("input");
    ANSW1P.setAttribute("type", "number");
    ANSW1P.setAttribute("min", "-5");
    ANSW1P.setAttribute("max", "5");
    ANSW1P.setAttribute("placeholder", "poeng");
    ANSW1P.setAttribute("size", "3");
    ANSW1P.setAttribute("name", "QuestionList[" + count + "].Points1");
    ANSW1P.setAttribute("class", "form-control-sm");
    ANSW1P.required = true;
    ANSW1P.value = "0";

    // answer 2
    var ANSW2 = document.createElement("input");
    ANSW2.setAttribute("type", "text");
    //ANSW2.setAttribute("name", "Answer2"); 
    ANSW2.setAttribute("placeholder", "Answer2");
    ANSW2.setAttribute("size", "50");
    ANSW2.setAttribute("name", "QuestionList[" +count+ "].Answer2");
    ANSW2.setAttribute("id", "QuestionList[" +count+ "].Answer2");
    ANSW2.setAttribute("class", "form-control-sm");

    // where answer 2 goes
    var ANSW2T = document.createElement("input");
    ANSW2T.setAttribute("type", "text");
    //ANSW2T.setAttribute("name", "Answer2to"); 
    ANSW2T.setAttribute("placeholder", "Go to");
    ANSW2T.setAttribute("size", "3");
    ANSW2T.setAttribute("name", "QuestionList[" +count+ "].Next2");
    ANSW2T.setAttribute("class", "form-control-sm");

    var ANSW2P = document.createElement("input");
    ANSW2P.setAttribute("type", "number");
    ANSW2P.setAttribute("min", "-5");
    ANSW2P.setAttribute("max", "5");
    ANSW2P.setAttribute("placeholder", "poeng");
    ANSW2P.setAttribute("size", "3");
    ANSW2P.setAttribute("name", "QuestionList[" + count + "].Points2");
    ANSW2P.setAttribute("class", "form-control-sm");

    // answer 3
    var ANSW3 = document.createElement("input");
    ANSW3.setAttribute("type", "text");
    // ANSW3.setAttribute("name", "Answer3"); 
    ANSW3.setAttribute("placeholder", "Answer3");
    ANSW3.setAttribute("size", "50");
    ANSW3.setAttribute("name", "QuestionList[" +count+ "].Answer3");
    ANSW3.setAttribute("id", "QuestionList[" +count+ "].Answer3");
    ANSW3.setAttribute("class", "form-control-sm");

    // where answer 3 goes
    var ANSW3T = document.createElement("input");
    ANSW3T.setAttribute("type", "text");
    //  ANSW3T.setAttribute("name", "Answer3to"); 
    ANSW3T.setAttribute("placeholder", "Go to");
    ANSW3T.setAttribute("size", "3");
    ANSW3T.setAttribute("name", "QuestionList[" +count+ "].Next3");
    ANSW3T.setAttribute("class", "form-control-sm");

    var ANSW3P = document.createElement("input");
    ANSW3P.setAttribute("type", "number");
    ANSW3P.setAttribute("min", "-5");
    ANSW3P.setAttribute("max", "5");
    ANSW3P.setAttribute("placeholder", "number");
    ANSW3P.setAttribute("size", "3");
    ANSW3P.setAttribute("name", "QuestionList[" + count + "].Points3");
    ANSW3P.setAttribute("class", "form-control-sm");

    // answer 4
    var ANSW4 = document.createElement("input");
    ANSW4.setAttribute("type", "text");
    //  ANSW4.setAttribute("name", "Answer4"); 
    ANSW4.setAttribute("placeholder", "Answer4");
    ANSW4.setAttribute("size", "50");
    ANSW4.setAttribute("name", "QuestionList[" +count+ "].Answer4");
    ANSW4.setAttribute("id", "QuestionList[" +count+ "].Answer4");
    ANSW4.setAttribute("class", "form-control-sm");

    //where answer 4 goes
    var ANSW4T = document.createElement("input");
    ANSW4T.setAttribute("type", "text");
    //   ANSW4T.setAttribute("name", "Answer4to"); 
    ANSW4T.setAttribute("placeholder", "Go to");
    ANSW4T.setAttribute("size", "3");
    ANSW4T.setAttribute("name", "QuestionList[" +count+ "].Next4");
    ANSW4T.setAttribute("class", "form-control-sm");

    var ANSW4P = document.createElement("input");
    ANSW4P.setAttribute("type", "number");
    ANSW4P.setAttribute("min", "-5");
    ANSW4P.setAttribute("max", "5");
    ANSW4P.setAttribute("placeholder", "number");
    ANSW4P.setAttribute("size", "3");
    ANSW4P.setAttribute("name", "QuestionList[" + count + "].Points4");
    ANSW4P.setAttribute("class", "form-control-sm");

    var IMGL = document.createElement("select");
    IMGL.setAttribute("type", "text");
    //  IMGL.setAttribute("name", "ImageLink"); 
    //IMGL.setAttribute("placeholder", "Image: Hansglad.gif"); 
    IMGL.setAttribute("name", "QuestionList[" +count+ "].Image");
    IMGL.setAttribute("class", "form-select form-select-md");

    let QTYPE = document.createElement("select");
    QTYPE.setAttribute("type", "text");
    QTYPE.setAttribute("name", "QuestionList[" +count+"].Type");
    QTYPE.setAttribute("class", "form-select form-select-md");

    var BGIL = document.createElement("select");
    BGIL.setAttribute("type", "text");
    //  IMGL.setAttribute("name", "ImageLink"); 
    //IMGL.setAttribute("placeholder", "Image: Hansglad.gif"); 
    BGIL.setAttribute("name", "QuestionList[" +count+ "].Background");
    BGIL.setAttribute("class", "form-select form-select-md");
    
    
    let gang = document.createElement("option");
    gang.innerHTML = "I gangen";
    gang.value = "gang";
    BGIL.appendChild(gang);

    let hansRom = document.createElement("option");
    hansRom.innerHTML = "Hans sitt rom";
    hansRom.value = "rom";
    BGIL.appendChild(hansRom);

    let kontor = document.createElement("option");
    kontor.innerHTML = "Leders kontor";
    kontor.value = "kontor";
    BGIL.appendChild(kontor);

    let leilighet = document.createElement("option");
    leilighet.innerHTML = "I leilighet";
    leilighet.value = "leilighet";
    BGIL.appendChild(leilighet);
    
    let Standard = document.createElement("option");
    Standard.innerHTML = "Standard";
    Standard.value = "Standard";
    QTYPE.appendChild(Standard);

    let TextBox = document.createElement("option");
    TextBox.innerHTML = "TextBox";
    TextBox.value = "TextBox";
    QTYPE.appendChild(TextBox);

    let Quiz = document.createElement("option");
    Quiz.innerHTML = "Quiz";
    Quiz.value = "Quiz"
    QTYPE.appendChild(Quiz);

    let LastQuestion = document.createElement("option");
    LastQuestion.innerHTML = "Siste spørsmål";
    LastQuestion.value = "LastQuestion";
    QTYPE.appendChild(LastQuestion)

    
    let Character = document.createElement("option");
    Character.innerHTML = "Character";
    Character.value = "Character";
    QTYPE.appendChild(Character);
    QTYPE.onchange = function (){
        if (QTYPE.value == "Character"){
        setToChar(document.getElementById(ANSW1.id), form);
        setToChar(document.getElementById(ANSW2.id), form);
        setToChar(document.getElementById(ANSW3.id), form);
        setToChar(document.getElementById(ANSW4.id), form);
        }else{
            setToText(document.getElementById(ANSW1.id), form);
            setToText(document.getElementById(ANSW2.id), form);
            setToText(document.getElementById(ANSW3.id), form);
            setToText(document.getElementById(ANSW4.id), form);
        }
    };



    for(let i =0; i<listOptions.length;i++)
    {
        let option = document.createElement("option");
        option.innerHTML = listOptions[i];
        option.value = listOptions[i];
        IMGL.appendChild(option);
    }
    let emptyOption = document.createElement("option");
    emptyOption.innerHTML = "Ingen Karakter";
    emptyOption.value = "";
    IMGL.appendChild(emptyOption);
    let ringOption = document.createElement("option");
    emptyOption.innerHTML = "ring";
    emptyOption.value = "ring.gif";
    IMGL.appendChild(emptyOption);
    


    // create a submit button 
    /*
    if (count === 0){
    var s = document.createElement("input"); 
    s.setAttribute("type", "submit"); 
    s.setAttribute("value", "Submit"); 
    }
      
    if (count === 0){
        form.appendChild(s); 
        form.appendChild(br.cloneNode());  
        }
        
        
     */
    // Append the full name input to the form
    let qContainer = document.createElement("div");
    qContainer.setAttribute("class", "form-row");
   
    //form.appendChild(displayNr);
    qContainer.appendChild(displayNr);
    qContainer.appendChild(QUE);
    //some styling stuff


    // Inserting a line break 
    //form.appendChild(br.cloneNode());  

    // Append the QUE to the form 
    //form.appendChild(QUE); 
    form.appendChild(qContainer);
    //form.appendChild(br.cloneNode());  

    // Append the emailID to the form 
    form.appendChild(ANSW1);
    //form.appendChild(br.cloneNode());  

    // Append the Password to the form 
    form.appendChild(ANSW1T);
    form.appendChild(ANSW1P);
    form.appendChild(br.cloneNode());

    // Append the ReEnterPassword to the form 
    form.appendChild(ANSW2);
    form.appendChild(ANSW2T);
    form.appendChild(ANSW2P);
    form.appendChild(br.cloneNode());
    form.appendChild(ANSW3);
    form.appendChild(ANSW3T);
    form.appendChild(ANSW3P);
    form.appendChild(br.cloneNode());
    form.appendChild(ANSW4);
    form.appendChild(ANSW4T);
    form.appendChild(ANSW4P);
    form.appendChild(br.cloneNode());
    form.appendChild(IMGL);
    form.appendChild(BGIL);
    form.appendChild(QTYPE);
    // Append the submit button to the form 

    form.appendChild(br.cloneNode());
    form.appendChild(br.cloneNode());
    form.setAttribute("class", "form")
    document.getElementById("questions").appendChild(form);
    count += 1;
    index += 1;
    
    
}
function setToChar(elem, form){
    let name = elem.getAttribute("name");
    let id = elem.getAttribute("id");
    let imageSelect = document.createElement("select");
    imageSelect.setAttribute("type", "text");
    imageSelect.setAttribute("name", name);
    imageSelect.setAttribute("id", id);
    for(let i =0; i<listOptions.length;i++)
    {
        let option = document.createElement("option");
        option.innerHTML = listOptions[i];
        option.value = listOptions[i] + "delim" + descriptions[i];
        imageSelect.appendChild(option);
    }
    let option = document.createElement("option");
    option.innerHTML = "Ingen Karakter";
    option.value = "";
    imageSelect.appendChild(option);
    form.replaceChild(imageSelect, elem);
    
    
}
function setToText(elem, form){
    let name = elem.getAttribute("name");
    let id = elem.getAttribute("id");
    let textSelect = document.createElement("input");
    
    textSelect.setAttribute("name", name);
    textSelect.setAttribute("id", name);
    
    form.replaceChild(textSelect, elem);
    textSelect.setAttribute("type", "text");
    textSelect.setAttribute("class", "form-control-sm");
    textSelect.setAttribute("size", "50");

}
function setToQuiz(elem, form){
    let name = elem.getAttribute("name");
    let id = elem.getAttribute("id");
    let textSelect = document.createElement("input");

    textSelect.setAttribute("name", name);
    textSelect.setAttribute("id", name);

    form.replaceChild(textSelect, elem);
    textSelect.setAttribute("type", "text");
    textSelect.setAttribute("class", "form-control-sm");
    textSelect.setAttribute("size", "50");

}
/*
function removeForm() {


    var list = document.getElementById("questions");


    if (count>=1){


        list.removeChild(list.lastChild)

        //form.removeChild(form.lastChild)
        // list.removeChild(list.lastChild)
        count-=1;
    }
}*/


function addFilled(nr, q, a1, a1t, a1p, a2, a2t, a2p, a3, a3t, a3p, a4, a4t, a4p, img, type, audioURl, bgURL){
    let form = document.createElement("div");


    var displayNr = document.createElement("input");
    displayNr.setAttribute("type", "text");
    displayNr.setAttribute("size", "3");
    displayNr.setAttribute("value", count + 1);
    displayNr.setAttribute("readonly", "true");
    displayNr.setAttribute("class", "form-control-sm");
    displayNr.setAttribute("name", "QuestionList[" +count+ "].Nr");
    
    let audio = document.createElement("input");
    audio.setAttribute("hidden", "true");
    audio.value = audioURl;
    audio.setAttribute("name", "QuestionList[" +count+ "].AudioURL")
    

   



    //question
    var QUE = document.createElement("input");
    QUE.setAttribute("type", "text");
    //QUE.setAttribute("name", "Question"); 
    QUE.setAttribute("placeholder", "Question");
    QUE.setAttribute("size", "60")
    QUE.setAttribute("name", "QuestionList[" +count+ "].Question");
    QUE.setAttribute("class", "form-control-sm");
    QUE.setAttribute("value", q);

    //answer 1
    var ANSW1 = document.createElement("input");
    ANSW1.setAttribute("type", "text");
    //ANSW1.setAttribute("name", "Answer1"); 
    ANSW1.setAttribute("placeholder", "Answer1");
    ANSW1.setAttribute("size", "50");
    ANSW1.setAttribute("name", "QuestionList[" +count+ "].Answer1");
    ANSW1.setAttribute("id", "QuestionList[" +count+ "].Answer1");
    ANSW1.setAttribute("class", "form-control-sm");
   

    // where answer 1 goes
    var ANSW1T = document.createElement("input");
    ANSW1T.setAttribute("type", "text");
    //ANSW1T.setAttribute("name", "Answer1to"); 
    ANSW1T.setAttribute("placeholder", "Go to");
    ANSW1T.setAttribute("size", "3");
    ANSW1T.setAttribute("name", "QuestionList[" +count+ "].Next1");
    ANSW1T.setAttribute("class", "form-control-sm");
    ANSW1T.setAttribute("value", a1t);

    var ANSW1P = document.createElement("input");
    ANSW1P.setAttribute("type", "number");
    ANSW1P.setAttribute("min", "-5");
    ANSW1P.setAttribute("max", "5");
    ANSW1P.setAttribute("placeholder", "poeng");
    ANSW1P.setAttribute("size", "3");
    ANSW1P.setAttribute("name", "QuestionList[" + count + "].Points1");
    ANSW1P.setAttribute("class", "form-control-sm");
    ANSW1P.setAttribute("value", a1p);

    // answer 2
    var ANSW2 = document.createElement("input");
    ANSW2.setAttribute("type", "text");
    //ANSW2.setAttribute("name", "Answer2"); 
    ANSW2.setAttribute("placeholder", "Answer2");
    ANSW2.setAttribute("size", "50");
    ANSW2.setAttribute("name", "QuestionList[" +count+ "].Answer2");
    ANSW2.setAttribute("id", "QuestionList[" +count+ "].Answer2");
    ANSW2.setAttribute("class", "form-control-sm");
      
    
    
    
    // where answer 2 goes
    var ANSW2T = document.createElement("input");
    ANSW2T.setAttribute("type", "text");
    //ANSW2T.setAttribute("name", "Answer2to"); 
    ANSW2T.setAttribute("placeholder", "Go to");
    ANSW2T.setAttribute("size", "3");
    ANSW2T.setAttribute("name", "QuestionList[" +count+ "].Next2");
    ANSW2T.setAttribute("class", "form-control-sm");
    ANSW2T.setAttribute("value", a2t);

    var ANSW2P = document.createElement("input");
    ANSW2P.setAttribute("type", "number");
    ANSW2P.setAttribute("min", "-5");
    ANSW2P.setAttribute("max", "5");
    ANSW2P.setAttribute("placeholder", "poeng");
    ANSW2P.setAttribute("size", "3");
    ANSW2P.setAttribute("name", "QuestionList[" + count + "].Points2");
    ANSW2P.setAttribute("class", "form-control-sm");
    ANSW2P.setAttribute("value", a2p);

    // answer 3
    var ANSW3 = document.createElement("input");
    ANSW3.setAttribute("type", "text");
    // ANSW3.setAttribute("name", "Answer3"); 
    ANSW3.setAttribute("placeholder", "Answer3");
    ANSW3.setAttribute("size", "50");
    ANSW3.setAttribute("name", "QuestionList[" +count+ "].Answer3");
    ANSW3.setAttribute("id", "QuestionList[" +count+ "].Answer3");
    ANSW3.setAttribute("class", "form-control-sm");
    
    
    
    // where answer 3 goes
    var ANSW3T = document.createElement("input");
    ANSW3T.setAttribute("type", "text");
    //  ANSW3T.setAttribute("name", "Answer3to"); 
    ANSW3T.setAttribute("placeholder", "Go to");
    ANSW3T.setAttribute("size", "3");
    ANSW3T.setAttribute("name", "QuestionList[" +count+ "].Next3");
    ANSW3T.setAttribute("class", "form-control-sm");
    ANSW3T.setAttribute("value", a3t);

    var ANSW3P = document.createElement("input");
    ANSW3P.setAttribute("type", "number");
    ANSW3P.setAttribute("min", "-5");
    ANSW3P.setAttribute("max", "5");
    ANSW3P.setAttribute("placeholder", "number");
    ANSW3P.setAttribute("size", "3");
    ANSW3P.setAttribute("name", "QuestionList[" + count + "].Points3");
    ANSW3P.setAttribute("class", "form-control-sm");
    ANSW3P.setAttribute("value", a3p);

    // answer 4
    var ANSW4 = document.createElement("input");
    ANSW4.setAttribute("type", "text");
    //  ANSW4.setAttribute("name", "Answer4"); 
    ANSW4.setAttribute("placeholder", "Answer4");
    ANSW4.setAttribute("size", "50");
    ANSW4.setAttribute("name", "QuestionList[" +count+ "].Answer4");
    ANSW4.setAttribute("id", "QuestionList[" +count+ "].Answer4");
    ANSW4.setAttribute("class", "form-control-sm");
    //ANSW4.setAttribute("value", a4);
    
    
    

    //where answer 4 goes
    var ANSW4T = document.createElement("input");
    ANSW4T.setAttribute("type", "text");
    //   ANSW4T.setAttribute("name", "Answer4to"); 
    ANSW4T.setAttribute("placeholder", "Go to");
    ANSW4T.setAttribute("size", "3");
    ANSW4T.setAttribute("name", "QuestionList[" +count+ "].Next4");
    ANSW4T.setAttribute("class", "form-control-sm");
    ANSW4T.setAttribute("value", a4t);

    var ANSW4P = document.createElement("input");
    ANSW4P.setAttribute("type", "number");
    ANSW4P.setAttribute("min", "-5");
    ANSW4P.setAttribute("max", "5");
    ANSW4P.setAttribute("placeholder", "number");
    ANSW4P.setAttribute("size", "3");
    ANSW4P.setAttribute("name", "QuestionList[" + count + "].Points4");
    ANSW4P.setAttribute("class", "form-control-sm");
    ANSW4P.setAttribute("value", a4p);

    var IMGL = document.createElement("select");
    IMGL.setAttribute("type", "text");
    //  IMGL.setAttribute("name", "ImageLink"); 
    //IMGL.setAttribute("placeholder", "Image: Hansglad.gif"); 
    IMGL.setAttribute("name", "QuestionList[" +count+ "].Image");
    IMGL.setAttribute("class", "form-select form-select-md");
    

    let QTYPE = document.createElement("select");
    QTYPE.setAttribute("type", "text");
    QTYPE.setAttribute("name", "QuestionList[" +count+"].Type");
    QTYPE.setAttribute("class", "form-select form-select-md");
    
    QTYPE.onchange = function (){
        if (QTYPE.value == "Character"){
            setToChar(document.getElementById(ANSW1.id), form);
            setToChar(document.getElementById(ANSW2.id), form);
            setToChar(document.getElementById(ANSW3.id), form);
            setToChar(document.getElementById(ANSW4.id), form);
        }else{
            setToText(document.getElementById(ANSW1.id), form);
            setToText(document.getElementById(ANSW2.id), form);
            setToText(document.getElementById(ANSW3.id), form);
            setToText(document.getElementById(ANSW4.id), form);
        }
    };
    var BGIL = document.createElement("select");
    BGIL.setAttribute("type", "text");
    //  IMGL.setAttribute("name", "ImageLink"); 
    //IMGL.setAttribute("placeholder", "Image: Hansglad.gif"); 
    BGIL.setAttribute("name", "QuestionList[" +count+ "].Background");
    BGIL.setAttribute("class", "form-select form-select-md");


    let gang = document.createElement("option");
    gang.innerHTML = "I gangen";
    gang.value = "gang";
    BGIL.appendChild(gang);

    let hansRom = document.createElement("option");
    hansRom.innerHTML = "Rommet til Hans";
    hansRom.value = "rom";
    BGIL.appendChild(hansRom);

    let kontor = document.createElement("option");
    kontor.innerHTML = "Leders kontor";
    kontor.value = "kontor";
    BGIL.appendChild(kontor);

    let leilighet = document.createElement("option");
    leilighet.innerHTML = "I leilighet";
    leilighet.value = "leilighet";
    BGIL.appendChild(leilighet);
 
    
    let Standard = document.createElement("option");
    Standard.innerHTML = "Standard";
    Standard.value = "Standard";
    QTYPE.appendChild(Standard);

    let TextBox = document.createElement("option");
    TextBox.innerHTML = "Tekstboks";
    TextBox.value = "TextBox";
    QTYPE.appendChild(TextBox);

    let Character = document.createElement("option");
    Character.innerHTML = "Karakter";
    Character.value = "Character";
    QTYPE.appendChild(Character);
    
    let Quiz = document.createElement("option");
    Quiz.innerHTML = "Quiz";
    Quiz.value = "Quiz"
    QTYPE.appendChild(Quiz);
    
    let LastQuestion = document.createElement("option");
    LastQuestion.innerHTML = "Siste spørsmål";
    LastQuestion.value = "LastQuestion";
    QTYPE.appendChild(LastQuestion);
    


    for(let i =0; i<listOptions.length;i++)
    {
        let option = document.createElement("option");
        option.innerHTML = listOptions[i];
        option.value = listOptions[i];
        IMGL.appendChild(option);
    }
    let emptyOption = document.createElement("option");
    emptyOption.innerHTML = "Ingen Karakter";
    emptyOption.value = "";
    let ringOption = document.createElement("option");
    emptyOption.innerHTML = "ring";
    emptyOption.value = "ring.gif";
    IMGL.appendChild(emptyOption);






    // create a submit button 
    /*
    if (count === 0){
    var s = document.createElement("input"); 
    s.setAttribute("type", "submit"); 
    s.setAttribute("value", "Submit"); 
    }
      
    if (count === 0){
        form.appendChild(s); 
        form.appendChild(br.cloneNode());  
        }
        
        
     */
    // Append the full name input to the form
    let qContainer = document.createElement("div");
    qContainer.setAttribute("class", "form-row");
    //form.appendChild(NR);
    //form.appendChild(displayNr);
    qContainer.appendChild(displayNr);
    qContainer.appendChild(QUE);
    //some styling stuff


    // Inserting a line break 
    //form.appendChild(br.cloneNode());  

    // Append the QUE to the form 
    //form.appendChild(QUE); 
    form.appendChild(qContainer);
    //form.appendChild(br.cloneNode());  

    // Append the emailID to the form 
    form.appendChild(ANSW1);
    //form.appendChild(br.cloneNode());  

    // Append the Password to the form 
    form.appendChild(ANSW1T);
    form.appendChild(ANSW1P);
    form.appendChild(br.cloneNode());

    // Append the ReEnterPassword to the form 
    form.appendChild(ANSW2);
    form.appendChild(ANSW2T);
    form.appendChild(ANSW2P);
    form.appendChild(br.cloneNode());
    form.appendChild(ANSW3);
    form.appendChild(ANSW3T);
    form.appendChild(ANSW3P);
    form.appendChild(br.cloneNode());
    form.appendChild(ANSW4);
    form.appendChild(ANSW4T);
    form.appendChild(ANSW4P);
    form.appendChild(br.cloneNode());
    form.appendChild(IMGL);
    form.appendChild(BGIL);
    form.appendChild(QTYPE);
    form.appendChild(audio);
    // Append the submit button to the form 

    form.appendChild(br.cloneNode());
    form.appendChild(br.cloneNode());
    form.setAttribute("class", "form")
    document.getElementById("questions").appendChild(form);
    count += 1;
    index = parseInt(nr) + 1;
    //verdier settes på bunnen siden elemenetene må være på sida først
    IMGL.value = img;
    QTYPE.value = type;
    BGIL.value = bgURL;
    if(type == "Character"){
        setToChar(document.getElementById(ANSW1.id), form);
        setToChar(document.getElementById(ANSW2.id), form);
        setToChar(document.getElementById(ANSW3.id), form);
        setToChar(document.getElementById(ANSW4.id), form);
    }
    /*
    document.getElementById(ANSW1.id).setAttribute("value", a1);
    document.getElementById(ANSW2.id).setAttribute("value", a2);
    document.getElementById(ANSW3.id).setAttribute("value", a3);
    document.getElementById(ANSW4.id).setAttribute("value", a4);
    */
    document.getElementById(ANSW1.id).value = a1;
    document.getElementById(ANSW2.id).value = a2;
    document.getElementById(ANSW3.id).value = a3;
    document.getElementById(ANSW4.id).value = a4;
   
}


