#include <stdio.h>
//#include "library.h"


int digging() {

    int x = 10;
    int y = 25;
    int z = -13;

    int x2 = -24;
    int y2 = 27;
    int z2 = 14;

    int x3;
    int z3;
    int y3;

    int fi;

    x3 = x - x2;
    if (x3 < 0) {
        x3 = x3 * (-1);
    }
    x3++;

    z3 = z - z2;
    if (z3 < 0) {
        z3 = z3 * (-1);
    }
    z3++;

    y3 = y - y2;
    if (y3 < 0) {
        y3 = y3 * (-1);
    }
    y3++;

    fi = x3*z3*y3;
    printf("%d Blocks", fi);
    
    return 0;
}