using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom;
using RecRoom.Avatars;
using RecRoom.Avatars.Face;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class AvatarSelectionElement : ScriptableObject
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string Guid;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x662E540", Offset = "0x662CF40", VA = "0x18662E540")]
	public AvatarSelectionElement()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct AnchorParams : IEquatable<AnchorParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Vector2 NormalizedPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public Vector3 HemisphereOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Vector3 HemisphereRotations;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static AnchorParams Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x662DE50", Offset = "0x662C850", VA = "0x18662DE50")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x662DCB0", Offset = "0x662C6B0", VA = "0x18662DCB0")]
		public AnchorParams(Vector2 GLIBNCFJCOK, Vector3 IDNBCMADNAP, Vector3 KIDBDKKGFLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x662DCE0", Offset = "0x662C6E0", VA = "0x18662DCE0")]
		public AnchorParams(BDJCCOLDLFP DIFNILFINNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x662DBC0", Offset = "0x662C5C0", VA = "0x18662DBC0", Slot = "4")]
		public bool Equals(AnchorParams MPHACEGLFIL)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BDJCCOLDLFP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BLGFCOFCPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FNHDMOIIAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool POAFJJHPCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HEIODHFHNFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BJNFBMAGFGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool EOEHJGIKBOK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool HKLPJFBEONN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool OJPPFFJFLMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float JMCCLLGAFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float NBOFCICNLCD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float FGIINMIPHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float EIAMPDNBFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float MEAEBHJLDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float MGDEJHKKFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float AKBKHFEPKKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float CEJDMPBHMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float CINOEIFKCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float KFLIDLOOFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	float HLNDBLLCCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	float GJIJHAECKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float PJOAPFOCMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float OAILMDONDJG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float OGNAMMHCIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	float IKJHLENCKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Vector3 IJFOKNIBOLI(Vector3 KIDBDKKGFLJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 ACFFLFHHCFI(Vector3 ONIGBBCNBLE);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 PIAJJNFGKPG();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Vector3 KBOKGDHLMAH();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AnchorParamsRestrictions : BDJCCOLDLFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool AllowTranslation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public bool AllowRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public float DefaultOffsetX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public float MinXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public float MaxXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float DefaultOffsetY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public float MinYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public float MaxYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public float DefaultOffsetZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float MinZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public float MaxZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public float DefaultRotationX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float RightRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float LeftRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public float DefaultRotationY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float RightRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float LeftRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public float DefaultRotationZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float RightRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float LeftRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float MaxUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float MinUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public float MaxVCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float MinVCoordinate;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool GetAllowTranslationX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x662DB30", Offset = "0x662C530", VA = "0x18662DB30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool GetAllowTranslationY
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x662DB60", Offset = "0x662C560", VA = "0x18662DB60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool GetAllowTranslationZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x662DB90", Offset = "0x662C590", VA = "0x18662DB90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool GetAllowRotationX
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x662DAA0", Offset = "0x662C4A0", VA = "0x18662DAA0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool GetAllowRotationY
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x662DAD0", Offset = "0x662C4D0", VA = "0x18662DAD0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool GetAllowRotationZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x662DB00", Offset = "0x662C500", VA = "0x18662DB00", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x754640", Offset = "0x753040", VA = "0x180754640", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x82B540", Offset = "0x829F40", VA = "0x18082B540", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xE61050", Offset = "0xE5FA50", VA = "0x180E61050", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xEF8A50", Offset = "0xEF7450", VA = "0x180EF8A50", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1107D50", Offset = "0x1106750", VA = "0x181107D50", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x10B4100", Offset = "0x10B2B00", VA = "0x1810B4100", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xEF89D0", Offset = "0xEF73D0", VA = "0x180EF89D0", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x118E160", Offset = "0x118CB60", VA = "0x18118E160", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1459F70", Offset = "0x1458970", VA = "0x181459F70", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x1459F60", Offset = "0x1458960", VA = "0x181459F60", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x10C1BC0", Offset = "0x10C05C0", VA = "0x1810C1BC0", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x10C1BA0", Offset = "0x10C05A0", VA = "0x1810C1BA0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1459FA0", Offset = "0x14589A0", VA = "0x181459FA0", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x13682A0", Offset = "0x1366CA0", VA = "0x1813682A0", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xE5D160", Offset = "0xE5BB60", VA = "0x180E5D160", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x153E1C0", Offset = "0x153CBC0", VA = "0x18153E1C0", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1DCA150", Offset = "0x1DC8B50", VA = "0x181DCA150", Slot = "26")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x16C43F0", Offset = "0x16C2DF0", VA = "0x1816C43F0", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x662DA10", Offset = "0x662C410", VA = "0x18662DA10")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x662D7B0", Offset = "0x662C1B0", VA = "0x18662D7B0")]
		public AnchorParams KGCONLAPKAI(AnchorParams LLGKJHHCAIO)
		{
			return default(AnchorParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x662D9F0", Offset = "0x662C3F0", VA = "0x18662D9F0", Slot = "30")]
		public Vector3 PIAJJNFGKPG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x662D790", Offset = "0x662C190", VA = "0x18662D790", Slot = "31")]
		public Vector3 KBOKGDHLMAH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x662D700", Offset = "0x662C100", VA = "0x18662D700", Slot = "28")]
		public Vector3 IJFOKNIBOLI(Vector3 KIDBDKKGFLJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x662D660", Offset = "0x662C060", VA = "0x18662D660", Slot = "29")]
		public Vector3 ACFFLFHHCFI(Vector3 ONIGBBCNBLE)
		{
			return default(Vector3);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OPAENLAEFKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private List<Transform> BKNFILGOALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Matrix4x4[] FMFOMAIANKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<string, Transform> MLOIBEMGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private Dictionary<Transform, Transform> BIIFPGJHPKO;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Transform[] GKIEJGAMCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6633410", Offset = "0x6631E10", VA = "0x186633410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Matrix4x4[] FPDIFKPJMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6633460", Offset = "0x6631E60", VA = "0x186633460")]
	public void GOEELHIKBMN(SkinnedMeshRenderer AIGKKLHNCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6633A00", Offset = "0x6632400", VA = "0x186633A00")]
	public void PNKHMIOMKCG(Transform LOGPOHBHCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6633A70", Offset = "0x6632470", VA = "0x186633A70")]
	private Transform PPJPLGBLEFJ(Transform DGJCHANKHKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6633610", Offset = "0x6632010", VA = "0x186633610")]
	public void LNDDONDIIBJ(OPAENLAEFKJ LKPHDGNIGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6633890", Offset = "0x6632290", VA = "0x186633890")]
	private void OKJDCJGDKMM(Transform EAGPPNPHOBG, List<Transform> FADBJBIPAJF, Dictionary<string, Transform> MINPKKLEPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6633B50", Offset = "0x6632550", VA = "0x186633B50")]
	public OPAENLAEFKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MBIGCMNGNIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool JCDPJBHBBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool JBIGPNOIIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool LCACFFDPDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public bool GIKCIPMBDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public bool IDJPHHBKBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public bool PIIPKAIHEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool GBFGHGBIPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public IList<HLEHNIDDCEG> CNHPMCIFCMK;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public MBIGCMNGNIJ()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xDC40C0", Offset = "0xDC2AC0", VA = "0x180DC40C0")]
		protected AvatarConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AvatarCustomizationSettings
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public enum LMMJCMIOHAH
		{
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			Legacy_Hide,
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			On,
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			Off
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const int SERIALIZATION_VERSION = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private string eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private string mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private string hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private string hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private string hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private string beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private string beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private string beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private string faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private string bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private LMMJCMIOHAH useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private string baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x730AF0", Offset = "0x72F4F0", VA = "0x180730AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x27BBC00", Offset = "0x27BA600", VA = "0x1827BBC00")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA12F90", Offset = "0xA11990", VA = "0x180A12F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x10B4100", Offset = "0x10B2B00", VA = "0x1810B4100")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x10B4110", Offset = "0x10B2B10", VA = "0x1810B4110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7A9630", Offset = "0x7A8030", VA = "0x1807A9630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3B508A0", Offset = "0x3B4F2A0", VA = "0x183B508A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xD7F020", Offset = "0xD7DA20", VA = "0x180D7F020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x10C1BA0", Offset = "0x10C05A0", VA = "0x1810C1BA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x10C1BB0", Offset = "0x10C05B0", VA = "0x1810C1BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7270F0", Offset = "0x725AF0", VA = "0x1807270F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8093E0", Offset = "0x807DE0", VA = "0x1808093E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7270A0", Offset = "0x725AA0", VA = "0x1807270A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x79AB50", Offset = "0x799550", VA = "0x18079AB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7270D0", Offset = "0x725AD0", VA = "0x1807270D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8093D0", Offset = "0x807DD0", VA = "0x1808093D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7270B0", Offset = "0x725AB0", VA = "0x1807270B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7B2610", Offset = "0x7B1010", VA = "0x1807B2610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public string BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7270C0", Offset = "0x725AC0", VA = "0x1807270C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8093C0", Offset = "0x807DC0", VA = "0x1808093C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x727040", Offset = "0x725A40", VA = "0x180727040")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7392A0", Offset = "0x737CA0", VA = "0x1807392A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x727050", Offset = "0x725A50", VA = "0x180727050")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x748820", Offset = "0x747220", VA = "0x180748820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x74D1A0", Offset = "0x74BBA0", VA = "0x18074D1A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x748800", Offset = "0x747200", VA = "0x180748800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8750E0", Offset = "0x873AE0", VA = "0x1808750E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8753F0", Offset = "0x873DF0", VA = "0x1808753F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public LMMJCMIOHAH UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x662E3F0", Offset = "0x662CDF0", VA = "0x18662E3F0")]
			get
			{
				return default(LMMJCMIOHAH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x87A100", Offset = "0x878B00", VA = "0x18087A100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xBCC700", Offset = "0xBCB100", VA = "0x180BCC700")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xBCCCA0", Offset = "0xBCB6A0", VA = "0x180BCCCA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x662E3D0", Offset = "0x662CDD0", VA = "0x18662E3D0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x662E4C0", Offset = "0x662CEC0", VA = "0x18662E4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string BaseAvatarType
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x727080", Offset = "0x725A80", VA = "0x180727080")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x748830", Offset = "0x747230", VA = "0x180748830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool UsesFullBodyAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x662E420", Offset = "0x662CE20", VA = "0x18662E420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2764620", Offset = "0x2763020", VA = "0x182764620")]
		public string HLHCEBOKDMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x662DEC0", Offset = "0x662C8C0", VA = "0x18662DEC0")]
		public static AvatarCustomizationSettings JDGCKOHAIDJ(string IOENONLLAKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x662E210", Offset = "0x662CC10", VA = "0x18662E210")]
		public AvatarCustomizationSettings()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public SkinnedMeshRenderer[] LODs;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SkeletonLODUpdateRate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public FCDCKNBKJML lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public float updateRate;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct AvatarHairPatternOverride
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public string PatternGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public Texture2D Texture;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct ODLIIPADHBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Transform MBIEJALFDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public GameObject KKIJKELLAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public SkinnedMeshRenderer[] HNNOEAEDHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public SkinnedMeshRenderer[] CFMFGOKOIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public GameObject EHDONBEGLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public SkinnedMeshRenderer[] ENFKHPMKECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public SkinnedMeshRenderer[] HOEJKIGKLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public OPAENLAEFKJ GMLJMIMDEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Material PJLHLHLOHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Material NIIGBHEBMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Shader IDKBFIKKMOJ;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct GGEOJIDLALM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Transform JCPOBCALHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Transform MOGCCFAHOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Transform OIDCAIEOHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Transform DELGNLODDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public Transform BCPCBMPFKAE;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct KPPFLFJFELB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public SkinnedMeshRenderer[] DMFHPLMDGIK;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct IDNHPJADGGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public JMEPPPMIBHM KGKKJBLICHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public int PJIIBALFKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int DCLLMBJHGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int HMGNPLIJDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public int ELMCNDKJEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int ALLGLEBDLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int MNPKHCMGBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public int LGINFMDOIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float CMPMEAJJPBC;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct EKCGFMFPFIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public JMEPPPMIBHM KGKKJBLICHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Vector2 KFDDBIBFJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float PGIIAKBHEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Vector2 IDAJBJKEEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float EBAHJIFEIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Vector2 IOOEICBOLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float JNAIBEMBKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float JMPJEKPEJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Vector2 EECDEDDPBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Vector2 OLPKOBIDJHL;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HLEHNIDDCEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public string HOIPOKICKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public OutfitType MKCPBKJPGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public BJLHCNKBHJF DPBHPMCDPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public bool BFOADLNGMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Color? KKLDJIGGILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3? CKKJABALBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float? PGMBCMMCJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Guid? KAFJJHBPCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Color? NDMGAAPLLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool OFMEKDABCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool ILEMAFDCPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public AnchorParamsRestrictions ADLACGHBGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Vector2? ECHLGKDNOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Transform AMIHBBCNJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public FitMeshHemisphere JCKCOACBGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Vector2 LAGBGEJMFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private List<AvatarHairPatternOverride> FONGNNHKJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private Dictionary<string, Texture2D> ELMHPNIABJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<AvatarHairPatternOverride> DACEBGLEDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Dictionary<string, Texture2D> NIIBFLIEBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public AssetReference AEEFBPCFNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public AssetReference OOOMBMOOBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public AssetReference[] GGHENKIKOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool BAEKAFMNHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE9")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool IINAGGOHLIE;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public List<AvatarHairPatternOverride> BMMCODJGLCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x727090", Offset = "0x725A90", VA = "0x180727090")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6630DA0", Offset = "0x662F7A0", VA = "0x186630DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public List<AvatarHairPatternOverride> JPNNOCBHENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x82B350", Offset = "0x829D50", VA = "0x18082B350")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6631080", Offset = "0x662FA80", VA = "0x186631080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string KAHJMHDGION
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6630FD0", Offset = "0x662F9D0", VA = "0x186630FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x66312B0", Offset = "0x662FCB0", VA = "0x1866312B0")]
	public HLEHNIDDCEG()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class AvatarItemMaterial : AvatarSelectionElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x662E4E0", Offset = "0x662CEE0", VA = "0x18662E4E0")]
		public static void BCHMFOJOOPD(AvatarItemMaterial OKJJOBDPNGL, Material NIFEJPCAIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x662E540", Offset = "0x662CF40", VA = "0x18662E540")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BBJBIDBAIOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Mesh CMJKLMHPJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Material[] HECMIAOPCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool PNBDMAONBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool KFELIJMBILP;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	private BBJBIDBAIOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x662EB30", Offset = "0x662D530", VA = "0x18662EB30")]
	public BBJBIDBAIOM(Mesh JPGFKCEECPG, Material[] BNIOFOIDNPE, bool KBJHBJOLAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x662EA10", Offset = "0x662D410", VA = "0x18662EA10")]
	public BBJBIDBAIOM(SkinnedMeshRenderer ANHAEHCOCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x662E6A0", Offset = "0x662D0A0", VA = "0x18662E6A0")]
	public static BBJBIDBAIOM GPNGANFCKPN(Renderer AIGKKLHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum MHJMDOMFEIN
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Highfive,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Fistbump,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Handshake,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	Point,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	ThumbsUp,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	ThumbsDown,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	OpenHand
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum LGDFEDNCBDO
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum BJLHCNKBHJF
{
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Nose
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Flags]
public enum MEJPOCDAEGF
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Head = 1,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Torso = 2,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	LeftHand = 4,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	RightHand = 8,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Mouth = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Legs = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	RightFoot = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	LeftFoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	FullBody = 0x100,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Nose = 0x200
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum NOFDNEBJIKK
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum GFAACINOCDD
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum ONOLOCPGAKN
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum FLGJOHPFKFO
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum NKLMPEELMBB
{
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class JDMHCICDPPM
{
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static readonly int CJBPEDOFKLK;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static readonly string OPLAFDBNKPL;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static readonly string NGIOEKJFEOL;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x66314E0", Offset = "0x662FEE0", VA = "0x1866314E0")]
	public static DKIEELGDAGK DDGBDPPLGID()
	{
		return default(DKIEELGDAGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x66315A0", Offset = "0x662FFA0", VA = "0x1866315A0")]
	public static NFECBEDIPFJ IJANMECLIMM(Transform OIDCDAJDFJD, Transform IPMHOHOGLON, AvatarConfiguration PEBJDBECJHD, Animator BIPDNJNAKCO, VRIK BONCJGFFMAE, SkeletonLODUpdateRate[] DPLDGDJMMFB, GameObject[] NNNDGCBMNKA, Transform BDOKAPDDIHJ, GameObject HADICMHDJMP, BodySkinnedMeshLODs OLJHMHGHCPO, BodySkinnedMeshLODs ENCJKKLNEGP, GameObject JLBKLJNCEPF, BodySkinnedMeshLODs CMAHAHIDBGE, BodySkinnedMeshLODs ONMKEPLLHEO, OPAENLAEFKJ MLLKJLPDEKC, Material BFADNIBADKK, Material EHPLKHDFMDN, Shader MECMECDLMCA, Transform KEDGNJBMFLB, Transform KOPJMBJEIFD, Transform PFBEEFLHEMJ, Transform EGLKCJLAALH, Transform FMFCJPOGGLD)
	{
		return default(NFECBEDIPFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x66312C0", Offset = "0x662FCC0", VA = "0x1866312C0")]
	public static NCGEPACEDNP BAGABPLCKHJ(string NPHEMPIIJLM, bool PIOEHMHFFGE, bool MKPKCNCLKBM, bool EKFBEIFHKNK, RigidbodyEx CCHHIINKLCF, RigidbodyEx NMMALIEJFFM, RigidbodyEx GIANDLAGIMP, RigidbodyEx BEDBNNMHBBM, Transform BLELHMHPIEE, Transform NFBOPBHHGBC, Transform OKDLDHILINA, float KDOOINEMMLO, float OHCLGDFGIHL, PlayerAvatarFullBodyColliders AOKJMJIFABG)
	{
		return default(NCGEPACEDNP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x66317C0", Offset = "0x66301C0", VA = "0x1866317C0")]
	public static ODLIIPADHBN OBIKNKONNCD(Transform IPMHOHOGLON, GameObject HADICMHDJMP, SkinnedMeshRenderer[] HHKEFLLFLMA, SkinnedMeshRenderer[] CKGKMAADJBD, GameObject JLBKLJNCEPF, SkinnedMeshRenderer[] KHMLPHGHFIJ, SkinnedMeshRenderer[] HBDOBLICLBG, OPAENLAEFKJ MLLKJLPDEKC, Material BFADNIBADKK, Material EHPLKHDFMDN, Shader MECMECDLMCA)
	{
		return default(ODLIIPADHBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6631510", Offset = "0x662FF10", VA = "0x186631510")]
	public static GGEOJIDLALM EAILOBJJBJJ(Transform KEDGNJBMFLB, Transform PFBEEFLHEMJ, Transform KOPJMBJEIFD, Transform EGLKCJLAALH, Transform FMFCJPOGGLD)
	{
		return default(GGEOJIDLALM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x10A3770", Offset = "0x10A2170", VA = "0x1810A3770")]
	public static KPPFLFJFELB KIONNGGEHLG(SkinnedMeshRenderer[] HJHGCCNDCAN)
	{
		return default(KPPFLFJFELB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6631460", Offset = "0x662FE60", VA = "0x186631460")]
	public static IDNHPJADGGI BEMINAPEJJM(JMEPPPMIBHM OKDGILMCAPP, int LMOAHOHECPM, int JELCHNIJBEG, int KGCFKGFMGLJ, int FKILNFAPJHO, int AOIFNJCMDFJ, int NFHJHMOJPCE, int LIAJNEENJLJ, float GJNGCIHEBMN)
	{
		return default(IDNHPJADGGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x66313D0", Offset = "0x662FDD0", VA = "0x1866313D0")]
	public static EKCGFMFPFIH BCENKJHNBIE(JMEPPPMIBHM OKDGILMCAPP, Vector2 FAGKMLKMDNL, float EFKPMKMCMAM, Vector2 AMCJMBBEFJH, float DGCMKGBENNG, Vector2 DGEIGHDKJBM, float PBINJMHBMMP)
	{
		return default(EKCGFMFPFIH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface AKJEHADBJGB
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Transform LHEBMCHBDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Vector3 GDGBBNGGLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class PPJDJPDOGBB : AKJEHADBJGB
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public Transform LHEBMCHBDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x730AE0", Offset = "0x72F4E0", VA = "0x180730AE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public Vector3 GDGBBNGGLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x12B1630", Offset = "0x12B0030", VA = "0x1812B1630", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x12B1620", Offset = "0x12B0020", VA = "0x1812B1620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public float? AJINMHOAOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x12B1610", Offset = "0x12B0010", VA = "0x1812B1610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x12B1600", Offset = "0x12B0000", VA = "0x1812B1600")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public PPJDJPDOGBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class ABHMCKEHIBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	protected readonly PPJDJPDOGBB DPNOMFDOKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	protected readonly PPJDJPDOGBB BBNEFKOOAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	protected readonly PPJDJPDOGBB LAOJNHLCDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	protected readonly PPJDJPDOGBB KGGHICIMABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	protected readonly PPJDJPDOGBB PKEEEMAHEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	protected readonly PPJDJPDOGBB NNHKNJDOEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	protected readonly PPJDJPDOGBB HDFFDHEOMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	protected readonly PPJDJPDOGBB HOLLHIJOALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected readonly PPJDJPDOGBB OCOEGPPJOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	protected readonly PPJDJPDOGBB PNPHDLBHNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	protected readonly PPJDJPDOGBB IANGLLKEMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	protected readonly PPJDJPDOGBB LADIPEPGHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	protected readonly PPJDJPDOGBB MMDFELAHFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	protected PPJDJPDOGBB JALNMPAJJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	protected readonly PPJDJPDOGBB BAJCHNGIMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	protected readonly PPJDJPDOGBB IGKBPLNINND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	protected readonly PPJDJPDOGBB MBHFCFHDMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	protected PPJDJPDOGBB EMLFGOJEPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	protected readonly PPJDJPDOGBB NPHBJLABLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected readonly PPJDJPDOGBB HDPCDNPFLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	protected readonly PPJDJPDOGBB HILHEEONEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected ReadOnlyCollection<PPJDJPDOGBB> KCLILGKCCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public Transform BDOKAPDDIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private (PPJDJPDOGBB Start, PPJDJPDOGBB End)[] GFAPDMLLMGM;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public AKJEHADBJGB HMNCBHKALLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public AKJEHADBJGB KFMHDJPBIPF
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public AKJEHADBJGB AEINGFIPHDF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public AKJEHADBJGB IKHOACALJII
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x72B270", Offset = "0x729C70", VA = "0x18072B270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public AKJEHADBJGB PEGEKCKPONH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public AKJEHADBJGB OJPFBADCPBC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x731A10", Offset = "0x730410", VA = "0x180731A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public AKJEHADBJGB MPBAGJOACAA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76F9F0", VA = "0x180770FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public PPJDJPDOGBB COGHMGJEABH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76F9F0", VA = "0x180770FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public AKJEHADBJGB EADCHLCNKDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7270F0", Offset = "0x725AF0", VA = "0x1807270F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public PPJDJPDOGBB PGCOJPFKDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7270F0", Offset = "0x725AF0", VA = "0x1807270F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public AKJEHADBJGB JDJKOPAOOBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7270A0", Offset = "0x725AA0", VA = "0x1807270A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public AKJEHADBJGB GLIJFPPCLBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7270D0", Offset = "0x725AD0", VA = "0x1807270D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public AKJEHADBJGB FNMHKFLHFNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7270B0", Offset = "0x725AB0", VA = "0x1807270B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public PPJDJPDOGBB HDAOHMEGNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7270B0", Offset = "0x725AB0", VA = "0x1807270B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public PPJDJPDOGBB NFGANOFJBMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7270C0", Offset = "0x725AC0", VA = "0x1807270C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public AKJEHADBJGB AEJMLLPODND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7270C0", Offset = "0x725AC0", VA = "0x1807270C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public AKJEHADBJGB GCPBCNABHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x727040", Offset = "0x725A40", VA = "0x180727040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public AKJEHADBJGB LKLDOKHNFKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x727050", Offset = "0x725A50", VA = "0x180727050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public AKJEHADBJGB FOCKNMJKJBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x74D1A0", Offset = "0x74BBA0", VA = "0x18074D1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public AKJEHADBJGB JFAGJBHDBMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x82D960", Offset = "0x82C360", VA = "0x18082D960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public AKJEHADBJGB EHAAOAPPBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7EC720", Offset = "0x7EB120", VA = "0x1807EC720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public AKJEHADBJGB JJOKKEKPPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x74D170", Offset = "0x74BB70", VA = "0x18074D170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public AKJEHADBJGB LBBHMJPPHIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x727060", Offset = "0x725A60", VA = "0x180727060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public AKJEHADBJGB NJDDCGKHLEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x727070", Offset = "0x725A70", VA = "0x180727070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public AKJEHADBJGB DIAEDNMIPFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x727090", Offset = "0x725A90", VA = "0x180727090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public IReadOnlyList<AKJEHADBJGB> DKDFGPMBPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x727080", Offset = "0x725A80", VA = "0x180727080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x662C240", Offset = "0x662AC40", VA = "0x18662C240")]
	public void JBHBBPKNOHB(VRIK HJHKECIFCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5F00", Offset = "0x2BD4900", VA = "0x182BD5F00")]
	private void FPFCPCAOBAJ(Transform KCGHNGOMAMI, PPJDJPDOGBB ELODBNLDLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x662CE10", Offset = "0x662B810", VA = "0x18662CE10")]
	public void NJALBDAPFPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2BD5860", Offset = "0x2BD4260", VA = "0x182BD5860")]
	public float EEIJFBICKLG(in (PPJDJPDOGBB Start, PPJDJPDOGBB End) NNNOLHFJAKK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x662CC30", Offset = "0x662B630", VA = "0x18662CC30")]
	public void LAOBEMPCCOE(in DKIEELGDAGK OJNFGJAPBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x662C0F0", Offset = "0x662AAF0", VA = "0x18662C0F0")]
	private Vector3 AMHLMABPOED(in (PPJDJPDOGBB Start, PPJDJPDOGBB End) NNNOLHFJAKK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x662D2C0", Offset = "0x662BCC0", VA = "0x18662D2C0")]
	public ABHMCKEHIBC()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x662E600", Offset = "0x662D000", VA = "0x18662E600")]
		public string JIFLMHGJECH(string HFKDBMDMLKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x662E650", Offset = "0x662D050", VA = "0x18662E650")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct NCGEPACEDNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public string FBBKKKOJBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool IKJDNLBFBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool CKBFOLMFGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public float NHDDCACBJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public float PGKKCLKEIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public bool DKJLCPMIONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public RigidbodyEx MOFFAEOGPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public RigidbodyEx JMDNCGBCLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public RigidbodyEx PEAKBHKKNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public RigidbodyEx PBDFPGFMNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public Transform GCFJIOOCHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public Transform JGEKLJLCAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public Transform CLFKLADECJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public PlayerAvatarFullBodyColliders EGKPANNBEJN;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct NFECBEDIPFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Transform HOELEHEDINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public Transform FJKAMBBNGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public AvatarConfiguration BBEJPEJNGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Animator DEGJDIINKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public VRIK NOJPKMNEOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public SkeletonLODUpdateRate[] IJPFLNIICDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public GameObject[] BEKCNEAHAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Transform OBAEKGGDNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public GameObject KKIJKELLAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public BodySkinnedMeshLODs DOLHFEJKHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public BodySkinnedMeshLODs FELNKPELNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public GameObject EHDONBEGLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public BodySkinnedMeshLODs EPNIBEOBJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public BodySkinnedMeshLODs CEADDDIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public OPAENLAEFKJ GMLJMIMDEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public Material PJLHLHLOHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public Material NIIGBHEBMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public Shader IDKBFIKKMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public Transform JCPOBCALHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public Transform OIDCAIEOHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public Transform MOGCCFAHOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public Transform DELGNLODDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public Transform BCPCBMPFKAE;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct DKIEELGDAGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public float ONLLPCFDIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public bool DNOPCPOBMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public FCDCKNBKJML JFJDFFKGPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public Vector3 IBLGBCBELBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public Vector3 NNGDNGAMIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public Vector3? IEKOMDKCHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public Vector3? ONICJDHHKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public bool INMBMAFNECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public bool LMPJEKGPBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public bool KHDGIJAHJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public bool ICMMHPHBHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool ONOAEEOGANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public Vector3? JEGLELNLKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool CJCKEDCIEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public Vector3? GIKKDJELHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public bool IDBAFBIALFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public Vector3? NKHIAEJBHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public Vector3? NLNMDKGPBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public bool HHNDJHKLEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public bool MIKFCDLNFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public bool LHFFBBLHDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public bool GJJHHONNECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool PIAFBFHGCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool KMEAHFLGFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public bool NKNGKIKOCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool DDJMIGEPBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public bool CFINADIFMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public bool IHLCGKHAHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public Vector3? JFEGPHIHGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public MHJMDOMFEIN LLLEGDAPGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public MHJMDOMFEIN CHDDCABPAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public float GJMBKBMEHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public float JGBNLEFBLPP;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface GJFNMOMAHNP
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJFBJIDLCCD();

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::EBCMIJBCHOC<Texture2D> EAEADALJFHB(IFMBCBAPEDO ELJDPKAKMKM, [Optional] NNEGPJHBIIE BHGFJLDJJON);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class BILBJAAGDHB : GJFNMOMAHNP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private MKHAAJODKBK JDLFNMONOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private IRecRoomQualityConfigProvider LDPPFCIGJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private bool BPADAGFHNCC;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private const uint JKGIOPDGNFA = 16u;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x662EC40", Offset = "0x662D640", VA = "0x18662EC40")]
	[JDDIJBKLPJE(GHILFLKBMBN.None)]
	private static void BLJDAMCOIOA(AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	[Preserve]
	public BILBJAAGDHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x662F350", Offset = "0x662DD50", VA = "0x18662F350")]
	private void LNIAGJFHONI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x662F400", Offset = "0x662DE00", VA = "0x18662F400", Slot = "4")]
	public void OJFBJIDLCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x662EF40", Offset = "0x662D940", VA = "0x18662EF40", Slot = "5")]
	public global::EBCMIJBCHOC<Texture2D> EAEADALJFHB(IFMBCBAPEDO ELJDPKAKMKM, [Optional] NNEGPJHBIIE BHGFJLDJJON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x662ED30", Offset = "0x662D730", VA = "0x18662ED30")]
	private uint DBCPAHGIKBE(IFMBCBAPEDO ELJDPKAKMKM, NNEGPJHBIIE BHGFJLDJJON)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum HMNNEAPFBJN
{
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class NNEGPJHBIIE
{
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static readonly NNEGPJHBIIE EBMJMAANCBN;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int HLDNDHFOMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x727020", Offset = "0x725A20", VA = "0x180727020")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7318F0", Offset = "0x7302F0", VA = "0x1807318F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public HMNNEAPFBJN DIGIIPNELOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7270E0", Offset = "0x725AE0", VA = "0x1807270E0")]
		[CompilerGenerated]
		get
		{
			return default(HMNNEAPFBJN);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA4DC20", Offset = "0xA4C620", VA = "0x180A4DC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public NNEGPJHBIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6633300", Offset = "0x6631D00", VA = "0x186633300")]
	public NNEGPJHBIIE(HMNNEAPFBJN FLAGJIBPLNC, int FGOMBIENHFG)
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6630D90", Offset = "0x662F790", VA = "0x186630D90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6630CD0", Offset = "0x662F6D0", VA = "0x186630CD0")]
		public FitMeshHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x66308B0", Offset = "0x662F2B0", VA = "0x1866308B0")]
		public void KJJGGBJLHHP(FitMeshHemisphere BADGGAEEHDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6630570", Offset = "0x662EF70", VA = "0x186630570")]
		public Vector3 GEACIIBDDIP(Vector2 NDJMJLGKMNA, bool EEBCENCEOBJ = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x66304D0", Offset = "0x662EED0", VA = "0x1866304D0")]
		public Vector3 BAFCJKFCAHJ(Vector2 NDJMJLGKMNA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6630A10", Offset = "0x662F410", VA = "0x186630A10")]
		public Quaternion MNPGJLHPHKD(Vector2 NDJMJLGKMNA)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6630900", Offset = "0x662F300", VA = "0x186630900")]
		public Quaternion MNPGJLHPHKD(Vector2 NDJMJLGKMNA, Vector3 LEBJPGDJFAJ)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6630530", Offset = "0x662EF30", VA = "0x186630530")]
		private Vector2 DCFDFIOLNAP(Vector2 BFAKKMLJOKB)
		{
			return default(Vector2);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct HCAMBKKGICP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public readonly GameObject NBKOMLPOFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public readonly AvatarItemMaterial OMKMLCAKDFF;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7C16B0", Offset = "0x7C00B0", VA = "0x1807C16B0")]
	public HCAMBKKGICP(GameObject NBKOMLPOFGC, AvatarItemMaterial OMKMLCAKDFF)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class BLLPICIMNGG
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x662F460", Offset = "0x662DE60", VA = "0x18662F460")]
	public static bool BGGCGBEBIMG(this OutfitType APIBEGHGDDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x662F490", Offset = "0x662DE90", VA = "0x18662F490")]
	public static bool MCBPLFPFCCN(this OutfitType APIBEGHGDDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x662F4D0", Offset = "0x662DED0", VA = "0x18662F4D0")]
	public static bool PPAJPFEAIAE(this OutfitType APIBEGHGDDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x662F4C0", Offset = "0x662DEC0", VA = "0x18662F4C0")]
	public static bool MOHJBDPCKAD(this OutfitType APIBEGHGDDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x662F4B0", Offset = "0x662DEB0", VA = "0x18662F4B0")]
	public static bool MIOHKIBOKBK(this OutfitType APIBEGHGDDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x662F480", Offset = "0x662DE80", VA = "0x18662F480")]
	public static bool DMOADCFBFMP(this OutfitType APIBEGHGDDH)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private OPAENLAEFKJ ICMIBKMHIKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private Collider[] CDMLNLMLHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private Collider[] BFLABGJLBJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6633CD0", Offset = "0x66326D0", VA = "0x186633CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6633C50", Offset = "0x6632650", VA = "0x186633C50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6633E90", Offset = "0x6632890", VA = "0x186633E90")]
		public void UpdateBones(OPAENLAEFKJ MLLKJLPDEKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6633D40", Offset = "0x6632740", VA = "0x186633D40")]
		public void SetCollidersEnabled(bool EFCPHECCPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6633EC0", Offset = "0x66328C0", VA = "0x186633EC0")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x72BC30", Offset = "0x72A630", VA = "0x18072BC30", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x662F4E0", Offset = "0x662DEE0", VA = "0x18662F4E0")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x72B5A0", Offset = "0x729FA0", VA = "0x18072B5A0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x662F4E0", Offset = "0x662DEE0", VA = "0x18662F4E0")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x662F870", Offset = "0x662E270", VA = "0x18662F870")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x82DA80", Offset = "0x82C480", VA = "0x18082DA80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x13870F0", Offset = "0x1385AF0", VA = "0x1813870F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x14EEC10", Offset = "0x14ED610", VA = "0x1814EEC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x662F740", Offset = "0x662E140", VA = "0x18662F740", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x662F7F0", Offset = "0x662E1F0", VA = "0x18662F7F0")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public abstract class FaceFeatureBase : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private const bool HIGH_QUALTIY_COMPRESS = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		private string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		private Sprite[] Sprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public string Guid
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public IEnumerable<Sprite> SrcSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x72B270", Offset = "0x729C70", VA = "0x18072B270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x662F720", Offset = "0x662E120", VA = "0x18662F720")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x47EE360", Offset = "0x47ECD60", VA = "0x1847EE360")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1937C10", Offset = "0x1936610", VA = "0x181937C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x662F550", Offset = "0x662DF50", VA = "0x18662F550")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x662F5C0", Offset = "0x662DFC0", VA = "0x18662F5C0", Slot = "5")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x662F640", Offset = "0x662E040", VA = "0x18662F640")]
		protected FaceFeatureBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class JMEPPPMIBHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private class NOGIJHGELCA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public readonly Texture2DArray HLOIAHINNIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public readonly Dictionary<string, int> EIEAIBEOKJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private readonly BHECNCBBLMC GDFPKEBEFHP;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool EPAMMAMBPAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x1FD3BD0", Offset = "0x1FD25D0", VA = "0x181FD3BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6633340", Offset = "0x6631D40", VA = "0x186633340")]
		public NOGIJHGELCA(Texture2DArray MHNGBAGDOAL, Dictionary<string, int> BJAPIIGFFHC, JMEPPPMIBHM LDCMJAEDFKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x1442800", Offset = "0x1441200", VA = "0x181442800")]
		public void GHAKHFNEEBH(JMEPPPMIBHM MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x1442910", Offset = "0x1441310", VA = "0x181442910")]
		public void FFJEEECDHBK(JMEPPPMIBHM MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x1361BF0", Offset = "0x13605F0", VA = "0x181361BF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct NFJIKMHLHDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private readonly string CMOOEHIOMLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private readonly string NBKEKKHCDFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private readonly string AHJJBECPBCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private readonly string BOKMNCINENB;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5530250", Offset = "0x552EC50", VA = "0x185530250")]
		public NFJIKMHLHDN(string LEJFOICLPNI, string EJEEDDCIBEB, string LBNBJEPFOIM, string PDGBIGDGNCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6632FB0", Offset = "0x66319B0", VA = "0x186632FB0")]
		public bool MDDDKCHCFCJ(NFJIKMHLHDN MPHACEGLFIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6633040", Offset = "0x6631A40", VA = "0x186633040", Slot = "0")]
		public override bool Equals(object NBNOMDAKOCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x66331B0", Offset = "0x6631BB0", VA = "0x1866331B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6632FB0", Offset = "0x66319B0", VA = "0x186632FB0")]
		public static bool BOBJELOEACN(NFJIKMHLHDN LJLKLAFAGNO, NFJIKMHLHDN HFBAHIGFPIF)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6633120", Offset = "0x6631B20", VA = "0x186633120")]
		public static bool GPCPOEGFAHL(NFJIKMHLHDN LJLKLAFAGNO, NFJIKMHLHDN HFBAHIGFPIF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly Dictionary<string, int> BJAPIIGFFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly NFJIKMHLHDN DKLCPGGDHML;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Texture2DArray JIJBALEGCGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x730AF0", Offset = "0x72F4F0", VA = "0x180730AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public SymmetricalFaceFeature OHOLNPEOKKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x74C3F0", Offset = "0x74ADF0", VA = "0x18074C3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public SymmetricalFaceFeature MIBCIHJCACC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x72B270", Offset = "0x729C70", VA = "0x18072B270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x752CF0", Offset = "0x7516F0", VA = "0x180752CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public SymmetricalFaceFeature ICOMHBBGPCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7A9630", Offset = "0x7A8030", VA = "0x1807A9630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public FaceFeature CIPJLKGPFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x731A10", Offset = "0x730410", VA = "0x180731A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x731A20", Offset = "0x730420", VA = "0x180731A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x66319E0", Offset = "0x66303E0", VA = "0x1866319E0")]
	private static void GFAFEMPILGG(Sprite CLAFOINJMNO, Sprite COLPMBEFOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6631970", Offset = "0x6630370", VA = "0x186631970")]
	private static void FMNFHBCIIPH(Sprite CBBEKKLCOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6632940", Offset = "0x6631340", VA = "0x186632940")]
	public JMEPPPMIBHM(SymmetricalFaceFeature KPFFNMGHAPD, FaceFeature LMAGCLGKMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6631CF0", Offset = "0x66306F0", VA = "0x186631CF0")]
	public JMEPPPMIBHM(SymmetricalFaceFeature ALMOBDNLEDP, SymmetricalFaceFeature KPFFNMGHAPD, SymmetricalFaceFeature FIDCBJOJBHF, FaceFeature LMAGCLGKMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6631AE0", Offset = "0x66304E0", VA = "0x186631AE0")]
	public bool KJMHLDHBOED(Sprite CBBEKKLCOBK, out int EGNHJGKABLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6631960", Offset = "0x6630360", VA = "0x186631960", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Eye = 0,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Mouth = 1,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Nose = 2,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		Brows = 3,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		EyeGleams = 4,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Other = 10
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public SymmetricalFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public SymmetricalFaceFeature[] EyeGleams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Dictionary<string, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private Dictionary<string, SymmetricalFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private Dictionary<string, SymmetricalFaceFeature> eyeGleamFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private Dictionary<string, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private Dictionary<string, int> featureToIndexMap;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x66304A0", Offset = "0x662EEA0", VA = "0x1866304A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x662FB60", Offset = "0x662E560", VA = "0x18662FB60")]
		public JMEPPPMIBHM HHHGPANOPOC(int KPFFNMGHAPD, int LMAGCLGKMPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x662FE00", Offset = "0x662E800", VA = "0x18662FE00")]
		public JMEPPPMIBHM HHHGPANOPOC(int OIGNMIADNKF, int KPFFNMGHAPD, int JEDOLABNDOG, int LMAGCLGKMPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6630080", Offset = "0x662EA80", VA = "0x186630080")]
		public FaceFeatureBase HIMNPIJKNBH(FaceFeatureType NDPOJEPADAJ, string NPIFLODGAHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6630390", Offset = "0x662ED90", VA = "0x186630390")]
		public int OEKJBGKMPCD(string NPIFLODGAHD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x662F890", Offset = "0x662E290", VA = "0x18662F890")]
		private void ADBLMKAELEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x25969A0", Offset = "0x25953A0", VA = "0x1825969A0")]
		private void NGONMFGCJAE<T>(Dictionary<string, T> GDCEFHMGFFB, T[] ENOPFDBLECC) where T : FaceFeatureBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x662FA70", Offset = "0x662E470", VA = "0x18662FA70")]
		public string CAGPGFLBNCO(FaceFeatureType NDPOJEPADAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6630210", Offset = "0x662EC10", VA = "0x186630210")]
		public string KLOBGMNDKOJ(FaceFeatureType NDPOJEPADAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6630420", Offset = "0x662EE20", VA = "0x186630420")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7374E0", Offset = "0x735EE0", VA = "0x1807374E0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6632FA0", Offset = "0x66319A0", VA = "0x186632FA0")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class NoseFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x72BC40", Offset = "0x72A640", VA = "0x18072BC40", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6632FA0", Offset = "0x66319A0", VA = "0x186632FA0")]
		public NoseFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x6634120", Offset = "0x6632B20", VA = "0x186634120")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x45FABC0", Offset = "0x45F95C0", VA = "0x1845FABC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x1459F80", Offset = "0x1458980", VA = "0x181459F80")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x45FABB0", Offset = "0x45F95B0", VA = "0x1845FABB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x1459F40", Offset = "0x1458940", VA = "0x181459F40")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x37FC520", Offset = "0x37FAF20", VA = "0x1837FC520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1459EA0", Offset = "0x14588A0", VA = "0x181459EA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x6634140", Offset = "0x6632B40", VA = "0x186634140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6634010", Offset = "0x6632A10", VA = "0x186634010", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x662F4E0", Offset = "0x662DEE0", VA = "0x18662F4E0")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6632CC0", Offset = "0x66316C0", VA = "0x186632CC0")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6632970", Offset = "0x6631370", VA = "0x186632970")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
