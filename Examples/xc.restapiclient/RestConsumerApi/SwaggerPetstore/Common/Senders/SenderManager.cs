﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by XCTools.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using XComponent.SwaggerPetstore.Common;

namespace XComponent.SwaggerPetstore.Common.Senders
{
    public class SenderManager
    {
		private static InitDefaultEventOnUpSwaggerPetstoreSender _initDefaultEventOnUpSwaggerPetstoreSender;
		private static AddPetAddPetOnUpSwaggerPetstoreSender _addPetAddPetOnUpSwaggerPetstoreSender;
		private static UpdatePetUpdatePetOnUpSwaggerPetstoreSender _updatePetUpdatePetOnUpSwaggerPetstoreSender;
		private static FindPetsByStatusFindPetsByStatusOnUpSwaggerPetstoreSender _findPetsByStatusFindPetsByStatusOnUpSwaggerPetstoreSender;
		private static FindPetsByTagsFindPetsByTagsOnUpSwaggerPetstoreSender _findPetsByTagsFindPetsByTagsOnUpSwaggerPetstoreSender;
		private static GetPetByIdGetPetByIdOnUpSwaggerPetstoreSender _getPetByIdGetPetByIdOnUpSwaggerPetstoreSender;
		private static UpdatePetWithFormUpdatePetWithFormOnUpSwaggerPetstoreSender _updatePetWithFormUpdatePetWithFormOnUpSwaggerPetstoreSender;
		private static DeletePetDeletePetOnUpSwaggerPetstoreSender _deletePetDeletePetOnUpSwaggerPetstoreSender;
		private static UploadFileUploadFileOnUpSwaggerPetstoreSender _uploadFileUploadFileOnUpSwaggerPetstoreSender;
		private static GetInventoryGetInventoryOnUpSwaggerPetstoreSender _getInventoryGetInventoryOnUpSwaggerPetstoreSender;
		private static PlaceOrderPlaceOrderOnUpSwaggerPetstoreSender _placeOrderPlaceOrderOnUpSwaggerPetstoreSender;
		private static GetOrderByIdGetOrderByIdOnUpSwaggerPetstoreSender _getOrderByIdGetOrderByIdOnUpSwaggerPetstoreSender;
		private static DeleteOrderDeleteOrderOnUpSwaggerPetstoreSender _deleteOrderDeleteOrderOnUpSwaggerPetstoreSender;
		private static CreateUserCreateUserOnUpSwaggerPetstoreSender _createUserCreateUserOnUpSwaggerPetstoreSender;
		private static CreateUsersWithArrayInputCreateUsersWithArrayInputOnUpSwaggerPetstoreSender _createUsersWithArrayInputCreateUsersWithArrayInputOnUpSwaggerPetstoreSender;
		private static CreateUsersWithListInputCreateUsersWithListInputOnUpSwaggerPetstoreSender _createUsersWithListInputCreateUsersWithListInputOnUpSwaggerPetstoreSender;
		private static LoginUserLoginUserOnUpSwaggerPetstoreSender _loginUserLoginUserOnUpSwaggerPetstoreSender;
		private static LogoutUserLogoutUserOnUpSwaggerPetstoreSender _logoutUserLogoutUserOnUpSwaggerPetstoreSender;
		private static GetUserByNameGetUserByNameOnUpSwaggerPetstoreSender _getUserByNameGetUserByNameOnUpSwaggerPetstoreSender;
		private static UpdateUserUpdateUserOnUpSwaggerPetstoreSender _updateUserUpdateUserOnUpSwaggerPetstoreSender;
		private static DeleteUserDeleteUserOnUpSwaggerPetstoreSender _deleteUserDeleteUserOnUpSwaggerPetstoreSender;
		private static CreateAddPetHttpRequestAddPetOperationOnSendingRequestAddPetOperationSender _createAddPetHttpRequestAddPetOperationOnSendingRequestAddPetOperationSender;
		private static CreateUpdatePetHttpRequestUpdatePetOperationOnSendingRequestUpdatePetOperationSender _createUpdatePetHttpRequestUpdatePetOperationOnSendingRequestUpdatePetOperationSender;
		private static CreateFindPetsByStatusHttpRequestFindPetsByStatusOperationOnSendingRequestFindPetsByStatusOperationSender _createFindPetsByStatusHttpRequestFindPetsByStatusOperationOnSendingRequestFindPetsByStatusOperationSender;
		private static CreateFindPetsByTagsHttpRequestFindPetsByTagsOperationOnSendingRequestFindPetsByTagsOperationSender _createFindPetsByTagsHttpRequestFindPetsByTagsOperationOnSendingRequestFindPetsByTagsOperationSender;
		private static CreateGetPetByIdHttpRequestGetPetByIdOperationOnSendingRequestGetPetByIdOperationSender _createGetPetByIdHttpRequestGetPetByIdOperationOnSendingRequestGetPetByIdOperationSender;
		private static CreateUpdatePetWithFormHttpRequestUpdatePetWithFormOperationOnSendingRequestUpdatePetWithFormOperationSender _createUpdatePetWithFormHttpRequestUpdatePetWithFormOperationOnSendingRequestUpdatePetWithFormOperationSender;
		private static CreateDeletePetHttpRequestDeletePetOperationOnSendingRequestDeletePetOperationSender _createDeletePetHttpRequestDeletePetOperationOnSendingRequestDeletePetOperationSender;
		private static CreateUploadFileHttpRequestUploadFileOperationOnSendingRequestUploadFileOperationSender _createUploadFileHttpRequestUploadFileOperationOnSendingRequestUploadFileOperationSender;
		private static CreateGetInventoryHttpRequestGetInventoryOperationOnSendingRequestGetInventoryOperationSender _createGetInventoryHttpRequestGetInventoryOperationOnSendingRequestGetInventoryOperationSender;
		private static CreatePlaceOrderHttpRequestPlaceOrderOperationOnSendingRequestPlaceOrderOperationSender _createPlaceOrderHttpRequestPlaceOrderOperationOnSendingRequestPlaceOrderOperationSender;
		private static CreateGetOrderByIdHttpRequestGetOrderByIdOperationOnSendingRequestGetOrderByIdOperationSender _createGetOrderByIdHttpRequestGetOrderByIdOperationOnSendingRequestGetOrderByIdOperationSender;
		private static CreateDeleteOrderHttpRequestDeleteOrderOperationOnSendingRequestDeleteOrderOperationSender _createDeleteOrderHttpRequestDeleteOrderOperationOnSendingRequestDeleteOrderOperationSender;
		private static CreateCreateUserHttpRequestCreateUserOperationOnSendingRequestCreateUserOperationSender _createCreateUserHttpRequestCreateUserOperationOnSendingRequestCreateUserOperationSender;
		private static CreateCreateUsersWithArrayInputHttpRequestCreateUsersWithArrayInputOperationOnSendingRequestCreateUsersWithArrayInputOperationSender _createCreateUsersWithArrayInputHttpRequestCreateUsersWithArrayInputOperationOnSendingRequestCreateUsersWithArrayInputOperationSender;
		private static CreateCreateUsersWithListInputHttpRequestCreateUsersWithListInputOperationOnSendingRequestCreateUsersWithListInputOperationSender _createCreateUsersWithListInputHttpRequestCreateUsersWithListInputOperationOnSendingRequestCreateUsersWithListInputOperationSender;
		private static CreateLoginUserHttpRequestLoginUserOperationOnSendingRequestLoginUserOperationSender _createLoginUserHttpRequestLoginUserOperationOnSendingRequestLoginUserOperationSender;
		private static CreateLogoutUserHttpRequestLogoutUserOperationOnSendingRequestLogoutUserOperationSender _createLogoutUserHttpRequestLogoutUserOperationOnSendingRequestLogoutUserOperationSender;
		private static CreateGetUserByNameHttpRequestGetUserByNameOperationOnSendingRequestGetUserByNameOperationSender _createGetUserByNameHttpRequestGetUserByNameOperationOnSendingRequestGetUserByNameOperationSender;
		private static CreateUpdateUserHttpRequestUpdateUserOperationOnSendingRequestUpdateUserOperationSender _createUpdateUserHttpRequestUpdateUserOperationOnSendingRequestUpdateUserOperationSender;
		private static CreateDeleteUserHttpRequestDeleteUserOperationOnSendingRequestDeleteUserOperationSender _createDeleteUserHttpRequestDeleteUserOperationOnSendingRequestDeleteUserOperationSender;

        public static InitDefaultEventOnUpSwaggerPetstoreSender InitDefaultEventOnUpSwaggerPetstoreSender
        {
            get
            {
                return _initDefaultEventOnUpSwaggerPetstoreSender ??
                       (_initDefaultEventOnUpSwaggerPetstoreSender = new InitDefaultEventOnUpSwaggerPetstoreSender());
            }
        }

        public static AddPetAddPetOnUpSwaggerPetstoreSender AddPetAddPetOnUpSwaggerPetstoreSender
        {
            get
            {
                return _addPetAddPetOnUpSwaggerPetstoreSender ??
                       (_addPetAddPetOnUpSwaggerPetstoreSender = new AddPetAddPetOnUpSwaggerPetstoreSender());
            }
        }

        public static UpdatePetUpdatePetOnUpSwaggerPetstoreSender UpdatePetUpdatePetOnUpSwaggerPetstoreSender
        {
            get
            {
                return _updatePetUpdatePetOnUpSwaggerPetstoreSender ??
                       (_updatePetUpdatePetOnUpSwaggerPetstoreSender = new UpdatePetUpdatePetOnUpSwaggerPetstoreSender());
            }
        }

        public static FindPetsByStatusFindPetsByStatusOnUpSwaggerPetstoreSender FindPetsByStatusFindPetsByStatusOnUpSwaggerPetstoreSender
        {
            get
            {
                return _findPetsByStatusFindPetsByStatusOnUpSwaggerPetstoreSender ??
                       (_findPetsByStatusFindPetsByStatusOnUpSwaggerPetstoreSender = new FindPetsByStatusFindPetsByStatusOnUpSwaggerPetstoreSender());
            }
        }

        public static FindPetsByTagsFindPetsByTagsOnUpSwaggerPetstoreSender FindPetsByTagsFindPetsByTagsOnUpSwaggerPetstoreSender
        {
            get
            {
                return _findPetsByTagsFindPetsByTagsOnUpSwaggerPetstoreSender ??
                       (_findPetsByTagsFindPetsByTagsOnUpSwaggerPetstoreSender = new FindPetsByTagsFindPetsByTagsOnUpSwaggerPetstoreSender());
            }
        }

        public static GetPetByIdGetPetByIdOnUpSwaggerPetstoreSender GetPetByIdGetPetByIdOnUpSwaggerPetstoreSender
        {
            get
            {
                return _getPetByIdGetPetByIdOnUpSwaggerPetstoreSender ??
                       (_getPetByIdGetPetByIdOnUpSwaggerPetstoreSender = new GetPetByIdGetPetByIdOnUpSwaggerPetstoreSender());
            }
        }

        public static UpdatePetWithFormUpdatePetWithFormOnUpSwaggerPetstoreSender UpdatePetWithFormUpdatePetWithFormOnUpSwaggerPetstoreSender
        {
            get
            {
                return _updatePetWithFormUpdatePetWithFormOnUpSwaggerPetstoreSender ??
                       (_updatePetWithFormUpdatePetWithFormOnUpSwaggerPetstoreSender = new UpdatePetWithFormUpdatePetWithFormOnUpSwaggerPetstoreSender());
            }
        }

        public static DeletePetDeletePetOnUpSwaggerPetstoreSender DeletePetDeletePetOnUpSwaggerPetstoreSender
        {
            get
            {
                return _deletePetDeletePetOnUpSwaggerPetstoreSender ??
                       (_deletePetDeletePetOnUpSwaggerPetstoreSender = new DeletePetDeletePetOnUpSwaggerPetstoreSender());
            }
        }

        public static UploadFileUploadFileOnUpSwaggerPetstoreSender UploadFileUploadFileOnUpSwaggerPetstoreSender
        {
            get
            {
                return _uploadFileUploadFileOnUpSwaggerPetstoreSender ??
                       (_uploadFileUploadFileOnUpSwaggerPetstoreSender = new UploadFileUploadFileOnUpSwaggerPetstoreSender());
            }
        }

        public static GetInventoryGetInventoryOnUpSwaggerPetstoreSender GetInventoryGetInventoryOnUpSwaggerPetstoreSender
        {
            get
            {
                return _getInventoryGetInventoryOnUpSwaggerPetstoreSender ??
                       (_getInventoryGetInventoryOnUpSwaggerPetstoreSender = new GetInventoryGetInventoryOnUpSwaggerPetstoreSender());
            }
        }

        public static PlaceOrderPlaceOrderOnUpSwaggerPetstoreSender PlaceOrderPlaceOrderOnUpSwaggerPetstoreSender
        {
            get
            {
                return _placeOrderPlaceOrderOnUpSwaggerPetstoreSender ??
                       (_placeOrderPlaceOrderOnUpSwaggerPetstoreSender = new PlaceOrderPlaceOrderOnUpSwaggerPetstoreSender());
            }
        }

        public static GetOrderByIdGetOrderByIdOnUpSwaggerPetstoreSender GetOrderByIdGetOrderByIdOnUpSwaggerPetstoreSender
        {
            get
            {
                return _getOrderByIdGetOrderByIdOnUpSwaggerPetstoreSender ??
                       (_getOrderByIdGetOrderByIdOnUpSwaggerPetstoreSender = new GetOrderByIdGetOrderByIdOnUpSwaggerPetstoreSender());
            }
        }

        public static DeleteOrderDeleteOrderOnUpSwaggerPetstoreSender DeleteOrderDeleteOrderOnUpSwaggerPetstoreSender
        {
            get
            {
                return _deleteOrderDeleteOrderOnUpSwaggerPetstoreSender ??
                       (_deleteOrderDeleteOrderOnUpSwaggerPetstoreSender = new DeleteOrderDeleteOrderOnUpSwaggerPetstoreSender());
            }
        }

        public static CreateUserCreateUserOnUpSwaggerPetstoreSender CreateUserCreateUserOnUpSwaggerPetstoreSender
        {
            get
            {
                return _createUserCreateUserOnUpSwaggerPetstoreSender ??
                       (_createUserCreateUserOnUpSwaggerPetstoreSender = new CreateUserCreateUserOnUpSwaggerPetstoreSender());
            }
        }

        public static CreateUsersWithArrayInputCreateUsersWithArrayInputOnUpSwaggerPetstoreSender CreateUsersWithArrayInputCreateUsersWithArrayInputOnUpSwaggerPetstoreSender
        {
            get
            {
                return _createUsersWithArrayInputCreateUsersWithArrayInputOnUpSwaggerPetstoreSender ??
                       (_createUsersWithArrayInputCreateUsersWithArrayInputOnUpSwaggerPetstoreSender = new CreateUsersWithArrayInputCreateUsersWithArrayInputOnUpSwaggerPetstoreSender());
            }
        }

        public static CreateUsersWithListInputCreateUsersWithListInputOnUpSwaggerPetstoreSender CreateUsersWithListInputCreateUsersWithListInputOnUpSwaggerPetstoreSender
        {
            get
            {
                return _createUsersWithListInputCreateUsersWithListInputOnUpSwaggerPetstoreSender ??
                       (_createUsersWithListInputCreateUsersWithListInputOnUpSwaggerPetstoreSender = new CreateUsersWithListInputCreateUsersWithListInputOnUpSwaggerPetstoreSender());
            }
        }

        public static LoginUserLoginUserOnUpSwaggerPetstoreSender LoginUserLoginUserOnUpSwaggerPetstoreSender
        {
            get
            {
                return _loginUserLoginUserOnUpSwaggerPetstoreSender ??
                       (_loginUserLoginUserOnUpSwaggerPetstoreSender = new LoginUserLoginUserOnUpSwaggerPetstoreSender());
            }
        }

        public static LogoutUserLogoutUserOnUpSwaggerPetstoreSender LogoutUserLogoutUserOnUpSwaggerPetstoreSender
        {
            get
            {
                return _logoutUserLogoutUserOnUpSwaggerPetstoreSender ??
                       (_logoutUserLogoutUserOnUpSwaggerPetstoreSender = new LogoutUserLogoutUserOnUpSwaggerPetstoreSender());
            }
        }

        public static GetUserByNameGetUserByNameOnUpSwaggerPetstoreSender GetUserByNameGetUserByNameOnUpSwaggerPetstoreSender
        {
            get
            {
                return _getUserByNameGetUserByNameOnUpSwaggerPetstoreSender ??
                       (_getUserByNameGetUserByNameOnUpSwaggerPetstoreSender = new GetUserByNameGetUserByNameOnUpSwaggerPetstoreSender());
            }
        }

        public static UpdateUserUpdateUserOnUpSwaggerPetstoreSender UpdateUserUpdateUserOnUpSwaggerPetstoreSender
        {
            get
            {
                return _updateUserUpdateUserOnUpSwaggerPetstoreSender ??
                       (_updateUserUpdateUserOnUpSwaggerPetstoreSender = new UpdateUserUpdateUserOnUpSwaggerPetstoreSender());
            }
        }

        public static DeleteUserDeleteUserOnUpSwaggerPetstoreSender DeleteUserDeleteUserOnUpSwaggerPetstoreSender
        {
            get
            {
                return _deleteUserDeleteUserOnUpSwaggerPetstoreSender ??
                       (_deleteUserDeleteUserOnUpSwaggerPetstoreSender = new DeleteUserDeleteUserOnUpSwaggerPetstoreSender());
            }
        }

        public static CreateAddPetHttpRequestAddPetOperationOnSendingRequestAddPetOperationSender CreateAddPetHttpRequestAddPetOperationOnSendingRequestAddPetOperationSender
        {
            get
            {
                return _createAddPetHttpRequestAddPetOperationOnSendingRequestAddPetOperationSender ??
                       (_createAddPetHttpRequestAddPetOperationOnSendingRequestAddPetOperationSender = new CreateAddPetHttpRequestAddPetOperationOnSendingRequestAddPetOperationSender());
            }
        }

        public static CreateUpdatePetHttpRequestUpdatePetOperationOnSendingRequestUpdatePetOperationSender CreateUpdatePetHttpRequestUpdatePetOperationOnSendingRequestUpdatePetOperationSender
        {
            get
            {
                return _createUpdatePetHttpRequestUpdatePetOperationOnSendingRequestUpdatePetOperationSender ??
                       (_createUpdatePetHttpRequestUpdatePetOperationOnSendingRequestUpdatePetOperationSender = new CreateUpdatePetHttpRequestUpdatePetOperationOnSendingRequestUpdatePetOperationSender());
            }
        }

        public static CreateFindPetsByStatusHttpRequestFindPetsByStatusOperationOnSendingRequestFindPetsByStatusOperationSender CreateFindPetsByStatusHttpRequestFindPetsByStatusOperationOnSendingRequestFindPetsByStatusOperationSender
        {
            get
            {
                return _createFindPetsByStatusHttpRequestFindPetsByStatusOperationOnSendingRequestFindPetsByStatusOperationSender ??
                       (_createFindPetsByStatusHttpRequestFindPetsByStatusOperationOnSendingRequestFindPetsByStatusOperationSender = new CreateFindPetsByStatusHttpRequestFindPetsByStatusOperationOnSendingRequestFindPetsByStatusOperationSender());
            }
        }

        public static CreateFindPetsByTagsHttpRequestFindPetsByTagsOperationOnSendingRequestFindPetsByTagsOperationSender CreateFindPetsByTagsHttpRequestFindPetsByTagsOperationOnSendingRequestFindPetsByTagsOperationSender
        {
            get
            {
                return _createFindPetsByTagsHttpRequestFindPetsByTagsOperationOnSendingRequestFindPetsByTagsOperationSender ??
                       (_createFindPetsByTagsHttpRequestFindPetsByTagsOperationOnSendingRequestFindPetsByTagsOperationSender = new CreateFindPetsByTagsHttpRequestFindPetsByTagsOperationOnSendingRequestFindPetsByTagsOperationSender());
            }
        }

        public static CreateGetPetByIdHttpRequestGetPetByIdOperationOnSendingRequestGetPetByIdOperationSender CreateGetPetByIdHttpRequestGetPetByIdOperationOnSendingRequestGetPetByIdOperationSender
        {
            get
            {
                return _createGetPetByIdHttpRequestGetPetByIdOperationOnSendingRequestGetPetByIdOperationSender ??
                       (_createGetPetByIdHttpRequestGetPetByIdOperationOnSendingRequestGetPetByIdOperationSender = new CreateGetPetByIdHttpRequestGetPetByIdOperationOnSendingRequestGetPetByIdOperationSender());
            }
        }

        public static CreateUpdatePetWithFormHttpRequestUpdatePetWithFormOperationOnSendingRequestUpdatePetWithFormOperationSender CreateUpdatePetWithFormHttpRequestUpdatePetWithFormOperationOnSendingRequestUpdatePetWithFormOperationSender
        {
            get
            {
                return _createUpdatePetWithFormHttpRequestUpdatePetWithFormOperationOnSendingRequestUpdatePetWithFormOperationSender ??
                       (_createUpdatePetWithFormHttpRequestUpdatePetWithFormOperationOnSendingRequestUpdatePetWithFormOperationSender = new CreateUpdatePetWithFormHttpRequestUpdatePetWithFormOperationOnSendingRequestUpdatePetWithFormOperationSender());
            }
        }

        public static CreateDeletePetHttpRequestDeletePetOperationOnSendingRequestDeletePetOperationSender CreateDeletePetHttpRequestDeletePetOperationOnSendingRequestDeletePetOperationSender
        {
            get
            {
                return _createDeletePetHttpRequestDeletePetOperationOnSendingRequestDeletePetOperationSender ??
                       (_createDeletePetHttpRequestDeletePetOperationOnSendingRequestDeletePetOperationSender = new CreateDeletePetHttpRequestDeletePetOperationOnSendingRequestDeletePetOperationSender());
            }
        }

        public static CreateUploadFileHttpRequestUploadFileOperationOnSendingRequestUploadFileOperationSender CreateUploadFileHttpRequestUploadFileOperationOnSendingRequestUploadFileOperationSender
        {
            get
            {
                return _createUploadFileHttpRequestUploadFileOperationOnSendingRequestUploadFileOperationSender ??
                       (_createUploadFileHttpRequestUploadFileOperationOnSendingRequestUploadFileOperationSender = new CreateUploadFileHttpRequestUploadFileOperationOnSendingRequestUploadFileOperationSender());
            }
        }

        public static CreateGetInventoryHttpRequestGetInventoryOperationOnSendingRequestGetInventoryOperationSender CreateGetInventoryHttpRequestGetInventoryOperationOnSendingRequestGetInventoryOperationSender
        {
            get
            {
                return _createGetInventoryHttpRequestGetInventoryOperationOnSendingRequestGetInventoryOperationSender ??
                       (_createGetInventoryHttpRequestGetInventoryOperationOnSendingRequestGetInventoryOperationSender = new CreateGetInventoryHttpRequestGetInventoryOperationOnSendingRequestGetInventoryOperationSender());
            }
        }

        public static CreatePlaceOrderHttpRequestPlaceOrderOperationOnSendingRequestPlaceOrderOperationSender CreatePlaceOrderHttpRequestPlaceOrderOperationOnSendingRequestPlaceOrderOperationSender
        {
            get
            {
                return _createPlaceOrderHttpRequestPlaceOrderOperationOnSendingRequestPlaceOrderOperationSender ??
                       (_createPlaceOrderHttpRequestPlaceOrderOperationOnSendingRequestPlaceOrderOperationSender = new CreatePlaceOrderHttpRequestPlaceOrderOperationOnSendingRequestPlaceOrderOperationSender());
            }
        }

        public static CreateGetOrderByIdHttpRequestGetOrderByIdOperationOnSendingRequestGetOrderByIdOperationSender CreateGetOrderByIdHttpRequestGetOrderByIdOperationOnSendingRequestGetOrderByIdOperationSender
        {
            get
            {
                return _createGetOrderByIdHttpRequestGetOrderByIdOperationOnSendingRequestGetOrderByIdOperationSender ??
                       (_createGetOrderByIdHttpRequestGetOrderByIdOperationOnSendingRequestGetOrderByIdOperationSender = new CreateGetOrderByIdHttpRequestGetOrderByIdOperationOnSendingRequestGetOrderByIdOperationSender());
            }
        }

        public static CreateDeleteOrderHttpRequestDeleteOrderOperationOnSendingRequestDeleteOrderOperationSender CreateDeleteOrderHttpRequestDeleteOrderOperationOnSendingRequestDeleteOrderOperationSender
        {
            get
            {
                return _createDeleteOrderHttpRequestDeleteOrderOperationOnSendingRequestDeleteOrderOperationSender ??
                       (_createDeleteOrderHttpRequestDeleteOrderOperationOnSendingRequestDeleteOrderOperationSender = new CreateDeleteOrderHttpRequestDeleteOrderOperationOnSendingRequestDeleteOrderOperationSender());
            }
        }

        public static CreateCreateUserHttpRequestCreateUserOperationOnSendingRequestCreateUserOperationSender CreateCreateUserHttpRequestCreateUserOperationOnSendingRequestCreateUserOperationSender
        {
            get
            {
                return _createCreateUserHttpRequestCreateUserOperationOnSendingRequestCreateUserOperationSender ??
                       (_createCreateUserHttpRequestCreateUserOperationOnSendingRequestCreateUserOperationSender = new CreateCreateUserHttpRequestCreateUserOperationOnSendingRequestCreateUserOperationSender());
            }
        }

        public static CreateCreateUsersWithArrayInputHttpRequestCreateUsersWithArrayInputOperationOnSendingRequestCreateUsersWithArrayInputOperationSender CreateCreateUsersWithArrayInputHttpRequestCreateUsersWithArrayInputOperationOnSendingRequestCreateUsersWithArrayInputOperationSender
        {
            get
            {
                return _createCreateUsersWithArrayInputHttpRequestCreateUsersWithArrayInputOperationOnSendingRequestCreateUsersWithArrayInputOperationSender ??
                       (_createCreateUsersWithArrayInputHttpRequestCreateUsersWithArrayInputOperationOnSendingRequestCreateUsersWithArrayInputOperationSender = new CreateCreateUsersWithArrayInputHttpRequestCreateUsersWithArrayInputOperationOnSendingRequestCreateUsersWithArrayInputOperationSender());
            }
        }

        public static CreateCreateUsersWithListInputHttpRequestCreateUsersWithListInputOperationOnSendingRequestCreateUsersWithListInputOperationSender CreateCreateUsersWithListInputHttpRequestCreateUsersWithListInputOperationOnSendingRequestCreateUsersWithListInputOperationSender
        {
            get
            {
                return _createCreateUsersWithListInputHttpRequestCreateUsersWithListInputOperationOnSendingRequestCreateUsersWithListInputOperationSender ??
                       (_createCreateUsersWithListInputHttpRequestCreateUsersWithListInputOperationOnSendingRequestCreateUsersWithListInputOperationSender = new CreateCreateUsersWithListInputHttpRequestCreateUsersWithListInputOperationOnSendingRequestCreateUsersWithListInputOperationSender());
            }
        }

        public static CreateLoginUserHttpRequestLoginUserOperationOnSendingRequestLoginUserOperationSender CreateLoginUserHttpRequestLoginUserOperationOnSendingRequestLoginUserOperationSender
        {
            get
            {
                return _createLoginUserHttpRequestLoginUserOperationOnSendingRequestLoginUserOperationSender ??
                       (_createLoginUserHttpRequestLoginUserOperationOnSendingRequestLoginUserOperationSender = new CreateLoginUserHttpRequestLoginUserOperationOnSendingRequestLoginUserOperationSender());
            }
        }

        public static CreateLogoutUserHttpRequestLogoutUserOperationOnSendingRequestLogoutUserOperationSender CreateLogoutUserHttpRequestLogoutUserOperationOnSendingRequestLogoutUserOperationSender
        {
            get
            {
                return _createLogoutUserHttpRequestLogoutUserOperationOnSendingRequestLogoutUserOperationSender ??
                       (_createLogoutUserHttpRequestLogoutUserOperationOnSendingRequestLogoutUserOperationSender = new CreateLogoutUserHttpRequestLogoutUserOperationOnSendingRequestLogoutUserOperationSender());
            }
        }

        public static CreateGetUserByNameHttpRequestGetUserByNameOperationOnSendingRequestGetUserByNameOperationSender CreateGetUserByNameHttpRequestGetUserByNameOperationOnSendingRequestGetUserByNameOperationSender
        {
            get
            {
                return _createGetUserByNameHttpRequestGetUserByNameOperationOnSendingRequestGetUserByNameOperationSender ??
                       (_createGetUserByNameHttpRequestGetUserByNameOperationOnSendingRequestGetUserByNameOperationSender = new CreateGetUserByNameHttpRequestGetUserByNameOperationOnSendingRequestGetUserByNameOperationSender());
            }
        }

        public static CreateUpdateUserHttpRequestUpdateUserOperationOnSendingRequestUpdateUserOperationSender CreateUpdateUserHttpRequestUpdateUserOperationOnSendingRequestUpdateUserOperationSender
        {
            get
            {
                return _createUpdateUserHttpRequestUpdateUserOperationOnSendingRequestUpdateUserOperationSender ??
                       (_createUpdateUserHttpRequestUpdateUserOperationOnSendingRequestUpdateUserOperationSender = new CreateUpdateUserHttpRequestUpdateUserOperationOnSendingRequestUpdateUserOperationSender());
            }
        }

        public static CreateDeleteUserHttpRequestDeleteUserOperationOnSendingRequestDeleteUserOperationSender CreateDeleteUserHttpRequestDeleteUserOperationOnSendingRequestDeleteUserOperationSender
        {
            get
            {
                return _createDeleteUserHttpRequestDeleteUserOperationOnSendingRequestDeleteUserOperationSender ??
                       (_createDeleteUserHttpRequestDeleteUserOperationOnSendingRequestDeleteUserOperationSender = new CreateDeleteUserHttpRequestDeleteUserOperationOnSendingRequestDeleteUserOperationSender());
            }
        }

    }
}
