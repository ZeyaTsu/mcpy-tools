import colorama
from colorama import Fore, Back, Style
import index
import debugmode
from debugmode import *


colorama.init()
bm = Back.MAGENTA
w = Fore.WHITE
g = Fore.GREEN
c = Fore.CYAN
import math

def all():


    print(g+"- - - - - Stronghold Finder - - - - -")

    print(g+"Follow the steps to get the correct coordinates.")
    print("1. Go to X:0 and Z:0 (Press F3 to show coordinates)")
    print("2. Throw an ender eye, look at the center of it and look at 'Facing' Section.")
    print("Write down the Facing (North,south,west or east) and the first number after it.")
    print("E.g: Facing: north (Towars negative Z) (xxx <- this number)")
    print("Write that number here. (The most you look to the center of it, the most accurate it is.)")
    ThisAngle1 = float(input("> "))
    facing = str(input("Facing: north/south/east/west > "))

    if facing == "north":
        print("Please go to X:0 Z: -310")
        c = -310
    if facing == "south":
        print("Please go to X:0 Z: 310")
        c = 310
    if facing == "west":
        print("Please go to X:-310 Z:0")
        c = -310
    if facing == "east":
        print("Please go to X:310 Z:0")
        c = 310
    print("Redo the steps and enter the number you get in the facing section:")
    ThisAngle2 = float(input("> "))

    

#142
#135.1
    angle1 = ThisAngle1
    angle2 = ThisAngle2
    h0 = 90 - ThisAngle1
    h00 = 90 - ThisAngle2

    def north(h0, c, h00):
        h1 = math.radians(h0)
        h2 = math.radians(h00)
       

        xNorthFind = -(c / (math.tan(h1) - math.tan(h2)))
        zNorthFind = (c*math.tan(h1)) / (math.tan(h1) - math.tan(h2)) 

        print("- - - - -  Coordinates - - - - -")

        print("Stronghold found!")
        print("X:",xNorthFind, "Z:",zNorthFind)
        print("Note: If you don't find the stronghold on those coordinates, it may be around of that area.")
        print("You can use an cave finder bug if you have troubles.")
        choix()



       
    def west(c, angle1, angle2):
        print("gfhjghdfjgd")
        h3 = math.radians(angle1)
        h4 = math.radians(angle2)
        aWestFind = (c * math.tan(h3)) / (math.tan(h3) - math.tan(h4))
        bWestFind = -(c / (math.tan(h3) - math.tan(h4)))

        print("- - - - -  Coordinates - - - - -")

        print("Stronghold found!")
        print("X:",aWestFind, "Z:",bWestFind)
        print("Note: If you don't find the stronghold on those coordinates, it may be around of that area.")
        print("You can use an cave finder bug if you have troubles.")
        choix()


    if facing == "west":
        west(c, angle1, angle2)
    if facing == "east":
        west(c, angle1, angle2)
    if facing == "north":
        north(h0, c, h00)
    if facing == "south":
        north(h0, c, h00)

    
 


    
def choix():
    print(c+"Write 'list' to go back. 'r' to restart.")
    w = True
    while w:
        
        ca = str(input("> "))
        if ca == "list":
            index.menu()
            w = False
        elif ca == "r" or "res" or "restart":
            all()
            w = False

