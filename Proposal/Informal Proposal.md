# Characteristic AI--More decisions when facing the enemy#

## Problem Statement ##
In most current ACT or RPG games, hostile behaviors of enemy (or teammate) AI are monotonous. They behaves almost in the same procedure: after spotting enemies, they rush to the enemies and keep attacking until the either enemies or themselves are killed. Fighting to death sounds honorable, but obviously is not intelligent and realistic. 

In reality, one (creatures with thinking ability. Zombies? No.) is expected to determine whether they can beat their enemy, and choose whether to fight or run for lives based on current situation and its own characters. The situations (external) that may influence one's decision include the enemy's strength and quantity and so on. While its character (internal), like brevity or cowardice, may also change its behaviors. Furthermore, if they choose to fight back, they should fight intelligently, like hitting and running. Otherwise, they should choose a best way to escape.

If time allows and for further improvement, we want to build the connection among these AIs to form a team. It allows one AI making group decision that affects the whole group, and have more choice on their own behavior like waiting for backups or fight stratigies as a team.


## Techniques Involved ##
Many AI techniques are involved in this project. 

For the most basic and important, the AI should own the ability of evaluating the chance of beating the enemies by using Bayesian Network and decision making. 

Finite state machine should be used to allow AI translating from different states based on its decisions. In addition, some fighting skills may includes a series behaviors and can be achieved by game trees.

Finding a way to chase or escape could includes common path finding algorithms like A*, but other algorithms with less cost and same efficiency should also be compared and considered.

## Evaluation Method ##
This project is designed to be implemented on ACT or RPG games. 

One of the most important evaluation metric of this project is the AI's reactions to enemies. The AI is expected to behave differently towards different enemies and different characters compared with ordinary AI. We could assign enemies with different attributes to AI with different characters and see the AI's behaviors. Or we could set two AI teams fighting each other and see the result.

The project could also be evaluated by the survival rate (survival times/times of encountering enemies) and winning rate(times of beating enemies/times of fighting with enemies) of AI.Both of them reflects the success of decision making, and the second one specifically presents how smart the AI fighting skills are.

## Importance ##

For the most significant, this project allows game AI to make reasonable choice and actions, which looks more intelligent and characteristic. In addition, AI with different characters provides player and the game with more possibilities. 

