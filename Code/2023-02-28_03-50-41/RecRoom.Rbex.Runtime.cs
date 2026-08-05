using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using Photon.Pun;
using RecRoom;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal class MIFBLINELCN
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public const string AEENDAFMNMP = "RBEX_DEFAULT";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const float BIGFIGODGBK = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public const float NPKLDNKBPFE = 0f;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public const float LAIJDKGIIEN = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public MIFBLINELCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void EOIGEIAJIKF(RigidbodyEx EIBKGMOKIDN);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void KHIJGEMJFAG(RigidbodyEx EIBKGMOKIDN, bool GJNGLKLPECL = false);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum GFNIKGHNFMK
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum PFIAFKPIHKP
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum BAPDLIMMIEJ
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class OOMAPLBOMFL : JPCNLOFKBAB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NDCDECKAEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C1040", Offset = "0x6BFA40", VA = "0x1806C1040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int MOEACPGDHPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D7790", Offset = "0x6D6190", VA = "0x1806D7790", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "6")]
	public MDILDCKBKMK EICKBCDDCBI(float EFJMJHLOKOL)
	{
		return default(MDILDCKBKMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "7")]
	public void CPLOAHMOJFD(GNMELKHCPEM LAFPICAOEAI, float DKGFBEEAKHF, EMCPICLMHHI EKIBJMEACIK = EMCPICLMHHI.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "8")]
	public void CPLOAHMOJFD(GNMELKHCPEM LAFPICAOEAI, Transform HHNPFCDICHH, float DKGFBEEAKHF, EMCPICLMHHI EKIBJMEACIK = EMCPICLMHHI.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "9")]
	public void HFDCJFDGIMI(GNMELKHCPEM LAFPICAOEAI, [Optional] float? DKGFBEEAKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "10")]
	public void OLCIACFECIH(GNMELKHCPEM IEIILDHIHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "11")]
	public MDILDCKBKMK KKAABKAJAAH(GNMELKHCPEM LAFPICAOEAI)
	{
		return default(MDILDCKBKMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6E2020", Offset = "0x6E0A20", VA = "0x1806E2020", Slot = "12")]
	public bool MCHJMJIJOAM(GNMELKHCPEM LAFPICAOEAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "13")]
	public void NEBFNPGIFHB(GNMELKHCPEM LAFPICAOEAI, EMCPICLMHHI OINHCOOFNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public OOMAPLBOMFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DNOPHNKOHLA(typeof(NEHCJNCFCPO), new string[] { "Ignore", "Mock" })]
public class IJEGCHBHIDN : NEHCJNCFCPO
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OGLDALHHNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C5250", Offset = "0x6C3C50", VA = "0x1806C5250", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
	public void AIEDDEJLAOG(string IMHLNJJFNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "6")]
	public void FPOIDDFFOHJ(RigidbodyEx MPLGHJJKMAH, Action CKAPOBIDCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "7")]
	public JPCNLOFKBAB PGKBIHACAOO(int FEJNIGEMPJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "8")]
	public void FFFGMGBGFFB(Vector3 GGMMBNPEDOM, float NOHFBAMFKJE, Color HAAENNGJIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public IJEGCHBHIDN()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	[LOEOGANCBGC(EDPDLGMLNHJ.Physics)]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool AAKELOLAKFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private FINELKBJAJC BJOCKKDEENH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[NKNFGAPPAGL(BPOBPCLEAHD.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[NKNFGAPPAGL(BPOBPCLEAHD.SelfAndParent, true, false, false)]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private PFIAFKPIHKP physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[HideInInspector]
		[SerializeField]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal FINELKBJAJC GCDBCKCLBIL
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6419E70", Offset = "0x6418870", VA = "0x186419E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<RigidbodyEx> DLHGIFABMAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6D7770", Offset = "0x6D6170", VA = "0x1806D7770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x762AB0", Offset = "0x7614B0", VA = "0x180762AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx LDPMKFFALAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x641B700", Offset = "0x641A100", VA = "0x18641B700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx PMIOODBJODJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x641B6A0", Offset = "0x641A0A0", VA = "0x18641B6A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public RigidbodyEx ELGBIOMPEHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x641C260", Offset = "0x641AC60", VA = "0x18641C260")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x641D9B0", Offset = "0x641C3B0", VA = "0x18641D9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform HOCKJBJNDGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x10C1050", Offset = "0x10BFA50", VA = "0x1810C1050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform CEGIGFGJCJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x10C1050", Offset = "0x10BFA50", VA = "0x1810C1050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public EMCPICLMHHI BOHPADGHJKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x641B390", Offset = "0x6419D90", VA = "0x18641B390")]
			get
			{
				return default(EMCPICLMHHI);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x641CF50", Offset = "0x641B950", VA = "0x18641CF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool BKLEDPDFLFC
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x641B910", Offset = "0x641A310", VA = "0x18641B910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool FBANMELJCLP
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x641B520", Offset = "0x6419F20", VA = "0x18641B520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public AAGBILKCEFJ HJMCHGKOFPF
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x641B8B0", Offset = "0x641A2B0", VA = "0x18641B8B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x641D160", Offset = "0x641BB60", VA = "0x18641D160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public HPBKAAPNIDE JFIJDPHAPDK
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x641B850", Offset = "0x641A250", VA = "0x18641B850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x641D0F0", Offset = "0x641BAF0", VA = "0x18641D0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool DADGANMPJCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x641B730", Offset = "0x641A130", VA = "0x18641B730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Rigidbody NGHLLPGFILB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x641B790", Offset = "0x641A190", VA = "0x18641B790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool HJNDJLEEIDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x641B5E0", Offset = "0x6419FE0", VA = "0x18641B5E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x641D010", Offset = "0x641BA10", VA = "0x18641D010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool LHMIDKJLKKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x10A8D70", Offset = "0x10A7770", VA = "0x1810A8D70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x10A7910", Offset = "0x10A6310", VA = "0x1810A7910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float CNALKFMBGBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x641C200", Offset = "0x641AC00", VA = "0x18641C200")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float IMELDNLFGMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x641C1A0", Offset = "0x641ABA0", VA = "0x18641C1A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x641D940", Offset = "0x641C340", VA = "0x18641D940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float JAFDEMBADIM
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x641BB70", Offset = "0x641A570", VA = "0x18641BB70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x641D400", Offset = "0x641BE00", VA = "0x18641D400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float EILAHENKJDI
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x641B970", Offset = "0x641A370", VA = "0x18641B970")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x641D1D0", Offset = "0x641BBD0", VA = "0x18641D1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool JOONLGAEPGE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x641C780", Offset = "0x641B180", VA = "0x18641C780")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x641DEF0", Offset = "0x641C8F0", VA = "0x18641DEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 IBGDLACDKOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x641BF80", Offset = "0x641A980", VA = "0x18641BF80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x641D710", Offset = "0x641C110", VA = "0x18641D710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 GGMMBNPEDOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x641C8C0", Offset = "0x641B2C0", VA = "0x18641C8C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CollisionDetectionMode NHHHCFEGDHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x641BAB0", Offset = "0x641A4B0", VA = "0x18641BAB0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x641D320", Offset = "0x641BD20", VA = "0x18641D320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float GPJNEDFLKLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x641B640", Offset = "0x641A040", VA = "0x18641B640")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x641D080", Offset = "0x641BA80", VA = "0x18641D080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public RigidbodyConstraints NHPBJPFJGOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x641BB10", Offset = "0x641A510", VA = "0x18641BB10")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x641D390", Offset = "0x641BD90", VA = "0x18641D390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 FGNHMPEFGAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x641C2C0", Offset = "0x641ACC0", VA = "0x18641C2C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 HHGKCOGHCII
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x641C2C0", Offset = "0x641ACC0", VA = "0x18641C2C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x641DCC0", Offset = "0x641C6C0", VA = "0x18641DCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float GCJNENCOCDE
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x641C060", Offset = "0x641AA60", VA = "0x18641C060")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x641D7F0", Offset = "0x641C1F0", VA = "0x18641D7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float EIMFGGDMPEH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x641C720", Offset = "0x641B120", VA = "0x18641C720")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x641DE80", Offset = "0x641C880", VA = "0x18641DE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion PJNKFBHKBHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x641C3A0", Offset = "0x641ADA0", VA = "0x18641C3A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x641DA20", Offset = "0x641C420", VA = "0x18641DA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion FHDHFGHLJJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x641C640", Offset = "0x641B040", VA = "0x18641C640")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x641DDA0", Offset = "0x641C7A0", VA = "0x18641DDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 EDGPDKPDBCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x641C480", Offset = "0x641AE80", VA = "0x18641C480")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x641DB00", Offset = "0x641C500", VA = "0x18641DB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Quaternion DFCGBIMIAKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x641C560", Offset = "0x641AF60", VA = "0x18641C560")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x641DBE0", Offset = "0x641C5E0", VA = "0x18641DBE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 DDEOINEGECJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x641C7E0", Offset = "0x641B1E0", VA = "0x18641C7E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x641DF60", Offset = "0x641C960", VA = "0x18641DF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 EGKOABIGCEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x641C0C0", Offset = "0x641AAC0", VA = "0x18641C0C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x641D860", Offset = "0x641C260", VA = "0x18641D860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 AMIMCOHFMAN
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x641B9D0", Offset = "0x641A3D0", VA = "0x18641B9D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x641D240", Offset = "0x641BC40", VA = "0x18641D240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 HHCGJCNNJDI
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x641BEA0", Offset = "0x641A8A0", VA = "0x18641BEA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x641D630", Offset = "0x641C030", VA = "0x18641D630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 KCOOHIHBBMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x641BD60", Offset = "0x641A760", VA = "0x18641BD60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x641D550", Offset = "0x641BF50", VA = "0x18641D550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Quaternion NKELJEENFBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x641BC80", Offset = "0x641A680", VA = "0x18641BC80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x641D470", Offset = "0x641BE70", VA = "0x18641D470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 JDACDKDMOFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x641CA80", Offset = "0x641B480", VA = "0x18641CA80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 HOJJNKBNCCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x641C9A0", Offset = "0x641B3A0", VA = "0x18641C9A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool OMHEKMNNLNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x641BE40", Offset = "0x641A840", VA = "0x18641BE40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool NNINDJDOIEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x641B580", Offset = "0x6419F80", VA = "0x18641B580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool AAPGKFBKDBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x641B4C0", Offset = "0x6419EC0", VA = "0x18641B4C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool AKLHDCGMDIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x641B460", Offset = "0x6419E60", VA = "0x18641B460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool PBKENEJPHOG
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x641B330", Offset = "0x6419D30", VA = "0x18641B330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool EEPBKGGLOCA
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x641BBD0", Offset = "0x641A5D0", VA = "0x18641BBD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool HNCHBAEIKCG
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x759580", Offset = "0x757F80", VA = "0x180759580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event EOIGEIAJIKF OFNJGIKAKPM
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x641B250", Offset = "0x6419C50", VA = "0x18641B250")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x641CE70", Offset = "0x641B870", VA = "0x18641CE70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event KHIJGEMJFAG CKIIKPLGOLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x641B1E0", Offset = "0x6419BE0", VA = "0x18641B1E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x641CE00", Offset = "0x641B800", VA = "0x18641CE00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event EOIGEIAJIKF EJLIAHAIONF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x641AF40", Offset = "0x6419940", VA = "0x18641AF40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x641CB60", Offset = "0x641B560", VA = "0x18641CB60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event EOIGEIAJIKF DIJMKGIEGED
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x641AFB0", Offset = "0x64199B0", VA = "0x18641AFB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x641CBD0", Offset = "0x641B5D0", VA = "0x18641CBD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event EOIGEIAJIKF DEAKDANAAGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x641B100", Offset = "0x6419B00", VA = "0x18641B100")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x641CD20", Offset = "0x641B720", VA = "0x18641CD20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<MDILDCKBKMK, MDILDCKBKMK> JMFOKJJIFJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x641B090", Offset = "0x6419A90", VA = "0x18641B090")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x641CCB0", Offset = "0x641B6B0", VA = "0x18641CCB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event EOIGEIAJIKF DLGCFHJHOHB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x641B170", Offset = "0x6419B70", VA = "0x18641B170")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x641CD90", Offset = "0x641B790", VA = "0x18641CD90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event EOIGEIAJIKF GLGFGKNEDEG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x641B2C0", Offset = "0x6419CC0", VA = "0x18641B2C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x641CEE0", Offset = "0x641B8E0", VA = "0x18641CEE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event EOIGEIAJIKF MHANNHKCODL
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x641B020", Offset = "0x6419A20", VA = "0x18641B020")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x641CC40", Offset = "0x641B640", VA = "0x18641CC40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6C2130", Offset = "0x6C0B30", VA = "0x1806C2130")]
		internal void LHPDDJAEGGL(FINELKBJAJC GCIFBDHGBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6418BD0", Offset = "0x64175D0", VA = "0x186418BD0")]
		internal void ALLJBGPPHJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x641AC90", Offset = "0x6419690", VA = "0x18641AC90")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody FNGKGEMFFOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x64195D0", Offset = "0x6417FD0", VA = "0x1864195D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6419E70", Offset = "0x6418870", VA = "0x186419E70")]
		private FINELKBJAJC HBDCCCAIEKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6419AE0", Offset = "0x64184E0", VA = "0x186419AE0")]
		private void HAKOKLHEDIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x641A1D0", Offset = "0x6418BD0", VA = "0x18641A1D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x641A160", Offset = "0x6418B60", VA = "0x18641A160")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6419880", Offset = "0x6418280", VA = "0x186419880")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x641A170", Offset = "0x6418B70", VA = "0x18641A170")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x641A230", Offset = "0x6418C30", VA = "0x18641A230")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6418C60", Offset = "0x6417660", VA = "0x186418C60")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x641A2A0", Offset = "0x6418CA0", VA = "0x18641A2A0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6419820", Offset = "0x6418220", VA = "0x186419820")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x641A100", Offset = "0x6418B00", VA = "0x18641A100")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x641AA90", Offset = "0x6419490", VA = "0x18641AA90")]
		public void SetParent(RigidbodyEx MNIAGKNOHEJ, bool GJNGLKLPECL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x641A5B0", Offset = "0x6418FB0", VA = "0x18641A5B0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6419F20", Offset = "0x6418920", VA = "0x186419F20")]
		public bool IsRigidbodyAncestor(RigidbodyEx EPCCEENAILA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6419F60", Offset = "0x6418960", VA = "0x186419F60")]
		public bool IsRigidbodyDescendant(RigidbodyEx ANNHMJEHEKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6418E80", Offset = "0x6417880", VA = "0x186418E80")]
		public void AddInterpolationRestriction(object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x641A310", Offset = "0x6418D10", VA = "0x18641A310")]
		public void RemoveInterpolationRestriction(object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6419640", Offset = "0x6418040", VA = "0x186419640")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6418EF0", Offset = "0x64178F0", VA = "0x186418EF0")]
		public void AddKinematic(object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x641A380", Offset = "0x6418D80", VA = "0x18641A380")]
		public void RemoveKinematic(object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x641AA10", Offset = "0x6419410", VA = "0x18641AA10")]
		public void SetKinematic(object DEGCIHEAIBD, bool MPIEKKDMKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x641A910", Offset = "0x6419310", VA = "0x18641A910")]
		public void SetDiscontinuousPositionAndRotation(Vector3 ICMDDAIKFFC, Quaternion EGLMODKINDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x641A810", Offset = "0x6419210", VA = "0x18641A810")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 NLDIPKCEGFI, Quaternion CPMNDBAPBHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x64199E0", Offset = "0x64183E0", VA = "0x1864199E0")]
		public Vector3 GetConstrainedVelocity(Vector3 DDEOINEGECJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x64198E0", Offset = "0x64182E0", VA = "0x1864198E0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 AMIMCOHFMAN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6418DF0", Offset = "0x64177F0", VA = "0x186418DF0")]
		public void AddForce(Vector3 GONNPACEKOP, ForceMode LLGEKNKAFEH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6418CD0", Offset = "0x64176D0", VA = "0x186418CD0")]
		public void AddForceAtPosition(Vector3 GONNPACEKOP, Vector3 OAALNDIAAOB, ForceMode LLGEKNKAFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6418FF0", Offset = "0x64179F0", VA = "0x186418FF0")]
		public void AddTorque(Vector3 ALEOGDBLBAL, ForceMode LLGEKNKAFEH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6418F60", Offset = "0x6417960", VA = "0x186418F60")]
		public void AddRelativeTorque(Vector3 ALEOGDBLBAL, ForceMode LLGEKNKAFEH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x641AD70", Offset = "0x6419770", VA = "0x18641AD70")]
		public Vector3 WorldToLocalVelocity(Vector3 KFMEEFJANFE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x641A000", Offset = "0x6418A00", VA = "0x18641A000")]
		public Vector3 LocalToWorldVelocity(Vector3 EGKOABIGCEJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x64197C0", Offset = "0x64181C0", VA = "0x1864197C0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6419760", Offset = "0x6418160", VA = "0x186419760")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6419700", Offset = "0x6418100", VA = "0x186419700")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x64196A0", Offset = "0x64180A0", VA = "0x1864196A0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x641A710", Offset = "0x6419110", VA = "0x18641A710")]
		public void ResetVelocityWorldSpace(Vector3 KNMAKDBFNDP, Vector3 JGIOFMHEJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x641A610", Offset = "0x6419010", VA = "0x18641A610")]
		public void ResetVelocityLocalSpace(Vector3 HAOHPFICBPO, Vector3 HHCGJCNNJDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x641A4D0", Offset = "0x6418ED0", VA = "0x18641A4D0")]
		public void ResetLinearVelocityLocalSpace(Vector3 HAOHPFICBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x641AB80", Offset = "0x6419580", VA = "0x18641AB80")]
		public bool SweepTest(Vector3 PANBGKEJNBF, out RaycastHit EKBEEAKLGKG, float OEPBPFIFMKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6419FA0", Offset = "0x64189A0", VA = "0x186419FA0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x641AB20", Offset = "0x6419520", VA = "0x18641AB20")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x641AD10", Offset = "0x6419710", VA = "0x18641AD10")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6419080", Offset = "0x6417A80", VA = "0x186419080")]
		public void AddUnityRigidbody(object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x641A3F0", Offset = "0x6418DF0", VA = "0x18641A3F0")]
		public void RemoveUnityRigidbody(object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x64193A0", Offset = "0x6417DA0", VA = "0x1864193A0")]
		public void ApplyForceVelocityChange(GFNIKGHNFMK NDCODNFDBDL, Vector3 BKCKHNNPBPN, float FDLFHFCEKLG, float BCPPBALBKDI = 8f, float HDGDBBFNACP = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x64192A0", Offset = "0x6417CA0", VA = "0x1864192A0")]
		public void ApplyAngularVelocityChange(BAPDLIMMIEJ DFBKFCMOCAB, Vector3 KHAIFHDNCAN, float DHGAEJJNMPB = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x64194C0", Offset = "0x6417EC0", VA = "0x1864194C0")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(BAPDLIMMIEJ DFBKFCMOCAB, Vector3 HOOCPOKGFMC, float NHJDIFFEONI = 7f, float MKKFGBEOHMB = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x64191E0", Offset = "0x6417BE0", VA = "0x1864191E0")]
		public bool AllowedScaleChange(float EGAHANLMNHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x64190F0", Offset = "0x6417AF0", VA = "0x1864190F0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx CDMJBEHHHDN, object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x641A460", Offset = "0x6418E60", VA = "0x18641A460")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object DEGCIHEAIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x641AEC0", Offset = "0x64198C0", VA = "0x18641AEC0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class MHDNMJCAOKJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5381F60", Offset = "0x5380960", VA = "0x185381F60")]
	public static FINELKBJAJC GCDBCKCLBIL(this RigidbodyEx MPLGHJJKMAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct GBAJKBMADFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Rigidbody NMAIJIEBGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PhotonView HGNNDDBGCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 PKFOLHABNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OverridableVector3 GPJCMEMKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public PFIAFKPIHKP JEFJOFCHGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool MCELILPBIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool LFKJEFBLPKE;
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[LOEOGANCBGC(EDPDLGMLNHJ.Physics)]
	[DNOPHNKOHLA(typeof(AHOEMGMJFLI), new string[] { })]
	public class RigidbodyExManager : AHOEMGMJFLI, MMKNGEFLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private CGCFBBFKDEL HHKHFGCMHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private NEHCJNCFCPO EDFOBNPNANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private PGDLJBLFBNG MINNPODDJOP;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool IBOMABLDHMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x64186A0", Offset = "0x64170A0", VA = "0x1864186A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public NEHCJNCFCPO KKDHBDCFHOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public PGDLJBLFBNG FKLIHIDKNHN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x64188B0", Offset = "0x64172B0", VA = "0x1864188B0", Slot = "12")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x64183D0", Offset = "0x6416DD0", VA = "0x1864183D0", Slot = "7")]
		public DFKOJFHJBPL CEEEHNBIEOP(RigidbodyEx MPLGHJJKMAH)
		{
			return default(DFKOJFHJBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x64186F0", Offset = "0x64170F0", VA = "0x1864186F0")]
		private static DFKOJFHJBPL FKDKDHBLMCM(RigidbodyEx MPLGHJJKMAH)
		{
			return default(DFKOJFHJBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x64182C0", Offset = "0x6416CC0", VA = "0x1864182C0", Slot = "8")]
		public FINELKBJAJC BHAAGIJHAHG(RigidbodyEx MPLGHJJKMAH, GBAJKBMADFI NIPBPKPBPPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x64187E0", Offset = "0x64171E0", VA = "0x1864187E0", Slot = "11")]
		private RigidbodyEx GDLJIFBPFMH(GameObject ICDBBFEMLLL, GBAJKBMADFI NIPBPKPBPPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6418940", Offset = "0x6417340", VA = "0x186418940", Slot = "9")]
		public void HPPHICKCNHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6418A30", Offset = "0x6417430", VA = "0x186418A30", Slot = "10")]
		public void MOCLBOHJAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static JCAAIAKPOCC UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int EENGJGAHLMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int FKCHCHEIFKH;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6417DA0", Offset = "0x64167A0", VA = "0x186417DA0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6417DE0", Offset = "0x64167E0", VA = "0x186417DE0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6417DC0", Offset = "0x64167C0", VA = "0x186417DC0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string EJEIJOMMNGK, [Optional] UnityEngine.Object CGFEOLDGFLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string EJEIJOMMNGK, [Optional] UnityEngine.Object CGFEOLDGFLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6417ED0", Offset = "0x64168D0", VA = "0x186417ED0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class CFDOFCKAFEG
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5362470", Offset = "0x5360E70", VA = "0x185362470")]
	public static void LBCLIAJNMKM(this Rigidbody FNGKGEMFFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x53625C0", Offset = "0x5360FC0", VA = "0x1853625C0")]
	public static void LBCLIAJNMKM(this Rigidbody FNGKGEMFFOG, Vector3 KCOOHIHBBMN, Quaternion NKELJEENFBH, Vector3 MGHIJOGNGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x53623A0", Offset = "0x5360DA0", VA = "0x1853623A0")]
	public static void JFACBEMHOMC(Vector3 DDEOINEGECJ, Vector3 PIELFIAEDGN, out Vector3 ODPKJKLJCNG, out Vector3 NOMLCLPLGMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CMLLCPINADO
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class AFBGMONBDCI : AAGBILKCEFJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1521670", Offset = "0x1520070", VA = "0x181521670", Slot = "4")]
		public Vector3 FNGKPAIKPDP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x1521670", Offset = "0x1520070", VA = "0x181521670", Slot = "5")]
		public Vector3 HPIGFNACKGG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public AFBGMONBDCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static AAGBILKCEFJ JPCHKMHINBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5363300", Offset = "0x5361D00", VA = "0x185363300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PBGEAABGDLG
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode HIONHKLMGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKHIMNHIOOI();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IANIKNPGJKE(bool OMHEKMNNLNE);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JCLABJGBIGH(bool OMHEKMNNLNE);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EEDPPAEHCMF(Rigidbody NMAIJIEBGIH);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MCCMDLKNBFC(Vector3 PANBGKEJNBF, out RaycastHit EKBEEAKLGKG, float OEPBPFIFMKK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LOHCPIFOKBA : IDisposable, GNMELKHCPEM
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	FHGIMEJNAKL BOHPADGHJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<MDILDCKBKMK, MDILDCKBKMK> JMFOKJJIFJJ;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AKHIMNHIOOI();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[AINPJLGDEKF(EIJAKMAIFNG.Application)]
public interface PGDLJBLFBNG
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ALDDLAJCNDJ KJLFNJLJKGO(FINELKBJAJC GCIFBDHGBMN);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HHEJEAPJBJM IJIONEIJDFG(FINELKBJAJC GCIFBDHGBMN);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NOHOJFFFHFH GGIMKEHLCFJ(FINELKBJAJC GCIFBDHGBMN);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DNGEAFOGJME NBFNLDDJHLF(FINELKBJAJC GCIFBDHGBMN);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CHNFBMHLJMH PHDCAMEIJBD(FINELKBJAJC GCIFBDHGBMN);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LOHCPIFOKBA KCKGECDIJAH(FINELKBJAJC GCIFBDHGBMN);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OBIFGANNEIA MOBIIGHHKNC(FINELKBJAJC GCIFBDHGBMN);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CEHLNMEGNHL GHEMBNKCOOB(FINELKBJAJC GCIFBDHGBMN);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PBGEAABGDLG LAGLKODAAHG(FINELKBJAJC GCIFBDHGBMN);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EFCHMGFPPNG DJDAINJJJMD(FINELKBJAJC GCIFBDHGBMN);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IPLCEEKLLAN HIFIDCFLLFP(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FOABFNIFJAA GLHDBOGCFCL(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DPLEFMDCHAK FGJEKHEKKKJ(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KBKJLCPHENA NJIHJIBLCFE(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JGIJDMAANMH JEOFLAOFKFI(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FINELKBJAJC BHAAGIJHAHG(RigidbodyEx MPLGHJJKMAH, GBAJKBMADFI NIPBPKPBPPP, AHOEMGMJFLI MPEBEBMNLLA);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CEHLNMEGNHL
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADHPHHGGPFO(Vector3 GONNPACEKOP, ForceMode LLGEKNKAFEH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKENGLILDKP(Vector3 GONNPACEKOP, Vector3 OAALNDIAAOB, ForceMode LLGEKNKAFEH);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ONFMLOBCLMC(Vector3 ALEOGDBLBAL, ForceMode LLGEKNKAFEH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BMOHKBFEDIO(Vector3 ALEOGDBLBAL, ForceMode LLGEKNKAFEH = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EFCHMGFPPNG
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool MNJCELLFCNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EEDPPAEHCMF(Rigidbody NMAIJIEBGIH);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MEBCMKNIKNA(Rigidbody NMAIJIEBGIH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ALDDLAJCNDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<FINELKBJAJC> DLHGIFABMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	FINELKBJAJC PMIOODBJODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	FINELKBJAJC NNHCCDNOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event EOIGEIAJIKF EJLIAHAIONF;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event EOIGEIAJIKF DIJMKGIEGED;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event KHIJGEMJFAG BHDKKEHCFIG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action IIBADDINJBN;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action IOECKPFCOLL;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<FINELKBJAJC> NKBAGBFAOPH;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<FINELKBJAJC> MKBNLFLFJHE;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action KGNALDKPAGK;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<FINELKBJAJC> PNKIOGHFIOB;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DGJAMCMEJGD(FINELKBJAJC DILGNCFGGHK, bool GJNGLKLPECL = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NOHOJFFFHFH
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 DLHOKPCNDHK
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 KHNHKEGICDO
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NPIEMEPDEKC(FINELKBJAJC ELGBIOMPEHN, object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FPCIKEFOMNG(object DEGCIHEAIBD);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface KBKJLCPHENA
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 IJDDNEDHONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 LDJDMCFGDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float LDIJJJKDKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float JOFKNAMFKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 BGAIPPJOAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion HCJFINDADJC
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event EOIGEIAJIKF IEDFEDNDNHC;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GCGKMMPELCF();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GMGCKIECDGK();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NPIFIBABAPM();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EEDPPAEHCMF(Rigidbody NMAIJIEBGIH);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MEBCMKNIKNA(Rigidbody NMAIJIEBGIH);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AJAEADGGIFO();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface DPLEFMDCHAK
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool JBMIBNPELKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	IHGNHGBDMIK OMDDDNFJDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKHIMNHIOOI();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JJHDJKEBOLP(object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CDMHBJANAKM(object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ILCODHFGIJP(FINELKBJAJC MPLGHJJKMAH);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BKELDDDHEDA(FINELKBJAJC MPLGHJJKMAH);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JJMJBENMNKK();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface OBIFGANNEIA
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool LLANJLNCMHP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	IEnumerable<object> HENALIPPCOD
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event EOIGEIAJIKF CPLFJIEMCBI;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CKHNMOAIKKF(object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AFOJJCPKDKC(object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NMBFJKGLMLM(object DEGCIHEAIBD, bool MPIEKKDMKID);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable EFJNJIADBJO();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EEDPPAEHCMF(Rigidbody NIGLNONICLM);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MEBCMKNIKNA(Rigidbody NMAIJIEBGIH);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface FOABFNIFJAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool BKLEDPDFLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool FBANMELJCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event EOIGEIAJIKF AKILOILIGPI;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AKHIMNHIOOI();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ELJFDCONCDI(FINELKBJAJC ELGBIOMPEHN);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JMJFGKIDBLA(FINELKBJAJC ELGBIOMPEHN);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JGIJDMAANMH
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool HJNDJLEEIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool BNIFPAGGLMF
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	RigidbodyConstraints JGJHMHEFNNB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EEDPPAEHCMF(Rigidbody NMAIJIEBGIH);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MEBCMKNIKNA(Rigidbody NMAIJIEBGIH);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DNGEAFOGJME
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float CBCHKHFNIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float BKOJANHELNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EEDPPAEHCMF(Rigidbody NMAIJIEBGIH);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MEBCMKNIKNA(Rigidbody NMAIJIEBGIH);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface KPHAAJODFJK
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx LNKJOHIOLCB);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CHNFBMHLJMH
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event EOIGEIAJIKF AOKABOPPDCE;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKHIMNHIOOI();

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KHIMNPKKOOI();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OPDMIIBMDPD();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MHHNJOOIKBA();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NHIMCHDCAII();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FADGJLPBHGH();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FHHCHNDGGHH(bool JKOMJKKMCJB);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface IPLCEEKLLAN
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Rigidbody NGHLLPGFILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKHIMNHIOOI();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HNKAHGBLMFG(object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BOKFPLECABM(object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EKMLDDLGAHD();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OEOFELGGEJN();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CJJBBLKMCFP();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HBCINAGAAFF();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface HHEJEAPJBJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	AAGBILKCEFJ HJMCHGKOFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	HPBKAAPNIDE JFIJDPHAPDK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 ABFNJJJIFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 DMDIOGFKLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	Vector3 EIFGBJCCKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Vector3 AEHCEPOJINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float GPJNEDFLKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool DADGANMPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AKHIMNHIOOI();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EDACDIJGMDM(object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EIOODGJPGNH(BAPDLIMMIEJ DFBKFCMOCAB, Vector3 KHAIFHDNCAN, float DHGAEJJNMPB = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MAFJLECBAJB(GFNIKGHNFMK NDCODNFDBDL, Vector3 BKCKHNNPBPN, float FDLFHFCEKLG, float BCPPBALBKDI = 8f, float HDGDBBFNACP = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MJJKJNEOFFA(BAPDLIMMIEJ DFBKFCMOCAB, Vector3 HOOCPOKGFMC, float NHJDIFFEONI = 7f, float MKKFGBEOHMB = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NHIOLLFNDEO();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HOCINLNMKAN();

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void BCGKFGHJEGE();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void LIJHHFDNMII();

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void EEDPPAEHCMF(Rigidbody NMAIJIEBGIH);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 MKMPALOPNCI(Vector3 AMIMCOHFMAN);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 BMOCCKOACNL(Vector3 DDEOINEGECJ);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MHHGHPEHPOJ(object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IGKKCOIIJPE(Vector3 LBJDLPFBLAD);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DGDDFJLDGHA(Vector3 HAOHPFICBPO, Vector3 HHCGJCNNJDI);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void ODBDKBKNKKH(Vector3 KNMAKDBFNDP, Vector3 JGIOFMHEJDJ);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 CFNAJGAOBEF(Vector3 EGKOABIGCEJ);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 ONCHFGBOPNN(Vector3 KFMEEFJANFE);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[AINPJLGDEKF(EIJAKMAIFNG.Application)]
public interface NEHCJNCFCPO
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool OGLDALHHNHP
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIEDDEJLAOG(string IMHLNJJFNDD);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FPOIDDFFOHJ(RigidbodyEx MPLGHJJKMAH, Action CKAPOBIDCEI);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JPCNLOFKBAB PGKBIHACAOO(int FEJNIGEMPJI);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FFFGMGBGFFB(Vector3 GGMMBNPEDOM, float NOHFBAMFKJE, Color HAAENNGJIPE);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[AINPJLGDEKF(EIJAKMAIFNG.Application)]
public interface AHOEMGMJFLI
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	NEHCJNCFCPO KKDHBDCFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	PGDLJBLFBNG FKLIHIDKNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool IBOMABLDHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DFKOJFHJBPL CEEEHNBIEOP(RigidbodyEx MPLGHJJKMAH);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FINELKBJAJC BHAAGIJHAHG(RigidbodyEx MPLGHJJKMAH, GBAJKBMADFI NIPBPKPBPPP);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HPPHICKCNHJ();

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MOCLBOHJAPO();

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal RigidbodyEx AKEFKPBEGPB(GameObject ICDBBFEMLLL, [Optional] GBAJKBMADFI NIPBPKPBPPP);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HPBKAAPNIDE
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NIHILGBOBIE(Vector3 NGKJLDPJCGG);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EJOFIKNOGMA(Vector3 AMIMCOHFMAN);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JAJDGIOLKCB(Vector3 NGKJLDPJCGG);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CFGNEKMPDGC(Vector3 AMIMCOHFMAN);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface AAGBILKCEFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 FNGKPAIKPDP();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 HPIGFNACKGG();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface FINELKBJAJC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Rigidbody NGHLLPGFILB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	RigidbodyEx HIPLOELIEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	GameObject AKKLNJDLHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Transform ONMPEEDNICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IEnumerable<object> BGPPMHHGDDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	FINELKBJAJC NNHCCDNOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	IReadOnlyList<FINELKBJAJC> DLHGIFABMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	FINELKBJAJC PMIOODBJODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool GOECHKKAMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool BKLEDPDFLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool FBANMELJCLP
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	AAGBILKCEFJ HJMCHGKOFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	HPBKAAPNIDE JFIJDPHAPDK
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	float GPJNEDFLKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 DMDIOGFKLBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 AEHCEPOJINK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 ABFNJJJIFJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 EIFGBJCCKOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool AAPGKFBKDBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool AKLHDCGMDIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool PBKENEJPHOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool DADGANMPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 DLHOKPCNDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 KHNHKEGICDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 IJDDNEDHONI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 LDJDMCFGDHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float LDIJJJKDKPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float JOFKNAMFKBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 BGAIPPJOAJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Quaternion HCJFINDADJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float CBCHKHFNIJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float BKOJANHELNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool MNJCELLFCNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "47")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	FHGIMEJNAKL BOHPADGHJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool LLANJLNCMHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Transform HOCKJBJNDGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Transform CEGIGFGJCJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 NJJBCKOHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float LMOFGOGBHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float DEOPFAEIOAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "58")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion KKEIEPMJOAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "60")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 IOJJLJDINFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Quaternion MBFBKKLCOFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "64")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	RigidbodyConstraints JGJHMHEFNNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "66")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool HJNDJLEEIDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CollisionDetectionMode HIONHKLMGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "70")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool NNINDJDOIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event EOIGEIAJIKF EJLIAHAIONF;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event EOIGEIAJIKF DIJMKGIEGED;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event KHIJGEMJFAG BHDKKEHCFIG;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event EOIGEIAJIKF AKILOILIGPI;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event EOIGEIAJIKF DEAKDANAAGM;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event EOIGEIAJIKF AOKABOPPDCE;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<MDILDCKBKMK, MDILDCKBKMK> JMFOKJJIFJJ;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event EOIGEIAJIKF LAADJFDFHAK;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event EOIGEIAJIKF MHANNHKCODL;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void AKHIMNHIOOI();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void DDAAOLGKOKM();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void ELEGAIPDPPJ();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void MHHNJOOIKBA();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void NKDDKEPLNOK();

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void DGJAMCMEJGD(FINELKBJAJC MNIAGKNOHEJ, bool GJNGLKLPECL = false);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void DOLHIOPLDNE(object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void NKHMCPFJJCB(object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 ONCHFGBOPNN(Vector3 KFMEEFJANFE);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "89")]
	Vector3 CFNAJGAOBEF(Vector3 EGKOABIGCEJ);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void LIJHHFDNMII();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void HOCINLNMKAN();

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void NHIOLLFNDEO();

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void ODBDKBKNKKH(Vector3 KNMAKDBFNDP, Vector3 JGIOFMHEJDJ);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void DGDDFJLDGHA(Vector3 HAOHPFICBPO, Vector3 HHCGJCNNJDI);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void IGKKCOIIJPE(Vector3 LBJDLPFBLAD);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void MAFJLECBAJB(GFNIKGHNFMK NDCODNFDBDL, Vector3 BKCKHNNPBPN, float FDLFHFCEKLG, float BCPPBALBKDI = 8f, float HDGDBBFNACP = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void EIOODGJPGNH(BAPDLIMMIEJ DFBKFCMOCAB, Vector3 KHAIFHDNCAN, float DHGAEJJNMPB = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void MJJKJNEOFFA(BAPDLIMMIEJ DFBKFCMOCAB, Vector3 HOOCPOKGFMC, float NHJDIFFEONI = 7f, float MKKFGBEOHMB = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 BMOCCKOACNL(Vector3 MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "100")]
	Vector3 MKMPALOPNCI(Vector3 MNIAGKNOHEJ);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void BCGKFGHJEGE();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void IANGFPPNEMN(FINELKBJAJC CDMJBEHHHDN, object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void HMJNHJHPEHP(object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void GMGCKIECDGK();

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void GCGKMMPELCF();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void NPIFIBABAPM();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "111")]
	bool KHIMNPKKOOI();

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void FADGJLPBHGH();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "117")]
	IDisposable EFJNJIADBJO();

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void CKHNMOAIKKF(object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void AFOJJCPKDKC(object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void NMBFJKGLMLM(object DEGCIHEAIBD, bool MPIEKKDMKID);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void FKLDPKCKKEP(Vector3 ICMDDAIKFFC, Quaternion EGLMODKINDN);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void IGOFKBBDCFJ(Vector3 NLDIPKCEGFI, Quaternion CPMNDBAPBHO);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "125")]
	bool IEHLOGIJCPN(float EGAHANLMNHJ);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void AEMGDJNANKB(object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void DIMBLJKMCFE(object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void HNKAHGBLMFG(object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void BOKFPLECABM(object DEGCIHEAIBD);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void ADHPHHGGPFO(Vector3 GONNPACEKOP, ForceMode LLGEKNKAFEH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void AKENGLILDKP(Vector3 GONNPACEKOP, Vector3 OAALNDIAAOB, ForceMode LLGEKNKAFEH);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void ONFMLOBCLMC(Vector3 ALEOGDBLBAL, ForceMode LLGEKNKAFEH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void BMOHKBFEDIO(Vector3 ALEOGDBLBAL, ForceMode LLGEKNKAFEH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool MCCMDLKNBFC(Vector3 PANBGKEJNBF, out RaycastHit EKBEEAKLGKG, float OEPBPFIFMKK);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void AJAEADGGIFO();

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class EMAOEODIEEA : FINELKBJAJC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly AHOEMGMJFLI MPEBEBMNLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal ALDDLAJCNDJ HKHMGAMGNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal DPLEFMDCHAK KJPNCEOIHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal FOABFNIFJAA JFLLPKLIMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal HHEJEAPJBJM DDEOINEGECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal NOHOJFFFHFH LMAGGBBKOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal KBKJLCPHENA MMPBDHBAOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal DNGEAFOGJME FKCHFOIOPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal EFCHMGFPPNG OOONGLELKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal CHNFBMHLJMH OAOPBKPEENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal LOHCPIFOKBA ELJEGLKOLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal OBIFGANNEIA DMDBOGPAPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal CEHLNMEGNHL GONNPACEKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal JGIJDMAANMH KMJALHLBFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal IPLCEEKLLAN NMAIJIEBGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal PBGEAABGDLG KKFGFFBAGFE;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public RigidbodyEx HIPLOELIEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E20", Offset = "0x6C6820", VA = "0x1806C7E20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x840610", Offset = "0x83F010", VA = "0x180840610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GameObject AKKLNJDLHMN
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6FD6A0", Offset = "0x6FC0A0", VA = "0x1806FD6A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8CB4D0", Offset = "0x8C9ED0", VA = "0x1808CB4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Transform ONMPEEDNICF
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x536ABD0", Offset = "0x53695D0", VA = "0x18536ABD0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEnumerable<object> BGPPMHHGDDM
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x536AEF0", Offset = "0x53698F0", VA = "0x18536AEF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Rigidbody NGHLLPGFILB
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x5369D90", Offset = "0x5368790", VA = "0x185369D90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public FINELKBJAJC NNHCCDNOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x536CED0", Offset = "0x536B8D0", VA = "0x18536CED0", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x536A490", Offset = "0x5368E90", VA = "0x18536A490", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public IReadOnlyList<FINELKBJAJC> DLHGIFABMAA
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5369C10", Offset = "0x5368610", VA = "0x185369C10", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public FINELKBJAJC PMIOODBJODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x536B600", Offset = "0x536A000", VA = "0x18536B600", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool GOECHKKAMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x536BC20", Offset = "0x536A620", VA = "0x18536BC20", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool BKLEDPDFLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5367FD0", Offset = "0x53669D0", VA = "0x185367FD0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool FBANMELJCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x536A2C0", Offset = "0x5368CC0", VA = "0x18536A2C0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public AAGBILKCEFJ HJMCHGKOFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x5368C20", Offset = "0x5367620", VA = "0x185368C20", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x536C060", Offset = "0x536AA60", VA = "0x18536C060", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public HPBKAAPNIDE JFIJDPHAPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x5368900", Offset = "0x5367300", VA = "0x185368900", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x536DC50", Offset = "0x536C650", VA = "0x18536DC50", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public float GPJNEDFLKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x536A440", Offset = "0x5368E40", VA = "0x18536A440", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x536CA80", Offset = "0x536B480", VA = "0x18536CA80", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 DMDIOGFKLBB
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5369950", Offset = "0x5368350", VA = "0x185369950", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x536AAA0", Offset = "0x53694A0", VA = "0x18536AAA0", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 AEHCEPOJINK
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x536A9D0", Offset = "0x53693D0", VA = "0x18536A9D0", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x536DB80", Offset = "0x536C580", VA = "0x18536DB80", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 ABFNJJJIFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x536CAE0", Offset = "0x536B4E0", VA = "0x18536CAE0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x536BA50", Offset = "0x536A450", VA = "0x18536BA50", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 EIFGBJCCKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5368F20", Offset = "0x5367920", VA = "0x185368F20", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5367F00", Offset = "0x5366900", VA = "0x185367F00", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool AAPGKFBKDBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x536BA00", Offset = "0x536A400", VA = "0x18536BA00", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool AKLHDCGMDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x536BD60", Offset = "0x536A760", VA = "0x18536BD60", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool PBKENEJPHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x536C0C0", Offset = "0x536AAC0", VA = "0x18536C0C0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool DADGANMPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x5367E30", Offset = "0x5366830", VA = "0x185367E30", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Vector3 DLHOKPCNDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x5369390", Offset = "0x5367D90", VA = "0x185369390", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 KHNHKEGICDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x536AD10", Offset = "0x5369710", VA = "0x18536AD10", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Vector3 IJDDNEDHONI
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x536A1F0", Offset = "0x5368BF0", VA = "0x18536A1F0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x536A4F0", Offset = "0x5368EF0", VA = "0x18536A4F0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 LDJDMCFGDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x5369B40", Offset = "0x5368540", VA = "0x185369B40", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float LDIJJJKDKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x5369F10", Offset = "0x5368910", VA = "0x185369F10", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float JOFKNAMFKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x536B510", Offset = "0x5369F10", VA = "0x18536B510", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x5368080", Offset = "0x5366A80", VA = "0x185368080", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Vector3 BGAIPPJOAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x536D280", Offset = "0x536BC80", VA = "0x18536D280", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5369E40", Offset = "0x5368840", VA = "0x185369E40", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion HCJFINDADJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x536B920", Offset = "0x536A320", VA = "0x18536B920", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x53687D0", Offset = "0x53671D0", VA = "0x1853687D0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float CBCHKHFNIJP
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x536BE10", Offset = "0x536A810", VA = "0x18536BE10", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x536A0B0", Offset = "0x5368AB0", VA = "0x18536A0B0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public float BKOJANHELNK
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x536CBB0", Offset = "0x536B5B0", VA = "0x18536CBB0", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x536C200", Offset = "0x536AC00", VA = "0x18536C200", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool MNJCELLFCNG
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x536BDC0", Offset = "0x536A7C0", VA = "0x18536BDC0", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x536B2E0", Offset = "0x5369CE0", VA = "0x18536B2E0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public FHGIMEJNAKL BOHPADGHJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x536BB20", Offset = "0x536A520", VA = "0x18536BB20", Slot = "52")]
		get
		{
			return default(FHGIMEJNAKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x5369A80", Offset = "0x5368480", VA = "0x185369A80", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool LLANJLNCMHP
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x536A8E0", Offset = "0x53692E0", VA = "0x18536A8E0", Slot = "54")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Transform HOCKJBJNDGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x536B9F0", Offset = "0x536A3F0", VA = "0x18536B9F0", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public Transform CEGIGFGJCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x536B9F0", Offset = "0x536A3F0", VA = "0x18536B9F0", Slot = "56")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Vector3 NJJBCKOHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x5369520", Offset = "0x5367F20", VA = "0x185369520", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x536BB70", Offset = "0x536A570", VA = "0x18536BB70", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public float LMOFGOGBHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x536AB70", Offset = "0x5369570", VA = "0x18536AB70", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x536B410", Offset = "0x5369E10", VA = "0x18536B410", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public float DEOPFAEIOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x5368770", Offset = "0x5367170", VA = "0x185368770", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x536D0D0", Offset = "0x536BAD0", VA = "0x18536D0D0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Quaternion KKEIEPMJOAP
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x536AC60", Offset = "0x5369660", VA = "0x18536AC60", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x536A3B0", Offset = "0x5368DB0", VA = "0x18536A3B0", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 IOJJLJDINFL
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x536BEC0", Offset = "0x536A8C0", VA = "0x18536BEC0", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x536CC00", Offset = "0x536B600", VA = "0x18536CC00", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Quaternion MBFBKKLCOFG
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x5368D90", Offset = "0x5367790", VA = "0x185368D90", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5368A70", Offset = "0x5367470", VA = "0x185368A70", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public RigidbodyConstraints JGJHMHEFNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x536A360", Offset = "0x5368D60", VA = "0x18536A360", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x536BF60", Offset = "0x536A960", VA = "0x18536BF60", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool HJNDJLEEIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x536B650", Offset = "0x536A050", VA = "0x18536B650", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5369460", Offset = "0x5367E60", VA = "0x185369460", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CollisionDetectionMode HIONHKLMGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x536A980", Offset = "0x5369380", VA = "0x18536A980", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x5369620", Offset = "0x5368020", VA = "0x185369620", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool NNINDJDOIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x536DCB0", Offset = "0x536C6B0", VA = "0x18536DCB0", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event EOIGEIAJIKF EJLIAHAIONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5368470", Offset = "0x5366E70", VA = "0x185368470", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x53688A0", Offset = "0x53672A0", VA = "0x1853688A0", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event EOIGEIAJIKF DIJMKGIEGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5368CD0", Offset = "0x53676D0", VA = "0x185368CD0", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x536C1A0", Offset = "0x536ABA0", VA = "0x18536C1A0", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event KHIJGEMJFAG BHDKKEHCFIG
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x536D630", Offset = "0x536C030", VA = "0x18536D630", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x536C530", Offset = "0x536AF30", VA = "0x18536C530", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event EOIGEIAJIKF AKILOILIGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x536AE30", Offset = "0x5369830", VA = "0x18536AE30", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x536CF80", Offset = "0x536B980", VA = "0x18536CF80", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event EOIGEIAJIKF DEAKDANAAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x536CE20", Offset = "0x536B820", VA = "0x18536CE20", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x536AE90", Offset = "0x5369890", VA = "0x18536AE90", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event EOIGEIAJIKF AOKABOPPDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x536CF20", Offset = "0x536B920", VA = "0x18536CF20", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5369DE0", Offset = "0x53687E0", VA = "0x185369DE0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<MDILDCKBKMK, MDILDCKBKMK> JMFOKJJIFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x536B170", Offset = "0x5369B70", VA = "0x18536B170", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x5368EC0", Offset = "0x53678C0", VA = "0x185368EC0", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event EOIGEIAJIKF LAADJFDFHAK
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x5368D30", Offset = "0x5367730", VA = "0x185368D30", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x536BE60", Offset = "0x536A860", VA = "0x18536BE60", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event EOIGEIAJIKF MHANNHKCODL
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x536D690", Offset = "0x536C090", VA = "0x18536D690", Slot = "125")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x536BFC0", Offset = "0x536A9C0", VA = "0x18536BFC0", Slot = "126")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x536DE30", Offset = "0x536C830", VA = "0x18536DE30")]
	public EMAOEODIEEA(GameObject KEHOIMKGHCH, RigidbodyEx MIEKGEIPEKE, AHOEMGMJFLI MPEBEBMNLLA, in GBAJKBMADFI NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x536D8A0", Offset = "0x536C2A0", VA = "0x18536D8A0", Slot = "142")]
	protected virtual void PFEGDELMDIC(AHOEMGMJFLI MPEBEBMNLLA, GBAJKBMADFI NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5369CC0", Offset = "0x53686C0", VA = "0x185369CC0", Slot = "143")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5368630", Offset = "0x5367030", VA = "0x185368630", Slot = "76")]
	public void AKHIMNHIOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x53695D0", Offset = "0x5367FD0", VA = "0x1853695D0", Slot = "77")]
	public void DDAAOLGKOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x1018630", Offset = "0x1017030", VA = "0x181018630", Slot = "78")]
	public void ELEGAIPDPPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x536CCA0", Offset = "0x536B6A0", VA = "0x18536CCA0", Slot = "144")]
	public virtual void NKDDKEPLNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x53698E0", Offset = "0x53682E0", VA = "0x1853698E0", Slot = "87")]
	public void DGJAMCMEJGD(FINELKBJAJC MNIAGKNOHEJ, bool GJNGLKLPECL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5369C60", Offset = "0x5368660", VA = "0x185369C60", Slot = "90")]
	public void DOLHIOPLDNE(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x536CD50", Offset = "0x536B750", VA = "0x18536CD50", Slot = "91")]
	public void NKHMCPFJJCB(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x536D730", Offset = "0x536C130", VA = "0x18536D730", Slot = "92")]
	public Vector3 ONCHFGBOPNN(Vector3 KFMEEFJANFE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x5368DD0", Offset = "0x53677D0", VA = "0x185368DD0", Slot = "93")]
	public Vector3 CFNAJGAOBEF(Vector3 EGKOABIGCEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x53695D0", Offset = "0x5367FD0", VA = "0x1853695D0", Slot = "94")]
	public void LIJHHFDNMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x536B290", Offset = "0x5369C90", VA = "0x18536B290", Slot = "95")]
	public void HOCINLNMKAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x536CC50", Offset = "0x536B650", VA = "0x18536CC50", Slot = "96")]
	public void NHIOLLFNDEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x536CFE0", Offset = "0x536B9E0", VA = "0x18536CFE0", Slot = "97")]
	public void ODBDKBKNKKH(Vector3 KNMAKDBFNDP, Vector3 JGIOFMHEJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x5369680", Offset = "0x5368080", VA = "0x185369680", Slot = "98")]
	public void DGDDFJLDGHA(Vector3 HAOHPFICBPO, Vector3 HHCGJCNNJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x536B6A0", Offset = "0x536A0A0", VA = "0x18536B6A0", Slot = "99")]
	public void IGKKCOIIJPE(Vector3 LBJDLPFBLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x536C310", Offset = "0x536AD10", VA = "0x18536C310", Slot = "100")]
	public void MAFJLECBAJB(GFNIKGHNFMK NDCODNFDBDL, Vector3 BKCKHNNPBPN, float FDLFHFCEKLG, float BCPPBALBKDI = 8f, float HDGDBBFNACP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x5369FB0", Offset = "0x53689B0", VA = "0x185369FB0", Slot = "101")]
	public void EIOODGJPGNH(BAPDLIMMIEJ DFBKFCMOCAB, Vector3 KHAIFHDNCAN, float DHGAEJJNMPB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x536C7D0", Offset = "0x536B1D0", VA = "0x18536C7D0", Slot = "102")]
	[Obsolete]
	public void MJJKJNEOFFA(BAPDLIMMIEJ DFBKFCMOCAB, Vector3 HOOCPOKGFMC, float NHJDIFFEONI = 7f, float MKKFGBEOHMB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x5368AB0", Offset = "0x53674B0", VA = "0x185368AB0", Slot = "103")]
	public Vector3 BMOCCKOACNL(Vector3 MNIAGKNOHEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x536C8E0", Offset = "0x536B2E0", VA = "0x18536C8E0", Slot = "104")]
	public Vector3 MKMPALOPNCI(Vector3 MNIAGKNOHEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x5368950", Offset = "0x5367350", VA = "0x185368950", Slot = "105")]
	public void BCGKFGHJEGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x536B340", Offset = "0x5369D40", VA = "0x18536B340", Slot = "106")]
	public void IANGFPPNEMN(FINELKBJAJC CDMJBEHHHDN, object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x536B1D0", Offset = "0x5369BD0", VA = "0x18536B1D0", Slot = "107")]
	public void HMJNHJHPEHP(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x536ADE0", Offset = "0x53697E0", VA = "0x18536ADE0", Slot = "110")]
	public void GMGCKIECDGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x536A930", Offset = "0x5369330", VA = "0x18536A930", Slot = "111")]
	public void GCGKMMPELCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x536CE80", Offset = "0x536B880", VA = "0x18536CE80", Slot = "112")]
	public void NPIFIBABAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x536BF10", Offset = "0x536A910", VA = "0x18536BF10", Slot = "115")]
	public bool KHIMNPKKOOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x536C780", Offset = "0x536B180", VA = "0x18536C780", Slot = "79")]
	public void MHHNJOOIKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x536A310", Offset = "0x5368D10", VA = "0x18536A310", Slot = "116")]
	public void FADGJLPBHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5369F60", Offset = "0x5368960", VA = "0x185369F60", Slot = "121")]
	public IDisposable EFJNJIADBJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x53694C0", Offset = "0x5367EC0", VA = "0x1853694C0", Slot = "122")]
	public void CKHNMOAIKKF(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x53680E0", Offset = "0x5366AE0", VA = "0x1853680E0", Slot = "123")]
	public void AFOJJCPKDKC(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x536CDB0", Offset = "0x536B7B0", VA = "0x18536CDB0", Slot = "124")]
	public void NMBFJKGLMLM(object DEGCIHEAIBD, bool MPIEKKDMKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x536A5C0", Offset = "0x5368FC0", VA = "0x18536A5C0", Slot = "127")]
	public void FKLDPKCKKEP(Vector3 ICMDDAIKFFC, Quaternion EGLMODKINDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x536B770", Offset = "0x536A170", VA = "0x18536B770", Slot = "128")]
	public void IGOFKBBDCFJ(Vector3 NLDIPKCEGFI, Quaternion CPMNDBAPBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x536B560", Offset = "0x5369F60", VA = "0x18536B560", Slot = "129")]
	public bool IEHLOGIJCPN(float EGAHANLMNHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x5368020", Offset = "0x5366A20", VA = "0x185368020", Slot = "130")]
	public void AEMGDJNANKB(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x5369A20", Offset = "0x5368420", VA = "0x185369A20", Slot = "131")]
	public void DIMBLJKMCFE(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x536B230", Offset = "0x5369C30", VA = "0x18536B230", Slot = "132")]
	public void HNKAHGBLMFG(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x5368C70", Offset = "0x5367670", VA = "0x185368C70", Slot = "133")]
	public void BOKFPLECABM(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5367E80", Offset = "0x5366880", VA = "0x185367E80", Slot = "134")]
	public void ADHPHHGGPFO(Vector3 GONNPACEKOP, ForceMode LLGEKNKAFEH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5368520", Offset = "0x5366F20", VA = "0x185368520", Slot = "135")]
	public void AKENGLILDKP(Vector3 GONNPACEKOP, Vector3 OAALNDIAAOB, ForceMode LLGEKNKAFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x536D820", Offset = "0x536C220", VA = "0x18536D820", Slot = "136")]
	public void ONFMLOBCLMC(Vector3 ALEOGDBLBAL, ForceMode LLGEKNKAFEH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5368BA0", Offset = "0x53675A0", VA = "0x185368BA0", Slot = "137")]
	public void BMOHKBFEDIO(Vector3 ALEOGDBLBAL, ForceMode LLGEKNKAFEH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x536C430", Offset = "0x536AE30", VA = "0x18536C430", Slot = "138")]
	public bool MCCMDLKNBFC(Vector3 PANBGKEJNBF, out RaycastHit EKBEEAKLGKG, float OEPBPFIFMKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x53684D0", Offset = "0x5366ED0", VA = "0x1853684D0", Slot = "139")]
	public void AJAEADGGIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x536DDF0", Offset = "0x536C7F0", VA = "0x18536DDF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x53689A0", Offset = "0x53673A0", VA = "0x1853689A0")]
	private void BCMJCHKFJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x536A7D0", Offset = "0x53691D0", VA = "0x18536A7D0")]
	private void FMNGDKKKOON(FINELKBJAJC ELGBIOMPEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x536C590", Offset = "0x536AF90", VA = "0x18536C590")]
	private void MHDLENNHGBH(FINELKBJAJC ELGBIOMPEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x536C260", Offset = "0x536AC60", VA = "0x18536C260")]
	private void LKNDKAGKHEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x536B070", Offset = "0x5369A70", VA = "0x18536B070")]
	private void HGJPLCBIOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x536C9D0", Offset = "0x536B3D0", VA = "0x18536C9D0")]
	private void MMAEGGPIMDN(FINELKBJAJC MCCGBMECIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x536A110", Offset = "0x5368B10", VA = "0x18536A110")]
	private void ELJFDCONCDI(FINELKBJAJC ELGBIOMPEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x536BC80", Offset = "0x536A680", VA = "0x18536BC80")]
	private void JMJFGKIDBLA(FINELKBJAJC ELGBIOMPEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x5369770", Offset = "0x5368170", VA = "0x185369770")]
	private void DGDFKADNKAD(RigidbodyEx ELGBIOMPEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x5368FF0", Offset = "0x53679F0", VA = "0x185368FF0")]
	private void CHKAAOOAKOA(RigidbodyEx MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x536AF40", Offset = "0x5369940", VA = "0x18536AF40")]
	[Conditional("UNITY_EDITOR")]
	private void HDIDMBOBEAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x536D350", Offset = "0x536BD50", VA = "0x18536D350")]
	protected void OJAHIFKCBOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5368140", Offset = "0x5366B40", VA = "0x185368140")]
	protected void AHAINAGBOBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class LACEHLCBNNE
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x537B720", Offset = "0x537A120", VA = "0x18537B720")]
	public static FINELKBJAJC OBHFEPGDGOE(this FINELKBJAJC MPLGHJJKMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x537B560", Offset = "0x5379F60", VA = "0x18537B560")]
	public static bool EKKJABKFKFE(this FINELKBJAJC MPLGHJJKMAH, FINELKBJAJC EPCCEENAILA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x537B650", Offset = "0x537A050", VA = "0x18537B650")]
	public static bool HFDIINGLLDM(this FINELKBJAJC MPLGHJJKMAH, FINELKBJAJC ANNHMJEHEKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x537B6D0", Offset = "0x537A0D0", VA = "0x18537B6D0")]
	public static RigidbodyEx HIPLOELIEMG(this FINELKBJAJC GCDBCKCLBIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x537B5E0", Offset = "0x5379FE0", VA = "0x18537B5E0")]
	public static EMAOEODIEEA FALDFIDNJDA(this FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class NGLECOCGOJK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly EMAOEODIEEA MPLGHJJKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool DHFBGINHBOF;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x53862A0", Offset = "0x5384CA0", VA = "0x1853862A0")]
	public NGLECOCGOJK(EMAOEODIEEA CBKOMEMMCDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5386240", Offset = "0x5384C40", VA = "0x185386240", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class BEMJCDMFEDK : JAFLICKPOKP, PBGEAABGDLG
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CollisionDetectionMode GPEGOMOLEMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x5361CB0", Offset = "0x53606B0", VA = "0x185361CB0")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x5362230", Offset = "0x5360C30", VA = "0x185362230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody NGHLLPGFILB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x5360940", Offset = "0x535F340", VA = "0x185360940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CollisionDetectionMode HIONHKLMGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5361D90", Offset = "0x5360790", VA = "0x185361D90", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5361BA0", Offset = "0x53605A0", VA = "0x185361BA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5362320", Offset = "0x5360D20", VA = "0x185362320")]
	public BEMJCDMFEDK(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5361A90", Offset = "0x5360490", VA = "0x185361A90", Slot = "6")]
	public void AKHIMNHIOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x5361C20", Offset = "0x5360620", VA = "0x185361C20", Slot = "9")]
	public void EEDPPAEHCMF(Rigidbody NMAIJIEBGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x5361EA0", Offset = "0x53608A0", VA = "0x185361EA0", Slot = "7")]
	public void IANIKNPGJKE(bool OMHEKMNNLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x5361EB0", Offset = "0x53608B0", VA = "0x185361EB0", Slot = "8")]
	public void JCLABJGBIGH(bool OMHEKMNNLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x53620C0", Offset = "0x5360AC0", VA = "0x1853620C0", Slot = "10")]
	public bool MCCMDLKNBFC(Vector3 PANBGKEJNBF, out RaycastHit EKBEEAKLGKG, float OEPBPFIFMKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5361EC0", Offset = "0x53608C0", VA = "0x185361EC0")]
	private void MBBPPFCCNJD(bool OMHEKMNNLNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class KIIMFPFNBDC : JAFLICKPOKP, LOHCPIFOKBA, IDisposable, GNMELKHCPEM
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public FHGIMEJNAKL FNMCFJMCLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x537B3A0", Offset = "0x5379DA0", VA = "0x18537B3A0")]
		get
		{
			return default(FHGIMEJNAKL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x537AFF0", Offset = "0x53799F0", VA = "0x18537AFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public FHGIMEJNAKL BOHPADGHJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x537B180", Offset = "0x5379B80", VA = "0x18537B180", Slot = "6")]
		get
		{
			return default(FHGIMEJNAKL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x537AFF0", Offset = "0x53799F0", VA = "0x18537AFF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private Transform PECHNIMJGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<MDILDCKBKMK, MDILDCKBKMK> JMFOKJJIFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x537B0E0", Offset = "0x5379AE0", VA = "0x18537B0E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x537AF50", Offset = "0x5379950", VA = "0x18537AF50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5362320", Offset = "0x5360D20", VA = "0x185362320")]
	public KIIMFPFNBDC(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x537B480", Offset = "0x5379E80", VA = "0x18537B480", Slot = "11")]
	public void OnChangedDistanceBand(MDILDCKBKMK HKLCHIBFNAM, MDILDCKBKMK APGCALANEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "12")]
	public void OnChangedVisibility(bool BCEBIPIOINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "8")]
	public void AKHIMNHIOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class OAJKNPKGAHB : JAFLICKPOKP, CEHLNMEGNHL
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private Rigidbody NGHLLPGFILB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x5360940", Offset = "0x535F340", VA = "0x185360940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool LLANJLNCMHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x536F640", Offset = "0x536E040", VA = "0x18536F640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private bool GOECHKKAMDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x536F690", Offset = "0x536E090", VA = "0x18536F690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private FINELKBJAJC NNHCCDNOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x53893F0", Offset = "0x5387DF0", VA = "0x1853893F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5362320", Offset = "0x5360D20", VA = "0x185362320")]
	public OAJKNPKGAHB(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5388AF0", Offset = "0x53874F0", VA = "0x185388AF0", Slot = "4")]
	public void ADHPHHGGPFO(Vector3 GONNPACEKOP, ForceMode LLGEKNKAFEH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5389450", Offset = "0x5387E50", VA = "0x185389450")]
	private void OHIJGALCACK(Vector3 GONNPACEKOP, ForceMode LLGEKNKAFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5388ED0", Offset = "0x53878D0", VA = "0x185388ED0", Slot = "5")]
	public void AKENGLILDKP(Vector3 GONNPACEKOP, Vector3 OAALNDIAAOB, ForceMode LLGEKNKAFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x53896D0", Offset = "0x53880D0", VA = "0x1853896D0", Slot = "6")]
	public void ONFMLOBCLMC(Vector3 ALEOGDBLBAL, ForceMode LLGEKNKAFEH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x5388C50", Offset = "0x5387650", VA = "0x185388C50")]
	private void AFPCJJGFHDO(Vector3 ALEOGDBLBAL, ForceMode LLGEKNKAFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x5389170", Offset = "0x5387B70", VA = "0x185389170", Slot = "7")]
	public void BMOHKBFEDIO(Vector3 ALEOGDBLBAL, ForceMode LLGEKNKAFEH = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class CGMEAIOLJGK : JAFLICKPOKP, EFCHMGFPPNG
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool MNJCELLFCNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x53629B0", Offset = "0x53613B0", VA = "0x1853629B0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x53627D0", Offset = "0x53611D0", VA = "0x1853627D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x5362320", Offset = "0x5360D20", VA = "0x185362320")]
	public CGMEAIOLJGK(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x53626D0", Offset = "0x53610D0", VA = "0x1853626D0", Slot = "6")]
	public void EEDPPAEHCMF(Rigidbody NMAIJIEBGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5362A90", Offset = "0x5361490", VA = "0x185362A90", Slot = "7")]
	public void MEBCMKNIKNA(Rigidbody NMAIJIEBGIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class NPBDEGLLFHF : JAFLICKPOKP, ALDDLAJCNDJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly HGHBLLBCIJM PFGJBHEKNMH;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Transform ONMPEEDNICF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x5386DE0", Offset = "0x53857E0", VA = "0x185386DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DFKOJFHJBPL GPFMBDKCEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x5386EB0", Offset = "0x53858B0", VA = "0x185386EB0")]
		get
		{
			return default(DFKOJFHJBPL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x5388400", Offset = "0x5386E00", VA = "0x185388400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public FINELKBJAJC NNHCCDNOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x53883C0", Offset = "0x5386DC0", VA = "0x1853883C0", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x5386D70", Offset = "0x5385770", VA = "0x185386D70", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public DFKOJFHJBPL HNIOKPHKMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x5388810", Offset = "0x5387210", VA = "0x185388810")]
		get
		{
			return default(DFKOJFHJBPL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x5388060", Offset = "0x5386A60", VA = "0x185388060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public FINELKBJAJC PMIOODBJODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x53872C0", Offset = "0x5385CC0", VA = "0x1853872C0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyList<FINELKBJAJC> DLHGIFABMAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6D7770", Offset = "0x6D6170", VA = "0x1806D7770", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event EOIGEIAJIKF EJLIAHAIONF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x5386550", Offset = "0x5384F50", VA = "0x185386550", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x5386690", Offset = "0x5385090", VA = "0x185386690", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event EOIGEIAJIKF DIJMKGIEGED
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x5386870", Offset = "0x5385270", VA = "0x185386870", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x5387740", Offset = "0x5386140", VA = "0x185387740", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event KHIJGEMJFAG BHDKKEHCFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x5388640", Offset = "0x5387040", VA = "0x185388640", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x5388160", Offset = "0x5386B60", VA = "0x185388160", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action IIBADDINJBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x5386730", Offset = "0x5385130", VA = "0x185386730", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x53885A0", Offset = "0x5386FA0", VA = "0x1853885A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action IOECKPFCOLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x53867D0", Offset = "0x53851D0", VA = "0x1853867D0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x53870F0", Offset = "0x5385AF0", VA = "0x1853870F0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<FINELKBJAJC> NKBAGBFAOPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x5387050", Offset = "0x5385A50", VA = "0x185387050", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x53865F0", Offset = "0x5384FF0", VA = "0x1853865F0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<FINELKBJAJC> MKBNLFLFJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x5388500", Offset = "0x5386F00", VA = "0x185388500", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x53874C0", Offset = "0x5385EC0", VA = "0x1853874C0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action KGNALDKPAGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5386B00", Offset = "0x5385500", VA = "0x185386B00", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x5386FB0", Offset = "0x53859B0", VA = "0x185386FB0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<FINELKBJAJC> PNKIOGHFIOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x5386E10", Offset = "0x5385810", VA = "0x185386E10", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x5388910", Offset = "0x5387310", VA = "0x185388910", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x53889B0", Offset = "0x53873B0", VA = "0x1853889B0")]
	public NPBDEGLLFHF(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5386BA0", Offset = "0x53855A0", VA = "0x185386BA0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5386910", Offset = "0x5385310", VA = "0x185386910", Slot = "26")]
	public void DGJAMCMEJGD(FINELKBJAJC DILGNCFGGHK, bool GJNGLKLPECL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5386990", Offset = "0x5385390", VA = "0x185386990")]
	private void DGJAMCMEJGD(IMDGPEHOLPH DILGNCFGGHK, bool GJNGLKLPECL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x53877E0", Offset = "0x53861E0", VA = "0x1853877E0")]
	private void LKBJAEPLPPI(IMDGPEHOLPH DILGNCFGGHK, bool GJNGLKLPECL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5387300", Offset = "0x5385D00", VA = "0x185387300")]
	private void KEHJLBDFMGD(IMDGPEHOLPH MCCGBMECIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5388200", Offset = "0x5386C00", VA = "0x185388200")]
	private void MIHNIBNCJBA(IMDGPEHOLPH MCCGBMECIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5386330", Offset = "0x5384D30", VA = "0x185386330")]
	private void AFEJHCPIELH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x53864D0", Offset = "0x5384ED0", VA = "0x1853864D0")]
	private void AHFAOJLGMLP(IMDGPEHOLPH MCCGBMECIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5387690", Offset = "0x5386090", VA = "0x185387690")]
	private void LBCPDMMOLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x5387560", Offset = "0x5385F60", VA = "0x185387560")]
	private void KPKNMPDBEAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5387190", Offset = "0x5385B90", VA = "0x185387190")]
	private void IBAFGGCIFCB(IMDGPEHOLPH MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x53886E0", Offset = "0x53870E0", VA = "0x1853886E0")]
	private void ONHPMCGNOEF(IMDGPEHOLPH MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5386A00", Offset = "0x5385400", VA = "0x185386A00")]
	[CompilerGenerated]
	private object DOAGJNHLCDE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class PKOOMCDLFPE
{
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6417D30", Offset = "0x6416730", VA = "0x186417D30")]
	public static NPBDEGLLFHF NHHBDODJKDO(this FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class OFBINCJFKCP : JAFLICKPOKP, NOHOJFFFHFH
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public Vector3 DLHOKPCNDHK
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x6417130", Offset = "0x6415B30", VA = "0x186417130", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public Vector3 KHNHKEGICDO
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x64175A0", Offset = "0x6415FA0", VA = "0x1864175A0", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	private Vector3 ABFNJJJIFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x6417860", Offset = "0x6416260", VA = "0x186417860")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private FINELKBJAJC BGDLBALHPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x6417730", Offset = "0x6416130", VA = "0x186417730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x6417C20", Offset = "0x6416620", VA = "0x186417C20")]
	public OFBINCJFKCP(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x6417A80", Offset = "0x6416480", VA = "0x186417A80", Slot = "6")]
	public void NPIEMEPDEKC(FINELKBJAJC ELGBIOMPEHN, object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x6417940", Offset = "0x6416340", VA = "0x186417940")]
	private void NPIEMEPDEKC(IMDGPEHOLPH ELGBIOMPEHN, object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x64174A0", Offset = "0x6415EA0", VA = "0x1864174A0", Slot = "7")]
	public void FPCIKEFOMNG(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6417160", Offset = "0x6415B60", VA = "0x186417160")]
	private Vector3 FHLCHHHFCPD()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class ICFLJFDGKID
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x53731C0", Offset = "0x5371BC0", VA = "0x1853731C0")]
	public static OFBINCJFKCP OKFHHECMBBP(this FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class KFKLGPIDNIL : JAFLICKPOKP, KBKJLCPHENA
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 IJDDNEDHONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x5379220", Offset = "0x5377C20", VA = "0x185379220", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x5379350", Offset = "0x5377D50", VA = "0x185379350", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 LDJDMCFGDHE
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x5378DD0", Offset = "0x53777D0", VA = "0x185378DD0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public float LDIJJJKDKPD
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x5379140", Offset = "0x5377B40", VA = "0x185379140", Slot = "9")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x5378DC0", Offset = "0x53777C0", VA = "0x185378DC0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float JOFKNAMFKBM
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x5379C30", Offset = "0x5378630", VA = "0x185379C30", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x5378670", Offset = "0x5377070", VA = "0x185378670", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public Vector3 BGAIPPJOAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x537A7E0", Offset = "0x53791E0", VA = "0x18537A7E0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x5378EF0", Offset = "0x53778F0", VA = "0x185378EF0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Quaternion HCJFINDADJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x5379D10", Offset = "0x5378710", VA = "0x185379D10", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x5378B70", Offset = "0x5377570", VA = "0x185378B70", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private Rigidbody NGHLLPGFILB
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x5360940", Offset = "0x535F340", VA = "0x185360940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event EOIGEIAJIKF IEDFEDNDNHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x537A490", Offset = "0x5378E90", VA = "0x18537A490", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x537AB60", Offset = "0x5379560", VA = "0x18537AB60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x537AC00", Offset = "0x5379600", VA = "0x18537AC00")]
	public KFKLGPIDNIL(FINELKBJAJC MPLGHJJKMAH, in GBAJKBMADFI NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5379810", Offset = "0x5378210", VA = "0x185379810", Slot = "17")]
	public void GMGCKIECDGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x5379490", Offset = "0x5377E90", VA = "0x185379490", Slot = "16")]
	public void GCGKMMPELCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x5378F20", Offset = "0x5377920", VA = "0x185378F20", Slot = "19")]
	public void EEDPPAEHCMF(Rigidbody NMAIJIEBGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x537A110", Offset = "0x5378B10", VA = "0x18537A110", Slot = "20")]
	public void MEBCMKNIKNA(Rigidbody NMAIJIEBGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x537A530", Offset = "0x5378F30", VA = "0x18537A530", Slot = "18")]
	public void NPIFIBABAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x5378680", Offset = "0x5377080", VA = "0x185378680", Slot = "21")]
	public void AJAEADGGIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5360D80", Offset = "0x535F780", VA = "0x185360D80")]
	public void JGOLENMBPGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x5379350", Offset = "0x5377D50", VA = "0x185379350")]
	private void KLHFKODODKK(Vector3 MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x537AA40", Offset = "0x5379440", VA = "0x18537AA40")]
	private Vector3 PDOPNOOIHFG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x537A610", Offset = "0x5379010", VA = "0x18537A610")]
	private void OFALDBALNCH(float MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x5379F50", Offset = "0x5378950", VA = "0x185379F50")]
	private void LOAMHNJDNGE(float MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x537A810", Offset = "0x5379210", VA = "0x18537A810")]
	private Vector3 OIMIGOLOKOH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5378B90", Offset = "0x5377590", VA = "0x185378B90")]
	private void CPAGBIGFEFO(Vector3 MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x5379D40", Offset = "0x5378740", VA = "0x185379D40")]
	private Quaternion KCEKPGFKJJM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x5379A20", Offset = "0x5378420", VA = "0x185379A20")]
	private void GOFBKBJPICO(Quaternion MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x5377620", Offset = "0x5376020", VA = "0x185377620")]
	internal (float, Vector3) AEPHKDOHKHK(Rigidbody KPJFDHAOIKF)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class AHNBNAGFNHK
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x5360800", Offset = "0x535F200", VA = "0x185360800")]
	public static KFKLGPIDNIL EKHBIACKGEF(this FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class LBJCNPACEBA : JAFLICKPOKP, DPLEFMDCHAK
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private const string ALDBBCFEPFC = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool JBMIBNPELKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x537B7E0", Offset = "0x537A1E0", VA = "0x18537B7E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public IHGNHGBDMIK OMDDDNFJDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x537BF10", Offset = "0x537A910", VA = "0x18537BF10", Slot = "5")]
		get
		{
			return default(IHGNHGBDMIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private IHGNHGBDMIK PLCJFGMOGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x537BD00", Offset = "0x537A700", VA = "0x18537BD00")]
		get
		{
			return default(IHGNHGBDMIK);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x537BDE0", Offset = "0x537A7E0", VA = "0x18537BDE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x537C1D0", Offset = "0x537ABD0", VA = "0x18537C1D0")]
	public LBJCNPACEBA(FINELKBJAJC MPLGHJJKMAH, in GBAJKBMADFI NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x537B8C0", Offset = "0x537A2C0", VA = "0x18537B8C0", Slot = "6")]
	public void AKHIMNHIOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x537C130", Offset = "0x537AB30", VA = "0x18537C130")]
	private bool OFDDANKCCEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x537BF20", Offset = "0x537A920", VA = "0x18537BF20", Slot = "7")]
	public void JJHDJKEBOLP(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x537B9C0", Offset = "0x537A3C0", VA = "0x18537B9C0", Slot = "8")]
	public void CDMHBJANAKM(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x537C020", Offset = "0x537AA20", VA = "0x18537C020", Slot = "11")]
	public void JJMJBENMNKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x537BC10", Offset = "0x537A610", VA = "0x18537BC10")]
	private void FGGOIJHNOLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x537BAC0", Offset = "0x537A4C0", VA = "0x18537BAC0")]
	private void EIIBPMJCCKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x537B980", Offset = "0x537A380", VA = "0x18537B980", Slot = "10")]
	public void BKELDDDHEDA(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x537BED0", Offset = "0x537A8D0", VA = "0x18537BED0", Slot = "9")]
	public void ILCODHFGIJP(FINELKBJAJC MPLGHJJKMAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class GCLFFLLHMDF : JAFLICKPOKP, OBIFGANNEIA
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool LLANJLNCMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x536E0D0", Offset = "0x536CAD0", VA = "0x18536E0D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public IEnumerable<object> HENALIPPCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x536E300", Offset = "0x536CD00", VA = "0x18536E300", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private bool DDJJBOPIBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x536DF00", Offset = "0x536C900", VA = "0x18536DF00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event EOIGEIAJIKF CPLFJIEMCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x536E230", Offset = "0x536CC30", VA = "0x18536E230", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x536E190", Offset = "0x536CB90", VA = "0x18536E190", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x5362320", Offset = "0x5360D20", VA = "0x185362320")]
	public GCLFFLLHMDF(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x536E070", Offset = "0x536CA70", VA = "0x18536E070", Slot = "11")]
	public IDisposable EFJNJIADBJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x536DFF0", Offset = "0x536C9F0", VA = "0x18536DFF0", Slot = "8")]
	public void CKHNMOAIKKF(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x536DFE0", Offset = "0x536C9E0", VA = "0x18536DFE0", Slot = "9")]
	public void AFOJJCPKDKC(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x536E3E0", Offset = "0x536CDE0", VA = "0x18536E3E0", Slot = "10")]
	public void NMBFJKGLMLM(object DEGCIHEAIBD, bool MPIEKKDMKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x536E000", Offset = "0x536CA00", VA = "0x18536E000", Slot = "12")]
	public void EEDPPAEHCMF(Rigidbody NIGLNONICLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x536E2D0", Offset = "0x536CCD0", VA = "0x18536E2D0", Slot = "13")]
	public void MEBCMKNIKNA(Rigidbody NMAIJIEBGIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class EDIAMIDNLKP : JAFLICKPOKP, FOABFNIFJAA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private PhotonView HGNNDDBGCIO;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool BKLEDPDFLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x5366EB0", Offset = "0x53658B0", VA = "0x185366EB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool FBANMELJCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x5367420", Offset = "0x5365E20", VA = "0x185367420", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event EOIGEIAJIKF AKILOILIGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x5367860", Offset = "0x5366260", VA = "0x185367860", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x5367B10", Offset = "0x5366510", VA = "0x185367B10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x5367DA0", Offset = "0x53667A0", VA = "0x185367DA0")]
	public EDIAMIDNLKP(FINELKBJAJC MPLGHJJKMAH, in GBAJKBMADFI NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x5366ED0", Offset = "0x53658D0", VA = "0x185366ED0", Slot = "8")]
	public void AKHIMNHIOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x5367020", Offset = "0x5365A20", VA = "0x185367020", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x5367210", Offset = "0x5365C10", VA = "0x185367210", Slot = "9")]
	public void ELJFDCONCDI(FINELKBJAJC ELGBIOMPEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x5367900", Offset = "0x5366300", VA = "0x185367900", Slot = "10")]
	public void JMJFGKIDBLA(FINELKBJAJC ELGBIOMPEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x5367BB0", Offset = "0x53665B0", VA = "0x185367BB0")]
	private void OGLDEBELHNI(PhotonView KJPEIALICOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x5367530", Offset = "0x5365F30", VA = "0x185367530")]
	private void FFJDKHOLJJC(RigidbodyEx NNOOGFBCAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x5367690", Offset = "0x5366090", VA = "0x185367690")]
	private void GHHPAMPIDCM(PhotonView AIKKOEKCJCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class GNMBIBLAAGB
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x536E560", Offset = "0x536CF60", VA = "0x18536E560")]
	public static EDIAMIDNLKP KHLEHGMJHFA(this EMAOEODIEEA GCIFBDHGBMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class NCNBELNGAJH : JAFLICKPOKP, JGIJDMAANMH
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool HJNDJLEEIDH
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x5385B40", Offset = "0x5384540", VA = "0x185385B40", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x5385870", Offset = "0x5384270", VA = "0x185385870", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool BNIFPAGGLMF
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x5385F20", Offset = "0x5384920", VA = "0x185385F20", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x5385780", Offset = "0x5384180", VA = "0x185385780")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public RigidbodyConstraints JGJHMHEFNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x5385A60", Offset = "0x5384460", VA = "0x185385A60", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x5385C20", Offset = "0x5384620", VA = "0x185385C20", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x5386000", Offset = "0x5384A00", VA = "0x185386000")]
	public NCNBELNGAJH(FINELKBJAJC MPLGHJJKMAH, in GBAJKBMADFI NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x5385960", Offset = "0x5384360", VA = "0x185385960", Slot = "9")]
	public void EEDPPAEHCMF(Rigidbody NMAIJIEBGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x5385E20", Offset = "0x5384820", VA = "0x185385E20", Slot = "10")]
	public void MEBCMKNIKNA(Rigidbody NMAIJIEBGIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class CKDGEPDFCMF : JAFLICKPOKP, DNGEAFOGJME
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public float CBCHKHFNIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x5362EA0", Offset = "0x53618A0", VA = "0x185362EA0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x5362CD0", Offset = "0x53616D0", VA = "0x185362CD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public float BKOJANHELNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x5363220", Offset = "0x5361C20", VA = "0x185363220", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x5362F80", Offset = "0x5361980", VA = "0x185362F80", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x5362320", Offset = "0x5360D20", VA = "0x185362320")]
	public CKDGEPDFCMF(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x5362B00", Offset = "0x5361500", VA = "0x185362B00", Slot = "8")]
	public void EEDPPAEHCMF(Rigidbody NMAIJIEBGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x5363150", Offset = "0x5361B50", VA = "0x185363150", Slot = "9")]
	public void MEBCMKNIKNA(Rigidbody NMAIJIEBGIH)
	{
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[DNOPHNKOHLA(typeof(GEIPPHFKOBG), new string[] { })]
	[LOEOGANCBGC(EDPDLGMLNHJ.Physics)]
	public sealed class RbexServiceCallbacks : MMKNGEFLOAO, GEIPPHFKOBG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly KGOHPJFJCLE LHMILDDMKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private GHMLCJKOGGN MPLGHJJKMAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private bool DHFBGINHBOF;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool JDCINNHHEGM
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x6DB8D0", Offset = "0x6DA2D0", VA = "0x1806DB8D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x6418220", Offset = "0x6416C20", VA = "0x186418220", Slot = "4")]
		public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x64181F0", Offset = "0x6416BF0", VA = "0x1864181F0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6417F40", Offset = "0x6416940", VA = "0x186417F40", Slot = "6")]
		public void AEPHKDOHKHK(DFKOJFHJBPL PMMCMCPNCLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public RbexServiceCallbacks()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class AJNIBEAFKPE : JAFLICKPOKP, CHNFBMHLJMH
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const int EOEFGFGBDCC = 10;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public const float DKGOCGFBEHL = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const float HKIBFKHPNFH = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public const float CDOEFLALDDL = 5f;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private Rigidbody NGHLLPGFILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x5360940", Offset = "0x535F340", VA = "0x185360940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool BJMNABPBBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x53617C0", Offset = "0x53601C0", VA = "0x1853617C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool NNINDJDOIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x5361870", Offset = "0x5360270", VA = "0x185361870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private FINELKBJAJC NNHCCDNOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x53616C0", Offset = "0x53600C0", VA = "0x1853616C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private bool GOECHKKAMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x53610D0", Offset = "0x535FAD0", VA = "0x1853610D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool HCJPBBJAPNF
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x5360DC0", Offset = "0x535F7C0", VA = "0x185360DC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x5361130", Offset = "0x535FB30", VA = "0x185361130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private bool IDOFEGFFNFF
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x5361440", Offset = "0x535FE40", VA = "0x185361440")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x53615D0", Offset = "0x535FFD0", VA = "0x1853615D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private int POKLJPAIOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x5360FF0", Offset = "0x535F9F0", VA = "0x185360FF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x5360A30", Offset = "0x535F430", VA = "0x185360A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event EOIGEIAJIKF AOKABOPPDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x5361720", Offset = "0x5360120", VA = "0x185361720", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x5360990", Offset = "0x535F390", VA = "0x185360990", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x5361890", Offset = "0x5360290", VA = "0x185361890")]
	public AJNIBEAFKPE(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x5360890", Offset = "0x535F290", VA = "0x185360890", Slot = "6")]
	public void AKHIMNHIOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x5361860", Offset = "0x5360260", VA = "0x185361860", Slot = "8")]
	public void OPDMIIBMDPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x5361220", Offset = "0x535FC20", VA = "0x185361220", Slot = "7")]
	public bool KHIMNPKKOOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x5361520", Offset = "0x535FF20", VA = "0x185361520", Slot = "9")]
	public void MHHNJOOIKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x5360D80", Offset = "0x535F780", VA = "0x185360D80", Slot = "12")]
	public void FHHCHNDGGHH(bool JKOMJKKMCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x5360CD0", Offset = "0x535F6D0", VA = "0x185360CD0", Slot = "11")]
	public void FADGJLPBHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "10")]
	public void NHIMCHDCAII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x5360B20", Offset = "0x535F520", VA = "0x185360B20")]
	private bool EDFELAJFLOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x5360EA0", Offset = "0x535F8A0", VA = "0x185360EA0")]
	private void JAGJIOGAADF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class JINACEHOCJO : JAFLICKPOKP, IPLCEEKLLAN
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private const string MABOMMFMPLF = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Rigidbody NGHLLPGFILB
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x53755E0", Offset = "0x5373FE0", VA = "0x1853755E0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x5375C40", Offset = "0x5374640", VA = "0x185375C40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private bool GOECHKKAMDL
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x536F690", Offset = "0x536E090", VA = "0x18536F690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x5375F90", Offset = "0x5374990", VA = "0x185375F90")]
	public JINACEHOCJO(FINELKBJAJC MPLGHJJKMAH, in GBAJKBMADFI NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x53750A0", Offset = "0x5373AA0", VA = "0x1853750A0", Slot = "5")]
	public void AKHIMNHIOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x5375980", Offset = "0x5374380", VA = "0x185375980", Slot = "6")]
	public void HNKAHGBLMFG(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x5375150", Offset = "0x5373B50", VA = "0x185375150", Slot = "7")]
	public void BOKFPLECABM(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x53756C0", Offset = "0x53740C0", VA = "0x1853756C0", Slot = "8")]
	public void EKMLDDLGAHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x5375D30", Offset = "0x5374730", VA = "0x185375D30", Slot = "9")]
	public void OEOFELGGEJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x5375250", Offset = "0x5373C50", VA = "0x185375250", Slot = "10")]
	public void CJJBBLKMCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "11")]
	public void HBCINAGAAFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x5375A80", Offset = "0x5374480", VA = "0x185375A80")]
	private void JBMOLNOAMPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x5375420", Offset = "0x5373E20", VA = "0x185375420")]
	private void CPNOCLFIODB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class MJAIPCGCOIK : JAFLICKPOKP, HHEJEAPJBJM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public AAGBILKCEFJ HJMCHGKOFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x5382B10", Offset = "0x5381510", VA = "0x185382B10", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x53844C0", Offset = "0x5382EC0", VA = "0x1853844C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public HPBKAAPNIDE JFIJDPHAPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x53827F0", Offset = "0x53811F0", VA = "0x1853827F0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5385690", Offset = "0x5384090", VA = "0x185385690", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 ABFNJJJIFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x5384EE0", Offset = "0x53838E0", VA = "0x185384EE0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5384400", Offset = "0x5382E00", VA = "0x185384400", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 DMDIOGFKLBB
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5383560", Offset = "0x5381F60", VA = "0x185383560", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x5384120", Offset = "0x5382B20", VA = "0x185384120", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Vector3 EIFGBJCCKOP
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5382F60", Offset = "0x5381960", VA = "0x185382F60", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x53820C0", Offset = "0x5380AC0", VA = "0x1853820C0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 AEHCEPOJINK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5384000", Offset = "0x5382A00", VA = "0x185384000", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5385660", Offset = "0x5384060", VA = "0x185385660", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public float GPJNEDFLKLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x5383E60", Offset = "0x5382860", VA = "0x185383E60", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x5384ED0", Offset = "0x53838D0", VA = "0x185384ED0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool DADGANMPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x5381FE0", Offset = "0x53809E0", VA = "0x185381FE0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private CEHLNMEGNHL HGMILGJMKLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x1D16570", Offset = "0x1D14F70", VA = "0x181D16570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private bool NNINDJDOIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x5361870", Offset = "0x5360270", VA = "0x185361870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x5362320", Offset = "0x5360D20", VA = "0x185362320")]
	public MJAIPCGCOIK(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x53837A0", Offset = "0x53821A0", VA = "0x1853837A0", Slot = "20")]
	public void EDACDIJGMDM(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x5384A20", Offset = "0x5383420", VA = "0x185384A20", Slot = "31")]
	public void MHHGHPEHPOJ(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x5382180", Offset = "0x5380B80", VA = "0x185382180", Slot = "19")]
	public void AKHIMNHIOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5383670", Offset = "0x5382070", VA = "0x185383670", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5383890", Offset = "0x5382290", VA = "0x185383890", Slot = "28")]
	public void EEDPPAEHCMF(Rigidbody NMAIJIEBGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5385480", Offset = "0x5383E80", VA = "0x185385480", Slot = "36")]
	public Vector3 ONCHFGBOPNN(Vector3 KFMEEFJANFE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5382DA0", Offset = "0x53817A0", VA = "0x185382DA0", Slot = "35")]
	public Vector3 CFNAJGAOBEF(Vector3 EGKOABIGCEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5382180", Offset = "0x5380B80", VA = "0x185382180", Slot = "27")]
	public void LIJHHFDNMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5384150", Offset = "0x5382B50", VA = "0x185384150", Slot = "25")]
	public void HOCINLNMKAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5385030", Offset = "0x5383A30", VA = "0x185385030", Slot = "24")]
	public void NHIOLLFNDEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5385070", Offset = "0x5383A70", VA = "0x185385070", Slot = "34")]
	public void ODBDKBKNKKH(Vector3 KNMAKDBFNDP, Vector3 JGIOFMHEJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5383500", Offset = "0x5381F00", VA = "0x185383500", Slot = "33")]
	public void DGDDFJLDGHA(Vector3 HAOHPFICBPO, Vector3 HHCGJCNNJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x53842A0", Offset = "0x5382CA0", VA = "0x1853842A0", Slot = "32")]
	public void IGKKCOIIJPE(Vector3 LBJDLPFBLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x53845B0", Offset = "0x5382FB0", VA = "0x1853845B0", Slot = "22")]
	public void MAFJLECBAJB(GFNIKGHNFMK NDCODNFDBDL, Vector3 BKCKHNNPBPN, float FDLFHFCEKLG, float BCPPBALBKDI = 8f, float HDGDBBFNACP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x53838D0", Offset = "0x53822D0", VA = "0x1853838D0", Slot = "21")]
	public void EIOODGJPGNH(BAPDLIMMIEJ DFBKFCMOCAB, Vector3 KHAIFHDNCAN, float DHGAEJJNMPB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5384B10", Offset = "0x5383510", VA = "0x185384B10", Slot = "23")]
	[Obsolete]
	public void MJJKJNEOFFA(BAPDLIMMIEJ DFBKFCMOCAB, Vector3 HOOCPOKGFMC, float NHJDIFFEONI = 7f, float MKKFGBEOHMB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5382A50", Offset = "0x5381450", VA = "0x185382A50", Slot = "30")]
	public Vector3 BMOCCKOACNL(Vector3 DDEOINEGECJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5384DE0", Offset = "0x53837E0", VA = "0x185384DE0", Slot = "29")]
	public Vector3 MKMPALOPNCI(Vector3 AMIMCOHFMAN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5382920", Offset = "0x5381320", VA = "0x185382920", Slot = "26")]
	public void BCGKFGHJEGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x53852B0", Offset = "0x5383CB0", VA = "0x1853852B0")]
	private void OKNAAJMEFPA(float MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5382C40", Offset = "0x5381640", VA = "0x185382C40")]
	private void BOEMFBCPDEL(Vector3 KHAIFHDNCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x53833F0", Offset = "0x5381DF0", VA = "0x1853833F0")]
	private Vector3 DDHCLKBNCMH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x53830B0", Offset = "0x5381AB0", VA = "0x1853830B0")]
	private void CGPEHBMEAFE(Vector3 EGKOABIGCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5384190", Offset = "0x5382B90", VA = "0x185384190")]
	private Vector3 HPIGFNACKGG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5383B00", Offset = "0x5382500", VA = "0x185383B00")]
	private void EJOFIKNOGMA(Vector3 MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x53821F0", Offset = "0x5380BF0", VA = "0x1853821F0")]
	private void AMFPDAMLGBL(Vector3 EGKOABIGCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x5383F40", Offset = "0x5382940", VA = "0x185383F40")]
	private void FLMPPENOHBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class JAFLICKPOKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly IMDGPEHOLPH MPLGHJJKMAH;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected GHMLCJKOGGN EEIHGOPACCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xBA6650", Offset = "0xBA5050", VA = "0x180BA6650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected DFKOJFHJBPL LIBEOLBPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x53742F0", Offset = "0x5372CF0", VA = "0x1853742F0")]
		get
		{
			return default(DFKOJFHJBPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x5362320", Offset = "0x5360D20", VA = "0x185362320")]
	public JAFLICKPOKP(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x53741D0", Offset = "0x5372BD0", VA = "0x1853741D0")]
	protected FINELKBJAJC NGGDMJFHALP(DFKOJFHJBPL EFHLICFAAGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class HMJAOBJGAGD : PGDLJBLFBNG
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x5371D30", Offset = "0x5370730", VA = "0x185371D30", Slot = "4")]
	public ALDDLAJCNDJ KJLFNJLJKGO(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x5371BF0", Offset = "0x53705F0", VA = "0x185371BF0", Slot = "5")]
	public HHEJEAPJBJM IJIONEIJDFG(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x5371A30", Offset = "0x5370430", VA = "0x185371A30", Slot = "6")]
	public NOHOJFFFHFH GGIMKEHLCFJ(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x5371FE0", Offset = "0x53709E0", VA = "0x185371FE0", Slot = "7")]
	public DNGEAFOGJME NBFNLDDJHLF(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x5372080", Offset = "0x5370A80", VA = "0x185372080", Slot = "8")]
	public CHNFBMHLJMH PHDCAMEIJBD(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5371C90", Offset = "0x5370690", VA = "0x185371C90", Slot = "9")]
	public LOHCPIFOKBA KCKGECDIJAH(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5371F40", Offset = "0x5370940", VA = "0x185371F40", Slot = "10")]
	public OBIFGANNEIA MOBIIGHHKNC(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x5371A90", Offset = "0x5370490", VA = "0x185371A90", Slot = "11")]
	public CEHLNMEGNHL GHEMBNKCOOB(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x5371EA0", Offset = "0x53708A0", VA = "0x185371EA0", Slot = "12")]
	public PBGEAABGDLG LAGLKODAAHG(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x5371990", Offset = "0x5370390", VA = "0x185371990", Slot = "13")]
	public EFCHMGFPPNG DJDAINJJJMD(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5371B30", Offset = "0x5370530", VA = "0x185371B30")]
	public IPLCEEKLLAN HIFIDCFLLFP(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x53715B0", Offset = "0x536FFB0", VA = "0x1853715B0")]
	public FOABFNIFJAA GLHDBOGCFCL(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5371800", Offset = "0x5370200", VA = "0x185371800")]
	public DPLEFMDCHAK FGJEKHEKKKJ(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x5371670", Offset = "0x5370070", VA = "0x185371670")]
	public KBKJLCPHENA NJIHJIBLCFE(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x53716E0", Offset = "0x53700E0", VA = "0x1853716E0")]
	public JGIJDMAANMH JEOFLAOFKFI(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5371750", Offset = "0x5370150", VA = "0x185371750", Slot = "19")]
	public FINELKBJAJC BHAAGIJHAHG(RigidbodyEx MPLGHJJKMAH, GBAJKBMADFI NIPBPKPBPPP, AHOEMGMJFLI MPEBEBMNLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public HMJAOBJGAGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5371B30", Offset = "0x5370530", VA = "0x185371B30", Slot = "14")]
	private IPLCEEKLLAN JMKCMGAOACA(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x53715B0", Offset = "0x536FFB0", VA = "0x1853715B0", Slot = "15")]
	private FOABFNIFJAA ACCLENEBICL(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5371800", Offset = "0x5370200", VA = "0x185371800", Slot = "16")]
	private DPLEFMDCHAK DCOPAPAFOOI(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5371670", Offset = "0x5370070", VA = "0x185371670", Slot = "17")]
	private KBKJLCPHENA AFBKJIFFIDE(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x53716E0", Offset = "0x53700E0", VA = "0x1853716E0", Slot = "18")]
	private JGIJDMAANMH BFAAOKKIEHG(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class HGHBLLBCIJM : IReadOnlyList<FINELKBJAJC>, IEnumerable<FINELKBJAJC>, IEnumerable, IReadOnlyCollection<FINELKBJAJC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly GHMLCJKOGGN DMALFCEFIJB;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x536FD20", Offset = "0x536E720", VA = "0x18536FD20", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public FINELKBJAJC NLCLIBHDEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x536FDF0", Offset = "0x536E7F0", VA = "0x18536FDF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x536FCD0", Offset = "0x536E6D0", VA = "0x18536FCD0")]
	public HGHBLLBCIJM(DFKOJFHJBPL EFHLICFAAGO, GHMLCJKOGGN DMALFCEFIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x536FB40", Offset = "0x536E540", VA = "0x18536FB40", Slot = "6")]
	public IEnumerator<FINELKBJAJC> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x536FB40", Offset = "0x536E540", VA = "0x18536FB40", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x536FB30", Offset = "0x536E530", VA = "0x18536FB30")]
	[CompilerGenerated]
	private FINELKBJAJC CBFDMCHKPEK(int ALJNHCKDPKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[DNOPHNKOHLA(typeof(PGDLJBLFBNG), new string[] { })]
public class DNBBCPLMNIA : PGDLJBLFBNG, MMKNGEFLOAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly PGDLJBLFBNG IFEBICJLPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly PGDLJBLFBNG LAHDFCJFOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private CGCFBBFKDEL HHKHFGCMHOJ;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private PGDLJBLFBNG FKLIHIDKNHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x5366710", Offset = "0x5365110", VA = "0x185366710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x53668B0", Offset = "0x53652B0", VA = "0x1853668B0", Slot = "20")]
	public void GKELOLOLCBL(NKLKBAHCHOA BKJAOJMOJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5366AF0", Offset = "0x53654F0", VA = "0x185366AF0", Slot = "4")]
	public ALDDLAJCNDJ KJLFNJLJKGO(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x53669B0", Offset = "0x53653B0", VA = "0x1853669B0", Slot = "5")]
	public HHEJEAPJBJM IJIONEIJDFG(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5366770", Offset = "0x5365170", VA = "0x185366770", Slot = "6")]
	public NOHOJFFFHFH GGIMKEHLCFJ(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5366CD0", Offset = "0x53656D0", VA = "0x185366CD0", Slot = "7")]
	public DNGEAFOGJME NBFNLDDJHLF(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5366D70", Offset = "0x5365770", VA = "0x185366D70", Slot = "8")]
	public CHNFBMHLJMH PHDCAMEIJBD(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5366A50", Offset = "0x5365450", VA = "0x185366A50", Slot = "9")]
	public LOHCPIFOKBA KCKGECDIJAH(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5366C30", Offset = "0x5365630", VA = "0x185366C30", Slot = "10")]
	public OBIFGANNEIA MOBIIGHHKNC(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5366810", Offset = "0x5365210", VA = "0x185366810", Slot = "11")]
	public CEHLNMEGNHL GHEMBNKCOOB(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5366B90", Offset = "0x5365590", VA = "0x185366B90", Slot = "12")]
	public PBGEAABGDLG LAGLKODAAHG(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5366670", Offset = "0x5365070", VA = "0x185366670", Slot = "13")]
	public EFCHMGFPPNG DJDAINJJJMD(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x5366900", Offset = "0x5365300", VA = "0x185366900")]
	public IPLCEEKLLAN HIFIDCFLLFP(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x5366260", Offset = "0x5364C60", VA = "0x185366260")]
	public FOABFNIFJAA GLHDBOGCFCL(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x53665C0", Offset = "0x5364FC0", VA = "0x1853665C0")]
	public DPLEFMDCHAK FGJEKHEKKKJ(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5366310", Offset = "0x5364D10", VA = "0x185366310")]
	public KBKJLCPHENA NJIHJIBLCFE(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x53663C0", Offset = "0x5364DC0", VA = "0x1853663C0")]
	public JGIJDMAANMH JEOFLAOFKFI(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5366470", Offset = "0x5364E70", VA = "0x185366470", Slot = "19")]
	public FINELKBJAJC BHAAGIJHAHG(RigidbodyEx MPLGHJJKMAH, GBAJKBMADFI NIPBPKPBPPP, AHOEMGMJFLI MPEBEBMNLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5366E10", Offset = "0x5365810", VA = "0x185366E10")]
	public DNBBCPLMNIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x5366900", Offset = "0x5365300", VA = "0x185366900", Slot = "14")]
	private IPLCEEKLLAN JMKCMGAOACA(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5366260", Offset = "0x5364C60", VA = "0x185366260", Slot = "15")]
	private FOABFNIFJAA ACCLENEBICL(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x53665C0", Offset = "0x5364FC0", VA = "0x1853665C0", Slot = "16")]
	private DPLEFMDCHAK DCOPAPAFOOI(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5366310", Offset = "0x5364D10", VA = "0x185366310", Slot = "17")]
	private KBKJLCPHENA AFBKJIFFIDE(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x53663C0", Offset = "0x5364DC0", VA = "0x1853663C0", Slot = "18")]
	private JGIJDMAANMH BFAAOKKIEHG(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Preserve]
public sealed class KLCPIHBHMNP : FINELKBJAJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly KLCPIHBHMNP FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Rigidbody NGHLLPGFILB
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public RigidbodyEx HIPLOELIEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public GameObject AKKLNJDLHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Transform ONMPEEDNICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public IEnumerable<object> BGPPMHHGDDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public FINELKBJAJC NNHCCDNOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x6C8570", Offset = "0x6C6F70", VA = "0x1806C8570", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x6C8590", Offset = "0x6C6F90", VA = "0x1806C8590", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public IReadOnlyList<FINELKBJAJC> DLHGIFABMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6C8580", Offset = "0x6C6F80", VA = "0x1806C8580", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public FINELKBJAJC PMIOODBJODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x6C10D0", Offset = "0x6BFAD0", VA = "0x1806C10D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool GOECHKKAMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1068E10", Offset = "0x1067810", VA = "0x181068E10", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool BKLEDPDFLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x111B340", Offset = "0x1119D40", VA = "0x18111B340", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool FBANMELJCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xB73E40", Offset = "0xB72840", VA = "0x180B73E40", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public AAGBILKCEFJ HJMCHGKOFPF
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x6C10B0", Offset = "0x6BFAB0", VA = "0x1806C10B0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7B9300", Offset = "0x7B7D00", VA = "0x1807B9300", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public HPBKAAPNIDE JFIJDPHAPDK
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x6D7770", Offset = "0x6D6170", VA = "0x1806D7770", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x762AB0", Offset = "0x7614B0", VA = "0x180762AB0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public float GPJNEDFLKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x11DE650", Offset = "0x11DD050", VA = "0x1811DE650", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x1C083D0", Offset = "0x1C06DD0", VA = "0x181C083D0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 DMDIOGFKLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x37A4B00", Offset = "0x37A3500", VA = "0x1837A4B00", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x37A4C10", Offset = "0x37A3610", VA = "0x1837A4C10", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 AEHCEPOJINK
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x1769020", Offset = "0x1767A20", VA = "0x181769020", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x1764450", Offset = "0x1762E50", VA = "0x181764450", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 ABFNJJJIFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x1769040", Offset = "0x1767A40", VA = "0x181769040", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1764B50", Offset = "0x1763550", VA = "0x181764B50", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Vector3 EIFGBJCCKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x15198A0", Offset = "0x15182A0", VA = "0x1815198A0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool AAPGKFBKDBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xBAA280", Offset = "0xBA8C80", VA = "0x180BAA280", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool AKLHDCGMDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xBEE8B0", Offset = "0xBED2B0", VA = "0x180BEE8B0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool PBKENEJPHOG
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xBEE8A0", Offset = "0xBED2A0", VA = "0x180BEE8A0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool DADGANMPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xA69B20", Offset = "0xA68520", VA = "0x180A69B20", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Vector3 DLHOKPCNDHK
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1A9F040", Offset = "0x1A9DA40", VA = "0x181A9F040", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 KHNHKEGICDO
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x15B7D00", Offset = "0x15B6700", VA = "0x1815B7D00", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 IJDDNEDHONI
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x15198A0", Offset = "0x15182A0", VA = "0x1815198A0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 LDJDMCFGDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x1769110", Offset = "0x1767B10", VA = "0x181769110", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public float LDIJJJKDKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x1218990", Offset = "0x1217390", VA = "0x181218990", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float JOFKNAMFKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x100C4C0", Offset = "0x100AEC0", VA = "0x18100C4C0", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 BGAIPPJOAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x15198A0", Offset = "0x15182A0", VA = "0x1815198A0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion HCJFINDADJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x16468A0", Offset = "0x16452A0", VA = "0x1816468A0", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public float CBCHKHFNIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x100C4C0", Offset = "0x100AEC0", VA = "0x18100C4C0", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public float BKOJANHELNK
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x100C4C0", Offset = "0x100AEC0", VA = "0x18100C4C0", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool MNJCELLFCNG
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool IGPKDOFADIA
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public FHGIMEJNAKL BOHPADGHJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "52")]
		get
		{
			return default(FHGIMEJNAKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool LLANJLNCMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2147690", Offset = "0x2146090", VA = "0x182147690", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Transform HOCKJBJNDGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x7F1820", Offset = "0x7F0220", VA = "0x1807F1820", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Transform CEGIGFGJCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x7797A0", Offset = "0x7781A0", VA = "0x1807797A0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Vector3 NJJBCKOHNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x15198A0", Offset = "0x15182A0", VA = "0x1815198A0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float LMOFGOGBHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x100C4C0", Offset = "0x100AEC0", VA = "0x18100C4C0", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public float DEOPFAEIOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x100C4C0", Offset = "0x100AEC0", VA = "0x18100C4C0", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Quaternion KKEIEPMJOAP
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x1152490", Offset = "0x1150E90", VA = "0x181152490", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Vector3 IOJJLJDINFL
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x15198A0", Offset = "0x15182A0", VA = "0x1815198A0", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Quaternion MBFBKKLCOFG
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x1152490", Offset = "0x1150E90", VA = "0x181152490", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public RigidbodyConstraints JGJHMHEFNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool HJNDJLEEIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public CollisionDetectionMode HIONHKLMGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool NNINDJDOIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x1316AB0", Offset = "0x13154B0", VA = "0x181316AB0", Slot = "75")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event EOIGEIAJIKF EJLIAHAIONF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event EOIGEIAJIKF DIJMKGIEGED
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event KHIJGEMJFAG BHDKKEHCFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event EOIGEIAJIKF AKILOILIGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event EOIGEIAJIKF DEAKDANAAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event EOIGEIAJIKF AOKABOPPDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<MDILDCKBKMK, MDILDCKBKMK> JMFOKJJIFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event EOIGEIAJIKF LAADJFDFHAK
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event EOIGEIAJIKF MHANNHKCODL
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "125")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "126")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "76")]
	public void AKHIMNHIOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "77")]
	public void DDAAOLGKOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "78")]
	public void ELEGAIPDPPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "79")]
	public void MHHNJOOIKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "80")]
	public void NKDDKEPLNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "87")]
	public void DGJAMCMEJGD(FINELKBJAJC MNIAGKNOHEJ, bool GJNGLKLPECL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "90")]
	public void DOLHIOPLDNE(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "91")]
	public void NKHMCPFJJCB(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x15198A0", Offset = "0x15182A0", VA = "0x1815198A0", Slot = "92")]
	public Vector3 ONCHFGBOPNN(Vector3 KFMEEFJANFE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x15198A0", Offset = "0x15182A0", VA = "0x1815198A0", Slot = "93")]
	public Vector3 CFNAJGAOBEF(Vector3 EGKOABIGCEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "94")]
	public void LIJHHFDNMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "95")]
	public void HOCINLNMKAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "96")]
	public void NHIOLLFNDEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "97")]
	public void ODBDKBKNKKH(Vector3 KNMAKDBFNDP, Vector3 JGIOFMHEJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "98")]
	public void DGDDFJLDGHA(Vector3 HAOHPFICBPO, Vector3 HHCGJCNNJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "99")]
	public void IGKKCOIIJPE(Vector3 LBJDLPFBLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "100")]
	public void MAFJLECBAJB(GFNIKGHNFMK NDCODNFDBDL, Vector3 BKCKHNNPBPN, float FDLFHFCEKLG, float BCPPBALBKDI = 8f, float HDGDBBFNACP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "101")]
	public void EIOODGJPGNH(BAPDLIMMIEJ DFBKFCMOCAB, Vector3 KHAIFHDNCAN, float DHGAEJJNMPB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "102")]
	public void MJJKJNEOFFA(BAPDLIMMIEJ DFBKFCMOCAB, Vector3 HOOCPOKGFMC, float NHJDIFFEONI = 7f, float MKKFGBEOHMB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x15198A0", Offset = "0x15182A0", VA = "0x1815198A0", Slot = "103")]
	public Vector3 BMOCCKOACNL(Vector3 MNIAGKNOHEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x15198A0", Offset = "0x15182A0", VA = "0x1815198A0", Slot = "104")]
	public Vector3 MKMPALOPNCI(Vector3 MNIAGKNOHEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "105")]
	public void BCGKFGHJEGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "106")]
	public void IANGFPPNEMN(FINELKBJAJC CDMJBEHHHDN, object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "107")]
	public void HMJNHJHPEHP(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "110")]
	public void GMGCKIECDGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "111")]
	public void GCGKMMPELCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "112")]
	public void NPIFIBABAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "115")]
	public bool KHIMNPKKOOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "116")]
	public void FADGJLPBHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6C8170", Offset = "0x6C6B70", VA = "0x1806C8170", Slot = "121")]
	public IDisposable EFJNJIADBJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "122")]
	public void CKHNMOAIKKF(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "123")]
	public void AFOJJCPKDKC(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "124")]
	public void NMBFJKGLMLM(object DEGCIHEAIBD, bool MPIEKKDMKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "127")]
	public void FKLDPKCKKEP(Vector3 ICMDDAIKFFC, Quaternion EGLMODKINDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "128")]
	public void IGOFKBBDCFJ(Vector3 NLDIPKCEGFI, Quaternion CPMNDBAPBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "129")]
	public bool IEHLOGIJCPN(float EGAHANLMNHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "130")]
	public void AEMGDJNANKB(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "131")]
	public void DIMBLJKMCFE(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "132")]
	public void HNKAHGBLMFG(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "133")]
	public void BOKFPLECABM(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "134")]
	public void ADHPHHGGPFO(Vector3 GONNPACEKOP, ForceMode LLGEKNKAFEH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "135")]
	public void AKENGLILDKP(Vector3 GONNPACEKOP, Vector3 OAALNDIAAOB, ForceMode LLGEKNKAFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "136")]
	public void ONFMLOBCLMC(Vector3 ALEOGDBLBAL, ForceMode LLGEKNKAFEH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "137")]
	public void BMOHKBFEDIO(Vector3 ALEOGDBLBAL, ForceMode LLGEKNKAFEH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x537B4E0", Offset = "0x5379EE0", VA = "0x18537B4E0", Slot = "138")]
	public bool MCCMDLKNBFC(Vector3 PANBGKEJNBF, out RaycastHit EKBEEAKLGKG, float OEPBPFIFMKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "139")]
	public void AJAEADGGIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KLCPIHBHMNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class IMDGPEHOLPH : EMAOEODIEEA, AJLHDLPKFOJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	internal DFKOJFHJBPL EFHLICFAAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	internal GHMLCJKOGGN EJLOOEPBJOA;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x53741C0", Offset = "0x5372BC0", VA = "0x1853741C0")]
	public IMDGPEHOLPH(GameObject KEHOIMKGHCH, RigidbodyEx MIEKGEIPEKE, AHOEMGMJFLI MPEBEBMNLLA, in GBAJKBMADFI NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x5373F30", Offset = "0x5372930", VA = "0x185373F30", Slot = "142")]
	protected override void PFEGDELMDIC(AHOEMGMJFLI MPEBEBMNLLA, GBAJKBMADFI NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5373B10", Offset = "0x5372510", VA = "0x185373B10", Slot = "143")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x5373D00", Offset = "0x5372700", VA = "0x185373D00", Slot = "145")]
	public void FKJMHNCLPHH(EIFFOLHELAI HKLCHIBFNAM, EIFFOLHELAI APGCALANEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x5373990", Offset = "0x5372390", VA = "0x185373990", Slot = "146")]
	public void CBBIADEHPKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x5373A50", Offset = "0x5372450", VA = "0x185373A50", Slot = "147")]
	public void DNPKPHKALNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x5373CA0", Offset = "0x53726A0", VA = "0x185373CA0", Slot = "148")]
	public void FHHCHNDGGHH(bool JKOMJKKMCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x5373DD0", Offset = "0x53727D0", VA = "0x185373DD0", Slot = "149")]
	public bool FOODODOIIEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "144")]
	public override void NKDDKEPLNOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class HBLNAEGAEFB
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x536ECF0", Offset = "0x536D6F0", VA = "0x18536ECF0")]
	public static EMAOEODIEEA DDGJEIAAMHC(this FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface LILLONKMEHD : ALDDLAJCNDJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBAFGGCIFCB(FINELKBJAJC MPLGHJJKMAH);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ONHPMCGNOEF(FINELKBJAJC MPLGHJJKMAH);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KEHJLBDFMGD(FINELKBJAJC MCCGBMECIAB);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MIHNIBNCJBA(FINELKBJAJC MCCGBMECIAB);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface PAFAEOFGLNK : NOHOJFFFHFH
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	global::PIEOFAGIBKK<FINELKBJAJC> NOOCFJHLCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	FINELKBJAJC BGDLBALHPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface CELDBJDFJKP : KBKJLCPHENA
{
	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) AEPHKDOHKHK(Rigidbody KPJFDHAOIKF);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface GIKAJKOLDEH : FOABFNIFJAA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	PhotonView HDCKANIMFMK
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class HACMJFPJCDD : PBGEAABGDLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly EMAOEODIEEA MPLGHJJKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private CollisionDetectionMode JMFAJAEMDLP;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private Rigidbody NGHLLPGFILB
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x5360940", Offset = "0x535F340", VA = "0x185360940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public CollisionDetectionMode HIONHKLMGKC
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x536E890", Offset = "0x536D290", VA = "0x18536E890", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x536E7A0", Offset = "0x536D1A0", VA = "0x18536E7A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x536EC60", Offset = "0x536D660", VA = "0x18536EC60")]
	public HACMJFPJCDD(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x536E680", Offset = "0x536D080", VA = "0x18536E680", Slot = "6")]
	public void AKHIMNHIOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x536E810", Offset = "0x536D210", VA = "0x18536E810", Slot = "9")]
	public void EEDPPAEHCMF(Rigidbody NMAIJIEBGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x536E9A0", Offset = "0x536D3A0", VA = "0x18536E9A0", Slot = "7")]
	public void IANIKNPGJKE(bool OMHEKMNNLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x536E9B0", Offset = "0x536D3B0", VA = "0x18536E9B0", Slot = "8")]
	public void JCLABJGBIGH(bool OMHEKMNNLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x536EAF0", Offset = "0x536D4F0", VA = "0x18536EAF0", Slot = "10")]
	public bool MCCMDLKNBFC(Vector3 PANBGKEJNBF, out RaycastHit EKBEEAKLGKG, float OEPBPFIFMKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x536E9C0", Offset = "0x536D3C0", VA = "0x18536E9C0")]
	private void MBBPPFCCNJD(bool OMHEKMNNLNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class MFJDIGODKOG : LOHCPIFOKBA, IDisposable, GNMELKHCPEM
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const int INLDPJGMNKD = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly EMAOEODIEEA MPLGHJJKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private FHGIMEJNAKL HAKAGMDOIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private JPCNLOFKBAB FEPKGGBJCJP;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public FHGIMEJNAKL BOHPADGHJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x5380F80", Offset = "0x537F980", VA = "0x185380F80", Slot = "6")]
		get
		{
			return default(FHGIMEJNAKL);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x5380DC0", Offset = "0x537F7C0", VA = "0x185380DC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Transform PECHNIMJGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x5381120", Offset = "0x537FB20", VA = "0x185381120", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<MDILDCKBKMK, MDILDCKBKMK> JMFOKJJIFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x5380EE0", Offset = "0x537F8E0", VA = "0x185380EE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x5380D20", Offset = "0x537F720", VA = "0x185380D20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x5381140", Offset = "0x537FB40", VA = "0x185381140")]
	public MFJDIGODKOG(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x5380A40", Offset = "0x537F440", VA = "0x185380A40", Slot = "8")]
	public void AKHIMNHIOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5380E90", Offset = "0x537F890", VA = "0x185380E90", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x53810C0", Offset = "0x537FAC0", VA = "0x1853810C0", Slot = "11")]
	private void MHCOGEBAHNE(MDILDCKBKMK IHKAOPFDPNM, MDILDCKBKMK NBMPKGLICDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "12")]
	private void BPHBEOLEPPB(bool BCEBIPIOINI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class HEAFNIHDIIA : CEHLNMEGNHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly EMAOEODIEEA MPLGHJJKMAH;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Rigidbody NGHLLPGFILB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x5360940", Offset = "0x535F340", VA = "0x185360940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private bool LLANJLNCMHP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x536F640", Offset = "0x536E040", VA = "0x18536F640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private bool GOECHKKAMDL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x536F690", Offset = "0x536E090", VA = "0x18536F690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private FINELKBJAJC NNHCCDNOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x536F6F0", Offset = "0x536E0F0", VA = "0x18536F6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x536EC60", Offset = "0x536D660", VA = "0x18536EC60")]
	public HEAFNIHDIIA(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x536ED40", Offset = "0x536D740", VA = "0x18536ED40", Slot = "4")]
	public void ADHPHHGGPFO(Vector3 GONNPACEKOP, ForceMode LLGEKNKAFEH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x536F750", Offset = "0x536E150", VA = "0x18536F750")]
	private void OHIJGALCACK(Vector3 GONNPACEKOP, ForceMode LLGEKNKAFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x536F120", Offset = "0x536DB20", VA = "0x18536F120", Slot = "5")]
	public void AKENGLILDKP(Vector3 GONNPACEKOP, Vector3 OAALNDIAAOB, ForceMode LLGEKNKAFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x536F9D0", Offset = "0x536E3D0", VA = "0x18536F9D0", Slot = "6")]
	public void ONFMLOBCLMC(Vector3 ALEOGDBLBAL, ForceMode LLGEKNKAFEH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x536EEA0", Offset = "0x536D8A0", VA = "0x18536EEA0")]
	private void AFPCJJGFHDO(Vector3 ALEOGDBLBAL, ForceMode LLGEKNKAFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x536F3C0", Offset = "0x536DDC0", VA = "0x18536F3C0", Slot = "7")]
	public void BMOHKBFEDIO(Vector3 ALEOGDBLBAL, ForceMode LLGEKNKAFEH = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class ILHMIHGODEN : EFCHMGFPPNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly EMAOEODIEEA MPLGHJJKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool JOONLGAEPGE;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool MNJCELLFCNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8D0", Offset = "0x6DA2D0", VA = "0x1806DB8D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x5373880", Offset = "0x5372280", VA = "0x185373880", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x536EC60", Offset = "0x536D660", VA = "0x18536EC60")]
	public ILHMIHGODEN(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x5373850", Offset = "0x5372250", VA = "0x185373850", Slot = "6")]
	public void EEDPPAEHCMF(Rigidbody NMAIJIEBGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x5362A90", Offset = "0x5361490", VA = "0x185362A90", Slot = "7")]
	public void MEBCMKNIKNA(Rigidbody NMAIJIEBGIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class MCJOFECIDPL : LILLONKMEHD, ALDDLAJCNDJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly FINELKBJAJC MPLGHJJKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<FINELKBJAJC> PFGJBHEKNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private FINELKBJAJC OFMDHDILEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private FINELKBJAJC ELGBIOMPEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Transform ONKDPAHCAAJ;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private Transform ONMPEEDNICF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x537FA30", Offset = "0x537E430", VA = "0x18537FA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public FINELKBJAJC NNHCCDNOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x6D7700", Offset = "0x6D6100", VA = "0x1806D7700", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x537FA20", Offset = "0x537E420", VA = "0x18537FA20", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public FINELKBJAJC PMIOODBJODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x6D7780", Offset = "0x6D6180", VA = "0x1806D7780", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public IReadOnlyList<FINELKBJAJC> DLHGIFABMAA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x6D7770", Offset = "0x6D6170", VA = "0x1806D7770", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event EOIGEIAJIKF EJLIAHAIONF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x537EE60", Offset = "0x537D860", VA = "0x18537EE60", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x537EFA0", Offset = "0x537D9A0", VA = "0x18537EFA0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event EOIGEIAJIKF DIJMKGIEGED
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x537F2D0", Offset = "0x537DCD0", VA = "0x18537F2D0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x5380360", Offset = "0x537ED60", VA = "0x185380360", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event KHIJGEMJFAG BHDKKEHCFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x53807B0", Offset = "0x537F1B0", VA = "0x1853807B0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x5380400", Offset = "0x537EE00", VA = "0x185380400", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action IIBADDINJBN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x537F040", Offset = "0x537DA40", VA = "0x18537F040", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x5380710", Offset = "0x537F110", VA = "0x185380710", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action IOECKPFCOLL
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x537F230", Offset = "0x537DC30", VA = "0x18537F230", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x537FD60", Offset = "0x537E760", VA = "0x18537FD60", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<FINELKBJAJC> NKBAGBFAOPH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x537FCC0", Offset = "0x537E6C0", VA = "0x18537FCC0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x537EF00", Offset = "0x537D900", VA = "0x18537EF00", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<FINELKBJAJC> MKBNLFLFJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x5380670", Offset = "0x537F070", VA = "0x185380670", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x5380060", Offset = "0x537EA60", VA = "0x185380060", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action KGNALDKPAGK
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x537F900", Offset = "0x537E300", VA = "0x18537F900", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x537FC20", Offset = "0x537E620", VA = "0x18537FC20", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<FINELKBJAJC> PNKIOGHFIOB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x537FA90", Offset = "0x537E490", VA = "0x18537FA90", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x53808F0", Offset = "0x537F2F0", VA = "0x1853808F0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x5380990", Offset = "0x537F390", VA = "0x185380990")]
	public MCJOFECIDPL(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x537F9A0", Offset = "0x537E3A0", VA = "0x18537F9A0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x537F370", Offset = "0x537DD70", VA = "0x18537F370", Slot = "30")]
	public void DGJAMCMEJGD(FINELKBJAJC DILGNCFGGHK, bool GJNGLKLPECL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x537FEA0", Offset = "0x537E8A0", VA = "0x18537FEA0", Slot = "6")]
	public void KEHJLBDFMGD(FINELKBJAJC MCCGBMECIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x53804A0", Offset = "0x537EEA0", VA = "0x1853804A0", Slot = "7")]
	public void MIHNIBNCJBA(FINELKBJAJC MCCGBMECIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x537FE00", Offset = "0x537E800", VA = "0x18537FE00", Slot = "4")]
	public void IBAFGGCIFCB(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x5380850", Offset = "0x537F250", VA = "0x185380850", Slot = "5")]
	public void ONHPMCGNOEF(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x537ED90", Offset = "0x537D790", VA = "0x18537ED90")]
	private void AFEJHCPIELH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x537EE20", Offset = "0x537D820", VA = "0x18537EE20")]
	private void AHFAOJLGMLP(FINELKBJAJC MCCGBMECIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x537F0E0", Offset = "0x537DAE0", VA = "0x18537F0E0")]
	private void BGBIJEADJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x5380230", Offset = "0x537EC30", VA = "0x185380230")]
	private void LBCPDMMOLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x5380100", Offset = "0x537EB00", VA = "0x185380100")]
	private void KPKNMPDBEAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x537FB30", Offset = "0x537E530", VA = "0x18537FB30")]
	[CompilerGenerated]
	private object HANLDPEGJEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class OGJHBOBBFBC
{
	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x6417C30", Offset = "0x6416630", VA = "0x186417C30")]
	public static LILLONKMEHD NHHBDODJKDO(this FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class HLEKMBHFLIC : PAFAEOFGLNK, NOHOJFFFHFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly EMAOEODIEEA MPLGHJJKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly global::PIEOFAGIBKK<FINELKBJAJC> LGHKCIDAILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool KJKMPNCMDJG;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public global::PIEOFAGIBKK<FINELKBJAJC> NOOCFJHLCIE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Vector3 DLHOKPCNDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x5370A40", Offset = "0x536F440", VA = "0x185370A40", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public Vector3 KHNHKEGICDO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x5370E20", Offset = "0x536F820", VA = "0x185370E20", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private Vector3 ABFNJJJIFJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x53710A0", Offset = "0x536FAA0", VA = "0x1853710A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public FINELKBJAJC BGDLBALHPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x5370FF0", Offset = "0x536F9F0", VA = "0x185370FF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x53711F0", Offset = "0x536FBF0", VA = "0x1853711F0")]
	public HLEKMBHFLIC(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x5371180", Offset = "0x536FB80", VA = "0x185371180", Slot = "8")]
	public void NPIEMEPDEKC(FINELKBJAJC ELGBIOMPEHN, object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x5370DC0", Offset = "0x536F7C0", VA = "0x185370DC0", Slot = "9")]
	public void FPCIKEFOMNG(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x5370A70", Offset = "0x536F470", VA = "0x185370A70")]
	private Vector3 FHLCHHHFCPD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x53706A0", Offset = "0x536F0A0", VA = "0x1853706A0")]
	private void AABEJECHCED(FINELKBJAJC LLPEDIIOIAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class PDMELLAMFHE
{
	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x6417CB0", Offset = "0x64166B0", VA = "0x186417CB0")]
	public static PAFAEOFGLNK OKFHHECMBBP(this FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class LDOJPHNPNMK : CELDBJDFJKP, KBKJLCPHENA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly EMAOEODIEEA MPLGHJJKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly OverridableVector3 PKFOLHABNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly OverridableVector3 GPJCMEMKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float IMELDNLFGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private float CNALKFMBGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Vector3 IBGDLACDKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Vector3? KCOOHIHBBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Quaternion? NKELJEENFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool GCNHPFDIPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool EDCONDGGGFH;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 IJDDNEDHONI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x1339CF0", Offset = "0x13386F0", VA = "0x181339CF0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x537DE00", Offset = "0x537C800", VA = "0x18537DE00", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 LDJDMCFGDHE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x537DC20", Offset = "0x537C620", VA = "0x18537DC20", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float LDIJJJKDKPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x1612260", Offset = "0x1610C60", VA = "0x181612260", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x537DB00", Offset = "0x537C500", VA = "0x18537DB00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public float JOFKNAMFKBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x11375E0", Offset = "0x1135FE0", VA = "0x1811375E0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x537D2E0", Offset = "0x537BCE0", VA = "0x18537D2E0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Vector3 BGAIPPJOAJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x537E840", Offset = "0x537D240", VA = "0x18537E840", Slot = "13")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x537D960", Offset = "0x537C360", VA = "0x18537D960", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public Quaternion HCJFINDADJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x537E0C0", Offset = "0x537CAC0", VA = "0x18537E0C0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x537D7C0", Offset = "0x537C1C0", VA = "0x18537D7C0", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody NGHLLPGFILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x53743B0", Offset = "0x5372DB0", VA = "0x1853743B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event EOIGEIAJIKF IEDFEDNDNHC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x537E630", Offset = "0x537D030", VA = "0x18537E630", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x537EC20", Offset = "0x537D620", VA = "0x18537EC20", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x537ECC0", Offset = "0x537D6C0", VA = "0x18537ECC0")]
	public LDOJPHNPNMK(FINELKBJAJC MPLGHJJKMAH, in GBAJKBMADFI NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x537DF00", Offset = "0x537C900", VA = "0x18537DF00", Slot = "18")]
	public void GMGCKIECDGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x537DE20", Offset = "0x537C820", VA = "0x18537DE20", Slot = "17")]
	public void GCGKMMPELCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x537DD20", Offset = "0x537C720", VA = "0x18537DD20", Slot = "20")]
	public void EEDPPAEHCMF(Rigidbody NMAIJIEBGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x537E390", Offset = "0x537CD90", VA = "0x18537E390", Slot = "21")]
	public void MEBCMKNIKNA(Rigidbody NMAIJIEBGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x537E6D0", Offset = "0x537D0D0", VA = "0x18537E6D0", Slot = "19")]
	public void NPIFIBABAPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x537D300", Offset = "0x537BD00", VA = "0x18537D300", Slot = "22")]
	public void AJAEADGGIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x537DE00", Offset = "0x537C800", VA = "0x18537DE00")]
	private void KLHFKODODKK(Vector3 MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x537EB30", Offset = "0x537D530", VA = "0x18537EB30")]
	private Vector3 PDOPNOOIHFG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x537DB00", Offset = "0x537C500", VA = "0x18537DB00")]
	private void OFALDBALNCH(float MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x537D2E0", Offset = "0x537BCE0", VA = "0x18537D2E0")]
	private void LOAMHNJDNGE(float MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x537E9B0", Offset = "0x537D3B0", VA = "0x18537E9B0")]
	private Vector3 OIMIGOLOKOH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x537D960", Offset = "0x537C360", VA = "0x18537D960")]
	private void CPAGBIGFEFO(Vector3 MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x537E230", Offset = "0x537CC30", VA = "0x18537E230")]
	private Quaternion KCEKPGFKJJM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x537D7C0", Offset = "0x537C1C0", VA = "0x18537D7C0")]
	private void GOFBKBJPICO(Quaternion MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x537D200", Offset = "0x537BC00", VA = "0x18537D200")]
	public void AEPHKDOHKHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x537C340", Offset = "0x537AD40", VA = "0x18537C340", Slot = "4")]
	public (float, Vector3) AEPHKDOHKHK(Rigidbody KPJFDHAOIKF)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class GPPEELNNFCP
{
	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x536E5C0", Offset = "0x536CFC0", VA = "0x18536E5C0")]
	public static CELDBJDFJKP EKHBIACKGEF(this FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class HGINPFMBPHD : DPLEFMDCHAK
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private const string ALDBBCFEPFC = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly EMAOEODIEEA MPLGHJJKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly AJDDIJFCKOM PHDKNOHEHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly IHGNHGBDMIK JEFJOFCHGBL;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool JBMIBNPELKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x116FBB0", Offset = "0x116E5B0", VA = "0x18116FBB0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public IHGNHGBDMIK OMDDDNFJDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x6C1010", Offset = "0x6BFA10", VA = "0x1806C1010", Slot = "5")]
		get
		{
			return default(IHGNHGBDMIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x53705B0", Offset = "0x536EFB0", VA = "0x1853705B0")]
	public HGINPFMBPHD(FINELKBJAJC MPLGHJJKMAH, in GBAJKBMADFI NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x536FFA0", Offset = "0x536E9A0", VA = "0x18536FFA0", Slot = "6")]
	public void AKHIMNHIOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x5370510", Offset = "0x536EF10", VA = "0x185370510")]
	private bool OFDDANKCCEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x53703B0", Offset = "0x536EDB0", VA = "0x1853703B0", Slot = "7")]
	public void JJHDJKEBOLP(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x53700B0", Offset = "0x536EAB0", VA = "0x1853700B0", Slot = "8")]
	public void CDMHBJANAKM(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x53703E0", Offset = "0x536EDE0", VA = "0x1853703E0", Slot = "11")]
	public void JJMJBENMNKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x5370260", Offset = "0x536EC60", VA = "0x185370260")]
	private void FGGOIJHNOLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x53700E0", Offset = "0x536EAE0", VA = "0x1853700E0")]
	private void EIIBPMJCCKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x5370070", Offset = "0x536EA70", VA = "0x185370070", Slot = "10")]
	public void BKELDDDHEDA(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x5370370", Offset = "0x536ED70", VA = "0x185370370", Slot = "9")]
	public void ILCODHFGIJP(FINELKBJAJC MPLGHJJKMAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class ICJAIOCBLBP : OBIFGANNEIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly EMAOEODIEEA MPLGHJJKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly AJDDIJFCKOM DMAIOOOINLC;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool LLANJLNCMHP
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x5373420", Offset = "0x5371E20", VA = "0x185373420", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IEnumerable<object> HENALIPPCOD
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x5373650", Offset = "0x5372050", VA = "0x185373650", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event EOIGEIAJIKF CPLFJIEMCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x5373580", Offset = "0x5371F80", VA = "0x185373580", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x53734E0", Offset = "0x5371EE0", VA = "0x1853734E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x5373770", Offset = "0x5372170", VA = "0x185373770")]
	public ICJAIOCBLBP(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x53733C0", Offset = "0x5371DC0", VA = "0x1853733C0", Slot = "11")]
	public IDisposable EFJNJIADBJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x5373260", Offset = "0x5371C60", VA = "0x185373260", Slot = "8")]
	public void CKHNMOAIKKF(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x5373250", Offset = "0x5371C50", VA = "0x185373250", Slot = "9")]
	public void AFOJJCPKDKC(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x5373670", Offset = "0x5372070", VA = "0x185373670", Slot = "10")]
	public void NMBFJKGLMLM(object DEGCIHEAIBD, bool MPIEKKDMKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x5373340", Offset = "0x5371D40", VA = "0x185373340", Slot = "12")]
	public void EEDPPAEHCMF(Rigidbody NIGLNONICLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x5373620", Offset = "0x5372020", VA = "0x185373620", Slot = "13")]
	public void MEBCMKNIKNA(Rigidbody NMAIJIEBGIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class KCNLEILAKEB : GIKAJKOLDEH, FOABFNIFJAA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly EMAOEODIEEA MPLGHJJKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private PhotonView HGNNDDBGCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool KLPNAKNBDDP;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public PhotonView HDCKANIMFMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool BKLEDPDFLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x5366EB0", Offset = "0x53658B0", VA = "0x185366EB0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool FBANMELJCLP
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F80", Offset = "0x7B0980", VA = "0x1807B1F80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event EOIGEIAJIKF AKILOILIGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x53768C0", Offset = "0x53752C0", VA = "0x1853768C0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x5376AF0", Offset = "0x53754F0", VA = "0x185376AF0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x5376D10", Offset = "0x5375710", VA = "0x185376D10")]
	public KCNLEILAKEB(FINELKBJAJC MPLGHJJKMAH, in GBAJKBMADFI NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x53760E0", Offset = "0x5374AE0", VA = "0x1853760E0", Slot = "9")]
	public void AKHIMNHIOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x5376230", Offset = "0x5374C30", VA = "0x185376230", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x5376340", Offset = "0x5374D40", VA = "0x185376340", Slot = "10")]
	public void ELJFDCONCDI(FINELKBJAJC ELGBIOMPEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x5376960", Offset = "0x5375360", VA = "0x185376960", Slot = "11")]
	public void JMJFGKIDBLA(FINELKBJAJC ELGBIOMPEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x5376B90", Offset = "0x5375590", VA = "0x185376B90")]
	private void OGLDEBELHNI(PhotonView KJPEIALICOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x53764D0", Offset = "0x5374ED0", VA = "0x1853764D0")]
	private void FFJDKHOLJJC(RigidbodyEx NNOOGFBCAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x5376640", Offset = "0x5375040", VA = "0x185376640")]
	private void GHHPAMPIDCM(PhotonView AIKKOEKCJCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class KCDJJPGJNPN
{
	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x5376020", Offset = "0x5374A20", VA = "0x185376020")]
	public static GIKAJKOLDEH KHLEHGMJHFA(this FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class KEGHGIOMCIG : JGIJDMAANMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly EMAOEODIEEA MPLGHJJKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private RigidbodyConstraints NHPBJPFJGOK;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool HJNDJLEEIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xA43B30", Offset = "0xA42530", VA = "0x180A43B30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x2691D00", Offset = "0x2690700", VA = "0x182691D00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool BNIFPAGGLMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x2691CD0", Offset = "0x26906D0", VA = "0x182691CD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x2691CC0", Offset = "0x26906C0", VA = "0x182691CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public RigidbodyConstraints JGJHMHEFNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6C2BD0", Offset = "0x6C15D0", VA = "0x1806C2BD0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x5377410", Offset = "0x5375E10", VA = "0x185377410", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x5377580", Offset = "0x5375F80", VA = "0x185377580")]
	public KEGHGIOMCIG(FINELKBJAJC MPLGHJJKMAH, in GBAJKBMADFI NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x53773E0", Offset = "0x5375DE0", VA = "0x1853773E0", Slot = "9")]
	public void EEDPPAEHCMF(Rigidbody NMAIJIEBGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x5377550", Offset = "0x5375F50", VA = "0x185377550", Slot = "10")]
	public void MEBCMKNIKNA(Rigidbody NMAIJIEBGIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class HLMMNDLLCAE : DNGEAFOGJME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly FINELKBJAJC MPLGHJJKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private float JAFDEMBADIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float EILAHENKJDI;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public float CBCHKHFNIJP
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x11DE660", Offset = "0x11DD060", VA = "0x1811DE660", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x5371330", Offset = "0x536FD30", VA = "0x185371330", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public float BKOJANHELNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xF3B940", Offset = "0xF3A340", VA = "0x180F3B940", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x5371400", Offset = "0x536FE00", VA = "0x185371400", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x5371570", Offset = "0x536FF70", VA = "0x185371570")]
	public HLMMNDLLCAE(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x53712E0", Offset = "0x536FCE0", VA = "0x1853712E0", Slot = "8")]
	public void EEDPPAEHCMF(Rigidbody NMAIJIEBGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x53714D0", Offset = "0x536FED0", VA = "0x1853714D0", Slot = "9")]
	public void MEBCMKNIKNA(Rigidbody NMAIJIEBGIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class JBLPCNLGIAF : CHNFBMHLJMH
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private const int EOEFGFGBDCC = 10;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const float DKGOCGFBEHL = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const float HKIBFKHPNFH = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private const float CDOEFLALDDL = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly EMAOEODIEEA MPLGHJJKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool AKLKALEJMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool AAABDOJIBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int OOODMJIDANK;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private Rigidbody NGHLLPGFILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x53743B0", Offset = "0x5372DB0", VA = "0x1853743B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private bool BJMNABPBBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x5374F40", Offset = "0x5373940", VA = "0x185374F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private bool NNINDJDOIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x5374FF0", Offset = "0x53739F0", VA = "0x185374FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private FINELKBJAJC NNHCCDNOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x5374E40", Offset = "0x5373840", VA = "0x185374E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool GOECHKKAMDL
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x53748C0", Offset = "0x53732C0", VA = "0x1853748C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event EOIGEIAJIKF AOKABOPPDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x5374EA0", Offset = "0x53738A0", VA = "0x185374EA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x5374400", Offset = "0x5372E00", VA = "0x185374400", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5375010", Offset = "0x5373A10", VA = "0x185375010")]
	public JBLPCNLGIAF(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5374320", Offset = "0x5372D20", VA = "0x185374320", Slot = "6")]
	public void AKHIMNHIOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5374FE0", Offset = "0x53739E0", VA = "0x185374FE0", Slot = "8")]
	public void OPDMIIBMDPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x5374920", Offset = "0x5373320", VA = "0x185374920", Slot = "7")]
	public bool KHIMNPKKOOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x5374A70", Offset = "0x5373470", VA = "0x185374A70", Slot = "9")]
	public void MHHNJOOIKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x5374650", Offset = "0x5373050", VA = "0x185374650", Slot = "11")]
	public void FADGJLPBHGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x53746F0", Offset = "0x53730F0", VA = "0x1853746F0", Slot = "12")]
	public void FHHCHNDGGHH(bool JKOMJKKMCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5374B10", Offset = "0x5373510", VA = "0x185374B10", Slot = "10")]
	public void NHIMCHDCAII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x53744A0", Offset = "0x5372EA0", VA = "0x1853744A0")]
	private bool EDFELAJFLOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x5374730", Offset = "0x5373130", VA = "0x185374730")]
	private void JAGJIOGAADF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class HMPGKLADNED : IPLCEEKLLAN
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const string MABOMMFMPLF = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly EMAOEODIEEA MPLGHJJKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly AJDDIJFCKOM GKDEAHBGJGK;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Rigidbody NGHLLPGFILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x6C2130", Offset = "0x6C0B30", VA = "0x1806C2130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private bool GOECHKKAMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x536F690", Offset = "0x536E090", VA = "0x18536F690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x53730D0", Offset = "0x5371AD0", VA = "0x1853730D0")]
	public HMPGKLADNED(FINELKBJAJC MPLGHJJKMAH, in GBAJKBMADFI NIPBPKPBPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x53720E0", Offset = "0x5370AE0", VA = "0x1853720E0", Slot = "5")]
	public void AKHIMNHIOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5372CF0", Offset = "0x53716F0", VA = "0x185372CF0", Slot = "6")]
	public void HNKAHGBLMFG(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x5372190", Offset = "0x5370B90", VA = "0x185372190", Slot = "7")]
	public void BOKFPLECABM(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x53724F0", Offset = "0x5370EF0", VA = "0x1853724F0", Slot = "8")]
	public void EKMLDDLGAHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x5372ED0", Offset = "0x53718D0", VA = "0x185372ED0", Slot = "9")]
	public void OEOFELGGEJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x53721C0", Offset = "0x5370BC0", VA = "0x1853721C0", Slot = "10")]
	public void CJJBBLKMCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x5372850", Offset = "0x5371250", VA = "0x185372850", Slot = "11")]
	public void HBCINAGAAFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5372D20", Offset = "0x5371720", VA = "0x185372D20")]
	private void JBMOLNOAMPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x5372340", Offset = "0x5370D40", VA = "0x185372340")]
	private void CPNOCLFIODB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class COKDBPLDLGK : HHEJEAPJBJM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly EMAOEODIEEA MPLGHJJKMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly AJDDIJFCKOM NNPGOIFEBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float MDHHAELGDAI;

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public AAGBILKCEFJ HJMCHGKOFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8E0", Offset = "0x6DA2E0", VA = "0x1806DB8E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x7031C0", Offset = "0x701BC0", VA = "0x1807031C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public HPBKAAPNIDE JFIJDPHAPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x759AE0", Offset = "0x7584E0", VA = "0x180759AE0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public Vector3 ABFNJJJIFJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x5365BD0", Offset = "0x53645D0", VA = "0x185365BD0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x53651E0", Offset = "0x5363BE0", VA = "0x1853651E0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public Vector3 DMDIOGFKLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x53645A0", Offset = "0x5362FA0", VA = "0x1853645A0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x5364F40", Offset = "0x5363940", VA = "0x185364F40", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 EIFGBJCCKOP
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x5363FF0", Offset = "0x53629F0", VA = "0x185363FF0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x53633D0", Offset = "0x5361DD0", VA = "0x1853633D0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public Vector3 AEHCEPOJINK
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x5364E50", Offset = "0x5363850", VA = "0x185364E50", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x5366150", Offset = "0x5364B50", VA = "0x185366150", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public float GPJNEDFLKLN
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x1612290", Offset = "0x1610C90", VA = "0x181612290", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x5365AB0", Offset = "0x53644B0", VA = "0x185365AB0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public bool DADGANMPJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x20C7790", Offset = "0x20C6190", VA = "0x1820C7790", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private CEHLNMEGNHL HGMILGJMKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x1D16570", Offset = "0x1D14F70", VA = "0x181D16570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private bool NNINDJDOIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x5361870", Offset = "0x5360270", VA = "0x185361870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x5366180", Offset = "0x5364B80", VA = "0x185366180")]
	public COKDBPLDLGK(FINELKBJAJC MPLGHJJKMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x5363490", Offset = "0x5361E90", VA = "0x185363490", Slot = "19")]
	public void AKHIMNHIOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x5364690", Offset = "0x5363090", VA = "0x185364690", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x53646F0", Offset = "0x53630F0", VA = "0x1853646F0", Slot = "28")]
	public void EEDPPAEHCMF(Rigidbody NMAIJIEBGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x20C6DD0", Offset = "0x20C57D0", VA = "0x1820C6DD0", Slot = "20")]
	public void EDACDIJGMDM(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x20C6DF0", Offset = "0x20C57F0", VA = "0x1820C6DF0", Slot = "31")]
	public void MHHGHPEHPOJ(object DEGCIHEAIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x5365F70", Offset = "0x5364970", VA = "0x185365F70", Slot = "36")]
	public Vector3 ONCHFGBOPNN(Vector3 KFMEEFJANFE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x5363E30", Offset = "0x5362830", VA = "0x185363E30", Slot = "35")]
	public Vector3 CFNAJGAOBEF(Vector3 EGKOABIGCEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x5363490", Offset = "0x5361E90", VA = "0x185363490", Slot = "27")]
	public void LIJHHFDNMII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x5364F70", Offset = "0x5363970", VA = "0x185364F70", Slot = "25")]
	public void HOCINLNMKAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x5365CF0", Offset = "0x53646F0", VA = "0x185365CF0", Slot = "24")]
	public void NHIOLLFNDEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x5365D30", Offset = "0x5364730", VA = "0x185365D30", Slot = "34")]
	public void ODBDKBKNKKH(Vector3 KNMAKDBFNDP, Vector3 JGIOFMHEJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5364540", Offset = "0x5362F40", VA = "0x185364540", Slot = "33")]
	public void DGDDFJLDGHA(Vector3 HAOHPFICBPO, Vector3 HHCGJCNNJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x53650A0", Offset = "0x5363AA0", VA = "0x1853650A0", Slot = "32")]
	public void IGKKCOIIJPE(Vector3 LBJDLPFBLAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x53652A0", Offset = "0x5363CA0", VA = "0x1853652A0", Slot = "22")]
	public void MAFJLECBAJB(GFNIKGHNFMK NDCODNFDBDL, Vector3 BKCKHNNPBPN, float FDLFHFCEKLG, float BCPPBALBKDI = 8f, float HDGDBBFNACP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x5364820", Offset = "0x5363220", VA = "0x185364820", Slot = "21")]
	public void EIOODGJPGNH(BAPDLIMMIEJ DFBKFCMOCAB, Vector3 KHAIFHDNCAN, float DHGAEJJNMPB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x53656F0", Offset = "0x53640F0", VA = "0x1853656F0", Slot = "23")]
	[Obsolete]
	public void MJJKJNEOFFA(BAPDLIMMIEJ DFBKFCMOCAB, Vector3 HOOCPOKGFMC, float NHJDIFFEONI = 7f, float MKKFGBEOHMB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x5363C30", Offset = "0x5362630", VA = "0x185363C30", Slot = "30")]
	public Vector3 BMOCCKOACNL(Vector3 DDEOINEGECJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x53659C0", Offset = "0x53643C0", VA = "0x1853659C0", Slot = "29")]
	public Vector3 MKMPALOPNCI(Vector3 AMIMCOHFMAN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x5363B00", Offset = "0x5362500", VA = "0x185363B00", Slot = "26")]
	public void BCGKFGHJEGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x5365AB0", Offset = "0x53644B0", VA = "0x185365AB0")]
	private void OKNAAJMEFPA(float MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x5363CF0", Offset = "0x53626F0", VA = "0x185363CF0")]
	private void BOEMFBCPDEL(Vector3 KHAIFHDNCAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x5364450", Offset = "0x5362E50", VA = "0x185364450")]
	private Vector3 DDHCLKBNCMH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x5364120", Offset = "0x5362B20", VA = "0x185364120")]
	private void CGPEHBMEAFE(Vector3 EGKOABIGCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x5364FB0", Offset = "0x53639B0", VA = "0x185364FB0")]
	private Vector3 HPIGFNACKGG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x5364A50", Offset = "0x5363450", VA = "0x185364A50")]
	private void EJOFIKNOGMA(Vector3 MNIAGKNOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x5363500", Offset = "0x5361F00", VA = "0x185363500")]
	private void AMFPDAMLGBL(Vector3 EGKOABIGCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x5364D90", Offset = "0x5363790", VA = "0x185364D90")]
	private void FLMPPENOHBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class MGODGEHLJGL : PGDLJBLFBNG
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x5381BA0", Offset = "0x53805A0", VA = "0x185381BA0", Slot = "4")]
	public ALDDLAJCNDJ KJLFNJLJKGO(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x53819D0", Offset = "0x53803D0", VA = "0x1853819D0", Slot = "5")]
	public HHEJEAPJBJM IJIONEIJDFG(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x53816F0", Offset = "0x53800F0", VA = "0x1853816F0", Slot = "6")]
	public NOHOJFFFHFH GGIMKEHLCFJ(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x5381E30", Offset = "0x5380830", VA = "0x185381E30", Slot = "7")]
	public DNGEAFOGJME NBFNLDDJHLF(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x5381EA0", Offset = "0x53808A0", VA = "0x185381EA0", Slot = "8")]
	public CHNFBMHLJMH PHDCAMEIJBD(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x5381AE0", Offset = "0x53804E0", VA = "0x185381AE0", Slot = "9")]
	public LOHCPIFOKBA KCKGECDIJAH(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x5381D30", Offset = "0x5380730", VA = "0x185381D30", Slot = "10")]
	public OBIFGANNEIA MOBIIGHHKNC(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x5381800", Offset = "0x5380200", VA = "0x185381800", Slot = "11")]
	public CEHLNMEGNHL GHEMBNKCOOB(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x5381C80", Offset = "0x5380680", VA = "0x185381C80", Slot = "12")]
	public PBGEAABGDLG LAGLKODAAHG(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x5381640", Offset = "0x5380040", VA = "0x185381640", Slot = "13")]
	public EFCHMGFPPNG DJDAINJJJMD(FINELKBJAJC GCIFBDHGBMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x53818B0", Offset = "0x53802B0", VA = "0x1853818B0")]
	public IPLCEEKLLAN HIFIDCFLLFP(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x53811D0", Offset = "0x537FBD0", VA = "0x1853811D0")]
	public FOABFNIFJAA GLHDBOGCFCL(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x5381520", Offset = "0x537FF20", VA = "0x185381520")]
	public DPLEFMDCHAK FGJEKHEKKKJ(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x53812A0", Offset = "0x537FCA0", VA = "0x1853812A0")]
	public KBKJLCPHENA NJIHJIBLCFE(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x53813A0", Offset = "0x537FDA0", VA = "0x1853813A0")]
	public JGIJDMAANMH JEOFLAOFKFI(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x5381470", Offset = "0x537FE70", VA = "0x185381470", Slot = "19")]
	public FINELKBJAJC BHAAGIJHAHG(RigidbodyEx MPLGHJJKMAH, GBAJKBMADFI NIPBPKPBPPP, AHOEMGMJFLI MPEBEBMNLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public MGODGEHLJGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x53818B0", Offset = "0x53802B0", VA = "0x1853818B0", Slot = "14")]
	private IPLCEEKLLAN JMKCMGAOACA(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x53811D0", Offset = "0x537FBD0", VA = "0x1853811D0", Slot = "15")]
	private FOABFNIFJAA ACCLENEBICL(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x5381520", Offset = "0x537FF20", VA = "0x185381520", Slot = "16")]
	private DPLEFMDCHAK DCOPAPAFOOI(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x53812A0", Offset = "0x537FCA0", VA = "0x1853812A0", Slot = "17")]
	private KBKJLCPHENA AFBKJIFFIDE(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x53813A0", Offset = "0x537FDA0", VA = "0x1853813A0", Slot = "18")]
	private JGIJDMAANMH BFAAOKKIEHG(FINELKBJAJC GCIFBDHGBMN, in GBAJKBMADFI NIPBPKPBPPP)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[Preserve]
	internal class _RRAssemblyIndex : NMOBLBLJIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B40", Offset = "0x6C1540", VA = "0x1806C2B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x641E1F0", Offset = "0x641CBF0", VA = "0x18641E1F0", Slot = "6")]
		public sealed override void EPCHFMECFAE(HCFBHIJDBLF JOIALDGLEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x641E160", Offset = "0x641CB60", VA = "0x18641E160", Slot = "4")]
		public sealed override void DBHAPDCLOEH()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class KEBPIDDMFLP
{
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static byte[] PACJNBAODEE;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static int CIPMBADAHHP;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static int EAOHPIEEBJK;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static BigInteger CAFOPFCNDHG;

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KEBPIDDMFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x5377100", Offset = "0x5375B00", VA = "0x185377100")]
	private static string PBGMOKJNJDM(byte[] DLAMIJMLOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x5376DB0", Offset = "0x53757B0", VA = "0x185376DB0")]
	public static string NPAMJBENNGG(byte[] FMIGDHLBIKP, bool BLHGHBBBDBI)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
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
