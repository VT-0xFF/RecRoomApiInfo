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
internal class PLMAKOANNEP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public const string CGBCJMGCGHI = "RBEX_DEFAULT";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const float EAJHGFDDPED = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public const float BKHNFLPIGIG = 0f;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public const float IOOENFBDOPN = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public PLMAKOANNEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void OBKDBINKHFD(RigidbodyEx DNLGNDAMJGB);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void LBNCGHJEAIO(RigidbodyEx DNLGNDAMJGB, bool FNAFEHLKFEA = false);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum IJDCLCAKEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DNJJGCFOPDB
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum IAABFEHMLCH
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class LNOELMMMPBL : DGBFOPLPHNA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AHODMLIGFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x66D040", Offset = "0x66C440", VA = "0x18066D040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DNALJEIIAGK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x683790", Offset = "0x682B90", VA = "0x180683790", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x674170", Offset = "0x673570", VA = "0x180674170", Slot = "6")]
	public AOJPHEJCEIM HEHCAOCMIAM(float LPOAHMAIIFD)
	{
		return default(AOJPHEJCEIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "7")]
	public void EIPAABBBFMM(CNCEJGIFHLA HKFNIHLBEHC, float MHBFEPFLJLP, MBNNENAJAAB GOCCHBDCKPC = MBNNENAJAAB.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "8")]
	public void EIPAABBBFMM(CNCEJGIFHLA HKFNIHLBEHC, Transform HIFDCIFFECM, float MHBFEPFLJLP, MBNNENAJAAB GOCCHBDCKPC = MBNNENAJAAB.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "9")]
	public void POFDLKCCHCA(CNCEJGIFHLA HKFNIHLBEHC, [Optional] float? MHBFEPFLJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "10")]
	public void GMLJNDAKNDK(CNCEJGIFHLA MBMKPMKIOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x674170", Offset = "0x673570", VA = "0x180674170", Slot = "11")]
	public AOJPHEJCEIM HGFLNBJKMMD(CNCEJGIFHLA HKFNIHLBEHC)
	{
		return default(AOJPHEJCEIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x68E020", Offset = "0x68D420", VA = "0x18068E020", Slot = "12")]
	public bool EHFLMNEEBEC(CNCEJGIFHLA HKFNIHLBEHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "13")]
	public void ODHDHECGEBB(CNCEJGIFHLA HKFNIHLBEHC, MBNNENAJAAB DGKACDEAHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public LNOELMMMPBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[BGGFAGPLFND(typeof(DJICCHFCEBA), new string[] { "Ignore", "Mock" })]
public class ICLEOPELBAP : DJICCHFCEBA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MAGJLCBONNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x671250", Offset = "0x670650", VA = "0x180671250", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "5")]
	public void PADDHJEJKKF(string DNNOOMDNIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "6")]
	public void GDHIMDMINJB(RigidbodyEx EIOOACKMMIN, Action PADKGNIPPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x674170", Offset = "0x673570", VA = "0x180674170", Slot = "7")]
	public DGBFOPLPHNA DKIKKMLCEOE(int ICCDNKDAJAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "8")]
	public void LNPGJDEIANC(Vector3 BODEKFHIHLB, float MNKAMLFNBID, Color GIPDGGFIBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public ICLEOPELBAP()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	[AFAPMPFKDID(JCDEPCAPNFC.Physics)]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool NHMEHEIGDLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private LDFFFADLJJJ EDOLNFCKPLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[FGPAGODBLAA(HNCKKAEODPP.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[FGPAGODBLAA(HNCKKAEODPP.SelfAndParent, true, false, false)]
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
		private DNJJGCFOPDB physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal LDFFFADLJJJ FMPGMEEKJBO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x5FC30C0", Offset = "0x5FC24C0", VA = "0x185FC30C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<RigidbodyEx> MMKJCMJHBBC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x683770", Offset = "0x682B70", VA = "0x180683770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x70EAB0", Offset = "0x70DEB0", VA = "0x18070EAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx GPBNNCOGMEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5190", Offset = "0x5FC4590", VA = "0x185FC5190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx HNOOCOABLIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5130", Offset = "0x5FC4530", VA = "0x185FC5130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public RigidbodyEx BLENCGKHIJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5CF0", Offset = "0x5FC50F0", VA = "0x185FC5CF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5FC7440", Offset = "0x5FC6840", VA = "0x185FC7440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform LGMPJDMJFAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1076E00", Offset = "0x1076200", VA = "0x181076E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform PAAMJCKPJFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1076E00", Offset = "0x1076200", VA = "0x181076E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MBNNENAJAAB CNANIPFOIOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5FC4E20", Offset = "0x5FC4220", VA = "0x185FC4E20")]
			get
			{
				return default(MBNNENAJAAB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x5FC69E0", Offset = "0x5FC5DE0", VA = "0x185FC69E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool AOGGMNBIPNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x5FC53A0", Offset = "0x5FC47A0", VA = "0x185FC53A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool GLNBGDPGNIE
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5FC4FB0", Offset = "0x5FC43B0", VA = "0x185FC4FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public GDJBDCHFLPM IKKDOCCFOPH
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5340", Offset = "0x5FC4740", VA = "0x185FC5340")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6BF0", Offset = "0x5FC5FF0", VA = "0x185FC6BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public MDBCJGELOMO EMIMILKLLLH
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5FC52E0", Offset = "0x5FC46E0", VA = "0x185FC52E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6B80", Offset = "0x5FC5F80", VA = "0x185FC6B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NGJJKMHFKCD
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5FC51C0", Offset = "0x5FC45C0", VA = "0x185FC51C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Rigidbody HHEABFBCNDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5220", Offset = "0x5FC4620", VA = "0x185FC5220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool PNKNIIFGHOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5070", Offset = "0x5FC4470", VA = "0x185FC5070")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6AA0", Offset = "0x5FC5EA0", VA = "0x185FC6AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float KOECGKDLFHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5C90", Offset = "0x5FC5090", VA = "0x185FC5C90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float AKJAJNBDHHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5C30", Offset = "0x5FC5030", VA = "0x185FC5C30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5FC73D0", Offset = "0x5FC67D0", VA = "0x185FC73D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float GDCLNFEPIOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5600", Offset = "0x5FC4A00", VA = "0x185FC5600")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6E90", Offset = "0x5FC6290", VA = "0x185FC6E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float CBOIDDOJDAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5400", Offset = "0x5FC4800", VA = "0x185FC5400")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6C60", Offset = "0x5FC6060", VA = "0x185FC6C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool MDPEGHGHAMG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6210", Offset = "0x5FC5610", VA = "0x185FC6210")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5FC7980", Offset = "0x5FC6D80", VA = "0x185FC7980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 GBHLCANBGFN
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5A10", Offset = "0x5FC4E10", VA = "0x185FC5A10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5FC71A0", Offset = "0x5FC65A0", VA = "0x185FC71A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 BODEKFHIHLB
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6350", Offset = "0x5FC5750", VA = "0x185FC6350")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode ECBGALFHHKE
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5540", Offset = "0x5FC4940", VA = "0x185FC5540")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6DB0", Offset = "0x5FC61B0", VA = "0x185FC6DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float FIHINFGIBCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5FC50D0", Offset = "0x5FC44D0", VA = "0x185FC50D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6B10", Offset = "0x5FC5F10", VA = "0x185FC6B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints BGPNKBPMPMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x5FC55A0", Offset = "0x5FC49A0", VA = "0x185FC55A0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6E20", Offset = "0x5FC6220", VA = "0x185FC6E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 PHAJJBACOBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5D50", Offset = "0x5FC5150", VA = "0x185FC5D50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 JGGMFHHIJEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5D50", Offset = "0x5FC5150", VA = "0x185FC5D50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5FC7750", Offset = "0x5FC6B50", VA = "0x185FC7750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float NDNBEDBDDLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5AF0", Offset = "0x5FC4EF0", VA = "0x185FC5AF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5FC7280", Offset = "0x5FC6680", VA = "0x185FC7280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float BNNOKKELMLN
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5FC61B0", Offset = "0x5FC55B0", VA = "0x185FC61B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5FC7910", Offset = "0x5FC6D10", VA = "0x185FC7910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion EDNLPCMJMMF
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5E30", Offset = "0x5FC5230", VA = "0x185FC5E30")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5FC74B0", Offset = "0x5FC68B0", VA = "0x185FC74B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion LPEEDOBOGIM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x5FC60D0", Offset = "0x5FC54D0", VA = "0x185FC60D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5FC7830", Offset = "0x5FC6C30", VA = "0x185FC7830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 KCLLBFJPJPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5F10", Offset = "0x5FC5310", VA = "0x185FC5F10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5FC7590", Offset = "0x5FC6990", VA = "0x185FC7590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion KNDMEINDCHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5FF0", Offset = "0x5FC53F0", VA = "0x185FC5FF0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5FC7670", Offset = "0x5FC6A70", VA = "0x185FC7670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 CNBICOEGBNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6270", Offset = "0x5FC5670", VA = "0x185FC6270")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5FC79F0", Offset = "0x5FC6DF0", VA = "0x185FC79F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 NMEPDMHFFKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5B50", Offset = "0x5FC4F50", VA = "0x185FC5B50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5FC72F0", Offset = "0x5FC66F0", VA = "0x185FC72F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 FEBDBINBLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5460", Offset = "0x5FC4860", VA = "0x185FC5460")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6CD0", Offset = "0x5FC60D0", VA = "0x185FC6CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 OPEKPFLGIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5930", Offset = "0x5FC4D30", VA = "0x185FC5930")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5FC70C0", Offset = "0x5FC64C0", VA = "0x185FC70C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 BHJPEBJDKLE
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x5FC57F0", Offset = "0x5FC4BF0", VA = "0x185FC57F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6FE0", Offset = "0x5FC63E0", VA = "0x185FC6FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion KKDPOLFCCMG
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5710", Offset = "0x5FC4B10", VA = "0x185FC5710")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6F00", Offset = "0x5FC6300", VA = "0x185FC6F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 PIHPHMPNEJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6510", Offset = "0x5FC5910", VA = "0x185FC6510")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 MKIKENJBJDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6430", Offset = "0x5FC5830", VA = "0x185FC6430")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool EFFLGKBJAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x5FC58D0", Offset = "0x5FC4CD0", VA = "0x185FC58D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool KOJKALGLCJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5010", Offset = "0x5FC4410", VA = "0x185FC5010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool EDJFMEGPJEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x5FC4F50", Offset = "0x5FC4350", VA = "0x185FC4F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool MGKKHOINCEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x5FC4EF0", Offset = "0x5FC42F0", VA = "0x185FC4EF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool OHGAHICGHKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x5FC4DC0", Offset = "0x5FC41C0", VA = "0x185FC4DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool EMNLJJMIEEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5660", Offset = "0x5FC4A60", VA = "0x185FC5660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool JKEKAKBCKJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x705580", Offset = "0x704980", VA = "0x180705580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OBKDBINKHFD JGPECMJEHBO
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5FC4CE0", Offset = "0x5FC40E0", VA = "0x185FC4CE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6900", Offset = "0x5FC5D00", VA = "0x185FC6900")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event LBNCGHJEAIO MIAGNHKHCMP
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5FC4C70", Offset = "0x5FC4070", VA = "0x185FC4C70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6890", Offset = "0x5FC5C90", VA = "0x185FC6890")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event OBKDBINKHFD OFAAEPPCPMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5FC49D0", Offset = "0x5FC3DD0", VA = "0x185FC49D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5FC65F0", Offset = "0x5FC59F0", VA = "0x185FC65F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event OBKDBINKHFD HCCGNILBJFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5FC4A40", Offset = "0x5FC3E40", VA = "0x185FC4A40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6660", Offset = "0x5FC5A60", VA = "0x185FC6660")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event OBKDBINKHFD OLHJFHBKGMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5FC4B90", Offset = "0x5FC3F90", VA = "0x185FC4B90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5FC67B0", Offset = "0x5FC5BB0", VA = "0x185FC67B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<AOJPHEJCEIM, AOJPHEJCEIM> HONLBKEHBHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5FC4B20", Offset = "0x5FC3F20", VA = "0x185FC4B20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6740", Offset = "0x5FC5B40", VA = "0x185FC6740")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event OBKDBINKHFD KNKNADJJPDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5FC4C00", Offset = "0x5FC4000", VA = "0x185FC4C00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6820", Offset = "0x5FC5C20", VA = "0x185FC6820")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event OBKDBINKHFD DKOAHCPEAPA
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5FC4D50", Offset = "0x5FC4150", VA = "0x185FC4D50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5FC6970", Offset = "0x5FC5D70", VA = "0x185FC6970")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event OBKDBINKHFD BIEKLOKNMHF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5FC4AB0", Offset = "0x5FC3EB0", VA = "0x185FC4AB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5FC66D0", Offset = "0x5FC5AD0", VA = "0x185FC66D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x66E130", Offset = "0x66D530", VA = "0x18066E130")]
		internal void MJPENOMEFHB(LDFFFADLJJJ MDAIEADLBOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3050", Offset = "0x5FC2450", VA = "0x185FC3050")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC30C0", Offset = "0x5FC24C0", VA = "0x185FC30C0")]
		private LDFFFADLJJJ GFNCADPOMIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3850", Offset = "0x5FC2C50", VA = "0x185FC3850")]
		private void NGKBIODLKGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3CE0", Offset = "0x5FC30E0", VA = "0x185FC3CE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3BE0", Offset = "0x5FC2FE0", VA = "0x185FC3BE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5FC33B0", Offset = "0x5FC27B0", VA = "0x185FC33B0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3C80", Offset = "0x5FC3080", VA = "0x185FC3C80")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3D40", Offset = "0x5FC3140", VA = "0x185FC3D40")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5FC26E0", Offset = "0x5FC1AE0", VA = "0x185FC26E0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3DB0", Offset = "0x5FC31B0", VA = "0x185FC3DB0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3350", Offset = "0x5FC2750", VA = "0x185FC3350")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5FC37F0", Offset = "0x5FC2BF0", VA = "0x185FC37F0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5FC45A0", Offset = "0x5FC39A0", VA = "0x185FC45A0")]
		public void SetParent(RigidbodyEx PKODKJLGOIN, bool FNAFEHLKFEA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5FC40C0", Offset = "0x5FC34C0", VA = "0x185FC40C0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3610", Offset = "0x5FC2A10", VA = "0x185FC3610")]
		public bool IsRigidbodyAncestor(RigidbodyEx OALCGOPGEPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3650", Offset = "0x5FC2A50", VA = "0x185FC3650")]
		public bool IsRigidbodyDescendant(RigidbodyEx FEDMCMKGGIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2900", Offset = "0x5FC1D00", VA = "0x185FC2900")]
		public void AddInterpolationRestriction(object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3E20", Offset = "0x5FC3220", VA = "0x185FC3E20")]
		public void RemoveInterpolationRestriction(object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3170", Offset = "0x5FC2570", VA = "0x185FC3170")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2970", Offset = "0x5FC1D70", VA = "0x185FC2970")]
		public void AddKinematic(object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3E90", Offset = "0x5FC3290", VA = "0x185FC3E90")]
		public void RemoveKinematic(object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4520", Offset = "0x5FC3920", VA = "0x185FC4520")]
		public void SetKinematic(object PFJMMABJIDH, bool MDOKFMLNLCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4420", Offset = "0x5FC3820", VA = "0x185FC4420")]
		public void SetDiscontinuousPositionAndRotation(Vector3 EFFLEILEAOJ, Quaternion EOJPJJFENEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4320", Offset = "0x5FC3720", VA = "0x185FC4320")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 AGLOIALKBAN, Quaternion AOPMNOAKDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3510", Offset = "0x5FC2910", VA = "0x185FC3510")]
		public Vector3 GetConstrainedVelocity(Vector3 CNBICOEGBNM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3410", Offset = "0x5FC2810", VA = "0x185FC3410")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 FEBDBINBLMJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2870", Offset = "0x5FC1C70", VA = "0x185FC2870")]
		public void AddForce(Vector3 LGPEEBCPBMM, ForceMode BIAGFHEEGCO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2750", Offset = "0x5FC1B50", VA = "0x185FC2750")]
		public void AddForceAtPosition(Vector3 LGPEEBCPBMM, Vector3 IAMBOGDEHMB, ForceMode BIAGFHEEGCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2A70", Offset = "0x5FC1E70", VA = "0x185FC2A70")]
		public void AddTorque(Vector3 NNOLOLENPFH, ForceMode BIAGFHEEGCO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5FC29E0", Offset = "0x5FC1DE0", VA = "0x185FC29E0")]
		public void AddRelativeTorque(Vector3 NNOLOLENPFH, ForceMode BIAGFHEEGCO = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4800", Offset = "0x5FC3C00", VA = "0x185FC4800")]
		public Vector3 WorldToLocalVelocity(Vector3 KINMMEKNHJL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5FC36F0", Offset = "0x5FC2AF0", VA = "0x185FC36F0")]
		public Vector3 LocalToWorldVelocity(Vector3 NMEPDMHFFKO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5FC32F0", Offset = "0x5FC26F0", VA = "0x185FC32F0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3290", Offset = "0x5FC2690", VA = "0x185FC3290")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3230", Offset = "0x5FC2630", VA = "0x185FC3230")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC31D0", Offset = "0x5FC25D0", VA = "0x185FC31D0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4220", Offset = "0x5FC3620", VA = "0x185FC4220")]
		public void ResetVelocityWorldSpace(Vector3 DDMIKGEOOPO, Vector3 HAFOPEOGPCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4120", Offset = "0x5FC3520", VA = "0x185FC4120")]
		public void ResetVelocityLocalSpace(Vector3 JKKOHPMJAOG, Vector3 OPEKPFLGIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3FE0", Offset = "0x5FC33E0", VA = "0x185FC3FE0")]
		public void ResetLinearVelocityLocalSpace(Vector3 JKKOHPMJAOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4690", Offset = "0x5FC3A90", VA = "0x185FC4690")]
		public bool SweepTest(Vector3 IJOKHPEAHHL, out RaycastHit HJNBLBFBKNA, float PAKNAMCBNFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3690", Offset = "0x5FC2A90", VA = "0x185FC3690")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4630", Offset = "0x5FC3A30", VA = "0x185FC4630")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5FC47A0", Offset = "0x5FC3BA0", VA = "0x185FC47A0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2B00", Offset = "0x5FC1F00", VA = "0x185FC2B00")]
		public void AddUnityRigidbody(object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3F00", Offset = "0x5FC3300", VA = "0x185FC3F00")]
		public void RemoveUnityRigidbody(object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2E20", Offset = "0x5FC2220", VA = "0x185FC2E20")]
		public void ApplyForceVelocityChange(IJDCLCAKEAN LEIHBICAMKK, Vector3 KAFKHBLOAFI, float MDPIMMDABFN, float ONCCEMEBFFA = 8f, float CMDCCPIAHFP = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2D20", Offset = "0x5FC2120", VA = "0x185FC2D20")]
		public void ApplyAngularVelocityChange(IAABFEHMLCH KLINALAALOC, Vector3 OIEKPCBPIOL, float PBEJEHPPJEK = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2F40", Offset = "0x5FC2340", VA = "0x185FC2F40")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(IAABFEHMLCH KLINALAALOC, Vector3 BOMBFPIEJKJ, float FOKMAHAMPKL = 7f, float IPMBDAIGFIH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2C60", Offset = "0x5FC2060", VA = "0x185FC2C60")]
		public bool AllowedScaleChange(float KALFLGFFPIH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2B70", Offset = "0x5FC1F70", VA = "0x185FC2B70")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx LGNMDJNNIHP, object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3F70", Offset = "0x5FC3370", VA = "0x185FC3F70")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object PFJMMABJIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4950", Offset = "0x5FC3D50", VA = "0x185FC4950")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class NLIGALLEMMH
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4EB9610", Offset = "0x4EB8A10", VA = "0x184EB9610")]
	public static LDFFFADLJJJ FMPGMEEKJBO(this RigidbodyEx EIOOACKMMIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CEGPKCKJNIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Rigidbody EMOKGIOEOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public PhotonView HEJFKPMKBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public OverridableVector3 KBDCFHKMMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 FBHKMNMJJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public DNJJGCFOPDB HMJIHEOLILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public bool DIGIEHONIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool HJGBECGEFLL;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BGGFAGPLFND(typeof(LMAIHHGHGOJ), new string[] { })]
public class AGKOOGKCPFC : LMAIHHGHGOJ, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private HIMFGGFNFGH GBKLMNGDJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private DJICCHFCEBA OENDHJEKNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HNPLEDGEHJM AGOOLBDAEKK;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool DOAACDNCMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x4E9DFF0", Offset = "0x4E9D3F0", VA = "0x184E9DFF0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DJICCHFCEBA LFHAICJIGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public HNPLEDGEHJM PFLFOBPDCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E5A0", Offset = "0x4E9D9A0", VA = "0x184E9E5A0", Slot = "10")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E260", Offset = "0x4E9D660", VA = "0x184E9E260", Slot = "7")]
	public HOGBEFGIKOI IEEGGJDBNAK(RigidbodyEx EIOOACKMMIN)
	{
		return default(HOGBEFGIKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E170", Offset = "0x4E9D570", VA = "0x184E9E170")]
	private static HOGBEFGIKOI HDPGDPGLMFH(RigidbodyEx EIOOACKMMIN)
	{
		return default(HOGBEFGIKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E500", Offset = "0x4E9D900", VA = "0x184E9E500", Slot = "8")]
	public LDFFFADLJJJ OPJEPJEFDJG(RigidbodyEx EIOOACKMMIN, CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E040", Offset = "0x4E9D440", VA = "0x184E9E040", Slot = "9")]
	private RigidbodyEx GIDFOKPBPLE(GameObject LJDNPPGJLHN, CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public AGKOOGKCPFC()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public static OMGHCAFPMEP UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int NPPNEDIJGBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private int LJCLPNEIHEJ;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5FC21C0", Offset = "0x5FC15C0", VA = "0x185FC21C0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2200", Offset = "0x5FC1600", VA = "0x185FC2200")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5FC21E0", Offset = "0x5FC15E0", VA = "0x185FC21E0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string HKDHNKHPGDP, [Optional] UnityEngine.Object IDEIPFIOJKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string HKDHNKHPGDP, [Optional] UnityEngine.Object IDEIPFIOJKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5FC22F0", Offset = "0x5FC16F0", VA = "0x185FC22F0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class EFIHCIMHNON
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4EAC860", Offset = "0x4EABC60", VA = "0x184EAC860")]
	public static void KHOMHDBDOEJ(this Rigidbody ECNANCDNFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4EAC9B0", Offset = "0x4EABDB0", VA = "0x184EAC9B0")]
	public static void KHOMHDBDOEJ(this Rigidbody ECNANCDNFBD, Vector3 BHJPEBJDKLE, Quaternion KKDPOLFCCMG, Vector3 PILIMKKDADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4EAC790", Offset = "0x4EABB90", VA = "0x184EAC790")]
	public static void HEPKNOIAMFM(Vector3 CNBICOEGBNM, Vector3 EMLKPCFFBLJ, out Vector3 KFHMDMHIKHA, out Vector3 EIBDGDOPOBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class IJDPBDEIJMN
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class BCAKLKEGBHM : GDJBDCHFLPM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x113CD70", Offset = "0x113C170", VA = "0x18113CD70", Slot = "4")]
		public Vector3 BDBLAPFOLKN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x113CD70", Offset = "0x113C170", VA = "0x18113CD70", Slot = "5")]
		public Vector3 LMKHJOLEIIA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public BCAKLKEGBHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static GDJBDCHFLPM DDHCOFNPHMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4EAFA30", Offset = "0x4EAEE30", VA = "0x184EAFA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NMCGJCCOOHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	CollisionDetectionMode MFPLMICGDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FHCJDMLKKLF();

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EOHNBBMPKLN(bool EFFLGKBJAMB);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PMLCENAIDKL(bool EFFLGKBJAMB);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GPBCEHCAEIE(Rigidbody EMOKGIOEOMC);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JGKJKBBGHKF(Vector3 IJOKHPEAHHL, out RaycastHit HJNBLBFBKNA, float PAKNAMCBNFF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JDPDNLNKMOL : IDisposable, CNCEJGIFHLA
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CKFADKHCOCO CNANIPFOIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<AOJPHEJCEIM, AOJPHEJCEIM> HONLBKEHBHM;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FHCJDMLKKLF();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[CIKFNDBCLGD(BADKLKEFGCO.Application)]
public interface HNPLEDGEHJM
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NKPNDPJNKPK PEBBGGAKMOG(LDFFFADLJJJ MDAIEADLBOD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IIBIBAOAIIL AJGKEIPFFII(LDFFFADLJJJ MDAIEADLBOD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IOJIKJOEGAG IDJMKIABLPM(LDFFFADLJJJ MDAIEADLBOD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EJJCAPKOAPE LEHJOCKCOMM(LDFFFADLJJJ MDAIEADLBOD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ILGKLKEDKPI IJODDIPBKAA(LDFFFADLJJJ MDAIEADLBOD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JDPDNLNKMOL GMADCNBNHFC(LDFFFADLJJJ MDAIEADLBOD);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KJJJDFEAIEN FCDBMBJKIDM(LDFFFADLJJJ MDAIEADLBOD);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ILOOGBEPGEC AEFONNIOMCI(LDFFFADLJJJ MDAIEADLBOD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NMCGJCCOOHJ KGGFHEGMFLF(LDFFFADLJJJ MDAIEADLBOD);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NPGCEJMKCHP LEDPNGNHKGL(LDFFFADLJJJ MDAIEADLBOD);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KEMMHKDIIBP FMFPPDHFDNJ(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	AMBACEAOLLK POFPJNFIOBP(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HMOBGIIKKNK BLPKEJNBFIL(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	COBPCPMCJAM PDAPNHPDCCC(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GJOEJMLHHMK NLCFPEEEPEN(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	LDFFFADLJJJ OPJEPJEFDJG(RigidbodyEx EIOOACKMMIN, CEGPKCKJNIC HANEMGLFJMM, LMAIHHGHGOJ INFFNKABNHB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ILOOGBEPGEC
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJJLKBEFOJB(Vector3 LGPEEBCPBMM, ForceMode BIAGFHEEGCO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MPMOKOLACFD(Vector3 LGPEEBCPBMM, Vector3 IAMBOGDEHMB, ForceMode BIAGFHEEGCO);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DEPAIDKHKDC(Vector3 NNOLOLENPFH, ForceMode BIAGFHEEGCO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BPIEDDANJJE(Vector3 NNOLOLENPFH, ForceMode BIAGFHEEGCO = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NPGCEJMKCHP
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool JDJININOJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GPBCEHCAEIE(Rigidbody EMOKGIOEOMC);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JJLFJOIGLGI(Rigidbody EMOKGIOEOMC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NKPNDPJNKPK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	IReadOnlyList<LDFFFADLJJJ> MMKJCMJHBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	LDFFFADLJJJ HNOOCOABLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	LDFFFADLJJJ MPHEKDGOELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event OBKDBINKHFD OFAAEPPCPMC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event OBKDBINKHFD HCCGNILBJFP;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event LBNCGHJEAIO LKJPOLHAOCC;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action MPJHBDPMHPE;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action FFPHKHEKBCL;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<LDFFFADLJJJ> KANHDBMMLND;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<LDFFFADLJJJ> PCHHDBLJBJH;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action JEJFOJFCOKH;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<LDFFFADLJJJ> ELDDJKDNPFG;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FFPPMEKEJBA(LDFFFADLJJJ GIJFJALMMOL, bool FNAFEHLKFEA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface IOJIKJOEGAG
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 GCPCJKOFFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 FHKMIHLBOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EEKIMDFIJMO(LDFFFADLJJJ BLENCGKHIJI, object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NJCKEKJHDOH(object PFJMMABJIDH);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface COBPCPMCJAM
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 GMGFNLABCLI
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 GPHDDLFKNHF
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float LDPEDKDIMEL
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float MPAIGPICGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Vector3 FJFFKOHHCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Quaternion KJGEANOCBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event OBKDBINKHFD MEBFCFJBPPB;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KPFCNOPBPFJ();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JPJFJEOEPBM();

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EGDEGICGGIP();

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GPBCEHCAEIE(Rigidbody EMOKGIOEOMC);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JJLFJOIGLGI(Rigidbody EMOKGIOEOMC);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NDEFFPLIHBE();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface HMOBGIIKKNK
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool NJANEGEJNFC
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	OBMNDCKAAPN ALNHKIHJPEP
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FHCJDMLKKLF();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JLBEOANOHLG(object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DCJCOAGCMAO(object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OIMAOBNILAB(LDFFFADLJJJ EIOOACKMMIN);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KLBGBFKKAAA(LDFFFADLJJJ EIOOACKMMIN);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KGLNIBBHPBH();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface KJJJDFEAIEN
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool JJCEADPPMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	IEnumerable<object> GIMIFJJJPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event OBKDBINKHFD BAOFIHNMMMB;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BIFPDPDDGDL(object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NANINNNICOB(object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BAEFPBDLCOE(object PFJMMABJIDH, bool MDOKFMLNLCB);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable HHMHIEDHOHN();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GPBCEHCAEIE(Rigidbody MCFBEICDKMP);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JJLFJOIGLGI(Rigidbody EMOKGIOEOMC);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface AMBACEAOLLK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool AOGGMNBIPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool GLNBGDPGNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event OBKDBINKHFD FOONNAAAKEG;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FHCJDMLKKLF();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PANBGPFHFPJ(LDFFFADLJJJ BLENCGKHIJI);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FPDEOLOBGJF(LDFFFADLJJJ BLENCGKHIJI);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GJOEJMLHHMK
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool PNKNIIFGHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool EGIJJCPIMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	RigidbodyConstraints DOLBOFHHNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GPBCEHCAEIE(Rigidbody EMOKGIOEOMC);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JJLFJOIGLGI(Rigidbody EMOKGIOEOMC);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface EJJCAPKOAPE
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	float IHABGKBJPJE
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float OJJNNNPAIOB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GPBCEHCAEIE(Rigidbody EMOKGIOEOMC);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JJLFJOIGLGI(Rigidbody EMOKGIOEOMC);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface AMGKNLCBADC
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx NIPHDNAACJG);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface ILGKLKEDKPI
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event OBKDBINKHFD DPJIEBMHGDB;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FHCJDMLKKLF();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MDDEJDBMFIN();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FOADLPPLLJJ();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LBEKAGHMMIN();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PLJBAMJCMKD();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DAPMLKLECBB();

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JHNLKPNKEBM(bool LJBNFKDALHI);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KEMMHKDIIBP
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Rigidbody HHEABFBCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHCJDMLKKLF();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NHPIIIMMNPK(object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PENEMIKMOLK(object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KHKJOHJIJDJ();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BNABEKGONBF();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BJEJPEJGCEL();

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LBLHJOEBAEG();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface IIBIBAOAIIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	GDJBDCHFLPM IKKDOCCFOPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	MDBCJGELOMO EMIMILKLLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 MFJJIFMGMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 FOIPNDJDCJL
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 KMHIECBCLMO
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	Vector3 CMDADPOFJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float FIHINFGIBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool NGJJKMHFKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FHCJDMLKKLF();

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void APNABGJPFJD(object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KIDNLLJJIDN(IAABFEHMLCH KLINALAALOC, Vector3 OIEKPCBPIOL, float PBEJEHPPJEK = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void ALPEEHFPDIC(IJDCLCAKEAN LEIHBICAMKK, Vector3 KAFKHBLOAFI, float MDPIMMDABFN, float ONCCEMEBFFA = 8f, float CMDCCPIAHFP = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HNDILLGBLAC(IAABFEHMLCH KLINALAALOC, Vector3 BOMBFPIEJKJ, float FOKMAHAMPKL = 7f, float IPMBDAIGFIH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KLEFLIGGHCK();

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void CMPJEOBIHGK();

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FIAEKINLCJN();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MMAEAMLHNPE();

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GPBCEHCAEIE(Rigidbody EMOKGIOEOMC);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 EPOCOFMAFLK(Vector3 FEBDBINBLMJ);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 DHEAGNCIMFN(Vector3 CNBICOEGBNM);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void BIDLBKJIOAI(object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void ICGIKNDEMKP(Vector3 DCLIGMBGEME);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void AJPIKIEJJON(Vector3 JKKOHPMJAOG, Vector3 OPEKPFLGIJJ);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GINACPDMAJK(Vector3 DDMIKGEOOPO, Vector3 HAFOPEOGPCE);

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 OGIHLPOGFOM(Vector3 NMEPDMHFFKO);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 LLLJCOENOCC(Vector3 KINMMEKNHJL);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[CIKFNDBCLGD(BADKLKEFGCO.Application)]
public interface DJICCHFCEBA
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool MAGJLCBONNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PADDHJEJKKF(string DNNOOMDNIBN);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GDHIMDMINJB(RigidbodyEx EIOOACKMMIN, Action PADKGNIPPLI);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DGBFOPLPHNA DKIKKMLCEOE(int ICCDNKDAJAM);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LNPGJDEIANC(Vector3 BODEKFHIHLB, float MNKAMLFNBID, Color GIPDGGFIBAH);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[CIKFNDBCLGD(BADKLKEFGCO.Application)]
public interface LMAIHHGHGOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	DJICCHFCEBA LFHAICJIGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	HNPLEDGEHJM PFLFOBPDCAO
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool DOAACDNCMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HOGBEFGIKOI IEEGGJDBNAK(RigidbodyEx EIOOACKMMIN);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LDFFFADLJJJ OPJEPJEFDJG(RigidbodyEx EIOOACKMMIN, CEGPKCKJNIC HANEMGLFJMM);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	internal RigidbodyEx IJGICMFENBE(GameObject LJDNPPGJLHN, [Optional] CEGPKCKJNIC HANEMGLFJMM);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface MDBCJGELOMO
{
	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBMDCNOIFDP(Vector3 MDEJDJDPCIN);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIAGBGIMKIM(Vector3 FEBDBINBLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OGGJOHPAELL(Vector3 MDEJDJDPCIN);

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LIBDLEGGBME(Vector3 FEBDBINBLMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface GDJBDCHFLPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 BDBLAPFOLKN();

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 LMKHJOLEIIA();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface LDFFFADLJJJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	Rigidbody HHEABFBCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	RigidbodyEx DNNFDLPJDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	GameObject PNKCHCINMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	Transform CNKOEBEMMDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	IEnumerable<object> JIJNFAHPCHL
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	LDFFFADLJJJ MPHEKDGOELO
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	IReadOnlyList<LDFFFADLJJJ> MMKJCMJHBBC
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	LDFFFADLJJJ HNOOCOABLIK
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	bool FIIKANAHFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool AOGGMNBIPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool GLNBGDPGNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	GDJBDCHFLPM IKKDOCCFOPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	MDBCJGELOMO EMIMILKLLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	float FIHINFGIBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 FOIPNDJDCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 CMDADPOFJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 MFJJIFMGMLG
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 KMHIECBCLMO
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	bool EDJFMEGPJEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool MGKKHOINCEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool OHGAHICGHKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool NGJJKMHFKCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Vector3 GCPCJKOFFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 FHKMIHLBOLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 GMGFNLABCLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 GPHDDLFKNHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	float LDPEDKDIMEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float MPAIGPICGBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 FJFFKOHHCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Quaternion KJGEANOCBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float IHABGKBJPJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float OJJNNNPAIOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	bool JDJININOJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "47")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	CKFADKHCOCO CNANIPFOIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool JJCEADPPMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Transform LGMPJDMJFAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Transform PAAMJCKPJFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Vector3 BAJFFFJJAEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	float AJFBKKCMDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float GCPIGMMGPEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "58")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	Quaternion DOJFCBEJNON
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "60")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Vector3 PCBACGKMIOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Quaternion NJDEEIELFBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "64")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	RigidbodyConstraints DOLBOFHHNAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "66")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	bool PNKNIIFGHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	CollisionDetectionMode MFPLMICGDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "70")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	bool KOJKALGLCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event OBKDBINKHFD OFAAEPPCPMC;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event OBKDBINKHFD HCCGNILBJFP;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event LBNCGHJEAIO LKJPOLHAOCC;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event OBKDBINKHFD FOONNAAAKEG;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event OBKDBINKHFD OLHJFHBKGMD;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event OBKDBINKHFD DPJIEBMHGDB;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<AOJPHEJCEIM, AOJPHEJCEIM> HONLBKEHBHM;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event OBKDBINKHFD DODKPAEOBBP;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event OBKDBINKHFD BIEKLOKNMHF;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void FHCJDMLKKLF();

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void PJABKKDODIH();

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void DDCMKFIJMIH();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void LBEKAGHMMIN();

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void NEOGNAGJGHE();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void FFPPMEKEJBA(LDFFFADLJJJ PKODKJLGOIN, bool FNAFEHLKFEA = false);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void PPKOIAMPNOC(object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void KPEPGENHJJP(object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 LLLJCOENOCC(Vector3 KINMMEKNHJL);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "89")]
	Vector3 OGIHLPOGFOM(Vector3 NMEPDMHFFKO);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void MMAEAMLHNPE();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void CMPJEOBIHGK();

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void KLEFLIGGHCK();

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void GINACPDMAJK(Vector3 DDMIKGEOOPO, Vector3 HAFOPEOGPCE);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void AJPIKIEJJON(Vector3 JKKOHPMJAOG, Vector3 OPEKPFLGIJJ);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void ICGIKNDEMKP(Vector3 DCLIGMBGEME);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void ALPEEHFPDIC(IJDCLCAKEAN LEIHBICAMKK, Vector3 KAFKHBLOAFI, float MDPIMMDABFN, float ONCCEMEBFFA = 8f, float CMDCCPIAHFP = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void KIDNLLJJIDN(IAABFEHMLCH KLINALAALOC, Vector3 OIEKPCBPIOL, float PBEJEHPPJEK = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void HNDILLGBLAC(IAABFEHMLCH KLINALAALOC, Vector3 BOMBFPIEJKJ, float FOKMAHAMPKL = 7f, float IPMBDAIGFIH = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 DHEAGNCIMFN(Vector3 PKODKJLGOIN);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "100")]
	Vector3 EPOCOFMAFLK(Vector3 PKODKJLGOIN);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void FIAEKINLCJN();

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void NAKDOJMHHBK(LDFFFADLJJJ LGNMDJNNIHP, object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void ALAFJOHOAFK(object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void JPJFJEOEPBM();

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void KPFCNOPBPFJ();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void EGDEGICGGIP();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "111")]
	bool MDDEJDBMFIN();

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void DAPMLKLECBB();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "117")]
	IDisposable HHMHIEDHOHN();

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void BIFPDPDDGDL(object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void NANINNNICOB(object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void BAEFPBDLCOE(object PFJMMABJIDH, bool MDOKFMLNLCB);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void FILFMDDFAOD(Vector3 EFFLEILEAOJ, Quaternion EOJPJJFENEG);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void LJNGCDFDFEB(Vector3 AGLOIALKBAN, Quaternion AOPMNOAKDHA);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "125")]
	bool NGCEOJEOCMH(float KALFLGFFPIH);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void FOMAJCJPCCE(object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void CMGDFHNIMEA(object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void NHPIIIMMNPK(object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void PENEMIKMOLK(object PFJMMABJIDH);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void KJJLKBEFOJB(Vector3 LGPEEBCPBMM, ForceMode BIAGFHEEGCO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void MPMOKOLACFD(Vector3 LGPEEBCPBMM, Vector3 IAMBOGDEHMB, ForceMode BIAGFHEEGCO);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void DEPAIDKHKDC(Vector3 NNOLOLENPFH, ForceMode BIAGFHEEGCO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void BPIEDDANJJE(Vector3 NNOLOLENPFH, ForceMode BIAGFHEEGCO = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool JGKJKBBGHKF(Vector3 IJOKHPEAHHL, out RaycastHit HJNBLBFBKNA, float PAKNAMCBNFF);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void NDEFFPLIHBE();

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AKDPLPNNHCO : LDFFFADLJJJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal readonly LMAIHHGHGOJ INFFNKABNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal NKPNDPJNKPK NDBEPEANOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal HMOBGIIKKNK JIMGGJGMHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal AMBACEAOLLK CLKGBFAJPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal IIBIBAOAIIL CNBICOEGBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal IOJIKJOEGAG BGPHIMJPLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal COBPCPMCJAM BNOCJAKMMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal EJJCAPKOAPE HNBPLHNNGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal NPGCEJMKCHP MLDELFDAAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal ILGKLKEDKPI HEINOPDMGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal JDPDNLNKMOL AJCILNFHCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal KJJJDFEAIEN AJHLKLMJIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal ILOOGBEPGEC LGPEEBCPBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal GJOEJMLHHMK PKKDNGBCIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal KEMMHKDIIBP EMOKGIOEOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal NMCGJCCOOHJ HMMDGINABFN;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public RigidbodyEx DNNFDLPJDKH
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x673E20", Offset = "0x673220", VA = "0x180673E20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7EC9F0", Offset = "0x7EBDF0", VA = "0x1807EC9F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public GameObject PNKCHCINMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6A96A0", Offset = "0x6A8AA0", VA = "0x1806A96A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x909EA0", Offset = "0x9092A0", VA = "0x180909EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Transform CNKOEBEMMDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x4EA43B0", Offset = "0x4EA37B0", VA = "0x184EA43B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public IEnumerable<object> JIJNFAHPCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x4EA1430", Offset = "0x4EA0830", VA = "0x184EA1430", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Rigidbody HHEABFBCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x4EA4E00", Offset = "0x4EA4200", VA = "0x184EA4E00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public LDFFFADLJJJ MPHEKDGOELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x4E9FD60", Offset = "0x4E9F160", VA = "0x184E9FD60", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3290", Offset = "0x4EA2690", VA = "0x184EA3290", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public IReadOnlyList<LDFFFADLJJJ> MMKJCMJHBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x4EA24F0", Offset = "0x4EA18F0", VA = "0x184EA24F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public LDFFFADLJJJ HNOOCOABLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2330", Offset = "0x4EA1730", VA = "0x184EA2330", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool FIIKANAHFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x4EA4DA0", Offset = "0x4EA41A0", VA = "0x184EA4DA0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool AOGGMNBIPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2010", Offset = "0x4EA1410", VA = "0x184EA2010", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool GLNBGDPGNIE
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x4EA1210", Offset = "0x4EA0610", VA = "0x184EA1210", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public GDJBDCHFLPM IKKDOCCFOPH
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x4EA25D0", Offset = "0x4EA19D0", VA = "0x184EA25D0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3850", Offset = "0x4EA2C50", VA = "0x184EA3850", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public MDBCJGELOMO EMIMILKLLLH
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x4EA17C0", Offset = "0x4EA0BC0", VA = "0x184EA17C0", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0170", Offset = "0x4E9F570", VA = "0x184EA0170", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public float FIHINFGIBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x4E9F8A0", Offset = "0x4E9ECA0", VA = "0x184E9F8A0", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x4EA5750", Offset = "0x4EA4B50", VA = "0x184EA5750", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 FOIPNDJDCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2C90", Offset = "0x4EA2090", VA = "0x184EA2C90", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3780", Offset = "0x4EA2B80", VA = "0x184EA3780", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 CMDADPOFJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0670", Offset = "0x4E9FA70", VA = "0x184EA0670", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x4E9FED0", Offset = "0x4E9F2D0", VA = "0x184E9FED0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 MFJJIFMGMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x4EA20C0", Offset = "0x4EA14C0", VA = "0x184EA20C0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x4E9F950", Offset = "0x4E9ED50", VA = "0x184E9F950", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 KMHIECBCLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x4EA41B0", Offset = "0x4EA35B0", VA = "0x184EA41B0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x4EA5680", Offset = "0x4EA4A80", VA = "0x184EA5680", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool EDJFMEGPJEM
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0230", Offset = "0x4E9F630", VA = "0x184EA0230", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool MGKKHOINCEI
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0610", Offset = "0x4E9FA10", VA = "0x184EA0610", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool OHGAHICGHKK
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x4EA4030", Offset = "0x4EA3430", VA = "0x184EA4030", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool NGJJKMHFKCD
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2380", Offset = "0x4EA1780", VA = "0x184EA2380", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 GCPCJKOFFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x4E9FE00", Offset = "0x4E9F200", VA = "0x184E9FE00", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Vector3 FHKMIHLBOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x4E9FB10", Offset = "0x4E9EF10", VA = "0x184E9FB10", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 GMGFNLABCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3F60", Offset = "0x4EA3360", VA = "0x184EA3F60", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x4EA36B0", Offset = "0x4EA2AB0", VA = "0x184EA36B0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Vector3 GPHDDLFKNHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x4EA23D0", Offset = "0x4EA17D0", VA = "0x184EA23D0", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public float LDPEDKDIMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2F70", Offset = "0x4EA2370", VA = "0x184EA2F70", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float MPAIGPICGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x4E9FDB0", Offset = "0x4E9F1B0", VA = "0x184E9FDB0", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x4EA31D0", Offset = "0x4EA25D0", VA = "0x184EA31D0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public Vector3 FJFFKOHHCLG
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x4EA1310", Offset = "0x4EA0710", VA = "0x184EA1310", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x4EA4490", Offset = "0x4EA3890", VA = "0x184EA4490", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Quaternion KJGEANOCBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2EA0", Offset = "0x4EA22A0", VA = "0x184EA2EA0", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3CE0", Offset = "0x4EA30E0", VA = "0x184EA3CE0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public float IHABGKBJPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0D10", Offset = "0x4EA0110", VA = "0x184EA0D10", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x4EA01D0", Offset = "0x4E9F5D0", VA = "0x184EA01D0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float OJJNNNPAIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x4EA4160", Offset = "0x4EA3560", VA = "0x184EA4160", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2990", Offset = "0x4EA1D90", VA = "0x184EA2990", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool JDJININOJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2E50", Offset = "0x4EA2250", VA = "0x184EA2E50", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x4EA21E0", Offset = "0x4EA15E0", VA = "0x184EA21E0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public CKFADKHCOCO CNANIPFOIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3390", Offset = "0x4EA2790", VA = "0x184EA3390", Slot = "52")]
		get
		{
			return default(CKFADKHCOCO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x4EA1F50", Offset = "0x4EA1350", VA = "0x184EA1F50", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool JJCEADPPMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x4EA24A0", Offset = "0x4EA18A0", VA = "0x184EA24A0", Slot = "54")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public Transform LGMPJDMJFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x4EA00B0", Offset = "0x4E9F4B0", VA = "0x184EA00B0", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Transform PAAMJCKPJFN
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x4EA00B0", Offset = "0x4E9F4B0", VA = "0x184EA00B0", Slot = "56")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public Vector3 BAJFFFJJAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x4EA47A0", Offset = "0x4EA3BA0", VA = "0x184EA47A0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x4EA5490", Offset = "0x4EA4890", VA = "0x184EA5490", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public float AJFBKKCMDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2C30", Offset = "0x4EA2030", VA = "0x184EA2C30", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x4EA33E0", Offset = "0x4EA27E0", VA = "0x184EA33E0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public float GCPIGMMGPEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x4E9F8F0", Offset = "0x4E9ECF0", VA = "0x184E9F8F0", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2670", Offset = "0x4EA1A70", VA = "0x184EA2670", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Quaternion DOJFCBEJNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x4EA00C0", Offset = "0x4E9F4C0", VA = "0x184EA00C0", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2540", Offset = "0x4EA1940", VA = "0x184EA2540", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Vector3 PCBACGKMIOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x4EA05C0", Offset = "0x4E9F9C0", VA = "0x184EA05C0", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2190", Offset = "0x4EA1590", VA = "0x184EA2190", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Quaternion NJDEEIELFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x4EA4C60", Offset = "0x4EA4060", VA = "0x184EA4C60", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x4EA1480", Offset = "0x4EA0880", VA = "0x184EA1480", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public RigidbodyConstraints DOLBOFHHNAL
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x4EA4560", Offset = "0x4EA3960", VA = "0x184EA4560", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x4EA38B0", Offset = "0x4EA2CB0", VA = "0x184EA38B0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool PNKNIIFGHOH
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x4EA4EB0", Offset = "0x4EA42B0", VA = "0x184EA4EB0", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3230", Offset = "0x4EA2630", VA = "0x184EA3230", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public CollisionDetectionMode MFPLMICGDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3340", Offset = "0x4EA2740", VA = "0x184EA3340", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0B40", Offset = "0x4E9FF40", VA = "0x184EA0B40", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool KOJKALGLCJD
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x4EA03A0", Offset = "0x4E9F7A0", VA = "0x184EA03A0", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event OBKDBINKHFD OFAAEPPCPMC
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0560", Offset = "0x4E9F960", VA = "0x184EA0560", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3EA0", Offset = "0x4EA32A0", VA = "0x184EA3EA0", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event OBKDBINKHFD HCCGNILBJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x4EA0340", Offset = "0x4E9F740", VA = "0x184EA0340", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x4EA5430", Offset = "0x4EA4830", VA = "0x184EA5430", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event LBNCGHJEAIO LKJPOLHAOCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4EA4E50", Offset = "0x4EA4250", VA = "0x184EA4E50", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4EA02E0", Offset = "0x4E9F6E0", VA = "0x184EA02E0", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event OBKDBINKHFD FOONNAAAKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3F00", Offset = "0x4EA3300", VA = "0x184EA3F00", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x4EA5330", Offset = "0x4EA4730", VA = "0x184EA5330", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event OBKDBINKHFD OLHJFHBKGMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x4EA52D0", Offset = "0x4EA46D0", VA = "0x184EA52D0", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2B00", Offset = "0x4EA1F00", VA = "0x184EA2B00", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event OBKDBINKHFD DPJIEBMHGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x4EA14C0", Offset = "0x4EA08C0", VA = "0x184EA14C0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x4E9F840", Offset = "0x4E9EC40", VA = "0x184E9F840", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<AOJPHEJCEIM, AOJPHEJCEIM> HONLBKEHBHM
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3A70", Offset = "0x4EA2E70", VA = "0x184EA3A70", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3AD0", Offset = "0x4EA2ED0", VA = "0x184EA3AD0", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event OBKDBINKHFD DODKPAEOBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3A10", Offset = "0x4EA2E10", VA = "0x184EA3A10", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2060", Offset = "0x4EA1460", VA = "0x184EA2060", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event OBKDBINKHFD BIEKLOKNMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x4E9FFA0", Offset = "0x4E9F3A0", VA = "0x184E9FFA0", Slot = "125")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x4EA5390", Offset = "0x4EA4790", VA = "0x184EA5390", Slot = "126")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5850", Offset = "0x4EA4C50", VA = "0x184EA5850")]
	public AKDPLPNNHCO(GameObject MGDBDEJKIMA, RigidbodyEx EGIGOCGBEBO, LMAIHHGHGOJ INFFNKABNHB, in CEGPKCKJNIC HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4EA07F0", Offset = "0x4E9FBF0", VA = "0x184EA07F0", Slot = "142")]
	protected virtual void CNIFGOMKBGM(LMAIHHGHGOJ INFFNKABNHB, CEGPKCKJNIC HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1140", Offset = "0x4EA0540", VA = "0x184EA1140", Slot = "143")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1680", Offset = "0x4EA0A80", VA = "0x184EA1680", Slot = "76")]
	public void FHCJDMLKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4EA4440", Offset = "0x4EA3840", VA = "0x184EA4440", Slot = "77")]
	public void PJABKKDODIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0B20", Offset = "0x4E9FF20", VA = "0x184EA0B20", Slot = "78")]
	public void DDCMKFIJMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x4EA4BB0", Offset = "0x4EA3FB0", VA = "0x184EA4BB0", Slot = "144")]
	public virtual void NEOGNAGJGHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1610", Offset = "0x4EA0A10", VA = "0x184EA1610", Slot = "87")]
	public void FFPPMEKEJBA(LDFFFADLJJJ PKODKJLGOIN, bool FNAFEHLKFEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x4EA57B0", Offset = "0x4EA4BB0", VA = "0x184EA57B0", Slot = "90")]
	public void PPKOIAMPNOC(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3910", Offset = "0x4EA2D10", VA = "0x184EA3910", Slot = "91")]
	public void KPEPGENHJJP(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3DB0", Offset = "0x4EA31B0", VA = "0x184EA3DB0", Slot = "92")]
	public Vector3 LLLJCOENOCC(Vector3 KINMMEKNHJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x4EA4F00", Offset = "0x4EA4300", VA = "0x184EA4F00", Slot = "93")]
	public Vector3 OGIHLPOGFOM(Vector3 NMEPDMHFFKO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x4EA4440", Offset = "0x4EA3840", VA = "0x184EA4440", Slot = "94")]
	public void MMAEAMLHNPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x4EA07A0", Offset = "0x4E9FBA0", VA = "0x184EA07A0", Slot = "95")]
	public void CMPJEOBIHGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3660", Offset = "0x4EA2A60", VA = "0x184EA3660", Slot = "96")]
	public void KLEFLIGGHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x4EA2240", Offset = "0x4EA1640", VA = "0x184EA2240", Slot = "97")]
	public void GINACPDMAJK(Vector3 DDMIKGEOOPO, Vector3 HAFOPEOGPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x4E9FA20", Offset = "0x4E9EE20", VA = "0x184E9FA20", Slot = "98")]
	public void AJPIKIEJJON(Vector3 JKKOHPMJAOG, Vector3 OPEKPFLGIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x4EA2B60", Offset = "0x4EA1F60", VA = "0x184EA2B60", Slot = "99")]
	public void ICGIKNDEMKP(Vector3 DCLIGMBGEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x4E9FC40", Offset = "0x4E9F040", VA = "0x184E9FC40", Slot = "100")]
	public void ALPEEHFPDIC(IJDCLCAKEAN LEIHBICAMKK, Vector3 KAFKHBLOAFI, float MDPIMMDABFN, float ONCCEMEBFFA = 8f, float CMDCCPIAHFP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x4EA34E0", Offset = "0x4EA28E0", VA = "0x184EA34E0", Slot = "101")]
	public void KIDNLLJJIDN(IAABFEHMLCH KLINALAALOC, Vector3 OIEKPCBPIOL, float PBEJEHPPJEK = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x4EA29F0", Offset = "0x4EA1DF0", VA = "0x184EA29F0", Slot = "102")]
	[Obsolete]
	public void HNDILLGBLAC(IAABFEHMLCH KLINALAALOC, Vector3 BOMBFPIEJKJ, float FOKMAHAMPKL = 7f, float IPMBDAIGFIH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0C20", Offset = "0x4EA0020", VA = "0x184EA0C20", Slot = "103")]
	public Vector3 DHEAGNCIMFN(Vector3 PKODKJLGOIN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1520", Offset = "0x4EA0920", VA = "0x184EA1520", Slot = "104")]
	public Vector3 EPOCOFMAFLK(Vector3 PKODKJLGOIN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1810", Offset = "0x4EA0C10", VA = "0x184EA1810", Slot = "105")]
	public void FIAEKINLCJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x4EA4960", Offset = "0x4EA3D60", VA = "0x184EA4960", Slot = "106")]
	public void NAKDOJMHHBK(LDFFFADLJJJ LGNMDJNNIHP, object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x4E9FBE0", Offset = "0x4E9EFE0", VA = "0x184E9FBE0", Slot = "107")]
	public void ALAFJOHOAFK(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4EA32F0", Offset = "0x4EA26F0", VA = "0x184EA32F0", Slot = "110")]
	public void JPJFJEOEPBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3970", Offset = "0x4EA2D70", VA = "0x184EA3970", Slot = "111")]
	public void KPFCNOPBPFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x4EA13E0", Offset = "0x4EA07E0", VA = "0x184EA13E0", Slot = "112")]
	public void EGDEGICGGIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x4EA4110", Offset = "0x4EA3510", VA = "0x184EA4110", Slot = "115")]
	public bool MDDEJDBMFIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x4EA39C0", Offset = "0x4EA2DC0", VA = "0x184EA39C0", Slot = "79")]
	public void LBEKAGHMMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0AD0", Offset = "0x4E9FED0", VA = "0x184EA0AD0", Slot = "116")]
	public void DAPMLKLECBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x4EA2620", Offset = "0x4EA1A20", VA = "0x184EA2620", Slot = "121")]
	public IDisposable HHMHIEDHOHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0280", Offset = "0x4E9F680", VA = "0x184EA0280", Slot = "122")]
	public void BIFPDPDDGDL(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4EA4A30", Offset = "0x4EA3E30", VA = "0x184EA4A30", Slot = "123")]
	public void NANINNNICOB(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0040", Offset = "0x4E9F440", VA = "0x184EA0040", Slot = "124")]
	public void BAEFPBDLCOE(object PFJMMABJIDH, bool MDOKFMLNLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1860", Offset = "0x4EA0C60", VA = "0x184EA1860", Slot = "127")]
	public void FILFMDDFAOD(Vector3 EFFLEILEAOJ, Quaternion EOJPJJFENEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3B30", Offset = "0x4EA2F30", VA = "0x184EA3B30", Slot = "128")]
	public void LJNGCDFDFEB(Vector3 AGLOIALKBAN, Quaternion AOPMNOAKDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x4EA4CA0", Offset = "0x4EA40A0", VA = "0x184EA4CA0", Slot = "129")]
	public bool NGCEOJEOCMH(float KALFLGFFPIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1A70", Offset = "0x4EA0E70", VA = "0x184EA1A70", Slot = "130")]
	public void FOMAJCJPCCE(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0740", Offset = "0x4E9FB40", VA = "0x184EA0740", Slot = "131")]
	public void CMGDFHNIMEA(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x4EA4D40", Offset = "0x4EA4140", VA = "0x184EA4D40", Slot = "132")]
	public void NHPIIIMMNPK(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5620", Offset = "0x4EA4A20", VA = "0x184EA5620", Slot = "133")]
	public void PENEMIKMOLK(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x4EA35E0", Offset = "0x4EA29E0", VA = "0x184EA35E0", Slot = "134")]
	public void KJJLKBEFOJB(Vector3 LGPEEBCPBMM, ForceMode BIAGFHEEGCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x4EA4850", Offset = "0x4EA3C50", VA = "0x184EA4850", Slot = "135")]
	public void MPMOKOLACFD(Vector3 LGPEEBCPBMM, Vector3 IAMBOGDEHMB, ForceMode BIAGFHEEGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0BA0", Offset = "0x4E9FFA0", VA = "0x184EA0BA0", Slot = "136")]
	public void DEPAIDKHKDC(Vector3 NNOLOLENPFH, ForceMode BIAGFHEEGCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x4EA04E0", Offset = "0x4E9F8E0", VA = "0x184EA04E0", Slot = "137")]
	public void BPIEDDANJJE(Vector3 NNOLOLENPFH, ForceMode BIAGFHEEGCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x4EA30D0", Offset = "0x4EA24D0", VA = "0x184EA30D0", Slot = "138")]
	public bool JGKJKBBGHKF(Vector3 IJOKHPEAHHL, out RaycastHit HJNBLBFBKNA, float PAKNAMCBNFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x4EA4B60", Offset = "0x4EA3F60", VA = "0x184EA4B60", Slot = "139")]
	public void NDEFFPLIHBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5810", Offset = "0x4EA4C10", VA = "0x184EA5810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x4EA4A90", Offset = "0x4EA3E90", VA = "0x184EA4A90")]
	private void NDBGBIBFHJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x4EA2FC0", Offset = "0x4EA23C0", VA = "0x184EA2FC0")]
	private void JDKLHENFIHN(LDFFFADLJJJ BLENCGKHIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x4EA45B0", Offset = "0x4EA39B0", VA = "0x184EA45B0")]
	private void MOBAOBMLGBI(LDFFFADLJJJ BLENCGKHIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1260", Offset = "0x4EA0660", VA = "0x184EA1260")]
	private void EBIDIKMGNAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x4EA2D60", Offset = "0x4EA2160", VA = "0x184EA2D60")]
	private void IMCOJDCEJDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0D60", Offset = "0x4EA0160", VA = "0x184EA0D60")]
	private void DIGNNGMNMFB(LDFFFADLJJJ DCMIHJECFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5540", Offset = "0x4EA4940", VA = "0x184EA5540")]
	private void PANBGPFHFPJ(LDFFFADLJJJ BLENCGKHIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1AD0", Offset = "0x4EA0ED0", VA = "0x184EA1AD0")]
	private void FPDEOLOBGJF(LDFFFADLJJJ BLENCGKHIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x4EA2820", Offset = "0x4EA1C20", VA = "0x184EA2820")]
	private void HIHMFPFGEMH(RigidbodyEx BLENCGKHIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x4EA1BB0", Offset = "0x4EA0FB0", VA = "0x184EA1BB0")]
	private void GAOGAIHMCDM(RigidbodyEx EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x4EA4280", Offset = "0x4EA3680", VA = "0x184EA4280")]
	[Conditional("UNITY_EDITOR")]
	private void MHLNMJBBANJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x4EA4FF0", Offset = "0x4EA43F0", VA = "0x184EA4FF0")]
	protected void OIBIFCHKKEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x4EA0E10", Offset = "0x4EA0210", VA = "0x184EA0E10")]
	protected void DPHHFJKAHCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class CCFBPECKLLD
{
	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6120", Offset = "0x4EA5520", VA = "0x184EA6120")]
	public static LDFFFADLJJJ NAADGLAGFMP(this LDFFFADLJJJ EIOOACKMMIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x4EA61E0", Offset = "0x4EA55E0", VA = "0x184EA61E0")]
	public static bool PPLNPEAEJKH(this LDFFFADLJJJ EIOOACKMMIN, LDFFFADLJJJ OALCGOPGEPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5FE0", Offset = "0x4EA53E0", VA = "0x184EA5FE0")]
	public static bool ALPCJICDGPO(this LDFFFADLJJJ EIOOACKMMIN, LDFFFADLJJJ FEDMCMKGGIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6060", Offset = "0x4EA5460", VA = "0x184EA6060")]
	public static RigidbodyEx DNNFDLPJDKH(this LDFFFADLJJJ FMPGMEEKJBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x4EA60B0", Offset = "0x4EA54B0", VA = "0x184EA60B0")]
	public static AKDPLPNNHCO INAFAGIKOPC(this LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class FAJFDIHHIKA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly AKDPLPNNHCO EIOOACKMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private bool HFPLCOEDAAK;

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x4EACD30", Offset = "0x4EAC130", VA = "0x184EACD30")]
	public FAJFDIHHIKA(AKDPLPNNHCO ELJCHDFDAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x4EACCD0", Offset = "0x4EAC0D0", VA = "0x184EACCD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class LMNJJOJMCED : PJADMJOPMOP, NMCGJCCOOHJ
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private CollisionDetectionMode LEKFNNFCDNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x4EB5A50", Offset = "0x4EB4E50", VA = "0x184EB5A50")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x4EB56D0", Offset = "0x4EB4AD0", VA = "0x184EB56D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private Rigidbody HHEABFBCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x4E9F5A0", Offset = "0x4E9E9A0", VA = "0x184E9F5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public CollisionDetectionMode MFPLMICGDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x4EB5940", Offset = "0x4EB4D40", VA = "0x184EB5940", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x4EB54A0", Offset = "0x4EB48A0", VA = "0x184EB54A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6EE0", Offset = "0x4EA62E0", VA = "0x184EA6EE0")]
	public LMNJJOJMCED(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x4EB5530", Offset = "0x4EB4930", VA = "0x184EB5530", Slot = "6")]
	public void FHCJDMLKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x4EB5640", Offset = "0x4EB4A40", VA = "0x184EB5640", Slot = "9")]
	public void GPBCEHCAEIE(Rigidbody EMOKGIOEOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x4EB5520", Offset = "0x4EB4920", VA = "0x184EB5520", Slot = "7")]
	public void EOHNBBMPKLN(bool EFFLGKBJAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x4EB5B40", Offset = "0x4EB4F40", VA = "0x184EB5B40", Slot = "8")]
	public void PMLCENAIDKL(bool EFFLGKBJAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x4EB57D0", Offset = "0x4EB4BD0", VA = "0x184EB57D0", Slot = "10")]
	public bool JGKJKBBGHKF(Vector3 IJOKHPEAHHL, out RaycastHit HJNBLBFBKNA, float PAKNAMCBNFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x4EB52A0", Offset = "0x4EB46A0", VA = "0x184EB52A0")]
	private void BCHKKAGPGJJ(bool EFFLGKBJAMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class OMIAGDLNCJA : PJADMJOPMOP, JDPDNLNKMOL, IDisposable, CNCEJGIFHLA
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CKFADKHCOCO JJIIOKAOIIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x4EBF080", Offset = "0x4EBE480", VA = "0x184EBF080")]
		get
		{
			return default(CKFADKHCOCO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x4EBEF80", Offset = "0x4EBE380", VA = "0x184EBEF80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public CKFADKHCOCO CNANIPFOIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x4EBF170", Offset = "0x4EBE570", VA = "0x184EBF170", Slot = "6")]
		get
		{
			return default(CKFADKHCOCO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x4EBEF80", Offset = "0x4EBE380", VA = "0x184EBEF80", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private Transform KCDOGBBMOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x674170", Offset = "0x673570", VA = "0x180674170", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<AOJPHEJCEIM, AOJPHEJCEIM> HONLBKEHBHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x4EBF390", Offset = "0x4EBE790", VA = "0x184EBF390", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x4EBF430", Offset = "0x4EBE830", VA = "0x184EBF430", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6EE0", Offset = "0x4EA62E0", VA = "0x184EA6EE0")]
	public OMIAGDLNCJA(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x4EBF4D0", Offset = "0x4EBE8D0", VA = "0x184EBF4D0", Slot = "11")]
	public void OnChangedDistanceBand(AOJPHEJCEIM ICBMMLPPJIN, AOJPHEJCEIM LPLBPOMCKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "12")]
	public void OnChangedVisibility(bool PHIOBBHMIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "8")]
	public void FHCJDMLKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class PPMIGCBKACG : PJADMJOPMOP, ILOOGBEPGEC
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private Rigidbody HHEABFBCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x5FC21A0", Offset = "0x5FC15A0", VA = "0x185FC21A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool JJCEADPPMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1C90", Offset = "0x5FC1090", VA = "0x185FC1C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool FIIKANAHFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2180", Offset = "0x5FC1580", VA = "0x185FC2180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private LDFFFADLJJJ MPHEKDGOELO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x5FC1750", Offset = "0x5FC0B50", VA = "0x185FC1750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x5FC16D0", Offset = "0x5FC0AD0", VA = "0x185FC16D0")]
	public PPMIGCBKACG(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1E90", Offset = "0x5FC1290", VA = "0x185FC1E90", Slot = "4")]
	public void KJJLKBEFOJB(Vector3 LGPEEBCPBMM, ForceMode BIAGFHEEGCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1CB0", Offset = "0x5FC10B0", VA = "0x185FC1CB0")]
	private void IGLDCBHBJOD(Vector3 LGPEEBCPBMM, ForceMode BIAGFHEEGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1F80", Offset = "0x5FC1380", VA = "0x185FC1F80", Slot = "5")]
	public void MPMOKOLACFD(Vector3 LGPEEBCPBMM, Vector3 IAMBOGDEHMB, ForceMode BIAGFHEEGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1B70", Offset = "0x5FC0F70", VA = "0x185FC1B70", Slot = "6")]
	public void DEPAIDKHKDC(Vector3 NNOLOLENPFH, ForceMode BIAGFHEEGCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1990", Offset = "0x5FC0D90", VA = "0x185FC1990")]
	private void CJCCLMCBDEJ(Vector3 NNOLOLENPFH, ForceMode BIAGFHEEGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x5FC17B0", Offset = "0x5FC0BB0", VA = "0x185FC17B0", Slot = "7")]
	public void BPIEDDANJJE(Vector3 NNOLOLENPFH, ForceMode BIAGFHEEGCO = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class EFELACGMBMJ : PJADMJOPMOP, NPGCEJMKCHP
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool JDJININOJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x4EAC630", Offset = "0x4EABA30", VA = "0x184EAC630", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x4EAC330", Offset = "0x4EAB730", VA = "0x184EAC330", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6EE0", Offset = "0x4EA62E0", VA = "0x184EA6EE0")]
	public EFELACGMBMJ(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x4EAC510", Offset = "0x4EAB910", VA = "0x184EAC510", Slot = "6")]
	public void GPBCEHCAEIE(Rigidbody EMOKGIOEOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x4EAC720", Offset = "0x4EABB20", VA = "0x184EAC720", Slot = "7")]
	public void JJLFJOIGLGI(Rigidbody EMOKGIOEOMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class CNGGGADDOEO : PJADMJOPMOP, NKPNDPJNKPK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly DEEHOKOEPIE CJDMCMNNBID;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private Transform CNKOEBEMMDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x4EAA960", Offset = "0x4EA9D60", VA = "0x184EAA960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public HOGBEFGIKOI IBPHIIAIPOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x4EA9930", Offset = "0x4EA8D30", VA = "0x184EA9930")]
		get
		{
			return default(HOGBEFGIKOI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x4EAB270", Offset = "0x4EAA670", VA = "0x184EAB270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public LDFFFADLJJJ MPHEKDGOELO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x4EA8ED0", Offset = "0x4EA82D0", VA = "0x184EA8ED0", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x4EAA600", Offset = "0x4EA9A00", VA = "0x184EAA600", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public HOGBEFGIKOI GENFGCOAJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x4EAA7B0", Offset = "0x4EA9BB0", VA = "0x184EAA7B0")]
		get
		{
			return default(HOGBEFGIKOI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x4EAB160", Offset = "0x4EAA560", VA = "0x184EAB160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public LDFFFADLJJJ HNOOCOABLIK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x4EAA480", Offset = "0x4EA9880", VA = "0x184EAA480", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public IReadOnlyList<LDFFFADLJJJ> MMKJCMJHBBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x683770", Offset = "0x682B70", VA = "0x180683770", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event OBKDBINKHFD OFAAEPPCPMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x4EA91F0", Offset = "0x4EA85F0", VA = "0x184EA91F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x4EAA8C0", Offset = "0x4EA9CC0", VA = "0x184EAA8C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event OBKDBINKHFD HCCGNILBJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x4EA90B0", Offset = "0x4EA84B0", VA = "0x184EA90B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x4EAB0C0", Offset = "0x4EAA4C0", VA = "0x184EAB0C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event LBNCGHJEAIO LKJPOLHAOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x4EAAB70", Offset = "0x4EA9F70", VA = "0x184EAAB70", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x4EA9010", Offset = "0x4EA8410", VA = "0x184EA9010", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action MPJHBDPMHPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x4EAA3E0", Offset = "0x4EA97E0", VA = "0x184EAA3E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x4EAA990", Offset = "0x4EA9D90", VA = "0x184EAA990", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action FFPHKHEKBCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x4EAA4C0", Offset = "0x4EA98C0", VA = "0x184EAA4C0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x4EAAF80", Offset = "0x4EAA380", VA = "0x184EAAF80", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<LDFFFADLJJJ> KANHDBMMLND
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x4EAA340", Offset = "0x4EA9740", VA = "0x184EAA340", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x4EA9150", Offset = "0x4EA8550", VA = "0x184EA9150", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<LDFFFADLJJJ> PCHHDBLJBJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x4EA9290", Offset = "0x4EA8690", VA = "0x184EA9290", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x4EA9890", Offset = "0x4EA8C90", VA = "0x184EA9890", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action JEJFOJFCOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x4EAAE40", Offset = "0x4EAA240", VA = "0x184EAAE40", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x4EAB020", Offset = "0x4EAA420", VA = "0x184EAB020", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<LDFFFADLJJJ> ELDDJKDNPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x4EAA560", Offset = "0x4EA9960", VA = "0x184EAA560", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x4EAAEE0", Offset = "0x4EAA2E0", VA = "0x184EAAEE0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x4EAB400", Offset = "0x4EAA800", VA = "0x184EAB400")]
	public CNGGGADDOEO(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x4EA95F0", Offset = "0x4EA89F0", VA = "0x184EA95F0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x4EA9A40", Offset = "0x4EA8E40", VA = "0x184EA9A40", Slot = "26")]
	public void FFPPMEKEJBA(LDFFFADLJJJ GIJFJALMMOL, bool FNAFEHLKFEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x4EA9AC0", Offset = "0x4EA8EC0", VA = "0x184EA9AC0")]
	private void FFPPMEKEJBA(GLAGHEJKLEN GIJFJALMMOL, bool FNAFEHLKFEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8CA0", Offset = "0x4EA80A0", VA = "0x184EA8CA0")]
	private void AAGKGKBGDLF(GLAGHEJKLEN DCMIHJECFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x4EAAC10", Offset = "0x4EAA010", VA = "0x184EAAC10")]
	private void NOPJMLNJJCN(GLAGHEJKLEN DCMIHJECFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x4EA9330", Offset = "0x4EA8730", VA = "0x184EA9330")]
	private void DCBBINMGFDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x4EAB380", Offset = "0x4EAA780", VA = "0x184EAB380")]
	private void PHCCHDHOMEM(GLAGHEJKLEN DCMIHJECFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x4EA97E0", Offset = "0x4EA8BE0", VA = "0x184EA97E0")]
	private void ECDLINPFPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x4EA94D0", Offset = "0x4EA88D0", VA = "0x184EA94D0")]
	private void DJCKLJBBHJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x4EAAA30", Offset = "0x4EA9E30", VA = "0x184EAAA30")]
	private void MNJLDMDAPLM(GLAGHEJKLEN EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x4EAA670", Offset = "0x4EA9A70", VA = "0x184EAA670")]
	private void KKMHFJFCFJD(GLAGHEJKLEN EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8F10", Offset = "0x4EA8310", VA = "0x184EA8F10")]
	[CompilerGenerated]
	private object BCACBAKFOBI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class KADPBJKAOHH
{
	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1E60", Offset = "0x4EB1260", VA = "0x184EB1E60")]
	public static CNGGGADDOEO OJNIAOBKCAC(this LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class CFPALCFPMIH : PJADMJOPMOP, IOJIKJOEGAG
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public Vector3 GCPCJKOFFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x4EA64A0", Offset = "0x4EA58A0", VA = "0x184EA64A0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public Vector3 FHKMIHLBOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x4EA6260", Offset = "0x4EA5660", VA = "0x184EA6260", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	private Vector3 MFJJIFMGMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x4EA6D00", Offset = "0x4EA6100", VA = "0x184EA6D00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	private LDFFFADLJJJ LIAOLHKKHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x4EA67B0", Offset = "0x4EA5BB0", VA = "0x184EA67B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6EE0", Offset = "0x4EA62E0", VA = "0x184EA6EE0")]
	public CFPALCFPMIH(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6610", Offset = "0x4EA5A10", VA = "0x184EA6610", Slot = "6")]
	public void EEKIMDFIJMO(LDFFFADLJJJ BLENCGKHIJI, object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x4EA64D0", Offset = "0x4EA58D0", VA = "0x184EA64D0")]
	private void EEKIMDFIJMO(GLAGHEJKLEN BLENCGKHIJI, object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6DE0", Offset = "0x4EA61E0", VA = "0x184EA6DE0", Slot = "7")]
	public void NJCKEKJHDOH(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6910", Offset = "0x4EA5D10", VA = "0x184EA6910")]
	private Vector3 FMNNLCLCFID()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class EJDOMPLKMIA
{
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x4EACB80", Offset = "0x4EABF80", VA = "0x184EACB80")]
	public static CFPALCFPMIH FNMKOPCBEOP(this LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class MGLEICPPCNI : PJADMJOPMOP, COBPCPMCJAM
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 GMGFNLABCLI
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x4EB8740", Offset = "0x4EB7B40", VA = "0x184EB8740", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x4EB8240", Offset = "0x4EB7640", VA = "0x184EB8240", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 GPHDDLFKNHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x4EB7300", Offset = "0x4EB6700", VA = "0x184EB7300", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public float LDPEDKDIMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x4EB7970", Offset = "0x4EB6D70", VA = "0x184EB7970", Slot = "9")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x4EB72F0", Offset = "0x4EB66F0", VA = "0x184EB72F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public float MPAIGPICGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x4EB5C90", Offset = "0x4EB5090", VA = "0x184EB5C90", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x4EB7DE0", Offset = "0x4EB71E0", VA = "0x184EB7DE0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public Vector3 FJFFKOHHCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x4EB7000", Offset = "0x4EB6400", VA = "0x184EB7000", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x4EB8A50", Offset = "0x4EB7E50", VA = "0x184EB8A50", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public Quaternion KJGEANOCBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x4EB7940", Offset = "0x4EB6D40", VA = "0x184EB7940", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x4EB8720", Offset = "0x4EB7B20", VA = "0x184EB8720", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private Rigidbody HHEABFBCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x4E9F5A0", Offset = "0x4E9E9A0", VA = "0x184E9F5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event OBKDBINKHFD MEBFCFJBPPB
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x4EB7670", Offset = "0x4EB6A70", VA = "0x184EB7670", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x4EB6E40", Offset = "0x4EB6240", VA = "0x184EB6E40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x4EB93A0", Offset = "0x4EB87A0", VA = "0x184EB93A0")]
	public MGLEICPPCNI(LDFFFADLJJJ EIOOACKMMIN, in CEGPKCKJNIC HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x4EB8020", Offset = "0x4EB7420", VA = "0x184EB8020", Slot = "17")]
	public void JPJFJEOEPBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x4EB8380", Offset = "0x4EB7780", VA = "0x184EB8380", Slot = "16")]
	public void KPFCNOPBPFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x4EB7420", Offset = "0x4EB6820", VA = "0x184EB7420", Slot = "19")]
	public void GPBCEHCAEIE(Rigidbody EMOKGIOEOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x4EB7A60", Offset = "0x4EB6E60", VA = "0x184EB7A60", Slot = "20")]
	public void JJLFJOIGLGI(Rigidbody EMOKGIOEOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x4EB7030", Offset = "0x4EB6430", VA = "0x184EB7030", Slot = "18")]
	public void EGDEGICGGIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x4EB8CA0", Offset = "0x4EB80A0", VA = "0x184EB8CA0", Slot = "21")]
	public void NDEFFPLIHBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EDA0", Offset = "0x4E9E1A0", VA = "0x184E9EDA0")]
	public void GHNMJJGFDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x4EB8240", Offset = "0x4EB7640", VA = "0x184EB8240")]
	private void LELPCIDOPDP(Vector3 PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x4EB6EE0", Offset = "0x4EB62E0", VA = "0x184EB6EE0")]
	private Vector3 DONLPDCCKKG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x4EB8880", Offset = "0x4EB7C80", VA = "0x184EB8880")]
	private void MKOFPBFHJHL(float PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x4EB7120", Offset = "0x4EB6520", VA = "0x184EB7120")]
	private void EMIKIENNOPO(float PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x4EB7DF0", Offset = "0x4EB71F0", VA = "0x184EB7DF0")]
	private Vector3 JMDCLJNNLIF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x4EB7710", Offset = "0x4EB6B10", VA = "0x184EB7710")]
	private void IJHGIMKFIHH(Vector3 PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x4EB8A80", Offset = "0x4EB7E80", VA = "0x184EB8A80")]
	private Quaternion NDBELHNICKH()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x4EB9190", Offset = "0x4EB8590", VA = "0x184EB9190")]
	private void OPIOHEIOBCG(Quaternion PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x4EB5D80", Offset = "0x4EB5180", VA = "0x184EB5D80")]
	internal (float, Vector3) BFICJFEPKPK(Rigidbody IBNKACBPOLA)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class KDDHGKALGMC
{
	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1EF0", Offset = "0x4EB12F0", VA = "0x184EB1EF0")]
	public static MGLEICPPCNI GFCKMPJOFGP(this LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class LDKCMFMNKMM : PJADMJOPMOP, HMOBGIIKKNK
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private const string BONPHMCJLKF = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool NJANEGEJNFC
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x4EB4380", Offset = "0x4EB3780", VA = "0x184EB4380", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public OBMNDCKAAPN ALNHKIHJPEP
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x4EB46C0", Offset = "0x4EB3AC0", VA = "0x184EB46C0", Slot = "5")]
		get
		{
			return default(OBMNDCKAAPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	private OBMNDCKAAPN FKNLKNEBHGK
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x4EB46D0", Offset = "0x4EB3AD0", VA = "0x184EB46D0")]
		get
		{
			return default(OBMNDCKAAPN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x4EB4070", Offset = "0x4EB3470", VA = "0x184EB4070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x4EB48A0", Offset = "0x4EB3CA0", VA = "0x184EB48A0")]
	public LDKCMFMNKMM(LDFFFADLJJJ EIOOACKMMIN, in CEGPKCKJNIC HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x4EB42C0", Offset = "0x4EB36C0", VA = "0x184EB42C0", Slot = "6")]
	public void FHCJDMLKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4800", Offset = "0x4EB3C00", VA = "0x184EB4800")]
	private bool PJGGEEILMMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4470", Offset = "0x4EB3870", VA = "0x184EB4470", Slot = "7")]
	public void JLBEOANOHLG(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x4EB3F70", Offset = "0x4EB3370", VA = "0x184EB3F70", Slot = "8")]
	public void DCJCOAGCMAO(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4570", Offset = "0x4EB3970", VA = "0x184EB4570", Slot = "11")]
	public void KGLNIBBHPBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x4EB3E80", Offset = "0x4EB3280", VA = "0x184EB3E80")]
	private void BHJFODIBNHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4170", Offset = "0x4EB3570", VA = "0x184EB4170")]
	private void ENDJDBHHMMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4680", Offset = "0x4EB3A80", VA = "0x184EB4680", Slot = "10")]
	public void KLBGBFKKAAA(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x4EB47C0", Offset = "0x4EB3BC0", VA = "0x184EB47C0", Slot = "9")]
	public void OIMAOBNILAB(LDFFFADLJJJ EIOOACKMMIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class FNDPGFFAENH : PJADMJOPMOP, KJJJDFEAIEN
{
	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool JJCEADPPMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD790", Offset = "0x4EACB90", VA = "0x184EAD790", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public IEnumerable<object> GIMIFJJJPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD950", Offset = "0x4EACD50", VA = "0x184EAD950", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	private bool NELDAAAIMGF
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x4EADA50", Offset = "0x4EACE50", VA = "0x184EADA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event OBKDBINKHFD BAOFIHNMMMB
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD6F0", Offset = "0x4EACAF0", VA = "0x184EAD6F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x4EADB40", Offset = "0x4EACF40", VA = "0x184EADB40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6EE0", Offset = "0x4EA62E0", VA = "0x184EA6EE0")]
	public FNDPGFFAENH(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD8C0", Offset = "0x4EACCC0", VA = "0x184EAD8C0", Slot = "11")]
	public IDisposable HHMHIEDHOHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD6E0", Offset = "0x4EACAE0", VA = "0x184EAD6E0", Slot = "8")]
	public void BIFPDPDDGDL(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x4EADA40", Offset = "0x4EACE40", VA = "0x184EADA40", Slot = "9")]
	public void NANINNNICOB(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD550", Offset = "0x4EAC950", VA = "0x184EAD550", Slot = "10")]
	public void BAEFPBDLCOE(object PFJMMABJIDH, bool MDOKFMLNLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD850", Offset = "0x4EACC50", VA = "0x184EAD850", Slot = "12")]
	public void GPBCEHCAEIE(Rigidbody MCFBEICDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD920", Offset = "0x4EACD20", VA = "0x184EAD920", Slot = "13")]
	public void JJLFJOIGLGI(Rigidbody EMOKGIOEOMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class PBNGPOOLGBN : PJADMJOPMOP, AMBACEAOLLK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private PhotonView HEJFKPMKBDB;

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public bool AOGGMNBIPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x4EBBF20", Offset = "0x4EBB320", VA = "0x184EBBF20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool GLNBGDPGNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x4EBFAA0", Offset = "0x4EBEEA0", VA = "0x184EBFAA0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event OBKDBINKHFD FOONNAAAKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x4EC00F0", Offset = "0x4EBF4F0", VA = "0x184EC00F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x4EC0190", Offset = "0x4EBF590", VA = "0x184EC0190", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x4EC0440", Offset = "0x4EBF840", VA = "0x184EC0440")]
	public PBNGPOOLGBN(LDFFFADLJJJ EIOOACKMMIN, in CEGPKCKJNIC HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x4EBFBC0", Offset = "0x4EBEFC0", VA = "0x184EBFBC0", Slot = "8")]
	public void FHCJDMLKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x4EBF8B0", Offset = "0x4EBECB0", VA = "0x184EBF8B0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x4EC0230", Offset = "0x4EBF630", VA = "0x184EC0230", Slot = "9")]
	public void PANBGPFHFPJ(LDFFFADLJJJ BLENCGKHIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x4EBFD10", Offset = "0x4EBF110", VA = "0x184EBFD10", Slot = "10")]
	public void FPDEOLOBGJF(LDFFFADLJJJ BLENCGKHIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x4EBF530", Offset = "0x4EBE930", VA = "0x184EBF530")]
	private void AINDNODLHIK(PhotonView BMNFGGEEIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x4EBF740", Offset = "0x4EBEB40", VA = "0x184EBF740")]
	private void CMOINLLJLHN(RigidbodyEx OJPMCPFEKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x4EBFF20", Offset = "0x4EBF320", VA = "0x184EBFF20")]
	private void KIHDEKCAEMF(PhotonView FLIKLLIJCPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class HEADJLOLIPH
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE4A0", Offset = "0x4EAD8A0", VA = "0x184EAE4A0")]
	public static PBNGPOOLGBN NMJDFAEJBPE(this AKDPLPNNHCO MDAIEADLBOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class AAAPKMLLJPI : PJADMJOPMOP, GJOEJMLHHMK
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool PNKNIIFGHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x4E9AE60", Offset = "0x4E9A260", VA = "0x184E9AE60", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x4E9A870", Offset = "0x4E99C70", VA = "0x184E9A870", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool EGIJJCPIMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x4E9AD70", Offset = "0x4E9A170", VA = "0x184E9AD70", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x4E9AB80", Offset = "0x4E99F80", VA = "0x184E9AB80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public RigidbodyConstraints DOLBOFHHNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x4E9AC80", Offset = "0x4E9A080", VA = "0x184E9AC80", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x4E9A970", Offset = "0x4E99D70", VA = "0x184E9A970", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x4E9AF50", Offset = "0x4E9A350", VA = "0x184E9AF50")]
	public AAAPKMLLJPI(LDFFFADLJJJ EIOOACKMMIN, in CEGPKCKJNIC HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x4E9A640", Offset = "0x4E99A40", VA = "0x184E9A640", Slot = "9")]
	public void GPBCEHCAEIE(Rigidbody EMOKGIOEOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x4E9A760", Offset = "0x4E99B60", VA = "0x184E9A760", Slot = "10")]
	public void JJLFJOIGLGI(Rigidbody EMOKGIOEOMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class HGIGFIAMMCI : PJADMJOPMOP, EJJCAPKOAPE
{
	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public float IHABGKBJPJE
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x4EAE6D0", Offset = "0x4EADAD0", VA = "0x184EAE6D0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x4EAE500", Offset = "0x4EAD900", VA = "0x184EAE500", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public float OJJNNNPAIOB
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x4EAEC40", Offset = "0x4EAE040", VA = "0x184EAEC40", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x4EAE9A0", Offset = "0x4EADDA0", VA = "0x184EAE9A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6EE0", Offset = "0x4EA62E0", VA = "0x184EA6EE0")]
	public HGIGFIAMMCI(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE7C0", Offset = "0x4EADBC0", VA = "0x184EAE7C0", Slot = "8")]
	public void GPBCEHCAEIE(Rigidbody EMOKGIOEOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x4EAEB70", Offset = "0x4EADF70", VA = "0x184EAEB70", Slot = "9")]
	public void JJLFJOIGLGI(Rigidbody EMOKGIOEOMC)
	{
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[AFAPMPFKDID(JCDEPCAPNFC.Physics)]
	[BGGFAGPLFND(typeof(OCMKMDCPLBN), new string[] { })]
	public sealed class RbexServiceCallbacks : OIOAOEDFDMG, OCMKMDCPLBN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly EHNHFGEGKKP PDHCNHGCAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private DLFLMEPDEKJ EIOOACKMMIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool HFPLCOEDAAK;

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public bool EMADIPGMFIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x6878D0", Offset = "0x686CD0", VA = "0x1806878D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2640", Offset = "0x5FC1A40", VA = "0x185FC2640", Slot = "4")]
		public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2610", Offset = "0x5FC1A10", VA = "0x185FC2610", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2360", Offset = "0x5FC1760", VA = "0x185FC2360", Slot = "6")]
		public void BFICJFEPKPK(HOGBEFGIKOI DCJOMJHHEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
		public RbexServiceCallbacks()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class AHICLGGDBKP : PJADMJOPMOP, ILGKLKEDKPI
{
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public const int HIPBDNINMIE = 10;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public const float KFIPGKPHLPC = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const float GDGOILMPCNP = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public const float MHNMKPEDGHJ = 5f;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private Rigidbody HHEABFBCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x4E9F5A0", Offset = "0x4E9E9A0", VA = "0x184E9F5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private bool OMOHDGMFPMF
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x4E9F5F0", Offset = "0x4E9E9F0", VA = "0x184E9F5F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool KOJKALGLCJD
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x4E9B820", Offset = "0x4E9AC20", VA = "0x184E9B820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private LDFFFADLJJJ MPHEKDGOELO
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E6D0", Offset = "0x4E9DAD0", VA = "0x184E9E6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private bool FIIKANAHFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x4E9F540", Offset = "0x4E9E940", VA = "0x184E9F540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private bool JLGOGEPBEIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x4E9EF80", Offset = "0x4E9E380", VA = "0x184E9EF80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x4E9EAA0", Offset = "0x4E9DEA0", VA = "0x184E9EAA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool GPIJIINEGFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x4E9F070", Offset = "0x4E9E470", VA = "0x184E9F070")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x4E9ECA0", Offset = "0x4E9E0A0", VA = "0x184E9ECA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private int BJEDFKILCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x4E9EE90", Offset = "0x4E9E290", VA = "0x184E9EE90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x4E9EBA0", Offset = "0x4E9DFA0", VA = "0x184E9EBA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event OBKDBINKHFD DPJIEBMHGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E940", Offset = "0x4E9DD40", VA = "0x184E9E940", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E630", Offset = "0x4E9DA30", VA = "0x184E9E630", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x4E9F690", Offset = "0x4E9EA90", VA = "0x184E9F690")]
	public AHICLGGDBKP(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E9E0", Offset = "0x4E9DDE0", VA = "0x184E9E9E0", Slot = "6")]
	public void FHCJDMLKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EA90", Offset = "0x4E9DE90", VA = "0x184E9EA90", Slot = "8")]
	public void FOADLPPLLJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x4E9F160", Offset = "0x4E9E560", VA = "0x184E9F160", Slot = "7")]
	public bool MDDEJDBMFIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EDE0", Offset = "0x4E9E1E0", VA = "0x184E9EDE0", Slot = "9")]
	public void LBEKAGHMMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x4E9EDA0", Offset = "0x4E9E1A0", VA = "0x184E9EDA0", Slot = "12")]
	public void JHNLKPNKEBM(bool LJBNFKDALHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E890", Offset = "0x4E9DC90", VA = "0x184E9E890", Slot = "11")]
	public void DAPMLKLECBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "10")]
	public void PLJBAMJCMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x4E9F390", Offset = "0x4E9E790", VA = "0x184E9F390")]
	private bool MDJCLFFAFKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x4E9E730", Offset = "0x4E9DB30", VA = "0x184E9E730")]
	private void BFIPGLBLGCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class IOMHCBFIFOG : PJADMJOPMOP, KEMMHKDIIBP
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private const string GHAKMJNPJAH = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Rigidbody HHEABFBCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x4EB0EB0", Offset = "0x4EB02B0", VA = "0x184EB0EB0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x4EB0C50", Offset = "0x4EB0050", VA = "0x184EB0C50")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	private bool FIIKANAHFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x4EB0E50", Offset = "0x4EB0250", VA = "0x184EB0E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x4EB10A0", Offset = "0x4EB04A0", VA = "0x184EB10A0")]
	public IOMHCBFIFOG(LDFFFADLJJJ EIOOACKMMIN, in CEGPKCKJNIC HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0720", Offset = "0x4EAFB20", VA = "0x184EB0720", Slot = "5")]
	public void FHCJDMLKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0D50", Offset = "0x4EB0150", VA = "0x184EB0D50", Slot = "6")]
	public void NHPIIIMMNPK(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0FA0", Offset = "0x4EB03A0", VA = "0x184EB0FA0", Slot = "7")]
	public void PENEMIKMOLK(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0990", Offset = "0x4EAFD90", VA = "0x184EB0990", Slot = "8")]
	public void KHKJOHJIJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0300", Offset = "0x4EAF700", VA = "0x184EB0300", Slot = "9")]
	public void BNABEKGONBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0130", Offset = "0x4EAF530", VA = "0x184EB0130", Slot = "10")]
	public void BJEJPEJGCEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "11")]
	public void LBLHJOEBAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x4EB07D0", Offset = "0x4EAFBD0", VA = "0x184EB07D0")]
	private void HKBACMAFJDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0560", Offset = "0x4EAF960", VA = "0x184EB0560")]
	private void EBFJKCPDBLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class PHBDLNGGIEP : PJADMJOPMOP, IIBIBAOAIIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public GDJBDCHFLPM IKKDOCCFOPH
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x4EC25C0", Offset = "0x4EC19C0", VA = "0x184EC25C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x4EC3230", Offset = "0x4EC2630", VA = "0x184EC3230", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public MDBCJGELOMO EMIMILKLLLH
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x4EC1B60", Offset = "0x4EC0F60", VA = "0x184EC1B60", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x4EC0D90", Offset = "0x4EC0190", VA = "0x184EC0D90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public Vector3 MFJJIFMGMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x4EC2100", Offset = "0x4EC1500", VA = "0x184EC2100", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x4EC0570", Offset = "0x4EBF970", VA = "0x184EC0570", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 FOIPNDJDCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x4EC2E80", Offset = "0x4EC2280", VA = "0x184EC2E80", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x4EC3200", Offset = "0x4EC2600", VA = "0x184EC3200", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 KMHIECBCLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x4EC36E0", Offset = "0x4EC2AE0", VA = "0x184EC36E0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x4EC3BC0", Offset = "0x4EC2FC0", VA = "0x184EC3BC0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Vector3 CMDADPOFJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x4EC0F90", Offset = "0x4EC0390", VA = "0x184EC0F90", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x4EC0C60", Offset = "0x4EC0060", VA = "0x184EC0C60", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public float FIHINFGIBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x4EC0480", Offset = "0x4EBF880", VA = "0x184EC0480", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x4EC3C80", Offset = "0x4EC3080", VA = "0x184EC3C80", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public bool NGJJKMHFKCD
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x4EC2490", Offset = "0x4EC1890", VA = "0x184EC2490", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private ILOOGBEPGEC EKOOBBKDOMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x1B2AE50", Offset = "0x1B2A250", VA = "0x181B2AE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private bool KOJKALGLCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x4E9B820", Offset = "0x4E9AC20", VA = "0x184E9B820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6EE0", Offset = "0x4EA62E0", VA = "0x184EA6EE0")]
	public PHBDLNGGIEP(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x4EC0C90", Offset = "0x4EC0090", VA = "0x184EC0C90", Slot = "20")]
	public void APNABGJPFJD(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x4EC0E90", Offset = "0x4EC0290", VA = "0x184EC0E90", Slot = "31")]
	public void BIDLBKJIOAI(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x4EC1AF0", Offset = "0x4EC0EF0", VA = "0x184EC1AF0", Slot = "19")]
	public void FHCJDMLKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x4EC18C0", Offset = "0x4EC0CC0", VA = "0x184EC18C0", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x4EC2580", Offset = "0x4EC1980", VA = "0x184EC2580", Slot = "28")]
	public void GPBCEHCAEIE(Rigidbody EMOKGIOEOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x4EC33F0", Offset = "0x4EC27F0", VA = "0x184EC33F0", Slot = "36")]
	public Vector3 LLLJCOENOCC(Vector3 KINMMEKNHJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x4EC3830", Offset = "0x4EC2C30", VA = "0x184EC3830", Slot = "35")]
	public Vector3 OGIHLPOGFOM(Vector3 NMEPDMHFFKO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x4EC1AF0", Offset = "0x4EC0EF0", VA = "0x184EC1AF0", Slot = "27")]
	public void MMAEAMLHNPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x4EC10B0", Offset = "0x4EC04B0", VA = "0x184EC10B0", Slot = "25")]
	public void CMPJEOBIHGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x4EC31C0", Offset = "0x4EC25C0", VA = "0x184EC31C0", Slot = "24")]
	public void KLEFLIGGHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x4EC2250", Offset = "0x4EC1650", VA = "0x184EC2250", Slot = "34")]
	public void GINACPDMAJK(Vector3 DDMIKGEOOPO, Vector3 HAFOPEOGPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x4EC0790", Offset = "0x4EBFB90", VA = "0x184EC0790", Slot = "33")]
	public void AJPIKIEJJON(Vector3 JKKOHPMJAOG, Vector3 OPEKPFLGIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x4EC2D20", Offset = "0x4EC2120", VA = "0x184EC2D20", Slot = "32")]
	public void ICGIKNDEMKP(Vector3 DCLIGMBGEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x4EC07F0", Offset = "0x4EBFBF0", VA = "0x184EC07F0", Slot = "22")]
	public void ALPEEHFPDIC(IJDCLCAKEAN LEIHBICAMKK, Vector3 KAFKHBLOAFI, float MDPIMMDABFN, float ONCCEMEBFFA = 8f, float CMDCCPIAHFP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x4EC2F90", Offset = "0x4EC2390", VA = "0x184EC2F90", Slot = "21")]
	public void KIDNLLJJIDN(IAABFEHMLCH KLINALAALOC, Vector3 OIEKPCBPIOL, float PBEJEHPPJEK = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x4EC2A50", Offset = "0x4EC1E50", VA = "0x184EC2A50", Slot = "23")]
	[Obsolete]
	public void HNDILLGBLAC(IAABFEHMLCH KLINALAALOC, Vector3 BOMBFPIEJKJ, float FOKMAHAMPKL = 7f, float IPMBDAIGFIH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x4EC10F0", Offset = "0x4EC04F0", VA = "0x184EC10F0", Slot = "30")]
	public Vector3 DHEAGNCIMFN(Vector3 CNBICOEGBNM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x4EC1A00", Offset = "0x4EC0E00", VA = "0x184EC1A00", Slot = "29")]
	public Vector3 EPOCOFMAFLK(Vector3 FEBDBINBLMJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x4EC1C90", Offset = "0x4EC1090", VA = "0x184EC1C90", Slot = "26")]
	public void FIAEKINLCJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x4EC39F0", Offset = "0x4EC2DF0", VA = "0x184EC39F0")]
	private void OOLKGMCIGOA(float PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x4EC0630", Offset = "0x4EBFA30", VA = "0x184EC0630")]
	private void AJONMFOFDAF(Vector3 OIEKPCBPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x4EC17B0", Offset = "0x4EC0BB0", VA = "0x184EC17B0")]
	private Vector3 DMJNDFOFBAN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x4EC1DC0", Offset = "0x4EC11C0", VA = "0x184EC1DC0")]
	private void FIMHMGPMDIJ(Vector3 NMEPDMHFFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x4EC35D0", Offset = "0x4EC29D0", VA = "0x184EC35D0")]
	private Vector3 LMKHJOLEIIA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x4EC26F0", Offset = "0x4EC1AF0", VA = "0x184EC26F0")]
	private void HIAGBGIMKIM(Vector3 PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x4EC11B0", Offset = "0x4EC05B0", VA = "0x184EC11B0")]
	private void DKMLHGPNHLM(Vector3 NMEPDMHFFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x4EC3330", Offset = "0x4EC2730", VA = "0x184EC3330")]
	private void KOJDHKPBDAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class PJADMJOPMOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected readonly GLAGHEJKLEN EIOOACKMMIN;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	protected DLFLMEPDEKJ HAJHCOEKMDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xC5AD70", Offset = "0xC5A170", VA = "0x180C5AD70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected HOGBEFGIKOI EPIGHCONBEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x5FC16A0", Offset = "0x5FC0AA0", VA = "0x185FC16A0")]
		get
		{
			return default(HOGBEFGIKOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5FC16D0", Offset = "0x5FC0AD0", VA = "0x185FC16D0")]
	public PJADMJOPMOP(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1580", Offset = "0x5FC0980", VA = "0x185FC1580")]
	protected LDFFFADLJJJ ACGMLMGJGBC(HOGBEFGIKOI ODKPHBBMMPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class LJCLDPLDDJL : HNPLEDGEHJM
{
	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x4EB5180", Offset = "0x4EB4580", VA = "0x184EB5180", Slot = "4")]
	public NKPNDPJNKPK PEBBGGAKMOG(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4AC0", Offset = "0x4EB3EC0", VA = "0x184EB4AC0", Slot = "5")]
	public IIBIBAOAIIL AJGKEIPFFII(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4E80", Offset = "0x4EB4280", VA = "0x184EB4E80", Slot = "6")]
	public IOJIKJOEGAG IDJMKIABLPM(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x4EB5070", Offset = "0x4EB4470", VA = "0x184EB5070", Slot = "7")]
	public EJJCAPKOAPE LEHJOCKCOMM(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4EE0", Offset = "0x4EB42E0", VA = "0x184EB4EE0", Slot = "8")]
	public ILGKLKEDKPI IJODDIPBKAA(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4E20", Offset = "0x4EB4220", VA = "0x184EB4E20", Slot = "9")]
	public JDPDNLNKMOL GMADCNBNHFC(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4D50", Offset = "0x4EB4150", VA = "0x184EB4D50", Slot = "10")]
	public KJJJDFEAIEN FCDBMBJKIDM(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4A60", Offset = "0x4EB3E60", VA = "0x184EB4A60", Slot = "11")]
	public ILOOGBEPGEC AEFONNIOMCI(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4F40", Offset = "0x4EB4340", VA = "0x184EB4F40", Slot = "12")]
	public NMCGJCCOOHJ KGGFHEGMFLF(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x4EB5010", Offset = "0x4EB4410", VA = "0x184EB5010", Slot = "13")]
	public NPGCEJMKCHP LEDPNGNHKGL(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4DB0", Offset = "0x4EB41B0", VA = "0x184EB4DB0")]
	public KEMMHKDIIBP FMFPPDHFDNJ(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4CD0", Offset = "0x4EB40D0", VA = "0x184EB4CD0")]
	public AMBACEAOLLK POFPJNFIOBP(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4B20", Offset = "0x4EB3F20", VA = "0x184EB4B20")]
	public HMOBGIIKKNK BLPKEJNBFIL(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4C60", Offset = "0x4EB4060", VA = "0x184EB4C60")]
	public COBPCPMCJAM PDAPNHPDCCC(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4FA0", Offset = "0x4EB43A0", VA = "0x184EB4FA0")]
	public GJOEJMLHHMK NLCFPEEEPEN(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x4EB50D0", Offset = "0x4EB44D0", VA = "0x184EB50D0", Slot = "19")]
	public LDFFFADLJJJ OPJEPJEFDJG(RigidbodyEx EIOOACKMMIN, CEGPKCKJNIC HANEMGLFJMM, LMAIHHGHGOJ INFFNKABNHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public LJCLDPLDDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4DB0", Offset = "0x4EB41B0", VA = "0x184EB4DB0", Slot = "14")]
	private KEMMHKDIIBP JOCMFEIEEKK(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4CD0", Offset = "0x4EB40D0", VA = "0x184EB4CD0", Slot = "15")]
	private AMBACEAOLLK DICHMAJNDLI(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4B20", Offset = "0x4EB3F20", VA = "0x184EB4B20", Slot = "16")]
	private HMOBGIIKKNK MIOGDIGFGLK(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4C60", Offset = "0x4EB4060", VA = "0x184EB4C60", Slot = "17")]
	private COBPCPMCJAM CNOJNFJDLPL(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x4EB4FA0", Offset = "0x4EB43A0", VA = "0x184EB4FA0", Slot = "18")]
	private GJOEJMLHHMK KPHPKFNKHNM(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class DEEHOKOEPIE : IReadOnlyList<LDFFFADLJJJ>, IEnumerable<LDFFFADLJJJ>, IEnumerable, IReadOnlyCollection<LDFFFADLJJJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly HOGBEFGIKOI ODKPHBBMMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly DLFLMEPDEKJ BHMPCEPJFGF;

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public int MHDOGPFGFFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x4EAC0B0", Offset = "0x4EAB4B0", VA = "0x184EAC0B0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public LDFFFADLJJJ BJGDNLMGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x4EAC180", Offset = "0x4EAB580", VA = "0x184EAC180", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x4EAC060", Offset = "0x4EAB460", VA = "0x184EAC060")]
	public DEEHOKOEPIE(HOGBEFGIKOI ODKPHBBMMPO, DLFLMEPDEKJ BHMPCEPJFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x4EABEC0", Offset = "0x4EAB2C0", VA = "0x184EABEC0", Slot = "6")]
	public IEnumerator<LDFFFADLJJJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x4EABEC0", Offset = "0x4EAB2C0", VA = "0x184EABEC0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x4EAC050", Offset = "0x4EAB450", VA = "0x184EAC050")]
	[CompilerGenerated]
	private LDFFFADLJJJ MGOACAMCFKE(int BBOINFMIBOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[BGGFAGPLFND(typeof(HNPLEDGEHJM), new string[] { })]
public class OIGHPGPMHJO : HNPLEDGEHJM, OIOAOEDFDMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly HNPLEDGEHJM HPAMHKKLAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly HNPLEDGEHJM HNBJGDKCNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private HIMFGGFNFGH GBKLMNGDJMG;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	private HNPLEDGEHJM PFLFOBPDCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x4EBB2D0", Offset = "0x4EBA6D0", VA = "0x184EBB2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB6B0", Offset = "0x4EBAAB0", VA = "0x184EBB6B0", Slot = "20")]
	public void PCFHGGJGIHL(EJMKHPELEHA KMGLINHGLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB700", Offset = "0x4EBAB00", VA = "0x184EBB700", Slot = "4")]
	public NKPNDPJNKPK PEBBGGAKMOG(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x4EBACF0", Offset = "0x4EBA0F0", VA = "0x184EBACF0", Slot = "5")]
	public IIBIBAOAIIL AJGKEIPFFII(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB190", Offset = "0x4EBA590", VA = "0x184EBB190", Slot = "6")]
	public IOJIKJOEGAG IDJMKIABLPM(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB520", Offset = "0x4EBA920", VA = "0x184EBB520", Slot = "7")]
	public EJJCAPKOAPE LEHJOCKCOMM(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB230", Offset = "0x4EBA630", VA = "0x184EBB230", Slot = "8")]
	public ILGKLKEDKPI IJODDIPBKAA(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB0F0", Offset = "0x4EBA4F0", VA = "0x184EBB0F0", Slot = "9")]
	public JDPDNLNKMOL GMADCNBNHFC(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAFA0", Offset = "0x4EBA3A0", VA = "0x184EBAFA0", Slot = "10")]
	public KJJJDFEAIEN FCDBMBJKIDM(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAC50", Offset = "0x4EBA050", VA = "0x184EBAC50", Slot = "11")]
	public ILOOGBEPGEC AEFONNIOMCI(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB330", Offset = "0x4EBA730", VA = "0x184EBB330", Slot = "12")]
	public NMCGJCCOOHJ KGGFHEGMFLF(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB480", Offset = "0x4EBA880", VA = "0x184EBB480", Slot = "13")]
	public NPGCEJMKCHP LEDPNGNHKGL(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB040", Offset = "0x4EBA440", VA = "0x184EBB040")]
	public KEMMHKDIIBP FMFPPDHFDNJ(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAEF0", Offset = "0x4EBA2F0", VA = "0x184EBAEF0")]
	public AMBACEAOLLK POFPJNFIOBP(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAD90", Offset = "0x4EBA190", VA = "0x184EBAD90")]
	public HMOBGIIKKNK BLPKEJNBFIL(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAE40", Offset = "0x4EBA240", VA = "0x184EBAE40")]
	public COBPCPMCJAM PDAPNHPDCCC(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB3D0", Offset = "0x4EBA7D0", VA = "0x184EBB3D0")]
	public GJOEJMLHHMK NLCFPEEEPEN(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB5C0", Offset = "0x4EBA9C0", VA = "0x184EBB5C0", Slot = "19")]
	public LDFFFADLJJJ OPJEPJEFDJG(RigidbodyEx EIOOACKMMIN, CEGPKCKJNIC HANEMGLFJMM, LMAIHHGHGOJ INFFNKABNHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB7A0", Offset = "0x4EBABA0", VA = "0x184EBB7A0")]
	public OIGHPGPMHJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB040", Offset = "0x4EBA440", VA = "0x184EBB040", Slot = "14")]
	private KEMMHKDIIBP JOCMFEIEEKK(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAEF0", Offset = "0x4EBA2F0", VA = "0x184EBAEF0", Slot = "15")]
	private AMBACEAOLLK DICHMAJNDLI(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAD90", Offset = "0x4EBA190", VA = "0x184EBAD90", Slot = "16")]
	private HMOBGIIKKNK MIOGDIGFGLK(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAE40", Offset = "0x4EBA240", VA = "0x184EBAE40", Slot = "17")]
	private COBPCPMCJAM CNOJNFJDLPL(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB3D0", Offset = "0x4EBA7D0", VA = "0x184EBB3D0", Slot = "18")]
	private GJOEJMLHHMK KPHPKFNKHNM(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Preserve]
public sealed class GCKEPMHBAIN : LDFFFADLJJJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly GCKEPMHBAIN PNBICMAKACI;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public Rigidbody HHEABFBCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x66EAC0", Offset = "0x66DEC0", VA = "0x18066EAC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public RigidbodyEx DNNFDLPJDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public GameObject PNKCHCINMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public Transform CNKOEBEMMDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x6878E0", Offset = "0x686CE0", VA = "0x1806878E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public IEnumerable<object> JIJNFAHPCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x6836F0", Offset = "0x682AF0", VA = "0x1806836F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public LDFFFADLJJJ MPHEKDGOELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x674570", Offset = "0x673970", VA = "0x180674570", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x674590", Offset = "0x673990", VA = "0x180674590", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public IReadOnlyList<LDFFFADLJJJ> MMKJCMJHBBC
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x674580", Offset = "0x673980", VA = "0x180674580", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public LDFFFADLJJJ HNOOCOABLIK
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x66D0D0", Offset = "0x66C4D0", VA = "0x18066D0D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public bool FIIKANAHFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x9EDB40", Offset = "0x9ECF40", VA = "0x1809EDB40", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool AOGGMNBIPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xA2EC90", Offset = "0xA2E090", VA = "0x180A2EC90", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool GLNBGDPGNIE
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xC28580", Offset = "0xC27980", VA = "0x180C28580", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public GDJBDCHFLPM IKKDOCCFOPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x66D0B0", Offset = "0x66C4B0", VA = "0x18066D0B0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x765300", Offset = "0x764700", VA = "0x180765300", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public MDBCJGELOMO EMIMILKLLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x683770", Offset = "0x682B70", VA = "0x180683770", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x70EAB0", Offset = "0x70DEB0", VA = "0x18070EAB0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public float FIHINFGIBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x15E7EB0", Offset = "0x15E72B0", VA = "0x1815E7EB0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xEC14B0", Offset = "0xEC08B0", VA = "0x180EC14B0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 FOIPNDJDCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x2D8AD70", Offset = "0x2D8A170", VA = "0x182D8AD70", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x2D89340", Offset = "0x2D88740", VA = "0x182D89340", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 CMDADPOFJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x1A4DB20", Offset = "0x1A4CF20", VA = "0x181A4DB20", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x1A4AA00", Offset = "0x1A49E00", VA = "0x181A4AA00", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 MFJJIFMGMLG
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x1A4DB40", Offset = "0x1A4CF40", VA = "0x181A4DB40", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x1A4BF80", Offset = "0x1A4B380", VA = "0x181A4BF80", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 KMHIECBCLMO
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x19F2490", Offset = "0x19F1890", VA = "0x1819F2490", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public bool EDJFMEGPJEM
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xC5E9A0", Offset = "0xC5DDA0", VA = "0x180C5E9A0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool MGKKHOINCEI
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xCC2D90", Offset = "0xCC2190", VA = "0x180CC2D90", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool OHGAHICGHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xCC2D80", Offset = "0xCC2180", VA = "0x180CC2D80", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool NGJJKMHFKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0xAEC050", Offset = "0xAEB450", VA = "0x180AEC050", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public Vector3 GCPCJKOFFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x106B900", Offset = "0x106AD00", VA = "0x18106B900", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Vector3 FHKMIHLBOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x18C32A0", Offset = "0x18C26A0", VA = "0x1818C32A0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 GMGFNLABCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x19F2490", Offset = "0x19F1890", VA = "0x1819F2490", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 GPHDDLFKNHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x1A4DC00", Offset = "0x1A4D000", VA = "0x181A4DC00", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public float LDPEDKDIMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x22AF7E0", Offset = "0x22AEBE0", VA = "0x1822AF7E0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public float MPAIGPICGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xFA7940", Offset = "0xFA6D40", VA = "0x180FA7940", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public Vector3 FJFFKOHHCLG
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x19F2490", Offset = "0x19F1890", VA = "0x1819F2490", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Quaternion KJGEANOCBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x15A2ED0", Offset = "0x15A22D0", VA = "0x1815A2ED0", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public float IHABGKBJPJE
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xFA7940", Offset = "0xFA6D40", VA = "0x180FA7940", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public float OJJNNNPAIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0xFA7940", Offset = "0xFA6D40", VA = "0x180FA7940", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool JDJININOJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool LDMAAOPEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public CKFADKHCOCO CNANIPFOIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00", Slot = "52")]
		get
		{
			return default(CKFADKHCOCO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool JJCEADPPMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x18B0C80", Offset = "0x18B0080", VA = "0x1818B0C80", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public Transform LGMPJDMJFAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x79DC00", Offset = "0x79D000", VA = "0x18079DC00", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Transform PAAMJCKPJFN
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x7257A0", Offset = "0x724BA0", VA = "0x1807257A0", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Vector3 BAJFFFJJAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x19F2490", Offset = "0x19F1890", VA = "0x1819F2490", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public float AJFBKKCMDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xFA7940", Offset = "0xFA6D40", VA = "0x180FA7940", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float GCPIGMMGPEB
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xFA7940", Offset = "0xFA6D40", VA = "0x180FA7940", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public Quaternion DOJFCBEJNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x16A8EC0", Offset = "0x16A82C0", VA = "0x1816A8EC0", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Vector3 PCBACGKMIOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x19F2490", Offset = "0x19F1890", VA = "0x1819F2490", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Quaternion NJDEEIELFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x16A8EC0", Offset = "0x16A82C0", VA = "0x1816A8EC0", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public RigidbodyConstraints DOLBOFHHNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x674170", Offset = "0x673570", VA = "0x180674170", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public bool PNKNIIFGHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public CollisionDetectionMode MFPLMICGDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x674170", Offset = "0x673570", VA = "0x180674170", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public bool KOJKALGLCJD
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x12724D0", Offset = "0x12718D0", VA = "0x1812724D0", Slot = "75")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event OBKDBINKHFD OFAAEPPCPMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event OBKDBINKHFD HCCGNILBJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event LBNCGHJEAIO LKJPOLHAOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event OBKDBINKHFD FOONNAAAKEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event OBKDBINKHFD OLHJFHBKGMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event OBKDBINKHFD DPJIEBMHGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<AOJPHEJCEIM, AOJPHEJCEIM> HONLBKEHBHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event OBKDBINKHFD DODKPAEOBBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event OBKDBINKHFD BIEKLOKNMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "125")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "126")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "76")]
	public void FHCJDMLKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "77")]
	public void PJABKKDODIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "78")]
	public void DDCMKFIJMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "79")]
	public void LBEKAGHMMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "80")]
	public void NEOGNAGJGHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "87")]
	public void FFPPMEKEJBA(LDFFFADLJJJ PKODKJLGOIN, bool FNAFEHLKFEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "90")]
	public void PPKOIAMPNOC(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "91")]
	public void KPEPGENHJJP(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x19F2490", Offset = "0x19F1890", VA = "0x1819F2490", Slot = "92")]
	public Vector3 LLLJCOENOCC(Vector3 KINMMEKNHJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x19F2490", Offset = "0x19F1890", VA = "0x1819F2490", Slot = "93")]
	public Vector3 OGIHLPOGFOM(Vector3 NMEPDMHFFKO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "94")]
	public void MMAEAMLHNPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "95")]
	public void CMPJEOBIHGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "96")]
	public void KLEFLIGGHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "97")]
	public void GINACPDMAJK(Vector3 DDMIKGEOOPO, Vector3 HAFOPEOGPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "98")]
	public void AJPIKIEJJON(Vector3 JKKOHPMJAOG, Vector3 OPEKPFLGIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "99")]
	public void ICGIKNDEMKP(Vector3 DCLIGMBGEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "100")]
	public void ALPEEHFPDIC(IJDCLCAKEAN LEIHBICAMKK, Vector3 KAFKHBLOAFI, float MDPIMMDABFN, float ONCCEMEBFFA = 8f, float CMDCCPIAHFP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "101")]
	public void KIDNLLJJIDN(IAABFEHMLCH KLINALAALOC, Vector3 OIEKPCBPIOL, float PBEJEHPPJEK = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "102")]
	public void HNDILLGBLAC(IAABFEHMLCH KLINALAALOC, Vector3 BOMBFPIEJKJ, float FOKMAHAMPKL = 7f, float IPMBDAIGFIH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x19F2490", Offset = "0x19F1890", VA = "0x1819F2490", Slot = "103")]
	public Vector3 DHEAGNCIMFN(Vector3 PKODKJLGOIN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x19F2490", Offset = "0x19F1890", VA = "0x1819F2490", Slot = "104")]
	public Vector3 EPOCOFMAFLK(Vector3 PKODKJLGOIN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "105")]
	public void FIAEKINLCJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "106")]
	public void NAKDOJMHHBK(LDFFFADLJJJ LGNMDJNNIHP, object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "107")]
	public void ALAFJOHOAFK(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "110")]
	public void JPJFJEOEPBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "111")]
	public void KPFCNOPBPFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "112")]
	public void EGDEGICGGIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00", Slot = "115")]
	public bool MDDEJDBMFIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "116")]
	public void DAPMLKLECBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x674170", Offset = "0x673570", VA = "0x180674170", Slot = "121")]
	public IDisposable HHMHIEDHOHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "122")]
	public void BIFPDPDDGDL(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "123")]
	public void NANINNNICOB(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "124")]
	public void BAEFPBDLCOE(object PFJMMABJIDH, bool MDOKFMLNLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "127")]
	public void FILFMDDFAOD(Vector3 EFFLEILEAOJ, Quaternion EOJPJJFENEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "128")]
	public void LJNGCDFDFEB(Vector3 AGLOIALKBAN, Quaternion AOPMNOAKDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x670D00", Offset = "0x670100", VA = "0x180670D00", Slot = "129")]
	public bool NGCEOJEOCMH(float KALFLGFFPIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "130")]
	public void FOMAJCJPCCE(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "131")]
	public void CMGDFHNIMEA(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "132")]
	public void NHPIIIMMNPK(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "133")]
	public void PENEMIKMOLK(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "134")]
	public void KJJLKBEFOJB(Vector3 LGPEEBCPBMM, ForceMode BIAGFHEEGCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "135")]
	public void MPMOKOLACFD(Vector3 LGPEEBCPBMM, Vector3 IAMBOGDEHMB, ForceMode BIAGFHEEGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "136")]
	public void DEPAIDKHKDC(Vector3 NNOLOLENPFH, ForceMode BIAGFHEEGCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "137")]
	public void BPIEDDANJJE(Vector3 NNOLOLENPFH, ForceMode BIAGFHEEGCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x4EADBE0", Offset = "0x4EACFE0", VA = "0x184EADBE0", Slot = "138")]
	public bool JGKJKBBGHKF(Vector3 IJOKHPEAHHL, out RaycastHit HJNBLBFBKNA, float PAKNAMCBNFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "139")]
	public void NDEFFPLIHBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public GCKEPMHBAIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class GLAGHEJKLEN : AKDPLPNNHCO, KFMMEAOIBIL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	internal HOGBEFGIKOI ODKPHBBMMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	internal DLFLMEPDEKJ EGJKMNCLENP;

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE490", Offset = "0x4EAD890", VA = "0x184EAE490")]
	public GLAGHEJKLEN(GameObject MGDBDEJKIMA, RigidbodyEx EGIGOCGBEBO, LMAIHHGHGOJ INFFNKABNHB, in CEGPKCKJNIC HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x4EADC60", Offset = "0x4EAD060", VA = "0x184EADC60", Slot = "142")]
	protected override void CNIFGOMKBGM(LMAIHHGHGOJ INFFNKABNHB, CEGPKCKJNIC HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x4EADEF0", Offset = "0x4EAD2F0", VA = "0x184EADEF0", Slot = "143")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE140", Offset = "0x4EAD540", VA = "0x184EAE140", Slot = "145")]
	public void ILIPNLHHAFK(KACHEPBJCJB ICBMMLPPJIN, KACHEPBJCJB LPLBPOMCKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE3D0", Offset = "0x4EAD7D0", VA = "0x184EAE3D0", Slot = "146")]
	public void MKAHJOONMIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE080", Offset = "0x4EAD480", VA = "0x184EAE080", Slot = "147")]
	public void IDBOKNCOPNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE210", Offset = "0x4EAD610", VA = "0x184EAE210", Slot = "148")]
	public void JHNLKPNKEBM(bool LJBNFKDALHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x4EAE270", Offset = "0x4EAD670", VA = "0x184EAE270", Slot = "149")]
	public bool LFIJKDEFHIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "144")]
	public override void NEOGNAGJGHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class BIKKFBLHOLI
{
	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5F90", Offset = "0x4EA5390", VA = "0x184EA5F90")]
	public static AKDPLPNNHCO KKGCIEKOPBD(this LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface ICPIFBJHGCM : NKPNDPJNKPK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNJLDMDAPLM(LDFFFADLJJJ EIOOACKMMIN);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKMHFJFCFJD(LDFFFADLJJJ EIOOACKMMIN);

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AAGKGKBGDLF(LDFFFADLJJJ DCMIHJECFPJ);

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NOPJMLNJJCN(LDFFFADLJJJ DCMIHJECFPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface DCHMFOEBFDK : IOJIKJOEGAG
{
	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	global::HMOFNPFCBGC<LDFFFADLJJJ> OMIMIGOIPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	LDFFFADLJJJ LIAOLHKKHMK
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface MHDGOPNFAJP : COBPCPMCJAM
{
	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) BFICJFEPKPK(Rigidbody IBNKACBPOLA);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface NDLNMBPCBPI : AMBACEAOLLK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	PhotonView NMOAIPGNGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class BAAJGODLBDK : NMCGJCCOOHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly AKDPLPNNHCO EIOOACKMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private CollisionDetectionMode PCMIAMNBBHC;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private Rigidbody HHEABFBCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x4E9F5A0", Offset = "0x4E9E9A0", VA = "0x184E9F5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public CollisionDetectionMode MFPLMICGDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x4EA5DE0", Offset = "0x4EA51E0", VA = "0x184EA5DE0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x4EA5A50", Offset = "0x4EA4E50", VA = "0x184EA5A50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5F00", Offset = "0x4EA5300", VA = "0x184EA5F00")]
	public BAAJGODLBDK(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5AD0", Offset = "0x4EA4ED0", VA = "0x184EA5AD0", Slot = "6")]
	public void FHCJDMLKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5BF0", Offset = "0x4EA4FF0", VA = "0x184EA5BF0", Slot = "9")]
	public void GPBCEHCAEIE(Rigidbody EMOKGIOEOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5AC0", Offset = "0x4EA4EC0", VA = "0x184EA5AC0", Slot = "7")]
	public void EOHNBBMPKLN(bool EFFLGKBJAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5EF0", Offset = "0x4EA52F0", VA = "0x184EA5EF0", Slot = "8")]
	public void PMLCENAIDKL(bool EFFLGKBJAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5C70", Offset = "0x4EA5070", VA = "0x184EA5C70", Slot = "10")]
	public bool JGKJKBBGHKF(Vector3 IJOKHPEAHHL, out RaycastHit HJNBLBFBKNA, float PAKNAMCBNFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5920", Offset = "0x4EA4D20", VA = "0x184EA5920")]
	private void BCHKKAGPGJJ(bool EFFLGKBJAMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class FCLMGFNNDKH : JDPDNLNKMOL, IDisposable, CNCEJGIFHLA
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public const int MCKALEJMAOE = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly AKDPLPNNHCO EIOOACKMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private CKFADKHCOCO PAHDKPNJMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private DGBFOPLPHNA FHLFPECABFC;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public CKFADKHCOCO CNANIPFOIOF
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD1E0", Offset = "0x4EAC5E0", VA = "0x184EAD1E0", Slot = "6")]
		get
		{
			return default(CKFADKHCOCO);
		}
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD0F0", Offset = "0x4EAC4F0", VA = "0x184EAD0F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	private Transform KCDOGBBMOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD1C0", Offset = "0x4EAC5C0", VA = "0x184EAD1C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<AOJPHEJCEIM, AOJPHEJCEIM> HONLBKEHBHM
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD320", Offset = "0x4EAC720", VA = "0x184EAD320", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x4EAD3C0", Offset = "0x4EAC7C0", VA = "0x184EAD3C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD4C0", Offset = "0x4EAC8C0", VA = "0x184EAD4C0")]
	public FCLMGFNNDKH(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x4EACE10", Offset = "0x4EAC210", VA = "0x184EACE10", Slot = "8")]
	public void FHCJDMLKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x4EACDC0", Offset = "0x4EAC1C0", VA = "0x184EACDC0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD460", Offset = "0x4EAC860", VA = "0x184EAD460", Slot = "11")]
	private void NDCKLHDOIHD(AOJPHEJCEIM CCHOACKDLOO, AOJPHEJCEIM OAKKLPMJENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x686EB0", Offset = "0x6862B0", VA = "0x180686EB0", Slot = "12")]
	private void KHCNPECAOHC(bool PHIOBBHMIJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class LANGAPCFEFI : ILOOGBEPGEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly AKDPLPNNHCO EIOOACKMMIN;

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Rigidbody HHEABFBCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x4E9F5A0", Offset = "0x4E9E9A0", VA = "0x184E9F5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private bool JJCEADPPMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x4EB3720", Offset = "0x4EB2B20", VA = "0x184EB3720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private bool FIIKANAHFCD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x4EB0E50", Offset = "0x4EB0250", VA = "0x184EB0E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private LDFFFADLJJJ MPHEKDGOELO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x4EB3060", Offset = "0x4EB2460", VA = "0x184EB3060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5F00", Offset = "0x4EA5300", VA = "0x184EA5F00")]
	public LANGAPCFEFI(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x4EB39F0", Offset = "0x4EB2DF0", VA = "0x184EB39F0", Slot = "4")]
	public void KJJLKBEFOJB(Vector3 LGPEEBCPBMM, ForceMode BIAGFHEEGCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x4EB3770", Offset = "0x4EB2B70", VA = "0x184EB3770")]
	private void IGLDCBHBJOD(Vector3 LGPEEBCPBMM, ForceMode BIAGFHEEGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x4EB3B50", Offset = "0x4EB2F50", VA = "0x184EB3B50", Slot = "5")]
	public void MPMOKOLACFD(Vector3 LGPEEBCPBMM, Vector3 IAMBOGDEHMB, ForceMode BIAGFHEEGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x4EB35C0", Offset = "0x4EB29C0", VA = "0x184EB35C0", Slot = "6")]
	public void DEPAIDKHKDC(Vector3 NNOLOLENPFH, ForceMode BIAGFHEEGCO = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x4EB3340", Offset = "0x4EB2740", VA = "0x184EB3340")]
	private void CJCCLMCBDEJ(Vector3 NNOLOLENPFH, ForceMode BIAGFHEEGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x4EB30C0", Offset = "0x4EB24C0", VA = "0x184EB30C0", Slot = "7")]
	public void BPIEDDANJJE(Vector3 NNOLOLENPFH, ForceMode BIAGFHEEGCO = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class MAGJKGBHNNC : NPGCEJMKCHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AKDPLPNNHCO EIOOACKMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool MDPEGHGHAMG;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public bool JDJININOJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x6878D0", Offset = "0x686CD0", VA = "0x1806878D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x4EB5B50", Offset = "0x4EB4F50", VA = "0x184EB5B50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5F00", Offset = "0x4EA5300", VA = "0x184EA5F00")]
	public MAGJKGBHNNC(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x4EB5C60", Offset = "0x4EB5060", VA = "0x184EB5C60", Slot = "6")]
	public void GPBCEHCAEIE(Rigidbody EMOKGIOEOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x4EAC720", Offset = "0x4EABB20", VA = "0x184EAC720", Slot = "7")]
	public void JJLFJOIGLGI(Rigidbody EMOKGIOEOMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class CLELKPCCNPJ : ICPIFBJHGCM, NKPNDPJNKPK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly LDFFFADLJJJ EIOOACKMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<LDFFFADLJJJ> CJDMCMNNBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private LDFFFADLJJJ JAFNHFEOMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private LDFFFADLJJJ BLENCGKHIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Transform MBFGFGHANLK;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private Transform CNKOEBEMMDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x4EA83F0", Offset = "0x4EA77F0", VA = "0x184EA83F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public LDFFFADLJJJ MPHEKDGOELO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x683700", Offset = "0x682B00", VA = "0x180683700", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x4EA82A0", Offset = "0x4EA76A0", VA = "0x184EA82A0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public LDFFFADLJJJ HNOOCOABLIK
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x683780", Offset = "0x682B80", VA = "0x180683780", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public IReadOnlyList<LDFFFADLJJJ> MMKJCMJHBBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x683770", Offset = "0x682B70", VA = "0x180683770", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event OBKDBINKHFD OFAAEPPCPMC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x4EA7410", Offset = "0x4EA6810", VA = "0x184EA7410", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x4EA8350", Offset = "0x4EA7750", VA = "0x184EA8350", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event OBKDBINKHFD HCCGNILBJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x4EA72D0", Offset = "0x4EA66D0", VA = "0x184EA72D0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x4EA8B10", Offset = "0x4EA7F10", VA = "0x184EA8B10", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event LBNCGHJEAIO LKJPOLHAOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x4EA8590", Offset = "0x4EA7990", VA = "0x184EA8590", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x4EA7230", Offset = "0x4EA6630", VA = "0x184EA7230", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action MPJHBDPMHPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x4EA7F70", Offset = "0x4EA7370", VA = "0x184EA7F70", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x4EA8450", Offset = "0x4EA7850", VA = "0x184EA8450", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action FFPHKHEKBCL
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x4EA8010", Offset = "0x4EA7410", VA = "0x184EA8010", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x4EA89D0", Offset = "0x4EA7DD0", VA = "0x184EA89D0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<LDFFFADLJJJ> KANHDBMMLND
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x4EA7ED0", Offset = "0x4EA72D0", VA = "0x184EA7ED0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x4EA7370", Offset = "0x4EA6770", VA = "0x184EA7370", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<LDFFFADLJJJ> PCHHDBLJBJH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x4EA74B0", Offset = "0x4EA68B0", VA = "0x184EA74B0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x4EA78B0", Offset = "0x4EA6CB0", VA = "0x184EA78B0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action JEJFOJFCOKH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x4EA8890", Offset = "0x4EA7C90", VA = "0x184EA8890", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x4EA8A70", Offset = "0x4EA7E70", VA = "0x184EA8A70", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<LDFFFADLJJJ> ELDDJKDNPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x4EA80B0", Offset = "0x4EA74B0", VA = "0x184EA80B0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x4EA8930", Offset = "0x4EA7D30", VA = "0x184EA8930", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8BF0", Offset = "0x4EA7FF0", VA = "0x184EA8BF0")]
	public CLELKPCCNPJ(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7700", Offset = "0x4EA6B00", VA = "0x184EA7700", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7950", Offset = "0x4EA6D50", VA = "0x184EA7950", Slot = "30")]
	public void FFPPMEKEJBA(LDFFFADLJJJ GIJFJALMMOL, bool FNAFEHLKFEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6EF0", Offset = "0x4EA62F0", VA = "0x184EA6EF0", Slot = "6")]
	public void AAGKGKBGDLF(LDFFFADLJJJ DCMIHJECFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8630", Offset = "0x4EA7A30", VA = "0x184EA8630", Slot = "7")]
	public void NOPJMLNJJCN(LDFFFADLJJJ DCMIHJECFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x4EA84F0", Offset = "0x4EA78F0", VA = "0x184EA84F0", Slot = "4")]
	public void MNJLDMDAPLM(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x4EA82B0", Offset = "0x4EA76B0", VA = "0x184EA82B0", Slot = "5")]
	public void KKMHFJFCFJD(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7550", Offset = "0x4EA6950", VA = "0x184EA7550")]
	private void DCBBINMGFDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8BB0", Offset = "0x4EA7FB0", VA = "0x184EA8BB0")]
	private void PHCCHDHOMEM(LDFFFADLJJJ DCMIHJECFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x4EA8150", Offset = "0x4EA7550", VA = "0x184EA8150")]
	private void JOKLKDNLDCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7780", Offset = "0x4EA6B80", VA = "0x184EA7780")]
	private void ECDLINPFPBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x4EA75E0", Offset = "0x4EA69E0", VA = "0x184EA75E0")]
	private void DJCKLJBBHJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7140", Offset = "0x4EA6540", VA = "0x184EA7140")]
	[CompilerGenerated]
	private object BCACBAKFOBI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class HNHHHJKHFGG
{
	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x4EAED30", Offset = "0x4EAE130", VA = "0x184EAED30")]
	public static ICPIFBJHGCM OJNIAOBKCAC(this LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class IEBHJOFJHAO : DCHMFOEBFDK, IOJIKJOEGAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly AKDPLPNNHCO EIOOACKMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly global::HMOFNPFCBGC<LDFFFADLJJJ> NJPCFADIKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool LAJFPNGIGKL;

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public global::HMOFNPFCBGC<LDFFFADLJJJ> OMIMIGOIPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x66D0C0", Offset = "0x66C4C0", VA = "0x18066D0C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public Vector3 GCPCJKOFFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x4EAEFC0", Offset = "0x4EAE3C0", VA = "0x184EAEFC0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Vector3 FHKMIHLBOLC
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x4EAEDF0", Offset = "0x4EAE1F0", VA = "0x184EAEDF0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private Vector3 MFJJIFMGMLG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF460", Offset = "0x4EAE860", VA = "0x184EAF460")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public LDFFFADLJJJ LIAOLHKKHMK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF060", Offset = "0x4EAE460", VA = "0x184EAF060", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF940", Offset = "0x4EAED40", VA = "0x184EAF940")]
	public IEBHJOFJHAO(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x4EAEFF0", Offset = "0x4EAE3F0", VA = "0x184EAEFF0", Slot = "8")]
	public void EEKIMDFIJMO(LDFFFADLJJJ BLENCGKHIJI, object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF8E0", Offset = "0x4EAECE0", VA = "0x184EAF8E0", Slot = "9")]
	public void NJCKEKJHDOH(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF110", Offset = "0x4EAE510", VA = "0x184EAF110")]
	private Vector3 FMNNLCLCFID()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF540", Offset = "0x4EAE940", VA = "0x184EAF540")]
	private void IPEGIDHCJMB(LDFFFADLJJJ CAPLPOKFBHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class EHBLDAFMILC
{
	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x4EACAC0", Offset = "0x4EABEC0", VA = "0x184EACAC0")]
	public static DCHMFOEBFDK FNMKOPCBEOP(this LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class OJKDBGDGFIH : MHDGOPNFAJP, COBPCPMCJAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly AKDPLPNNHCO EIOOACKMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly OverridableVector3 KBDCFHKMMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly OverridableVector3 FBHKMNMJJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private float AKJAJNBDHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private float KOECGKDLFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Vector3 GBHLCANBGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Vector3? BHJPEBJDKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Quaternion? KKDPOLFCCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool KBGCBCMAOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private bool KBNAGJIJPMF;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public Vector3 GMGFNLABCLI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x12CB5C0", Offset = "0x12CA9C0", VA = "0x1812CB5C0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x4EBE5F0", Offset = "0x4EBD9F0", VA = "0x184EBE5F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 GPHDDLFKNHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x4EBDA80", Offset = "0x4EBCE80", VA = "0x184EBDA80", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public float LDPEDKDIMEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x1723B40", Offset = "0x1722F40", VA = "0x181723B40", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x4EBD960", Offset = "0x4EBCD60", VA = "0x184EBD960")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float MPAIGPICGBN
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x1048300", Offset = "0x1047700", VA = "0x181048300", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x4EBD940", Offset = "0x4EBCD40", VA = "0x184EBD940", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public Vector3 FJFFKOHHCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x4EBD660", Offset = "0x4EBCA60", VA = "0x184EBD660", Slot = "13")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x4EBDD00", Offset = "0x4EBD100", VA = "0x184EBDD00", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Quaternion KJGEANOCBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x4EBDEA0", Offset = "0x4EBD2A0", VA = "0x184EBDEA0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x4EBE6F0", Offset = "0x4EBDAF0", VA = "0x184EBE6F0", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private Rigidbody HHEABFBCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x4EBA560", Offset = "0x4EB9960", VA = "0x184EBA560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event OBKDBINKHFD MEBFCFJBPPB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x4EBDC60", Offset = "0x4EBD060", VA = "0x184EBDC60", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x4EBD4D0", Offset = "0x4EBC8D0", VA = "0x184EBD4D0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x4EBEEB0", Offset = "0x4EBE2B0", VA = "0x184EBEEB0")]
	public OJKDBGDGFIH(LDFFFADLJJJ EIOOACKMMIN, in CEGPKCKJNIC HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x4EBE430", Offset = "0x4EBD830", VA = "0x184EBE430", Slot = "18")]
	public void JPJFJEOEPBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x4EBE610", Offset = "0x4EBDA10", VA = "0x184EBE610", Slot = "17")]
	public void KPFCNOPBPFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x4EBDB80", Offset = "0x4EBCF80", VA = "0x184EBDB80", Slot = "20")]
	public void GPBCEHCAEIE(Rigidbody EMOKGIOEOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x4EBE010", Offset = "0x4EBD410", VA = "0x184EBE010", Slot = "21")]
	public void JJLFJOIGLGI(Rigidbody EMOKGIOEOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x4EBD7D0", Offset = "0x4EBCBD0", VA = "0x184EBD7D0", Slot = "19")]
	public void EGDEGICGGIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x4EBE9F0", Offset = "0x4EBDDF0", VA = "0x184EBE9F0", Slot = "22")]
	public void NDEFFPLIHBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x4EBE5F0", Offset = "0x4EBD9F0", VA = "0x184EBE5F0")]
	private void LELPCIDOPDP(Vector3 PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x4EBD570", Offset = "0x4EBC970", VA = "0x184EBD570")]
	private Vector3 DONLPDCCKKG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x4EBD960", Offset = "0x4EBCD60", VA = "0x184EBD960")]
	private void MKOFPBFHJHL(float PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x4EBD940", Offset = "0x4EBCD40", VA = "0x184EBD940")]
	private void EMIKIENNOPO(float PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x4EBE2B0", Offset = "0x4EBD6B0", VA = "0x184EBE2B0")]
	private Vector3 JMDCLJNNLIF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x4EBDD00", Offset = "0x4EBD100", VA = "0x184EBDD00")]
	private void IJHGIMKFIHH(Vector3 PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x4EBE890", Offset = "0x4EBDC90", VA = "0x184EBE890")]
	private Quaternion NDBELHNICKH()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x4EBE6F0", Offset = "0x4EBDAF0", VA = "0x184EBE6F0")]
	private void OPIOHEIOBCG(Quaternion PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x4EBD3F0", Offset = "0x4EBC7F0", VA = "0x184EBD3F0")]
	public void BFICJFEPKPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x4EBC530", Offset = "0x4EBB930", VA = "0x184EBC530", Slot = "4")]
	public (float, Vector3) BFICJFEPKPK(Rigidbody IBNKACBPOLA)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class EMMOGDEDAGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x4EACC10", Offset = "0x4EAC010", VA = "0x184EACC10")]
	public static MHDGOPNFAJP GFCKMPJOFGP(this LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class DAKGFJIDLLE : HMOBGIIKKNK
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private const string BONPHMCJLKF = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly AKDPLPNNHCO EIOOACKMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly BMHJPGJHMEO EDKNAGLIGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly OBMNDCKAAPN HMJIHEOLILH;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool NJANEGEJNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x13D2EA0", Offset = "0x13D22A0", VA = "0x1813D2EA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public OBMNDCKAAPN ALNHKIHJPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x66D010", Offset = "0x66C410", VA = "0x18066D010", Slot = "5")]
		get
		{
			return default(OBMNDCKAAPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x4EABDD0", Offset = "0x4EAB1D0", VA = "0x184EABDD0")]
	public DAKGFJIDLLE(LDFFFADLJJJ EIOOACKMMIN, in CEGPKCKJNIC HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x4EABA80", Offset = "0x4EAAE80", VA = "0x184EABA80", Slot = "6")]
	public void FHCJDMLKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x4EABD30", Offset = "0x4EAB130", VA = "0x184EABD30")]
	private bool PJGGEEILMMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x4EABB50", Offset = "0x4EAAF50", VA = "0x184EABB50", Slot = "7")]
	public void JLBEOANOHLG(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x4EAB8D0", Offset = "0x4EAACD0", VA = "0x184EAB8D0", Slot = "8")]
	public void DCJCOAGCMAO(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x4EABB80", Offset = "0x4EAAF80", VA = "0x184EABB80", Slot = "11")]
	public void KGLNIBBHPBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x4EAB7C0", Offset = "0x4EAABC0", VA = "0x184EAB7C0")]
	private void BHJFODIBNHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x4EAB900", Offset = "0x4EAAD00", VA = "0x184EAB900")]
	private void ENDJDBHHMMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x4EABCB0", Offset = "0x4EAB0B0", VA = "0x184EABCB0", Slot = "10")]
	public void KLBGBFKKAAA(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x4EABCF0", Offset = "0x4EAB0F0", VA = "0x184EABCF0", Slot = "9")]
	public void OIMAOBNILAB(LDFFFADLJJJ EIOOACKMMIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class NMPBFLILHBK : KJJJDFEAIEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly AKDPLPNNHCO EIOOACKMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly BMHJPGJHMEO LOMBGFCJFMM;

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public bool JJCEADPPMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x4EB9910", Offset = "0x4EB8D10", VA = "0x184EB9910", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public IEnumerable<object> GIMIFJJJPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x4EB9AE0", Offset = "0x4EB8EE0", VA = "0x184EB9AE0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event OBKDBINKHFD BAOFIHNMMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x4EB9870", Offset = "0x4EB8C70", VA = "0x184EB9870", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x4EB9B10", Offset = "0x4EB8F10", VA = "0x184EB9B10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x4EB9BB0", Offset = "0x4EB8FB0", VA = "0x184EB9BB0")]
	public NMPBFLILHBK(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x4EB9A50", Offset = "0x4EB8E50", VA = "0x184EB9A50", Slot = "11")]
	public IDisposable HHMHIEDHOHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x4EB9790", Offset = "0x4EB8B90", VA = "0x184EB9790", Slot = "8")]
	public void BIFPDPDDGDL(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x4EB9B00", Offset = "0x4EB8F00", VA = "0x184EB9B00", Slot = "9")]
	public void NANINNNICOB(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x4EB9690", Offset = "0x4EB8A90", VA = "0x184EB9690", Slot = "10")]
	public void BAEFPBDLCOE(object PFJMMABJIDH, bool MDOKFMLNLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x4EB99D0", Offset = "0x4EB8DD0", VA = "0x184EB99D0", Slot = "12")]
	public void GPBCEHCAEIE(Rigidbody MCFBEICDKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x4EB9AB0", Offset = "0x4EB8EB0", VA = "0x184EB9AB0", Slot = "13")]
	public void JJLFJOIGLGI(Rigidbody EMOKGIOEOMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class OJBLNMLPJAJ : NDLNMBPCBPI, AMBACEAOLLK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly AKDPLPNNHCO EIOOACKMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private PhotonView HEJFKPMKBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private bool CEHCDICBFKB;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public PhotonView NMOAIPGNGGD
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public bool AOGGMNBIPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x4EBBF20", Offset = "0x4EBB320", VA = "0x184EBBF20", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool GLNBGDPGNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x75DF80", Offset = "0x75D380", VA = "0x18075DF80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event OBKDBINKHFD FOONNAAAKEG
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x4EBC1C0", Offset = "0x4EBB5C0", VA = "0x184EBC1C0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x4EBC260", Offset = "0x4EBB660", VA = "0x184EBC260", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x4EBC490", Offset = "0x4EBB890", VA = "0x184EBC490")]
	public OJBLNMLPJAJ(LDFFFADLJJJ EIOOACKMMIN, in CEGPKCKJNIC HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x4EBBC40", Offset = "0x4EBB040", VA = "0x184EBBC40", Slot = "9")]
	public void FHCJDMLKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x4EBBB30", Offset = "0x4EBAF30", VA = "0x184EBBB30", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x4EBC300", Offset = "0x4EBB700", VA = "0x184EBC300", Slot = "10")]
	public void PANBGPFHFPJ(LDFFFADLJJJ BLENCGKHIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x4EBBD90", Offset = "0x4EBB190", VA = "0x184EBBD90", Slot = "11")]
	public void FPDEOLOBGJF(LDFFFADLJJJ BLENCGKHIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB840", Offset = "0x4EBAC40", VA = "0x184EBB840")]
	private void AINDNODLHIK(PhotonView BMNFGGEEIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB9C0", Offset = "0x4EBADC0", VA = "0x184EBB9C0")]
	private void CMOINLLJLHN(RigidbodyEx OJPMCPFEKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x4EBBF40", Offset = "0x4EBB340", VA = "0x184EBBF40")]
	private void KIHDEKCAEMF(PhotonView FLIKLLIJCPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class LIMIHLMJOPE
{
	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x4EB49A0", Offset = "0x4EB3DA0", VA = "0x184EB49A0")]
	public static NDLNMBPCBPI NMJDFAEJBPE(this LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class OCKMKFCIFJB : GJOEJMLHHMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly AKDPLPNNHCO EIOOACKMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private RigidbodyConstraints BGPNKBPMPMD;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool PNKNIIFGHOH
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xAC60C0", Offset = "0xAC54C0", VA = "0x180AC60C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x24A4660", Offset = "0x24A3A60", VA = "0x1824A4660", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool EGIJJCPIMPD
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x24A4650", Offset = "0x24A3A50", VA = "0x1824A4650", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x24A4640", Offset = "0x24A3A40", VA = "0x1824A4640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public RigidbodyConstraints DOLBOFHHNAL
	{
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x66EBD0", Offset = "0x66DFD0", VA = "0x18066EBD0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x4EBAA70", Offset = "0x4EB9E70", VA = "0x184EBAA70", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x4EBABB0", Offset = "0x4EB9FB0", VA = "0x184EBABB0")]
	public OCKMKFCIFJB(LDFFFADLJJJ EIOOACKMMIN, in CEGPKCKJNIC HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAA10", Offset = "0x4EB9E10", VA = "0x184EBAA10", Slot = "9")]
	public void GPBCEHCAEIE(Rigidbody EMOKGIOEOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x4EBAA40", Offset = "0x4EB9E40", VA = "0x184EBAA40", Slot = "10")]
	public void JJLFJOIGLGI(Rigidbody EMOKGIOEOMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class CNMJKPECFEH : EJJCAPKOAPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly LDFFFADLJJJ EIOOACKMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float GDCLNFEPIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private float CBOIDDOJDAO;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public float IHABGKBJPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x116A3A0", Offset = "0x11697A0", VA = "0x18116A3A0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x4EAB4F0", Offset = "0x4EAA8F0", VA = "0x184EAB4F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public float OJJNNNPAIOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x10F7D10", Offset = "0x10F7110", VA = "0x1810F7D10", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x4EAB610", Offset = "0x4EAAA10", VA = "0x184EAB610", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x4EAB780", Offset = "0x4EAAB80", VA = "0x184EAB780")]
	public CNMJKPECFEH(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x4EAB5C0", Offset = "0x4EAA9C0", VA = "0x184EAB5C0", Slot = "8")]
	public void GPBCEHCAEIE(Rigidbody EMOKGIOEOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x4EAB6E0", Offset = "0x4EAAAE0", VA = "0x184EAB6E0", Slot = "9")]
	public void JJLFJOIGLGI(Rigidbody EMOKGIOEOMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class OBAAPIGAFIM : ILGKLKEDKPI
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private const int HIPBDNINMIE = 10;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private const float KFIPGKPHLPC = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private const float GDGOILMPCNP = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const float MHNMKPEDGHJ = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly AKDPLPNNHCO EIOOACKMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool EIPPDNGBPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private bool KNIOINNMMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int NBNLKJODOFF;

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	private Rigidbody HHEABFBCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x4EBA560", Offset = "0x4EB9960", VA = "0x184EBA560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private bool OMOHDGMFPMF
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x4EBA8E0", Offset = "0x4EB9CE0", VA = "0x184EBA8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private bool KOJKALGLCJD
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x4EB9F20", Offset = "0x4EB9320", VA = "0x184EB9F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private LDFFFADLJJJ MPHEKDGOELO
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x4EB9D30", Offset = "0x4EB9130", VA = "0x184EB9D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private bool FIIKANAHFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x4EBA500", Offset = "0x4EB9900", VA = "0x184EBA500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event OBKDBINKHFD DPJIEBMHGDB
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x4EB9FE0", Offset = "0x4EB93E0", VA = "0x184EB9FE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x4EB9C90", Offset = "0x4EB9090", VA = "0x184EB9C90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x4EBA980", Offset = "0x4EB9D80", VA = "0x184EBA980")]
	public OBAAPIGAFIM(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x4EBA080", Offset = "0x4EB9480", VA = "0x184EBA080", Slot = "6")]
	public void FHCJDMLKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x4EBA110", Offset = "0x4EB9510", VA = "0x184EBA110", Slot = "8")]
	public void FOADLPPLLJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x4EBA200", Offset = "0x4EB9600", VA = "0x184EBA200", Slot = "7")]
	public bool MDDEJDBMFIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x4EBA160", Offset = "0x4EB9560", VA = "0x184EBA160", Slot = "9")]
	public void LBEKAGHMMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x4EB9F40", Offset = "0x4EB9340", VA = "0x184EB9F40", Slot = "11")]
	public void DAPMLKLECBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x4EBA120", Offset = "0x4EB9520", VA = "0x184EBA120", Slot = "12")]
	public void JHNLKPNKEBM(bool LJBNFKDALHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x4EBA5B0", Offset = "0x4EB99B0", VA = "0x184EBA5B0", Slot = "10")]
	public void PLJBAMJCMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x4EBA350", Offset = "0x4EB9750", VA = "0x184EBA350")]
	private bool MDJCLFFAFKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x4EB9D90", Offset = "0x4EB9190", VA = "0x184EB9D90")]
	private void BFIPGLBLGCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class KOICPPKAONA : KEMMHKDIIBP
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const string GHAKMJNPJAH = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly AKDPLPNNHCO EIOOACKMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly BMHJPGJHMEO IABACMHIPGI;

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public Rigidbody HHEABFBCNDG
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x66E120", Offset = "0x66D520", VA = "0x18066E120", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x66E130", Offset = "0x66D530", VA = "0x18066E130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	private bool FIIKANAHFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x4EB0E50", Offset = "0x4EB0250", VA = "0x184EB0E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x4EB2F70", Offset = "0x4EB2370", VA = "0x184EB2F70")]
	public KOICPPKAONA(LDFFFADLJJJ EIOOACKMMIN, in CEGPKCKJNIC HANEMGLFJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x4EB24B0", Offset = "0x4EB18B0", VA = "0x184EB24B0", Slot = "5")]
	public void FHCJDMLKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x4EB2F10", Offset = "0x4EB2310", VA = "0x184EB2F10", Slot = "6")]
	public void NHPIIIMMNPK(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x4EB2F40", Offset = "0x4EB2340", VA = "0x184EB2F40", Slot = "7")]
	public void PENEMIKMOLK(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x4EB2710", Offset = "0x4EB1B10", VA = "0x184EB2710", Slot = "8")]
	public void KHKJOHJIJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x4EB2100", Offset = "0x4EB1500", VA = "0x184EB2100", Slot = "9")]
	public void BNABEKGONBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1F80", Offset = "0x4EB1380", VA = "0x184EB1F80", Slot = "10")]
	public void BJEJPEJGCEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x4EB2A70", Offset = "0x4EB1E70", VA = "0x184EB2A70", Slot = "11")]
	public void LBLHJOEBAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x4EB2560", Offset = "0x4EB1960", VA = "0x184EB2560")]
	private void HKBACMAFJDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x4EB2300", Offset = "0x4EB1700", VA = "0x184EB2300")]
	private void EBFJKCPDBLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class ACPBMFDAEPO : IIBIBAOAIIL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly AKDPLPNNHCO EIOOACKMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly BMHJPGJHMEO FCMKPKIKIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private float OBFEIADOPEN;

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public GDJBDCHFLPM IKKDOCCFOPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x6878E0", Offset = "0x686CE0", VA = "0x1806878E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1C0", Offset = "0x6AE5C0", VA = "0x1806AF1C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public MDBCJGELOMO EMIMILKLLLH
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x6836F0", Offset = "0x682AF0", VA = "0x1806836F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x705AE0", Offset = "0x704EE0", VA = "0x180705AE0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public Vector3 MFJJIFMGMLG
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x4E9C740", Offset = "0x4E9BB40", VA = "0x184E9C740", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x4E9B140", Offset = "0x4E9A540", VA = "0x184E9B140", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public Vector3 FOIPNDJDCJL
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x4E9D320", Offset = "0x4E9C720", VA = "0x184E9D320", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x4E9D680", Offset = "0x4E9CA80", VA = "0x184E9D680", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public Vector3 KMHIECBCLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x4E9DA40", Offset = "0x4E9CE40", VA = "0x184E9DA40", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x4E9DE50", Offset = "0x4E9D250", VA = "0x184E9DE50", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 CMDADPOFJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x4E9B840", Offset = "0x4E9AC40", VA = "0x184E9B840", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x4E9B7F0", Offset = "0x4E9ABF0", VA = "0x184E9B7F0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public float FIHINFGIBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x122CFD0", Offset = "0x122C3D0", VA = "0x18122CFD0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x4E9DD30", Offset = "0x4E9D130", VA = "0x184E9DD30", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public bool NGJJKMHFKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x208B180", Offset = "0x208A580", VA = "0x18208B180", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	private ILOOGBEPGEC EKOOBBKDOMA
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x1B2AE50", Offset = "0x1B2A250", VA = "0x181B2AE50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private bool KOJKALGLCJD
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x4E9B820", Offset = "0x4E9AC20", VA = "0x184E9B820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x4E9DF10", Offset = "0x4E9D310", VA = "0x184E9DF10")]
	public ACPBMFDAEPO(LDFFFADLJJJ EIOOACKMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C270", Offset = "0x4E9B670", VA = "0x184E9C270", Slot = "19")]
	public void FHCJDMLKKLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C120", Offset = "0x4E9B520", VA = "0x184E9C120", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CAA0", Offset = "0x4E9BEA0", VA = "0x184E9CAA0", Slot = "28")]
	public void GPBCEHCAEIE(Rigidbody EMOKGIOEOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x140ECA0", Offset = "0x140E0A0", VA = "0x18140ECA0", Slot = "20")]
	public void APNABGJPFJD(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x140FB50", Offset = "0x140EF50", VA = "0x18140FB50", Slot = "31")]
	public void BIDLBKJIOAI(object PFJMMABJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D770", Offset = "0x4E9CB70", VA = "0x184E9D770", Slot = "36")]
	public Vector3 LLLJCOENOCC(Vector3 KINMMEKNHJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x4E9DB70", Offset = "0x4E9CF70", VA = "0x184E9DB70", Slot = "35")]
	public Vector3 OGIHLPOGFOM(Vector3 NMEPDMHFFKO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C270", Offset = "0x4E9B670", VA = "0x184E9C270", Slot = "27")]
	public void MMAEAMLHNPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x4E9B930", Offset = "0x4E9AD30", VA = "0x184E9B930", Slot = "25")]
	public void CMPJEOBIHGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D640", Offset = "0x4E9CA40", VA = "0x184E9D640", Slot = "24")]
	public void KLEFLIGGHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C860", Offset = "0x4E9BC60", VA = "0x184E9C860", Slot = "34")]
	public void GINACPDMAJK(Vector3 DDMIKGEOOPO, Vector3 HAFOPEOGPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x4E9B340", Offset = "0x4E9A740", VA = "0x184E9B340", Slot = "33")]
	public void AJPIKIEJJON(Vector3 JKKOHPMJAOG, Vector3 OPEKPFLGIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D1E0", Offset = "0x4E9C5E0", VA = "0x184E9D1E0", Slot = "32")]
	public void ICGIKNDEMKP(Vector3 DCLIGMBGEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x4E9B3A0", Offset = "0x4E9A7A0", VA = "0x184E9B3A0", Slot = "22")]
	public void ALPEEHFPDIC(IJDCLCAKEAN LEIHBICAMKK, Vector3 KAFKHBLOAFI, float MDPIMMDABFN, float ONCCEMEBFFA = 8f, float CMDCCPIAHFP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D410", Offset = "0x4E9C810", VA = "0x184E9D410", Slot = "21")]
	public void KIDNLLJJIDN(IAABFEHMLCH KLINALAALOC, Vector3 OIEKPCBPIOL, float PBEJEHPPJEK = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CF10", Offset = "0x4E9C310", VA = "0x184E9CF10", Slot = "23")]
	[Obsolete]
	public void HNDILLGBLAC(IAABFEHMLCH KLINALAALOC, Vector3 BOMBFPIEJKJ, float FOKMAHAMPKL = 7f, float IPMBDAIGFIH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x4E9B970", Offset = "0x4E9AD70", VA = "0x184E9B970", Slot = "30")]
	public Vector3 DHEAGNCIMFN(Vector3 CNBICOEGBNM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C180", Offset = "0x4E9B580", VA = "0x184E9C180", Slot = "29")]
	public Vector3 EPOCOFMAFLK(Vector3 FEBDBINBLMJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C2E0", Offset = "0x4E9B6E0", VA = "0x184E9C2E0", Slot = "26")]
	public void FIAEKINLCJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x4E9DD30", Offset = "0x4E9D130", VA = "0x184E9DD30")]
	private void OOLKGMCIGOA(float PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x4E9B200", Offset = "0x4E9A600", VA = "0x184E9B200")]
	private void AJONMFOFDAF(Vector3 OIEKPCBPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C030", Offset = "0x4E9B430", VA = "0x184E9C030")]
	private Vector3 DMJNDFOFBAN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x4E9C410", Offset = "0x4E9B810", VA = "0x184E9C410")]
	private void FIMHMGPMDIJ(Vector3 NMEPDMHFFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D950", Offset = "0x4E9CD50", VA = "0x184E9D950")]
	private Vector3 LMKHJOLEIIA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x4E9CBD0", Offset = "0x4E9BFD0", VA = "0x184E9CBD0")]
	private void HIAGBGIMKIM(Vector3 PKODKJLGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x4E9BA30", Offset = "0x4E9AE30", VA = "0x184E9BA30")]
	private void DKMLHGPNHLM(Vector3 NMEPDMHFFKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x4E9D6B0", Offset = "0x4E9CAB0", VA = "0x184E9D6B0")]
	private void KOJDHKPBDAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class JFKKGCHOGOE : HNPLEDGEHJM
{
	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1D80", Offset = "0x4EB1180", VA = "0x184EB1D80", Slot = "4")]
	public NKPNDPJNKPK PEBBGGAKMOG(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1180", Offset = "0x4EB0580", VA = "0x184EB1180", Slot = "5")]
	public IIBIBAOAIIL AJGKEIPFFII(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1860", Offset = "0x4EB0C60", VA = "0x184EB1860", Slot = "6")]
	public IOJIKJOEGAG IDJMKIABLPM(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1C60", Offset = "0x4EB1060", VA = "0x184EB1C60", Slot = "7")]
	public EJJCAPKOAPE LEHJOCKCOMM(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1970", Offset = "0x4EB0D70", VA = "0x184EB1970", Slot = "8")]
	public ILGKLKEDKPI IJODDIPBKAA(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x4EB17A0", Offset = "0x4EB0BA0", VA = "0x184EB17A0", Slot = "9")]
	public JDPDNLNKMOL GMADCNBNHFC(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1580", Offset = "0x4EB0980", VA = "0x184EB1580", Slot = "10")]
	public KJJJDFEAIEN FCDBMBJKIDM(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x4EB10D0", Offset = "0x4EB04D0", VA = "0x184EB10D0", Slot = "11")]
	public ILOOGBEPGEC AEFONNIOMCI(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1A30", Offset = "0x4EB0E30", VA = "0x184EB1A30", Slot = "12")]
	public NMCGJCCOOHJ KGGFHEGMFLF(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1BB0", Offset = "0x4EB0FB0", VA = "0x184EB1BB0", Slot = "13")]
	public NPGCEJMKCHP LEDPNGNHKGL(LDFFFADLJJJ MDAIEADLBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1680", Offset = "0x4EB0A80", VA = "0x184EB1680")]
	public KEMMHKDIIBP FMFPPDHFDNJ(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x4EB14B0", Offset = "0x4EB08B0", VA = "0x184EB14B0")]
	public AMBACEAOLLK POFPJNFIOBP(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1290", Offset = "0x4EB0690", VA = "0x184EB1290")]
	public HMOBGIIKKNK BLPKEJNBFIL(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x4EB13B0", Offset = "0x4EB07B0", VA = "0x184EB13B0")]
	public COBPCPMCJAM PDAPNHPDCCC(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1AE0", Offset = "0x4EB0EE0", VA = "0x184EB1AE0")]
	public GJOEJMLHHMK NLCFPEEEPEN(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1CD0", Offset = "0x4EB10D0", VA = "0x184EB1CD0", Slot = "19")]
	public LDFFFADLJJJ OPJEPJEFDJG(RigidbodyEx EIOOACKMMIN, CEGPKCKJNIC HANEMGLFJMM, LMAIHHGHGOJ INFFNKABNHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public JFKKGCHOGOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1680", Offset = "0x4EB0A80", VA = "0x184EB1680", Slot = "14")]
	private KEMMHKDIIBP JOCMFEIEEKK(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x4EB14B0", Offset = "0x4EB08B0", VA = "0x184EB14B0", Slot = "15")]
	private AMBACEAOLLK DICHMAJNDLI(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1290", Offset = "0x4EB0690", VA = "0x184EB1290", Slot = "16")]
	private HMOBGIIKKNK MIOGDIGFGLK(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x4EB13B0", Offset = "0x4EB07B0", VA = "0x184EB13B0", Slot = "17")]
	private COBPCPMCJAM CNOJNFJDLPL(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x4EB1AE0", Offset = "0x4EB0EE0", VA = "0x184EB1AE0", Slot = "18")]
	private GJOEJMLHHMK KPHPKFNKHNM(LDFFFADLJJJ MDAIEADLBOD, in CEGPKCKJNIC HANEMGLFJMM)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[Preserve]
	internal class _RRAssemblyIndex : EFIPBPLGBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x66EB40", Offset = "0x66DF40", VA = "0x18066EB40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7C70", Offset = "0x5FC7070", VA = "0x185FC7C70", Slot = "6")]
		public sealed override void HGCIEPNFBCH(LDNEHEGKOKK EGLKIOCIBPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7BF0", Offset = "0x5FC6FF0", VA = "0x185FC7BF0", Slot = "4")]
		public sealed override void AMKPAJEBOOH()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class ILPMCCIAAOO
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static byte[] EFCNCHAHCDJ;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static int IFHOEBNLHGF;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static int CLAMAIDAIOM;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static BigInteger ADBDIIFGHNH;

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
	public ILPMCCIAAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x4EAFE50", Offset = "0x4EAF250", VA = "0x184EAFE50")]
	private static string PINDCOCBOMG(byte[] ABBMKKCGFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x4EAFB00", Offset = "0x4EAEF00", VA = "0x184EAFB00")]
	public static string OEPGMAKGOND(byte[] OGILIIFBKAD, bool GHCIENBALCN)
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

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x66EB30", Offset = "0x66DF30", VA = "0x18066EB30")]
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
