# Comparative Analysis of AI models for team with goal of survival #

## Problem Statement ##

AI models for team is an interesting subject. But that might be too general for our porject. We would like to evaluate different methods for a group of agents, in an environment where the survival of the team is the goal. More specifically, We would like to compare centralized approaches(e.g. there is a leader in the group) to decentralized approaches(e.g. acting individually but cooperatively).

## Techniques Involved ##

Many AI techniques are involved in this project. 

For decentralized methods, our thoughts is there are many levels of communication. Level-1 self-interested; level-2 sharing useful intel; level-3 sharing stats and maybe form tactics accordingly and so on with each level more information is shared.

For centralized methods, our thoughts is maybe decision tree, machine learning techniques, state machines, game tree.

And of course, there is some necessary AI needed like path-finding, decision of fight or flight and so on. 

Question we are interested in are:

- Is decentralized methods superior centralized methods?
- which one of these looks better?

## Evaluation Method ##

Obvious metric for evaluation is time of survival: By using which methods can a team surivive the enivronment is the most amount of time. Another thought is to have 2 AI teams using different methods go against each other, but that would add to the complexity. We could aslo use the survival rate (survival times/times of encountering enemies) and winning rate(times of beating enemies/times of fighting with enemies) of AI. Both of them reflects the success of decision making, and the second one specifically presents how smart the AI fighting skills are.
Another metric would be to ask people to play against AI, and survey about how do they feel, since intelligent of a game AI could be a subjective subject.
Other evaluation metrics exist that are better-targeted at specific applications.

## Importance ##
We can see in common games, that difficulties are achieved by making enemy stats stronger.

## didn't use

For the most significant, this project allows game AI to make reasonable choice and actions, which looks more intelligent and characteristic. In addition, AI with different characters provides player and the game with more possibilities. 


In most current ACT or RPG games, hostile behaviors of enemy (or teammate) AI are monotonous. They behaves almost in the same procedure: after spotting enemies, they rush to the enemies and keep attacking until the either enemies or themselves are killed. Fighting to death sounds honorable, but obviously is not intelligent and realistic. 

In reality, one (creatures with thinking ability. Zombies? No.) is expected to determine whether they can beat their enemy, and choose whether to fight or run for lives based on current situation and its own characters. The situations (external) that may influence one's decision include the enemy's strength and quantity and so on. While its character (internal), like brevity or cowardice, may also change its behaviors. Furthermore, if they choose to fight back, they should fight intelligently, like hitting and running. Otherwise, they should choose a best way to escape.

If time allows and for further improvement, we want to build the connection among these AIs to form a team. It allows one AI making group decision that affects the whole group, and have more choice on their own behavior like waiting for backups or fight stratigies as a team.

