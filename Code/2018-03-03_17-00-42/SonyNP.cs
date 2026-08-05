using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using AOT;

[assembly: AssemblyCopyright("Copyright © Unity Technologies 2015")]
[assembly: AssemblyProduct("")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyTitle("SonyNP")]
[assembly: CompilationRelaxations(8)]
[assembly: AssemblyVersion("4.508.6382.26719")]
namespace Sony.NP;

public class Auth
{
	public struct NpClientId
	{
		public const int NP_CLIENT_ID_MAX_LEN = 128;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		internal string id;

		public string Id
		{
			get
			{
				return id;
			}
			set
			{
				if (value.Length > 128)
				{
					throw new NpToolkitException("The size of the string is more than " + 128 + " characters.");
				}
				id = value;
			}
		}
	}

	public struct NpClientSecret
	{
		public const int NP_CLIENT_SECRET_MAX_LEN = 256;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
		internal string secret;

		public string Secret
		{
			get
			{
				return secret;
			}
			set
			{
				if (value.Length > 256)
				{
					throw new NpToolkitException("The size of the string is more than " + 256 + " characters.");
				}
				secret = value;
			}
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetAuthCodeRequest : RequestBase
	{
		public const int MAX_SIZE_SCOPE = 511;

		internal NpClientId clientId;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
		internal string scope;

		public NpClientId ClientId
		{
			get
			{
				return clientId;
			}
			set
			{
				clientId = value;
			}
		}

		public string Scope
		{
			get
			{
				return scope;
			}
			set
			{
				if (value.Length > 511)
				{
					throw new NpToolkitException("The size of the string is more than " + 511 + " characters.");
				}
				scope = value;
			}
		}

		public GetAuthCodeRequest()
			: base(ServiceTypes.Auth, FunctionTypes.AuthGetAuthCode)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetIdTokenRequest : RequestBase
	{
		public const int MAX_SIZE_SCOPE = 511;

		internal NpClientId clientId;

		internal NpClientSecret clientSecret;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
		internal string scope;

		public NpClientId ClientId
		{
			get
			{
				return clientId;
			}
			set
			{
				clientId = value;
			}
		}

		public NpClientSecret ClientSecret
		{
			get
			{
				return clientSecret;
			}
			set
			{
				clientSecret = value;
			}
		}

		public string Scope
		{
			get
			{
				return scope;
			}
			set
			{
				if (value.Length > 511)
				{
					throw new NpToolkitException("The size of the string is more than " + 511 + " characters.");
				}
				scope = value;
			}
		}

		public GetIdTokenRequest()
			: base(ServiceTypes.Auth, FunctionTypes.AuthGetIdToken)
		{
		}
	}

	public enum IssuerIdType
	{
		Invalid = -1,
		Development = 1,
		Certification = 8,
		Live = 256
	}

	public class AuthCodeResponse : ResponseBase
	{
		internal string authCode;

		internal IssuerIdType issuerId;

		public string AuthCode => authCode;

		public IssuerIdType IssuerId => issuerId;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.AuthCodeBegin);
			memoryBuffer.ReadString(ref authCode);
			issuerId = (IssuerIdType)memoryBuffer.ReadUInt32();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.AuthCodeEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class IdTokenResponse : ResponseBase
	{
		internal string idToken;

		public string IdToken => idToken;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.IdTokenBegin);
			memoryBuffer.ReadString(ref idToken);
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.IdTokenEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetAuthCode(GetAuthCodeRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetIdToken(GetIdTokenRequest request, out APIResult result);

	public static int GetAuthCode(GetAuthCodeRequest request, AuthCodeResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetAuthCode(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetIdToken(GetIdTokenRequest request, IdTokenResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetIdToken(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}
}
[StructLayout(LayoutKind.Sequential, Pack = 8)]
public class RequestBase
{
	internal ServiceTypes serviceType;

	internal FunctionTypes functionType;

	internal uint serviceLabel;

	internal Core.UserServiceUserId userId;

	[MarshalAs(UnmanagedType.I1)]
	internal bool async = true;

	internal uint padding = 1234u;

	public ServiceTypes ServiceType => serviceType;

	public FunctionTypes FunctionType => functionType;

	public uint ServiceLabel
	{
		get
		{
			return serviceLabel;
		}
		set
		{
			serviceLabel = value;
		}
	}

	public Core.UserServiceUserId UserId
	{
		get
		{
			return userId;
		}
		set
		{
			userId = value;
		}
	}

	public bool Async
	{
		get
		{
			return async;
		}
		set
		{
			async = value;
		}
	}

	internal RequestBase(ServiceTypes serviceType, FunctionTypes functionType)
	{
		userId.id = -1;
		this.serviceType = serviceType;
		this.functionType = functionType;
	}

	internal static void FinaliseRequest(RequestBase request, ResponseBase response, int npRequestId)
	{
		if (!request.async)
		{
			response.PopulateFromNative((uint)npRequestId, request.functionType, request);
			return;
		}
		PendingAsyncRequestList.AddRequest((uint)npRequestId, request);
		PendingAsyncResponseList.AddResponse((uint)npRequestId, response);
		response.UpdateAsyncState((uint)npRequestId, request.functionType);
	}
}
public class ResponseBase
{
	internal int returnCode;

	internal bool locked;

	internal ServerErrorManaged serverError;

	public int ReturnCodeValue => returnCode;

	public Core.ReturnCodes ReturnCode => (Core.ReturnCodes)returnCode;

	public bool Locked => locked;

	public ServerErrorManaged ServerError => serverError;

	public bool IsErrorCode
	{
		get
		{
			if ((uint)returnCode >= 2181038080u && (uint)returnCode <= 2197815295u)
			{
				return true;
			}
			return false;
		}
	}

	public bool HasServerError => serverError != null;

	[DllImport("UnityNpToolkit2")]
	private static extern void PrxReadResponseBase(uint nptRequestId, FunctionTypes apiCalled, out int returnCode, out bool locked, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern void PrxReadResponseBaseLockedState(uint nptRequestId, FunctionTypes apiCalled, out bool locked, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern void PrxReadResponseCompleted(uint nptRequestId, FunctionTypes apiCalled, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool PrxReadHasServerError(uint nptRequestId, FunctionTypes apiCalled, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern void PrxMarshalResponse(uint npRequestId, FunctionTypes apiCalled, out NpMemoryBuffer data, out APIResult result);

	internal ResponseBase()
	{
	}

	internal void PopulateFromNative(uint nptRequestId, FunctionTypes apiCalled, RequestBase request)
	{
		ReadResult(nptRequestId, apiCalled, request);
		PrxReadResponseCompleted(nptRequestId, apiCalled, out var result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
	}

	protected internal virtual void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
	{
		PrxReadResponseBase(id, apiCalled, out returnCode, out var flag, out var result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		if (PrxReadHasServerError(id, apiCalled, out result))
		{
			serverError = new ServerErrorManaged();
			serverError.ReadResult(id, apiCalled);
		}
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		locked = flag;
	}

	internal void UpdateAsyncState(uint nptRequestId, FunctionTypes apiCalled)
	{
		PrxReadResponseBaseLockedState(nptRequestId, apiCalled, out locked, out var result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
	}

	internal MemoryBuffer BeginReadResponseBuffer(uint id, FunctionTypes apiCalled, out APIResult result)
	{
		NpMemoryBuffer data = default(NpMemoryBuffer);
		PrxMarshalResponse(id, apiCalled, out data, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		MemoryBuffer memoryBuffer = new MemoryBuffer(data);
		memoryBuffer.CheckStartMarker();
		return memoryBuffer;
	}

	internal void EndReadResponseBuffer(MemoryBuffer readBuffer)
	{
		readBuffer.CheckEndMarker();
	}

	public string ConvertReturnCodeToString(FunctionTypes apiCalled)
	{
		string text = "(0x" + returnCode.ToString("X8") + ")";
		Core.ReturnCodes returnCodes = (Core.ReturnCodes)returnCode;
		if (apiCalled != FunctionTypes.Invalid)
		{
			switch (apiCalled)
			{
			case FunctionTypes.CommerceDisplayCategoryBrowseDialog:
			case FunctionTypes.CommerceDisplayProductBrowseDialog:
			case FunctionTypes.CommerceDisplayVoucherCodeInputDialog:
			case FunctionTypes.CommerceDisplayCheckoutDialog:
			case FunctionTypes.CommerceDisplayJoinPlusDialog:
			case FunctionTypes.CommerceDisplayDownloadListDialog:
			case FunctionTypes.FriendsDisplayFriendRequestDialog:
			case FunctionTypes.FriendsDisplayBlockUserDialog:
			case FunctionTypes.MessagingDisplayReceivedGameDataMessagesDialog:
			case FunctionTypes.NpUtilsDisplaySigninDialog:
			case FunctionTypes.SessionDisplayReceivedInvitationsDialog:
			case FunctionTypes.TrophyDisplayTrophyListDialog:
			case FunctionTypes.UserProfileDisplayUserProfileDialog:
			case FunctionTypes.UserProfileDisplayGriefReportingDialog:
				switch (returnCodes)
				{
				case Core.ReturnCodes.SUCCESS:
					return text + " (DIALOG_RESULT_OK) ";
				case Core.ReturnCodes.DIALOG_RESULT_USER_CANCELED:
					return text + " (DIALOG_RESULT_USER_CANCELED) ";
				}
				break;
			case FunctionTypes.TrophyUnlock:
				if (returnCodes == Core.ReturnCodes.DIALOG_RESULT_USER_CANCELED)
				{
					return text + " (TROPHY_PLATINUM_UNLOCKED) ";
				}
				break;
			default:
				if (returnCode == 0)
				{
					return text += " (SUCCESS) ";
				}
				break;
			}
		}
		return (!Enum.IsDefined(typeof(Core.ReturnCodes), returnCodes)) ? (text + " (UNKNOWN) ") : (text + " (" + returnCodes.ToString() + ") ");
	}
}
public class Commerce
{
	public struct CategoryLabel
	{
		public const int CATEGORY_LABEL_MAX_LEN = 16;

		public const int SDK4_0_CATEGORY_LABEL_MAX_LEN = 55;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 56)]
		internal string internalValue;

		public string Value
		{
			get
			{
				return internalValue;
			}
			set
			{
				int num = 16;
				if (Main.initResult.sceSDKVersion < 72351744)
				{
					num = 55;
				}
				if (value.Length > num)
				{
					throw new NpToolkitException("The size of the label is more than " + num + " characters.");
				}
				internalValue = value;
			}
		}

		internal void Read(MemoryBuffer buffer)
		{
			buffer.ReadString(ref internalValue);
		}
	}

	public struct ServiceEntitlementLabel
	{
		public const int SERVICE_ENTITLEMENT_LABEL_MAX_LEN = 6;

		public const int SDK4_0_SERVICE_ENTITLEMENT_LABEL_MAX_LEN = 31;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		internal string internalValue;

		public string Value
		{
			get
			{
				return internalValue;
			}
			set
			{
				int num = 6;
				if (Main.initResult.sceSDKVersion < 72351744)
				{
					num = 31;
				}
				if (value.Length > num)
				{
					throw new NpToolkitException("The size of the label is more than " + num + " characters.");
				}
				internalValue = value;
			}
		}

		internal void Read(MemoryBuffer buffer)
		{
			buffer.ReadString(ref internalValue);
		}
	}

	public struct ProductLabel
	{
		public const int PRODUCT_LABEL_MAX_LEN = 16;

		public const int SDK4_0_PRODUCT_LABEL_MAX_LEN = 47;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
		internal string internalValue;

		public string Value
		{
			get
			{
				return internalValue;
			}
			set
			{
				int num = 16;
				if (Main.initResult.sceSDKVersion < 72351744)
				{
					num = 47;
				}
				if (value.Length > num)
				{
					throw new NpToolkitException("The size of the label is more than " + num + " characters.");
				}
				internalValue = value;
			}
		}

		internal void Read(MemoryBuffer buffer)
		{
			buffer.ReadString(ref internalValue);
		}
	}

	public struct SkuLabel
	{
		public const int SKU_LABEL_MAX_LEN = 4;

		public const int SDK4_0_SKU_LABEL_MAX_LEN = 55;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 56)]
		internal string internalValue;

		public string Value
		{
			get
			{
				return internalValue;
			}
			set
			{
				int num = 4;
				if (Main.initResult.sceSDKVersion < 72351744)
				{
					num = 55;
				}
				if (value.Length > num)
				{
					throw new NpToolkitException("The size of the label is more than " + num + " characters.");
				}
				internalValue = value;
			}
		}

		internal void Read(MemoryBuffer buffer)
		{
			buffer.ReadString(ref internalValue);
		}
	}

	public struct DownloadListTarget
	{
		internal ProductLabel productLabel;

		internal SkuLabel skuLabel;

		public ProductLabel ProductLabel
		{
			get
			{
				return productLabel;
			}
			set
			{
				productLabel = value;
			}
		}

		public SkuLabel SkuLabel
		{
			get
			{
				return skuLabel;
			}
			set
			{
				skuLabel = value;
			}
		}
	}

	public struct CheckoutTarget
	{
		public const uint NP_INVALID_SERVICE_LABEL = uint.MaxValue;

		internal ProductLabel productLabel;

		internal SkuLabel skuLabel;

		internal uint serviceLabel;

		public ProductLabel ProductLabel
		{
			get
			{
				return productLabel;
			}
			set
			{
				productLabel = value;
			}
		}

		public SkuLabel SkuLabel
		{
			get
			{
				return skuLabel;
			}
			set
			{
				skuLabel = value;
			}
		}

		public uint ServiceLabel
		{
			get
			{
				return serviceLabel;
			}
			set
			{
				serviceLabel = value;
			}
		}
	}

	public class SubCategory
	{
		internal string categoryName;

		internal string categoryDescription;

		internal string imageUrl;

		internal CategoryLabel categoryLabel;

		public string CategoryName => categoryName;

		public string CategoryDescription => categoryDescription;

		public string ImageUrl => imageUrl;

		public CategoryLabel CategoryLabel => categoryLabel;

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.SubCategoryBegin);
			buffer.ReadString(ref categoryName);
			buffer.ReadString(ref categoryDescription);
			buffer.ReadString(ref imageUrl);
			categoryLabel.Read(buffer);
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.SubCategoryEnd);
		}
	}

	public class Category
	{
		internal SubCategory[] subCategories;

		internal ulong countOfProducts;

		internal string categoryName;

		internal string categoryDescription;

		internal string imageUrl;

		internal CategoryLabel categoryLabel;

		public SubCategory[] SubCategories => subCategories;

		public ulong CountOfProducts => countOfProducts;

		public string CategoryName => categoryName;

		public string CategoryDescription => categoryDescription;

		public string ImageUrl => imageUrl;

		public CategoryLabel CategoryLabel => categoryLabel;

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.CategoryBegin);
			ulong num = buffer.ReadUInt64();
			if (num != 0)
			{
				subCategories = new SubCategory[num];
				for (ulong num2 = 0uL; num2 < num; num2++)
				{
					subCategories[num2] = new SubCategory();
					subCategories[num2].Read(buffer);
				}
			}
			countOfProducts = buffer.ReadUInt64();
			buffer.ReadString(ref categoryName);
			buffer.ReadString(ref categoryDescription);
			buffer.ReadString(ref imageUrl);
			categoryLabel.Read(buffer);
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.CategoryEnd);
		}
	}

	public class Product
	{
		internal ProductLabel productLabel;

		internal string productName;

		internal string imageUrl;

		internal bool hasDetails;

		internal ProductDetails details;

		public ProductLabel ProductLabel => productLabel;

		public string ProductName => productName;

		public string ImageUrl => imageUrl;

		public bool HasDetails => hasDetails;

		public ProductDetails Details => details;

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.ProductBegin);
			productLabel.Read(buffer);
			buffer.ReadString(ref productName);
			buffer.ReadString(ref imageUrl);
			hasDetails = buffer.ReadBool();
			if (hasDetails)
			{
				details = new ProductDetails();
				details.Read(buffer);
			}
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.ProductEnd);
		}
	}

	public enum PurchasabilityStatus
	{
		NotPurchased,
		PurchasedCanPurchaseAgain,
		PurchasedCannotPurchaseAgain
	}

	public class RatingDescriptor
	{
		internal string name;

		internal string imageUrl;

		public string Name => name;

		public string ImageUrl => imageUrl;

		internal void Read(MemoryBuffer buffer)
		{
			buffer.ReadString(ref name);
			buffer.ReadString(ref imageUrl);
		}
	}

	public class ProductDetails
	{
		internal DateTime releaseDate;

		internal string longDescription;

		internal string spName;

		internal string ratingSystemId;

		internal string ratingImageUrl;

		internal RatingDescriptor[] ratingDescriptors;

		internal SkuInfo[] skuinfo;

		internal PurchasabilityStatus purchasabilityStatus;

		internal uint starRatingsTotal;

		internal double starRatingScore;

		public DateTime ReleaseDate => releaseDate;

		public string LongDescription => longDescription;

		public string SpName => spName;

		public string RatingSystemId => ratingSystemId;

		public string RatingImageUrl => ratingImageUrl;

		public RatingDescriptor[] RatingDescriptors => ratingDescriptors;

		public SkuInfo[] Skuinfo => skuinfo;

		public PurchasabilityStatus PurchasabilityStatus => purchasabilityStatus;

		public uint StarRatingsTotal => starRatingsTotal;

		public double StarRatingScore => starRatingScore;

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.ProductDetailsBegin);
			releaseDate = Core.ReadRtcTick(buffer);
			buffer.ReadString(ref longDescription);
			buffer.ReadString(ref spName);
			buffer.ReadString(ref ratingSystemId);
			buffer.ReadString(ref ratingImageUrl);
			ulong num = buffer.ReadUInt64();
			if (num != 0)
			{
				ratingDescriptors = new RatingDescriptor[num];
				for (int i = 0; i < (int)num; i++)
				{
					ratingDescriptors[i] = new RatingDescriptor();
					ratingDescriptors[i].Read(buffer);
				}
			}
			else
			{
				ratingDescriptors = null;
			}
			ulong num2 = buffer.ReadUInt64();
			if (num2 != 0)
			{
				skuinfo = new SkuInfo[num2];
				for (int i = 0; i < (int)num2; i++)
				{
					skuinfo[i] = new SkuInfo();
					skuinfo[i].Read(buffer);
				}
			}
			else
			{
				skuinfo = null;
			}
			purchasabilityStatus = (PurchasabilityStatus)buffer.ReadUInt32();
			starRatingsTotal = buffer.ReadUInt32();
			starRatingScore = buffer.ReadDouble();
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.ProductDetailsEnd);
		}
	}

	public enum SkuType
	{
		Invalid,
		Standard,
		Preorder
	}

	public class SkuInfo
	{
		internal SkuType type;

		internal PurchasabilityStatus purchasabilityStatus;

		internal SkuLabel label;

		internal string name;

		internal string price;

		internal ulong intPrice;

		internal uint consumableUseCount;

		public SkuType Type => type;

		public PurchasabilityStatus PurchasabilityStatus => purchasabilityStatus;

		public SkuLabel Label => label;

		public string Name => name;

		public string Price => price;

		public ulong IntPrice => intPrice;

		public uint ConsumableUseCount => consumableUseCount;

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.SkuInfoBegin);
			type = (SkuType)buffer.ReadUInt32();
			purchasabilityStatus = (PurchasabilityStatus)buffer.ReadUInt32();
			label.Read(buffer);
			buffer.ReadString(ref name);
			buffer.ReadString(ref price);
			intPrice = buffer.ReadUInt64();
			consumableUseCount = buffer.ReadUInt32();
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.SkuInfoEnd);
		}
	}

	public enum EntitlementType
	{
		Invalid,
		Service,
		ServiceConsumable,
		Unified
	}

	public class ServiceEntitlement
	{
		internal ServiceEntitlementLabel entitlementLabel;

		internal DateTime createdDate;

		internal DateTime expireDate;

		internal long remainingCount;

		internal uint consumedCount;

		internal EntitlementType type;

		public ServiceEntitlementLabel EntitlementLabel => entitlementLabel;

		public DateTime CreatedDate => createdDate;

		public DateTime ExpireDate => expireDate;

		public long RemainingCount => remainingCount;

		public uint ConsumedCount => consumedCount;

		public EntitlementType Type => type;

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.ServiceEntitlementBegin);
			entitlementLabel.Read(buffer);
			createdDate = Core.ReadRtcTick(buffer);
			expireDate = Core.ReadRtcTick(buffer);
			remainingCount = buffer.ReadInt64();
			consumedCount = buffer.ReadUInt32();
			type = (EntitlementType)buffer.ReadUInt32();
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.ServiceEntitlementEnd);
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetCategoriesRequest : RequestBase
	{
		public const int MAX_CATEGORIES = 8;

		internal ulong numCategories;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		internal CategoryLabel[] categoryLabels = new CategoryLabel[8];

		public CategoryLabel[] CategoryLabels
		{
			get
			{
				if (numCategories == 0)
				{
					return null;
				}
				CategoryLabel[] array = new CategoryLabel[numCategories];
				Array.Copy(categoryLabels, array, (int)numCategories);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 8)
					{
						throw new NpToolkitException("The size of the array is more than " + 8);
					}
					value.CopyTo(categoryLabels, 0);
					numCategories = (uint)value.Length;
				}
				else
				{
					numCategories = 0uL;
				}
			}
		}

		public GetCategoriesRequest()
			: base(ServiceTypes.Commerce, FunctionTypes.CommerceGetCategories)
		{
		}
	}

	public enum ProductSortOrders
	{
		DefaultOrder,
		Name,
		Price,
		ReleaseDate
	}

	public enum ProductSortDirections
	{
		Ascending,
		Descending
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetProductsRequest : RequestBase
	{
		public const int MAX_PRODUCTS = 32;

		public const int MAX_CATEGORIES = 8;

		public const int DEFAULT_PAGE_SIZE = 32;

		internal ulong numProducts;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		internal ProductLabel[] productLabels = new ProductLabel[32];

		internal ulong numCategories;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		internal CategoryLabel[] categoryLabels = new CategoryLabel[8];

		internal uint offset;

		internal uint pageSize;

		internal ProductSortOrders sortOrder;

		internal ProductSortDirections sortDirection;

		[MarshalAs(UnmanagedType.I1)]
		internal bool keepHtmlTags;

		[MarshalAs(UnmanagedType.I1)]
		internal bool useCurrencySymbol;

		public ProductLabel[] ProductLabels
		{
			get
			{
				if (numProducts == 0)
				{
					return null;
				}
				ProductLabel[] array = new ProductLabel[numProducts];
				Array.Copy(productLabels, array, (int)numProducts);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 8)
					{
						throw new NpToolkitException("The size of the array is more than " + 32);
					}
					value.CopyTo(productLabels, 0);
					numProducts = (uint)value.Length;
				}
				else
				{
					numProducts = 0uL;
				}
			}
		}

		public CategoryLabel[] CategoryLabels
		{
			get
			{
				if (numCategories == 0)
				{
					return null;
				}
				CategoryLabel[] array = new CategoryLabel[numCategories];
				Array.Copy(categoryLabels, array, (int)numCategories);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 8)
					{
						throw new NpToolkitException("The size of the array is more than " + 8);
					}
					value.CopyTo(categoryLabels, 0);
					numCategories = (uint)value.Length;
				}
				else
				{
					numCategories = 0uL;
				}
			}
		}

		public uint Offset
		{
			get
			{
				return offset;
			}
			set
			{
				offset = value;
			}
		}

		public uint PageSize
		{
			get
			{
				return pageSize;
			}
			set
			{
				pageSize = value;
			}
		}

		public ProductSortOrders SortOrder
		{
			get
			{
				return sortOrder;
			}
			set
			{
				sortOrder = value;
			}
		}

		public ProductSortDirections SortDirection
		{
			get
			{
				return sortDirection;
			}
			set
			{
				sortDirection = value;
			}
		}

		public bool KeepHtmlTags
		{
			get
			{
				return keepHtmlTags;
			}
			set
			{
				keepHtmlTags = value;
			}
		}

		public bool UseCurrencySymbol
		{
			get
			{
				return useCurrencySymbol;
			}
			set
			{
				useCurrencySymbol = value;
			}
		}

		public GetProductsRequest()
			: base(ServiceTypes.Commerce, FunctionTypes.CommerceGetProducts)
		{
			pageSize = 32u;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetServiceEntitlementsRequest : RequestBase
	{
		public const int DEFAULT_PAGE_SIZE = 64;

		internal uint offset;

		internal uint pageSize;

		public uint Offset
		{
			get
			{
				return offset;
			}
			set
			{
				offset = value;
			}
		}

		public uint PageSize
		{
			get
			{
				return pageSize;
			}
			set
			{
				pageSize = value;
			}
		}

		public GetServiceEntitlementsRequest()
			: base(ServiceTypes.Commerce, FunctionTypes.CommerceGetServiceEntitlements)
		{
			pageSize = 64u;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class ConsumeServiceEntitlementRequest : RequestBase
	{
		internal ServiceEntitlementLabel entitlementLabel;

		internal uint consumedCount;

		public ServiceEntitlementLabel EntitlementLabel
		{
			get
			{
				return entitlementLabel;
			}
			set
			{
				entitlementLabel = value;
			}
		}

		public uint ConsumedCount
		{
			get
			{
				return consumedCount;
			}
			set
			{
				consumedCount = value;
			}
		}

		public ConsumeServiceEntitlementRequest()
			: base(ServiceTypes.Commerce, FunctionTypes.CommerceConsumeServiceEntitlement)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class DisplayCategoryBrowseDialogRequest : RequestBase
	{
		internal CategoryLabel categoryLabel;

		public CategoryLabel CategoryLabel
		{
			get
			{
				return categoryLabel;
			}
			set
			{
				categoryLabel = value;
			}
		}

		public DisplayCategoryBrowseDialogRequest()
			: base(ServiceTypes.Commerce, FunctionTypes.CommerceDisplayCategoryBrowseDialog)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class DisplayProductBrowseDialogRequest : RequestBase
	{
		internal ProductLabel productLabel;

		public ProductLabel ProductLabel
		{
			get
			{
				return productLabel;
			}
			set
			{
				productLabel = value;
			}
		}

		public DisplayProductBrowseDialogRequest()
			: base(ServiceTypes.Commerce, FunctionTypes.CommerceDisplayProductBrowseDialog)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class DisplayVoucherCodeInputDialogRequest : RequestBase
	{
		public const int VOUCHER_CODE_LEN = 63;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		internal string voucherCode;

		public string VoucherCode
		{
			get
			{
				return voucherCode;
			}
			set
			{
				if (value.Length > 63)
				{
					throw new NpToolkitException("The size of the voucher code is more than " + 63 + " characters.");
				}
				voucherCode = value;
			}
		}

		public DisplayVoucherCodeInputDialogRequest()
			: base(ServiceTypes.Commerce, FunctionTypes.CommerceDisplayVoucherCodeInputDialog)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class DisplayCheckoutDialogRequest : RequestBase
	{
		public const int MAX_TARGETS = 10;

		internal ulong numTargets;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		internal CheckoutTarget[] targets = new CheckoutTarget[10];

		public CheckoutTarget[] Targets
		{
			get
			{
				if (numTargets == 0)
				{
					return null;
				}
				CheckoutTarget[] array = new CheckoutTarget[numTargets];
				Array.Copy(targets, array, (int)numTargets);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 10)
					{
						throw new NpToolkitException("The size of the array is more than " + 10);
					}
					value.CopyTo(targets, 0);
					numTargets = (ulong)value.Length;
				}
				else
				{
					numTargets = 0uL;
				}
			}
		}

		public DisplayCheckoutDialogRequest()
			: base(ServiceTypes.Commerce, FunctionTypes.CommerceDisplayCheckoutDialog)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class DisplayDownloadListDialogRequest : RequestBase
	{
		public const int MAX_TARGETS = 10;

		internal ulong numTargets;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		internal DownloadListTarget[] targets = new DownloadListTarget[10];

		public DownloadListTarget[] Targets
		{
			get
			{
				if (numTargets == 0)
				{
					return null;
				}
				DownloadListTarget[] array = new DownloadListTarget[numTargets];
				Array.Copy(targets, array, (int)numTargets);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 10)
					{
						throw new NpToolkitException("The size of the array is more than " + 10);
					}
					value.CopyTo(targets, 0);
					numTargets = (ulong)value.Length;
				}
				else
				{
					numTargets = 0uL;
				}
			}
		}

		public DisplayDownloadListDialogRequest()
			: base(ServiceTypes.Commerce, FunctionTypes.CommerceDisplayDownloadListDialog)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class DisplayJoinPlusDialogRequest : RequestBase
	{
		internal ulong features;

		public DisplayJoinPlusDialogRequest()
			: base(ServiceTypes.Commerce, FunctionTypes.CommerceDisplayJoinPlusDialog)
		{
			features = 1uL;
		}
	}

	public enum PsStoreIconPos
	{
		Center,
		Left,
		Right
	}

	[StructLayout(LayoutKind.Sequential)]
	public class SetPsStoreIconDisplayStateRequest : RequestBase
	{
		internal PsStoreIconPos iconPosition;

		[MarshalAs(UnmanagedType.I1)]
		internal bool showIcon;

		public PsStoreIconPos IconPosition
		{
			get
			{
				return iconPosition;
			}
			set
			{
				iconPosition = value;
			}
		}

		public bool ShowIcon
		{
			get
			{
				return showIcon;
			}
			set
			{
				showIcon = value;
			}
		}

		public SetPsStoreIconDisplayStateRequest()
			: base(ServiceTypes.Commerce, FunctionTypes.CommerceSetPsStoreIconDisplayState)
		{
		}
	}

	public class CategoriesResponse : ResponseBase
	{
		internal Category[] categories;

		public Category[] Categories => categories;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.CategoriesBegin);
			ulong num = memoryBuffer.ReadUInt64();
			if (num != 0)
			{
				categories = new Category[num];
				for (ulong num2 = 0uL; num2 < num; num2++)
				{
					categories[num2] = new Category();
					categories[num2].Read(memoryBuffer);
				}
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.CategoriesEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class ProductsResponse : ResponseBase
	{
		internal Product[] products;

		public Product[] Products => products;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.ProductsBegin);
			ulong num = memoryBuffer.ReadUInt64();
			if (num != 0)
			{
				products = new Product[num];
				for (ulong num2 = 0uL; num2 < num; num2++)
				{
					products[num2] = new Product();
					products[num2].Read(memoryBuffer);
				}
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.ProductsEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class ServiceEntitlementsResponse : ResponseBase
	{
		internal ServiceEntitlement[] entitlements;

		internal ulong totalEntitlementsAvailable;

		public ServiceEntitlement[] Entitlements => entitlements;

		public ulong TotalEntitlementsAvailable => totalEntitlementsAvailable;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.ServiceEntitlementsBegin);
			totalEntitlementsAvailable = memoryBuffer.ReadUInt64();
			ulong num = memoryBuffer.ReadUInt64();
			if (num != 0)
			{
				entitlements = new ServiceEntitlement[num];
				for (int i = 0; i < (int)num; i++)
				{
					entitlements[i] = new ServiceEntitlement();
					entitlements[i].Read(memoryBuffer);
				}
			}
			else
			{
				entitlements = null;
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.ServiceEntitlementsEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetCategories(GetCategoriesRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetProducts(GetProductsRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetServiceEntitlements(GetServiceEntitlementsRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxConsumeServiceEntitlement(ConsumeServiceEntitlementRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxDisplayCategoryBrowseDialog(DisplayCategoryBrowseDialogRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxDisplayProductBrowseDialog(DisplayProductBrowseDialogRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxDisplayVoucherCodeInputDialog(DisplayVoucherCodeInputDialogRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxDisplayCheckoutDialog(DisplayCheckoutDialogRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxDisplayDownloadListDialog(DisplayDownloadListDialogRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxDisplayJoinPlusDialog(DisplayJoinPlusDialogRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxSetPsStoreIconDisplayState(SetPsStoreIconDisplayStateRequest request, out APIResult result);

	public static int GetCategories(GetCategoriesRequest request, CategoriesResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetCategories(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetProducts(GetProductsRequest request, ProductsResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetProducts(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetServiceEntitlements(GetServiceEntitlementsRequest request, ServiceEntitlementsResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetServiceEntitlements(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int ConsumeServiceEntitlement(ConsumeServiceEntitlementRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxConsumeServiceEntitlement(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int DisplayCategoryBrowseDialog(DisplayCategoryBrowseDialogRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxDisplayCategoryBrowseDialog(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int DisplayProductBrowseDialog(DisplayProductBrowseDialogRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxDisplayProductBrowseDialog(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int DisplayVoucherCodeInputDialog(DisplayVoucherCodeInputDialogRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxDisplayVoucherCodeInputDialog(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int DisplayCheckoutDialog(DisplayCheckoutDialogRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxDisplayCheckoutDialog(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int DisplayDownloadListDialog(DisplayDownloadListDialogRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxDisplayDownloadListDialog(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int DisplayJoinPlusDialog(DisplayJoinPlusDialogRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxDisplayJoinPlusDialog(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int SetPsStoreIconDisplayState(SetPsStoreIconDisplayStateRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxSetPsStoreIconDisplayState(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}
}
public class Friends
{
	public class Friend
	{
		internal Profiles.Profile profile = new Profiles.Profile();

		internal Presence.UserPresence presence = new Presence.UserPresence();

		public Profiles.Profile Profile => profile;

		public Presence.UserPresence Presence => presence;

		public override string ToString()
		{
			string text = "Profile:\n" + profile.ToString();
			return text + "\nPresence:\n" + presence.ToString();
		}

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.FriendBegin);
			profile.Read(buffer);
			presence.Read(buffer);
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.FriendEnd);
		}
	}

	public enum FriendsRetrievalModes
	{
		invalid,
		all,
		online,
		inContext,
		tryCached
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetFriendsRequest : RequestBase
	{
		internal FriendsRetrievalModes mode;

		internal uint limit;

		internal uint offset;

		public FriendsRetrievalModes Mode
		{
			get
			{
				return mode;
			}
			set
			{
				mode = value;
			}
		}

		public uint Limit
		{
			get
			{
				return limit;
			}
			set
			{
				limit = value;
			}
		}

		public uint Offset
		{
			get
			{
				return offset;
			}
			set
			{
				offset = value;
			}
		}

		public GetFriendsRequest()
			: base(ServiceTypes.Friends, FunctionTypes.FriendsGetFriends)
		{
			mode = FriendsRetrievalModes.invalid;
			limit = 0u;
			offset = 0u;
		}
	}

	public class FriendsResponse : ResponseBase
	{
		internal Friend[] friends;

		public Friend[] Friends => friends;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.FriendsBegin);
			uint num = memoryBuffer.ReadUInt32();
			friends = new Friend[num];
			for (int i = 0; i < num; i++)
			{
				friends[i] = new Friend();
				friends[i].Read(memoryBuffer);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.FriendsEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class FriendsOfFriend
	{
		internal Core.OnlineUser originalFriend;

		internal Core.OnlineUser[] users;

		public Core.OnlineUser OriginalFriend => originalFriend;

		public Core.OnlineUser[] Users => users;

		public FriendsOfFriend()
		{
			originalFriend = new Core.OnlineUser();
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetFriendsOfFriendsRequest : RequestBase
	{
		public const int MAX_ACCOUNT_IDS = 10;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		internal Core.NpAccountId[] accountIds;

		internal uint numAccountIds;

		public Core.NpAccountId[] AccountIds
		{
			get
			{
				if (numAccountIds == 0)
				{
					return null;
				}
				Core.NpAccountId[] array = new Core.NpAccountId[numAccountIds];
				Array.Copy(accountIds, array, numAccountIds);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 10)
					{
						throw new NpToolkitException("The size of the array is more than " + 10);
					}
					value.CopyTo(accountIds, 0);
					numAccountIds = (uint)value.Length;
				}
				else
				{
					numAccountIds = 0u;
				}
			}
		}

		public GetFriendsOfFriendsRequest()
			: base(ServiceTypes.Friends, FunctionTypes.FriendsGetFriendsOfFriends)
		{
			accountIds = new Core.NpAccountId[10];
			numAccountIds = 0u;
		}
	}

	public class FriendsOfFriendsResponse : ResponseBase
	{
		internal FriendsOfFriend[] friendsOfFriends;

		public FriendsOfFriend[] FriendsOfFriends => friendsOfFriends;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.FriendsOfFriendsBegin);
			uint num = memoryBuffer.ReadUInt32();
			friendsOfFriends = new FriendsOfFriend[num];
			for (int i = 0; i < num; i++)
			{
				friendsOfFriends[i] = new FriendsOfFriend();
				friendsOfFriends[i].originalFriend.Read(memoryBuffer);
				uint num2 = memoryBuffer.ReadUInt32();
				friendsOfFriends[i].users = new Core.OnlineUser[num2];
				for (int j = 0; j < num2; j++)
				{
					friendsOfFriends[i].users[j] = new Core.OnlineUser();
					friendsOfFriends[i].users[j].Read(memoryBuffer);
				}
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.FriendsOfFriendsEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public enum BlockedUsersRetrievalMode
	{
		invalid,
		all,
		tryCached
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetBlockedUsersRquest : RequestBase
	{
		internal BlockedUsersRetrievalMode mode;

		internal uint limit;

		internal uint offset;

		public BlockedUsersRetrievalMode Mode
		{
			get
			{
				return mode;
			}
			set
			{
				mode = value;
			}
		}

		public uint Limit
		{
			get
			{
				return limit;
			}
			set
			{
				limit = value;
			}
		}

		public uint Offset
		{
			get
			{
				return offset;
			}
			set
			{
				offset = value;
			}
		}

		public GetBlockedUsersRquest()
			: base(ServiceTypes.Friends, FunctionTypes.FriendsGetBlockedUsers)
		{
			mode = BlockedUsersRetrievalMode.invalid;
			limit = 0u;
			offset = 0u;
		}
	}

	public class BlockedUsersResponse : ResponseBase
	{
		internal Core.OnlineUser[] users;

		public Core.OnlineUser[] Users => users;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.BlockedUsersBegin);
			uint num = memoryBuffer.ReadUInt32();
			users = new Core.OnlineUser[num];
			for (int i = 0; i < num; i++)
			{
				users[i] = new Core.OnlineUser();
				users[i].Read(memoryBuffer);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.BlockedUsersEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class DisplayFriendRequestDialogRequest : RequestBase
	{
		internal Core.NpAccountId targetUser;

		public Core.NpAccountId TargetUser
		{
			get
			{
				return targetUser;
			}
			set
			{
				targetUser = value;
			}
		}

		public DisplayFriendRequestDialogRequest()
			: base(ServiceTypes.Friends, FunctionTypes.FriendsDisplayFriendRequestDialog)
		{
			targetUser.id = 0uL;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class DisplayBlockUserDialogRequest : RequestBase
	{
		internal Core.NpAccountId targetUser;

		public Core.NpAccountId TargetUser
		{
			get
			{
				return targetUser;
			}
			set
			{
				targetUser = value;
			}
		}

		public DisplayBlockUserDialogRequest()
			: base(ServiceTypes.Friends, FunctionTypes.FriendsDisplayBlockUserDialog)
		{
			targetUser.id = 0uL;
		}
	}

	public enum FriendListUpdateEvents
	{
		none,
		friendAdded,
		friendRemoved,
		friendOnlineStatusChanged
	}

	public class FriendListUpdateResponse : ResponseBase
	{
		internal Core.OnlineUser localUpdatedUser = new Core.OnlineUser();

		internal Core.OnlineUser remoteUser = new Core.OnlineUser();

		internal Core.UserServiceUserId userId;

		internal FriendListUpdateEvents eventType;

		public Core.OnlineUser LocalUpdatedUser => localUpdatedUser;

		public Core.OnlineUser RemoteUser => remoteUser;

		public Core.UserServiceUserId UserId => userId;

		public FriendListUpdateEvents EventType => eventType;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.FriendListUpdateBegin);
			localUpdatedUser.Read(memoryBuffer);
			remoteUser.Read(memoryBuffer);
			userId = memoryBuffer.ReadInt32();
			eventType = (FriendListUpdateEvents)memoryBuffer.ReadInt32();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.FriendListUpdateEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class BlocklistUpdateResponse : ResponseBase
	{
		internal Core.OnlineUser localUpdatedUser = new Core.OnlineUser();

		internal Core.UserServiceUserId userId;

		public Core.OnlineUser LocalUpdatedUser => localUpdatedUser;

		public Core.UserServiceUserId UserId => userId;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.BlocklistUpdateBegin);
			localUpdatedUser.Read(memoryBuffer);
			userId = memoryBuffer.ReadInt32();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.BlocklistUpdateEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetFriends(GetFriendsRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetFriendsOfFriends(GetFriendsOfFriendsRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetBlockedUsers(GetBlockedUsersRquest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxDisplayFriendRequestDialog(DisplayFriendRequestDialogRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxDisplayBlockUserDialog(DisplayBlockUserDialogRequest request, out APIResult result);

	public static int GetFriends(GetFriendsRequest request, FriendsResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetFriends(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetFriendsOfFriends(GetFriendsOfFriendsRequest request, FriendsOfFriendsResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetFriendsOfFriends(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetBlockedUsers(GetBlockedUsersRquest request, BlockedUsersResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetBlockedUsers(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int DisplayFriendRequestDialog(DisplayFriendRequestDialogRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxDisplayFriendRequestDialog(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int DisplayBlockUserDialog(DisplayBlockUserDialogRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxDisplayBlockUserDialog(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}
}
public class Main
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void OnPrxCallbackEvent();

	[StructLayout(LayoutKind.Sequential)]
	internal class ValidationChecks
	{
		internal uint expectedNumFunctionTypes;

		public void Init()
		{
			expectedNumFunctionTypes = 118u;
		}
	}

	public delegate void EventHandler(NpCallbackEvent npEvent);

	internal static InitResult initResult;

	public static event EventHandler OnAsyncEvent;

	[DllImport("UnityNpToolkit2")]
	private static extern void PrxInitialize(InitToolkit initParams, out NativeInitResult initResult, OnPrxCallbackEvent toolkitEventCallback, OnPrxCallbackEvent npRequestEventCallback, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern void PrxValidateToolkit(ValidationChecks checks, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern void PrxShutDown();

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxUpdate();

	[DllImport("UnityNpToolkit2")]
	private static extern bool PrxAbortRequest(uint npRequestId, out APIResult result);

	public static InitResult Initialize(InitToolkit initParams)
	{
		ValidationChecks validationChecks = new ValidationChecks();
		validationChecks.Init();
		PrxValidateToolkit(validationChecks, out var result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		initParams.CheckValid();
		OnPrxCallbackEvent toolkitEventCallback = PopulateThread.OnPrxNpToolkitEvent;
		OnPrxCallbackEvent npRequestEventCallback = NpRequestsThread.OnPrxNpRequestEvent;
		NativeInitResult nativeResult = default(NativeInitResult);
		PrxInitialize(initParams, out nativeResult, toolkitEventCallback, npRequestEventCallback, out result);
		initResult.Initialise(nativeResult);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		PopulateThread.Start();
		NpRequestsThread.Start();
		return initResult;
	}

	internal static void InternalEventHandler(NpCallbackEvent npEvent)
	{
		if (npEvent.service == ServiceTypes.Notification && npEvent.apiCalled == FunctionTypes.NotificationAborted)
		{
			PendingAsyncRequestList.RequestHasBeenAborted(npEvent.npRequestId);
		}
	}

	internal static void CallOnAsyncEvent(NpCallbackEvent npEvent)
	{
		InternalEventHandler(npEvent);
		try
		{
			Main.OnAsyncEvent(npEvent);
		}
		catch (Exception ex)
		{
			Console.WriteLine("Exception Occured in OnAsyncEvent handler : " + ex.Message);
			Console.WriteLine(ex.StackTrace);
			throw;
		}
	}

	public static void Update()
	{
		PrxUpdate();
	}

	private static void PumpAsyncEvents()
	{
		if (Main.OnAsyncEvent != null)
		{
			for (NpCallbackEvent npCallbackEvent = PendingCallbackQueue.PopEvent(); npCallbackEvent != null; npCallbackEvent = PendingCallbackQueue.PopEvent())
			{
				InternalEventHandler(npCallbackEvent);
				Main.OnAsyncEvent(npCallbackEvent);
			}
		}
	}

	public static void ShutDown()
	{
		PopulateThread.Stop();
		NpRequestsThread.Stop();
		PendingAsyncRequestList.Shutdown();
		PrxShutDown();
	}

	public static List<PendingRequest> GetPendingRequests()
	{
		return PendingAsyncRequestList.PendingRequests;
	}

	public static bool AbortRequest(uint npRequestId)
	{
		if (!PendingAsyncRequestList.IsPending(npRequestId))
		{
			return false;
		}
		PrxAbortRequest(npRequestId, out var result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		PendingAsyncRequestList.MarkRequestAsAborting(npRequestId);
		return true;
	}
}
public class Matching
{
	public enum AttributeType
	{
		Invalid,
		Integer,
		Binary
	}

	public enum AttributeScope
	{
		Invalid,
		Room,
		Member
	}

	public enum RoomAttributeVisibility
	{
		Invalid,
		Internal,
		External,
		Search
	}

	public enum RoomVisibility
	{
		Invalid,
		PublicRoom,
		PrivateRoom,
		ReserveSlots
	}

	public enum RoomMigrationType
	{
		OwnerBind,
		OwnerMigration
	}

	public enum TopologyType
	{
		Invalid,
		None,
		Mesh,
		Star
	}

	public struct AttributeMetadata
	{
		public const int MAX_SIZE_NAME = 31;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		internal string name;

		internal AttributeType type;

		internal AttributeScope scope;

		internal RoomAttributeVisibility roomAttributeVisibility;

		internal uint size;

		public string Name => name;

		public AttributeType Type => type;

		public AttributeScope Scope => scope;

		public RoomAttributeVisibility RoomVisibility => roomAttributeVisibility;

		public uint Size => size;

		private void InternalSetAttribute(string name, AttributeType type, AttributeScope scope, RoomAttributeVisibility roomAttributeVisibility, uint size)
		{
			if (name.Length > 31)
			{
				throw new NpToolkitException("Attribute " + name + " : The size of the name string is more than " + 31 + " characters.");
			}
			if (type == AttributeType.Invalid)
			{
				throw new NpToolkitException("Attribute " + name + " : Can't set an Invalid type.");
			}
			switch (scope)
			{
			case AttributeScope.Invalid:
				throw new NpToolkitException("Attribute " + name + " : Can't set an Invalid scope.");
			case AttributeScope.Room:
				if (roomAttributeVisibility == RoomAttributeVisibility.Invalid)
				{
					throw new NpToolkitException("Attribute " + name + " : Can't set an Invalid roomAttributeVisibility when Scope is Room.");
				}
				break;
			}
			if (type == AttributeType.Integer && size != 8)
			{
				throw new NpToolkitException("Attribute " + name + " : Integer attribute must be size 8.");
			}
			if (type == AttributeType.Binary && size > 256)
			{
				throw new NpToolkitException("Attribute " + name + " : Binary attribute size must not be more than " + 256);
			}
			if (scope == AttributeScope.Member && roomAttributeVisibility != RoomAttributeVisibility.Invalid)
			{
				throw new NpToolkitException("Attribute " + name + " : A Member attribute can't set a RoomAttributeVisibility of " + roomAttributeVisibility.ToString() + ". It must always be set to RoomAttributeVisibility.Invalid.");
			}
			if (roomAttributeVisibility == RoomAttributeVisibility.Search && type == AttributeType.Binary && size > 64)
			{
				throw new NpToolkitException("Attribute " + name + " : A Binary Search attribute can't be more than 64 bytes.");
			}
			this.name = name;
			this.type = type;
			this.scope = scope;
			this.roomAttributeVisibility = roomAttributeVisibility;
			this.size = size;
		}

		internal void Read(MemoryBuffer buffer)
		{
			buffer.ReadString(ref name);
			type = (AttributeType)buffer.ReadUInt32();
			scope = (AttributeScope)buffer.ReadUInt32();
			roomAttributeVisibility = (RoomAttributeVisibility)buffer.ReadUInt32();
			size = buffer.ReadUInt32();
		}

		public static AttributeMetadata CreateIntegerAttribute(string name, AttributeScope scope, RoomAttributeVisibility roomAttributeVisibility)
		{
			AttributeMetadata result = default(AttributeMetadata);
			result.InternalSetAttribute(name, AttributeType.Integer, scope, roomAttributeVisibility, 8u);
			return result;
		}

		public static AttributeMetadata CreateBinaryAttribute(string name, AttributeScope scope, RoomAttributeVisibility roomAttributeVisibility, uint size)
		{
			AttributeMetadata result = default(AttributeMetadata);
			result.InternalSetAttribute(name, AttributeType.Binary, scope, roomAttributeVisibility, size);
			return result;
		}
	}

	public struct Attribute
	{
		public const int MAX_SIZE_BIN_VALUE = 256;

		internal AttributeMetadata metadata;

		internal int intValue;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		internal byte[] binValue;

		public AttributeMetadata Metadata => metadata;

		public int IntValue
		{
			get
			{
				if (metadata.type != AttributeType.Integer)
				{
					throw new NpToolkitException("Attribute " + metadata.name + " : This is not an interger attribute type.");
				}
				return intValue;
			}
			set
			{
				if (metadata.type != AttributeType.Integer)
				{
					throw new NpToolkitException("Attribute " + metadata.name + " : Expecting an interger attribute type.");
				}
				intValue = value;
			}
		}

		public byte[] BinValue
		{
			get
			{
				if (metadata.type != AttributeType.Binary)
				{
					throw new NpToolkitException("Attribute " + metadata.name + " : This is not a binary attribute type.");
				}
				if (metadata.size == 0)
				{
					return null;
				}
				byte[] destinationArray = new byte[metadata.size];
				Array.Copy(binValue, destinationArray, metadata.size);
				return binValue;
			}
			set
			{
				if (metadata.type != AttributeType.Binary)
				{
					throw new NpToolkitException("Attribute " + metadata.name + " : Expected a binary attribute type.");
				}
				if (value == null)
				{
					throw new NpToolkitException("Attribute " + metadata.name + " : Expected a non-null byte array.");
				}
				if (value.Length > 256)
				{
					throw new NpToolkitException("Attribute " + metadata.name + " : Binary array is more than " + 256);
				}
				if (value.Length > metadata.size)
				{
					throw new NpToolkitException("Attribute " + metadata.name + " : Array size of " + value.Length + " can't exceed " + metadata.size + " bytes defined in metadata.");
				}
				if (binValue == null)
				{
					binValue = new byte[256];
				}
				value.CopyTo(binValue, 0);
			}
		}

		internal void Read(MemoryBuffer buffer)
		{
			metadata.Read(buffer);
			if (metadata.type == AttributeType.Integer)
			{
				intValue = buffer.ReadInt32();
			}
			else if (metadata.type == AttributeType.Binary)
			{
				buffer.ReadData(ref binValue);
			}
		}

		public static Attribute CreateIntegerAttribute(AttributeMetadata metadata, int intValue)
		{
			return new Attribute
			{
				metadata = metadata,
				IntValue = intValue
			};
		}

		public static Attribute CreateBinaryAttribute(AttributeMetadata metadata, byte[] binValue)
		{
			return new Attribute
			{
				metadata = metadata,
				BinValue = binValue
			};
		}
	}

	public struct SessionImage
	{
		public const int IMAGE_PATH_MAX_LEN = 255;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		internal string sessionImgPath;

		public string SessionImgPath
		{
			get
			{
				return sessionImgPath;
			}
			set
			{
				if (value.Length > 255)
				{
					throw new NpToolkitException("The size of the image path string is more than " + 255 + " characters.");
				}
				sessionImgPath = value;
			}
		}

		internal bool IsValid()
		{
			if (sessionImgPath == null || sessionImgPath.Length == 0)
			{
				return false;
			}
			return true;
		}

		internal bool Exists()
		{
			if (sessionImgPath == null || sessionImgPath.Length == 0)
			{
				return false;
			}
			return true;
		}
	}

	public struct LocalizedSessionInfo
	{
		public const int SESSION_NAME_LEN = 63;

		public const int STATUS_LEN = 255;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		private string sessionName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		private string status;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
		internal string languageCode;

		public string SessionName
		{
			get
			{
				return sessionName;
			}
			set
			{
				if (value.Length > 63)
				{
					throw new NpToolkitException("The size of the session name is more than " + 63 + " characters.");
				}
				sessionName = value;
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set
			{
				if (value.Length > 255)
				{
					throw new NpToolkitException("The size of the status string is more than " + 255 + " characters.");
				}
				status = value;
			}
		}

		public Core.LanguageCode LanguageCode
		{
			get
			{
				Core.LanguageCode languageCode = new Core.LanguageCode();
				languageCode.code = this.languageCode;
				return languageCode;
			}
			set
			{
				languageCode = value.code;
			}
		}

		public LocalizedSessionInfo(string sessionName, string status, Core.LanguageCode languageCode)
		{
			this.sessionName = "";
			this.status = "";
			this.languageCode = "";
			SessionName = sessionName;
			Status = status;
			LanguageCode = languageCode;
		}
	}

	public struct PresenceOptionData
	{
		public const int NP_MATCHING2_PRESENCE_OPTION_DATA_SIZE = 16;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		internal byte[] data;

		[MarshalAs(UnmanagedType.U1)]
		internal byte length;

		public byte[] Data
		{
			get
			{
				if (length == 0)
				{
					return null;
				}
				byte[] array = new byte[length];
				Array.Copy(data, array, length);
				return array;
			}
			set
			{
				if (data == null)
				{
					data = new byte[16];
				}
				if (value != null)
				{
					if (value.Length > 16)
					{
						throw new NpToolkitException("The size of the data array is more than " + 16);
					}
					value.CopyTo(data, 0);
					length = (byte)value.Length;
				}
				else
				{
					length = 0;
				}
			}
		}

		public string DataAsString
		{
			get
			{
				if (length == 0)
				{
					return "";
				}
				return Encoding.ASCII.GetString(data, 0, length);
			}
			set
			{
				if (data == null)
				{
					data = new byte[16];
				}
				if (value != null)
				{
					byte[] bytes = Encoding.ASCII.GetBytes(value);
					if (bytes.Length > 16)
					{
						throw new NpToolkitException("The size of the ASCII string is more than " + 16 + " characters.");
					}
					bytes.CopyTo(data, 0);
					length = (byte)bytes.Length;
				}
				else
				{
					if (data == null)
					{
						data = new byte[16];
					}
					length = 0;
				}
			}
		}

		internal void Init()
		{
			data = new byte[16];
		}

		internal void Read(MemoryBuffer buffer)
		{
			buffer.ReadData(ref data);
		}
	}

	public enum SearchOperatorTypes
	{
		Invalid,
		Equals,
		NotEquals,
		LessThan,
		LessEqualsThan,
		GreaterThan,
		GreaterEqualsThan
	}

	public struct SearchClause
	{
		internal Attribute attributeToCompare;

		internal SearchOperatorTypes operatorType;

		public Attribute AttributeToCompare
		{
			get
			{
				return attributeToCompare;
			}
			set
			{
				attributeToCompare = value;
			}
		}

		public SearchOperatorTypes OperatorType
		{
			get
			{
				return operatorType;
			}
			set
			{
				operatorType = value;
			}
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class SetInitConfigurationRequest : RequestBase
	{
		public const int MAX_ATTRIBUTES = 64;

		private ulong numAttributes;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		private AttributeMetadata[] attributes = new AttributeMetadata[64];

		public AttributeMetadata[] Attributes
		{
			get
			{
				if (numAttributes == 0)
				{
					return null;
				}
				AttributeMetadata[] array = new AttributeMetadata[numAttributes];
				Array.Copy(attributes, array, (int)numAttributes);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 64)
					{
						throw new NpToolkitException("The size of the array is more than " + 64);
					}
					value.CopyTo(attributes, 0);
					numAttributes = (uint)value.Length;
				}
				else
				{
					numAttributes = 0uL;
				}
				ValidateAttributes();
			}
		}

		private void ValidateAttributes()
		{
			uint num = 0u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			uint num5 = 0u;
			for (ulong num6 = 0uL; num6 < numAttributes; num6++)
			{
				if (attributes[num6].scope == AttributeScope.Member)
				{
					num += attributes[num6].size;
					continue;
				}
				if (attributes[num6].scope == AttributeScope.Room)
				{
					if (attributes[num6].roomAttributeVisibility == RoomAttributeVisibility.Internal)
					{
						num2 += attributes[num6].size;
						continue;
					}
					if (attributes[num6].roomAttributeVisibility == RoomAttributeVisibility.External)
					{
						num3 += attributes[num6].size;
						continue;
					}
					if (attributes[num6].roomAttributeVisibility == RoomAttributeVisibility.Search)
					{
						if (attributes[num6].type == AttributeType.Binary)
						{
							num4++;
							continue;
						}
						if (attributes[num6].type == AttributeType.Integer)
						{
							num5++;
							continue;
						}
						throw new NpToolkitException("Attribute " + attributes[num6].name + " : Type is not set to either Binary or Integer.");
					}
					throw new NpToolkitException("Attribute " + attributes[num6].name + " : RoomAttributeVisibility is not set to either Internal or External.");
				}
				throw new NpToolkitException("Attribute " + attributes[num6].name + " : " + num6 + " : Scope is not set to either Member or Room.");
			}
			if (num > 64)
			{
				throw new NpToolkitException("The sum of all member attributes has to be a max of 64.");
			}
			if (num2 > 448)
			{
				throw new NpToolkitException("The sum of all internal room attributes has to be a max of 448 bytes. ");
			}
			if (num3 > 448)
			{
				throw new NpToolkitException("The sum of all external room attributes has to be a max of 448 bytes");
			}
			if (num4 > 1)
			{
				throw new NpToolkitException("Only 1 binary search variable is permitted.");
			}
			if (num5 > 8)
			{
				throw new NpToolkitException("Only 8 interger search variables are permitted.");
			}
		}

		public SetInitConfigurationRequest()
			: base(ServiceTypes.Matching, FunctionTypes.MatchingSetInitConfiguration)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetWorldsRequest : RequestBase
	{
		public GetWorldsRequest()
			: base(ServiceTypes.Matching, FunctionTypes.MatchingGetWorlds)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class CreateRoomRequest : RequestBase
	{
		public const int MAX_ATTRIBUTES = 64;

		public const int MAX_SIZE_ROOM_NAME = 63;

		public const int MAX_SIZE_ROOM_STATUS = 255;

		public const int MAX_SIZE_FIXED_DATA = 1047552;

		public const int MAX_SIZE_CHANGEABLE_DATA = 1024;

		public const int MAX_SIZE_LOCALIZATIONS = 10;

		internal ulong numAttributes;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		internal Attribute[] attributes = new Attribute[64];

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		internal string name;

		internal NpMatching2SessionPassword password;

		internal RoomVisibility visibility;

		internal uint numReservedSlots;

		internal ulong fixedDataSize;

		[MarshalAs(UnmanagedType.LPArray)]
		internal byte[] fixedData;

		internal ulong changeableDataSize;

		[MarshalAs(UnmanagedType.LPArray)]
		internal byte[] changeableData;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		internal string status;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		internal LocalizedSessionInfo[] localizations = new LocalizedSessionInfo[10];

		internal SessionImage image;

		internal RoomMigrationType ownershipMigration;

		internal TopologyType topology;

		internal uint maxNumMembers;

		internal NpMatching2WorldNumber worldNumber;

		[MarshalAs(UnmanagedType.I1)]
		internal bool displayOnSystem;

		[MarshalAs(UnmanagedType.I1)]
		internal bool isSystemJoinable;

		[MarshalAs(UnmanagedType.I1)]
		internal bool joinAllLocalUsers;

		[MarshalAs(UnmanagedType.I1)]
		internal bool isNatRestricted;

		[MarshalAs(UnmanagedType.I1)]
		internal bool isCrossplatform;

		[MarshalAs(UnmanagedType.I1)]
		internal bool allowBlockedUsersOfOwner;

		[MarshalAs(UnmanagedType.I1)]
		internal bool allowBlockedUsersOfMembers;

		public Attribute[] Attributes
		{
			get
			{
				if (numAttributes == 0)
				{
					return null;
				}
				Attribute[] array = new Attribute[numAttributes];
				Array.Copy(attributes, array, (int)numAttributes);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 64)
					{
						throw new NpToolkitException("The size of the array is more than " + 64);
					}
					value.CopyTo(attributes, 0);
					numAttributes = (uint)value.Length;
				}
				else
				{
					numAttributes = 0uL;
				}
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				if (value.Length > 63)
				{
					throw new NpToolkitException("The size of the name string is more than " + 63 + " characters.");
				}
				name = value;
			}
		}

		public NpMatching2SessionPassword Password
		{
			get
			{
				return password;
			}
			set
			{
				password = value;
			}
		}

		public RoomVisibility Visibility
		{
			get
			{
				return visibility;
			}
			set
			{
				visibility = value;
			}
		}

		public uint NumReservedSlots
		{
			get
			{
				return numReservedSlots;
			}
			set
			{
				numReservedSlots = value;
			}
		}

		public byte[] FixedData
		{
			get
			{
				return fixedData;
			}
			set
			{
				if (value.Length > 1047552)
				{
					throw new NpToolkitException("The size of the fixed data array is more than " + 1047552 + " bytes.");
				}
				fixedData = value;
				fixedDataSize = (ulong)((value != null) ? value.Length : 0);
			}
		}

		public byte[] ChangeableData
		{
			get
			{
				return changeableData;
			}
			set
			{
				if (value.Length > 1024)
				{
					throw new NpToolkitException("The size of the changeable data array is more than " + 1024 + " bytes.");
				}
				changeableData = value;
				changeableDataSize = (ulong)((value != null) ? value.Length : 0);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set
			{
				if (value.Length > 255)
				{
					throw new NpToolkitException("The size of the status string is more than " + 255 + " characters.");
				}
				status = value;
			}
		}

		public LocalizedSessionInfo[] Localizations
		{
			get
			{
				LocalizedSessionInfo[] array = new LocalizedSessionInfo[10];
				Array.Copy(localizations, array, 10);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 10)
					{
						throw new NpToolkitException("The size of the array is more than " + 10);
					}
					value.CopyTo(localizations, 0);
				}
			}
		}

		public SessionImage Image
		{
			get
			{
				return image;
			}
			set
			{
				image = value;
			}
		}

		public bool DisplayOnSystem
		{
			get
			{
				return displayOnSystem;
			}
			set
			{
				displayOnSystem = value;
			}
		}

		public bool IsSystemJoinable
		{
			get
			{
				return isSystemJoinable;
			}
			set
			{
				isSystemJoinable = value;
			}
		}

		public bool JoinAllLocalUsers
		{
			get
			{
				return joinAllLocalUsers;
			}
			set
			{
				joinAllLocalUsers = value;
			}
		}

		public bool IsNatRestricted
		{
			get
			{
				return isNatRestricted;
			}
			set
			{
				isNatRestricted = value;
			}
		}

		public RoomMigrationType OwnershipMigration
		{
			get
			{
				return ownershipMigration;
			}
			set
			{
				ownershipMigration = value;
			}
		}

		public TopologyType Topology
		{
			get
			{
				return topology;
			}
			set
			{
				topology = value;
			}
		}

		public uint MaxNumMembers
		{
			get
			{
				return maxNumMembers;
			}
			set
			{
				maxNumMembers = value;
			}
		}

		public NpMatching2WorldNumber WorldNumber
		{
			get
			{
				return worldNumber;
			}
			set
			{
				worldNumber = value;
			}
		}

		public bool IsCrossplatform
		{
			get
			{
				return isCrossplatform;
			}
			set
			{
				isCrossplatform = value;
			}
		}

		public bool AllowBlockedUsersOfOwner
		{
			get
			{
				return allowBlockedUsersOfOwner;
			}
			set
			{
				allowBlockedUsersOfOwner = value;
			}
		}

		public bool AllowBlockedUsersOfMembers
		{
			get
			{
				return allowBlockedUsersOfMembers;
			}
			set
			{
				allowBlockedUsersOfMembers = value;
			}
		}

		public CreateRoomRequest()
			: base(ServiceTypes.Matching, FunctionTypes.MatchingCreateRoom)
		{
			numReservedSlots = 0u;
			displayOnSystem = true;
			isSystemJoinable = true;
			joinAllLocalUsers = false;
			isNatRestricted = false;
			ownershipMigration = RoomMigrationType.OwnerBind;
			topology = TopologyType.None;
			worldNumber.num = 1;
			isCrossplatform = false;
			allowBlockedUsersOfOwner = false;
			allowBlockedUsersOfMembers = true;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class LeaveRoomRequest : RequestBase
	{
		internal ulong roomId;

		internal PresenceOptionData notificationDataToMembers;

		public ulong RoomId
		{
			get
			{
				return roomId;
			}
			set
			{
				roomId = value;
			}
		}

		public PresenceOptionData NotificationDataToMembers
		{
			get
			{
				return notificationDataToMembers;
			}
			set
			{
				notificationDataToMembers = value;
			}
		}

		public LeaveRoomRequest()
			: base(ServiceTypes.Matching, FunctionTypes.MatchingLeaveRoom)
		{
			notificationDataToMembers.Init();
		}
	}

	public enum RoomsSearchScope
	{
		All,
		FriendsRooms,
		RecentlyMetRooms,
		CustomUsersList
	}

	[StructLayout(LayoutKind.Sequential)]
	public class SearchRoomsRequest : RequestBase
	{
		public const int MAX_SEARCH_CLAUSES = 64;

		public const int MAX_PAGE_SIZE = 20;

		public const int MIN_OFFSET = 1;

		public const int MAX_NUM_USERS_TO_SEARCH_IN_ROOMS = 20;

		internal ulong numSearchClauses;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		internal SearchClause[] searchClauses = new SearchClause[64];

		internal ulong numUsersToSearchInRooms;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
		internal Core.NpAccountId[] usersToSearchInRooms = new Core.NpAccountId[20];

		internal int offset;

		internal int pageSize;

		internal RoomsSearchScope searchScope;

		internal NpMatching2WorldNumber worldNumber;

		[MarshalAs(UnmanagedType.I1)]
		internal bool provideRandomRooms;

		[MarshalAs(UnmanagedType.I1)]
		internal bool quickJoin;

		[MarshalAs(UnmanagedType.I1)]
		internal bool applyNatTypeFilter;

		public SearchClause[] SearchClauses
		{
			get
			{
				if (numSearchClauses == 0)
				{
					return null;
				}
				SearchClause[] array = new SearchClause[numSearchClauses];
				Array.Copy(searchClauses, array, (int)numSearchClauses);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 64)
					{
						throw new NpToolkitException("The size of the array is more than " + 64);
					}
					value.CopyTo(searchClauses, 0);
					numSearchClauses = (uint)value.Length;
				}
				else
				{
					numSearchClauses = 0uL;
				}
			}
		}

		public Core.NpAccountId[] UsersToSearchInRooms
		{
			get
			{
				if (numUsersToSearchInRooms == 0)
				{
					return null;
				}
				Core.NpAccountId[] array = new Core.NpAccountId[numUsersToSearchInRooms];
				Array.Copy(usersToSearchInRooms, array, (int)numUsersToSearchInRooms);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 20)
					{
						throw new NpToolkitException("The size of the array is larger than " + 20);
					}
					value.CopyTo(usersToSearchInRooms, 0);
					numUsersToSearchInRooms = (ulong)value.Length;
				}
				else
				{
					numUsersToSearchInRooms = 0uL;
				}
			}
		}

		public int Offset
		{
			get
			{
				return offset;
			}
			set
			{
				offset = value;
			}
		}

		public int PageSize
		{
			get
			{
				return pageSize;
			}
			set
			{
				pageSize = value;
			}
		}

		public RoomsSearchScope SearchScope
		{
			get
			{
				return searchScope;
			}
			set
			{
				searchScope = value;
			}
		}

		public NpMatching2WorldNumber WorldNumber
		{
			get
			{
				return worldNumber;
			}
			set
			{
				worldNumber = value;
			}
		}

		public bool ProvideRandomRooms
		{
			get
			{
				return provideRandomRooms;
			}
			set
			{
				provideRandomRooms = value;
			}
		}

		public bool QuickJoin
		{
			get
			{
				return quickJoin;
			}
			set
			{
				quickJoin = value;
			}
		}

		public bool ApplyNatTypeFilter
		{
			get
			{
				return applyNatTypeFilter;
			}
			set
			{
				applyNatTypeFilter = value;
			}
		}

		public SearchRoomsRequest()
			: base(ServiceTypes.Matching, FunctionTypes.MatchingSearchRooms)
		{
			offset = 1;
			pageSize = 20;
			worldNumber.num = 1;
			provideRandomRooms = false;
			quickJoin = false;
			applyNatTypeFilter = true;
		}
	}

	public enum RoomJoiningType
	{
		Room,
		BoundSessionId
	}

	[StructLayout(LayoutKind.Sequential)]
	public class JoinRoomRequest : RequestBase
	{
		public const int MAX_ATTRIBUTES = 64;

		internal NpMatching2SessionPassword password;

		internal ulong numMemberAttributes;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		internal Attribute[] memberAttributes = new Attribute[64];

		internal PresenceOptionData notificationDataToMembers;

		internal ulong roomId;

		internal NpSessionId boundSessionId;

		internal RoomJoiningType identifyRoomBy;

		[MarshalAs(UnmanagedType.I1)]
		internal bool joinAllLocalUsers;

		[MarshalAs(UnmanagedType.I1)]
		internal bool allowBlockedUsers;

		public NpMatching2SessionPassword Password
		{
			get
			{
				return password;
			}
			set
			{
				password = value;
			}
		}

		public Attribute[] MemberAttributes
		{
			get
			{
				if (numMemberAttributes == 0)
				{
					return null;
				}
				Attribute[] array = new Attribute[numMemberAttributes];
				Array.Copy(memberAttributes, array, (int)numMemberAttributes);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 64)
					{
						throw new NpToolkitException("The size of the array is larger than " + 64);
					}
					value.CopyTo(memberAttributes, 0);
					numMemberAttributes = (ulong)value.Length;
				}
				else
				{
					numMemberAttributes = 0uL;
				}
			}
		}

		public PresenceOptionData NotificationDataToMembers
		{
			get
			{
				return notificationDataToMembers;
			}
			set
			{
				notificationDataToMembers = value;
			}
		}

		public ulong RoomId
		{
			get
			{
				return roomId;
			}
			set
			{
				if (identifyRoomBy != RoomJoiningType.Room)
				{
					throw new NpToolkitException("Can't set RoomId if IdentifyRoomBy isn't RoomJoiningType.Room.");
				}
				roomId = value;
			}
		}

		public NpSessionId BoundSessionId
		{
			get
			{
				return boundSessionId;
			}
			set
			{
				if (identifyRoomBy != RoomJoiningType.BoundSessionId)
				{
					throw new NpToolkitException("Can't set BoundSessionId if IdentifyRoomBy isn't RoomJoiningType.BoundSessionId.");
				}
				boundSessionId = value;
			}
		}

		public RoomJoiningType IdentifyRoomBy
		{
			get
			{
				return identifyRoomBy;
			}
			set
			{
				identifyRoomBy = value;
			}
		}

		public bool JoinAllLocalUsers
		{
			get
			{
				return joinAllLocalUsers;
			}
			set
			{
				joinAllLocalUsers = value;
			}
		}

		public bool AllowBlockedUsers
		{
			get
			{
				return allowBlockedUsers;
			}
			set
			{
				allowBlockedUsers = value;
			}
		}

		public JoinRoomRequest()
			: base(ServiceTypes.Matching, FunctionTypes.MatchingJoinRoom)
		{
			joinAllLocalUsers = false;
			allowBlockedUsers = true;
			notificationDataToMembers.Init();
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetRoomPingTimeRequest : RequestBase
	{
		internal ulong roomId;

		public ulong RoomId
		{
			get
			{
				return roomId;
			}
			set
			{
				roomId = value;
			}
		}

		public GetRoomPingTimeRequest()
			: base(ServiceTypes.Matching, FunctionTypes.MatchingGetRoomPingTime)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class KickOutRoomMemberRequest : RequestBase
	{
		internal ulong roomId;

		internal PresenceOptionData notificationDataToMembers;

		internal ushort memberId;

		[MarshalAs(UnmanagedType.I1)]
		internal bool allowRejoin;

		public ulong RoomId
		{
			get
			{
				return roomId;
			}
			set
			{
				roomId = value;
			}
		}

		public PresenceOptionData NotificationDataToMembers
		{
			get
			{
				return notificationDataToMembers;
			}
			set
			{
				if (value.data == null || value.length != 16)
				{
					notificationDataToMembers.Init();
				}
				notificationDataToMembers = value;
			}
		}

		public ushort MemberId
		{
			get
			{
				return memberId;
			}
			set
			{
				memberId = value;
			}
		}

		public bool AllowRejoin
		{
			get
			{
				return allowRejoin;
			}
			set
			{
				allowRejoin = value;
			}
		}

		public KickOutRoomMemberRequest()
			: base(ServiceTypes.Matching, FunctionTypes.MatchingKickOutRoomMember)
		{
			notificationDataToMembers.Init();
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class SendRoomMessageRequest : RequestBase
	{
		public const int MESSAGE_MAX_SIZE = 1023;

		public const int MAX_MEMBERS = 32;

		internal ulong roomId;

		internal ulong numMembers;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		internal ushort[] members = new ushort[32];

		internal ulong dataSize;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
		internal byte[] data = new byte[1024];

		[MarshalAs(UnmanagedType.I1)]
		internal bool isChatMsg;

		public ulong RoomId
		{
			get
			{
				return roomId;
			}
			set
			{
				roomId = value;
			}
		}

		public ushort[] Members
		{
			get
			{
				if (numMembers == 0)
				{
					return null;
				}
				ushort[] array = new ushort[numMembers];
				Array.Copy(members, array, (int)numMembers);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 32)
					{
						throw new NpToolkitException("The size of the array is larger than " + 32);
					}
					value.CopyTo(members, 0);
					numMembers = (ulong)value.Length;
				}
				else
				{
					numMembers = 0uL;
				}
			}
		}

		public byte[] Data
		{
			get
			{
				if (dataSize == 0)
				{
					return null;
				}
				byte[] array = new byte[dataSize];
				Array.Copy(data, array, (int)dataSize);
				return array;
			}
			set
			{
				if (data == null)
				{
					data = new byte[1023];
				}
				if (value != null)
				{
					if (value.Length > 1023)
					{
						throw new NpToolkitException("The size of the data array is more than " + 1023);
					}
					value.CopyTo(data, 0);
					dataSize = (byte)value.Length;
				}
				else
				{
					dataSize = 0uL;
				}
			}
		}

		public string DataAsString
		{
			get
			{
				if (dataSize == 0)
				{
					return "";
				}
				return Encoding.UTF8.GetString(data, 0, (int)dataSize);
			}
			set
			{
				if (data == null)
				{
					data = new byte[1023];
				}
				if (value != null)
				{
					byte[] bytes = Encoding.UTF8.GetBytes(value);
					if (bytes.Length > 1023)
					{
						throw new NpToolkitException("The size of the string is more than " + 1023 + " bytes.");
					}
					bytes.CopyTo(data, 0);
					dataSize = (byte)bytes.Length;
				}
				else
				{
					if (data == null)
					{
						data = new byte[1023];
					}
					dataSize = 0uL;
				}
			}
		}

		public bool IsChatMsg
		{
			get
			{
				return isChatMsg;
			}
			set
			{
				isChatMsg = value;
			}
		}

		public SendRoomMessageRequest()
			: base(ServiceTypes.Matching, FunctionTypes.MatchingSendRoomMessage)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetAttributesRequest : RequestBase
	{
		internal ulong roomId;

		internal AttributeScope scope;

		internal RoomAttributeVisibility roomAttributeVisibility;

		internal ushort memberId;

		public ulong RoomId
		{
			get
			{
				return roomId;
			}
			set
			{
				roomId = value;
			}
		}

		public AttributeScope Scope => scope;

		public RoomAttributeVisibility RoomAttributeVisibility
		{
			get
			{
				return roomAttributeVisibility;
			}
			set
			{
				roomAttributeVisibility = value;
				scope = AttributeScope.Room;
			}
		}

		public ushort MemberId
		{
			get
			{
				return memberId;
			}
			set
			{
				memberId = value;
				scope = AttributeScope.Member;
			}
		}

		public GetAttributesRequest()
			: base(ServiceTypes.Matching, FunctionTypes.MatchingGetAttributes)
		{
		}
	}

	public enum DataType
	{
		Fixed,
		Changeable
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetDataRequest : RequestBase
	{
		internal ulong roomId;

		internal DataType type;

		public ulong RoomId
		{
			get
			{
				return roomId;
			}
			set
			{
				roomId = value;
			}
		}

		public DataType Type
		{
			get
			{
				return type;
			}
			set
			{
				type = value;
			}
		}

		public GetDataRequest()
			: base(ServiceTypes.Matching, FunctionTypes.MatchingGetData)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class SendInvitationRequest : RequestBase
	{
		public const int MAX_SIZE_ATTACHMENT = 1048576;

		public const int MAX_NUM_RECIPIENTS = 16;

		public const int MAX_SIZE_USER_MESSAGE = 511;

		internal ulong roomId;

		internal ulong numRecipients;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		internal Core.NpAccountId[] recipients = new Core.NpAccountId[16];

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
		internal string userMessage;

		internal ulong attachmentSize;

		[MarshalAs(UnmanagedType.LPArray)]
		internal byte[] attachment;

		internal int maxNumberRecipientsToAdd;

		[MarshalAs(UnmanagedType.I1)]
		internal bool recipientsEditableByUser;

		[MarshalAs(UnmanagedType.I1)]
		internal bool enableDialog;

		public ulong RoomId
		{
			get
			{
				return roomId;
			}
			set
			{
				roomId = value;
			}
		}

		public Core.NpAccountId[] Recipients
		{
			get
			{
				if (numRecipients == 0)
				{
					return null;
				}
				Core.NpAccountId[] array = new Core.NpAccountId[numRecipients];
				Array.Copy(recipients, array, (int)numRecipients);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 16)
					{
						throw new NpToolkitException("The size of the array is larger than " + 16);
					}
					value.CopyTo(recipients, 0);
					numRecipients = (ulong)value.Length;
				}
				else
				{
					numRecipients = 0uL;
				}
			}
		}

		public string UserMessage
		{
			get
			{
				return userMessage;
			}
			set
			{
				if (value.Length > 511)
				{
					throw new NpToolkitException("The size of the user message string is more than " + 511 + " characters.");
				}
				userMessage = value;
			}
		}

		public byte[] Attachment
		{
			get
			{
				return attachment;
			}
			set
			{
				if (value.Length > 1048576)
				{
					throw new NpToolkitException("The size of the attachment array is more than " + 1048576);
				}
				attachment = value;
				attachmentSize = (byte)value.Length;
			}
		}

		public int MaxNumberRecipientsToAdd
		{
			get
			{
				return maxNumberRecipientsToAdd;
			}
			set
			{
				maxNumberRecipientsToAdd = value;
			}
		}

		public bool RecipientsEditableByUser
		{
			get
			{
				return recipientsEditableByUser;
			}
			set
			{
				recipientsEditableByUser = value;
			}
		}

		public bool EnableDialog
		{
			get
			{
				return enableDialog;
			}
			set
			{
				enableDialog = value;
			}
		}

		public SendInvitationRequest()
			: base(ServiceTypes.Matching, FunctionTypes.MatchingSendInvitation)
		{
		}
	}

	public enum SetRoomInfoType
	{
		Invalid,
		MemberInfo,
		RoomExternalInfo,
		RoomInternalInfo,
		RoomSessionInfo,
		RoomTopology
	}

	[StructLayout(LayoutKind.Sequential)]
	public class SetRoomInfoRequest : RequestBase
	{
		public struct MemberInformation
		{
			internal ulong numMemberAttributes;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
			internal Attribute[] memberAttributes;

			internal ushort memberId;

			public Attribute[] MemberAttributes
			{
				get
				{
					if (numMemberAttributes == 0)
					{
						return null;
					}
					Attribute[] array = new Attribute[numMemberAttributes];
					Array.Copy(memberAttributes, array, (int)numMemberAttributes);
					return array;
				}
				set
				{
					if (memberAttributes == null)
					{
						memberAttributes = new Attribute[8];
					}
					if (value != null)
					{
						if (value.Length > 8)
						{
							throw new NpToolkitException("The size of the attributes array is more than " + 8);
						}
						value.CopyTo(memberAttributes, 0);
						numMemberAttributes = (ulong)value.Length;
					}
					else
					{
						numMemberAttributes = 0uL;
					}
				}
			}

			public ushort MemberId
			{
				get
				{
					return memberId;
				}
				set
				{
					memberId = value;
				}
			}

			internal void Init()
			{
				memberAttributes = new Attribute[8];
			}
		}

		public struct ExternalRoomInformation
		{
			internal ulong numExternalAttributes;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
			internal Attribute[] externalAttributes;

			internal ulong numSearchAttributes;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
			internal Attribute[] searchAttributes;

			public Attribute[] ExternalAttributes
			{
				get
				{
					if (numExternalAttributes == 0)
					{
						return null;
					}
					Attribute[] array = new Attribute[numExternalAttributes];
					Array.Copy(externalAttributes, array, (int)numExternalAttributes);
					return array;
				}
				set
				{
					if (externalAttributes == null)
					{
						externalAttributes = new Attribute[64];
					}
					if (value != null)
					{
						if (value.Length > 64)
						{
							throw new NpToolkitException("The size of the attributes array is more than " + 64);
						}
						value.CopyTo(externalAttributes, 0);
						numExternalAttributes = (ulong)value.Length;
					}
					else
					{
						numExternalAttributes = 0uL;
					}
				}
			}

			public Attribute[] SearchAttributes
			{
				get
				{
					if (numSearchAttributes == 0)
					{
						return null;
					}
					Attribute[] array = new Attribute[numSearchAttributes];
					Array.Copy(searchAttributes, array, (int)numSearchAttributes);
					return array;
				}
				set
				{
					if (searchAttributes == null)
					{
						searchAttributes = new Attribute[64];
					}
					if (value != null)
					{
						if (value.Length > 64)
						{
							throw new NpToolkitException("The size of the attributes array is more than " + 64);
						}
						value.CopyTo(searchAttributes, 0);
						numSearchAttributes = (ulong)value.Length;
					}
					else
					{
						numSearchAttributes = 0uL;
					}
				}
			}

			internal void Init()
			{
				externalAttributes = new Attribute[64];
				searchAttributes = new Attribute[64];
			}
		}

		public struct InternalRoomInformation
		{
			internal ulong numInternalAttributes;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
			internal Attribute[] internalAttributes;

			internal Core.OptionalBoolean allowBlockedUsersOfMembers;

			internal Core.OptionalBoolean joinAllLocalUsers;

			internal Core.OptionalBoolean isNatRestricted;

			internal uint numReservedSlots;

			internal RoomVisibility visibility;

			internal Core.OptionalBoolean closeRoom;

			public Attribute[] InternalAttributes
			{
				get
				{
					if (numInternalAttributes == 0)
					{
						return null;
					}
					Attribute[] array = new Attribute[numInternalAttributes];
					Array.Copy(internalAttributes, array, (int)numInternalAttributes);
					return array;
				}
				set
				{
					if (internalAttributes == null)
					{
						internalAttributes = new Attribute[64];
					}
					if (value != null)
					{
						if (value.Length > 64)
						{
							throw new NpToolkitException("The size of the attributes array is more than " + 64);
						}
						value.CopyTo(internalAttributes, 0);
						numInternalAttributes = (ulong)value.Length;
					}
					else
					{
						numInternalAttributes = 0uL;
					}
				}
			}

			public Core.OptionalBoolean AllowBlockedUsersOfMembers
			{
				get
				{
					return allowBlockedUsersOfMembers;
				}
				set
				{
					allowBlockedUsersOfMembers = value;
				}
			}

			public Core.OptionalBoolean JoinAllLocalUsers
			{
				get
				{
					return joinAllLocalUsers;
				}
				set
				{
					joinAllLocalUsers = value;
				}
			}

			public Core.OptionalBoolean IsNatRestricted
			{
				get
				{
					return isNatRestricted;
				}
				set
				{
					isNatRestricted = value;
				}
			}

			public uint NumReservedSlots
			{
				get
				{
					return numReservedSlots;
				}
				set
				{
					numReservedSlots = value;
				}
			}

			public RoomVisibility Visibility
			{
				get
				{
					return visibility;
				}
				set
				{
					visibility = value;
				}
			}

			public Core.OptionalBoolean CloseRoom
			{
				get
				{
					return closeRoom;
				}
				set
				{
					closeRoom = value;
				}
			}

			internal void Init()
			{
				internalAttributes = new Attribute[64];
			}
		}

		public struct RoomSessionInformation
		{
			internal Core.OptionalBoolean displayOnSystem;

			internal Core.OptionalBoolean isSystemJoinable;

			internal ulong changeableDataSize;

			[MarshalAs(UnmanagedType.LPArray)]
			internal byte[] changeableData;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
			internal string status;

			internal ulong numLocalizations;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
			internal LocalizedSessionInfo[] localizations;

			internal SessionImage image;

			public Core.OptionalBoolean DisplayOnSystem
			{
				get
				{
					return displayOnSystem;
				}
				set
				{
					displayOnSystem = value;
				}
			}

			public Core.OptionalBoolean IsSystemJoinable
			{
				get
				{
					return isSystemJoinable;
				}
				set
				{
					isSystemJoinable = value;
				}
			}

			public byte[] ChangeableData
			{
				get
				{
					return changeableData;
				}
				set
				{
					if (value.Length > 1024)
					{
						throw new NpToolkitException("The size of the changeable data array is more than " + 1024 + " bytes.");
					}
					changeableData = value;
					changeableDataSize = (ulong)value.Length;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set
				{
					if (value.Length > 255)
					{
						throw new NpToolkitException("The size of the status string is more than " + 255 + " characters.");
					}
					status = value;
				}
			}

			public LocalizedSessionInfo[] Localizations
			{
				get
				{
					if (numLocalizations == 0)
					{
						return null;
					}
					LocalizedSessionInfo[] array = new LocalizedSessionInfo[numLocalizations];
					Array.Copy(localizations, array, (int)numLocalizations);
					return array;
				}
				set
				{
					if (value != null)
					{
						if (value.Length > 10)
						{
							throw new NpToolkitException("The size of the localization array is more than " + 10);
						}
						value.CopyTo(localizations, 0);
						numLocalizations = (ulong)value.Length;
					}
					else
					{
						numLocalizations = 0uL;
					}
				}
			}

			public SessionImage Image
			{
				get
				{
					return image;
				}
				set
				{
					image = value;
				}
			}

			internal void Init()
			{
				localizations = new LocalizedSessionInfo[10];
			}
		}

		public const int MAX_MEMBER_ATTRIBUTES = 8;

		public const int MAX_ATTRIBUTES = 64;

		internal ulong roomId;

		internal SetRoomInfoType roomInfoType;

		internal MemberInformation memberInfo;

		internal ExternalRoomInformation externalRoomInfo;

		internal InternalRoomInformation internalRoomInfo;

		internal RoomSessionInformation roomSessionInfo;

		internal TopologyType roomTopology;

		public ulong RoomId
		{
			get
			{
				return roomId;
			}
			set
			{
				roomId = value;
			}
		}

		public SetRoomInfoType RoomInfoType
		{
			get
			{
				return roomInfoType;
			}
			set
			{
				roomInfoType = value;
			}
		}

		public MemberInformation MemberInfo
		{
			get
			{
				return memberInfo;
			}
			set
			{
				memberInfo = value;
			}
		}

		public ExternalRoomInformation ExternalRoomInfo
		{
			get
			{
				return externalRoomInfo;
			}
			set
			{
				externalRoomInfo = value;
			}
		}

		public InternalRoomInformation InternalRoomInfo
		{
			get
			{
				return internalRoomInfo;
			}
			set
			{
				internalRoomInfo = value;
			}
		}

		public RoomSessionInformation RoomSessionInfo
		{
			get
			{
				return roomSessionInfo;
			}
			set
			{
				roomSessionInfo = value;
			}
		}

		public TopologyType RoomTopology
		{
			get
			{
				return roomTopology;
			}
			set
			{
				roomTopology = value;
			}
		}

		public SetRoomInfoRequest()
			: base(ServiceTypes.Matching, FunctionTypes.MatchingSetRoomInfo)
		{
			memberInfo.Init();
			externalRoomInfo.Init();
			internalRoomInfo.Init();
			roomSessionInfo.Init();
		}
	}

	public struct NpMatching2SessionPassword
	{
		public const int NP_MATCHING2_SESSION_PASSWORD_SIZE = 8;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
		internal string password;

		public string Password
		{
			get
			{
				return password;
			}
			set
			{
				if (value.Length > 8)
				{
					throw new NpToolkitException("The size of the password string is more than " + 8 + " characters.");
				}
				password = value;
			}
		}

		internal void Read(MemoryBuffer buffer)
		{
			buffer.ReadString(ref password);
		}

		public override string ToString()
		{
			return password;
		}

		public static implicit operator NpMatching2SessionPassword(string value)
		{
			return new NpMatching2SessionPassword
			{
				Password = value
			};
		}
	}

	public struct NpSessionId
	{
		public const int NP_SESSION_ID_MAX_SIZE = 45;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 46)]
		internal string data;

		public string Data => data;

		internal void Read(MemoryBuffer buffer)
		{
			buffer.ReadString(ref data);
		}

		public override string ToString()
		{
			return data;
		}
	}

	public struct NpMatching2WorldId
	{
		internal uint id;

		public uint Id
		{
			get
			{
				return id;
			}
			set
			{
				id = value;
			}
		}

		internal void Read(MemoryBuffer buffer)
		{
			id = buffer.ReadUInt32();
		}
	}

	public struct NpMatching2WorldNumber
	{
		internal ushort num;

		public ushort Num
		{
			get
			{
				return num;
			}
			set
			{
				num = value;
			}
		}

		internal void Read(MemoryBuffer buffer)
		{
			num = buffer.ReadUInt16();
		}

		public static implicit operator NpMatching2WorldNumber(ushort value)
		{
			return new NpMatching2WorldNumber
			{
				num = value
			};
		}
	}

	public struct World
	{
		internal NpMatching2WorldId worldId;

		internal uint currentNumberOfRooms;

		internal uint currentNumberOfMembers;

		internal NpMatching2WorldNumber worldNumber;

		public NpMatching2WorldId WorldId => worldId;

		public uint CurrentNumberOfRooms => currentNumberOfRooms;

		public uint CurrentNumberOfMembers => currentNumberOfMembers;

		public NpMatching2WorldNumber WorldNumber => worldNumber;

		internal void Read(MemoryBuffer buffer)
		{
			worldId.Read(buffer);
			currentNumberOfRooms = buffer.ReadUInt32();
			currentNumberOfMembers = buffer.ReadUInt32();
			worldNumber.Read(buffer);
		}
	}

	public enum SignalingStatus
	{
		NotApplicable,
		Established,
		EstablishedFailToGetInformation,
		Dead
	}

	public enum NatType
	{
		Invalid,
		NatType1,
		NatType2,
		NatType3
	}

	public class MemberSignalingInformation
	{
		internal NatType natType;

		internal SignalingStatus status;

		internal uint roundTripTime;

		internal NetworkUtils.NetInAddr ipAddress;

		internal ushort port;

		internal ushort portNetworkOrder;

		public NatType NatType => natType;

		public SignalingStatus Status => status;

		public uint RoundTripTime => roundTripTime;

		public NetworkUtils.NetInAddr IpAddress => ipAddress;

		public ushort Port => port;

		public ushort PortNetworkOrder => portNetworkOrder;

		internal void Read(MemoryBuffer buffer)
		{
			natType = (NatType)buffer.ReadUInt32();
			status = (SignalingStatus)buffer.ReadUInt32();
			roundTripTime = buffer.ReadUInt32();
			ipAddress.Read(buffer);
			port = buffer.ReadUInt16();
			portNetworkOrder = buffer.ReadUInt16();
		}
	}

	public class Member
	{
		internal Core.OnlineUser onlineUser = new Core.OnlineUser();

		internal Attribute[] memberAttributes;

		internal DateTime joinedDate;

		internal MemberSignalingInformation signalingInformation = new MemberSignalingInformation();

		internal Core.PlatformType platform;

		internal ushort roomMemberId;

		internal bool isOwner;

		internal bool isMe;

		public Core.OnlineUser OnlineUser => onlineUser;

		public Attribute[] MemberAttributes => memberAttributes;

		public DateTime JoinedDate => joinedDate;

		public MemberSignalingInformation SignalingInformation => signalingInformation;

		public Core.PlatformType Platform => platform;

		public ushort RoomMemberId => roomMemberId;

		public bool IsOwner => isOwner;

		public bool IsMe => isMe;

		internal void Read(MemoryBuffer buffer)
		{
			onlineUser.Read(buffer);
			ulong num = buffer.ReadUInt64();
			memberAttributes = new Attribute[num];
			for (ulong num2 = 0uL; num2 < num; num2++)
			{
				memberAttributes[num2].Read(buffer);
			}
			joinedDate = Core.ReadRtcTick(buffer);
			signalingInformation.Read(buffer);
			platform = (Core.PlatformType)buffer.ReadUInt32();
			roomMemberId = buffer.ReadUInt16();
			isOwner = buffer.ReadBool();
			isMe = buffer.ReadBool();
		}
	}

	public class Room
	{
		internal ushort matchingContext;

		internal ushort serverId;

		internal uint worldId;

		internal ulong roomId;

		internal Attribute[] attributes;

		internal string name;

		internal Member[] currentMembers;

		internal ulong numMaxMembers;

		internal TopologyType topology;

		internal uint numReservedSlots;

		internal bool isNatRestricted;

		internal bool allowBlockedUsersOfOwner;

		internal bool allowBlockedUsersOfMembers;

		internal bool joinAllLocalUsers;

		internal RoomMigrationType ownershipMigration;

		internal RoomVisibility visibility;

		internal NpMatching2SessionPassword password;

		internal NpSessionId boundSessionId;

		internal bool isSystemJoinable;

		internal bool displayOnSystem;

		internal bool hasChangeableData;

		internal bool hasFixedData;

		internal bool isCrossplatform;

		internal bool isClosed;

		public ushort MatchingContext => matchingContext;

		public ushort ServerId => serverId;

		public uint WorldId => worldId;

		public ulong RoomId => roomId;

		public Attribute[] Attributes => attributes;

		public string Name => name;

		public Member[] CurrentMembers => currentMembers;

		public ulong NumMaxMembers => numMaxMembers;

		public TopologyType Topology => topology;

		public uint NumReservedSlots => numReservedSlots;

		public bool IsNatRestricted => isNatRestricted;

		public bool AllowBlockedUsersOfOwner => allowBlockedUsersOfOwner;

		public bool AllowBlockedUsersOfMembers => allowBlockedUsersOfMembers;

		public bool JoinAllLocalUsers => joinAllLocalUsers;

		public RoomMigrationType OwnershipMigration => ownershipMigration;

		public RoomVisibility Visibility => visibility;

		public NpMatching2SessionPassword Password => password;

		public NpSessionId BoundSessionId => boundSessionId;

		public bool IsSystemJoinable => isSystemJoinable;

		public bool DisplayOnSystem => displayOnSystem;

		public bool HasChangeableData => hasChangeableData;

		public bool HasFixedData => hasFixedData;

		public bool IsCrossplatform => isCrossplatform;

		public bool IsClosed => isClosed;

		public ushort FindRoomMemberId(Core.NpAccountId accountId)
		{
			if (currentMembers == null)
			{
				return 0;
			}
			for (int i = 0; i < currentMembers.Length; i++)
			{
				if (currentMembers[i].OnlineUser.accountId == accountId)
				{
					return currentMembers[i].roomMemberId;
				}
			}
			return 0;
		}

		public ushort FindRoomMemberId(Core.OnlineID onlineId)
		{
			if (currentMembers == null)
			{
				return 0;
			}
			for (int i = 0; i < currentMembers.Length; i++)
			{
				if (currentMembers[i].OnlineUser.onlineId == onlineId)
				{
					return currentMembers[i].roomMemberId;
				}
			}
			return 0;
		}

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.RoomBegin);
			matchingContext = buffer.ReadUInt16();
			serverId = buffer.ReadUInt16();
			worldId = buffer.ReadUInt32();
			roomId = buffer.ReadUInt64();
			ulong num = buffer.ReadUInt64();
			attributes = new Attribute[num];
			for (ulong num2 = 0uL; num2 < num; num2++)
			{
				attributes[num2].Read(buffer);
			}
			buffer.ReadString(ref name);
			ulong num3 = buffer.ReadUInt64();
			currentMembers = new Member[num3];
			for (ulong num2 = 0uL; num2 < num3; num2++)
			{
				currentMembers[num2] = new Member();
				currentMembers[num2].Read(buffer);
			}
			numMaxMembers = buffer.ReadUInt64();
			topology = (TopologyType)buffer.ReadUInt32();
			numReservedSlots = buffer.ReadUInt32();
			isNatRestricted = buffer.ReadBool();
			allowBlockedUsersOfOwner = buffer.ReadBool();
			allowBlockedUsersOfMembers = buffer.ReadBool();
			joinAllLocalUsers = buffer.ReadBool();
			ownershipMigration = (RoomMigrationType)buffer.ReadUInt32();
			visibility = (RoomVisibility)buffer.ReadUInt32();
			password.Read(buffer);
			boundSessionId.Read(buffer);
			isSystemJoinable = buffer.ReadBool();
			displayOnSystem = buffer.ReadBool();
			hasChangeableData = buffer.ReadBool();
			hasFixedData = buffer.ReadBool();
			isCrossplatform = buffer.ReadBool();
			isClosed = buffer.ReadBool();
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.RoomEnd);
		}
	}

	public class WorldsResponse : ResponseBase
	{
		internal World[] worlds;

		public World[] Worlds => worlds;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.WorldsBegin);
			ulong num = memoryBuffer.ReadUInt64();
			worlds = new World[num];
			for (ulong num2 = 0uL; num2 < num; num2++)
			{
				worlds[num2].Read(memoryBuffer);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.WorldsEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class RoomResponse : ResponseBase
	{
		internal Room room;

		public Room Room => room;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.CreateRoomBegin);
			room = new Room();
			room.Read(memoryBuffer);
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.CreateRoomEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class RoomsResponse : ResponseBase
	{
		internal Room[] rooms;

		public Room[] Rooms => rooms;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.RoomsBegin);
			ulong num = memoryBuffer.ReadUInt64();
			rooms = new Room[num];
			for (ulong num2 = 0uL; num2 < num; num2++)
			{
				rooms[num2] = new Room();
				rooms[num2].Read(memoryBuffer);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.RoomsEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class GetRoomPingTimeResponse : ResponseBase
	{
		private uint roundTripTime;

		public uint RoundTripTime => roundTripTime;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.RoomPingTimeBegin);
			roundTripTime = memoryBuffer.ReadUInt32();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.RoomPingTimeEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class GetDataResponse : ResponseBase
	{
		internal byte[] data;

		internal DataType type;

		public byte[] Data => data;

		public DataType Type => type;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.GetDataBegin);
			type = (DataType)memoryBuffer.ReadUInt32();
			memoryBuffer.ReadData(ref data);
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.GetDataEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public enum Reasons
	{
		MemberJoined,
		MemberLeft,
		MemberSignalingUpdate,
		MemberInfoUpdated,
		OwnerChanged,
		RoomDestroyed,
		RoomKickedOut,
		RoomExternalInfoUpdated,
		RoomInternalInfoUpdated,
		RoomTopologyUpdated,
		RoomSessionInfoUpdated
	}

	public enum Causes
	{
		Unknown = 1,
		LeaveAction = 1,
		KickoutAction = 2,
		GrantOwnerAction = 3,
		ServerOperation = 4,
		MemberDisappeared = 5,
		ServerInternal = 6,
		ConnectionError = 7,
		SignedOut = 8,
		SystemError = 9,
		ContextError = 10,
		ContextAction = 11
	}

	public class RefreshRoomResponse : ResponseBase
	{
		public class OwnerInformation
		{
			public const int OWNER_EXCHANGE_SIZE = 2;

			internal NpMatching2SessionPassword password;

			internal ushort[] oldAndNewOwners;

			public NpMatching2SessionPassword Password => password;

			public ushort[] OldAndNewOwners => oldAndNewOwners;

			internal void Read(MemoryBuffer buffer)
			{
				password.Read(buffer);
				for (int i = 0; i < 2; i++)
				{
					oldAndNewOwners[i] = buffer.ReadUInt16();
				}
			}

			internal OwnerInformation()
			{
				oldAndNewOwners = new ushort[2];
			}
		}

		public class RoomExternalInformation
		{
			internal Attribute[] attributes;

			public Attribute[] Attributes => attributes;

			internal void Read(MemoryBuffer buffer)
			{
				ulong num = buffer.ReadUInt64();
				attributes = new Attribute[num];
				for (ulong num2 = 0uL; num2 < num; num2++)
				{
					attributes[num2] = default(Attribute);
					attributes[num2].Read(buffer);
				}
			}
		}

		public class RoomInternalInformation
		{
			internal Attribute[] attributes;

			internal Core.OptionalBoolean allowBlockedUsersOfMembers;

			internal Core.OptionalBoolean joinAllLocalUsers;

			internal Core.OptionalBoolean isNatRestricted;

			internal uint numReservedSlots;

			internal RoomVisibility visibility;

			internal Core.OptionalBoolean closeRoom;

			public Attribute[] Attributes => attributes;

			public Core.OptionalBoolean AllowBlockedUsersOfMembers => allowBlockedUsersOfMembers;

			public Core.OptionalBoolean JoinAllLocalUsers => joinAllLocalUsers;

			public Core.OptionalBoolean IsNatRestricted => isNatRestricted;

			public uint NumReservedSlots => numReservedSlots;

			public RoomVisibility Visibility => visibility;

			public Core.OptionalBoolean CloseRoom => closeRoom;

			internal void Read(MemoryBuffer buffer)
			{
				ulong num = buffer.ReadUInt64();
				attributes = new Attribute[num];
				for (ulong num2 = 0uL; num2 < num; num2++)
				{
					attributes[num2] = default(Attribute);
					attributes[num2].Read(buffer);
				}
				allowBlockedUsersOfMembers = (Core.OptionalBoolean)buffer.ReadUInt32();
				joinAllLocalUsers = (Core.OptionalBoolean)buffer.ReadUInt32();
				isNatRestricted = (Core.OptionalBoolean)buffer.ReadUInt32();
				numReservedSlots = buffer.ReadUInt32();
				visibility = (RoomVisibility)buffer.ReadUInt32();
				closeRoom = (Core.OptionalBoolean)buffer.ReadUInt32();
			}
		}

		public class RoomSessionInformation
		{
			internal Core.OptionalBoolean displayOnSystem;

			internal Core.OptionalBoolean isSystemJoinable;

			internal Core.OptionalBoolean hasChangeableData;

			internal NpSessionId boundSessionId;

			public Core.OptionalBoolean DisplayOnSystem => displayOnSystem;

			public Core.OptionalBoolean IsSystemJoinable => isSystemJoinable;

			public Core.OptionalBoolean HasChangeableData => hasChangeableData;

			public NpSessionId BoundSessionId => boundSessionId;

			internal void Read(MemoryBuffer buffer)
			{
				displayOnSystem = (Core.OptionalBoolean)buffer.ReadUInt32();
				isSystemJoinable = (Core.OptionalBoolean)buffer.ReadUInt32();
				hasChangeableData = (Core.OptionalBoolean)buffer.ReadUInt32();
				boundSessionId.Read(buffer);
			}
		}

		internal ulong roomId;

		internal PresenceOptionData notificationFromMember;

		internal Reasons reason;

		internal Causes cause;

		internal OwnerInformation ownerInfo;

		internal Member memberInfo;

		internal long roomLeftError;

		internal RoomExternalInformation roomExternalInfo;

		internal RoomInternalInformation roomInternalInfo;

		internal RoomSessionInformation roomSessionInfo;

		internal TopologyType roomTopology;

		public ulong RoomId => roomId;

		public PresenceOptionData NotificationFromMember => notificationFromMember;

		public Reasons Reason => reason;

		public Causes Cause => cause;

		public OwnerInformation OwnerInfo => ownerInfo;

		public Member MemberInfo => memberInfo;

		public long RoomLeftError => roomLeftError;

		public RoomExternalInformation RoomExternalInfo => roomExternalInfo;

		public RoomInternalInformation RoomInternalInfo => roomInternalInfo;

		public RoomSessionInformation RoomSessionInfo => roomSessionInfo;

		public TopologyType RoomTopology => roomTopology;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.RefreshRoomBegin);
			roomId = memoryBuffer.ReadUInt64();
			notificationFromMember.Read(memoryBuffer);
			reason = (Reasons)memoryBuffer.ReadUInt32();
			cause = (Causes)memoryBuffer.ReadUInt32();
			if (reason == Reasons.MemberJoined || reason == Reasons.MemberLeft || reason == Reasons.MemberSignalingUpdate || reason == Reasons.MemberInfoUpdated)
			{
				memberInfo = new Member();
				memberInfo.Read(memoryBuffer);
			}
			else if (reason == Reasons.OwnerChanged)
			{
				ownerInfo = new OwnerInformation();
				ownerInfo.Read(memoryBuffer);
			}
			else if (reason == Reasons.RoomDestroyed || reason == Reasons.RoomKickedOut)
			{
				roomLeftError = memoryBuffer.ReadInt64();
			}
			else if (reason == Reasons.RoomExternalInfoUpdated)
			{
				roomExternalInfo = new RoomExternalInformation();
				roomExternalInfo.Read(memoryBuffer);
			}
			else if (reason == Reasons.RoomInternalInfoUpdated)
			{
				roomInternalInfo = new RoomInternalInformation();
				roomInternalInfo.Read(memoryBuffer);
			}
			else if (reason == Reasons.RoomSessionInfoUpdated)
			{
				roomSessionInfo = new RoomSessionInformation();
				roomSessionInfo.Read(memoryBuffer);
			}
			else if (reason == Reasons.RoomTopologyUpdated)
			{
				roomTopology = (TopologyType)memoryBuffer.ReadUInt32();
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.RefreshRoomEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class NewRoomMessageResponse : ResponseBase
	{
		internal ulong roomId;

		internal byte[] data;

		internal ushort sender;

		internal bool isChatMsg;

		internal bool isFiltered;

		public ulong RoomId => roomId;

		public byte[] Data => data;

		public string DataAsString
		{
			get
			{
				if (!isChatMsg)
				{
					throw new NpToolkitException("Room message data is not a UTF-8 string.");
				}
				if (data == null)
				{
					return "";
				}
				return Encoding.UTF8.GetString(data, 0, data.Length);
			}
		}

		public ushort Sender => sender;

		public bool IsChatMsg => isChatMsg;

		public bool IsFiltered => isFiltered;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NewRoomMessageBegin);
			roomId = memoryBuffer.ReadUInt64();
			memoryBuffer.ReadData(ref data);
			sender = memoryBuffer.ReadUInt16();
			isChatMsg = memoryBuffer.ReadBool();
			isFiltered = memoryBuffer.ReadBool();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NewRoomMessageEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public enum CurrentPlatform
	{
		NotSet,
		PSVita,
		PS4
	}

	public class InvitationReceivedResponse : ResponseBase
	{
		internal Core.OnlineUser localUpdatedUser = new Core.OnlineUser();

		internal Core.OnlineUser remoteUser = new Core.OnlineUser();

		internal CurrentPlatform platform;

		public Core.OnlineUser LocalUpdatedUser => localUpdatedUser;

		public Core.OnlineUser RemoteUser => remoteUser;

		public CurrentPlatform Platform => platform;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.InvitationReceivedBegin);
			localUpdatedUser.Read(memoryBuffer);
			remoteUser.Read(memoryBuffer);
			platform = (CurrentPlatform)memoryBuffer.ReadUInt32();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.InvitationReceivedEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public struct NpInvitationId
	{
		public const int NP_INVITATION_ID_MAX_SIZE = 60;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 60)]
		internal string id;

		public string Id => id;

		internal void Read(MemoryBuffer buffer)
		{
			buffer.ReadString(ref id);
		}

		public override string ToString()
		{
			return id;
		}
	}

	public class SessionInvitationEventResponse : ResponseBase
	{
		internal NpSessionId sessionId;

		internal NpInvitationId invitationId;

		internal bool acceptedInvite;

		internal Core.OnlineID onlineId = new Core.OnlineID();

		internal Core.UserServiceUserId userId;

		internal Core.OnlineID referralOnlineId = new Core.OnlineID();

		internal Core.NpAccountId referralAccountId;

		public NpSessionId SessionId => sessionId;

		public NpInvitationId InvitationId => invitationId;

		public bool AcceptedInvite => acceptedInvite;

		public Core.OnlineID OnlineId => onlineId;

		public Core.UserServiceUserId UserId => userId;

		public Core.OnlineID ReferralOnlineId => referralOnlineId;

		public Core.NpAccountId ReferralAccountId => referralAccountId;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.SessionInvitationEventBegin);
			sessionId.Read(memoryBuffer);
			invitationId.Read(memoryBuffer);
			int num = memoryBuffer.ReadInt32();
			if ((num & 1) != 0)
			{
				acceptedInvite = true;
			}
			onlineId.Read(memoryBuffer);
			userId.Read(memoryBuffer);
			referralOnlineId.Read(memoryBuffer);
			referralAccountId.Read(memoryBuffer);
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.SessionInvitationEventEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public struct NpPlayTogetherInvitee
	{
		internal Core.NpAccountId accountId;

		internal Core.OnlineID onlineId;

		public Core.NpAccountId AccountId => accountId;

		public Core.OnlineID OnlineId => onlineId;

		internal void Read(MemoryBuffer buffer)
		{
			onlineId = new Core.OnlineID();
			accountId.Read(buffer);
			onlineId.Read(buffer);
		}
	}

	public class PlayTogetherHostEventResponse : ResponseBase
	{
		internal Core.UserServiceUserId userId;

		internal NpPlayTogetherInvitee[] invitees;

		public Core.UserServiceUserId UserId => userId;

		public NpPlayTogetherInvitee[] Invitees => invitees;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.PlayTogetherHostEventBegin);
			userId.Read(memoryBuffer);
			uint num = memoryBuffer.ReadUInt32();
			invitees = new NpPlayTogetherInvitee[num];
			for (int i = 0; i < num; i++)
			{
				invitees[i].Read(memoryBuffer);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.PlayTogetherHostEventEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public const int INVALID_ROOM_MEMBER_ID = 0;

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxSetInitConfiguration(SetInitConfigurationRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetWorlds(GetWorldsRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxCreateRoom(CreateRoomRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxLeaveRoom(LeaveRoomRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxSearchRooms(SearchRoomsRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxJoinRoom(JoinRoomRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetRoomPingTime(GetRoomPingTimeRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxKickOutRoomMember(KickOutRoomMemberRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxSendRoomMessage(SendRoomMessageRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetAttributes(GetAttributesRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxSetRoomInfo(SetRoomInfoRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxSendInvitation(SendInvitationRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetData(GetDataRequest request, out APIResult result);

	public static int SetInitConfiguration(SetInitConfigurationRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxSetInitConfiguration(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetWorlds(GetWorldsRequest request, WorldsResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetWorlds(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int CreateRoom(CreateRoomRequest request, RoomResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		if (!request.image.IsValid())
		{
			throw new NpToolkitException("Request Image hasn't be defined. A session can't be created without an image.");
		}
		if (!request.image.Exists())
		{
			throw new NpToolkitException("Request Image doesn't exists. A session can't be created without an image. " + request.image.sessionImgPath);
		}
		if (request.status == null || request.status.Length == 0)
		{
			throw new NpToolkitException("Request Status text doesn't exists. A session can't be created without Status text being set.");
		}
		APIResult result;
		int num = PrxCreateRoom(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int LeaveRoom(LeaveRoomRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxLeaveRoom(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int SearchRooms(SearchRoomsRequest request, RoomsResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxSearchRooms(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int JoinRoom(JoinRoomRequest request, RoomResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxJoinRoom(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetRoomPingTime(GetRoomPingTimeRequest request, GetRoomPingTimeResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetRoomPingTime(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int KickOutRoomMember(KickOutRoomMemberRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxKickOutRoomMember(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int SendRoomMessage(SendRoomMessageRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxSendRoomMessage(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetAttributes(GetAttributesRequest request, RefreshRoomResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetAttributes(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetData(GetDataRequest request, GetDataResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetData(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int SendInvitation(SendInvitationRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxSendInvitation(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int SetRoomInfo(SetRoomInfoRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxSetRoomInfo(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}
}
public class Messaging
{
	[StructLayout(LayoutKind.Sequential)]
	public class SendInGameMessageRequest : RequestBase
	{
		public const int NP_IN_GAME_MESSAGE_DATA_SIZE_MAX = 512;

		internal ulong messageSize;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		internal byte[] message = new byte[512];

		internal Core.NpAccountId recipientId;

		internal Core.PlatformType recipientPlatformType;

		public byte[] Message
		{
			get
			{
				if (messageSize == 0)
				{
					return null;
				}
				byte[] array = new byte[messageSize];
				Array.Copy(message, array, (int)messageSize);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 512)
					{
						throw new NpToolkitException("The size of the array is larger than " + 512);
					}
					value.CopyTo(message, 0);
					messageSize = (ulong)value.Length;
				}
				else
				{
					messageSize = 0uL;
				}
			}
		}

		public Core.NpAccountId RecipientId
		{
			get
			{
				return recipientId;
			}
			set
			{
				recipientId = value;
			}
		}

		public Core.PlatformType RecipientPlatformType
		{
			get
			{
				return recipientPlatformType;
			}
			set
			{
				recipientPlatformType = value;
			}
		}

		public SendInGameMessageRequest()
			: base(ServiceTypes.Messaging, FunctionTypes.MessagingSendInGameMessage)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class DisplayReceivedGameDataMessagesDialogRequest : RequestBase
	{
		public DisplayReceivedGameDataMessagesDialogRequest()
			: base(ServiceTypes.Messaging, FunctionTypes.MessagingDisplayReceivedGameDataMessagesDialog)
		{
		}
	}

	public enum GameCustomDataTypes
	{
		Invalid,
		Url,
		Attachment
	}

	public struct GameDataMessageImage
	{
		public const int IMAGE_PATH_MAX_LEN = 255;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		internal string imgPath;

		public string ImgPath
		{
			get
			{
				return imgPath;
			}
			set
			{
				if (value.Length > 255)
				{
					throw new NpToolkitException("The size of the image path string is more than " + 255 + " characters.");
				}
				imgPath = value;
			}
		}

		internal bool IsValid()
		{
			if (imgPath == null || imgPath.Length == 0)
			{
				return false;
			}
			return true;
		}
	}

	public struct LocalizedMetadata
	{
		public const int MAX_SIZE_DATA_NAME = 127;

		public const int MAX_SIZE_DATA_DESCRIPTION = 511;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
		internal string languageCode;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		internal string name;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
		internal string description;

		public Core.LanguageCode LanguageCode
		{
			get
			{
				Core.LanguageCode languageCode = new Core.LanguageCode();
				languageCode.code = this.languageCode;
				return languageCode;
			}
			set
			{
				languageCode = value.code;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				if (value.Length > 127)
				{
					throw new NpToolkitException("The size of the string is more than " + 127 + " characters.");
				}
				name = value;
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set
			{
				if (value.Length > 511)
				{
					throw new NpToolkitException("The size of the string is more than " + 511 + " characters.");
				}
				description = value;
			}
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class SendGameDataMessageRequest : RequestBase
	{
		public const int MAX_SIZE_TEXT_MESSAGE = 511;

		public const int MAX_SIZE_DATA_NAME = 127;

		public const int MAX_SIZE_DATA_DESCRIPTION = 511;

		public const int MAX_NUM_RECIPIENTS = 16;

		public const int MAX_SIZE_ATTACHMENT = 1048576;

		public const int MAX_URL_SIZE = 1023;

		public const int MAX_LOCALIZED_METADATA = 50;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
		internal string textMessage;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		internal string dataName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
		internal string dataDescription;

		internal uint numRecipients;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		internal Core.NpAccountId[] recipients = new Core.NpAccountId[16];

		internal GameCustomDataTypes dataType;

		internal uint expireMinutes;

		[MarshalAs(UnmanagedType.LPArray)]
		internal byte[] attachment;

		internal ulong attachmentSize;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
		internal string url;

		internal ulong numDataLocalized;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		internal LocalizedMetadata[] localizedMetaData = new LocalizedMetadata[50];

		internal GameDataMessageImage thumbnail;

		internal uint maxNumberRecipientsToAdd;

		[MarshalAs(UnmanagedType.I1)]
		private bool enableDialog;

		[MarshalAs(UnmanagedType.I1)]
		private bool senderCanEditRecipients;

		[MarshalAs(UnmanagedType.I1)]
		private bool isPS4Available;

		[MarshalAs(UnmanagedType.I1)]
		private bool isPSVitaAvailable;

		[MarshalAs(UnmanagedType.I1)]
		private bool addGameDataMsgIdToUrl;

		public string TextMessage
		{
			get
			{
				return textMessage;
			}
			set
			{
				if (value.Length > 511)
				{
					throw new NpToolkitException("The size of the string is more than " + 511 + " characters.");
				}
				textMessage = value;
			}
		}

		public string DataName
		{
			get
			{
				return dataName;
			}
			set
			{
				if (value.Length > 127)
				{
					throw new NpToolkitException("The size of the string is more than " + 127 + " characters.");
				}
				dataName = value;
			}
		}

		public string DataDescription
		{
			get
			{
				return dataDescription;
			}
			set
			{
				if (value.Length > 511)
				{
					throw new NpToolkitException("The size of the string is more than " + 511 + " characters.");
				}
				dataDescription = value;
			}
		}

		public Core.NpAccountId[] Recipients
		{
			get
			{
				if (numRecipients == 0)
				{
					return null;
				}
				Core.NpAccountId[] array = new Core.NpAccountId[numRecipients];
				Array.Copy(recipients, array, (int)numRecipients);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 16)
					{
						throw new NpToolkitException("The size of the array is larger than " + 16);
					}
					value.CopyTo(recipients, 0);
					numRecipients = (uint)value.Length;
				}
				else
				{
					numRecipients = 0u;
				}
			}
		}

		public GameCustomDataTypes DataType => dataType;

		public byte[] Attachment
		{
			get
			{
				return attachment;
			}
			set
			{
				if (value.Length > 1048576)
				{
					throw new NpToolkitException("The size of the array is larger than " + 1048576);
				}
				attachment = value;
				attachmentSize = (ulong)((value != null) ? value.Length : 0);
				dataType = GameCustomDataTypes.Attachment;
			}
		}

		public uint ExpireMinutes
		{
			get
			{
				return expireMinutes;
			}
			set
			{
				expireMinutes = value;
			}
		}

		public string Url
		{
			get
			{
				return url;
			}
			set
			{
				if (value.Length > 1023)
				{
					throw new NpToolkitException("The size of the string is more than " + 1023 + " characters.");
				}
				url = value;
				dataType = GameCustomDataTypes.Url;
			}
		}

		public LocalizedMetadata[] LocalizedMetaData
		{
			get
			{
				if (numDataLocalized == 0)
				{
					return null;
				}
				LocalizedMetadata[] array = new LocalizedMetadata[numDataLocalized];
				Array.Copy(localizedMetaData, array, (int)numDataLocalized);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 50)
					{
						throw new NpToolkitException("The size of the localized game metadata array is more than " + 50);
					}
					localizedMetaData = value;
					numDataLocalized = (ulong)value.Length;
				}
				else
				{
					numDataLocalized = 0uL;
				}
			}
		}

		public GameDataMessageImage Thumbnail
		{
			get
			{
				return thumbnail;
			}
			set
			{
				thumbnail = value;
			}
		}

		public uint MaxNumberRecipientsToAdd
		{
			get
			{
				return maxNumberRecipientsToAdd;
			}
			set
			{
				maxNumberRecipientsToAdd = value;
			}
		}

		public bool EnableDialog
		{
			get
			{
				return enableDialog;
			}
			set
			{
				enableDialog = value;
			}
		}

		public bool SenderCanEditRecipients
		{
			get
			{
				return senderCanEditRecipients;
			}
			set
			{
				senderCanEditRecipients = value;
			}
		}

		public bool IsPS4Available
		{
			get
			{
				return isPS4Available;
			}
			set
			{
				isPS4Available = value;
			}
		}

		public bool IsPSVitaAvailable
		{
			get
			{
				return isPSVitaAvailable;
			}
			set
			{
				isPSVitaAvailable = value;
			}
		}

		public bool AddGameDataMsgIdToUrl
		{
			get
			{
				return addGameDataMsgIdToUrl;
			}
			set
			{
				addGameDataMsgIdToUrl = value;
			}
		}

		public SendGameDataMessageRequest()
			: base(ServiceTypes.Messaging, FunctionTypes.MessagingSendGameDataMessage)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class ConsumeGameDataMessageRequest : RequestBase
	{
		private ulong gameDataMsgId;

		public ulong GameDataMsgId
		{
			get
			{
				return gameDataMsgId;
			}
			set
			{
				gameDataMsgId = value;
			}
		}

		public ConsumeGameDataMessageRequest()
			: base(ServiceTypes.Messaging, FunctionTypes.MessagingConsumeGameDataMessage)
		{
		}
	}

	public enum GameDataMessagesToRetrieve
	{
		FromGameDataMsgIds,
		All
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetReceivedGameDataMessagesRequest : RequestBase
	{
		public const int MAX_NUM_GAME_DATA_MSG_IDS = 20;

		public const int MAX_PAGE_SIZE = 100;

		internal ulong numGameDataMsgIds;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
		internal ulong[] gameDataMsgIds = new ulong[20];

		internal uint pageSize;

		internal uint offset;

		internal GameDataMessagesToRetrieve retrieveType;

		public ulong[] GameDataMsgIds
		{
			get
			{
				if (numGameDataMsgIds == 0)
				{
					return null;
				}
				ulong[] array = new ulong[numGameDataMsgIds];
				Array.Copy(gameDataMsgIds, array, (int)numGameDataMsgIds);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 20)
					{
						throw new NpToolkitException("The size of the array is more than " + 20);
					}
					gameDataMsgIds = value;
					numGameDataMsgIds = (ulong)value.Length;
				}
				else
				{
					numGameDataMsgIds = 0uL;
				}
				if (numGameDataMsgIds != 0)
				{
					retrieveType = GameDataMessagesToRetrieve.FromGameDataMsgIds;
				}
				else
				{
					retrieveType = GameDataMessagesToRetrieve.All;
				}
			}
		}

		public uint PageSize
		{
			get
			{
				return pageSize;
			}
			set
			{
				pageSize = value;
				retrieveType = GameDataMessagesToRetrieve.All;
			}
		}

		public uint Offset
		{
			get
			{
				return offset;
			}
			set
			{
				offset = value;
				retrieveType = GameDataMessagesToRetrieve.All;
			}
		}

		public GameDataMessagesToRetrieve RetrieveType => retrieveType;

		public GetReceivedGameDataMessagesRequest()
			: base(ServiceTypes.Messaging, FunctionTypes.MessagingGetReceivedGameDataMessages)
		{
			pageSize = 100u;
			offset = 0u;
			retrieveType = GameDataMessagesToRetrieve.All;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetGameDataMessageThumbnailRequest : RequestBase
	{
		private ulong gameDataMsgId;

		public ulong GameDataMsgId
		{
			get
			{
				return gameDataMsgId;
			}
			set
			{
				gameDataMsgId = value;
			}
		}

		public GetGameDataMessageThumbnailRequest()
			: base(ServiceTypes.Messaging, FunctionTypes.MessagingGetGameDataMessageThumbnail)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetGameDataMessageAttachmentRequest : RequestBase
	{
		private ulong gameDataMsgId;

		public ulong GameDataMsgId
		{
			get
			{
				return gameDataMsgId;
			}
			set
			{
				gameDataMsgId = value;
			}
		}

		public GetGameDataMessageAttachmentRequest()
			: base(ServiceTypes.Messaging, FunctionTypes.MessagingGetGameDataMessageAttachment)
		{
		}
	}

	public class GameDataMessageDetails
	{
		internal string dataName;

		internal string dataDescription;

		internal string textMessage;

		public string DataName => dataName;

		public string DataDescription => dataDescription;

		public string TextMessage => textMessage;

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.GameDataMessageDetailsBegin);
			buffer.ReadString(ref dataName);
			buffer.ReadString(ref dataDescription);
			buffer.ReadString(ref textMessage);
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.GameDataMessageDetailsEnd);
		}
	}

	public class GameDataMessage
	{
		internal ulong gameDataMsgId;

		internal Core.OnlineUser fromUser = new Core.OnlineUser();

		internal string receivedDate;

		internal string expiredDate;

		internal bool isPS4Available;

		internal bool isPSVitaAvailable;

		internal GameCustomDataTypes dataType;

		internal string url;

		internal GameDataMessageDetails details;

		internal bool hasDetails;

		internal bool isUsed;

		public ulong GameDataMsgId => gameDataMsgId;

		public Core.OnlineUser FromUser => fromUser;

		public string ReceivedDate => receivedDate;

		public string ExpiredDate => expiredDate;

		public bool IsPS4Available => isPS4Available;

		public bool IsPSVitaAvailable => isPSVitaAvailable;

		public GameCustomDataTypes DataType => dataType;

		public string Url => url;

		public GameDataMessageDetails Details => details;

		public bool HasDetails => hasDetails;

		public bool IsUsed => isUsed;

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.GameDataMessageBegin);
			gameDataMsgId = buffer.ReadUInt64();
			fromUser.Read(buffer);
			buffer.ReadString(ref receivedDate);
			buffer.ReadString(ref expiredDate);
			isPS4Available = buffer.ReadBool();
			isPSVitaAvailable = buffer.ReadBool();
			dataType = (GameCustomDataTypes)buffer.ReadUInt32();
			buffer.ReadString(ref url);
			hasDetails = buffer.ReadBool();
			if (hasDetails)
			{
				details = new GameDataMessageDetails();
				details.Read(buffer);
			}
			isUsed = buffer.ReadBool();
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.GameDataMessageEnd);
		}
	}

	public class GameDataMessagesResponse : ResponseBase
	{
		internal GameDataMessage[] gameDataMessages;

		public GameDataMessage[] GameDataMessages => gameDataMessages;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.GameDataMessagesBegin);
			ulong num = memoryBuffer.ReadUInt64();
			gameDataMessages = new GameDataMessage[num];
			for (ulong num2 = 0uL; num2 < num; num2++)
			{
				gameDataMessages[num2] = new GameDataMessage();
				gameDataMessages[num2].Read(memoryBuffer);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.GameDataMessagesEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class GameDataMessageThumbnailResponse : ResponseBase
	{
		internal ulong gameDataMsgId;

		internal byte[] thumbnail = null;

		public ulong GameDataMsgId => gameDataMsgId;

		public byte[] Thumbnail => thumbnail;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.GameDataMessageThumbnailBegin);
			gameDataMsgId = memoryBuffer.ReadUInt64();
			memoryBuffer.ReadData(ref thumbnail);
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.GameDataMessageThumbnailEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class GameDataMessageAttachmentResponse : ResponseBase
	{
		internal ulong gameDataMsgId;

		internal byte[] attachment;

		public ulong GameDataMsgId => gameDataMsgId;

		public byte[] Attachment => attachment;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.GameDataMessageAttachmentBegin);
			gameDataMsgId = memoryBuffer.ReadUInt64();
			memoryBuffer.ReadData(ref attachment);
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.GameDataMessageAttachmentEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class NewInGameMessageResponse : ResponseBase
	{
		internal byte[] message;

		internal Core.OnlineUser sender = new Core.OnlineUser();

		internal Core.OnlineUser recipient = new Core.OnlineUser();

		internal Core.PlatformType senderPlatformType;

		internal Core.PlatformType recipientPlatformType;

		public byte[] Message => message;

		public Core.OnlineUser Sender => sender;

		public Core.OnlineUser Recipient => recipient;

		public Core.PlatformType SenderPlatformType => senderPlatformType;

		public Core.PlatformType RecipientPlatformType => recipientPlatformType;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NewInGameMessageBegin);
			memoryBuffer.ReadData(ref message);
			sender.Read(memoryBuffer);
			recipient.Read(memoryBuffer);
			senderPlatformType = (Core.PlatformType)memoryBuffer.ReadUInt32();
			recipientPlatformType = (Core.PlatformType)memoryBuffer.ReadUInt32();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NewInGameMessageEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class NewGameDataMessageResponse : ResponseBase
	{
		internal Core.OnlineUser to = new Core.OnlineUser();

		internal Core.OnlineUser from = new Core.OnlineUser();

		public Core.OnlineUser To => to;

		public Core.OnlineUser From => from;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NewGameDataMessageBegin);
			to.Read(memoryBuffer);
			from.Read(memoryBuffer);
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NewGameDataMessageEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class GameCustomDataEventResponse : ResponseBase
	{
		internal ulong itemId;

		internal Core.OnlineID onlineId = new Core.OnlineID();

		internal Core.UserServiceUserId userId;

		public ulong ItemId => itemId;

		public Core.OnlineID OnlineId => onlineId;

		public Core.UserServiceUserId UserId => userId;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.GameCustomDataEventBegin);
			itemId = memoryBuffer.ReadUInt64();
			onlineId.Read(memoryBuffer);
			userId.Read(memoryBuffer);
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.GameCustomDataEventEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxSendInGameMessage(SendInGameMessageRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxDisplayReceivedGameDataMessagesDialog(DisplayReceivedGameDataMessagesDialogRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxSendGameDataMessage(SendGameDataMessageRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxConsumeGameDataMessage(ConsumeGameDataMessageRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetReceivedGameDataMessages(GetReceivedGameDataMessagesRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetGameDataMessageThumbnail(GetGameDataMessageThumbnailRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetGameDataMessageAttachment(GetGameDataMessageAttachmentRequest request, out APIResult result);

	public static int SendInGameMessage(SendInGameMessageRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxSendInGameMessage(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int DisplayReceivedGameDataMessagesDialog(DisplayReceivedGameDataMessagesDialogRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxDisplayReceivedGameDataMessagesDialog(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int SendGameDataMessage(SendGameDataMessageRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		if (!request.thumbnail.IsValid())
		{
			throw new NpToolkitException("Request thumbnail image hasn't be defined. A message can't be created without an image.");
		}
		APIResult result;
		int num = PrxSendGameDataMessage(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int ConsumeGameDataMessage(ConsumeGameDataMessageRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxConsumeGameDataMessage(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetReceivedGameDataMessages(GetReceivedGameDataMessagesRequest request, GameDataMessagesResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetReceivedGameDataMessages(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetGameDataMessageThumbnail(GetGameDataMessageThumbnailRequest request, GameDataMessageThumbnailResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetGameDataMessageThumbnail(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetGameDataMessageAttachment(GetGameDataMessageAttachmentRequest request, GameDataMessageAttachmentResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetGameDataMessageAttachment(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}
}
public class NetworkUtils
{
	[StructLayout(LayoutKind.Sequential)]
	public class GetBandwidthInfoRequest : RequestBase
	{
		public GetBandwidthInfoRequest()
			: base(ServiceTypes.NetworkUtils, FunctionTypes.NetworkUtilsGetBandwidthInfo)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetBasicNetworkInfoRequest : RequestBase
	{
		public GetBasicNetworkInfoRequest()
			: base(ServiceTypes.NetworkUtils, FunctionTypes.NetworkUtilsGetBasicNetworkInfo)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetDetailedNetworkInfoRequest : RequestBase
	{
		public GetDetailedNetworkInfoRequest()
			: base(ServiceTypes.NetworkUtils, FunctionTypes.NetworkUtilsGetDetailedNetworkInfo)
		{
		}
	}

	public enum NetworkConnectionState
	{
		Disconnected,
		Connecting,
		ObtainingIP,
		ObtainedIP
	}

	public struct NpBandwidthTestResult
	{
		internal double uploadBps;

		internal double downloadBps;

		internal int result;

		public double UploadBps => uploadBps;

		public double DownloadBps => downloadBps;

		internal void Read(MemoryBuffer buffer)
		{
			uploadBps = buffer.ReadDouble();
			downloadBps = buffer.ReadDouble();
			result = buffer.ReadInt32();
		}

		public override string ToString()
		{
			return "Up Bps = " + uploadBps + " Down Bps = " + downloadBps;
		}
	}

	public struct NetInAddr
	{
		internal uint addr;

		public uint Addr
		{
			get
			{
				return addr;
			}
			set
			{
				addr = value;
			}
		}

		internal void Read(MemoryBuffer buffer)
		{
			addr = buffer.ReadUInt32();
		}

		public override string ToString()
		{
			byte[] bytes = BitConverter.GetBytes(addr);
			string text = bytes[0].ToString();
			for (int i = 1; i < bytes.Length; i++)
			{
				text = text + "." + bytes[i];
			}
			return text;
		}
	}

	public enum RouterNatType
	{
		Type1 = 1,
		Type2,
		Type3
	}

	public enum RouterStun
	{
		Unchecked,
		Failed,
		OK
	}

	public struct NatRouterInfo
	{
		internal RouterStun stunStatus;

		internal RouterNatType natType;

		internal NetInAddr mappedAddr;

		public RouterStun StunStatus => stunStatus;

		public RouterNatType NatType => natType;

		public NetInAddr MappedAddr => mappedAddr;

		internal void Read(MemoryBuffer buffer)
		{
			stunStatus = (RouterStun)buffer.ReadInt32();
			natType = (RouterNatType)buffer.ReadInt32();
			mappedAddr.Read(buffer);
		}

		public override string ToString()
		{
			return string.Concat("Stun Status = ", stunStatus, " : Nat Type = ", natType, " : Mapped Addr = ", mappedAddr.ToString());
		}
	}

	public struct NetEtherAddr
	{
		public const int SCE_NET_ETHER_ADDR_LEN = 6;

		internal byte[] data;

		public byte[] Data => data;

		internal void Read(MemoryBuffer buffer)
		{
			data = new byte[6];
			buffer.ReadData(ref data);
		}

		public override string ToString()
		{
			if (data == null)
			{
				return "0.0.0.0.0.0";
			}
			string text = data[0].ToString();
			for (int i = 1; i < data.Length; i++)
			{
				text = text + "." + data[i];
			}
			return text;
		}
	}

	public class BandwidthInfoResponse : ResponseBase
	{
		internal NpBandwidthTestResult bandwidth;

		public NpBandwidthTestResult Bandwidth => bandwidth;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.BandwidthInfoBegin);
			bandwidth.Read(memoryBuffer);
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.BandwidthInfoEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class BasicNetworkInfoResponse : ResponseBase
	{
		internal string ipAddress;

		internal NatRouterInfo natInfo;

		internal NetworkConnectionState connectionStatus;

		public string IpAddress => ipAddress;

		public NatRouterInfo NatInfo => natInfo;

		public NetworkConnectionState ConnectionStatus => connectionStatus;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NetStateBasicBegin);
			memoryBuffer.ReadString(ref ipAddress);
			natInfo.Read(memoryBuffer);
			connectionStatus = (NetworkConnectionState)memoryBuffer.ReadUInt32();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NetStateBasicEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public enum NetworkDevice
	{
		Wired,
		Wireless
	}

	public enum NetworkLink
	{
		Disconnected,
		Connected
	}

	public enum WfiSecurity
	{
		NoSecurity,
		WEP,
		WPAPSK_WPA2PSK,
		WPAPSK_TKIP,
		WPAPSK_AES,
		WPA2PSK_TKIP,
		WPA2PSK_AES,
		Unsupported
	}

	public enum NetworkIPConfig
	{
		DHCP,
		Static,
		PPPoE
	}

	public enum NetworkHTTPProxyConfig
	{
		Off,
		On
	}

	public class DetailedNetworkInfoResponse : ResponseBase
	{
		internal NatRouterInfo natInfo;

		internal NetworkConnectionState connectionStatus;

		internal NetworkDevice device;

		internal NetEtherAddr ethernetAddress;

		internal byte rssiPercentage;

		internal byte channel;

		internal uint mtu;

		internal NetworkLink link;

		internal WfiSecurity wifiSecurity;

		internal NetworkIPConfig ipConfig;

		internal NetworkHTTPProxyConfig httpProxyConfig;

		internal ushort httpProxyPort;

		internal NetEtherAddr bssid;

		internal string ssid = "";

		internal string dhcpHostname = "";

		internal string pppoeAuthName = "";

		internal string ipAddress = "";

		internal string netmask = "";

		internal string defaultRoute = "";

		internal string primaryDNS = "";

		internal string secondaryDNS = "";

		internal string httpProxyServer = "";

		public NatRouterInfo NatInfo => natInfo;

		public NetworkConnectionState ConnectionStatus => connectionStatus;

		public NetworkDevice Device => device;

		public NetEtherAddr EthernetAddress => ethernetAddress;

		public byte RssiPercentage => rssiPercentage;

		public byte Channel => channel;

		public uint MTU => mtu;

		public NetworkLink Link => link;

		public WfiSecurity WifiSecurity => wifiSecurity;

		public NetworkIPConfig IpConfig => ipConfig;

		public NetworkHTTPProxyConfig HttpProxyConfig => httpProxyConfig;

		public ushort HttpProxyPort => httpProxyPort;

		public NetEtherAddr BSSID => bssid;

		public string SSID => ssid;

		public string DhcpHostname => dhcpHostname;

		public string PPPoeAuthName => pppoeAuthName;

		public string IpAddress => ipAddress;

		public string Netmask => netmask;

		public string DefaultRoute => defaultRoute;

		public string PrimaryDNS => primaryDNS;

		public string SecondaryDNS => secondaryDNS;

		public string HttpProxyServer => httpProxyServer;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NetStateDetailedBegin);
			natInfo.Read(memoryBuffer);
			connectionStatus = (NetworkConnectionState)memoryBuffer.ReadUInt32();
			device = (NetworkDevice)memoryBuffer.ReadUInt32();
			ethernetAddress.Read(memoryBuffer);
			rssiPercentage = memoryBuffer.ReadUInt8();
			channel = memoryBuffer.ReadUInt8();
			mtu = memoryBuffer.ReadUInt32();
			link = (NetworkLink)memoryBuffer.ReadUInt32();
			wifiSecurity = (WfiSecurity)memoryBuffer.ReadUInt32();
			ipConfig = (NetworkIPConfig)memoryBuffer.ReadUInt32();
			httpProxyConfig = (NetworkHTTPProxyConfig)memoryBuffer.ReadUInt32();
			httpProxyPort = memoryBuffer.ReadUInt16();
			bssid.Read(memoryBuffer);
			memoryBuffer.ReadString(ref ssid);
			memoryBuffer.ReadString(ref dhcpHostname);
			memoryBuffer.ReadString(ref pppoeAuthName);
			memoryBuffer.ReadString(ref ipAddress);
			memoryBuffer.ReadString(ref netmask);
			memoryBuffer.ReadString(ref defaultRoute);
			memoryBuffer.ReadString(ref primaryDNS);
			memoryBuffer.ReadString(ref secondaryDNS);
			memoryBuffer.ReadString(ref httpProxyServer);
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NetStateDetailedEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public enum NetworkEvent
	{
		none,
		networkConnected,
		networkDisconnected
	}

	public class NetStateChangeResponse : ResponseBase
	{
		internal NetworkEvent netEvent;

		public NetworkEvent NetEvent => netEvent;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NetStateChangeBegin);
			netEvent = (NetworkEvent)memoryBuffer.ReadInt32();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NetStateChangeEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetBandwidthInfo(GetBandwidthInfoRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetBasicNetworkInfo(GetBasicNetworkInfoRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetDetailedNetworkInfo(GetDetailedNetworkInfoRequest request, out APIResult result);

	public static int GetBandwidthInfo(GetBandwidthInfoRequest request, BandwidthInfoResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetBandwidthInfo(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetBasicNetworkInfoInfo(GetBasicNetworkInfoRequest request, BasicNetworkInfoResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetBasicNetworkInfo(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetDetailedNetworkInfo(GetDetailedNetworkInfoRequest request, DetailedNetworkInfoResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetDetailedNetworkInfo(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}
}
internal class Notifications
{
	internal static ResponseBase CreateNotificationResponse(FunctionTypes notificationType)
	{
		ResponseBase result = null;
		switch (notificationType)
		{
		case FunctionTypes.NotificationDialogOpened:
		case FunctionTypes.NotificationDialogClosed:
		case FunctionTypes.NotificationAborted:
			result = new Core.EmptyResponse();
			break;
		case FunctionTypes.NotificationRefreshRoom:
			result = new Matching.RefreshRoomResponse();
			break;
		case FunctionTypes.NotificationNewRoomMessage:
			result = new Matching.NewRoomMessageResponse();
			break;
		case FunctionTypes.NotificationNewInGameMessage:
			result = new Messaging.NewInGameMessageResponse();
			break;
		case FunctionTypes.NotificationNewGameDataMessage:
			result = new Messaging.NewGameDataMessageResponse();
			break;
		case FunctionTypes.NotificationUserStateChange:
			result = new NpUtils.UserStateChangeResponse();
			break;
		case FunctionTypes.NotificationNetStateChange:
			result = new NetworkUtils.NetStateChangeResponse();
			break;
		case FunctionTypes.NotificationUpdateFriendsList:
			result = new Friends.FriendListUpdateResponse();
			break;
		case FunctionTypes.NotificationUpdateFriendPresence:
			result = new Presence.PresenceUpdateResponse();
			break;
		case FunctionTypes.NotificationUpdateBlockedUsersList:
			result = new Friends.BlocklistUpdateResponse();
			break;
		case FunctionTypes.NotificationNewInvitation:
			result = new Matching.InvitationReceivedResponse();
			break;
		case FunctionTypes.NotificationSessionInvitationEvent:
			result = new Matching.SessionInvitationEventResponse();
			break;
		case FunctionTypes.NotificationPlayTogetherHostEvent:
			result = new Matching.PlayTogetherHostEventResponse();
			break;
		case FunctionTypes.NotificationGameCustomDataEvent:
			result = new Messaging.GameCustomDataEventResponse();
			break;
		}
		return result;
	}
}
public class NpUtils
{
	[StructLayout(LayoutKind.Sequential)]
	public class SetTitleIdForDevelopmentRequest : RequestBase
	{
		private const int SCE_NP_TITLE_ID_LEN = 12;

		public string titleId;

		public string titleSecretString;

		public uint titleSecretStringSize;

		public SetTitleIdForDevelopmentRequest()
			: base(ServiceTypes.NpUtils, FunctionTypes.NpUtilsSetTitleIdForDevelopment)
		{
			titleId = "";
			titleSecretString = "";
			titleSecretStringSize = 0u;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class DisplaySigninDialogRequest : RequestBase
	{
		public DisplaySigninDialogRequest()
			: base(ServiceTypes.NpUtils, FunctionTypes.NpUtilsDisplaySigninDialog)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class CheckAvailablityRequest : RequestBase
	{
		public CheckAvailablityRequest()
			: base(ServiceTypes.NpUtils, FunctionTypes.NpUtilsCheckAvailability)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class CheckPlusRequest : RequestBase
	{
		internal ulong features;

		public CheckPlusRequest()
			: base(ServiceTypes.NpUtils, FunctionTypes.NpUtilsCheckPlus)
		{
			features = 1uL;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetParentalControlInfoRequest : RequestBase
	{
		public GetParentalControlInfoRequest()
			: base(ServiceTypes.NpUtils, FunctionTypes.NpUtilsGetParentalControlInfo)
		{
		}
	}

	public class CheckPlusResponse : ResponseBase
	{
		internal bool authorized;

		public bool Authorized => authorized;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.CheckPlusBegin);
			authorized = memoryBuffer.ReadBool();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.CheckPlusEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class GetParentalControlInfoResponse : ResponseBase
	{
		private int age;

		internal bool contentRestriction;

		internal bool chatRestriction;

		internal bool ugcRestriction;

		public int Age => age;

		public bool ChatRestriction => chatRestriction;

		public bool UGCRestriction => ugcRestriction;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.GetParentalControlInfoBegin);
			age = memoryBuffer.ReadInt32();
			contentRestriction = memoryBuffer.ReadBool();
			chatRestriction = memoryBuffer.ReadBool();
			ugcRestriction = memoryBuffer.ReadBool();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.GetParentalControlInfoEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public enum SignInState
	{
		unknown,
		signedOut,
		signedIn
	}

	public enum LogInState
	{
		loggedIn,
		loggedOut,
		unknown
	}

	public enum StateChanged
	{
		none,
		signedInState,
		loggedInState
	}

	public class UserStateChangeResponse : ResponseBase
	{
		internal Core.UserServiceUserId userId;

		internal SignInState currentSignInState;

		internal LogInState currentLogInState;

		internal StateChanged stateChanged;

		public Core.UserServiceUserId UserId => userId;

		public SignInState CurrentSignInState => currentSignInState;

		public LogInState CurrentLogInState => currentLogInState;

		public StateChanged StateChanged => stateChanged;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.UserStateChangeBegin);
			userId = memoryBuffer.ReadInt32();
			currentSignInState = (SignInState)memoryBuffer.ReadInt32();
			currentLogInState = (LogInState)memoryBuffer.ReadInt32();
			stateChanged = (StateChanged)memoryBuffer.ReadInt32();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.UserStateChangeEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxSetTitleIdForDevelopment(SetTitleIdForDevelopmentRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxDisplaySigninDialog(DisplaySigninDialogRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxCheckAvailablity(CheckAvailablityRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxCheckPlus(CheckPlusRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetParentalControlInfo(GetParentalControlInfoRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern void PrxNotifyPlusFeature(int userId, ulong features, out APIResult result);

	public static int SetTitleIdForDevelopment(SetTitleIdForDevelopmentRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxSetTitleIdForDevelopment(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int DisplaySigninDialog(DisplaySigninDialogRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxDisplaySigninDialog(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int CheckAvailablity(CheckAvailablityRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxCheckAvailablity(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int CheckPlus(CheckPlusRequest request, CheckPlusResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxCheckPlus(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetParentalControlInfo(GetParentalControlInfoRequest request, GetParentalControlInfoResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetParentalControlInfo(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static void NotifyPlusFeature(Core.UserServiceUserId userId)
	{
		PrxNotifyPlusFeature(userId.id, 1uL, out var result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
	}
}
public class Presence
{
	[StructLayout(LayoutKind.Sequential)]
	public class DeletePresenceRequest : RequestBase
	{
		[MarshalAs(UnmanagedType.I1)]
		internal bool deleteGameData;

		[MarshalAs(UnmanagedType.I1)]
		internal bool deleteGameStatus;

		public bool DeleteGameData => deleteGameData;

		public bool DeleteGameStatus => deleteGameStatus;

		public DeletePresenceRequest()
			: base(ServiceTypes.Presence, FunctionTypes.PresenceDeletePresence)
		{
			deleteGameData = true;
			deleteGameStatus = true;
		}
	}

	public struct LocalizedGameStatus
	{
		public const int MAX_SIZE_LOCALIZED_GAME_STATUS = 96;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
		internal string languageCode;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 97)]
		internal string gameStatus;

		public Core.LanguageCode LanguageCode
		{
			get
			{
				Core.LanguageCode languageCode = new Core.LanguageCode();
				languageCode.code = this.languageCode;
				return languageCode;
			}
			set
			{
				languageCode = value.code;
			}
		}

		public string GameStatus
		{
			get
			{
				return gameStatus;
			}
			set
			{
				if (value.Length > 96)
				{
					throw new NpToolkitException("The size of the game stutus string is more than " + 96 + " characters.");
				}
				gameStatus = value;
			}
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class SetPresenceRequest : RequestBase
	{
		public const int MAX_LOCALIZED_STATUSES = 50;

		public const int MAX_SIZE_GAME_DATA = 128;

		public const int MAX_SIZE_DEFAULT_GAME_STATUS = 191;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 191)]
		internal string defaultGameStatus;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		internal LocalizedGameStatus[] localizedGameStatuses;

		internal uint numLocalizedGameStatuses;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
		internal byte[] binaryGameData;

		internal uint binaryGameDataSize;

		public string DefaultGameStatus
		{
			get
			{
				return defaultGameStatus;
			}
			set
			{
				if (value.Length > 191)
				{
					throw new NpToolkitException("The size of the default game stutus string is more than " + 191 + " characters.");
				}
				defaultGameStatus = value;
			}
		}

		public LocalizedGameStatus[] LocalizedGameStatuses
		{
			get
			{
				if (numLocalizedGameStatuses == 0)
				{
					return null;
				}
				LocalizedGameStatus[] array = new LocalizedGameStatus[numLocalizedGameStatuses];
				Array.Copy(localizedGameStatuses, array, numLocalizedGameStatuses);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 50)
					{
						throw new NpToolkitException("The size of the localized game statuses array is more than " + 50);
					}
					value.CopyTo(localizedGameStatuses, 0);
					numLocalizedGameStatuses = (uint)value.Length;
				}
				else
				{
					numLocalizedGameStatuses = 0u;
				}
			}
		}

		public byte[] BinaryGameData
		{
			get
			{
				if (binaryGameData == null)
				{
					return null;
				}
				byte[] array = new byte[binaryGameDataSize];
				Array.Copy(binaryGameData, array, binaryGameDataSize);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 128)
					{
						throw new NpToolkitException("The size of the binary game data is more than " + 128 + " bytes.");
					}
					value.CopyTo(binaryGameData, 0);
					binaryGameDataSize = (uint)value.Length;
				}
				else
				{
					binaryGameDataSize = 0u;
				}
			}
		}

		public SetPresenceRequest()
			: base(ServiceTypes.Presence, FunctionTypes.PresenceSetPresence)
		{
			defaultGameStatus = "";
			localizedGameStatuses = new LocalizedGameStatus[50];
			numLocalizedGameStatuses = 0u;
			binaryGameData = new byte[128];
			binaryGameDataSize = 0u;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetPresenceRequest : RequestBase
	{
		internal Core.NpAccountId fromUser;

		internal bool inContext;

		public Core.NpAccountId FromUser
		{
			get
			{
				return fromUser;
			}
			set
			{
				fromUser = value;
			}
		}

		public bool InContext
		{
			get
			{
				return inContext;
			}
			set
			{
				inContext = value;
			}
		}

		public GetPresenceRequest()
			: base(ServiceTypes.Presence, FunctionTypes.PresenceGetPresence)
		{
			fromUser.id = 0uL;
			inContext = true;
		}
	}

	public class PlatformPresence
	{
		public const int MAX_SIZE_TITLE_NAME = 127;

		public const int MAX_SIZE_GAME_STATUS = 191;

		public const int MAX_SIZE_GAME_DATA = 128;

		internal Core.OnlineStatus onlineStatusOnPlatform;

		internal Core.PlatformType platform;

		internal Core.TitleId titleId = new Core.TitleId();

		internal string titleName = "";

		internal string gameStatus = "";

		internal byte[] binaryGameData;

		public Core.OnlineStatus OnlineStatusOnPlatform => onlineStatusOnPlatform;

		public Core.PlatformType Platform => platform;

		public Core.TitleId TitleId => titleId;

		public string TitleName => titleName;

		public string GameStatus => gameStatus;

		public byte[] BinaryGameData => binaryGameData;

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.PlatformPresenceBegin);
			onlineStatusOnPlatform = (Core.OnlineStatus)buffer.ReadUInt32();
			platform = (Core.PlatformType)buffer.ReadUInt32();
			titleId.Read(buffer);
			buffer.ReadString(ref titleName);
			buffer.ReadString(ref gameStatus);
			buffer.ReadData(ref binaryGameData);
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.PlatformPresenceEnd);
		}

		public override string ToString()
		{
			string text = "";
			return text + string.Format("\n: Platform Presence : OS ({0}) Platform ({1}) TitleId ({2}) ", onlineStatusOnPlatform, platform, titleId.ToString(), titleName);
		}
	}

	public class UserPresence
	{
		public const int MAX_NUM_PLATFORM_PRESENCE = 3;

		internal Core.OnlineUser user = new Core.OnlineUser();

		internal Core.OnlineStatus psnOnlineStatus;

		internal Core.PlatformType mostRelevantPlatform;

		internal PlatformPresence[] platforms;

		public Core.OnlineUser User => user;

		public Core.OnlineStatus PsnOnlineStatus => psnOnlineStatus;

		public Core.PlatformType MostRelevantPlatform => mostRelevantPlatform;

		public PlatformPresence[] Platforms => platforms;

		internal UserPresence()
		{
		}

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.PresenceBegin);
			user.Read(buffer);
			psnOnlineStatus = (Core.OnlineStatus)buffer.ReadUInt32();
			mostRelevantPlatform = (Core.PlatformType)buffer.ReadUInt32();
			uint num = buffer.ReadUInt32();
			if (num == 0)
			{
				platforms = null;
			}
			else
			{
				platforms = new PlatformPresence[num];
				for (int i = 0; i < num; i++)
				{
					platforms[i] = new PlatformPresence();
					platforms[i].Read(buffer);
				}
			}
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.PresenceEnd);
		}

		public override string ToString()
		{
			string text = "";
			int num = 0;
			if (platforms != null)
			{
				num = platforms.Length;
			}
			text += $"0x{User.accountId:X} : {User.onlineId.name} : PSN OS ({PsnOnlineStatus}) MRP ({MostRelevantPlatform}) #P ({num})'\n";
			for (int i = 0; i < num; i++)
			{
				text = text + Platforms[i].ToString() + "\n";
			}
			return text;
		}
	}

	public class PresenceResponse : ResponseBase
	{
		internal UserPresence userPresence = new UserPresence();

		public UserPresence UserPresence => userPresence;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			userPresence.Read(memoryBuffer);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public enum PresenceUpdateType
	{
		invalid,
		gameTitle,
		gameStatus,
		gameData
	}

	public class PresenceUpdateResponse : ResponseBase
	{
		public const int MAX_SIZE_GAME_STATUS = 191;

		public const int MAX_SIZE_GAME_DATA = 128;

		internal Core.OnlineUser localUpdatedUser = new Core.OnlineUser();

		internal Core.OnlineUser remoteUser = new Core.OnlineUser();

		internal Core.UserServiceUserId userId;

		internal PresenceUpdateType updateType;

		internal string gameStatus = "";

		internal byte[] binaryGameData;

		internal Core.PlatformType platform;

		public Core.OnlineUser LocalUpdatedUser => localUpdatedUser;

		public Core.OnlineUser RemoteUser => remoteUser;

		public Core.UserServiceUserId UserId => userId;

		public PresenceUpdateType UpdateType => updateType;

		public string GameStatus
		{
			get
			{
				if (updateType != PresenceUpdateType.gameStatus)
				{
					throw new NpToolkitException("GameStatus isn't valid unless 'UpdateType' is set to " + PresenceUpdateType.gameStatus);
				}
				return gameStatus;
			}
		}

		public byte[] BinaryGameData
		{
			get
			{
				if (updateType != PresenceUpdateType.gameData)
				{
					throw new NpToolkitException("BinaryGameData isn't valid unless 'UpdateType' is set to " + PresenceUpdateType.gameData);
				}
				return binaryGameData;
			}
		}

		public Core.PlatformType Platform => platform;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.PresenceUpdateBegin);
			localUpdatedUser.Read(memoryBuffer);
			remoteUser.Read(memoryBuffer);
			userId = memoryBuffer.ReadInt32();
			updateType = (PresenceUpdateType)memoryBuffer.ReadInt32();
			memoryBuffer.ReadString(ref gameStatus);
			memoryBuffer.ReadData(ref binaryGameData);
			platform = (Core.PlatformType)memoryBuffer.ReadInt32();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.PresenceUpdateEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxDeletePresence(DeletePresenceRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxSetPresence(SetPresenceRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetPresence(GetPresenceRequest request, out APIResult result);

	public static int DeletePresence(DeletePresenceRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxDeletePresence(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int SetPresence(SetPresenceRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxSetPresence(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetPresence(GetPresenceRequest request, PresenceResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetPresence(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}
}
public class Profiles
{
	public class RealName
	{
		public const int MAX_SIZE_FIRST_NAME = 16;

		public const int MAX_SIZE_MIDDLE_NAME = 16;

		public const int MAX_SIZE_LAST_NAME = 16;

		internal string firstName = "";

		internal string middleName = "";

		internal string lastName = "";

		public string FirstName => firstName;

		public string MiddleName => middleName;

		public string LastName => lastName;

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.RealNameBegin);
			buffer.ReadString(ref firstName);
			buffer.ReadString(ref middleName);
			buffer.ReadString(ref lastName);
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.RealNameEnd);
		}
	}

	public class Profile
	{
		public enum RelationTypes
		{
			notSet,
			me,
			friends,
			requestingFriend,
			requestedFriend,
			blocked,
			friendOfFriends,
			noRelationship
		}

		public enum PersonalDetailsTypes
		{
			none,
			realName,
			verifiedAccountDisplayName
		}

		public const int MAX_SIZE_ABOUT_ME = 140;

		public const int MAX_SIZE_AVATAR_URL = 128;

		public const int MAX_NUM_LANGUAGES_USED = 3;

		public const int MAX_SIZE_VERIFIED_ACCOUNT_DISPLAY_NAME = 32;

		public const int MAX_SIZE_PROFILE_PICTURE_URL = 256;

		internal Core.OnlineUser onlineUser = new Core.OnlineUser();

		internal RelationTypes relationType;

		internal Core.LanguageCode[] languagesUsed = new Core.LanguageCode[3];

		internal Core.CountryCode country = new Core.CountryCode();

		internal PersonalDetailsTypes personalDetailsType;

		internal RealName realName;

		internal string verifiedAccountDisplayName;

		internal string aboutMe = "";

		internal string avatarUrl = "";

		internal string profilePictureUrl = "";

		internal bool isVerifiedAccount;

		public Core.OnlineUser OnlineUser => onlineUser;

		public RelationTypes RelationType => relationType;

		public Core.CountryCode Country => country;

		public Core.LanguageCode[] LanguagesUsed => languagesUsed;

		public PersonalDetailsTypes PersonalDetailsType => personalDetailsType;

		public RealName RealName
		{
			get
			{
				if (personalDetailsType != PersonalDetailsTypes.realName)
				{
					throw new NpToolkitException("Can't access RealName unless PersonalDetailsType is PersonalDetailsType.realName");
				}
				return realName;
			}
		}

		public string VerifiedAccountDisplayName
		{
			get
			{
				if (personalDetailsType != PersonalDetailsTypes.verifiedAccountDisplayName)
				{
					throw new NpToolkitException("Can't access VerifiedAccountDisplayName unless PersonalDetailsType is PersonalDetailsType.verifiedAccountDisplayName");
				}
				return verifiedAccountDisplayName;
			}
		}

		public bool IsVerifiedAccount => isVerifiedAccount;

		public string AboutMe => aboutMe;

		public string AvatarUrl => avatarUrl;

		public string ProfilePictureUrl => profilePictureUrl;

		public Profile()
		{
			for (int i = 0; i < 3; i++)
			{
				languagesUsed[i] = new Core.LanguageCode();
			}
		}

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.ProfileBegin);
			onlineUser.Read(buffer);
			relationType = (RelationTypes)buffer.ReadUInt32();
			uint num = buffer.ReadUInt32();
			if (num != 3)
			{
				throw new NpToolkitException("Unexpected language array size in Profile. Should be " + 3);
			}
			for (int i = 0; i < 3; i++)
			{
				languagesUsed[i].Read(buffer);
			}
			country.Read(buffer);
			personalDetailsType = (PersonalDetailsTypes)buffer.ReadUInt32();
			if (personalDetailsType == PersonalDetailsTypes.realName)
			{
				realName = new RealName();
				realName.Read(buffer);
			}
			else if (personalDetailsType == PersonalDetailsTypes.verifiedAccountDisplayName)
			{
				verifiedAccountDisplayName = "";
				buffer.ReadString(ref verifiedAccountDisplayName);
			}
			buffer.ReadString(ref aboutMe);
			buffer.ReadString(ref avatarUrl);
			buffer.ReadString(ref profilePictureUrl);
			isVerifiedAccount = buffer.ReadBool();
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.ProfileEnd);
		}

		public override string ToString()
		{
			string text = "";
			text += $"{OnlineUser.ToString()} : Relation ({RelationType}) CC ({Country.ToString()}) PT ({PersonalDetailsType}) Lang1 ({languagesUsed[0].ToString()})\n";
			if (PersonalDetailsType == PersonalDetailsTypes.realName)
			{
				text += $" RN ({RealName.FirstName} {RealName.MiddleName} {RealName.LastName})\n";
			}
			else if (PersonalDetailsType == PersonalDetailsTypes.verifiedAccountDisplayName)
			{
				text += $" VDN ({VerifiedAccountDisplayName})\n";
			}
			return text + $" Verified Account ({IsVerifiedAccount})";
		}
	}
}
public class Ranking
{
	[StructLayout(LayoutKind.Sequential)]
	public class SetScoreRequest : RequestBase
	{
		public const int NP_SCORE_COMMENT_MAXLEN = 63;

		public const int NP_SCORE_GAMEINFO_MAXSIZE = 189;

		[MarshalAs(UnmanagedType.I8)]
		internal long score;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		internal string utf8Comment;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 189)]
		internal byte[] gameInfoData;

		[MarshalAs(UnmanagedType.U8)]
		internal ulong dataLength;

		[MarshalAs(UnmanagedType.U4)]
		internal uint boardId;

		[MarshalAs(UnmanagedType.I4)]
		internal int pcId;

		public long Score
		{
			get
			{
				return score;
			}
			set
			{
				score = value;
			}
		}

		public string Comment
		{
			get
			{
				return utf8Comment;
			}
			set
			{
				if (value.Length > 63)
				{
					throw new NpToolkitException("The size of the comment string is more than " + 63 + " characters.");
				}
				utf8Comment = value;
			}
		}

		public byte[] GameInfoData
		{
			get
			{
				if (dataLength == 0)
				{
					return null;
				}
				byte[] array = new byte[dataLength];
				Array.Copy(gameInfoData, array, (int)dataLength);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 189)
					{
						throw new NpToolkitException("The size of the game data is more than " + 189 + " bytes.");
					}
					value.CopyTo(gameInfoData, 0);
					dataLength = (uint)value.Length;
				}
				else
				{
					dataLength = 0uL;
				}
			}
		}

		public uint BoardId
		{
			get
			{
				return boardId;
			}
			set
			{
				if (value > 1000)
				{
					throw new NpToolkitException("The BoardId can't be more than " + 1000);
				}
				boardId = value;
			}
		}

		public int PcId
		{
			get
			{
				return pcId;
			}
			set
			{
				pcId = value;
			}
		}

		public SetScoreRequest()
			: base(ServiceTypes.Ranking, FunctionTypes.RankingSetScore)
		{
			gameInfoData = new byte[189];
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetRangeOfRanksRequest : RequestBase
	{
		[MarshalAs(UnmanagedType.U4)]
		internal uint boardId;

		[MarshalAs(UnmanagedType.U4)]
		internal uint startRank;

		[MarshalAs(UnmanagedType.U4)]
		internal uint range;

		[MarshalAs(UnmanagedType.I1)]
		internal bool isCrossSaveInformation;

		public uint BoardId
		{
			get
			{
				return boardId;
			}
			set
			{
				if (value > 1000)
				{
					throw new NpToolkitException("The BoardId can't be more than " + 1000);
				}
				boardId = value;
			}
		}

		public uint StartRank
		{
			get
			{
				return startRank;
			}
			set
			{
				if (value < 1)
				{
					throw new NpToolkitException("The StartRank can't be less than " + 1);
				}
				startRank = value;
			}
		}

		public uint Range
		{
			get
			{
				return range;
			}
			set
			{
				if (value < 1 || value > 100)
				{
					throw new NpToolkitException("The Range must be between " + 1 + " and " + 100);
				}
				range = value;
			}
		}

		public bool IsCrossSaveInformation
		{
			get
			{
				return isCrossSaveInformation;
			}
			set
			{
				isCrossSaveInformation = value;
			}
		}

		public GetRangeOfRanksRequest()
			: base(ServiceTypes.Ranking, FunctionTypes.RankingGetRangeOfRanks)
		{
			IsCrossSaveInformation = false;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetFriendsRanksRequest : RequestBase
	{
		[MarshalAs(UnmanagedType.U4)]
		internal uint boardId;

		[MarshalAs(UnmanagedType.U4)]
		internal uint startRank;

		[MarshalAs(UnmanagedType.U4)]
		internal uint friendsWithPcId;

		[MarshalAs(UnmanagedType.I1)]
		internal bool isCrossSaveInformation;

		[MarshalAs(UnmanagedType.I1)]
		internal bool addCallingUserRank;

		public uint BoardId
		{
			get
			{
				return boardId;
			}
			set
			{
				boardId = value;
			}
		}

		public uint StartRank
		{
			get
			{
				return startRank;
			}
			set
			{
				startRank = value;
			}
		}

		public uint FriendsWithPcId
		{
			get
			{
				return friendsWithPcId;
			}
			set
			{
				friendsWithPcId = value;
			}
		}

		public bool IsCrossSaveInformation
		{
			get
			{
				return isCrossSaveInformation;
			}
			set
			{
				isCrossSaveInformation = value;
			}
		}

		public bool AddCallingUserRank
		{
			get
			{
				return addCallingUserRank;
			}
			set
			{
				addCallingUserRank = value;
			}
		}

		public GetFriendsRanksRequest()
			: base(ServiceTypes.Ranking, FunctionTypes.RankingGetFriendsRanks)
		{
			IsCrossSaveInformation = false;
			addCallingUserRank = true;
		}
	}

	public struct ScoreAccountIdPcId
	{
		public Core.NpAccountId accountId;

		public int pcId;
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetUsersRanksRequest : RequestBase
	{
		public const int MAX_NUM_USERS = 101;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 101)]
		internal ScoreAccountIdPcId[] users;

		[MarshalAs(UnmanagedType.U4)]
		internal uint numUsers;

		[MarshalAs(UnmanagedType.U4)]
		internal uint boardId;

		[MarshalAs(UnmanagedType.I1)]
		internal bool isCrossSaveInformation;

		[MarshalAs(UnmanagedType.I1)]
		internal bool ignorePcIds;

		public ScoreAccountIdPcId[] Users
		{
			get
			{
				if (numUsers == 0)
				{
					return null;
				}
				ScoreAccountIdPcId[] array = new ScoreAccountIdPcId[numUsers];
				Array.Copy(users, array, numUsers);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 101)
					{
						throw new NpToolkitException("The size of the Users array is more than " + 101);
					}
					if (!IgnorePcIds)
					{
						for (int i = 0; i < value.Length; i++)
						{
							if (value[i].pcId < 0 || value[i].pcId > 9)
							{
								throw new NpToolkitException("The pcId in Users[" + i + "] is outside the range of MIN_PCID/MAX_PCID");
							}
						}
					}
					value.CopyTo(users, 0);
					numUsers = (uint)value.Length;
				}
				else
				{
					numUsers = 0u;
				}
			}
		}

		public uint BoardId
		{
			get
			{
				return boardId;
			}
			set
			{
				boardId = value;
			}
		}

		public bool IsCrossSaveInformation
		{
			get
			{
				return isCrossSaveInformation;
			}
			set
			{
				isCrossSaveInformation = value;
			}
		}

		public bool IgnorePcIds
		{
			get
			{
				return ignorePcIds;
			}
			set
			{
				ignorePcIds = value;
			}
		}

		public GetUsersRanksRequest()
			: base(ServiceTypes.Ranking, FunctionTypes.RankingGetUsersRanks)
		{
			users = new ScoreAccountIdPcId[101];
			IsCrossSaveInformation = false;
			ignorePcIds = true;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class SetGameDataRequest : RequestBase
	{
		internal uint boardId;

		internal int idOfPrevChunk;

		internal long score;

		internal ulong totalSize;

		[MarshalAs(UnmanagedType.LPArray)]
		internal byte[] data;

		internal ulong byteOffset;

		internal ulong chunkDataSize;

		internal int pcId;

		public uint BoardId
		{
			get
			{
				return boardId;
			}
			set
			{
				boardId = value;
			}
		}

		public int IdOfPrevChunk
		{
			get
			{
				return idOfPrevChunk;
			}
			set
			{
				idOfPrevChunk = value;
			}
		}

		public long Score
		{
			get
			{
				return score;
			}
			set
			{
				score = value;
			}
		}

		public ulong TotalSize => totalSize;

		public byte[] Data => data;

		public ulong StartIndex => byteOffset;

		public int PcId
		{
			get
			{
				return pcId;
			}
			set
			{
				pcId = value;
			}
		}

		public void SetDataChunk(byte[] data, ulong startIndex, ulong chunkSize)
		{
			SetDataChunk(data, startIndex, chunkSize, 0uL);
		}

		public void SetDataChunk(byte[] data, ulong startIndex, ulong chunkSize, ulong totalSize)
		{
			if (startIndex + chunkSize > (ulong)data.Length)
			{
				throw new NpToolkitException("The start Index and chunk size go off the end of the data array.");
			}
			this.data = data;
			byteOffset = startIndex;
			chunkDataSize = chunkSize;
			if (totalSize == 0)
			{
				this.totalSize = (ulong)data.Length;
			}
			else
			{
				this.totalSize = totalSize;
			}
		}

		public SetGameDataRequest()
			: base(ServiceTypes.Ranking, FunctionTypes.RankingSetGameData)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetGameDataRequest : RequestBase
	{
		internal uint boardId;

		internal int idOfPrevChunk;

		internal Core.NpAccountId accountId;

		internal byte[] rcvData;

		internal ulong byteOffset;

		internal ulong chunkToRcvDataSize;

		internal int pcId;

		public uint BoardId
		{
			get
			{
				return boardId;
			}
			set
			{
				boardId = value;
			}
		}

		public int IdOfPrevChunk
		{
			get
			{
				return idOfPrevChunk;
			}
			set
			{
				idOfPrevChunk = value;
			}
		}

		public Core.NpAccountId AccountId
		{
			get
			{
				return accountId;
			}
			set
			{
				accountId = value;
			}
		}

		public byte[] RcvData => rcvData;

		public int PcId
		{
			get
			{
				return pcId;
			}
			set
			{
				pcId = value;
			}
		}

		public void SetRcvDataChunk(byte[] data, ulong startIndex, ulong chunkSize)
		{
			if (startIndex + chunkSize > (ulong)data.Length)
			{
				throw new NpToolkitException("The start Index and chunk size go off the end of the data array.");
			}
			rcvData = data;
			byteOffset = startIndex;
			chunkToRcvDataSize = chunkSize;
		}

		public GetGameDataRequest()
			: base(ServiceTypes.Ranking, FunctionTypes.RankingGetGameData)
		{
		}
	}

	public class TempRankResponse : ResponseBase
	{
		internal uint tempRank;

		public uint TempRank => tempRank;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.TempRankBegin);
			tempRank = memoryBuffer.ReadUInt32();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.TempRankEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class ScoreRankDataBase
	{
		internal string utf8Comment;

		internal byte[] gameInfo;

		internal int pcId;

		internal uint serialRank;

		internal uint rank;

		internal uint highestRank;

		internal bool hasGameData;

		internal long scoreValue;

		internal DateTime recordDate;

		internal Core.NpAccountId accountId;

		public string Comment => utf8Comment;

		public byte[] GameInfo => gameInfo;

		public int PcId => pcId;

		public uint SerialRank => serialRank;

		public uint Rank => rank;

		public uint HighestRank => highestRank;

		public bool HasGameData => hasGameData;

		public long ScoreValue => scoreValue;

		public DateTime RecordDate => recordDate;

		public Core.NpAccountId AccountId => accountId;

		internal void ReadBase(MemoryBuffer buffer)
		{
			pcId = buffer.ReadInt32();
			serialRank = buffer.ReadUInt32();
			rank = buffer.ReadUInt32();
			highestRank = buffer.ReadUInt32();
			hasGameData = buffer.ReadBool();
			scoreValue = buffer.ReadInt64();
			recordDate = Core.ReadRtcTick(buffer);
			accountId.Read(buffer);
		}

		internal void ReadAdditionalData(MemoryBuffer buffer)
		{
			buffer.ReadString(ref utf8Comment);
			buffer.ReadData(ref gameInfo);
		}
	}

	public class ScoreRankData : ScoreRankDataBase
	{
		internal Core.OnlineID onlineId;

		public Core.OnlineID OnlineId => onlineId;

		internal void ReadData(MemoryBuffer buffer)
		{
			ReadBase(buffer);
			onlineId = new Core.OnlineID();
			onlineId.Read(buffer);
		}
	}

	public class ScoreRankDataForCrossSave : ScoreRankDataBase
	{
		internal Core.NpId npId;

		public Core.NpId NpId => npId;

		internal void ReadData(MemoryBuffer buffer)
		{
			ReadBase(buffer);
			npId.Read(buffer);
		}
	}

	public class ScorePlayerRankData : ScoreRankData
	{
		internal bool hasData;

		public bool HasData => hasData;

		internal void Read(MemoryBuffer buffer)
		{
			hasData = buffer.ReadBool();
			if (hasData)
			{
				ReadData(buffer);
			}
		}
	}

	public class ScorePlayerRankDataForCrossSave : ScoreRankDataForCrossSave
	{
		internal bool hasData;

		public bool HasData => hasData;

		internal void Read(MemoryBuffer buffer)
		{
			hasData = buffer.ReadBool();
			if (hasData)
			{
				ReadData(buffer);
			}
		}
	}

	public class RangeOfRanksResponse : ResponseBase
	{
		internal ScoreRankData[] scoreRankData;

		internal ScoreRankDataForCrossSave[] scoreRankDataForCrossSave;

		internal bool isCrossSaveInformation;

		internal ulong numValidEntries;

		internal DateTime updateTime;

		internal uint totalEntriesOnBoard;

		internal uint boardId;

		internal int startRank;

		public ScoreRankData[] RankData
		{
			get
			{
				if (isCrossSaveInformation)
				{
					throw new NpToolkitException("RankData isn't valid unless 'IsCrossSaveInformation' is set to false.");
				}
				return scoreRankData;
			}
		}

		public ScoreRankDataForCrossSave[] RankDataForCrossSave
		{
			get
			{
				if (!isCrossSaveInformation)
				{
					throw new NpToolkitException("RankDataForCrossSave isn't valid unless 'IsCrossSaveInformation' is set to true.");
				}
				return scoreRankDataForCrossSave;
			}
		}

		public bool IsCrossSaveInformation => isCrossSaveInformation;

		public DateTime UpdateTime => updateTime;

		public uint TotalEntriesOnBoard => totalEntriesOnBoard;

		public uint BoardId => boardId;

		public ulong NumValidEntries => numValidEntries;

		public int StartRank => startRank;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.RangeOfRanksBegin);
			isCrossSaveInformation = memoryBuffer.ReadBool();
			ulong num = memoryBuffer.ReadUInt64();
			scoreRankData = null;
			scoreRankDataForCrossSave = null;
			if (num != 0)
			{
				if (isCrossSaveInformation)
				{
					scoreRankDataForCrossSave = new ScoreRankDataForCrossSave[num];
					for (ulong num2 = 0uL; num2 < num; num2++)
					{
						scoreRankDataForCrossSave[num2] = new ScoreRankDataForCrossSave();
						scoreRankDataForCrossSave[num2].ReadData(memoryBuffer);
						scoreRankDataForCrossSave[num2].ReadAdditionalData(memoryBuffer);
					}
				}
				else
				{
					scoreRankData = new ScoreRankData[num];
					for (ulong num2 = 0uL; num2 < num; num2++)
					{
						scoreRankData[num2] = new ScoreRankData();
						scoreRankData[num2].ReadData(memoryBuffer);
						scoreRankData[num2].ReadAdditionalData(memoryBuffer);
					}
				}
			}
			numValidEntries = memoryBuffer.ReadUInt64();
			updateTime = Core.ReadRtcTick(memoryBuffer);
			totalEntriesOnBoard = memoryBuffer.ReadUInt32();
			boardId = memoryBuffer.ReadUInt32();
			startRank = memoryBuffer.ReadInt32();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.RangeOfRanksEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class FriendsRanksResponse : ResponseBase
	{
		internal ScoreRankData[] scoreRankData;

		internal ScoreRankDataForCrossSave[] scoreRankDataForCrossSave;

		internal bool isCrossSaveInformation;

		internal ulong numFriends;

		internal DateTime updateTime;

		internal uint boardId;

		internal uint totalEntriesOnBoard;

		internal uint totalFriendsOnBoard;

		internal int friendsWithPcId;

		public ScoreRankData[] RankData
		{
			get
			{
				if (isCrossSaveInformation)
				{
					throw new NpToolkitException("RankData isn't valid unless 'IsCrossSaveInformation' is set to false.");
				}
				return scoreRankData;
			}
		}

		public ScoreRankDataForCrossSave[] RankDataForCrossSave
		{
			get
			{
				if (!isCrossSaveInformation)
				{
					throw new NpToolkitException("RankDataForCrossSave isn't valid unless 'IsCrossSaveInformation' is set to true.");
				}
				return scoreRankDataForCrossSave;
			}
		}

		public bool IsCrossSaveInformation => isCrossSaveInformation;

		public ulong NumFriends => numFriends;

		public DateTime UpdateTime => updateTime;

		public uint BoardId => boardId;

		public uint TotalEntriesOnBoard => totalEntriesOnBoard;

		public uint TotalFriendsOnBoard => totalFriendsOnBoard;

		public int FriendsWithPcId => friendsWithPcId;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.FriendsRanksBegin);
			isCrossSaveInformation = memoryBuffer.ReadBool();
			numFriends = memoryBuffer.ReadUInt64();
			scoreRankData = null;
			scoreRankDataForCrossSave = null;
			if (isCrossSaveInformation)
			{
				scoreRankDataForCrossSave = new ScoreRankDataForCrossSave[numFriends];
				for (ulong num = 0uL; num < numFriends; num++)
				{
					scoreRankDataForCrossSave[num] = new ScoreRankDataForCrossSave();
					scoreRankDataForCrossSave[num].ReadData(memoryBuffer);
					scoreRankDataForCrossSave[num].ReadAdditionalData(memoryBuffer);
				}
			}
			else
			{
				scoreRankData = new ScoreRankData[numFriends];
				for (ulong num = 0uL; num < numFriends; num++)
				{
					scoreRankData[num] = new ScoreRankData();
					scoreRankData[num].ReadData(memoryBuffer);
					scoreRankData[num].ReadAdditionalData(memoryBuffer);
				}
			}
			updateTime = Core.ReadRtcTick(memoryBuffer);
			boardId = memoryBuffer.ReadUInt32();
			totalEntriesOnBoard = memoryBuffer.ReadUInt32();
			totalFriendsOnBoard = memoryBuffer.ReadUInt32();
			friendsWithPcId = memoryBuffer.ReadInt32();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.FriendsRanksEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class UsersRanksResponse : ResponseBase
	{
		internal ScorePlayerRankData[] users;

		internal ScorePlayerRankDataForCrossSave[] usersForCrossSave;

		internal bool isCrossSaveInformation;

		internal ulong numUsers;

		internal ulong numValidUsers;

		internal DateTime updateTime;

		internal uint boardId;

		internal uint totalEntriesOnBoard;

		public ScorePlayerRankData[] Users
		{
			get
			{
				if (isCrossSaveInformation)
				{
					throw new NpToolkitException("RankData isn't valid unless 'IsCrossSaveInformation' is set to false.");
				}
				return users;
			}
		}

		public ScorePlayerRankDataForCrossSave[] UsersForCrossSave
		{
			get
			{
				if (!isCrossSaveInformation)
				{
					throw new NpToolkitException("RankDataForCrossSave isn't valid unless 'IsCrossSaveInformation' is set to true.");
				}
				return usersForCrossSave;
			}
		}

		public bool IsCrossSaveInformation => isCrossSaveInformation;

		public ulong NumUsers => numUsers;

		public ulong NumValidUsers => numValidUsers;

		public DateTime UpdateTime => updateTime;

		public uint BoardId => boardId;

		public uint TotalEntriesOnBoard => totalEntriesOnBoard;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.UsersRanksBegin);
			isCrossSaveInformation = memoryBuffer.ReadBool();
			numUsers = memoryBuffer.ReadUInt64();
			numValidUsers = memoryBuffer.ReadUInt64();
			users = null;
			usersForCrossSave = null;
			if (isCrossSaveInformation)
			{
				usersForCrossSave = new ScorePlayerRankDataForCrossSave[numUsers];
				for (ulong num = 0uL; num < numUsers; num++)
				{
					usersForCrossSave[num] = new ScorePlayerRankDataForCrossSave();
					usersForCrossSave[num].Read(memoryBuffer);
					if (usersForCrossSave[num].HasData)
					{
						usersForCrossSave[num].ReadAdditionalData(memoryBuffer);
					}
				}
			}
			else
			{
				users = new ScorePlayerRankData[numUsers];
				for (ulong num = 0uL; num < numUsers; num++)
				{
					users[num] = new ScorePlayerRankData();
					users[num].Read(memoryBuffer);
					if (users[num].HasData)
					{
						users[num].ReadAdditionalData(memoryBuffer);
					}
				}
			}
			updateTime = Core.ReadRtcTick(memoryBuffer);
			boardId = memoryBuffer.ReadUInt32();
			totalEntriesOnBoard = memoryBuffer.ReadUInt32();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.UsersRanksEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class SetGameDataResultResponse : ResponseBase
	{
		internal int chunkId;

		public int ChunkId => chunkId;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.SetGameDataBegin);
			chunkId = memoryBuffer.ReadInt32();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.SetGameDataEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class GetGameDataResultResponse : ResponseBase
	{
		internal ulong totalSize;

		internal ulong rcvDataSize;

		internal ulong rcvDataValidSize;

		internal ulong startIndex;

		internal int chunkId;

		internal byte[] rcvData;

		public ulong TotalSize => totalSize;

		public ulong RcvDataSize => rcvDataSize;

		public ulong RcvDataValidSize => rcvDataValidSize;

		public ulong StartIndex => startIndex;

		public byte[] RcvData => rcvData;

		public int ChunkId => chunkId;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.GetGameDataBegin);
			totalSize = memoryBuffer.ReadUInt64();
			rcvDataSize = memoryBuffer.ReadUInt64();
			rcvDataValidSize = memoryBuffer.ReadUInt64();
			chunkId = memoryBuffer.ReadInt32();
			GetGameDataRequest getGameDataRequest = request as GetGameDataRequest;
			rcvData = getGameDataRequest.rcvData;
			startIndex = getGameDataRequest.byteOffset;
			memoryBuffer.ReadData(ref rcvData, (uint)startIndex);
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.GetGameDataEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public const int MAX_NUM_BOARDS = 1000;

	public const int MIN_PCID = 0;

	public const int MAX_PCID = 9;

	public const int MAX_RANGE = 100;

	public const int MIN_RANGE = 1;

	public const int FIRST_RANK = 1;

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxSetScore(SetScoreRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetRangeOfRanks(GetRangeOfRanksRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetFriendsRanks(GetFriendsRanksRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetUsersRanks(GetUsersRanksRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxSetGameData(SetGameDataRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetGameData(GetGameDataRequest request, out APIResult result);

	public static int SetScore(SetScoreRequest request, TempRankResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxSetScore(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetRangeOfRanks(GetRangeOfRanksRequest request, RangeOfRanksResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetRangeOfRanks(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetFriendsRanks(GetFriendsRanksRequest request, FriendsRanksResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetFriendsRanks(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetUsersRanks(GetUsersRanksRequest request, UsersRanksResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetUsersRanks(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int SetGameData(SetGameDataRequest request, SetGameDataResultResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxSetGameData(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetGameData(GetGameDataRequest request, GetGameDataResultResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetGameData(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}
}
public class Trophies
{
	[StructLayout(LayoutKind.Sequential)]
	public class RegisterTrophyPackRequest : RequestBase
	{
		public RegisterTrophyPackRequest()
			: base(ServiceTypes.Trophy, FunctionTypes.TrophyRegisterTrophyPack)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class UnlockTrophyRequest : RequestBase
	{
		internal int trophyId;

		public int TrophyId
		{
			get
			{
				return trophyId;
			}
			set
			{
				trophyId = value;
			}
		}

		public UnlockTrophyRequest()
			: base(ServiceTypes.Trophy, FunctionTypes.TrophyUnlock)
		{
			trophyId = -1;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class SetScreenshotRequest : RequestBase
	{
		public const int INVALID_TROPHY_ID = -1;

		public const int MAX_NUMBER_TROPHIES = 4;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		internal int[] trophiesIds;

		internal uint numTrophiesIds;

		[MarshalAs(UnmanagedType.I1)]
		internal bool assignToAllUsers;

		public int[] TrophiesIds
		{
			get
			{
				if (numTrophiesIds == 0)
				{
					return null;
				}
				int[] array = new int[numTrophiesIds];
				Array.Copy(trophiesIds, array, numTrophiesIds);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 4)
					{
						throw new NpToolkitException("The size of the TrophyIds array is more than " + 4);
					}
					value.CopyTo(trophiesIds, 0);
					numTrophiesIds = (uint)value.Length;
				}
				else
				{
					numTrophiesIds = 0u;
				}
			}
		}

		public bool AssignToAllUsers
		{
			get
			{
				return assignToAllUsers;
			}
			set
			{
				assignToAllUsers = value;
			}
		}

		public SetScreenshotRequest()
			: base(ServiceTypes.Trophy, FunctionTypes.TrophySetScreenshot)
		{
			trophiesIds = new int[4];
			numTrophiesIds = 0u;
			assignToAllUsers = true;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetUnlockedTrophiesRequest : RequestBase
	{
		public GetUnlockedTrophiesRequest()
			: base(ServiceTypes.Trophy, FunctionTypes.TrophyGetUnlockedTrophies)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class DisplayTrophyListDialogRequest : RequestBase
	{
		public DisplayTrophyListDialogRequest()
			: base(ServiceTypes.Trophy, FunctionTypes.TrophyDisplayTrophyListDialog)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetTrophyPackSummaryRequest : RequestBase
	{
		[MarshalAs(UnmanagedType.I1)]
		internal bool retrieveTrophyPackSummaryIcon;

		public bool RetrieveTrophyPackSummaryIcon
		{
			get
			{
				return retrieveTrophyPackSummaryIcon;
			}
			set
			{
				retrieveTrophyPackSummaryIcon = value;
			}
		}

		public GetTrophyPackSummaryRequest()
			: base(ServiceTypes.Trophy, FunctionTypes.TrophyGetTrophyPackSummary)
		{
			retrieveTrophyPackSummaryIcon = false;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetTrophyPackGroupRequest : RequestBase
	{
		internal int groupId;

		[MarshalAs(UnmanagedType.I1)]
		internal bool retrieveTrophyPackGroupIcon;

		public int GroupId
		{
			get
			{
				return groupId;
			}
			set
			{
				groupId = value;
			}
		}

		public bool RetrieveTrophyPackGroupIcon
		{
			get
			{
				return retrieveTrophyPackGroupIcon;
			}
			set
			{
				retrieveTrophyPackGroupIcon = value;
			}
		}

		public GetTrophyPackGroupRequest()
			: base(ServiceTypes.Trophy, FunctionTypes.TrophyGetTrophyPackGroup)
		{
			groupId = -1;
			retrieveTrophyPackGroupIcon = false;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetTrophyPackTrophyRequest : RequestBase
	{
		internal int trophyId;

		internal bool retrieveTrophyPackTrophyIcon;

		public int TrophyId
		{
			get
			{
				return trophyId;
			}
			set
			{
				trophyId = value;
			}
		}

		public bool RetrieveTrophyPackTrophyIcon
		{
			get
			{
				return retrieveTrophyPackTrophyIcon;
			}
			set
			{
				retrieveTrophyPackTrophyIcon = value;
			}
		}

		public GetTrophyPackTrophyRequest()
			: base(ServiceTypes.Trophy, FunctionTypes.TrophyGetTrophyPackTrophy)
		{
			trophyId = -1;
			retrieveTrophyPackTrophyIcon = false;
		}
	}

	public class UnlockedTrophiesResponse : ResponseBase
	{
		internal int[] trophyIds;

		public int[] TrophyIds => trophyIds;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.UnlockedTrophiesBegin);
			uint num = memoryBuffer.ReadUInt32();
			trophyIds = new int[num];
			for (int i = 0; i < num; i++)
			{
				trophyIds[i] = memoryBuffer.ReadInt32();
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.UnlockedTrophiesEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public struct NpTrophyGameDetails
	{
		internal uint numGroups;

		internal uint numTrophies;

		internal uint numPlatinum;

		internal uint numGold;

		internal uint numSilver;

		internal uint numBronze;

		internal string title;

		internal string description;

		public uint NumGroups => numGroups;

		public uint NumTrophies => numTrophies;

		public uint NumPlatinum => numPlatinum;

		public uint NumGold => numGold;

		public uint NumSilver => numSilver;

		public uint NumBronze => numBronze;

		public string Title => title;

		public string Description => description;

		internal void Read(MemoryBuffer buffer)
		{
			numGroups = buffer.ReadUInt32();
			numTrophies = buffer.ReadUInt32();
			numPlatinum = buffer.ReadUInt32();
			numGold = buffer.ReadUInt32();
			numSilver = buffer.ReadUInt32();
			numBronze = buffer.ReadUInt32();
			buffer.ReadString(ref title);
			buffer.ReadString(ref description);
		}
	}

	public struct NpTrophyGameData
	{
		internal uint unlockedTrophies;

		internal uint unlockedPlatinum;

		internal uint unlockedGold;

		internal uint unlockedSilver;

		internal uint unlockedBronze;

		internal uint progressPercentage;

		public uint UnlockedTrophies => unlockedTrophies;

		public uint UnlockedPlatinum => unlockedPlatinum;

		public uint UnlockedGold => unlockedGold;

		public uint UnlockedSilver => unlockedSilver;

		public uint UnlockedBronze => unlockedBronze;

		public uint ProgressPercentage => progressPercentage;

		internal void Read(MemoryBuffer buffer)
		{
			unlockedTrophies = buffer.ReadUInt32();
			unlockedPlatinum = buffer.ReadUInt32();
			unlockedGold = buffer.ReadUInt32();
			unlockedSilver = buffer.ReadUInt32();
			unlockedBronze = buffer.ReadUInt32();
			progressPercentage = buffer.ReadUInt32();
		}
	}

	public class TrophyPackSummaryResponse : ResponseBase
	{
		internal Icon icon = null;

		internal NpTrophyGameDetails staticConfiguration;

		internal NpTrophyGameData userProgress;

		public Icon Icon => icon;

		public NpTrophyGameDetails StaticConfiguration => staticConfiguration;

		public NpTrophyGameData UserProgress => userProgress;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.TrophyPackSummaryBegin);
			icon = Icon.ReadAndCreate(memoryBuffer);
			staticConfiguration.Read(memoryBuffer);
			userProgress.Read(memoryBuffer);
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.TrophyPackSummaryEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public struct NpTrophyGroupDetails
	{
		internal int groupId;

		internal uint numTrophies;

		internal uint numPlatinum;

		internal uint numGold;

		internal uint numSilver;

		internal uint numBronze;

		internal string title;

		internal string description;

		public int GroupId => groupId;

		public uint NumTrophies => numTrophies;

		public uint NumPlatinum => numPlatinum;

		public uint NumGold => numGold;

		public uint NumSilver => numSilver;

		public uint NumBronze => numBronze;

		public string Title => title;

		public string Description => description;

		internal void Read(MemoryBuffer buffer)
		{
			groupId = buffer.ReadInt32();
			numTrophies = buffer.ReadUInt32();
			numPlatinum = buffer.ReadUInt32();
			numGold = buffer.ReadUInt32();
			numSilver = buffer.ReadUInt32();
			numBronze = buffer.ReadUInt32();
			buffer.ReadString(ref title);
			buffer.ReadString(ref description);
		}
	}

	public struct NpTrophyGroupData
	{
		internal int groupId;

		internal uint unlockedTrophies;

		internal uint unlockedPlatinum;

		internal uint unlockedGold;

		internal uint unlockedSilver;

		internal uint unlockedBronze;

		internal uint progressPercentage;

		public int GroupId => groupId;

		public uint UnlockedTrophies => unlockedTrophies;

		public uint UnlockedPlatinum => unlockedPlatinum;

		public uint UnlockedGold => unlockedGold;

		public uint UnlockedSilver => unlockedSilver;

		public uint UnlockedBronze => unlockedBronze;

		public uint ProgressPercentage => progressPercentage;

		internal void Read(MemoryBuffer buffer)
		{
			groupId = buffer.ReadInt32();
			unlockedTrophies = buffer.ReadUInt32();
			unlockedPlatinum = buffer.ReadUInt32();
			unlockedGold = buffer.ReadUInt32();
			unlockedSilver = buffer.ReadUInt32();
			unlockedBronze = buffer.ReadUInt32();
			progressPercentage = buffer.ReadUInt32();
		}
	}

	public class TrophyPackGroupResponse : ResponseBase
	{
		internal Icon icon = null;

		internal NpTrophyGroupDetails staticConfiguration;

		internal NpTrophyGroupData userProgress;

		public Icon Icon => icon;

		public NpTrophyGroupDetails StaticConfiguration => staticConfiguration;

		public NpTrophyGroupData UserProgress => userProgress;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.TrophyPackGroupBegin);
			icon = Icon.ReadAndCreate(memoryBuffer);
			staticConfiguration.Read(memoryBuffer);
			userProgress.Read(memoryBuffer);
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.TrophyPackGroupEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public enum TrophyGrade
	{
		Unknown,
		Platinum,
		Gold,
		Silver,
		Bronze
	}

	public struct NpTrophyDetails
	{
		internal int trophyId;

		internal TrophyGrade trophyGrade;

		internal int groupId;

		internal bool hidden;

		internal string name;

		internal string description;

		public int TrophyId => trophyId;

		public TrophyGrade TrophyGrade => trophyGrade;

		public int GroupId => groupId;

		public bool Hidden => hidden;

		public string Name => name;

		public string Description => description;

		internal void Read(MemoryBuffer buffer)
		{
			trophyId = buffer.ReadInt32();
			trophyGrade = (TrophyGrade)buffer.ReadInt32();
			groupId = buffer.ReadInt32();
			hidden = buffer.ReadBool();
			buffer.ReadString(ref name);
			buffer.ReadString(ref description);
		}
	}

	public struct NpTrophyData
	{
		internal int trophyId;

		internal bool unlocked;

		internal DateTime timestamp;

		public int TrophyId => trophyId;

		public bool Unlocked => unlocked;

		public DateTime Timestamp => timestamp;

		internal void Read(MemoryBuffer buffer)
		{
			trophyId = buffer.ReadInt32();
			unlocked = buffer.ReadBool();
			timestamp = Core.ReadRtcTick(buffer);
		}
	}

	public class TrophyPackTrophyResponse : ResponseBase
	{
		internal Icon icon = null;

		internal NpTrophyDetails staticConfiguration;

		internal NpTrophyData userProgress;

		public Icon Icon => icon;

		public NpTrophyDetails StaticConfiguration => staticConfiguration;

		public NpTrophyData UserProgress => userProgress;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.TrophyPackTrophyBegin);
			icon = Icon.ReadAndCreate(memoryBuffer);
			staticConfiguration.Read(memoryBuffer);
			userProgress.Read(memoryBuffer);
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.TrophyPackTrophyEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxRegisterTrophyPack(RegisterTrophyPackRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxUnlockTrophy(UnlockTrophyRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxSetScreenshot(SetScreenshotRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetUnlockedTrophies(GetUnlockedTrophiesRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxDisplayTrophyListDialog(DisplayTrophyListDialogRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetTrophyPackSummary(GetTrophyPackSummaryRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetTrophyPackGroup(GetTrophyPackGroupRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetTrophyPackTrophy(GetTrophyPackTrophyRequest request, out APIResult result);

	public static int RegisterTrophyPack(RegisterTrophyPackRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxRegisterTrophyPack(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int SetScreenshot(SetScreenshotRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxSetScreenshot(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int UnlockTrophy(UnlockTrophyRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		if (request.trophyId < 0)
		{
			throw new NpToolkitException("Invalid trophy id has been used.");
		}
		APIResult result;
		int num = PrxUnlockTrophy(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetUnlockedTrophies(GetUnlockedTrophiesRequest request, UnlockedTrophiesResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetUnlockedTrophies(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int DisplayTrophyListDialog(DisplayTrophyListDialogRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxDisplayTrophyListDialog(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetTrophyPackSummary(GetTrophyPackSummaryRequest request, TrophyPackSummaryResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetTrophyPackSummary(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetTrophyPackGroup(GetTrophyPackGroupRequest request, TrophyPackGroupResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetTrophyPackGroup(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetTrophyPackTrophy(GetTrophyPackTrophyRequest request, TrophyPackTrophyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetTrophyPackTrophy(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}
}
public class Tss
{
	[StructLayout(LayoutKind.Sequential)]
	public class GetDataRequest : RequestBase
	{
		internal ulong offset;

		internal ulong length;

		internal ulong lastModifiedTicks;

		internal int tssSlotId;

		[MarshalAs(UnmanagedType.I1)]
		internal bool retrieveStatusOnly;

		public ulong Offset
		{
			get
			{
				return offset;
			}
			set
			{
				offset = value;
			}
		}

		public ulong Length
		{
			get
			{
				return length;
			}
			set
			{
				length = value;
			}
		}

		public DateTime LastModifiedTicks
		{
			get
			{
				return Core.RtcTicksToDateTime(lastModifiedTicks);
			}
			set
			{
				lastModifiedTicks = Core.DateTimeToRtcTicks(value);
			}
		}

		public int TssSlotId
		{
			get
			{
				return tssSlotId;
			}
			set
			{
				tssSlotId = value;
			}
		}

		public bool RetrieveStatusOnly
		{
			get
			{
				return retrieveStatusOnly;
			}
			set
			{
				retrieveStatusOnly = value;
			}
		}

		public GetDataRequest()
			: base(ServiceTypes.Tss, FunctionTypes.TssGetData)
		{
		}
	}

	public enum TssStatusCodes
	{
		Ok,
		Partial,
		NotModified
	}

	public class TssDataResponse : ResponseBase
	{
		internal byte[] data;

		internal DateTime lastModified;

		internal TssStatusCodes statusCode;

		internal long contentLength;

		public byte[] Data => data;

		public DateTime LastModified => lastModified;

		public TssStatusCodes StatusCode => statusCode;

		public long ContentLength => contentLength;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.TssDataBegin);
			memoryBuffer.ReadData(ref data);
			lastModified = Core.ReadRtcTick(memoryBuffer);
			statusCode = (TssStatusCodes)memoryBuffer.ReadInt32();
			contentLength = memoryBuffer.ReadInt64();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.TssDataEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxTssGetData(GetDataRequest request, out APIResult result);

	public static int GetData(GetDataRequest request, TssDataResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxTssGetData(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}
}
public class Tus
{
	public struct VirtualUserID
	{
		public const int NP_ONLINEID_MAX_LENGTH = 16;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		internal string name;

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				if (value.Length > 16)
				{
					throw new NpToolkitException("VirtualUserID can't be more than " + 16 + " characters.");
				}
				name = value;
			}
		}

		internal void Read(MemoryBuffer buffer)
		{
			buffer.ReadString(ref name);
		}

		public override string ToString()
		{
			return name;
		}
	}

	public struct Variable
	{
		internal long varValue;

		internal int slotId;

		public long Value
		{
			get
			{
				return varValue;
			}
			set
			{
				varValue = value;
			}
		}

		public int SlotId
		{
			get
			{
				return slotId;
			}
			set
			{
				slotId = value;
			}
		}
	}

	public class NpVariableBase
	{
		internal bool hasData;

		internal DateTime lastChangedDate;

		internal long variable;

		internal long oldVariable;

		internal Core.NpAccountId ownerAccountId;

		internal Core.NpAccountId lastChangedAuthorAccountId;

		public bool HasData => hasData;

		public DateTime LastChangedDate => lastChangedDate;

		public long Variable => variable;

		public long OldVariable => oldVariable;

		public Core.NpAccountId OwnerAccountId => ownerAccountId;

		public Core.NpAccountId LastChangedAuthorAccountId => lastChangedAuthorAccountId;

		internal void ReadBase(MemoryBuffer buffer)
		{
			hasData = buffer.ReadBool();
			lastChangedDate = Core.ReadRtcTick(buffer);
			variable = buffer.ReadInt64();
			oldVariable = buffer.ReadInt64();
			ownerAccountId.Read(buffer);
			lastChangedAuthorAccountId.Read(buffer);
		}
	}

	public class NpVariable : NpVariableBase
	{
		internal Core.OnlineID ownerId;

		internal Core.OnlineID lastChangedAuthorId;

		public Core.OnlineID OwnerId => ownerId;

		public Core.OnlineID LastChangedAuthorId => lastChangedAuthorId;

		internal void Read(MemoryBuffer buffer)
		{
			ReadBase(buffer);
			ownerId = new Core.OnlineID();
			ownerId.Read(buffer);
			lastChangedAuthorId = new Core.OnlineID();
			lastChangedAuthorId.Read(buffer);
		}
	}

	public class NpVariableForCrossSave : NpVariableBase
	{
		internal Core.NpId ownerId;

		internal Core.NpId lastChangedAuthorId;

		public Core.NpId OwnerId => ownerId;

		public Core.NpId LastChangedAuthorId => lastChangedAuthorId;

		internal void Read(MemoryBuffer buffer)
		{
			ReadBase(buffer);
			ownerId.Read(buffer);
			lastChangedAuthorId.Read(buffer);
		}
	}

	public class NpTusDataStatusBase
	{
		internal bool hasData;

		internal DateTime lastChangedDate;

		internal byte[] data;

		internal byte[] supplementaryInfo;

		internal Core.NpAccountId ownerAccountId;

		internal Core.NpAccountId lastChangedAuthorAccountId;

		public bool HasData => hasData;

		public DateTime LastChangedDate => lastChangedDate;

		public byte[] Data => data;

		public byte[] SupplementaryInfo => supplementaryInfo;

		public Core.NpAccountId OwnerAccountId => ownerAccountId;

		public Core.NpAccountId LastChangedAuthorAccountId => lastChangedAuthorAccountId;

		internal void ReadBase(MemoryBuffer buffer)
		{
			hasData = buffer.ReadBool();
			lastChangedDate = Core.ReadRtcTick(buffer);
			buffer.ReadData(ref data);
			buffer.ReadData(ref supplementaryInfo);
			ownerAccountId.Read(buffer);
			lastChangedAuthorAccountId.Read(buffer);
		}
	}

	public class NpTusDataStatus : NpTusDataStatusBase
	{
		internal Core.OnlineID ownerId;

		internal Core.OnlineID lastChangedAuthorId;

		public Core.OnlineID OwnerId => ownerId;

		public Core.OnlineID LastChangedAuthorId => lastChangedAuthorId;

		internal void Read(MemoryBuffer buffer)
		{
			ReadBase(buffer);
			ownerId = new Core.OnlineID();
			ownerId.Read(buffer);
			lastChangedAuthorId = new Core.OnlineID();
			lastChangedAuthorId.Read(buffer);
		}
	}

	public class NpTusDataStatusForCrossSave : NpTusDataStatusBase
	{
		internal Core.NpId ownerId;

		internal Core.NpId lastChangedAuthorId;

		public Core.NpId OwnerId => ownerId;

		public Core.NpId LastChangedAuthorId => lastChangedAuthorId;

		internal void Read(MemoryBuffer buffer)
		{
			ReadBase(buffer);
			ownerId.Read(buffer);
			lastChangedAuthorId.Read(buffer);
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class SetVariablesRequest : RequestBase
	{
		public const int MAX_VARIABLE_SLOTS = 64;

		internal ulong numVars;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		private Variable[] vars = new Variable[64];

		internal Core.NpAccountId targetUser;

		internal VirtualUserID virtualUserID;

		[MarshalAs(UnmanagedType.I1)]
		internal bool isVirtualUser;

		public Variable[] Vars
		{
			get
			{
				if (numVars == 0)
				{
					return null;
				}
				Variable[] array = new Variable[numVars];
				Array.Copy(vars, array, (int)numVars);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 64)
					{
						throw new NpToolkitException("The size of the array is larger than " + 64);
					}
					value.CopyTo(vars, 0);
					numVars = (ulong)value.Length;
				}
				else
				{
					numVars = 0uL;
				}
			}
		}

		public Core.NpAccountId TargetUser
		{
			get
			{
				if (isVirtualUser)
				{
					throw new NpToolkitException("A virtual user id is currently configured on for this request, meaning the TargetUser is not valid");
				}
				return targetUser;
			}
			set
			{
				targetUser = value;
				isVirtualUser = false;
			}
		}

		public VirtualUserID VirtualUserID
		{
			get
			{
				if (!isVirtualUser)
				{
					throw new NpToolkitException("This request doesn't have a virtual user id current set.");
				}
				return virtualUserID;
			}
			set
			{
				virtualUserID = value;
				if (value.name.Length > 0)
				{
					isVirtualUser = true;
				}
				else
				{
					isVirtualUser = false;
				}
			}
		}

		public bool IsVirtualUser => isVirtualUser;

		public SetVariablesRequest()
			: base(ServiceTypes.Tus, FunctionTypes.TusSetVariables)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetVariablesRequest : RequestBase
	{
		public const int MAX_VARIABLE_SLOTS = 64;

		internal ulong numSlots;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		internal int[] slotIds = new int[64];

		internal Core.NpAccountId targetUser;

		internal VirtualUserID virtualUserID;

		[MarshalAs(UnmanagedType.I1)]
		internal bool isVirtualUser;

		[MarshalAs(UnmanagedType.I1)]
		internal bool forCrossSave;

		public int[] SlotIds
		{
			get
			{
				if (numSlots == 0)
				{
					return null;
				}
				int[] array = new int[numSlots];
				Array.Copy(slotIds, array, (int)numSlots);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 64)
					{
						throw new NpToolkitException("The size of the array is larger than " + 64);
					}
					value.CopyTo(slotIds, 0);
					numSlots = (ulong)value.Length;
				}
				else
				{
					numSlots = 0uL;
				}
			}
		}

		public Core.NpAccountId TargetUser
		{
			get
			{
				if (isVirtualUser)
				{
					throw new NpToolkitException("A virtual user id is currently configured on for this request, meaning the TargetUser is not valid");
				}
				return targetUser;
			}
			set
			{
				targetUser = value;
				isVirtualUser = false;
			}
		}

		public VirtualUserID VirtualUserID
		{
			get
			{
				if (!isVirtualUser)
				{
					throw new NpToolkitException("This request doesn't have a virtual user id current set.");
				}
				return virtualUserID;
			}
			set
			{
				virtualUserID = value;
				if (value.name.Length > 0)
				{
					isVirtualUser = true;
				}
				else
				{
					isVirtualUser = false;
				}
			}
		}

		public bool IsVirtualUser => isVirtualUser;

		public GetVariablesRequest()
			: base(ServiceTypes.Tus, FunctionTypes.TusGetVariables)
		{
		}
	}

	public struct DataContention
	{
		internal ulong lastChangedDateTicks;

		internal Core.NpAccountId requiredLastChangeUser;

		public DateTime LastChangedDate
		{
			get
			{
				return Core.RtcTicksToDateTime(lastChangedDateTicks);
			}
			set
			{
				lastChangedDateTicks = Core.DateTimeToRtcTicks(value);
			}
		}

		public Core.NpAccountId RequiredLastChangeUser
		{
			get
			{
				return requiredLastChangeUser;
			}
			set
			{
				requiredLastChangeUser = value;
			}
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class AddToAndGetVariableRequest : RequestBase
	{
		internal Variable var;

		internal DataContention dataContention;

		internal Core.NpAccountId targetUser;

		internal VirtualUserID virtualUserID;

		[MarshalAs(UnmanagedType.I1)]
		internal bool isVirtualUser;

		[MarshalAs(UnmanagedType.I1)]
		internal bool forCrossSave;

		public Variable Var
		{
			get
			{
				return var;
			}
			set
			{
				var = value;
			}
		}

		public DataContention DataContention
		{
			get
			{
				return dataContention;
			}
			set
			{
				dataContention = value;
			}
		}

		public Core.NpAccountId TargetUser
		{
			get
			{
				if (isVirtualUser)
				{
					throw new NpToolkitException("A virtual user id is currently configured on for this request, meaning the TargetUser is not valid");
				}
				return targetUser;
			}
			set
			{
				targetUser = value;
				isVirtualUser = false;
			}
		}

		public VirtualUserID VirtualUserID
		{
			get
			{
				if (!isVirtualUser)
				{
					throw new NpToolkitException("This request doesn't have a virtual user id current set.");
				}
				return virtualUserID;
			}
			set
			{
				virtualUserID = value;
				if (value.name.Length > 0)
				{
					isVirtualUser = true;
				}
				else
				{
					isVirtualUser = false;
				}
			}
		}

		public bool IsVirtualUser => isVirtualUser;

		public bool ForCrossSave
		{
			get
			{
				return forCrossSave;
			}
			set
			{
				forCrossSave = value;
			}
		}

		public AddToAndGetVariableRequest()
			: base(ServiceTypes.Tus, FunctionTypes.TusAddToAndGetVariable)
		{
			dataContention.lastChangedDateTicks = 0uL;
			dataContention.requiredLastChangeUser = 0uL;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class SetDataRequest : RequestBase
	{
		public const int NP_TUS_DATA_INFO_MAX_SIZE = 384;

		[MarshalAs(UnmanagedType.LPArray)]
		internal byte[] data;

		internal ulong dataSize;

		internal Core.NpAccountId targetUser;

		internal ulong supplementaryInfoSize;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 384)]
		internal byte[] supplementaryInfo = new byte[384];

		internal DataContention dataContention;

		internal int slotId;

		internal VirtualUserID virtualUserID;

		[MarshalAs(UnmanagedType.I1)]
		internal bool isVirtualUser;

		public byte[] Data
		{
			get
			{
				return data;
			}
			set
			{
				data = value;
				dataSize = (ulong)((value != null) ? value.Length : 0);
			}
		}

		public byte[] SupplementaryInfo
		{
			get
			{
				if (supplementaryInfoSize == 0)
				{
					return null;
				}
				byte[] array = new byte[supplementaryInfoSize];
				Array.Copy(supplementaryInfo, array, (int)supplementaryInfoSize);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 384)
					{
						throw new NpToolkitException("The size of the array is larger than " + 384);
					}
					value.CopyTo(supplementaryInfo, 0);
					supplementaryInfoSize = (ulong)value.Length;
				}
				else
				{
					supplementaryInfoSize = 0uL;
				}
			}
		}

		public int SlotId
		{
			get
			{
				return slotId;
			}
			set
			{
				slotId = value;
			}
		}

		public DataContention DataContention
		{
			get
			{
				return dataContention;
			}
			set
			{
				dataContention = value;
			}
		}

		public Core.NpAccountId TargetUser
		{
			get
			{
				if (isVirtualUser)
				{
					throw new NpToolkitException("A virtual user id is currently configured on for this request, meaning the TargetUser is not valid");
				}
				return targetUser;
			}
			set
			{
				targetUser = value;
				isVirtualUser = false;
			}
		}

		public VirtualUserID VirtualUserID
		{
			get
			{
				if (!isVirtualUser)
				{
					throw new NpToolkitException("This request doesn't have a virtual user id current set.");
				}
				return virtualUserID;
			}
			set
			{
				virtualUserID = value;
				if (value.name.Length > 0)
				{
					isVirtualUser = true;
				}
				else
				{
					isVirtualUser = false;
				}
			}
		}

		public bool IsVirtualUser => isVirtualUser;

		public SetDataRequest()
			: base(ServiceTypes.Tus, FunctionTypes.TusSetData)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetDataRequest : RequestBase
	{
		internal Core.NpAccountId targetUser;

		internal int slotId;

		internal VirtualUserID virtualUserID;

		[MarshalAs(UnmanagedType.I1)]
		internal bool isVirtualUser;

		[MarshalAs(UnmanagedType.I1)]
		internal bool forCrossSave;

		[MarshalAs(UnmanagedType.I1)]
		internal bool retrieveStatusOnly;

		public int SlotId
		{
			get
			{
				return slotId;
			}
			set
			{
				slotId = value;
			}
		}

		public Core.NpAccountId TargetUser
		{
			get
			{
				if (isVirtualUser)
				{
					throw new NpToolkitException("A virtual user id is currently configured on for this request, meaning the TargetUser is not valid");
				}
				return targetUser;
			}
			set
			{
				targetUser = value;
				isVirtualUser = false;
			}
		}

		public VirtualUserID VirtualUserID
		{
			get
			{
				if (!isVirtualUser)
				{
					throw new NpToolkitException("This request doesn't have a virtual user id current set.");
				}
				return virtualUserID;
			}
			set
			{
				virtualUserID = value;
				if (value.name.Length > 0)
				{
					isVirtualUser = true;
				}
				else
				{
					isVirtualUser = false;
				}
			}
		}

		public bool IsVirtualUser => isVirtualUser;

		public bool ForCrossSave
		{
			get
			{
				return forCrossSave;
			}
			set
			{
				forCrossSave = value;
			}
		}

		public bool RetrieveStatusOnly
		{
			get
			{
				return retrieveStatusOnly;
			}
			set
			{
				retrieveStatusOnly = value;
			}
		}

		public GetDataRequest()
			: base(ServiceTypes.Tus, FunctionTypes.TusGetData)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class DeleteDataRequest : RequestBase
	{
		public const int MAX_DATA_SLOTS = 16;

		internal ulong numSlots;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		private int[] slotIds = new int[16];

		internal Core.NpAccountId targetUser;

		internal VirtualUserID virtualUserID;

		[MarshalAs(UnmanagedType.I1)]
		internal bool isVirtualUser;

		public int[] SlotIds
		{
			get
			{
				if (numSlots == 0)
				{
					return null;
				}
				int[] array = new int[numSlots];
				Array.Copy(slotIds, array, (int)numSlots);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 16)
					{
						throw new NpToolkitException("The size of the array is larger than " + 16);
					}
					value.CopyTo(slotIds, 0);
					numSlots = (ulong)value.Length;
				}
				else
				{
					numSlots = 0uL;
				}
			}
		}

		public Core.NpAccountId TargetUser
		{
			get
			{
				if (isVirtualUser)
				{
					throw new NpToolkitException("A virtual user id is currently configured on for this request, meaning the TargetUser is not valid");
				}
				return targetUser;
			}
			set
			{
				targetUser = value;
				isVirtualUser = false;
			}
		}

		public VirtualUserID VirtualUserID
		{
			get
			{
				if (!isVirtualUser)
				{
					throw new NpToolkitException("This request doesn't have a virtual user id current set.");
				}
				return virtualUserID;
			}
			set
			{
				virtualUserID = value;
				if (value.name.Length > 0)
				{
					isVirtualUser = true;
				}
				else
				{
					isVirtualUser = false;
				}
			}
		}

		public bool IsVirtualUser => isVirtualUser;

		public DeleteDataRequest()
			: base(ServiceTypes.Tus, FunctionTypes.TusDeleteData)
		{
		}
	}

	public class VariablesResponse : ResponseBase
	{
		internal bool forCrossSave;

		internal NpVariable[] vars;

		internal NpVariableForCrossSave[] varsForCrossSave;

		public bool ForCrossSave => forCrossSave;

		public NpVariable[] Vars
		{
			get
			{
				if (forCrossSave)
				{
					throw new NpToolkitException("Vars isn't valid unless 'ForCrossSave' is set to false.");
				}
				return vars;
			}
		}

		public NpVariableForCrossSave[] VarsForCrossSave
		{
			get
			{
				if (!forCrossSave)
				{
					throw new NpToolkitException("VarsForCrossSave isn't valid unless 'ForCrossSave' is set to true.");
				}
				return varsForCrossSave;
			}
		}

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.TusVariablesBegin);
			long num = memoryBuffer.ReadInt64();
			forCrossSave = memoryBuffer.ReadBool();
			if (forCrossSave)
			{
				varsForCrossSave = new NpVariableForCrossSave[num];
			}
			else
			{
				vars = new NpVariable[num];
			}
			for (int i = 0; i < num; i++)
			{
				if (forCrossSave)
				{
					varsForCrossSave[i] = new NpVariableForCrossSave();
					varsForCrossSave[i].Read(memoryBuffer);
				}
				else
				{
					vars[i] = new NpVariable();
					vars[i].Read(memoryBuffer);
				}
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.TusVariablesEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class AtomicAddToAndGetVariableResponse : ResponseBase
	{
		internal bool forCrossSave;

		internal NpVariable var;

		internal NpVariableForCrossSave varForCrossSave;

		public bool ForCrossSave => forCrossSave;

		public NpVariable Var
		{
			get
			{
				if (forCrossSave)
				{
					throw new NpToolkitException("Vars isn't valid unless 'ForCrossSave' is set to false.");
				}
				return var;
			}
		}

		public NpVariableForCrossSave VarForCrossSave
		{
			get
			{
				if (!forCrossSave)
				{
					throw new NpToolkitException("VarsForCrossSave isn't valid unless 'ForCrossSave' is set to true.");
				}
				return varForCrossSave;
			}
		}

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.TusAtomicAddToAndGetVariableBegin);
			forCrossSave = memoryBuffer.ReadBool();
			if (forCrossSave)
			{
				varForCrossSave = new NpVariableForCrossSave();
				varForCrossSave.Read(memoryBuffer);
			}
			else
			{
				var = new NpVariable();
				var.Read(memoryBuffer);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.TusAtomicAddToAndGetVariableEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	public class GetDataResponse : ResponseBase
	{
		internal bool forCrossSave;

		internal NpTusDataStatus status;

		internal NpTusDataStatusForCrossSave statusForCrossSave;

		internal byte[] data;

		public byte[] Data => data;

		public bool ForCrossSave => forCrossSave;

		public NpTusDataStatus Status
		{
			get
			{
				if (forCrossSave)
				{
					throw new NpToolkitException("Vars isn't valid unless 'ForCrossSave' is set to false.");
				}
				return status;
			}
		}

		public NpTusDataStatusForCrossSave StatusForCrossSave
		{
			get
			{
				if (!forCrossSave)
				{
					throw new NpToolkitException("VarsForCrossSave isn't valid unless 'ForCrossSave' is set to true.");
				}
				return statusForCrossSave;
			}
		}

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.TusDataBegin);
			memoryBuffer.ReadData(ref data);
			forCrossSave = memoryBuffer.ReadBool();
			if (forCrossSave)
			{
				statusForCrossSave = new NpTusDataStatusForCrossSave();
				statusForCrossSave.Read(memoryBuffer);
			}
			else
			{
				status = new NpTusDataStatus();
				status.Read(memoryBuffer);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.TusDataEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxTusSetVariables(SetVariablesRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxTusGetVariables(GetVariablesRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxTusAddToAndGetVariable(AddToAndGetVariableRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxTusSetData(SetDataRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxTusGetData(GetDataRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxTusDeleteData(DeleteDataRequest request, out APIResult result);

	public static int SetVariables(SetVariablesRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxTusSetVariables(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetVariables(GetVariablesRequest request, VariablesResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxTusGetVariables(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int AddToAndGetVariable(AddToAndGetVariableRequest request, AtomicAddToAndGetVariableResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxTusAddToAndGetVariable(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int SetData(SetDataRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxTusSetData(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetData(GetDataRequest request, GetDataResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxTusGetData(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int DeleteData(DeleteDataRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxTusDeleteData(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}
}
public class UserProfiles
{
	public class LocalUsers
	{
		public const int MaxLocalUsers = 4;

		internal LocalLoginUserId[] localUsers = new LocalLoginUserId[4];

		public LocalLoginUserId[] LocalUsersIds => localUsers;
	}

	public struct LocalLoginUserId
	{
		internal Core.UserServiceUserId userId;

		internal Core.NpAccountId accountId;

		internal int sceErrorCode;

		public Core.UserServiceUserId UserId => userId;

		public Core.NpAccountId AccountId => accountId;

		public int SceErrorCode => sceErrorCode;
	}

	public class NpProfilesResponse : ResponseBase
	{
		internal Profiles.Profile[] profiles;

		public Profiles.Profile[] Profiles => profiles;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NpProfilesBegin);
			uint num = memoryBuffer.ReadUInt32();
			profiles = new Profiles.Profile[num];
			for (int i = 0; i < num; i++)
			{
				profiles[i] = new Profiles.Profile();
				profiles[i].Read(memoryBuffer);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NpProfilesEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetNpProfilesRquest : RequestBase
	{
		public const int MAX_SIZE_ACCOUNT_IDS = 50;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		internal Core.NpAccountId[] accountIds;

		internal uint numValidAccountIds;

		public Core.NpAccountId[] AccountIds
		{
			get
			{
				if (numValidAccountIds == 0)
				{
					return null;
				}
				Core.NpAccountId[] array = new Core.NpAccountId[numValidAccountIds];
				Array.Copy(accountIds, array, numValidAccountIds);
				return array;
			}
			set
			{
				if (value != null)
				{
					if (value.Length > 50)
					{
						throw new NpToolkitException("The size of the Account ids array is more than " + 50);
					}
					value.CopyTo(accountIds, 0);
					numValidAccountIds = (uint)value.Length;
				}
				else
				{
					numValidAccountIds = 0u;
				}
			}
		}

		public GetNpProfilesRquest()
			: base(ServiceTypes.UserProfile, FunctionTypes.UserProfileGetNpProfiles)
		{
			accountIds = new Core.NpAccountId[50];
			numValidAccountIds = 0u;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class GetVerifiedAccountsForTitleRequest : RequestBase
	{
		internal uint limit;

		public uint Limit
		{
			get
			{
				return limit;
			}
			set
			{
				limit = value;
			}
		}

		public GetVerifiedAccountsForTitleRequest()
			: base(ServiceTypes.UserProfile, FunctionTypes.UserProfileGetVerifiedAccountsForTitle)
		{
			limit = 10u;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class DisplayUserProfileDialogRequest : RequestBase
	{
		internal Core.NpAccountId targetAccountId;

		public Core.NpAccountId TargetAccountId
		{
			get
			{
				return targetAccountId;
			}
			set
			{
				targetAccountId = value;
			}
		}

		public DisplayUserProfileDialogRequest()
			: base(ServiceTypes.UserProfile, FunctionTypes.UserProfileDisplayUserProfileDialog)
		{
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public class DisplayGriefReportingDialogRequest : RequestBase
	{
		public Core.NpAccountId targetAccountId;

		[MarshalAs(UnmanagedType.I1)]
		public bool reportOnlineId;

		[MarshalAs(UnmanagedType.I1)]
		public bool reportName;

		[MarshalAs(UnmanagedType.I1)]
		public bool reportPicture;

		[MarshalAs(UnmanagedType.I1)]
		public bool reportAboutMe;

		public Core.NpAccountId TargetAccountId
		{
			get
			{
				return targetAccountId;
			}
			set
			{
				targetAccountId = value;
			}
		}

		public bool ReportOnlineId
		{
			get
			{
				return reportOnlineId;
			}
			set
			{
				reportOnlineId = value;
			}
		}

		public bool ReportName
		{
			get
			{
				return reportName;
			}
			set
			{
				reportName = value;
			}
		}

		public bool ReportPicture
		{
			get
			{
				return reportPicture;
			}
			set
			{
				reportPicture = value;
			}
		}

		public bool ReportAboutMe
		{
			get
			{
				return reportAboutMe;
			}
			set
			{
				reportAboutMe = value;
			}
		}

		public DisplayGriefReportingDialogRequest()
			: base(ServiceTypes.UserProfile, FunctionTypes.UserProfileDisplayGriefReportingDialog)
		{
		}
	}

	[DllImport("UnityNpToolkit2")]
	private static extern void PrxGetLocalLoginUserIds([Out][MarshalAs(UnmanagedType.LPArray, SizeConst = 4)] LocalLoginUserId[] users, int maxSize, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetNpProfiles(GetNpProfilesRquest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxGetVerifiedAccountsForTitle(GetVerifiedAccountsForTitleRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxDisplayUserProfileDialog(DisplayUserProfileDialogRequest request, out APIResult result);

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxDisplayGriefReportingDialog(DisplayGriefReportingDialogRequest request, out APIResult result);

	public static void GetLocalUsers(LocalUsers users)
	{
		PrxGetLocalLoginUserIds(users.localUsers, 4, out var result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
	}

	public static int GetNpProfiles(GetNpProfilesRquest request, NpProfilesResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetNpProfiles(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int GetVerifiedAccountsForTitle(GetVerifiedAccountsForTitleRequest request, NpProfilesResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxGetVerifiedAccountsForTitle(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int DisplayUserProfileDialog(DisplayUserProfileDialogRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxDisplayUserProfileDialog(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}

	public static int DisplayGriefReportingDialog(DisplayGriefReportingDialogRequest request, Core.EmptyResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked.");
		}
		if (!request.reportAboutMe && !request.reportName && !request.reportOnlineId && !request.reportAboutMe)
		{
			throw new NpToolkitException("It is mandatory to specify at least one reason for the report.");
		}
		APIResult result;
		int num = PrxDisplayGriefReportingDialog(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}
}
public class WordFilter
{
	[StructLayout(LayoutKind.Sequential)]
	public class FilterCommentRequest : RequestBase
	{
		public const int MAX_SIZE_COMMENT = 1024;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1025)]
		internal string comment;

		public string Comment
		{
			get
			{
				return comment;
			}
			set
			{
				if (value.Length > 1024)
				{
					throw new NpToolkitException("The size of the string is more than " + 1024 + " characters.");
				}
				comment = value;
			}
		}

		public FilterCommentRequest()
			: base(ServiceTypes.WordFilter, FunctionTypes.WordfilterFilterComment)
		{
		}
	}

	public class SanitizedCommentResponse : ResponseBase
	{
		internal string resultComment;

		internal bool isCommentChanged;

		public string ResultComment => resultComment;

		public bool IsCommentChanged => isCommentChanged;

		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer memoryBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.WordFilterBegin);
			memoryBuffer.ReadString(ref resultComment);
			isCommentChanged = memoryBuffer.ReadBool();
			memoryBuffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.WordFilterEnd);
			EndReadResponseBuffer(memoryBuffer);
		}
	}

	[DllImport("UnityNpToolkit2")]
	private static extern int PrxFilterComment(FilterCommentRequest request, out APIResult result);

	public static int FilterComment(FilterCommentRequest request, SanitizedCommentResponse response)
	{
		if (response.locked)
		{
			throw new NpToolkitException("Response object is already locked");
		}
		APIResult result;
		int num = PrxFilterComment(request, out result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
		RequestBase.FinaliseRequest(request, response, num);
		return num;
	}
}
public class NpCallbackEvent
{
	internal ServiceTypes service;

	internal FunctionTypes apiCalled;

	internal uint npRequestId;

	internal ResponseBase response;

	internal Core.UserServiceUserId userId;

	internal RequestBase request;

	public ServiceTypes Service => service;

	public FunctionTypes ApiCalled => apiCalled;

	public uint NpRequestId => npRequestId;

	public ResponseBase Response => response;

	public RequestBase Request => request;

	public Core.UserServiceUserId UserId => userId;
}
internal static class PendingCallbackQueue
{
	private static Queue<NpCallbackEvent> pendingEvents = new Queue<NpCallbackEvent>();

	private static object syncObject = new object();

	public static void AddEvent(NpCallbackEvent callbackEvent)
	{
		Monitor.Enter(syncObject);
		pendingEvents.Enqueue(callbackEvent);
		Monitor.Exit(syncObject);
	}

	public static NpCallbackEvent PopEvent()
	{
		NpCallbackEvent result = null;
		if (Monitor.TryEnter(syncObject))
		{
			if (pendingEvents.Count == 0)
			{
				Monitor.Exit(syncObject);
				return null;
			}
			result = pendingEvents.Dequeue();
			Monitor.Exit(syncObject);
		}
		return result;
	}
}
public class Core
{
	public enum OptionalBoolean
	{
		notSet,
		setTrue,
		setFalse
	}

	public enum PlatformType
	{
		none,
		ps3,
		psVita,
		ps4
	}

	public enum OnlineStatus
	{
		notRequested,
		online,
		standBy,
		offline
	}

	public enum ReturnCodes : uint
	{
		SUCCESS = 0u,
		DIALOG_RESULT_OK = 0u,
		DIALOG_RESULT_USER_CANCELED = 1u,
		DIALOG_RESULT_USER_PURCHASED = 2u,
		DIALOG_RESULT_ALREADY_SIGNED_IN = 3u,
		DIALOG_RESULT_NOT_SIGNED_IN = 4u,
		DIALOG_RESULT_ABORTED = 10u,
		TROPHY_PLATINUM_UNLOCKED = 1u,
		MATCHING_CREATE_SYSTEM_SESSION_FAILED = 160u,
		MATCHING_JOIN_SYSTEM_SESSION_FAILED = 176u,
		MATCHING_UPDATE_SYSTEM_SESSION_FAILED = 192u,
		MATCHING_UPDATE_EXTERNAL_NOTIFICATION_FAILED = 208u,
		ERROR_FAILED_TO_ALLOCATE = 2153065984u,
		ERROR_TOO_MANY_REQUESTS = 2153065985u,
		ERROR_LOCKED_RESPONSE = 2153065986u,
		ERROR_ALREADY_INITIALIZED = 2153065987u,
		ERROR_NOT_INITIALIZED = 2153065988u,
		ERROR_INCORRECT_ARGUMENTS = 2153065989u,
		ERROR_MODIFICATION_NOT_ALLOWED = 2153065990u,
		ERROR_MAX_USERS_REACHED = 2153065991u,
		ERROR_INVALID_IMAGE = 2153065992u,
		ERROR_MEM_POOLS_INCORRECT = 2153065993u,
		ERROR_EXT_ALLOCATOR_INCORRECT = 2153065994u,
		ERROR_MAX_NUM_CALLBACKS_REACHED = 2153065995u,
		ERROR_CALLBACK_NOT_REGISTERED = 2153065996u,
		ERROR_TROPHY_HOME_DIRECTORY_NOT_CONFIGURED = 2153066096u,
		ERROR_MATCHING_ROOM_DESTROYED = 2153066240u,
		ERROR_MATCHING_INVALID_ATTRIBUTE_SCOPE = 2153066241u,
		ERROR_MATCHING_INVALID_ATTRIBUTE_TYP = 2153066242u,
		ERROR_MATCHING_INVALID_ROOM_ATTRIBUTE_VISIBILITY = 2153066243u,
		ERROR_MATCHING_SUM_OF_MEMBER_ATTRIBUTES_SIZES_IS_MORE_THAN_64 = 2153066244u,
		ERROR_MATCHING_MORE_THAN_1_BINARY_SEARCH_ATTRIBUTE_PROVIDED = 2153066245u,
		ERROR_MATCHING_SEARCH_BINARY_ATTRIBUTE_SIZE_IS_MORE_THAN_64 = 2153066246u,
		ERROR_MATCHING_MORE_THAN_8_INTEGER_SEARCH_ATTRIBUTES_PROVIDED = 2153066247u,
		ERROR_MATCHING_SUM_OF_EXTERNAL_ROOM_ATTRIBUTES_SIZES_IS_MORE_THAN_512 = 2153066248u,
		ERROR_MATCHING_SUM_OF_INTERNAL_ROOM_ATTRIBUTES_SIZES_IS_MORE_THAN_512 = 2153066249u,
		ERROR_MATCHING_NAMES_OF_ATTRIBUTES_MUST_BE_UNIQUE = 2153066250u,
		ERROR_MATCHING_INTERNAL_ATTRIBUTES_DONT_FIT_IN_256_ARRAYS = 2153066251u,
		ERROR_MATCHING_EXTERNAL_ATTRIBUTES_DONT_FIT_IN_256_ARRAYS = 2153066252u,
		ERROR_MATCHING_BIN_ATTRIBUTE_CANNOT_BE_SIZE_0 = 2153066253u,
		ERROR_MATCHING_INIT_CONFIGURATION_ALREADY_SET = 2153066254u,
		ERROR_MATCHING_INIT_CONFIGURATION_NOT_SET = 2153066255u,
		ERROR_MATCHING_USER_IS_ALREADY_IN_A_ROOM = 2153066256u,
		ERROR_MATCHING_USER_IS_NOT_IN_A_ROOM = 2153066257u,
		ERROR_MATCHING_NO_SESSION_BOUND_TO_ROOM = 2153066258u,
		ERROR_MATCHING_INVALID_WORLD_NUMBER = 2153066259u,
		ERROR_MATCHING_ATTRIBUTE_IS_NOT_SEARCHABLE_TYPE = 2153066260u,
		ERROR_MATCHING_INVALID_ATTRIBUTE = 2153066261u,
		ERROR_MATCHING_INVALID_MEMBER_ID = 2153066262u,
		NP_ERROR_INVALID_ARGUMENT = 2153054211u,
		NP_ERROR_UNKNOWN_PLATFORM_TYPE = 2153054212u,
		NP_ERROR_OUT_OF_MEMORY = 2153054213u,
		NP_ERROR_SIGNED_OUT = 2153054214u,
		NP_ERROR_USER_NOT_FOUND = 2153054215u,
		NP_ERROR_CALLBACK_ALREADY_REGISTERED = 2153054216u,
		NP_ERROR_CALLBACK_NOT_REGISTERED = 2153054217u,
		NP_ERROR_NOT_SIGNED_UP = 2153054218u,
		NP_ERROR_AGE_RESTRICTION = 2153054219u,
		NP_ERROR_LOGOUT = 2153054220u,
		NP_ERROR_LATEST_SYSTEM_SOFTWARE_EXIST = 2153054221u,
		NP_ERROR_LATEST_SYSTEM_SOFTWARE_EXIST_FOR_TITLE = 2153054222u,
		NP_ERROR_LATEST_PATCH_PKG_EXIST = 2153054223u,
		NP_ERROR_LATEST_PATCH_PKG_DOWNLOADED = 2153054224u,
		NP_ERROR_INVALID_SIZE = 2153054225u,
		NP_ERROR_ABORTED = 2153054226u,
		NP_ERROR_REQUEST_MAX = 2153054227u,
		NP_ERROR_REQUEST_NOT_FOUND = 2153054228u,
		NP_ERROR_INVALID_ID = 2153054229u,
		NP_ERROR_PATCH_NOT_CHECKED = 2153054232u,
		NP_ERROR_TIMEOUT = 2153054234u,
		NP_UTIL_ERROR_INVALID_NP_ID = 2153055749u,
		NP_UTIL_ERROR_NOT_MATCH = 2153055753u,
		NP_WEBAPI_ERROR_LIB_CONTEXT_NOT_FOUND = 2153064708u,
		NP_TROPHY_ERROR_INVALID_ARGUMENT = 2153059844u,
		NP_TROPHY_ERROR_ALREADY_REGISTERED = 2153059856u,
		NP_TROPHY_ERROR_INVALID_GROUP_ID = 2153059851u,
		NP_TROPHY_ERROR_TROPHY_ALREADY_UNLOCKED = 2153059852u,
		NP_TROPHY_ERROR_NOT_REGISTERED = 2153059855u,
		NP_TROPHY_ERROR_TROPHY_NOT_UNLOCKED = 2153059866u,
		TOOLKIT_NP_V2_ERROR_INCORRECT_ARGUMENTS = 2153065989u,
		NET_ERROR_RESOLVER_ENODNS = 2151743969u,
		NET_CTL_ERROR_NOT_CONNECTED = 2151751944u,
		NET_CTL_ERROR_NOT_AVAIL = 2151751945u,
		NP_COMMUNITY_SERVER_ERROR_NOT_BEST_SCORE = 2153056277u,
		NP_COMMUNITY_SERVER_ERROR_INVALID_SCORE = 2153056291u,
		NP_COMMUNITY_SERVER_ERROR_GAME_DATA_ALREADY_EXISTS = 2153056300u,
		NP_COMMUNITY_SERVER_ERROR_RANKING_GAME_DATA_MASTER_NOT_FOUND = 2153056280u,
		NP_MATCHING2_ERROR_CONTEXT_NOT_STARTED = 2153057288u
	}

	public struct UserServiceUserId
	{
		public const int UserIdInvalid = -1;

		internal int id;

		public int Id
		{
			get
			{
				return id;
			}
			set
			{
				id = value;
			}
		}

		public override string ToString()
		{
			return "0x" + id.ToString("X8");
		}

		internal void Read(MemoryBuffer buffer)
		{
			id = buffer.ReadInt32();
		}

		public static implicit operator UserServiceUserId(int value)
		{
			return new UserServiceUserId
			{
				id = value
			};
		}
	}

	public struct NpAccountId
	{
		internal ulong id;

		public ulong Id
		{
			get
			{
				return id;
			}
			set
			{
				id = value;
			}
		}

		public override string ToString()
		{
			return "0x" + id.ToString("X16");
		}

		internal void Read(MemoryBuffer buffer)
		{
			id = buffer.ReadUInt64();
		}

		public static implicit operator NpAccountId(ulong value)
		{
			return new NpAccountId
			{
				id = value
			};
		}

		public static bool operator ==(NpAccountId a, NpAccountId b)
		{
			if (object.ReferenceEquals(a, b))
			{
				return true;
			}
			return a.id == b.id;
		}

		public static bool operator !=(NpAccountId a, NpAccountId b)
		{
			return !(a == b);
		}

		public override bool Equals(object obj)
		{
			return obj is NpAccountId && this == (NpAccountId)obj;
		}

		public override int GetHashCode()
		{
			return id.GetHashCode();
		}
	}

	public struct NpId
	{
		internal OnlineID handle;

		internal byte[] opt;

		public OnlineID Handle => handle;

		public byte[] Opt => opt;

		public override string ToString()
		{
			return handle.ToString();
		}

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.SceNpIdBegin);
			handle.Read(buffer);
			buffer.ReadData(ref opt);
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.SceNpIdEnd);
		}
	}

	public class OnlineID
	{
		public const int SCE_NP_ONLINEID_MAX_LENGTH = 16;

		internal byte[] data;

		internal string name = "";

		public string Name => name;

		public OnlineID()
		{
			data = new byte[16];
		}

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NpOnlineIdBegin);
			buffer.ReadData(ref data);
			int num = 16;
			for (int i = 0; i < data.Length; i++)
			{
				if (data[i] == 0)
				{
					num = i;
					break;
				}
			}
			if (num > 0)
			{
				name = Encoding.ASCII.GetString(data, 0, num);
			}
			else
			{
				name = "";
			}
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NpOnlineIdEnd);
		}

		public override string ToString()
		{
			return name;
		}

		public static bool operator ==(OnlineID a, OnlineID b)
		{
			if (object.ReferenceEquals(a, b))
			{
				return true;
			}
			if ((object)a == null || (object)b == null)
			{
				return false;
			}
			return a.name == b.name;
		}

		public static bool operator !=(OnlineID a, OnlineID b)
		{
			return !(a == b);
		}

		public override bool Equals(object obj)
		{
			return obj is OnlineID && this == (OnlineID)obj;
		}

		public override int GetHashCode()
		{
			return name.GetHashCode();
		}
	}

	public class OnlineUser
	{
		internal NpAccountId accountId;

		internal OnlineID onlineId;

		public NpAccountId AccountId => accountId;

		public OnlineID OnlineID => onlineId;

		public OnlineUser()
		{
			onlineId = new OnlineID();
		}

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.OnlineUserBegin);
			accountId.Read(buffer);
			onlineId.Read(buffer);
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.OnlineUserEnd);
		}

		public override string ToString()
		{
			return $"0x{accountId:X} : {onlineId.ToString()}\n";
		}
	}

	public class CountryCode
	{
		public const int SCE_NP_COUNTRY_CODE_LENGTH = 2;

		internal string code = "";

		public string Code
		{
			get
			{
				return code;
			}
			set
			{
				if (value.Length > 2)
				{
					throw new NpToolkitException("Country code can only be a maximum of 2 characters .");
				}
				code = value;
			}
		}

		public CountryCode()
		{
			code = "";
		}

		public CountryCode(string countryCode)
		{
			Code = countryCode;
		}

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NpCountryCodeBegin);
			buffer.ReadString(ref code);
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NpCountryCodeEnd);
		}

		public override string ToString()
		{
			return code;
		}

		public static implicit operator CountryCode(string countryCode)
		{
			CountryCode countryCode2 = new CountryCode();
			countryCode2.Code = countryCode;
			return countryCode2;
		}
	}

	public class LanguageCode
	{
		public const int SCE_NP_LANGUAGE_CODE_MAX_LEN = 5;

		internal string code;

		public string Code
		{
			get
			{
				return code;
			}
			set
			{
				if (value.Length > 5)
				{
					throw new NpToolkitException("Language code can only be a maximum of 5 characters .");
				}
				code = value;
			}
		}

		public LanguageCode()
		{
			code = "";
		}

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NpLanguageCodeBegin);
			buffer.ReadString(ref code);
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NpLanguageCodeEnd);
		}

		public override string ToString()
		{
			return code;
		}

		public static implicit operator LanguageCode(string languageCode)
		{
			LanguageCode languageCode2 = new LanguageCode();
			languageCode2.Code = languageCode;
			return languageCode2;
		}
	}

	public class TitleId
	{
		public const int SCE_NP_TITLE_ID_LEN = 12;

		internal byte[] data;

		public string Id => Encoding.ASCII.GetString(data, 0, data.Length);

		public TitleId()
		{
			data = new byte[12];
		}

		internal void Read(MemoryBuffer buffer)
		{
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NpTitleIdBegin);
			buffer.ReadData(ref data);
			buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.NpTitleIdEnd);
		}

		public override string ToString()
		{
			return Encoding.ASCII.GetString(data, 0, data.Length);
		}
	}

	public class EmptyResponse : ResponseBase
	{
		protected internal override void ReadResult(uint id, FunctionTypes apiCalled, RequestBase request)
		{
			base.ReadResult(id, apiCalled, request);
			APIResult result;
			MemoryBuffer readBuffer = BeginReadResponseBuffer(id, apiCalled, out result);
			if (result.RaiseException)
			{
				throw new NpToolkitException(result);
			}
			EndReadResponseBuffer(readBuffer);
		}
	}

	public static string ConvertSceErrorToString(int errorCode)
	{
		string text = "(0x" + errorCode.ToString("X8") + ")";
		ReturnCodes returnCodes = (ReturnCodes)errorCode;
		if (Enum.IsDefined(typeof(ReturnCodes), returnCodes))
		{
			return text + " (" + returnCodes.ToString() + ") ";
		}
		return text + " (UNKNOWN) ";
	}

	internal static DateTime ReadRtcTick(MemoryBuffer buffer)
	{
		ulong rtcTick = buffer.ReadUInt64();
		return RtcTicksToDateTime(rtcTick);
	}

	internal static ulong DateTimeToRtcTicks(DateTime dateTime)
	{
		ulong num = 10uL;
		ulong ticks = (ulong)dateTime.Ticks;
		return ticks / num;
	}

	internal static DateTime RtcTicksToDateTime(ulong rtcTick)
	{
		ulong num = 10uL;
		rtcTick *= num;
		return new DateTime((long)rtcTick);
	}
}
public class Icon
{
	internal byte[] rawBytes;

	internal int width;

	internal int height;

	public byte[] RawBytes => rawBytes;

	public int Width => width;

	public int Height => height;

	internal static Icon ReadAndCreate(MemoryBuffer buffer)
	{
		Icon icon = null;
		buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.PNGBegin);
		if (buffer.ReadBool())
		{
			icon = new Icon();
			int num = buffer.ReadInt32();
			icon.width = buffer.ReadInt32();
			icon.height = buffer.ReadInt32();
			buffer.ReadData(ref icon.rawBytes);
		}
		buffer.CheckMarker(MemoryBuffer.BufferIntegrityChecks.PNGEnd);
		return icon;
	}
}
public enum APIResultTypes
{
	Success,
	Warning,
	Error
}
internal struct APIResult
{
	public APIResultTypes apiResult;

	private IntPtr _message;

	private IntPtr _filename;

	public int lineNumber;

	public int sceErrorCode;

	public string message => Marshal.PtrToStringAnsi(_message);

	public string filename => Marshal.PtrToStringAnsi(_filename);

	public bool RaiseException => apiResult != APIResultTypes.Success;
}
public class NpToolkitException : Exception
{
	internal APIResultTypes resultType = APIResultTypes.Error;

	internal string filename;

	internal int lineNumber;

	internal int sceErrorCode;

	public APIResultTypes ResultType => resultType;

	public string Filename => filename;

	public int LineNumber => lineNumber;

	public int SceErrorCode => sceErrorCode;

	public string ExtendedMessage
	{
		get
		{
			string text = Message;
			if (sceErrorCode != 0)
			{
				text = text + " (Sce : 0x" + sceErrorCode.ToString("X") + " ) ";
			}
			if (filename != null && filename.Length > 0)
			{
				object obj = text;
				text = string.Concat(obj, " ( ", filename, " : Line = ", lineNumber, " ) ");
			}
			return text;
		}
	}

	public NpToolkitException()
	{
	}

	public NpToolkitException(string message)
		: base(message)
	{
	}

	public NpToolkitException(string message, Exception inner)
		: base(message, inner)
	{
	}

	internal NpToolkitException(APIResult apiResult)
		: base(apiResult.message)
	{
		resultType = apiResult.apiResult;
		filename = apiResult.filename;
		lineNumber = apiResult.lineNumber;
		sceErrorCode = apiResult.sceErrorCode;
	}
}
public struct AgeRestriction
{
	internal string countryCode;

	internal int age;

	public Core.CountryCode CountryCode
	{
		get
		{
			Core.CountryCode countryCode = new Core.CountryCode();
			countryCode.code = this.countryCode;
			return countryCode;
		}
		set
		{
			countryCode = value.code;
		}
	}

	public int Age
	{
		get
		{
			return age;
		}
		set
		{
			age = value;
		}
	}

	public AgeRestriction(int age, Core.CountryCode countryCode)
	{
		this.age = age;
		this.countryCode = countryCode.code;
	}

	public void Init()
	{
		countryCode = "";
		age = 0;
	}
}
public struct ContentRestriction
{
	public const int MAX_AGE_RESTICTIONS = 32;

	public const int NP_NO_AGE_RESTRICTION = 0;

	internal int defaultAgeRestriction;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
	internal AgeRestriction[] ageRestrictions;

	internal int numAgeRestictions;

	[MarshalAs(UnmanagedType.I1)]
	internal bool applyContentRestriction;

	public int DefaultAgeRestriction
	{
		get
		{
			return defaultAgeRestriction;
		}
		set
		{
			defaultAgeRestriction = value;
		}
	}

	public AgeRestriction[] AgeRestrictions
	{
		get
		{
			if (numAgeRestictions == 0)
			{
				return null;
			}
			AgeRestriction[] array = new AgeRestriction[numAgeRestictions];
			Array.Copy(ageRestrictions, array, numAgeRestictions);
			return array;
		}
		set
		{
			if (value != null)
			{
				if (value.Length > 32)
				{
					throw new NpToolkitException("The size of the array is larger than " + 32);
				}
				value.CopyTo(ageRestrictions, 0);
				numAgeRestictions = value.Length;
			}
			else
			{
				numAgeRestictions = 0;
			}
		}
	}

	public bool ApplyContentRestriction
	{
		get
		{
			return applyContentRestriction;
		}
		set
		{
			applyContentRestriction = value;
		}
	}

	public void Init()
	{
		defaultAgeRestriction = 0;
		ageRestrictions = new AgeRestriction[32];
		numAgeRestictions = 0;
		applyContentRestriction = true;
		for (int i = 0; i < 32; i++)
		{
			ageRestrictions[i].Init();
		}
	}
}
[Obsolete("ServerPushNotifications is deprecated, please use PushNotificationsFlags instead.")]
public struct ServerPushNotifications
{
	[MarshalAs(UnmanagedType.I1)]
	internal bool newGameDataMessage;

	[MarshalAs(UnmanagedType.I1)]
	internal bool newInvitation;

	[MarshalAs(UnmanagedType.I1)]
	internal bool updateBlockedUsersList;

	[MarshalAs(UnmanagedType.I1)]
	internal bool updateFriendPresence;

	[MarshalAs(UnmanagedType.I1)]
	internal bool updateFriendsList;

	[MarshalAs(UnmanagedType.I1)]
	internal bool newInGameMessage;

	public bool NewGameDataMessage
	{
		get
		{
			return newGameDataMessage;
		}
		set
		{
			newGameDataMessage = value;
		}
	}

	public bool NewInvitation
	{
		get
		{
			return newInvitation;
		}
		set
		{
			newInvitation = value;
		}
	}

	public bool UpdateBlockedUsersList
	{
		get
		{
			return updateBlockedUsersList;
		}
		set
		{
			updateBlockedUsersList = value;
		}
	}

	public bool UpdateFriendPresence
	{
		get
		{
			return updateFriendPresence;
		}
		set
		{
			updateFriendPresence = value;
		}
	}

	public bool UpdateFriendsList
	{
		get
		{
			return updateFriendsList;
		}
		set
		{
			updateFriendsList = value;
		}
	}

	public bool NewInGameMessage
	{
		get
		{
			return newInGameMessage;
		}
		set
		{
			newInGameMessage = value;
		}
	}

	public void Init()
	{
		newGameDataMessage = true;
		newInvitation = true;
		updateBlockedUsersList = true;
		updateFriendPresence = true;
		updateFriendsList = true;
		newInGameMessage = true;
	}
}
public enum PushNotificationsFlags
{
	None = 0,
	NewGameDataMessage = 1,
	NewInvitation = 2,
	UpdateBlockedUsersList = 4,
	UpdateFriendPresence = 8,
	UpdateFriendsList = 0x10,
	NewInGameMessage = 0x20
}
public enum Affinity
{
	Core2 = 4,
	Core3 = 8,
	Core4 = 16,
	Core5 = 32,
	AllCores = 60
}
public struct ThreadSettings
{
	public Affinity affinity;

	public void Init()
	{
		affinity = Affinity.AllCores;
	}
}
public struct MemoryPools
{
	public const int TOOLKIT_MEM_DEFAULT_SIZE = 16777216;

	public const int JSON_MEM_MINIMUM_SIZE = 16384;

	public const int JSON_MEM_DEFAULT_SIZE = 4194304;

	public const int WEB_API_MEM_DEFAULT_SIZE = 1048576;

	public const int HTTP_MEM_DEFAULT_SIZE = 65536;

	public const int HTTP_MEM_MINIMUM_SIZE = 16384;

	public const int SSL_MEM_DEFAULT_SIZE = 262144;

	public const int SSL_MEM_MINIMUM_SIZE = 32768;

	public const int NET_MEM_DEFAULT_SIZE = 32768;

	public const int NET_MEM_MINIMUM_SIZE = 4096;

	public const int MATCHING_MEM_DEFAULT_SIZE = 524288;

	public const int MATCHING_SSL_MEM_DEFAULT_SIZE = 196608;

	public const int IN_GAME_MESSAGE_MEM_DEFAULT_SIZE = 16384;

	private ulong toolkitPoolSize;

	private ulong jsonPoolSize;

	private ulong webApiPoolSize;

	private ulong httpPoolSize;

	private ulong sslPoolSize;

	private ulong netPoolSize;

	private ulong matchingPoolSize;

	private ulong matchingSslPoolSize;

	private ulong inGameMessagePoolSize;

	public ulong ToolkitPoolSize
	{
		get
		{
			return toolkitPoolSize;
		}
		set
		{
			Validate("ToolkitPoolSize", value, 0uL, "", mustBe16kbAlligned: true);
			toolkitPoolSize = value;
		}
	}

	public ulong JsonPoolSize
	{
		get
		{
			return jsonPoolSize;
		}
		set
		{
			Validate("JsonPoolSize", value, 16384uL, "JSON_MEM_MINIMUM_SIZE", mustBe16kbAlligned: true);
			jsonPoolSize = value;
		}
	}

	public ulong WebApiPoolSize
	{
		get
		{
			return webApiPoolSize;
		}
		set
		{
			Validate("WebApiPoolSize", value, 0uL, "", mustBe16kbAlligned: true);
			webApiPoolSize = value;
		}
	}

	public ulong HttpPoolSize
	{
		get
		{
			return httpPoolSize;
		}
		set
		{
			Validate("HttpPoolSize", value, 16384uL, "HTTP_MEM_MINIMUM_SIZE", mustBe16kbAlligned: true);
			httpPoolSize = value;
		}
	}

	public ulong SslPoolSize
	{
		get
		{
			return sslPoolSize;
		}
		set
		{
			Validate("SslPoolSize", value, 32768uL, "SSL_MEM_MINIMUM_SIZE", mustBe16kbAlligned: true);
			sslPoolSize = value;
		}
	}

	public ulong NetPoolSize
	{
		get
		{
			return netPoolSize;
		}
		set
		{
			Validate("NetPoolSize", value, 4096uL, "NET_MEM_MINIMUM_SIZE", mustBe16kbAlligned: true);
			netPoolSize = value;
		}
	}

	public ulong MatchingPoolSize
	{
		get
		{
			return matchingPoolSize;
		}
		set
		{
			Validate("MatchingPoolSize", value, 0uL, "", mustBe16kbAlligned: true);
			matchingPoolSize = value;
		}
	}

	public ulong MatchingSslPoolSize
	{
		get
		{
			return matchingSslPoolSize;
		}
		set
		{
			Validate("MatchingSslPoolSize", value, 0uL, "", mustBe16kbAlligned: true);
			matchingSslPoolSize = value;
		}
	}

	public ulong InGameMessagePoolSize
	{
		get
		{
			return inGameMessagePoolSize;
		}
		set
		{
			Validate("InGameMessagePoolSize", value, 0uL, "", mustBe16kbAlligned: true);
			inGameMessagePoolSize = value;
		}
	}

	private void Validate(string propertyName, ulong size, ulong minSize, string minSizeName, bool mustBe16kbAlligned)
	{
		if (mustBe16kbAlligned && size % 16384 != 0)
		{
			throw new NpToolkitException("The size of the " + propertyName + " must be a multiple of 16 kbs (16384 bytes).");
		}
		if (minSize != 0 && size < minSize)
		{
			throw new NpToolkitException("The size of the " + propertyName + " must be greater than " + minSizeName + ".");
		}
	}

	public void Init()
	{
		toolkitPoolSize = 16777216uL;
		jsonPoolSize = 4194304uL;
		webApiPoolSize = 1048576uL;
		httpPoolSize = 65536uL;
		sslPoolSize = 262144uL;
		netPoolSize = 32768uL;
		matchingPoolSize = 524288uL;
		matchingSslPoolSize = 196608uL;
		inGameMessagePoolSize = 16384uL;
	}
}
public enum SDKVersions
{
	SDK_4 = 0x4000000
}
public struct SceSDKVersion
{
	public uint Major;

	public uint Minor;

	public uint Patch;

	public override string ToString()
	{
		return Major.ToString("X2") + "." + Minor.ToString("X3") + "." + Patch.ToString("X3");
	}
}
internal struct NativeInitResult
{
	[MarshalAs(UnmanagedType.I1)]
	internal bool initialized;

	internal uint sceSDKVersion;
}
public struct InitResult
{
	internal bool initialized;

	internal uint sceSDKVersion;

	internal Version dllVersion;

	public bool Initialized => initialized;

	public uint SceSDKVersionValue => sceSDKVersion;

	public Version DllVersion => dllVersion;

	public SceSDKVersion SceSDKVersion
	{
		get
		{
			SceSDKVersion result = default(SceSDKVersion);
			result.Patch = sceSDKVersion & 0xFFF;
			result.Minor = (sceSDKVersion >> 12) & 0xFFF;
			result.Major = sceSDKVersion >> 24;
			return result;
		}
	}

	internal void Initialise(NativeInitResult nativeResult)
	{
		initialized = nativeResult.initialized;
		sceSDKVersion = nativeResult.sceSDKVersion;
		dllVersion = Assembly.GetExecutingAssembly().GetName().Version;
	}
}
[StructLayout(LayoutKind.Sequential)]
public class InitToolkit
{
	public ContentRestriction contentRestrictions;

	[Obsolete("serverPushNotifications is deprecated, please use SetPushNotificationsFlags instead.")]
	public ServerPushNotifications serverPushNotifications;

	private PushNotificationsFlags serverPushNotificationsFlags;

	[MarshalAs(UnmanagedType.I1)]
	private bool notificationsFlagsSet;

	public ThreadSettings threadSettings;

	public MemoryPools memoryPools;

	public InitToolkit()
	{
		contentRestrictions.Init();
		serverPushNotifications.Init();
		threadSettings.Init();
		memoryPools.Init();
		serverPushNotificationsFlags = PushNotificationsFlags.None;
		notificationsFlagsSet = false;
	}

	public void SetPushNotificationsFlags(PushNotificationsFlags pushNotifications)
	{
		serverPushNotificationsFlags = pushNotifications;
		notificationsFlagsSet = true;
	}

	public void CheckValid()
	{
		if ((threadSettings.affinity & (Affinity)3) != 0)
		{
			throw new NpToolkitException("Can't set thread affinity to Core 0 or Core 1 as this will interfer with the main loop and gfx threads.");
		}
	}
}
internal struct NpMemoryBuffer
{
	public uint size;

	public IntPtr data;
}
internal class MemoryBuffer
{
	public enum BufferIntegrityChecks
	{
		BufferBegin,
		BufferEnd,
		OnlineUserBegin,
		OnlineUserEnd,
		NpOnlineIdBegin,
		NpOnlineIdEnd,
		SceNpIdBegin,
		SceNpIdEnd,
		NpCountryCodeBegin,
		NpCountryCodeEnd,
		NpTitleIdBegin,
		NpTitleIdEnd,
		NpLanguageCodeBegin,
		NpLanguageCodeEnd,
		PNGBegin,
		PNGEnd,
		FriendsBegin,
		FriendsEnd,
		FriendBegin,
		FriendEnd,
		FriendsOfFriendsBegin,
		FriendsOfFriendsEnd,
		BlockedUsersBegin,
		BlockedUsersEnd,
		ProfileBegin,
		ProfileEnd,
		RealNameBegin,
		RealNameEnd,
		PresenceBegin,
		PresenceEnd,
		PlatformPresenceBegin,
		PlatformPresenceEnd,
		NpProfilesBegin,
		NpProfilesEnd,
		BandwidthInfoBegin,
		BandwidthInfoEnd,
		NetStateBasicBegin,
		NetStateBasicEnd,
		NetStateDetailedBegin,
		NetStateDetailedEnd,
		UnlockedTrophiesBegin,
		UnlockedTrophiesEnd,
		TrophyPackSummaryBegin,
		TrophyPackSummaryEnd,
		TrophyPackGroupBegin,
		TrophyPackGroupEnd,
		TrophyPackTrophyBegin,
		TrophyPackTrophyEnd,
		TempRankBegin,
		TempRankEnd,
		RangeOfRanksBegin,
		RangeOfRanksEnd,
		FriendsRanksBegin,
		FriendsRanksEnd,
		UsersRanksBegin,
		UsersRanksEnd,
		SetGameDataBegin,
		SetGameDataEnd,
		GetGameDataBegin,
		GetGameDataEnd,
		WorldsBegin,
		WorldsEnd,
		CreateRoomBegin,
		CreateRoomEnd,
		RoomBegin,
		RoomEnd,
		RoomsBegin,
		RoomsEnd,
		RoomPingTimeBegin,
		RoomPingTimeEnd,
		GetDataBegin,
		GetDataEnd,
		TssDataBegin,
		TssDataEnd,
		TusVariablesBegin,
		TusVariablesEnd,
		TusAtomicAddToAndGetVariableBegin,
		TusAtomicAddToAndGetVariableEnd,
		TusDataBegin,
		TusDataEnd,
		GameDataMessagesBegin,
		GameDataMessagesEnd,
		GameDataMessageThumbnailBegin,
		GameDataMessageThumbnailEnd,
		GameDataMessageAttachmentBegin,
		GameDataMessageAttachmentEnd,
		GameDataMessageBegin,
		GameDataMessageEnd,
		GameDataMessageDetailsBegin,
		GameDataMessageDetailsEnd,
		CategoriesBegin,
		CategoriesEnd,
		CategoryBegin,
		CategoryEnd,
		SubCategoryBegin,
		SubCategoryEnd,
		ProductsBegin,
		ProductsEnd,
		ProductBegin,
		ProductEnd,
		ProductDetailsBegin,
		ProductDetailsEnd,
		SkuInfoBegin,
		SkuInfoEnd,
		ServiceEntitlementsBegin,
		ServiceEntitlementsEnd,
		ServiceEntitlementBegin,
		ServiceEntitlementEnd,
		AuthCodeBegin,
		AuthCodeEnd,
		IdTokenBegin,
		IdTokenEnd,
		WordFilterBegin,
		WordFilterEnd,
		FriendListUpdateBegin,
		FriendListUpdateEnd,
		BlocklistUpdateBegin,
		BlocklistUpdateEnd,
		PresenceUpdateBegin,
		PresenceUpdateEnd,
		UserStateChangeBegin,
		UserStateChangeEnd,
		NetStateChangeBegin,
		NetStateChangeEnd,
		RefreshRoomBegin,
		RefreshRoomEnd,
		InvitationReceivedBegin,
		InvitationReceivedEnd,
		NewRoomMessageBegin,
		NewRoomMessageEnd,
		NewInGameMessageBegin,
		NewInGameMessageEnd,
		NewGameDataMessageBegin,
		NewGameDataMessageEnd,
		SessionInvitationEventBegin,
		SessionInvitationEventEnd,
		PlayTogetherHostEventBegin,
		PlayTogetherHostEventEnd,
		GameCustomDataEventBegin,
		GameCustomDataEventEnd,
		CheckPlusBegin,
		CheckPlusEnd,
		GetParentalControlInfoBegin,
		GetParentalControlInfoEnd
	}

	private NpMemoryBuffer rawBuffer;

	private IntPtr pos;

	public MemoryBuffer(NpMemoryBuffer pointer)
	{
		rawBuffer.data = pointer.data;
		rawBuffer.size = pointer.size;
		pos = rawBuffer.data;
	}

	public void CheckStartMarker()
	{
		CheckMarker(BufferIntegrityChecks.BufferBegin);
	}

	public void CheckEndMarker()
	{
		CheckMarker(BufferIntegrityChecks.BufferEnd);
	}

	public void CheckMarker(BufferIntegrityChecks value)
	{
		byte b = Marshal.ReadByte(pos);
		pos = new IntPtr(pos.ToInt64() + 1);
		byte b2 = Marshal.ReadByte(pos);
		pos = new IntPtr(pos.ToInt64() + 1);
		byte b3 = Marshal.ReadByte(pos);
		pos = new IntPtr(pos.ToInt64() + 1);
		byte b4 = Marshal.ReadByte(pos);
		pos = new IntPtr(pos.ToInt64() + 1);
		if (b == byte.MaxValue && b2 == 254 && b3 == 253 && (BufferIntegrityChecks)b4 == value)
		{
			return;
		}
		throw new NpToolkitException("MemoryBuffer - CheckMarker error - Expecting " + value);
	}

	public void CheckBufferOverflow(string method)
	{
		long num = pos.ToInt64() - rawBuffer.data.ToInt64();
		if ((uint)num > rawBuffer.size)
		{
			throw new NpToolkitException("MemoryBuffer - Overflow error detected. (" + method + ") (" + num + "," + rawBuffer.size + ")");
		}
	}

	public bool ReadBool()
	{
		CheckBufferOverflow("ReadBool");
		byte b = Marshal.ReadByte(pos);
		pos = new IntPtr(pos.ToInt64() + 1);
		if (b == 0)
		{
			return false;
		}
		return true;
	}

	public sbyte ReadInt8()
	{
		CheckBufferOverflow("ReadInt8");
		sbyte result = (sbyte)Marshal.ReadByte(pos);
		pos = new IntPtr(pos.ToInt64() + 1);
		return result;
	}

	public byte ReadUInt8()
	{
		CheckBufferOverflow("ReadUInt8");
		byte result = Marshal.ReadByte(pos);
		pos = new IntPtr(pos.ToInt64() + 1);
		return result;
	}

	public short ReadInt16()
	{
		CheckBufferOverflow("ReadInt16");
		short result = Marshal.ReadInt16(pos);
		pos = new IntPtr(pos.ToInt64() + 2);
		return result;
	}

	public ushort ReadUInt16()
	{
		CheckBufferOverflow("ReadUInt16");
		ushort result = (ushort)Marshal.ReadInt16(pos);
		pos = new IntPtr(pos.ToInt64() + 2);
		return result;
	}

	public int ReadInt32()
	{
		CheckBufferOverflow("ReadInt32");
		int result = Marshal.ReadInt32(pos);
		pos = new IntPtr(pos.ToInt64() + 4);
		return result;
	}

	public uint ReadUInt32()
	{
		CheckBufferOverflow("ReadUInt32");
		uint result = (uint)Marshal.ReadInt32(pos);
		pos = new IntPtr(pos.ToInt64() + 4);
		return result;
	}

	public long ReadInt64()
	{
		CheckBufferOverflow("ReadInt64");
		long result = Marshal.ReadInt64(pos);
		pos = new IntPtr(pos.ToInt64() + 8);
		return result;
	}

	public ulong ReadUInt64()
	{
		CheckBufferOverflow("ReadUInt64");
		ulong result = (ulong)Marshal.ReadInt64(pos);
		pos = new IntPtr(pos.ToInt64() + 8);
		return result;
	}

	public IntPtr ReadPtr()
	{
		CheckBufferOverflow("ReadPtr");
		long value = Marshal.ReadInt64(pos);
		pos = new IntPtr(pos.ToInt64() + 8);
		return new IntPtr(value);
	}

	public double ReadDouble()
	{
		CheckBufferOverflow("ReadDouble");
		double[] array = new double[1];
		Marshal.Copy(pos, array, 0, 1);
		pos = new IntPtr(pos.ToInt64() + 8);
		return array[0];
	}

	public uint ReadData(ref byte[] data)
	{
		CheckBufferOverflow("ReadData");
		uint num = ReadUInt32();
		if (num == 0)
		{
			return 0u;
		}
		if (data == null || data.Length != num)
		{
			data = new byte[num];
		}
		Marshal.Copy(pos, data, 0, (int)num);
		pos = new IntPtr(pos.ToInt64() + num);
		return num;
	}

	public uint ReadData(ref byte[] data, uint startIndex)
	{
		CheckBufferOverflow("ReadData");
		uint num = ReadUInt32();
		if (num == 0)
		{
			return 0u;
		}
		if (data == null || startIndex + num > data.Length)
		{
			byte[] array = new byte[num];
			if (data != null)
			{
				Array.Copy(data, array, startIndex);
			}
			data = array;
		}
		Marshal.Copy(pos, data, (int)startIndex, (int)num);
		pos = new IntPtr(pos.ToInt64() + num);
		return num;
	}

	public void ReadString(ref string str)
	{
		CheckBufferOverflow("ReadString");
		byte[] data = null;
		if (ReadData(ref data) == 0)
		{
			str = "";
		}
		else
		{
			str = Encoding.UTF8.GetString(data, 0, data.Length);
		}
	}

	public override string ToString()
	{
		long num = pos.ToInt64() - rawBuffer.data.ToInt64();
		long num2 = rawBuffer.data.ToInt64();
		return "Memorry buffer : Data = (" + num2.ToString("X") + ") Size = (" + rawBuffer.size + ") Read = (" + num + ")";
	}
}
public enum ServiceTypes
{
	Invalid,
	Auth,
	Presence,
	Ranking,
	Trophy,
	NetworkUtils,
	NpUtils,
	WordFilter,
	UserProfile,
	EventsClient,
	Messaging,
	Matching,
	Commerce,
	Challenge,
	Tus,
	Tss,
	Friends,
	Session,
	ActivityFeed,
	SocialMedia,
	SharedMedia,
	Core,
	Notification,
	Size
}
public enum FunctionTypes
{
	Invalid,
	ActivityFeedGetSharedVideos,
	ActivityFeedGetPlayedWith,
	ActivityFeedPostPlayedWith,
	ActivityFeedGetWhoLiked,
	ActivityFeedSetLiked,
	ActivityFeedGetFeed,
	ActivityFeedPostInGameStory,
	AuthGetAuthCode,
	AuthGetIdToken,
	ChallengeConsumeChallenge,
	ChallengeSendChallenge,
	ChallengeGetReceivedChallenges,
	ChallengeGetChallengeData,
	ChallengeGetChallengeThumbnail,
	CommerceGetCategories,
	CommerceGetProducts,
	CommerceGetServiceEntitlements,
	CommerceConsumeServiceEntitlement,
	CommerceDisplayCategoryBrowseDialog,
	CommerceDisplayProductBrowseDialog,
	CommerceDisplayVoucherCodeInputDialog,
	CommerceDisplayCheckoutDialog,
	CommerceDisplayJoinPlusDialog,
	CommerceDisplayDownloadListDialog,
	CommerceSetPsStoreIconDisplayState,
	EventsClientGetEvent,
	FriendsGetFriends,
	FriendsGetFriendsOfFriends,
	FriendsGetBlockedUsers,
	FriendsDisplayFriendRequestDialog,
	FriendsDisplayBlockUserDialog,
	MatchingSetInitConfiguration,
	MatchingGetWorlds,
	MatchingCreateRoom,
	MatchingLeaveRoom,
	MatchingSearchRooms,
	MatchingJoinRoom,
	MatchingGetRoomPingTime,
	MatchingKickOutRoomMember,
	MatchingSendRoomMessage,
	MatchingGetAttributes,
	MatchingSetRoomInfo,
	MatchingSendInvitation,
	MatchingGetData,
	MatchingSetMembersAsRecentlyMet,
	MessagingSendInGameMessage,
	MessagingSendGameDataMessage,
	MessagingDisplayReceivedGameDataMessagesDialog,
	MessagingGetReceivedGameDataMessages,
	MessagingConsumeGameDataMessage,
	MessagingGetGameDataMessageThumbnail,
	MessagingGetGameDataMessageAttachment,
	NetworkUtilsGetBandwidthInfo,
	NetworkUtilsGetBasicNetworkInfo,
	NetworkUtilsGetDetailedNetworkInfo,
	NpUtilsDisplaySigninDialog,
	NpUtilsSetTitleIdForDevelopment,
	NpUtilsCheckAvailability,
	PresenceSetPresence,
	PresenceGetPresence,
	PresenceDeletePresence,
	RankingSetScore,
	RankingGetRangeOfRanks,
	RankingGetFriendsRanks,
	RankingGetUsersRanks,
	RankingSetGameData,
	RankingGetGameData,
	SessionSendInvitation,
	SessionDisplayReceivedInvitationsDialog,
	SessionGetReceivedInvitations,
	SessionGetInvitationData,
	SessionConsumeInvitation,
	SessionGetData,
	SessionLeave,
	SessionUpdate,
	SessionGetInfo,
	SessionJoin,
	SessionSearch,
	SessionCreate,
	SocialMediaPostMessageToFacebook,
	SharedMediaGetScreenshots,
	SharedMediaGetBroadcasts,
	SharedMediaGetVideos,
	TrophyRegisterTrophyPack,
	TrophyUnlock,
	TrophySetScreenshot,
	TrophyGetUnlockedTrophies,
	TrophyDisplayTrophyListDialog,
	TrophyGetTrophyPackSummary,
	TrophyGetTrophyPackGroup,
	TrophyGetTrophyPackTrophy,
	TssGetData,
	TusSetVariables,
	TusGetVariables,
	TusAddToAndGetVariable,
	TusSetData,
	TusGetData,
	TusDeleteData,
	UserProfileGetNpProfiles,
	UserProfileGetVerifiedAccountsForTitle,
	UserProfileDisplayUserProfileDialog,
	UserProfileDisplayGriefReportingDialog,
	WordfilterFilterComment,
	CoreTerminateService,
	NotificationRefreshRoom,
	NotificationNewRoomMessage,
	NotificationDialogOpened,
	NotificationDialogClosed,
	NotificationUserStateChange,
	NotificationNetStateChange,
	NotificationNewInGameMessage,
	NotificationUpdateFriendsList,
	NotificationNewInvitation,
	NotificationNewGameDataMessage,
	NotificationUpdateFriendPresence,
	NotificationUpdateBlockedUsersList,
	NotificationAborted,
	NumFunctionTypes,
	NotificationSessionInvitationEvent,
	NotificationPlayTogetherHostEvent,
	NotificationGameCustomDataEvent,
	NpUtilsCheckPlus,
	NpUtilsGetParentalControlInfo
}
public class PendingRequest
{
	internal uint npRequestId;

	internal RequestBase request;

	internal bool abortPending;

	public uint NpRequestId => npRequestId;

	public RequestBase Request => request;

	public bool AbortPending => abortPending;
}
internal static class PendingAsyncRequestList
{
	private static Dictionary<uint, PendingRequest> requestsLookup = new Dictionary<uint, PendingRequest>();

	private static List<PendingRequest> pendingRequests = new List<PendingRequest>();

	private static object syncObject = new object();

	public static List<PendingRequest> PendingRequests
	{
		get
		{
			lock (syncObject)
			{
				return new List<PendingRequest>(pendingRequests);
			}
		}
	}

	internal static void Shutdown()
	{
		lock (syncObject)
		{
			pendingRequests.Clear();
		}
	}

	public static bool IsPending(uint npRequestId)
	{
		lock (syncObject)
		{
			return requestsLookup.ContainsKey(npRequestId);
		}
	}

	internal static void AddRequest(uint npRequestId, RequestBase request)
	{
		lock (syncObject)
		{
			PendingRequest pendingRequest = new PendingRequest();
			pendingRequest.npRequestId = npRequestId;
			pendingRequest.request = request;
			pendingRequest.abortPending = false;
			requestsLookup.Add(npRequestId, pendingRequest);
			pendingRequests.Add(pendingRequest);
		}
	}

	internal static RequestBase RemoveRequest(uint npRequestId)
	{
		lock (syncObject)
		{
			PendingRequest value = null;
			if (!requestsLookup.TryGetValue(npRequestId, out value))
			{
				return null;
			}
			requestsLookup.Remove(npRequestId);
			pendingRequests.Remove(value);
			return value.request;
		}
	}

	internal static bool MarkRequestAsAborting(uint npRequestId)
	{
		lock (syncObject)
		{
			PendingRequest value = null;
			if (!requestsLookup.TryGetValue(npRequestId, out value))
			{
				return false;
			}
			value.abortPending = true;
			return true;
		}
	}

	internal static void RequestHasBeenAborted(uint npRequestId)
	{
		lock (syncObject)
		{
			RemoveRequest(npRequestId);
		}
	}
}
public class ServerErrorManaged
{
	private const int JSON_DATA_MAX_LEN = 512;

	internal byte[] jsonData = new byte[512];

	internal long webApiNextAvailableTime = 0L;

	internal int httpStatusCode = 0;

	public string JsonData => Encoding.UTF8.GetString(jsonData, 0, jsonData.Length);

	public long WebApiNextAvailableTime => webApiNextAvailableTime;

	public int HttpStatusCode => httpStatusCode;

	[DllImport("UnityNpToolkit2")]
	private static extern void PrxReadServerError(uint responseId, FunctionTypes apiCalled, out long webApiNextAvailableTime, out int httpStatusCode, [In][Out][MarshalAs(UnmanagedType.LPArray, SizeConst = 512)] byte[] jsonData, out APIResult result);

	internal void ReadResult(uint unqiueId, FunctionTypes apiCalled)
	{
		PrxReadServerError(unqiueId, apiCalled, out webApiNextAvailableTime, out httpStatusCode, jsonData, out var result);
		if (result.RaiseException)
		{
			throw new NpToolkitException(result);
		}
	}
}
internal static class PendingAsyncResponseList
{
	private static Dictionary<uint, ResponseBase> responseLookup = new Dictionary<uint, ResponseBase>();

	private static object syncObject = new object();

	public static void AddResponse(uint npRequestId, ResponseBase response)
	{
		lock (syncObject)
		{
			responseLookup.Add(npRequestId, response);
		}
	}

	public static ResponseBase FindAndRemoveResponse(uint npRequestId)
	{
		lock (syncObject)
		{
			if (responseLookup.TryGetValue(npRequestId, out var value))
			{
				responseLookup.Remove(npRequestId);
				return value;
			}
			return null;
		}
	}
}
internal static class PopulateThread
{
	private static Thread populateThread;

	private static bool stopThread = false;

	private static Semaphore workLoad = new Semaphore(0, 1000);

	[DllImport("UnityNpToolkit2")]
	private static extern bool PrxPopFirstResponse(out ServiceTypes service, out FunctionTypes apiCalled, out uint npRequestId, out int userId, out int customReturnCode);

	public static void Start()
	{
		stopThread = false;
		populateThread = new Thread(RunProc);
		populateThread.Name = "Sony Np";
		populateThread.Start();
	}

	private static void RunProc()
	{
		workLoad.WaitOne();
		Core.UserServiceUserId userId = default(Core.UserServiceUserId);
		while (!stopThread)
		{
			if (PrxPopFirstResponse(out var service, out var apiCalled, out var npRequestId, out userId.id, out var customReturnCode))
			{
				RequestBase requestBase = null;
				NpCallbackEvent npCallbackEvent = null;
				try
				{
					npCallbackEvent = new NpCallbackEvent();
					if (service == ServiceTypes.Notification)
					{
						npCallbackEvent.response = Notifications.CreateNotificationResponse(apiCalled);
					}
					else
					{
						requestBase = PendingAsyncRequestList.RemoveRequest(npRequestId);
						npCallbackEvent.response = PendingAsyncResponseList.FindAndRemoveResponse(npRequestId);
						if (npCallbackEvent.response == null)
						{
							Console.WriteLine("Error : PopulateThread.RunProc : Can't find response object for Request " + npRequestId);
						}
					}
					if (npCallbackEvent.response != null)
					{
						npCallbackEvent.response.PopulateFromNative(npRequestId, apiCalled, requestBase);
						if (customReturnCode != 0)
						{
							npCallbackEvent.response.returnCode = customReturnCode;
						}
					}
					npCallbackEvent.service = service;
					npCallbackEvent.apiCalled = apiCalled;
					npCallbackEvent.npRequestId = npRequestId;
					npCallbackEvent.userId = userId;
					npCallbackEvent.request = requestBase;
					Main.CallOnAsyncEvent(npCallbackEvent);
				}
				catch (NpToolkitException ex)
				{
					Console.WriteLine("Toolkit Exception - PopulateThread.RunProc : " + ex.ExtendedMessage);
					Console.WriteLine(ex.StackTrace);
					Console.WriteLine(string.Concat("Toolkit Exception : service = ", service, " : apiCalled = ", apiCalled, "(", (int)apiCalled, ") : npRequestId = ", npRequestId, " : userId = ", userId.id));
					if (requestBase != null)
					{
						Console.WriteLine("Toolkit Exception - Caused by Request : " + requestBase.functionType);
					}
					if (npCallbackEvent != null && npCallbackEvent.response != null)
					{
						Console.WriteLine("Toolkit Exception - Response Type = " + npCallbackEvent.response.GetType().ToString());
					}
				}
				catch (Exception ex2)
				{
					Console.WriteLine("Exception - PopulateThread.RunProc : " + ex2.Message);
					Console.WriteLine(ex2.StackTrace);
					Console.WriteLine(string.Concat("Toolkit Exception : service = ", service, " : apiCalled = ", apiCalled, "(", (int)apiCalled, ") : npRequestId = ", npRequestId, " : userId = ", userId.id));
					if (requestBase != null)
					{
						Console.WriteLine("Toolkit Exception - Caused by Request : " + requestBase.functionType);
					}
					else
					{
						Console.WriteLine("Toolkit Exception - No request data available");
					}
				}
			}
			workLoad.WaitOne();
		}
	}

	public static void Execute()
	{
		workLoad.Release();
	}

	public static void Stop()
	{
		stopThread = true;
		workLoad.Release();
	}

	[MonoPInvokeCallback(typeof(Main.OnPrxCallbackEvent))]
	public static void OnPrxNpToolkitEvent()
	{
		Execute();
	}
}
internal static class NpRequestsThread
{
	private static Thread requestsThread;

	private static bool stopThread = false;

	private static Semaphore workLoad = new Semaphore(0, 1000);

	[DllImport("UnityNpToolkit2")]
	private static extern bool PrxPollFirstRequest();

	public static void Start()
	{
		stopThread = false;
		requestsThread = new Thread(RunProc);
		requestsThread.Name = "Requests Thread";
		requestsThread.Start();
	}

	private static void RunProc()
	{
		workLoad.WaitOne();
		while (!stopThread)
		{
			if (PrxPollFirstRequest())
			{
				workLoad.WaitOne();
			}
			else
			{
				Thread.Sleep(1000);
			}
		}
	}

	public static void Execute()
	{
		workLoad.Release();
	}

	public static void Stop()
	{
		stopThread = true;
		workLoad.Release();
	}

	[MonoPInvokeCallback(typeof(Main.OnPrxCallbackEvent))]
	public static void OnPrxNpRequestEvent()
	{
		Execute();
	}
}
