
//Javascript code

document.querySelectorAll("form >.Form__MainBody > section > div > input[placeholder='Name']").forEach(function(p) {
   console.log(p.value);
   p.style.color = 'orange';  
  });
