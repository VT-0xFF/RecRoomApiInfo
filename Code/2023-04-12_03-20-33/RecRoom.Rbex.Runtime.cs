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
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0040", Offset = "0x6DF440", VA = "0x1806E0040", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F6790", Offset = "0x6F5B90", VA = "0x1806F6790", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E7170", Offset = "0x6E6570", VA = "0x1806E7170", Slot = "6")]
	public GMJLIEJPOEJ PHAEAJEKMNM(float NGOKMEGFDGA)
	{
		return default(GMJLIEJPOEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "7")]
	public void GBJBCHALJOG(NFBHMIKCNHJ AELIHOPICED, float ANAMGBGEMJA, LCKOHGIHFDM OFGFMHCEFLE = LCKOHGIHFDM.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "8")]
	public void GBJBCHALJOG(NFBHMIKCNHJ AELIHOPICED, Transform ODGIIEPIGAJ, float ANAMGBGEMJA, LCKOHGIHFDM OFGFMHCEFLE = LCKOHGIHFDM.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "9")]
	public void HPKOMPPMIMN(NFBHMIKCNHJ AELIHOPICED, [Optional] float? ANAMGBGEMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "10")]
	public void PMMODKPOELK(NFBHMIKCNHJ JCHEIJOMOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6E7170", Offset = "0x6E6570", VA = "0x1806E7170", Slot = "11")]
	public GMJLIEJPOEJ MJPFNFLEHLA(NFBHMIKCNHJ AELIHOPICED)
	{
		return default(GMJLIEJPOEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x701020", Offset = "0x700420", VA = "0x180701020", Slot = "12")]
	public bool HOOAGMBBGPL(NFBHMIKCNHJ AELIHOPICED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "13")]
	public void BJBIJOPKCKP(NFBHMIKCNHJ AELIHOPICED, LCKOHGIHFDM MLADFEEADKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E4250", Offset = "0x6E3650", VA = "0x1806E4250", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
	public void DKHDOIMNAHA(string CNMFEBEOFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "6")]
	public void CPPGLFMFABI(RigidbodyEx LKMGIJIPLIN, Action FFBLFKDINEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E7170", Offset = "0x6E6570", VA = "0x1806E7170", Slot = "7")]
	public OOGGPHHIOEI OBBKIDKKMBA(int MGDHNMJCIFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "8")]
	public void PHPLIKONAJP(Vector3 KJOMJOHPAIM, float KHOELGGJGBI, Color LDFNLMPJEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6695A50", Offset = "0x6694E50", VA = "0x186695A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<RigidbodyEx> BIMGCBEFPGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6F6770", Offset = "0x6F5B70", VA = "0x1806F6770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x781AD0", Offset = "0x780ED0", VA = "0x180781AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx HJFIOMOEOKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6697B40", Offset = "0x6696F40", VA = "0x186697B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx IMFMPPONFAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6697AE0", Offset = "0x6696EE0", VA = "0x186697AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public RigidbodyEx OKMBLMILFGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x66986A0", Offset = "0x6697AA0", VA = "0x1866986A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6699DF0", Offset = "0x66991F0", VA = "0x186699DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform AAMHCPKDGML
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1825CF0", Offset = "0x18250F0", VA = "0x181825CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform GFCCGCABKON
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1825CF0", Offset = "0x18250F0", VA = "0x181825CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public LCKOHGIHFDM JLBHGNPAHLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x66977D0", Offset = "0x6696BD0", VA = "0x1866977D0")]
			get
			{
				return default(LCKOHGIHFDM);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6699390", Offset = "0x6698790", VA = "0x186699390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool DHECOBNPECP
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6697D50", Offset = "0x6697150", VA = "0x186697D50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool PGDDLMMJJIL
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6697960", Offset = "0x6696D60", VA = "0x186697960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public CCEJFGGKGLM CPIHALLPKPB
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6697CF0", Offset = "0x66970F0", VA = "0x186697CF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x66995A0", Offset = "0x66989A0", VA = "0x1866995A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GGBMPGNAFJD OPABPNIHPDI
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6697C90", Offset = "0x6697090", VA = "0x186697C90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6699530", Offset = "0x6698930", VA = "0x186699530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool ACGMNKMENFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6697B70", Offset = "0x6696F70", VA = "0x186697B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Rigidbody OCHJHJGKDEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6697BD0", Offset = "0x6696FD0", VA = "0x186697BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool ELDBHBFKIGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6697A20", Offset = "0x6696E20", VA = "0x186697A20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6699450", Offset = "0x6698850", VA = "0x186699450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool MPAFDMHBAIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3B889E0", Offset = "0x3B87DE0", VA = "0x183B889E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3B889B0", Offset = "0x3B87DB0", VA = "0x183B889B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float ICHMOGPIDMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6698640", Offset = "0x6697A40", VA = "0x186698640")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float ADJBEFMGEJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x66985E0", Offset = "0x66979E0", VA = "0x1866985E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6699D80", Offset = "0x6699180", VA = "0x186699D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float FAFJFMCOIOO
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6697FB0", Offset = "0x66973B0", VA = "0x186697FB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6699840", Offset = "0x6698C40", VA = "0x186699840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float PNHAJHONKIF
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6697DB0", Offset = "0x66971B0", VA = "0x186697DB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6699610", Offset = "0x6698A10", VA = "0x186699610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool BMOGOGGFIGA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6698BC0", Offset = "0x6697FC0", VA = "0x186698BC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x669A330", Offset = "0x6699730", VA = "0x18669A330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 MKPLIDDMPHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x66983C0", Offset = "0x66977C0", VA = "0x1866983C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6699B50", Offset = "0x6698F50", VA = "0x186699B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 KJOMJOHPAIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6698D00", Offset = "0x6698100", VA = "0x186698D00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CollisionDetectionMode KBIGAPDAFHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6697EF0", Offset = "0x66972F0", VA = "0x186697EF0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6699760", Offset = "0x6698B60", VA = "0x186699760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float FCAAJGFAJEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6697A80", Offset = "0x6696E80", VA = "0x186697A80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x66994C0", Offset = "0x66988C0", VA = "0x1866994C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public RigidbodyConstraints CKKHKJALDEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6697F50", Offset = "0x6697350", VA = "0x186697F50")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x66997D0", Offset = "0x6698BD0", VA = "0x1866997D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 AKKIDKDDCDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6698700", Offset = "0x6697B00", VA = "0x186698700")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 KNFOOAPBKFA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6698700", Offset = "0x6697B00", VA = "0x186698700")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x669A100", Offset = "0x6699500", VA = "0x18669A100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float JGMCCEBCOIP
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x66984A0", Offset = "0x66978A0", VA = "0x1866984A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6699C30", Offset = "0x6699030", VA = "0x186699C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float AEIEKJBHCEM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6698B60", Offset = "0x6697F60", VA = "0x186698B60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x669A2C0", Offset = "0x66996C0", VA = "0x18669A2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion NLPAKBHPNJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x66987E0", Offset = "0x6697BE0", VA = "0x1866987E0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6699E60", Offset = "0x6699260", VA = "0x186699E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion NLCKBACAMDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6698A80", Offset = "0x6697E80", VA = "0x186698A80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x669A1E0", Offset = "0x66995E0", VA = "0x18669A1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 DNNFLEKACON
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x66988C0", Offset = "0x6697CC0", VA = "0x1866988C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6699F40", Offset = "0x6699340", VA = "0x186699F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Quaternion DOCMMADAPJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x66989A0", Offset = "0x6697DA0", VA = "0x1866989A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x669A020", Offset = "0x6699420", VA = "0x18669A020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 FJHEIJDCBEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6698C20", Offset = "0x6698020", VA = "0x186698C20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x669A3A0", Offset = "0x66997A0", VA = "0x18669A3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 FEAFOIFGCCF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6698500", Offset = "0x6697900", VA = "0x186698500")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6699CA0", Offset = "0x66990A0", VA = "0x186699CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 BAMHFNACLOC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6697E10", Offset = "0x6697210", VA = "0x186697E10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6699680", Offset = "0x6698A80", VA = "0x186699680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 IMCNKNPLDHH
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x66982E0", Offset = "0x66976E0", VA = "0x1866982E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6699A70", Offset = "0x6698E70", VA = "0x186699A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 MIDKEEPKLBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x66981A0", Offset = "0x66975A0", VA = "0x1866981A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6699990", Offset = "0x6698D90", VA = "0x186699990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Quaternion FAGMBLNKBPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x66980C0", Offset = "0x66974C0", VA = "0x1866980C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x66998B0", Offset = "0x6698CB0", VA = "0x1866998B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 NCENLNJDPOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6698EC0", Offset = "0x66982C0", VA = "0x186698EC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 AGCBGLLKCBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6698DE0", Offset = "0x66981E0", VA = "0x186698DE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool BJPNLAHPGHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x6698280", Offset = "0x6697680", VA = "0x186698280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool CEEGNNLCJLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x66979C0", Offset = "0x6696DC0", VA = "0x1866979C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool CPPIJLCAPKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6697900", Offset = "0x6696D00", VA = "0x186697900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool GBCOKGPNABB
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x66978A0", Offset = "0x6696CA0", VA = "0x1866978A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool DCOIJAMPGBE
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6697770", Offset = "0x6696B70", VA = "0x186697770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool EBCDPIHLHKO
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6698010", Offset = "0x6697410", VA = "0x186698010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool LCLDHDEMAPD
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7785A0", Offset = "0x7779A0", VA = "0x1807785A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event ONKEIMPDALF JBPALIFIJAG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6697690", Offset = "0x6696A90", VA = "0x186697690")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x66992B0", Offset = "0x66986B0", VA = "0x1866992B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event BAPGIHMPHAC MNLCKCJOLFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6697620", Offset = "0x6696A20", VA = "0x186697620")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6699240", Offset = "0x6698640", VA = "0x186699240")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ONKEIMPDALF FGKDCAIOBOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6697380", Offset = "0x6696780", VA = "0x186697380")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6698FA0", Offset = "0x66983A0", VA = "0x186698FA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event ONKEIMPDALF BJBFJNEGDJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x66973F0", Offset = "0x66967F0", VA = "0x1866973F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6699010", Offset = "0x6698410", VA = "0x186699010")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event ONKEIMPDALF BPFDNFOMPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6697540", Offset = "0x6696940", VA = "0x186697540")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6699160", Offset = "0x6698560", VA = "0x186699160")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<GMJLIEJPOEJ, GMJLIEJPOEJ> BKPNGAGNMKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x66974D0", Offset = "0x66968D0", VA = "0x1866974D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x66990F0", Offset = "0x66984F0", VA = "0x1866990F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event ONKEIMPDALF KFBNIOPGCLI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x66975B0", Offset = "0x66969B0", VA = "0x1866975B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x66991D0", Offset = "0x66985D0", VA = "0x1866991D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event ONKEIMPDALF DECLPAEMMEC
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6697700", Offset = "0x6696B00", VA = "0x186697700")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6699320", Offset = "0x6698720", VA = "0x186699320")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event ONKEIMPDALF JFGDBEMBLMM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6697460", Offset = "0x6696860", VA = "0x186697460")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6699080", Offset = "0x6698480", VA = "0x186699080")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6E0530", VA = "0x1806E1130")]
		internal void PLJLOPPFBCG(PEMJBFLGGMM DNGPHMONFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6695CE0", Offset = "0x66950E0", VA = "0x186695CE0")]
		internal void EKOBNKLFDJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x66970D0", Offset = "0x66964D0", VA = "0x1866970D0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody BNJALKGHBFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6695980", Offset = "0x6694D80", VA = "0x186695980")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6695A50", Offset = "0x6694E50", VA = "0x186695A50")]
		private PEMJBFLGGMM CLHJEPJAIDH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x66961B0", Offset = "0x66955B0", VA = "0x1866961B0")]
		private void MGAGAAKAIAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6696610", Offset = "0x6695A10", VA = "0x186696610")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x66965A0", Offset = "0x66959A0", VA = "0x1866965A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6695D70", Offset = "0x6695170", VA = "0x186695D70")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x66965B0", Offset = "0x66959B0", VA = "0x1866965B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6696670", Offset = "0x6695A70", VA = "0x186696670")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6695010", Offset = "0x6694410", VA = "0x186695010")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x66966E0", Offset = "0x6695AE0", VA = "0x1866966E0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6695C80", Offset = "0x6695080", VA = "0x186695C80")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6696540", Offset = "0x6695940", VA = "0x186696540")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6696ED0", Offset = "0x66962D0", VA = "0x186696ED0")]
		public void SetParent(RigidbodyEx KPPLMEOMNGF, bool GMEFKHHIEPP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x66969F0", Offset = "0x6695DF0", VA = "0x1866969F0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6695FD0", Offset = "0x66953D0", VA = "0x186695FD0")]
		public bool IsRigidbodyAncestor(RigidbodyEx BGGGLHDGEEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6696010", Offset = "0x6695410", VA = "0x186696010")]
		public bool IsRigidbodyDescendant(RigidbodyEx IMGNFLHGNFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6695230", Offset = "0x6694630", VA = "0x186695230")]
		public void AddInterpolationRestriction(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6696750", Offset = "0x6695B50", VA = "0x186696750")]
		public void RemoveInterpolationRestriction(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x66959F0", Offset = "0x6694DF0", VA = "0x1866959F0")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x66952A0", Offset = "0x66946A0", VA = "0x1866952A0")]
		public void AddKinematic(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x66967C0", Offset = "0x6695BC0", VA = "0x1866967C0")]
		public void RemoveKinematic(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6696E50", Offset = "0x6696250", VA = "0x186696E50")]
		public void SetKinematic(object JAKCBCDLMLB, bool FANMJAGAPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6696D50", Offset = "0x6696150", VA = "0x186696D50")]
		public void SetDiscontinuousPositionAndRotation(Vector3 IIHKIEHLKJE, Quaternion OKGAEIKHFKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6696C50", Offset = "0x6696050", VA = "0x186696C50")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 JAGOFJILOLJ, Quaternion PAFGOIINECO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6695ED0", Offset = "0x66952D0", VA = "0x186695ED0")]
		public Vector3 GetConstrainedVelocity(Vector3 FJHEIJDCBEJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6695DD0", Offset = "0x66951D0", VA = "0x186695DD0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 BAMHFNACLOC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x66951A0", Offset = "0x66945A0", VA = "0x1866951A0")]
		public void AddForce(Vector3 AKNNPOEHKML, ForceMode KHIFDLIHLBI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6695080", Offset = "0x6694480", VA = "0x186695080")]
		public void AddForceAtPosition(Vector3 AKNNPOEHKML, Vector3 MIFJBHLKJIN, ForceMode KHIFDLIHLBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x66953A0", Offset = "0x66947A0", VA = "0x1866953A0")]
		public void AddTorque(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6695310", Offset = "0x6694710", VA = "0x186695310")]
		public void AddRelativeTorque(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x66971B0", Offset = "0x66965B0", VA = "0x1866971B0")]
		public Vector3 WorldToLocalVelocity(Vector3 HFELIOHGGDO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x66960B0", Offset = "0x66954B0", VA = "0x1866960B0")]
		public Vector3 LocalToWorldVelocity(Vector3 FEAFOIFGCCF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6695C20", Offset = "0x6695020", VA = "0x186695C20")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6695BC0", Offset = "0x6694FC0", VA = "0x186695BC0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6695B60", Offset = "0x6694F60", VA = "0x186695B60")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6695B00", Offset = "0x6694F00", VA = "0x186695B00")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6696B50", Offset = "0x6695F50", VA = "0x186696B50")]
		public void ResetVelocityWorldSpace(Vector3 OLJIPBFJCBL, Vector3 CJANALIFPDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6696A50", Offset = "0x6695E50", VA = "0x186696A50")]
		public void ResetVelocityLocalSpace(Vector3 OABJFLBJEKB, Vector3 IMCNKNPLDHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6696910", Offset = "0x6695D10", VA = "0x186696910")]
		public void ResetLinearVelocityLocalSpace(Vector3 OABJFLBJEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6696FC0", Offset = "0x66963C0", VA = "0x186696FC0")]
		public bool SweepTest(Vector3 JLBPNKFCLFO, out RaycastHit JFEEEDGCAPO, float FNIJMIADAMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6696050", Offset = "0x6695450", VA = "0x186696050")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6696F60", Offset = "0x6696360", VA = "0x186696F60")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6697150", Offset = "0x6696550", VA = "0x186697150")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6695430", Offset = "0x6694830", VA = "0x186695430")]
		public void AddUnityRigidbody(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6696830", Offset = "0x6695C30", VA = "0x186696830")]
		public void RemoveUnityRigidbody(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6695750", Offset = "0x6694B50", VA = "0x186695750")]
		public void ApplyForceVelocityChange(OBJOKHNKAPP CAMLNFGKHFE, Vector3 MAIIDBKHIED, float JOFBEKECLOD, float CLOJEHHLDHC = 8f, float ILPINEMCFMP = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6695650", Offset = "0x6694A50", VA = "0x186695650")]
		public void ApplyAngularVelocityChange(EKKHOJNPNMO PNJHOCPNCML, Vector3 NFNPPPGADBK, float MMIALNFHMCC = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6695870", Offset = "0x6694C70", VA = "0x186695870")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(EKKHOJNPNMO PNJHOCPNCML, Vector3 OLBDAPNGDPL, float CEIPLLMFOOE = 7f, float OGLOAGFEIHM = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6695590", Offset = "0x6694990", VA = "0x186695590")]
		public bool AllowedScaleChange(float DEGNNNFBBGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x66954A0", Offset = "0x66948A0", VA = "0x1866954A0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx HEPODBMIMNP, object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x66968A0", Offset = "0x6695CA0", VA = "0x1866968A0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object JAKCBCDLMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6697300", Offset = "0x6696700", VA = "0x186697300")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class LPPKKOFIIGD
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x558E570", Offset = "0x558D970", VA = "0x18558E570")]
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
			[Cpp2IlInjected.Address(RVA = "0x6694E80", Offset = "0x6694280", VA = "0x186694E80", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public CNGJPACLCIB JBJJKKBFHAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public HMOFCBOHILL CHGCPFMHBIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6694CA0", Offset = "0x66940A0", VA = "0x186694CA0", Slot = "12")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x66949D0", Offset = "0x6693DD0", VA = "0x1866949D0", Slot = "7")]
		public GPEJGMHBDPO IJANLHNKKJL(RigidbodyEx LKMGIJIPLIN)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6694ED0", Offset = "0x66942D0", VA = "0x186694ED0")]
		private static GPEJGMHBDPO MINBBKKJHMB(RigidbodyEx LKMGIJIPLIN)
		{
			return default(GPEJGMHBDPO);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x66947F0", Offset = "0x6693BF0", VA = "0x1866947F0", Slot = "8")]
		public PEMJBFLGGMM BBMPNOCKHLJ(RigidbodyEx LKMGIJIPLIN, IKIHJJFFHFA FNIHENPLJHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6694900", Offset = "0x6693D00", VA = "0x186694900", Slot = "11")]
		private RigidbodyEx CHEAODAHGEC(GameObject LOCIAIPOBLA, IKIHJJFFHFA FNIHENPLJHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6694700", Offset = "0x6693B00", VA = "0x186694700", Slot = "9")]
		public void AIOGKBDENBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6694D30", Offset = "0x6694130", VA = "0x186694D30", Slot = "10")]
		public void KAELCLHILKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x66941E0", Offset = "0x66935E0", VA = "0x1866941E0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6694220", Offset = "0x6693620", VA = "0x186694220")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6694200", Offset = "0x6693600", VA = "0x186694200")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string GOMILMNIGIC, [Optional] UnityEngine.Object MFEOJPNCOBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string GOMILMNIGIC, [Optional] UnityEngine.Object MFEOJPNCOBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6694310", Offset = "0x6693710", VA = "0x186694310")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EEPGLGMEAGO
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5571BC0", Offset = "0x5570FC0", VA = "0x185571BC0")]
	public static void FGMPKNFDGIC(this Rigidbody BNJALKGHBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5571D10", Offset = "0x5571110", VA = "0x185571D10")]
	public static void FGMPKNFDGIC(this Rigidbody BNJALKGHBFN, Vector3 MIDKEEPKLBG, Quaternion FAGMBLNKBPB, Vector3 ADIOMBOKILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5571E20", Offset = "0x5571220", VA = "0x185571E20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1626330", Offset = "0x1625730", VA = "0x181626330", Slot = "4")]
		public Vector3 BOEHIMLHPKM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x1626330", Offset = "0x1625730", VA = "0x181626330", Slot = "5")]
		public Vector3 FDMJOFIOEHO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public LOJGGPIEPOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static CCEJFGGKGLM JAKJBIBHOKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x556A480", Offset = "0x5569880", VA = "0x18556A480")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E6E20", Offset = "0x6E6220", VA = "0x1806E6E20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x85F5D0", Offset = "0x85E9D0", VA = "0x18085F5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GameObject OCGHLHMMGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x71C6A0", Offset = "0x71BAA0", VA = "0x18071C6A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8EA490", Offset = "0x8E9890", VA = "0x1808EA490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Transform AMINHCIEOMN
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x5576200", Offset = "0x5575600", VA = "0x185576200", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEnumerable<object> EPIMPBJGKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x5576A20", Offset = "0x5575E20", VA = "0x185576A20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Rigidbody OCHJHJGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x5577F80", Offset = "0x5577380", VA = "0x185577F80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public PEMJBFLGGMM AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x5578B50", Offset = "0x5577F50", VA = "0x185578B50", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x5578520", Offset = "0x5577920", VA = "0x185578520", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public IReadOnlyList<PEMJBFLGGMM> BIMGCBEFPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5575AF0", Offset = "0x5574EF0", VA = "0x185575AF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public PEMJBFLGGMM IMFMPPONFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5575CB0", Offset = "0x55750B0", VA = "0x185575CB0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool OCODEBHAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x55792E0", Offset = "0x55786E0", VA = "0x1855792E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool DHECOBNPECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5578B00", Offset = "0x5577F00", VA = "0x185578B00", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool PGDDLMMJJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x5577AD0", Offset = "0x5576ED0", VA = "0x185577AD0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public CCEJFGGKGLM CPIHALLPKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x55774A0", Offset = "0x55768A0", VA = "0x1855774A0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x5578400", Offset = "0x5577800", VA = "0x185578400", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public GGBMPGNAFJD OPABPNIHPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x5578200", Offset = "0x5577600", VA = "0x185578200", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x5577FD0", Offset = "0x55773D0", VA = "0x185577FD0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public float FCAAJGFAJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x5574D00", Offset = "0x5574100", VA = "0x185574D00", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5579CE0", Offset = "0x55790E0", VA = "0x185579CE0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 AHAJMJBMMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5576760", Offset = "0x5575B60", VA = "0x185576760", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x557A0F0", Offset = "0x55794F0", VA = "0x18557A0F0", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 HBNCABOKHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5579E00", Offset = "0x5579200", VA = "0x185579E00", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x55778F0", Offset = "0x5576CF0", VA = "0x1855778F0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 LCNCCKHCPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x55748F0", Offset = "0x5573CF0", VA = "0x1855748F0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5577D10", Offset = "0x5577110", VA = "0x185577D10", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 JLGHJOIMMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5575060", Offset = "0x5574460", VA = "0x185575060", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x55797A0", Offset = "0x5578BA0", VA = "0x1855797A0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool CPPIJLCAPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x55795A0", Offset = "0x55789A0", VA = "0x1855795A0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool GBCOKGPNABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5577B70", Offset = "0x5576F70", VA = "0x185577B70", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool DCOIJAMPGBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5579870", Offset = "0x5578C70", VA = "0x185579870", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool ACGMNKMENFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x5575C60", Offset = "0x5575060", VA = "0x185575C60", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Vector3 PPABHMBOJDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x5579340", Offset = "0x5578740", VA = "0x185579340", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 DIKOGGMMGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x5576950", Offset = "0x5575D50", VA = "0x185576950", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Vector3 KDBEDBCAALJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x5574C30", Offset = "0x5574030", VA = "0x185574C30", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x5575F90", Offset = "0x5575390", VA = "0x185575F90", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 CIMPCCAAMLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x5577820", Offset = "0x5576C20", VA = "0x185577820", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float JCADBDOALOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x5578350", Offset = "0x5577750", VA = "0x185578350", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float JPJAIDEFGCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x55763A0", Offset = "0x55757A0", VA = "0x1855763A0", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x5574A10", Offset = "0x5573E10", VA = "0x185574A10", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Vector3 OFHAOOPEAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5578760", Offset = "0x5577B60", VA = "0x185578760", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x55771A0", Offset = "0x55765A0", VA = "0x1855771A0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion OIBJJPCINPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x55780E0", Offset = "0x55774E0", VA = "0x1855780E0", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5576F20", Offset = "0x5576320", VA = "0x185576F20", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float CMNCFAMIFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5577A80", Offset = "0x5576E80", VA = "0x185577A80", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x55744E0", Offset = "0x55738E0", VA = "0x1855744E0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public float GLPBFLLCCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5574F60", Offset = "0x5574360", VA = "0x185574F60", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x55784C0", Offset = "0x55778C0", VA = "0x1855784C0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool IKHDPECJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x5578F30", Offset = "0x5578330", VA = "0x185578F30", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x5576830", Offset = "0x5575C30", VA = "0x185576830", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CLIIJKDLFPK JLBHGNPAHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x5579230", Offset = "0x5578630", VA = "0x185579230", Slot = "52")]
		get
		{
			return default(CLIIJKDLFPK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x55779C0", Offset = "0x5576DC0", VA = "0x1855779C0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool HIDLJAAELFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x557A0A0", Offset = "0x55794A0", VA = "0x18557A0A0", Slot = "54")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Transform AAMHCPKDGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x5575B40", Offset = "0x5574F40", VA = "0x185575B40", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public Transform GFCCGCABKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x5575B40", Offset = "0x5574F40", VA = "0x185575B40", Slot = "56")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Vector3 HFOAEBOMNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x5577ED0", Offset = "0x55772D0", VA = "0x185577ED0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x55796F0", Offset = "0x5578AF0", VA = "0x1855796F0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public float FKAPONKEAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x5577370", Offset = "0x5576770", VA = "0x185577370", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x55795F0", Offset = "0x55789F0", VA = "0x1855795F0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public float FOMCKPAPOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x5575A40", Offset = "0x5574E40", VA = "0x185575A40", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x5576FF0", Offset = "0x55763F0", VA = "0x185576FF0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Quaternion CBCKCFLIFDK
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5575D00", Offset = "0x5575100", VA = "0x185575D00", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x55782C0", Offset = "0x55776C0", VA = "0x1855782C0", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 INAHNKFEMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x5577B20", Offset = "0x5576F20", VA = "0x185577B20", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5577700", Offset = "0x5576B00", VA = "0x185577700", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Quaternion PHAFEIAABKC
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x5574D50", Offset = "0x5574150", VA = "0x185574D50", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5575DB0", Offset = "0x55751B0", VA = "0x185575DB0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public RigidbodyConstraints HLIGOHOAJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x55781B0", Offset = "0x55775B0", VA = "0x1855781B0", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5579280", Offset = "0x5578680", VA = "0x185579280", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool ELDBHBFKIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5579550", Offset = "0x5578950", VA = "0x185579550", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x55790A0", Offset = "0x55784A0", VA = "0x1855790A0", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CollisionDetectionMode IBLNPOEEODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x557A220", Offset = "0x5579620", VA = "0x18557A220", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x5579C80", Offset = "0x5579080", VA = "0x185579C80", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool CEEGNNLCJLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x5579410", Offset = "0x5578810", VA = "0x185579410", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event ONKEIMPDALF FGKDCAIOBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x55783A0", Offset = "0x55777A0", VA = "0x1855783A0", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x5575230", Offset = "0x5574630", VA = "0x185575230", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event ONKEIMPDALF BJBFJNEGDJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5579D40", Offset = "0x5579140", VA = "0x185579D40", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x5576340", Offset = "0x5575740", VA = "0x185576340", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event BAPGIHMPHAC JDHPMFPKGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x5577310", Offset = "0x5576710", VA = "0x185577310", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x5578E70", Offset = "0x5578270", VA = "0x185578E70", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event ONKEIMPDALF BLJCHPILBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x5574BD0", Offset = "0x5573FD0", VA = "0x185574BD0", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x5579C20", Offset = "0x5579020", VA = "0x185579C20", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event ONKEIMPDALF BPFDNFOMPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x5578030", Offset = "0x5577430", VA = "0x185578030", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x5574F00", Offset = "0x5574300", VA = "0x185574F00", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event ONKEIMPDALF HOLNOCHIGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5576120", Offset = "0x5575520", VA = "0x185576120", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5578ED0", Offset = "0x55782D0", VA = "0x185578ED0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<GMJLIEJPOEJ, GMJLIEJPOEJ> BKPNGAGNMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x557A1C0", Offset = "0x55795C0", VA = "0x18557A1C0", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x5574A70", Offset = "0x5573E70", VA = "0x185574A70", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event ONKEIMPDALF PEJBAIOJGEE
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x5576060", Offset = "0x5575460", VA = "0x185576060", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x55791D0", Offset = "0x55785D0", VA = "0x1855791D0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event ONKEIMPDALF JFGDBEMBLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x55768B0", Offset = "0x5575CB0", VA = "0x1855768B0", Slot = "125")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5574640", Offset = "0x5573A40", VA = "0x185574640", Slot = "126")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x557A2B0", Offset = "0x55796B0", VA = "0x18557A2B0")]
	public GAFHNPMJPMB(GameObject BLPBCMIHDMD, RigidbodyEx JKNMFOBKPNO, OOMBAIEJEBP CBBILOOJOAK, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5575560", Offset = "0x5574960", VA = "0x185575560", Slot = "142")]
	protected virtual void CICIFIGLLJJ(OOMBAIEJEBP CBBILOOJOAK, IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5575EC0", Offset = "0x55752C0", VA = "0x185575EC0", Slot = "143")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5577BD0", Offset = "0x5576FD0", VA = "0x185577BD0", Slot = "76")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x5577750", Offset = "0x5576B50", VA = "0x185577750", Slot = "77")]
	public void HDKFJIKLEJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x5576890", Offset = "0x5575C90", VA = "0x185576890", Slot = "78")]
	public void EPMHDFKPLEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x5576290", Offset = "0x5575690", VA = "0x185576290", Slot = "144")]
	public virtual void EJBOICBIHAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5578250", Offset = "0x5577650", VA = "0x185578250", Slot = "87")]
	public void JDHACNMMLIE(PEMJBFLGGMM KPPLMEOMNGF, bool GMEFKHHIEPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5574AD0", Offset = "0x5573ED0", VA = "0x185574AD0", Slot = "90")]
	public void BFMOPJLHBBG(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5578830", Offset = "0x5577C30", VA = "0x185578830", Slot = "91")]
	public void LHGJEIODGLO(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x5574280", Offset = "0x5573680", VA = "0x185574280", Slot = "92")]
	public Vector3 ABHOGLBBGMA(Vector3 HFELIOHGGDO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x55774F0", Offset = "0x55768F0", VA = "0x1855774F0", Slot = "93")]
	public Vector3 GNEKHGHFGKA(Vector3 FEAFOIFGCCF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x5577750", Offset = "0x5576B50", VA = "0x185577750", Slot = "94")]
	public void IIPKPIBFBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x5577270", Offset = "0x5576670", VA = "0x185577270", Slot = "95")]
	public void GJGKIDGKPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x5575AA0", Offset = "0x5574EA0", VA = "0x185575AA0", Slot = "96")]
	public void CMHHFMOHFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x5575950", Offset = "0x5574D50", VA = "0x185575950", Slot = "97")]
	public void CJHODKMAJBE(Vector3 OLJIPBFJCBL, Vector3 CJANALIFPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x5578890", Offset = "0x5577C90", VA = "0x185578890", Slot = "98")]
	public void LICDBAEOAFD(Vector3 OABJFLBJEKB, Vector3 IMCNKNPLDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x55773D0", Offset = "0x55767D0", VA = "0x1855773D0", Slot = "99")]
	public void GMEDHCFFMEH(Vector3 ANJGHBFDIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5575290", Offset = "0x5574690", VA = "0x185575290", Slot = "100")]
	public void CBOAGHDBPJH(OBJOKHNKAPP CAMLNFGKHFE, Vector3 MAIIDBKHIED, float JOFBEKECLOD, float CLOJEHHLDHC = 8f, float ILPINEMCFMP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x5574540", Offset = "0x5573940", VA = "0x185574540", Slot = "101")]
	public void AFOBMMCCHIM(EKKHOJNPNMO PNJHOCPNCML, Vector3 NFNPPPGADBK, float MMIALNFHMCC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x5574D90", Offset = "0x5574190", VA = "0x185574D90", Slot = "102")]
	[Obsolete]
	public void BMPJNHFGFFL(EKKHOJNPNMO PNJHOCPNCML, Vector3 OLBDAPNGDPL, float CEIPLLMFOOE = 7f, float OGLOAGFEIHM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x5577DE0", Offset = "0x55771E0", VA = "0x185577DE0", Slot = "103")]
	public Vector3 IDKDPPMOKNN(Vector3 KPPLMEOMNGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5579950", Offset = "0x5578D50", VA = "0x185579950", Slot = "104")]
	public Vector3 NOILBEMLPLM(Vector3 KPPLMEOMNGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x5578F80", Offset = "0x5578380", VA = "0x185578F80", Slot = "105")]
	public void MDDKFEEINFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x5578FD0", Offset = "0x55783D0", VA = "0x185578FD0", Slot = "106")]
	public void MEJBHJGELMJ(PEMJBFLGGMM HEPODBMIMNP, object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x5576E70", Offset = "0x5576270", VA = "0x185576E70", Slot = "107")]
	public void GAIBLGGKAKK(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x5576ED0", Offset = "0x55762D0", VA = "0x185576ED0", Slot = "110")]
	public void GCHILAJIGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x5579ED0", Offset = "0x55792D0", VA = "0x185579ED0", Slot = "111")]
	public void OPJNHLCKFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x5576710", Offset = "0x5575B10", VA = "0x185576710", Slot = "112")]
	public void ENHMBOFJGPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x55776B0", Offset = "0x5576AB0", VA = "0x1855776B0", Slot = "115")]
	public bool GOBGGIIBKON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x55749C0", Offset = "0x5573DC0", VA = "0x1855749C0", Slot = "79")]
	public void AMHGNHLMFNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x55772C0", Offset = "0x55766C0", VA = "0x1855772C0", Slot = "116")]
	public void GKCJECCPPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5578090", Offset = "0x5577490", VA = "0x185578090", Slot = "121")]
	public IDisposable ILBPDKJDBCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x5579DA0", Offset = "0x55791A0", VA = "0x185579DA0", Slot = "122")]
	public void OJMDMCDKKPE(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x5576A70", Offset = "0x5575E70", VA = "0x185576A70", Slot = "123")]
	public void FHDCOJAJODE(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x55785E0", Offset = "0x55779E0", VA = "0x1855785E0", Slot = "124")]
	public void LAOHBPMFIPD(object JAKCBCDLMLB, bool FANMJAGAPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x55746E0", Offset = "0x5573AE0", VA = "0x1855746E0", Slot = "127")]
	public void AGNLAHKGJCD(Vector3 IIHKIEHLKJE, Quaternion OKGAEIKHFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x55753B0", Offset = "0x55747B0", VA = "0x1855753B0", Slot = "128")]
	public void CGBDHLAKFPB(Vector3 JAGOFJILOLJ, Quaternion PAFGOIINECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5574B30", Offset = "0x5573F30", VA = "0x185574B30", Slot = "129")]
	public bool BGJIPHJJDJL(float DEGNNNFBBGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x5578460", Offset = "0x5577860", VA = "0x185578460", Slot = "130")]
	public void KGPNCHMMJJG(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x55760C0", Offset = "0x55754C0", VA = "0x1855760C0", Slot = "131")]
	public void EFNCJDLHIIK(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5574EA0", Offset = "0x55742A0", VA = "0x185574EA0", Slot = "132")]
	public void BNFFEJKELLJ(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x5578580", Offset = "0x5577980", VA = "0x185578580", Slot = "133")]
	public void LAIPLJBIIOF(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5578980", Offset = "0x5577D80", VA = "0x185578980", Slot = "134")]
	public void LKANBCJLPMP(Vector3 AKNNPOEHKML, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5578650", Offset = "0x5577A50", VA = "0x185578650", Slot = "135")]
	public void LBNEOPMLINP(Vector3 AKNNPOEHKML, Vector3 MIFJBHLKJIN, ForceMode KHIFDLIHLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x55777A0", Offset = "0x5576BA0", VA = "0x1855777A0", Slot = "136")]
	public void HKPKKNJICLF(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5576180", Offset = "0x5575580", VA = "0x185576180", Slot = "137")]
	public void EIKMOLMEFMN(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5575130", Offset = "0x5574530", VA = "0x185575130", Slot = "138")]
	public bool CBCMNPEEDCJ(Vector3 JLBPNKFCLFO, out RaycastHit JFEEEDGCAPO, float FNIJMIADAMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x557A050", Offset = "0x5579450", VA = "0x18557A050", Slot = "139")]
	public void PFHHLHIKMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x557A270", Offset = "0x5579670", VA = "0x18557A270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x5579100", Offset = "0x5578500", VA = "0x185579100")]
	private void MIEEMNLFCOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x5575840", Offset = "0x5574C40", VA = "0x185575840")]
	private void CJFENHGIGEE(PEMJBFLGGMM OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x5579A40", Offset = "0x5578E40", VA = "0x185579A40")]
	private void OBDHJANEMGD(PEMJBFLGGMM OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x5574FB0", Offset = "0x55743B0", VA = "0x185574FB0")]
	private void BOJMJLJHIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x5578A00", Offset = "0x5577E00", VA = "0x185578A00")]
	private void LKKBJCHBCOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5575B50", Offset = "0x5574F50", VA = "0x185575B50")]
	private void DHFHNNOJGHO(PEMJBFLGGMM OBCJBMNJCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x55775E0", Offset = "0x55769E0", VA = "0x1855775E0")]
	private void GOBBLIKIBOC(PEMJBFLGGMM OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x5575DF0", Offset = "0x55751F0", VA = "0x185575DF0")]
	private void DODGKOMIJNM(PEMJBFLGGMM OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x5574370", Offset = "0x5573770", VA = "0x185574370")]
	private void ADCNGJHKDKB(RigidbodyEx OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x5576AD0", Offset = "0x5575ED0", VA = "0x185576AD0")]
	private void FLKADGMOHML(RigidbodyEx LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5579F20", Offset = "0x5579320", VA = "0x185579F20")]
	[Conditional("UNITY_EDITOR")]
	private void PCCIINJJIFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5578BA0", Offset = "0x5577FA0", VA = "0x185578BA0")]
	protected void LPCKBJAIACO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x55763F0", Offset = "0x55757F0", VA = "0x1855763F0")]
	protected void EMCHHAJEOKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class DEADILLHEJA
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x556AE40", Offset = "0x556A240", VA = "0x18556AE40")]
	public static PEMJBFLGGMM BDOILDEPFKL(this PEMJBFLGGMM LKMGIJIPLIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x556AFC0", Offset = "0x556A3C0", VA = "0x18556AFC0")]
	public static bool IHGDEOBMJOA(this PEMJBFLGGMM LKMGIJIPLIN, PEMJBFLGGMM BGGGLHDGEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x556B040", Offset = "0x556A440", VA = "0x18556B040")]
	public static bool PFFODPCMNAO(this PEMJBFLGGMM LKMGIJIPLIN, PEMJBFLGGMM IMGNFLHGNFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x556AF70", Offset = "0x556A370", VA = "0x18556AF70")]
	public static RigidbodyEx BHNPGPJFIDL(this PEMJBFLGGMM IPKNMKDFBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x556AF00", Offset = "0x556A300", VA = "0x18556AF00")]
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
	[Cpp2IlInjected.Address(RVA = "0x558E650", Offset = "0x558DA50", VA = "0x18558E650")]
	public MAEAADDDLBO(GAFHNPMJPMB ANOKHAKIKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x558E5F0", Offset = "0x558D9F0", VA = "0x18558E5F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5582820", Offset = "0x5581C20", VA = "0x185582820")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x5582900", Offset = "0x5581D00", VA = "0x185582900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody OCHJHJGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x55678D0", Offset = "0x5566CD0", VA = "0x1855678D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CollisionDetectionMode IBLNPOEEODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5582BF0", Offset = "0x5581FF0", VA = "0x185582BF0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x55827A0", Offset = "0x5581BA0", VA = "0x1855827A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5567360", Offset = "0x5566760", VA = "0x185567360")]
	public JFFOGCKBJCO(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5582600", Offset = "0x5581A00", VA = "0x185582600", Slot = "6")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x5582710", Offset = "0x5581B10", VA = "0x185582710", Slot = "9")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x55825E0", Offset = "0x55819E0", VA = "0x1855825E0", Slot = "7")]
	public void CKELEIJDMGC(bool BJPNLAHPGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x55825F0", Offset = "0x55819F0", VA = "0x1855825F0", Slot = "8")]
	public void FAAPOKHEFAE(bool BJPNLAHPGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x5582470", Offset = "0x5581870", VA = "0x185582470", Slot = "10")]
	public bool CBCMNPEEDCJ(Vector3 JLBPNKFCLFO, out RaycastHit JFEEEDGCAPO, float FNIJMIADAMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x55829F0", Offset = "0x5581DF0", VA = "0x1855829F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x556A950", Offset = "0x5569D50", VA = "0x18556A950")]
		get
		{
			return default(CLIIJKDLFPK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x556AA30", Offset = "0x5569E30", VA = "0x18556AA30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public CLIIJKDLFPK JLBHGNPAHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x556AB20", Offset = "0x5569F20", VA = "0x18556AB20", Slot = "6")]
		get
		{
			return default(CLIIJKDLFPK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x556AA30", Offset = "0x5569E30", VA = "0x18556AA30", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private Transform MPACEKJKBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6E7170", Offset = "0x6E6570", VA = "0x1806E7170", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<GMJLIEJPOEJ, GMJLIEJPOEJ> BKPNGAGNMKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x556ADA0", Offset = "0x556A1A0", VA = "0x18556ADA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x556A8B0", Offset = "0x5569CB0", VA = "0x18556A8B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5567360", Offset = "0x5566760", VA = "0x185567360")]
	public DAFGJOBLEJI(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x556AD40", Offset = "0x556A140", VA = "0x18556AD40", Slot = "11")]
	public void OnChangedDistanceBand(GMJLIEJPOEJ ENFEPLFMJNK, GMJLIEJPOEJ IEFBANIHOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "12")]
	public void OnChangedVisibility(bool DPOEBCKBBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "8")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x55678D0", Offset = "0x5566CD0", VA = "0x1855678D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool HIDLJAAELFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x557E110", Offset = "0x557D510", VA = "0x18557E110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private bool OCODEBHAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x5568C20", Offset = "0x5568020", VA = "0x185568C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private PEMJBFLGGMM AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x557DE30", Offset = "0x557D230", VA = "0x18557DE30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5567360", Offset = "0x5566760", VA = "0x185567360")]
	public HEILDAJBMLO(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x557DCD0", Offset = "0x557D0D0", VA = "0x18557DCD0", Slot = "4")]
	public void LKANBCJLPMP(Vector3 AKNNPOEHKML, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x557D3D0", Offset = "0x557C7D0", VA = "0x18557D3D0")]
	private void APHEOOMGEAE(Vector3 AKNNPOEHKML, ForceMode KHIFDLIHLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x557DA30", Offset = "0x557CE30", VA = "0x18557DA30", Slot = "5")]
	public void LBNEOPMLINP(Vector3 AKNNPOEHKML, Vector3 MIFJBHLKJIN, ForceMode KHIFDLIHLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x557D8D0", Offset = "0x557CCD0", VA = "0x18557D8D0", Slot = "6")]
	public void HKPKKNJICLF(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x557DE90", Offset = "0x557D290", VA = "0x18557DE90")]
	private void PDBJHNFEIFK(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x557D650", Offset = "0x557CA50", VA = "0x18557D650", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x557D1F0", Offset = "0x557C5F0", VA = "0x18557D1F0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x557D010", Offset = "0x557C410", VA = "0x18557D010", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x5567360", Offset = "0x5566760", VA = "0x185567360")]
	public HBINDKBJBKF(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x557D2D0", Offset = "0x557C6D0", VA = "0x18557D2D0", Slot = "6")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x557CFA0", Offset = "0x557C3A0", VA = "0x18557CFA0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x5580650", Offset = "0x557FA50", VA = "0x185580650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public GPEJGMHBDPO DAFDAGLIEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x55804B0", Offset = "0x557F8B0", VA = "0x1855804B0")]
		get
		{
			return default(GPEJGMHBDPO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x5580C70", Offset = "0x5580070", VA = "0x185580C70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public PEMJBFLGGMM AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x5581660", Offset = "0x5580A60", VA = "0x185581660", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x5581200", Offset = "0x5580600", VA = "0x185581200", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public GPEJGMHBDPO EAONMAIKBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x55801E0", Offset = "0x557F5E0", VA = "0x1855801E0")]
		get
		{
			return default(GPEJGMHBDPO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x5581270", Offset = "0x5580670", VA = "0x185581270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public PEMJBFLGGMM IMFMPPONFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x5580100", Offset = "0x557F500", VA = "0x185580100", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyList<PEMJBFLGGMM> BIMGCBEFPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6F6770", Offset = "0x6F5B70", VA = "0x1806F6770", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event ONKEIMPDALF FGKDCAIOBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x5581160", Offset = "0x5580560", VA = "0x185581160", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x557FEB0", Offset = "0x557F2B0", VA = "0x18557FEB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event ONKEIMPDALF BJBFJNEGDJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x5581920", Offset = "0x5580D20", VA = "0x185581920", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x5580680", Offset = "0x557FA80", VA = "0x185580680", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event BAPGIHMPHAC JDHPMFPKGAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x5580B30", Offset = "0x557FF30", VA = "0x185580B30", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x55816A0", Offset = "0x5580AA0", VA = "0x1855816A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action CLLCEGLBDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x5580140", Offset = "0x557F540", VA = "0x185580140", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x55807C0", Offset = "0x557FBC0", VA = "0x1855807C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action LHGLPPNOMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x55819C0", Offset = "0x5580DC0", VA = "0x1855819C0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x5581880", Offset = "0x5580C80", VA = "0x185581880", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<PEMJBFLGGMM> NEGJPDDONIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x5581740", Offset = "0x5580B40", VA = "0x185581740", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x5580D70", Offset = "0x5580170", VA = "0x185580D70", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<PEMJBFLGGMM> MKOODLOMFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x5580BD0", Offset = "0x557FFD0", VA = "0x185580BD0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5580720", Offset = "0x557FB20", VA = "0x185580720", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action JHGAJELOKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x55817E0", Offset = "0x5580BE0", VA = "0x1855817E0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x5580F00", Offset = "0x5580300", VA = "0x185580F00", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<PEMJBFLGGMM> LEMANBDPLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x55805B0", Offset = "0x557F9B0", VA = "0x1855805B0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x5580860", Offset = "0x557FC60", VA = "0x185580860", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5581A60", Offset = "0x5580E60", VA = "0x185581A60")]
	public ICKLKDNAEJE(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x55802E0", Offset = "0x557F6E0", VA = "0x1855802E0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5580E80", Offset = "0x5580280", VA = "0x185580E80", Slot = "26")]
	public void JDHACNMMLIE(PEMJBFLGGMM KHLHKJKADHO, bool GMEFKHHIEPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5580E10", Offset = "0x5580210", VA = "0x185580E10")]
	private void JDHACNMMLIE(IMFFNFBANME KHLHKJKADHO, bool GMEFKHHIEPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x557F580", Offset = "0x557E980", VA = "0x18557F580")]
	private void ANMOFPKAJBO(IMFFNFBANME KHLHKJKADHO, bool GMEFKHHIEPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5580FA0", Offset = "0x55803A0", VA = "0x185580FA0")]
	private void JJJDGCHINFP(IMFFNFBANME OBCJBMNJCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x55814A0", Offset = "0x55808A0", VA = "0x1855814A0")]
	private void LLKFKAGPDOF(IMFFNFBANME OBCJBMNJCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x557F3E0", Offset = "0x557E7E0", VA = "0x18557F3E0")]
	private void ACMEOJCFDDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x557FF50", Offset = "0x557F350", VA = "0x18557FF50")]
	private void CEJMMPCINJH(IMFFNFBANME OBCJBMNJCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x557FE00", Offset = "0x557F200", VA = "0x18557FE00")]
	private void BGGDFBNJICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x557FFD0", Offset = "0x557F3D0", VA = "0x18557FFD0")]
	private void COBJFADANHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5580A00", Offset = "0x557FE00", VA = "0x185580A00")]
	private void GFLPJLNLLDG(IMFFNFBANME LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x5581370", Offset = "0x5580770", VA = "0x185581370")]
	private void LDFJFKBFDMD(IMFFNFBANME LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5580900", Offset = "0x557FD00", VA = "0x185580900")]
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
	[Cpp2IlInjected.Address(RVA = "0x558BB20", Offset = "0x558AF20", VA = "0x18558BB20")]
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
		[Cpp2IlInjected.Address(RVA = "0x556CDC0", Offset = "0x556C1C0", VA = "0x18556CDC0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public Vector3 DIKOGGMMGKO
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x556C370", Offset = "0x556B770", VA = "0x18556C370", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	private Vector3 LCNCCKHCPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x556C1A0", Offset = "0x556B5A0", VA = "0x18556C1A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private PEMJBFLGGMM PFDDKBIHDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x556C5B0", Offset = "0x556B9B0", VA = "0x18556C5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x5567360", Offset = "0x5566760", VA = "0x185567360")]
	public DIFGNLBKGAE(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x556CC30", Offset = "0x556C030", VA = "0x18556CC30", Slot = "6")]
	public void LEIFIIGNCAL(PEMJBFLGGMM OKMBLMILFGG, object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x556CB00", Offset = "0x556BF00", VA = "0x18556CB00")]
	private void LEIFIIGNCAL(IMFFNFBANME OKMBLMILFGG, object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x556C280", Offset = "0x556B680", VA = "0x18556C280", Slot = "7")]
	public void DCNGBDBEBAG(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x556C710", Offset = "0x556BB10", VA = "0x18556C710")]
	private Vector3 KHDJGFCAFJN()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class CDCOFHCDLGA
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x556A820", Offset = "0x5569C20", VA = "0x18556A820")]
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
		[Cpp2IlInjected.Address(RVA = "0x5588330", Offset = "0x5587730", VA = "0x185588330", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x5588690", Offset = "0x5587A90", VA = "0x185588690", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 CIMPCCAAMLF
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x5588F80", Offset = "0x5588380", VA = "0x185588F80", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public float JCADBDOALOF
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x55895B0", Offset = "0x55889B0", VA = "0x1855895B0", Slot = "9")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x55887D0", Offset = "0x5587BD0", VA = "0x1855887D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float JPJAIDEFGCF
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x5588B60", Offset = "0x5587F60", VA = "0x185588B60", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x5588320", Offset = "0x5587720", VA = "0x185588320", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public Vector3 OFHAOOPEAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x558A6E0", Offset = "0x5589AE0", VA = "0x18558A6E0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x5588F50", Offset = "0x5588350", VA = "0x185588F50", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Quaternion OIBJJPCINPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x5589350", Offset = "0x5588750", VA = "0x185589350", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x5588F30", Offset = "0x5588330", VA = "0x185588F30", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private Rigidbody OCHJHJGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x55678D0", Offset = "0x5566CD0", VA = "0x1855678D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event ONKEIMPDALF GCAFEBIMFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x55890A0", Offset = "0x55884A0", VA = "0x1855890A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x5588280", Offset = "0x5587680", VA = "0x185588280", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x558B860", Offset = "0x558AC60", VA = "0x18558B860")]
	public KIDKGFLHJFB(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5588D20", Offset = "0x5588120", VA = "0x185588D20", Slot = "17")]
	public void GCHILAJIGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x558AB00", Offset = "0x5589F00", VA = "0x18558AB00", Slot = "16")]
	public void OPJNHLCKFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x558A710", Offset = "0x5589B10", VA = "0x18558A710", Slot = "19")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x55887E0", Offset = "0x5587BE0", VA = "0x1855887E0", Slot = "20")]
	public void EHKIOOCJGFF(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5588C40", Offset = "0x5588040", VA = "0x185588C40", Slot = "18")]
	public void ENHMBOFJGPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x558B250", Offset = "0x558A650", VA = "0x18558B250", Slot = "21")]
	public void PFHHLHIKMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x556E860", Offset = "0x556DC60", VA = "0x18556E860")]
	public void MOFFGHGKAFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x5588690", Offset = "0x5587A90", VA = "0x185588690")]
	private void HNNBIOJHDFN(Vector3 KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x558B740", Offset = "0x558AB40", VA = "0x18558B740")]
	private Vector3 PIBNIEFFMLI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x558A930", Offset = "0x5589D30", VA = "0x18558A930")]
	private void OHAEJELHKHK(float KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x558B090", Offset = "0x558A490", VA = "0x18558B090")]
	private void PCLAMECJFPB(float KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x5588460", Offset = "0x5587860", VA = "0x185588460")]
	private Vector3 BJINAFCIKKL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5589380", Offset = "0x5588780", VA = "0x185589380")]
	private void JELHKDPFBMA(Vector3 KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x5589140", Offset = "0x5588540", VA = "0x185589140")]
	private Quaternion IMMAAHNEPAL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x558AE80", Offset = "0x558A280", VA = "0x18558AE80")]
	private void PCEJMLCKBGP(Quaternion KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x5589690", Offset = "0x5588A90", VA = "0x185589690")]
	internal (float, Vector3) KFPHEOGPMGI(Rigidbody HKILLHMPOIL)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class IJNCJGEHJGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x5581BA0", Offset = "0x5580FA0", VA = "0x185581BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5573E20", Offset = "0x5573220", VA = "0x185573E20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public CACECFKIIAN LGANHOBMNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x5573660", Offset = "0x5572A60", VA = "0x185573660", Slot = "5")]
		get
		{
			return default(CACECFKIIAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private CACECFKIIAN DJNKNEBEENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x5573AF0", Offset = "0x5572EF0", VA = "0x185573AF0")]
		get
		{
			return default(CACECFKIIAN);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x5573670", Offset = "0x5572A70", VA = "0x185573670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5574050", Offset = "0x5573450", VA = "0x185574050")]
	public FILIAHGOCKK(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x5573990", Offset = "0x5572D90", VA = "0x185573990", Slot = "6")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x5573A50", Offset = "0x5572E50", VA = "0x185573A50")]
	private bool KIOONBMNHCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x5573760", Offset = "0x5572B60", VA = "0x185573760", Slot = "7")]
	public void DMFIPAONEJJ(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x5573BD0", Offset = "0x5572FD0", VA = "0x185573BD0", Slot = "8")]
	public void LOIGBFPIIGA(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x5573D10", Offset = "0x5573110", VA = "0x185573D10", Slot = "11")]
	public void NCPFCGEECHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x55738A0", Offset = "0x5572CA0", VA = "0x1855738A0")]
	private void FEICMNHAHJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x5573F00", Offset = "0x5573300", VA = "0x185573F00")]
	private void PBOKGMJLJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x5573860", Offset = "0x5572C60", VA = "0x185573860", Slot = "10")]
	public void EPIMLABDGHA(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x5573CD0", Offset = "0x55730D0", VA = "0x185573CD0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x6694140", Offset = "0x6693540", VA = "0x186694140", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public IEnumerable<object> KPJACHNJINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6693B70", Offset = "0x6692F70", VA = "0x186693B70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private bool AIBMDCPHFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x6694040", Offset = "0x6693440", VA = "0x186694040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event ONKEIMPDALF NKOIMHHPNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6693D00", Offset = "0x6693100", VA = "0x186693D00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6693DA0", Offset = "0x66931A0", VA = "0x186693DA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x66941D0", Offset = "0x66935D0", VA = "0x1866941D0")]
	public OHCHCEFNEPO(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x6693CA0", Offset = "0x66930A0", VA = "0x186693CA0", Slot = "11")]
	public IDisposable ILBPDKJDBCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x6694130", Offset = "0x6693530", VA = "0x186694130", Slot = "8")]
	public void OJMDMCDKKPE(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x6693C90", Offset = "0x6693090", VA = "0x186693C90", Slot = "9")]
	public void FHDCOJAJODE(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x6693E40", Offset = "0x6693240", VA = "0x186693E40", Slot = "10")]
	public void LAOHBPMFIPD(object JAKCBCDLMLB, bool FANMJAGAPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x6693FD0", Offset = "0x66933D0", VA = "0x186693FD0", Slot = "12")]
	public void MIFKLLNLBMA(Rigidbody MMACFBGEFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6693C60", Offset = "0x6693060", VA = "0x186693C60", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x556D730", Offset = "0x556CB30", VA = "0x18556D730", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool PGDDLMMJJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x5590090", Offset = "0x558F490", VA = "0x185590090", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event ONKEIMPDALF BLJCHPILBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x558FA00", Offset = "0x558EE00", VA = "0x18558FA00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x55906B0", Offset = "0x558FAB0", VA = "0x1855906B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x55908B0", Offset = "0x558FCB0", VA = "0x1855908B0")]
	public OAJIIILBHJB(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x55901A0", Offset = "0x558F5A0", VA = "0x1855901A0", Slot = "8")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x558FCA0", Offset = "0x558F0A0", VA = "0x18558FCA0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x558FE90", Offset = "0x558F290", VA = "0x18558FE90", Slot = "9")]
	public void GOBBLIKIBOC(PEMJBFLGGMM OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x558FAA0", Offset = "0x558EEA0", VA = "0x18558FAA0", Slot = "10")]
	public void DODGKOMIJNM(PEMJBFLGGMM OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x55904C0", Offset = "0x558F8C0", VA = "0x1855904C0")]
	private void MJKKJFIHOKF(PhotonView NGBCDGACPJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x5590750", Offset = "0x558FB50", VA = "0x185590750")]
	private void PBGBNLJNCHB(RigidbodyEx CGFIDIJHMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x55902F0", Offset = "0x558F6F0", VA = "0x1855902F0")]
	private void IGOHCJNCMGO(PhotonView LIFCNEOPDDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class KOFLGONBECM
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x558BBB0", Offset = "0x558AFB0", VA = "0x18558BBB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x558EE80", Offset = "0x558E280", VA = "0x18558EE80", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x558EA90", Offset = "0x558DE90", VA = "0x18558EA90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool JMMGDKCOBOK
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x558E8D0", Offset = "0x558DCD0", VA = "0x18558E8D0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x558E6E0", Offset = "0x558DAE0", VA = "0x18558E6E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public RigidbodyConstraints HLIGOHOAJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x558E9B0", Offset = "0x558DDB0", VA = "0x18558E9B0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x558EC80", Offset = "0x558E080", VA = "0x18558EC80", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x558EF60", Offset = "0x558E360", VA = "0x18558EF60")]
	public MJNGMFLMECE(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x558EB80", Offset = "0x558DF80", VA = "0x18558EB80", Slot = "9")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x558E7D0", Offset = "0x558DBD0", VA = "0x18558E7D0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x5566EE0", Offset = "0x55662E0", VA = "0x185566EE0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x5566B60", Offset = "0x5565F60", VA = "0x185566B60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public float GLPBFLLCCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x5566D30", Offset = "0x5566130", VA = "0x185566D30", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x5566FC0", Offset = "0x55663C0", VA = "0x185566FC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x5567360", Offset = "0x5566760", VA = "0x185567360")]
	public AEFNFONOAEJ(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x5567190", Offset = "0x5566590", VA = "0x185567190", Slot = "8")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x5566E10", Offset = "0x5566210", VA = "0x185566E10", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FA8D0", Offset = "0x6F9CD0", VA = "0x1806FA8D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x66943B0", Offset = "0x66937B0", VA = "0x1866943B0", Slot = "4")]
		public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6694380", Offset = "0x6693780", VA = "0x186694380", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6694400", Offset = "0x6693800", VA = "0x186694400", Slot = "6")]
		public void KFPHEOGPMGI(GPEJGMHBDPO GBPGPLEPLBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x55678D0", Offset = "0x5566CD0", VA = "0x1855678D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool IDEKOBKBJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x556EA90", Offset = "0x556DE90", VA = "0x18556EA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool CEEGNNLCJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x556EA70", Offset = "0x556DE70", VA = "0x18556EA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private PEMJBFLGGMM AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x556E610", Offset = "0x556DA10", VA = "0x18556E610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private bool OCODEBHAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x556E800", Offset = "0x556DC00", VA = "0x18556E800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool BIDFLEDLBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x556DD10", Offset = "0x556D110", VA = "0x18556DD10")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x556E710", Offset = "0x556DB10", VA = "0x18556E710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private bool NBPCKCACJCH
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x556E8A0", Offset = "0x556DCA0", VA = "0x18556E8A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x556E980", Offset = "0x556DD80", VA = "0x18556E980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private int LOKHHJFBMHL
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x556DC30", Offset = "0x556D030", VA = "0x18556DC30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x556DFA0", Offset = "0x556D3A0", VA = "0x18556DFA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event ONKEIMPDALF HOLNOCHIGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x556E1E0", Offset = "0x556D5E0", VA = "0x18556E1E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x556E670", Offset = "0x556DA70", VA = "0x18556E670", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x556EB30", Offset = "0x556DF30", VA = "0x18556EB30")]
	public EDKLLFKMKHG(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x556E550", Offset = "0x556D950", VA = "0x18556E550", Slot = "6")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x556E600", Offset = "0x556DA00", VA = "0x18556E600", Slot = "8")]
	public void IGEMGMCLGIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x556E330", Offset = "0x556D730", VA = "0x18556E330", Slot = "7")]
	public bool GOBGGIIBKON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x556DB80", Offset = "0x556CF80", VA = "0x18556DB80", Slot = "9")]
	public void AMHGNHLMFNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x556E860", Offset = "0x556DC60", VA = "0x18556E860", Slot = "12")]
	public void MOPGLEDKLOM(bool NBPKMHPMALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x556E280", Offset = "0x556D680", VA = "0x18556E280", Slot = "11")]
	public void GKCJECCPPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "10")]
	public void EKFBEOFALEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x556DDF0", Offset = "0x556D1F0", VA = "0x18556DDF0")]
	private bool CNCFDBKEHJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x556E090", Offset = "0x556D490", VA = "0x18556E090")]
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
		[Cpp2IlInjected.Address(RVA = "0x5568880", Offset = "0x5567C80", VA = "0x185568880", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x5568090", Offset = "0x5567490", VA = "0x185568090")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private bool OCODEBHAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x5568C20", Offset = "0x5568020", VA = "0x185568C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x5568C80", Offset = "0x5568080", VA = "0x185568C80")]
	public ANAJJKACFFF(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x5568510", Offset = "0x5567910", VA = "0x185568510", Slot = "5")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x5567F90", Offset = "0x5567390", VA = "0x185567F90", Slot = "6")]
	public void BNFFEJKELLJ(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x5568B20", Offset = "0x5567F20", VA = "0x185568B20", Slot = "7")]
	public void LAIPLJBIIOF(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x55685C0", Offset = "0x55679C0", VA = "0x1855685C0", Slot = "8")]
	public void ICGPBGLDJFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x5567D30", Offset = "0x5567130", VA = "0x185567D30", Slot = "9")]
	public void BBBNKDJHOPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x5568340", Offset = "0x5567740", VA = "0x185568340", Slot = "10")]
	public void GOGONJBMCAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "11")]
	public void HDCHMOLMOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x5568180", Offset = "0x5567580", VA = "0x185568180")]
	private void GMMEAGCIGJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x5568960", Offset = "0x5567D60", VA = "0x185568960")]
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
		[Cpp2IlInjected.Address(RVA = "0x55863E0", Offset = "0x55857E0", VA = "0x1855863E0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5587640", Offset = "0x5586A40", VA = "0x185587640", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public GGBMPGNAFJD OPABPNIHPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x5586D40", Offset = "0x5586140", VA = "0x185586D40", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x55868F0", Offset = "0x5585CF0", VA = "0x1855868F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 LCNCCKHCPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x5584EF0", Offset = "0x55842F0", VA = "0x185584EF0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5586770", Offset = "0x5585B70", VA = "0x185586770", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 AHAJMJBMMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5585F30", Offset = "0x5585330", VA = "0x185585F30", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x5588250", Offset = "0x5587650", VA = "0x185588250", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Vector3 JLGHJOIMMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x55853F0", Offset = "0x55847F0", VA = "0x1855853F0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x55879C0", Offset = "0x5586DC0", VA = "0x1855879C0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 HBNCABOKHHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5587C90", Offset = "0x5587090", VA = "0x185587C90", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x55866D0", Offset = "0x5585AD0", VA = "0x1855866D0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public float FCAAJGFAJEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x5585040", Offset = "0x5584440", VA = "0x185585040", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x5587B70", Offset = "0x5586F70", VA = "0x185587B70", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool ACGMNKMENFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x5585C30", Offset = "0x5585030", VA = "0x185585C30", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private EBDBHLCOCAL AONNGMAKJLK
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x1A07060", Offset = "0x1A06460", VA = "0x181A07060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private bool CEEGNNLCJLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x556EA70", Offset = "0x556DE70", VA = "0x18556EA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x5567360", Offset = "0x5566760", VA = "0x185567360")]
	public JOLGODBODJI(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x5586150", Offset = "0x5585550", VA = "0x185586150", Slot = "20")]
	public void FOJGNOFNCLG(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x5585E40", Offset = "0x5585240", VA = "0x185585E40", Slot = "31")]
	public void EJPJLNDPFPP(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x5586700", Offset = "0x5585B00", VA = "0x185586700", Slot = "19")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5585D10", Offset = "0x5585110", VA = "0x185585D10", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5587980", Offset = "0x5586D80", VA = "0x185587980", Slot = "28")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5584AE0", Offset = "0x5583EE0", VA = "0x185584AE0", Slot = "36")]
	public Vector3 ABHOGLBBGMA(Vector3 HFELIOHGGDO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5586510", Offset = "0x5585910", VA = "0x185586510", Slot = "35")]
	public Vector3 GNEKHGHFGKA(Vector3 FEAFOIFGCCF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5586700", Offset = "0x5585B00", VA = "0x185586700", Slot = "27")]
	public void IIPKPIBFBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5586240", Offset = "0x5585640", VA = "0x185586240", Slot = "25")]
	public void GJGKIDGKPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5585BF0", Offset = "0x5584FF0", VA = "0x185585BF0", Slot = "24")]
	public void CMHHFMOHFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x55859B0", Offset = "0x5584DB0", VA = "0x1855859B0", Slot = "34")]
	public void CJHODKMAJBE(Vector3 OLJIPBFJCBL, Vector3 CJANALIFPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5587730", Offset = "0x5586B30", VA = "0x185587730", Slot = "33")]
	public void LICDBAEOAFD(Vector3 OABJFLBJEKB, Vector3 IMCNKNPLDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5586280", Offset = "0x5585680", VA = "0x185586280", Slot = "32")]
	public void GMEDHCFFMEH(Vector3 ANJGHBFDIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5585540", Offset = "0x5584940", VA = "0x185585540", Slot = "22")]
	public void CBOAGHDBPJH(OBJOKHNKAPP CAMLNFGKHFE, Vector3 MAIIDBKHIED, float JOFBEKECLOD, float CLOJEHHLDHC = 8f, float ILPINEMCFMP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5584CC0", Offset = "0x55840C0", VA = "0x185584CC0", Slot = "21")]
	public void AFOBMMCCHIM(EKKHOJNPNMO PNJHOCPNCML, Vector3 NFNPPPGADBK, float MMIALNFHMCC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5585120", Offset = "0x5584520", VA = "0x185585120", Slot = "23")]
	[Obsolete]
	public void BMPJNHFGFFL(EKKHOJNPNMO PNJHOCPNCML, Vector3 OLBDAPNGDPL, float CEIPLLMFOOE = 7f, float OGLOAGFEIHM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5586830", Offset = "0x5585C30", VA = "0x185586830", Slot = "30")]
	public Vector3 IDKDPPMOKNN(Vector3 FJHEIJDCBEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5587A80", Offset = "0x5586E80", VA = "0x185587A80", Slot = "29")]
	public Vector3 NOILBEMLPLM(Vector3 BAMHFNACLOC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5587850", Offset = "0x5586C50", VA = "0x185587850", Slot = "26")]
	public void MDDKFEEINFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5586E70", Offset = "0x5586270", VA = "0x185586E70")]
	private void JCFEOFGMADC(float KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5587DB0", Offset = "0x55871B0", VA = "0x185587DB0")]
	private void PANKLFBIFGF(Vector3 NFNPPPGADBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5587B80", Offset = "0x5586F80", VA = "0x185587B80")]
	private Vector3 OICADJOPIOK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5587F10", Offset = "0x5587310", VA = "0x185587F10")]
	private void PLMCKOJFMKL(Vector3 FEAFOIFGCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5586040", Offset = "0x5585440", VA = "0x185586040")]
	private Vector3 FDMJOFIOEHO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x55869E0", Offset = "0x5585DE0", VA = "0x1855869E0")]
	private void INELDJICPMM(Vector3 KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5587040", Offset = "0x5586440", VA = "0x185587040")]
	private void KBIABBAPIJA(Vector3 FEAFOIFGCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x5587790", Offset = "0x5586B90", VA = "0x185587790")]
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
		[Cpp2IlInjected.Address(RVA = "0xBC5610", Offset = "0xBC4A10", VA = "0x180BC5610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected GPEJGMHBDPO PJKAPDAPHHE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x557CEF0", Offset = "0x557C2F0", VA = "0x18557CEF0")]
		get
		{
			return default(GPEJGMHBDPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x5567360", Offset = "0x5566760", VA = "0x185567360")]
	public GLKGHFNEBOE(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x557CDD0", Offset = "0x557C1D0", VA = "0x18557CDD0")]
	protected PEMJBFLGGMM AEEHHDDIJIH(GPEJGMHBDPO LCCDBPIJCNE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class EOLPDLGBALJ : HMOFCBOHILL
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x5572FC0", Offset = "0x55723C0", VA = "0x185572FC0", Slot = "4")]
	public KOFIFPKBGDE HPMJMPJAEBF(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x5572CC0", Offset = "0x55720C0", VA = "0x185572CC0", Slot = "5")]
	public IGHPKHJEAKK ELGDCBJCMFN(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x55732C0", Offset = "0x55726C0", VA = "0x1855732C0", Slot = "6")]
	public DOLOBBHOJCN JPOHICNGBBP(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x5573360", Offset = "0x5572760", VA = "0x185573360", Slot = "7")]
	public BEGCJHEKPFH KCHPJLDNMCG(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x55734A0", Offset = "0x55728A0", VA = "0x1855734A0", Slot = "8")]
	public FEJPDKKHHEB LNKOELKMANO(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x55735C0", Offset = "0x55729C0", VA = "0x1855735C0", Slot = "9")]
	public CCMAIABHGHM OKIKOAODBKA(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5572D60", Offset = "0x5572160", VA = "0x185572D60", Slot = "10")]
	public KJKCPGCAIML GBFBEIIDFCA(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x5572DC0", Offset = "0x55721C0", VA = "0x185572DC0", Slot = "11")]
	public EBDBHLCOCAL GJGOKLOIGBN(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x5573400", Offset = "0x5572800", VA = "0x185573400", Slot = "12")]
	public AHAFDFAMMOI LHOEKHPMJKM(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x5572F20", Offset = "0x5572320", VA = "0x185572F20", Slot = "13")]
	public COEGLBKNHNL HLENLHEFFLE(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5572E60", Offset = "0x5572260", VA = "0x185572E60")]
	public BJEGJOOAAHN HLAKIFBKGOD(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x5573500", Offset = "0x5572900", VA = "0x185573500")]
	public AEHNOIOGGNB PFOFCHGKLBD(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5573130", Offset = "0x5572530", VA = "0x185573130")]
	public FAMFIMIKKAN JOJCEHJOGPP(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x5572C50", Offset = "0x5572050", VA = "0x185572C50")]
	public DPAGPKHBGMK DBPGDMNKLJL(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x5572B30", Offset = "0x5571F30", VA = "0x185572B30")]
	public MNOPDMEBLBE KCDDEIIAPGE(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5572BA0", Offset = "0x5571FA0", VA = "0x185572BA0", Slot = "19")]
	public PEMJBFLGGMM BBMPNOCKHLJ(RigidbodyEx LKMGIJIPLIN, IKIHJJFFHFA FNIHENPLJHK, OOMBAIEJEBP CBBILOOJOAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public EOLPDLGBALJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5572E60", Offset = "0x5572260", VA = "0x185572E60", Slot = "14")]
	private BJEGJOOAAHN NGEGFJLNLMF(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5573500", Offset = "0x5572900", VA = "0x185573500", Slot = "15")]
	private AEHNOIOGGNB NKLPIGOJNFO(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5573130", Offset = "0x5572530", VA = "0x185573130", Slot = "16")]
	private FAMFIMIKKAN JEMOMHAJBJM(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5572C50", Offset = "0x5572050", VA = "0x185572C50", Slot = "17")]
	private DPAGPKHBGMK INHHAPJMGIP(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5572B30", Offset = "0x5571F30", VA = "0x185572B30", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x556A200", Offset = "0x5569600", VA = "0x18556A200", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public PEMJBFLGGMM IHLOOLPGFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x556A2D0", Offset = "0x55696D0", VA = "0x18556A2D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x556A1B0", Offset = "0x55695B0", VA = "0x18556A1B0")]
	public BNFDBLCAHDO(GPEJGMHBDPO LCCDBPIJCNE, OLGPCPINIDC GNJOCELFONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x556A010", Offset = "0x5569410", VA = "0x18556A010", Slot = "6")]
	public IEnumerator<PEMJBFLGGMM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x556A010", Offset = "0x5569410", VA = "0x18556A010", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x556A1A0", Offset = "0x55695A0", VA = "0x18556A1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x557E990", Offset = "0x557DD90", VA = "0x18557E990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x557EF20", Offset = "0x557E320", VA = "0x18557EF20", Slot = "20")]
	public void JMIGPNHIIPA(FEPIHHOJCOJ HPFBGIEBCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x557EDD0", Offset = "0x557E1D0", VA = "0x18557EDD0", Slot = "4")]
	public KOFIFPKBGDE HPMJMPJAEBF(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x557EAA0", Offset = "0x557DEA0", VA = "0x18557EAA0", Slot = "5")]
	public IGHPKHJEAKK ELGDCBJCMFN(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x557EF70", Offset = "0x557E370", VA = "0x18557EF70", Slot = "6")]
	public DOLOBBHOJCN JPOHICNGBBP(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x557F010", Offset = "0x557E410", VA = "0x18557F010", Slot = "7")]
	public BEGCJHEKPFH KCHPJLDNMCG(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x557F150", Offset = "0x557E550", VA = "0x18557F150", Slot = "8")]
	public FEJPDKKHHEB LNKOELKMANO(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x557F2A0", Offset = "0x557E6A0", VA = "0x18557F2A0", Slot = "9")]
	public CCMAIABHGHM OKIKOAODBKA(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x557EB40", Offset = "0x557DF40", VA = "0x18557EB40", Slot = "10")]
	public KJKCPGCAIML GBFBEIIDFCA(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x557EBE0", Offset = "0x557DFE0", VA = "0x18557EBE0", Slot = "11")]
	public EBDBHLCOCAL GJGOKLOIGBN(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x557F0B0", Offset = "0x557E4B0", VA = "0x18557F0B0", Slot = "12")]
	public AHAFDFAMMOI LHOEKHPMJKM(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x557ED30", Offset = "0x557E130", VA = "0x18557ED30", Slot = "13")]
	public COEGLBKNHNL HLENLHEFFLE(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x557EC80", Offset = "0x557E080", VA = "0x18557EC80")]
	public BJEGJOOAAHN HLAKIFBKGOD(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x557F1F0", Offset = "0x557E5F0", VA = "0x18557F1F0")]
	public AEHNOIOGGNB PFOFCHGKLBD(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x557EE70", Offset = "0x557E270", VA = "0x18557EE70")]
	public FAMFIMIKKAN JOJCEHJOGPP(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x557E9F0", Offset = "0x557DDF0", VA = "0x18557E9F0")]
	public DPAGPKHBGMK DBPGDMNKLJL(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x557E790", Offset = "0x557DB90", VA = "0x18557E790")]
	public MNOPDMEBLBE KCDDEIIAPGE(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x557E840", Offset = "0x557DC40", VA = "0x18557E840", Slot = "19")]
	public PEMJBFLGGMM BBMPNOCKHLJ(RigidbodyEx LKMGIJIPLIN, IKIHJJFFHFA FNIHENPLJHK, OOMBAIEJEBP CBBILOOJOAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x557F340", Offset = "0x557E740", VA = "0x18557F340")]
	public HINFBEJMPDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x557EC80", Offset = "0x557E080", VA = "0x18557EC80", Slot = "14")]
	private BJEGJOOAAHN NGEGFJLNLMF(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x557F1F0", Offset = "0x557E5F0", VA = "0x18557F1F0", Slot = "15")]
	private AEHNOIOGGNB NKLPIGOJNFO(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x557EE70", Offset = "0x557E270", VA = "0x18557EE70", Slot = "16")]
	private FAMFIMIKKAN JEMOMHAJBJM(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x557E9F0", Offset = "0x557DDF0", VA = "0x18557E9F0", Slot = "17")]
	private DPAGPKHBGMK INHHAPJMGIP(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x557E790", Offset = "0x557DB90", VA = "0x18557E790", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FA8E0", Offset = "0x6F9CE0", VA = "0x1806FA8E0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E7570", Offset = "0x6E6970", VA = "0x1806E7570", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x6E7590", Offset = "0x6E6990", VA = "0x1806E7590", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public IReadOnlyList<PEMJBFLGGMM> BIMGCBEFPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6E7580", Offset = "0x6E6980", VA = "0x1806E7580", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E00D0", Offset = "0x6DF4D0", VA = "0x1806E00D0", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0xED5AB0", Offset = "0xED4EB0", VA = "0x180ED5AB0", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x135A610", Offset = "0x1359A10", VA = "0x18135A610", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0xB92E00", Offset = "0xB92200", VA = "0x180B92E00", Slot = "15")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E00B0", Offset = "0x6DF4B0", VA = "0x1806E00B0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7D8320", Offset = "0x7D7720", VA = "0x1807D8320", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public GGBMPGNAFJD OPABPNIHPDI
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x6F6770", Offset = "0x6F5B70", VA = "0x1806F6770", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x781AD0", Offset = "0x780ED0", VA = "0x180781AD0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public float FCAAJGFAJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1592350", Offset = "0x1591750", VA = "0x181592350", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x15923F0", Offset = "0x15917F0", VA = "0x1815923F0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 AHAJMJBMMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x26C6CF0", Offset = "0x26C60F0", VA = "0x1826C6CF0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x26C6C70", Offset = "0x26C6070", VA = "0x1826C6C70", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 HBNCABOKHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x1D8CAC0", Offset = "0x1D8BEC0", VA = "0x181D8CAC0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x1D89FF0", Offset = "0x1D893F0", VA = "0x181D89FF0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 LCNCCKHCPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x1D8CAE0", Offset = "0x1D8BEE0", VA = "0x181D8CAE0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1D88850", Offset = "0x1D87C50", VA = "0x181D88850", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Vector3 JLGHJOIMMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x11221A0", Offset = "0x11215A0", VA = "0x1811221A0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool CPPIJLCAPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xBC9240", Offset = "0xBC8640", VA = "0x180BC9240", Slot = "30")]
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
		[Cpp2IlInjected.Address(RVA = "0xC0D870", Offset = "0xC0CC70", VA = "0x180C0D870", Slot = "31")]
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
		[Cpp2IlInjected.Address(RVA = "0xC0D860", Offset = "0xC0CC60", VA = "0x180C0D860", Slot = "32")]
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
		[Cpp2IlInjected.Address(RVA = "0xA88AE0", Offset = "0xA87EE0", VA = "0x180A88AE0", Slot = "33")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C09420", Offset = "0x1C08820", VA = "0x181C09420", Slot = "34")]
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
		[Cpp2IlInjected.Address(RVA = "0x161DF30", Offset = "0x161D330", VA = "0x18161DF30", Slot = "35")]
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
		[Cpp2IlInjected.Address(RVA = "0x11221A0", Offset = "0x11215A0", VA = "0x1811221A0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 CIMPCCAAMLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x1D8CBA0", Offset = "0x1D8BFA0", VA = "0x181D8CBA0", Slot = "38")]
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
		[Cpp2IlInjected.Address(RVA = "0x115B720", Offset = "0x115AB20", VA = "0x18115B720", Slot = "39")]
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
		[Cpp2IlInjected.Address(RVA = "0x1222300", Offset = "0x1221700", VA = "0x181222300", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 OFHAOOPEAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x11221A0", Offset = "0x11215A0", VA = "0x1811221A0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion OIBJJPCINPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x11A86E0", Offset = "0x11A7AE0", VA = "0x1811A86E0", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public float CMNCFAMIFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x1222300", Offset = "0x1221700", VA = "0x181222300", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public float GLPBFLLCCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x1222300", Offset = "0x1221700", VA = "0x181222300", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool IKHDPECJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool EJFKHFNNKHH
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CLIIJKDLFPK JLBHGNPAHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00", Slot = "52")]
		get
		{
			return default(CLIIJKDLFPK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool HIDLJAAELFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x21FDFC0", Offset = "0x21FD3C0", VA = "0x1821FDFC0", Slot = "54")]
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
		[Cpp2IlInjected.Address(RVA = "0x810840", Offset = "0x80FC40", VA = "0x180810840", Slot = "55")]
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
		[Cpp2IlInjected.Address(RVA = "0x7987C0", Offset = "0x797BC0", VA = "0x1807987C0", Slot = "56")]
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
		[Cpp2IlInjected.Address(RVA = "0x11221A0", Offset = "0x11215A0", VA = "0x1811221A0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float FKAPONKEAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x1222300", Offset = "0x1221700", VA = "0x181222300", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public float FOMCKPAPOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x1222300", Offset = "0x1221700", VA = "0x181222300", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Quaternion CBCKCFLIFDK
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x127E020", Offset = "0x127D420", VA = "0x18127E020", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Vector3 INAHNKFEMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x11221A0", Offset = "0x11215A0", VA = "0x1811221A0", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Quaternion PHAFEIAABKC
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x127E020", Offset = "0x127D420", VA = "0x18127E020", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public RigidbodyConstraints HLIGOHOAJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x6E7170", Offset = "0x6E6570", VA = "0x1806E7170", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool ELDBHBFKIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public CollisionDetectionMode IBLNPOEEODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x6E7170", Offset = "0x6E6570", VA = "0x1806E7170", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool CEEGNNLCJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xFB4180", Offset = "0xFB3580", VA = "0x180FB4180", Slot = "75")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event ONKEIMPDALF BJBFJNEGDJP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event BAPGIHMPHAC JDHPMFPKGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event ONKEIMPDALF BLJCHPILBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event ONKEIMPDALF BPFDNFOMPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event ONKEIMPDALF HOLNOCHIGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<GMJLIEJPOEJ, GMJLIEJPOEJ> BKPNGAGNMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event ONKEIMPDALF PEJBAIOJGEE
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event ONKEIMPDALF JFGDBEMBLMM
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "125")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "126")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "76")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "77")]
	public void HDKFJIKLEJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "78")]
	public void EPMHDFKPLEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "79")]
	public void AMHGNHLMFNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "80")]
	public void EJBOICBIHAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "87")]
	public void JDHACNMMLIE(PEMJBFLGGMM KPPLMEOMNGF, bool GMEFKHHIEPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "90")]
	public void BFMOPJLHBBG(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "91")]
	public void LHGJEIODGLO(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x11221A0", Offset = "0x11215A0", VA = "0x1811221A0", Slot = "92")]
	public Vector3 ABHOGLBBGMA(Vector3 HFELIOHGGDO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x11221A0", Offset = "0x11215A0", VA = "0x1811221A0", Slot = "93")]
	public Vector3 GNEKHGHFGKA(Vector3 FEAFOIFGCCF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "94")]
	public void IIPKPIBFBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "95")]
	public void GJGKIDGKPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "96")]
	public void CMHHFMOHFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "97")]
	public void CJHODKMAJBE(Vector3 OLJIPBFJCBL, Vector3 CJANALIFPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "98")]
	public void LICDBAEOAFD(Vector3 OABJFLBJEKB, Vector3 IMCNKNPLDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "99")]
	public void GMEDHCFFMEH(Vector3 ANJGHBFDIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "100")]
	public void CBOAGHDBPJH(OBJOKHNKAPP CAMLNFGKHFE, Vector3 MAIIDBKHIED, float JOFBEKECLOD, float CLOJEHHLDHC = 8f, float ILPINEMCFMP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "101")]
	public void AFOBMMCCHIM(EKKHOJNPNMO PNJHOCPNCML, Vector3 NFNPPPGADBK, float MMIALNFHMCC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "102")]
	public void BMPJNHFGFFL(EKKHOJNPNMO PNJHOCPNCML, Vector3 OLBDAPNGDPL, float CEIPLLMFOOE = 7f, float OGLOAGFEIHM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x11221A0", Offset = "0x11215A0", VA = "0x1811221A0", Slot = "103")]
	public Vector3 IDKDPPMOKNN(Vector3 KPPLMEOMNGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x11221A0", Offset = "0x11215A0", VA = "0x1811221A0", Slot = "104")]
	public Vector3 NOILBEMLPLM(Vector3 KPPLMEOMNGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "105")]
	public void MDDKFEEINFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "106")]
	public void MEJBHJGELMJ(PEMJBFLGGMM HEPODBMIMNP, object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "107")]
	public void GAIBLGGKAKK(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "110")]
	public void GCHILAJIGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "111")]
	public void OPJNHLCKFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "112")]
	public void ENHMBOFJGPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00", Slot = "115")]
	public bool GOBGGIIBKON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "116")]
	public void GKCJECCPPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6E7170", Offset = "0x6E6570", VA = "0x1806E7170", Slot = "121")]
	public IDisposable ILBPDKJDBCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "122")]
	public void OJMDMCDKKPE(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "123")]
	public void FHDCOJAJODE(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "124")]
	public void LAOHBPMFIPD(object JAKCBCDLMLB, bool FANMJAGAPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "127")]
	public void AGNLAHKGJCD(Vector3 IIHKIEHLKJE, Quaternion OKGAEIKHFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "128")]
	public void CGBDHLAKFPB(Vector3 JAGOFJILOLJ, Quaternion PAFGOIINECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00", Slot = "129")]
	public bool BGJIPHJJDJL(float DEGNNNFBBGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "130")]
	public void KGPNCHMMJJG(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "131")]
	public void EFNCJDLHIIK(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "132")]
	public void BNFFEJKELLJ(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "133")]
	public void LAIPLJBIIOF(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "134")]
	public void LKANBCJLPMP(Vector3 AKNNPOEHKML, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "135")]
	public void LBNEOPMLINP(Vector3 AKNNPOEHKML, Vector3 MIFJBHLKJIN, ForceMode KHIFDLIHLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "136")]
	public void HKPKKNJICLF(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "137")]
	public void EIKMOLMEFMN(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x557CF20", Offset = "0x557C320", VA = "0x18557CF20", Slot = "138")]
	public bool CBCMNPEEDCJ(Vector3 JLBPNKFCLFO, out RaycastHit JFEEEDGCAPO, float FNIJMIADAMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "139")]
	public void PFHHLHIKMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5582460", Offset = "0x5581860", VA = "0x185582460")]
	public IMFFNFBANME(GameObject BLPBCMIHDMD, RigidbodyEx JKNMFOBKPNO, OOMBAIEJEBP CBBILOOJOAK, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x5581F20", Offset = "0x5581320", VA = "0x185581F20", Slot = "142")]
	protected override void CICIFIGLLJJ(OOMBAIEJEBP CBBILOOJOAK, IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x55821B0", Offset = "0x55815B0", VA = "0x1855821B0", Slot = "143")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x5581C30", Offset = "0x5581030", VA = "0x185581C30", Slot = "145")]
	public void AKLOKOLCHJE(CBFJMCFAKAM ENFEPLFMJNK, CBFJMCFAKAM IEFBANIHOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x5581E60", Offset = "0x5581260", VA = "0x185581E60", Slot = "146")]
	public void AOBLDGDALCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x5582340", Offset = "0x5581740", VA = "0x185582340", Slot = "147")]
	public void JCPJHKHAFHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x5582400", Offset = "0x5581800", VA = "0x185582400", Slot = "148")]
	public void MOPGLEDKLOM(bool NBPKMHPMALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x5581D00", Offset = "0x5581100", VA = "0x185581D00", Slot = "149")]
	public bool ANBIINOJEPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "144")]
	public override void EJBOICBIHAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class AJDCAPBMBKG
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x5567CE0", Offset = "0x55670E0", VA = "0x185567CE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x55678D0", Offset = "0x5566CD0", VA = "0x1855678D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public CollisionDetectionMode IBLNPOEEODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x5567B40", Offset = "0x5566F40", VA = "0x185567B40", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x55679A0", Offset = "0x5566DA0", VA = "0x1855679A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x5567C50", Offset = "0x5567050", VA = "0x185567C50")]
	public AJCMBNBPOCE(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x55677B0", Offset = "0x5566BB0", VA = "0x1855677B0", Slot = "6")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x5567920", Offset = "0x5566D20", VA = "0x185567920", Slot = "9")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x5567790", Offset = "0x5566B90", VA = "0x185567790", Slot = "7")]
	public void CKELEIJDMGC(bool BJPNLAHPGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x55677A0", Offset = "0x5566BA0", VA = "0x1855677A0", Slot = "8")]
	public void FAAPOKHEFAE(bool BJPNLAHPGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x5567620", Offset = "0x5566A20", VA = "0x185567620", Slot = "10")]
	public bool CBCMNPEEDCJ(Vector3 JLBPNKFCLFO, out RaycastHit JFEEEDGCAPO, float FNIJMIADAMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x5567A10", Offset = "0x5566E10", VA = "0x185567A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x558E300", Offset = "0x558D700", VA = "0x18558E300", Slot = "6")]
		get
		{
			return default(CLIIJKDLFPK);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x558DED0", Offset = "0x558D2D0", VA = "0x18558DED0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Transform MPACEKJKBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x558E2E0", Offset = "0x558D6E0", VA = "0x18558E2E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<GMJLIEJPOEJ, GMJLIEJPOEJ> BKPNGAGNMKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x558E440", Offset = "0x558D840", VA = "0x18558E440", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x558DDE0", Offset = "0x558D1E0", VA = "0x18558DDE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x558E4E0", Offset = "0x558D8E0", VA = "0x18558E4E0")]
	public LOACJNKAMFP(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x558DFA0", Offset = "0x558D3A0", VA = "0x18558DFA0", Slot = "8")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x558DE80", Offset = "0x558D280", VA = "0x18558DE80", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x558E280", Offset = "0x558D680", VA = "0x18558E280", Slot = "11")]
	private void KIIOGLGMDAF(GMJLIEJPOEJ BBGPNJDGJOJ, GMJLIEJPOEJ BDOHNKDFFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "12")]
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
		[Cpp2IlInjected.Address(RVA = "0x55678D0", Offset = "0x5566CD0", VA = "0x1855678D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private bool HIDLJAAELFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x557E110", Offset = "0x557D510", VA = "0x18557E110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private bool OCODEBHAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x5568C20", Offset = "0x5568020", VA = "0x185568C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private PEMJBFLGGMM AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x558D400", Offset = "0x558C800", VA = "0x18558D400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x5567C50", Offset = "0x5567050", VA = "0x185567C50")]
	public LLNCOKAMAFD(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x558D2A0", Offset = "0x558C6A0", VA = "0x18558D2A0", Slot = "4")]
	public void LKANBCJLPMP(Vector3 AKNNPOEHKML, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x558C9A0", Offset = "0x558BDA0", VA = "0x18558C9A0")]
	private void APHEOOMGEAE(Vector3 AKNNPOEHKML, ForceMode KHIFDLIHLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x558D000", Offset = "0x558C400", VA = "0x18558D000", Slot = "5")]
	public void LBNEOPMLINP(Vector3 AKNNPOEHKML, Vector3 MIFJBHLKJIN, ForceMode KHIFDLIHLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x558CEA0", Offset = "0x558C2A0", VA = "0x18558CEA0", Slot = "6")]
	public void HKPKKNJICLF(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x558D460", Offset = "0x558C860", VA = "0x18558D460")]
	private void PDBJHNFEIFK(Vector3 MFDHEHJLGKG, ForceMode KHIFDLIHLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x558CC20", Offset = "0x558C020", VA = "0x18558CC20", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FA8D0", Offset = "0x6F9CD0", VA = "0x1806FA8D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x558F1A0", Offset = "0x558E5A0", VA = "0x18558F1A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x5567C50", Offset = "0x5567050", VA = "0x185567C50")]
	public MLJIJONONIB(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x558F2B0", Offset = "0x558E6B0", VA = "0x18558F2B0", Slot = "6")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x557CFA0", Offset = "0x557C3A0", VA = "0x18557CFA0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x55833E0", Offset = "0x55827E0", VA = "0x1855833E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public PEMJBFLGGMM AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x6F6700", Offset = "0x6F5B00", VA = "0x1806F6700", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x5584270", Offset = "0x5583670", VA = "0x185584270", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public PEMJBFLGGMM IMFMPPONFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x6F6780", Offset = "0x6F5B80", VA = "0x1806F6780", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public IReadOnlyList<PEMJBFLGGMM> BIMGCBEFPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x6F6770", Offset = "0x6F5B70", VA = "0x1806F6770", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event ONKEIMPDALF FGKDCAIOBOH
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x55841D0", Offset = "0x55835D0", VA = "0x1855841D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x5582EC0", Offset = "0x55822C0", VA = "0x185582EC0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event ONKEIMPDALF BJBFJNEGDJP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x55848F0", Offset = "0x5583CF0", VA = "0x1855848F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x5583440", Offset = "0x5582840", VA = "0x185583440", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event BAPGIHMPHAC JDHPMFPKGAD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x5583760", Offset = "0x5582B60", VA = "0x185583760", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x5584670", Offset = "0x5583A70", VA = "0x185584670", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action CLLCEGLBDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x5583220", Offset = "0x5582620", VA = "0x185583220", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x5583580", Offset = "0x5582980", VA = "0x185583580", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action LHGLPPNOMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x5584990", Offset = "0x5583D90", VA = "0x185584990", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x5584850", Offset = "0x5583C50", VA = "0x185584850", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<PEMJBFLGGMM> NEGJPDDONIC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x5584710", Offset = "0x5583B10", VA = "0x185584710", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x55838A0", Offset = "0x5582CA0", VA = "0x1855838A0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<PEMJBFLGGMM> MKOODLOMFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x5583800", Offset = "0x5582C00", VA = "0x185583800", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x55834E0", Offset = "0x55828E0", VA = "0x1855834E0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action JHGAJELOKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x55847B0", Offset = "0x5583BB0", VA = "0x1855847B0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x5583EE0", Offset = "0x55832E0", VA = "0x185583EE0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<PEMJBFLGGMM> LEMANBDPLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x5583340", Offset = "0x5582740", VA = "0x185583340", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x5583620", Offset = "0x5582A20", VA = "0x185583620", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x5584A30", Offset = "0x5583E30", VA = "0x185584A30")]
	public JLGHEJKJAIM(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x55832C0", Offset = "0x55826C0", VA = "0x1855832C0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x5583940", Offset = "0x5582D40", VA = "0x185583940", Slot = "30")]
	public void JDHACNMMLIE(PEMJBFLGGMM KHLHKJKADHO, bool GMEFKHHIEPP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x5583F80", Offset = "0x5583380", VA = "0x185583F80", Slot = "6")]
	public void JJJDGCHINFP(PEMJBFLGGMM OBCJBMNJCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x5584410", Offset = "0x5583810", VA = "0x185584410", Slot = "7")]
	public void LLKFKAGPDOF(PEMJBFLGGMM OBCJBMNJCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x55836C0", Offset = "0x5582AC0", VA = "0x1855836C0", Slot = "4")]
	public void GFLPJLNLLDG(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x5584370", Offset = "0x5583770", VA = "0x185584370", Slot = "5")]
	public void LDFJFKBFDMD(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x5582D00", Offset = "0x5582100", VA = "0x185582D00")]
	private void ACMEOJCFDDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x5582F60", Offset = "0x5582360", VA = "0x185582F60")]
	private void CEJMMPCINJH(PEMJBFLGGMM OBCJBMNJCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x55830D0", Offset = "0x55824D0", VA = "0x1855830D0")]
	private void DCLEOJKOOIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x5582D90", Offset = "0x5582190", VA = "0x185582D90")]
	private void BGGDFBNJICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x5582FA0", Offset = "0x55823A0", VA = "0x185582FA0")]
	private void COBJFADANHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x5584280", Offset = "0x5583680", VA = "0x185584280")]
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
	[Cpp2IlInjected.Address(RVA = "0x55741C0", Offset = "0x55735C0", VA = "0x1855741C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Vector3 PPABHMBOJDG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x5572670", Offset = "0x5571A70", VA = "0x185572670", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public Vector3 DIKOGGMMGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x5572030", Offset = "0x5571430", VA = "0x185572030", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private Vector3 LCNCCKHCPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x5571EF0", Offset = "0x55712F0", VA = "0x185571EF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public PEMJBFLGGMM PFDDKBIHDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x5572200", Offset = "0x5571600", VA = "0x185572200", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x5572A40", Offset = "0x5571E40", VA = "0x185572A40")]
	public EOLMEMIOLOI(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x5572600", Offset = "0x5571A00", VA = "0x185572600", Slot = "8")]
	public void LEIFIIGNCAL(PEMJBFLGGMM OKMBLMILFGG, object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x5571FD0", Offset = "0x55713D0", VA = "0x185571FD0", Slot = "9")]
	public void DCNGBDBEBAG(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x55722B0", Offset = "0x55716B0", VA = "0x1855722B0")]
	private Vector3 KHDJGFCAFJN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x55726A0", Offset = "0x5571AA0", VA = "0x1855726A0")]
	private void NMNLIDBJLAH(PEMJBFLGGMM KDELELJPDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class BCNPDOJBGBA
{
	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x5569F50", Offset = "0x5569350", VA = "0x185569F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x12C3170", Offset = "0x12C2570", VA = "0x1812C3170", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x557A5C0", Offset = "0x55799C0", VA = "0x18557A5C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 CIMPCCAAMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x557B010", Offset = "0x557A410", VA = "0x18557B010", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float JCADBDOALOF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x15AB6F0", Offset = "0x15AAAF0", VA = "0x1815AB6F0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x557A5E0", Offset = "0x55799E0", VA = "0x18557A5E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public float JPJAIDEFGCF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x112D660", Offset = "0x112CA60", VA = "0x18112D660", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x557A420", Offset = "0x5579820", VA = "0x18557A420", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Vector3 OFHAOOPEAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x557C420", Offset = "0x557B820", VA = "0x18557C420", Slot = "13")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x557AE70", Offset = "0x557A270", VA = "0x18557AE70", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public Quaternion OIBJJPCINPO
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x557B310", Offset = "0x557A710", VA = "0x18557B310", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x557ACD0", Offset = "0x557A0D0", VA = "0x18557ACD0", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody OCHJHJGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x5569C10", Offset = "0x5569010", VA = "0x185569C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event ONKEIMPDALF GCAFEBIMFLK
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x557B110", Offset = "0x557A510", VA = "0x18557B110", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x557A380", Offset = "0x5579780", VA = "0x18557A380", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x557CD00", Offset = "0x557C100", VA = "0x18557CD00")]
	public GANEHBCINGN(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x557AB10", Offset = "0x5579F10", VA = "0x18557AB10", Slot = "18")]
	public void GCHILAJIGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x557C670", Offset = "0x557BA70", VA = "0x18557C670", Slot = "17")]
	public void OPJNHLCKFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x557C590", Offset = "0x557B990", VA = "0x18557C590", Slot = "20")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x557A700", Offset = "0x5579B00", VA = "0x18557A700", Slot = "21")]
	public void EHKIOOCJGFF(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x557A9A0", Offset = "0x5579DA0", VA = "0x18557A9A0", Slot = "19")]
	public void ENHMBOFJGPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x557C750", Offset = "0x557BB50", VA = "0x18557C750", Slot = "22")]
	public void PFHHLHIKMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x557A5C0", Offset = "0x55799C0", VA = "0x18557A5C0")]
	private void HNNBIOJHDFN(Vector3 KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x557CC10", Offset = "0x557C010", VA = "0x18557CC10")]
	private Vector3 PIBNIEFFMLI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x557A5E0", Offset = "0x55799E0", VA = "0x18557A5E0")]
	private void OHAEJELHKHK(float KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x557A420", Offset = "0x5579820", VA = "0x18557A420")]
	private void PCLAMECJFPB(float KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x557A440", Offset = "0x5579840", VA = "0x18557A440")]
	private Vector3 BJINAFCIKKL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x557AE70", Offset = "0x557A270", VA = "0x18557AE70")]
	private void JELHKDPFBMA(Vector3 KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x557B1B0", Offset = "0x557A5B0", VA = "0x18557B1B0")]
	private Quaternion IMMAAHNEPAL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x557ACD0", Offset = "0x557A0D0", VA = "0x18557ACD0")]
	private void PCEJMLCKBGP(Quaternion KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x557C340", Offset = "0x557B740", VA = "0x18557C340")]
	public void KFPHEOGPMGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x557B480", Offset = "0x557A880", VA = "0x18557B480", Slot = "4")]
	public (float, Vector3) KFPHEOGPMGI(Rigidbody HKILLHMPOIL)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class NPILOOBAKCL
{
	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x558F940", Offset = "0x558ED40", VA = "0x18558F940")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DBD850", Offset = "0x1DBCC50", VA = "0x181DBD850", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public CACECFKIIAN LGANHOBMNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x6E0010", Offset = "0x6DF410", VA = "0x1806E0010", Slot = "5")]
		get
		{
			return default(CACECFKIIAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x558DCF0", Offset = "0x558D0F0", VA = "0x18558DCF0")]
	public LNDDAJDGAEE(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x558D860", Offset = "0x558CC60", VA = "0x18558D860", Slot = "6")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x558D930", Offset = "0x558CD30", VA = "0x18558D930")]
	private bool KIOONBMNHCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x558D6E0", Offset = "0x558CAE0", VA = "0x18558D6E0", Slot = "7")]
	public void DMFIPAONEJJ(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x558D9D0", Offset = "0x558CDD0", VA = "0x18558D9D0", Slot = "8")]
	public void LOIGBFPIIGA(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x558DA40", Offset = "0x558CE40", VA = "0x18558DA40", Slot = "11")]
	public void NCPFCGEECHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x558D750", Offset = "0x558CB50", VA = "0x18558D750")]
	private void FEICMNHAHJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x558DB70", Offset = "0x558CF70", VA = "0x18558DB70")]
	private void PBOKGMJLJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x558D710", Offset = "0x558CB10", VA = "0x18558D710", Slot = "10")]
	public void EPIMLABDGHA(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x558DA00", Offset = "0x558CE00", VA = "0x18558DA00", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x558F7A0", Offset = "0x558EBA0", VA = "0x18558F7A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IEnumerable<object> KPJACHNJINE
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x558F2E0", Offset = "0x558E6E0", VA = "0x18558F2E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event ONKEIMPDALF NKOIMHHPNOC
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x558F400", Offset = "0x558E800", VA = "0x18558F400", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x558F4A0", Offset = "0x558E8A0", VA = "0x18558F4A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x558F860", Offset = "0x558EC60", VA = "0x18558F860")]
	public NKGAJHDPEAL(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x558F340", Offset = "0x558E740", VA = "0x18558F340", Slot = "11")]
	public IDisposable ILBPDKJDBCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x558F6C0", Offset = "0x558EAC0", VA = "0x18558F6C0", Slot = "8")]
	public void OJMDMCDKKPE(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x558F330", Offset = "0x558E730", VA = "0x18558F330", Slot = "9")]
	public void FHDCOJAJODE(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x558F540", Offset = "0x558E940", VA = "0x18558F540", Slot = "10")]
	public void LAOHBPMFIPD(object JAKCBCDLMLB, bool FANMJAGAPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x558F640", Offset = "0x558EA40", VA = "0x18558F640", Slot = "12")]
	public void MIFKLLNLBMA(Rigidbody MMACFBGEFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x558F300", Offset = "0x558E700", VA = "0x18558F300", Slot = "13")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool DHECOBNPECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x556D730", Offset = "0x556CB30", VA = "0x18556D730", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool PGDDLMMJJIL
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x7D0FA0", Offset = "0x7D03A0", VA = "0x1807D0FA0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event ONKEIMPDALF BLJCHPILBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x556CEB0", Offset = "0x556C2B0", VA = "0x18556CEB0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x556D8D0", Offset = "0x556CCD0", VA = "0x18556D8D0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x556DAE0", Offset = "0x556CEE0", VA = "0x18556DAE0")]
	public ECLDGFPDPLI(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x556D360", Offset = "0x556C760", VA = "0x18556D360", Slot = "9")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x556D0D0", Offset = "0x556C4D0", VA = "0x18556D0D0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x556D1E0", Offset = "0x556C5E0", VA = "0x18556D1E0", Slot = "10")]
	public void GOBBLIKIBOC(PEMJBFLGGMM OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x556CF50", Offset = "0x556C350", VA = "0x18556CF50", Slot = "11")]
	public void DODGKOMIJNM(PEMJBFLGGMM OKMBLMILFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x556D750", Offset = "0x556CB50", VA = "0x18556D750")]
	private void MJKKJFIHOKF(PhotonView NGBCDGACPJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x556D970", Offset = "0x556CD70", VA = "0x18556D970")]
	private void PBGBNLJNCHB(RigidbodyEx CGFIDIJHMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x556D4B0", Offset = "0x556C8B0", VA = "0x18556D4B0")]
	private void IGOHCJNCMGO(PhotonView LIFCNEOPDDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class EBCOJEKIBBC
{
	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x556CDF0", Offset = "0x556C1F0", VA = "0x18556CDF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA62AF0", Offset = "0xA61EF0", VA = "0x180A62AF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x2603990", Offset = "0x2602D90", VA = "0x182603990", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool JMMGDKCOBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x26039A0", Offset = "0x2602DA0", VA = "0x1826039A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x2603960", Offset = "0x2602D60", VA = "0x182603960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public RigidbodyConstraints HLIGOHOAJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x6E1BD0", Offset = "0x6E0FD0", VA = "0x1806E1BD0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x5567440", Offset = "0x5566840", VA = "0x185567440", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x5567580", Offset = "0x5566980", VA = "0x185567580")]
	public AHEGFBGBFCO(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x5567410", Offset = "0x5566810", VA = "0x185567410", Slot = "9")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x55673E0", Offset = "0x55667E0", VA = "0x1855673E0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x12C8520", Offset = "0x12C7920", VA = "0x1812C8520", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x556A550", Offset = "0x5569950", VA = "0x18556A550", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public float GLPBFLLCCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x107A660", Offset = "0x1079A60", VA = "0x18107A660", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x556A6C0", Offset = "0x5569AC0", VA = "0x18556A6C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x556A7E0", Offset = "0x5569BE0", VA = "0x18556A7E0")]
	public CBIKEAEOOHF(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x556A790", Offset = "0x5569B90", VA = "0x18556A790", Slot = "8")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x556A620", Offset = "0x5569A20", VA = "0x18556A620", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x5569C10", Offset = "0x5569010", VA = "0x185569C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private bool IDEKOBKBJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x5569E20", Offset = "0x5569220", VA = "0x185569E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private bool CEEGNNLCJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x5569E00", Offset = "0x5569200", VA = "0x185569E00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private PEMJBFLGGMM AKKGLHPPJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x5569C60", Offset = "0x5569060", VA = "0x185569C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool OCODEBHAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x5569D60", Offset = "0x5569160", VA = "0x185569D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event ONKEIMPDALF HOLNOCHIGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x55695B0", Offset = "0x55689B0", VA = "0x1855695B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x5569CC0", Offset = "0x55690C0", VA = "0x185569CC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5569EC0", Offset = "0x55692C0", VA = "0x185569EC0")]
	public BBMKOGPAMPG(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5569B70", Offset = "0x5568F70", VA = "0x185569B70", Slot = "6")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5569C00", Offset = "0x5569000", VA = "0x185569C00", Slot = "8")]
	public void IGEMGMCLGIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x5569A20", Offset = "0x5568E20", VA = "0x185569A20", Slot = "7")]
	public bool GOBGGIIBKON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x55691D0", Offset = "0x55685D0", VA = "0x1855691D0", Slot = "9")]
	public void AMHGNHLMFNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x5569980", Offset = "0x5568D80", VA = "0x185569980", Slot = "11")]
	public void GKCJECCPPNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5569DC0", Offset = "0x55691C0", VA = "0x185569DC0", Slot = "12")]
	public void MOPGLEDKLOM(bool NBPKMHPMALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5569650", Offset = "0x5568A50", VA = "0x185569650", Slot = "10")]
	public void EKFBEOFALEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x5569270", Offset = "0x5568670", VA = "0x185569270")]
	private bool CNCFDBKEHJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x5569420", Offset = "0x5568820", VA = "0x185569420")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6E0530", VA = "0x1806E1130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private bool OCODEBHAHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x5568C20", Offset = "0x5568020", VA = "0x185568C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x556C0B0", Offset = "0x556B4B0", VA = "0x18556C0B0")]
	public DEKKDKDKGHO(PEMJBFLGGMM LKMGIJIPLIN, in IKIHJJFFHFA FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x556BAC0", Offset = "0x556AEC0", VA = "0x18556BAC0", Slot = "5")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x556B2C0", Offset = "0x556A6C0", VA = "0x18556B2C0", Slot = "6")]
	public void BNFFEJKELLJ(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x556C080", Offset = "0x556B480", VA = "0x18556C080", Slot = "7")]
	public void LAIPLJBIIOF(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x556BB70", Offset = "0x556AF70", VA = "0x18556BB70", Slot = "8")]
	public void ICGPBGLDJFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x556B0C0", Offset = "0x556A4C0", VA = "0x18556B0C0", Slot = "9")]
	public void BBBNKDJHOPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x556B4A0", Offset = "0x556A8A0", VA = "0x18556B4A0", Slot = "10")]
	public void GOGONJBMCAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x556B620", Offset = "0x556AA20", VA = "0x18556B620", Slot = "11")]
	public void HDCHMOLMOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x556B2F0", Offset = "0x556A6F0", VA = "0x18556B2F0")]
	private void GMMEAGCIGJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x556BED0", Offset = "0x556B2D0", VA = "0x18556BED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FA8E0", Offset = "0x6F9CE0", VA = "0x1806FA8E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x722210", Offset = "0x721610", VA = "0x180722210", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public GGBMPGNAFJD OPABPNIHPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x6F66F0", Offset = "0x6F5AF0", VA = "0x1806F66F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x778B00", Offset = "0x777F00", VA = "0x180778B00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public Vector3 LCNCCKHCPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x556F140", Offset = "0x556E540", VA = "0x18556F140", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x5570350", Offset = "0x556F750", VA = "0x185570350", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public Vector3 AHAJMJBMMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x556FD90", Offset = "0x556F190", VA = "0x18556FD90", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x5571AB0", Offset = "0x5570EB0", VA = "0x185571AB0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 JLGHJOIMMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x556F530", Offset = "0x556E930", VA = "0x18556F530", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x55712B0", Offset = "0x55706B0", VA = "0x1855712B0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public Vector3 HBNCABOKHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x5571550", Offset = "0x5570950", VA = "0x185571550", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x55702B0", Offset = "0x556F6B0", VA = "0x1855702B0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public float FCAAJGFAJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x10231E0", Offset = "0x10225E0", VA = "0x1810231E0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x5570810", Offset = "0x556FC10", VA = "0x185570810", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public bool ACGMNKMENFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x207D810", Offset = "0x207CC10", VA = "0x18207D810", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private EBDBHLCOCAL AONNGMAKJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x1A07060", Offset = "0x1A06460", VA = "0x181A07060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private bool CEEGNNLCJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x556EA70", Offset = "0x556DE70", VA = "0x18556EA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x5571AE0", Offset = "0x5570EE0", VA = "0x185571AE0")]
	public EECKBIDCJML(PEMJBFLGGMM LKMGIJIPLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x55702E0", Offset = "0x556F6E0", VA = "0x1855702E0", Slot = "19")]
	public void IBMMKMLPEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x556FD30", Offset = "0x556F130", VA = "0x18556FD30", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x5571180", Offset = "0x5570580", VA = "0x185571180", Slot = "28")]
	public void MIFKLLNLBMA(Rigidbody BEMEPNIHEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0xF643C0", Offset = "0xF637C0", VA = "0x180F643C0", Slot = "20")]
	public void FOJGNOFNCLG(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0xF64F10", Offset = "0xF64310", VA = "0x180F64F10", Slot = "31")]
	public void EJPJLNDPFPP(object JAKCBCDLMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x556ED30", Offset = "0x556E130", VA = "0x18556ED30", Slot = "36")]
	public Vector3 ABHOGLBBGMA(Vector3 HFELIOHGGDO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x55700F0", Offset = "0x556F4F0", VA = "0x1855700F0", Slot = "35")]
	public Vector3 GNEKHGHFGKA(Vector3 FEAFOIFGCCF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x55702E0", Offset = "0x556F6E0", VA = "0x1855702E0", Slot = "27")]
	public void IIPKPIBFBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x556FF70", Offset = "0x556F370", VA = "0x18556FF70", Slot = "25")]
	public void GJGKIDGKPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x556FCF0", Offset = "0x556F0F0", VA = "0x18556FCF0", Slot = "24")]
	public void CMHHFMOHFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x556FAB0", Offset = "0x556EEB0", VA = "0x18556FAB0", Slot = "34")]
	public void CJHODKMAJBE(Vector3 OLJIPBFJCBL, Vector3 CJANALIFPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5570F30", Offset = "0x5570330", VA = "0x185570F30", Slot = "33")]
	public void LICDBAEOAFD(Vector3 OABJFLBJEKB, Vector3 IMCNKNPLDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x556FFB0", Offset = "0x556F3B0", VA = "0x18556FFB0", Slot = "32")]
	public void GMEDHCFFMEH(Vector3 ANJGHBFDIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x556F660", Offset = "0x556EA60", VA = "0x18556F660", Slot = "22")]
	public void CBOAGHDBPJH(OBJOKHNKAPP CAMLNFGKHFE, Vector3 MAIIDBKHIED, float JOFBEKECLOD, float CLOJEHHLDHC = 8f, float ILPINEMCFMP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x556EF10", Offset = "0x556E310", VA = "0x18556EF10", Slot = "21")]
	public void AFOBMMCCHIM(EKKHOJNPNMO PNJHOCPNCML, Vector3 NFNPPPGADBK, float MMIALNFHMCC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x556F260", Offset = "0x556E660", VA = "0x18556F260", Slot = "23")]
	[Obsolete]
	public void BMPJNHFGFFL(EKKHOJNPNMO PNJHOCPNCML, Vector3 OLBDAPNGDPL, float CEIPLLMFOOE = 7f, float OGLOAGFEIHM = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x5570410", Offset = "0x556F810", VA = "0x185570410", Slot = "30")]
	public Vector3 IDKDPPMOKNN(Vector3 FJHEIJDCBEJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x5571370", Offset = "0x5570770", VA = "0x185571370", Slot = "29")]
	public Vector3 NOILBEMLPLM(Vector3 BAMHFNACLOC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x5571050", Offset = "0x5570450", VA = "0x185571050", Slot = "26")]
	public void MDDKFEEINFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x5570810", Offset = "0x556FC10", VA = "0x185570810")]
	private void JCFEOFGMADC(float KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x5571640", Offset = "0x5570A40", VA = "0x185571640")]
	private void PANKLFBIFGF(Vector3 NFNPPPGADBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x5571460", Offset = "0x5570860", VA = "0x185571460")]
	private Vector3 OICADJOPIOK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x5571780", Offset = "0x5570B80", VA = "0x185571780")]
	private void PLMCKOJFMKL(Vector3 FEAFOIFGCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x556FE80", Offset = "0x556F280", VA = "0x18556FE80")]
	private Vector3 FDMJOFIOEHO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x55704D0", Offset = "0x556F8D0", VA = "0x1855704D0")]
	private void INELDJICPMM(Vector3 KPPLMEOMNGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x5570930", Offset = "0x556FD30", VA = "0x185570930")]
	private void KBIABBAPIJA(Vector3 FEAFOIFGCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x5570F90", Offset = "0x5570390", VA = "0x185570F90")]
	private void LICLOKPCMOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class LGFBDCBNIPC : HMOFCBOHILL
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x558C320", Offset = "0x558B720", VA = "0x18558C320", Slot = "4")]
	public KOFIFPKBGDE HPMJMPJAEBF(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x558BE90", Offset = "0x558B290", VA = "0x18558BE90", Slot = "5")]
	public IGHPKHJEAKK ELGDCBJCMFN(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x558C520", Offset = "0x558B920", VA = "0x18558C520", Slot = "6")]
	public DOLOBBHOJCN JPOHICNGBBP(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x558C630", Offset = "0x558BA30", VA = "0x18558C630", Slot = "7")]
	public BEGCJHEKPFH KCHPJLDNMCG(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x558C750", Offset = "0x558BB50", VA = "0x18558C750", Slot = "8")]
	public FEJPDKKHHEB LNKOELKMANO(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x558C8E0", Offset = "0x558BCE0", VA = "0x18558C8E0", Slot = "9")]
	public CCMAIABHGHM OKIKOAODBKA(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x558BFA0", Offset = "0x558B3A0", VA = "0x18558BFA0", Slot = "10")]
	public KJKCPGCAIML GBFBEIIDFCA(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x558C0A0", Offset = "0x558B4A0", VA = "0x18558C0A0", Slot = "11")]
	public EBDBHLCOCAL GJGOKLOIGBN(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x558C6A0", Offset = "0x558BAA0", VA = "0x18558C6A0", Slot = "12")]
	public AHAFDFAMMOI LHOEKHPMJKM(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x558C270", Offset = "0x558B670", VA = "0x18558C270", Slot = "13")]
	public COEGLBKNHNL HLENLHEFFLE(PEMJBFLGGMM DNGPHMONFKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x558C150", Offset = "0x558B550", VA = "0x18558C150")]
	public BJEGJOOAAHN HLAKIFBKGOD(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x558C810", Offset = "0x558BC10", VA = "0x18558C810")]
	public AEHNOIOGGNB PFOFCHGKLBD(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x558C400", Offset = "0x558B800", VA = "0x18558C400")]
	public FAMFIMIKKAN JOJCEHJOGPP(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x558BD90", Offset = "0x558B190", VA = "0x18558BD90")]
	public DPAGPKHBGMK DBPGDMNKLJL(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x558BC10", Offset = "0x558B010", VA = "0x18558BC10")]
	public MNOPDMEBLBE KCDDEIIAPGE(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x558BCE0", Offset = "0x558B0E0", VA = "0x18558BCE0", Slot = "19")]
	public PEMJBFLGGMM BBMPNOCKHLJ(RigidbodyEx LKMGIJIPLIN, IKIHJJFFHFA FNIHENPLJHK, OOMBAIEJEBP CBBILOOJOAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public LGFBDCBNIPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x558C150", Offset = "0x558B550", VA = "0x18558C150", Slot = "14")]
	private BJEGJOOAAHN NGEGFJLNLMF(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x558C810", Offset = "0x558BC10", VA = "0x18558C810", Slot = "15")]
	private AEHNOIOGGNB NKLPIGOJNFO(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x558C400", Offset = "0x558B800", VA = "0x18558C400", Slot = "16")]
	private FAMFIMIKKAN JEMOMHAJBJM(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x558BD90", Offset = "0x558B190", VA = "0x18558BD90", Slot = "17")]
	private DPAGPKHBGMK INHHAPJMGIP(PEMJBFLGGMM DNGPHMONFKM, in IKIHJJFFHFA FNIHENPLJHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x558BC10", Offset = "0x558B010", VA = "0x18558BC10", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B40", Offset = "0x6E0F40", VA = "0x1806E1B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x669A630", Offset = "0x6699A30", VA = "0x18669A630", Slot = "6")]
		public sealed override void LDHMAOMPMOJ(JNCGCMMLAKP PEPHBHFBJFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x669A5A0", Offset = "0x66999A0", VA = "0x18669A5A0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
	public HFBMMEPCDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x557E160", Offset = "0x557D560", VA = "0x18557E160")]
	private static string AEHPCHKGFJE(byte[] ICPOAGANOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x557E270", Offset = "0x557D670", VA = "0x18557E270")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
