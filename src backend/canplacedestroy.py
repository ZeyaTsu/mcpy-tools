import colorama
from colorama import Fore, Back, Style
import index
import debugmode
from debugmode import *


colorama.init()
b = Fore.BLUE
bm = Back.MAGENTA
w = Fore.WHITE
g = Fore.GREEN
c = Fore.CYAN


def candestroy():

    
    blocklist = []
    print("Write 'DONE' when finish.")
    item = str(input("Item: "))
    t = True
    while t:
        add = str(input("Can Destroy: "))
        blocklist.append(add)
        if add == "DONE":
            blocklist.pop(len(blocklist) - 1 )
            t = False
    output = ','.join(f"minecraft:{add}" for add in blocklist)
    xd = '"'
    print("/give @s minecraft:" + item + "{CanDestroy:["+ xd + output + xd + "]}")
    choix()


def canplaceon():
    blocklist = []
    item = str(input("Item: "))
    t = True
    while t:
        print("Write 'DONE' when finish.")
        add = str(input("Can Be Placed On: "))
        blocklist.append(add)
        if add == "DONE":
            blocklist.pop(len(blocklist) - 1 )
            t = False
    output = ','.join(f"minecraft:{add}" for add in blocklist)
    xd = '"'
    print("/give @s minecraft:" + item + "{CanPlaceOn:["+ xd + output + xd +"]}")
    choix()

def choix():
    s = True 
    while s:
        print(b+"1. CanDestroy ")
        print(b+"2. CanPlaceOn")
        print(c+"Write 'list' to go back.")
        choice = str(input("> "))
        if choice == "1":
            candestroy()
            s = False
        elif choice == "2":
            canplaceon()
            s = False
        elif choice == "list":
            index.menu()
            s = False

