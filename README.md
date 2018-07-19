# Jeylabs code reviews(C#)

## General Directions

<br/>
Complete the following puzzle in C#. Your completed solution must be able to be built in Visual Studio 2017 without additional software or commercial add-ons (NuGet packages/NPM Packages & Angular is allowed).   

* All code should be considered ready for production!

## Submissions
Share a private Bitbucket or GitHub repository containing your solution with jeylabscodereviews.  

## The Problem 
Write a program that lets the user generate a shape with the dimensions of their choosing using a semi-natural language interface. Your solution must have two components – a “front-end” and a “back-end”.  

## User Story  
As a user I want to generate shapes with natural language so that I don’t have to enter values in boxes  

## Acceptance Criteria  
The user should specify what to draw using natural language. To keep things simple, we’ll fix the allowed format to the following: `Draw a(n) <shape> with a(n) <measurement> of <amount> (and a(n) <measurement> of <amount>) `

Here are some examples:  
* Draw a circle with a radius of 100  
* Draw a square with a side length of 200  
* Draw a rectangle with a width of 250 and a height of 400  
* Draw an octagon with a side length of 200  
* Draw an isosceles triangle with a height of 200 and a width of 100  
 	 
The following shapes should be supported:  
* Isosceles Triangle  	 
* Square  
* Scalene Triangle  		
* Parallelogram  
* Equilateral Triangle  	 
* Pentagon  
* Rectangle 
* Hexagon  
* Heptagon  
* Octagon  
* Circle  	 
* Oval

The input parsing should happen in the back-end.  
Once the user enters the information, the shape should be displayed on the screen.  
Distances are in pixels.

## Optional  
If you thought that was too easy, add support for some 3D shapes.  

