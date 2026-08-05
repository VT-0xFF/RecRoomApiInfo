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
internal class IIHHKHENBKK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public const string PFGKFBIKDBH = "RBEX_DEFAULT";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const float IDFEBHIDPPF = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public const float LHPOAHLPPPH = 0f;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public const float CMNPNGOCPKN = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public IIHHKHENBKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void IDBANGEEFOC(RigidbodyEx PPEDJFJKBCP);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void BMBDIJCKKFM(RigidbodyEx PPEDJFJKBCP, bool BFNLLLADIAA = false);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KDLFENIMCAA
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum LFEOGCDJGOL
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum ELMJFFPDDAN
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class LNIPDGJNNPN : EIJNDDCMLGM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OMPAIHNDLPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x755A00", Offset = "0x754400", VA = "0x180755A00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LHKCIIMHDBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x80B660", Offset = "0x80A060", VA = "0x18080B660", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "6")]
	public IJJPEDCHMLC MGJNKCINCNF(float FFOCLOKDMIA)
	{
		return default(IJJPEDCHMLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "7")]
	public void IFPOOIAJHAI(KPFJBIMGOOA OMHIFHKMIMJ, float KCGKLFGFACE, EFJPJGLGGEC KCEEGGDAHKJ = EFJPJGLGGEC.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "8")]
	public void IFPOOIAJHAI(KPFJBIMGOOA OMHIFHKMIMJ, Transform AHIIIGNBKLC, float KCGKLFGFACE, EFJPJGLGGEC KCEEGGDAHKJ = EFJPJGLGGEC.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "9")]
	public void LAOLLLDEKLP(KPFJBIMGOOA OMHIFHKMIMJ, [Optional] float? KCGKLFGFACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "10")]
	public void HEOHJOBENDL(KPFJBIMGOOA PGKPMAELFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "11")]
	public IJJPEDCHMLC MMMOMAIKHGL(KPFJBIMGOOA OMHIFHKMIMJ)
	{
		return default(IJJPEDCHMLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE80", Offset = "0x7FC880", VA = "0x1807FDE80", Slot = "12")]
	public bool ELEOMEKFNDG(KPFJBIMGOOA OMHIFHKMIMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "13")]
	public void CNHJBJOLBFD(KPFJBIMGOOA OMHIFHKMIMJ, EFJPJGLGGEC ICKKJNLFBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public LNIPDGJNNPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[LHOECCIDBFM(typeof(PNBBKMEKBPB), new string[] { "Ignore", "Mock" })]
public class KDEILEPLDHI : PNBBKMEKBPB
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MNHECLJOIEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A20", Offset = "0x7E5420", VA = "0x1807E6A20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
	public void MFFPIOKOEML(string MCCDEFDHGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "6")]
	public void FCNIDIECIMK(RigidbodyEx PALOPBGAJFN, Action DJJNLDOINEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "7")]
	public EIJNDDCMLGM LJPHINKBKDJ(int FGPNDDNFJOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "8")]
	public void JCCJMEOGJOB(Vector3 DLAONILBDIM, float HHLKEPPBBCO, Color CPPINAHFMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public KDEILEPLDHI()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	[KEFMDJAGLBH(IGKCNDFEDMC.Physics)]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool BDMDEKJELMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private COAHBFHINFJ HFLLMJOKBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[CCLDAICIAJB(MAMLNCPNJJC.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[CCLDAICIAJB(MAMLNCPNJJC.SelfAndParent, true, false, false)]
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
		private LFEOGCDJGOL physicsInterpolation;

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
		internal COAHBFHINFJ IKPFPMKENNC
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6A95910", Offset = "0x6A94310", VA = "0x186A95910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<RigidbodyEx> PLEEMIOGEJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7D7060", Offset = "0x7D5A60", VA = "0x1807D7060")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7D7050", Offset = "0x7D5A50", VA = "0x1807D7050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx ICJJEDCKKNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6A97A60", Offset = "0x6A96460", VA = "0x186A97A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx ADLFAHHCAGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6A97A00", Offset = "0x6A96400", VA = "0x186A97A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public RigidbodyEx EOBFGLJBCIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6A985C0", Offset = "0x6A96FC0", VA = "0x186A985C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6A99D10", Offset = "0x6A98710", VA = "0x186A99D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform NFIHBIKGJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x12386A0", Offset = "0x12370A0", VA = "0x1812386A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform MANILMNCAOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x12386A0", Offset = "0x12370A0", VA = "0x1812386A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public EFJPJGLGGEC KPFOHJHFIIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6A976F0", Offset = "0x6A960F0", VA = "0x186A976F0")]
			get
			{
				return default(EFJPJGLGGEC);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6A992B0", Offset = "0x6A97CB0", VA = "0x186A992B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool PNPAICFFMGP
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6A97C70", Offset = "0x6A96670", VA = "0x186A97C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool EJPMOLMBFPC
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6A97880", Offset = "0x6A96280", VA = "0x186A97880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public OAAJJMEKKCO FOHFKKLNCEO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6A97C10", Offset = "0x6A96610", VA = "0x186A97C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6A994C0", Offset = "0x6A97EC0", VA = "0x186A994C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public NGGEJBJJIOA ONFHFHJINDD
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6A97BB0", Offset = "0x6A965B0", VA = "0x186A97BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6A99450", Offset = "0x6A97E50", VA = "0x186A99450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool EMAEPLLIHHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6A97A90", Offset = "0x6A96490", VA = "0x186A97A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Rigidbody OMLJJMOAGEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6A97AF0", Offset = "0x6A964F0", VA = "0x186A97AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool MNBOPCHPOPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6A97940", Offset = "0x6A96340", VA = "0x186A97940")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6A99370", Offset = "0x6A97D70", VA = "0x186A99370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DALGAOKKMBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3C321F0", Offset = "0x3C30BF0", VA = "0x183C321F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3C32210", Offset = "0x3C30C10", VA = "0x183C32210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float LCIGAPICOAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6A98560", Offset = "0x6A96F60", VA = "0x186A98560")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float MOKFCAHNAPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6A98500", Offset = "0x6A96F00", VA = "0x186A98500")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6A99CA0", Offset = "0x6A986A0", VA = "0x186A99CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float ANBFJKDEKAB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6A97ED0", Offset = "0x6A968D0", VA = "0x186A97ED0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6A99760", Offset = "0x6A98160", VA = "0x186A99760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float HPCKAGPDAKC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6A97CD0", Offset = "0x6A966D0", VA = "0x186A97CD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6A99530", Offset = "0x6A97F30", VA = "0x186A99530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool PPJFNNMGJID
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6A98AE0", Offset = "0x6A974E0", VA = "0x186A98AE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6A9A250", Offset = "0x6A98C50", VA = "0x186A9A250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 FAJNPDIOIFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6A982E0", Offset = "0x6A96CE0", VA = "0x186A982E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6A99A70", Offset = "0x6A98470", VA = "0x186A99A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 DLAONILBDIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6A98C20", Offset = "0x6A97620", VA = "0x186A98C20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CollisionDetectionMode ECEGLEGLHHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6A97E10", Offset = "0x6A96810", VA = "0x186A97E10")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6A99680", Offset = "0x6A98080", VA = "0x186A99680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float JBJNCHGJKNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6A979A0", Offset = "0x6A963A0", VA = "0x186A979A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6A993E0", Offset = "0x6A97DE0", VA = "0x186A993E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public RigidbodyConstraints IHKKDCFLCHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6A97E70", Offset = "0x6A96870", VA = "0x186A97E70")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6A996F0", Offset = "0x6A980F0", VA = "0x186A996F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 LMOGGMHCDHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6A98620", Offset = "0x6A97020", VA = "0x186A98620")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 OCNEJOIBOBO
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6A98620", Offset = "0x6A97020", VA = "0x186A98620")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6A9A020", Offset = "0x6A98A20", VA = "0x186A9A020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float NDAMJBDDGDH
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6A983C0", Offset = "0x6A96DC0", VA = "0x186A983C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6A99B50", Offset = "0x6A98550", VA = "0x186A99B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float BDEINNLJOOB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6A98A80", Offset = "0x6A97480", VA = "0x186A98A80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6A9A1E0", Offset = "0x6A98BE0", VA = "0x186A9A1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion DKEILPOFHBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6A98700", Offset = "0x6A97100", VA = "0x186A98700")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6A99D80", Offset = "0x6A98780", VA = "0x186A99D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion PAHDBKIPHAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6A989A0", Offset = "0x6A973A0", VA = "0x186A989A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6A9A100", Offset = "0x6A98B00", VA = "0x186A9A100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 KFKPBGIPPDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6A987E0", Offset = "0x6A971E0", VA = "0x186A987E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6A99E60", Offset = "0x6A98860", VA = "0x186A99E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Quaternion BIGHDIBKMFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6A988C0", Offset = "0x6A972C0", VA = "0x186A988C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6A99F40", Offset = "0x6A98940", VA = "0x186A99F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 PBLNDACCBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6A98B40", Offset = "0x6A97540", VA = "0x186A98B40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6A9A2C0", Offset = "0x6A98CC0", VA = "0x186A9A2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 NKKNGNHELCP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6A98420", Offset = "0x6A96E20", VA = "0x186A98420")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6A99BC0", Offset = "0x6A985C0", VA = "0x186A99BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 LOMDGDKPDKD
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6A97D30", Offset = "0x6A96730", VA = "0x186A97D30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6A995A0", Offset = "0x6A97FA0", VA = "0x186A995A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 OBAPNEEPMPN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6A98200", Offset = "0x6A96C00", VA = "0x186A98200")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6A99990", Offset = "0x6A98390", VA = "0x186A99990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 LLOCHGNGKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6A980C0", Offset = "0x6A96AC0", VA = "0x186A980C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6A998B0", Offset = "0x6A982B0", VA = "0x186A998B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Quaternion FIMLOJEIEHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6A97FE0", Offset = "0x6A969E0", VA = "0x186A97FE0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6A997D0", Offset = "0x6A981D0", VA = "0x186A997D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 IFCHKGOHIIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6A98DE0", Offset = "0x6A977E0", VA = "0x186A98DE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 PCIGPGLOELO
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x6A98D00", Offset = "0x6A97700", VA = "0x186A98D00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool HOCNLDJLJMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x6A981A0", Offset = "0x6A96BA0", VA = "0x186A981A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool FKIBJJIHGPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6A978E0", Offset = "0x6A962E0", VA = "0x186A978E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool EBNPMBHCAAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6A97820", Offset = "0x6A96220", VA = "0x186A97820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool ODAILKPDPBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6A977C0", Offset = "0x6A961C0", VA = "0x186A977C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool DLMFFEBHFDG
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6A97690", Offset = "0x6A96090", VA = "0x186A97690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool AMJNEBCFDPG
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6A97F30", Offset = "0x6A96930", VA = "0x186A97F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool FFCJMMOGLGC
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7B1D20", Offset = "0x7B0720", VA = "0x1807B1D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event IDBANGEEFOC NCGJCAKEHGA
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6A975B0", Offset = "0x6A95FB0", VA = "0x186A975B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6A991D0", Offset = "0x6A97BD0", VA = "0x186A991D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event BMBDIJCKKFM KKHOBAGFADL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6A97540", Offset = "0x6A95F40", VA = "0x186A97540")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6A99160", Offset = "0x6A97B60", VA = "0x186A99160")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event IDBANGEEFOC FHNMFLEGKLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6A972A0", Offset = "0x6A95CA0", VA = "0x186A972A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6A98EC0", Offset = "0x6A978C0", VA = "0x186A98EC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event IDBANGEEFOC KACABKHKGJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6A97310", Offset = "0x6A95D10", VA = "0x186A97310")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6A98F30", Offset = "0x6A97930", VA = "0x186A98F30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event IDBANGEEFOC OGFKCFDDFAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6A97460", Offset = "0x6A95E60", VA = "0x186A97460")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6A99080", Offset = "0x6A97A80", VA = "0x186A99080")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<IJJPEDCHMLC, IJJPEDCHMLC> HMNEDFGDGIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6A973F0", Offset = "0x6A95DF0", VA = "0x186A973F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6A99010", Offset = "0x6A97A10", VA = "0x186A99010")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event IDBANGEEFOC KIKNAOBEIBM
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6A974D0", Offset = "0x6A95ED0", VA = "0x186A974D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6A990F0", Offset = "0x6A97AF0", VA = "0x186A990F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event IDBANGEEFOC BHMOOGKHABI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6A97620", Offset = "0x6A96020", VA = "0x186A97620")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6A99240", Offset = "0x6A97C40", VA = "0x186A99240")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event IDBANGEEFOC BAOOFNJOHJA
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6A97380", Offset = "0x6A95D80", VA = "0x186A97380")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6A98FA0", Offset = "0x6A979A0", VA = "0x186A98FA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x831AC0", Offset = "0x8304C0", VA = "0x180831AC0")]
		internal void HJMEFAPKPJE(COAHBFHINFJ NPGEFAIHGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6A95E60", Offset = "0x6A94860", VA = "0x186A95E60")]
		internal void IALCNCFIPOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6A96FF0", Offset = "0x6A959F0", VA = "0x186A96FF0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody LGLHNOLCGAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6A958A0", Offset = "0x6A942A0", VA = "0x186A958A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6A95910", Offset = "0x6A94310", VA = "0x186A95910")]
		private COAHBFHINFJ HHCFHCDDAGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6A95FD0", Offset = "0x6A949D0", VA = "0x186A95FD0")]
		private void LFPDFEJCFOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6A96530", Offset = "0x6A94F30", VA = "0x186A96530")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6A964C0", Offset = "0x6A94EC0", VA = "0x186A964C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6A95C00", Offset = "0x6A94600", VA = "0x186A95C00")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6A964D0", Offset = "0x6A94ED0", VA = "0x186A964D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6A96590", Offset = "0x6A94F90", VA = "0x186A96590")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6A94F30", Offset = "0x6A93930", VA = "0x186A94F30")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6A96600", Offset = "0x6A95000", VA = "0x186A96600")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6A95BA0", Offset = "0x6A945A0", VA = "0x186A95BA0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6A96460", Offset = "0x6A94E60", VA = "0x186A96460")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6A96DF0", Offset = "0x6A957F0", VA = "0x186A96DF0")]
		public void SetParent(RigidbodyEx MFBGAMJDOKA, bool BFNLLLADIAA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6A96910", Offset = "0x6A95310", VA = "0x186A96910")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6A95EF0", Offset = "0x6A948F0", VA = "0x186A95EF0")]
		public bool IsRigidbodyAncestor(RigidbodyEx OBMBIBGPNLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6A95F30", Offset = "0x6A94930", VA = "0x186A95F30")]
		public bool IsRigidbodyDescendant(RigidbodyEx NOKCDOJGIJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6A95150", Offset = "0x6A93B50", VA = "0x186A95150")]
		public void AddInterpolationRestriction(object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6A96670", Offset = "0x6A95070", VA = "0x186A96670")]
		public void RemoveInterpolationRestriction(object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6A959C0", Offset = "0x6A943C0", VA = "0x186A959C0")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6A951C0", Offset = "0x6A93BC0", VA = "0x186A951C0")]
		public void AddKinematic(object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6A966E0", Offset = "0x6A950E0", VA = "0x186A966E0")]
		public void RemoveKinematic(object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6A96D70", Offset = "0x6A95770", VA = "0x186A96D70")]
		public void SetKinematic(object HMAOAMDKNDD, bool OHANDDCLMMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6A96C70", Offset = "0x6A95670", VA = "0x186A96C70")]
		public void SetDiscontinuousPositionAndRotation(Vector3 JJJOPGOLMFH, Quaternion KLBIBNCNCIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6A96B70", Offset = "0x6A95570", VA = "0x186A96B70")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 ONKHKGGGDFH, Quaternion DHKLEPIAPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6A95D60", Offset = "0x6A94760", VA = "0x186A95D60")]
		public Vector3 GetConstrainedVelocity(Vector3 PBLNDACCBGI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A95C60", Offset = "0x6A94660", VA = "0x186A95C60")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 LOMDGDKPDKD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6A950C0", Offset = "0x6A93AC0", VA = "0x186A950C0")]
		public void AddForce(Vector3 BFIMHHIKINE, ForceMode PFMKMOIPPCD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6A94FA0", Offset = "0x6A939A0", VA = "0x186A94FA0")]
		public void AddForceAtPosition(Vector3 BFIMHHIKINE, Vector3 LHCEFCJDGIJ, ForceMode PFMKMOIPPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6A952C0", Offset = "0x6A93CC0", VA = "0x186A952C0")]
		public void AddTorque(Vector3 PIPIGKBLIGD, ForceMode PFMKMOIPPCD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6A95230", Offset = "0x6A93C30", VA = "0x186A95230")]
		public void AddRelativeTorque(Vector3 PIPIGKBLIGD, ForceMode PFMKMOIPPCD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6A970D0", Offset = "0x6A95AD0", VA = "0x186A970D0")]
		public Vector3 WorldToLocalVelocity(Vector3 GELONNAFHPN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6A96360", Offset = "0x6A94D60", VA = "0x186A96360")]
		public Vector3 LocalToWorldVelocity(Vector3 NKKNGNHELCP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6A95B40", Offset = "0x6A94540", VA = "0x186A95B40")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6A95AE0", Offset = "0x6A944E0", VA = "0x186A95AE0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6A95A80", Offset = "0x6A94480", VA = "0x186A95A80")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6A95A20", Offset = "0x6A94420", VA = "0x186A95A20")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6A96A70", Offset = "0x6A95470", VA = "0x186A96A70")]
		public void ResetVelocityWorldSpace(Vector3 GMNCBDPBBLL, Vector3 CAEAHDMGPBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6A96970", Offset = "0x6A95370", VA = "0x186A96970")]
		public void ResetVelocityLocalSpace(Vector3 JJEOGAGCOIH, Vector3 OBAPNEEPMPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6A96830", Offset = "0x6A95230", VA = "0x186A96830")]
		public void ResetLinearVelocityLocalSpace(Vector3 JJEOGAGCOIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6A96EE0", Offset = "0x6A958E0", VA = "0x186A96EE0")]
		public bool SweepTest(Vector3 GNIANLFIOCO, out RaycastHit ANGKOJNCMIA, float AGKAIFMKLLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6A95F70", Offset = "0x6A94970", VA = "0x186A95F70")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6A96E80", Offset = "0x6A95880", VA = "0x186A96E80")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6A97070", Offset = "0x6A95A70", VA = "0x186A97070")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6A95350", Offset = "0x6A93D50", VA = "0x186A95350")]
		public void AddUnityRigidbody(object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6A96750", Offset = "0x6A95150", VA = "0x186A96750")]
		public void RemoveUnityRigidbody(object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6A95670", Offset = "0x6A94070", VA = "0x186A95670")]
		public void ApplyForceVelocityChange(KDLFENIMCAA NALNFBLFJEL, Vector3 ACKJBHOBHDH, float MEEIIJPJJBC, float JHBPAKGIBHB = 8f, float LJLGEELHOJE = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A95570", Offset = "0x6A93F70", VA = "0x186A95570")]
		public void ApplyAngularVelocityChange(ELMJFFPDDAN KLDJNIPILLN, Vector3 BCFGIAPFKKB, float OKLEEHKJJBA = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A95790", Offset = "0x6A94190", VA = "0x186A95790")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(ELMJFFPDDAN KLDJNIPILLN, Vector3 FDBNIAOOEMB, float HBOOAGHCBND = 7f, float BKMDHMBHOBP = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6A954B0", Offset = "0x6A93EB0", VA = "0x186A954B0")]
		public bool AllowedScaleChange(float HEPLPCOEDGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A953C0", Offset = "0x6A93DC0", VA = "0x186A953C0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx IGEMLIBMGHF, object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6A967C0", Offset = "0x6A951C0", VA = "0x186A967C0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6A97220", Offset = "0x6A95C20", VA = "0x186A97220")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class FHOCLNBHDFO
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5ACC450", Offset = "0x5ACAE50", VA = "0x185ACC450")]
	public static COAHBFHINFJ IKPFPMKENNC(this RigidbodyEx PALOPBGAJFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OFBIGENLNDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Rigidbody ACKBNFBBKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PhotonView ONJFDBACIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 BNNHCKIABAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OverridableVector3 EGPHBDFHDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public LFEOGCDJGOL MALPDEENGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool OMCJALKANGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool OIKEPLCMCIN;
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[KEFMDJAGLBH(IGKCNDFEDMC.Physics)]
	[LHOECCIDBFM(typeof(GMOFJHOBHHJ), new string[] { })]
	public class RigidbodyExManager : GMOFJHOBHHJ, HNADMPPHDEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DPFFGIGBPCD OPAHKFOPLAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private PNBBKMEKBPB FAMLIKPHPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private BDGACHFDAAD BKIHNFJIPMM;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GLBBMDKAEEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6A94A00", Offset = "0x6A93400", VA = "0x186A94A00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public PNBBKMEKBPB CNLJCAAJBOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public BDGACHFDAAD FIOAJCDLGFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6A94BA0", Offset = "0x6A935A0", VA = "0x186A94BA0", Slot = "12")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6A94730", Offset = "0x6A93130", VA = "0x186A94730", Slot = "7")]
		public GEEJJFIMDNA CIPMKCCBHCB(RigidbodyEx PALOPBGAJFN)
		{
			return default(GEEJJFIMDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6A94C30", Offset = "0x6A93630", VA = "0x186A94C30")]
		private static GEEJJFIMDNA NMKPCAKOCPB(RigidbodyEx PALOPBGAJFN)
		{
			return default(GEEJJFIMDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6A94620", Offset = "0x6A93020", VA = "0x186A94620", Slot = "8")]
		public COAHBFHINFJ AHDJIEGMHLB(RigidbodyEx PALOPBGAJFN, OFBIGENLNDL MNILNHMNKJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6A94E10", Offset = "0x6A93810", VA = "0x186A94E10", Slot = "11")]
		private RigidbodyEx PGKOLKDCPFM(GameObject LNBPLDMMKPA, OFBIGENLNDL MNILNHMNKJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6A94D20", Offset = "0x6A93720", VA = "0x186A94D20", Slot = "9")]
		public void PFJCLAFPKOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6A94A50", Offset = "0x6A93450", VA = "0x186A94A50", Slot = "10")]
		public void KKMAKIBOCNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static JAENCPCNABI UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int BPCMAFCOJHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int ADLHCOOBOKE;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A94100", Offset = "0x6A92B00", VA = "0x186A94100")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A94140", Offset = "0x6A92B40", VA = "0x186A94140")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A94120", Offset = "0x6A92B20", VA = "0x186A94120")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string MDEEJIBNIAD, [Optional] UnityEngine.Object BKJKDPLKCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string MDEEJIBNIAD, [Optional] UnityEngine.Object BKJKDPLKCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6A94230", Offset = "0x6A92C30", VA = "0x186A94230")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GKHDCENNOEN
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5ACF360", Offset = "0x5ACDD60", VA = "0x185ACF360")]
	public static void NNKDCPGECMH(this Rigidbody LGLHNOLCGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5ACF250", Offset = "0x5ACDC50", VA = "0x185ACF250")]
	public static void NNKDCPGECMH(this Rigidbody LGLHNOLCGAC, Vector3 LLOCHGNGKEI, Quaternion FIMLOJEIEHB, Vector3 GODPHGNFAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5ACF180", Offset = "0x5ACDB80", VA = "0x185ACF180")]
	public static void LAMFPFAJCGP(Vector3 PBLNDACCBGI, Vector3 DGILHLOCJDI, out Vector3 ODMFAJHPEKN, out Vector3 GCPOAFIDENA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HFNNBLLHAMA
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class JKLHBKPPEHO : OAAJJMEKKCO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x229BAE0", Offset = "0x229A4E0", VA = "0x18229BAE0", Slot = "4")]
		public Vector3 JCKHGMFFHBP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x229BAE0", Offset = "0x229A4E0", VA = "0x18229BAE0", Slot = "5")]
		public Vector3 DHOHLCHHEGL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public JKLHBKPPEHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static OAAJJMEKKCO CHGDGCCHPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5ACFD90", Offset = "0x5ACE790", VA = "0x185ACFD90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OLPBGKDBBKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode ONKHAABGHFC
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
	void HNIBDJMDFAL();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KAHCOLHEFIM(bool HOCNLDJLJMP);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AGEBFPMMJEA(bool HOCNLDJLJMP);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KPJHAKFGFBB(Rigidbody ACKBNFBBKOA);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CEHDPNMJOLM(Vector3 GNIANLFIOCO, out RaycastHit ANGKOJNCMIA, float AGKAIFMKLLP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IHEBEOFGNMA : IDisposable, KPFJBIMGOOA
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	AIFDGFHGOFL KPFOHJHFIIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<IJJPEDCHMLC, IJJPEDCHMLC> HMNEDFGDGIP;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HNIBDJMDFAL();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[POJCHFKPLOJ(PFPBFPDNLIO.Application)]
public interface BDGACHFDAAD
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KEPEBEIEONO LLFOFDPPPEH(COAHBFHINFJ NPGEFAIHGBA);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IJCAKKDCEJD BOOAJPBGFCJ(COAHBFHINFJ NPGEFAIHGBA);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DJGACNAABHP DEKGIBJDDEA(COAHBFHINFJ NPGEFAIHGBA);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BHMIPOFDPEF PPKKMOKPHMH(COAHBFHINFJ NPGEFAIHGBA);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LEABOMDCKNB CKBCPEEIFMM(COAHBFHINFJ NPGEFAIHGBA);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IHEBEOFGNMA LFPCDGDGHAA(COAHBFHINFJ NPGEFAIHGBA);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OBINMAACDBO ANJBKMGAONL(COAHBFHINFJ NPGEFAIHGBA);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ALMDAKNNCFI PDIOMEDJEAD(COAHBFHINFJ NPGEFAIHGBA);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OLPBGKDBBKJ MBHPECPBGKJ(COAHBFHINFJ NPGEFAIHGBA);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EGJGFBDNEPH NBLJJLHMPHB(COAHBFHINFJ NPGEFAIHGBA);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FLBBEGCCDPK ELAPBOIDLMJ(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	MAIEJCNIIBN CEFAJHJADHC(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IKEFBCLFODA IKMDFEKNPBJ(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MKIPBOEDJDF AHJJEEACDHH(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PKJGDCALGBM JDPIOHJNDBJ(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "15")]
	COAHBFHINFJ AHDJIEGMHLB(RigidbodyEx PALOPBGAJFN, OFBIGENLNDL MNILNHMNKJK, GMOFJHOBHHJ KONLJOKGCCN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ALMDAKNNCFI
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEEMGOCGBED(Vector3 BFIMHHIKINE, ForceMode PFMKMOIPPCD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PEICNGFMEKD(Vector3 BFIMHHIKINE, Vector3 LHCEFCJDGIJ, ForceMode PFMKMOIPPCD);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HMDGDDGCCFL(Vector3 PIPIGKBLIGD, ForceMode PFMKMOIPPCD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GEHIBBCOGKG(Vector3 PIPIGKBLIGD, ForceMode PFMKMOIPPCD = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EGJGFBDNEPH
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool OBCEOAKDHMN
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
	void KPJHAKFGFBB(Rigidbody ACKBNFBBKOA);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LCMOCMNDGKD(Rigidbody ACKBNFBBKOA);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KEPEBEIEONO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<COAHBFHINFJ> PLEEMIOGEJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	COAHBFHINFJ ADLFAHHCAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	COAHBFHINFJ NLJMPCEPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event IDBANGEEFOC FHNMFLEGKLF;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event IDBANGEEFOC KACABKHKGJH;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event BMBDIJCKKFM NDCGJGKOFAI;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action JGBCBBLECPE;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action PLFEODELMBG;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<COAHBFHINFJ> LCFBPJEOADK;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<COAHBFHINFJ> OCAKJFLNEGN;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action MGCEPPELIDB;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<COAHBFHINFJ> CIILGHHGBIH;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CLOBJFNMHGM(COAHBFHINFJ KLJNAJJPMKN, bool BFNLLLADIAA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DJGACNAABHP
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 CCOEDOIODMG
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 NOCJNDBDOAC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBJAEJPGKCB(COAHBFHINFJ EOBFGLJBCIJ, object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BJDINJFLCGP(object HMAOAMDKNDD);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface MKIPBOEDJDF
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 HHPIFJCOOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 GGIEIBKNPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float PADHGHJLJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float EAKNKCMIHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 HDCBDKOIDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion PNOHMMCCAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event IDBANGEEFOC EMALNHCGFCO;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GFJEIFADKDP();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OGAPPILJDFN();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NHEHBCMANCA();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KPJHAKFGFBB(Rigidbody ACKBNFBBKOA);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LCMOCMNDGKD(Rigidbody ACKBNFBBKOA);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CCBHJNAJCPF();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface IKEFBCLFODA
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool CCBOLEPEIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	INDOICOKDMJ AJLEGAJMBED
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HNIBDJMDFAL();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NAPJGOOENPP(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJLMLLFFDMC(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NJEDOOPKMBA(COAHBFHINFJ PALOPBGAJFN);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CHHKBIKAIGD(COAHBFHINFJ PALOPBGAJFN);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MDMJKJBLKHN();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface OBINMAACDBO
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool LKJAOHPJMHA
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	IEnumerable<object> FBHCFIEFDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event IDBANGEEFOC MGPMICPPGPB;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDHBMAEMFGJ(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BILHHPDCDKM(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DCKOMBAMFDF(object HMAOAMDKNDD, bool OHANDDCLMMH);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable GLHGEKDKPPE();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KPJHAKFGFBB(Rigidbody LHAKPCGHEAG);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LCMOCMNDGKD(Rigidbody ACKBNFBBKOA);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface MAIEJCNIIBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool PNPAICFFMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool EJPMOLMBFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event IDBANGEEFOC HEBMBPDHBHK;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HNIBDJMDFAL();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NAJOGAHKIEE(COAHBFHINFJ EOBFGLJBCIJ);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DKLKECNJIAP(COAHBFHINFJ EOBFGLJBCIJ);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PKJGDCALGBM
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool MNBOPCHPOPL
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool GLGCOGBLPJC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	RigidbodyConstraints LBIHCKGJNDJ
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
	void KPJHAKFGFBB(Rigidbody ACKBNFBBKOA);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LCMOCMNDGKD(Rigidbody ACKBNFBBKOA);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BHMIPOFDPEF
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float DKMCCCEGGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float DNJAHBCJABP
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
	void KPJHAKFGFBB(Rigidbody ACKBNFBBKOA);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LCMOCMNDGKD(Rigidbody ACKBNFBBKOA);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MKEKABGMAFE
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx DIEJJCKFNHL);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface LEABOMDCKNB
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event IDBANGEEFOC EAJDOHBLDEM;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HNIBDJMDFAL();

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BIOLEFGLELD();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GEFJBHOINKA();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FKCCMPCDICG();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KLEAIMMHIMM();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NEBOODLLBAL();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EHAEKEPECIJ(bool CCNCEDMACNP);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FLBBEGCCDPK
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Rigidbody OMLJJMOAGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HNIBDJMDFAL();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MDJKOOAEJGP(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JNAKANEBFGD(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ODDJBGMPAHE();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JLPFPMGKIGF();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ANOJPKEOEOJ();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HFEDMBGBACP();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface IJCAKKDCEJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	OAAJJMEKKCO FOHFKKLNCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	NGGEJBJJIOA ONFHFHJINDD
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 MBKHAGELNKC
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 PNMFHCHJLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	Vector3 MKCBJFMHIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Vector3 CLGPPIAECCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float JBJNCHGJKNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool EMAEPLLIHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void HNIBDJMDFAL();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OFEAGCJBKIE(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EHGOOBAPJML(ELMJFFPDDAN KLDJNIPILLN, Vector3 BCFGIAPFKKB, float OKLEEHKJJBA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CPBCIKEJEFA(KDLFENIMCAA NALNFBLFJEL, Vector3 ACKJBHOBHDH, float MEEIIJPJJBC, float JHBPAKGIBHB = 8f, float LJLGEELHOJE = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void NMKJNOACPKB(ELMJFFPDDAN KLDJNIPILLN, Vector3 FDBNIAOOEMB, float HBOOAGHCBND = 7f, float BKMDHMBHOBP = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JGDGGMLOEEF();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void JOPHKGJJEHF();

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IODHOHMNIGM();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void DOGPHMJJOMI();

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KPJHAKFGFBB(Rigidbody ACKBNFBBKOA);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 JMCMOBNNEMD(Vector3 LOMDGDKPDKD);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 EKHCFAGKJAA(Vector3 PBLNDACCBGI);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void JHLGMNKNLCL(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void BKNOFAAHKIP(Vector3 NBKMOPIFBBP);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void BIPMBCHIBJM(Vector3 JJEOGAGCOIH, Vector3 OBAPNEEPMPN);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IKHGBFBJDEA(Vector3 GMNCBDPBBLL, Vector3 CAEAHDMGPBP);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 AFLKIDCHEPD(Vector3 NKKNGNHELCP);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 BKPNHLFHBLJ(Vector3 GELONNAFHPN);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[POJCHFKPLOJ(PFPBFPDNLIO.Application)]
public interface PNBBKMEKBPB
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool MNHECLJOIEH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFFPIOKOEML(string MCCDEFDHGFH);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FCNIDIECIMK(RigidbodyEx PALOPBGAJFN, Action DJJNLDOINEG);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EIJNDDCMLGM LJPHINKBKDJ(int FGPNDDNFJOA);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JCCJMEOGJOB(Vector3 DLAONILBDIM, float HHLKEPPBBCO, Color CPPINAHFMCO);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[POJCHFKPLOJ(PFPBFPDNLIO.Application)]
public interface GMOFJHOBHHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	PNBBKMEKBPB CNLJCAAJBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	BDGACHFDAAD FIOAJCDLGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool GLBBMDKAEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GEEJJFIMDNA CIPMKCCBHCB(RigidbodyEx PALOPBGAJFN);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "4")]
	COAHBFHINFJ AHDJIEGMHLB(RigidbodyEx PALOPBGAJFN, OFBIGENLNDL MNILNHMNKJK);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PFJCLAFPKOE();

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KKMAKIBOCNA();

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal RigidbodyEx NFOLGGBIOOH(GameObject LNBPLDMMKPA, [Optional] OFBIGENLNDL MNILNHMNKJK);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface NGGEJBJJIOA
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKFGHOPEJEO(Vector3 DFCBOFEIGJP);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJLNPICKPDO(Vector3 LOMDGDKPDKD);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FNCMHENGFPA(Vector3 DFCBOFEIGJP);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BJBGGFJAJAP(Vector3 LOMDGDKPDKD);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface OAAJJMEKKCO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 JCKHGMFFHBP();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 DHOHLCHHEGL();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface COAHBFHINFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Rigidbody OMLJJMOAGEL
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	RigidbodyEx BJOMECCDLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	GameObject KLFJADJOODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Transform CCKPELKPNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IEnumerable<object> MOJELOMFNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	COAHBFHINFJ NLJMPCEPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	IReadOnlyList<COAHBFHINFJ> PLEEMIOGEJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	COAHBFHINFJ ADLFAHHCAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool APDKJKFGMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool PNPAICFFMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool EJPMOLMBFPC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	OAAJJMEKKCO FOHFKKLNCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	NGGEJBJJIOA ONFHFHJINDD
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	float JBJNCHGJKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 PNMFHCHJLKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 CLGPPIAECCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 MBKHAGELNKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 MKCBJFMHIAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool EBNPMBHCAAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool ODAILKPDPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool DLMFFEBHFDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool EMAEPLLIHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 CCOEDOIODMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 NOCJNDBDOAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 HHPIFJCOOGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 GGIEIBKNPGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float PADHGHJLJDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float EAKNKCMIHOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 HDCBDKOIDPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Quaternion PNOHMMCCAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float DKMCCCEGGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float DNJAHBCJABP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool OBCEOAKDHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "47")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	AIFDGFHGOFL KPFOHJHFIIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool LKJAOHPJMHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Transform NFIHBIKGJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Transform MANILMNCAOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 FCOKJGLMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float NFBPMPNKKEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float JLDIPJBLGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "58")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion GNHNFAGLCOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "60")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 ICHCLDFIPAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Quaternion MKBNFPHEILA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "64")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	RigidbodyConstraints LBIHCKGJNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "66")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool MNBOPCHPOPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CollisionDetectionMode ONKHAABGHFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "70")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool FKIBJJIHGPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event IDBANGEEFOC FHNMFLEGKLF;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event IDBANGEEFOC KACABKHKGJH;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event BMBDIJCKKFM NDCGJGKOFAI;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event IDBANGEEFOC HEBMBPDHBHK;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event IDBANGEEFOC OGFKCFDDFAD;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event IDBANGEEFOC EAJDOHBLDEM;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<IJJPEDCHMLC, IJJPEDCHMLC> HMNEDFGDGIP;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event IDBANGEEFOC IHOMKKFKAKF;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event IDBANGEEFOC BAOOFNJOHJA;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void HNIBDJMDFAL();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void IMNIDIOEADF();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void CGIDAOFPDGN();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void FKCCMPCDICG();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void APHKPGCLALM();

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void CLOBJFNMHGM(COAHBFHINFJ MFBGAMJDOKA, bool BFNLLLADIAA = false);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void OLOAAEPFOPK(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void NMNBFMLLAFC(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 BKPNHLFHBLJ(Vector3 GELONNAFHPN);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "89")]
	Vector3 AFLKIDCHEPD(Vector3 NKKNGNHELCP);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void DOGPHMJJOMI();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void JOPHKGJJEHF();

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void JGDGGMLOEEF();

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void IKHGBFBJDEA(Vector3 GMNCBDPBBLL, Vector3 CAEAHDMGPBP);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void BIPMBCHIBJM(Vector3 JJEOGAGCOIH, Vector3 OBAPNEEPMPN);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void BKNOFAAHKIP(Vector3 NBKMOPIFBBP);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void CPBCIKEJEFA(KDLFENIMCAA NALNFBLFJEL, Vector3 ACKJBHOBHDH, float MEEIIJPJJBC, float JHBPAKGIBHB = 8f, float LJLGEELHOJE = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void EHGOOBAPJML(ELMJFFPDDAN KLDJNIPILLN, Vector3 BCFGIAPFKKB, float OKLEEHKJJBA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void NMKJNOACPKB(ELMJFFPDDAN KLDJNIPILLN, Vector3 FDBNIAOOEMB, float HBOOAGHCBND = 7f, float BKMDHMBHOBP = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 EKHCFAGKJAA(Vector3 MFBGAMJDOKA);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "100")]
	Vector3 JMCMOBNNEMD(Vector3 MFBGAMJDOKA);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void IODHOHMNIGM();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void MEODIFCOIKA(COAHBFHINFJ IGEMLIBMGHF, object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void LMNFLAJGKLI(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void OGAPPILJDFN();

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void GFJEIFADKDP();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void NHEHBCMANCA();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "111")]
	bool BIOLEFGLELD();

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void NEBOODLLBAL();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "117")]
	IDisposable GLHGEKDKPPE();

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void FDHBMAEMFGJ(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void BILHHPDCDKM(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void DCKOMBAMFDF(object HMAOAMDKNDD, bool OHANDDCLMMH);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void FLHCNGPMALE(Vector3 JJJOPGOLMFH, Quaternion KLBIBNCNCIH);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void KMHOJILANDC(Vector3 ONKHKGGGDFH, Quaternion DHKLEPIAPPN);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "125")]
	bool EBHINPAMFNL(float HEPLPCOEDGD);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void KJNEBLODDHI(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void HDOBEGGHCGG(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void MDJKOOAEJGP(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void JNAKANEBFGD(object HMAOAMDKNDD);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void EEEMGOCGBED(Vector3 BFIMHHIKINE, ForceMode PFMKMOIPPCD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void PEICNGFMEKD(Vector3 BFIMHHIKINE, Vector3 LHCEFCJDGIJ, ForceMode PFMKMOIPPCD);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void HMDGDDGCCFL(Vector3 PIPIGKBLIGD, ForceMode PFMKMOIPPCD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void GEHIBBCOGKG(Vector3 PIPIGKBLIGD, ForceMode PFMKMOIPPCD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool CEHDPNMJOLM(Vector3 GNIANLFIOCO, out RaycastHit ANGKOJNCMIA, float AGKAIFMKLLP);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void CCBHJNAJCPF();

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class HIFMFONNJJL : COAHBFHINFJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly GMOFJHOBHHJ KONLJOKGCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal KEPEBEIEONO ILCFADBMBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal IKEFBCLFODA GCANBMDDBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal MAIEJCNIIBN PADNNEGLENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal IJCAKKDCEJD PBLNDACCBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal DJGACNAABHP GBMCMAJGJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal MKIPBOEDJDF GBOPHEMMLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal BHMIPOFDPEF BAENANGEKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal EGJGFBDNEPH CPPKFNLFEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal LEABOMDCKNB CKKDDGDCEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal IHEBEOFGNMA ABMGEKKNOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal OBINMAACDBO NCCJPJKFDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal ALMDAKNNCFI BFIMHHIKINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal PKJGDCALGBM GJPGENNHOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal FLBBEGCCDPK ACKBNFBBKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal OLPBGKDBBKJ LGMCPDDNPDD;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public RigidbodyEx BJOMECCDLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7D5630", Offset = "0x7D4030", VA = "0x1807D5630", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7DABF0", Offset = "0x7D95F0", VA = "0x1807DABF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GameObject KLFJADJOODK
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7D6740", Offset = "0x7D5140", VA = "0x1807D6740", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B70", Offset = "0x7D6570", VA = "0x1807D7B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Transform CCKPELKPNKA
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1690", Offset = "0x5AD0090", VA = "0x185AD1690", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEnumerable<object> MOJELOMFNEL
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2C80", Offset = "0x5AD1680", VA = "0x185AD2C80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Rigidbody OMLJJMOAGEL
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1DB0", Offset = "0x5AD07B0", VA = "0x185AD1DB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public COAHBFHINFJ NLJMPCEPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x5AD12D0", Offset = "0x5ACFCD0", VA = "0x185AD12D0", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1AB0", Offset = "0x5AD04B0", VA = "0x185AD1AB0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public IReadOnlyList<COAHBFHINFJ> PLEEMIOGEJD
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5AD48B0", Offset = "0x5AD32B0", VA = "0x185AD48B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public COAHBFHINFJ ADLFAHHCAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3200", Offset = "0x5AD1C00", VA = "0x185AD3200", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool APDKJKFGMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x5AD4F50", Offset = "0x5AD3950", VA = "0x185AD4F50", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool PNPAICFFMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5AD56F0", Offset = "0x5AD40F0", VA = "0x185AD56F0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool EJPMOLMBFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1640", Offset = "0x5AD0040", VA = "0x185AD1640", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public OAAJJMEKKCO FOHFKKLNCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3BB0", Offset = "0x5AD25B0", VA = "0x185AD3BB0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5CD0", Offset = "0x5AD46D0", VA = "0x185AD5CD0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public NGGEJBJJIOA ONFHFHJINDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5C80", Offset = "0x5AD4680", VA = "0x185AD5C80", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5080", Offset = "0x5AD3A80", VA = "0x185AD5080", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public float JBJNCHGJKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0E80", Offset = "0x5ACF880", VA = "0x185AD0E80", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3C00", Offset = "0x5AD2600", VA = "0x185AD3C00", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 PNMFHCHJLKD
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2BB0", Offset = "0x5AD15B0", VA = "0x185AD2BB0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x5AD4610", Offset = "0x5AD3010", VA = "0x185AD4610", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 CLGPPIAECCK
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5930", Offset = "0x5AD4330", VA = "0x185AD5930", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x5AD46E0", Offset = "0x5AD30E0", VA = "0x185AD46E0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 MBKHAGELNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5AD4A90", Offset = "0x5AD3490", VA = "0x185AD4A90", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0250", Offset = "0x5ACEC50", VA = "0x185AD0250", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 MKCBJFMHIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2DA0", Offset = "0x5AD17A0", VA = "0x185AD2DA0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5AD4FB0", Offset = "0x5AD39B0", VA = "0x185AD4FB0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool EBNPMBHCAAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5AD36A0", Offset = "0x5AD20A0", VA = "0x185AD36A0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool ODAILKPDPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1C80", Offset = "0x5AD0680", VA = "0x185AD1C80", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool DLMFFEBHFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3740", Offset = "0x5AD2140", VA = "0x185AD3740", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool EMAEPLLIHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x5AD01A0", Offset = "0x5ACEBA0", VA = "0x185AD01A0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Vector3 CCOEDOIODMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3250", Offset = "0x5AD1C50", VA = "0x185AD3250", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 NOCJNDBDOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5250", Offset = "0x5AD3C50", VA = "0x185AD5250", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Vector3 HHPIFJCOOGE
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0480", Offset = "0x5ACEE80", VA = "0x185AD0480", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0850", Offset = "0x5ACF250", VA = "0x185AD0850", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 GGIEIBKNPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2100", Offset = "0x5AD0B00", VA = "0x185AD2100", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float PADHGHJLJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1CE0", Offset = "0x5AD06E0", VA = "0x185AD1CE0", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float EAKNKCMIHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2560", Offset = "0x5AD0F60", VA = "0x185AD2560", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2E70", Offset = "0x5AD1870", VA = "0x185AD2E70", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Vector3 HDCBDKOIDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2980", Offset = "0x5AD1380", VA = "0x185AD2980", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5A40", Offset = "0x5AD4440", VA = "0x185AD5A40", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion PNOHMMCCAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5AD00D0", Offset = "0x5ACEAD0", VA = "0x185AD00D0", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5AD4120", Offset = "0x5AD2B20", VA = "0x185AD4120", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float DKMCCCEGGBH
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1280", Offset = "0x5ACFC80", VA = "0x185AD1280", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2610", Offset = "0x5AD1010", VA = "0x185AD2610", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public float DNJAHBCJABP
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5AD36F0", Offset = "0x5AD20F0", VA = "0x185AD36F0", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x5AD26C0", Offset = "0x5AD10C0", VA = "0x185AD26C0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool OBCEOAKDHMN
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0ED0", Offset = "0x5ACF8D0", VA = "0x185AD0ED0", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x5AD20A0", Offset = "0x5AD0AA0", VA = "0x185AD20A0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public AIFDGFHGOFL KPFOHJHFIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2720", Offset = "0x5AD1120", VA = "0x185AD2720", Slot = "52")]
		get
		{
			return default(AIFDGFHGOFL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x5ACFE60", Offset = "0x5ACE860", VA = "0x185ACFE60", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool LKJAOHPJMHA
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0380", Offset = "0x5ACED80", VA = "0x185AD0380", Slot = "54")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Transform NFIHBIKGJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3420", Offset = "0x5AD1E20", VA = "0x185AD3420", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public Transform MANILMNCAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3420", Offset = "0x5AD1E20", VA = "0x185AD3420", Slot = "56")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Vector3 FCOKJGLMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2B00", Offset = "0x5AD1500", VA = "0x185AD2B00", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5AD10B0", Offset = "0x5ACFAB0", VA = "0x185AD10B0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public float NFBPMPNKKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1570", Offset = "0x5ACFF70", VA = "0x185AD1570", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5320", Offset = "0x5AD3D20", VA = "0x185AD5320", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public float JLDIPJBLGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x5AD54C0", Offset = "0x5AD3EC0", VA = "0x185AD54C0", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x5AD42B0", Offset = "0x5AD2CB0", VA = "0x185AD42B0", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Quaternion GNHNFAGLCOE
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3B00", Offset = "0x5AD2500", VA = "0x185AD3B00", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0620", Offset = "0x5ACF020", VA = "0x185AD0620", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 ICHCLDFIPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2AB0", Offset = "0x5AD14B0", VA = "0x185AD2AB0", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3430", Offset = "0x5AD1E30", VA = "0x185AD3430", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Quaternion MKBNFPHEILA
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1860", Offset = "0x5AD0260", VA = "0x185AD1860", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5A00", Offset = "0x5AD4400", VA = "0x185AD5A00", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public RigidbodyConstraints LBIHCKGJNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5420", Offset = "0x5AD3E20", VA = "0x185AD5420", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5AD18A0", Offset = "0x5AD02A0", VA = "0x185AD18A0", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool MNBOPCHPOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5AD47B0", Offset = "0x5AD31B0", VA = "0x185AD47B0", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0320", Offset = "0x5ACED20", VA = "0x185AD0320", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CollisionDetectionMode ONKHAABGHFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x5AD4860", Offset = "0x5AD3260", VA = "0x185AD4860", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5C20", Offset = "0x5AD4620", VA = "0x185AD5C20", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool FKIBJJIHGPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x5AD0F70", Offset = "0x5ACF970", VA = "0x185AD0F70", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event IDBANGEEFOC FHNMFLEGKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5AD2A50", Offset = "0x5AD1450", VA = "0x185AD2A50", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5D30", Offset = "0x5AD4730", VA = "0x185AD5D30", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event IDBANGEEFOC KACABKHKGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5AD13F0", Offset = "0x5ACFDF0", VA = "0x185AD13F0", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x5ACFF80", Offset = "0x5ACE980", VA = "0x185ACFF80", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event BMBDIJCKKFM NDCGJGKOFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x5ACFF20", Offset = "0x5ACE920", VA = "0x185ACFF20", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x5AD25B0", Offset = "0x5AD0FB0", VA = "0x185AD25B0", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event IDBANGEEFOC HEBMBPDHBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3D50", Offset = "0x5AD2750", VA = "0x185AD3D50", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x5AD01F0", Offset = "0x5ACEBF0", VA = "0x185AD01F0", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event IDBANGEEFOC OGFKCFDDFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x5AD4900", Offset = "0x5AD3300", VA = "0x185AD4900", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x5AD4C60", Offset = "0x5AD3660", VA = "0x185AD4C60", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event IDBANGEEFOC EAJDOHBLDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1720", Offset = "0x5AD0120", VA = "0x185AD1720", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1320", Offset = "0x5ACFD20", VA = "0x185AD1320", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<IJJPEDCHMLC, IJJPEDCHMLC> HMNEDFGDGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x5AD41F0", Offset = "0x5AD2BF0", VA = "0x185AD41F0", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3480", Offset = "0x5AD1E80", VA = "0x185AD3480", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event IDBANGEEFOC IHOMKKFKAKF
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1A00", Offset = "0x5AD0400", VA = "0x185AD1A00", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x5AD4C00", Offset = "0x5AD3600", VA = "0x185AD4C00", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event IDBANGEEFOC BAOOFNJOHJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5AD4B60", Offset = "0x5AD3560", VA = "0x185AD4B60", Slot = "125")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5AD3320", Offset = "0x5AD1D20", VA = "0x185AD3320", Slot = "126")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5E80", Offset = "0x5AD4880", VA = "0x185AD5E80")]
	public HIFMFONNJJL(GameObject OJBDJCCAFCN, RigidbodyEx IHKHHDDLICA, GMOFJHOBHHJ KONLJOKGCCN, in OFBIGENLNDL MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5AD2ED0", Offset = "0x5AD18D0", VA = "0x185AD2ED0", Slot = "142")]
	protected virtual void GLAJCKEHOLG(GMOFJHOBHHJ KONLJOKGCCN, OFBIGENLNDL MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1B10", Offset = "0x5AD0510", VA = "0x185AD1B10", Slot = "143")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3560", Offset = "0x5AD1F60", VA = "0x185AD3560", Slot = "76")]
	public void HNIBDJMDFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1A60", Offset = "0x5AD0460", VA = "0x185AD1A60", Slot = "77")]
	public void IMNIDIOEADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1260", Offset = "0x5ACFC60", VA = "0x185AD1260", Slot = "78")]
	public void CGIDAOFPDGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x5AD03D0", Offset = "0x5ACEDD0", VA = "0x185AD03D0", Slot = "144")]
	public virtual void APHKPGCLALM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1380", Offset = "0x5ACFD80", VA = "0x185AD1380", Slot = "87")]
	public void CLOBJFNMHGM(COAHBFHINFJ MFBGAMJDOKA, bool BFNLLLADIAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5690", Offset = "0x5AD4090", VA = "0x185AD5690", Slot = "90")]
	public void OLOAAEPFOPK(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5AD51F0", Offset = "0x5AD3BF0", VA = "0x185AD51F0", Slot = "91")]
	public void NMNBFMLLAFC(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x5AD09F0", Offset = "0x5ACF3F0", VA = "0x185AD09F0", Slot = "92")]
	public Vector3 BKPNHLFHBLJ(Vector3 GELONNAFHPN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x5ACFFE0", Offset = "0x5ACE9E0", VA = "0x185ACFFE0", Slot = "93")]
	public Vector3 AFLKIDCHEPD(Vector3 NKKNGNHELCP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1A60", Offset = "0x5AD0460", VA = "0x185AD1A60", Slot = "94")]
	public void DOGPHMJJOMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x5AD40D0", Offset = "0x5AD2AD0", VA = "0x185AD40D0", Slot = "95")]
	public void JOPHKGJJEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3E00", Offset = "0x5AD2800", VA = "0x185AD3E00", Slot = "96")]
	public void JGDGGMLOEEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3C60", Offset = "0x5AD2660", VA = "0x185AD3C60", Slot = "97")]
	public void IKHGBFBJDEA(Vector3 GMNCBDPBBLL, Vector3 CAEAHDMGPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x5AD0760", Offset = "0x5ACF160", VA = "0x185AD0760", Slot = "98")]
	public void BIPMBCHIBJM(Vector3 JJEOGAGCOIH, Vector3 OBAPNEEPMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x5AD0920", Offset = "0x5ACF320", VA = "0x185AD0920", Slot = "99")]
	public void BKNOFAAHKIP(Vector3 NBKMOPIFBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1450", Offset = "0x5ACFE50", VA = "0x185AD1450", Slot = "100")]
	public void CPBCIKEJEFA(KDLFENIMCAA NALNFBLFJEL, Vector3 ACKJBHOBHDH, float MEEIIJPJJBC, float JHBPAKGIBHB = 8f, float LJLGEELHOJE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1E00", Offset = "0x5AD0800", VA = "0x185AD1E00", Slot = "101")]
	public void EHGOOBAPJML(ELMJFFPDDAN KLDJNIPILLN, Vector3 BCFGIAPFKKB, float OKLEEHKJJBA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x5AD50E0", Offset = "0x5AD3AE0", VA = "0x185AD50E0", Slot = "102")]
	[Obsolete]
	public void NMKJNOACPKB(ELMJFFPDDAN KLDJNIPILLN, Vector3 FDBNIAOOEMB, float HBOOAGHCBND = 7f, float BKMDHMBHOBP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1F00", Offset = "0x5AD0900", VA = "0x185AD1F00", Slot = "103")]
	public Vector3 EKHCFAGKJAA(Vector3 MFBGAMJDOKA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3F80", Offset = "0x5AD2980", VA = "0x185AD3F80", Slot = "104")]
	public Vector3 JMCMOBNNEMD(Vector3 MFBGAMJDOKA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3DB0", Offset = "0x5AD27B0", VA = "0x185AD3DB0", Slot = "105")]
	public void IODHOHMNIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x5AD49C0", Offset = "0x5AD33C0", VA = "0x185AD49C0", Slot = "106")]
	public void MEODIFCOIKA(COAHBFHINFJ IGEMLIBMGHF, object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x5AD4800", Offset = "0x5AD3200", VA = "0x185AD4800", Slot = "107")]
	public void LMNFLAJGKLI(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5470", Offset = "0x5AD3E70", VA = "0x185AD5470", Slot = "110")]
	public void OGAPPILJDFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x5AD2D50", Offset = "0x5AD1750", VA = "0x185AD2D50", Slot = "111")]
	public void GFJEIFADKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x5AD4F00", Offset = "0x5AD3900", VA = "0x185AD4F00", Slot = "112")]
	public void NHEHBCMANCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x5AD0710", Offset = "0x5ACF110", VA = "0x185AD0710", Slot = "115")]
	public bool BIOLEFGLELD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x5AD2670", Offset = "0x5AD1070", VA = "0x185AD2670", Slot = "79")]
	public void FKCCMPCDICG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x5AD4EB0", Offset = "0x5AD38B0", VA = "0x185AD4EB0", Slot = "116")]
	public void NEBOODLLBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5AD31B0", Offset = "0x5AD1BB0", VA = "0x185AD31B0", Slot = "121")]
	public IDisposable GLHGEKDKPPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD2500", Offset = "0x5AD0F00", VA = "0x185AD2500", Slot = "122")]
	public void FDHBMAEMFGJ(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x5AD06B0", Offset = "0x5ACF0B0", VA = "0x185AD06B0", Slot = "123")]
	public void BILHHPDCDKM(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x5AD15D0", Offset = "0x5ACFFD0", VA = "0x185AD15D0", Slot = "124")]
	public void DCKOMBAMFDF(object HMAOAMDKNDD, bool OHANDDCLMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x5AD2770", Offset = "0x5AD1170", VA = "0x185AD2770", Slot = "127")]
	public void FLHCNGPMALE(Vector3 JJJOPGOLMFH, Quaternion KLBIBNCNCIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5AD4460", Offset = "0x5AD2E60", VA = "0x185AD4460", Slot = "128")]
	public void KMHOJILANDC(Vector3 ONKHKGGGDFH, Quaternion DHKLEPIAPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1BE0", Offset = "0x5AD05E0", VA = "0x185AD1BE0", Slot = "129")]
	public bool EBHINPAMFNL(float HEPLPCOEDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x5AD4250", Offset = "0x5AD2C50", VA = "0x185AD4250", Slot = "130")]
	public void KJNEBLODDHI(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x5AD33C0", Offset = "0x5AD1DC0", VA = "0x185AD33C0", Slot = "131")]
	public void HDOBEGGHCGG(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5AD4960", Offset = "0x5AD3360", VA = "0x185AD4960", Slot = "132")]
	public void MDJKOOAEJGP(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x5AD4070", Offset = "0x5AD2A70", VA = "0x185AD4070", Slot = "133")]
	public void JNAKANEBFGD(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1D30", Offset = "0x5AD0730", VA = "0x185AD1D30", Slot = "134")]
	public void EEEMGOCGBED(Vector3 BFIMHHIKINE, ForceMode PFMKMOIPPCD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5B10", Offset = "0x5AD4510", VA = "0x185AD5B10", Slot = "135")]
	public void PEICNGFMEKD(Vector3 BFIMHHIKINE, Vector3 LHCEFCJDGIJ, ForceMode PFMKMOIPPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD34E0", Offset = "0x5AD1EE0", VA = "0x185AD34E0", Slot = "136")]
	public void HMDGDDGCCFL(Vector3 PIPIGKBLIGD, ForceMode PFMKMOIPPCD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5AD2CD0", Offset = "0x5AD16D0", VA = "0x185AD2CD0", Slot = "137")]
	public void GEHIBBCOGKG(Vector3 PIPIGKBLIGD, ForceMode PFMKMOIPPCD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1160", Offset = "0x5ACFB60", VA = "0x185AD1160", Slot = "138")]
	public bool CEHDPNMJOLM(Vector3 GNIANLFIOCO, out RaycastHit ANGKOJNCMIA, float AGKAIFMKLLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5AD0F20", Offset = "0x5ACF920", VA = "0x185AD0F20", Slot = "139")]
	public void CCBHJNAJCPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5E40", Offset = "0x5AD4840", VA = "0x185AD5E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x5AD0550", Offset = "0x5ACEF50", VA = "0x185AD0550")]
	private void BCEBNFOOHJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x5AD4CC0", Offset = "0x5AD36C0", VA = "0x185AD4CC0")]
	private void MNHCFNAALJB(COAHBFHINFJ EOBFGLJBCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5740", Offset = "0x5AD4140", VA = "0x185AD5740")]
	private void OOAPLAECOKJ(COAHBFHINFJ EOBFGLJBCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5D90", Offset = "0x5AD4790", VA = "0x185AD5D90")]
	private void POJIHPMIDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1900", Offset = "0x5AD0300", VA = "0x185AD1900")]
	private void DNNDAPPIDDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1FF0", Offset = "0x5AD09F0", VA = "0x185AD1FF0")]
	private void ENEKCOMAKID(COAHBFHINFJ ENLKANOCMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5AD4DD0", Offset = "0x5AD37D0", VA = "0x185AD4DD0")]
	private void NAJOGAHKIEE(COAHBFHINFJ EOBFGLJBCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x5AD1780", Offset = "0x5AD0180", VA = "0x185AD1780")]
	private void DKLKECNJIAP(COAHBFHINFJ EOBFGLJBCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5520", Offset = "0x5AD3F20", VA = "0x185AD5520")]
	private void OIJPJFIBAHP(RigidbodyEx EOBFGLJBCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x5AD0AE0", Offset = "0x5ACF4E0", VA = "0x185AD0AE0")]
	private void BMCONPMEPKH(RigidbodyEx PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3E50", Offset = "0x5AD2850", VA = "0x185AD3E50")]
	[Conditional("UNITY_EDITOR")]
	private void JLADBLDECDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5AD3820", Offset = "0x5AD2220", VA = "0x185AD3820")]
	protected void IGAEABNOEDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5AD21D0", Offset = "0x5AD0BD0", VA = "0x185AD21D0")]
	protected void FCIHNIOECII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class BIFBDONEEOC
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5AC3AB0", Offset = "0x5AC24B0", VA = "0x185AC3AB0")]
	public static COAHBFHINFJ POLHOCGDCHG(this COAHBFHINFJ PALOPBGAJFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5AC38F0", Offset = "0x5AC22F0", VA = "0x185AC38F0")]
	public static bool BGOJHODBJAA(this COAHBFHINFJ PALOPBGAJFN, COAHBFHINFJ OBMBIBGPNLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5AC3A30", Offset = "0x5AC2430", VA = "0x185AC3A30")]
	public static bool JEMHMACKPJA(this COAHBFHINFJ PALOPBGAJFN, COAHBFHINFJ NOKCDOJGIJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5AC3970", Offset = "0x5AC2370", VA = "0x185AC3970")]
	public static RigidbodyEx BJOMECCDLKE(this COAHBFHINFJ IKPFPMKENNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x5AC39C0", Offset = "0x5AC23C0", VA = "0x185AC39C0")]
	public static HIFMFONNJJL CCKDKHCGAFA(this COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class KFLPBOFLLMP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly HIFMFONNJJL PALOPBGAJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool ILMLECMLEKB;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5AE0BF0", Offset = "0x5ADF5F0", VA = "0x185AE0BF0")]
	public KFLPBOFLLMP(HIFMFONNJJL COAEKLAHGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5AE0B90", Offset = "0x5ADF590", VA = "0x185AE0B90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class HDLKEFNJFLK : HOEHMNAHADO, OLPBGKDBBKJ
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CollisionDetectionMode MAHKAEOFLEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x5ACFC30", Offset = "0x5ACE630", VA = "0x185ACFC30")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF880", Offset = "0x5ACE280", VA = "0x185ACF880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody OMLJJMOAGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF830", Offset = "0x5ACE230", VA = "0x185ACF830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CollisionDetectionMode ONKHAABGHFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5ACFB20", Offset = "0x5ACE520", VA = "0x185ACFB20", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5ACFD10", Offset = "0x5ACE710", VA = "0x185ACFD10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7900", Offset = "0x5AC6300", VA = "0x185AC7900")]
	public HDLKEFNJFLK(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5ACF970", Offset = "0x5ACE370", VA = "0x185ACF970", Slot = "6")]
	public void HNIBDJMDFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x5ACFA90", Offset = "0x5ACE490", VA = "0x185ACFA90", Slot = "9")]
	public void KPJHAKFGFBB(Rigidbody ACKBNFBBKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x5ACFA80", Offset = "0x5ACE480", VA = "0x185ACFA80", Slot = "7")]
	public void KAHCOLHEFIM(bool HOCNLDJLJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x5ACF4B0", Offset = "0x5ACDEB0", VA = "0x185ACF4B0", Slot = "8")]
	public void AGEBFPMMJEA(bool HOCNLDJLJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x5ACF6C0", Offset = "0x5ACE0C0", VA = "0x185ACF6C0", Slot = "10")]
	public bool CEHDPNMJOLM(Vector3 GNIANLFIOCO, out RaycastHit ANGKOJNCMIA, float AGKAIFMKLLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5ACF4C0", Offset = "0x5ACDEC0", VA = "0x185ACF4C0")]
	private void BPFLJKCIEBA(bool HOCNLDJLJMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class LICBFHCHNPJ : HOEHMNAHADO, IHEBEOFGNMA, IDisposable, KPFJBIMGOOA
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public AIFDGFHGOFL GMAOMLBAHEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5AE1DC0", Offset = "0x5AE07C0", VA = "0x185AE1DC0")]
		get
		{
			return default(AIFDGFHGOFL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x5AE1A10", Offset = "0x5AE0410", VA = "0x185AE1A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public AIFDGFHGOFL KPFOHJHFIIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x5AE1B00", Offset = "0x5AE0500", VA = "0x185AE1B00", Slot = "6")]
		get
		{
			return default(AIFDGFHGOFL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5AE1A10", Offset = "0x5AE0410", VA = "0x185AE1A10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private Transform EJMAHPBGPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<IJJPEDCHMLC, IJJPEDCHMLC> HMNEDFGDGIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x5AE1EA0", Offset = "0x5AE08A0", VA = "0x185AE1EA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x5AE1D20", Offset = "0x5AE0720", VA = "0x185AE1D20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7900", Offset = "0x5AC6300", VA = "0x185AC7900")]
	public LICBFHCHNPJ(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x5AE1F40", Offset = "0x5AE0940", VA = "0x185AE1F40", Slot = "11")]
	public void OnChangedDistanceBand(IJJPEDCHMLC GFPNEMALIHE, IJJPEDCHMLC JOOHHAMJDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "12")]
	public void OnChangedVisibility(bool OIIJGABMEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "8")]
	public void HNIBDJMDFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class NICHDFIHGDF : HOEHMNAHADO, ALMDAKNNCFI
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private Rigidbody OMLJJMOAGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF830", Offset = "0x5ACE230", VA = "0x185ACF830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool LKJAOHPJMHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x5AE0F00", Offset = "0x5ADF900", VA = "0x185AE0F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private bool APDKJKFGMHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x5AD7E10", Offset = "0x5AD6810", VA = "0x185AD7E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private COAHBFHINFJ NLJMPCEPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x5AE5EF0", Offset = "0x5AE48F0", VA = "0x185AE5EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7900", Offset = "0x5AC6300", VA = "0x185AC7900")]
	public NICHDFIHGDF(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5AE5F50", Offset = "0x5AE4950", VA = "0x185AE5F50", Slot = "4")]
	public void EEEMGOCGBED(Vector3 BFIMHHIKINE, ForceMode PFMKMOIPPCD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5AE5C70", Offset = "0x5AE4670", VA = "0x185AE5C70")]
	private void BKKFANPGBDN(Vector3 BFIMHHIKINE, ForceMode PFMKMOIPPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5AE6490", Offset = "0x5AE4E90", VA = "0x185AE6490", Slot = "5")]
	public void PEICNGFMEKD(Vector3 BFIMHHIKINE, Vector3 LHCEFCJDGIJ, ForceMode PFMKMOIPPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x5AE6330", Offset = "0x5AE4D30", VA = "0x185AE6330", Slot = "6")]
	public void HMDGDDGCCFL(Vector3 PIPIGKBLIGD, ForceMode PFMKMOIPPCD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x5AE59F0", Offset = "0x5AE43F0", VA = "0x185AE59F0")]
	private void ACLPJGIOPAH(Vector3 PIPIGKBLIGD, ForceMode PFMKMOIPPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x5AE60B0", Offset = "0x5AE4AB0", VA = "0x185AE60B0", Slot = "7")]
	public void GEHIBBCOGKG(Vector3 PIPIGKBLIGD, ForceMode PFMKMOIPPCD = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class ODBFFCHAENA : HOEHMNAHADO, EGJGFBDNEPH
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool OBCEOAKDHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x5AE73C0", Offset = "0x5AE5DC0", VA = "0x185AE73C0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x5AE74A0", Offset = "0x5AE5EA0", VA = "0x185AE74A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7900", Offset = "0x5AC6300", VA = "0x185AC7900")]
	public ODBFFCHAENA(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x5AE7680", Offset = "0x5AE6080", VA = "0x185AE7680", Slot = "6")]
	public void KPJHAKFGFBB(Rigidbody ACKBNFBBKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7000", Offset = "0x5AC5A00", VA = "0x185AC7000", Slot = "7")]
	public void LCMOCMNDGKD(Rigidbody ACKBNFBBKOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class PJOKEGPDABF : HOEHMNAHADO, KEPEBEIEONO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OFEDBOFDLJH GFIGBAPMFPP;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Transform CCKPELKPNKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x5AEC3F0", Offset = "0x5AEADF0", VA = "0x185AEC3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public GEEJJFIMDNA MJENILHPGED
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x5AECF00", Offset = "0x5AEB900", VA = "0x185AECF00")]
		get
		{
			return default(GEEJJFIMDNA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x5AED770", Offset = "0x5AEC170", VA = "0x185AED770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public COAHBFHINFJ NLJMPCEPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x5AEB900", Offset = "0x5AEA300", VA = "0x185AEB900", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x5AEC4C0", Offset = "0x5AEAEC0", VA = "0x185AEC4C0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public GEEJJFIMDNA EOMFGDMFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x5AED310", Offset = "0x5AEBD10", VA = "0x185AED310")]
		get
		{
			return default(GEEJJFIMDNA);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x5AECCC0", Offset = "0x5AEB6C0", VA = "0x185AECCC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public COAHBFHINFJ ADLFAHHCAGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x5AECB40", Offset = "0x5AEB540", VA = "0x185AECB40", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyList<COAHBFHINFJ> PLEEMIOGEJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x7D7060", Offset = "0x7D5A60", VA = "0x1807D7060", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event IDBANGEEFOC FHNMFLEGKLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x5AECA00", Offset = "0x5AEB400", VA = "0x185AECA00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x5AEDA30", Offset = "0x5AEC430", VA = "0x185AEDA30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event IDBANGEEFOC KACABKHKGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x5AEBAD0", Offset = "0x5AEA4D0", VA = "0x185AEBAD0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x5AEB590", Offset = "0x5AE9F90", VA = "0x185AEB590", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event BMBDIJCKKFM NDCGJGKOFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x5AEB4F0", Offset = "0x5AE9EF0", VA = "0x185AEB4F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x5AEC700", Offset = "0x5AEB100", VA = "0x185AEC700", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action JGBCBBLECPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x5AECC20", Offset = "0x5AEB620", VA = "0x185AECC20", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x5AECDC0", Offset = "0x5AEB7C0", VA = "0x185AECDC0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action PLFEODELMBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x5AED140", Offset = "0x5AEBB40", VA = "0x185AED140", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x5AECAA0", Offset = "0x5AEB4A0", VA = "0x185AECAA0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<COAHBFHINFJ> LCFBPJEOADK
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x5AEDAD0", Offset = "0x5AEC4D0", VA = "0x185AEDAD0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x5AECB80", Offset = "0x5AEB580", VA = "0x185AECB80", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<COAHBFHINFJ> OCAKJFLNEGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x5AEB940", Offset = "0x5AEA340", VA = "0x185AEB940", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5AEB630", Offset = "0x5AEA030", VA = "0x185AEB630", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action MGCEPPELIDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5AED000", Offset = "0x5AEBA00", VA = "0x185AED000", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x5AEC420", Offset = "0x5AEAE20", VA = "0x185AEC420", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<COAHBFHINFJ> CIILGHHGBIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x5AED0A0", Offset = "0x5AEBAA0", VA = "0x185AED0A0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x5AECE60", Offset = "0x5AEB860", VA = "0x185AECE60", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5AEDB70", Offset = "0x5AEC570", VA = "0x185AEDB70")]
	public PJOKEGPDABF(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5AEC530", Offset = "0x5AEAF30", VA = "0x185AEC530", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB9E0", Offset = "0x5AEA3E0", VA = "0x185AEB9E0", Slot = "26")]
	public void CLOBJFNMHGM(COAHBFHINFJ KLJNAJJPMKN, bool BFNLLLADIAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5AEBA60", Offset = "0x5AEA460", VA = "0x185AEBA60")]
	private void CLOBJFNMHGM(NFBCNBGCJMF KLJNAJJPMKN, bool BFNLLLADIAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5AEBB70", Offset = "0x5AEA570", VA = "0x185AEBB70")]
	private void COJNMLKIGOH(NFBCNBGCJMF KLJNAJJPMKN, bool BFNLLLADIAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5AED870", Offset = "0x5AEC270", VA = "0x185AED870")]
	private void PJDPLBPDOJA(NFBCNBGCJMF ENLKANOCMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5AED5B0", Offset = "0x5AEBFB0", VA = "0x185AED5B0")]
	private void NMMGJMPGKPK(NFBCNBGCJMF ENLKANOCMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5AED410", Offset = "0x5AEBE10", VA = "0x185AED410")]
	private void NJNBDEOPBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x5AED290", Offset = "0x5AEBC90", VA = "0x185AED290")]
	private void NBAEKPGOBNP(NFBCNBGCJMF ENLKANOCMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5AED1E0", Offset = "0x5AEBBE0", VA = "0x185AED1E0")]
	private void LPJKPCAALCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x5AEC7A0", Offset = "0x5AEB1A0", VA = "0x185AEC7A0")]
	private void FMAGMBLFOAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB7D0", Offset = "0x5AEA1D0", VA = "0x185AEB7D0")]
	private void BMKFLEEHJJC(NFBCNBGCJMF PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x5AEC8D0", Offset = "0x5AEB2D0", VA = "0x185AEC8D0")]
	private void FMALHNNINDF(NFBCNBGCJMF PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB6D0", Offset = "0x5AEA0D0", VA = "0x185AEB6D0")]
	[CompilerGenerated]
	private object BGIOMLMPIHE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class FJPPOPEIMOL
{
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x5ACC4D0", Offset = "0x5ACAED0", VA = "0x185ACC4D0")]
	public static PJOKEGPDABF HHNHIPIOBHC(this COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class OFDOEJLNIIC : HOEHMNAHADO, DJGACNAABHP
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public Vector3 CCOEDOIODMG
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x5AE7DC0", Offset = "0x5AE67C0", VA = "0x185AE7DC0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public Vector3 NOCJNDBDOAC
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x5AE7ED0", Offset = "0x5AE68D0", VA = "0x185AE7ED0", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	private Vector3 MBKHAGELNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x5AE7DF0", Offset = "0x5AE67F0", VA = "0x185AE7DF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private COAHBFHINFJ FBFJBKHAAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x5AE7C60", Offset = "0x5AE6660", VA = "0x185AE7C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7900", Offset = "0x5AC6300", VA = "0x185AC7900")]
	public OFDOEJLNIIC(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x5AE8240", Offset = "0x5AE6C40", VA = "0x185AE8240", Slot = "6")]
	public void PBJAEJPGKCB(COAHBFHINFJ EOBFGLJBCIJ, object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x5AE8110", Offset = "0x5AE6B10", VA = "0x185AE8110")]
	private void PBJAEJPGKCB(NFBCNBGCJMF EOBFGLJBCIJ, object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5AE7780", Offset = "0x5AE6180", VA = "0x185AE7780", Slot = "7")]
	public void BJDINJFLCGP(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x5AE7870", Offset = "0x5AE6270", VA = "0x185AE7870")]
	private Vector3 CHFOAJPHIFB()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class PDKJLBMBBKD
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB460", Offset = "0x5AE9E60", VA = "0x185AEB460")]
	public static OFDOEJLNIIC GMIFEAAGMNB(this COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class JIADDBKOKDG : HOEHMNAHADO, MKIPBOEDJDF
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 HHPIFJCOOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x5AD9E50", Offset = "0x5AD8850", VA = "0x185AD9E50", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x5ADA480", Offset = "0x5AD8E80", VA = "0x185ADA480", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 GGIEIBKNPGB
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x5ADBE90", Offset = "0x5ADA890", VA = "0x185ADBE90", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public float PADHGHJLJDM
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x5ADBD10", Offset = "0x5ADA710", VA = "0x185ADBD10", Slot = "9")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x5ADCF10", Offset = "0x5ADB910", VA = "0x185ADCF10")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float EAKNKCMIHOB
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x5ADBFB0", Offset = "0x5ADA9B0", VA = "0x185ADBFB0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x5ADC8A0", Offset = "0x5ADB2A0", VA = "0x185ADC8A0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public Vector3 HDCBDKOIDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x5ADC4F0", Offset = "0x5ADAEF0", VA = "0x185ADC4F0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x5ADD3D0", Offset = "0x5ADBDD0", VA = "0x185ADD3D0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Quaternion PNOHMMCCAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x5AD9E20", Offset = "0x5AD8820", VA = "0x185AD9E20", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x5ADC950", Offset = "0x5ADB350", VA = "0x185ADC950", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private Rigidbody OMLJJMOAGEL
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF830", Offset = "0x5ACE230", VA = "0x185ACF830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event IDBANGEEFOC EMALNHCGFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x5ADC8B0", Offset = "0x5ADB2B0", VA = "0x185ADC8B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x5ADBDF0", Offset = "0x5ADA7F0", VA = "0x185ADBDF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5ADD440", Offset = "0x5ADBE40", VA = "0x185ADD440")]
	public JIADDBKOKDG(COAHBFHINFJ PALOPBGAJFN, in OFBIGENLNDL MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5ADD000", Offset = "0x5ADBA00", VA = "0x185ADD000", Slot = "17")]
	public void OGAPPILJDFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x5ADC520", Offset = "0x5ADAF20", VA = "0x185ADC520", Slot = "16")]
	public void GFJEIFADKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x5ADC970", Offset = "0x5ADB370", VA = "0x185ADC970", Slot = "19")]
	public void KPJHAKFGFBB(Rigidbody ACKBNFBBKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x5ADCB90", Offset = "0x5ADB590", VA = "0x185ADCB90", Slot = "20")]
	public void LCMOCMNDGKD(Rigidbody ACKBNFBBKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5ADCF20", Offset = "0x5ADB920", VA = "0x185ADCF20", Slot = "18")]
	public void NHEHBCMANCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x5ADB820", Offset = "0x5ADA220", VA = "0x185ADB820", Slot = "21")]
	public void CCBHJNAJCPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5ADD400", Offset = "0x5ADBE00", VA = "0x185ADD400")]
	public void PLIDFFCPFAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x5ADA480", Offset = "0x5AD8E80", VA = "0x185ADA480")]
	private void MIFGEBHLHAH(Vector3 MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x5ADA360", Offset = "0x5AD8D60", VA = "0x185ADA360")]
	private Vector3 BEKACJMHMPB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9F80", Offset = "0x5AD8980", VA = "0x185AD9F80")]
	private void BCFECMBGIMK(float MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x5ADD210", Offset = "0x5ADBC10", VA = "0x185ADD210")]
	private void OJFGCJEFEBN(float MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x5ADC090", Offset = "0x5ADAA90", VA = "0x185ADC090")]
	private Vector3 FMIMGBHGCBM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5ADC2C0", Offset = "0x5ADACC0", VA = "0x185ADC2C0")]
	private void FNJLCCBFLMD(Vector3 MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x5ADA5C0", Offset = "0x5AD8FC0", VA = "0x185ADA5C0")]
	private Quaternion BMKAKLPJGMM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x5ADA150", Offset = "0x5AD8B50", VA = "0x185ADA150")]
	private void BEBICDKDHMI(Quaternion MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x5ADA7D0", Offset = "0x5AD91D0", VA = "0x185ADA7D0")]
	internal (float, Vector3) BPJJLOCIGPG(Rigidbody DKLCELDOMIF)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class BAHHGLLNDDH
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x5AC3860", Offset = "0x5AC2260", VA = "0x185AC3860")]
	public static JIADDBKOKDG PEFNAECIBIG(this COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class IDJCJIEDGFL : HOEHMNAHADO, IKEFBCLFODA
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private const string MHDBNEAAAKE = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool CCBOLEPEIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x5AD6DA0", Offset = "0x5AD57A0", VA = "0x185AD6DA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public INDOICOKDMJ AJLEGAJMBED
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x5AD6680", Offset = "0x5AD5080", VA = "0x185AD6680", Slot = "5")]
		get
		{
			return default(INDOICOKDMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private INDOICOKDMJ PMFHCAGCHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x5AD66D0", Offset = "0x5AD50D0", VA = "0x185AD66D0")]
		get
		{
			return default(INDOICOKDMJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x5AD6F80", Offset = "0x5AD5980", VA = "0x185AD6F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7070", Offset = "0x5AD5A70", VA = "0x185AD7070")]
	public IDJCJIEDGFL(COAHBFHINFJ PALOPBGAJFN, in OFBIGENLNDL MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x5AD68A0", Offset = "0x5AD52A0", VA = "0x185AD68A0", Slot = "6")]
	public void HNIBDJMDFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x5AD6BC0", Offset = "0x5AD55C0", VA = "0x185AD6BC0")]
	private bool MFGKMMDONJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x5AD6C60", Offset = "0x5AD5660", VA = "0x185AD6C60", Slot = "7")]
	public void NAPJGOOENPP(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD6E80", Offset = "0x5AD5880", VA = "0x185AD6E80", Slot = "8")]
	public void OJLMLLFFDMC(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x5AD6AB0", Offset = "0x5AD54B0", VA = "0x185AD6AB0", Slot = "11")]
	public void MDMJKJBLKHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x5AD67B0", Offset = "0x5AD51B0", VA = "0x185AD67B0")]
	private void GEJKKCAAGBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x5AD6960", Offset = "0x5AD5360", VA = "0x185AD6960")]
	private void KDJBBCOBJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x5AD6690", Offset = "0x5AD5090", VA = "0x185AD6690", Slot = "10")]
	public void CHHKBIKAIGD(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x5AD6D60", Offset = "0x5AD5760", VA = "0x185AD6D60", Slot = "9")]
	public void NJEDOOPKMBA(COAHBFHINFJ PALOPBGAJFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class NJDBBEOFEAH : HOEHMNAHADO, OBINMAACDBO
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool LKJAOHPJMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x5AE6730", Offset = "0x5AE5130", VA = "0x185AE6730", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public IEnumerable<object> FBHCFIEFDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x5AE6B30", Offset = "0x5AE5530", VA = "0x185AE6B30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private bool IIOIJBAHPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x5AE6CB0", Offset = "0x5AE56B0", VA = "0x185AE6CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event IDBANGEEFOC MGPMICPPGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x5AE6990", Offset = "0x5AE5390", VA = "0x185AE6990", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x5AE6A90", Offset = "0x5AE5490", VA = "0x185AE6A90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7900", Offset = "0x5AC6300", VA = "0x185AC7900")]
	public NJDBBEOFEAH(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x5AE6A30", Offset = "0x5AE5430", VA = "0x185AE6A30", Slot = "11")]
	public IDisposable GLHGEKDKPPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x5AE6980", Offset = "0x5AE5380", VA = "0x185AE6980", Slot = "8")]
	public void FDHBMAEMFGJ(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x5AE67F0", Offset = "0x5AE51F0", VA = "0x185AE67F0", Slot = "9")]
	public void BILHHPDCDKM(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x5AE6800", Offset = "0x5AE5200", VA = "0x185AE6800", Slot = "10")]
	public void DCKOMBAMFDF(object HMAOAMDKNDD, bool OHANDDCLMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x5AE6C10", Offset = "0x5AE5610", VA = "0x185AE6C10", Slot = "12")]
	public void KPJHAKFGFBB(Rigidbody LHAKPCGHEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x5AE6C80", Offset = "0x5AE5680", VA = "0x185AE6C80", Slot = "13")]
	public void LCMOCMNDGKD(Rigidbody ACKBNFBBKOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class EALJOJDKKDO : HOEHMNAHADO, MAIEJCNIIBN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private PhotonView ONJFDBACIAC;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool PNPAICFFMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x5AC53F0", Offset = "0x5AC3DF0", VA = "0x185AC53F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool EJPMOLMBFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x5AC7D70", Offset = "0x5AC6770", VA = "0x185AC7D70", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event IDBANGEEFOC HEBMBPDHBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x5AC85A0", Offset = "0x5AC6FA0", VA = "0x185AC85A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x5AC7AE0", Offset = "0x5AC64E0", VA = "0x185AC7AE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x5AC8850", Offset = "0x5AC7250", VA = "0x185AC8850")]
	public EALJOJDKKDO(COAHBFHINFJ PALOPBGAJFN, in OFBIGENLNDL MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x5AC8280", Offset = "0x5AC6C80", VA = "0x185AC8280", Slot = "8")]
	public void HNIBDJMDFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x5AC8090", Offset = "0x5AC6A90", VA = "0x185AC8090", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x5AC8640", Offset = "0x5AC7040", VA = "0x185AC8640", Slot = "9")]
	public void NAJOGAHKIEE(COAHBFHINFJ EOBFGLJBCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7E80", Offset = "0x5AC6880", VA = "0x185AC7E80", Slot = "10")]
	public void DKLKECNJIAP(COAHBFHINFJ EOBFGLJBCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7B80", Offset = "0x5AC6580", VA = "0x185AC7B80")]
	private void APCGBJPFCIL(PhotonView ALJNKDMCHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7980", Offset = "0x5AC6380", VA = "0x185AC7980")]
	private void ACIONEDBIPE(RigidbodyEx BGDEOJDCKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x5AC83D0", Offset = "0x5AC6DD0", VA = "0x185AC83D0")]
	private void IFCBNHOEAFB(PhotonView JANADLHNPPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class ECADGNKCPNP
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x5AC88E0", Offset = "0x5AC72E0", VA = "0x185AC88E0")]
	public static EALJOJDKKDO NOIKFDKCMFG(this HIFMFONNJJL NPGEFAIHGBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class IIGLJNEHJCE : HOEHMNAHADO, PKJGDCALGBM
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool MNBOPCHPOPL
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x5AD8790", Offset = "0x5AD7190", VA = "0x185AD8790", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x5AD81C0", Offset = "0x5AD6BC0", VA = "0x185AD81C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool GLGCOGBLPJC
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x5AD82B0", Offset = "0x5AD6CB0", VA = "0x185AD82B0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x5AD8870", Offset = "0x5AD7270", VA = "0x185AD8870")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public RigidbodyConstraints LBIHCKGJNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x5AD8960", Offset = "0x5AD7360", VA = "0x185AD8960", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x5AD8390", Offset = "0x5AD6D90", VA = "0x185AD8390", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x5AD8A40", Offset = "0x5AD7440", VA = "0x185AD8A40")]
	public IIGLJNEHJCE(COAHBFHINFJ PALOPBGAJFN, in OFBIGENLNDL MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x5AD8590", Offset = "0x5AD6F90", VA = "0x185AD8590", Slot = "9")]
	public void KPJHAKFGFBB(Rigidbody ACKBNFBBKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x5AD8690", Offset = "0x5AD7090", VA = "0x185AD8690", Slot = "10")]
	public void LCMOCMNDGKD(Rigidbody ACKBNFBBKOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class DNEFBAFCLEG : HOEHMNAHADO, BHMIPOFDPEF
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public float DKMCCCEGGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x5AC7100", Offset = "0x5AC5B00", VA = "0x185AC7100", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x5AC71E0", Offset = "0x5AC5BE0", VA = "0x185AC71E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public float DNJAHBCJABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x5AC7580", Offset = "0x5AC5F80", VA = "0x185AC7580", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x5AC73B0", Offset = "0x5AC5DB0", VA = "0x185AC73B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7900", Offset = "0x5AC6300", VA = "0x185AC7900")]
	public DNEFBAFCLEG(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7660", Offset = "0x5AC6060", VA = "0x185AC7660", Slot = "8")]
	public void KPJHAKFGFBB(Rigidbody ACKBNFBBKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7830", Offset = "0x5AC6230", VA = "0x185AC7830", Slot = "9")]
	public void LCMOCMNDGKD(Rigidbody ACKBNFBBKOA)
	{
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[LHOECCIDBFM(typeof(ENPBFGLEBMA), new string[] { })]
	[KEFMDJAGLBH(IGKCNDFEDMC.Physics)]
	public sealed class RbexServiceCallbacks : HNADMPPHDEF, ENPBFGLEBMA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly NNLEPLPFODN DPMCBMJDHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private CEILNDOCFMN PALOPBGAJFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private bool ILMLECMLEKB;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool FKIMOIOBPDE
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x80ADB0", Offset = "0x8097B0", VA = "0x18080ADB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x6A94580", Offset = "0x6A92F80", VA = "0x186A94580", Slot = "4")]
		public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6A94550", Offset = "0x6A92F50", VA = "0x186A94550", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6A942A0", Offset = "0x6A92CA0", VA = "0x186A942A0", Slot = "6")]
		public void BPJJLOCIGPG(GEEJJFIMDNA BJLPLHMBBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public RbexServiceCallbacks()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class OHGKNNEEOCI : HOEHMNAHADO, LEABOMDCKNB
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const int AIIMKOKGGLK = 10;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public const float KHCDIABCJFJ = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const float GGDLAAELDHB = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public const float NIDAJINFEKM = 5f;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private Rigidbody OMLJJMOAGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF830", Offset = "0x5ACE230", VA = "0x185ACF830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool HALMCOFHIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x5AE8920", Offset = "0x5AE7320", VA = "0x185AE8920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool FKIBJJIHGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x5AC9680", Offset = "0x5AC8080", VA = "0x185AC9680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private COAHBFHINFJ NLJMPCEPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x5AE8CC0", Offset = "0x5AE76C0", VA = "0x185AE8CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private bool APDKJKFGMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x5AE9580", Offset = "0x5AE7F80", VA = "0x185AE9580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool LCDFDKHDDMB
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x5AE8BE0", Offset = "0x5AE75E0", VA = "0x185AE8BE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x5AE9290", Offset = "0x5AE7C90", VA = "0x185AE9290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private bool PFLJONJFANK
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x5AE8840", Offset = "0x5AE7240", VA = "0x185AE8840")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x5AE8DC0", Offset = "0x5AE77C0", VA = "0x185AE8DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private int ELFBDGIKLMH
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x5AE8F50", Offset = "0x5AE7950", VA = "0x185AE8F50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x5AE91A0", Offset = "0x5AE7BA0", VA = "0x185AE91A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event IDBANGEEFOC EAJDOHBLDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x5AE8EB0", Offset = "0x5AE78B0", VA = "0x185AE8EB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x5AE8D20", Offset = "0x5AE7720", VA = "0x185AE8D20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x5AE9790", Offset = "0x5AE8190", VA = "0x185AE9790")]
	public OHGKNNEEOCI(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x5AE90F0", Offset = "0x5AE7AF0", VA = "0x185AE90F0", Slot = "6")]
	public void HNIBDJMDFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x5AE90E0", Offset = "0x5AE7AE0", VA = "0x185AE90E0", Slot = "8")]
	public void GEFJBHOINKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x5AE89C0", Offset = "0x5AE73C0", VA = "0x185AE89C0", Slot = "7")]
	public bool BIOLEFGLELD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x5AE9030", Offset = "0x5AE7A30", VA = "0x185AE9030", Slot = "9")]
	public void FKCCMPCDICG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x5ADD400", Offset = "0x5ADBE00", VA = "0x185ADD400", Slot = "12")]
	public void EHAEKEPECIJ(bool CCNCEDMACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x5AE94D0", Offset = "0x5AE7ED0", VA = "0x185AE94D0", Slot = "11")]
	public void NEBOODLLBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "10")]
	public void KLEAIMMHIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x5AE95E0", Offset = "0x5AE7FE0", VA = "0x185AE95E0")]
	private bool NNKPHKGNDCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x5AE9380", Offset = "0x5AE7D80", VA = "0x185AE9380")]
	private void MJCLKPNNMGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class IIEFBIPJPLN : HOEHMNAHADO, FLBBEGCCDPK
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private const string JMFDJOLHGHG = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Rigidbody OMLJJMOAGEL
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x5AD73B0", Offset = "0x5AD5DB0", VA = "0x185AD73B0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x5AD7C20", Offset = "0x5AD6620", VA = "0x185AD7C20")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private bool APDKJKFGMHP
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x5AD7E10", Offset = "0x5AD6810", VA = "0x185AD7E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x5AD8130", Offset = "0x5AD6B30", VA = "0x185AD8130")]
	public IIEFBIPJPLN(COAHBFHINFJ PALOPBGAJFN, in OFBIGENLNDL MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7650", Offset = "0x5AD6050", VA = "0x185AD7650", Slot = "5")]
	public void HNIBDJMDFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7D10", Offset = "0x5AD6710", VA = "0x185AD7D10", Slot = "6")]
	public void MDJKOOAEJGP(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7960", Offset = "0x5AD6360", VA = "0x185AD7960", Slot = "7")]
	public void JNAKANEBFGD(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7E70", Offset = "0x5AD6870", VA = "0x185AD7E70", Slot = "8")]
	public void ODDJBGMPAHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7700", Offset = "0x5AD6100", VA = "0x185AD7700", Slot = "9")]
	public void JLPFPMGKIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x5AD71E0", Offset = "0x5AD5BE0", VA = "0x185AD71E0", Slot = "10")]
	public void ANOJPKEOEOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "11")]
	public void HFEDMBGBACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7A60", Offset = "0x5AD6460", VA = "0x185AD7A60")]
	private void KALPCNPFLEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x5AD7490", Offset = "0x5AD5E90", VA = "0x185AD7490")]
	private void GOCIGAOOPNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class EHLBCAFLNMJ : HOEHMNAHADO, IJCAKKDCEJD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public OAAJJMEKKCO FOHFKKLNCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x5ACA470", Offset = "0x5AC8E70", VA = "0x185ACA470", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5ACC2E0", Offset = "0x5ACACE0", VA = "0x185ACC2E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public NGGEJBJJIOA ONFHFHJINDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x5ACC1B0", Offset = "0x5ACABB0", VA = "0x185ACC1B0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5ACBBE0", Offset = "0x5ACA5E0", VA = "0x185ACBBE0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 MBKHAGELNKC
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB070", Offset = "0x5AC9A70", VA = "0x185ACB070", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5AC8EB0", Offset = "0x5AC78B0", VA = "0x185AC8EB0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 PNMFHCHJLKD
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5ACA0B0", Offset = "0x5AC8AB0", VA = "0x185ACA0B0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x5ACAC90", Offset = "0x5AC9690", VA = "0x185ACAC90", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Vector3 MKCBJFMHIAP
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5ACA1C0", Offset = "0x5AC8BC0", VA = "0x185ACA1C0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5ACBB20", Offset = "0x5ACA520", VA = "0x185ACBB20", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 CLGPPIAECCK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5ACC090", Offset = "0x5ACAA90", VA = "0x185ACC090", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5ACAD00", Offset = "0x5AC9700", VA = "0x185ACAD00", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public float JBJNCHGJKNF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x5AC95A0", Offset = "0x5AC7FA0", VA = "0x185AC95A0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x5ACA5A0", Offset = "0x5AC8FA0", VA = "0x185ACA5A0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool EMAEPLLIHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x5AC8DD0", Offset = "0x5AC77D0", VA = "0x185AC8DD0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private ALMDAKNNCFI GBNEKFAJJMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x29EBD40", Offset = "0x29EA740", VA = "0x1829EBD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private bool FKIBJJIHGPL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x5AC9680", Offset = "0x5AC8080", VA = "0x185AC9680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7900", Offset = "0x5AC6300", VA = "0x185AC7900")]
	public EHLBCAFLNMJ(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x5ACBFA0", Offset = "0x5ACA9A0", VA = "0x185ACBFA0", Slot = "20")]
	public void OFEAGCJBKIE(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA960", Offset = "0x5AC9360", VA = "0x185ACA960", Slot = "31")]
	public void JHLGMNKNLCL(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x5AC9C20", Offset = "0x5AC8620", VA = "0x185AC9C20", Slot = "19")]
	public void HNIBDJMDFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5AC9C90", Offset = "0x5AC8690", VA = "0x185AC9C90", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5ACACC0", Offset = "0x5AC96C0", VA = "0x185ACACC0", Slot = "28")]
	public void KPJHAKFGFBB(Rigidbody ACKBNFBBKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5AC93C0", Offset = "0x5AC7DC0", VA = "0x185AC93C0", Slot = "36")]
	public Vector3 BKPNHLFHBLJ(Vector3 GELONNAFHPN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5AC8C10", Offset = "0x5AC7610", VA = "0x185AC8C10", Slot = "35")]
	public Vector3 AFLKIDCHEPD(Vector3 NKKNGNHELCP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5AC9C20", Offset = "0x5AC8620", VA = "0x185AC9C20", Slot = "27")]
	public void DOGPHMJJOMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5ACAB40", Offset = "0x5AC9540", VA = "0x185ACAB40", Slot = "25")]
	public void JOPHKGJJEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA920", Offset = "0x5AC9320", VA = "0x185ACA920", Slot = "24")]
	public void JGDGGMLOEEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA5B0", Offset = "0x5AC8FB0", VA = "0x185ACA5B0", Slot = "34")]
	public void IKHGBFBJDEA(Vector3 GMNCBDPBBLL, Vector3 CAEAHDMGPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5AC9200", Offset = "0x5AC7C00", VA = "0x185AC9200", Slot = "33")]
	public void BIPMBCHIBJM(Vector3 JJEOGAGCOIH, Vector3 OBAPNEEPMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5AC9260", Offset = "0x5AC7C60", VA = "0x185AC9260", Slot = "32")]
	public void BKNOFAAHKIP(Vector3 NBKMOPIFBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5AC96A0", Offset = "0x5AC80A0", VA = "0x185AC96A0", Slot = "22")]
	public void CPBCIKEJEFA(KDLFENIMCAA NALNFBLFJEL, Vector3 ACKJBHOBHDH, float MEEIIJPJJBC, float JHBPAKGIBHB = 8f, float LJLGEELHOJE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5AC9DC0", Offset = "0x5AC87C0", VA = "0x185AC9DC0", Slot = "21")]
	public void EHGOOBAPJML(ELMJFFPDDAN KLDJNIPILLN, Vector3 BCFGIAPFKKB, float OKLEEHKJJBA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5ACBCD0", Offset = "0x5ACA6D0", VA = "0x185ACBCD0", Slot = "23")]
	[Obsolete]
	public void NMKJNOACPKB(ELMJFFPDDAN KLDJNIPILLN, Vector3 FDBNIAOOEMB, float HBOOAGHCBND = 7f, float BKMDHMBHOBP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5AC9FF0", Offset = "0x5AC89F0", VA = "0x185AC9FF0", Slot = "30")]
	public Vector3 EKHCFAGKJAA(Vector3 PBLNDACCBGI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5ACAA50", Offset = "0x5AC9450", VA = "0x185ACAA50", Slot = "29")]
	public Vector3 JMCMOBNNEMD(Vector3 LOMDGDKPDKD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA7F0", Offset = "0x5AC91F0", VA = "0x185ACA7F0", Slot = "26")]
	public void IODHOHMNIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5AC9030", Offset = "0x5AC7A30", VA = "0x185AC9030")]
	private void BHOAJPBFJEB(float MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5ACA310", Offset = "0x5AC8D10", VA = "0x185ACA310")]
	private void ICDHBABCJFM(Vector3 BCFGIAPFKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5ACAB80", Offset = "0x5AC9580", VA = "0x185ACAB80")]
	private Vector3 KKIKOGNDAFK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5ACAD30", Offset = "0x5AC9730", VA = "0x185ACAD30")]
	private void LPJAFENFIEO(Vector3 NKKNGNHELCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5AC9B10", Offset = "0x5AC8510", VA = "0x185AC9B10")]
	private Vector3 DHOHLCHHEGL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5ACB1C0", Offset = "0x5AC9BC0", VA = "0x185ACB1C0")]
	private void MJLNPICKPDO(Vector3 MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5ACB520", Offset = "0x5AC9F20", VA = "0x185ACB520")]
	private void MOEFHPPIAOP(Vector3 NKKNGNHELCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x5AC8F70", Offset = "0x5AC7970", VA = "0x185AC8F70")]
	private void ALHEDMHPIFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class HOEHMNAHADO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly NFBCNBGCJMF PALOPBGAJFN;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected CEILNDOCFMN ECGLCMDNHIE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x17D0F50", Offset = "0x17CF950", VA = "0x1817D0F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected GEEJJFIMDNA PAGAMJKGOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x5AD5F50", Offset = "0x5AD4950", VA = "0x185AD5F50")]
		get
		{
			return default(GEEJJFIMDNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7900", Offset = "0x5AC6300", VA = "0x185AC7900")]
	public HOEHMNAHADO(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x5AD5F80", Offset = "0x5AD4980", VA = "0x185AD5F80")]
	protected COAHBFHINFJ LDNFNONDBCL(GEEJJFIMDNA AGGJCDBCIGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class DENFFLJDHIB : BDGACHFDAAD
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6AD0", Offset = "0x5AC54D0", VA = "0x185AC6AD0", Slot = "4")]
	public KEPEBEIEONO LLFOFDPPPEH(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6510", Offset = "0x5AC4F10", VA = "0x185AC6510", Slot = "5")]
	public IJCAKKDCEJD BOOAJPBGFCJ(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x5AC66D0", Offset = "0x5AC50D0", VA = "0x185AC66D0", Slot = "6")]
	public DJGACNAABHP DEKGIBJDDEA(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6E20", Offset = "0x5AC5820", VA = "0x185AC6E20", Slot = "7")]
	public BHMIPOFDPEF PPKKMOKPHMH(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6670", Offset = "0x5AC5070", VA = "0x185AC6670", Slot = "8")]
	public LEABOMDCKNB CKBCPEEIFMM(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6A30", Offset = "0x5AC5430", VA = "0x185AC6A30", Slot = "9")]
	public IHEBEOFGNMA LFPCDGDGHAA(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6470", Offset = "0x5AC4E70", VA = "0x185AC6470", Slot = "10")]
	public OBINMAACDBO ANJBKMGAONL(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6D80", Offset = "0x5AC5780", VA = "0x185AC6D80", Slot = "11")]
	public ALMDAKNNCFI PDIOMEDJEAD(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6C40", Offset = "0x5AC5640", VA = "0x185AC6C40", Slot = "12")]
	public OLPBGKDBBKJ MBHPECPBGKJ(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6CE0", Offset = "0x5AC56E0", VA = "0x185AC6CE0", Slot = "13")]
	public EGJGFBDNEPH NBLJJLHMPHB(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5AC67E0", Offset = "0x5AC51E0", VA = "0x185AC67E0")]
	public FLBBEGCCDPK ELAPBOIDLMJ(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x5AC65B0", Offset = "0x5AC4FB0", VA = "0x185AC65B0")]
	public MAIEJCNIIBN CEFAJHJADHC(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5AC68A0", Offset = "0x5AC52A0", VA = "0x185AC68A0")]
	public IKEFBCLFODA IKMDFEKNPBJ(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6400", Offset = "0x5AC4E00", VA = "0x185AC6400")]
	public MKIPBOEDJDF AHJJEEACDHH(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6770", Offset = "0x5AC5170", VA = "0x185AC6770")]
	public PKJGDCALGBM JDPIOHJNDBJ(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6350", Offset = "0x5AC4D50", VA = "0x185AC6350", Slot = "19")]
	public COAHBFHINFJ AHDJIEGMHLB(RigidbodyEx PALOPBGAJFN, OFBIGENLNDL MNILNHMNKJK, GMOFJHOBHHJ KONLJOKGCCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public DENFFLJDHIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5AC67E0", Offset = "0x5AC51E0", VA = "0x185AC67E0", Slot = "14")]
	private FLBBEGCCDPK JBJHDNHNDNJ(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5AC65B0", Offset = "0x5AC4FB0", VA = "0x185AC65B0", Slot = "15")]
	private MAIEJCNIIBN PGACBBAIJMO(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5AC68A0", Offset = "0x5AC52A0", VA = "0x185AC68A0", Slot = "16")]
	private IKEFBCLFODA HKBAKONKOGM(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6400", Offset = "0x5AC4E00", VA = "0x185AC6400", Slot = "17")]
	private MKIPBOEDJDF OPFOBNJHMII(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6770", Offset = "0x5AC5170", VA = "0x185AC6770", Slot = "18")]
	private PKJGDCALGBM DGHOIAMPHOM(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class OFEDBOFDLJH : IReadOnlyList<COAHBFHINFJ>, IEnumerable<COAHBFHINFJ>, IEnumerable, IReadOnlyCollection<COAHBFHINFJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly GEEJJFIMDNA AGGJCDBCIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly CEILNDOCFMN LMACCHFJBFE;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int GNKNLJGDNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x5AE85C0", Offset = "0x5AE6FC0", VA = "0x185AE85C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public COAHBFHINFJ KBLKMCBLENC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x5AE8690", Offset = "0x5AE7090", VA = "0x185AE8690", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5AE8570", Offset = "0x5AE6F70", VA = "0x185AE8570")]
	public OFEDBOFDLJH(GEEJJFIMDNA AGGJCDBCIGG, CEILNDOCFMN LMACCHFJBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5AE83E0", Offset = "0x5AE6DE0", VA = "0x185AE83E0", Slot = "6")]
	public IEnumerator<COAHBFHINFJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x5AE83E0", Offset = "0x5AE6DE0", VA = "0x185AE83E0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5AE83D0", Offset = "0x5AE6DD0", VA = "0x185AE83D0")]
	[CompilerGenerated]
	private COAHBFHINFJ CCCCLOMAOKP(int HLFOHCODFGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[LHOECCIDBFM(typeof(BDGACHFDAAD), new string[] { })]
public class ONNHKCHLOFD : BDGACHFDAAD, HNADMPPHDEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly BDGACHFDAAD DCIFFHIHJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly BDGACHFDAAD GHJONFLCPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private DPFFGIGBPCD OPAHKFOPLAF;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private BDGACHFDAAD FIOAJCDLGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x5AEAFE0", Offset = "0x5AE99E0", VA = "0x185AEAFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAEF0", Offset = "0x5AE98F0", VA = "0x185AEAEF0", Slot = "20")]
	public void MJNDDLKNMNL(IBDMDNNFKPL CFMBBKOCIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5AEADB0", Offset = "0x5AE97B0", VA = "0x185AEADB0", Slot = "4")]
	public KEPEBEIEONO LLFOFDPPPEH(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA870", Offset = "0x5AE9270", VA = "0x185AEA870", Slot = "5")]
	public IJCAKKDCEJD BOOAJPBGFCJ(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAA60", Offset = "0x5AE9460", VA = "0x185AEAA60", Slot = "6")]
	public DJGACNAABHP DEKGIBJDDEA(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB0E0", Offset = "0x5AE9AE0", VA = "0x185AEB0E0", Slot = "7")]
	public BHMIPOFDPEF PPKKMOKPHMH(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA9C0", Offset = "0x5AE93C0", VA = "0x185AEA9C0", Slot = "8")]
	public LEABOMDCKNB CKBCPEEIFMM(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAD10", Offset = "0x5AE9710", VA = "0x185AEAD10", Slot = "9")]
	public IHEBEOFGNMA LFPCDGDGHAA(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA7D0", Offset = "0x5AE91D0", VA = "0x185AEA7D0", Slot = "10")]
	public OBINMAACDBO ANJBKMGAONL(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB040", Offset = "0x5AE9A40", VA = "0x185AEB040", Slot = "11")]
	public ALMDAKNNCFI PDIOMEDJEAD(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAE50", Offset = "0x5AE9850", VA = "0x185AEAE50", Slot = "12")]
	public OLPBGKDBBKJ MBHPECPBGKJ(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAF40", Offset = "0x5AE9940", VA = "0x185AEAF40", Slot = "13")]
	public EGJGFBDNEPH NBLJJLHMPHB(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x5AEABB0", Offset = "0x5AE95B0", VA = "0x185AEABB0")]
	public FLBBEGCCDPK ELAPBOIDLMJ(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA910", Offset = "0x5AE9310", VA = "0x185AEA910")]
	public MAIEJCNIIBN CEFAJHJADHC(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAC60", Offset = "0x5AE9660", VA = "0x185AEAC60")]
	public IKEFBCLFODA IKMDFEKNPBJ(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA720", Offset = "0x5AE9120", VA = "0x185AEA720")]
	public MKIPBOEDJDF AHJJEEACDHH(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAB00", Offset = "0x5AE9500", VA = "0x185AEAB00")]
	public PKJGDCALGBM JDPIOHJNDBJ(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA5D0", Offset = "0x5AE8FD0", VA = "0x185AEA5D0", Slot = "19")]
	public COAHBFHINFJ AHDJIEGMHLB(RigidbodyEx PALOPBGAJFN, OFBIGENLNDL MNILNHMNKJK, GMOFJHOBHHJ KONLJOKGCCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB180", Offset = "0x5AE9B80", VA = "0x185AEB180")]
	public ONNHKCHLOFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x5AEABB0", Offset = "0x5AE95B0", VA = "0x185AEABB0", Slot = "14")]
	private FLBBEGCCDPK JBJHDNHNDNJ(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA910", Offset = "0x5AE9310", VA = "0x185AEA910", Slot = "15")]
	private MAIEJCNIIBN PGACBBAIJMO(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAC60", Offset = "0x5AE9660", VA = "0x185AEAC60", Slot = "16")]
	private IKEFBCLFODA HKBAKONKOGM(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA720", Offset = "0x5AE9120", VA = "0x185AEA720", Slot = "17")]
	private MKIPBOEDJDF OPFOBNJHMII(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x5AEAB00", Offset = "0x5AE9500", VA = "0x185AEAB00", Slot = "18")]
	private PKJGDCALGBM DGHOIAMPHOM(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Preserve]
public sealed class EKCGPPOFGEN : COAHBFHINFJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly EKCGPPOFGEN FINLHCLDLDF;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Rigidbody OMLJJMOAGEL
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public RigidbodyEx BJOMECCDLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public GameObject KLFJADJOODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Transform CCKPELKPNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public IEnumerable<object> MOJELOMFNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public COAHBFHINFJ NLJMPCEPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x8464B0", Offset = "0x844EB0", VA = "0x1808464B0", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public IReadOnlyList<COAHBFHINFJ> PLEEMIOGEJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x73EEB0", Offset = "0x73D8B0", VA = "0x18073EEB0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public COAHBFHINFJ ADLFAHHCAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x73B590", Offset = "0x739F90", VA = "0x18073B590", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool APDKJKFGMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x8F20E0", Offset = "0x8F0AE0", VA = "0x1808F20E0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool PNPAICFFMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x846330", Offset = "0x844D30", VA = "0x180846330", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool EJPMOLMBFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xEBAB20", Offset = "0xEB9520", VA = "0x180EBAB20", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public OAAJJMEKKCO FOHFKKLNCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x741FC0", Offset = "0x7409C0", VA = "0x180741FC0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB90", Offset = "0x7D9590", VA = "0x1807DAB90", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public NGGEJBJJIOA ONFHFHJINDD
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7D7060", Offset = "0x7D5A60", VA = "0x1807D7060", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x7D7050", Offset = "0x7D5A50", VA = "0x1807D7050", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public float JBJNCHGJKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x140E2E0", Offset = "0x140CCE0", VA = "0x18140E2E0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x140E930", Offset = "0x140D330", VA = "0x18140E930", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 PNMFHCHJLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x36D25E0", Offset = "0x36D0FE0", VA = "0x1836D25E0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x36D2670", Offset = "0x36D1070", VA = "0x1836D2670", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 CLGPPIAECCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD0D0", Offset = "0x2ADBAD0", VA = "0x182ADD0D0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x2AD93B0", Offset = "0x2AD7DB0", VA = "0x182AD93B0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 MBKHAGELNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xD7D6F0", Offset = "0xD7C0F0", VA = "0x180D7D6F0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0xD7D370", Offset = "0xD7BD70", VA = "0x180D7D370", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Vector3 MKCBJFMHIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x7383D0", Offset = "0x736DD0", VA = "0x1807383D0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool EBNPMBHCAAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xDF96D0", Offset = "0xDF80D0", VA = "0x180DF96D0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool ODAILKPDPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xDF96C0", Offset = "0xDF80C0", VA = "0x180DF96C0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool DLMFFEBHFDG
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x106D4B0", Offset = "0x106BEB0", VA = "0x18106D4B0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool EMAEPLLIHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x150E450", Offset = "0x150CE50", VA = "0x18150E450", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Vector3 CCOEDOIODMG
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x15DB450", Offset = "0x15D9E50", VA = "0x1815DB450", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 NOCJNDBDOAC
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x16C6EE0", Offset = "0x16C58E0", VA = "0x1816C6EE0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 HHPIFJCOOGE
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x7383D0", Offset = "0x736DD0", VA = "0x1807383D0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 GGIEIBKNPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD190", Offset = "0x2ADBB90", VA = "0x182ADD190", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public float PADHGHJLJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xD53750", Offset = "0xD52150", VA = "0x180D53750", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float EAKNKCMIHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xAEEA90", Offset = "0xAED490", VA = "0x180AEEA90", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 HDCBDKOIDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x7383D0", Offset = "0x736DD0", VA = "0x1807383D0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion PNOHMMCCAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x7379B0", Offset = "0x7363B0", VA = "0x1807379B0", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public float DKMCCCEGGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xAEEA90", Offset = "0xAED490", VA = "0x180AEEA90", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public float DNJAHBCJABP
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xAEEA90", Offset = "0xAED490", VA = "0x180AEEA90", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool OBCEOAKDHMN
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool GDIMOJIKJPK
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public AIFDGFHGOFL KPFOHJHFIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "52")]
		get
		{
			return default(AIFDGFHGOFL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool LKJAOHPJMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x12D7370", Offset = "0x12D5D70", VA = "0x1812D7370", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Transform NFIHBIKGJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x895EB0", Offset = "0x8948B0", VA = "0x180895EB0", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Transform MANILMNCAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x7D5640", Offset = "0x7D4040", VA = "0x1807D5640", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Vector3 FCOKJGLMIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x7383D0", Offset = "0x736DD0", VA = "0x1807383D0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float NFBPMPNKKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xAEEA90", Offset = "0xAED490", VA = "0x180AEEA90", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public float JLDIPJBLGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xAEEA90", Offset = "0xAED490", VA = "0x180AEEA90", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Quaternion GNHNFAGLCOE
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x1EEFEE0", Offset = "0x1EEE8E0", VA = "0x181EEFEE0", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Vector3 ICHCLDFIPAC
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x7383D0", Offset = "0x736DD0", VA = "0x1807383D0", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Quaternion MKBNFPHEILA
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x1EEFEE0", Offset = "0x1EEE8E0", VA = "0x181EEFEE0", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public RigidbodyConstraints LBIHCKGJNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool MNBOPCHPOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public CollisionDetectionMode ONKHAABGHFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool FKIBJJIHGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x12C03C0", Offset = "0x12BEDC0", VA = "0x1812C03C0", Slot = "75")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event IDBANGEEFOC FHNMFLEGKLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event IDBANGEEFOC KACABKHKGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event BMBDIJCKKFM NDCGJGKOFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event IDBANGEEFOC HEBMBPDHBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event IDBANGEEFOC OGFKCFDDFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event IDBANGEEFOC EAJDOHBLDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<IJJPEDCHMLC, IJJPEDCHMLC> HMNEDFGDGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event IDBANGEEFOC IHOMKKFKAKF
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event IDBANGEEFOC BAOOFNJOHJA
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "125")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "126")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "76")]
	public void HNIBDJMDFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "77")]
	public void IMNIDIOEADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "78")]
	public void CGIDAOFPDGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "79")]
	public void FKCCMPCDICG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "80")]
	public void APHKPGCLALM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "87")]
	public void CLOBJFNMHGM(COAHBFHINFJ MFBGAMJDOKA, bool BFNLLLADIAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "90")]
	public void OLOAAEPFOPK(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "91")]
	public void NMNBFMLLAFC(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x7383D0", Offset = "0x736DD0", VA = "0x1807383D0", Slot = "92")]
	public Vector3 BKPNHLFHBLJ(Vector3 GELONNAFHPN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7383D0", Offset = "0x736DD0", VA = "0x1807383D0", Slot = "93")]
	public Vector3 AFLKIDCHEPD(Vector3 NKKNGNHELCP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "94")]
	public void DOGPHMJJOMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "95")]
	public void JOPHKGJJEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "96")]
	public void JGDGGMLOEEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "97")]
	public void IKHGBFBJDEA(Vector3 GMNCBDPBBLL, Vector3 CAEAHDMGPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "98")]
	public void BIPMBCHIBJM(Vector3 JJEOGAGCOIH, Vector3 OBAPNEEPMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "99")]
	public void BKNOFAAHKIP(Vector3 NBKMOPIFBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "100")]
	public void CPBCIKEJEFA(KDLFENIMCAA NALNFBLFJEL, Vector3 ACKJBHOBHDH, float MEEIIJPJJBC, float JHBPAKGIBHB = 8f, float LJLGEELHOJE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "101")]
	public void EHGOOBAPJML(ELMJFFPDDAN KLDJNIPILLN, Vector3 BCFGIAPFKKB, float OKLEEHKJJBA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "102")]
	public void NMKJNOACPKB(ELMJFFPDDAN KLDJNIPILLN, Vector3 FDBNIAOOEMB, float HBOOAGHCBND = 7f, float BKMDHMBHOBP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x7383D0", Offset = "0x736DD0", VA = "0x1807383D0", Slot = "103")]
	public Vector3 EKHCFAGKJAA(Vector3 MFBGAMJDOKA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x7383D0", Offset = "0x736DD0", VA = "0x1807383D0", Slot = "104")]
	public Vector3 JMCMOBNNEMD(Vector3 MFBGAMJDOKA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "105")]
	public void IODHOHMNIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "106")]
	public void MEODIFCOIKA(COAHBFHINFJ IGEMLIBMGHF, object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "107")]
	public void LMNFLAJGKLI(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "110")]
	public void OGAPPILJDFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "111")]
	public void GFJEIFADKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "112")]
	public void NHEHBCMANCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "115")]
	public bool BIOLEFGLELD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "116")]
	public void NEBOODLLBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "121")]
	public IDisposable GLHGEKDKPPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "122")]
	public void FDHBMAEMFGJ(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "123")]
	public void BILHHPDCDKM(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "124")]
	public void DCKOMBAMFDF(object HMAOAMDKNDD, bool OHANDDCLMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "127")]
	public void FLHCNGPMALE(Vector3 JJJOPGOLMFH, Quaternion KLBIBNCNCIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "128")]
	public void KMHOJILANDC(Vector3 ONKHKGGGDFH, Quaternion DHKLEPIAPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "129")]
	public bool EBHINPAMFNL(float HEPLPCOEDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "130")]
	public void KJNEBLODDHI(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "131")]
	public void HDOBEGGHCGG(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "132")]
	public void MDJKOOAEJGP(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "133")]
	public void JNAKANEBFGD(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "134")]
	public void EEEMGOCGBED(Vector3 BFIMHHIKINE, ForceMode PFMKMOIPPCD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "135")]
	public void PEICNGFMEKD(Vector3 BFIMHHIKINE, Vector3 LHCEFCJDGIJ, ForceMode PFMKMOIPPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "136")]
	public void HMDGDDGCCFL(Vector3 PIPIGKBLIGD, ForceMode PFMKMOIPPCD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "137")]
	public void GEHIBBCOGKG(Vector3 PIPIGKBLIGD, ForceMode PFMKMOIPPCD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x5ACC3D0", Offset = "0x5ACADD0", VA = "0x185ACC3D0", Slot = "138")]
	public bool CEHDPNMJOLM(Vector3 GNIANLFIOCO, out RaycastHit ANGKOJNCMIA, float AGKAIFMKLLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "139")]
	public void CCBHJNAJCPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public EKCGPPOFGEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class NFBCNBGCJMF : HIFMFONNJJL, CBHBHIBBFBM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	internal GEEJJFIMDNA AGGJCDBCIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	internal CEILNDOCFMN JCOCCDLNBIB;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x5AE59E0", Offset = "0x5AE43E0", VA = "0x185AE59E0")]
	public NFBCNBGCJMF(GameObject OJBDJCCAFCN, RigidbodyEx IHKHHDDLICA, GMOFJHOBHHJ KONLJOKGCCN, in OFBIGENLNDL MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x5AE5690", Offset = "0x5AE4090", VA = "0x185AE5690", Slot = "142")]
	protected override void GLAJCKEHOLG(GMOFJHOBHHJ KONLJOKGCCN, OFBIGENLNDL MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5AE5310", Offset = "0x5AE3D10", VA = "0x185AE5310", Slot = "143")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x5AE54A0", Offset = "0x5AE3EA0", VA = "0x185AE54A0", Slot = "145")]
	public void EGAJBGAGDDO(CDOKOIKGOFB GFPNEMALIHE, CDOKOIKGOFB JOOHHAMJDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x5AE55D0", Offset = "0x5AE3FD0", VA = "0x185AE55D0", Slot = "146")]
	public void EMCICENPFHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x5AE5920", Offset = "0x5AE4320", VA = "0x185AE5920", Slot = "147")]
	public void LJHLACBCJFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x5AE5570", Offset = "0x5AE3F70", VA = "0x185AE5570", Slot = "148")]
	public void EHAEKEPECIJ(bool CCNCEDMACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x5AE51B0", Offset = "0x5AE3BB0", VA = "0x185AE51B0", Slot = "149")]
	public bool AINKPNLJILM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "144")]
	public override void APHKPGCLALM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class CNKLHEGOEEC
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x5AC54B0", Offset = "0x5AC3EB0", VA = "0x185AC54B0")]
	public static HIFMFONNJJL LJDHOLLCHNB(this COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface BNOGDBDCBKF : KEPEBEIEONO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMKFLEEHJJC(COAHBFHINFJ PALOPBGAJFN);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FMALHNNINDF(COAHBFHINFJ PALOPBGAJFN);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJDPLBPDOJA(COAHBFHINFJ ENLKANOCMGJ);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NMMGJMPGKPK(COAHBFHINFJ ENLKANOCMGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface ANJDAHJGPLG : DJGACNAABHP
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	global::INFEPAMAGFB<COAHBFHINFJ> JIGEOOKHDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	COAHBFHINFJ FBFJBKHAAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface FEOHBKJLJBH : MKIPBOEDJDF
{
	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) BPJJLOCIGPG(Rigidbody DKLCELDOMIF);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface DCMCHJPIMDM : MAIEJCNIIBN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	PhotonView LNKCNEENEOM
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class IAIPDOALGDL : OLPBGKDBBKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly HIFMFONNJJL PALOPBGAJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private CollisionDetectionMode DPANCHPGDII;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private Rigidbody OMLJJMOAGEL
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF830", Offset = "0x5ACE230", VA = "0x185ACF830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public CollisionDetectionMode ONKHAABGHFC
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x5AD6500", Offset = "0x5AD4F00", VA = "0x185AD6500", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x5AD6610", Offset = "0x5AD5010", VA = "0x185AD6610", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7070", Offset = "0x5AC5A70", VA = "0x185AC7070")]
	public IAIPDOALGDL(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x5AD6350", Offset = "0x5AD4D50", VA = "0x185AD6350", Slot = "6")]
	public void HNIBDJMDFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD6480", Offset = "0x5AD4E80", VA = "0x185AD6480", Slot = "9")]
	public void KPJHAKFGFBB(Rigidbody ACKBNFBBKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x5AD6470", Offset = "0x5AD4E70", VA = "0x185AD6470", Slot = "7")]
	public void KAHCOLHEFIM(bool HOCNLDJLJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x5AD60A0", Offset = "0x5AD4AA0", VA = "0x185AD60A0", Slot = "8")]
	public void AGEBFPMMJEA(bool HOCNLDJLJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x5AD61E0", Offset = "0x5AD4BE0", VA = "0x185AD61E0", Slot = "10")]
	public bool CEHDPNMJOLM(Vector3 GNIANLFIOCO, out RaycastHit ANGKOJNCMIA, float AGKAIFMKLLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x5AD60B0", Offset = "0x5AD4AB0", VA = "0x185AD60B0")]
	private void BPFLJKCIEBA(bool HOCNLDJLJMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class BJPFJLOEPDH : IHEBEOFGNMA, IDisposable, KPFJBIMGOOA
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const int EEBKDDLBNMB = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly HIFMFONNJJL PALOPBGAJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private AIFDGFHGOFL FIOPHNAPPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private EIJNDDCMLGM MMHMBGCGCNH;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public AIFDGFHGOFL KPFOHJHFIIB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x5AC3CB0", Offset = "0x5AC26B0", VA = "0x185AC3CB0", Slot = "6")]
		get
		{
			return default(AIFDGFHGOFL);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x5AC3B70", Offset = "0x5AC2570", VA = "0x185AC3B70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Transform EJMAHPBGPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x5AC3C40", Offset = "0x5AC2640", VA = "0x185AC3C40", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<IJJPEDCHMLC, IJJPEDCHMLC> HMNEDFGDGIP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x5AC4170", Offset = "0x5AC2B70", VA = "0x185AC4170", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x5AC3DF0", Offset = "0x5AC27F0", VA = "0x185AC3DF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x5AC4270", Offset = "0x5AC2C70", VA = "0x185AC4270")]
	public BJPFJLOEPDH(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x5AC3E90", Offset = "0x5AC2890", VA = "0x185AC3E90", Slot = "8")]
	public void HNIBDJMDFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5AC3C60", Offset = "0x5AC2660", VA = "0x185AC3C60", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5AC4210", Offset = "0x5AC2C10", VA = "0x185AC4210", Slot = "11")]
	private void NFLDCPGILCL(IJJPEDCHMLC MFNDIHIAOHD, IJJPEDCHMLC BHIMKEHCCPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "12")]
	private void PPBHFDHHAOO(bool OIIJGABMEKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class KIDFHENKKDG : ALMDAKNNCFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly HIFMFONNJJL PALOPBGAJFN;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Rigidbody OMLJJMOAGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF830", Offset = "0x5ACE230", VA = "0x185ACF830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private bool LKJAOHPJMHA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x5AE0F00", Offset = "0x5ADF900", VA = "0x185AE0F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private bool APDKJKFGMHP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x5AD7E10", Offset = "0x5AD6810", VA = "0x185AD7E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private COAHBFHINFJ NLJMPCEPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x5AE11D0", Offset = "0x5ADFBD0", VA = "0x185AE11D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7070", Offset = "0x5AC5A70", VA = "0x185AC7070")]
	public KIDFHENKKDG(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x5AE1230", Offset = "0x5ADFC30", VA = "0x185AE1230", Slot = "4")]
	public void EEEMGOCGBED(Vector3 BFIMHHIKINE, ForceMode PFMKMOIPPCD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x5AE0F50", Offset = "0x5ADF950", VA = "0x185AE0F50")]
	private void BKKFANPGBDN(Vector3 BFIMHHIKINE, ForceMode PFMKMOIPPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x5AE1770", Offset = "0x5AE0170", VA = "0x185AE1770", Slot = "5")]
	public void PEICNGFMEKD(Vector3 BFIMHHIKINE, Vector3 LHCEFCJDGIJ, ForceMode PFMKMOIPPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x5AE1610", Offset = "0x5AE0010", VA = "0x185AE1610", Slot = "6")]
	public void HMDGDDGCCFL(Vector3 PIPIGKBLIGD, ForceMode PFMKMOIPPCD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x5AE0C80", Offset = "0x5ADF680", VA = "0x185AE0C80")]
	private void ACLPJGIOPAH(Vector3 PIPIGKBLIGD, ForceMode PFMKMOIPPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x5AE1390", Offset = "0x5ADFD90", VA = "0x185AE1390", Slot = "7")]
	public void GEHIBBCOGKG(Vector3 PIPIGKBLIGD, ForceMode PFMKMOIPPCD = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class DLPIHHBPEAH : EGJGFBDNEPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly HIFMFONNJJL PALOPBGAJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool PPJFNNMGJID;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool OBCEOAKDHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x80ADB0", Offset = "0x8097B0", VA = "0x18080ADB0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x5AC6EC0", Offset = "0x5AC58C0", VA = "0x185AC6EC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7070", Offset = "0x5AC5A70", VA = "0x185AC7070")]
	public DLPIHHBPEAH(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6FD0", Offset = "0x5AC59D0", VA = "0x185AC6FD0", Slot = "6")]
	public void KPJHAKFGFBB(Rigidbody ACKBNFBBKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x5AC7000", Offset = "0x5AC5A00", VA = "0x185AC7000", Slot = "7")]
	public void LCMOCMNDGKD(Rigidbody ACKBNFBBKOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class GDNMBNMNNJO : BNOGDBDCBKF, KEPEBEIEONO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly COAHBFHINFJ PALOPBGAJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<COAHBFHINFJ> GFIGBAPMFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private COAHBFHINFJ MNGLAEJHIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private COAHBFHINFJ EOBFGLJBCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Transform MNJFMFJBKNO;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private Transform CCKPELKPNKA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x5ACDD00", Offset = "0x5ACC700", VA = "0x185ACDD00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public COAHBFHINFJ NLJMPCEPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B40", Offset = "0x7D6540", VA = "0x1807D7B40", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x5ACDE00", Offset = "0x5ACC800", VA = "0x185ACDE00", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public COAHBFHINFJ ADLFAHHCAGF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x7D7940", Offset = "0x7D6340", VA = "0x1807D7940", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public IReadOnlyList<COAHBFHINFJ> PLEEMIOGEJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x7D7060", Offset = "0x7D5A60", VA = "0x1807D7060", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event IDBANGEEFOC FHNMFLEGKLF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE100", Offset = "0x5ACCB00", VA = "0x185ACE100", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x5ACEF90", Offset = "0x5ACD990", VA = "0x185ACEF90", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event IDBANGEEFOC KACABKHKGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x5ACDC60", Offset = "0x5ACC660", VA = "0x185ACDC60", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x5ACD440", Offset = "0x5ACBE40", VA = "0x185ACD440", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event BMBDIJCKKFM NDCGJGKOFAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x5ACD3A0", Offset = "0x5ACBDA0", VA = "0x185ACD3A0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x5ACDE90", Offset = "0x5ACC890", VA = "0x185ACDE90", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action JGBCBBLECPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE2E0", Offset = "0x5ACCCE0", VA = "0x185ACE2E0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE380", Offset = "0x5ACCD80", VA = "0x185ACE380", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action PLFEODELMBG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE600", Offset = "0x5ACD000", VA = "0x185ACE600", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE1A0", Offset = "0x5ACCBA0", VA = "0x185ACE1A0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<COAHBFHINFJ> LCFBPJEOADK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x5ACF030", Offset = "0x5ACDA30", VA = "0x185ACF030", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE240", Offset = "0x5ACCC40", VA = "0x185ACE240", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<COAHBFHINFJ> OCAKJFLNEGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x5ACD620", Offset = "0x5ACC020", VA = "0x185ACD620", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x5ACD4E0", Offset = "0x5ACBEE0", VA = "0x185ACD4E0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action MGCEPPELIDB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE4C0", Offset = "0x5ACCEC0", VA = "0x185ACE4C0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x5ACDD60", Offset = "0x5ACC760", VA = "0x185ACDD60", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<COAHBFHINFJ> CIILGHHGBIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE560", Offset = "0x5ACCF60", VA = "0x185ACE560", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE420", Offset = "0x5ACCE20", VA = "0x185ACE420", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x5ACF0D0", Offset = "0x5ACDAD0", VA = "0x185ACF0D0")]
	public GDNMBNMNNJO(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x5ACDE10", Offset = "0x5ACC810", VA = "0x185ACDE10", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD6C0", Offset = "0x5ACC0C0", VA = "0x185ACD6C0", Slot = "30")]
	public void CLOBJFNMHGM(COAHBFHINFJ KLJNAJJPMKN, bool BFNLLLADIAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x5ACED40", Offset = "0x5ACD740", VA = "0x185ACED40", Slot = "6")]
	public void PJDPLBPDOJA(COAHBFHINFJ ENLKANOCMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x5ACE8A0", Offset = "0x5ACD2A0", VA = "0x185ACE8A0", Slot = "7")]
	public void NMMGJMPGKPK(COAHBFHINFJ ENLKANOCMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD580", Offset = "0x5ACBF80", VA = "0x185ACD580", Slot = "4")]
	public void BMKFLEEHJJC(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x5ACE060", Offset = "0x5ACCA60", VA = "0x185ACE060", Slot = "5")]
	public void FMALHNNINDF(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x5ACE810", Offset = "0x5ACD210", VA = "0x185ACE810")]
	private void NJNBDEOPBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x5ACE7D0", Offset = "0x5ACD1D0", VA = "0x185ACE7D0")]
	private void NBAEKPGOBNP(COAHBFHINFJ ENLKANOCMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x5ACEBF0", Offset = "0x5ACD5F0", VA = "0x185ACEBF0")]
	private void OJMONMHAGCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x5ACE6A0", Offset = "0x5ACD0A0", VA = "0x185ACE6A0")]
	private void LPJKPCAALCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x5ACDF30", Offset = "0x5ACC930", VA = "0x185ACDF30")]
	private void FMAGMBLFOAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x5ACEB00", Offset = "0x5ACD500", VA = "0x185ACEB00")]
	[CompilerGenerated]
	private object OEFOEEJKCNP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class MDGBMLIIEAH
{
	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x5AE1FA0", Offset = "0x5AE09A0", VA = "0x185AE1FA0")]
	public static BNOGDBDCBKF HHNHIPIOBHC(this COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class OHMPMPKDIPI : ANJDAHJGPLG, DJGACNAABHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly HIFMFONNJJL PALOPBGAJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly global::INFEPAMAGFB<COAHBFHINFJ> FIBEKAAIGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool KBFMADDABPP;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public global::INFEPAMAGFB<COAHBFHINFJ> JIGEOOKHDKP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Vector3 CCOEDOIODMG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x5AEA190", Offset = "0x5AE8B90", VA = "0x185AEA190", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public Vector3 NOCJNDBDOAC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x5AEA2A0", Offset = "0x5AE8CA0", VA = "0x185AEA2A0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private Vector3 MBKHAGELNKC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x5AEA1C0", Offset = "0x5AE8BC0", VA = "0x185AEA1C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public COAHBFHINFJ FBFJBKHAAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x5AE9D40", Offset = "0x5AE8740", VA = "0x185AE9D40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA4E0", Offset = "0x5AE8EE0", VA = "0x185AEA4E0")]
	public OHMPMPKDIPI(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x5AEA470", Offset = "0x5AE8E70", VA = "0x185AEA470", Slot = "8")]
	public void PBJAEJPGKCB(COAHBFHINFJ EOBFGLJBCIJ, object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x5AE9990", Offset = "0x5AE8390", VA = "0x185AE9990", Slot = "9")]
	public void BJDINJFLCGP(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x5AE99F0", Offset = "0x5AE83F0", VA = "0x185AE99F0")]
	private Vector3 CHFOAJPHIFB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x5AE9DF0", Offset = "0x5AE87F0", VA = "0x185AE9DF0")]
	private void EKPGMMOEDEK(COAHBFHINFJ IIFNPLLOOGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class FPFOPDHODLB
{
	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD2E0", Offset = "0x5ACBCE0", VA = "0x185ACD2E0")]
	public static ANJDAHJGPLG GMIFEAAGMNB(this COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class MMEMEMKCAHO : FEOHBKJLJBH, MKIPBOEDJDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly HIFMFONNJJL PALOPBGAJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly OverridableVector3 BNNHCKIABAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly OverridableVector3 EGPHBDFHDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float MOKFCAHNAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private float LCIGAPICOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Vector3 FAJNPDIOIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Vector3? LLOCHGNGKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Quaternion? FIMLOJEIEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool IKNHLCNPIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool BAJDPEMMGIC;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 HHPIFJCOOGE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xDEE920", Offset = "0xDED320", VA = "0x180DEE920", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x5AE2C80", Offset = "0x5AE1680", VA = "0x185AE2C80", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 GGIEIBKNPGB
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x5AE4300", Offset = "0x5AE2D00", VA = "0x185AE4300", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float PADHGHJLJDM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x8C3860", Offset = "0x8C2260", VA = "0x1808C3860", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x5AE28D0", Offset = "0x5AE12D0", VA = "0x185AE28D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public float EAKNKCMIHOB
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x9D1A20", Offset = "0x9D0420", VA = "0x1809D1A20", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x5AE4970", Offset = "0x5AE3370", VA = "0x185AE4970", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Vector3 HDCBDKOIDPH
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x5AE4720", Offset = "0x5AE3120", VA = "0x185AE4720", Slot = "13")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x5AE4580", Offset = "0x5AE2F80", VA = "0x185AE4580", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public Quaternion PNOHMMCCAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x5AE2760", Offset = "0x5AE1160", VA = "0x185AE2760", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x5AE29F0", Offset = "0x5AE13F0", VA = "0x185AE29F0", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody OMLJJMOAGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x5ACC910", Offset = "0x5ACB310", VA = "0x185ACC910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event IDBANGEEFOC EMALNHCGFCO
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x5AE4990", Offset = "0x5AE3390", VA = "0x185AE4990", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x5AE4260", Offset = "0x5AE2C60", VA = "0x185AE4260", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x5AE50E0", Offset = "0x5AE3AE0", VA = "0x185AE50E0")]
	public MMEMEMKCAHO(COAHBFHINFJ PALOPBGAJFN, in OFBIGENLNDL MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x5AE4F20", Offset = "0x5AE3920", VA = "0x185AE4F20", Slot = "18")]
	public void OGAPPILJDFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x5AE4890", Offset = "0x5AE3290", VA = "0x185AE4890", Slot = "17")]
	public void GFJEIFADKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x5AE4A30", Offset = "0x5AE3430", VA = "0x185AE4A30", Slot = "20")]
	public void KPJHAKFGFBB(Rigidbody ACKBNFBBKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x5AE4B10", Offset = "0x5AE3510", VA = "0x185AE4B10", Slot = "21")]
	public void LCMOCMNDGKD(Rigidbody ACKBNFBBKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x5AE4DB0", Offset = "0x5AE37B0", VA = "0x185AE4DB0", Slot = "19")]
	public void NHEHBCMANCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x5AE3DA0", Offset = "0x5AE27A0", VA = "0x185AE3DA0", Slot = "22")]
	public void CCBHJNAJCPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x5AE2C80", Offset = "0x5AE1680", VA = "0x185AE2C80")]
	private void MIFGEBHLHAH(Vector3 MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x5AE2B90", Offset = "0x5AE1590", VA = "0x185AE2B90")]
	private Vector3 BEKACJMHMPB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x5AE28D0", Offset = "0x5AE12D0", VA = "0x185AE28D0")]
	private void BCFECMBGIMK(float MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x5AE4970", Offset = "0x5AE3370", VA = "0x185AE4970")]
	private void OJFGCJEFEBN(float MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x5AE4400", Offset = "0x5AE2E00", VA = "0x185AE4400")]
	private Vector3 FMIMGBHGCBM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x5AE4580", Offset = "0x5AE2F80", VA = "0x185AE4580")]
	private void FNJLCCBFLMD(Vector3 MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x5AE2CA0", Offset = "0x5AE16A0", VA = "0x185AE2CA0")]
	private Quaternion BMKAKLPJGMM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x5AE29F0", Offset = "0x5AE13F0", VA = "0x185AE29F0")]
	private void BEBICDKDHMI(Quaternion MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x5AE3CC0", Offset = "0x5AE26C0", VA = "0x185AE3CC0")]
	public void BPJJLOCIGPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x5AE2E00", Offset = "0x5AE1800", VA = "0x185AE2E00", Slot = "4")]
	public (float, Vector3) BPJJLOCIGPG(Rigidbody DKLCELDOMIF)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class DDONHMNEDLF
{
	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6290", Offset = "0x5AC4C90", VA = "0x185AC6290")]
	public static FEOHBKJLJBH PEFNAECIBIG(this COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class MIFBNOPOAGI : IKEFBCLFODA
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private const string MHDBNEAAAKE = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly HIFMFONNJJL PALOPBGAJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly MLJMKOJHCLB AKNKDCJPCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly INDOICOKDMJ MALPDEENGOC;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool CCBOLEPEIFN
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x2300210", Offset = "0x22FEC10", VA = "0x182300210", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public INDOICOKDMJ AJLEGAJMBED
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CF0", Offset = "0x7D26F0", VA = "0x1807D3CF0", Slot = "5")]
		get
		{
			return default(INDOICOKDMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x5AE2670", Offset = "0x5AE1070", VA = "0x185AE2670")]
	public MIFBNOPOAGI(COAHBFHINFJ PALOPBGAJFN, in OFBIGENLNDL MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x5AE21B0", Offset = "0x5AE0BB0", VA = "0x185AE21B0", Slot = "6")]
	public void HNIBDJMDFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x5AE2530", Offset = "0x5AE0F30", VA = "0x185AE2530")]
	private bool MFGKMMDONJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x5AE25D0", Offset = "0x5AE0FD0", VA = "0x185AE25D0", Slot = "7")]
	public void NAPJGOOENPP(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x5AE2640", Offset = "0x5AE1040", VA = "0x185AE2640", Slot = "8")]
	public void OJLMLLFFDMC(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x5AE2400", Offset = "0x5AE0E00", VA = "0x185AE2400", Slot = "11")]
	public void MDMJKJBLKHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x5AE20A0", Offset = "0x5AE0AA0", VA = "0x185AE20A0")]
	private void GEJKKCAAGBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x5AE2280", Offset = "0x5AE0C80", VA = "0x185AE2280")]
	private void KDJBBCOBJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x5AE2060", Offset = "0x5AE0A60", VA = "0x185AE2060", Slot = "10")]
	public void CHHKBIKAIGD(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x5AE2600", Offset = "0x5AE1000", VA = "0x185AE2600", Slot = "9")]
	public void NJEDOOPKMBA(COAHBFHINFJ PALOPBGAJFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class JINDNIDLGJC : OBINMAACDBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly HIFMFONNJJL PALOPBGAJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly MLJMKOJHCLB MCKAPHPGMDF;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool LKJAOHPJMHA
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x5ADD700", Offset = "0x5ADC100", VA = "0x185ADD700", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IEnumerable<object> FBHCFIEFDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x5ADDB50", Offset = "0x5ADC550", VA = "0x185ADDB50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event IDBANGEEFOC MGPMICPPGPB
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x5ADD9B0", Offset = "0x5ADC3B0", VA = "0x185ADD9B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x5ADDAB0", Offset = "0x5ADC4B0", VA = "0x185ADDAB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x5ADDC20", Offset = "0x5ADC620", VA = "0x185ADDC20")]
	public JINDNIDLGJC(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x5ADDA50", Offset = "0x5ADC450", VA = "0x185ADDA50", Slot = "11")]
	public IDisposable GLHGEKDKPPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x5ADD8D0", Offset = "0x5ADC2D0", VA = "0x185ADD8D0", Slot = "8")]
	public void FDHBMAEMFGJ(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x5ADD7C0", Offset = "0x5ADC1C0", VA = "0x185ADD7C0", Slot = "9")]
	public void BILHHPDCDKM(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x5ADD7D0", Offset = "0x5ADC1D0", VA = "0x185ADD7D0", Slot = "10")]
	public void DCKOMBAMFDF(object HMAOAMDKNDD, bool OHANDDCLMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x5ADDB70", Offset = "0x5ADC570", VA = "0x185ADDB70", Slot = "12")]
	public void KPJHAKFGFBB(Rigidbody LHAKPCGHEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x5ADDBF0", Offset = "0x5ADC5F0", VA = "0x185ADDBF0", Slot = "13")]
	public void LCMOCMNDGKD(Rigidbody ACKBNFBBKOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class CDEEAJKBNMG : DCMCHJPIMDM, MAIEJCNIIBN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly HIFMFONNJJL PALOPBGAJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private PhotonView ONJFDBACIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool DGHKDMOPCBL;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public PhotonView LNKCNEENEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool PNPAICFFMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x5AC53F0", Offset = "0x5AC3DF0", VA = "0x185AC53F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool EJPMOLMBFPC
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x856FD0", Offset = "0x8559D0", VA = "0x180856FD0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event IDBANGEEFOC HEBMBPDHBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x5AC51C0", Offset = "0x5AC3BC0", VA = "0x185AC51C0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x5AC4930", Offset = "0x5AC3330", VA = "0x185AC4930", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5410", Offset = "0x5AC3E10", VA = "0x185AC5410")]
	public CDEEAJKBNMG(COAHBFHINFJ PALOPBGAJFN, in OFBIGENLNDL MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x5AC4DF0", Offset = "0x5AC37F0", VA = "0x185AC4DF0", Slot = "9")]
	public void HNIBDJMDFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x5AC4CE0", Offset = "0x5AC36E0", VA = "0x185AC4CE0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5260", Offset = "0x5AC3C60", VA = "0x185AC5260", Slot = "10")]
	public void NAJOGAHKIEE(COAHBFHINFJ EOBFGLJBCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x5AC4B50", Offset = "0x5AC3550", VA = "0x185AC4B50", Slot = "11")]
	public void DKLKECNJIAP(COAHBFHINFJ EOBFGLJBCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x5AC49D0", Offset = "0x5AC33D0", VA = "0x185AC49D0")]
	private void APCGBJPFCIL(PhotonView ALJNKDMCHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x5AC47C0", Offset = "0x5AC31C0", VA = "0x185AC47C0")]
	private void ACIONEDBIPE(RigidbodyEx BGDEOJDCKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x5AC4F40", Offset = "0x5AC3940", VA = "0x185AC4F40")]
	private void IFCBNHOEAFB(PhotonView JANADLHNPPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class JFLMEIDLOMH
{
	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9D60", Offset = "0x5AD8760", VA = "0x185AD9D60")]
	public static DCMCHJPIMDM NOIKFDKCMFG(this COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class PADGNKAGOGC : PKJGDCALGBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly HIFMFONNJJL PALOPBGAJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private RigidbodyConstraints IHKKDCFLCHA;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool MNBOPCHPOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x8EBEB0", Offset = "0x8EA8B0", VA = "0x1808EBEB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x8EBCB0", Offset = "0x8EA6B0", VA = "0x1808EBCB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool GLGCOGBLPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x8EBCA0", Offset = "0x8EA6A0", VA = "0x1808EBCA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x8EBCC0", Offset = "0x8EA6C0", VA = "0x1808EBCC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public RigidbodyConstraints LBIHCKGJNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x767550", Offset = "0x765F50", VA = "0x180767550", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x5AEB220", Offset = "0x5AE9C20", VA = "0x185AEB220", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB3C0", Offset = "0x5AE9DC0", VA = "0x185AEB3C0")]
	public PADGNKAGOGC(COAHBFHINFJ PALOPBGAJFN, in OFBIGENLNDL MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB360", Offset = "0x5AE9D60", VA = "0x185AEB360", Slot = "9")]
	public void KPJHAKFGFBB(Rigidbody ACKBNFBBKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x5AEB390", Offset = "0x5AE9D90", VA = "0x185AEB390", Slot = "10")]
	public void LCMOCMNDGKD(Rigidbody ACKBNFBBKOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class ECEFINAEPOI : BHMIPOFDPEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly COAHBFHINFJ PALOPBGAJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private float ANBFJKDEKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float HPCKAGPDAKC;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public float DKMCCCEGGBH
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xAEC0F0", Offset = "0xAEAAF0", VA = "0x180AEC0F0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x5AC8940", Offset = "0x5AC7340", VA = "0x185AC8940", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public float DNJAHBCJABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x856FB0", Offset = "0x8559B0", VA = "0x180856FB0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x5AC8A10", Offset = "0x5AC7410", VA = "0x185AC8A10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x5AC8BD0", Offset = "0x5AC75D0", VA = "0x185AC8BD0")]
	public ECEFINAEPOI(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x5AC8AE0", Offset = "0x5AC74E0", VA = "0x185AC8AE0", Slot = "8")]
	public void KPJHAKFGFBB(Rigidbody ACKBNFBBKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x5AC8B30", Offset = "0x5AC7530", VA = "0x185AC8B30", Slot = "9")]
	public void LCMOCMNDGKD(Rigidbody ACKBNFBBKOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class FKCPBHEBPLB : LEABOMDCKNB
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private const int AIIMKOKGGLK = 10;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const float KHCDIABCJFJ = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const float GGDLAAELDHB = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private const float NIDAJINFEKM = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly HIFMFONNJJL PALOPBGAJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool KFGODFNDMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool KGEEOOOIDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int AJPOOPPDOPK;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private Rigidbody OMLJJMOAGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x5ACC910", Offset = "0x5ACB310", VA = "0x185ACC910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private bool HALMCOFHIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x5ACC560", Offset = "0x5ACAF60", VA = "0x185ACC560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private bool FKIBJJIHGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x5ACC750", Offset = "0x5ACB150", VA = "0x185ACC750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private COAHBFHINFJ NLJMPCEPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x5ACC770", Offset = "0x5ACB170", VA = "0x185ACC770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool APDKJKFGMHP
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x5ACD040", Offset = "0x5ACBA40", VA = "0x185ACD040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event IDBANGEEFOC EAJDOHBLDEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x5ACC870", Offset = "0x5ACB270", VA = "0x185ACC870", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x5ACC7D0", Offset = "0x5ACB1D0", VA = "0x185ACC7D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD250", Offset = "0x5ACBC50", VA = "0x185ACD250")]
	public FKCPBHEBPLB(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCA50", Offset = "0x5ACB450", VA = "0x185ACCA50", Slot = "6")]
	public void HNIBDJMDFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCA40", Offset = "0x5ACB440", VA = "0x185ACCA40", Slot = "8")]
	public void GEFJBHOINKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x5ACC600", Offset = "0x5ACB000", VA = "0x185ACC600", Slot = "7")]
	public bool BIOLEFGLELD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x5ACC9A0", Offset = "0x5ACB3A0", VA = "0x185ACC9A0", Slot = "9")]
	public void FKCCMPCDICG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCFA0", Offset = "0x5ACB9A0", VA = "0x185ACCFA0", Slot = "11")]
	public void NEBOODLLBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5ACC960", Offset = "0x5ACB360", VA = "0x185ACC960", Slot = "12")]
	public void EHAEKEPECIJ(bool CCNCEDMACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCAE0", Offset = "0x5ACB4E0", VA = "0x185ACCAE0", Slot = "10")]
	public void KLEAIMMHIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x5ACD0A0", Offset = "0x5ACBAA0", VA = "0x185ACD0A0")]
	private bool NNKPHKGNDCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x5ACCE10", Offset = "0x5ACB810", VA = "0x185ACCE10")]
	private void MJCLKPNNMGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class INMBJCDKBBH : FLBBEGCCDPK
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const string JMFDJOLHGHG = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly HIFMFONNJJL PALOPBGAJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly MLJMKOJHCLB EIBENJKBCIN;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Rigidbody OMLJJMOAGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x831AC0", Offset = "0x8304C0", VA = "0x180831AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private bool APDKJKFGMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x5AD7E10", Offset = "0x5AD6810", VA = "0x185AD7E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9C70", Offset = "0x5AD8670", VA = "0x185AD9C70")]
	public INMBJCDKBBH(COAHBFHINFJ PALOPBGAJFN, in OFBIGENLNDL MNILNHMNKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9450", Offset = "0x5AD7E50", VA = "0x185AD9450", Slot = "5")]
	public void HNIBDJMDFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5AD98E0", Offset = "0x5AD82E0", VA = "0x185AD98E0", Slot = "6")]
	public void MDJKOOAEJGP(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9700", Offset = "0x5AD8100", VA = "0x185AD9700", Slot = "7")]
	public void JNAKANEBFGD(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9910", Offset = "0x5AD8310", VA = "0x185AD9910", Slot = "8")]
	public void ODDJBGMPAHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9500", Offset = "0x5AD7F00", VA = "0x185AD9500", Slot = "9")]
	public void JLPFPMGKIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x5AD8C80", Offset = "0x5AD7680", VA = "0x185AD8C80", Slot = "10")]
	public void ANOJPKEOEOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x5AD8FB0", Offset = "0x5AD79B0", VA = "0x185AD8FB0", Slot = "11")]
	public void HFEDMBGBACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5AD9730", Offset = "0x5AD8130", VA = "0x185AD9730")]
	private void KALPCNPFLEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x5AD8E00", Offset = "0x5AD7800", VA = "0x185AD8E00")]
	private void GOCIGAOOPNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class JPAPPLCIDIG : IJCAKKDCEJD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly HIFMFONNJJL PALOPBGAJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly MLJMKOJHCLB PPOOMJDPNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float OCLKGPEOGDJ;

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public OAAJJMEKKCO FOHFKKLNCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB60", Offset = "0x7D9560", VA = "0x1807DAB60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public NGGEJBJJIOA ONFHFHJINDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D2D70", VA = "0x1807D4370", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public Vector3 MBKHAGELNKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x5ADFBD0", Offset = "0x5ADE5D0", VA = "0x185ADFBD0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x5ADDEC0", Offset = "0x5ADC8C0", VA = "0x185ADDEC0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public Vector3 PNMFHCHJLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x5ADEDE0", Offset = "0x5ADD7E0", VA = "0x185ADEDE0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x5ADF710", Offset = "0x5ADE110", VA = "0x185ADF710", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 MKCBJFMHIAP
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x5ADEED0", Offset = "0x5ADD8D0", VA = "0x185ADEED0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x5AE0630", Offset = "0x5ADF030", VA = "0x185AE0630", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public Vector3 CLGPPIAECCK
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x5AE09C0", Offset = "0x5ADF3C0", VA = "0x185AE09C0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x5ADF870", Offset = "0x5ADE270", VA = "0x185ADF870", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public float JBJNCHGJKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7D2AD0", Offset = "0x7D14D0", VA = "0x1807D2AD0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x5ADE040", Offset = "0x5ADCA40", VA = "0x185ADE040", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public bool EMAEPLLIHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x30C1E10", Offset = "0x30C0810", VA = "0x1830C1E10", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private ALMDAKNNCFI GBNEKFAJJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x29EBD40", Offset = "0x29EA740", VA = "0x1829EBD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private bool FKIBJJIHGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x5AC9680", Offset = "0x5AC8080", VA = "0x185AC9680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x5AE0AB0", Offset = "0x5ADF4B0", VA = "0x185AE0AB0")]
	public JPAPPLCIDIG(COAHBFHINFJ PALOPBGAJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x5ADEA20", Offset = "0x5ADD420", VA = "0x185ADEA20", Slot = "19")]
	public void HNIBDJMDFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x5ADEA90", Offset = "0x5ADD490", VA = "0x185ADEA90", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x5ADF740", Offset = "0x5ADE140", VA = "0x185ADF740", Slot = "28")]
	public void KPJHAKFGFBB(Rigidbody ACKBNFBBKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x25D1DD0", Offset = "0x25D07D0", VA = "0x1825D1DD0", Slot = "20")]
	public void OFEAGCJBKIE(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x25D2250", Offset = "0x25D0C50", VA = "0x1825D2250", Slot = "31")]
	public void JHLGMNKNLCL(object HMAOAMDKNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x5ADE300", Offset = "0x5ADCD00", VA = "0x185ADE300", Slot = "36")]
	public Vector3 BKPNHLFHBLJ(Vector3 GELONNAFHPN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x5ADDD00", Offset = "0x5ADC700", VA = "0x185ADDD00", Slot = "35")]
	public Vector3 AFLKIDCHEPD(Vector3 NKKNGNHELCP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x5ADEA20", Offset = "0x5ADD420", VA = "0x185ADEA20", Slot = "27")]
	public void DOGPHMJJOMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x5ADF5E0", Offset = "0x5ADDFE0", VA = "0x185ADF5E0", Slot = "25")]
	public void JOPHKGJJEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x5ADF4B0", Offset = "0x5ADDEB0", VA = "0x185ADF4B0", Slot = "24")]
	public void JGDGGMLOEEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x5ADF140", Offset = "0x5ADDB40", VA = "0x185ADF140", Slot = "34")]
	public void IKHGBFBJDEA(Vector3 GMNCBDPBBLL, Vector3 CAEAHDMGPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5ADE160", Offset = "0x5ADCB60", VA = "0x185ADE160", Slot = "33")]
	public void BIPMBCHIBJM(Vector3 JJEOGAGCOIH, Vector3 OBAPNEEPMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x5ADE1C0", Offset = "0x5ADCBC0", VA = "0x185ADE1C0", Slot = "32")]
	public void BKNOFAAHKIP(Vector3 NBKMOPIFBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5ADE4E0", Offset = "0x5ADCEE0", VA = "0x185ADE4E0", Slot = "22")]
	public void CPBCIKEJEFA(KDLFENIMCAA NALNFBLFJEL, Vector3 ACKJBHOBHDH, float MEEIIJPJJBC, float JHBPAKGIBHB = 8f, float LJLGEELHOJE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x5ADEAF0", Offset = "0x5ADD4F0", VA = "0x185ADEAF0", Slot = "21")]
	public void EHGOOBAPJML(ELMJFFPDDAN KLDJNIPILLN, Vector3 BCFGIAPFKKB, float OKLEEHKJJBA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x5AE06F0", Offset = "0x5ADF0F0", VA = "0x185AE06F0", Slot = "23")]
	[Obsolete]
	public void NMKJNOACPKB(ELMJFFPDDAN KLDJNIPILLN, Vector3 FDBNIAOOEMB, float HBOOAGHCBND = 7f, float BKMDHMBHOBP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x5ADED20", Offset = "0x5ADD720", VA = "0x185ADED20", Slot = "30")]
	public Vector3 EKHCFAGKJAA(Vector3 PBLNDACCBGI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x5ADF4F0", Offset = "0x5ADDEF0", VA = "0x185ADF4F0", Slot = "29")]
	public Vector3 JMCMOBNNEMD(Vector3 LOMDGDKPDKD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x5ADF380", Offset = "0x5ADDD80", VA = "0x185ADF380", Slot = "26")]
	public void IODHOHMNIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x5ADE040", Offset = "0x5ADCA40", VA = "0x185ADE040")]
	private void BHOAJPBFJEB(float MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x5ADF000", Offset = "0x5ADDA00", VA = "0x185ADF000")]
	private void ICDHBABCJFM(Vector3 BCFGIAPFKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x5ADF620", Offset = "0x5ADE020", VA = "0x185ADF620")]
	private Vector3 KKIKOGNDAFK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x5ADF8A0", Offset = "0x5ADE2A0", VA = "0x185ADF8A0")]
	private void LPJAFENFIEO(Vector3 NKKNGNHELCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x5ADE930", Offset = "0x5ADD330", VA = "0x185ADE930")]
	private Vector3 DHOHLCHHEGL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x5ADFCF0", Offset = "0x5ADE6F0", VA = "0x185ADFCF0")]
	private void MJLNPICKPDO(Vector3 MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x5AE0030", Offset = "0x5ADEA30", VA = "0x185AE0030")]
	private void MOEFHPPIAOP(Vector3 NKKNGNHELCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x5ADDF80", Offset = "0x5ADC980", VA = "0x185ADDF80")]
	private void ALHEDMHPIFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class DADPCCIHIFI : BDGACHFDAAD
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5F30", Offset = "0x5AC4930", VA = "0x185AC5F30", Slot = "4")]
	public KEPEBEIEONO LLFOFDPPPEH(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x5AC57B0", Offset = "0x5AC41B0", VA = "0x185AC57B0", Slot = "5")]
	public IJCAKKDCEJD BOOAJPBGFCJ(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5A50", Offset = "0x5AC4450", VA = "0x185AC5A50", Slot = "6")]
	public DJGACNAABHP DEKGIBJDDEA(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6220", Offset = "0x5AC4C20", VA = "0x185AC6220", Slot = "7")]
	public BHMIPOFDPEF PPKKMOKPHMH(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5990", Offset = "0x5AC4390", VA = "0x185AC5990", Slot = "8")]
	public LEABOMDCKNB CKBCPEEIFMM(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5E70", Offset = "0x5AC4870", VA = "0x185AC5E70", Slot = "9")]
	public IHEBEOFGNMA LFPCDGDGHAA(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x5AC56B0", Offset = "0x5AC40B0", VA = "0x185AC56B0", Slot = "10")]
	public OBINMAACDBO ANJBKMGAONL(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6170", Offset = "0x5AC4B70", VA = "0x185AC6170", Slot = "11")]
	public ALMDAKNNCFI PDIOMEDJEAD(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x5AC6010", Offset = "0x5AC4A10", VA = "0x185AC6010", Slot = "12")]
	public OLPBGKDBBKJ MBHPECPBGKJ(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x5AC60C0", Offset = "0x5AC4AC0", VA = "0x185AC60C0", Slot = "13")]
	public EGJGFBDNEPH NBLJJLHMPHB(COAHBFHINFJ NPGEFAIHGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5C30", Offset = "0x5AC4630", VA = "0x185AC5C30")]
	public FLBBEGCCDPK ELAPBOIDLMJ(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x5AC58C0", Offset = "0x5AC42C0", VA = "0x185AC58C0")]
	public MAIEJCNIIBN CEFAJHJADHC(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5D50", Offset = "0x5AC4750", VA = "0x185AC5D50")]
	public IKEFBCLFODA IKMDFEKNPBJ(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x5AC55B0", Offset = "0x5AC3FB0", VA = "0x185AC55B0")]
	public MKIPBOEDJDF AHJJEEACDHH(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5B60", Offset = "0x5AC4560", VA = "0x185AC5B60")]
	public PKJGDCALGBM JDPIOHJNDBJ(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5500", Offset = "0x5AC3F00", VA = "0x185AC5500", Slot = "19")]
	public COAHBFHINFJ AHDJIEGMHLB(RigidbodyEx PALOPBGAJFN, OFBIGENLNDL MNILNHMNKJK, GMOFJHOBHHJ KONLJOKGCCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public DADPCCIHIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5C30", Offset = "0x5AC4630", VA = "0x185AC5C30", Slot = "14")]
	private FLBBEGCCDPK JBJHDNHNDNJ(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x5AC58C0", Offset = "0x5AC42C0", VA = "0x185AC58C0", Slot = "15")]
	private MAIEJCNIIBN PGACBBAIJMO(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5D50", Offset = "0x5AC4750", VA = "0x185AC5D50", Slot = "16")]
	private IKEFBCLFODA HKBAKONKOGM(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x5AC55B0", Offset = "0x5AC3FB0", VA = "0x185AC55B0", Slot = "17")]
	private MKIPBOEDJDF OPFOBNJHMII(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x5AC5B60", Offset = "0x5AC4560", VA = "0x185AC5B60", Slot = "18")]
	private PKJGDCALGBM DGHOIAMPHOM(COAHBFHINFJ NPGEFAIHGBA, in OFBIGENLNDL MNILNHMNKJK)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[Preserve]
	internal class _RRAssemblyIndex : IAAKGJNKLFL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x6A9A550", Offset = "0x6A98F50", VA = "0x186A9A550", Slot = "6")]
		public sealed override void DCGFCAGLEEJ(FOBODKDCELK KFICNKMCGGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x6A9A4C0", Offset = "0x6A98EC0", VA = "0x186A9A4C0", Slot = "4")]
		public sealed override void BGMNFOJPGJK()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class NNIFMOPFNIE
{
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static byte[] FNNHBCFPBIC;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static int IPKGAJADJFC;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static int DIJMLDGECMG;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static BigInteger DGOGINAIMEE;

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public NNIFMOPFNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x5AE6D90", Offset = "0x5AE5790", VA = "0x185AE6D90")]
	private static string DAIOEIOFDHG(byte[] LPDJCHOFJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x5AE6EA0", Offset = "0x5AE58A0", VA = "0x185AE6EA0")]
	public static string LIOEFPBPBEO(byte[] AHIMNOMEIMA, bool ADOOPHPHCDD)
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
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
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
