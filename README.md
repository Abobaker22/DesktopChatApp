# DesktopChatApp
Develop a Desktop Message Application Using C# Windows Forms And ADO.NET\

Objective:\
Build a desktop-based message application that allows users to send, receive, and manage messages. The application should support individual and group messaging, with robust search and filter functionality.\
________________________________________
Core Features:\
1.User Authentication:\
    1.1 Users can log in with a username and password.\
    1.2 Ensure proper authentication and session management.\
2.Messaging:\
    2.1.1 Send and Receive Messages:\
        2.1.2 Users can send messages to other users.\
        2.1.3 Messages should include:\
        2.1.4 Subject\
        2.1.5 Body\
        2.1.6 Date Sent\
        2.1.7 Sender\
        2.1.8 Recipient\
3.Search and Filter:\
    3.1 Allow users to search messages using:\
        3.1.1 Date range\
        3.1.2 Subject\
        3.1.3 Sender/Recipient\
    3.2 Filters should apply to both sent and received messages.\
4.Message Management:\
    4.1 Inbox: Displays received messages.\
    4.2 Sent Items: Displays sent messages.\
    4.3 Mark as Read/Unread.\
    4.4 Refresh to get new messages\
5.UI/UX:\
    5.1 Design a user-friendly Windows Forms application interface:\
        5.1.1 Tabs or panels for "Inbox," "Sent Items," \
        5.1.2 A form to send new messages.\
        5.1.3 A search/filter panel.\
________________________________________


Backend Features:\
1. Database:\
2. Use SQL Server with ADO.NET for data access.\
3. Tables:\
    3.1	Users: UserID, UserName, FullName ,phone,Password ,GroupId\
    3.2	Groups: GroupID, GroupName, GroupDesc \
    3.3	Messages: MessageID, SenderID, RecipientID  ,Subject, Body, DateSent, IsRead\

Development Steps:\
1. Design the Database:\
    1.1	Create tables with proper relationships and constraints.\
2.	Build the Application:\
    2.1 Use Windows Forms for the UI.\
    2.2 Implement ADO.NET for database interactions.\
3.	Test Features:\
    3.1 Validate sending and receiving messages.\
    3.2 Test search and filter functionality.\


 

