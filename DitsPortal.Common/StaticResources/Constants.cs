using System;
using System.Collections.Generic;
using System.Text;

namespace DitsPortal.Common.StaticResources
{
    public static class Constants
    {
        public const int SUCCESS_CODE = 200;
        public const int FAILURE_CODE = 400;
        public const int ERROR_CODE = 500;

        // Common
        public const string DEFAULT_ERROR_MSG = "Something went wrong";
        public const string DEFAULT_SUCCESS_MSG = "Success";
        public const string NO_RECORD_FOUND = "Email does not exist.";

        // User Screen
        public const string USER_NOT_EXITS = "User not exits.";
        public const string USER_EXITS = "User Exits";
        public const string USER_PROFILE_UPDATE = "User Profile Update successfully";
        public const string LOGIN_FAILURE_MSG = "Username or password is incorrect";
        public const string EMAIL_ALREADY_EXIST = "Email already exists";
        public const string OLD_PASSWORD_INCORRECT = "Old password incorrect";
        public const string OLD_NEW_PASSWORD_SAME_ERROR = "New password can not be same as old password.";
        public const string PASSWORD_CHANGED = "Password changed successfully.";
        public const string PROFILE_UPDATED = "User Profile updated successfully.";
        public const string USER_REGISTERED = "User registered successfully.Please wait for admin approval";
        public const string RESET_PASSWORD_EMAIL = "Your password reset email has been sent.";


        //Users Registration Screen
        public const string USER_CREATED = "User created successfully.";
        public const string USER_NOT_CREATED = "Please fill the required fields.";
        public const string USER_UPDATED = "User   updated successfully.";
        public const string USER_NOT_UPDATED = "User not updated successfully.";
        public const string USER_NOT_EXISTS = "User not exits.";
        public const string USER_DELETED = "User deleted successfully.";
        public const string USER_NOT_DELETED = "User not deleted successfully.";
        public static readonly string RESET_PASSWORD_VALID_LINK = "Reset password link is valid.";
        public static readonly string RESET_PASSWORD_EXPIRED_LINK = "Reset password link is expired";

        //Leave Screen
        public const string LEAVE_CREATED = "Leave created successfully.";
        public const string LEAVE_NOT_CREATED = "Leave creation failed.";
        public const string LEAVE_APPROVED = "Leave approved successfully";
        public const string LEAVE_NOT_APPROVED = "Leave declined successfully";
        public const string NO_LEAVE_AVAILABLE = "No leave available.";
        public const string LEAVE_UPDATE = "LEAVE UPDATE successfully.";
        public const string LEAVE_NOT_UPDATE = "LEAVE NOT UPDATE.";

        /* Validation Messages */
        public const string VALIDATION_FULLNAME_ERROR_MSG = "Name should contains alphabets, space and dot";
        public const string VALIDATION_PASSWORD_ERROR_MSG = "Password is not strong";
        public const string VALIDATION_PASSWORD_NOT_SAME_MSG = "Confirm password is not same as password.";

        // GlobalCode Category Screen 
        public const string GLOBAL_CODE_CATEGORY_CREATED = "Global Code Category created successfully.";
        public const string GLOBAL_CODE_CATEGORY_NOT_CREATED = "Please fill the required fields.";
        public const string GLOBAL_CODE_CATEGORY_UPDATED = "Global code category updated successfully.";
        public const string GLOBAL_CODE_CATEGORY_NOT_UPDATED = "Global code category not updated successfully.";
        public const string GLOBAL_CODE_CATEGORY_DELETED = "Global code category deleted successfully.";
        public const string GLOBAL_CODE_CATEGORY_NOT_DELETED = "Global Code Cateegory not deleted successfully.";
        public const string GLOBAL_CODE_CATEGORY_NOT_EXISTS = "Global Code Category not exist.";
        public const string GLOBAL_CODE_CATEGORY_AllRECORDS_UPDATED = "";

        //Email Errors
        public const string EMAIL_ERROR = "Error while sending email";
    }
}
