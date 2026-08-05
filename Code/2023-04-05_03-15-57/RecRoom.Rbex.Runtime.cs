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
internal class JDKKAPPEDAP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public const string LOKINKCCMNG = "RBEX_DEFAULT";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const float LIFMLGJABEH = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public const float FBKIPHDOJLB = 0f;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public const float BNJGKBDEOEC = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public JDKKAPPEDAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void ONKEIMPDALF(RigidbodyEx FECMCLMNIMM);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void BAPGIHMPHAC(RigidbodyEx FECMCLMNIMM, bool GMEFKHHIEPP = false);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OBJOKHNKAPP
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum AONMFLABHAI
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum EKKHOJNPNMO
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GMNGKCNLIOO : OOGGPHHIOEI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AIJNJANHJAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6DF040", Offset = "0x6DE040", VA = "0x1806DF040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ACKDKGMHFHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F5790", Offset = "0x6F4790", VA = "0x1806F5790", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E6170", Offset = "0x6E5170", VA = "0x1806E6170", Slot = "6")]
	public GMJLIEJPOEJ PHAEAJEKMNM(float NGOKMEGFDGA)
	{
		return default(GMJLIEJPOEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "7")]
	public void GBJBCHALJOG(NFBHMIKCNHJ AELIHOPICED, float ANAMGBGEMJA, LCKOHGIHFDM OFGFMHCEFLE = LCKOHGIHFDM.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "8")]
	public void GBJBCHALJOG(NFBHMIKCNHJ AELIHOPICED, Transform ODGIIEPIGAJ, float ANAMGBGEMJA, LCKOHGIHFDM OFGFMHCEFLE = LCKOHGIHFDM.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "9")]
	public void HPKOMPPMIMN(NFBHMIKCNHJ AELIHOPICED, [Optional] float? ANAMGBGEMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "10")]
	public void PMMODKPOELK(NFBHMIKCNHJ JCHEIJOMOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6E6170", Offset = "0x6E5170", VA = "0x1806E6170", Slot = "11")]
	public GMJLIEJPOEJ MJPFNFLEHLA(NFBHMIKCNHJ AELIHOPICED)
	{
		return default(GMJLIEJPOEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x700020", Offset = "0x6FF020", VA = "0x180700020", Slot = "12")]
	public bool HOOAGMBBGPL(NFBHMIKCNHJ AELIHOPICED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "13")]
	public void BJBIJOPKCKP(NFBHMIKCNHJ AELIHOPICED, LCKOHGIHFDM MLADFEEADKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public GMNGKCNLIOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[IABFONFHPFO(typeof(CNGJPACLCIB), new string[] { "Ignore", "Mock" })]
public class OPECJIGNBKK : CNGJPACLCIB
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GCJCCEAHAAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6E3250", Offset = "0x6E2250", VA = "0x1806E3250", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
	public void DKHDOIMNAHA(string CNMFEBEOFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "6")]
	public void CPPGLFMFABI(RigidbodyEx LKMGIJIPLIN, Action FFBLFKDINEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E6170", Offset = "0x6E5170", VA = "0x1806E6170", Slot = "7")]
	public OOGGPHHIOEI OBBKIDKKMBA(int MGDHNMJCIFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "8")]
	public void PHPLIKONAJP(Vector3 KJOMJOHPAIM, float KHOELGGJGBI, Color LDFNLMPJEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public OPECJIGNBKK()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	[OHGELDJCNJM(GGAOONGBEBH.Physics)]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool HMGJGFNHBLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private PEMJBFLGGMM PKHJCMCBPFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[IKGEDHPILMJ(LNNFGJICGEC.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[IKGEDHPILMJ(LNNFGJICGEC.SelfAndParent, true, false, false)]
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
		private AONMFLABHAI physicsInterpolation;

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
		internal PEMJBFLGGMM IPKNMKDFBPN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6619A30", Offset = "0x6618A30", VA = "0x186619A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<RigidbodyEx> BIMGCBEFPGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6F5770", Offset = "0x6F4770", VA = "0x1806F5770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x780AD0", Offset = "0x77FAD0", VA = "0x180780AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx HJFIOMOEOKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x661BB20", Offset = "0x661AB20", VA = "0x18661BB20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx IMFMPPONFAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x661BAC0", Offset = "0x661AAC0", VA = "0x18661BAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public RigidbodyEx OKMBLMILFGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x661C680", Offset = "0x661B680", VA = "0x18661C680")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x661DDD0", Offset = "0x661CDD0", VA = "0x18661DDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform AAMHCPKDGML
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1885ED0", Offset = "0x1884ED0", VA = "0x181885ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform GFCCGCABKON
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1885ED0", Offset = "0x1884ED0", VA = "0x181885ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public LCKOHGIHFDM JLBHGNPAHLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x661B7B0", Offset = "0x661A7B0", VA = "0x18661B7B0")]
			get
			{
				return default(LCKOHGIHFDM);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x661D370", Offset = "0x661C370", VA = "0x18661D370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool DHECOBNPECP
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x661BD30", Offset = "0x661AD30", VA = "0x18661BD30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool PGDDLMMJJIL
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x661B940", Offset = "0x661A940", VA = "0x18661B940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public CCEJFGGKGLM CPIHALLPKPB
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x661BCD0", Offset = "0x661ACD0", VA = "0x18661BCD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x661D580", Offset = "0x661C580", VA = "0x18661D580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GGBMPGNAFJD OPABPNIHPDI
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x661BC70", Offset = "0x661AC70", VA = "0x18661BC70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x661D510", Offset = "0x661C510", VA = "0x18661D510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool ACGMNKMENFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x661BB50", Offset = "0x661AB50", VA = "0x18661BB50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Rigidbody OCHJHJGKDEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x661BBB0", Offset = "0x661ABB0", VA = "0x18661BBB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool ELDBHBFKIGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x661BA00", Offset = "0x661AA00", VA = "0x18661BA00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x661D430", Offset = "0x661C430", VA = "0x18661D430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool MPAFDMHBAIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3A68400", Offset = "0x3A67400", VA = "0x183A68400")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3A683D0", Offset = "0x3A673D0", VA = "0x183A683D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float ICHMOGPIDMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x661C620", Offset = "0x661B620", VA = "0x18661C620")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float ADJBEFMGEJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x661C5C0", Offset = "0x661B5C0", VA = "0x18661C5C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x661DD60", Offset = "0x661CD60", VA = "0x18661DD60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float FAFJFMCOIOO
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x661BF90", Offset = "0x661AF90", VA = "0x18661BF90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x661D820", Offset = "0x661C820", VA = "0x18661D820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float PNHAJHONKIF
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x661BD90", Offset = "0x661AD90", VA = "0x18661BD90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x661D5F0", Offset = "0x661C5F0", VA = "0x18661D5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool BMOGOGGFIGA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x661CBA0", Offset = "0x661BBA0", VA = "0x18661CBA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x661E310", Offset = "0x661D310", VA = "0x18661E310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 MKPLIDDMPHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x661C3A0", Offset = "0x661B3A0", VA = "0x18661C3A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x661DB30", Offset = "0x661CB30", VA = "0x18661DB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 KJOMJOHPAIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x661CCE0", Offset = "0x661BCE0", VA = "0x18661CCE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CollisionDetectionMode KBIGAPDAFHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x661BED0", Offset = "0x661AED0", VA = "0x18661BED0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x661D740", Offset = "0x661C740", VA = "0x18661D740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float FCAAJGFAJEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x661BA60", Offset = "0x661AA60", VA = "0x18661BA60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x661D4A0", Offset = "0x661C4A0", VA = "0x18661D4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public RigidbodyConstraints CKKHKJALDEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x661BF30", Offset = "0x661AF30", VA = "0x18661BF30")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x661D7B0", Offset = "0x661C7B0", VA = "0x18661D7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 AKKIDKDDCDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x661C6E0", Offset = "0x661B6E0", VA = "0x18661C6E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 KNFOOAPBKFA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x661C6E0", Offset = "0x661B6E0", VA = "0x18661C6E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x661E0E0", Offset = "0x661D0E0", VA = "0x18661E0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float JGMCCEBCOIP
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x661C480", Offset = "0x661B480", VA = "0x18661C480")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x661DC10", Offset = "0x661CC10", VA = "0x18661DC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float AEIEKJBHCEM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x661CB40", Offset = "0x661BB40", VA = "0x18661CB40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x661E2A0", Offset = "0x661D2A0", VA = "0x18661E2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion NLPAKBHPNJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x661C7C0", Offset = "0x661B7C0", VA = "0x18661C7C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x661DE40", Offset = "0x661CE40", VA = "0x18661DE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion NLCKBACAMDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x661CA60", Offset = "0x661BA60", VA = "0x18661CA60")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x661E1C0", Offset = "0x661D1C0", VA = "0x18661E1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 DNNFLEKACON
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x661C8A0", Offset = "0x661B8A0", VA = "0x18661C8A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x661DF20", Offset = "0x661CF20", VA = "0x18661DF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Quaternion DOCMMADAPJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x661C980", Offset = "0x661B980", VA = "0x18661C980")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x661E000", Offset = "0x661D000", VA = "0x18661E000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 FJHEIJDCBEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x661CC00", Offset = "0x661BC00", VA = "0x18661CC00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x661E380", Offset = "0x661D380", VA = "0x18661E380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 FEAFOIFGCCF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x661C4E0", Offset = "0x661B4E0", VA = "0x18661C4E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x661DC80", Offset = "0x661CC80", VA = "0x18661DC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 BAMHFNACLOC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x661BDF0", Offset = "0x661ADF0", VA = "0x18661BDF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x661D660", Offset = "0x661C660", VA = "0x18661D660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 IMCNKNPLDHH
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x661C2C0", Offset = "0x661B2C0", VA = "0x18661C2C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x661DA50", Offset = "0x661CA50", VA = "0x18661DA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 MIDKEEPKLBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x661C180", Offset = "0x661B180", VA = "0x18661C180")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x661D970", Offset = "0x661C970", VA = "0x18661D970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Quaternion FAGMBLNKBPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x661C0A0", Offset = "0x661B0A0", VA = "0x18661C0A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x661D890", Offset = "0x661C890", VA = "0x18661D890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 NCENLNJDPOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x661CEA0", Offset = "0x661BEA0", VA = "0x18661CEA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 AGCBGLLKCBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x661CDC0", Offset = "0x661BDC0", VA = "0x18661CDC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool BJPNLAHPGHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x661C260", Offset = "0x661B260", VA = "0x18661C260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool CEEGNNLCJLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x661B9A0", Offset = "0x661A9A0", VA = "0x18661B9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool CPPIJLCAPKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x661B8E0", Offset = "0x661A8E0", VA = "0x18661B8E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool GBCOKGPNABB
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x661B880", Offset = "0x661A880", VA = "0x18661B880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool DCOIJAMPGBE
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x661B750", Offset = "0x661A750", VA = "0x18661B750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool EBCDPIHLHKO
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x661BFF0", Offset = "0x661AFF0", VA = "0x18661BFF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool LCLDHDEMAPD
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7775A0", Offset = "0x7765A0", VA = "0x1807775A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event ONKEIMPDALF JBPALIFIJAG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x661B670", Offset = "0x661A670", VA = "0x18661B670")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x661D290", Offset = "0x661C290", VA = "0x18661D290")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event BAPGIHMPHAC MNLCKCJOLFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x661B600", Offset = "0x661A600", VA = "0x18661B600")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x661D220", Offset = "0x661C220", VA = "0x18661D220")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ONKEIMPDALF FGKDCAIOBOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x661B360", Offset = "0x661A360", VA = "0x18661B360")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x661CF80", Offset = "0x661BF80", VA = "0x18661CF80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event ONKEIMPDALF BJBFJNEGDJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x661B3D0", Offset = "0x661A3D0", VA = "0x18661B3D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x661CFF0", Offset = "0x661BFF0", VA = "0x18661CFF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event ONKEIMPDALF BPFDNFOMPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x661B520", Offset = "0x661A520", VA = "0x18661B520")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x661D140", Offset = "0x661C140", VA = "0x18661D140")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<GMJLIEJPOEJ, GMJLIEJPOEJ> BKPNGAGNMKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x661B4B0", Offset = "0x661A4B0", VA = "0x18661B4B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x661D0D0", Offset = "0x661C0D0", VA = "0x18661D0D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event ONKEIMPDALF KFBNIOPGCLI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x661B590", Offset = "0x661A590", VA = "0x18661B590")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x661D1B0", Offset = "0x661C1B0", VA = "0x18661D1B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event ONKEIMPDALF DECLPAEMMEC
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x661B6E0", Offset = "0x661A6E0", VA = "0x18661B6E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x661D300", Offset = "0x661C300", VA = "0x18661D300")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event ONKEIMPDALF JFGDBEMBLMM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x661B440", Offset = "0x661A440", VA = "0x18661B440")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x661D060", Offset = "0x661C060", VA = "0x18661D060")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0130", Offset = "0x6DF130", VA = "0x1806E0130")]
		internal void PLJLOPPFBCG(PEMJBFLGGMM DNGPHMONFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6619CC0", Offset = "0x6618CC0", VA = "0x186619CC0")]
		internal void EKOBNKLFDJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x661B0B0", Offset = "0x661A0B0", VA = "0x18661B0B0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody BNJALKGHBFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6619960", Offset = "0x6618960", VA = "0x186619960")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6619A30", Offset = "0x6618A30", VA = "0x186619A30")]
		private PEMJBFLGGMM CLHJEPJAIDH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x661A190", Offset = "0x6619190", VA = "0x18661A190")]
		private void MGAGAAKAIAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x661A5F0", Offset = "0x66195F0", VA = "0x18661A5F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x661A580", Offset = "0x6619580", VA = "0x18661A580")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6619D50", Offset = "0x6618D50", VA = "0x186619D50")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x661A590", Offset = "0x6619590", VA = "0x18661A590")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x661A650", Offset = "0x6619650", VA = "0x18661A650")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6618FF0", Offset = "0x6617FF0", VA = "0x186618FF0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x661A6C0", Offset = "0x66196C0", VA = "0x18661A6C0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6619C60", Offset = "0x6618C60", VA = "0x186619C60")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x661A520", Offset = "0x6619520", VA = "0x18661A520")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x661AEB0", Offset = "0x6619EB0", VA = "0x18661AEB0")]
		public void SetParent(RigidbodyEx KPPLMEOMNGF, bool GMEFKHHIEPP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x661A9D0", Offset = "0x66199D0", VA = "0x18661A9D0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6619FB0", Offset = "0x6618FB0", VA = "0x186619FB0")]
		public bool IsRigidbodyAncestor(RigidbodyEx BGGGLHDGEEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6619FF0", Offset = "0x6618FF0", VA = "0x186619FF0")]
		public bool IsRigidbodyDescendant(RigidbodyEx IMGNFLHGNFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6619210", Offset = "0x6618210", VA = "0x186619210")]
		public void AddInterpolationRestriction(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x661A730", Offset = "0x6619730", VA = "0x18661A730")]
		public void RemoveInterpolationRestriction(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x66199D0", Offset = "0x66189D0", VA = "0x1866199D0")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6619280", Offset = "0x6618280", VA = "0x186619280")]
		public void AddKinematic(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x661A7A0", Offset = "0x66197A0", VA = "0x18661A7A0")]
		public void RemoveKinematic(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x661AE30", Offset = "0x6619E30", VA = "0x18661AE30")]
		public void SetKinematic(object JAKCBCDLMLB, bool FANMJAGAPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x661AD30", Offset = "0x6619D30", VA = "0x18661AD30")]
		public void SetDiscontinuousPositionAndRotation(Vector3 IIHKIEHLKJE, Quaternion OKGAEIKHFKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x661AC30", Offset = "0x6619C30", VA = "0x18661AC30")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 JAGOFJILOLJ, Quaternion PAFGOIINECO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6619EB0", Offset = "0x6618EB0", VA = "0x186619EB0")]
		public Vector3 GetConstrainedVelocity(Vector3 FJHEIJDCBEJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6619DB0", Offset = "0x6618DB0", VA = "0x186619DB0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 BAMHFNACLOC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6619180", Offset = "0x6618180", VA = "0x186619180")]
		public void AddForce(Vector3 AKNNPOEHKML, ForceMode KHIFDLIHLBI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6619060", Offset = "0x6618060", VA = "0x186619060")]
		public void AddForceAtPosition(Vector3 AKNNPOEHKML, Vector3 MIFJBHLKJIN, ForceMode KHIFDLIHLBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6619380", Offset = "0x6618380", VA = "0x186619380")]
		public void AddTorque(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x66192F0", Offset = "0x66182F0", VA = "0x1866192F0")]
		public void AddRelativeTorque(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x661B190", Offset = "0x661A190", VA = "0x18661B190")]
		public Vector3 WorldToLocalVelocity(Vector3 HFELIOHGGDO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x661A090", Offset = "0x6619090", VA = "0x18661A090")]
		public Vector3 LocalToWorldVelocity(Vector3 FEAFOIFGCCF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6619C00", Offset = "0x6618C00", VA = "0x186619C00")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6619BA0", Offset = "0x6618BA0", VA = "0x186619BA0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6619B40", Offset = "0x6618B40", VA = "0x186619B40")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6619AE0", Offset = "0x6618AE0", VA = "0x186619AE0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x661AB30", Offset = "0x6619B30", VA = "0x18661AB30")]
		public void ResetVelocityWorldSpace(Vector3 OLJIPBFJCBL, Vector3 CJANALIFPDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x661AA30", Offset = "0x6619A30", VA = "0x18661AA30")]
		public void ResetVelocityLocalSpace(Vector3 OABJFLBJEKB, Vector3 IMCNKNPLDHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x661A8F0", Offset = "0x66198F0", VA = "0x18661A8F0")]
		public void ResetLinearVelocityLocalSpace(Vector3 OABJFLBJEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x661AFA0", Offset = "0x6619FA0", VA = "0x18661AFA0")]
		public bool SweepTest(Vector3 JLBPNKFCLFO, out RaycastHit JFEEEDGCAPO, float FNIJMIADAMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x661A030", Offset = "0x6619030", VA = "0x18661A030")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x661AF40", Offset = "0x6619F40", VA = "0x18661AF40")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x661B130", Offset = "0x661A130", VA = "0x18661B130")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6619410", Offset = "0x6618410", VA = "0x186619410")]
		public void AddUnityRigidbody(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x661A810", Offset = "0x6619810", VA = "0x18661A810")]
		public void RemoveUnityRigidbody(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6619730", Offset = "0x6618730", VA = "0x186619730")]
		public void ApplyForceVelocityChange(OBJOKHNKAPP CAMLNFGKHFE, Vector3 MAIIDBKHIED, float JOFBEKECLOD, float CLOJEHHLDHC = 8f, float ILPINEMCFMP = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6619630", Offset = "0x6618630", VA = "0x186619630")]
		public void ApplyAngularVelocityChange(EKKHOJNPNMO PNJHOCPNCML, Vector3 NFNPPPGADBK, float MMIALNFHMCC = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6619850", Offset = "0x6618850", VA = "0x186619850")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(EKKHOJNPNMO PNJHOCPNCML, Vector3 OLBDAPNGDPL, float CEIPLLMFOOE = 7f, float OGLOAGFEIHM = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6619570", Offset = "0x6618570", VA = "0x186619570")]
		public bool AllowedScaleChange(float DEGNNNFBBGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6619480", Offset = "0x6618480", VA = "0x186619480")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx HEPODBMIMNP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x661A880", Offset = "0x6619880", VA = "0x18661A880")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x661B2E0", Offset = "0x661A2E0", VA = "0x18661B2E0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class LPPKKOFIIGD
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x54EA350", Offset = "0x54E9350", VA = "0x1854EA350")]
	public static PEMJBFLGGMM IPKNMKDFBPN(this RigidbodyEx LKMGIJIPLIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct IKIHJJFFHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Rigidbody BEMEPNIHEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PhotonView OLADCELCKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 BPHDIFLPGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OverridableVector3 JEOEIFINIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public AONMFLABHAI HMHPFNKNCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool BFCIJHLEAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool GEJFJNCHJLO;
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[OHGELDJCNJM(GGAOONGBEBH.Physics)]
	[IABFONFHPFO(typeof(OOMBAIEJEBP), new string[] { })]
	public class RigidbodyExManager : OOMBAIEJEBP, MIBCENMOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private AHENLKMMNNA ACCCBDFPKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private CNGJPACLCIB JPJNJBPAHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private HMOFCBOHILL AJGFDPPCCKJ;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool MLINOHDNKEN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6618E60", Offset = "0x6617E60", VA = "0x186618E60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public CNGJPACLCIB JBJJKKBFHAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public HMOFCBOHILL CHGCPFMHBIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6618C80", Offset = "0x6617C80", VA = "0x186618C80", Slot = "12")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x66189B0", Offset = "0x66179B0", VA = "0x1866189B0", Slot = "7")]
		public GPEJGMHBDPO IJANLHNKKJL(RigidbodyEx LKMGIJIPLIN)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6618EB0", Offset = "0x6617EB0", VA = "0x186618EB0")]
		private static GPEJGMHBDPO MINBBKKJHMB(RigidbodyEx LKMGIJIPLIN)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x66187D0", Offset = "0x66177D0", VA = "0x1866187D0", Slot = "8")]
		public PEMJBFLGGMM BBMPNOCKHLJ(RigidbodyEx LKMGIJIPLIN, IKIHJJFFHFA FNIHENPLJHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x66188E0", Offset = "0x66178E0", VA = "0x1866188E0", Slot = "11")]
		private RigidbodyEx CHEAODAHGEC(GameObject LOCIAIPOBLA, IKIHJJFFHFA FNIHENPLJHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x66186E0", Offset = "0x66176E0", VA = "0x1866186E0", Slot = "9")]
		public void AIOGKBDENBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6618D10", Offset = "0x6617D10", VA = "0x186618D10", Slot = "10")]
		public void KAELCLHILKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static AMNHKKJOBOK UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int IEOKOMKLAMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int JCEEDGFECHE;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x66181C0", Offset = "0x66171C0", VA = "0x1866181C0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6618200", Offset = "0x6617200", VA = "0x186618200")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x66181E0", Offset = "0x66171E0", VA = "0x1866181E0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string GOMILMNIGIC, [Optional] UnityEngine.Object MFEOJPNCOBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string GOMILMNIGIC, [Optional] UnityEngine.Object MFEOJPNCOBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x66182F0", Offset = "0x66172F0", VA = "0x1866182F0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EEPGLGMEAGO
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x54CD9C0", Offset = "0x54CC9C0", VA = "0x1854CD9C0")]
	public static void FGMPKNFDGIC(this Rigidbody BNJALKGHBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x54CDB10", Offset = "0x54CCB10", VA = "0x1854CDB10")]
	public static void FGMPKNFDGIC(this Rigidbody BNJALKGHBFN, Vector3 MIDKEEPKLBG, Quaternion FAGMBLNKBPB, Vector3 ADIOMBOKILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x54CDC20", Offset = "0x54CCC20", VA = "0x1854CDC20")]
	public static void GNAOMBGNKOE(Vector3 FJHEIJDCBEJ, Vector3 MFJFJLMHLGM, out Vector3 MCBDENLHCEP, out Vector3 DDPNEECHDFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BPNCLCMHACD
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class LOJGGPIEPOB : CCEJFGGKGLM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x163AE90", Offset = "0x1639E90", VA = "0x18163AE90", Slot = "4")]
		public Vector3 BOEHIMLHPKM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x163AE90", Offset = "0x1639E90", VA = "0x18163AE90", Slot = "5")]
		public Vector3 FDMJOFIOEHO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public LOJGGPIEPOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static CCEJFGGKGLM JAKJBIBHOKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x54C6280", Offset = "0x54C5280", VA = "0x1854C6280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AHAFDFAMMOI
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode IBLNPOEEODJ
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
	void IBMMKMLPEOI();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CKELEIJDMGC(bool BJPNLAHPGHI);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FAAPOKHEFAE(bool BJPNLAHPGHI);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CBCMNPEEDCJ(Vector3 JLBPNKFCLFO, out RaycastHit JFEEEDGCAPO, float FNIJMIADAMA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CCMAIABHGHM : IDisposable, NFBHMIKCNHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CLIIJKDLFPK JLBHGNPAHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<GMJLIEJPOEJ, GMJLIEJPOEJ> BKPNGAGNMKO;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IBMMKMLPEOI();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[IODJMJFIADF(PGBOFPGBDBH.Application)]
public interface HMOFCBOHILL
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KOFIFPKBGDE HPMJMPJAEBF(PEMJBFLGGMM DNGPHMONFKM);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IGHPKHJEAKK ELGDCBJCMFN(PEMJBFLGGMM DNGPHMONFKM);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DOLOBBHOJCN JPOHICNGBBP(PEMJBFLGGMM DNGPHMONFKM);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BEGCJHEKPFH KCHPJLDNMCG(PEMJBFLGGMM DNGPHMONFKM);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FEJPDKKHHEB LNKOELKMANO(PEMJBFLGGMM DNGPHMONFKM);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CCMAIABHGHM OKIKOAODBKA(PEMJBFLGGMM DNGPHMONFKM);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KJKCPGCAIML GBFBEIIDFCA(PEMJBFLGGMM DNGPHMONFKM);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EBDBHLCOCAL GJGOKLOIGBN(PEMJBFLGGMM DNGPHMONFKM);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AHAFDFAMMOI LHOEKHPMJKM(PEMJBFLGGMM DNGPHMONFKM);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	COEGLBKNHNL HLENLHEFFLE(PEMJBFLGGMM DNGPHMONFKM);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BJEGJOOAAHN HLAKIFBKGOD(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	AEHNOIOGGNB PFOFCHGKLBD(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FAMFIMIKKAN JOJCEHJOGPP(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DPAGPKHBGMK DBPGDMNKLJL(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MNOPDMEBLBE KCDDEIIAPGE(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "15")]
	PEMJBFLGGMM BBMPNOCKHLJ(RigidbodyEx LKMGIJIPLIN, IKIHJJFFHFA FNIHENPLJHK, OOMBAIEJEBP CBBILOOJOAK);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EBDBHLCOCAL
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKANBCJLPMP(Vector3 AKNNPOEHKML, ForceMode KHIFDLIHLBI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBNEOPMLINP(Vector3 AKNNPOEHKML, Vector3 MIFJBHLKJIN, ForceMode KHIFDLIHLBI);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HKPKKNJICLF(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EIKMOLMEFMN(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface COEGLBKNHNL
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool IKHDPECJDJE
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
	void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EHKIOOCJGFF(Rigidbody BEMEPNIHEKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KOFIFPKBGDE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<PEMJBFLGGMM> BIMGCBEFPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	PEMJBFLGGMM IMFMPPONFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	PEMJBFLGGMM AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event ONKEIMPDALF FGKDCAIOBOH;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event ONKEIMPDALF BJBFJNEGDJP;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event BAPGIHMPHAC JDHPMFPKGAD;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action CLLCEGLBDLH;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action LHGLPPNOMEI;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<PEMJBFLGGMM> NEGJPDDONIC;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<PEMJBFLGGMM> MKOODLOMFFL;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action JHGAJELOKJK;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<PEMJBFLGGMM> LEMANBDPLKJ;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JDHACNMMLIE(PEMJBFLGGMM KHLHKJKADHO, bool GMEFKHHIEPP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DOLOBBHOJCN
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 PPABHMBOJDG
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 DIKOGGMMGKO
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LEIFIIGNCAL(PEMJBFLGGMM OKMBLMILFGG, object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DCNGBDBEBAG(object JAKCBCDLMLB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface DPAGPKHBGMK
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 KDBEDBCAALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 CIMPCCAAMLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float JCADBDOALOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float JPJAIDEFGCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 OFHAOOPEAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion OIBJJPCINPO
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event ONKEIMPDALF GCAFEBIMFLK;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OPJNHLCKFOO();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GCHILAJIGDA();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ENHMBOFJGPN();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EHKIOOCJGFF(Rigidbody BEMEPNIHEKJ);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PFHHLHIKMFB();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FAMFIMIKKAN
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool ADAMCHGCIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	CACECFKIIAN LGANHOBMNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBMMKMLPEOI();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DMFIPAONEJJ(object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LOIGBFPIIGA(object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MEACCKMJFCC(PEMJBFLGGMM LKMGIJIPLIN);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EPIMLABDGHA(PEMJBFLGGMM LKMGIJIPLIN);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NCPFCGEECHN();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KJKCPGCAIML
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool HIDLJAAELFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	IEnumerable<object> KPJACHNJINE
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event ONKEIMPDALF NKOIMHHPNOC;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJMDMCDKKPE(object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FHDCOJAJODE(object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LAOHBPMFIPD(object JAKCBCDLMLB, bool FANMJAGAPKF);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable ILBPDKJDBCP();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MIFKLLNLBMA(Rigidbody MMACFBGEFCH);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EHKIOOCJGFF(Rigidbody BEMEPNIHEKJ);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface AEHNOIOGGNB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool DHECOBNPECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool PGDDLMMJJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event ONKEIMPDALF BLJCHPILBGJ;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IBMMKMLPEOI();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GOBBLIKIBOC(PEMJBFLGGMM OKMBLMILFGG);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DODGKOMIJNM(PEMJBFLGGMM OKMBLMILFGG);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface MNOPDMEBLBE
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool ELDBHBFKIGF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool JMMGDKCOBOK
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	RigidbodyConstraints HLIGOHOAJLE
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
	void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EHKIOOCJGFF(Rigidbody BEMEPNIHEKJ);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BEGCJHEKPFH
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float CMNCFAMIFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float GLPBFLLCCKF
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
	void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EHKIOOCJGFF(Rigidbody BEMEPNIHEKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JGJHHLDLPEG
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx LNPGKGLDBCG);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FEJPDKKHHEB
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event ONKEIMPDALF HOLNOCHIGIL;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBMMKMLPEOI();

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GOBGGIIBKON();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IGEMGMCLGIK();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AMHGNHLMFNN();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EKFBEOFALEK();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GKCJECCPPNM();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MOPGLEDKLOM(bool NBPKMHPMALK);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface BJEGJOOAAHN
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Rigidbody OCHJHJGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBMMKMLPEOI();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BNFFEJKELLJ(object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LAIPLJBIIOF(object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ICGPBGLDJFB();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BBBNKDJHOPK();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GOGONJBMCAN();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HDCHMOLMOGG();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface IGHPKHJEAKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	CCEJFGGKGLM CPIHALLPKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	GGBMPGNAFJD OPABPNIHPDI
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 LCNCCKHCPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 AHAJMJBMMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	Vector3 JLGHJOIMMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Vector3 HBNCABOKHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float FCAAJGFAJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool ACGMNKMENFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IBMMKMLPEOI();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FOJGNOFNCLG(object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AFOBMMCCHIM(EKKHOJNPNMO PNJHOCPNCML, Vector3 NFNPPPGADBK, float MMIALNFHMCC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CBOAGHDBPJH(OBJOKHNKAPP CAMLNFGKHFE, Vector3 MAIIDBKHIED, float JOFBEKECLOD, float CLOJEHHLDHC = 8f, float ILPINEMCFMP = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void BMPJNHFGFFL(EKKHOJNPNMO PNJHOCPNCML, Vector3 OLBDAPNGDPL, float CEIPLLMFOOE = 7f, float OGLOAGFEIHM = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void CMHHFMOHFCF();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GJGKIDGKPEE();

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MDDKFEEINFE();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void IIPKPIBFBHP();

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 NOILBEMLPLM(Vector3 BAMHFNACLOC);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 IDKDPPMOKNN(Vector3 FJHEIJDCBEJ);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EJPJLNDPFPP(object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GMEDHCFFMEH(Vector3 ANJGHBFDIMN);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void LICDBAEOAFD(Vector3 OABJFLBJEKB, Vector3 IMCNKNPLDHH);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void CJHODKMAJBE(Vector3 OLJIPBFJCBL, Vector3 CJANALIFPDO);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 GNEKHGHFGKA(Vector3 FEAFOIFGCCF);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 ABHOGLBBGMA(Vector3 HFELIOHGGDO);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[IODJMJFIADF(PGBOFPGBDBH.Application)]
public interface CNGJPACLCIB
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool GCJCCEAHAAP
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKHDOIMNAHA(string CNMFEBEOFOM);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CPPGLFMFABI(RigidbodyEx LKMGIJIPLIN, Action FFBLFKDINEA);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OOGGPHHIOEI OBBKIDKKMBA(int MGDHNMJCIFE);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PHPLIKONAJP(Vector3 KJOMJOHPAIM, float KHOELGGJGBI, Color LDFNLMPJEDN);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[IODJMJFIADF(PGBOFPGBDBH.Application)]
public interface OOMBAIEJEBP
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	CNGJPACLCIB JBJJKKBFHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	HMOFCBOHILL CHGCPFMHBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool MLINOHDNKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GPEJGMHBDPO IJANLHNKKJL(RigidbodyEx LKMGIJIPLIN);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PEMJBFLGGMM BBMPNOCKHLJ(RigidbodyEx LKMGIJIPLIN, IKIHJJFFHFA FNIHENPLJHK);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AIOGKBDENBF();

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KAELCLHILKP();

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal RigidbodyEx DHANHONDGIB(GameObject LOCIAIPOBLA, [Optional] IKIHJJFFHFA FNIHENPLJHK);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface GGBMPGNAFJD
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGIIBFBPGLP(Vector3 GIMGONGBBFI);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INELDJICPMM(Vector3 BAMHFNACLOC);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HCLGCMEEECG(Vector3 GIMGONGBBFI);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FCDEEMJBIHE(Vector3 BAMHFNACLOC);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface CCEJFGGKGLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 BOEHIMLHPKM();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 FDMJOFIOEHO();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface PEMJBFLGGMM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Rigidbody OCHJHJGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	RigidbodyEx BHNPGPJFIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	GameObject OCGHLHMMGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Transform AMINHCIEOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IEnumerable<object> EPIMPBJGKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	PEMJBFLGGMM AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	IReadOnlyList<PEMJBFLGGMM> BIMGCBEFPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	PEMJBFLGGMM IMFMPPONFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool OCODEBHAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool DHECOBNPECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool PGDDLMMJJIL
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	CCEJFGGKGLM CPIHALLPKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	GGBMPGNAFJD OPABPNIHPDI
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	float FCAAJGFAJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 AHAJMJBMMNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 HBNCABOKHHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 LCNCCKHCPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 JLGHJOIMMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool CPPIJLCAPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool GBCOKGPNABB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool DCOIJAMPGBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool ACGMNKMENFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 PPABHMBOJDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 DIKOGGMMGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 KDBEDBCAALJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 CIMPCCAAMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float JCADBDOALOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float JPJAIDEFGCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 OFHAOOPEAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Quaternion OIBJJPCINPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float CMNCFAMIFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float GLPBFLLCCKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool IKHDPECJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "47")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	CLIIJKDLFPK JLBHGNPAHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool HIDLJAAELFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Transform AAMHCPKDGML
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Transform GFCCGCABKON
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 HFOAEBOMNLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float FKAPONKEAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float FOMCKPAPOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "58")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion CBCKCFLIFDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "60")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 INAHNKFEMKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Quaternion PHAFEIAABKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "64")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	RigidbodyConstraints HLIGOHOAJLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "66")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool ELDBHBFKIGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CollisionDetectionMode IBLNPOEEODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "70")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool CEEGNNLCJLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event ONKEIMPDALF FGKDCAIOBOH;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event ONKEIMPDALF BJBFJNEGDJP;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event BAPGIHMPHAC JDHPMFPKGAD;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event ONKEIMPDALF BLJCHPILBGJ;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event ONKEIMPDALF BPFDNFOMPLB;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event ONKEIMPDALF HOLNOCHIGIL;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<GMJLIEJPOEJ, GMJLIEJPOEJ> BKPNGAGNMKO;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event ONKEIMPDALF PEJBAIOJGEE;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event ONKEIMPDALF JFGDBEMBLMM;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void IBMMKMLPEOI();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void HDKFJIKLEJI();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void EPMHDFKPLEJ();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void AMHGNHLMFNN();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void EJBOICBIHAK();

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void JDHACNMMLIE(PEMJBFLGGMM KPPLMEOMNGF, bool GMEFKHHIEPP = false);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void BFMOPJLHBBG(object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void LHGJEIODGLO(object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 ABHOGLBBGMA(Vector3 HFELIOHGGDO);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "89")]
	Vector3 GNEKHGHFGKA(Vector3 FEAFOIFGCCF);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void IIPKPIBFBHP();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void GJGKIDGKPEE();

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void CMHHFMOHFCF();

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void CJHODKMAJBE(Vector3 OLJIPBFJCBL, Vector3 CJANALIFPDO);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void LICDBAEOAFD(Vector3 OABJFLBJEKB, Vector3 IMCNKNPLDHH);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void GMEDHCFFMEH(Vector3 ANJGHBFDIMN);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void CBOAGHDBPJH(OBJOKHNKAPP CAMLNFGKHFE, Vector3 MAIIDBKHIED, float JOFBEKECLOD, float CLOJEHHLDHC = 8f, float ILPINEMCFMP = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void AFOBMMCCHIM(EKKHOJNPNMO PNJHOCPNCML, Vector3 NFNPPPGADBK, float MMIALNFHMCC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void BMPJNHFGFFL(EKKHOJNPNMO PNJHOCPNCML, Vector3 OLBDAPNGDPL, float CEIPLLMFOOE = 7f, float OGLOAGFEIHM = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 IDKDPPMOKNN(Vector3 KPPLMEOMNGF);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "100")]
	Vector3 NOILBEMLPLM(Vector3 KPPLMEOMNGF);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void MDDKFEEINFE();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void MEJBHJGELMJ(PEMJBFLGGMM HEPODBMIMNP, object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void GAIBLGGKAKK(object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void GCHILAJIGDA();

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void OPJNHLCKFOO();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void ENHMBOFJGPN();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "111")]
	bool GOBGGIIBKON();

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void GKCJECCPPNM();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "117")]
	IDisposable ILBPDKJDBCP();

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void OJMDMCDKKPE(object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void FHDCOJAJODE(object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void LAOHBPMFIPD(object JAKCBCDLMLB, bool FANMJAGAPKF);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void AGNLAHKGJCD(Vector3 IIHKIEHLKJE, Quaternion OKGAEIKHFKF);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void CGBDHLAKFPB(Vector3 JAGOFJILOLJ, Quaternion PAFGOIINECO);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "125")]
	bool BGJIPHJJDJL(float DEGNNNFBBGJ);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void KGPNCHMMJJG(object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void EFNCJDLHIIK(object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void BNFFEJKELLJ(object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void LAIPLJBIIOF(object JAKCBCDLMLB);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void LKANBCJLPMP(Vector3 AKNNPOEHKML, ForceMode KHIFDLIHLBI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void LBNEOPMLINP(Vector3 AKNNPOEHKML, Vector3 MIFJBHLKJIN, ForceMode KHIFDLIHLBI);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void HKPKKNJICLF(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void EIKMOLMEFMN(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool CBCMNPEEDCJ(Vector3 JLBPNKFCLFO, out RaycastHit JFEEEDGCAPO, float FNIJMIADAMA);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void PFHHLHIKMFB();

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class GAFHNPMJPMB : PEMJBFLGGMM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly OOMBAIEJEBP CBBILOOJOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal KOFIFPKBGDE EBGBIKNFKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal FAMFIMIKKAN EHHDFEKGMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal AEHNOIOGGNB HDOHKKMKDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal IGHPKHJEAKK FJHEIJDCBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal DOLOBBHOJCN KOKGNKEKCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal DPAGPKHBGMK GKEEAACCNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal BEGCJHEKPFH JAACENIIOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal COEGLBKNHNL EHEELLIOING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal FEJPDKKHHEB EBDKPGLCCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal CCMAIABHGHM DDDIPBMAIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal KJKCPGCAIML HKLJHAHIHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal EBDBHLCOCAL AKNNPOEHKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal MNOPDMEBLBE OHDHDMBKKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal BJEGJOOAAHN BEMEPNIHEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal AHAFDFAMMOI PAOCCAPODMK;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public RigidbodyEx BHNPGPJFIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6E5E20", Offset = "0x6E4E20", VA = "0x1806E5E20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x85E5D0", Offset = "0x85D5D0", VA = "0x18085E5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GameObject OCGHLHMMGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x71B6A0", Offset = "0x71A6A0", VA = "0x18071B6A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8E9490", Offset = "0x8E8490", VA = "0x1808E9490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Transform AMINHCIEOMN
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x54D2000", Offset = "0x54D1000", VA = "0x1854D2000", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEnumerable<object> EPIMPBJGKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x54D2800", Offset = "0x54D1800", VA = "0x1854D2800", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Rigidbody OCHJHJGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x54D3D60", Offset = "0x54D2D60", VA = "0x1854D3D60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PEMJBFLGGMM AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x54D4930", Offset = "0x54D3930", VA = "0x1854D4930", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x54D4300", Offset = "0x54D3300", VA = "0x1854D4300", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public IReadOnlyList<PEMJBFLGGMM> BIMGCBEFPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x54D18F0", Offset = "0x54D08F0", VA = "0x1854D18F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public PEMJBFLGGMM IMFMPPONFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x54D1AB0", Offset = "0x54D0AB0", VA = "0x1854D1AB0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool OCODEBHAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x54D50C0", Offset = "0x54D40C0", VA = "0x1854D50C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool DHECOBNPECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x54D48E0", Offset = "0x54D38E0", VA = "0x1854D48E0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool PGDDLMMJJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x54D38B0", Offset = "0x54D28B0", VA = "0x1854D38B0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public CCEJFGGKGLM CPIHALLPKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x54D3280", Offset = "0x54D2280", VA = "0x1854D3280", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x54D41E0", Offset = "0x54D31E0", VA = "0x1854D41E0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public GGBMPGNAFJD OPABPNIHPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x54D3FE0", Offset = "0x54D2FE0", VA = "0x1854D3FE0", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x54D3DB0", Offset = "0x54D2DB0", VA = "0x1854D3DB0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public float FCAAJGFAJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x54D0B00", Offset = "0x54CFB00", VA = "0x1854D0B00", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x54D5AC0", Offset = "0x54D4AC0", VA = "0x1854D5AC0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 AHAJMJBMMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x54D2560", Offset = "0x54D1560", VA = "0x1854D2560", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x54D5ED0", Offset = "0x54D4ED0", VA = "0x1854D5ED0", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 HBNCABOKHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x54D5BE0", Offset = "0x54D4BE0", VA = "0x1854D5BE0", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x54D36D0", Offset = "0x54D26D0", VA = "0x1854D36D0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 LCNCCKHCPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x54D06F0", Offset = "0x54CF6F0", VA = "0x1854D06F0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x54D3AF0", Offset = "0x54D2AF0", VA = "0x1854D3AF0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 JLGHJOIMMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x54D0E60", Offset = "0x54CFE60", VA = "0x1854D0E60", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x54D5580", Offset = "0x54D4580", VA = "0x1854D5580", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool CPPIJLCAPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x54D5380", Offset = "0x54D4380", VA = "0x1854D5380", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool GBCOKGPNABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x54D3950", Offset = "0x54D2950", VA = "0x1854D3950", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool DCOIJAMPGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x54D5650", Offset = "0x54D4650", VA = "0x1854D5650", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool ACGMNKMENFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x54D1A60", Offset = "0x54D0A60", VA = "0x1854D1A60", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Vector3 PPABHMBOJDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x54D5120", Offset = "0x54D4120", VA = "0x1854D5120", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 DIKOGGMMGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x54D2730", Offset = "0x54D1730", VA = "0x1854D2730", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Vector3 KDBEDBCAALJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x54D0A30", Offset = "0x54CFA30", VA = "0x1854D0A30", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x54D1D90", Offset = "0x54D0D90", VA = "0x1854D1D90", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 CIMPCCAAMLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x54D3600", Offset = "0x54D2600", VA = "0x1854D3600", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float JCADBDOALOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x54D4130", Offset = "0x54D3130", VA = "0x1854D4130", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float JPJAIDEFGCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x54D21A0", Offset = "0x54D11A0", VA = "0x1854D21A0", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x54D0810", Offset = "0x54CF810", VA = "0x1854D0810", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Vector3 OFHAOOPEAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x54D4540", Offset = "0x54D3540", VA = "0x1854D4540", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x54D2F80", Offset = "0x54D1F80", VA = "0x1854D2F80", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion OIBJJPCINPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x54D3EC0", Offset = "0x54D2EC0", VA = "0x1854D3EC0", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x54D2D00", Offset = "0x54D1D00", VA = "0x1854D2D00", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float CMNCFAMIFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x54D3860", Offset = "0x54D2860", VA = "0x1854D3860", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x54D02E0", Offset = "0x54CF2E0", VA = "0x1854D02E0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public float GLPBFLLCCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x54D0D60", Offset = "0x54CFD60", VA = "0x1854D0D60", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x54D42A0", Offset = "0x54D32A0", VA = "0x1854D42A0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool IKHDPECJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x54D4D10", Offset = "0x54D3D10", VA = "0x1854D4D10", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x54D2630", Offset = "0x54D1630", VA = "0x1854D2630", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CLIIJKDLFPK JLBHGNPAHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x54D5010", Offset = "0x54D4010", VA = "0x1854D5010", Slot = "52")]
		get
		{
			return default(CLIIJKDLFPK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x54D37A0", Offset = "0x54D27A0", VA = "0x1854D37A0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool HIDLJAAELFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x54D5E80", Offset = "0x54D4E80", VA = "0x1854D5E80", Slot = "54")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Transform AAMHCPKDGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x54D1940", Offset = "0x54D0940", VA = "0x1854D1940", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public Transform GFCCGCABKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x54D1940", Offset = "0x54D0940", VA = "0x1854D1940", Slot = "56")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Vector3 HFOAEBOMNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x54D3CB0", Offset = "0x54D2CB0", VA = "0x1854D3CB0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x54D54D0", Offset = "0x54D44D0", VA = "0x1854D54D0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public float FKAPONKEAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x54D3150", Offset = "0x54D2150", VA = "0x1854D3150", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x54D53D0", Offset = "0x54D43D0", VA = "0x1854D53D0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public float FOMCKPAPOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x54D1840", Offset = "0x54D0840", VA = "0x1854D1840", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x54D2DD0", Offset = "0x54D1DD0", VA = "0x1854D2DD0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Quaternion CBCKCFLIFDK
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x54D1B00", Offset = "0x54D0B00", VA = "0x1854D1B00", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x54D40A0", Offset = "0x54D30A0", VA = "0x1854D40A0", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 INAHNKFEMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x54D3900", Offset = "0x54D2900", VA = "0x1854D3900", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x54D34E0", Offset = "0x54D24E0", VA = "0x1854D34E0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Quaternion PHAFEIAABKC
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x54D0B50", Offset = "0x54CFB50", VA = "0x1854D0B50", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x54D1BB0", Offset = "0x54D0BB0", VA = "0x1854D1BB0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public RigidbodyConstraints HLIGOHOAJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x54D3F90", Offset = "0x54D2F90", VA = "0x1854D3F90", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x54D5060", Offset = "0x54D4060", VA = "0x1854D5060", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool ELDBHBFKIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x54D5330", Offset = "0x54D4330", VA = "0x1854D5330", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x54D4E80", Offset = "0x54D3E80", VA = "0x1854D4E80", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CollisionDetectionMode IBLNPOEEODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x54D6000", Offset = "0x54D5000", VA = "0x1854D6000", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x54D5A60", Offset = "0x54D4A60", VA = "0x1854D5A60", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool CEEGNNLCJLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x54D51F0", Offset = "0x54D41F0", VA = "0x1854D51F0", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event ONKEIMPDALF FGKDCAIOBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x54D4180", Offset = "0x54D3180", VA = "0x1854D4180", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x54D1030", Offset = "0x54D0030", VA = "0x1854D1030", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event ONKEIMPDALF BJBFJNEGDJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x54D5B20", Offset = "0x54D4B20", VA = "0x1854D5B20", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x54D2140", Offset = "0x54D1140", VA = "0x1854D2140", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event BAPGIHMPHAC JDHPMFPKGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x54D30F0", Offset = "0x54D20F0", VA = "0x1854D30F0", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x54D4C50", Offset = "0x54D3C50", VA = "0x1854D4C50", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event ONKEIMPDALF BLJCHPILBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x54D09D0", Offset = "0x54CF9D0", VA = "0x1854D09D0", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x54D5A00", Offset = "0x54D4A00", VA = "0x1854D5A00", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event ONKEIMPDALF BPFDNFOMPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x54D3E10", Offset = "0x54D2E10", VA = "0x1854D3E10", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x54D0D00", Offset = "0x54CFD00", VA = "0x1854D0D00", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event ONKEIMPDALF HOLNOCHIGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x54D1F20", Offset = "0x54D0F20", VA = "0x1854D1F20", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x54D4CB0", Offset = "0x54D3CB0", VA = "0x1854D4CB0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<GMJLIEJPOEJ, GMJLIEJPOEJ> BKPNGAGNMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x54D5FA0", Offset = "0x54D4FA0", VA = "0x1854D5FA0", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x54D0870", Offset = "0x54CF870", VA = "0x1854D0870", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event ONKEIMPDALF PEJBAIOJGEE
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x54D1E60", Offset = "0x54D0E60", VA = "0x1854D1E60", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x54D4FB0", Offset = "0x54D3FB0", VA = "0x1854D4FB0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event ONKEIMPDALF JFGDBEMBLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x54D2690", Offset = "0x54D1690", VA = "0x1854D2690", Slot = "125")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x54D0440", Offset = "0x54CF440", VA = "0x1854D0440", Slot = "126")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x54D6090", Offset = "0x54D5090", VA = "0x1854D6090")]
	public GAFHNPMJPMB(GameObject BLPBCMIHDMD, RigidbodyEx JKNMFOBKPNO, OOMBAIEJEBP CBBILOOJOAK, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x54D1360", Offset = "0x54D0360", VA = "0x1854D1360", Slot = "142")]
	protected virtual void CICIFIGLLJJ(OOMBAIEJEBP CBBILOOJOAK, IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x54D1CC0", Offset = "0x54D0CC0", VA = "0x1854D1CC0", Slot = "143")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x54D39B0", Offset = "0x54D29B0", VA = "0x1854D39B0", Slot = "76")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x54D3530", Offset = "0x54D2530", VA = "0x1854D3530", Slot = "77")]
	public void HDKFJIKLEJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x1988FC0", Offset = "0x1987FC0", VA = "0x181988FC0", Slot = "78")]
	public void EPMHDFKPLEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x54D2090", Offset = "0x54D1090", VA = "0x1854D2090", Slot = "144")]
	public virtual void EJBOICBIHAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x54D4030", Offset = "0x54D3030", VA = "0x1854D4030", Slot = "87")]
	public void JDHACNMMLIE(PEMJBFLGGMM KPPLMEOMNGF, bool GMEFKHHIEPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x54D08D0", Offset = "0x54CF8D0", VA = "0x1854D08D0", Slot = "90")]
	public void BFMOPJLHBBG(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x54D4610", Offset = "0x54D3610", VA = "0x1854D4610", Slot = "91")]
	public void LHGJEIODGLO(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x54D0080", Offset = "0x54CF080", VA = "0x1854D0080", Slot = "92")]
	public Vector3 ABHOGLBBGMA(Vector3 HFELIOHGGDO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x54D32D0", Offset = "0x54D22D0", VA = "0x1854D32D0", Slot = "93")]
	public Vector3 GNEKHGHFGKA(Vector3 FEAFOIFGCCF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x54D3530", Offset = "0x54D2530", VA = "0x1854D3530", Slot = "94")]
	public void IIPKPIBFBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x54D3050", Offset = "0x54D2050", VA = "0x1854D3050", Slot = "95")]
	public void GJGKIDGKPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x54D18A0", Offset = "0x54D08A0", VA = "0x1854D18A0", Slot = "96")]
	public void CMHHFMOHFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x54D1750", Offset = "0x54D0750", VA = "0x1854D1750", Slot = "97")]
	public void CJHODKMAJBE(Vector3 OLJIPBFJCBL, Vector3 CJANALIFPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x54D4670", Offset = "0x54D3670", VA = "0x1854D4670", Slot = "98")]
	public void LICDBAEOAFD(Vector3 OABJFLBJEKB, Vector3 IMCNKNPLDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x54D31B0", Offset = "0x54D21B0", VA = "0x1854D31B0", Slot = "99")]
	public void GMEDHCFFMEH(Vector3 ANJGHBFDIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x54D1090", Offset = "0x54D0090", VA = "0x1854D1090", Slot = "100")]
	public void CBOAGHDBPJH(OBJOKHNKAPP CAMLNFGKHFE, Vector3 MAIIDBKHIED, float JOFBEKECLOD, float CLOJEHHLDHC = 8f, float ILPINEMCFMP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x54D0340", Offset = "0x54CF340", VA = "0x1854D0340", Slot = "101")]
	public void AFOBMMCCHIM(EKKHOJNPNMO PNJHOCPNCML, Vector3 NFNPPPGADBK, float MMIALNFHMCC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x54D0B90", Offset = "0x54CFB90", VA = "0x1854D0B90", Slot = "102")]
	[Obsolete]
	public void BMPJNHFGFFL(EKKHOJNPNMO PNJHOCPNCML, Vector3 OLBDAPNGDPL, float CEIPLLMFOOE = 7f, float OGLOAGFEIHM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x54D3BC0", Offset = "0x54D2BC0", VA = "0x1854D3BC0", Slot = "103")]
	public Vector3 IDKDPPMOKNN(Vector3 KPPLMEOMNGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x54D5730", Offset = "0x54D4730", VA = "0x1854D5730", Slot = "104")]
	public Vector3 NOILBEMLPLM(Vector3 KPPLMEOMNGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x54D4D60", Offset = "0x54D3D60", VA = "0x1854D4D60", Slot = "105")]
	public void MDDKFEEINFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x54D4DB0", Offset = "0x54D3DB0", VA = "0x1854D4DB0", Slot = "106")]
	public void MEJBHJGELMJ(PEMJBFLGGMM HEPODBMIMNP, object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x54D2C50", Offset = "0x54D1C50", VA = "0x1854D2C50", Slot = "107")]
	public void GAIBLGGKAKK(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x54D2CB0", Offset = "0x54D1CB0", VA = "0x1854D2CB0", Slot = "110")]
	public void GCHILAJIGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x54D5CB0", Offset = "0x54D4CB0", VA = "0x1854D5CB0", Slot = "111")]
	public void OPJNHLCKFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x54D2510", Offset = "0x54D1510", VA = "0x1854D2510", Slot = "112")]
	public void ENHMBOFJGPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x54D3490", Offset = "0x54D2490", VA = "0x1854D3490", Slot = "115")]
	public bool GOBGGIIBKON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x54D07C0", Offset = "0x54CF7C0", VA = "0x1854D07C0", Slot = "79")]
	public void AMHGNHLMFNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x54D30A0", Offset = "0x54D20A0", VA = "0x1854D30A0", Slot = "116")]
	public void GKCJECCPPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x54D3E70", Offset = "0x54D2E70", VA = "0x1854D3E70", Slot = "121")]
	public IDisposable ILBPDKJDBCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x54D5B80", Offset = "0x54D4B80", VA = "0x1854D5B80", Slot = "122")]
	public void OJMDMCDKKPE(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x54D2850", Offset = "0x54D1850", VA = "0x1854D2850", Slot = "123")]
	public void FHDCOJAJODE(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x54D43C0", Offset = "0x54D33C0", VA = "0x1854D43C0", Slot = "124")]
	public void LAOHBPMFIPD(object JAKCBCDLMLB, bool FANMJAGAPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x54D04E0", Offset = "0x54CF4E0", VA = "0x1854D04E0", Slot = "127")]
	public void AGNLAHKGJCD(Vector3 IIHKIEHLKJE, Quaternion OKGAEIKHFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x54D11B0", Offset = "0x54D01B0", VA = "0x1854D11B0", Slot = "128")]
	public void CGBDHLAKFPB(Vector3 JAGOFJILOLJ, Quaternion PAFGOIINECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x54D0930", Offset = "0x54CF930", VA = "0x1854D0930", Slot = "129")]
	public bool BGJIPHJJDJL(float DEGNNNFBBGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x54D4240", Offset = "0x54D3240", VA = "0x1854D4240", Slot = "130")]
	public void KGPNCHMMJJG(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x54D1EC0", Offset = "0x54D0EC0", VA = "0x1854D1EC0", Slot = "131")]
	public void EFNCJDLHIIK(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x54D0CA0", Offset = "0x54CFCA0", VA = "0x1854D0CA0", Slot = "132")]
	public void BNFFEJKELLJ(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x54D4360", Offset = "0x54D3360", VA = "0x1854D4360", Slot = "133")]
	public void LAIPLJBIIOF(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x54D4760", Offset = "0x54D3760", VA = "0x1854D4760", Slot = "134")]
	public void LKANBCJLPMP(Vector3 AKNNPOEHKML, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x54D4430", Offset = "0x54D3430", VA = "0x1854D4430", Slot = "135")]
	public void LBNEOPMLINP(Vector3 AKNNPOEHKML, Vector3 MIFJBHLKJIN, ForceMode KHIFDLIHLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x54D3580", Offset = "0x54D2580", VA = "0x1854D3580", Slot = "136")]
	public void HKPKKNJICLF(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x54D1F80", Offset = "0x54D0F80", VA = "0x1854D1F80", Slot = "137")]
	public void EIKMOLMEFMN(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x54D0F30", Offset = "0x54CFF30", VA = "0x1854D0F30", Slot = "138")]
	public bool CBCMNPEEDCJ(Vector3 JLBPNKFCLFO, out RaycastHit JFEEEDGCAPO, float FNIJMIADAMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x54D5E30", Offset = "0x54D4E30", VA = "0x1854D5E30", Slot = "139")]
	public void PFHHLHIKMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x54D6050", Offset = "0x54D5050", VA = "0x1854D6050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x54D4EE0", Offset = "0x54D3EE0", VA = "0x1854D4EE0")]
	private void MIEEMNLFCOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x54D1640", Offset = "0x54D0640", VA = "0x1854D1640")]
	private void CJFENHGIGEE(PEMJBFLGGMM OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x54D5820", Offset = "0x54D4820", VA = "0x1854D5820")]
	private void OBDHJANEMGD(PEMJBFLGGMM OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x54D0DB0", Offset = "0x54CFDB0", VA = "0x1854D0DB0")]
	private void BOJMJLJHIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x54D47E0", Offset = "0x54D37E0", VA = "0x1854D47E0")]
	private void LKKBJCHBCOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x54D1950", Offset = "0x54D0950", VA = "0x1854D1950")]
	private void DHFHNNOJGHO(PEMJBFLGGMM OBCJBMNJCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x54D33C0", Offset = "0x54D23C0", VA = "0x1854D33C0")]
	private void GOBBLIKIBOC(PEMJBFLGGMM OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x54D1BF0", Offset = "0x54D0BF0", VA = "0x1854D1BF0")]
	private void DODGKOMIJNM(PEMJBFLGGMM OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x54D0170", Offset = "0x54CF170", VA = "0x1854D0170")]
	private void ADCNGJHKDKB(RigidbodyEx OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x54D28B0", Offset = "0x54D18B0", VA = "0x1854D28B0")]
	private void FLKADGMOHML(RigidbodyEx LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x54D5D00", Offset = "0x54D4D00", VA = "0x1854D5D00")]
	[Conditional("UNITY_EDITOR")]
	private void PCCIINJJIFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x54D4980", Offset = "0x54D3980", VA = "0x1854D4980")]
	protected void LPCKBJAIACO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x54D21F0", Offset = "0x54D11F0", VA = "0x1854D21F0")]
	protected void EMCHHAJEOKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class DEADILLHEJA
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x54C6C40", Offset = "0x54C5C40", VA = "0x1854C6C40")]
	public static PEMJBFLGGMM BDOILDEPFKL(this PEMJBFLGGMM LKMGIJIPLIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x54C6DC0", Offset = "0x54C5DC0", VA = "0x1854C6DC0")]
	public static bool IHGDEOBMJOA(this PEMJBFLGGMM LKMGIJIPLIN, PEMJBFLGGMM BGGGLHDGEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x54C6E40", Offset = "0x54C5E40", VA = "0x1854C6E40")]
	public static bool PFFODPCMNAO(this PEMJBFLGGMM LKMGIJIPLIN, PEMJBFLGGMM IMGNFLHGNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x54C6D70", Offset = "0x54C5D70", VA = "0x1854C6D70")]
	public static RigidbodyEx BHNPGPJFIDL(this PEMJBFLGGMM IPKNMKDFBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x54C6D00", Offset = "0x54C5D00", VA = "0x1854C6D00")]
	public static GAFHNPMJPMB BHLKCGGJEJK(this PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class MAEAADDDLBO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly GAFHNPMJPMB LKMGIJIPLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool FLFCLOAFFCN;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x54EA430", Offset = "0x54E9430", VA = "0x1854EA430")]
	public MAEAADDDLBO(GAFHNPMJPMB ANOKHAKIKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x54EA3D0", Offset = "0x54E93D0", VA = "0x1854EA3D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class JFFOGCKBJCO : GLKGHFNEBOE, AHAFDFAMMOI
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CollisionDetectionMode GDDIPJILDKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x54DE600", Offset = "0x54DD600", VA = "0x1854DE600")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x54DE6E0", Offset = "0x54DD6E0", VA = "0x1854DE6E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody OCHJHJGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x54C36D0", Offset = "0x54C26D0", VA = "0x1854C36D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CollisionDetectionMode IBLNPOEEODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x54DE9D0", Offset = "0x54DD9D0", VA = "0x1854DE9D0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x54DE580", Offset = "0x54DD580", VA = "0x1854DE580", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x54C3160", Offset = "0x54C2160", VA = "0x1854C3160")]
	public JFFOGCKBJCO(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x54DE3E0", Offset = "0x54DD3E0", VA = "0x1854DE3E0", Slot = "6")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x54DE4F0", Offset = "0x54DD4F0", VA = "0x1854DE4F0", Slot = "9")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x54DE3C0", Offset = "0x54DD3C0", VA = "0x1854DE3C0", Slot = "7")]
	public void CKELEIJDMGC(bool BJPNLAHPGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x54DE3D0", Offset = "0x54DD3D0", VA = "0x1854DE3D0", Slot = "8")]
	public void FAAPOKHEFAE(bool BJPNLAHPGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x54DE250", Offset = "0x54DD250", VA = "0x1854DE250", Slot = "10")]
	public bool CBCMNPEEDCJ(Vector3 JLBPNKFCLFO, out RaycastHit JFEEEDGCAPO, float FNIJMIADAMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x54DE7D0", Offset = "0x54DD7D0", VA = "0x1854DE7D0")]
	private void PHEBFFKLIOJ(bool BJPNLAHPGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class DAFGJOBLEJI : GLKGHFNEBOE, CCMAIABHGHM, IDisposable, NFBHMIKCNHJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public CLIIJKDLFPK DLIPJJIOMLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x54C6750", Offset = "0x54C5750", VA = "0x1854C6750")]
		get
		{
			return default(CLIIJKDLFPK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x54C6830", Offset = "0x54C5830", VA = "0x1854C6830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public CLIIJKDLFPK JLBHGNPAHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x54C6920", Offset = "0x54C5920", VA = "0x1854C6920", Slot = "6")]
		get
		{
			return default(CLIIJKDLFPK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x54C6830", Offset = "0x54C5830", VA = "0x1854C6830", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private Transform MPACEKJKBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6E6170", Offset = "0x6E5170", VA = "0x1806E6170", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<GMJLIEJPOEJ, GMJLIEJPOEJ> BKPNGAGNMKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x54C6BA0", Offset = "0x54C5BA0", VA = "0x1854C6BA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x54C66B0", Offset = "0x54C56B0", VA = "0x1854C66B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x54C3160", Offset = "0x54C2160", VA = "0x1854C3160")]
	public DAFGJOBLEJI(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x54C6B40", Offset = "0x54C5B40", VA = "0x1854C6B40", Slot = "11")]
	public void OnChangedDistanceBand(GMJLIEJPOEJ ENFEPLFMJNK, GMJLIEJPOEJ IEFBANIHOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "12")]
	public void OnChangedVisibility(bool DPOEBCKBBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "8")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class HEILDAJBMLO : GLKGHFNEBOE, EBDBHLCOCAL
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private Rigidbody OCHJHJGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x54C36D0", Offset = "0x54C26D0", VA = "0x1854C36D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool HIDLJAAELFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x54D9EF0", Offset = "0x54D8EF0", VA = "0x1854D9EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private bool OCODEBHAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x54C4A20", Offset = "0x54C3A20", VA = "0x1854C4A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private PEMJBFLGGMM AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x54D9C10", Offset = "0x54D8C10", VA = "0x1854D9C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x54C3160", Offset = "0x54C2160", VA = "0x1854C3160")]
	public HEILDAJBMLO(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x54D9AB0", Offset = "0x54D8AB0", VA = "0x1854D9AB0", Slot = "4")]
	public void LKANBCJLPMP(Vector3 AKNNPOEHKML, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x54D91B0", Offset = "0x54D81B0", VA = "0x1854D91B0")]
	private void APHEOOMGEAE(Vector3 AKNNPOEHKML, ForceMode KHIFDLIHLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x54D9810", Offset = "0x54D8810", VA = "0x1854D9810", Slot = "5")]
	public void LBNEOPMLINP(Vector3 AKNNPOEHKML, Vector3 MIFJBHLKJIN, ForceMode KHIFDLIHLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x54D96B0", Offset = "0x54D86B0", VA = "0x1854D96B0", Slot = "6")]
	public void HKPKKNJICLF(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x54D9C70", Offset = "0x54D8C70", VA = "0x1854D9C70")]
	private void PDBJHNFEIFK(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x54D9430", Offset = "0x54D8430", VA = "0x1854D9430", Slot = "7")]
	public void EIKMOLMEFMN(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class HBINDKBJBKF : GLKGHFNEBOE, COEGLBKNHNL
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool IKHDPECJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x54D8FD0", Offset = "0x54D7FD0", VA = "0x1854D8FD0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x54D8DF0", Offset = "0x54D7DF0", VA = "0x1854D8DF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x54C3160", Offset = "0x54C2160", VA = "0x1854C3160")]
	public HBINDKBJBKF(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x54D90B0", Offset = "0x54D80B0", VA = "0x1854D90B0", Slot = "6")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x54D8D80", Offset = "0x54D7D80", VA = "0x1854D8D80", Slot = "7")]
	public void EHKIOOCJGFF(Rigidbody BEMEPNIHEKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class ICKLKDNAEJE : GLKGHFNEBOE, KOFIFPKBGDE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly BNFDBLCAHDO DJHPOGLHKJI;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Transform AMINHCIEOMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x54DC430", Offset = "0x54DB430", VA = "0x1854DC430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public GPEJGMHBDPO DAFDAGLIEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x54DC290", Offset = "0x54DB290", VA = "0x1854DC290")]
		get
		{
			return default(GPEJGMHBDPO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x54DCA50", Offset = "0x54DBA50", VA = "0x1854DCA50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public PEMJBFLGGMM AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x54DD440", Offset = "0x54DC440", VA = "0x1854DD440", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x54DCFE0", Offset = "0x54DBFE0", VA = "0x1854DCFE0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public GPEJGMHBDPO EAONMAIKBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x54DBFC0", Offset = "0x54DAFC0", VA = "0x1854DBFC0")]
		get
		{
			return default(GPEJGMHBDPO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x54DD050", Offset = "0x54DC050", VA = "0x1854DD050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public PEMJBFLGGMM IMFMPPONFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x54DBEE0", Offset = "0x54DAEE0", VA = "0x1854DBEE0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyList<PEMJBFLGGMM> BIMGCBEFPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6F5770", Offset = "0x6F4770", VA = "0x1806F5770", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event ONKEIMPDALF FGKDCAIOBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x54DCF40", Offset = "0x54DBF40", VA = "0x1854DCF40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x54DBC90", Offset = "0x54DAC90", VA = "0x1854DBC90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event ONKEIMPDALF BJBFJNEGDJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x54DD700", Offset = "0x54DC700", VA = "0x1854DD700", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x54DC460", Offset = "0x54DB460", VA = "0x1854DC460", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event BAPGIHMPHAC JDHPMFPKGAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x54DC910", Offset = "0x54DB910", VA = "0x1854DC910", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x54DD480", Offset = "0x54DC480", VA = "0x1854DD480", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action CLLCEGLBDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x54DBF20", Offset = "0x54DAF20", VA = "0x1854DBF20", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x54DC5A0", Offset = "0x54DB5A0", VA = "0x1854DC5A0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action LHGLPPNOMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x54DD7A0", Offset = "0x54DC7A0", VA = "0x1854DD7A0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x54DD660", Offset = "0x54DC660", VA = "0x1854DD660", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<PEMJBFLGGMM> NEGJPDDONIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x54DD520", Offset = "0x54DC520", VA = "0x1854DD520", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x54DCB50", Offset = "0x54DBB50", VA = "0x1854DCB50", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<PEMJBFLGGMM> MKOODLOMFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x54DC9B0", Offset = "0x54DB9B0", VA = "0x1854DC9B0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x54DC500", Offset = "0x54DB500", VA = "0x1854DC500", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action JHGAJELOKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x54DD5C0", Offset = "0x54DC5C0", VA = "0x1854DD5C0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x54DCCE0", Offset = "0x54DBCE0", VA = "0x1854DCCE0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<PEMJBFLGGMM> LEMANBDPLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x54DC390", Offset = "0x54DB390", VA = "0x1854DC390", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x54DC640", Offset = "0x54DB640", VA = "0x1854DC640", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x54DD840", Offset = "0x54DC840", VA = "0x1854DD840")]
	public ICKLKDNAEJE(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x54DC0C0", Offset = "0x54DB0C0", VA = "0x1854DC0C0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x54DCC60", Offset = "0x54DBC60", VA = "0x1854DCC60", Slot = "26")]
	public void JDHACNMMLIE(PEMJBFLGGMM KHLHKJKADHO, bool GMEFKHHIEPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x54DCBF0", Offset = "0x54DBBF0", VA = "0x1854DCBF0")]
	private void JDHACNMMLIE(IMFFNFBANME KHLHKJKADHO, bool GMEFKHHIEPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x54DB360", Offset = "0x54DA360", VA = "0x1854DB360")]
	private void ANMOFPKAJBO(IMFFNFBANME KHLHKJKADHO, bool GMEFKHHIEPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x54DCD80", Offset = "0x54DBD80", VA = "0x1854DCD80")]
	private void JJJDGCHINFP(IMFFNFBANME OBCJBMNJCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x54DD280", Offset = "0x54DC280", VA = "0x1854DD280")]
	private void LLKFKAGPDOF(IMFFNFBANME OBCJBMNJCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x54DB1C0", Offset = "0x54DA1C0", VA = "0x1854DB1C0")]
	private void ACMEOJCFDDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x54DBD30", Offset = "0x54DAD30", VA = "0x1854DBD30")]
	private void CEJMMPCINJH(IMFFNFBANME OBCJBMNJCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x54DBBE0", Offset = "0x54DABE0", VA = "0x1854DBBE0")]
	private void BGGDFBNJICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x54DBDB0", Offset = "0x54DADB0", VA = "0x1854DBDB0")]
	private void COBJFADANHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x54DC7E0", Offset = "0x54DB7E0", VA = "0x1854DC7E0")]
	private void GFLPJLNLLDG(IMFFNFBANME LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x54DD150", Offset = "0x54DC150", VA = "0x1854DD150")]
	private void LDFJFKBFDMD(IMFFNFBANME LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x54DC6E0", Offset = "0x54DB6E0", VA = "0x1854DC6E0")]
	[CompilerGenerated]
	private object FOLCFPMAPCD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class KMOANCKPKKK
{
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x54E7900", Offset = "0x54E6900", VA = "0x1854E7900")]
	public static ICKLKDNAEJE AKFBLEDGEBH(this PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class DIFGNLBKGAE : GLKGHFNEBOE, DOLOBBHOJCN
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public Vector3 PPABHMBOJDG
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x54C8BC0", Offset = "0x54C7BC0", VA = "0x1854C8BC0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public Vector3 DIKOGGMMGKO
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x54C8170", Offset = "0x54C7170", VA = "0x1854C8170", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	private Vector3 LCNCCKHCPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x54C7FA0", Offset = "0x54C6FA0", VA = "0x1854C7FA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private PEMJBFLGGMM PFDDKBIHDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x54C83B0", Offset = "0x54C73B0", VA = "0x1854C83B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x54C3160", Offset = "0x54C2160", VA = "0x1854C3160")]
	public DIFGNLBKGAE(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x54C8A30", Offset = "0x54C7A30", VA = "0x1854C8A30", Slot = "6")]
	public void LEIFIIGNCAL(PEMJBFLGGMM OKMBLMILFGG, object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x54C8900", Offset = "0x54C7900", VA = "0x1854C8900")]
	private void LEIFIIGNCAL(IMFFNFBANME OKMBLMILFGG, object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x54C8080", Offset = "0x54C7080", VA = "0x1854C8080", Slot = "7")]
	public void DCNGBDBEBAG(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x54C8510", Offset = "0x54C7510", VA = "0x1854C8510")]
	private Vector3 KHDJGFCAFJN()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class CDCOFHCDLGA
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x54C6620", Offset = "0x54C5620", VA = "0x1854C6620")]
	public static DIFGNLBKGAE OEMBBBEGDIP(this PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class KIDKGFLHJFB : GLKGHFNEBOE, DPAGPKHBGMK
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 KDBEDBCAALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x54E4110", Offset = "0x54E3110", VA = "0x1854E4110", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x54E4470", Offset = "0x54E3470", VA = "0x1854E4470", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 CIMPCCAAMLF
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x54E4D60", Offset = "0x54E3D60", VA = "0x1854E4D60", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public float JCADBDOALOF
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x54E5390", Offset = "0x54E4390", VA = "0x1854E5390", Slot = "9")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x54E45B0", Offset = "0x54E35B0", VA = "0x1854E45B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float JPJAIDEFGCF
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x54E4940", Offset = "0x54E3940", VA = "0x1854E4940", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x54E4100", Offset = "0x54E3100", VA = "0x1854E4100", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public Vector3 OFHAOOPEAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x54E64C0", Offset = "0x54E54C0", VA = "0x1854E64C0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x54E4D30", Offset = "0x54E3D30", VA = "0x1854E4D30", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Quaternion OIBJJPCINPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x54E5130", Offset = "0x54E4130", VA = "0x1854E5130", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x54E4D10", Offset = "0x54E3D10", VA = "0x1854E4D10", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private Rigidbody OCHJHJGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x54C36D0", Offset = "0x54C26D0", VA = "0x1854C36D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event ONKEIMPDALF GCAFEBIMFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x54E4E80", Offset = "0x54E3E80", VA = "0x1854E4E80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x54E4060", Offset = "0x54E3060", VA = "0x1854E4060", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x54E7640", Offset = "0x54E6640", VA = "0x1854E7640")]
	public KIDKGFLHJFB(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x54E4B00", Offset = "0x54E3B00", VA = "0x1854E4B00", Slot = "17")]
	public void GCHILAJIGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x54E68E0", Offset = "0x54E58E0", VA = "0x1854E68E0", Slot = "16")]
	public void OPJNHLCKFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x54E64F0", Offset = "0x54E54F0", VA = "0x1854E64F0", Slot = "19")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x54E45C0", Offset = "0x54E35C0", VA = "0x1854E45C0", Slot = "20")]
	public void EHKIOOCJGFF(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x54E4A20", Offset = "0x54E3A20", VA = "0x1854E4A20", Slot = "18")]
	public void ENHMBOFJGPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x54E7030", Offset = "0x54E6030", VA = "0x1854E7030", Slot = "21")]
	public void PFHHLHIKMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x54CA660", Offset = "0x54C9660", VA = "0x1854CA660")]
	public void MOFFGHGKAFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x54E4470", Offset = "0x54E3470", VA = "0x1854E4470")]
	private void HNNBIOJHDFN(Vector3 KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x54E7520", Offset = "0x54E6520", VA = "0x1854E7520")]
	private Vector3 PIBNIEFFMLI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x54E6710", Offset = "0x54E5710", VA = "0x1854E6710")]
	private void OHAEJELHKHK(float KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x54E6E70", Offset = "0x54E5E70", VA = "0x1854E6E70")]
	private void PCLAMECJFPB(float KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x54E4240", Offset = "0x54E3240", VA = "0x1854E4240")]
	private Vector3 BJINAFCIKKL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x54E5160", Offset = "0x54E4160", VA = "0x1854E5160")]
	private void JELHKDPFBMA(Vector3 KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x54E4F20", Offset = "0x54E3F20", VA = "0x1854E4F20")]
	private Quaternion IMMAAHNEPAL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x54E6C60", Offset = "0x54E5C60", VA = "0x1854E6C60")]
	private void PCEJMLCKBGP(Quaternion KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x54E5470", Offset = "0x54E4470", VA = "0x1854E5470")]
	internal (float, Vector3) KFPHEOGPMGI(Rigidbody HKILLHMPOIL)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class IJNCJGEHJGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x54DD980", Offset = "0x54DC980", VA = "0x1854DD980")]
	public static KIDKGFLHJFB MFNOOEDINHH(this PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class FILIAHGOCKK : GLKGHFNEBOE, FAMFIMIKKAN
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private const string DKCIADJKFLI = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool ADAMCHGCIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x54CFC20", Offset = "0x54CEC20", VA = "0x1854CFC20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public CACECFKIIAN LGANHOBMNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x54CF460", Offset = "0x54CE460", VA = "0x1854CF460", Slot = "5")]
		get
		{
			return default(CACECFKIIAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private CACECFKIIAN DJNKNEBEENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x54CF8F0", Offset = "0x54CE8F0", VA = "0x1854CF8F0")]
		get
		{
			return default(CACECFKIIAN);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x54CF470", Offset = "0x54CE470", VA = "0x1854CF470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x54CFE50", Offset = "0x54CEE50", VA = "0x1854CFE50")]
	public FILIAHGOCKK(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x54CF790", Offset = "0x54CE790", VA = "0x1854CF790", Slot = "6")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x54CF850", Offset = "0x54CE850", VA = "0x1854CF850")]
	private bool KIOONBMNHCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x54CF560", Offset = "0x54CE560", VA = "0x1854CF560", Slot = "7")]
	public void DMFIPAONEJJ(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x54CF9D0", Offset = "0x54CE9D0", VA = "0x1854CF9D0", Slot = "8")]
	public void LOIGBFPIIGA(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x54CFB10", Offset = "0x54CEB10", VA = "0x1854CFB10", Slot = "11")]
	public void NCPFCGEECHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x54CF6A0", Offset = "0x54CE6A0", VA = "0x1854CF6A0")]
	private void FEICMNHAHJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x54CFD00", Offset = "0x54CED00", VA = "0x1854CFD00")]
	private void PBOKGMJLJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x54CF660", Offset = "0x54CE660", VA = "0x1854CF660", Slot = "10")]
	public void EPIMLABDGHA(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x54CFAD0", Offset = "0x54CEAD0", VA = "0x1854CFAD0", Slot = "9")]
	public void MEACCKMJFCC(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class OHCHCEFNEPO : GLKGHFNEBOE, KJKCPGCAIML
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool HIDLJAAELFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x6618120", Offset = "0x6617120", VA = "0x186618120", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public IEnumerable<object> KPJACHNJINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6617B50", Offset = "0x6616B50", VA = "0x186617B50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private bool AIBMDCPHFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x6618020", Offset = "0x6617020", VA = "0x186618020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event ONKEIMPDALF NKOIMHHPNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6617CE0", Offset = "0x6616CE0", VA = "0x186617CE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6617D80", Offset = "0x6616D80", VA = "0x186617D80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x66181B0", Offset = "0x66171B0", VA = "0x1866181B0")]
	public OHCHCEFNEPO(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x6617C80", Offset = "0x6616C80", VA = "0x186617C80", Slot = "11")]
	public IDisposable ILBPDKJDBCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x6618110", Offset = "0x6617110", VA = "0x186618110", Slot = "8")]
	public void OJMDMCDKKPE(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6617C70", Offset = "0x6616C70", VA = "0x186617C70", Slot = "9")]
	public void FHDCOJAJODE(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x6617E20", Offset = "0x6616E20", VA = "0x186617E20", Slot = "10")]
	public void LAOHBPMFIPD(object JAKCBCDLMLB, bool FANMJAGAPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6617FB0", Offset = "0x6616FB0", VA = "0x186617FB0", Slot = "12")]
	public void MIFKLLNLBMA(Rigidbody MMACFBGEFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6617C40", Offset = "0x6616C40", VA = "0x186617C40", Slot = "13")]
	public void EHKIOOCJGFF(Rigidbody BEMEPNIHEKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class OAJIIILBHJB : GLKGHFNEBOE, AEHNOIOGGNB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private PhotonView OLADCELCKCG;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool DHECOBNPECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x54C9530", Offset = "0x54C8530", VA = "0x1854C9530", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool PGDDLMMJJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x54EBE70", Offset = "0x54EAE70", VA = "0x1854EBE70", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event ONKEIMPDALF BLJCHPILBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x54EB7E0", Offset = "0x54EA7E0", VA = "0x1854EB7E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x54EC490", Offset = "0x54EB490", VA = "0x1854EC490", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x54EC690", Offset = "0x54EB690", VA = "0x1854EC690")]
	public OAJIIILBHJB(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x54EBF80", Offset = "0x54EAF80", VA = "0x1854EBF80", Slot = "8")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x54EBA80", Offset = "0x54EAA80", VA = "0x1854EBA80", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x54EBC70", Offset = "0x54EAC70", VA = "0x1854EBC70", Slot = "9")]
	public void GOBBLIKIBOC(PEMJBFLGGMM OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x54EB880", Offset = "0x54EA880", VA = "0x1854EB880", Slot = "10")]
	public void DODGKOMIJNM(PEMJBFLGGMM OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x54EC2A0", Offset = "0x54EB2A0", VA = "0x1854EC2A0")]
	private void MJKKJFIHOKF(PhotonView NGBCDGACPJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x54EC530", Offset = "0x54EB530", VA = "0x1854EC530")]
	private void PBGBNLJNCHB(RigidbodyEx CGFIDIJHMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x54EC0D0", Offset = "0x54EB0D0", VA = "0x1854EC0D0")]
	private void IGOHCJNCMGO(PhotonView LIFCNEOPDDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class KOFLGONBECM
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x54E7990", Offset = "0x54E6990", VA = "0x1854E7990")]
	public static OAJIIILBHJB DKMDFCGOODG(this GAFHNPMJPMB DNGPHMONFKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class MJNGMFLMECE : GLKGHFNEBOE, MNOPDMEBLBE
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool ELDBHBFKIGF
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x54EAC60", Offset = "0x54E9C60", VA = "0x1854EAC60", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x54EA870", Offset = "0x54E9870", VA = "0x1854EA870", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool JMMGDKCOBOK
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x54EA6B0", Offset = "0x54E96B0", VA = "0x1854EA6B0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x54EA4C0", Offset = "0x54E94C0", VA = "0x1854EA4C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public RigidbodyConstraints HLIGOHOAJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x54EA790", Offset = "0x54E9790", VA = "0x1854EA790", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x54EAA60", Offset = "0x54E9A60", VA = "0x1854EAA60", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x54EAD40", Offset = "0x54E9D40", VA = "0x1854EAD40")]
	public MJNGMFLMECE(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x54EA960", Offset = "0x54E9960", VA = "0x1854EA960", Slot = "9")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x54EA5B0", Offset = "0x54E95B0", VA = "0x1854EA5B0", Slot = "10")]
	public void EHKIOOCJGFF(Rigidbody BEMEPNIHEKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class AEFNFONOAEJ : GLKGHFNEBOE, BEGCJHEKPFH
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public float CMNCFAMIFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x54C2CE0", Offset = "0x54C1CE0", VA = "0x1854C2CE0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x54C2960", Offset = "0x54C1960", VA = "0x1854C2960", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public float GLPBFLLCCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x54C2B30", Offset = "0x54C1B30", VA = "0x1854C2B30", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x54C2DC0", Offset = "0x54C1DC0", VA = "0x1854C2DC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x54C3160", Offset = "0x54C2160", VA = "0x1854C3160")]
	public AEFNFONOAEJ(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x54C2F90", Offset = "0x54C1F90", VA = "0x1854C2F90", Slot = "8")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x54C2C10", Offset = "0x54C1C10", VA = "0x1854C2C10", Slot = "9")]
	public void EHKIOOCJGFF(Rigidbody BEMEPNIHEKJ)
	{
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[IABFONFHPFO(typeof(FKBFBGACCHL), new string[] { })]
	[OHGELDJCNJM(GGAOONGBEBH.Physics)]
	public sealed class RbexServiceCallbacks : MIBCENMOHFA, FKBFBGACCHL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly JHCDFELAIDH AOHKNGHOEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private OLGPCPINIDC LKMGIJIPLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private bool FLFCLOAFFCN;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool KCIOFPNPCCB
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F88D0", VA = "0x1806F98D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x6618390", Offset = "0x6617390", VA = "0x186618390", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6618360", Offset = "0x6617360", VA = "0x186618360", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x66183E0", Offset = "0x66173E0", VA = "0x1866183E0", Slot = "6")]
		public void KFPHEOGPMGI(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public RbexServiceCallbacks()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class EDKLLFKMKHG : GLKGHFNEBOE, FEJPDKKHHEB
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const int IEADCEPMANA = 10;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public const float NBCHBANONOI = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const float EAIGICHPJOE = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public const float CABFCCNLLHO = 5f;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private Rigidbody OCHJHJGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x54C36D0", Offset = "0x54C26D0", VA = "0x1854C36D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool IDEKOBKBJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x54CA890", Offset = "0x54C9890", VA = "0x1854CA890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool CEEGNNLCJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x54CA870", Offset = "0x54C9870", VA = "0x1854CA870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private PEMJBFLGGMM AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x54CA410", Offset = "0x54C9410", VA = "0x1854CA410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private bool OCODEBHAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x54CA600", Offset = "0x54C9600", VA = "0x1854CA600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool BIDFLEDLBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x54C9B10", Offset = "0x54C8B10", VA = "0x1854C9B10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x54CA510", Offset = "0x54C9510", VA = "0x1854CA510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private bool NBPCKCACJCH
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x54CA6A0", Offset = "0x54C96A0", VA = "0x1854CA6A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x54CA780", Offset = "0x54C9780", VA = "0x1854CA780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private int LOKHHJFBMHL
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x54C9A30", Offset = "0x54C8A30", VA = "0x1854C9A30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x54C9DA0", Offset = "0x54C8DA0", VA = "0x1854C9DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event ONKEIMPDALF HOLNOCHIGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x54C9FE0", Offset = "0x54C8FE0", VA = "0x1854C9FE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x54CA470", Offset = "0x54C9470", VA = "0x1854CA470", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x54CA930", Offset = "0x54C9930", VA = "0x1854CA930")]
	public EDKLLFKMKHG(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x54CA350", Offset = "0x54C9350", VA = "0x1854CA350", Slot = "6")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x54CA400", Offset = "0x54C9400", VA = "0x1854CA400", Slot = "8")]
	public void IGEMGMCLGIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x54CA130", Offset = "0x54C9130", VA = "0x1854CA130", Slot = "7")]
	public bool GOBGGIIBKON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x54C9980", Offset = "0x54C8980", VA = "0x1854C9980", Slot = "9")]
	public void AMHGNHLMFNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x54CA660", Offset = "0x54C9660", VA = "0x1854CA660", Slot = "12")]
	public void MOPGLEDKLOM(bool NBPKMHPMALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x54CA080", Offset = "0x54C9080", VA = "0x1854CA080", Slot = "11")]
	public void GKCJECCPPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "10")]
	public void EKFBEOFALEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x54C9BF0", Offset = "0x54C8BF0", VA = "0x1854C9BF0")]
	private bool CNCFDBKEHJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x54C9E90", Offset = "0x54C8E90", VA = "0x1854C9E90")]
	private void DPHEOMPFPLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class ANAJJKACFFF : GLKGHFNEBOE, BJEGJOOAAHN
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private const string MJDABFIBLLI = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Rigidbody OCHJHJGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x54C4680", Offset = "0x54C3680", VA = "0x1854C4680", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x54C3E90", Offset = "0x54C2E90", VA = "0x1854C3E90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private bool OCODEBHAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x54C4A20", Offset = "0x54C3A20", VA = "0x1854C4A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x54C4A80", Offset = "0x54C3A80", VA = "0x1854C4A80")]
	public ANAJJKACFFF(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x54C4310", Offset = "0x54C3310", VA = "0x1854C4310", Slot = "5")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x54C3D90", Offset = "0x54C2D90", VA = "0x1854C3D90", Slot = "6")]
	public void BNFFEJKELLJ(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x54C4920", Offset = "0x54C3920", VA = "0x1854C4920", Slot = "7")]
	public void LAIPLJBIIOF(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x54C43C0", Offset = "0x54C33C0", VA = "0x1854C43C0", Slot = "8")]
	public void ICGPBGLDJFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x54C3B30", Offset = "0x54C2B30", VA = "0x1854C3B30", Slot = "9")]
	public void BBBNKDJHOPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x54C4140", Offset = "0x54C3140", VA = "0x1854C4140", Slot = "10")]
	public void GOGONJBMCAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "11")]
	public void HDCHMOLMOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x54C3F80", Offset = "0x54C2F80", VA = "0x1854C3F80")]
	private void GMMEAGCIGJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x54C4760", Offset = "0x54C3760", VA = "0x1854C4760")]
	private void KOCAKEMPCLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class JOLGODBODJI : GLKGHFNEBOE, IGHPKHJEAKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public CCEJFGGKGLM CPIHALLPKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x54E21C0", Offset = "0x54E11C0", VA = "0x1854E21C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x54E3420", Offset = "0x54E2420", VA = "0x1854E3420", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public GGBMPGNAFJD OPABPNIHPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x54E2B20", Offset = "0x54E1B20", VA = "0x1854E2B20", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x54E26D0", Offset = "0x54E16D0", VA = "0x1854E26D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 LCNCCKHCPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x54E0CD0", Offset = "0x54DFCD0", VA = "0x1854E0CD0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x54E2550", Offset = "0x54E1550", VA = "0x1854E2550", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 AHAJMJBMMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x54E1D10", Offset = "0x54E0D10", VA = "0x1854E1D10", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x54E4030", Offset = "0x54E3030", VA = "0x1854E4030", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Vector3 JLGHJOIMMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x54E11D0", Offset = "0x54E01D0", VA = "0x1854E11D0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x54E37A0", Offset = "0x54E27A0", VA = "0x1854E37A0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 HBNCABOKHHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x54E3A70", Offset = "0x54E2A70", VA = "0x1854E3A70", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x54E24B0", Offset = "0x54E14B0", VA = "0x1854E24B0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public float FCAAJGFAJEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x54E0E20", Offset = "0x54DFE20", VA = "0x1854E0E20", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x54E3950", Offset = "0x54E2950", VA = "0x1854E3950", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool ACGMNKMENFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x54E1A10", Offset = "0x54E0A10", VA = "0x1854E1A10", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private EBDBHLCOCAL AONNGMAKJLK
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFF60", Offset = "0x1DAEF60", VA = "0x181DAFF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private bool CEEGNNLCJLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x54CA870", Offset = "0x54C9870", VA = "0x1854CA870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x54C3160", Offset = "0x54C2160", VA = "0x1854C3160")]
	public JOLGODBODJI(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x54E1F30", Offset = "0x54E0F30", VA = "0x1854E1F30", Slot = "20")]
	public void FOJGNOFNCLG(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x54E1C20", Offset = "0x54E0C20", VA = "0x1854E1C20", Slot = "31")]
	public void EJPJLNDPFPP(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x54E24E0", Offset = "0x54E14E0", VA = "0x1854E24E0", Slot = "19")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x54E1AF0", Offset = "0x54E0AF0", VA = "0x1854E1AF0", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x54E3760", Offset = "0x54E2760", VA = "0x1854E3760", Slot = "28")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x54E08C0", Offset = "0x54DF8C0", VA = "0x1854E08C0", Slot = "36")]
	public Vector3 ABHOGLBBGMA(Vector3 HFELIOHGGDO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x54E22F0", Offset = "0x54E12F0", VA = "0x1854E22F0", Slot = "35")]
	public Vector3 GNEKHGHFGKA(Vector3 FEAFOIFGCCF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x54E24E0", Offset = "0x54E14E0", VA = "0x1854E24E0", Slot = "27")]
	public void IIPKPIBFBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x54E2020", Offset = "0x54E1020", VA = "0x1854E2020", Slot = "25")]
	public void GJGKIDGKPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x54E19D0", Offset = "0x54E09D0", VA = "0x1854E19D0", Slot = "24")]
	public void CMHHFMOHFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x54E1790", Offset = "0x54E0790", VA = "0x1854E1790", Slot = "34")]
	public void CJHODKMAJBE(Vector3 OLJIPBFJCBL, Vector3 CJANALIFPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x54E3510", Offset = "0x54E2510", VA = "0x1854E3510", Slot = "33")]
	public void LICDBAEOAFD(Vector3 OABJFLBJEKB, Vector3 IMCNKNPLDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x54E2060", Offset = "0x54E1060", VA = "0x1854E2060", Slot = "32")]
	public void GMEDHCFFMEH(Vector3 ANJGHBFDIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x54E1320", Offset = "0x54E0320", VA = "0x1854E1320", Slot = "22")]
	public void CBOAGHDBPJH(OBJOKHNKAPP CAMLNFGKHFE, Vector3 MAIIDBKHIED, float JOFBEKECLOD, float CLOJEHHLDHC = 8f, float ILPINEMCFMP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x54E0AA0", Offset = "0x54DFAA0", VA = "0x1854E0AA0", Slot = "21")]
	public void AFOBMMCCHIM(EKKHOJNPNMO PNJHOCPNCML, Vector3 NFNPPPGADBK, float MMIALNFHMCC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x54E0F00", Offset = "0x54DFF00", VA = "0x1854E0F00", Slot = "23")]
	[Obsolete]
	public void BMPJNHFGFFL(EKKHOJNPNMO PNJHOCPNCML, Vector3 OLBDAPNGDPL, float CEIPLLMFOOE = 7f, float OGLOAGFEIHM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x54E2610", Offset = "0x54E1610", VA = "0x1854E2610", Slot = "30")]
	public Vector3 IDKDPPMOKNN(Vector3 FJHEIJDCBEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x54E3860", Offset = "0x54E2860", VA = "0x1854E3860", Slot = "29")]
	public Vector3 NOILBEMLPLM(Vector3 BAMHFNACLOC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x54E3630", Offset = "0x54E2630", VA = "0x1854E3630", Slot = "26")]
	public void MDDKFEEINFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x54E2C50", Offset = "0x54E1C50", VA = "0x1854E2C50")]
	private void JCFEOFGMADC(float KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x54E3B90", Offset = "0x54E2B90", VA = "0x1854E3B90")]
	private void PANKLFBIFGF(Vector3 NFNPPPGADBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x54E3960", Offset = "0x54E2960", VA = "0x1854E3960")]
	private Vector3 OICADJOPIOK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x54E3CF0", Offset = "0x54E2CF0", VA = "0x1854E3CF0")]
	private void PLMCKOJFMKL(Vector3 FEAFOIFGCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x54E1E20", Offset = "0x54E0E20", VA = "0x1854E1E20")]
	private Vector3 FDMJOFIOEHO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x54E27C0", Offset = "0x54E17C0", VA = "0x1854E27C0")]
	private void INELDJICPMM(Vector3 KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x54E2E20", Offset = "0x54E1E20", VA = "0x1854E2E20")]
	private void KBIABBAPIJA(Vector3 FEAFOIFGCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x54E3570", Offset = "0x54E2570", VA = "0x1854E3570")]
	private void LICLOKPCMOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class GLKGHFNEBOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly IMFFNFBANME LKMGIJIPLIN;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected OLGPCPINIDC CBKNAIMKJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xBC4610", Offset = "0xBC3610", VA = "0x180BC4610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected GPEJGMHBDPO PJKAPDAPHHE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x54D8CD0", Offset = "0x54D7CD0", VA = "0x1854D8CD0")]
		get
		{
			return default(GPEJGMHBDPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x54C3160", Offset = "0x54C2160", VA = "0x1854C3160")]
	public GLKGHFNEBOE(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x54D8BB0", Offset = "0x54D7BB0", VA = "0x1854D8BB0")]
	protected PEMJBFLGGMM AEEHHDDIJIH(GPEJGMHBDPO LCCDBPIJCNE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class EOLPDLGBALJ : HMOFCBOHILL
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x54CEDC0", Offset = "0x54CDDC0", VA = "0x1854CEDC0", Slot = "4")]
	public KOFIFPKBGDE HPMJMPJAEBF(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x54CEAC0", Offset = "0x54CDAC0", VA = "0x1854CEAC0", Slot = "5")]
	public IGHPKHJEAKK ELGDCBJCMFN(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x54CF0C0", Offset = "0x54CE0C0", VA = "0x1854CF0C0", Slot = "6")]
	public DOLOBBHOJCN JPOHICNGBBP(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x54CF160", Offset = "0x54CE160", VA = "0x1854CF160", Slot = "7")]
	public BEGCJHEKPFH KCHPJLDNMCG(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x54CF2A0", Offset = "0x54CE2A0", VA = "0x1854CF2A0", Slot = "8")]
	public FEJPDKKHHEB LNKOELKMANO(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x54CF3C0", Offset = "0x54CE3C0", VA = "0x1854CF3C0", Slot = "9")]
	public CCMAIABHGHM OKIKOAODBKA(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x54CEB60", Offset = "0x54CDB60", VA = "0x1854CEB60", Slot = "10")]
	public KJKCPGCAIML GBFBEIIDFCA(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x54CEBC0", Offset = "0x54CDBC0", VA = "0x1854CEBC0", Slot = "11")]
	public EBDBHLCOCAL GJGOKLOIGBN(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x54CF200", Offset = "0x54CE200", VA = "0x1854CF200", Slot = "12")]
	public AHAFDFAMMOI LHOEKHPMJKM(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x54CED20", Offset = "0x54CDD20", VA = "0x1854CED20", Slot = "13")]
	public COEGLBKNHNL HLENLHEFFLE(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x54CEC60", Offset = "0x54CDC60", VA = "0x1854CEC60")]
	public BJEGJOOAAHN HLAKIFBKGOD(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x54CF300", Offset = "0x54CE300", VA = "0x1854CF300")]
	public AEHNOIOGGNB PFOFCHGKLBD(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x54CEF30", Offset = "0x54CDF30", VA = "0x1854CEF30")]
	public FAMFIMIKKAN JOJCEHJOGPP(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x54CEA50", Offset = "0x54CDA50", VA = "0x1854CEA50")]
	public DPAGPKHBGMK DBPGDMNKLJL(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x54CE930", Offset = "0x54CD930", VA = "0x1854CE930")]
	public MNOPDMEBLBE KCDDEIIAPGE(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x54CE9A0", Offset = "0x54CD9A0", VA = "0x1854CE9A0", Slot = "19")]
	public PEMJBFLGGMM BBMPNOCKHLJ(RigidbodyEx LKMGIJIPLIN, IKIHJJFFHFA FNIHENPLJHK, OOMBAIEJEBP CBBILOOJOAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public EOLPDLGBALJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x54CEC60", Offset = "0x54CDC60", VA = "0x1854CEC60", Slot = "14")]
	private BJEGJOOAAHN NGEGFJLNLMF(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x54CF300", Offset = "0x54CE300", VA = "0x1854CF300", Slot = "15")]
	private AEHNOIOGGNB NKLPIGOJNFO(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x54CEF30", Offset = "0x54CDF30", VA = "0x1854CEF30", Slot = "16")]
	private FAMFIMIKKAN JEMOMHAJBJM(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x54CEA50", Offset = "0x54CDA50", VA = "0x1854CEA50", Slot = "17")]
	private DPAGPKHBGMK INHHAPJMGIP(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x54CE930", Offset = "0x54CD930", VA = "0x1854CE930", Slot = "18")]
	private MNOPDMEBLBE AHFFIDEIBJD(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class BNFDBLCAHDO : IReadOnlyList<PEMJBFLGGMM>, IEnumerable<PEMJBFLGGMM>, IEnumerable, IReadOnlyCollection<PEMJBFLGGMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly GPEJGMHBDPO LCCDBPIJCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly OLGPCPINIDC GNJOCELFONM;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x54C6000", Offset = "0x54C5000", VA = "0x1854C6000", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public PEMJBFLGGMM IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x54C60D0", Offset = "0x54C50D0", VA = "0x1854C60D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x54C5FB0", Offset = "0x54C4FB0", VA = "0x1854C5FB0")]
	public BNFDBLCAHDO(GPEJGMHBDPO LCCDBPIJCNE, OLGPCPINIDC GNJOCELFONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x54C5E10", Offset = "0x54C4E10", VA = "0x1854C5E10", Slot = "6")]
	public IEnumerator<PEMJBFLGGMM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x54C5E10", Offset = "0x54C4E10", VA = "0x1854C5E10", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x54C5FA0", Offset = "0x54C4FA0", VA = "0x1854C5FA0")]
	[CompilerGenerated]
	private PEMJBFLGGMM OOONPIIKMGJ(int BDAADCOCKII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[IABFONFHPFO(typeof(HMOFCBOHILL), new string[] { })]
public class HINFBEJMPDK : HMOFCBOHILL, MIBCENMOHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly HMOFCBOHILL CDINOJJOLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly HMOFCBOHILL ALNGLBHBEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private AHENLKMMNNA ACCCBDFPKPF;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private HMOFCBOHILL CHGCPFMHBIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x54DA770", Offset = "0x54D9770", VA = "0x1854DA770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x54DAD00", Offset = "0x54D9D00", VA = "0x1854DAD00", Slot = "20")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x54DABB0", Offset = "0x54D9BB0", VA = "0x1854DABB0", Slot = "4")]
	public KOFIFPKBGDE HPMJMPJAEBF(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x54DA880", Offset = "0x54D9880", VA = "0x1854DA880", Slot = "5")]
	public IGHPKHJEAKK ELGDCBJCMFN(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x54DAD50", Offset = "0x54D9D50", VA = "0x1854DAD50", Slot = "6")]
	public DOLOBBHOJCN JPOHICNGBBP(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x54DADF0", Offset = "0x54D9DF0", VA = "0x1854DADF0", Slot = "7")]
	public BEGCJHEKPFH KCHPJLDNMCG(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x54DAF30", Offset = "0x54D9F30", VA = "0x1854DAF30", Slot = "8")]
	public FEJPDKKHHEB LNKOELKMANO(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x54DB080", Offset = "0x54DA080", VA = "0x1854DB080", Slot = "9")]
	public CCMAIABHGHM OKIKOAODBKA(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x54DA920", Offset = "0x54D9920", VA = "0x1854DA920", Slot = "10")]
	public KJKCPGCAIML GBFBEIIDFCA(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x54DA9C0", Offset = "0x54D99C0", VA = "0x1854DA9C0", Slot = "11")]
	public EBDBHLCOCAL GJGOKLOIGBN(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x54DAE90", Offset = "0x54D9E90", VA = "0x1854DAE90", Slot = "12")]
	public AHAFDFAMMOI LHOEKHPMJKM(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x54DAB10", Offset = "0x54D9B10", VA = "0x1854DAB10", Slot = "13")]
	public COEGLBKNHNL HLENLHEFFLE(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x54DAA60", Offset = "0x54D9A60", VA = "0x1854DAA60")]
	public BJEGJOOAAHN HLAKIFBKGOD(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x54DAFD0", Offset = "0x54D9FD0", VA = "0x1854DAFD0")]
	public AEHNOIOGGNB PFOFCHGKLBD(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x54DAC50", Offset = "0x54D9C50", VA = "0x1854DAC50")]
	public FAMFIMIKKAN JOJCEHJOGPP(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x54DA7D0", Offset = "0x54D97D0", VA = "0x1854DA7D0")]
	public DPAGPKHBGMK DBPGDMNKLJL(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x54DA570", Offset = "0x54D9570", VA = "0x1854DA570")]
	public MNOPDMEBLBE KCDDEIIAPGE(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x54DA620", Offset = "0x54D9620", VA = "0x1854DA620", Slot = "19")]
	public PEMJBFLGGMM BBMPNOCKHLJ(RigidbodyEx LKMGIJIPLIN, IKIHJJFFHFA FNIHENPLJHK, OOMBAIEJEBP CBBILOOJOAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x54DB120", Offset = "0x54DA120", VA = "0x1854DB120")]
	public HINFBEJMPDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x54DAA60", Offset = "0x54D9A60", VA = "0x1854DAA60", Slot = "14")]
	private BJEGJOOAAHN NGEGFJLNLMF(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x54DAFD0", Offset = "0x54D9FD0", VA = "0x1854DAFD0", Slot = "15")]
	private AEHNOIOGGNB NKLPIGOJNFO(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x54DAC50", Offset = "0x54D9C50", VA = "0x1854DAC50", Slot = "16")]
	private FAMFIMIKKAN JEMOMHAJBJM(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x54DA7D0", Offset = "0x54D97D0", VA = "0x1854DA7D0", Slot = "17")]
	private DPAGPKHBGMK INHHAPJMGIP(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x54DA570", Offset = "0x54D9570", VA = "0x1854DA570", Slot = "18")]
	private MNOPDMEBLBE AHFFIDEIBJD(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Preserve]
public sealed class GPKGOIFLNJC : PEMJBFLGGMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly GPKGOIFLNJC FDNKALDKIIB;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Rigidbody OCHJHJGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public RigidbodyEx BHNPGPJFIDL
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public GameObject OCGHLHMMGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Transform AMINHCIEOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public IEnumerable<object> EPIMPBJGKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public PEMJBFLGGMM AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x6E6570", Offset = "0x6E5570", VA = "0x1806E6570", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x6E6590", Offset = "0x6E5590", VA = "0x1806E6590", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public IReadOnlyList<PEMJBFLGGMM> BIMGCBEFPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6E6580", Offset = "0x6E5580", VA = "0x1806E6580", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public PEMJBFLGGMM IMFMPPONFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0D0", Offset = "0x6DE0D0", VA = "0x1806DF0D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool OCODEBHAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xF10FD0", Offset = "0xF0FFD0", VA = "0x180F10FD0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool DHECOBNPECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1202C80", Offset = "0x1201C80", VA = "0x181202C80", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool PGDDLMMJJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xB91E00", Offset = "0xB90E00", VA = "0x180B91E00", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public CCEJFGGKGLM CPIHALLPKPB
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0B0", Offset = "0x6DE0B0", VA = "0x1806DF0B0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7D7320", Offset = "0x7D6320", VA = "0x1807D7320", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public GGBMPGNAFJD OPABPNIHPDI
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5770", Offset = "0x6F4770", VA = "0x1806F5770", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x780AD0", Offset = "0x77FAD0", VA = "0x180780AD0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public float FCAAJGFAJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x15AEE70", Offset = "0x15ADE70", VA = "0x1815AEE70", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x15AEF10", Offset = "0x15ADF10", VA = "0x1815AEF10", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 AHAJMJBMMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x25F30A0", Offset = "0x25F20A0", VA = "0x1825F30A0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x25F2FC0", Offset = "0x25F1FC0", VA = "0x1825F2FC0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 HBNCABOKHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x1C0EBF0", Offset = "0x1C0DBF0", VA = "0x181C0EBF0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x1C0C120", Offset = "0x1C0B120", VA = "0x181C0C120", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 LCNCCKHCPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x1C0EC10", Offset = "0x1C0DC10", VA = "0x181C0EC10", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1C0A970", Offset = "0x1C09970", VA = "0x181C0A970", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Vector3 JLGHJOIMMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x11BC7B0", Offset = "0x11BB7B0", VA = "0x1811BC7B0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool CPPIJLCAPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xBC8240", Offset = "0xBC7240", VA = "0x180BC8240", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool GBCOKGPNABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xC0C870", Offset = "0xC0B870", VA = "0x180C0C870", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool DCOIJAMPGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xC0C860", Offset = "0xC0B860", VA = "0x180C0C860", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool ACGMNKMENFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xA87AE0", Offset = "0xA86AE0", VA = "0x180A87AE0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Vector3 PPABHMBOJDG
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x17BB550", Offset = "0x17BA550", VA = "0x1817BB550", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 DIKOGGMMGKO
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1632A90", Offset = "0x1631A90", VA = "0x181632A90", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 KDBEDBCAALJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x11BC7B0", Offset = "0x11BB7B0", VA = "0x1811BC7B0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 CIMPCCAAMLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x1C0ECD0", Offset = "0x1C0DCD0", VA = "0x181C0ECD0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public float JCADBDOALOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x11384E0", Offset = "0x11374E0", VA = "0x1811384E0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float JPJAIDEFGCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x130EAF0", Offset = "0x130DAF0", VA = "0x18130EAF0", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 OFHAOOPEAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x11BC7B0", Offset = "0x11BB7B0", VA = "0x1811BC7B0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion OIBJJPCINPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x11AFBF0", Offset = "0x11AEBF0", VA = "0x1811AFBF0", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public float CMNCFAMIFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x130EAF0", Offset = "0x130DAF0", VA = "0x18130EAF0", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public float GLPBFLLCCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x130EAF0", Offset = "0x130DAF0", VA = "0x18130EAF0", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool IKHDPECJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool EJFKHFNNKHH
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CLIIJKDLFPK JLBHGNPAHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "52")]
		get
		{
			return default(CLIIJKDLFPK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool HIDLJAAELFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x21F0A80", Offset = "0x21EFA80", VA = "0x1821F0A80", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Transform AAMHCPKDGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x80F840", Offset = "0x80E840", VA = "0x18080F840", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Transform GFCCGCABKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x7977C0", Offset = "0x7967C0", VA = "0x1807977C0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Vector3 HFOAEBOMNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x11BC7B0", Offset = "0x11BB7B0", VA = "0x1811BC7B0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float FKAPONKEAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x130EAF0", Offset = "0x130DAF0", VA = "0x18130EAF0", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public float FOMCKPAPOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x130EAF0", Offset = "0x130DAF0", VA = "0x18130EAF0", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Quaternion CBCKCFLIFDK
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x10222E0", Offset = "0x10212E0", VA = "0x1810222E0", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Vector3 INAHNKFEMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x11BC7B0", Offset = "0x11BB7B0", VA = "0x1811BC7B0", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Quaternion PHAFEIAABKC
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x10222E0", Offset = "0x10212E0", VA = "0x1810222E0", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public RigidbodyConstraints HLIGOHOAJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x6E6170", Offset = "0x6E5170", VA = "0x1806E6170", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool ELDBHBFKIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public CollisionDetectionMode IBLNPOEEODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x6E6170", Offset = "0x6E5170", VA = "0x1806E6170", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool CEEGNNLCJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xFA4190", Offset = "0xFA3190", VA = "0x180FA4190", Slot = "75")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event ONKEIMPDALF FGKDCAIOBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event ONKEIMPDALF BJBFJNEGDJP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event BAPGIHMPHAC JDHPMFPKGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event ONKEIMPDALF BLJCHPILBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event ONKEIMPDALF BPFDNFOMPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event ONKEIMPDALF HOLNOCHIGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<GMJLIEJPOEJ, GMJLIEJPOEJ> BKPNGAGNMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event ONKEIMPDALF PEJBAIOJGEE
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event ONKEIMPDALF JFGDBEMBLMM
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "125")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "126")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "76")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "77")]
	public void HDKFJIKLEJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "78")]
	public void EPMHDFKPLEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "79")]
	public void AMHGNHLMFNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "80")]
	public void EJBOICBIHAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "87")]
	public void JDHACNMMLIE(PEMJBFLGGMM KPPLMEOMNGF, bool GMEFKHHIEPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "90")]
	public void BFMOPJLHBBG(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "91")]
	public void LHGJEIODGLO(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x11BC7B0", Offset = "0x11BB7B0", VA = "0x1811BC7B0", Slot = "92")]
	public Vector3 ABHOGLBBGMA(Vector3 HFELIOHGGDO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x11BC7B0", Offset = "0x11BB7B0", VA = "0x1811BC7B0", Slot = "93")]
	public Vector3 GNEKHGHFGKA(Vector3 FEAFOIFGCCF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "94")]
	public void IIPKPIBFBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "95")]
	public void GJGKIDGKPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "96")]
	public void CMHHFMOHFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "97")]
	public void CJHODKMAJBE(Vector3 OLJIPBFJCBL, Vector3 CJANALIFPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "98")]
	public void LICDBAEOAFD(Vector3 OABJFLBJEKB, Vector3 IMCNKNPLDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "99")]
	public void GMEDHCFFMEH(Vector3 ANJGHBFDIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "100")]
	public void CBOAGHDBPJH(OBJOKHNKAPP CAMLNFGKHFE, Vector3 MAIIDBKHIED, float JOFBEKECLOD, float CLOJEHHLDHC = 8f, float ILPINEMCFMP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "101")]
	public void AFOBMMCCHIM(EKKHOJNPNMO PNJHOCPNCML, Vector3 NFNPPPGADBK, float MMIALNFHMCC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "102")]
	public void BMPJNHFGFFL(EKKHOJNPNMO PNJHOCPNCML, Vector3 OLBDAPNGDPL, float CEIPLLMFOOE = 7f, float OGLOAGFEIHM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x11BC7B0", Offset = "0x11BB7B0", VA = "0x1811BC7B0", Slot = "103")]
	public Vector3 IDKDPPMOKNN(Vector3 KPPLMEOMNGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x11BC7B0", Offset = "0x11BB7B0", VA = "0x1811BC7B0", Slot = "104")]
	public Vector3 NOILBEMLPLM(Vector3 KPPLMEOMNGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "105")]
	public void MDDKFEEINFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "106")]
	public void MEJBHJGELMJ(PEMJBFLGGMM HEPODBMIMNP, object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "107")]
	public void GAIBLGGKAKK(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "110")]
	public void GCHILAJIGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "111")]
	public void OPJNHLCKFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "112")]
	public void ENHMBOFJGPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "115")]
	public bool GOBGGIIBKON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "116")]
	public void GKCJECCPPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6E6170", Offset = "0x6E5170", VA = "0x1806E6170", Slot = "121")]
	public IDisposable ILBPDKJDBCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "122")]
	public void OJMDMCDKKPE(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "123")]
	public void FHDCOJAJODE(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "124")]
	public void LAOHBPMFIPD(object JAKCBCDLMLB, bool FANMJAGAPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "127")]
	public void AGNLAHKGJCD(Vector3 IIHKIEHLKJE, Quaternion OKGAEIKHFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "128")]
	public void CGBDHLAKFPB(Vector3 JAGOFJILOLJ, Quaternion PAFGOIINECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "129")]
	public bool BGJIPHJJDJL(float DEGNNNFBBGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "130")]
	public void KGPNCHMMJJG(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "131")]
	public void EFNCJDLHIIK(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "132")]
	public void BNFFEJKELLJ(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "133")]
	public void LAIPLJBIIOF(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "134")]
	public void LKANBCJLPMP(Vector3 AKNNPOEHKML, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "135")]
	public void LBNEOPMLINP(Vector3 AKNNPOEHKML, Vector3 MIFJBHLKJIN, ForceMode KHIFDLIHLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "136")]
	public void HKPKKNJICLF(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "137")]
	public void EIKMOLMEFMN(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x54D8D00", Offset = "0x54D7D00", VA = "0x1854D8D00", Slot = "138")]
	public bool CBCMNPEEDCJ(Vector3 JLBPNKFCLFO, out RaycastHit JFEEEDGCAPO, float FNIJMIADAMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "139")]
	public void PFHHLHIKMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public GPKGOIFLNJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class IMFFNFBANME : GAFHNPMJPMB, KLALODLBPPC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	internal GPEJGMHBDPO LCCDBPIJCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	internal OLGPCPINIDC LHCLNKNGLAO;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x54DE240", Offset = "0x54DD240", VA = "0x1854DE240")]
	public IMFFNFBANME(GameObject BLPBCMIHDMD, RigidbodyEx JKNMFOBKPNO, OOMBAIEJEBP CBBILOOJOAK, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x54DDD00", Offset = "0x54DCD00", VA = "0x1854DDD00", Slot = "142")]
	protected override void CICIFIGLLJJ(OOMBAIEJEBP CBBILOOJOAK, IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x54DDF90", Offset = "0x54DCF90", VA = "0x1854DDF90", Slot = "143")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x54DDA10", Offset = "0x54DCA10", VA = "0x1854DDA10", Slot = "145")]
	public void AKLOKOLCHJE(CBFJMCFAKAM ENFEPLFMJNK, CBFJMCFAKAM IEFBANIHOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x54DDC40", Offset = "0x54DCC40", VA = "0x1854DDC40", Slot = "146")]
	public void AOBLDGDALCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x54DE120", Offset = "0x54DD120", VA = "0x1854DE120", Slot = "147")]
	public void JCPJHKHAFHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x54DE1E0", Offset = "0x54DD1E0", VA = "0x1854DE1E0", Slot = "148")]
	public void MOPGLEDKLOM(bool NBPKMHPMALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x54DDAE0", Offset = "0x54DCAE0", VA = "0x1854DDAE0", Slot = "149")]
	public bool ANBIINOJEPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "144")]
	public override void EJBOICBIHAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class AJDCAPBMBKG
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x54C3AE0", Offset = "0x54C2AE0", VA = "0x1854C3AE0")]
	public static GAFHNPMJPMB BGLLCLODHIH(this PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface DFIPBNCMOHJ : KOFIFPKBGDE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFLPJLNLLDG(PEMJBFLGGMM LKMGIJIPLIN);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LDFJFKBFDMD(PEMJBFLGGMM LKMGIJIPLIN);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJJDGCHINFP(PEMJBFLGGMM OBCJBMNJCJN);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LLKFKAGPDOF(PEMJBFLGGMM OBCJBMNJCJN);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface DNGCENMLNGI : DOLOBBHOJCN
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	global::JOJICCBKMBL<PEMJBFLGGMM> GJPJKGKACEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	PEMJBFLGGMM PFDDKBIHDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface KDAAOBKCANG : DPAGPKHBGMK
{
	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) KFPHEOGPMGI(Rigidbody HKILLHMPOIL);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface KCFNNGILHCH : AEHNOIOGGNB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	PhotonView NMAEAMDJDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class AJCMBNBPOCE : AHAFDFAMMOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly GAFHNPMJPMB LKMGIJIPLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private CollisionDetectionMode ONDIHNNFNCP;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private Rigidbody OCHJHJGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x54C36D0", Offset = "0x54C26D0", VA = "0x1854C36D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public CollisionDetectionMode IBLNPOEEODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x54C3940", Offset = "0x54C2940", VA = "0x1854C3940", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x54C37A0", Offset = "0x54C27A0", VA = "0x1854C37A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x54C3A50", Offset = "0x54C2A50", VA = "0x1854C3A50")]
	public AJCMBNBPOCE(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x54C35B0", Offset = "0x54C25B0", VA = "0x1854C35B0", Slot = "6")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x54C3720", Offset = "0x54C2720", VA = "0x1854C3720", Slot = "9")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x54C3590", Offset = "0x54C2590", VA = "0x1854C3590", Slot = "7")]
	public void CKELEIJDMGC(bool BJPNLAHPGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x54C35A0", Offset = "0x54C25A0", VA = "0x1854C35A0", Slot = "8")]
	public void FAAPOKHEFAE(bool BJPNLAHPGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x54C3420", Offset = "0x54C2420", VA = "0x1854C3420", Slot = "10")]
	public bool CBCMNPEEDCJ(Vector3 JLBPNKFCLFO, out RaycastHit JFEEEDGCAPO, float FNIJMIADAMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x54C3810", Offset = "0x54C2810", VA = "0x1854C3810")]
	private void PHEBFFKLIOJ(bool BJPNLAHPGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class LOACJNKAMFP : CCMAIABHGHM, IDisposable, NFBHMIKCNHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const int JELGOOBEIBH = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly GAFHNPMJPMB LKMGIJIPLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private CLIIJKDLFPK ONBOIAGPHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private OOGGPHHIOEI AMOCLAAKHIF;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public CLIIJKDLFPK JLBHGNPAHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x54EA0E0", Offset = "0x54E90E0", VA = "0x1854EA0E0", Slot = "6")]
		get
		{
			return default(CLIIJKDLFPK);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x54E9CB0", Offset = "0x54E8CB0", VA = "0x1854E9CB0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Transform MPACEKJKBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x54EA0C0", Offset = "0x54E90C0", VA = "0x1854EA0C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<GMJLIEJPOEJ, GMJLIEJPOEJ> BKPNGAGNMKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x54EA220", Offset = "0x54E9220", VA = "0x1854EA220", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x54E9BC0", Offset = "0x54E8BC0", VA = "0x1854E9BC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x54EA2C0", Offset = "0x54E92C0", VA = "0x1854EA2C0")]
	public LOACJNKAMFP(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x54E9D80", Offset = "0x54E8D80", VA = "0x1854E9D80", Slot = "8")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x54E9C60", Offset = "0x54E8C60", VA = "0x1854E9C60", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x54EA060", Offset = "0x54E9060", VA = "0x1854EA060", Slot = "11")]
	private void KIIOGLGMDAF(GMJLIEJPOEJ BBGPNJDGJOJ, GMJLIEJPOEJ BDOHNKDFFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "12")]
	private void MPENIDFFLDN(bool DPOEBCKBBJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class LLNCOKAMAFD : EBDBHLCOCAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly GAFHNPMJPMB LKMGIJIPLIN;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Rigidbody OCHJHJGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x54C36D0", Offset = "0x54C26D0", VA = "0x1854C36D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private bool HIDLJAAELFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x54D9EF0", Offset = "0x54D8EF0", VA = "0x1854D9EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private bool OCODEBHAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x54C4A20", Offset = "0x54C3A20", VA = "0x1854C4A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private PEMJBFLGGMM AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x54E91E0", Offset = "0x54E81E0", VA = "0x1854E91E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x54C3A50", Offset = "0x54C2A50", VA = "0x1854C3A50")]
	public LLNCOKAMAFD(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x54E9080", Offset = "0x54E8080", VA = "0x1854E9080", Slot = "4")]
	public void LKANBCJLPMP(Vector3 AKNNPOEHKML, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x54E8780", Offset = "0x54E7780", VA = "0x1854E8780")]
	private void APHEOOMGEAE(Vector3 AKNNPOEHKML, ForceMode KHIFDLIHLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x54E8DE0", Offset = "0x54E7DE0", VA = "0x1854E8DE0", Slot = "5")]
	public void LBNEOPMLINP(Vector3 AKNNPOEHKML, Vector3 MIFJBHLKJIN, ForceMode KHIFDLIHLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x54E8C80", Offset = "0x54E7C80", VA = "0x1854E8C80", Slot = "6")]
	public void HKPKKNJICLF(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x54E9240", Offset = "0x54E8240", VA = "0x1854E9240")]
	private void PDBJHNFEIFK(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x54E8A00", Offset = "0x54E7A00", VA = "0x1854E8A00", Slot = "7")]
	public void EIKMOLMEFMN(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class MLJIJONONIB : COEGLBKNHNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly GAFHNPMJPMB LKMGIJIPLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool BMOGOGGFIGA;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool IKHDPECJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F88D0", VA = "0x1806F98D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x54EAF80", Offset = "0x54E9F80", VA = "0x1854EAF80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x54C3A50", Offset = "0x54C2A50", VA = "0x1854C3A50")]
	public MLJIJONONIB(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x54EB090", Offset = "0x54EA090", VA = "0x1854EB090", Slot = "6")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x54D8D80", Offset = "0x54D7D80", VA = "0x1854D8D80", Slot = "7")]
	public void EHKIOOCJGFF(Rigidbody BEMEPNIHEKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class JLGHEJKJAIM : DFIPBNCMOHJ, KOFIFPKBGDE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly PEMJBFLGGMM LKMGIJIPLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<PEMJBFLGGMM> DJHPOGLHKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private PEMJBFLGGMM IGJDJDNFANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private PEMJBFLGGMM OKMBLMILFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Transform JBDAALBGCDI;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private Transform AMINHCIEOMN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x54DF1C0", Offset = "0x54DE1C0", VA = "0x1854DF1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public PEMJBFLGGMM AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F5700", Offset = "0x6F4700", VA = "0x1806F5700", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x54E0050", Offset = "0x54DF050", VA = "0x1854E0050", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public PEMJBFLGGMM IMFMPPONFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x6F5780", Offset = "0x6F4780", VA = "0x1806F5780", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public IReadOnlyList<PEMJBFLGGMM> BIMGCBEFPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x6F5770", Offset = "0x6F4770", VA = "0x1806F5770", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event ONKEIMPDALF FGKDCAIOBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x54DFFB0", Offset = "0x54DEFB0", VA = "0x1854DFFB0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x54DECA0", Offset = "0x54DDCA0", VA = "0x1854DECA0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event ONKEIMPDALF BJBFJNEGDJP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x54E06D0", Offset = "0x54DF6D0", VA = "0x1854E06D0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x54DF220", Offset = "0x54DE220", VA = "0x1854DF220", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event BAPGIHMPHAC JDHPMFPKGAD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x54DF540", Offset = "0x54DE540", VA = "0x1854DF540", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x54E0450", Offset = "0x54DF450", VA = "0x1854E0450", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action CLLCEGLBDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x54DF000", Offset = "0x54DE000", VA = "0x1854DF000", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x54DF360", Offset = "0x54DE360", VA = "0x1854DF360", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action LHGLPPNOMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x54E0770", Offset = "0x54DF770", VA = "0x1854E0770", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x54E0630", Offset = "0x54DF630", VA = "0x1854E0630", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<PEMJBFLGGMM> NEGJPDDONIC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x54E04F0", Offset = "0x54DF4F0", VA = "0x1854E04F0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x54DF680", Offset = "0x54DE680", VA = "0x1854DF680", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<PEMJBFLGGMM> MKOODLOMFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x54DF5E0", Offset = "0x54DE5E0", VA = "0x1854DF5E0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x54DF2C0", Offset = "0x54DE2C0", VA = "0x1854DF2C0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action JHGAJELOKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x54E0590", Offset = "0x54DF590", VA = "0x1854E0590", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x54DFCC0", Offset = "0x54DECC0", VA = "0x1854DFCC0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<PEMJBFLGGMM> LEMANBDPLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x54DF120", Offset = "0x54DE120", VA = "0x1854DF120", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x54DF400", Offset = "0x54DE400", VA = "0x1854DF400", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x54E0810", Offset = "0x54DF810", VA = "0x1854E0810")]
	public JLGHEJKJAIM(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x54DF0A0", Offset = "0x54DE0A0", VA = "0x1854DF0A0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x54DF720", Offset = "0x54DE720", VA = "0x1854DF720", Slot = "30")]
	public void JDHACNMMLIE(PEMJBFLGGMM KHLHKJKADHO, bool GMEFKHHIEPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x54DFD60", Offset = "0x54DED60", VA = "0x1854DFD60", Slot = "6")]
	public void JJJDGCHINFP(PEMJBFLGGMM OBCJBMNJCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x54E01F0", Offset = "0x54DF1F0", VA = "0x1854E01F0", Slot = "7")]
	public void LLKFKAGPDOF(PEMJBFLGGMM OBCJBMNJCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x54DF4A0", Offset = "0x54DE4A0", VA = "0x1854DF4A0", Slot = "4")]
	public void GFLPJLNLLDG(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x54E0150", Offset = "0x54DF150", VA = "0x1854E0150", Slot = "5")]
	public void LDFJFKBFDMD(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x54DEAE0", Offset = "0x54DDAE0", VA = "0x1854DEAE0")]
	private void ACMEOJCFDDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x54DED40", Offset = "0x54DDD40", VA = "0x1854DED40")]
	private void CEJMMPCINJH(PEMJBFLGGMM OBCJBMNJCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x54DEEB0", Offset = "0x54DDEB0", VA = "0x1854DEEB0")]
	private void DCLEOJKOOIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x54DEB70", Offset = "0x54DDB70", VA = "0x1854DEB70")]
	private void BGGDFBNJICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x54DED80", Offset = "0x54DDD80", VA = "0x1854DED80")]
	private void COBJFADANHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x54E0060", Offset = "0x54DF060", VA = "0x1854E0060")]
	[CompilerGenerated]
	private object KPHCMMANGKM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class GAEHKBKKFBB
{
	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x54CFFC0", Offset = "0x54CEFC0", VA = "0x1854CFFC0")]
	public static DFIPBNCMOHJ AKFBLEDGEBH(this PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class EOLMEMIOLOI : DNGCENMLNGI, DOLOBBHOJCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly GAFHNPMJPMB LKMGIJIPLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly global::JOJICCBKMBL<PEMJBFLGGMM> FFDAIKFJKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool DHKNDLEAKNL;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public global::JOJICCBKMBL<PEMJBFLGGMM> GJPJKGKACEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Vector3 PPABHMBOJDG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x54CE470", Offset = "0x54CD470", VA = "0x1854CE470", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public Vector3 DIKOGGMMGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x54CDE30", Offset = "0x54CCE30", VA = "0x1854CDE30", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private Vector3 LCNCCKHCPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x54CDCF0", Offset = "0x54CCCF0", VA = "0x1854CDCF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public PEMJBFLGGMM PFDDKBIHDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x54CE000", Offset = "0x54CD000", VA = "0x1854CE000", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x54CE840", Offset = "0x54CD840", VA = "0x1854CE840")]
	public EOLMEMIOLOI(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x54CE400", Offset = "0x54CD400", VA = "0x1854CE400", Slot = "8")]
	public void LEIFIIGNCAL(PEMJBFLGGMM OKMBLMILFGG, object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x54CDDD0", Offset = "0x54CCDD0", VA = "0x1854CDDD0", Slot = "9")]
	public void DCNGBDBEBAG(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x54CE0B0", Offset = "0x54CD0B0", VA = "0x1854CE0B0")]
	private Vector3 KHDJGFCAFJN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x54CE4A0", Offset = "0x54CD4A0", VA = "0x1854CE4A0")]
	private void NMNLIDBJLAH(PEMJBFLGGMM KDELELJPDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class BCNPDOJBGBA
{
	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x54C5D50", Offset = "0x54C4D50", VA = "0x1854C5D50")]
	public static DNGCENMLNGI OEMBBBEGDIP(this PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class GANEHBCINGN : KDAAOBKCANG, DPAGPKHBGMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly GAFHNPMJPMB LKMGIJIPLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly OverridableVector3 BPHDIFLPGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly OverridableVector3 JEOEIFINIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float ADJBEFMGEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private float ICHMOGPIDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Vector3 MKPLIDDMPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Vector3? MIDKEEPKLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Quaternion? FAGMBLNKBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool MIHACODCCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool EBJBKCKAEBA;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 KDBEDBCAALJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x11DB450", Offset = "0x11DA450", VA = "0x1811DB450", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x54D63A0", Offset = "0x54D53A0", VA = "0x1854D63A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 CIMPCCAAMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x54D6DF0", Offset = "0x54D5DF0", VA = "0x1854D6DF0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float JCADBDOALOF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x1587360", Offset = "0x1586360", VA = "0x181587360", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x54D63C0", Offset = "0x54D53C0", VA = "0x1854D63C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public float JPJAIDEFGCF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x1012170", Offset = "0x1011170", VA = "0x181012170", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x54D6200", Offset = "0x54D5200", VA = "0x1854D6200", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Vector3 OFHAOOPEAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x54D8200", Offset = "0x54D7200", VA = "0x1854D8200", Slot = "13")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x54D6C50", Offset = "0x54D5C50", VA = "0x1854D6C50", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public Quaternion OIBJJPCINPO
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x54D70F0", Offset = "0x54D60F0", VA = "0x1854D70F0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x54D6AB0", Offset = "0x54D5AB0", VA = "0x1854D6AB0", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody OCHJHJGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x54C5A10", Offset = "0x54C4A10", VA = "0x1854C5A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event ONKEIMPDALF GCAFEBIMFLK
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x54D6EF0", Offset = "0x54D5EF0", VA = "0x1854D6EF0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x54D6160", Offset = "0x54D5160", VA = "0x1854D6160", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x54D8AE0", Offset = "0x54D7AE0", VA = "0x1854D8AE0")]
	public GANEHBCINGN(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x54D68F0", Offset = "0x54D58F0", VA = "0x1854D68F0", Slot = "18")]
	public void GCHILAJIGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x54D8450", Offset = "0x54D7450", VA = "0x1854D8450", Slot = "17")]
	public void OPJNHLCKFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x54D8370", Offset = "0x54D7370", VA = "0x1854D8370", Slot = "20")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x54D64E0", Offset = "0x54D54E0", VA = "0x1854D64E0", Slot = "21")]
	public void EHKIOOCJGFF(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x54D6780", Offset = "0x54D5780", VA = "0x1854D6780", Slot = "19")]
	public void ENHMBOFJGPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x54D8530", Offset = "0x54D7530", VA = "0x1854D8530", Slot = "22")]
	public void PFHHLHIKMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x54D63A0", Offset = "0x54D53A0", VA = "0x1854D63A0")]
	private void HNNBIOJHDFN(Vector3 KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x54D89F0", Offset = "0x54D79F0", VA = "0x1854D89F0")]
	private Vector3 PIBNIEFFMLI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x54D63C0", Offset = "0x54D53C0", VA = "0x1854D63C0")]
	private void OHAEJELHKHK(float KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x54D6200", Offset = "0x54D5200", VA = "0x1854D6200")]
	private void PCLAMECJFPB(float KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x54D6220", Offset = "0x54D5220", VA = "0x1854D6220")]
	private Vector3 BJINAFCIKKL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x54D6C50", Offset = "0x54D5C50", VA = "0x1854D6C50")]
	private void JELHKDPFBMA(Vector3 KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x54D6F90", Offset = "0x54D5F90", VA = "0x1854D6F90")]
	private Quaternion IMMAAHNEPAL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x54D6AB0", Offset = "0x54D5AB0", VA = "0x1854D6AB0")]
	private void PCEJMLCKBGP(Quaternion KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x54D8120", Offset = "0x54D7120", VA = "0x1854D8120")]
	public void KFPHEOGPMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x54D7260", Offset = "0x54D6260", VA = "0x1854D7260", Slot = "4")]
	public (float, Vector3) KFPHEOGPMGI(Rigidbody HKILLHMPOIL)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class NPILOOBAKCL
{
	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x54EB720", Offset = "0x54EA720", VA = "0x1854EB720")]
	public static KDAAOBKCANG MFNOOEDINHH(this PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class LNDDAJDGAEE : FAMFIMIKKAN
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private const string DKCIADJKFLI = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly GAFHNPMJPMB LKMGIJIPLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly JLNNFJHBOML KOFOAHHMJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly CACECFKIIAN HMHPFNKNCJD;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool ADAMCHGCIHK
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x1CDE2B0", Offset = "0x1CDD2B0", VA = "0x181CDE2B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public CACECFKIIAN LGANHOBMNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x6DF010", Offset = "0x6DE010", VA = "0x1806DF010", Slot = "5")]
		get
		{
			return default(CACECFKIIAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x54E9AD0", Offset = "0x54E8AD0", VA = "0x1854E9AD0")]
	public LNDDAJDGAEE(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x54E9640", Offset = "0x54E8640", VA = "0x1854E9640", Slot = "6")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x54E9710", Offset = "0x54E8710", VA = "0x1854E9710")]
	private bool KIOONBMNHCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x54E94C0", Offset = "0x54E84C0", VA = "0x1854E94C0", Slot = "7")]
	public void DMFIPAONEJJ(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x54E97B0", Offset = "0x54E87B0", VA = "0x1854E97B0", Slot = "8")]
	public void LOIGBFPIIGA(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x54E9820", Offset = "0x54E8820", VA = "0x1854E9820", Slot = "11")]
	public void NCPFCGEECHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x54E9530", Offset = "0x54E8530", VA = "0x1854E9530")]
	private void FEICMNHAHJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x54E9950", Offset = "0x54E8950", VA = "0x1854E9950")]
	private void PBOKGMJLJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x54E94F0", Offset = "0x54E84F0", VA = "0x1854E94F0", Slot = "10")]
	public void EPIMLABDGHA(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x54E97E0", Offset = "0x54E87E0", VA = "0x1854E97E0", Slot = "9")]
	public void MEACCKMJFCC(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class NKGAJHDPEAL : KJKCPGCAIML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly GAFHNPMJPMB LKMGIJIPLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly JLNNFJHBOML NECCMAHPNED;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool HIDLJAAELFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x54EB580", Offset = "0x54EA580", VA = "0x1854EB580", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IEnumerable<object> KPJACHNJINE
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x54EB0C0", Offset = "0x54EA0C0", VA = "0x1854EB0C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event ONKEIMPDALF NKOIMHHPNOC
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x54EB1E0", Offset = "0x54EA1E0", VA = "0x1854EB1E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x54EB280", Offset = "0x54EA280", VA = "0x1854EB280", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x54EB640", Offset = "0x54EA640", VA = "0x1854EB640")]
	public NKGAJHDPEAL(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x54EB120", Offset = "0x54EA120", VA = "0x1854EB120", Slot = "11")]
	public IDisposable ILBPDKJDBCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x54EB4A0", Offset = "0x54EA4A0", VA = "0x1854EB4A0", Slot = "8")]
	public void OJMDMCDKKPE(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x54EB110", Offset = "0x54EA110", VA = "0x1854EB110", Slot = "9")]
	public void FHDCOJAJODE(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x54EB320", Offset = "0x54EA320", VA = "0x1854EB320", Slot = "10")]
	public void LAOHBPMFIPD(object JAKCBCDLMLB, bool FANMJAGAPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x54EB420", Offset = "0x54EA420", VA = "0x1854EB420", Slot = "12")]
	public void MIFKLLNLBMA(Rigidbody MMACFBGEFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x54EB0E0", Offset = "0x54EA0E0", VA = "0x1854EB0E0", Slot = "13")]
	public void EHKIOOCJGFF(Rigidbody BEMEPNIHEKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class ECLDGFPDPLI : KCFNNGILHCH, AEHNOIOGGNB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly GAFHNPMJPMB LKMGIJIPLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private PhotonView OLADCELCKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool JIEIFIMONIL;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public PhotonView NMAEAMDJDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool DHECOBNPECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x54C9530", Offset = "0x54C8530", VA = "0x1854C9530", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool PGDDLMMJJIL
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x7CFFA0", Offset = "0x7CEFA0", VA = "0x1807CFFA0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event ONKEIMPDALF BLJCHPILBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x54C8CB0", Offset = "0x54C7CB0", VA = "0x1854C8CB0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x54C96D0", Offset = "0x54C86D0", VA = "0x1854C96D0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x54C98E0", Offset = "0x54C88E0", VA = "0x1854C98E0")]
	public ECLDGFPDPLI(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x54C9160", Offset = "0x54C8160", VA = "0x1854C9160", Slot = "9")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x54C8ED0", Offset = "0x54C7ED0", VA = "0x1854C8ED0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x54C8FE0", Offset = "0x54C7FE0", VA = "0x1854C8FE0", Slot = "10")]
	public void GOBBLIKIBOC(PEMJBFLGGMM OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x54C8D50", Offset = "0x54C7D50", VA = "0x1854C8D50", Slot = "11")]
	public void DODGKOMIJNM(PEMJBFLGGMM OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x54C9550", Offset = "0x54C8550", VA = "0x1854C9550")]
	private void MJKKJFIHOKF(PhotonView NGBCDGACPJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x54C9770", Offset = "0x54C8770", VA = "0x1854C9770")]
	private void PBGBNLJNCHB(RigidbodyEx CGFIDIJHMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x54C92B0", Offset = "0x54C82B0", VA = "0x1854C92B0")]
	private void IGOHCJNCMGO(PhotonView LIFCNEOPDDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class EBCOJEKIBBC
{
	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x54C8BF0", Offset = "0x54C7BF0", VA = "0x1854C8BF0")]
	public static KCFNNGILHCH DKMDFCGOODG(this PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class AHEGFBGBFCO : MNOPDMEBLBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly GAFHNPMJPMB LKMGIJIPLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private RigidbodyConstraints CKKHKJALDEO;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool ELDBHBFKIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xA61AF0", Offset = "0xA60AF0", VA = "0x180A61AF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x23B3760", Offset = "0x23B2760", VA = "0x1823B3760", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool JMMGDKCOBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x23B3750", Offset = "0x23B2750", VA = "0x1823B3750", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x23B3740", Offset = "0x23B2740", VA = "0x1823B3740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public RigidbodyConstraints HLIGOHOAJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6E0BD0", Offset = "0x6DFBD0", VA = "0x1806E0BD0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x54C3240", Offset = "0x54C2240", VA = "0x1854C3240", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x54C3380", Offset = "0x54C2380", VA = "0x1854C3380")]
	public AHEGFBGBFCO(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x54C3210", Offset = "0x54C2210", VA = "0x1854C3210", Slot = "9")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x54C31E0", Offset = "0x54C21E0", VA = "0x1854C31E0", Slot = "10")]
	public void EHKIOOCJGFF(Rigidbody BEMEPNIHEKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class CBIKEAEOOHF : BEGCJHEKPFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly PEMJBFLGGMM LKMGIJIPLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private float FAFJFMCOIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float PNHAJHONKIF;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public float CMNCFAMIFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x11E0800", Offset = "0x11DF800", VA = "0x1811E0800", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x54C6350", Offset = "0x54C5350", VA = "0x1854C6350", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public float GLPBFLLCCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x1145CE0", Offset = "0x1144CE0", VA = "0x181145CE0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x54C64C0", Offset = "0x54C54C0", VA = "0x1854C64C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x54C65E0", Offset = "0x54C55E0", VA = "0x1854C65E0")]
	public CBIKEAEOOHF(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x54C6590", Offset = "0x54C5590", VA = "0x1854C6590", Slot = "8")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x54C6420", Offset = "0x54C5420", VA = "0x1854C6420", Slot = "9")]
	public void EHKIOOCJGFF(Rigidbody BEMEPNIHEKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class BBMKOGPAMPG : FEJPDKKHHEB
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private const int IEADCEPMANA = 10;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const float NBCHBANONOI = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const float EAIGICHPJOE = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private const float CABFCCNLLHO = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly GAFHNPMJPMB LKMGIJIPLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool EBOIADGOODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool AJHGLLANEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int JHHIKEHBMFL;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private Rigidbody OCHJHJGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x54C5A10", Offset = "0x54C4A10", VA = "0x1854C5A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private bool IDEKOBKBJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x54C5C20", Offset = "0x54C4C20", VA = "0x1854C5C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private bool CEEGNNLCJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x54C5C00", Offset = "0x54C4C00", VA = "0x1854C5C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private PEMJBFLGGMM AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x54C5A60", Offset = "0x54C4A60", VA = "0x1854C5A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool OCODEBHAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x54C5B60", Offset = "0x54C4B60", VA = "0x1854C5B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event ONKEIMPDALF HOLNOCHIGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x54C53B0", Offset = "0x54C43B0", VA = "0x1854C53B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x54C5AC0", Offset = "0x54C4AC0", VA = "0x1854C5AC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x54C5CC0", Offset = "0x54C4CC0", VA = "0x1854C5CC0")]
	public BBMKOGPAMPG(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x54C5970", Offset = "0x54C4970", VA = "0x1854C5970", Slot = "6")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x54C5A00", Offset = "0x54C4A00", VA = "0x1854C5A00", Slot = "8")]
	public void IGEMGMCLGIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x54C5820", Offset = "0x54C4820", VA = "0x1854C5820", Slot = "7")]
	public bool GOBGGIIBKON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x54C4FD0", Offset = "0x54C3FD0", VA = "0x1854C4FD0", Slot = "9")]
	public void AMHGNHLMFNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x54C5780", Offset = "0x54C4780", VA = "0x1854C5780", Slot = "11")]
	public void GKCJECCPPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x54C5BC0", Offset = "0x54C4BC0", VA = "0x1854C5BC0", Slot = "12")]
	public void MOPGLEDKLOM(bool NBPKMHPMALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x54C5450", Offset = "0x54C4450", VA = "0x1854C5450", Slot = "10")]
	public void EKFBEOFALEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x54C5070", Offset = "0x54C4070", VA = "0x1854C5070")]
	private bool CNCFDBKEHJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x54C5220", Offset = "0x54C4220", VA = "0x1854C5220")]
	private void DPHEOMPFPLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class DEKKDKDKGHO : BJEGJOOAAHN
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const string MJDABFIBLLI = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly GAFHNPMJPMB LKMGIJIPLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly JLNNFJHBOML ENJHPLPDNAH;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Rigidbody OCHJHJGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x6E0130", Offset = "0x6DF130", VA = "0x1806E0130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private bool OCODEBHAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x54C4A20", Offset = "0x54C3A20", VA = "0x1854C4A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x54C7EB0", Offset = "0x54C6EB0", VA = "0x1854C7EB0")]
	public DEKKDKDKGHO(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x54C78C0", Offset = "0x54C68C0", VA = "0x1854C78C0", Slot = "5")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x54C70C0", Offset = "0x54C60C0", VA = "0x1854C70C0", Slot = "6")]
	public void BNFFEJKELLJ(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x54C7E80", Offset = "0x54C6E80", VA = "0x1854C7E80", Slot = "7")]
	public void LAIPLJBIIOF(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x54C7970", Offset = "0x54C6970", VA = "0x1854C7970", Slot = "8")]
	public void ICGPBGLDJFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x54C6EC0", Offset = "0x54C5EC0", VA = "0x1854C6EC0", Slot = "9")]
	public void BBBNKDJHOPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x54C72A0", Offset = "0x54C62A0", VA = "0x1854C72A0", Slot = "10")]
	public void GOGONJBMCAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x54C7420", Offset = "0x54C6420", VA = "0x1854C7420", Slot = "11")]
	public void HDCHMOLMOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x54C70F0", Offset = "0x54C60F0", VA = "0x1854C70F0")]
	private void GMMEAGCIGJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x54C7CD0", Offset = "0x54C6CD0", VA = "0x1854C7CD0")]
	private void KOCAKEMPCLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class EECKBIDCJML : IGHPKHJEAKK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly GAFHNPMJPMB LKMGIJIPLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly JLNNFJHBOML KLIONHGEGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float NNEHANMEMGB;

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public CCEJFGGKGLM CPIHALLPKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x6F98E0", Offset = "0x6F88E0", VA = "0x1806F98E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x721210", Offset = "0x720210", VA = "0x180721210", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public GGBMPGNAFJD OPABPNIHPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x6F56F0", Offset = "0x6F46F0", VA = "0x1806F56F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x777B00", Offset = "0x776B00", VA = "0x180777B00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public Vector3 LCNCCKHCPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x54CAF40", Offset = "0x54C9F40", VA = "0x1854CAF40", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x54CC150", Offset = "0x54CB150", VA = "0x1854CC150", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public Vector3 AHAJMJBMMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x54CBB90", Offset = "0x54CAB90", VA = "0x1854CBB90", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x54CD8B0", Offset = "0x54CC8B0", VA = "0x1854CD8B0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 JLGHJOIMMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x54CB330", Offset = "0x54CA330", VA = "0x1854CB330", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x54CD0B0", Offset = "0x54CC0B0", VA = "0x1854CD0B0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public Vector3 HBNCABOKHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x54CD350", Offset = "0x54CC350", VA = "0x1854CD350", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x54CC0B0", Offset = "0x54CB0B0", VA = "0x1854CC0B0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public float FCAAJGFAJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x107F900", Offset = "0x107E900", VA = "0x18107F900", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x54CC610", Offset = "0x54CB610", VA = "0x1854CC610", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public bool ACGMNKMENFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x2068920", Offset = "0x2067920", VA = "0x182068920", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private EBDBHLCOCAL AONNGMAKJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFF60", Offset = "0x1DAEF60", VA = "0x181DAFF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private bool CEEGNNLCJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x54CA870", Offset = "0x54C9870", VA = "0x1854CA870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x54CD8E0", Offset = "0x54CC8E0", VA = "0x1854CD8E0")]
	public EECKBIDCJML(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x54CC0E0", Offset = "0x54CB0E0", VA = "0x1854CC0E0", Slot = "19")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x54CBB30", Offset = "0x54CAB30", VA = "0x1854CBB30", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x54CCF80", Offset = "0x54CBF80", VA = "0x1854CCF80", Slot = "28")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0xFE2E90", Offset = "0xFE1E90", VA = "0x180FE2E90", Slot = "20")]
	public void FOJGNOFNCLG(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0xFE39E0", Offset = "0xFE29E0", VA = "0x180FE39E0", Slot = "31")]
	public void EJPJLNDPFPP(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x54CAB30", Offset = "0x54C9B30", VA = "0x1854CAB30", Slot = "36")]
	public Vector3 ABHOGLBBGMA(Vector3 HFELIOHGGDO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x54CBEF0", Offset = "0x54CAEF0", VA = "0x1854CBEF0", Slot = "35")]
	public Vector3 GNEKHGHFGKA(Vector3 FEAFOIFGCCF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x54CC0E0", Offset = "0x54CB0E0", VA = "0x1854CC0E0", Slot = "27")]
	public void IIPKPIBFBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x54CBD70", Offset = "0x54CAD70", VA = "0x1854CBD70", Slot = "25")]
	public void GJGKIDGKPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x54CBAF0", Offset = "0x54CAAF0", VA = "0x1854CBAF0", Slot = "24")]
	public void CMHHFMOHFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x54CB8B0", Offset = "0x54CA8B0", VA = "0x1854CB8B0", Slot = "34")]
	public void CJHODKMAJBE(Vector3 OLJIPBFJCBL, Vector3 CJANALIFPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x54CCD30", Offset = "0x54CBD30", VA = "0x1854CCD30", Slot = "33")]
	public void LICDBAEOAFD(Vector3 OABJFLBJEKB, Vector3 IMCNKNPLDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x54CBDB0", Offset = "0x54CADB0", VA = "0x1854CBDB0", Slot = "32")]
	public void GMEDHCFFMEH(Vector3 ANJGHBFDIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x54CB460", Offset = "0x54CA460", VA = "0x1854CB460", Slot = "22")]
	public void CBOAGHDBPJH(OBJOKHNKAPP CAMLNFGKHFE, Vector3 MAIIDBKHIED, float JOFBEKECLOD, float CLOJEHHLDHC = 8f, float ILPINEMCFMP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x54CAD10", Offset = "0x54C9D10", VA = "0x1854CAD10", Slot = "21")]
	public void AFOBMMCCHIM(EKKHOJNPNMO PNJHOCPNCML, Vector3 NFNPPPGADBK, float MMIALNFHMCC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x54CB060", Offset = "0x54CA060", VA = "0x1854CB060", Slot = "23")]
	[Obsolete]
	public void BMPJNHFGFFL(EKKHOJNPNMO PNJHOCPNCML, Vector3 OLBDAPNGDPL, float CEIPLLMFOOE = 7f, float OGLOAGFEIHM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x54CC210", Offset = "0x54CB210", VA = "0x1854CC210", Slot = "30")]
	public Vector3 IDKDPPMOKNN(Vector3 FJHEIJDCBEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x54CD170", Offset = "0x54CC170", VA = "0x1854CD170", Slot = "29")]
	public Vector3 NOILBEMLPLM(Vector3 BAMHFNACLOC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x54CCE50", Offset = "0x54CBE50", VA = "0x1854CCE50", Slot = "26")]
	public void MDDKFEEINFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x54CC610", Offset = "0x54CB610", VA = "0x1854CC610")]
	private void JCFEOFGMADC(float KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x54CD440", Offset = "0x54CC440", VA = "0x1854CD440")]
	private void PANKLFBIFGF(Vector3 NFNPPPGADBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x54CD260", Offset = "0x54CC260", VA = "0x1854CD260")]
	private Vector3 OICADJOPIOK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x54CD580", Offset = "0x54CC580", VA = "0x1854CD580")]
	private void PLMCKOJFMKL(Vector3 FEAFOIFGCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x54CBC80", Offset = "0x54CAC80", VA = "0x1854CBC80")]
	private Vector3 FDMJOFIOEHO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x54CC2D0", Offset = "0x54CB2D0", VA = "0x1854CC2D0")]
	private void INELDJICPMM(Vector3 KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x54CC730", Offset = "0x54CB730", VA = "0x1854CC730")]
	private void KBIABBAPIJA(Vector3 FEAFOIFGCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x54CCD90", Offset = "0x54CBD90", VA = "0x1854CCD90")]
	private void LICLOKPCMOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class LGFBDCBNIPC : HMOFCBOHILL
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x54E8100", Offset = "0x54E7100", VA = "0x1854E8100", Slot = "4")]
	public KOFIFPKBGDE HPMJMPJAEBF(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x54E7C70", Offset = "0x54E6C70", VA = "0x1854E7C70", Slot = "5")]
	public IGHPKHJEAKK ELGDCBJCMFN(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x54E8300", Offset = "0x54E7300", VA = "0x1854E8300", Slot = "6")]
	public DOLOBBHOJCN JPOHICNGBBP(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x54E8410", Offset = "0x54E7410", VA = "0x1854E8410", Slot = "7")]
	public BEGCJHEKPFH KCHPJLDNMCG(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x54E8530", Offset = "0x54E7530", VA = "0x1854E8530", Slot = "8")]
	public FEJPDKKHHEB LNKOELKMANO(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x54E86C0", Offset = "0x54E76C0", VA = "0x1854E86C0", Slot = "9")]
	public CCMAIABHGHM OKIKOAODBKA(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x54E7D80", Offset = "0x54E6D80", VA = "0x1854E7D80", Slot = "10")]
	public KJKCPGCAIML GBFBEIIDFCA(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x54E7E80", Offset = "0x54E6E80", VA = "0x1854E7E80", Slot = "11")]
	public EBDBHLCOCAL GJGOKLOIGBN(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x54E8480", Offset = "0x54E7480", VA = "0x1854E8480", Slot = "12")]
	public AHAFDFAMMOI LHOEKHPMJKM(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x54E8050", Offset = "0x54E7050", VA = "0x1854E8050", Slot = "13")]
	public COEGLBKNHNL HLENLHEFFLE(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x54E7F30", Offset = "0x54E6F30", VA = "0x1854E7F30")]
	public BJEGJOOAAHN HLAKIFBKGOD(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x54E85F0", Offset = "0x54E75F0", VA = "0x1854E85F0")]
	public AEHNOIOGGNB PFOFCHGKLBD(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x54E81E0", Offset = "0x54E71E0", VA = "0x1854E81E0")]
	public FAMFIMIKKAN JOJCEHJOGPP(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x54E7B70", Offset = "0x54E6B70", VA = "0x1854E7B70")]
	public DPAGPKHBGMK DBPGDMNKLJL(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x54E79F0", Offset = "0x54E69F0", VA = "0x1854E79F0")]
	public MNOPDMEBLBE KCDDEIIAPGE(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x54E7AC0", Offset = "0x54E6AC0", VA = "0x1854E7AC0", Slot = "19")]
	public PEMJBFLGGMM BBMPNOCKHLJ(RigidbodyEx LKMGIJIPLIN, IKIHJJFFHFA FNIHENPLJHK, OOMBAIEJEBP CBBILOOJOAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public LGFBDCBNIPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x54E7F30", Offset = "0x54E6F30", VA = "0x1854E7F30", Slot = "14")]
	private BJEGJOOAAHN NGEGFJLNLMF(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x54E85F0", Offset = "0x54E75F0", VA = "0x1854E85F0", Slot = "15")]
	private AEHNOIOGGNB NKLPIGOJNFO(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x54E81E0", Offset = "0x54E71E0", VA = "0x1854E81E0", Slot = "16")]
	private FAMFIMIKKAN JEMOMHAJBJM(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x54E7B70", Offset = "0x54E6B70", VA = "0x1854E7B70", Slot = "17")]
	private DPAGPKHBGMK INHHAPJMGIP(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x54E79F0", Offset = "0x54E69F0", VA = "0x1854E79F0", Slot = "18")]
	private MNOPDMEBLBE AHFFIDEIBJD(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[Preserve]
	internal class _RRAssemblyIndex : PLIGCBHMDFD
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B40", Offset = "0x6DFB40", VA = "0x1806E0B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x661E610", Offset = "0x661D610", VA = "0x18661E610", Slot = "6")]
		public sealed override void LDHMAOMPMOJ(JNCGCMMLAKP PEPHBHFBJFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x661E580", Offset = "0x661D580", VA = "0x18661E580", Slot = "4")]
		public sealed override void DOIEPELEGLE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class HFBMMEPCDLM
{
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static byte[] JNCOHDGFJLD;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static int DPLNOEOFOIM;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static int ICHAIMIBEGB;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static BigInteger GDFBBFKEIIP;

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x54D9F40", Offset = "0x54D8F40", VA = "0x1854D9F40")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x54DA050", Offset = "0x54D9050", VA = "0x1854DA050")]
	public static string PKAAKGDAGEE(byte[] FHNEBAPANCE, bool MGDFGAKHOKG)
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
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
