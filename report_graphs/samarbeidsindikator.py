#!/usr/bin/env python3
import matplotlib.pyplot as plt
from operator import mul
x = (-1, 0, 1, 0, -1)
y = (0, 1, 0, -1, 0)

plt.fill((-5, 5, 5, -5), (5, 5, -5, -5), color=(0.95, 0.95, 0.95))
plt.plot((-5, 5), (0, 0), color=(0.85, 0.85, 0.85))
plt.plot((0, 0), (-5, 5), color=(0.85, 0.85, 0.85))
for c in [1, 2, 3, 4, 5]:
    plt.fill([i*c for i in x], [i*c for i in y], color="white")
    plt.plot([i*c for i in x], [i*c for i in y], color=(0.85, 0.85, 0.85))

plt.text(-3.6, -0.3, "Åpen og\nlyttende")
plt.text(-1,    4.3, "Ærlig og direkte")
plt.text( 2.3, -0.3, "Forpliktet\nog tillitsfull")
plt.text(-1.5, -4.5,   "Effektiv og strukturert")

#plt.plot([],[]) # to offset the colors
for label, vals in [
    ("Første",        (4.5, 3.1, 4.5,  3.6)),
    #("Andre, ønsket", (4.8, 5,   4.55, 2.9)),
    ("Andre",         (4.8, 4,   4.55, 2.9)),
    #("Tredje",        (1,   2,   3,    4)),
]:
    vals = list(vals) + [vals[0]]
    cx = list(map(mul, x, vals))
    cy = list(map(mul, y, vals))
    plt.plot(cx, cy, label=label)


plt.legend()
plt.xlim(-5, 5)
plt.ylim(-5, 5)
plt.xticks(range(-5, 6), map(abs, range(-5, 6)))
plt.yticks(range(-5, 6), map(abs, range(-5, 6)))
plt.grid(False)
plt.savefig("samarbeidsindikator.png", dpi=300)
#plt.show()
