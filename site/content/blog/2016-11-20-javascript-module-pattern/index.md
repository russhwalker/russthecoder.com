---
title: "JavaScript Design Patterns: Module Pattern"
date: "2016-11-20T00:00:00.000Z"
description: "An introduction to the JavaScript Module Pattern."
---

The **module pattern** is a design pattern that greatly helps to create a clean JavaScript code base. Instead of files full of random intertwined functions that call in each other in a spaghetti code fashion, the module pattern pushes us to group common functionality(functions and variables) together. By doing this we use the power of JavaScript closures to have private variables and functions that are NOT in the global scope.

---

**In the following JavaScript code file below, we define the first part of the module which simply defines one public function, *addNumber*.**

```javascript
var MyApp = (function () {
    var addNumber = function(a, b){
        return a + b;
    };
    return {
        add: addNumber
    };
}());
```

---

**Here in our second JavaScript file, we extend our module by adding a *multiply* function.**

```javascript
var MyApp = (function (myApp) {
    myApp.multiply = function (a, b) {
        return a * b;
    };
    return myApp;
} (MyApp || {}));
```

---

**In our third and last JavaScript file we add a *circle* sub-module.  This sub-module adds a public function as well as a private variable for pi. This private variable is only accessible within the scope of circle.**

```javascript
MyApp.Circle = function () {
    var pi = Math.PI; 
    var calcArea = function (r) {
        return pi * r * r;
    }; 
    return {
        calcArea: calcArea    
    };
}();
```

---

**Here are the results of the console output showing the results of our modules working together:**

```html
<body>
    <script src="siteModule1.js"></script>
    <script src="siteModule2.js"></script>
    <script src="siteModule3.js"></script>
    <script>
        console.log(MyApp.add(3, 7));
        console.log(MyApp.multiply(3, 7));
        console.log(MyApp.Circle.calcArea(2));
        console.log(MyApp.pi); //undefined, pi is not in scope    
    </script>
</body>
```