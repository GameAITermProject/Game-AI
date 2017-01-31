# Autonomous AI #

## Problem Statement ##
In most current ACT or RPG games, behaviors of enemy AI are monotonous. They behaves almost in the same procedure: after spotting enemies(i.e. player), they rush to the enemies and keep attacking until the either enemies or they are killed. Fighting to death sounds honorable, but obviously is not intelligent and realistic. 
In reality, one is expected to determine whether they can beat their enemy, and choose whether to fight or run for lives based on current situation. The elements that may influence one's decision include the enemy's strength and quantity, the companion's quantity and so on. If they choose to fight back, they fight intelligently, like hitting and running. Otherwise, they should choose a best way to escape.

## Techniques Involved ##
Many AI techniques are involved in this project. 
For the most basic and important, the AI should own the ability of evaluating the chance of beating the enemies by using Bayesian Network. 
Finite state machine should be used to allow AI translating from different states based on its decisions. In addition, some fighting skills may includes a series behaviors and can be achieved by behavior trees.
Finding a way to escape could includes algorithms like A*, but other algorithms with less cost should also be considered and compared.

## Evaluation Method ##
This project is designed to be implemented on ACT or RPG games. One of very important evaluation metric of this techniques is the AI's reactions to enemies. 

## Importance ##
This technique makes game AI more intelligent characteristic, thus providing player and the game with more possibilities. 