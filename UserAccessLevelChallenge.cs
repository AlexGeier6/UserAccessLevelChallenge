string permission = "User";
int level = 5;

if (permission.Contains("Admin")){
    if (level >= 56){
    Console.WriteLine ( "Welcome, Super Admin user" );
}}
if(permission.Contains("Admin")){
    if((level <= 55)){
Console.WriteLine ( "Welcome, Admin user" );
}}

if(permission.Contains("Manager")){
    if((level >= 20)){
Console.WriteLine ("Contact an Admin for access." );
}}

if(permission.Contains("Manager")){
    if((level < 20)){
Console.WriteLine ("You do not have sufficient privileges." );
}}

if(!permission.Contains("Admin|Manager")){
    if((level <= 19 )){
Console.WriteLine("You do not have sufficient privileges.");
}}



