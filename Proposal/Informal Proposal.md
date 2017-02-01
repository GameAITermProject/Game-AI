# Autonomous AI -- More decisions when facing the enemy#

## Problem Statement ##
In most current ACT or RPG games, behaviors of enemy AI are monotonous. They behaves almost in the same procedure: after spotting enemies(i.e. player), they rush to the enemies and keep attacking until either enemies or themselves are killed. Fighting to death sounds honorable, but obviously is not intelligent and realistic. 

Therefore, the purpose of this project is to design the game AI agents, which are expected to determine whether they can beat their enemy, and choose to whether fight or run for lives based on current situation. The elements that may influence one's decision include the enemy's strength and quantity, its character (brave or craven) and so on. Furthermore, if they choose to fight back, they fight intelligently, like hitting and running. Otherwise, they should choose a best way to escape.

For further goal of project, we want to build the connection among agents to form a team, which are able to let one agent make decision based on other agents' strength and behavior, and have more choice on their own behavior like waiting for backups and having fight stratigies as a team.

## Techniques Involved ##
Many AI techniques are involved in this project. 

For the most basic and important, the AI should own the ability of evaluating the probability of beating the enemies by using Bayesian Network. 

Finite state machine should be used to allow AI translating from different states based on its decisions. In addition, some fighting skills may includes a series behaviors and can be achieved by game trees.

Finding a way to chase the enemy or escape could includes path finding algorithms like A*, but other algorithms with less cost should also be compared and considered.

## Evaluation Method ##
This project is designed to be implemented on ACT or RPG games. 

One of very important evaluation metric of this techniques is the AI's reactions to enemies. 

## Importance ##
This technique allows game AI to make choice, which behaves more intelligently and characteristically, As a result, it provides player and the game with more possibilities. 
