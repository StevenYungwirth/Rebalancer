The rebalancing tool shows all of a client's positions, and the necessary sales needed to bring them back to their equity target. The goal is to completely replace the need for Total Rebalance Expert (TRX), as this website app is extremely slow for what FPIS uses it for, and its key feature - creating trade proposals - is unused as it doesn't fit with how FPIS completes rebalances. 
This is a project currently in progress, so many features are yet to be implemented.

Upon running, the user chooses a household to load. The combo box may be typed into to find a specific household, but each set of radio buttons below the combo box filter the list down if necessary (the filter is still in progress).

The list of households is built from a .csv file. When a household is chosen, three other .csv files are used to bring in the household's holdings.

When a household is loaded, its accounts are shown in the top-left list view, the asset subclasses of each accounts' holdings in the top-right list view, and every accounts' holdings in the bottom list view. The accounts and subclasses can be clicked to filter the list of holdings to specific accounts or subclasses. The total value of each asset class and subclass is put into the "Current" column.

The total household value is calculated, and the allocation and fee are loaded with the household. Using these, the "Target" column is filled, showing what each asset class and subclass would be if the household was at its target. The spinners in the bottom target group box show the target for each subclass as a portion of the total equities*, and may be changed in order to look at hypothetical allocation changes. The household's equity target can also be changed in this way, and the "Money In/Out" box can alter the houshold's total value to see how hypothetical distributions or additions to the clients' accounts would alter the targets.
*As an example, say a client has a portfolio with $100,000, 75% equities overall, and the "Large Value" spinner shows "20". Their Large Value target would be $15,000 (75% of $100,000 is $75,000 total equities, 20% of which, or $15,000, are Large Value).

Using the "Current" and "Target" columns, the "Action" column is filled as the difference between the two values. These values show the amount that needs to be bought or sold to bring the portfolio back to its target.

This is currently the capabilities of the rebalancing tool, but future plans to be worked on include:
1. Load security pricing info and per-account cost basis to be used for determining which funds to make trades on.
2. Show another form where trades can be manually entered for each account. These trades could then be exported into two .csv files - One to be used with the "Report Builder" workbook and its macros to generate a client-facing letter and report, and one to be used to import the trades into TD Ameritrade.
3. Automatically generate trades. This would start with simple households consisting of only one tax-qualified account, and systematically expand the logic to include more complex households (Two tax-qualified accounts, a tax-qualified and a taxable account, three accounts of some combination, etc.).
4. Implement a relational database to hold every client and their holdings, and use this as a static base instead of pulling data from .csv files every time the tool is opened. This database is already designed, but not yet built.
5. Quality-of-life improvements, such as information about a fund appearing when it is clicked on.