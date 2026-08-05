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
internal class CGKLGLBEDEH
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public const string KNAGCOJIEDC = "RBEX_DEFAULT";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const float JFEIMDCKMLF = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public const float JMDPLMHLGKM = 0f;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public const float GHCABINHHBB = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public CGKLGLBEDEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void DGAAFHCPHEH(RigidbodyEx EJMCJKCJMNM);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void MKKJLKCGEAC(RigidbodyEx EJMCJKCJMNM, bool OMIKAFGHIFK = false);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum EECECFKKEJP
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum GHELGGICJHJ
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum JDHBHPOMECG
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IPOIOPLAADG : KKMENLLDAPN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MEHIPKALLPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x727020", Offset = "0x725A20", VA = "0x180727020", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DMEAPIODOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7270E0", Offset = "0x725AE0", VA = "0x1807270E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72B5A0", Offset = "0x729FA0", VA = "0x18072B5A0", Slot = "6")]
	public FCDCKNBKJML NGPFGLFICJL(float FLFEPFNINBJ)
	{
		return default(FCDCKNBKJML);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "7")]
	public void AGMLDLCGDGN(FLCKAICBODN NBNOMDAKOCG, float KHPBNPIIPMK, FJJLEAMIEBC GFECCLMJIJB = FJJLEAMIEBC.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "8")]
	public void AGMLDLCGDGN(FLCKAICBODN NBNOMDAKOCG, Transform NNNEKOPBKOD, float KHPBNPIIPMK, FJJLEAMIEBC GFECCLMJIJB = FJJLEAMIEBC.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "9")]
	public void BKNMIOLEDCJ(FLCKAICBODN NBNOMDAKOCG, [Optional] float? KHPBNPIIPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "10")]
	public void FJEBMLODAAK(FLCKAICBODN LILGPDENNHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x72B5A0", Offset = "0x729FA0", VA = "0x18072B5A0", Slot = "11")]
	public FCDCKNBKJML BBCJDADENAF(FLCKAICBODN NBNOMDAKOCG)
	{
		return default(FCDCKNBKJML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7319E0", Offset = "0x7303E0", VA = "0x1807319E0", Slot = "12")]
	public bool FJJDFBCKGOK(FLCKAICBODN NBNOMDAKOCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "13")]
	public void LJMKICNDLAI(FLCKAICBODN NBNOMDAKOCG, FJJLEAMIEBC GEIMPLCDGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public IPOIOPLAADG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[HAMPPOKOPOP(typeof(IGHAJODIIKL), new string[] { "Ignore", "Mock" })]
public class PMJPOIOGLBC : IGHAJODIIKL
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BIAKKCIGCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x754640", Offset = "0x753040", VA = "0x180754640", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
	public void IKKAAMCDFCC(string NOGDNAGMMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "6")]
	public void FHNGJIOABHC(RigidbodyEx IILFNNEDNCJ, Action DAAMKALKLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x72B5A0", Offset = "0x729FA0", VA = "0x18072B5A0", Slot = "7")]
	public KKMENLLDAPN GNGDKHBAKPP(int IBKOPKJJILA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "8")]
	public void CFFENDALNLG(Vector3 HNGOLMBMNBC, float PLDCHDPKEGB, Color HAFGGBNGKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public PMJPOIOGLBC()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool IIBFOCPMDPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private NCOEFPHLCKK DEJCFCAINJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[DOHNIIAADJA(DIMAPHHKBON.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[DOHNIIAADJA(DIMAPHHKBON.SelfAndParent, true, false, false)]
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
		private GHELGGICJHJ physicsInterpolation;

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
		internal NCOEFPHLCKK EOOOGHAIOAE
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6980270", Offset = "0x697EC70", VA = "0x186980270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<RigidbodyEx> PHPDFDJEEEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7270B0", Offset = "0x725AB0", VA = "0x1807270B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7B2610", Offset = "0x7B1010", VA = "0x1807B2610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx GNACMJCGFII
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6981B00", Offset = "0x6980500", VA = "0x186981B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx CMJKBCMDGHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6981AA0", Offset = "0x69804A0", VA = "0x186981AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public RigidbodyEx GGEKFPEBLKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6982660", Offset = "0x6981060", VA = "0x186982660")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6983DB0", Offset = "0x69827B0", VA = "0x186983DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform KMDNPAAIEIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x122D2C0", Offset = "0x122BCC0", VA = "0x18122D2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform FNPJMEGGLFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x122D2C0", Offset = "0x122BCC0", VA = "0x18122D2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public FJJLEAMIEBC LEKOFMMMFBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6981790", Offset = "0x6980190", VA = "0x186981790")]
			get
			{
				return default(FJJLEAMIEBC);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6983350", Offset = "0x6981D50", VA = "0x186983350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool BBHAHOHMEPG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6981D10", Offset = "0x6980710", VA = "0x186981D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool MPDIPBBGKKB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6981920", Offset = "0x6980320", VA = "0x186981920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public EKLLOLLHLDP LNMCPLFHCHG
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6981CB0", Offset = "0x69806B0", VA = "0x186981CB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6983560", Offset = "0x6981F60", VA = "0x186983560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public CHACNCJIDJM GJHPEGFOAME
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6981C50", Offset = "0x6980650", VA = "0x186981C50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x69834F0", Offset = "0x6981EF0", VA = "0x1869834F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool LIGEJEKODFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6981B30", Offset = "0x6980530", VA = "0x186981B30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Rigidbody LNMDHFKNJIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6981B90", Offset = "0x6980590", VA = "0x186981B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool KHDKIPLIJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x69819E0", Offset = "0x69803E0", VA = "0x1869819E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6983410", Offset = "0x6981E10", VA = "0x186983410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool GFGJJPEPNGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x33E9400", Offset = "0x33E7E00", VA = "0x1833E9400")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x33E9410", Offset = "0x33E7E10", VA = "0x1833E9410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float NJAPMMIKJGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6982600", Offset = "0x6981000", VA = "0x186982600")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float BJEKPKOHOHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x69825A0", Offset = "0x6980FA0", VA = "0x1869825A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6983D40", Offset = "0x6982740", VA = "0x186983D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float NKICPJKJIPG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6981F70", Offset = "0x6980970", VA = "0x186981F70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6983800", Offset = "0x6982200", VA = "0x186983800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float KJIENHELDBA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6981D70", Offset = "0x6980770", VA = "0x186981D70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x69835D0", Offset = "0x6981FD0", VA = "0x1869835D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool ECEFGAGMMPK
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6982B80", Offset = "0x6981580", VA = "0x186982B80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x69842F0", Offset = "0x6982CF0", VA = "0x1869842F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 GMBCHMBJMEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6982380", Offset = "0x6980D80", VA = "0x186982380")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6983B10", Offset = "0x6982510", VA = "0x186983B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 HNGOLMBMNBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6982CC0", Offset = "0x69816C0", VA = "0x186982CC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CollisionDetectionMode ABODELJNHAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6981EB0", Offset = "0x69808B0", VA = "0x186981EB0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6983720", Offset = "0x6982120", VA = "0x186983720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float KKALKPOINCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6981A40", Offset = "0x6980440", VA = "0x186981A40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6983480", Offset = "0x6981E80", VA = "0x186983480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public RigidbodyConstraints JBGLIGODAKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6981F10", Offset = "0x6980910", VA = "0x186981F10")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6983790", Offset = "0x6982190", VA = "0x186983790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 FPBCPCJIICN
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x69826C0", Offset = "0x69810C0", VA = "0x1869826C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 LJOBCKOOBEG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x69826C0", Offset = "0x69810C0", VA = "0x1869826C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x69840C0", Offset = "0x6982AC0", VA = "0x1869840C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float KAKBMDMPBAD
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6982460", Offset = "0x6980E60", VA = "0x186982460")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6983BF0", Offset = "0x69825F0", VA = "0x186983BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float NKEPFBEFOJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6982B20", Offset = "0x6981520", VA = "0x186982B20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6984280", Offset = "0x6982C80", VA = "0x186984280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion LBCAFAOMOKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x69827A0", Offset = "0x69811A0", VA = "0x1869827A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6983E20", Offset = "0x6982820", VA = "0x186983E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion JNAFAGHBKBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6982A40", Offset = "0x6981440", VA = "0x186982A40")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x69841A0", Offset = "0x6982BA0", VA = "0x1869841A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 CJJCECBKAHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6982880", Offset = "0x6981280", VA = "0x186982880")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6983F00", Offset = "0x6982900", VA = "0x186983F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Quaternion EMABLKCADLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6982960", Offset = "0x6981360", VA = "0x186982960")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6983FE0", Offset = "0x69829E0", VA = "0x186983FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 GCAABCBBBAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6982BE0", Offset = "0x69815E0", VA = "0x186982BE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6984360", Offset = "0x6982D60", VA = "0x186984360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 HMPFDEAFPND
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x69824C0", Offset = "0x6980EC0", VA = "0x1869824C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6983C60", Offset = "0x6982660", VA = "0x186983C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 DIIFLOBFBLO
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6981DD0", Offset = "0x69807D0", VA = "0x186981DD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6983640", Offset = "0x6982040", VA = "0x186983640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 FHFHNDANMPN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x69822A0", Offset = "0x6980CA0", VA = "0x1869822A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6983A30", Offset = "0x6982430", VA = "0x186983A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 OLICLKGPABG
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6982160", Offset = "0x6980B60", VA = "0x186982160")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6983950", Offset = "0x6982350", VA = "0x186983950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Quaternion AIDBIHPFFIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6982080", Offset = "0x6980A80", VA = "0x186982080")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6983870", Offset = "0x6982270", VA = "0x186983870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 EPBCMIAGOAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6982E80", Offset = "0x6981880", VA = "0x186982E80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 POPFEKPNEIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6982DA0", Offset = "0x69817A0", VA = "0x186982DA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool OJNHEHLGDGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x6982240", Offset = "0x6980C40", VA = "0x186982240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool LFGDELENJCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6981980", Offset = "0x6980380", VA = "0x186981980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool NHCAAMEDKKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x69818C0", Offset = "0x69802C0", VA = "0x1869818C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool GDCCIECOAEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6981860", Offset = "0x6980260", VA = "0x186981860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool ABAINBEINAC
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6981730", Offset = "0x6980130", VA = "0x186981730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool PEMBAGILPPO
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6981FD0", Offset = "0x69809D0", VA = "0x186981FD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool CDOMMGFPCNB
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7A90D0", Offset = "0x7A7AD0", VA = "0x1807A90D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event DGAAFHCPHEH LAFMHICCNNB
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6981650", Offset = "0x6980050", VA = "0x186981650")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6983270", Offset = "0x6981C70", VA = "0x186983270")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event MKKJLKCGEAC NPFLEBOEALL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x69815E0", Offset = "0x697FFE0", VA = "0x1869815E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6983200", Offset = "0x6981C00", VA = "0x186983200")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event DGAAFHCPHEH NJJHHELIHIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6981340", Offset = "0x697FD40", VA = "0x186981340")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6982F60", Offset = "0x6981960", VA = "0x186982F60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event DGAAFHCPHEH EPBNCIPAFDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x69813B0", Offset = "0x697FDB0", VA = "0x1869813B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6982FD0", Offset = "0x69819D0", VA = "0x186982FD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event DGAAFHCPHEH DHIFCNEILML
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6981500", Offset = "0x697FF00", VA = "0x186981500")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6983120", Offset = "0x6981B20", VA = "0x186983120")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<FCDCKNBKJML, FCDCKNBKJML> DLLBDKMMJIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6981490", Offset = "0x697FE90", VA = "0x186981490")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x69830B0", Offset = "0x6981AB0", VA = "0x1869830B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event DGAAFHCPHEH CJGCBPJLDJA
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6981570", Offset = "0x697FF70", VA = "0x186981570")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6983190", Offset = "0x6981B90", VA = "0x186983190")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event DGAAFHCPHEH OPFMBHBCCBN
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x69816C0", Offset = "0x69800C0", VA = "0x1869816C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x69832E0", Offset = "0x6981CE0", VA = "0x1869832E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event DGAAFHCPHEH MGPMCLDJCJA
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6981420", Offset = "0x697FE20", VA = "0x186981420")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6983040", Offset = "0x6981A40", VA = "0x186983040")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x74C3F0", Offset = "0x74ADF0", VA = "0x18074C3F0")]
		internal void HCALOHKNMHJ(NCOEFPHLCKK NLKDOMNEDBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x69801E0", Offset = "0x697EBE0", VA = "0x1869801E0")]
		internal void IAGILEKBKIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6981090", Offset = "0x697FA90", VA = "0x186981090")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody EGFCGGBAJBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x697F940", Offset = "0x697E340", VA = "0x18697F940")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6980270", Offset = "0x697EC70", VA = "0x186980270")]
		private NCOEFPHLCKK KBFEBNIJONE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x697FC50", Offset = "0x697E650", VA = "0x18697FC50")]
		private void GJPLHHGHDFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x69805D0", Offset = "0x697EFD0", VA = "0x1869805D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6980560", Offset = "0x697EF60", VA = "0x186980560")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x697FBF0", Offset = "0x697E5F0", VA = "0x18697FBF0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6980570", Offset = "0x697EF70", VA = "0x186980570")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6980630", Offset = "0x697F030", VA = "0x186980630")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x697EFD0", Offset = "0x697D9D0", VA = "0x18697EFD0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x69806A0", Offset = "0x697F0A0", VA = "0x1869806A0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x697FB90", Offset = "0x697E590", VA = "0x18697FB90")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6980500", Offset = "0x697EF00", VA = "0x186980500")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6980E90", Offset = "0x697F890", VA = "0x186980E90")]
		public void SetParent(RigidbodyEx LPJDDLMPNCG, bool OMIKAFGHIFK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69809B0", Offset = "0x697F3B0", VA = "0x1869809B0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6980320", Offset = "0x697ED20", VA = "0x186980320")]
		public bool IsRigidbodyAncestor(RigidbodyEx FMPADABIBEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6980360", Offset = "0x697ED60", VA = "0x186980360")]
		public bool IsRigidbodyDescendant(RigidbodyEx BOAHBOBCIFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x697F1F0", Offset = "0x697DBF0", VA = "0x18697F1F0")]
		public void AddInterpolationRestriction(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6980710", Offset = "0x697F110", VA = "0x186980710")]
		public void RemoveInterpolationRestriction(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x697F9B0", Offset = "0x697E3B0", VA = "0x18697F9B0")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x697F260", Offset = "0x697DC60", VA = "0x18697F260")]
		public void AddKinematic(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6980780", Offset = "0x697F180", VA = "0x186980780")]
		public void RemoveKinematic(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6980E10", Offset = "0x697F810", VA = "0x186980E10")]
		public void SetKinematic(object MIFCLBEAOPM, bool KLMBPMINIHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6980D10", Offset = "0x697F710", VA = "0x186980D10")]
		public void SetDiscontinuousPositionAndRotation(Vector3 PGJOODJOMAI, Quaternion OMJBPOHHBNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6980C10", Offset = "0x697F610", VA = "0x186980C10")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 PPNOLBKPBJH, Quaternion KAHANPFONLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x69800E0", Offset = "0x697EAE0", VA = "0x1869800E0")]
		public Vector3 GetConstrainedVelocity(Vector3 GCAABCBBBAL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x697FFE0", Offset = "0x697E9E0", VA = "0x18697FFE0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 DIIFLOBFBLO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x697F160", Offset = "0x697DB60", VA = "0x18697F160")]
		public void AddForce(Vector3 HKPPDHFDHMN, ForceMode MPMGBCACKOF = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x697F040", Offset = "0x697DA40", VA = "0x18697F040")]
		public void AddForceAtPosition(Vector3 HKPPDHFDHMN, Vector3 PICDPPHNNLH, ForceMode MPMGBCACKOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x697F360", Offset = "0x697DD60", VA = "0x18697F360")]
		public void AddTorque(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x697F2D0", Offset = "0x697DCD0", VA = "0x18697F2D0")]
		public void AddRelativeTorque(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6981170", Offset = "0x697FB70", VA = "0x186981170")]
		public Vector3 WorldToLocalVelocity(Vector3 JOJEMOKKGPP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6980400", Offset = "0x697EE00", VA = "0x186980400")]
		public Vector3 LocalToWorldVelocity(Vector3 HMPFDEAFPND)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x697FB30", Offset = "0x697E530", VA = "0x18697FB30")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x697FAD0", Offset = "0x697E4D0", VA = "0x18697FAD0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x697FA70", Offset = "0x697E470", VA = "0x18697FA70")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x697FA10", Offset = "0x697E410", VA = "0x18697FA10")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6980B10", Offset = "0x697F510", VA = "0x186980B10")]
		public void ResetVelocityWorldSpace(Vector3 GKKEEHNMPBL, Vector3 NFGPCLPNMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6980A10", Offset = "0x697F410", VA = "0x186980A10")]
		public void ResetVelocityLocalSpace(Vector3 FHKLDEIKECB, Vector3 FHFHNDANMPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x69808D0", Offset = "0x697F2D0", VA = "0x1869808D0")]
		public void ResetLinearVelocityLocalSpace(Vector3 FHKLDEIKECB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6980F80", Offset = "0x697F980", VA = "0x186980F80")]
		public bool SweepTest(Vector3 MFKKMPGAJFI, out RaycastHit ONOMCDOFLKH, float CBFODBDKBEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x69803A0", Offset = "0x697EDA0", VA = "0x1869803A0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6980F20", Offset = "0x697F920", VA = "0x186980F20")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6981110", Offset = "0x697FB10", VA = "0x186981110")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x697F3F0", Offset = "0x697DDF0", VA = "0x18697F3F0")]
		public void AddUnityRigidbody(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x69807F0", Offset = "0x697F1F0", VA = "0x1869807F0")]
		public void RemoveUnityRigidbody(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x697F710", Offset = "0x697E110", VA = "0x18697F710")]
		public void ApplyForceVelocityChange(EECECFKKEJP KMDODPJBKLE, Vector3 CFLMAEMNHKL, float ABGPHLFIFAO, float OPCFMELHIKJ = 8f, float ECOHALOPPDN = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x697F610", Offset = "0x697E010", VA = "0x18697F610")]
		public void ApplyAngularVelocityChange(JDHBHPOMECG EFAKAOJPAJJ, Vector3 PKAJMBKNJIL, float KBLOKDLNEPD = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x697F830", Offset = "0x697E230", VA = "0x18697F830")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(JDHBHPOMECG EFAKAOJPAJJ, Vector3 IHCJBCJFELL, float MEJPNNANPLH = 7f, float CKIIILKMBKK = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x697F550", Offset = "0x697DF50", VA = "0x18697F550")]
		public bool AllowedScaleChange(float ANPGDIDDDCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x697F460", Offset = "0x697DE60", VA = "0x18697F460")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx BKGBHBNCDJA, object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6980860", Offset = "0x697F260", VA = "0x186980860")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object MIFCLBEAOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x69812C0", Offset = "0x697FCC0", VA = "0x1869812C0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class BBBFCONGDJG
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5737300", Offset = "0x5735D00", VA = "0x185737300")]
	public static NCOEFPHLCKK EOOOGHAIOAE(this RigidbodyEx IILFNNEDNCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JCAJMGPJNDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Rigidbody GHAGIOLHPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PhotonView NIHEFIPHFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 OCCIBCJMCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OverridableVector3 DDBDFGDEJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public GHELGGICJHJ FAACPMLGAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool DDHEKPKMKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool LAHEKDPLCHD;
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	[HAMPPOKOPOP(typeof(BKDMDHLJAEJ), new string[] { })]
	public class RigidbodyExManager : BKDMDHLJAEJ, GBCNOEIKEOL
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private LPHNFCPFJBF KHKOGBBOGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private IGHAJODIIKL NOHGMFJPJKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private CCKADDACLBD OHBNFBFIMDH;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool FNDECKOCKHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x697EAA0", Offset = "0x697D4A0", VA = "0x18697EAA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IGHAJODIIKL CLPKFOJNNAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public CCKADDACLBD BLIAEGBHDHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x697EAF0", Offset = "0x697D4F0", VA = "0x18697EAF0", Slot = "12")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x697E7D0", Offset = "0x697D1D0", VA = "0x18697E7D0", Slot = "7")]
		public MBEDCJLMHEO EGHEGCMJHNL(RigidbodyEx IILFNNEDNCJ)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x697ED40", Offset = "0x697D740", VA = "0x18697ED40")]
		private static MBEDCJLMHEO KGBJFPMJCDH(RigidbodyEx IILFNNEDNCJ)
		{
			return default(MBEDCJLMHEO);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x697E6C0", Offset = "0x697D0C0", VA = "0x18697E6C0", Slot = "8")]
		public NCOEFPHLCKK APMJEHJBGBJ(RigidbodyEx IILFNNEDNCJ, JCAJMGPJNDN HIDEHJGLNHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x697EC70", Offset = "0x697D670", VA = "0x18697EC70", Slot = "11")]
		private RigidbodyEx JMJIAGGMHNE(GameObject JNONJGMFMNE, JCAJMGPJNDN HIDEHJGLNHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x697EB80", Offset = "0x697D580", VA = "0x18697EB80", Slot = "9")]
		public void HHEKJCFELLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x697EE30", Offset = "0x697D830", VA = "0x18697EE30", Slot = "10")]
		public void KLDDNNLENKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static FNCKCCFNKKK UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int OOPAFJLGBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int OIIFCLJENMH;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x697E1A0", Offset = "0x697CBA0", VA = "0x18697E1A0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x697E1E0", Offset = "0x697CBE0", VA = "0x18697E1E0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x697E1C0", Offset = "0x697CBC0", VA = "0x18697E1C0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string BALNMHDNCIN, [Optional] UnityEngine.Object PKDAKJPDDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string BALNMHDNCIN, [Optional] UnityEngine.Object PKDAKJPDDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x697E2D0", Offset = "0x697CCD0", VA = "0x18697E2D0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PHMLDHNALOO
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5757B80", Offset = "0x5756580", VA = "0x185757B80")]
	public static void BCLGFNINKDD(this Rigidbody EGFCGGBAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5757CD0", Offset = "0x57566D0", VA = "0x185757CD0")]
	public static void BCLGFNINKDD(this Rigidbody EGFCGGBAJBP, Vector3 OLICLKGPABG, Quaternion AIDBIHPFFIK, Vector3 HLNEMANOIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5757DE0", Offset = "0x57567E0", VA = "0x185757DE0")]
	public static void OKDHENJIFKE(Vector3 GCAABCBBBAL, Vector3 GCGCIPKJGGG, out Vector3 KIIINPINNOD, out Vector3 CJCBDLFPJNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class MMMNNNGIGIF
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class NCFKAKBGHGE : EKLLOLLHLDP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1293A80", Offset = "0x1292480", VA = "0x181293A80", Slot = "4")]
		public Vector3 BOHCGEJKGNK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x1293A80", Offset = "0x1292480", VA = "0x181293A80", Slot = "5")]
		public Vector3 BGJJOBCDBBC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public NCFKAKBGHGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static EKLLOLLHLDP PGFHPADKEGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5751260", Offset = "0x574FC60", VA = "0x185751260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AIOOGANOGPH
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode PAOOKBBFCLK
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
	void PBJONABJOBO();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DLGGDMCBIHM(bool OJNHEHLGDGI);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FICHJHCOBIG(bool OJNHEHLGDGI);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OFDKFHJBLOJ(Vector3 MFKKMPGAJFI, out RaycastHit ONOMCDOFLKH, float CBFODBDKBEK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JBCOLILENLD : IDisposable, FLCKAICBODN
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GGPABLKNBJB LEKOFMMMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<FCDCKNBKJML, FCDCKNBKJML> DLLBDKMMJIP;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBJONABJOBO();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DCBDIJCKLAD(IKIGKMLBEFF.Application)]
public interface CCKADDACLBD
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PLDJMDIFCKE HPIEMLILMFL(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ODMDEDICELM IINCPPFHAME(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IMBEMHENMNJ MOJGNMKJFLF(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CAONNBLCKEG ILCPDNKDAKJ(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EIMJIHNCMHI KJNNEGNLPCG(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JBCOLILENLD JDEHAKBEPFB(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KGDABPANOEG CLMAKHLOHMN(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BDJOPHNNEJG LAGKMHIIGOF(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AIOOGANOGPH JNMPFOJECMI(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BBGAPPNBFLO DPGNNNONAOD(NCOEFPHLCKK NLKDOMNEDBE);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IPANMLAMAAD MNBKDOEPCLE(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	INNKCACPKLA HPGHLDDNEHH(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LBPABMNHAKF OCGJAPKHCOA(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OGBLFJOOHEI BMJLAHFILLO(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IKFALNBDADN KIKLIMOCIDB(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "15")]
	NCOEFPHLCKK APMJEHJBGBJ(RigidbodyEx IILFNNEDNCJ, JCAJMGPJNDN HIDEHJGLNHO, BKDMDHLJAEJ CMIHNHHBGOO);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BDJOPHNNEJG
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BEJNHGKJNLM(Vector3 HKPPDHFDHMN, ForceMode MPMGBCACKOF = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBMEMNKKLDE(Vector3 HKPPDHFDHMN, Vector3 PICDPPHNNLH, ForceMode MPMGBCACKOF);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OHNHDPGFLAC(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PPDGHDJCFAP(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BBGAPPNBFLO
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool OGIIANAEIFL
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
	void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PLDJMDIFCKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<NCOEFPHLCKK> PHPDFDJEEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	NCOEFPHLCKK CMJKBCMDGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event DGAAFHCPHEH NJJHHELIHIP;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event DGAAFHCPHEH EPBNCIPAFDB;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event MKKJLKCGEAC EIBHEHIGCNB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action PFANGAANPGN;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action NJGCKLJKCAG;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<NCOEFPHLCKK> NFDMKCEEBKO;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<NCOEFPHLCKK> AMBCDPFGEAJ;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action KKKJMJHLIKB;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<NCOEFPHLCKK> PFJIOBMDLAL;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DEIBNNOCJKC(NCOEFPHLCKK BJNIPOLNMLD, bool OMIKAFGHIFK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface IMBEMHENMNJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 BFENAJAEKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 LECHPMMLACE
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IOHAPAEGEFD(NCOEFPHLCKK GGEKFPEBLKN, object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNECHJALIBL(object MIFCLBEAOPM);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface OGBLFJOOHEI
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 BMNHHGGIMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 ICDJEGJHDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float AHNCJOKPCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float JAHICELIBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 JLIOGCPKLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion OCGLMIOIKKA
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event DGAAFHCPHEH IBFMPJKFDEA;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AEAABDHDFFI();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FCDPOIHJAAG();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IEIECPGHPLP();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AMJHKJLPLNB();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface LBPABMNHAKF
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool OJDFKEJHLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	JGBCGHMDEIJ PAEMELMEBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBJONABJOBO();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BBPFDNFCENP(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JDDFJPPACKN(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OKPPPAGPECC(NCOEFPHLCKK IILFNNEDNCJ);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KONHDGEMJBN(NCOEFPHLCKK IILFNNEDNCJ);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EKFOLENAMJE();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KGDABPANOEG
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool FAJNDFDCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	IEnumerable<object> OPBNFDMBOBA
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event DGAAFHCPHEH KOKLFFIBABB;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LDMPNKDCNKH(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGAHJAEMBHA(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PNGKMLMJNAK(object MIFCLBEAOPM, bool KLMBPMINIHN);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable EBMGEFKJGJE();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BOFMJFDPNBF(Rigidbody HKPNCKPHHLB);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface INNKCACPKLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool BBHAHOHMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool MPDIPBBGKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event DGAAFHCPHEH DELNFHCFIKO;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBJONABJOBO();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FPAGIJPELCJ(NCOEFPHLCKK GGEKFPEBLKN);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EDIJKBDKKBN(NCOEFPHLCKK GGEKFPEBLKN);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface IKFALNBDADN
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool KHDKIPLIJCN
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool ILHHOPCAOME
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	RigidbodyConstraints AOEOJAJAPKL
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
	void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CAONNBLCKEG
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float PGABAKFPNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float DCNFDLOMNCM
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
	void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JALFLILHBPD
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx JHFKNMGKLNH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EIMJIHNCMHI
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event DGAAFHCPHEH BGFDOMIHHPL;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBJONABJOBO();

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NEPEFPHIELC();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NKFCECIGMAG();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PKFLOCAHJCK();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LMCNKOCFNJH();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PFPLFILECPI();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PHLPAOAPADB(bool DFLJHGHEKJD);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface IPANMLAMAAD
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBJONABJOBO();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KPOLANLNJJI(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HIBCGDMOODJ(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EDEILOABNOJ();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EONBBMLLGPB();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FDIDMCANFME();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IKMAJMOKAJI();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface ODMDEDICELM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	EKLLOLLHLDP LNMCPLFHCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	CHACNCJIDJM GJHPEGFOAME
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 LGEGEJPPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 JBHIDAJMGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	Vector3 LJMFIEJCGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Vector3 ICEKJCBHJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float KKALKPOINCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool LIGEJEKODFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PBJONABJOBO();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KNFJENEFGIE(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HHLJBCNAEPM(JDHBHPOMECG EFAKAOJPAJJ, Vector3 PKAJMBKNJIL, float KBLOKDLNEPD = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HHAFJJGJPFB(EECECFKKEJP KMDODPJBKLE, Vector3 CFLMAEMNHKL, float ABGPHLFIFAO, float OPCFMELHIKJ = 8f, float ECOHALOPPDN = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IALNLOAFGMK(JDHBHPOMECG EFAKAOJPAJJ, Vector3 IHCJBCJFELL, float MEJPNNANPLH = 7f, float CKIIILKMBKK = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IFMLGPGPJDO();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BHDNAPGFIPJ();

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EPOKPKAANHO();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void INLPOAEPJGG();

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 GJAHBCCOAII(Vector3 DIIFLOBFBLO);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 DNICIBAAMCG(Vector3 GCAABCBBBAL);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NEMGEGCJOPN(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KIIDBBLBANB(Vector3 JDDALKKDLNA);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void JLDEEBLCKGA(Vector3 FHKLDEIKECB, Vector3 FHFHNDANMPN);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void NGFKLMPAGOE(Vector3 GKKEEHNMPBL, Vector3 NFGPCLPNMJK);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 KIKKEDPKAKK(Vector3 HMPFDEAFPND);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 AFFCJBHNNJL(Vector3 JOJEMOKKGPP);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DCBDIJCKLAD(IKIGKMLBEFF.Application)]
public interface IGHAJODIIKL
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool BIAKKCIGCGA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKKAAMCDFCC(string NOGDNAGMMCO);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FHNGJIOABHC(RigidbodyEx IILFNNEDNCJ, Action DAAMKALKLMO);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KKMENLLDAPN GNGDKHBAKPP(int IBKOPKJJILA);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CFFENDALNLG(Vector3 HNGOLMBMNBC, float PLDCHDPKEGB, Color HAFGGBNGKBN);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DCBDIJCKLAD(IKIGKMLBEFF.Application)]
public interface BKDMDHLJAEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	IGHAJODIIKL CLPKFOJNNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	CCKADDACLBD BLIAEGBHDHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool FNDECKOCKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MBEDCJLMHEO EGHEGCMJHNL(RigidbodyEx IILFNNEDNCJ);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NCOEFPHLCKK APMJEHJBGBJ(RigidbodyEx IILFNNEDNCJ, JCAJMGPJNDN HIDEHJGLNHO);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HHEKJCFELLD();

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KLDDNNLENKE();

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal RigidbodyEx GIFJOELLPHL(GameObject JNONJGMFMNE, [Optional] JCAJMGPJNDN HIDEHJGLNHO);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CHACNCJIDJM
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BJIHEAFMKCO(Vector3 NBPFLBOCGJL);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HOGMIBAAANA(Vector3 DIIFLOBFBLO);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NHCDCOOMJKI(Vector3 NBPFLBOCGJL);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKMBOHHCKDH(Vector3 DIIFLOBFBLO);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface EKLLOLLHLDP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 BOHCGEJKGNK();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 BGJJOBCDBBC();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NCOEFPHLCKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	RigidbodyEx OEOEKIBFEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	GameObject MILHHPLGFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Transform LHEBMCHBDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IEnumerable<object> IMECMIODOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	IReadOnlyList<NCOEFPHLCKK> PHPDFDJEEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	NCOEFPHLCKK CMJKBCMDGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool KMDIPAOGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool BBHAHOHMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool MPDIPBBGKKB
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	EKLLOLLHLDP LNMCPLFHCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	CHACNCJIDJM GJHPEGFOAME
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	float KKALKPOINCB
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 JBHIDAJMGMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 ICEKJCBHJBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 LGEGEJPPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 LJMFIEJCGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool NHCAAMEDKKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool GDCCIECOAEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool ABAINBEINAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool LIGEJEKODFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 BFENAJAEKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 LECHPMMLACE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 BMNHHGGIMHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 ICDJEGJHDEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float AHNCJOKPCCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float JAHICELIBID
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 JLIOGCPKLOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Quaternion OCGLMIOIKKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float PGABAKFPNBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float DCNFDLOMNCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool OGIIANAEIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "47")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	GGPABLKNBJB LEKOFMMMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool FAJNDFDCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Transform KMDNPAAIEIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Transform FNPJMEGGLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 BLGJDGKFELJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float CLIPDFNDOOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float JHDBNDJGACG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "58")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion INFAOAKNLJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "60")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 NAILLMLOGGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Quaternion FBMHBHAGGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "64")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	RigidbodyConstraints AOEOJAJAPKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "66")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool KHDKIPLIJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CollisionDetectionMode PAOOKBBFCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "70")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool LFGDELENJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event DGAAFHCPHEH NJJHHELIHIP;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event DGAAFHCPHEH EPBNCIPAFDB;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event MKKJLKCGEAC EIBHEHIGCNB;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event DGAAFHCPHEH DELNFHCFIKO;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event DGAAFHCPHEH DHIFCNEILML;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event DGAAFHCPHEH BGFDOMIHHPL;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<FCDCKNBKJML, FCDCKNBKJML> DLLBDKMMJIP;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event DGAAFHCPHEH FCJJAJLCBGC;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event DGAAFHCPHEH MGPMCLDJCJA;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void PBJONABJOBO();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void AOLBABCADFF();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void NKMAPFPPLGO();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void PKFLOCAHJCK();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void MCKPAKFDOPH();

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void DEIBNNOCJKC(NCOEFPHLCKK LPJDDLMPNCG, bool OMIKAFGHIFK = false);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void KMKIMCBMAFA(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void JCGBFLMHKCG(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 AFFCJBHNNJL(Vector3 JOJEMOKKGPP);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "89")]
	Vector3 KIKKEDPKAKK(Vector3 HMPFDEAFPND);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void INLPOAEPJGG();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void BHDNAPGFIPJ();

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void IFMLGPGPJDO();

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void NGFKLMPAGOE(Vector3 GKKEEHNMPBL, Vector3 NFGPCLPNMJK);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void JLDEEBLCKGA(Vector3 FHKLDEIKECB, Vector3 FHFHNDANMPN);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void KIIDBBLBANB(Vector3 JDDALKKDLNA);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void HHAFJJGJPFB(EECECFKKEJP KMDODPJBKLE, Vector3 CFLMAEMNHKL, float ABGPHLFIFAO, float OPCFMELHIKJ = 8f, float ECOHALOPPDN = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void HHLJBCNAEPM(JDHBHPOMECG EFAKAOJPAJJ, Vector3 PKAJMBKNJIL, float KBLOKDLNEPD = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void IALNLOAFGMK(JDHBHPOMECG EFAKAOJPAJJ, Vector3 IHCJBCJFELL, float MEJPNNANPLH = 7f, float CKIIILKMBKK = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 DNICIBAAMCG(Vector3 LPJDDLMPNCG);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "100")]
	Vector3 GJAHBCCOAII(Vector3 LPJDDLMPNCG);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void EPOKPKAANHO();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void OIHMDCKKBFA(NCOEFPHLCKK BKGBHBNCDJA, object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void ELAHEJFDAHO(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void FCDPOIHJAAG();

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void AEAABDHDFFI();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void IEIECPGHPLP();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "111")]
	bool NEPEFPHIELC();

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void PFPLFILECPI();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "117")]
	IDisposable EBMGEFKJGJE();

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void LDMPNKDCNKH(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void FGAHJAEMBHA(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void PNGKMLMJNAK(object MIFCLBEAOPM, bool KLMBPMINIHN);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void LOKMBIPHOGK(Vector3 PGJOODJOMAI, Quaternion OMJBPOHHBNI);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void OFCCCKGCAPP(Vector3 PPNOLBKPBJH, Quaternion KAHANPFONLJ);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "125")]
	bool AMLDEGGHKAD(float ANPGDIDDDCB);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void HMHFMGOKMHP(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void KNMLFLHNFDJ(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void KPOLANLNJJI(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void HIBCGDMOODJ(object MIFCLBEAOPM);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void BEJNHGKJNLM(Vector3 HKPPDHFDHMN, ForceMode MPMGBCACKOF = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void CBMEMNKKLDE(Vector3 HKPPDHFDHMN, Vector3 PICDPPHNNLH, ForceMode MPMGBCACKOF);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void OHNHDPGFLAC(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void PPDGHDJCFAP(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool OFDKFHJBLOJ(Vector3 MFKKMPGAJFI, out RaycastHit ONOMCDOFLKH, float CBFODBDKBEK);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void AMJHKJLPLNB();

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class PLOEBEDJGLE : NCOEFPHLCKK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly BKDMDHLJAEJ CMIHNHHBGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal PLDJMDIFCKE BKOBOKBHBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal LBPABMNHAKF BJPFGGIMOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal INNKCACPKLA LCMHIEKJLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal ODMDEDICELM GCAABCBBBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal IMBEMHENMNJ NBMNJAEIEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal OGBLFJOOHEI DDHOGLKMBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal CAONNBLCKEG ODLGAEJDKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal BBGAPPNBFLO PGCKHKHCPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal EIMJIHNCMHI INAPIHIPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal JBCOLILENLD HCIMMAHILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal KGDABPANOEG KOEGAAAEINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal BDJOPHNNEJG HKPPDHFDHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal IKFALNBDADN LHIILEMPCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal IPANMLAMAAD GHAGIOLHPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal AIOOGANOGPH COPBAHMMIPO;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public RigidbodyEx OEOEKIBFEMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7EC720", Offset = "0x7EB120", VA = "0x1807EC720", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x87A110", Offset = "0x878B10", VA = "0x18087A110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GameObject MILHHPLGFOL
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x74D170", Offset = "0x74BB70", VA = "0x18074D170", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x905130", Offset = "0x903B30", VA = "0x180905130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Transform LHEBMCHBDEI
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x5759F50", Offset = "0x5758950", VA = "0x185759F50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEnumerable<object> IMECMIODOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x57581F0", Offset = "0x5756BF0", VA = "0x1857581F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x575A0D0", Offset = "0x5758AD0", VA = "0x18575A0D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x575C9D0", Offset = "0x575B3D0", VA = "0x18575C9D0", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x5757EB0", Offset = "0x57568B0", VA = "0x185757EB0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public IReadOnlyList<NCOEFPHLCKK> PHPDFDJEEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x575A170", Offset = "0x5758B70", VA = "0x18575A170", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public NCOEFPHLCKK CMJKBCMDGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5758EF0", Offset = "0x57578F0", VA = "0x185758EF0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool KMDIPAOGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x575C6B0", Offset = "0x575B0B0", VA = "0x18575C6B0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool BBHAHOHMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5758DB0", Offset = "0x57577B0", VA = "0x185758DB0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool MPDIPBBGKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x575A120", Offset = "0x5758B20", VA = "0x18575A120", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public EKLLOLLHLDP LNMCPLFHCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x575DC40", Offset = "0x575C640", VA = "0x18575DC40", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x57589A0", Offset = "0x57573A0", VA = "0x1857589A0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public CHACNCJIDJM GJHPEGFOAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x5758710", Offset = "0x5757110", VA = "0x185758710", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x575A790", Offset = "0x5759190", VA = "0x18575A790", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public float KKALKPOINCB
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x5758EA0", Offset = "0x57578A0", VA = "0x185758EA0", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5759230", Offset = "0x5757C30", VA = "0x185759230", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 JBHIDAJMGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x575AB50", Offset = "0x5759550", VA = "0x18575AB50", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x57597E0", Offset = "0x57581E0", VA = "0x1857597E0", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 ICEKJCBHJBH
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x575B0C0", Offset = "0x5759AC0", VA = "0x18575B0C0", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x575AFF0", Offset = "0x57599F0", VA = "0x18575AFF0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 LGEGEJPPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5758120", Offset = "0x5756B20", VA = "0x185758120", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5758BE0", Offset = "0x57575E0", VA = "0x185758BE0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 LJMFIEJCGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5758B10", Offset = "0x5757510", VA = "0x185758B10", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5758450", Offset = "0x5756E50", VA = "0x185758450", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool NHCAAMEDKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5758E00", Offset = "0x5757800", VA = "0x185758E00", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool GDCCIECOAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5758CB0", Offset = "0x57576B0", VA = "0x185758CB0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool ABAINBEINAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x575A5E0", Offset = "0x5758FE0", VA = "0x18575A5E0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool LIGEJEKODFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x575AF40", Offset = "0x5759940", VA = "0x18575AF40", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Vector3 BFENAJAEKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x575C860", Offset = "0x575B260", VA = "0x18575C860", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 LECHPMMLACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x575A6C0", Offset = "0x57590C0", VA = "0x18575A6C0", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Vector3 BMNHHGGIMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x5758380", Offset = "0x5756D80", VA = "0x185758380", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x5758870", Offset = "0x5757270", VA = "0x185758870", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 ICDJEGJHDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x575A850", Offset = "0x5759250", VA = "0x18575A850", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float AHNCJOKPCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x57598B0", Offset = "0x57582B0", VA = "0x1857598B0", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float JAHICELIBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x5758E50", Offset = "0x5757850", VA = "0x185758E50", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x575DD50", Offset = "0x575C750", VA = "0x18575DD50", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Vector3 JLIOGCPKLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5757F10", Offset = "0x5756910", VA = "0x185757F10", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x575AC20", Offset = "0x5759620", VA = "0x18575AC20", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion OCGLMIOIKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5759900", Offset = "0x5758300", VA = "0x185759900", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x575D5F0", Offset = "0x575BFF0", VA = "0x18575D5F0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float PGABAKFPNBB
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x575C7C0", Offset = "0x575B1C0", VA = "0x18575C7C0", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x575A920", Offset = "0x5759320", VA = "0x18575A920", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public float DCNFDLOMNCM
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x575D710", Offset = "0x575C110", VA = "0x18575D710", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x575C130", Offset = "0x575AB30", VA = "0x18575C130", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool OGIIANAEIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x575C930", Offset = "0x575B330", VA = "0x18575C930", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x5758FB0", Offset = "0x57579B0", VA = "0x185758FB0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public GGPABLKNBJB LEKOFMMMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x575ADF0", Offset = "0x57597F0", VA = "0x18575ADF0", Slot = "52")]
		get
		{
			return default(GGPABLKNBJB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x5759400", Offset = "0x5757E00", VA = "0x185759400", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool FAJNDFDCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x575C810", Offset = "0x575B210", VA = "0x18575C810", Slot = "54")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Transform KMDNPAAIEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x57594C0", Offset = "0x5757EC0", VA = "0x1857594C0", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public Transform FNPJMEGGLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x57594C0", Offset = "0x5757EC0", VA = "0x1857594C0", Slot = "56")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Vector3 BLGJDGKFELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x57599D0", Offset = "0x57583D0", VA = "0x1857599D0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5759EA0", Offset = "0x57588A0", VA = "0x185759EA0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public float CLIPDFNDOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x5758940", Offset = "0x5757340", VA = "0x185758940", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x575A260", Offset = "0x5758C60", VA = "0x18575A260", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public float JHDBNDJGACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x57587B0", Offset = "0x57571B0", VA = "0x1857587B0", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x575B1F0", Offset = "0x5759BF0", VA = "0x18575B1F0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Quaternion INFAOAKNLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x575C080", Offset = "0x575AA80", VA = "0x18575C080", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x575D410", Offset = "0x575BE10", VA = "0x18575D410", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 NAILLMLOGGK
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x575A210", Offset = "0x5758C10", VA = "0x18575A210", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x575C240", Offset = "0x575AC40", VA = "0x18575C240", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Quaternion FBMHBHAGGPI
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x5759590", Offset = "0x5757F90", VA = "0x185759590", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x57593C0", Offset = "0x5757DC0", VA = "0x1857593C0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public RigidbodyConstraints AOEOJAJAPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x575A1C0", Offset = "0x5758BC0", VA = "0x18575A1C0", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x575DE30", Offset = "0x575C830", VA = "0x18575DE30", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool KHDKIPLIJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x575DD00", Offset = "0x575C700", VA = "0x18575DD00", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x575BB00", Offset = "0x575A500", VA = "0x18575BB00", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CollisionDetectionMode PAOOKBBFCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x575D6C0", Offset = "0x575C0C0", VA = "0x18575D6C0", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x575CBE0", Offset = "0x575B5E0", VA = "0x18575CBE0", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool LFGDELENJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x575C570", Offset = "0x575AF70", VA = "0x18575C570", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event DGAAFHCPHEH NJJHHELIHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x575B4F0", Offset = "0x5759EF0", VA = "0x18575B4F0", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x575BC20", Offset = "0x575A620", VA = "0x18575BC20", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event DGAAFHCPHEH EPBNCIPAFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x575AD40", Offset = "0x5759740", VA = "0x18575AD40", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x575A980", Offset = "0x5759380", VA = "0x18575A980", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event MKKJLKCGEAC EIBHEHIGCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x575A9E0", Offset = "0x57593E0", VA = "0x18575A9E0", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x575B190", Offset = "0x5759B90", VA = "0x18575B190", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event DGAAFHCPHEH DELNFHCFIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x575AF90", Offset = "0x5759990", VA = "0x18575AF90", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x5758810", Offset = "0x5757210", VA = "0x185758810", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event DGAAFHCPHEH DHIFCNEILML
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x5759E40", Offset = "0x5758840", VA = "0x185759E40", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x5759720", Offset = "0x5758120", VA = "0x185759720", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event DGAAFHCPHEH BGFDOMIHHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x575CC60", Offset = "0x575B660", VA = "0x18575CC60", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5759100", Offset = "0x5757B00", VA = "0x185759100", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<FCDCKNBKJML, FCDCKNBKJML> DLLBDKMMJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x5758520", Offset = "0x5756F20", VA = "0x185758520", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x575D760", Offset = "0x575C160", VA = "0x18575D760", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event DGAAFHCPHEH FCJJAJLCBGC
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x575D2B0", Offset = "0x575BCB0", VA = "0x18575D2B0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x5759530", Offset = "0x5757F30", VA = "0x185759530", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event DGAAFHCPHEH MGPMCLDJCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x575D060", Offset = "0x575BA60", VA = "0x18575D060", Slot = "125")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5758D10", Offset = "0x5757710", VA = "0x185758D10", Slot = "126")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x575DED0", Offset = "0x575C8D0", VA = "0x18575DED0")]
	public PLOEBEDJGLE(GameObject DLNMCGFEPOP, RigidbodyEx MCLIFNMABNA, BKDMDHLJAEJ CMIHNHHBGOO, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5759A80", Offset = "0x5758480", VA = "0x185759A80", Slot = "142")]
	protected virtual void FOIMKAENAPH(BKDMDHLJAEJ CMIHNHHBGOO, JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5759160", Offset = "0x5757B60", VA = "0x185759160", Slot = "143")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x575D7C0", Offset = "0x575C1C0", VA = "0x18575D7C0", Slot = "76")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x5758330", Offset = "0x5756D30", VA = "0x185758330", Slot = "77")]
	public void AOLBABCADFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x575CC40", Offset = "0x575B640", VA = "0x18575CC40", Slot = "78")]
	public void NKMAPFPPLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x575C190", Offset = "0x575AB90", VA = "0x18575C190", Slot = "144")]
	public virtual void MCKPAKFDOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5758F40", Offset = "0x5757940", VA = "0x185758F40", Slot = "87")]
	public void DEIBNNOCJKC(NCOEFPHLCKK LPJDDLMPNCG, bool OMIKAFGHIFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x575BA40", Offset = "0x575A440", VA = "0x18575BA40", Slot = "90")]
	public void KMKIMCBMAFA(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x575B3A0", Offset = "0x5759DA0", VA = "0x18575B3A0", Slot = "91")]
	public void JCGBFLMHKCG(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x5758030", Offset = "0x5756A30", VA = "0x185758030", Slot = "92")]
	public Vector3 AFFCJBHNNJL(Vector3 JOJEMOKKGPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x575B620", Offset = "0x575A020", VA = "0x18575B620", Slot = "93")]
	public Vector3 KIKKEDPKAKK(Vector3 HMPFDEAFPND)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x5758330", Offset = "0x5756D30", VA = "0x185758330", Slot = "94")]
	public void INLPOAEPJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x5758760", Offset = "0x5757160", VA = "0x185758760", Slot = "95")]
	public void BHDNAPGFIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x575ADA0", Offset = "0x57597A0", VA = "0x18575ADA0", Slot = "96")]
	public void IFMLGPGPJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x575CA20", Offset = "0x575B420", VA = "0x18575CA20", Slot = "97")]
	public void NGFKLMPAGOE(Vector3 GKKEEHNMPBL, Vector3 NFGPCLPNMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x575B400", Offset = "0x5759E00", VA = "0x18575B400", Slot = "98")]
	public void JLDEEBLCKGA(Vector3 FHKLDEIKECB, Vector3 FHFHNDANMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x575B550", Offset = "0x5759F50", VA = "0x18575B550", Slot = "99")]
	public void KIIDBBLBANB(Vector3 JDDALKKDLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x575A360", Offset = "0x5758D60", VA = "0x18575A360", Slot = "100")]
	public void HHAFJJGJPFB(EECECFKKEJP KMDODPJBKLE, Vector3 CFLMAEMNHKL, float ABGPHLFIFAO, float OPCFMELHIKJ = 8f, float ECOHALOPPDN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x575A480", Offset = "0x5758E80", VA = "0x18575A480", Slot = "101")]
	public void HHLJBCNAEPM(JDHBHPOMECG EFAKAOJPAJJ, Vector3 PKAJMBKNJIL, float KBLOKDLNEPD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x575AA40", Offset = "0x5759440", VA = "0x18575AA40", Slot = "102")]
	[Obsolete]
	public void IALNLOAFGMK(JDHBHPOMECG EFAKAOJPAJJ, Vector3 IHCJBCJFELL, float MEJPNNANPLH = 7f, float CKIIILKMBKK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x5759010", Offset = "0x5757A10", VA = "0x185759010", Slot = "103")]
	public Vector3 DNICIBAAMCG(Vector3 LPJDDLMPNCG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5759FE0", Offset = "0x57589E0", VA = "0x185759FE0", Slot = "104")]
	public Vector3 GJAHBCCOAII(Vector3 LPJDDLMPNCG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x57595D0", Offset = "0x5757FD0", VA = "0x1857595D0", Slot = "105")]
	public void EPOKPKAANHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x575D520", Offset = "0x575BF20", VA = "0x18575D520", Slot = "106")]
	public void OIHMDCKKBFA(NCOEFPHLCKK BKGBHBNCDJA, object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x57594D0", Offset = "0x5757ED0", VA = "0x1857594D0", Slot = "107")]
	public void ELAHEJFDAHO(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x57596D0", Offset = "0x57580D0", VA = "0x1857596D0", Slot = "110")]
	public void FCDPOIHJAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x5757FE0", Offset = "0x57569E0", VA = "0x185757FE0", Slot = "111")]
	public void AEAABDHDFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x575ACF0", Offset = "0x57596F0", VA = "0x18575ACF0", Slot = "112")]
	public void IEIECPGHPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x575C980", Offset = "0x575B380", VA = "0x18575C980", Slot = "115")]
	public bool NEPEFPHIELC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x575DBF0", Offset = "0x575C5F0", VA = "0x18575DBF0", Slot = "79")]
	public void PKFLOCAHJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x575DA70", Offset = "0x575C470", VA = "0x18575DA70", Slot = "116")]
	public void PFPLFILECPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5759290", Offset = "0x5757C90", VA = "0x185759290", Slot = "121")]
	public IDisposable EBMGEFKJGJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x575BBC0", Offset = "0x575A5C0", VA = "0x18575BBC0", Slot = "122")]
	public void LDMPNKDCNKH(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x5759780", Offset = "0x5758180", VA = "0x185759780", Slot = "123")]
	public void FGAHJAEMBHA(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x575DC90", Offset = "0x575C690", VA = "0x18575DC90", Slot = "124")]
	public void PNGKMLMJNAK(object MIFCLBEAOPM, bool KLMBPMINIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x575BE70", Offset = "0x575A870", VA = "0x18575BE70", Slot = "127")]
	public void LOKMBIPHOGK(Vector3 PGJOODJOMAI, Quaternion OMJBPOHHBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x575D100", Offset = "0x575BB00", VA = "0x18575D100", Slot = "128")]
	public void OFCCCKGCAPP(Vector3 PPNOLBKPBJH, Quaternion KAHANPFONLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5758290", Offset = "0x5756C90", VA = "0x185758290", Slot = "129")]
	public bool AMLDEGGHKAD(float ANPGDIDDDCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x575A7F0", Offset = "0x57591F0", VA = "0x18575A7F0", Slot = "130")]
	public void HMHFMGOKMHP(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x575BAA0", Offset = "0x575A4A0", VA = "0x18575BAA0", Slot = "131")]
	public void KNMLFLHNFDJ(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x575BB60", Offset = "0x575A560", VA = "0x18575BB60", Slot = "132")]
	public void KPOLANLNJJI(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x575A580", Offset = "0x5758F80", VA = "0x18575A580", Slot = "133")]
	public void HIBCGDMOODJ(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5758690", Offset = "0x5757090", VA = "0x185758690", Slot = "134")]
	public void BEJNHGKJNLM(Vector3 HKPPDHFDHMN, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5758A00", Offset = "0x5757400", VA = "0x185758A00", Slot = "135")]
	public void CBMEMNKKLDE(Vector3 HKPPDHFDHMN, Vector3 PICDPPHNNLH, ForceMode MPMGBCACKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x575D4A0", Offset = "0x575BEA0", VA = "0x18575D4A0", Slot = "136")]
	public void OHNHDPGFLAC(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x575DDB0", Offset = "0x575C7B0", VA = "0x18575DDB0", Slot = "137")]
	public void PPDGHDJCFAP(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x575D310", Offset = "0x575BD10", VA = "0x18575D310", Slot = "138")]
	public bool OFDKFHJBLOJ(Vector3 MFKKMPGAJFI, out RaycastHit ONOMCDOFLKH, float CBFODBDKBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5758240", Offset = "0x5756C40", VA = "0x185758240", Slot = "139")]
	public void AMJHKJLPLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x575DE90", Offset = "0x575C890", VA = "0x18575DE90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x575CB10", Offset = "0x575B510", VA = "0x18575CB10")]
	private void NICOHLOHFBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x5758580", Offset = "0x5756F80", VA = "0x185758580")]
	private void BDNBLBFFHHC(NCOEFPHLCKK GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x575BC80", Offset = "0x575A680", VA = "0x18575BC80")]
	private void LMNJJEPMEEO(NCOEFPHLCKK GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x575C710", Offset = "0x575B110", VA = "0x18575C710")]
	private void MKEPJNOMJBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x575AE40", Offset = "0x5759840", VA = "0x18575AE40")]
	private void IGJFIAMCHNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5759620", Offset = "0x5758020", VA = "0x185759620")]
	private void FAJPHEAJODP(NCOEFPHLCKK EMJBGADPLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5759D60", Offset = "0x5758760", VA = "0x185759D60")]
	private void FPAGIJPELCJ(NCOEFPHLCKK GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x57592E0", Offset = "0x5757CE0", VA = "0x1857592E0")]
	private void EDIJKBDKKBN(NCOEFPHLCKK GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x575D900", Offset = "0x575C300", VA = "0x18575D900")]
	private void PDGKMGMBAKE(RigidbodyEx GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x575CCC0", Offset = "0x575B6C0", VA = "0x18575CCC0")]
	private void NMKMBEIECNB(RigidbodyEx IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x575DAC0", Offset = "0x575C4C0", VA = "0x18575DAC0")]
	[Conditional("UNITY_EDITOR")]
	private void PGPNDFCEJPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x575C290", Offset = "0x575AC90", VA = "0x18575C290")]
	protected void MIDJGBOHFJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x575B710", Offset = "0x575A110", VA = "0x18575B710")]
	protected void KJAKLLMPFGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class FBAAOANGPOH
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x573D260", Offset = "0x573BC60", VA = "0x18573D260")]
	public static NCOEFPHLCKK LHDELKCHFDH(this NCOEFPHLCKK IILFNNEDNCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x573D0F0", Offset = "0x573BAF0", VA = "0x18573D0F0")]
	public static bool DNONFCCKBCL(this NCOEFPHLCKK IILFNNEDNCJ, NCOEFPHLCKK FMPADABIBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x573D1E0", Offset = "0x573BBE0", VA = "0x18573D1E0")]
	public static bool JMKFKNLDDPE(this NCOEFPHLCKK IILFNNEDNCJ, NCOEFPHLCKK BOAHBOBCIFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x573D320", Offset = "0x573BD20", VA = "0x18573D320")]
	public static RigidbodyEx OEOEKIBFEMO(this NCOEFPHLCKK EOOOGHAIOAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x573D170", Offset = "0x573BB70", VA = "0x18573D170")]
	public static PLOEBEDJGLE FBBPFDMGFIE(this NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class OFHEAMJAHEA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool FCPODLMHINC;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5757770", Offset = "0x5756170", VA = "0x185757770")]
	public OFHEAMJAHEA(PLOEBEDJGLE NFAMBOPBCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5757710", Offset = "0x5756110", VA = "0x185757710", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class KKKKDAHHJPA : LPHFOFKHCNE, AIOOGANOGPH
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CollisionDetectionMode MAJGBEOMFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x574DDE0", Offset = "0x574C7E0", VA = "0x18574DDE0")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x574D8E0", Offset = "0x574C2E0", VA = "0x18574D8E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x5737FA0", Offset = "0x57369A0", VA = "0x185737FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CollisionDetectionMode PAOOKBBFCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x574DBC0", Offset = "0x574C5C0", VA = "0x18574DBC0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x574D9D0", Offset = "0x574C3D0", VA = "0x18574D9D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x57389E0", Offset = "0x57373E0", VA = "0x1857389E0")]
	public KKKKDAHHJPA(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x574DCD0", Offset = "0x574C6D0", VA = "0x18574DCD0", Slot = "6")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x574D630", Offset = "0x574C030", VA = "0x18574D630", Slot = "9")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x574D8C0", Offset = "0x574C2C0", VA = "0x18574D8C0", Slot = "7")]
	public void DLGGDMCBIHM(bool OJNHEHLGDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x574D8D0", Offset = "0x574C2D0", VA = "0x18574D8D0", Slot = "8")]
	public void FICHJHCOBIG(bool OJNHEHLGDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x574DA50", Offset = "0x574C450", VA = "0x18574DA50", Slot = "10")]
	public bool OFDKFHJBLOJ(Vector3 MFKKMPGAJFI, out RaycastHit ONOMCDOFLKH, float CBFODBDKBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x574D6C0", Offset = "0x574C0C0", VA = "0x18574D6C0")]
	private void DAOOMGFPAAE(bool OJNHEHLGDGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class JFJILAEEHEP : LPHFOFKHCNE, JBCOLILENLD, IDisposable, FLCKAICBODN
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public GGPABLKNBJB EMHBGABGONE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5749FE0", Offset = "0x57489E0", VA = "0x185749FE0")]
		get
		{
			return default(GGPABLKNBJB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x5749CD0", Offset = "0x57486D0", VA = "0x185749CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public GGPABLKNBJB LEKOFMMMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x5749DC0", Offset = "0x57487C0", VA = "0x185749DC0", Slot = "6")]
		get
		{
			return default(GGPABLKNBJB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5749CD0", Offset = "0x57486D0", VA = "0x185749CD0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private Transform OACKHJKFCIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x72B5A0", Offset = "0x729FA0", VA = "0x18072B5A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<FCDCKNBKJML, FCDCKNBKJML> DLLBDKMMJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x5749C30", Offset = "0x5748630", VA = "0x185749C30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x574A120", Offset = "0x5748B20", VA = "0x18574A120", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x57389E0", Offset = "0x57373E0", VA = "0x1857389E0")]
	public JFJILAEEHEP(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x574A0C0", Offset = "0x5748AC0", VA = "0x18574A0C0", Slot = "11")]
	public void OnChangedDistanceBand(FCDCKNBKJML DKOFAPECACL, FCDCKNBKJML JFNADPGFOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "12")]
	public void OnChangedVisibility(bool FHFGDHHLCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "8")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class DGILPDFDKEJ : LPHFOFKHCNE, BDJOPHNNEJG
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x5737FA0", Offset = "0x57369A0", VA = "0x185737FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool FAJNDFDCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x5738550", Offset = "0x5736F50", VA = "0x185738550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private bool KMDIPAOGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x57384F0", Offset = "0x5736EF0", VA = "0x1857384F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x57385A0", Offset = "0x5736FA0", VA = "0x1857385A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x57389E0", Offset = "0x57373E0", VA = "0x1857389E0")]
	public DGILPDFDKEJ(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5737BA0", Offset = "0x57365A0", VA = "0x185737BA0", Slot = "4")]
	public void BEJNHGKJNLM(Vector3 HKPPDHFDHMN, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5737FF0", Offset = "0x57369F0", VA = "0x185737FF0")]
	private void GNLGGMKPOAG(Vector3 HKPPDHFDHMN, ForceMode MPMGBCACKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5737D00", Offset = "0x5736700", VA = "0x185737D00", Slot = "5")]
	public void CBMEMNKKLDE(Vector3 HKPPDHFDHMN, Vector3 PICDPPHNNLH, ForceMode MPMGBCACKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x5738600", Offset = "0x5737000", VA = "0x185738600", Slot = "6")]
	public void OHNHDPGFLAC(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x5738270", Offset = "0x5736C70", VA = "0x185738270")]
	private void HDEEJGEFJJL(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x5738760", Offset = "0x5737160", VA = "0x185738760", Slot = "7")]
	public void PPDGHDJCFAP(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class MGNEKJDGJKC : LPHFOFKHCNE, BBGAPPNBFLO
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool OGIIANAEIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x5750980", Offset = "0x574F380", VA = "0x185750980", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x57507A0", Offset = "0x574F1A0", VA = "0x1857507A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x57389E0", Offset = "0x57373E0", VA = "0x1857389E0")]
	public MGNEKJDGJKC(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x57506A0", Offset = "0x574F0A0", VA = "0x1857506A0", Slot = "6")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5750A60", Offset = "0x574F460", VA = "0x185750A60", Slot = "7")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class MPAFELNNHEE : LPHFOFKHCNE, PLDJMDIFCKE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly GMOJEAHHPKO BOGHIFKGACA;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Transform LHEBMCHBDEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x57527E0", Offset = "0x57511E0", VA = "0x1857527E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public MBEDCJLMHEO NIBHAOFECEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x5753710", Offset = "0x5752110", VA = "0x185753710")]
		get
		{
			return default(MBEDCJLMHEO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x5751440", Offset = "0x574FE40", VA = "0x185751440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x5753410", Offset = "0x5751E10", VA = "0x185753410", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x5751330", Offset = "0x574FD30", VA = "0x185751330", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public MBEDCJLMHEO IAPCCNJLHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x5752A90", Offset = "0x5751490", VA = "0x185752A90")]
		get
		{
			return default(MBEDCJLMHEO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x57538B0", Offset = "0x57522B0", VA = "0x1857538B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public NCOEFPHLCKK CMJKBCMDGHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x5751EE0", Offset = "0x57508E0", VA = "0x185751EE0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyList<NCOEFPHLCKK> PHPDFDJEEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x7270B0", Offset = "0x725AB0", VA = "0x1807270B0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event DGAAFHCPHEH NJJHHELIHIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x5752E10", Offset = "0x5751810", VA = "0x185752E10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x5752FE0", Offset = "0x57519E0", VA = "0x185752FE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event DGAAFHCPHEH EPBNCIPAFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x5752C30", Offset = "0x5751630", VA = "0x185752C30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x57529F0", Offset = "0x57513F0", VA = "0x1857529F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event MKKJLKCGEAC EIBHEHIGCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x5752B90", Offset = "0x5751590", VA = "0x185752B90", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x5752CD0", Offset = "0x57516D0", VA = "0x185752CD0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action PFANGAANPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x5752D70", Offset = "0x5751770", VA = "0x185752D70", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x57532C0", Offset = "0x5751CC0", VA = "0x1857532C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action NJGCKLJKCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x5752950", Offset = "0x5751350", VA = "0x185752950", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x5751E40", Offset = "0x5750840", VA = "0x185751E40", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<NCOEFPHLCKK> NFDMKCEEBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x5753810", Offset = "0x5752210", VA = "0x185753810", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x5752810", Offset = "0x5751210", VA = "0x185752810", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<NCOEFPHLCKK> AMBCDPFGEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x57528B0", Offset = "0x57512B0", VA = "0x1857528B0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5752610", Offset = "0x5751010", VA = "0x185752610", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action KKKJMJHLIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x57521E0", Offset = "0x5750BE0", VA = "0x1857521E0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x57513A0", Offset = "0x574FDA0", VA = "0x1857513A0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<NCOEFPHLCKK> PFJIOBMDLAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x5752570", Offset = "0x5750F70", VA = "0x185752570", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x5753220", Offset = "0x5751C20", VA = "0x185753220", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x57539B0", Offset = "0x57523B0", VA = "0x1857539B0")]
	public MPAFELNNHEE(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5752010", Offset = "0x5750A10", VA = "0x185752010", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5751F20", Offset = "0x5750920", VA = "0x185751F20", Slot = "26")]
	public void DEIBNNOCJKC(NCOEFPHLCKK BJNIPOLNMLD, bool OMIKAFGHIFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5751FA0", Offset = "0x57509A0", VA = "0x185751FA0")]
	private void DEIBNNOCJKC(KNGEGNFMEDP BJNIPOLNMLD, bool OMIKAFGHIFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5751540", Offset = "0x574FF40", VA = "0x185751540")]
	private void BJMKIEJKNJF(KNGEGNFMEDP BJNIPOLNMLD, bool OMIKAFGHIFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5753450", Offset = "0x5751E50", VA = "0x185753450")]
	private void OAJEEOBFKGI(KNGEGNFMEDP EMJBGADPLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5752280", Offset = "0x5750C80", VA = "0x185752280")]
	private void FEBKLPDLGMF(KNGEGNFMEDP EMJBGADPLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5753080", Offset = "0x5751A80", VA = "0x185753080")]
	private void MAFJOMEFHJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x5751DC0", Offset = "0x57507C0", VA = "0x185751DC0")]
	private void CIAELCNFLBC(KNGEGNFMEDP EMJBGADPLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5753360", Offset = "0x5751D60", VA = "0x185753360")]
	private void MJFKBFMOHPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x57526B0", Offset = "0x57510B0", VA = "0x1857526B0")]
	private void GCCACPFBAFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5752EB0", Offset = "0x57518B0", VA = "0x185752EB0")]
	private void LBIPGKKJCGE(KNGEGNFMEDP IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x5752440", Offset = "0x5750E40", VA = "0x185752440")]
	private void FHJPDJCNJIO(KNGEGNFMEDP IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5753610", Offset = "0x5752010", VA = "0x185753610")]
	[CompilerGenerated]
	private object OHPPPDIIACM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class JMPJPOHIBBG
{
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x574A8C0", Offset = "0x57492C0", VA = "0x18574A8C0")]
	public static MPAFELNNHEE EHJMHIENHGI(this NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class PPELHKHJNDB : LPHFOFKHCNE, IMBEMHENMNJ
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public Vector3 BFENAJAEKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x697E160", Offset = "0x697CB60", VA = "0x18697E160", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public Vector3 LECHPMMLACE
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x697DCF0", Offset = "0x697C6F0", VA = "0x18697DCF0", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	private Vector3 LGEGEJPPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x697D6A0", Offset = "0x697C0A0", VA = "0x18697D6A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private NCOEFPHLCKK KJCAOKIHBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x697DAC0", Offset = "0x697C4C0", VA = "0x18697DAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x697E190", Offset = "0x697CB90", VA = "0x18697E190")]
	public PPELHKHJNDB(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x697DE80", Offset = "0x697C880", VA = "0x18697DE80", Slot = "6")]
	public void IOHAPAEGEFD(NCOEFPHLCKK GGEKFPEBLKN, object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x697E020", Offset = "0x697CA20", VA = "0x18697E020")]
	private void IOHAPAEGEFD(KNGEGNFMEDP GGEKFPEBLKN, object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x697DBF0", Offset = "0x697C5F0", VA = "0x18697DBF0", Slot = "7")]
	public void DNECHJALIBL(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x697D780", Offset = "0x697C180", VA = "0x18697D780")]
	private Vector3 BIHFLNGABAB()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class CFFBFMHJJFN
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x5737380", Offset = "0x5735D80", VA = "0x185737380")]
	public static PPELHKHJNDB FCOMDNGDAPJ(this NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class IHCNHADGBCB : LPHFOFKHCNE, OGBLFJOOHEI
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 BMNHHGGIMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x5746100", Offset = "0x5744B00", VA = "0x185746100", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x5746230", Offset = "0x5744C30", VA = "0x185746230", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 ICDJEGJHDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x5747CB0", Offset = "0x57466B0", VA = "0x185747CB0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public float AHNCJOKPCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x5746B50", Offset = "0x5745550", VA = "0x185746B50", Slot = "9")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x57480A0", Offset = "0x5746AA0", VA = "0x1857480A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float JAHICELIBID
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x5746590", Offset = "0x5744F90", VA = "0x185746590", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x5748C20", Offset = "0x5747620", VA = "0x185748C20", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public Vector3 JLIOGCPKLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x5745650", Offset = "0x5744050", VA = "0x185745650", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x5747F90", Offset = "0x5746990", VA = "0x185747F90", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Quaternion OCGLMIOIKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x5746C30", Offset = "0x5745630", VA = "0x185746C30", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x5748320", Offset = "0x5746D20", VA = "0x185748320", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x5737FA0", Offset = "0x57369A0", VA = "0x185737FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event DGAAFHCPHEH IBFMPJKFDEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x57480B0", Offset = "0x5746AB0", VA = "0x1857480B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x5746670", Offset = "0x5745070", VA = "0x185746670", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5748C30", Offset = "0x5747630", VA = "0x185748C30")]
	public IHCNHADGBCB(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5746940", Offset = "0x5745340", VA = "0x185746940", Slot = "17")]
	public void FCDPOIHJAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x5745680", Offset = "0x5744080", VA = "0x185745680", Slot = "16")]
	public void AEAABDHDFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x5746370", Offset = "0x5744D70", VA = "0x185746370", Slot = "19")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x5748690", Offset = "0x5747090", VA = "0x185748690", Slot = "20")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5747FC0", Offset = "0x57469C0", VA = "0x185747FC0", Slot = "18")]
	public void IEIECPGHPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x5745A00", Offset = "0x5744400", VA = "0x185745A00", Slot = "21")]
	public void AMJHKJLPLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x573E210", Offset = "0x573CC10", VA = "0x18573E210")]
	public void AFBLDODBAMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x5746230", Offset = "0x5744C30", VA = "0x185746230")]
	private void PNBIFKFCFEF(Vector3 LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x5748340", Offset = "0x5746D40", VA = "0x185748340")]
	private Vector3 OMGBOJNFENG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x5748150", Offset = "0x5746B50", VA = "0x185748150")]
	private void MMGDLCDAMEC(float LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x5747DD0", Offset = "0x57467D0", VA = "0x185747DD0")]
	private void IAOOGBCNABD(float LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x5746710", Offset = "0x5745110", VA = "0x185746710")]
	private Vector3 EMNKCDOKIJP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5748460", Offset = "0x5746E60", VA = "0x185748460")]
	private void PBMBMDIIBMG(Vector3 LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x5745EF0", Offset = "0x57448F0", VA = "0x185745EF0")]
	private Quaternion ANKHAKNDHKM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x5748A10", Offset = "0x5747410", VA = "0x185748A10")]
	private void PMCIAKDJBLM(Quaternion LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x5746C60", Offset = "0x5745660", VA = "0x185746C60")]
	internal (float, Vector3) HCPEECAOGOM(Rigidbody BMDOKJBOKPE)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class JPHFHBIKMAL
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x574B8D0", Offset = "0x574A2D0", VA = "0x18574B8D0")]
	public static IHCNHADGBCB JIDBPFDBCJM(this NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class ACPOBIBHKIB : LPHFOFKHCNE, LBPABMNHAKF
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private const string DKCLIMFPCAB = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool OJDFKEJHLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x5735BD0", Offset = "0x57345D0", VA = "0x185735BD0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public JGBCGHMDEIJ PAEMELMEBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x5735BC0", Offset = "0x57345C0", VA = "0x185735BC0", Slot = "5")]
		get
		{
			return default(JGBCGHMDEIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private JGBCGHMDEIJ PFLJCKLKGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x5735DC0", Offset = "0x57347C0", VA = "0x185735DC0")]
		get
		{
			return default(JGBCGHMDEIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x5735FA0", Offset = "0x57349A0", VA = "0x185735FA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5736410", Offset = "0x5734E10", VA = "0x185736410")]
	public ACPOBIBHKIB(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x5736350", Offset = "0x5734D50", VA = "0x185736350", Slot = "6")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x5735B20", Offset = "0x5734520", VA = "0x185735B20")]
	private bool BPCPFBNLLLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x5735A20", Offset = "0x5734420", VA = "0x185735A20", Slot = "7")]
	public void BBPFDNFCENP(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x5735EA0", Offset = "0x57348A0", VA = "0x185735EA0", Slot = "8")]
	public void JDDFJPPACKN(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x5735CB0", Offset = "0x57346B0", VA = "0x185735CB0", Slot = "11")]
	public void EKFOLENAMJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x5736220", Offset = "0x5734C20", VA = "0x185736220")]
	private void NLCICEBEBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x57360D0", Offset = "0x5734AD0", VA = "0x1857360D0")]
	private void LPEGKOLKNAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x5736090", Offset = "0x5734A90", VA = "0x185736090", Slot = "10")]
	public void KONHDGEMJBN(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x5736310", Offset = "0x5734D10", VA = "0x185736310", Slot = "9")]
	public void OKPPPAGPECC(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class HOCAEFIHPFJ : LPHFOFKHCNE, KGDABPANOEG
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool FAJNDFDCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x57433E0", Offset = "0x5741DE0", VA = "0x1857433E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public IEnumerable<object> OPBNFDMBOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x57431A0", Offset = "0x5741BA0", VA = "0x1857431A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private bool JAGHPILGEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x57434A0", Offset = "0x5741EA0", VA = "0x1857434A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event DGAAFHCPHEH KOKLFFIBABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x5743290", Offset = "0x5741C90", VA = "0x185743290", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x5743340", Offset = "0x5741D40", VA = "0x185743340", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x57389E0", Offset = "0x57373E0", VA = "0x1857389E0")]
	public HOCAEFIHPFJ(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x5743140", Offset = "0x5741B40", VA = "0x185743140", Slot = "11")]
	public IDisposable EBMGEFKJGJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x5743330", Offset = "0x5741D30", VA = "0x185743330", Slot = "8")]
	public void LDMPNKDCNKH(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x5743280", Offset = "0x5741C80", VA = "0x185743280", Slot = "9")]
	public void FGAHJAEMBHA(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x57435B0", Offset = "0x5741FB0", VA = "0x1857435B0", Slot = "10")]
	public void PNGKMLMJNAK(object MIFCLBEAOPM, bool KLMBPMINIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x57430D0", Offset = "0x5741AD0", VA = "0x1857430D0", Slot = "12")]
	public void BOFMJFDPNBF(Rigidbody HKPNCKPHHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x5743580", Offset = "0x5741F80", VA = "0x185743580", Slot = "13")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class HJIMEIEFNLL : LPHFOFKHCNE, INNKCACPKLA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private PhotonView NIHEFIPHFDI;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool BBHAHOHMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x5741520", Offset = "0x573FF20", VA = "0x185741520", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool MPDIPBBGKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x5741D40", Offset = "0x5740740", VA = "0x185741D40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event DGAAFHCPHEH DELNFHCFIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x5741E50", Offset = "0x5740850", VA = "0x185741E50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x5741480", Offset = "0x573FE80", VA = "0x185741480", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x5742370", Offset = "0x5740D70", VA = "0x185742370")]
	public HJIMEIEFNLL(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x5742050", Offset = "0x5740A50", VA = "0x185742050", Slot = "8")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x5741540", Offset = "0x573FF40", VA = "0x185741540", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x5741B30", Offset = "0x5740530", VA = "0x185741B30", Slot = "9")]
	public void FPAGIJPELCJ(NCOEFPHLCKK GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x5741730", Offset = "0x5740130", VA = "0x185741730", Slot = "10")]
	public void EDIJKBDKKBN(NCOEFPHLCKK GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x5741940", Offset = "0x5740340", VA = "0x185741940")]
	private void FHAIJPNFBDJ(PhotonView CCKCOJFPKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x5741EF0", Offset = "0x57408F0", VA = "0x185741EF0")]
	private void NMOCGHMFIDJ(RigidbodyEx HLCKNLLPKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x57421A0", Offset = "0x5740BA0", VA = "0x1857421A0")]
	private void PDFJNKCICEB(PhotonView FGIJLKAFKLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class EIPKGBFBKEI
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x573C890", Offset = "0x573B290", VA = "0x18573C890")]
	public static HJIMEIEFNLL PFFJAHDNLIN(this PLOEBEDJGLE NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class MFPJGFBMPCG : LPHFOFKHCNE, IKFALNBDADN
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool KHDKIPLIJCN
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x5750180", Offset = "0x574EB80", VA = "0x185750180", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x574FF90", Offset = "0x574E990", VA = "0x18574FF90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool ILHHOPCAOME
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x574FDD0", Offset = "0x574E7D0", VA = "0x18574FDD0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x574FCE0", Offset = "0x574E6E0", VA = "0x18574FCE0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public RigidbodyConstraints AOEOJAJAPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x574FEB0", Offset = "0x574E8B0", VA = "0x18574FEB0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x5750260", Offset = "0x574EC60", VA = "0x185750260", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x5750460", Offset = "0x574EE60", VA = "0x185750460")]
	public MFPJGFBMPCG(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x574FBE0", Offset = "0x574E5E0", VA = "0x18574FBE0", Slot = "9")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x5750080", Offset = "0x574EA80", VA = "0x185750080", Slot = "10")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class EODIHAMODMJ : LPHFOFKHCNE, CAONNBLCKEG
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public float PGABAKFPNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x573CE60", Offset = "0x573B860", VA = "0x18573CE60", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x573CAC0", Offset = "0x573B4C0", VA = "0x18573CAC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public float DCNFDLOMNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x573CF40", Offset = "0x573B940", VA = "0x18573CF40", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x573CC90", Offset = "0x573B690", VA = "0x18573CC90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x57389E0", Offset = "0x57373E0", VA = "0x1857389E0")]
	public EODIHAMODMJ(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x573C8F0", Offset = "0x573B2F0", VA = "0x18573C8F0", Slot = "8")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x573D020", Offset = "0x573BA20", VA = "0x18573D020", Slot = "9")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[HAMPPOKOPOP(typeof(NKLBMAPECJD), new string[] { })]
	[JEGJCCBDMOE(OLCAJGBKOGB.Physics)]
	public sealed class RbexServiceCallbacks : GBCNOEIKEOL, NKLBMAPECJD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly KLBHBMBPLOA JFFPIFJCILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private ABGDBOLFPHD IILFNNEDNCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private bool FCPODLMHINC;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool AMOPNJPCIDE
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x72B260", Offset = "0x729C60", VA = "0x18072B260", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x697E370", Offset = "0x697CD70", VA = "0x18697E370", Slot = "4")]
		public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x697E340", Offset = "0x697CD40", VA = "0x18697E340", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x697E3C0", Offset = "0x697CDC0", VA = "0x18697E3C0", Slot = "6")]
		public void HCPEECAOGOM(MBEDCJLMHEO LKHNLAILFFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public RbexServiceCallbacks()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class GJAKHGNMFAD : LPHFOFKHCNE, EIMJIHNCMHI
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const int BODIPJBOABD = 10;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public const float LEOMFFLEOJP = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const float GJBNLKILOFJ = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public const float MDELHFJODGE = 5f;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x5737FA0", Offset = "0x57369A0", VA = "0x185737FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool HBCBGANJMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x573DBA0", Offset = "0x573C5A0", VA = "0x18573DBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool LFGDELENJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x573B900", Offset = "0x573A300", VA = "0x18573B900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x573DFA0", Offset = "0x573C9A0", VA = "0x18573DFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private bool KMDIPAOGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x573DD20", Offset = "0x573C720", VA = "0x18573DD20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool FHNFDKLFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x573DC40", Offset = "0x573C640", VA = "0x18573DC40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x573D370", Offset = "0x573BD70", VA = "0x18573D370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private bool OBAKHFEALOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x573D460", Offset = "0x573BE60", VA = "0x18573D460")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x573DAB0", Offset = "0x573C4B0", VA = "0x18573DAB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private int BIDOOJBIHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x573D9D0", Offset = "0x573C3D0", VA = "0x18573D9D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x573D6F0", Offset = "0x573C0F0", VA = "0x18573D6F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event DGAAFHCPHEH BGFDOMIHHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x573E010", Offset = "0x573CA10", VA = "0x18573E010", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x573D7E0", Offset = "0x573C1E0", VA = "0x18573D7E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x573E300", Offset = "0x573CD00", VA = "0x18573E300")]
	public GJAKHGNMFAD(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x573E0B0", Offset = "0x573CAB0", VA = "0x18573E0B0", Slot = "6")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x573E000", Offset = "0x573CA00", VA = "0x18573E000", Slot = "8")]
	public void NKFCECIGMAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x573DD80", Offset = "0x573C780", VA = "0x18573DD80", Slot = "7")]
	public bool NEPEFPHIELC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x573E250", Offset = "0x573CC50", VA = "0x18573E250", Slot = "9")]
	public void PKFLOCAHJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x573E210", Offset = "0x573CC10", VA = "0x18573E210", Slot = "12")]
	public void PHLPAOAPADB(bool DFLJHGHEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x573E160", Offset = "0x573CB60", VA = "0x18573E160", Slot = "11")]
	public void PFPLFILECPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "10")]
	public void LMCNKOCFNJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x573D540", Offset = "0x573BF40", VA = "0x18573D540")]
	private bool BEIPPJFGNKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x573D880", Offset = "0x573C280", VA = "0x18573D880")]
	private void GKLPFICFPDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class JOCMIJIKNOI : LPHFOFKHCNE, IPANMLAMAAD
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private const string EKLCKOGJHLL = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x574B200", Offset = "0x5749C00", VA = "0x18574B200", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x574B5A0", Offset = "0x5749FA0", VA = "0x18574B5A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private bool KMDIPAOGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x57384F0", Offset = "0x5736EF0", VA = "0x1857384F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x574B840", Offset = "0x574A240", VA = "0x18574B840")]
	public JOCMIJIKNOI(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x574B790", Offset = "0x574A190", VA = "0x18574B790", Slot = "5")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x574B690", Offset = "0x574A090", VA = "0x18574B690", Slot = "6")]
	public void KPOLANLNJJI(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x574B2E0", Offset = "0x5749CE0", VA = "0x18574B2E0", Slot = "7")]
	public void HIBCGDMOODJ(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x574A950", Offset = "0x5749350", VA = "0x18574A950", Slot = "8")]
	public void EDEILOABNOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x574ADD0", Offset = "0x57497D0", VA = "0x18574ADD0", Slot = "9")]
	public void EONBBMLLGPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x574B030", Offset = "0x5749A30", VA = "0x18574B030", Slot = "10")]
	public void FDIDMCANFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "11")]
	public void IKMAJMOKAJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x574AC10", Offset = "0x5749610", VA = "0x18574AC10")]
	private void EOLCGNDNPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x574B3E0", Offset = "0x5749DE0", VA = "0x18574B3E0")]
	private void KAMMGDNLJDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class DJFIPOGEBKP : LPHFOFKHCNE, ODMDEDICELM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public EKLLOLLHLDP LNMCPLFHCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x573C590", Offset = "0x573AF90", VA = "0x18573C590", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5739890", Offset = "0x5738290", VA = "0x185739890", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public CHACNCJIDJM GJHPEGFOAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x57395D0", Offset = "0x5737FD0", VA = "0x1857395D0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x573A980", Offset = "0x5739380", VA = "0x18573A980", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 LGEGEJPPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x57392B0", Offset = "0x5737CB0", VA = "0x1857392B0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5739AD0", Offset = "0x57384D0", VA = "0x185739AD0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 JBHIDAJMGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x573B0A0", Offset = "0x5739AA0", VA = "0x18573B0A0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x573A1C0", Offset = "0x5738BC0", VA = "0x18573A1C0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Vector3 LJMFIEJCGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5739980", Offset = "0x5738380", VA = "0x185739980", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5739510", Offset = "0x5737F10", VA = "0x185739510", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 ICEKJCBHJBH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x573B370", Offset = "0x5739D70", VA = "0x18573B370", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x573B2D0", Offset = "0x5739CD0", VA = "0x18573B2D0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public float KKALKPOINCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x5739B90", Offset = "0x5738590", VA = "0x185739B90", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x5739FC0", Offset = "0x57389C0", VA = "0x185739FC0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool LIGEJEKODFL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x573B1F0", Offset = "0x5739BF0", VA = "0x18573B1F0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private BDJOPHNNEJG AODMDOCLCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x1D9F4C0", Offset = "0x1D9DEC0", VA = "0x181D9F4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private bool LFGDELENJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x573B900", Offset = "0x573A300", VA = "0x18573B900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x57389E0", Offset = "0x57373E0", VA = "0x1857389E0")]
	public DJFIPOGEBKP(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x573B810", Offset = "0x573A210", VA = "0x18573B810", Slot = "20")]
	public void KNFJENEFGIE(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x573B920", Offset = "0x573A320", VA = "0x18573B920", Slot = "31")]
	public void NEMGEGCJOPN(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x573B300", Offset = "0x5739D00", VA = "0x18573B300", Slot = "19")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5739E90", Offset = "0x5738890", VA = "0x185739E90", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5739850", Offset = "0x5738250", VA = "0x185739850", Slot = "28")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x57390D0", Offset = "0x5737AD0", VA = "0x1857390D0", Slot = "36")]
	public Vector3 AFFCJBHNNJL(Vector3 JOJEMOKKGPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x573B650", Offset = "0x573A050", VA = "0x18573B650", Slot = "35")]
	public Vector3 KIKKEDPKAKK(Vector3 HMPFDEAFPND)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x573B300", Offset = "0x5739D00", VA = "0x18573B300", Slot = "27")]
	public void INLPOAEPJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5739810", Offset = "0x5738210", VA = "0x185739810", Slot = "25")]
	public void BHDNAPGFIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x573B1B0", Offset = "0x5739BB0", VA = "0x18573B1B0", Slot = "24")]
	public void IFMLGPGPJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x573BA10", Offset = "0x573A410", VA = "0x18573BA10", Slot = "34")]
	public void NGFKLMPAGOE(Vector3 GKKEEHNMPBL, Vector3 NFGPCLPNMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x573B490", Offset = "0x5739E90", VA = "0x18573B490", Slot = "33")]
	public void JLDEEBLCKGA(Vector3 FHKLDEIKECB, Vector3 FHFHNDANMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x573B4F0", Offset = "0x5739EF0", VA = "0x18573B4F0", Slot = "32")]
	public void KIIDBBLBANB(Vector3 JDDALKKDLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x573A2E0", Offset = "0x5738CE0", VA = "0x18573A2E0", Slot = "22")]
	public void HHAFJJGJPFB(EECECFKKEJP KMDODPJBKLE, Vector3 CFLMAEMNHKL, float ABGPHLFIFAO, float OPCFMELHIKJ = 8f, float ECOHALOPPDN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x573A750", Offset = "0x5739150", VA = "0x18573A750", Slot = "21")]
	public void HHLJBCNAEPM(JDHBHPOMECG EFAKAOJPAJJ, Vector3 PKAJMBKNJIL, float KBLOKDLNEPD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x573ADD0", Offset = "0x57397D0", VA = "0x18573ADD0", Slot = "23")]
	[Obsolete]
	public void IALNLOAFGMK(JDHBHPOMECG EFAKAOJPAJJ, Vector3 IHCJBCJFELL, float MEJPNNANPLH = 7f, float CKIIILKMBKK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5739DD0", Offset = "0x57387D0", VA = "0x185739DD0", Slot = "30")]
	public Vector3 DNICIBAAMCG(Vector3 GCAABCBBBAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x573A1F0", Offset = "0x5738BF0", VA = "0x18573A1F0", Slot = "29")]
	public Vector3 GJAHBCCOAII(Vector3 DIIFLOBFBLO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x573A090", Offset = "0x5738A90", VA = "0x18573A090", Slot = "26")]
	public void EPOKPKAANHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x573C6C0", Offset = "0x573B0C0", VA = "0x18573C6C0")]
	private void PPEMJOPAMJI(float LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5739C70", Offset = "0x5738670", VA = "0x185739C70")]
	private void DKLBMGLGABJ(Vector3 PKAJMBKNJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5739400", Offset = "0x5737E00", VA = "0x185739400")]
	private Vector3 AIPGGJCOIBK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x573BC50", Offset = "0x573A650", VA = "0x18573BC50")]
	private void OIMGBAHMGOG(Vector3 HMPFDEAFPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5739700", Offset = "0x5738100", VA = "0x185739700")]
	private Vector3 BGJJOBCDBBC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x573AA70", Offset = "0x5739470", VA = "0x18573AA70")]
	private void HOGMIBAAANA(Vector3 LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x573BF90", Offset = "0x573A990", VA = "0x18573BF90")]
	private void OPKJDBGLKOE(Vector3 HMPFDEAFPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x5739FD0", Offset = "0x57389D0", VA = "0x185739FD0")]
	private void EKIKIKBLFAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class LPHFOFKHCNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly KNGEGNFMEDP IILFNNEDNCJ;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected ABGDBOLFPHD IGNBGAICHNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xBC8AD0", Offset = "0xBC74D0", VA = "0x180BC8AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected MBEDCJLMHEO BEFNGGLNHMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x574FAA0", Offset = "0x574E4A0", VA = "0x18574FAA0")]
		get
		{
			return default(MBEDCJLMHEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x57389E0", Offset = "0x57373E0", VA = "0x1857389E0")]
	public LPHFOFKHCNE(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x574F980", Offset = "0x574E380", VA = "0x18574F980")]
	protected NCOEFPHLCKK AEPMGFDGAMM(MBEDCJLMHEO LMLBLIDPKCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class KCDDPFPGDON : CCKADDACLBD
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x574CE20", Offset = "0x574B820", VA = "0x18574CE20", Slot = "4")]
	public PLDJMDIFCKE HPIEMLILMFL(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x574CF90", Offset = "0x574B990", VA = "0x18574CF90", Slot = "5")]
	public ODMDEDICELM IINCPPFHAME(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x574D510", Offset = "0x574BF10", VA = "0x18574D510", Slot = "6")]
	public IMBEMHENMNJ MOJGNMKJFLF(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x574D030", Offset = "0x574BA30", VA = "0x18574D030", Slot = "7")]
	public CAONNBLCKEG ILCPDNKDAKJ(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x574D280", Offset = "0x574BC80", VA = "0x18574D280", Slot = "8")]
	public EIMJIHNCMHI KJNNEGNLPCG(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x574D140", Offset = "0x574BB40", VA = "0x18574D140", Slot = "9")]
	public JBCOLILENLD JDEHAKBEPFB(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x574CB60", Offset = "0x574B560", VA = "0x18574CB60", Slot = "10")]
	public KGDABPANOEG CLMAKHLOHMN(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x574D2E0", Offset = "0x574BCE0", VA = "0x18574D2E0", Slot = "11")]
	public BDJOPHNNEJG LAGKMHIIGOF(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x574D1E0", Offset = "0x574BBE0", VA = "0x18574D1E0", Slot = "12")]
	public AIOOGANOGPH JNMPFOJECMI(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x574CCC0", Offset = "0x574B6C0", VA = "0x18574CCC0", Slot = "13")]
	public BBGAPPNBFLO DPGNNNONAOD(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x574CC00", Offset = "0x574B600", VA = "0x18574CC00")]
	public IPANMLAMAAD MNBKDOEPCLE(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x574CD60", Offset = "0x574B760", VA = "0x18574CD60")]
	public INNKCACPKLA HPGHLDDNEHH(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x574D380", Offset = "0x574BD80", VA = "0x18574D380")]
	public LBPABMNHAKF OCGJAPKHCOA(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x574CA40", Offset = "0x574B440", VA = "0x18574CA40")]
	public OGBLFJOOHEI BMJLAHFILLO(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x574D0D0", Offset = "0x574BAD0", VA = "0x18574D0D0")]
	public IKFALNBDADN KIKLIMOCIDB(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x574CAB0", Offset = "0x574B4B0", VA = "0x18574CAB0", Slot = "19")]
	public NCOEFPHLCKK APMJEHJBGBJ(RigidbodyEx IILFNNEDNCJ, JCAJMGPJNDN HIDEHJGLNHO, BKDMDHLJAEJ CMIHNHHBGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KCDDPFPGDON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x574CC00", Offset = "0x574B600", VA = "0x18574CC00", Slot = "14")]
	private IPANMLAMAAD DBBGHPHPGNC(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x574CD60", Offset = "0x574B760", VA = "0x18574CD60", Slot = "15")]
	private INNKCACPKLA IACLMNOIKMC(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x574D380", Offset = "0x574BD80", VA = "0x18574D380", Slot = "16")]
	private LBPABMNHAKF MFFOKDJHDOK(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x574CA40", Offset = "0x574B440", VA = "0x18574CA40", Slot = "17")]
	private OGBLFJOOHEI AFFGIKNDDLN(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x574D0D0", Offset = "0x574BAD0", VA = "0x18574D0D0", Slot = "18")]
	private IKFALNBDADN ILNOMKKJMMB(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class GMOJEAHHPKO : IReadOnlyList<NCOEFPHLCKK>, IEnumerable<NCOEFPHLCKK>, IEnumerable, IReadOnlyCollection<NCOEFPHLCKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly MBEDCJLMHEO LMLBLIDPKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly ABGDBOLFPHD LHDJJEMNOIF;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int JAMIBFCLJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x5741140", Offset = "0x573FB40", VA = "0x185741140", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public NCOEFPHLCKK JNKMHBEEDBP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x5741210", Offset = "0x573FC10", VA = "0x185741210", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x57410F0", Offset = "0x573FAF0", VA = "0x1857410F0")]
	public GMOJEAHHPKO(MBEDCJLMHEO LMLBLIDPKCN, ABGDBOLFPHD LHDJJEMNOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5740F50", Offset = "0x573F950", VA = "0x185740F50", Slot = "6")]
	public IEnumerator<NCOEFPHLCKK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x5740F50", Offset = "0x573F950", VA = "0x185740F50", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x57410E0", Offset = "0x573FAE0", VA = "0x1857410E0")]
	[CompilerGenerated]
	private NCOEFPHLCKK LMNEAPADJMJ(int FMPGMDDDGFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[HAMPPOKOPOP(typeof(CCKADDACLBD), new string[] { })]
public class LJABFKEOBMH : CCKADDACLBD, GBCNOEIKEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly CCKADDACLBD IOLLFKFHGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly CCKADDACLBD EGACOJLEBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private LPHNFCPFJBF KHKOGBBOGKO;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private CCKADDACLBD BLIAEGBHDHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x574F880", Offset = "0x574E280", VA = "0x18574F880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x574F120", Offset = "0x574DB20", VA = "0x18574F120", Slot = "20")]
	public void FLFPICJOFML(FJEOEPCCLME JGMMDACFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x574F220", Offset = "0x574DC20", VA = "0x18574F220", Slot = "4")]
	public PLDJMDIFCKE HPIEMLILMFL(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x574F2C0", Offset = "0x574DCC0", VA = "0x18574F2C0", Slot = "5")]
	public ODMDEDICELM IINCPPFHAME(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x574F7E0", Offset = "0x574E1E0", VA = "0x18574F7E0", Slot = "6")]
	public IMBEMHENMNJ MOJGNMKJFLF(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x574F360", Offset = "0x574DD60", VA = "0x18574F360", Slot = "7")]
	public CAONNBLCKEG ILCPDNKDAKJ(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x574F5F0", Offset = "0x574DFF0", VA = "0x18574F5F0", Slot = "8")]
	public EIMJIHNCMHI KJNNEGNLPCG(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x574F4B0", Offset = "0x574DEB0", VA = "0x18574F4B0", Slot = "9")]
	public JBCOLILENLD JDEHAKBEPFB(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x574EF30", Offset = "0x574D930", VA = "0x18574EF30", Slot = "10")]
	public KGDABPANOEG CLMAKHLOHMN(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x574F690", Offset = "0x574E090", VA = "0x18574F690", Slot = "11")]
	public BDJOPHNNEJG LAGKMHIIGOF(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x574F550", Offset = "0x574DF50", VA = "0x18574F550", Slot = "12")]
	public AIOOGANOGPH JNMPFOJECMI(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x574F080", Offset = "0x574DA80", VA = "0x18574F080", Slot = "13")]
	public BBGAPPNBFLO DPGNNNONAOD(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x574EFD0", Offset = "0x574D9D0", VA = "0x18574EFD0")]
	public IPANMLAMAAD MNBKDOEPCLE(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x574F170", Offset = "0x574DB70", VA = "0x18574F170")]
	public INNKCACPKLA HPGHLDDNEHH(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x574F730", Offset = "0x574E130", VA = "0x18574F730")]
	public LBPABMNHAKF OCGJAPKHCOA(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x574ED30", Offset = "0x574D730", VA = "0x18574ED30")]
	public OGBLFJOOHEI BMJLAHFILLO(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x574F400", Offset = "0x574DE00", VA = "0x18574F400")]
	public IKFALNBDADN KIKLIMOCIDB(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x574EDE0", Offset = "0x574D7E0", VA = "0x18574EDE0", Slot = "19")]
	public NCOEFPHLCKK APMJEHJBGBJ(RigidbodyEx IILFNNEDNCJ, JCAJMGPJNDN HIDEHJGLNHO, BKDMDHLJAEJ CMIHNHHBGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x574F8E0", Offset = "0x574E2E0", VA = "0x18574F8E0")]
	public LJABFKEOBMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x574EFD0", Offset = "0x574D9D0", VA = "0x18574EFD0", Slot = "14")]
	private IPANMLAMAAD DBBGHPHPGNC(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x574F170", Offset = "0x574DB70", VA = "0x18574F170", Slot = "15")]
	private INNKCACPKLA IACLMNOIKMC(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x574F730", Offset = "0x574E130", VA = "0x18574F730", Slot = "16")]
	private LBPABMNHAKF MFFOKDJHDOK(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x574ED30", Offset = "0x574D730", VA = "0x18574ED30", Slot = "17")]
	private OGBLFJOOHEI AFFGIKNDDLN(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x574F400", Offset = "0x574DE00", VA = "0x18574F400", Slot = "18")]
	private IKFALNBDADN ILNOMKKJMMB(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Preserve]
public sealed class IBKOCLOMPFN : NCOEFPHLCKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly IBKOCLOMPFN AGBLMGNNIDO;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public RigidbodyEx OEOEKIBFEMO
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public GameObject MILHHPLGFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Transform LHEBMCHBDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x72B270", Offset = "0x729C70", VA = "0x18072B270", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public IEnumerable<object> IMECMIODOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x731A10", Offset = "0x730410", VA = "0x180731A10", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x731A20", Offset = "0x730420", VA = "0x180731A20", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public IReadOnlyList<NCOEFPHLCKK> PHPDFDJEEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x770FF0", Offset = "0x76F9F0", VA = "0x180770FF0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public NCOEFPHLCKK CMJKBCMDGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x7270F0", Offset = "0x725AF0", VA = "0x1807270F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool KMDIPAOGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x13FB6E0", Offset = "0x13FA0E0", VA = "0x1813FB6E0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool BBHAHOHMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x11C71D0", Offset = "0x11C5BD0", VA = "0x1811C71D0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool MPDIPBBGKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xB962C0", Offset = "0xB94CC0", VA = "0x180B962C0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public EKLLOLLHLDP LNMCPLFHCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x7270D0", Offset = "0x725AD0", VA = "0x1807270D0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x8093D0", Offset = "0x807DD0", VA = "0x1808093D0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public CHACNCJIDJM GJHPEGFOAME
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7270B0", Offset = "0x725AB0", VA = "0x1807270B0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x7B2610", Offset = "0x7B1010", VA = "0x1807B2610", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public float KKALKPOINCB
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x16C43F0", Offset = "0x16C2DF0", VA = "0x1816C43F0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x16C4490", Offset = "0x16C2E90", VA = "0x1816C4490", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 JBHIDAJMGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2DEC3A0", Offset = "0x2DEADA0", VA = "0x182DEC3A0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x2DE8460", Offset = "0x2DE6E60", VA = "0x182DE8460", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 ICEKJCBHJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x1496820", Offset = "0x1495220", VA = "0x181496820", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x14926B0", Offset = "0x14910B0", VA = "0x1814926B0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 LGEGEJPPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x1496840", Offset = "0x1495240", VA = "0x181496840", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1494400", Offset = "0x1492E00", VA = "0x181494400", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Vector3 LJMFIEJCGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1163260", Offset = "0x1161C60", VA = "0x181163260", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool NHCAAMEDKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xBCC700", Offset = "0xBCB100", VA = "0x180BCC700", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool GDCCIECOAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xBF7ED0", Offset = "0xBF68D0", VA = "0x180BF7ED0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool ABAINBEINAC
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xBF7EC0", Offset = "0xBF68C0", VA = "0x180BF7EC0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool LIGEJEKODFL
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xA8BF10", Offset = "0xA8A910", VA = "0x180A8BF10", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Vector3 BFENAJAEKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x172F3D0", Offset = "0x172DDD0", VA = "0x18172F3D0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 LECHPMMLACE
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x13CA820", Offset = "0x13C9220", VA = "0x1813CA820", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 BMNHHGGIMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x1163260", Offset = "0x1161C60", VA = "0x181163260", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 ICDJEGJHDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x1496900", Offset = "0x1495300", VA = "0x181496900", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public float AHNCJOKPCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x216D200", Offset = "0x216BC00", VA = "0x18216D200", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float JAHICELIBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x12E9F50", Offset = "0x12E8950", VA = "0x1812E9F50", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 JLIOGCPKLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x1163260", Offset = "0x1161C60", VA = "0x181163260", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion OCGLMIOIKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x127BBD0", Offset = "0x127A5D0", VA = "0x18127BBD0", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public float PGABAKFPNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x12E9F50", Offset = "0x12E8950", VA = "0x1812E9F50", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public float DCNFDLOMNCM
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x12E9F50", Offset = "0x12E8950", VA = "0x1812E9F50", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool OGIIANAEIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool ODGKAIJIABE
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public GGPABLKNBJB LEKOFMMMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "52")]
		get
		{
			return default(GGPABLKNBJB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool FAJNDFDCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x21ADCB0", Offset = "0x21AC6B0", VA = "0x1821ADCB0", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Transform KMDNPAAIEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x82B350", Offset = "0x829D50", VA = "0x18082B350", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Transform FNPJMEGGLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x7C9480", Offset = "0x7C7E80", VA = "0x1807C9480", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Vector3 BLGJDGKFELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x1163260", Offset = "0x1161C60", VA = "0x181163260", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float CLIPDFNDOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x12E9F50", Offset = "0x12E8950", VA = "0x1812E9F50", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public float JHDBNDJGACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x12E9F50", Offset = "0x12E8950", VA = "0x1812E9F50", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Quaternion INFAOAKNLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x11E6600", Offset = "0x11E5000", VA = "0x1811E6600", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Vector3 NAILLMLOGGK
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x1163260", Offset = "0x1161C60", VA = "0x181163260", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Quaternion FBMHBHAGGPI
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x11E6600", Offset = "0x11E5000", VA = "0x1811E6600", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public RigidbodyConstraints AOEOJAJAPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x72B5A0", Offset = "0x729FA0", VA = "0x18072B5A0", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool KHDKIPLIJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public CollisionDetectionMode PAOOKBBFCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x72B5A0", Offset = "0x729FA0", VA = "0x18072B5A0", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool LFGDELENJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x1283730", Offset = "0x1282130", VA = "0x181283730", Slot = "75")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event DGAAFHCPHEH NJJHHELIHIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event DGAAFHCPHEH EPBNCIPAFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event MKKJLKCGEAC EIBHEHIGCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event DGAAFHCPHEH DELNFHCFIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event DGAAFHCPHEH DHIFCNEILML
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event DGAAFHCPHEH BGFDOMIHHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<FCDCKNBKJML, FCDCKNBKJML> DLLBDKMMJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event DGAAFHCPHEH FCJJAJLCBGC
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event DGAAFHCPHEH MGPMCLDJCJA
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "125")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "126")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "76")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "77")]
	public void AOLBABCADFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "78")]
	public void NKMAPFPPLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "79")]
	public void PKFLOCAHJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "80")]
	public void MCKPAKFDOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "87")]
	public void DEIBNNOCJKC(NCOEFPHLCKK LPJDDLMPNCG, bool OMIKAFGHIFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "90")]
	public void KMKIMCBMAFA(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "91")]
	public void JCGBFLMHKCG(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x1163260", Offset = "0x1161C60", VA = "0x181163260", Slot = "92")]
	public Vector3 AFFCJBHNNJL(Vector3 JOJEMOKKGPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x1163260", Offset = "0x1161C60", VA = "0x181163260", Slot = "93")]
	public Vector3 KIKKEDPKAKK(Vector3 HMPFDEAFPND)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "94")]
	public void INLPOAEPJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "95")]
	public void BHDNAPGFIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "96")]
	public void IFMLGPGPJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "97")]
	public void NGFKLMPAGOE(Vector3 GKKEEHNMPBL, Vector3 NFGPCLPNMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "98")]
	public void JLDEEBLCKGA(Vector3 FHKLDEIKECB, Vector3 FHFHNDANMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "99")]
	public void KIIDBBLBANB(Vector3 JDDALKKDLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "100")]
	public void HHAFJJGJPFB(EECECFKKEJP KMDODPJBKLE, Vector3 CFLMAEMNHKL, float ABGPHLFIFAO, float OPCFMELHIKJ = 8f, float ECOHALOPPDN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "101")]
	public void HHLJBCNAEPM(JDHBHPOMECG EFAKAOJPAJJ, Vector3 PKAJMBKNJIL, float KBLOKDLNEPD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "102")]
	public void IALNLOAFGMK(JDHBHPOMECG EFAKAOJPAJJ, Vector3 IHCJBCJFELL, float MEJPNNANPLH = 7f, float CKIIILKMBKK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x1163260", Offset = "0x1161C60", VA = "0x181163260", Slot = "103")]
	public Vector3 DNICIBAAMCG(Vector3 LPJDDLMPNCG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x1163260", Offset = "0x1161C60", VA = "0x181163260", Slot = "104")]
	public Vector3 GJAHBCCOAII(Vector3 LPJDDLMPNCG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "105")]
	public void EPOKPKAANHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "106")]
	public void OIHMDCKKBFA(NCOEFPHLCKK BKGBHBNCDJA, object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "107")]
	public void ELAHEJFDAHO(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "110")]
	public void FCDPOIHJAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "111")]
	public void AEAABDHDFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "112")]
	public void IEIECPGHPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "115")]
	public bool NEPEFPHIELC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "116")]
	public void PFPLFILECPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x72B5A0", Offset = "0x729FA0", VA = "0x18072B5A0", Slot = "121")]
	public IDisposable EBMGEFKJGJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "122")]
	public void LDMPNKDCNKH(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "123")]
	public void FGAHJAEMBHA(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "124")]
	public void PNGKMLMJNAK(object MIFCLBEAOPM, bool KLMBPMINIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "127")]
	public void LOKMBIPHOGK(Vector3 PGJOODJOMAI, Quaternion OMJBPOHHBNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "128")]
	public void OFCCCKGCAPP(Vector3 PPNOLBKPBJH, Quaternion KAHANPFONLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "129")]
	public bool AMLDEGGHKAD(float ANPGDIDDDCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "130")]
	public void HMHFMGOKMHP(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "131")]
	public void KNMLFLHNFDJ(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "132")]
	public void KPOLANLNJJI(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "133")]
	public void HIBCGDMOODJ(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "134")]
	public void BEJNHGKJNLM(Vector3 HKPPDHFDHMN, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "135")]
	public void CBMEMNKKLDE(Vector3 HKPPDHFDHMN, Vector3 PICDPPHNNLH, ForceMode MPMGBCACKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "136")]
	public void OHNHDPGFLAC(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "137")]
	public void PPDGHDJCFAP(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x5745510", Offset = "0x5743F10", VA = "0x185745510", Slot = "138")]
	public bool OFDKFHJBLOJ(Vector3 MFKKMPGAJFI, out RaycastHit ONOMCDOFLKH, float CBFODBDKBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "139")]
	public void AMJHKJLPLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public IBKOCLOMPFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class KNGEGNFMEDP : PLOEBEDJGLE, KDBGLABEDCA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	internal MBEDCJLMHEO LMLBLIDPKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	internal ABGDBOLFPHD ENDDCBHJOLK;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x574ED20", Offset = "0x574D720", VA = "0x18574ED20")]
	public KNGEGNFMEDP(GameObject DLNMCGFEPOP, RigidbodyEx MCLIFNMABNA, BKDMDHLJAEJ CMIHNHHBGOO, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x574E810", Offset = "0x574D210", VA = "0x18574E810", Slot = "142")]
	protected override void FOIMKAENAPH(BKDMDHLJAEJ CMIHNHHBGOO, JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x574E4F0", Offset = "0x574CEF0", VA = "0x18574E4F0", Slot = "143")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x574E740", Offset = "0x574D140", VA = "0x18574E740", Slot = "145")]
	public void FFNAHMJFGNN(PHOCPPOEDBC DKOFAPECACL, PHOCPPOEDBC JFNADPGFOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x574E680", Offset = "0x574D080", VA = "0x18574E680", Slot = "146")]
	public void EBCHKCMKFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x574EC00", Offset = "0x574D600", VA = "0x18574EC00", Slot = "147")]
	public void LECPOGDAAEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x574ECC0", Offset = "0x574D6C0", VA = "0x18574ECC0", Slot = "148")]
	public void PHLPAOAPADB(bool DFLJHGHEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x574EAA0", Offset = "0x574D4A0", VA = "0x18574EAA0", Slot = "149")]
	public bool KOAJJHHAGFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "144")]
	public override void MCKPAKFDOPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class LPLLHKKDBOF
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x574FAD0", Offset = "0x574E4D0", VA = "0x18574FAD0")]
	public static PLOEBEDJGLE GCBNHDAINOK(this NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface BAOLOJAHLLA : PLDJMDIFCKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBIPGKKJCGE(NCOEFPHLCKK IILFNNEDNCJ);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHJPDJCNJIO(NCOEFPHLCKK IILFNNEDNCJ);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OAJEEOBFKGI(NCOEFPHLCKK EMJBGADPLOE);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FEBKLPDLGMF(NCOEFPHLCKK EMJBGADPLOE);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface HOBENBLCEGH : IMBEMHENMNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	global::NFFFIELCCID<NCOEFPHLCKK> PCADFNIAGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	NCOEFPHLCKK KJCAOKIHBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface EJLCPNDNOPA : OGBLFJOOHEI
{
	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) HCPEECAOGOM(Rigidbody BMDOKJBOKPE);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface KJOHJJNNODA : INNKCACPKLA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	PhotonView PPFKDGBOMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class DHCELJMCPKJ : AIOOGANOGPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private CollisionDetectionMode ODBBONENPLE;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x5737FA0", Offset = "0x57369A0", VA = "0x185737FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public CollisionDetectionMode PAOOKBBFCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x5738E10", Offset = "0x5737810", VA = "0x185738E10", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x5738C30", Offset = "0x5737630", VA = "0x185738C30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x5739040", Offset = "0x5737A40", VA = "0x185739040")]
	public DHCELJMCPKJ(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x5738F20", Offset = "0x5737920", VA = "0x185738F20", Slot = "6")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x5738A60", Offset = "0x5737460", VA = "0x185738A60", Slot = "9")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x5738C10", Offset = "0x5737610", VA = "0x185738C10", Slot = "7")]
	public void DLGGDMCBIHM(bool OJNHEHLGDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x5738C20", Offset = "0x5737620", VA = "0x185738C20", Slot = "8")]
	public void FICHJHCOBIG(bool OJNHEHLGDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x5738CA0", Offset = "0x57376A0", VA = "0x185738CA0", Slot = "10")]
	public bool OFDKFHJBLOJ(Vector3 MFKKMPGAJFI, out RaycastHit ONOMCDOFLKH, float CBFODBDKBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x5738AE0", Offset = "0x57374E0", VA = "0x185738AE0")]
	private void DAOOMGFPAAE(bool OJNHEHLGDGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class DFEIONJIKJB : JBCOLILENLD, IDisposable, FLCKAICBODN
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const int ANLGCFMELOM = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private GGPABLKNBJB IOBNLGDAEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private KKMENLLDAPN EJCAONAAFLL;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public GGPABLKNBJB LEKOFMMMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x5737650", Offset = "0x5736050", VA = "0x185737650", Slot = "6")]
		get
		{
			return default(GGPABLKNBJB);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x5737500", Offset = "0x5735F00", VA = "0x185737500", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Transform OACKHJKFCIO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x5737630", Offset = "0x5736030", VA = "0x185737630", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<FCDCKNBKJML, FCDCKNBKJML> DLLBDKMMJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x5737410", Offset = "0x5735E10", VA = "0x185737410", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x5737790", Offset = "0x5736190", VA = "0x185737790", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x5737B10", Offset = "0x5736510", VA = "0x185737B10")]
	public DFEIONJIKJB(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x5737830", Offset = "0x5736230", VA = "0x185737830", Slot = "8")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x57374B0", Offset = "0x5735EB0", VA = "0x1857374B0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x57375D0", Offset = "0x5735FD0", VA = "0x1857375D0", Slot = "11")]
	private void FFJAMPMFIBH(FCDCKNBKJML NBPFLJDNNCH, FCDCKNBKJML ABBGLPJCAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "12")]
	private void CDNBHJPFKMB(bool FHFGDHHLCHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class IIFHDLPGBCO : BDJOPHNNEJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x5737FA0", Offset = "0x57369A0", VA = "0x185737FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private bool FAJNDFDCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x5738550", Offset = "0x5736F50", VA = "0x185738550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private bool KMDIPAOGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x57384F0", Offset = "0x5736EF0", VA = "0x1857384F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x57497F0", Offset = "0x57481F0", VA = "0x1857497F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x5739040", Offset = "0x5737A40", VA = "0x185739040")]
	public IIFHDLPGBCO(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x5748EF0", Offset = "0x57478F0", VA = "0x185748EF0", Slot = "4")]
	public void BEJNHGKJNLM(Vector3 HKPPDHFDHMN, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x57492F0", Offset = "0x5747CF0", VA = "0x1857492F0")]
	private void GNLGGMKPOAG(Vector3 HKPPDHFDHMN, ForceMode MPMGBCACKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x5749050", Offset = "0x5747A50", VA = "0x185749050", Slot = "5")]
	public void CBMEMNKKLDE(Vector3 HKPPDHFDHMN, Vector3 PICDPPHNNLH, ForceMode MPMGBCACKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x5749850", Offset = "0x5748250", VA = "0x185749850", Slot = "6")]
	public void OHNHDPGFLAC(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x5749570", Offset = "0x5747F70", VA = "0x185749570")]
	private void HDEEJGEFJJL(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x57499B0", Offset = "0x57483B0", VA = "0x1857499B0", Slot = "7")]
	public void PPDGHDJCFAP(Vector3 MBBMKANKKGB, ForceMode MPMGBCACKOF = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class PGOGIEBHIFE : BBGAPPNBFLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool ECEFGAGMMPK;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool OGIIANAEIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x72B260", Offset = "0x729C60", VA = "0x18072B260", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x5757830", Offset = "0x5756230", VA = "0x185757830", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x5739040", Offset = "0x5737A40", VA = "0x185739040")]
	public PGOGIEBHIFE(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x5757800", Offset = "0x5756200", VA = "0x185757800", Slot = "6")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x5750A60", Offset = "0x574F460", VA = "0x185750A60", Slot = "7")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class IBJNOEFNELA : BAOLOJAHLLA, PLDJMDIFCKE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly NCOEFPHLCKK IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<NCOEFPHLCKK> BOGHIFKGACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private NCOEFPHLCKK EAGPPNPHOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private NCOEFPHLCKK GGEKFPEBLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Transform LNOINKFMENB;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private Transform LHEBMCHBDEI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x57444F0", Offset = "0x5742EF0", VA = "0x1857444F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x727040", Offset = "0x725A40", VA = "0x180727040", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x5743730", Offset = "0x5742130", VA = "0x185743730", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public NCOEFPHLCKK CMJKBCMDGHN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x7270C0", Offset = "0x725AC0", VA = "0x1807270C0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public IReadOnlyList<NCOEFPHLCKK> PHPDFDJEEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x7270B0", Offset = "0x725AB0", VA = "0x1807270B0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event DGAAFHCPHEH NJJHHELIHIP
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x5744B40", Offset = "0x5743540", VA = "0x185744B40", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x5744C80", Offset = "0x5743680", VA = "0x185744C80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event DGAAFHCPHEH EPBNCIPAFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x5744870", Offset = "0x5743270", VA = "0x185744870", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x5744730", Offset = "0x5743130", VA = "0x185744730", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event MKKJLKCGEAC EIBHEHIGCNB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x57447D0", Offset = "0x57431D0", VA = "0x1857447D0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x5744910", Offset = "0x5743310", VA = "0x185744910", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action PFANGAANPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x57449B0", Offset = "0x57433B0", VA = "0x1857449B0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x5744E50", Offset = "0x5743850", VA = "0x185744E50", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action NJGCKLJKCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x5744690", Offset = "0x5743090", VA = "0x185744690", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x5743820", Offset = "0x5742220", VA = "0x185743820", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<NCOEFPHLCKK> NFDMKCEEBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x5745270", Offset = "0x5743C70", VA = "0x185745270", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x5744550", Offset = "0x5742F50", VA = "0x185744550", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<NCOEFPHLCKK> AMBCDPFGEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x57445F0", Offset = "0x5742FF0", VA = "0x1857445F0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x5744320", Offset = "0x5742D20", VA = "0x185744320", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action KKKJMJHLIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x5743EE0", Offset = "0x57428E0", VA = "0x185743EE0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x5743740", Offset = "0x5742140", VA = "0x185743740", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<NCOEFPHLCKK> PFJIOBMDLAL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x5744280", Offset = "0x5742C80", VA = "0x185744280", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x5744DB0", Offset = "0x57437B0", VA = "0x185744DB0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x5745460", Offset = "0x5743E60", VA = "0x185745460")]
	public IBJNOEFNELA(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x5743E60", Offset = "0x5742860", VA = "0x185743E60", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x57438C0", Offset = "0x57422C0", VA = "0x1857438C0", Slot = "30")]
	public void DEIBNNOCJKC(NCOEFPHLCKK BJNIPOLNMLD, bool OMIKAFGHIFK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x5745020", Offset = "0x5743A20", VA = "0x185745020", Slot = "6")]
	public void OAJEEOBFKGI(NCOEFPHLCKK EMJBGADPLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x5743F80", Offset = "0x5742980", VA = "0x185743F80", Slot = "7")]
	public void FEBKLPDLGMF(NCOEFPHLCKK EMJBGADPLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x5744BE0", Offset = "0x57435E0", VA = "0x185744BE0", Slot = "4")]
	public void LBIPGKKJCGE(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x57441E0", Offset = "0x5742BE0", VA = "0x1857441E0", Slot = "5")]
	public void FHJPDJCNJIO(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x5744D20", Offset = "0x5743720", VA = "0x185744D20")]
	private void MAFJOMEFHJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x57437E0", Offset = "0x57421E0", VA = "0x1857437E0")]
	private void CIAELCNFLBC(NCOEFPHLCKK EMJBGADPLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x5745310", Offset = "0x5743D10", VA = "0x185745310")]
	private void PPAJNJCEOJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x5744EF0", Offset = "0x57438F0", VA = "0x185744EF0")]
	private void MJFKBFMOHPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x57443C0", Offset = "0x5742DC0", VA = "0x1857443C0")]
	private void GCCACPFBAFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x5744A50", Offset = "0x5743450", VA = "0x185744A50")]
	[CompilerGenerated]
	private object JPNEAMCDIFO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class MECBMGLNGLE
{
	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x574FB20", Offset = "0x574E520", VA = "0x18574FB20")]
	public static BAOLOJAHLLA EHJMHIENHGI(this NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class AAMJEFJMFFB : HOBENBLCEGH, IMBEMHENMNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly global::NFFFIELCCID<NCOEFPHLCKK> MINDKHLMMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool AHJHOHPBMLN;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public global::NFFFIELCCID<NCOEFPHLCKK> PCADFNIAGAD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Vector3 BFENAJAEKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x5735300", Offset = "0x5733D00", VA = "0x185735300", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public Vector3 LECHPMMLACE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x5734D20", Offset = "0x5733720", VA = "0x185734D20", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private Vector3 LGEGEJPPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x57347E0", Offset = "0x57331E0", VA = "0x1857347E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public NCOEFPHLCKK KJCAOKIHBIK
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x5734C10", Offset = "0x5733610", VA = "0x185734C10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x5735330", Offset = "0x5733D30", VA = "0x185735330")]
	public AAMJEFJMFFB(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x5734EF0", Offset = "0x57338F0", VA = "0x185734EF0", Slot = "8")]
	public void IOHAPAEGEFD(NCOEFPHLCKK GGEKFPEBLKN, object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x5734CC0", Offset = "0x57336C0", VA = "0x185734CC0", Slot = "9")]
	public void DNECHJALIBL(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x57348C0", Offset = "0x57332C0", VA = "0x1857348C0")]
	private Vector3 BIHFLNGABAB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x5734F60", Offset = "0x5733960", VA = "0x185734F60")]
	private void LMCLHJOPLFN(NCOEFPHLCKK ICONGCOMDAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class KDBNNAEOBEC
{
	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x574D570", Offset = "0x574BF70", VA = "0x18574D570")]
	public static HOBENBLCEGH FCOMDNGDAPJ(this NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class GKILPNGPKKF : EJLCPNDNOPA, OGBLFJOOHEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly OverridableVector3 OCCIBCJMCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly OverridableVector3 DDBDFGDEJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float BJEKPKOHOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private float NJAPMMIKJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Vector3 GMBCHMBJMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Vector3? OLICLKGPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Quaternion? AIDBIHPFFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool ICBJHGNDPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool FFNAKAHNLAF;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 BMNHHGGIMHD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xEF3660", Offset = "0xEF2060", VA = "0x180EF3660", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x573ED70", Offset = "0x573D770", VA = "0x18573ED70", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 ICDJEGJHDEE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x5740360", Offset = "0x573ED60", VA = "0x185740360", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float AHNCJOKPCCM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x1459FB0", Offset = "0x14589B0", VA = "0x181459FB0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x5740790", Offset = "0x573F190", VA = "0x185740790")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public float JAHICELIBID
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x10C1BA0", Offset = "0x10C05A0", VA = "0x1810C1BA0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x5740460", Offset = "0x573EE60", VA = "0x185740460", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Vector3 JLIOGCPKLOL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x573E500", Offset = "0x573CF00", VA = "0x18573E500", Slot = "13")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x5740480", Offset = "0x573EE80", VA = "0x185740480", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public Quaternion OCGLMIOIKKA
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x573F250", Offset = "0x573DC50", VA = "0x18573F250", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x5740950", Offset = "0x573F350", VA = "0x185740950", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x57367D0", Offset = "0x57351D0", VA = "0x1857367D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event DGAAFHCPHEH IBFMPJKFDEA
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x57408B0", Offset = "0x573F2B0", VA = "0x1857408B0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x573EE70", Offset = "0x573D870", VA = "0x18573EE70", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x5740E80", Offset = "0x573F880", VA = "0x185740E80")]
	public GKILPNGPKKF(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x573F090", Offset = "0x573DA90", VA = "0x18573F090", Slot = "18")]
	public void FCDPOIHJAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x573E670", Offset = "0x573D070", VA = "0x18573E670", Slot = "17")]
	public void AEAABDHDFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x573ED90", Offset = "0x573D790", VA = "0x18573ED90", Slot = "20")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x5740BE0", Offset = "0x573F5E0", VA = "0x185740BE0", Slot = "21")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x5740620", Offset = "0x573F020", VA = "0x185740620", Slot = "19")]
	public void IEIECPGHPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x573E750", Offset = "0x573D150", VA = "0x18573E750", Slot = "22")]
	public void AMJHKJLPLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x573ED70", Offset = "0x573D770", VA = "0x18573ED70")]
	private void PNBIFKFCFEF(Vector3 LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x5740AF0", Offset = "0x573F4F0", VA = "0x185740AF0")]
	private Vector3 OMGBOJNFENG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x5740790", Offset = "0x573F190", VA = "0x185740790")]
	private void MMGDLCDAMEC(float LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x5740460", Offset = "0x573EE60", VA = "0x185740460")]
	private void IAOOGBCNABD(float LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x573EF10", Offset = "0x573D910", VA = "0x18573EF10")]
	private Vector3 EMNKCDOKIJP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x5740480", Offset = "0x573EE80", VA = "0x185740480")]
	private void PBMBMDIIBMG(Vector3 LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x573EC10", Offset = "0x573D610", VA = "0x18573EC10")]
	private Quaternion ANKHAKNDHKM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x5740950", Offset = "0x573F350", VA = "0x185740950")]
	private void PMCIAKDJBLM(Quaternion LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x573F3C0", Offset = "0x573DDC0", VA = "0x18573F3C0")]
	public void HCPEECAOGOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x573F4A0", Offset = "0x573DEA0", VA = "0x18573F4A0", Slot = "4")]
	public (float, Vector3) HCPEECAOGOM(Rigidbody BMDOKJBOKPE)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class HHOJEEAPIPJ
{
	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x57413C0", Offset = "0x573FDC0", VA = "0x1857413C0")]
	public static EJLCPNDNOPA JIDBPFDBCJM(this NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class JIFLPFKICCE : LBPABMNHAKF
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private const string DKCLIMFPCAB = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly BHECNCBBLMC NIFKNKCEHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly JGBCGHMDEIJ FAACPMLGAIL;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool OJDFKEJHLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x1F1CFE0", Offset = "0x1F1B9E0", VA = "0x181F1CFE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public JGBCGHMDEIJ PAEMELMEBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x731750", Offset = "0x730150", VA = "0x180731750", Slot = "5")]
		get
		{
			return default(JGBCGHMDEIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x574A7D0", Offset = "0x57491D0", VA = "0x18574A7D0")]
	public JIFLPFKICCE(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x574A700", Offset = "0x5749100", VA = "0x18574A700", Slot = "6")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x574A1F0", Offset = "0x5748BF0", VA = "0x18574A1F0")]
	private bool BPCPFBNLLLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x574A1C0", Offset = "0x5748BC0", VA = "0x18574A1C0", Slot = "7")]
	public void BBPFDNFCENP(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x574A3C0", Offset = "0x5748DC0", VA = "0x18574A3C0", Slot = "8")]
	public void JDDFJPPACKN(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x574A290", Offset = "0x5748C90", VA = "0x18574A290", Slot = "11")]
	public void EKFOLENAMJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x574A5B0", Offset = "0x5748FB0", VA = "0x18574A5B0")]
	private void NLCICEBEBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x574A430", Offset = "0x5748E30", VA = "0x18574A430")]
	private void LPEGKOLKNAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x574A3F0", Offset = "0x5748DF0", VA = "0x18574A3F0", Slot = "10")]
	public void KONHDGEMJBN(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x574A6C0", Offset = "0x57490C0", VA = "0x18574A6C0", Slot = "9")]
	public void OKPPPAGPECC(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class ABEGKLMCNKN : KGDABPANOEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly BHECNCBBLMC GMNCOFMDGAF;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool FAJNDFDCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x5735750", Offset = "0x5734150", VA = "0x185735750", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IEnumerable<object> OPBNFDMBOBA
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x5735500", Offset = "0x5733F00", VA = "0x185735500", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event DGAAFHCPHEH KOKLFFIBABB
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x5735530", Offset = "0x5733F30", VA = "0x185735530", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x57356B0", Offset = "0x57340B0", VA = "0x1857356B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x5735940", Offset = "0x5734340", VA = "0x185735940")]
	public ABEGKLMCNKN(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x57354A0", Offset = "0x5733EA0", VA = "0x1857354A0", Slot = "11")]
	public IDisposable EBMGEFKJGJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x57355D0", Offset = "0x5733FD0", VA = "0x1857355D0", Slot = "8")]
	public void LDMPNKDCNKH(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x5735520", Offset = "0x5733F20", VA = "0x185735520", Slot = "9")]
	public void FGAHJAEMBHA(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x5735840", Offset = "0x5734240", VA = "0x185735840", Slot = "10")]
	public void PNGKMLMJNAK(object MIFCLBEAOPM, bool KLMBPMINIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x5735420", Offset = "0x5733E20", VA = "0x185735420", Slot = "12")]
	public void BOFMJFDPNBF(Rigidbody HKPNCKPHHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x5735810", Offset = "0x5734210", VA = "0x185735810", Slot = "13")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class HNCLLPKFEBH : KJOHJJNNODA, INNKCACPKLA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private PhotonView NIHEFIPHFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool MDPAFOENDPA;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public PhotonView PPFKDGBOMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool BBHAHOHMEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x5741520", Offset = "0x573FF20", VA = "0x185741520", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool MPDIPBBGKKB
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x802050", Offset = "0x800A50", VA = "0x180802050", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event DGAAFHCPHEH DELNFHCFIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x5742A50", Offset = "0x5741450", VA = "0x185742A50", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x5742400", Offset = "0x5740E00", VA = "0x185742400", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x5743030", Offset = "0x5741A30", VA = "0x185743030")]
	public HNCLLPKFEBH(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x5742C60", Offset = "0x5741660", VA = "0x185742C60", Slot = "9")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x57424A0", Offset = "0x5740EA0", VA = "0x1857424A0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x57428C0", Offset = "0x57412C0", VA = "0x1857428C0", Slot = "10")]
	public void FPAGIJPELCJ(NCOEFPHLCKK GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x57425B0", Offset = "0x5740FB0", VA = "0x1857425B0", Slot = "11")]
	public void EDIJKBDKKBN(NCOEFPHLCKK GGEKFPEBLKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x5742740", Offset = "0x5741140", VA = "0x185742740")]
	private void FHAIJPNFBDJ(PhotonView CCKCOJFPKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x5742AF0", Offset = "0x57414F0", VA = "0x185742AF0")]
	private void NMOCGHMFIDJ(RigidbodyEx HLCKNLLPKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x5742DB0", Offset = "0x57417B0", VA = "0x185742DB0")]
	private void PDFJNKCICEB(PhotonView FGIJLKAFKLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class IGNOBFOLHOG
{
	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x5745590", Offset = "0x5743F90", VA = "0x185745590")]
	public static KJOHJJNNODA PFFJAHDNLIN(this NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class PHBJFGPFKIB : IKFALNBDADN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private RigidbodyConstraints JBGLIGODAKH;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool KHDKIPLIJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xA65F20", Offset = "0xA64920", VA = "0x180A65F20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x2353A90", Offset = "0x2352490", VA = "0x182353A90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool ILHHOPCAOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x2353AA0", Offset = "0x23524A0", VA = "0x182353AA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x2353A80", Offset = "0x2352480", VA = "0x182353A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public RigidbodyConstraints AOEOJAJAPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x77AFB0", Offset = "0x7799B0", VA = "0x18077AFB0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x57579A0", Offset = "0x57563A0", VA = "0x1857579A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x5757AE0", Offset = "0x57564E0", VA = "0x185757AE0")]
	public PHBJFGPFKIB(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x5757940", Offset = "0x5756340", VA = "0x185757940", Slot = "9")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x5757970", Offset = "0x5756370", VA = "0x185757970", Slot = "10")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class MLLAIDEGMGG : CAONNBLCKEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly NCOEFPHLCKK IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private float NKICPJKJIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float KJIENHELDBA;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public float PGABAKFPNBB
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xE61050", Offset = "0xE5FA50", VA = "0x180E61050", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x5750FE0", Offset = "0x574F9E0", VA = "0x185750FE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public float DCNFDLOMNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0xEF8A50", Offset = "0xEF7450", VA = "0x180EF8A50", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x57510B0", Offset = "0x574FAB0", VA = "0x1857510B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x5751220", Offset = "0x574FC20", VA = "0x185751220")]
	public MLLAIDEGMGG(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x5750F90", Offset = "0x574F990", VA = "0x185750F90", Slot = "8")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x5751180", Offset = "0x574FB80", VA = "0x185751180", Slot = "9")]
	public void PKFCGBCFJGD(Rigidbody GHAGIOLHPMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class ALGNGADHBMC : EIMJIHNCMHI
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private const int BODIPJBOABD = 10;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const float LEOMFFLEOJP = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const float GJBNLKILOFJ = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private const float MDELHFJODGE = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool BGFIBJGJHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool CKBFPADPCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int IICOFCPBOJK;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x57367D0", Offset = "0x57351D0", VA = "0x1857367D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private bool HBCBGANJMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x57369B0", Offset = "0x57353B0", VA = "0x1857369B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private bool LFGDELENJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x5736D80", Offset = "0x5735780", VA = "0x185736D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private NCOEFPHLCKK GKEMABFNEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x5736F50", Offset = "0x5735950", VA = "0x185736F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool KMDIPAOGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x5736DA0", Offset = "0x57357A0", VA = "0x185736DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event DGAAFHCPHEH BGFDOMIHHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x5736FC0", Offset = "0x57359C0", VA = "0x185736FC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x5736730", Offset = "0x5735130", VA = "0x185736730", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5737270", Offset = "0x5735C70", VA = "0x185737270")]
	public ALGNGADHBMC(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5737060", Offset = "0x5735A60", VA = "0x185737060", Slot = "6")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5736FB0", Offset = "0x57359B0", VA = "0x185736FB0", Slot = "8")]
	public void NKFCECIGMAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x5736E00", Offset = "0x5735800", VA = "0x185736E00", Slot = "7")]
	public bool NEPEFPHIELC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x57371D0", Offset = "0x5735BD0", VA = "0x1857371D0", Slot = "9")]
	public void PKFLOCAHJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x57370F0", Offset = "0x5735AF0", VA = "0x1857370F0", Slot = "11")]
	public void PFPLFILECPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5737190", Offset = "0x5735B90", VA = "0x185737190", Slot = "12")]
	public void PHLPAOAPADB(bool DFLJHGHEKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5736A50", Offset = "0x5735450", VA = "0x185736A50", Slot = "10")]
	public void LMCNKOCFNJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x5736580", Offset = "0x5734F80", VA = "0x185736580")]
	private bool BEIPPJFGNKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x5736820", Offset = "0x5735220", VA = "0x185736820")]
	private void GKLPFICFPDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class KBBDHDIMKDH : IPANMLAMAAD
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const string EKLCKOGJHLL = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly BHECNCBBLMC KGFFEMLFKLI;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Rigidbody LNMDHFKNJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x72B250", Offset = "0x729C50", VA = "0x18072B250", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x74C3F0", Offset = "0x74ADF0", VA = "0x18074C3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private bool KMDIPAOGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x57384F0", Offset = "0x5736EF0", VA = "0x1857384F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x574C950", Offset = "0x574B350", VA = "0x18574C950")]
	public KBBDHDIMKDH(NCOEFPHLCKK IILFNNEDNCJ, in JCAJMGPJNDN HIDEHJGLNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x574C8A0", Offset = "0x574B2A0", VA = "0x18574C8A0", Slot = "5")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x574C870", Offset = "0x574B270", VA = "0x18574C870", Slot = "6")]
	public void KPOLANLNJJI(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x574C1F0", Offset = "0x574ABF0", VA = "0x18574C1F0", Slot = "7")]
	public void HIBCGDMOODJ(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x574B960", Offset = "0x574A360", VA = "0x18574B960", Slot = "8")]
	public void EDEILOABNOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x574BE70", Offset = "0x574A870", VA = "0x18574BE70", Slot = "9")]
	public void EONBBMLLGPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x574C070", Offset = "0x574AA70", VA = "0x18574C070", Slot = "10")]
	public void FDIDMCANFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x574C220", Offset = "0x574AC20", VA = "0x18574C220", Slot = "11")]
	public void IKMAJMOKAJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x574BCC0", Offset = "0x574A6C0", VA = "0x18574BCC0")]
	private void EOLCGNDNPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x574C6C0", Offset = "0x574B0C0", VA = "0x18574C6C0")]
	private void KAMMGDNLJDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class NHKHPDIEFMI : ODMDEDICELM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly PLOEBEDJGLE IILFNNEDNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly BHECNCBBLMC JLNIAAJPPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float GHBILKANCFB;

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public EKLLOLLHLDP LNMCPLFHCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x72B270", Offset = "0x729C70", VA = "0x18072B270", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x752CF0", Offset = "0x7516F0", VA = "0x180752CF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public CHACNCJIDJM GJHPEGFOAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x7A9630", Offset = "0x7A8030", VA = "0x1807A9630", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public Vector3 LGEGEJPPDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x5754A60", Offset = "0x5753460", VA = "0x185754A60", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x57550C0", Offset = "0x5753AC0", VA = "0x1857550C0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public Vector3 JBHIDAJMGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x57564A0", Offset = "0x5754EA0", VA = "0x1857564A0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x57556F0", Offset = "0x57540F0", VA = "0x1857556F0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 LJMFIEJCGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x5754F90", Offset = "0x5753990", VA = "0x185754F90", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x5754C70", Offset = "0x5753670", VA = "0x185754C70", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public Vector3 ICEKJCBHJBH
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x5756670", Offset = "0x5755070", VA = "0x185756670", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x57565D0", Offset = "0x5754FD0", VA = "0x1857565D0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public float KKALKPOINCB
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xF6ADA0", Offset = "0xF697A0", VA = "0x180F6ADA0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x57553E0", Offset = "0x5753DE0", VA = "0x1857553E0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public bool LIGEJEKODFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0xEE8460", Offset = "0xEE6E60", VA = "0x180EE8460", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private BDJOPHNNEJG AODMDOCLCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x1D9F4C0", Offset = "0x1D9DEC0", VA = "0x181D9F4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private bool LFGDELENJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x573B900", Offset = "0x573A300", VA = "0x18573B900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x5757630", Offset = "0x5756030", VA = "0x185757630")]
	public NHKHPDIEFMI(NCOEFPHLCKK IILFNNEDNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x5756600", Offset = "0x5755000", VA = "0x185756600", Slot = "19")]
	public void PBJONABJOBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x5755380", Offset = "0x5753D80", VA = "0x185755380", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x5754E60", Offset = "0x5753860", VA = "0x185754E60", Slot = "28")]
	public void BOFMJFDPNBF(Rigidbody GHAGIOLHPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0xEE7EF0", Offset = "0xEE68F0", VA = "0x180EE7EF0", Slot = "20")]
	public void KNFJENEFGIE(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0xEE78F0", Offset = "0xEE62F0", VA = "0x180EE78F0", Slot = "31")]
	public void NEMGEGCJOPN(object MIFCLBEAOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x5754880", Offset = "0x5753280", VA = "0x185754880", Slot = "36")]
	public Vector3 AFFCJBHNNJL(Vector3 JOJEMOKKGPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x5756900", Offset = "0x5755300", VA = "0x185756900", Slot = "35")]
	public Vector3 KIKKEDPKAKK(Vector3 HMPFDEAFPND)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x5756600", Offset = "0x5755000", VA = "0x185756600", Slot = "27")]
	public void INLPOAEPJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x5754E20", Offset = "0x5753820", VA = "0x185754E20", Slot = "25")]
	public void BHDNAPGFIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x5756590", Offset = "0x5754F90", VA = "0x185756590", Slot = "24")]
	public void IFMLGPGPJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x5756AC0", Offset = "0x57554C0", VA = "0x185756AC0", Slot = "34")]
	public void NGFKLMPAGOE(Vector3 GKKEEHNMPBL, Vector3 NFGPCLPNMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5756760", Offset = "0x5755160", VA = "0x185756760", Slot = "33")]
	public void JLDEEBLCKGA(Vector3 FHKLDEIKECB, Vector3 FHFHNDANMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x57567C0", Offset = "0x57551C0", VA = "0x1857567C0", Slot = "32")]
	public void KIIDBBLBANB(Vector3 JDDALKKDLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5755810", Offset = "0x5754210", VA = "0x185755810", Slot = "22")]
	public void HHAFJJGJPFB(EECECFKKEJP KMDODPJBKLE, Vector3 CFLMAEMNHKL, float ABGPHLFIFAO, float OPCFMELHIKJ = 8f, float ECOHALOPPDN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x5755C60", Offset = "0x5754660", VA = "0x185755C60", Slot = "21")]
	public void HHLJBCNAEPM(JDHBHPOMECG EFAKAOJPAJJ, Vector3 PKAJMBKNJIL, float KBLOKDLNEPD = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x57561D0", Offset = "0x5754BD0", VA = "0x1857561D0", Slot = "23")]
	[Obsolete]
	public void IALNLOAFGMK(JDHBHPOMECG EFAKAOJPAJJ, Vector3 IHCJBCJFELL, float MEJPNNANPLH = 7f, float CKIIILKMBKK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x57552C0", Offset = "0x5753CC0", VA = "0x1857552C0", Slot = "30")]
	public Vector3 DNICIBAAMCG(Vector3 GCAABCBBBAL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x5755720", Offset = "0x5754120", VA = "0x185755720", Slot = "29")]
	public Vector3 GJAHBCCOAII(Vector3 DIIFLOBFBLO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x57555C0", Offset = "0x5753FC0", VA = "0x1857555C0", Slot = "26")]
	public void EPOKPKAANHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x57553E0", Offset = "0x5753DE0", VA = "0x1857553E0")]
	private void PPEMJOPAMJI(float LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x5755180", Offset = "0x5753B80", VA = "0x185755180")]
	private void DKLBMGLGABJ(Vector3 PKAJMBKNJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x5754B80", Offset = "0x5753580", VA = "0x185754B80")]
	private Vector3 AIPGGJCOIBK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x5756D00", Offset = "0x5755700", VA = "0x185756D00")]
	private void OIMGBAHMGOG(Vector3 HMPFDEAFPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x5754D30", Offset = "0x5753730", VA = "0x185754D30")]
	private Vector3 BGJJOBCDBBC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x5755E90", Offset = "0x5754890", VA = "0x185755E90")]
	private void HOGMIBAAANA(Vector3 LPJDDLMPNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x5757030", Offset = "0x5755A30", VA = "0x185757030")]
	private void OPKJDBGLKOE(Vector3 HMPFDEAFPND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x5755500", Offset = "0x5753F00", VA = "0x185755500")]
	private void EKIKIKBLFAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class NHDJMCGDAEJ : CCKADDACLBD
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x5754040", Offset = "0x5752A40", VA = "0x185754040", Slot = "4")]
	public PLDJMDIFCKE HPIEMLILMFL(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x5754120", Offset = "0x5752B20", VA = "0x185754120", Slot = "5")]
	public ODMDEDICELM IINCPPFHAME(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x5754770", Offset = "0x5753170", VA = "0x185754770", Slot = "6")]
	public IMBEMHENMNJ MOJGNMKJFLF(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x5754230", Offset = "0x5752C30", VA = "0x185754230", Slot = "7")]
	public CAONNBLCKEG ILCPDNKDAKJ(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x57544E0", Offset = "0x5752EE0", VA = "0x1857544E0", Slot = "8")]
	public EIMJIHNCMHI KJNNEGNLPCG(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x5754370", Offset = "0x5752D70", VA = "0x185754370", Slot = "9")]
	public JBCOLILENLD JDEHAKBEPFB(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x5753CA0", Offset = "0x57526A0", VA = "0x185753CA0", Slot = "10")]
	public KGDABPANOEG CLMAKHLOHMN(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x57545A0", Offset = "0x5752FA0", VA = "0x1857545A0", Slot = "11")]
	public BDJOPHNNEJG LAGKMHIIGOF(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x5754430", Offset = "0x5752E30", VA = "0x185754430", Slot = "12")]
	public AIOOGANOGPH JNMPFOJECMI(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x5753EC0", Offset = "0x57528C0", VA = "0x185753EC0", Slot = "13")]
	public BBGAPPNBFLO DPGNNNONAOD(NCOEFPHLCKK NLKDOMNEDBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x5753DA0", Offset = "0x57527A0", VA = "0x185753DA0")]
	public IPANMLAMAAD MNBKDOEPCLE(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x5753F70", Offset = "0x5752970", VA = "0x185753F70")]
	public INNKCACPKLA HPGHLDDNEHH(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x5754650", Offset = "0x5753050", VA = "0x185754650")]
	public LBPABMNHAKF OCGJAPKHCOA(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x5753AF0", Offset = "0x57524F0", VA = "0x185753AF0")]
	public OGBLFJOOHEI BMJLAHFILLO(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x57542A0", Offset = "0x5752CA0", VA = "0x1857542A0")]
	public IKFALNBDADN KIKLIMOCIDB(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x5753BF0", Offset = "0x57525F0", VA = "0x185753BF0", Slot = "19")]
	public NCOEFPHLCKK APMJEHJBGBJ(RigidbodyEx IILFNNEDNCJ, JCAJMGPJNDN HIDEHJGLNHO, BKDMDHLJAEJ CMIHNHHBGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public NHDJMCGDAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x5753DA0", Offset = "0x57527A0", VA = "0x185753DA0", Slot = "14")]
	private IPANMLAMAAD DBBGHPHPGNC(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x5753F70", Offset = "0x5752970", VA = "0x185753F70", Slot = "15")]
	private INNKCACPKLA IACLMNOIKMC(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x5754650", Offset = "0x5753050", VA = "0x185754650", Slot = "16")]
	private LBPABMNHAKF MFFOKDJHDOK(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x5753AF0", Offset = "0x57524F0", VA = "0x185753AF0", Slot = "17")]
	private OGBLFJOOHEI AFFGIKNDDLN(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x57542A0", Offset = "0x5752CA0", VA = "0x1857542A0", Slot = "18")]
	private IKFALNBDADN ILNOMKKJMMB(NCOEFPHLCKK NLKDOMNEDBE, in JCAJMGPJNDN HIDEHJGLNHO)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[Preserve]
	internal class _RRAssemblyIndex : AAHOHGIJHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x730AD0", Offset = "0x72F4D0", VA = "0x180730AD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x69845F0", Offset = "0x6982FF0", VA = "0x1869845F0", Slot = "6")]
		public sealed override void MNNDBLCHNEL(CKMMIMLGKKB MIKGEIBIMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x6984560", Offset = "0x6982F60", VA = "0x186984560", Slot = "4")]
		public sealed override void KLMOEJEAKPE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x574E210", Offset = "0x574CC10", VA = "0x18574E210")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x574DEC0", Offset = "0x574C8C0", VA = "0x18574DEC0")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
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
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
