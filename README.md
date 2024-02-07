# GA_LinkedListSingly_Ronda

Q: What is a linked list, and why is it useful? 
A: A linked list is a series of nodes that are linked by reference pointers. It is useful because data can be added easily without the need to change the size of a container.

Q: In what scenarios is a linked list more efficient for finding specific data, and in what scenarios is it more efficient for adding new data compared to other data structures like arrays or dynamic arrays (e.g., List in C#)?
A linked list could be more efficient for working with lists with frequently fluctuating capacities, and working with items that generally remain in sequence.

Q: What is the importance of proper referencing of nodes in a linked list, and what potential issues can arise from improper referencing?
Nodes in a linked list need to be referenced properly in order to prevent loss of data. If reference pointers are removed before new reference pointers are added,
the date it was pointing to could be lost because nothing is pointing to it anymore.

Q: Critical Thinking: What software or systems might benefit from using a Linked List, a system that is slow to search for something, but quick to add.
A: Some examples of systems that could benefit from Linked Lists are data edit logs, sequencers, and playlists.

Q: Follow Up: Which system would it be more beneficial to use a List or Array, where all the data is grouped together for easy searching, but slow to add?
A: Items that do not need to be sequential; items that are sorted often - such as lists of files, lists of names, etc.

Q: Any thoughts for combining the two to make it really efficient?
For systems that have both permanent information that might need to be sorted, which is also referenced in a sequential or fluctuating list, like a playlist, the long-term information could be stored in arrays or list,
and the short-term sequential or fluctuating information could be stored in a linked list.
