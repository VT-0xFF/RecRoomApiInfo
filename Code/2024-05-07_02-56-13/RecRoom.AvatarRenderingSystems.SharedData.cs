using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.AssetIds;
using RecRoom.Attributes;
using RecRoom.Avatars;
using RecRoom.Avatars.Face;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KELCFHOCGMI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float JCFFMNJOIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float KDNCKHCNEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float LLCGCJPHFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float NBKFAONPFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float GIEHFOKHEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float INOHGCIKOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float JOFDKLNJOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float JDLLHPBAJAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float KJNKPBKPLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float DLMKNOAFEBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float PACBLNICJGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float FOBJGPNMDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float DOIMGGFPCBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float DNBOGFCPBEA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float JHPBCMJHIEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float NJKDLHLACMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 HMMLNCGNOLN(Vector3 DENIFAFBDNP);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 EFPDMNJMIMD(Vector3 LLBEKECHFHH);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 FCBKPNKGNDE();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : KELCFHOCGMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public bool AllowTranslation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public bool AllowRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public float DefaultOffsetX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public float MinXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public float MaxXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public float DefaultOffsetY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public float MinYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public float MaxYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public float DefaultOffsetZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float MinZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public float MaxZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public float DefaultRotationX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public float RightRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float LeftRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public float DefaultRotationY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public float RightRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float LeftRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float DefaultRotationZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public float RightRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float LeftRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float MaxUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public float MinUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float MaxVCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float MinVCoordinate;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public const float DEFAULT_MIN_OFFSET = -0.1f;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public const float DEFAULT_MAX_OFFSET = 0.1f;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public const float DEFAULT_ROTATION_FREEDOM = 180f;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public const float DEFAULT_MIN_UV_COORDINATE = 0f;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const float DEFAULT_MAX_UV_COORDINATE = 1f;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x827680", Offset = "0x826880", VA = "0x180827680", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA339A0", Offset = "0xA32BA0", VA = "0x180A339A0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x94A870", Offset = "0x949A70", VA = "0x18094A870", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA03990", Offset = "0xA02B90", VA = "0x180A03990", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x905680", Offset = "0x904880", VA = "0x180905680", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x96FA50", Offset = "0x96EC50", VA = "0x18096FA50", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x88D930", Offset = "0x88CB30", VA = "0x18088D930", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7E4540", Offset = "0x7E3740", VA = "0x1807E4540", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA3F160", Offset = "0xA3E360", VA = "0x180A3F160", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x113D3A0", Offset = "0x113C5A0", VA = "0x18113D3A0", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x941250", Offset = "0x940450", VA = "0x180941250", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xC7BA80", Offset = "0xC7AC80", VA = "0x180C7BA80", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1B65870", Offset = "0x1B64A70", VA = "0x181B65870", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xD1D310", Offset = "0xD1C510", VA = "0x180D1D310", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xD1D720", Offset = "0xD1C920", VA = "0x180D1D720", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA80850", Offset = "0xA7FA50", VA = "0x180A80850", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8D34B0", Offset = "0x8D26B0", VA = "0x1808D34B0", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7CFC00", Offset = "0x7CEE00", VA = "0x1807CFC00", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x60AED60", Offset = "0x60ADF60", VA = "0x1860AED60")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x60AEDF0", Offset = "0x60ADFF0", VA = "0x1860AEDF0")]
		public AnchorParamsRestrictions(AJGKLNLMOMN PMCJJGJGOKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x60AEA80", Offset = "0x60ADC80", VA = "0x1860AEA80")]
		public BONMPAHMNCG LJLJMIKKPJA(BONMPAHMNCG CMAEFKALADH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x60AE6B0", Offset = "0x60AD8B0", VA = "0x1860AE6B0", Slot = "25")]
		public Vector3 DGHGILBHCHL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x60AE9F0", Offset = "0x60ADBF0", VA = "0x1860AE9F0", Slot = "22")]
		public Vector3 FCBKPNKGNDE()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x60AEA10", Offset = "0x60ADC10", VA = "0x1860AEA10", Slot = "20")]
		public Vector3 HMMLNCGNOLN(Vector3 DENIFAFBDNP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x60AE6D0", Offset = "0x60AD8D0", VA = "0x1860AE6D0", Slot = "21")]
		public Vector3 EFPDMNJMIMD(Vector3 LLBEKECHFHH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x60AE750", Offset = "0x60AD950", VA = "0x1860AE750", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x60AE4F0", Offset = "0x60AD6F0", VA = "0x1860AE4F0")]
		protected bool DBJIIIOILFO(AnchorParamsRestrictions NOBJAPGNDAK)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class JGLPKGBAOIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Transform[] JLPHECDIALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<string, Transform> LDANECJNDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<Transform, Transform> GHDGIPOCPLP;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public Transform[] BPNOKMFEFNM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60B39D0", Offset = "0x60B2BD0", VA = "0x1860B39D0")]
	public void LOCACHOEIEJ(Transform MMDIMMCFEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60B3AB0", Offset = "0x60B2CB0", VA = "0x1860B3AB0")]
	public Transform OGLMJAEDAIB(Transform LLKNPEPFEHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60B3B90", Offset = "0x60B2D90", VA = "0x1860B3B90")]
	public void OIEHMLENNFC(SkinnedMeshRenderer NNLPFHGHPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60B3820", Offset = "0x60B2A20", VA = "0x1860B3820")]
	private static void CHGFKJHNLLE(Transform MIAAKEAGJGI, List<Transform> PAKJADBLNNL, Dictionary<string, Transform> OAIODKJFKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60B3DD0", Offset = "0x60B2FD0", VA = "0x1860B3DD0")]
	public JGLPKGBAOIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KEHFDAKLHGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool EHNCDIDLFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool CNBJKICGNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public LDNHAIONBAK? PCODBOHJJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public JHJCKMOKKIL.JDLFGAOPFIH KLLEAAKBAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Texture2D CFJPJDAJFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Texture2D LJHJIIKHJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public IList<DFLONJANIBI> DNMAACHLCPO;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public KEHFDAKLHGP()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Header("Face Features")]
		[Tooltip("How far apart you can position your eyebrows.")]
		public Vector2 EyebrowsHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[Tooltip("How far up and down you can position your eyebrows.")]
		public Vector2 EyebrowsVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Tooltip("How small/large you can scale your eyebrows.")]
		public Vector2 EyebrowsScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Tooltip("How far apart can position your eyes.")]
		public Vector2 EyesHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Tooltip("How far up and down you can position your eyes.")]
		public Vector2 EyesVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Tooltip("How small/large you can scale your eyes.")]
		public Vector2 EyeScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[Tooltip("How far left and right you can position your mouth.")]
		public Vector2 MouthHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Tooltip("How far up and down you can position your mouth.")]
		public Vector2 MouthVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[Tooltip("How small/large you can scale your mouth.")]
		public Vector2 MouthScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Tooltip("How far left and right you can position your nose.")]
		public Vector2 NoseHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Tooltip("How far up and down you can position your nose.")]
		public Vector2 NoseVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Tooltip("How small/large you can scale your nose.")]
		public Vector2 NoseScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Tooltip("A constant multiplier on all eye jitter.")]
		public Vector2 GlobalEyeJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Tooltip("A constant multiplier on all eye gleam jitter.")]
		public Vector2 GlobalEyeGleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Tooltip("A constant multiplier on all eyebrow jitter.")]
		public Vector2 GlobalEyebrowJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Tooltip("A constant multiplier on all mouth jitter.")]
		public Vector2 GlobalMouthJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Tooltip("Used to scale a face bone into UV space by scaling to the bone's (x,y) position")]
		public Vector2 ScaleFaceBonesToUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("Used to translate all face bone into UV space by adding the offset to the post-scaled bone (x,y) position")]
		public Vector2 TranslateFaceBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Tooltip("Used to translate the eye brow bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBrowBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Tooltip("Used to translate the eye bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Tooltip("Used to translate the mouth bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateMouthBoneToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Tooltip("Minimum distance used to decrowd eyes to brows in vertical UV space")]
		public float MinDistFromEyesToBrowsInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Tooltip("Minimum distance used to decrowd nose to eyes in vertical UV space")]
		public float MinDistFromNoseToEyesInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Tooltip("Minimum distance used to decrowd mouth to nose in vertical UV space")]
		public float MinDistFromMouthToNoseInUVVerticalSpace;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x60AEEC0", Offset = "0x60AE0C0", VA = "0x1860AEEC0")]
		protected AvatarConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HDAHFNPPPIO
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly HPKOADDJOHD OKONIJJJBBM;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static BONMPAHMNCG HFCAALGIEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x60B3580", Offset = "0x60B2780", VA = "0x1860B3580")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct AGMEINJJBEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Transform NNEANOEKCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public AssetReference FMKJHEOFIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public GameObject FMLPEOKCBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public GameObject JKKCLCANNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public SkinnedMeshRenderer CIIPAALGOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Material AGNJHFBAKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Material LKKCAOICJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Material FCJEECNONHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public Shader MIFHHGBGOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Shader DKOKIPHHNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Animator DIPGOBCIHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Renderer[] JCPJBDNEJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public AvatarConfiguration OHCOCPFKFAH;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct PKAHLJKMCJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public SkinnedMeshRenderer[] IMMFMENAPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public SkinnedMeshRenderer[] CIBACAAJHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public SkinnedMeshRenderer[] OKIOCHAKJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public SkinnedMeshRenderer[] EHBHFBJADEA;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public SkinnedMeshRenderer[] LODs;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct AvatarHairPatternOverride : ISerializationCallbackReceiver, IEquatable<AvatarHairPatternOverride>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Obsolete("Use HairPatternId instead!")]
		[FormerlySerializedAs("PatternGuid")]
		[SerializeField]
		private string patternGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Texture2D Texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private SerializedHairPatternId hairPatternId;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public CBAFNFNJIBK HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x60AF2A0", Offset = "0x60AE4A0", VA = "0x1860AF2A0")]
			get
			{
				return default(CBAFNFNJIBK);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x60AF2D0", Offset = "0x60AE4D0", VA = "0x1860AF2D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x60AF250", Offset = "0x60AE450", VA = "0x1860AF250")]
		public AvatarHairPatternOverride(CBAFNFNJIBK FNPPFNFPABD, Texture2D AFMCPMEGELI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x60AF210", Offset = "0x60AE410", VA = "0x1860AF210", Slot = "6")]
		public bool Equals(AvatarHairPatternOverride NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x60AF160", Offset = "0x60AE360", VA = "0x1860AF160", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x60AF240", Offset = "0x60AE440", VA = "0x1860AF240", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BLMPBINFFNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public Transform CGFNGFGLKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Transform NAFKBAMBLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Transform KBFNAIAEKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Transform GOLFCKMLFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public Transform OKMLPIMGDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Transform CPLIOEIPOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Transform CGFIMELFDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public AvatarConfiguration OHCOCPFKFAH;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct GOJNOAGJEDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public SkinnedMeshRenderer[] HAHNJOPLLDI;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct OOEDLNLPEFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public CKFIBOLKANF HAHNIJDAGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int DIOACGKMDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int EIEHJLOKBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Color COBILJODMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Color PLLHDHLPCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public int DNMMEDJJALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public int OGNJPFFJHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Color DDPNELODOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Color OILGCDFEDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int FPBLPPHHKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float PDMDNEJNMOJ;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct FAHKNHJMFDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public CKFIBOLKANF HAHNIJDAGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Vector2 FPKOGNEGPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float PJNDKBOMPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Vector2 HICCDOGNAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float PEIHOADDKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Vector2 CAOEEOEGFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float KEPLMHABJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Vector2 DKMIGKGNDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float AFCJECJOKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool IJGFNFOGFJA;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DFLONJANIBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public string ECHFBJHACCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public OutfitType ENNLPNELCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public BKAHNFPJFDO CDAKOIINLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public JHJCKMOKKIL.JDLFGAOPFIH FABMBDIBHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public bool GOBHCMICFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public bool GMABBDBJEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public bool CLKOAICMDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Color? OFNMDAFJPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Guid? CPKAEKFGOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Color? FDPAOFHKBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public bool ONMAHKJKHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x65")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool PKHIDFCMFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Transform ICDPAHEBPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public FitMeshHemisphere MAEHGAJHNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Vector2 HJMCOIMMOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public AssetReference IGALNCJIDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public AssetReference NEONLMIFIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public AssetReference[] MICINANHGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool OEKHLHHJNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public bool JAMNPNPPECG;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string GPOBFOCAHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x60B1A30", Offset = "0x60B0C30", VA = "0x1860B1A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x60B1A30", Offset = "0x60B0C30", VA = "0x1860B1A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x60B1AE0", Offset = "0x60B0CE0", VA = "0x1860B1AE0")]
	public DFLONJANIBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KLHIEDGONPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public SkinnedMeshRenderer NIJGCLMFIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Material[] IANPIHJPICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private byte[] BDLDIAOFOOB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Mesh HNFFGBNBHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x60B4860", Offset = "0x60B3A60", VA = "0x1860B4860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Material[] EPFBJOMJAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public byte[] EIEOAAEHNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x60B4A00", Offset = "0x60B3C00", VA = "0x1860B4A00")]
	public KLHIEDGONPE(SkinnedMeshRenderer KEDLALENHJM, [Optional] Material[] LOHAIPJBPPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x60B4880", Offset = "0x60B3A80", VA = "0x1860B4880")]
	public static KLHIEDGONPE NCJGFBBGGBJ(Renderer CPHKADKGBCP)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct PositionAndRotation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Quaternion Rotation;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static PositionAndRotation Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA632F0", Offset = "0xA624F0", VA = "0x180A632F0")]
			get
			{
				return default(PositionAndRotation);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KOMJKBBICKE
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x60B4C40", Offset = "0x60B3E40", VA = "0x1860B4C40")]
	public static PositionAndRotation GJIBAJJOFGL(this PositionAndRotation NENMGGGFBAM)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x60B4DA0", Offset = "0x60B3FA0", VA = "0x1860B4DA0")]
	public static float OKHOCDKBNIE(float MOAGOANMCEN, Vector2 GNNFNGAAHIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x60B4E40", Offset = "0x60B4040", VA = "0x1860B4E40")]
	public static float OKHOCDKBNIE(float MOAGOANMCEN, float PMCJJGJGOKB, float MBHINFPNBPP, float OEEFGEJNCEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x60B4B70", Offset = "0x60B3D70", VA = "0x1860B4B70")]
	public static float EKOLAEMGJJG(float NICEPFIEJED, Vector2 GNNFNGAAHIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x60B4AC0", Offset = "0x60B3CC0", VA = "0x1860B4AC0")]
	public static float EKOLAEMGJJG(float NICEPFIEJED, float PMCJJGJGOKB, float MBHINFPNBPP, float OEEFGEJNCEK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PAIHNGJFJOL
{
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly int AJAPPCCAELM;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly string HDEDGNPPKJP;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum GOFAOAGAPBE
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum BKAHNFPJFDO
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Nose,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Face
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum KOLNPDEHNMN
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum AIBHHEMNOJP
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum LCOJHOLPOJB
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum BDOCOBBFHFE
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum MKGMNCBPOEP
{
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum CEJEDCNBEIC
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	None
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class AvatarSkinAssetItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public enum PDOMDOLMNBG
		{
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			ScreenFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			ThirdPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			VRFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			NoseSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			FaceSkinMesh
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[SerializeField]
		private NoseMeshConfiguration[] noseMeshConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private Dictionary<LDNHAIONBAK, BodySkinnedMeshLODs> OKDOHEKCJHM;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public BodySkinnedMeshLODs MBPGNBGHCEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public BodySkinnedMeshLODs OKAEEHHEJNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public BodySkinnedMeshLODs IGMBOLABJDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public BodySkinnedMeshLODs BEBEOLGJKMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x60AF6A0", Offset = "0x60AE8A0", VA = "0x1860AF6A0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x60AF410", Offset = "0x60AE610", VA = "0x1860AF410")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(PDOMDOLMNBG AKOIFOAKICP, [Optional] LDNHAIONBAK? JHPNHFGENCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x60AF7A0", Offset = "0x60AE9A0", VA = "0x1860AF7A0")]
		public AvatarSkinAssetItem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class JHJCKMOKKIL
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum EOGJPNMJKOH
	{
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Head,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		TorsoAll,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		TorsoHigh,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		TorsoLow,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		SleevesShort,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		SleevesLong,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		DEPRECATED_Palm,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		DEPRECATED_HandsAll,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		PantsLong,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Shorts,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		FootMid,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		ShoeLow,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		PantsShort,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		PalmL,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		PalmR,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		HandL,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		HandR,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		Ears,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		FootHigh
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[Flags]
	public enum JDLFGAOPFIH
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Head = 1,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		TorsoAll = 2,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		TorsoHigh = 4,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		TorsoLow = 8,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		SleevesShort = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		SleevesLong = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		DEPRECATED_Palm = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		DEPRECATED_HandsAll = 0x80,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		PantsLong = 0x100,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		Shorts = 0x200,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		FootMid = 0x400,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		ShoeLow = 0x800,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		PantsShort = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		PalmL = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		PalmR = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		HandL = 0x8000,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		HandR = 0x10000,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Ears = 0x20000,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		FootHigh = 0x40000
	}

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static JDLFGAOPFIH PBOJKINGOPP;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static JDLFGAOPFIH ECOPCENNOAK;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1BF2D40", Offset = "0x1BF1F40", VA = "0x181BF2D40")]
	public static JDLFGAOPFIH OKODHIFHGGK(JDLFGAOPFIH HPDHIBHKDCH, JDLFGAOPFIH EBMBGNAAFNA)
	{
		return default(JDLFGAOPFIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1BF2D30", Offset = "0x1BF1F30", VA = "0x181BF2D30")]
	public static JDLFGAOPFIH JLINJIGGCDA(JDLFGAOPFIH JMIDIMAKAPK, JDLFGAOPFIH JCFOFAGOEDM)
	{
		return default(JDLFGAOPFIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x60B3F20", Offset = "0x60B3120", VA = "0x1860B3F20")]
	public static JDLFGAOPFIH LJGFIOOAFHJ(EOGJPNMJKOH PKCJGBBEHNN, JDLFGAOPFIH GOFMGKLIOPJ)
	{
		return default(JDLFGAOPFIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x60B3EA0", Offset = "0x60B30A0", VA = "0x1860B3EA0")]
	public static JDLFGAOPFIH AJHFGFKMEFA(EOGJPNMJKOH PKCJGBBEHNN, JDLFGAOPFIH GOFMGKLIOPJ)
	{
		return default(JDLFGAOPFIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60B3EB0", Offset = "0x60B30B0", VA = "0x1860B3EB0")]
	public static bool HAMHIAIEIFF(this JDLFGAOPFIH AOCCBHMDOHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x60B3F30", Offset = "0x60B3130", VA = "0x1860B3F30")]
	public static bool PMHCCMINMLO(this JDLFGAOPFIH AOCCBHMDOHH)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class AvatarSkinnedMeshBoneOrderRemapsData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public struct BoneOrderRemapEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public string boneOrderChecksum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public byte[] boneOrderRemap;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class PANCOPLJLBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public AvatarSkinnedMeshBonesController bonesController;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public PANCOPLJLBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x60B5590", Offset = "0x60B4790", VA = "0x1860B5590")]
			internal bool GFJMGDPKMKO(BoneOrderRemapEntry item)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[SerializeField]
		private List<BoneOrderRemapEntry> BoneOrderRemapData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private Dictionary<string, byte[]> _boneOrderRemaps;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x60AF830", Offset = "0x60AEA30", VA = "0x1860AF830")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x60AF830", Offset = "0x60AEA30", VA = "0x1860AF830")]
		private void KPLOEOKNPAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x60B02A0", Offset = "0x60AF4A0", VA = "0x1860B02A0")]
		private void OMAGFCIJMBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x60AF840", Offset = "0x60AEA40", VA = "0x1860AF840")]
		public byte[] MICKMNFNPJC(string BANCHANDBPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x60AF8B0", Offset = "0x60AEAB0", VA = "0x1860AF8B0")]
		public bool OLAKODAHNHK(SkinnedMeshBoneOrderData JCCFLJKGFEN, AvatarSkinnedMeshBonesController IBEFIKKKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x60B03F0", Offset = "0x60AF5F0", VA = "0x1860B03F0")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class KDHDGHBIONK
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct LAHPBKPNDNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Transform[] BPNOKMFEFNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Matrix4x4[] AHMCMEDJOLM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static readonly string KGNMGCHHDMG;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static AvatarSkinnedMeshBoneOrderRemapsData EJKIEJFDDON;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x60B4800", Offset = "0x60B3A00", VA = "0x1860B4800")]
	static KDHDGHBIONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x60B3FF0", Offset = "0x60B31F0", VA = "0x1860B3FF0")]
	public static AvatarSkinnedMeshBoneOrderRemapsData CODHCPGHKHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x60B4160", Offset = "0x60B3360", VA = "0x1860B4160")]
	public static byte[] LBPJKIDGMCE(SkinnedMeshRenderer NNLPFHGHPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x60B4410", Offset = "0x60B3610", VA = "0x1860B4410")]
	public static LAHPBKPNDNM? NECKCGKBGAD(SkinnedMeshRenderer NNLPFHGHPAF)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	[DisallowMultipleComponent]
	public class AvatarSkinnedMeshBonesController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[SerializeField]
		[ReadOnlyField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[MGMFHFICAPM(OILHINDHMGI.Self, false, false, false)]
		[SerializeField]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public string CGIBAMHHAMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x60B04C0", Offset = "0x60AF6C0", VA = "0x1860B04C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x60B0920", Offset = "0x60AFB20", VA = "0x1860B0920")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x60B0880", Offset = "0x60AFA80", VA = "0x1860B0880")]
		private void OMAGFCIJMBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x60B04F0", Offset = "0x60AF6F0", VA = "0x1860B04F0")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B37D0", VA = "0x1807B45D0")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum MFCDKHJFNGG
{
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class FDEEEEBPKBB
{
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static readonly FDEEEEBPKBB CGCFGJJDBDI;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int FJCEKBFOBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7B3110", Offset = "0x7B2310", VA = "0x1807B3110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7B9910", Offset = "0x7B8B10", VA = "0x1807B9910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public MFCDKHJFNGG AKPFNBBBONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA552E0", Offset = "0xA544E0", VA = "0x180A552E0")]
		[CompilerGenerated]
		get
		{
			return default(MFCDKHJFNGG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA552D0", Offset = "0xA544D0", VA = "0x180A552D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public FDEEEEBPKBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x23C5BC0", Offset = "0x23C4DC0", VA = "0x1823C5BC0")]
	public FDEEEEBPKBB(MFCDKHJFNGG MAGPNICKDGE, int BKPPFOPONBJ)
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[SerializeField]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[SerializeField]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x60B3570", Offset = "0x60B2770", VA = "0x1860B3570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x60B34C0", Offset = "0x60B26C0", VA = "0x1860B34C0")]
		public FitMeshHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x60B2B60", Offset = "0x60B1D60", VA = "0x1860B2B60")]
		public void BKPDDPNNNLI(FitMeshHemisphere JBHEBCKDPNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x60B2BB0", Offset = "0x60B1DB0", VA = "0x1860B2BB0")]
		public Vector3 CABFMKCIFHN(Vector2 GNIPCNGPIJO, bool MMOFOJCKKNE = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x60B2F20", Offset = "0x60B2120", VA = "0x1860B2F20")]
		public Vector3 FPJDJBMBAOB(Vector2 GNIPCNGPIJO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x60B3160", Offset = "0x60B2360", VA = "0x1860B3160")]
		public Quaternion LKCFMOMCFEB(Vector2 GNIPCNGPIJO)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x60B2FE0", Offset = "0x60B21E0", VA = "0x1860B2FE0")]
		public Quaternion LKCFMOMCFEB(Vector2 GNIPCNGPIJO, Vector3 EIDAPDIFHFA)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x60B2F80", Offset = "0x60B2180", VA = "0x1860B2F80")]
		private Vector2 LFOMPALLDIP(Vector2 LLAIBEIHBON)
		{
			return default(Vector2);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct NoseMeshConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public NoseFaceOption NoseOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public BodySkinnedMeshLODs Meshes;
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class DMGNODEDAPH
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x60B1B80", Offset = "0x60B0D80", VA = "0x1860B1B80")]
	public static bool ICDNDGCGLIM(this OutfitType NBALLLMIMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x60B1B20", Offset = "0x60B0D20", VA = "0x1860B1B20")]
	public static bool GKJKNKFFHDF(this OutfitType NBALLLMIMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x60B1AF0", Offset = "0x60B0CF0", VA = "0x1860B1AF0")]
	public static bool ABCJKBMEPJD(this OutfitType NBALLLMIMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x60B1BB0", Offset = "0x60B0DB0", VA = "0x1860B1BB0")]
	public static bool OFCJNGPDOMA(this OutfitType NBALLLMIMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x60B1B10", Offset = "0x60B0D10", VA = "0x1860B1B10")]
	public static bool FMPMNPNGMLG(this OutfitType NBALLLMIMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x60B1B40", Offset = "0x60B0D40", VA = "0x1860B1B40")]
	public static bool HFGKFEPOBKM(this OutfitType NBALLLMIMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x60B1BA0", Offset = "0x60B0DA0", VA = "0x1860B1BA0")]
	public static bool IJKOGDPFANN(this OutfitType NBALLLMIMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x60B1B00", Offset = "0x60B0D00", VA = "0x1860B1B00")]
	public static bool DIIPICGMFMJ(this OutfitType NBALLLMIMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x60B1B60", Offset = "0x60B0D60", VA = "0x1860B1B60")]
	public static bool HHFACKBKIHG(this OutfitType NBALLLMIMML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class HDEHEKBJLNK : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static readonly HDEHEKBJLNK KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x60B3720", Offset = "0x60B2920", VA = "0x1860B3720", Slot = "4")]
	public bool Equals(OutfitType PHEBKAMJHKL, OutfitType KINOCFMACGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x60B3780", Offset = "0x60B2980", VA = "0x1860B3780", Slot = "5")]
	public int GetHashCode(OutfitType FLPJMDMACMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public HDEHEKBJLNK()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class SkinnedMeshBoneOrderData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		private List<string> validBoneOrder;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public IReadOnlyList<string> CurrentValidBoneOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x60B55C0", Offset = "0x60B47C0", VA = "0x1860B55C0")]
		public void BACHDLEAFJL(SkinnedMeshRenderer NNLPFHGHPAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x60B5760", Offset = "0x60B4960", VA = "0x1860B5760")]
		public SkinnedMeshBoneOrderData()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x9265C0", Offset = "0x9257C0", VA = "0x1809265C0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x60B0930", Offset = "0x60AFB30", VA = "0x1860B0930")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public Vector2 GleamJitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x60B1FD0", Offset = "0x60B11D0", VA = "0x1860B1FD0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x60B2030", Offset = "0x60B1230", VA = "0x1860B2030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x60B1FF0", Offset = "0x60B11F0", VA = "0x1860B1FF0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x60B2040", Offset = "0x60B1240", VA = "0x1860B2040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xACA460", Offset = "0xAC9660", VA = "0x180ACA460")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x181D220", Offset = "0x181C420", VA = "0x18181D220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x60B2010", Offset = "0x60B1210", VA = "0x1860B2010")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x60B2050", Offset = "0x60B1250", VA = "0x1860B2050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x60B1BC0", Offset = "0x60B0DC0", VA = "0x1860B1BC0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x60B1EC0", Offset = "0x60B10C0", VA = "0x1860B1EC0")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x60B2B40", Offset = "0x60B1D40", VA = "0x1860B2B40")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xF525E0", Offset = "0xF517E0", VA = "0x180F525E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xB38000", Offset = "0xB37200", VA = "0x180B38000")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xF4F840", Offset = "0xF4EA40", VA = "0x180F4F840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x60B2910", Offset = "0x60B1B10", VA = "0x1860B2910", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x60B2A50", Offset = "0x60B1C50", VA = "0x1860B2A50")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public abstract class FaceFeatureBase : SelectableFaceOption
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private struct <LoadSpriteAssetsAsync>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public FaceFeatureBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x60B5B40", Offset = "0x60B4D40", VA = "0x1860B5B40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x60B6890", Offset = "0x60B5A90", VA = "0x1860B6890", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private readonly List<IKCNFNMPLNN<Sprite>> _spriteResourceHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private readonly List<Sprite> _loadedSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private Task _activelyLoadingTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private int _referenceCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		private List<AssetReference> SpriteReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private Sprite[] DefaultSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public Vector2 JitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string DefaultSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x7B8CC0", Offset = "0x7B7EC0", VA = "0x1807B8CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7B8CD0", Offset = "0x7B7ED0", VA = "0x1807B8CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x60B2860", Offset = "0x60B1A60", VA = "0x1860B2860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x60B28D0", Offset = "0x60B1AD0", VA = "0x1860B28D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x60B2810", Offset = "0x60B1A10", VA = "0x1860B2810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x4D0E7B0", Offset = "0x4D0D9B0", VA = "0x184D0E7B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x4D0E9B0", Offset = "0x4D0DBB0", VA = "0x184D0E9B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x60B22F0", Offset = "0x60B14F0", VA = "0x1860B22F0")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x60B2430", Offset = "0x60B1630", VA = "0x1860B2430", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x60B2360", Offset = "0x60B1560", VA = "0x1860B2360")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x60B2510", Offset = "0x60B1710", VA = "0x1860B2510")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x60B20E0", Offset = "0x60B12E0", VA = "0x1860B20E0")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x60B2610", Offset = "0x60B1810", VA = "0x1860B2610")]
		protected FaceFeatureBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		Eye,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Mouth,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Nose,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		Brows
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class CKFIBOLKANF : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct OJKHLHKNCOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public AsyncTaskMethodBuilder<CKFIBOLKANF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public SymmetricalFaceFeature eyeBrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public EyesFaceFeature eye;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public FaceFeature mouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private HNAEADEHOKP.HLAHBHCFJNK <__>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x60B4EC0", Offset = "0x60B40C0", VA = "0x1860B4EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x60B54A0", Offset = "0x60B46A0", VA = "0x1860B54A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly Dictionary<string, int> DGGFDECFPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private bool BCAAEBMPFJH;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Texture2DArray PCGLJDMPMGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7B6290", Offset = "0x7B5490", VA = "0x1807B6290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public SymmetricalFaceFeature GFFKBALAGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7B84D0", Offset = "0x7B76D0", VA = "0x1807B84D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EyesFaceFeature BHKDJLJAIAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9A0", Offset = "0x7BBBA0", VA = "0x1807BC9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public FaceFeature PLCDEEHGFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7BC990", Offset = "0x7BBB90", VA = "0x1807BC990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x60B0940", Offset = "0x60AFB40", VA = "0x1860B0940")]
	private static void DHJABAHELDD(Sprite BGGLHDKBDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x60B1120", Offset = "0x60B0320", VA = "0x1860B1120")]
	public static CKFIBOLKANF FFJDPBHBDIA(SymmetricalFaceFeature JMNNOOKKCLN, EyesFaceFeature ANHHKLJOHFC, FaceFeature EEBGOBFKICL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x60B1230", Offset = "0x60B0430", VA = "0x1860B1230")]
	[AsyncStateMachine(typeof(OJKHLHKNCOE))]
	public static Task<CKFIBOLKANF> GAEJCOEKPED(SymmetricalFaceFeature JMNNOOKKCLN, EyesFaceFeature ANHHKLJOHFC, FaceFeature EEBGOBFKICL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x60B1650", Offset = "0x60B0850", VA = "0x1860B1650")]
	private CKFIBOLKANF(SymmetricalFaceFeature JMNNOOKKCLN, EyesFaceFeature ANHHKLJOHFC, FaceFeature EEBGOBFKICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x60B09B0", Offset = "0x60AFBB0", VA = "0x1860B09B0")]
	private void DKJEPAAKELG(List<Sprite> BHIIEIDPPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x60B1370", Offset = "0x60B0570", VA = "0x1860B1370")]
	public bool JNEAPEGLNKL(string HMKENGLGLHD, [Out] int HMFNCGHECPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x60B10F0", Offset = "0x60B02F0", VA = "0x1860B10F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x60B1560", Offset = "0x60B0760", VA = "0x1860B1560")]
	public bool KMIBCIBKNDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x60B11B0", Offset = "0x60B03B0", VA = "0x1860B11B0")]
	public void FJCFDHCMLEC()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x872860", Offset = "0x871A60", VA = "0x180872860", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x60B2A50", Offset = "0x60B1C50", VA = "0x1860B2A50")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public CEJEDCNBEIC SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x9157A0", Offset = "0x9149A0", VA = "0x1809157A0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x89ADA0", Offset = "0x899FA0", VA = "0x18089ADA0")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[Obsolete("Use FaceFeatureId instead!")]
		[SerializeField]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		protected string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private SerializedFaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private bool isNoneOption;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public LDNHAIONBAK FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x8A0B60", Offset = "0x89FD60", VA = "0x1808A0B60")]
			get
			{
				return default(LDNHAIONBAK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x899660", Offset = "0x898860", VA = "0x180899660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8A10A0", Offset = "0x8A02A0", VA = "0x1808A10A0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x89ADA0", Offset = "0x899FA0", VA = "0x18089ADA0")]
		protected SelectableFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x60B5AC0", Offset = "0x60B4CC0", VA = "0x1860B5AC0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xCF7600", Offset = "0xCF6800", VA = "0x180CF7600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x60B5B00", Offset = "0x60B4D00", VA = "0x1860B5B00")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x56B9170", Offset = "0x56B8370", VA = "0x1856B9170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x60B5AE0", Offset = "0x60B4CE0", VA = "0x1860B5AE0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x56BC430", Offset = "0x56BB630", VA = "0x1856BC430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x60B5B20", Offset = "0x60B4D20", VA = "0x1860B5B20")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x56BC420", Offset = "0x56BB620", VA = "0x1856BC420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x60B57F0", Offset = "0x60B49F0", VA = "0x1860B57F0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x60B59F0", Offset = "0x60B4BF0", VA = "0x1860B59F0")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class AdditionalHatData : AdditionalOutfitTypeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[ReadOnlyField]
		[SerializeField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[ReadOnlyField]
		[SerializeField]
		public Vector2 DefaultUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[ReadOnlyField]
		[SerializeField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x60ADF00", Offset = "0x60AD100", VA = "0x1860ADF00", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x60ADD10", Offset = "0x60ACF10", VA = "0x1860ADD10")]
		protected bool DBJIIIOILFO(AdditionalHatData NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x60AE010", Offset = "0x60AD210", VA = "0x1860AE010", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x60AE1B0", Offset = "0x60AD3B0", VA = "0x1860AE1B0")]
		public AdditionalHatData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x60AE2B0", Offset = "0x60AD4B0", VA = "0x1860AE2B0")]
		public AdditionalHatData(OPHLLOKBIGG PMCJJGJGOKB)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class AdditionalOutfitTypeData
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public AdditionalOutfitTypeData()
		{
		}
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
