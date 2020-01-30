# ListViewAddingTest

This is a simple repo that reproduces a strange behaviour in ListView UWP. To reproduce the bug:

1. Add an item to the list and draw something (like the number 1) on the canvas item
2. Then Repeat this until you have 6-7 items in the list 
3. Then Add more than 15 items in the list 
4. You will see that some of the new items added are not blank like they should, but they are a copy of the previously added items.
