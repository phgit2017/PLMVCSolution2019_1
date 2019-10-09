﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IOBalanceV3
{
    public static class Constants
    {
    }

    public static class Messages
    {
        public const string AccountLockedOut = "Unable to login. Your account is currently locked out. Please try again after {0} minute(s).";
        public const string AccountUserIncorrect = "The user name or password provided is incorrect.";
        public const string AccountUserIsInactive = "The user you are logging in is not active";
        public const string BatchNoEmpty = "Batch number is empty, kindly retry uploading your file (This is a SYSTEM ISSUE)";
        public const string BatchUploadErrorAllRecords = "All record contains error, Please check the file and re-upload again";
        public const string BulkInsertError = "There is a problem in INSERTING Of Bulk Products";
        public const string CaptchaError = "Please check the above captcha.";
        public const string ChangePasswordFailed = "Unable to change password. Please correct the errors.";
        public const string ChangeSecurityParametersFailed = "Unable to change security question and answer. Please correct the erors.";
        public const string ChangeSuccess = "{0} successfully changed.";
        public const string DeleteSuccessRecord = "{0} successfully deleted.";
        public const string DeleteSuccess = "successfully deleted record";
        public const string DeleteFailed = "There's an error deleting the {0}.";
        public const string DuplicateUserInBranch = "Please use a different username in particular Branch/User Type";
        public const string DuplicateItem = "System detect that you have duplicate {0}";
        public const string DuplicateItemInBranch = "System detect that you have duplicate {0} in particular branch";
        public const string ErrorOccuredDuringProcessing = "An error occured during the process. Please check the details, refresh the page, and try again.";
        public const string ErrorOccuredDuringProcessingOrRequiredFields = "An error occured during the process. Please check the details or the required fields.";
        public const string ErrorOccuredDuringProcessingThis = "An error occured during the process {{0}}. Please check the details, refresh the page, and try again.";
        public const string ErrorOccuredDuringBatchProcessing = "An error occured during the batch process. Please check the details, refresh the page, and try again.";
        public const string ExcelUploadedEmpty = "Excel uploaded is empty";
        public const string ExcelUploadNumberOfColumns = "Please download the template, this template may not be the same";
        public const string FieldRequired = "{0} is required.";
        public const string FileExceedLimit = "File must not exceed {0}.";
        public const string FileNameTooLong = "The file name is too long. It can only be {0} characters long.";
        public const string FileTypeNotAccepted = "The file type is not accepted";
        public const string FutureDate = "{0} should not be later than today.";
        public const string GenericFailed = "An error occurred during the process in the system.";
        public const string IncorrectEntry = "{0} is incorrect";
        public const string InsertSuccess = "Sucessfully inserted record";
        public const string InsertSuccessRecord = "Successfully inserted {0}!";
        public const string InsertSuccessButWithError = "Successfully inserted records but other data had an error";
        public const string InvalidAge = "{0} must be {1} years or above.";
        public const string InvalidDateEnd = "End date must be greater than Start date";
        public const string InvalidEmail = "Invalid Email Address";
        public const string InvalidFileType = "Invalid file type";
        public const string InvalidSecurityCode = "Invalid Security Code";
        public const string ManualRegistrationAccountFailed = "Update account failed. Please try again.";
        public const string MaxLengthExceeded = "Up to {0} characters only.";
        public const string NoApplicantFound = "No applicant found.";
        public const string NoProductFound = "No Product found.";
        public const string NoRowFound = "No Row Found";
        public const string NoSelectedFile = "No selected file.";
        public const string NotFound = "Not Found";
        public const string NotificationFailed = "Notification Failed";
        public const string NotificationSent = "Notification Sent";
        public const string PleaseSelectItem = "Please select {0}";
        public const string RecordExist = "{0} already exists.";
        public const string RecordNotExists = "{0} does not exists.";
        public const string RecoveryEmailNotExists = "Sorry, we are unable to locate the account that matches the email provided.";
        public const string SpaceNotAllowed = "Space are not allowed.";
        public const string Unauthorized = "Unauthorized";
        public const string UpdateError = "Unable to update {0}. Please correct the errors.";
        public const string UpdateFailed = "Update Failed. Please refresh the page and try again.";
        public const string UpdateSuccess = "successfully updated record";
        public const string UpdateSuccessRecord = "{0} successfully updated";
        public const string UploadSuccess = "Successfully uploaded!";
        public const string UploadSuccessThis = "{0} successfully uploaded";

    }
}
