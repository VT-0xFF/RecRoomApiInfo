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
	[Cpp2IlInjected.Address(RVA = "0x637F200", Offset = "0x637E600", VA = "0x18637F200")]
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
			[Cpp2IlInjected.Address(RVA = "0x637EB10", Offset = "0x637DF10", VA = "0x18637EB10")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x637E970", Offset = "0x637DD70", VA = "0x18637E970")]
		public AnchorParams(Vector2 AJLOBDENAOJ, Vector3 IJPBGNFLEOO, Vector3 NINFNBEEIPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x637E9A0", Offset = "0x637DDA0", VA = "0x18637E9A0")]
		public AnchorParams(KOAEACHKIMD CIIEGDDMMPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x637E880", Offset = "0x637DC80", VA = "0x18637E880", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x637E7F0", Offset = "0x637DBF0", VA = "0x18637E7F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool GetAllowTranslationY
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x637E820", Offset = "0x637DC20", VA = "0x18637E820", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool GetAllowTranslationZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x637E850", Offset = "0x637DC50", VA = "0x18637E850", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool GetAllowRotationX
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x637E760", Offset = "0x637DB60", VA = "0x18637E760", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool GetAllowRotationY
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x637E790", Offset = "0x637DB90", VA = "0x18637E790", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool GetAllowRotationZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x637E7C0", Offset = "0x637DBC0", VA = "0x18637E7C0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6E4250", Offset = "0x6E3650", VA = "0x1806E4250", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x800E90", Offset = "0x800290", VA = "0x180800E90", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x12C8520", Offset = "0x12C7920", VA = "0x1812C8520", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x107A660", Offset = "0x1079A60", VA = "0x18107A660", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x10231F0", Offset = "0x10225F0", VA = "0x1810231F0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x10231D0", Offset = "0x10225D0", VA = "0x1810231D0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xF8B800", Offset = "0xF8AC00", VA = "0x180F8B800", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1010BC0", Offset = "0x100FFC0", VA = "0x181010BC0", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x159C880", Offset = "0x159BC80", VA = "0x18159C880", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x15AB6B0", Offset = "0x15AAAB0", VA = "0x1815AB6B0", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x107D970", Offset = "0x107CD70", VA = "0x18107D970", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x112D660", Offset = "0x112CA60", VA = "0x18112D660", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x15AB6E0", Offset = "0x15AAAE0", VA = "0x1815AB6E0", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1186EE0", Offset = "0x11862E0", VA = "0x181186EE0", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1354710", Offset = "0x1353B10", VA = "0x181354710", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x190B770", Offset = "0x190AB70", VA = "0x18190B770", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1D25F60", Offset = "0x1D25360", VA = "0x181D25F60", Slot = "26")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1592350", Offset = "0x1591750", VA = "0x181592350", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x637E6D0", Offset = "0x637DAD0", VA = "0x18637E6D0")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x637E400", Offset = "0x637D800", VA = "0x18637E400")]
		public AnchorParams LILMMNPBBJH(AnchorParams DAGNBOCHJPI)
		{
			return default(AnchorParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x637E3E0", Offset = "0x637D7E0", VA = "0x18637E3E0", Slot = "30")]
		public Vector3 HLDAOLACKMK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x637E320", Offset = "0x637D720", VA = "0x18637E320", Slot = "31")]
		public Vector3 BGBALCMEDJA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x637E640", Offset = "0x637DA40", VA = "0x18637E640", Slot = "28")]
		public Vector3 PHNKCKOJAHK(Vector3 NINFNBEEIPP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x637E340", Offset = "0x637D740", VA = "0x18637E340", Slot = "29")]
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
		[Cpp2IlInjected.Address(RVA = "0x63844F0", Offset = "0x63838F0", VA = "0x1863844F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Matrix4x4[] FFNPPHFPIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6384690", Offset = "0x6383A90", VA = "0x186384690")]
	public void PBBIGFIAILP(SkinnedMeshRenderer CMNBAAPLLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6384620", Offset = "0x6383A20", VA = "0x186384620")]
	public void MKGEDGFJLBB(Transform OHPIACEKGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6384540", Offset = "0x6383940", VA = "0x186384540")]
	private Transform MGPFDMGDCGF(Transform MBNMHKCENGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6384270", Offset = "0x6383670", VA = "0x186384270")]
	public void DIANKPKMEAJ(MEOLDPJAGDP IJLIBPPGJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6384100", Offset = "0x6383500", VA = "0x186384100")]
	private void DDAHCIHHBFE(Transform IGJDJDNFANI, List<Transform> CLNKLEPCPON, Dictionary<string, Transform> NFEMMEENOIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6384840", Offset = "0x6383C40", VA = "0x186384840")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0xE24C60", Offset = "0xE24060", VA = "0x180E24C60")]
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
		private CPJKDPNGPKB useHelmetHair;

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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x700140", Offset = "0x6FF540", VA = "0x180700140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x2853530", Offset = "0x2852930", VA = "0x182853530")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA0BF60", Offset = "0xA0B360", VA = "0x180A0BF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x10231D0", Offset = "0x10225D0", VA = "0x1810231D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x117D7B0", Offset = "0x117CBB0", VA = "0x18117D7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x778B00", Offset = "0x777F00", VA = "0x180778B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3A61BE0", Offset = "0x3A60FE0", VA = "0x183A61BE0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xDD91E0", Offset = "0xDD85E0", VA = "0x180DD91E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x112D660", Offset = "0x112CA60", VA = "0x18112D660")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x112D650", Offset = "0x112CA50", VA = "0x18112D650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6E00D0", Offset = "0x6DF4D0", VA = "0x1806E00D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7D8330", Offset = "0x7D7730", VA = "0x1807D8330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6F6760", Offset = "0x6F5B60", VA = "0x1806F6760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x76A020", Offset = "0x769420", VA = "0x18076A020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6E00B0", Offset = "0x6DF4B0", VA = "0x1806E00B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7D8320", Offset = "0x7D7720", VA = "0x1807D8320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6F6770", Offset = "0x6F5B70", VA = "0x1806F6770")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x781AD0", Offset = "0x780ED0", VA = "0x180781AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public string BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6F6780", Offset = "0x6F5B80", VA = "0x1806F6780")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7D8310", Offset = "0x7D7710", VA = "0x1807D8310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6F6700", Offset = "0x6F5B00", VA = "0x1806F6700")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x708860", Offset = "0x707C60", VA = "0x180708860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6F6710", Offset = "0x6F5B10", VA = "0x1806F6710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x717DB0", Offset = "0x7171B0", VA = "0x180717DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x71C6D0", Offset = "0x71BAD0", VA = "0x18071C6D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x717D90", Offset = "0x717190", VA = "0x180717D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x85A5A0", Offset = "0x8599A0", VA = "0x18085A5A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x85A8B0", Offset = "0x859CB0", VA = "0x18085A8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public CPJKDPNGPKB UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x637F0B0", Offset = "0x637E4B0", VA = "0x18637F0B0")]
			get
			{
				return default(CPJKDPNGPKB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x85F5C0", Offset = "0x85E9C0", VA = "0x18085F5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xBC9240", Offset = "0xBC8640", VA = "0x180BC9240")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xBC97E0", Offset = "0xBC8BE0", VA = "0x180BC97E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x637F090", Offset = "0x637E490", VA = "0x18637F090")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x637F180", Offset = "0x637E580", VA = "0x18637F180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string BaseAvatarType
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6F6740", Offset = "0x6F5B40", VA = "0x1806F6740")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x717DC0", Offset = "0x7171C0", VA = "0x180717DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool UsesFullBodyAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x637F0E0", Offset = "0x637E4E0", VA = "0x18637F0E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2605620", Offset = "0x2604A20", VA = "0x182605620")]
		public string CJKIIDNIDDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x637EB80", Offset = "0x637DF80", VA = "0x18637EB80")]
		public static AvatarCustomizationSettings EOLLHEJPBAN(string HIHPKCFBFMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x637EED0", Offset = "0x637E2D0", VA = "0x18637EED0")]
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
		public GMJLIEJPOEJ lod;

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
public struct HGPPDMPPLMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Transform BDHDMDBBNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public GameObject CCJBJEBEKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public SkinnedMeshRenderer[] PDNHOOOLOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public SkinnedMeshRenderer[] MPLOMGFKOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public GameObject HKLPBEODHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public SkinnedMeshRenderer[] INCGLMKGLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public SkinnedMeshRenderer[] FKFDJNOGBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public MEOLDPJAGDP OEIBHADMCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Material DIFMJODLAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Material ODIPEDJKKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Shader PBJFALEGAHJ;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct GELDMJNLBJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Transform GPOKNKLKJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Transform OJFLPPDPFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Transform DPHNADLFLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Transform NFOAGPIBDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public Transform JOAKDKEPPPB;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NLNJDBEKDAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public SkinnedMeshRenderer[] NGDGCDPMGAE;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OFKHLABLOHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public LBAKALAPCCD KDDPPINGPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public int IJJJAOMIKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int HAFBLKOBMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int IJMIMFEEBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public int BIGLMMKMFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int HCCAOALLNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int NHMGLABAING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public int AADJFMBKJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float CNMHENKCDDP;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct FMGCOKCLLAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public LBAKALAPCCD KDDPPINGPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Vector2 HFDKNPOOKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public float BJKHLDBIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Vector2 PLGMAKCJPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float JBFJIBGDJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Vector2 HIKIGDKNBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float GHLBODEDMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float BAGCPLHEIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Vector2 LAOLBLPGNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Vector2 CGMFAODIEGP;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FKDEMMCJEBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public string DBDKMHBCKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public OutfitType KKMAKPNGFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NNLMNCGPPJI CLPLOIOBFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public bool MJOCJKPHGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Color? NIMNHLFIAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector3? DHEDNFOJJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float? NGPBOJLKLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Guid? NEELOGOFJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Color? KLOGGNMGMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool DJJMBJGLGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool NFOAIIHAJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public AnchorParamsRestrictions OBHJCFFAOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Vector2? BAELGDDOLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Transform NAPPGLLKAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public FitMeshHemisphere OJOCBJEHICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Vector2 BKBOFACOFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private List<AvatarHairPatternOverride> BAAEECLONFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private Dictionary<string, Texture2D> KFMLINABLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<AvatarHairPatternOverride> NJMCGNNGACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Dictionary<string, Texture2D> HHPBNJACPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public AssetReference CBIJCIJCCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public AssetReference OIELBIHNJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public AssetReference[] JNLKHMNLALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool BIAEJNEHGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE9")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool COBPPCCJCPL;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public List<AvatarHairPatternOverride> HANKLPCKGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F6750", Offset = "0x6F5B50", VA = "0x1806F6750")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x637F540", Offset = "0x637E940", VA = "0x18637F540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public List<AvatarHairPatternOverride> IJOIJMPDCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x810840", Offset = "0x80FC40", VA = "0x180810840")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x637F770", Offset = "0x637EB70", VA = "0x18637F770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string OHAFBKEHJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x637F490", Offset = "0x637E890", VA = "0x18637F490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x637F9A0", Offset = "0x637EDA0", VA = "0x18637F9A0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x637F1A0", Offset = "0x637E5A0", VA = "0x18637F1A0")]
		public static void IDLINKJDJNA(AvatarItemMaterial CAJPHFMJOIP, Material HNKAKNCAJGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x637F200", Offset = "0x637E600", VA = "0x18637F200")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NIEFOCPIMKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Mesh LLGFLPNLCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly Material[] LDPKNGCLEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public readonly bool ADMFIPPPINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool JJKKFNMJGKF;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	private NIEFOCPIMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x63856D0", Offset = "0x6384AD0", VA = "0x1863856D0")]
	public NIEFOCPIMKD(Mesh DJAAGGDMNFL, Material[] FBDANEMMOLJ, bool MHDCBOPEKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x63855B0", Offset = "0x63849B0", VA = "0x1863855B0")]
	public NIEFOCPIMKD(SkinnedMeshRenderer KGEGHCPPMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6385240", Offset = "0x6384640", VA = "0x186385240")]
	public static NIEFOCPIMKD KFEKFKJOJJJ(Renderer CMNBAAPLLDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum OPJOBFNALCH
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
public enum MKOAAPBHDJJ
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
public enum NNLMNCGPPJI
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
public enum HECGIAGAOOM
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
public enum GLLHGLJIPDJ
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
public enum PDNDDJAHPKA
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum BDKFDIBEFGB
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
public enum NEAFOOCMBCG
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
public enum JHOFGJONAMO
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
public static class NMBICGFLCAA
{
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static readonly int LALDPDIMBCC;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static readonly string CLJJFCONPGG;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static readonly string KDGNLEIPKED;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x63857E0", Offset = "0x6384BE0", VA = "0x1863857E0")]
	public static MBJBOIKCDKP BGOHBNLFOAF()
	{
		return default(MBJBOIKCDKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6385AB0", Offset = "0x6384EB0", VA = "0x186385AB0")]
	public static DIIKJOMKJNG NDEKLFOKGAC(Transform OFGIGKJMOGJ, Transform KIGMOHMNJLC, AvatarConfiguration BFIDAJKPLJP, Animator PKGCHLLBJOD, VRIK EIIAOGOICKD, SkeletonLODUpdateRate[] KDDHKANMBPA, GameObject[] MAHMBNGMDOF, Transform AGDCGCJGKBE, GameObject HAJOIOBJOBD, BodySkinnedMeshLODs FIADCCBMMLB, BodySkinnedMeshLODs LHPBMFDBLFI, GameObject AJPJCBECAIN, BodySkinnedMeshLODs LDFGAPIEJJN, BodySkinnedMeshLODs FEBNHDOPOHI, MEOLDPJAGDP DFKPGOHAJKI, Material BLPPILFGCKC, Material JIMLMNIKDOP, Shader KKDNIADMOFG, Transform JMHJJMIEEIE, Transform NCEKELMIBDG, Transform OIBKMKALNIB, Transform JHLNEODIAMC, Transform OFBNPKNCOBN)
	{
		return default(DIIKJOMKJNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6385CD0", Offset = "0x63850D0", VA = "0x186385CD0")]
	public static IBEGEDADFCM PNCGODCAMPL(string NKLDEIJAOID, bool JPLDDPHBBGK, bool CHJDBKMIOJP, bool JGBIBPALMDN, RigidbodyEx CGAMHDBLHMF, RigidbodyEx BCFJKANEFGG, RigidbodyEx DHKLHCMHKIL, RigidbodyEx PFFAKIMOPED, Transform MMMJBAKNMLM, Transform BDOHODPHKGI, Transform APDJDBCKHIC, float CJKCDNMPEJF, float AKIFKOACCPA, PlayerAvatarFullBodyColliders KBMIILDIFBE)
	{
		return default(IBEGEDADFCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6385930", Offset = "0x6384D30", VA = "0x186385930")]
	public static HGPPDMPPLMP KPKDFPKCENN(Transform KIGMOHMNJLC, GameObject HAJOIOBJOBD, SkinnedMeshRenderer[] GDKDHFPJICC, SkinnedMeshRenderer[] GJECDMCNOAI, GameObject AJPJCBECAIN, SkinnedMeshRenderer[] OLOICGDOEFM, SkinnedMeshRenderer[] KKEGMNCIADN, MEOLDPJAGDP DFKPGOHAJKI, Material BLPPILFGCKC, Material JIMLMNIKDOP, Shader KKDNIADMOFG)
	{
		return default(HGPPDMPPLMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6385810", Offset = "0x6384C10", VA = "0x186385810")]
	public static GELDMJNLBJM HMKGENJCDHC(Transform JMHJJMIEEIE, Transform OIBKMKALNIB, Transform NCEKELMIBDG, Transform JHLNEODIAMC, Transform OFBNPKNCOBN)
	{
		return default(GELDMJNLBJM);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xE0C800", Offset = "0xE0BC00", VA = "0x180E0C800")]
	public static NLNJDBEKDAL DFFNNHPDBCC(SkinnedMeshRenderer[] LOOMFAGIJDN)
	{
		return default(NLNJDBEKDAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6385A30", Offset = "0x6384E30", VA = "0x186385A30")]
	public static OFKHLABLOHB LJKKGFDBKGA(LBAKALAPCCD NLGAOHGHEFI, int KBCGMJPOFMP, int LAJGOOGOAGG, int ENGNMLPHAOO, int JAOKOLONGMH, int DFPAOGNHACD, int NILPOGFFKFF, int HGJEIOPMABN, float PBCBDFNEIFL)
	{
		return default(OFKHLABLOHB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x63858A0", Offset = "0x6384CA0", VA = "0x1863858A0")]
	public static FMGCOKCLLAF KCMFDODFKNE(LBAKALAPCCD NLGAOHGHEFI, Vector2 PMNGLOFCIGM, float CEJPCLHFCMG, Vector2 NHJJNLDKIIG, float PJLMKBBOCHL, Vector2 LIINBCONLIH, float MDIHHBJFGOG)
	{
		return default(FMGCOKCLLAF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LNCAJLGFGJD
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Transform AMINHCIEOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Vector3 CCKIMHBKAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class EDENHILDMKK : LNCAJLGFGJD
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public Transform AMINHCIEOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x700130", Offset = "0x6FF530", VA = "0x180700130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public Vector3 CCKIMHBKAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xFE2C10", Offset = "0xFE2010", VA = "0x180FE2C10", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xFE2C40", Offset = "0xFE2040", VA = "0x180FE2C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public float? NDELEJOLNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xFE2C30", Offset = "0xFE2030", VA = "0x180FE2C30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xFE2C50", Offset = "0xFE2050", VA = "0x180FE2C50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public EDENHILDMKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class IFOLPMIELHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	protected readonly EDENHILDMKK JCOIKHKGMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	protected readonly EDENHILDMKK IFAFDMENOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	protected readonly EDENHILDMKK FIBAABEIHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	protected readonly EDENHILDMKK PEKJNJAMNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	protected readonly EDENHILDMKK NFKFOGPFBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	protected readonly EDENHILDMKK LFAIFJPEOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	protected readonly EDENHILDMKK HNOICMCEAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	protected readonly EDENHILDMKK HGEEBJHFOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected readonly EDENHILDMKK KLLAIDOPOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	protected readonly EDENHILDMKK OLNMCONLCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	protected readonly EDENHILDMKK LKGDNMNPDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	protected readonly EDENHILDMKK GEEHDHLCNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	protected readonly EDENHILDMKK GNJMNFNKGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	protected EDENHILDMKK CHHFHGELKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	protected readonly EDENHILDMKK PELAIJIHFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	protected readonly EDENHILDMKK CKMHAHNEOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	protected readonly EDENHILDMKK ONGCOHDEKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	protected EDENHILDMKK FKADPGMCJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	protected readonly EDENHILDMKK HDPNOGPBNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected readonly EDENHILDMKK FMJFKPLPLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	protected readonly EDENHILDMKK IPLGGIBOPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected ReadOnlyCollection<EDENHILDMKK> GBPPLBABLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public Transform AGDCGCJGKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private (EDENHILDMKK Start, EDENHILDMKK End)[] AGLCHAAMDOM;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public LNCAJLGFGJD HONMEOIDEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public LNCAJLGFGJD AIHCLHLLGPN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public LNCAJLGFGJD DNNDPOCOABK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public LNCAJLGFGJD BNPCIAMFKIK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8E0", Offset = "0x6F9CE0", VA = "0x1806FA8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public LNCAJLGFGJD KAHJPBDJDIA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public LNCAJLGFGJD OLIBJIEKMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6E7570", Offset = "0x6E6970", VA = "0x1806E7570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public LNCAJLGFGJD PPHPFBHCHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6E7580", Offset = "0x6E6980", VA = "0x1806E7580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EDENHILDMKK DODPGAJGKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6E7580", Offset = "0x6E6980", VA = "0x1806E7580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public LNCAJLGFGJD KENAHAHKFOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6E00D0", Offset = "0x6DF4D0", VA = "0x1806E00D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public EDENHILDMKK LNMNMIMCGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E00D0", Offset = "0x6DF4D0", VA = "0x1806E00D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public LNCAJLGFGJD JBPLOIMHOIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6F6760", Offset = "0x6F5B60", VA = "0x1806F6760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public LNCAJLGFGJD DKMNNPOEKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6E00B0", Offset = "0x6DF4B0", VA = "0x1806E00B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public LNCAJLGFGJD OABDLCAIPIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F6770", Offset = "0x6F5B70", VA = "0x1806F6770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public EDENHILDMKK BBEPLEIPBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F6770", Offset = "0x6F5B70", VA = "0x1806F6770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public EDENHILDMKK IGIMHOPHLHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6F6780", Offset = "0x6F5B80", VA = "0x1806F6780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public LNCAJLGFGJD NLGMNNBNHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F6780", Offset = "0x6F5B80", VA = "0x1806F6780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public LNCAJLGFGJD HKGOICAJGIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F6700", Offset = "0x6F5B00", VA = "0x1806F6700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public LNCAJLGFGJD AOCCDJHFLHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F6710", Offset = "0x6F5B10", VA = "0x1806F6710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public LNCAJLGFGJD LGBMKAGDGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x71C6D0", Offset = "0x71BAD0", VA = "0x18071C6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public LNCAJLGFGJD JLOEMCKFIIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6E6D80", Offset = "0x6E6180", VA = "0x1806E6D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public LNCAJLGFGJD IBCEIBCGBOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6E6E20", Offset = "0x6E6220", VA = "0x1806E6E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public LNCAJLGFGJD AAFEJHEEGKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x71C6A0", Offset = "0x71BAA0", VA = "0x18071C6A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public LNCAJLGFGJD LFNJDIKDJPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6F6720", Offset = "0x6F5B20", VA = "0x1806F6720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public LNCAJLGFGJD CPJDAHJGDGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F6730", Offset = "0x6F5B30", VA = "0x1806F6730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public LNCAJLGFGJD COMFBBNEBEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F6750", Offset = "0x6F5B50", VA = "0x1806F6750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public IReadOnlyList<LNCAJLGFGJD> ALNLDCJJOEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F6740", Offset = "0x6F5B40", VA = "0x1806F6740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x63818B0", Offset = "0x6380CB0", VA = "0x1863818B0")]
	public void FJDPAHIAHLO(VRIK CGMNGDAGIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x20D8480", Offset = "0x20D7880", VA = "0x1820D8480")]
	private void FHDHFMOEHKK(Transform EHNCKNECPAL, EDENHILDMKK NMAMPMADCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x63825D0", Offset = "0x63819D0", VA = "0x1863825D0")]
	public void LKFGKAJBJCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x20D9EB0", Offset = "0x20D92B0", VA = "0x1820D9EB0")]
	public float JLACJPNOBNL(in (EDENHILDMKK Start, EDENHILDMKK End) GNDOGLGKNOI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x63823F0", Offset = "0x63817F0", VA = "0x1863823F0")]
	public void LHPDHMNBHMI(in MBJBOIKCDKP KFCHBPFAEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x63822A0", Offset = "0x63816A0", VA = "0x1863822A0")]
	private Vector3 KIFMFGGENHN(in (EDENHILDMKK Start, EDENHILDMKK End) GNDOGLGKNOI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6382A80", Offset = "0x6381E80", VA = "0x186382A80")]
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
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x637F2C0", Offset = "0x637E6C0", VA = "0x18637F2C0")]
		public string CCKLEFNAGNP(string BICMNJGHCBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x637F310", Offset = "0x637E710", VA = "0x18637F310")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct IBEGEDADFCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public string JDPHCJAAPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool BOGCINNBAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool LHDHINMLDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public float GEBIAGNALCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public float KPAGANNBAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public bool POGDKLKMEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public RigidbodyEx GJGAAGFNKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public RigidbodyEx DJEBFNPLNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public RigidbodyEx FOHJNHMIPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public RigidbodyEx LNCKBDJKNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public Transform BBIMBIACLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public Transform AIDJKLMEHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public Transform CIHLOCHEKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public PlayerAvatarFullBodyColliders FLNINGAPMMO;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct DIIKJOMKJNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Transform FBFEEHFHDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public Transform AEKLDPNCPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public AvatarConfiguration MFPEENJFGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Animator FNNALDEDLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public VRIK KLJLHMPHEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public SkeletonLODUpdateRate[] NJAPGBIFNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public GameObject[] NKDANFEIPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Transform ACIHCKFLIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public GameObject CCJBJEBEKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public BodySkinnedMeshLODs EMGHCAOOGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public BodySkinnedMeshLODs DLIIBBIFHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public GameObject HKLPBEODHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public BodySkinnedMeshLODs EECEIJLGKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public BodySkinnedMeshLODs LIJIFCDJPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public MEOLDPJAGDP OEIBHADMCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public Material DIFMJODLAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public Material ODIPEDJKKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public Shader PBJFALEGAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public Transform GPOKNKLKJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public Transform DPHNADLFLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public Transform OJFLPPDPFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public Transform NFOAGPIBDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public Transform JOAKDKEPPPB;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct MBJBOIKCDKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public float APJLDCLNPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public bool CEKBIFBPLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public GMJLIEJPOEJ LKNKANFLGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public Vector3 NNEEHDBABKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public Vector3 NFGINPGDPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public Vector3? LJCIDJADECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public Vector3? LNGNHJFFPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public bool NGCBDJDDBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public bool BNDCLGABHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public bool MGECLMHCLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public bool EDJOEGBHDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool APBBIIHIFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public Vector3? DHOJKBNEOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool DOJKFBKPKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public Vector3? CPMEFJCNPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public bool CFDIKANOBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public Vector3? OCPLHMPOGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public Vector3? KLCKLFBPLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public bool CBNCMFHHADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public bool PBPNKEIMCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public bool ICMAECLLDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public bool MHEJIKGAOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool IKEJOFFOFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool CFHEDMFLHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public bool LDCFKNEEPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool JOMCAFPFMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public bool KIFOOIMDDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public bool CBKCMBILBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public Vector3? GCFJMLEEDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public OPJOBFNALCH NIENJKLNFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public OPJOBFNALCH JCGKDGNEHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public float LIDPEOJLIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public float MHBNIGLECMN;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface LEEBCIMFDFP
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LCJCJJPEPFC();

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::NJBAAHLOPDA<Texture2D> CAEDLJJEDHL(MMPDNPLNFLF NLLFAFFBLCJ, [Optional] DHGMMBBNOAP DGCNIAGLPMA);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NFHEKJNAKHI : LEEBCIMFDFP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private KNALHJDADMH LOLNOAEHFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private IRecRoomQualityConfigProvider CFJNJBFPLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private bool FNOLDNMCLME;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private const uint LLGANPAIALF = 16u;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x63850F0", Offset = "0x63844F0", VA = "0x1863850F0")]
	[JDLBAGCFHIO(MEDANDNEHIF.None)]
	private static void GDFJHBNIOGM(DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	[Preserve]
	public NFHEKJNAKHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6384A20", Offset = "0x6383E20", VA = "0x186384A20")]
	private void BBCNCAGODCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x63851E0", Offset = "0x63845E0", VA = "0x1863851E0", Slot = "4")]
	public void LCJCJJPEPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6384AD0", Offset = "0x6383ED0", VA = "0x186384AD0", Slot = "5")]
	public global::NJBAAHLOPDA<Texture2D> CAEDLJJEDHL(MMPDNPLNFLF NLLFAFFBLCJ, [Optional] DHGMMBBNOAP DGCNIAGLPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6384EE0", Offset = "0x63842E0", VA = "0x186384EE0")]
	private uint DPPKHILNEBI(MMPDNPLNFLF NLLFAFFBLCJ, DHGMMBBNOAP DGCNIAGLPMA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum CFMBLBMHKNG
{
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class DHGMMBBNOAP
{
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public static readonly DHGMMBBNOAP LMPNKNOCBFL;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int AHIBFBMPKDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6E0040", Offset = "0x6DF440", VA = "0x1806E0040")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x700F30", Offset = "0x700330", VA = "0x180700F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public CFMBLBMHKNG OBCICDOMPBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6F6790", Offset = "0x6F5B90", VA = "0x1806F6790")]
		[CompilerGenerated]
		get
		{
			return default(CFMBLBMHKNG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x92A260", Offset = "0x929660", VA = "0x18092A260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public DHGMMBBNOAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x637F450", Offset = "0x637E850", VA = "0x18637F450")]
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
			[Cpp2IlInjected.Address(RVA = "0x63811F0", Offset = "0x63805F0", VA = "0x1863811F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6381130", Offset = "0x6380530", VA = "0x186381130")]
		public FitMeshHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6380930", Offset = "0x637FD30", VA = "0x186380930")]
		public void CNAKDNPCICA(FitMeshHemisphere NEDDLLDEBEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6380C60", Offset = "0x6380060", VA = "0x186380C60")]
		public Vector3 PFKDCJBOBEG(Vector2 BEAPKMGPPON, bool IMBPEOIKIDG = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6380980", Offset = "0x637FD80", VA = "0x186380980")]
		public Vector3 EOJDBBEDJHM(Vector2 BEAPKMGPPON)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x63809E0", Offset = "0x637FDE0", VA = "0x1863809E0")]
		public Quaternion NMMFPOHFOLF(Vector2 BEAPKMGPPON)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6380B10", Offset = "0x637FF10", VA = "0x186380B10")]
		public Quaternion NMMFPOHFOLF(Vector2 BEAPKMGPPON, Vector3 FHDDLBPPKOP)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6380C20", Offset = "0x6380020", VA = "0x186380C20")]
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
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public readonly GameObject KPMBGPHMJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public readonly AvatarItemMaterial IMFNNAOHILO;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x790A30", Offset = "0x78FE30", VA = "0x180790A30")]
	public MMEJMLEGDDM(GameObject KPMBGPHMJMA, AvatarItemMaterial IMFNNAOHILO)
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
public static class HEEIICMAPGB
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6381260", Offset = "0x6380660", VA = "0x186381260")]
	public static bool PPEINKIDBAP(this OutfitType LEHAMCBCPDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6381220", Offset = "0x6380620", VA = "0x186381220")]
	public static bool GJOOGHJHHCI(this OutfitType LEHAMCBCPDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6381240", Offset = "0x6380640", VA = "0x186381240")]
	public static bool LKOHENEDNNL(this OutfitType LEHAMCBCPDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6381250", Offset = "0x6380650", VA = "0x186381250")]
	public static bool LOOADOAOALC(this OutfitType LEHAMCBCPDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6381210", Offset = "0x6380610", VA = "0x186381210")]
	public static bool FJAILIBEIPP(this OutfitType LEHAMCBCPDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6381200", Offset = "0x6380600", VA = "0x186381200")]
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
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private MEOLDPJAGDP PAEODOPIKBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private Collider[] FFBNCNEDHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private Collider[] OPHGEDADPPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6385F00", Offset = "0x6385300", VA = "0x186385F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6385E80", Offset = "0x6385280", VA = "0x186385E80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x63860C0", Offset = "0x63854C0", VA = "0x1863860C0")]
		public void UpdateBones(MEOLDPJAGDP DFKPGOHAJKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6385F70", Offset = "0x6385370", VA = "0x186385F70")]
		public void SetCollidersEnabled(bool IGPDCEGDODH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x63860F0", Offset = "0x63854F0", VA = "0x1863860F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FB290", Offset = "0x6FA690", VA = "0x1806FB290", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x637F360", Offset = "0x637E760", VA = "0x18637F360")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E7170", Offset = "0x6E6570", VA = "0x1806E7170", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x637F360", Offset = "0x637E760", VA = "0x18637F360")]
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
			[Cpp2IlInjected.Address(RVA = "0x637FCD0", Offset = "0x637F0D0", VA = "0x18637FCD0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x812F50", Offset = "0x812350", VA = "0x180812F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x17CE4C0", Offset = "0x17CD8C0", VA = "0x1817CE4C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xF66320", Offset = "0xF65720", VA = "0x180F66320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x637FBA0", Offset = "0x637EFA0", VA = "0x18637FBA0", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x637FC50", Offset = "0x637F050", VA = "0x18637FC50")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public IEnumerable<Sprite> SrcSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x6FA8E0", Offset = "0x6F9CE0", VA = "0x1806FA8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x637FB80", Offset = "0x637EF80", VA = "0x18637FB80")]
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
			[Cpp2IlInjected.Address(RVA = "0x4793E70", Offset = "0x4793270", VA = "0x184793E70")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xE99210", Offset = "0xE98610", VA = "0x180E99210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x637F9B0", Offset = "0x637EDB0", VA = "0x18637F9B0")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x637FA20", Offset = "0x637EE20", VA = "0x18637FA20", Slot = "5")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x637FAA0", Offset = "0x637EEA0", VA = "0x18637FAA0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public readonly Texture2DArray NDACBKPFOCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public readonly Dictionary<string, int> EBFOFLMCMBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private readonly JLNNFJHBOML GFJEAEKJMBO;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool BLNDNEFKBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x1812600", Offset = "0x1811A00", VA = "0x181812600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6384940", Offset = "0x6383D40", VA = "0x186384940")]
		public MMLMLJPOMDD(Texture2DArray EBLGEKJICDL, Dictionary<string, int> GIAOHMIODOL, LBAKALAPCCD GDDJECPEDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xF650A0", Offset = "0xF644A0", VA = "0x180F650A0")]
		public void IFJGDKHAINM(LBAKALAPCCD JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xF64D60", Offset = "0xF64160", VA = "0x180F64D60")]
		public void KFFCNCACBBK(LBAKALAPCCD JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x117D060", Offset = "0x117C460", VA = "0x18117D060", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct KJKFKMKGPGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private readonly string AKDJBNPDCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private readonly string FMOHAPICJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private readonly string JIGGMHAJIND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private readonly string MILOHDAPMPO;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5B7EA00", Offset = "0x5B7DE00", VA = "0x185B7EA00")]
		public KJKFKMKGPGA(string DKIFPAACPFL, string MBBGPDAANEO, string OECFAIKHPNC, string AIFHMKLCMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6382FD0", Offset = "0x63823D0", VA = "0x186382FD0")]
		public bool OGHMKNDIAJH(KJKFKMKGPGA JHMCLPBFJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6382E20", Offset = "0x6382220", VA = "0x186382E20", Slot = "0")]
		public override bool Equals(object AELIHOPICED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6382F00", Offset = "0x6382300", VA = "0x186382F00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6382FD0", Offset = "0x63823D0", VA = "0x186382FD0")]
		public static bool IIPILNNMHKL(KJKFKMKGPGA NJMNOIGKPAI, KJKFKMKGPGA LIILEENPBBG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6383060", Offset = "0x6382460", VA = "0x186383060")]
		public static bool NCOOAABHIPD(KJKFKMKGPGA NJMNOIGKPAI, KJKFKMKGPGA LIILEENPBBG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly Dictionary<string, int> GIAOHMIODOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly KJKFKMKGPGA CPKHBEGGOIN;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Texture2DArray HJCBMJCPJLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x700140", Offset = "0x6FF540", VA = "0x180700140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public SymmetricalFaceFeature MIHEEOAEHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6E0530", VA = "0x1806E1130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public SymmetricalFaceFeature IMNKPCBOBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6FA8E0", Offset = "0x6F9CE0", VA = "0x1806FA8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x722210", Offset = "0x721610", VA = "0x180722210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public SymmetricalFaceFeature CABHNAFBOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x778B00", Offset = "0x777F00", VA = "0x180778B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public FaceFeature KDJGFAONMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6E7570", Offset = "0x6E6970", VA = "0x1806E7570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6E7590", Offset = "0x6E6990", VA = "0x1806E7590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6383100", Offset = "0x6382500", VA = "0x186383100")]
	private static void FCMMNBIIEFI(Sprite HIIHDJCCMJG, Sprite LCCPBBAOCCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6383410", Offset = "0x6382810", VA = "0x186383410")]
	private static void OCPHHCNEBFL(Sprite PMOFICFJAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6383480", Offset = "0x6382880", VA = "0x186383480")]
	public LBAKALAPCCD(SymmetricalFaceFeature MMKMLAALFOF, FaceFeature EANHAEEDJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x63834B0", Offset = "0x63828B0", VA = "0x1863834B0")]
	public LBAKALAPCCD(SymmetricalFaceFeature NCNNMFIGPFM, SymmetricalFaceFeature MMKMLAALFOF, SymmetricalFaceFeature BPFPOHJOPME, FaceFeature EANHAEEDJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6383200", Offset = "0x6382600", VA = "0x186383200")]
	public bool NMBFOFHJHME(Sprite PMOFICFJAIE, out int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x63830F0", Offset = "0x63824F0", VA = "0x1863830F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6380900", Offset = "0x637FD00", VA = "0x186380900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6380400", Offset = "0x637F800", VA = "0x186380400")]
		public LBAKALAPCCD KOFGCLOCOHF(int MMKMLAALFOF, int EANHAEEDJDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6380180", Offset = "0x637F580", VA = "0x186380180")]
		public LBAKALAPCCD KOFGCLOCOHF(int JOHJMIAEPKL, int MMKMLAALFOF, int NNLFLDKBEFA, int EANHAEEDJDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x637FCF0", Offset = "0x637F0F0", VA = "0x18637FCF0")]
		public FaceFeatureBase DFLNDBLAAHA(FaceFeatureType IEDCELGGALI, string DBODHDCBMLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x63800F0", Offset = "0x637F4F0", VA = "0x1863800F0")]
		public int EEHHNEIFEAO(string DBODHDCBMLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x63806A0", Offset = "0x637FAA0", VA = "0x1863806A0")]
		private void PDGFFBHBFDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x238A0A0", Offset = "0x23894A0", VA = "0x18238A0A0")]
		private void LKAKPGCDGFE<T>(Dictionary<string, T> GCMGJFGGLEN, T[] IPAKFKGAHLN) where T : FaceFeatureBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x637FE80", Offset = "0x637F280", VA = "0x18637FE80")]
		public string DHNKHCPIEAI(FaceFeatureType IEDCELGGALI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x637FF70", Offset = "0x637F370", VA = "0x18637FF70")]
		public string DIPKHBGKEJI(FaceFeatureType IEDCELGGALI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6380880", Offset = "0x637FC80", VA = "0x186380880")]
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
			[Cpp2IlInjected.Address(RVA = "0x706AA0", Offset = "0x705EA0", VA = "0x180706AA0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6384A10", Offset = "0x6383E10", VA = "0x186384A10")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FB2A0", Offset = "0x6FA6A0", VA = "0x1806FB2A0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6384A10", Offset = "0x6383E10", VA = "0x186384A10")]
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
			[Cpp2IlInjected.Address(RVA = "0x6386350", Offset = "0x6385750", VA = "0x186386350")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x4445100", Offset = "0x4444500", VA = "0x184445100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x15AB6C0", Offset = "0x15AAAC0", VA = "0x1815AB6C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x44450F0", Offset = "0x44444F0", VA = "0x1844450F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x15AB690", Offset = "0x15AAA90", VA = "0x1815AB690")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x3270420", Offset = "0x326F820", VA = "0x183270420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x15AB5F0", Offset = "0x15AA9F0", VA = "0x1815AB5F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x6386370", Offset = "0x6385770", VA = "0x186386370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6386240", Offset = "0x6385640", VA = "0x186386240", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x637F360", Offset = "0x637E760", VA = "0x18637F360")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6381280", Offset = "0x6380680", VA = "0x186381280")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6381390", Offset = "0x6380790", VA = "0x186381390")]
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

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
