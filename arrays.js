let my_hobbies = ["Programming", "Reading", "Listening to music"];
console.log(my_hobbies);

my_hobbies.pop();              
my_hobbies.push("Drawing");    
console.log(my_hobbies);

my_hobbies.shift();            
my_hobbies.unshift("Running"); 
console.log(my_hobbies);

console.log(my_hobbies.length); 

my_hobbies.forEach((i) => {
    console.log("My hobby is: " + i);
});