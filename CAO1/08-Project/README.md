# AVR Project written in Assembly (CAO1)

**Authors:**
   - [Robert Misura (269381)](github.com/R0b1S)
   - Ainis Skominas
   - Mihai Barbus
   - Aleksandr Zorin
   - Vladimir Rotaru
---

## Problem formulation
The first light switch was invented in 1884 by John Henry Holmes, employing “quick break technology”, and the same type of technology persists in almost every other ordinary light switch today.[(ref)](https://en.wikipedia.org/wiki/Light_switch) Nowadays a lot of people are supposed to approach the switch and turn the lights on manually. It is problematic sometimes to move through the darkness and sometimes an accident may occur while doing the most simplest thing a person can do.

## Goal
The goal of the project is to optimize the power consumption so the power is not wasted and people could have an option how they want to operate the switches either automatized or manually.

---
### Diagrams
**Switch between sensors/Pushed button**
![push_button_smd](https://github.com/R0b1S/3rd_Semester/blob/master/CAO1/08-Project/appendix/button_push_smd.png)
**Motion sensor**
![motion_sensor_smd](https://github.com/R0b1S/3rd_Semester/blob/master/CAO1/08-Project/appendix/motion_sensor_smd.png)
**Light sensor**
![light_sensor_smd](https://github.com/R0b1S/3rd_Semester/blob/master/CAO1/08-Project/appendix/light_sensor_smd.png)

---

##Circuit diagram
Diagram consists 1 motion sensor, 1 light sensor, 1 LED (light bulb - relay needed), 1 button, 2 resistors. User choose sensor by pressing button. LED lights based on values from sensors.

![circuit_diagram](https://github.com/R0b1S/3rd_Semester/blob/master/CAO1/08-Project/appendix/circuit_diagram.png)

---
