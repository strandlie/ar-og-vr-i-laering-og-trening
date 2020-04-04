#!/usr/bin/env python3
import pyvenn as venn
from operator import itemgetter
from functools import partial
from itertools import chain, combinations
from pprint import pprint
import matplotlib.pyplot as plt

def powerset(iterable):
    s = list(iterable)
    return chain.from_iterable(combinations(s, r) for r in range(len(s)+1))

people, labels = {}, {}
people["00010"] = "Peder"
people["01000"] = "Marthe"
people["00001"] = "Henning"
people["00100"] = "Håkon"
people["10000"] = "Runar"
labels["00010"] = "Programering\nog Grafikk"                  ### Peder
labels["01000"] = "Brannvern"                                 ### Marthe
labels["00001"] = "Økonomi med\nstrategi og AI"               ### Henning
labels["00100"] = "Programering\nog VR"                       ### Håkon
labels["10000"] = "Prosjektledelse"                           ### Runar
labels["01010"] = "Virtuelt\nkurs"                            ### Peder   + Marthe
labels["00011"] = "Spillogikk"                                ### Peder   + Henning
labels["01001"] = "Flammeutvikling"                           ### Marthe  + Henning
labels["00110"] = "VR\nSpill"                                 ### Peder   + Håkon
labels["01100"] = "VR\nBrannvern"                             ### Marthe  + Håkon
labels["00101"] = "Fysisk\nagent"                             ### Henning + Håkon
labels["10010"] = "Spillkurs"                                 ### Peder   + Runar
labels["11000"] = "HMS\nkurs"                                 ### Marthe  + Runar
labels["10001"] = "Prosjekt-\nstrategi"                       ### Henning + Runar
labels["10100"] = ""                                          ### Håkon   + Runar
labels["01011"] = ""                                          ### Peder   + Marthe  + Henning
labels["01110"] = "VR Kurs"                                   ### Peder   + Marthe  + Håkon
labels["00111"] = "VR\nagent"                                 ### Peder   + Henning + Håkon
labels["01101"] = "Responderende\nmiljø"                      ### Marthe  + Henning + Håkon
labels["11010"] = ""                                          ### Peder   + Marthe  + Runar
labels["10011"] = "Exponerings-\nspillkurs"                   ### Peder   + Henning + Runar
labels["11001"] = "Brannvern-\nstrategi"                      ### Marthe  + Henning + Runar
labels["10110"] = "VR\nKurs"                                  ### Peder   + Håkon   + Runar
labels["11100"] = "Kunde-\nbase"                                          ### Marthe  + Håkon   + Runar
labels["10101"] = ""                                          ### Henning + Håkon   + Runar
labels["01111"] = "Responderende\nVR kurs"                    ### Peder   + Marthe  + Henning + Håkon
labels["11011"] = "Brannvernkurs\n med exponering"            ### Peder   + Marthe  + Henning + Runar
labels["11110"] = "HMS Kurs\ni VR"                            ### Peder   + Marthe  + Håkon   + Runar
labels["10111"] = "Exponering\ni VR i et\nresponsivt\nmiljø" ### Peder   + Henning + Håkon   + Runar
labels["11101"] = "Anvendelse"                                          ### Marthe  + Henning + Håkon   + Runar
labels["11111"] = "Brannvernkurs\ni VR"                       ### Peder   + Marthe  + Henning + Håkon + Runar

for key, (thing, persons) in {
            bin(sum(subset))[2:].zfill(5) : (
                labels[bin(sum(subset))[2:].zfill(5)],
                " + ".join([people[bin(n)[2:].zfill(5)] for n in subset])
            ) for subset in powerset([int(i, 2) for i in people.keys()])
            if subset
        }.items():
    thing = thing.replace("-\n", "")
    thing = thing.replace("\n", " ")
    #print(f"{key}| {thing} ## {persons}")

names = map(itemgetter(1), sorted(people.items(), key=itemgetter(0)))

fig, ax = venn.venn5(labels, names=list(names)[::-1], fontsize=11.5)
#fig.show()
#plt.show()
#plt.savefig("venn_diagram.png", dpi=79)
plt.savefig("venn_diagram.png", dpi=300)
