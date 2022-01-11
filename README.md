# Lightning Blackjack Strategy
A simple program created using the [Lightning Blackjack strategy](https://static.egcdn.com/frontend/evo/r2/optimalLightningBlackjackStrategy.html?gameType=lightningscalablebj&lang=en#openMenu) provided by Evolution. This must be used if you want to play at the displayed RTP of 99.56%, although it is much more complicated than basic strategy.

For each round:
- Enter the multiplier you would receive for a Blackjack. Each board has a unique multiplier for this.
- Enter the current multiplier. If there isn't a current multiplier, then select 'None'.
- Enter the dealer's upcard.
- Enter your hand. For example, a hard 16 would be entered as 'Hard16' and soft 16 would be entered as 'Soft16'. A pair of 4s would be entered as 'Pair4'.
- The strategy for split hands is different. For example, if your first hand is a Soft 18 and the second split hand is yet to be played then this is entered as 'Soft18/?'. Alternatively, if you're second hand is a Hard 16 and the first hand is a secured 19, then this is entered as '19/Hard16'. It might look complicated but it's actually really easy.
- Once you have completed all fields, then the strategy is automatically displayed.
