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
	[Cpp2IlInjected.Address(RVA = "0x62CC830", Offset = "0x62CB830", VA = "0x1862CC830")]
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
			[Cpp2IlInjected.Address(RVA = "0x62CC1E0", Offset = "0x62CB1E0", VA = "0x1862CC1E0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x62CC040", Offset = "0x62CB040", VA = "0x1862CC040")]
		public AnchorParams(Vector2 AJLOBDENAOJ, Vector3 IJPBGNFLEOO, Vector3 NINFNBEEIPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x62CC070", Offset = "0x62CB070", VA = "0x1862CC070")]
		public AnchorParams(KOAEACHKIMD CIIEGDDMMPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x62CBF50", Offset = "0x62CAF50", VA = "0x1862CBF50", Slot = "4")]
		public bool Equals(AnchorParams JHMCLPBFJBC)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KOAEACHKIMD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LPJGJHIOMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KOIJMIGBBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BLFPIGMFOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool EPFEKLLMADG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MGCNFPOCJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool HALDKJNFPHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool PPGHCFCAAHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool OJLGEMGNAOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float HDKCKNKHHMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float GMONKILENPP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float HKFGABBGKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float CBMFCKNIJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float CCFHONPKDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float MBFGBDOBDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float PJEOCKDHCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float MAJIINCMEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float BEGJDBFCGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float DNHEJOGEBON
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	float DOOALABEEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	float HFLGBNPGMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float DHGOFOMCAJF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float APPHMFMNJFH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float MBMDICFCJEA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	float MBHJNHNFKGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Vector3 PHNKCKOJAHK(Vector3 NINFNBEEIPP);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 GDHHFIOANHG(Vector3 KCICOMEPLEF);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 HLDAOLACKMK();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Vector3 BGBALCMEDJA();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AnchorParamsRestrictions : KOAEACHKIMD
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
			[Cpp2IlInjected.Address(RVA = "0x62CBEC0", Offset = "0x62CAEC0", VA = "0x1862CBEC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool GetAllowTranslationY
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x62CBEF0", Offset = "0x62CAEF0", VA = "0x1862CBEF0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool GetAllowTranslationZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x62CBF20", Offset = "0x62CAF20", VA = "0x1862CBF20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool GetAllowRotationX
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x62CBE30", Offset = "0x62CAE30", VA = "0x1862CBE30", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool GetAllowRotationY
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x62CBE60", Offset = "0x62CAE60", VA = "0x1862CBE60", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool GetAllowRotationZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x62CBE90", Offset = "0x62CAE90", VA = "0x1862CBE90", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6E3250", Offset = "0x6E2250", VA = "0x1806E3250", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7FFE90", Offset = "0x7FEE90", VA = "0x1807FFE90", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x11E0800", Offset = "0x11DF800", VA = "0x1811E0800", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1145CE0", Offset = "0x1144CE0", VA = "0x181145CE0", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x107F910", Offset = "0x107E910", VA = "0x18107F910", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x107F8F0", Offset = "0x107E8F0", VA = "0x18107F8F0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x10C2260", Offset = "0x10C1260", VA = "0x1810C2260", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1054670", Offset = "0x1053670", VA = "0x181054670", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x15B93A0", Offset = "0x15B83A0", VA = "0x1815B93A0", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x15ED8C0", Offset = "0x15EC8C0", VA = "0x1815ED8C0", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x11B01C0", Offset = "0x11AF1C0", VA = "0x1811B01C0", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x1012170", Offset = "0x1011170", VA = "0x181012170", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x15ED8F0", Offset = "0x15EC8F0", VA = "0x1815ED8F0", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x12C5E20", Offset = "0x12C4E20", VA = "0x1812C5E20", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x12F73C0", Offset = "0x12F63C0", VA = "0x1812F73C0", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x168C3B0", Offset = "0x168B3B0", VA = "0x18168C3B0", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1CA7700", Offset = "0x1CA6700", VA = "0x181CA7700", Slot = "26")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x15AEE70", Offset = "0x15ADE70", VA = "0x1815AEE70", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x62CBDA0", Offset = "0x62CADA0", VA = "0x1862CBDA0")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x62CBAD0", Offset = "0x62CAAD0", VA = "0x1862CBAD0")]
		public AnchorParams LILMMNPBBJH(AnchorParams DAGNBOCHJPI)
		{
			return default(AnchorParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x62CBAB0", Offset = "0x62CAAB0", VA = "0x1862CBAB0", Slot = "30")]
		public Vector3 HLDAOLACKMK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x62CB9F0", Offset = "0x62CA9F0", VA = "0x1862CB9F0", Slot = "31")]
		public Vector3 BGBALCMEDJA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x62CBD10", Offset = "0x62CAD10", VA = "0x1862CBD10", Slot = "28")]
		public Vector3 PHNKCKOJAHK(Vector3 NINFNBEEIPP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x62CBA10", Offset = "0x62CAA10", VA = "0x1862CBA10", Slot = "29")]
		public Vector3 GDHHFIOANHG(Vector3 KCICOMEPLEF)
		{
			return default(Vector3);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MEOLDPJAGDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private List<Transform> OHLFOJOMBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Matrix4x4[] BLGKJEIHBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<string, Transform> MBHADJGODNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private Dictionary<Transform, Transform> EECHPIKHHMD;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Transform[] HNOKMHBPDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x62D1B20", Offset = "0x62D0B20", VA = "0x1862D1B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Matrix4x4[] FFNPPHFPIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x62D1CC0", Offset = "0x62D0CC0", VA = "0x1862D1CC0")]
	public void PBBIGFIAILP(SkinnedMeshRenderer CMNBAAPLLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x62D1C50", Offset = "0x62D0C50", VA = "0x1862D1C50")]
	public void MKGEDGFJLBB(Transform OHPIACEKGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x62D1B70", Offset = "0x62D0B70", VA = "0x1862D1B70")]
	private Transform MGPFDMGDCGF(Transform MBNMHKCENGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x62D18A0", Offset = "0x62D08A0", VA = "0x1862D18A0")]
	public void DIANKPKMEAJ(MEOLDPJAGDP IJLIBPPGJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x62D1730", Offset = "0x62D0730", VA = "0x1862D1730")]
	private void DDAHCIHHBFE(Transform IGJDJDNFANI, List<Transform> CLNKLEPCPON, Dictionary<string, Transform> NFEMMEENOIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x62D1E70", Offset = "0x62D0E70", VA = "0x1862D1E70")]
	public MEOLDPJAGDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HHPGBNLACHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool DIGCMNLBKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool CDHHAKBBLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool HDFKOIGPBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public bool DLNNLPJLBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public bool KDGFAIELBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public bool ILFIABOHBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool AMALBGLPNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public IList<FKDEMMCJEBC> LKHBBPAEKHI;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HHPGBNLACHM()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xE23C60", Offset = "0xE22C60", VA = "0x180E23C60")]
		protected AvatarConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AvatarCustomizationSettings
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public enum CPJKDPNGPKB
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			Legacy_Hide,
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			On,
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			Off
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const int SERIALIZATION_VERSION = 6;

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
		private CPJKDPNGPKB useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6FF140", Offset = "0x6FE140", VA = "0x1806FF140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x259FF20", Offset = "0x259EF20", VA = "0x18259FF20")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA0AF60", Offset = "0xA09F60", VA = "0x180A0AF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x107F8F0", Offset = "0x107E8F0", VA = "0x18107F8F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x14F30B0", Offset = "0x14F20B0", VA = "0x1814F30B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x777B00", Offset = "0x776B00", VA = "0x180777B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x39CE310", Offset = "0x39CD310", VA = "0x1839CE310")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xDD81E0", Offset = "0xDD71E0", VA = "0x180DD81E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1012170", Offset = "0x1011170", VA = "0x181012170")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x11C4D30", Offset = "0x11C3D30", VA = "0x1811C4D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0D0", Offset = "0x6DE0D0", VA = "0x1806DF0D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7D7330", Offset = "0x7D6330", VA = "0x1807D7330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6F5760", Offset = "0x6F4760", VA = "0x1806F5760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x769020", Offset = "0x768020", VA = "0x180769020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0B0", Offset = "0x6DE0B0", VA = "0x1806DF0B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7D7320", Offset = "0x7D6320", VA = "0x1807D7320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6F5770", Offset = "0x6F4770", VA = "0x1806F5770")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x780AD0", Offset = "0x77FAD0", VA = "0x180780AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public string BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6F5780", Offset = "0x6F4780", VA = "0x1806F5780")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7D7310", Offset = "0x7D6310", VA = "0x1807D7310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6F5700", Offset = "0x6F4700", VA = "0x1806F5700")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x707860", Offset = "0x706860", VA = "0x180707860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6F5710", Offset = "0x6F4710", VA = "0x1806F5710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x716DB0", Offset = "0x715DB0", VA = "0x180716DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x71B6D0", Offset = "0x71A6D0", VA = "0x18071B6D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x716D90", Offset = "0x715D90", VA = "0x180716D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8595A0", Offset = "0x8585A0", VA = "0x1808595A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8598B0", Offset = "0x8588B0", VA = "0x1808598B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public CPJKDPNGPKB UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x62CC780", Offset = "0x62CB780", VA = "0x1862CC780")]
			get
			{
				return default(CPJKDPNGPKB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x85E5C0", Offset = "0x85D5C0", VA = "0x18085E5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xBC8240", Offset = "0xBC7240", VA = "0x180BC8240")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xBC87E0", Offset = "0xBC77E0", VA = "0x180BC87E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x62CC760", Offset = "0x62CB760", VA = "0x1862CC760")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x62CC7B0", Offset = "0x62CB7B0", VA = "0x1862CC7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x27552D0", Offset = "0x27542D0", VA = "0x1827552D0")]
		public string CJKIIDNIDDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x62CC250", Offset = "0x62CB250", VA = "0x1862CC250")]
		public static AvatarCustomizationSettings EOLLHEJPBAN(string HIHPKCFBFMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x62CC5A0", Offset = "0x62CB5A0", VA = "0x1862CC5A0")]
		public AvatarCustomizationSettings()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public SkinnedMeshRenderer[] LODs;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SkeletonLODUpdateRate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public GMJLIEJPOEJ lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public float updateRate;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct AvatarHairPatternOverride
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public string PatternGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Texture2D Texture;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct HGPPDMPPLMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Transform BDHDMDBBNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public GameObject CCJBJEBEKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public SkinnedMeshRenderer[] PDNHOOOLOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public SkinnedMeshRenderer[] MPLOMGFKOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public GameObject HKLPBEODHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public SkinnedMeshRenderer[] INCGLMKGLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public SkinnedMeshRenderer[] FKFDJNOGBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public MEOLDPJAGDP OEIBHADMCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Material DIFMJODLAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Material ODIPEDJKKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Shader PBJFALEGAHJ;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct GELDMJNLBJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Transform GPOKNKLKJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Transform OJFLPPDPFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Transform DPHNADLFLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Transform NFOAGPIBDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Transform JOAKDKEPPPB;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NLNJDBEKDAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public SkinnedMeshRenderer[] NGDGCDPMGAE;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OFKHLABLOHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public LBAKALAPCCD KDDPPINGPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public int IJJJAOMIKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public int HAFBLKOBMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int IJMIMFEEBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int BIGLMMKMFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public int HCCAOALLNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int NHMGLABAING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int AADJFMBKJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float CNMHENKCDDP;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FMGCOKCLLAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public LBAKALAPCCD KDDPPINGPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Vector2 HFDKNPOOKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float BJKHLDBIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Vector2 PLGMAKCJPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float JBFJIBGDJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Vector2 HIKIGDKNBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float GHLBODEDMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float BAGCPLHEIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Vector2 LAOLBLPGNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Vector2 CGMFAODIEGP;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FKDEMMCJEBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public string DBDKMHBCKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public OutfitType KKMAKPNGFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NNLMNCGPPJI CLPLOIOBFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public bool MJOCJKPHGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Color? NIMNHLFIAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Vector3? DHEDNFOJJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float? NGPBOJLKLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Guid? NEELOGOFJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Color? KLOGGNMGMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool DJJMBJGLGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool NFOAIIHAJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public AnchorParamsRestrictions OBHJCFFAOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Vector2? BAELGDDOLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Transform NAPPGLLKAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public FitMeshHemisphere OJOCBJEHICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Vector2 BKBOFACOFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private List<AvatarHairPatternOverride> BAAEECLONFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private Dictionary<string, Texture2D> KFMLINABLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<AvatarHairPatternOverride> NJMCGNNGACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private Dictionary<string, Texture2D> HHPBNJACPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public AssetReference CBIJCIJCCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public AssetReference OIELBIHNJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public AssetReference[] JNLKHMNLALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public bool BIAEJNEHGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE9")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool COBPPCCJCPL;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public List<AvatarHairPatternOverride> HANKLPCKGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F5750", Offset = "0x6F4750", VA = "0x1806F5750")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x62CCB70", Offset = "0x62CBB70", VA = "0x1862CCB70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public List<AvatarHairPatternOverride> IJOIJMPDCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x80F840", Offset = "0x80E840", VA = "0x18080F840")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x62CCDA0", Offset = "0x62CBDA0", VA = "0x1862CCDA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public string OHAFBKEHJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x62CCAC0", Offset = "0x62CBAC0", VA = "0x1862CCAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x62CCFD0", Offset = "0x62CBFD0", VA = "0x1862CCFD0")]
	public FKDEMMCJEBC()
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
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x62CC7D0", Offset = "0x62CB7D0", VA = "0x1862CC7D0")]
		public static void IDLINKJDJNA(AvatarItemMaterial CAJPHFMJOIP, Material HNKAKNCAJGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x62CC830", Offset = "0x62CB830", VA = "0x1862CC830")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NIEFOCPIMKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Mesh LLGFLPNLCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Material[] LDPKNGCLEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly bool ADMFIPPPINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool JJKKFNMJGKF;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	private NIEFOCPIMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x62D2D00", Offset = "0x62D1D00", VA = "0x1862D2D00")]
	public NIEFOCPIMKD(Mesh DJAAGGDMNFL, Material[] FBDANEMMOLJ, bool MHDCBOPEKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x62D2BE0", Offset = "0x62D1BE0", VA = "0x1862D2BE0")]
	public NIEFOCPIMKD(SkinnedMeshRenderer KGEGHCPPMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x62D2870", Offset = "0x62D1870", VA = "0x1862D2870")]
	public static NIEFOCPIMKD KFEKFKJOJJJ(Renderer CMNBAAPLLDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum OPJOBFNALCH
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Highfive,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Fistbump,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Handshake,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Point,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	ThumbsUp,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	ThumbsDown,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	OpenHand
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum MKOAAPBHDJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum NNLMNCGPPJI
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Nose
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Flags]
public enum HECGIAGAOOM
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Head = 1,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Torso = 2,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	LeftHand = 4,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	RightHand = 8,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Mouth = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Legs = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	RightFoot = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	LeftFoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	FullBody = 0x100,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Nose = 0x200
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum GLLHGLJIPDJ
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum PDNDDJAHPKA
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum BDKFDIBEFGB
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum NEAFOOCMBCG
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum JHOFGJONAMO
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class NMBICGFLCAA
{
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static readonly int LALDPDIMBCC;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x62D2E10", Offset = "0x62D1E10", VA = "0x1862D2E10")]
	public static MBJBOIKCDKP BGOHBNLFOAF()
	{
		return default(MBJBOIKCDKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x62D30E0", Offset = "0x62D20E0", VA = "0x1862D30E0")]
	public static DIIKJOMKJNG NDEKLFOKGAC(Transform OFGIGKJMOGJ, Transform KIGMOHMNJLC, AvatarConfiguration BFIDAJKPLJP, Animator PKGCHLLBJOD, VRIK EIIAOGOICKD, SkeletonLODUpdateRate[] KDDHKANMBPA, GameObject[] MAHMBNGMDOF, Transform AGDCGCJGKBE, GameObject HAJOIOBJOBD, BodySkinnedMeshLODs FIADCCBMMLB, BodySkinnedMeshLODs LHPBMFDBLFI, GameObject AJPJCBECAIN, BodySkinnedMeshLODs LDFGAPIEJJN, BodySkinnedMeshLODs FEBNHDOPOHI, MEOLDPJAGDP DFKPGOHAJKI, Material BLPPILFGCKC, Material JIMLMNIKDOP, Shader KKDNIADMOFG, Transform JMHJJMIEEIE, Transform NCEKELMIBDG, Transform OIBKMKALNIB, Transform JHLNEODIAMC, Transform OFBNPKNCOBN)
	{
		return default(DIIKJOMKJNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x62D3300", Offset = "0x62D2300", VA = "0x1862D3300")]
	public static IBEGEDADFCM PNCGODCAMPL(string NKLDEIJAOID, bool JPLDDPHBBGK, bool CHJDBKMIOJP, bool JGBIBPALMDN, RigidbodyEx CGAMHDBLHMF, RigidbodyEx BCFJKANEFGG, RigidbodyEx DHKLHCMHKIL, RigidbodyEx PFFAKIMOPED, Transform MMMJBAKNMLM, Transform BDOHODPHKGI, Transform APDJDBCKHIC, float CJKCDNMPEJF, float AKIFKOACCPA, PlayerAvatarFullBodyColliders KBMIILDIFBE)
	{
		return default(IBEGEDADFCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x62D2F60", Offset = "0x62D1F60", VA = "0x1862D2F60")]
	public static HGPPDMPPLMP KPKDFPKCENN(Transform KIGMOHMNJLC, GameObject HAJOIOBJOBD, SkinnedMeshRenderer[] GDKDHFPJICC, SkinnedMeshRenderer[] GJECDMCNOAI, GameObject AJPJCBECAIN, SkinnedMeshRenderer[] OLOICGDOEFM, SkinnedMeshRenderer[] KKEGMNCIADN, MEOLDPJAGDP DFKPGOHAJKI, Material BLPPILFGCKC, Material JIMLMNIKDOP, Shader KKDNIADMOFG)
	{
		return default(HGPPDMPPLMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x62D2E40", Offset = "0x62D1E40", VA = "0x1862D2E40")]
	public static GELDMJNLBJM HMKGENJCDHC(Transform JMHJJMIEEIE, Transform OIBKMKALNIB, Transform NCEKELMIBDG, Transform JHLNEODIAMC, Transform OFBNPKNCOBN)
	{
		return default(GELDMJNLBJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xE0B800", Offset = "0xE0A800", VA = "0x180E0B800")]
	public static NLNJDBEKDAL DFFNNHPDBCC(SkinnedMeshRenderer[] LOOMFAGIJDN)
	{
		return default(NLNJDBEKDAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x62D3060", Offset = "0x62D2060", VA = "0x1862D3060")]
	public static OFKHLABLOHB LJKKGFDBKGA(LBAKALAPCCD NLGAOHGHEFI, int KBCGMJPOFMP, int LAJGOOGOAGG, int ENGNMLPHAOO, int JAOKOLONGMH, int DFPAOGNHACD, int NILPOGFFKFF, int HGJEIOPMABN, float PBCBDFNEIFL)
	{
		return default(OFKHLABLOHB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x62D2ED0", Offset = "0x62D1ED0", VA = "0x1862D2ED0")]
	public static FMGCOKCLLAF KCMFDODFKNE(LBAKALAPCCD NLGAOHGHEFI, Vector2 PMNGLOFCIGM, float CEJPCLHFCMG, Vector2 NHJJNLDKIIG, float PJLMKBBOCHL, Vector2 LIINBCONLIH, float MDIHHBJFGOG)
	{
		return default(FMGCOKCLLAF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LNCAJLGFGJD
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	Transform AMINHCIEOMN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	Vector3 CCKIMHBKAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class EDENHILDMKK : LNCAJLGFGJD
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public Transform AMINHCIEOMN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6FF130", Offset = "0x6FE130", VA = "0x1806FF130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Vector3 CCKIMHBKAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xFF5FE0", Offset = "0xFF4FE0", VA = "0x180FF5FE0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xFF6010", Offset = "0xFF5010", VA = "0x180FF6010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public float? NDELEJOLNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xFF6000", Offset = "0xFF5000", VA = "0x180FF6000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xFF6020", Offset = "0xFF5020", VA = "0x180FF6020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public EDENHILDMKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class IFOLPMIELHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	protected readonly EDENHILDMKK JCOIKHKGMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	protected readonly EDENHILDMKK IFAFDMENOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	protected readonly EDENHILDMKK FIBAABEIHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	protected readonly EDENHILDMKK PEKJNJAMNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	protected readonly EDENHILDMKK NFKFOGPFBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	protected readonly EDENHILDMKK LFAIFJPEOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	protected readonly EDENHILDMKK HNOICMCEAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	protected readonly EDENHILDMKK HGEEBJHFOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	protected readonly EDENHILDMKK KLLAIDOPOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	protected readonly EDENHILDMKK OLNMCONLCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	protected readonly EDENHILDMKK LKGDNMNPDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected readonly EDENHILDMKK GEEHDHLCNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	protected readonly EDENHILDMKK GNJMNFNKGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	protected EDENHILDMKK CHHFHGELKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	protected readonly EDENHILDMKK PELAIJIHFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	protected readonly EDENHILDMKK CKMHAHNEOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	protected readonly EDENHILDMKK ONGCOHDEKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	protected EDENHILDMKK FKADPGMCJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	protected readonly EDENHILDMKK HDPNOGPBNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	protected readonly EDENHILDMKK FMJFKPLPLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	protected readonly EDENHILDMKK IPLGGIBOPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	protected ReadOnlyCollection<EDENHILDMKK> GBPPLBABLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public Transform AGDCGCJGKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private (EDENHILDMKK Start, EDENHILDMKK End)[] AGLCHAAMDOM;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public LNCAJLGFGJD HONMEOIDEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public LNCAJLGFGJD AIHCLHLLGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public LNCAJLGFGJD DNNDPOCOABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public LNCAJLGFGJD BNPCIAMFKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public LNCAJLGFGJD KAHJPBDJDIA
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public LNCAJLGFGJD OLIBJIEKMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6E6570", Offset = "0x6E5570", VA = "0x1806E6570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public LNCAJLGFGJD PPHPFBHCHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6E6580", Offset = "0x6E5580", VA = "0x1806E6580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public EDENHILDMKK DODPGAJGKFC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6E6580", Offset = "0x6E5580", VA = "0x1806E6580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public LNCAJLGFGJD KENAHAHKFOB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0D0", Offset = "0x6DE0D0", VA = "0x1806DF0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EDENHILDMKK LNMNMIMCGCP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0D0", Offset = "0x6DE0D0", VA = "0x1806DF0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public LNCAJLGFGJD JBPLOIMHOIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F5760", Offset = "0x6F4760", VA = "0x1806F5760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public LNCAJLGFGJD DKMNNPOEKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0B0", Offset = "0x6DE0B0", VA = "0x1806DF0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public LNCAJLGFGJD OABDLCAIPIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F5770", Offset = "0x6F4770", VA = "0x1806F5770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public EDENHILDMKK BBEPLEIPBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F5770", Offset = "0x6F4770", VA = "0x1806F5770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public EDENHILDMKK IGIMHOPHLHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6F5780", Offset = "0x6F4780", VA = "0x1806F5780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public LNCAJLGFGJD NLGMNNBNHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F5780", Offset = "0x6F4780", VA = "0x1806F5780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public LNCAJLGFGJD HKGOICAJGIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F5700", Offset = "0x6F4700", VA = "0x1806F5700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public LNCAJLGFGJD AOCCDJHFLHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F5710", Offset = "0x6F4710", VA = "0x1806F5710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public LNCAJLGFGJD LGBMKAGDGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x71B6D0", Offset = "0x71A6D0", VA = "0x18071B6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public LNCAJLGFGJD JLOEMCKFIIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E5D80", Offset = "0x6E4D80", VA = "0x1806E5D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public LNCAJLGFGJD IBCEIBCGBOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6E5E20", Offset = "0x6E4E20", VA = "0x1806E5E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public LNCAJLGFGJD AAFEJHEEGKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x71B6A0", Offset = "0x71A6A0", VA = "0x18071B6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public LNCAJLGFGJD LFNJDIKDJPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F5720", Offset = "0x6F4720", VA = "0x1806F5720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public LNCAJLGFGJD CPJDAHJGDGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F5730", Offset = "0x6F4730", VA = "0x1806F5730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public LNCAJLGFGJD COMFBBNEBEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6F5750", Offset = "0x6F4750", VA = "0x1806F5750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public IReadOnlyList<LNCAJLGFGJD> ALNLDCJJOEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F5740", Offset = "0x6F4740", VA = "0x1806F5740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x62CEEE0", Offset = "0x62CDEE0", VA = "0x1862CEEE0")]
	public void FJDPAHIAHLO(VRIK CGMNGDAGIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x20D89D0", Offset = "0x20D79D0", VA = "0x1820D89D0")]
	private void FHDHFMOEHKK(Transform EHNCKNECPAL, EDENHILDMKK NMAMPMADCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x62CFC00", Offset = "0x62CEC00", VA = "0x1862CFC00")]
	public void LKFGKAJBJCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x20DA400", Offset = "0x20D9400", VA = "0x1820DA400")]
	public float JLACJPNOBNL(in (EDENHILDMKK Start, EDENHILDMKK End) GNDOGLGKNOI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x62CFA20", Offset = "0x62CEA20", VA = "0x1862CFA20")]
	public void LHPDHMNBHMI(in MBJBOIKCDKP KFCHBPFAEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x62CF8D0", Offset = "0x62CE8D0", VA = "0x1862CF8D0")]
	private Vector3 KIFMFGGENHN(in (EDENHILDMKK Start, EDENHILDMKK End) GNDOGLGKNOI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x62D00B0", Offset = "0x62CF0B0", VA = "0x1862D00B0")]
	public IFOLPMIELHD()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x62CC8F0", Offset = "0x62CB8F0", VA = "0x1862CC8F0")]
		public string CCKLEFNAGNP(string BICMNJGHCBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x62CC940", Offset = "0x62CB940", VA = "0x1862CC940")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct IBEGEDADFCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public string JDPHCJAAPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public bool BOGCINNBAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public bool LHDHINMLDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public float GEBIAGNALCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public float KPAGANNBAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool POGDKLKMEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public RigidbodyEx GJGAAGFNKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public RigidbodyEx DJEBFNPLNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public RigidbodyEx FOHJNHMIPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public RigidbodyEx LNCKBDJKNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public Transform BBIMBIACLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public Transform AIDJKLMEHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public Transform CIHLOCHEKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public PlayerAvatarFullBodyColliders FLNINGAPMMO;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct DIIKJOMKJNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public Transform FBFEEHFHDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public Transform AEKLDPNCPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public AvatarConfiguration MFPEENJFGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Animator FNNALDEDLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public VRIK KLJLHMPHEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public SkeletonLODUpdateRate[] NJAPGBIFNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public GameObject[] NKDANFEIPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Transform ACIHCKFLIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public GameObject CCJBJEBEKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public BodySkinnedMeshLODs EMGHCAOOGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public BodySkinnedMeshLODs DLIIBBIFHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public GameObject HKLPBEODHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public BodySkinnedMeshLODs EECEIJLGKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public BodySkinnedMeshLODs LIJIFCDJPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public MEOLDPJAGDP OEIBHADMCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Material DIFMJODLAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public Material ODIPEDJKKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public Shader PBJFALEGAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public Transform GPOKNKLKJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public Transform DPHNADLFLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public Transform OJFLPPDPFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public Transform NFOAGPIBDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public Transform JOAKDKEPPPB;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct MBJBOIKCDKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public float APJLDCLNPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool CEKBIFBPLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public GMJLIEJPOEJ LKNKANFLGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public Vector3 NNEEHDBABKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public Vector3 NFGINPGDPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public Vector3? LJCIDJADECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public Vector3? LNGNHJFFPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public bool NGCBDJDDBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public bool BNDCLGABHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public bool MGECLMHCLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public bool EDJOEGBHDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public bool APBBIIHIFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public Vector3? DHOJKBNEOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public bool DOJKFBKPKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public Vector3? CPMEFJCNPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public bool CFDIKANOBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public Vector3? OCPLHMPOGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public Vector3? KLCKLFBPLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public bool CBNCMFHHADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public bool PBPNKEIMCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public bool ICMAECLLDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public bool MHEJIKGAOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public bool IKEJOFFOFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public bool CFHEDMFLHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public bool LDCFKNEEPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool JOMCAFPFMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool KIFOOIMDDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public bool CBKCMBILBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public Vector3? GCFJMLEEDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public OPJOBFNALCH NIENJKLNFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public OPJOBFNALCH JCGKDGNEHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public float LIDPEOJLIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public float MHBNIGLECMN;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface LEEBCIMFDFP
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LCJCJJPEPFC();

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::NJBAAHLOPDA<Texture2D> CAEDLJJEDHL(MMPDNPLNFLF NLLFAFFBLCJ, [Optional] DHGMMBBNOAP DGCNIAGLPMA);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NFHEKJNAKHI : LEEBCIMFDFP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private KNALHJDADMH LOLNOAEHFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private IRecRoomQualityConfigProvider CFJNJBFPLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private bool FNOLDNMCLME;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private const uint LLGANPAIALF = 16u;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x62D2720", Offset = "0x62D1720", VA = "0x1862D2720")]
	[JDLBAGCFHIO(MEDANDNEHIF.None)]
	private static void GDFJHBNIOGM(DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	[Preserve]
	public NFHEKJNAKHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x62D2050", Offset = "0x62D1050", VA = "0x1862D2050")]
	private void BBCNCAGODCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x62D2810", Offset = "0x62D1810", VA = "0x1862D2810", Slot = "4")]
	public void LCJCJJPEPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x62D2100", Offset = "0x62D1100", VA = "0x1862D2100", Slot = "5")]
	public global::NJBAAHLOPDA<Texture2D> CAEDLJJEDHL(MMPDNPLNFLF NLLFAFFBLCJ, [Optional] DHGMMBBNOAP DGCNIAGLPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x62D2510", Offset = "0x62D1510", VA = "0x1862D2510")]
	private uint DPPKHILNEBI(MMPDNPLNFLF NLLFAFFBLCJ, DHGMMBBNOAP DGCNIAGLPMA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum CFMBLBMHKNG
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class DHGMMBBNOAP
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static readonly DHGMMBBNOAP LMPNKNOCBFL;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int AHIBFBMPKDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6DF040", Offset = "0x6DE040", VA = "0x1806DF040")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6FFF30", Offset = "0x6FEF30", VA = "0x1806FFF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public CFMBLBMHKNG OBCICDOMPBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F5790", Offset = "0x6F4790", VA = "0x1806F5790")]
		[CompilerGenerated]
		get
		{
			return default(CFMBLBMHKNG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x929260", Offset = "0x928260", VA = "0x180929260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public DHGMMBBNOAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x62CCA80", Offset = "0x62CBA80", VA = "0x1862CCA80")]
	public DHGMMBBNOAP(CFMBLBMHKNG COAEGBJAHMB, int NOMJNEMDDAD)
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
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x62CE820", Offset = "0x62CD820", VA = "0x1862CE820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x62CE760", Offset = "0x62CD760", VA = "0x1862CE760")]
		public FitMeshHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x62CDF60", Offset = "0x62CCF60", VA = "0x1862CDF60")]
		public void CNAKDNPCICA(FitMeshHemisphere NEDDLLDEBEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x62CE290", Offset = "0x62CD290", VA = "0x1862CE290")]
		public Vector3 PFKDCJBOBEG(Vector2 BEAPKMGPPON, bool IMBPEOIKIDG = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x62CDFB0", Offset = "0x62CCFB0", VA = "0x1862CDFB0")]
		public Vector3 EOJDBBEDJHM(Vector2 BEAPKMGPPON)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x62CE010", Offset = "0x62CD010", VA = "0x1862CE010")]
		public Quaternion NMMFPOHFOLF(Vector2 BEAPKMGPPON)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x62CE140", Offset = "0x62CD140", VA = "0x1862CE140")]
		public Quaternion NMMFPOHFOLF(Vector2 BEAPKMGPPON, Vector3 FHDDLBPPKOP)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x62CE250", Offset = "0x62CD250", VA = "0x1862CE250")]
		private Vector2 PDHNMMNLLIO(Vector2 EAPLDKELEEA)
		{
			return default(Vector2);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct MMEJMLEGDDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public readonly GameObject KPMBGPHMJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public readonly AvatarItemMaterial IMFNNAOHILO;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x78FA30", Offset = "0x78EA30", VA = "0x18078FA30")]
	public MMEJMLEGDDM(GameObject KPMBGPHMJMA, AvatarItemMaterial IMFNNAOHILO)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class HEEIICMAPGB
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x62CE890", Offset = "0x62CD890", VA = "0x1862CE890")]
	public static bool PPEINKIDBAP(this OutfitType LEHAMCBCPDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x62CE850", Offset = "0x62CD850", VA = "0x1862CE850")]
	public static bool GJOOGHJHHCI(this OutfitType LEHAMCBCPDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x62CE870", Offset = "0x62CD870", VA = "0x1862CE870")]
	public static bool LKOHENEDNNL(this OutfitType LEHAMCBCPDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x62CE880", Offset = "0x62CD880", VA = "0x1862CE880")]
	public static bool LOOADOAOALC(this OutfitType LEHAMCBCPDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x62CE840", Offset = "0x62CD840", VA = "0x1862CE840")]
	public static bool FJAILIBEIPP(this OutfitType LEHAMCBCPDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x62CE830", Offset = "0x62CD830", VA = "0x1862CE830")]
	public static bool DMFOBHPFIAF(this OutfitType LEHAMCBCPDD)
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
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private MEOLDPJAGDP PAEODOPIKBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private Collider[] FFBNCNEDHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		private Collider[] OPHGEDADPPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x62D34D0", Offset = "0x62D24D0", VA = "0x1862D34D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x62D3450", Offset = "0x62D2450", VA = "0x1862D3450")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x62D3690", Offset = "0x62D2690", VA = "0x1862D3690")]
		public void UpdateBones(MEOLDPJAGDP DFKPGOHAJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x62D3540", Offset = "0x62D2540", VA = "0x1862D3540")]
		public void SetCollidersEnabled(bool IGPDCEGDODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x62D36C0", Offset = "0x62D26C0", VA = "0x1862D36C0")]
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
		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x6FA290", Offset = "0x6F9290", VA = "0x1806FA290", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x62CC990", Offset = "0x62CB990", VA = "0x1862CC990")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x6E6170", Offset = "0x6E5170", VA = "0x1806E6170", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x62CC990", Offset = "0x62CB990", VA = "0x1862CC990")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x62CD300", Offset = "0x62CC300", VA = "0x1862CD300")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x811F50", Offset = "0x810F50", VA = "0x180811F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x17C8E20", Offset = "0x17C7E20", VA = "0x1817C8E20")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xFE4ED0", Offset = "0xFE3ED0", VA = "0x180FE4ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x62CD1D0", Offset = "0x62CC1D0", VA = "0x1862CD1D0", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x62CD280", Offset = "0x62CC280", VA = "0x1862CD280")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public abstract class FaceFeatureBase : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private const bool HIGH_QUALTIY_COMPRESS = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		private string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private Sprite[] Sprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string Guid
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public IEnumerable<Sprite> SrcSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x62CD1B0", Offset = "0x62CC1B0", VA = "0x1862CD1B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x4652C50", Offset = "0x4651C50", VA = "0x184652C50")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xFE4510", Offset = "0xFE3510", VA = "0x180FE4510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x62CCFE0", Offset = "0x62CBFE0", VA = "0x1862CCFE0")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x62CD050", Offset = "0x62CC050", VA = "0x1862CD050", Slot = "5")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x62CD0D0", Offset = "0x62CC0D0", VA = "0x1862CD0D0")]
		protected FaceFeatureBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class LBAKALAPCCD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private class MMLMLJPOMDD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public readonly Texture2DArray NDACBKPFOCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public readonly Dictionary<string, int> EBFOFLMCMBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private readonly JLNNFJHBOML GFJEAEKJMBO;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool BLNDNEFKBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1872840", Offset = "0x1871840", VA = "0x181872840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x62D1F70", Offset = "0x62D0F70", VA = "0x1862D1F70")]
		public MMLMLJPOMDD(Texture2DArray EBLGEKJICDL, Dictionary<string, int> GIAOHMIODOL, LBAKALAPCCD GDDJECPEDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xFE3B70", Offset = "0xFE2B70", VA = "0x180FE3B70")]
		public void IFJGDKHAINM(LBAKALAPCCD JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xFE3830", Offset = "0xFE2830", VA = "0x180FE3830")]
		public void KFFCNCACBBK(LBAKALAPCCD JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x12BD860", Offset = "0x12BC860", VA = "0x1812BD860", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct KJKFKMKGPGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private readonly string AKDJBNPDCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private readonly string FMOHAPICJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private readonly string JIGGMHAJIND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private readonly string MILOHDAPMPO;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5BB3000", Offset = "0x5BB2000", VA = "0x185BB3000")]
		public KJKFKMKGPGA(string DKIFPAACPFL, string MBBGPDAANEO, string OECFAIKHPNC, string AIFHMKLCMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x62D0600", Offset = "0x62CF600", VA = "0x1862D0600")]
		public bool OGHMKNDIAJH(KJKFKMKGPGA JHMCLPBFJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x62D0450", Offset = "0x62CF450", VA = "0x1862D0450", Slot = "0")]
		public override bool Equals(object AELIHOPICED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x62D0530", Offset = "0x62CF530", VA = "0x1862D0530", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x62D0600", Offset = "0x62CF600", VA = "0x1862D0600")]
		public static bool IIPILNNMHKL(KJKFKMKGPGA NJMNOIGKPAI, KJKFKMKGPGA LIILEENPBBG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x62D0690", Offset = "0x62CF690", VA = "0x1862D0690")]
		public static bool NCOOAABHIPD(KJKFKMKGPGA NJMNOIGKPAI, KJKFKMKGPGA LIILEENPBBG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<string, int> GIAOHMIODOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly KJKFKMKGPGA CPKHBEGGOIN;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Texture2DArray HJCBMJCPJLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6FF140", Offset = "0x6FE140", VA = "0x1806FF140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public SymmetricalFaceFeature MIHEEOAEHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6E0130", Offset = "0x6DF130", VA = "0x1806E0130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public SymmetricalFaceFeature IMNKPCBOBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x721210", Offset = "0x720210", VA = "0x180721210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public SymmetricalFaceFeature CABHNAFBOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x777B00", Offset = "0x776B00", VA = "0x180777B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public FaceFeature KDJGFAONMAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6E6570", Offset = "0x6E5570", VA = "0x1806E6570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6E6590", Offset = "0x6E5590", VA = "0x1806E6590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x62D0730", Offset = "0x62CF730", VA = "0x1862D0730")]
	private static void FCMMNBIIEFI(Sprite HIIHDJCCMJG, Sprite LCCPBBAOCCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x62D0A40", Offset = "0x62CFA40", VA = "0x1862D0A40")]
	private static void OCPHHCNEBFL(Sprite PMOFICFJAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x62D0AB0", Offset = "0x62CFAB0", VA = "0x1862D0AB0")]
	public LBAKALAPCCD(SymmetricalFaceFeature MMKMLAALFOF, FaceFeature EANHAEEDJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x62D0AE0", Offset = "0x62CFAE0", VA = "0x1862D0AE0")]
	public LBAKALAPCCD(SymmetricalFaceFeature NCNNMFIGPFM, SymmetricalFaceFeature MMKMLAALFOF, SymmetricalFaceFeature BPFPOHJOPME, FaceFeature EANHAEEDJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x62D0830", Offset = "0x62CF830", VA = "0x1862D0830")]
	public bool NMBFOFHJHME(Sprite PMOFICFJAIE, out int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x62D0720", Offset = "0x62CF720", VA = "0x1862D0720", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Eye = 0,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Mouth = 1,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		Nose = 2,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Brows = 3,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		EyeGleams = 4,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Other = 10
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public SymmetricalFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public SymmetricalFaceFeature[] EyeGleams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private Dictionary<string, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private Dictionary<string, SymmetricalFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private Dictionary<string, SymmetricalFaceFeature> eyeGleamFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Dictionary<string, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private Dictionary<string, int> featureToIndexMap;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x62CDF30", Offset = "0x62CCF30", VA = "0x1862CDF30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x62CDA30", Offset = "0x62CCA30", VA = "0x1862CDA30")]
		public LBAKALAPCCD KOFGCLOCOHF(int MMKMLAALFOF, int EANHAEEDJDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x62CD7B0", Offset = "0x62CC7B0", VA = "0x1862CD7B0")]
		public LBAKALAPCCD KOFGCLOCOHF(int JOHJMIAEPKL, int MMKMLAALFOF, int NNLFLDKBEFA, int EANHAEEDJDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x62CD320", Offset = "0x62CC320", VA = "0x1862CD320")]
		public FaceFeatureBase DFLNDBLAAHA(FaceFeatureType IEDCELGGALI, string DBODHDCBMLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x62CD720", Offset = "0x62CC720", VA = "0x1862CD720")]
		public int EEHHNEIFEAO(string DBODHDCBMLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x62CDCD0", Offset = "0x62CCCD0", VA = "0x1862CDCD0")]
		private void PDGFFBHBFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2359E00", Offset = "0x2358E00", VA = "0x182359E00")]
		private void LKAKPGCDGFE<T>(Dictionary<string, T> GCMGJFGGLEN, T[] IPAKFKGAHLN) where T : FaceFeatureBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x62CD4B0", Offset = "0x62CC4B0", VA = "0x1862CD4B0")]
		public string DHNKHCPIEAI(FaceFeatureType IEDCELGGALI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x62CD5A0", Offset = "0x62CC5A0", VA = "0x1862CD5A0")]
		public string DIPKHBGKEJI(FaceFeatureType IEDCELGGALI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x62CDEB0", Offset = "0x62CCEB0", VA = "0x1862CDEB0")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x705AA0", Offset = "0x704AA0", VA = "0x180705AA0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x62D2040", Offset = "0x62D1040", VA = "0x1862D2040")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class NoseFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x6FA2A0", Offset = "0x6F92A0", VA = "0x1806FA2A0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x62D2040", Offset = "0x62D1040", VA = "0x1862D2040")]
		public NoseFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x62D3920", Offset = "0x62D2920", VA = "0x1862D3920")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x4440330", Offset = "0x443F330", VA = "0x184440330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x15ED8D0", Offset = "0x15EC8D0", VA = "0x1815ED8D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x4440320", Offset = "0x443F320", VA = "0x184440320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x15ED8A0", Offset = "0x15EC8A0", VA = "0x1815ED8A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x3615060", Offset = "0x3614060", VA = "0x183615060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x15ED810", Offset = "0x15EC810", VA = "0x1815ED810")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x62D3940", Offset = "0x62D2940", VA = "0x1862D3940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x62D3810", Offset = "0x62D2810", VA = "0x1862D3810", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x62CC990", Offset = "0x62CB990", VA = "0x1862CC990")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x62CE8B0", Offset = "0x62CD8B0", VA = "0x1862CE8B0")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x62CE9C0", Offset = "0x62CD9C0", VA = "0x1862CE9C0")]
	public static string PKAAKGDAGEE(byte[] FHNEBAPANCE, bool MGDFGAKHOKG)
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

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
