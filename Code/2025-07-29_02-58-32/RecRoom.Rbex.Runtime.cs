using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.ObjectModel;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8B2BEA0", Offset = "0x8B2A8A0", VA = "0x188B2BEA0", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84C6920", Offset = "0x84C5320", VA = "0x1884C6920", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8B34A10", Offset = "0x8B33410", VA = "0x188B34A10")]
		private void JKAPILFGJLE(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8B34D10", Offset = "0x8B33710", VA = "0x188B34D10", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8B34D70", Offset = "0x8B33770", VA = "0x188B34D70")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, GAMCEIADCLK, DFEHPODJAJA, PFKAIMLHHGG
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly MEBJEIOEDLD KIAABGJELPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool INECMJMEOGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private MMLAFIMCODN JLDIOICDEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[MICOBDMLFEG(MGLGMLBODOF.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[MICOBDMLFEG(MGLGMLBODOF.SelfAndParent, true, false, false)]
		private RRNetworkView rrNetworkView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private EJPCFNJKDCP physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Transform BIFOCPBCDHJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal MMLAFIMCODN EJHJDCLJFLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8B30320", Offset = "0x8B2ED20", VA = "0x188B30320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private MMLAFIMCODN IDIDKIHKNNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int HLBJDIIHOPD
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8B31F20", Offset = "0x8B30920", VA = "0x188B31F20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx IEFLHLCKJEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8B32280", Offset = "0x8B30C80", VA = "0x188B32280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx BDILIHENIPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8B321C0", Offset = "0x8B30BC0", VA = "0x188B321C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx DFKFFPKHNCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8B32E80", Offset = "0x8B31880", VA = "0x188B32E80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8B34380", Offset = "0x8B32D80", VA = "0x188B34380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool HAAHJMNIMKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8744E60", Offset = "0x8743860", VA = "0x188744E60", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x87430D0", Offset = "0x8741AD0", VA = "0x1887430D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform EOBBLENOIHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x24F0CC0", Offset = "0x24EF6C0", VA = "0x1824F0CC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform MBAKIFGOKBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x24F0CC0", Offset = "0x24EF6C0", VA = "0x1824F0CC0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform DHCIHHENNMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x24F0CC0", Offset = "0x24EF6C0", VA = "0x1824F0CC0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public OGPMHIGIIEC JLPNBOJDJOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8B31F80", Offset = "0x8B30980", VA = "0x188B31F80")]
			get
			{
				return default(OGPMHIGIIEC);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8B33B30", Offset = "0x8B32530", VA = "0x188B33B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool ADGOFAPFAGI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8B32590", Offset = "0x8B30F90", VA = "0x188B32590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool DOBFHAMEJEM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8B320A0", Offset = "0x8B30AA0", VA = "0x188B320A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public DGLAKMOPOGI LIJEDFPFLKK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8B324D0", Offset = "0x8B30ED0", VA = "0x188B324D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8B33CF0", Offset = "0x8B326F0", VA = "0x188B33CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public OHIMHKLKCME KKPKJPAGCNB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8B32470", Offset = "0x8B30E70", VA = "0x188B32470")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8B33C80", Offset = "0x8B32680", VA = "0x188B33C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ANIFKINJJBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8B323C0", Offset = "0x8B30DC0", VA = "0x188B323C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody LJNAKNEMDOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8B32420", Offset = "0x8B30E20", VA = "0x188B32420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool KNHCPPDKNII
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8B32100", Offset = "0x8B30B00", VA = "0x188B32100")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8B33BA0", Offset = "0x8B325A0", VA = "0x188B33BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool JPKPGHFIBEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x87440C0", Offset = "0x8742AC0", VA = "0x1887440C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float KFPCCKLODAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8B32E20", Offset = "0x8B31820", VA = "0x188B32E20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float KDAIFIBAGKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8B32DC0", Offset = "0x8B317C0", VA = "0x188B32DC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8B34310", Offset = "0x8B32D10", VA = "0x188B34310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float GOBMCPDJAGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8B327F0", Offset = "0x8B311F0", VA = "0x188B327F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8B33F90", Offset = "0x8B32990", VA = "0x188B33F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float PPMELLOMIIG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8B325F0", Offset = "0x8B30FF0", VA = "0x188B325F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8B33D60", Offset = "0x8B32760", VA = "0x188B33D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool AMLLLOCNFCP
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8B333D0", Offset = "0x8B31DD0", VA = "0x188B333D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8B348C0", Offset = "0x8B332C0", VA = "0x188B348C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 ALMJDPCGOGC
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8B32BA0", Offset = "0x8B315A0", VA = "0x188B32BA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8B340E0", Offset = "0x8B32AE0", VA = "0x188B340E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 EJFCBBHCJOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8B33510", Offset = "0x8B31F10", VA = "0x188B33510")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode PFKKGAEKGEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8B32730", Offset = "0x8B31130", VA = "0x188B32730")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8B33EB0", Offset = "0x8B328B0", VA = "0x188B33EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float LDCEPJGJJPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8B32160", Offset = "0x8B30B60", VA = "0x188B32160")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8B33C10", Offset = "0x8B32610", VA = "0x188B33C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints AMKDAJKEPNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8B32790", Offset = "0x8B31190", VA = "0x188B32790")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8B33F20", Offset = "0x8B32920", VA = "0x188B33F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 GNFMDLOMDCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8B32F40", Offset = "0x8B31940", VA = "0x188B32F40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 HBOGNNFEJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8B32F40", Offset = "0x8B31940", VA = "0x188B32F40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8B346A0", Offset = "0x8B330A0", VA = "0x188B346A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float HIEAAJPFMEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8B32C80", Offset = "0x8B31680", VA = "0x188B32C80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8B341C0", Offset = "0x8B32BC0", VA = "0x188B341C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float HDKACHDMDCL
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8B33370", Offset = "0x8B31D70", VA = "0x188B33370")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8B34850", Offset = "0x8B33250", VA = "0x188B34850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion ADNMJLNKCHA
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8B33020", Offset = "0x8B31A20", VA = "0x188B33020")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8B34420", Offset = "0x8B32E20", VA = "0x188B34420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion NEGOMNLGDAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8B332A0", Offset = "0x8B31CA0", VA = "0x188B332A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8B34780", Offset = "0x8B33180", VA = "0x188B34780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 JBHCKAJABEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8B330F0", Offset = "0x8B31AF0", VA = "0x188B330F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8B344F0", Offset = "0x8B32EF0", VA = "0x188B344F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion OOPJKGODBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8B331D0", Offset = "0x8B31BD0", VA = "0x188B331D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8B345D0", Offset = "0x8B32FD0", VA = "0x188B345D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 GINLPEHDJCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8B33430", Offset = "0x8B31E30", VA = "0x188B33430")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8B34930", Offset = "0x8B33330", VA = "0x188B34930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 EEEABJHHEDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8B32CE0", Offset = "0x8B316E0", VA = "0x188B32CE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8B34230", Offset = "0x8B32C30", VA = "0x188B34230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 JMCMALMHEEL
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8B32650", Offset = "0x8B31050", VA = "0x188B32650")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8B33DD0", Offset = "0x8B327D0", VA = "0x188B33DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 KIOBGDPGDBB
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8B32AC0", Offset = "0x8B314C0", VA = "0x188B32AC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8B34000", Offset = "0x8B32A00", VA = "0x188B34000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 BOFAILPOFPI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8B32980", Offset = "0x8B31380", VA = "0x188B32980")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion DGLBECOLDHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8B328B0", Offset = "0x8B312B0", VA = "0x188B328B0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 GHABNGBPGMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8B336D0", Offset = "0x8B320D0", VA = "0x188B336D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 BLNPPCJINLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8B335F0", Offset = "0x8B31FF0", VA = "0x188B335F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool GOIPONBKIOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8B32A60", Offset = "0x8B31460", VA = "0x188B32A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool EIBOJNNMCDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8B32530", Offset = "0x8B30F30", VA = "0x188B32530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool LIGIFBDPOAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8B32040", Offset = "0x8B30A40", VA = "0x188B32040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool CHBDDICKFJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8B31FE0", Offset = "0x8B309E0", VA = "0x188B31FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool CEFEHAKKFFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8B31EC0", Offset = "0x8B308C0", VA = "0x188B31EC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool EAMDDFFKNKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8B32850", Offset = "0x8B31250", VA = "0x188B32850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GHGHOCPHKLM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x26ADD20", Offset = "0x26AC720", VA = "0x1826ADD20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event EPALFMCEDOH NCHOAGHCAJB
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8B31DE0", Offset = "0x8B307E0", VA = "0x188B31DE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8B33A50", Offset = "0x8B32450", VA = "0x188B33A50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event PMGMHKJLJEM FOBOOLGLKEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8B31B50", Offset = "0x8B30550", VA = "0x188B31B50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8B337B0", Offset = "0x8B321B0", VA = "0x188B337B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event PMGMHKJLJEM NKOBCKDNMNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8B31BB0", Offset = "0x8B305B0", VA = "0x188B31BB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8B33820", Offset = "0x8B32220", VA = "0x188B33820")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event PMGMHKJLJEM BOAMOHFIEOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8B31D00", Offset = "0x8B30700", VA = "0x188B31D00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8B33970", Offset = "0x8B32370", VA = "0x188B33970")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<CNMJFAPGOOG, CNMJFAPGOOG> JKLCEJHAMJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8B31C90", Offset = "0x8B30690", VA = "0x188B31C90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8B33900", Offset = "0x8B32300", VA = "0x188B33900")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event PMGMHKJLJEM AIPJMBJMHKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8B31D70", Offset = "0x8B30770", VA = "0x188B31D70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8B339E0", Offset = "0x8B323E0", VA = "0x188B339E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event PMGMHKJLJEM BINFOLOPPBN
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8B31E50", Offset = "0x8B30850", VA = "0x188B31E50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8B33AC0", Offset = "0x8B324C0", VA = "0x188B33AC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event PMGMHKJLJEM JPFDLBIHAMB
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8B31C20", Offset = "0x8B30620", VA = "0x188B31C20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8B33890", Offset = "0x8B32290", VA = "0x188B33890")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520", Slot = "8")]
		private void PKCBFGIKNND(MMLAFIMCODN JDFAIEBLNPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8B30770", Offset = "0x8B2F170", VA = "0x188B30770", Slot = "9")]
		public GCPMEGPNIPL GetData()
		{
			return default(GCPMEGPNIPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8B30430", Offset = "0x8B2EE30", VA = "0x188B30430")]
		internal void FDMOLFLHOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8B31870", Offset = "0x8B30270", VA = "0x188B31870")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody KIGJMJBHIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8B304C0", Offset = "0x8B2EEC0", VA = "0x188B304C0")]
		public GAMCEIADCLK GetChild(int FILGHJLFKAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8B314D0", Offset = "0x8B2FED0", VA = "0x188B314D0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) PGJAAKEMFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8B2FE50", Offset = "0x8B2E850", VA = "0x188B2FE50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8B31760", Offset = "0x8B30160", VA = "0x188B31760")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8B30320", Offset = "0x8B2ED20", VA = "0x188B30320")]
		private MMLAFIMCODN DMBCEFONCBJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8B30020", Offset = "0x8B2EA20", VA = "0x188B30020")]
		private void CEKLAJMLNPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8B30C90", Offset = "0x8B2F690", VA = "0x188B30C90")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8B30BD0", Offset = "0x8B2F5D0", VA = "0x188B30BD0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8B30430", Offset = "0x8B2EE30", VA = "0x188B30430")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8B30C30", Offset = "0x8B2F630", VA = "0x188B30C30")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8B30CF0", Offset = "0x8B2F6F0", VA = "0x188B30CF0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F440", Offset = "0x8B2DE40", VA = "0x188B2F440")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object DHNMCOFINFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8B30D60", Offset = "0x8B2F760", VA = "0x188B30D60")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object DHNMCOFINFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8B303D0", Offset = "0x8B2EDD0", VA = "0x188B303D0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8B30B70", Offset = "0x8B2F570", VA = "0x188B30B70")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8B31630", Offset = "0x8B30030", VA = "0x188B31630")]
		public void SetParent(RigidbodyEx PDKJBMPOMNC, bool CKECAKCIDFF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8B31070", Offset = "0x8B2FA70", VA = "0x188B31070")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8B30800", Offset = "0x8B2F200", VA = "0x188B30800")]
		public bool IsRigidbodyAncestor(RigidbodyEx BBKMHEEDCPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8B30900", Offset = "0x8B2F300", VA = "0x188B30900")]
		public bool IsRigidbodyDescendant(RigidbodyEx FHJNBGOPKKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F6B0", Offset = "0x8B2E0B0", VA = "0x188B2F6B0")]
		public void AddInterpolationRestriction(object DHNMCOFINFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8B30DD0", Offset = "0x8B2F7D0", VA = "0x188B30DD0")]
		public void RemoveInterpolationRestriction(object DHNMCOFINFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F720", Offset = "0x8B2E120", VA = "0x188B2F720")]
		public void AddKinematic(object DHNMCOFINFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8B30E40", Offset = "0x8B2F840", VA = "0x188B30E40")]
		public void RemoveKinematic(object DHNMCOFINFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8B315B0", Offset = "0x8B2FFB0", VA = "0x188B315B0")]
		public void SetKinematic(object DHNMCOFINFM, bool MMPDJFBCAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8B313D0", Offset = "0x8B2FDD0", VA = "0x188B313D0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 PJNPHLDNCIO, Quaternion BMJDLPCICGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8B312D0", Offset = "0x8B2FCD0", VA = "0x188B312D0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 JAEJANFNLKM, Quaternion POCCBMCKNOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8B30660", Offset = "0x8B2F060", VA = "0x188B30660")]
		public Vector3 GetConstrainedVelocity(Vector3 GINLPEHDJCD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8B30550", Offset = "0x8B2EF50", VA = "0x188B30550")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 JMCMALMHEEL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F5C0", Offset = "0x8B2DFC0", VA = "0x188B2F5C0")]
		public void AddForce(Vector3 FGLPKBNAEFO, ForceMode NOOEBPMMLLP = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F4B0", Offset = "0x8B2DEB0", VA = "0x188B2F4B0")]
		public void AddForceAtPosition(Vector3 FGLPKBNAEFO, Vector3 DDIHIBMHCDH, ForceMode NOOEBPMMLLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F8F0", Offset = "0x8B2E2F0", VA = "0x188B2F8F0")]
		public void AddTorque(Vector3 FDCHPHOPBKP, ForceMode NOOEBPMMLLP = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F790", Offset = "0x8B2E190", VA = "0x188B2F790")]
		public void AddRelativeTorque(Vector3 FDCHPHOPBKP, ForceMode NOOEBPMMLLP = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8B31940", Offset = "0x8B30340", VA = "0x188B31940")]
		public Vector3 WorldToLocalVelocity(Vector3 PFBBHDKAPNO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8B30A60", Offset = "0x8B2F460", VA = "0x188B30A60")]
		public Vector3 LocalToWorldVelocity(Vector3 EEEABJHHEDN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8B302C0", Offset = "0x8B2ECC0", VA = "0x188B302C0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8B30260", Offset = "0x8B2EC60", VA = "0x188B30260")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8B30200", Offset = "0x8B2EC00", VA = "0x188B30200")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8B301A0", Offset = "0x8B2EBA0", VA = "0x188B301A0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8B311D0", Offset = "0x8B2FBD0", VA = "0x188B311D0")]
		public void ResetVelocityWorldSpace(Vector3 EEPILHBAMLB, Vector3 KGBOAKKNPDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8B310D0", Offset = "0x8B2FAD0", VA = "0x188B310D0")]
		public void ResetVelocityLocalSpace(Vector3 BBHLJFHPKAN, Vector3 KIOBGDPGDBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8B30F90", Offset = "0x8B2F990", VA = "0x188B30F90")]
		public void ResetLinearVelocityLocalSpace(Vector3 BBHLJFHPKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8B31770", Offset = "0x8B30170", VA = "0x188B31770")]
		public bool SweepTest(Vector3 PNELABKCNPL, [Out] RaycastHit MEEEMKCEJJG, float JFEGIFCHDHH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8B30A00", Offset = "0x8B2F400", VA = "0x188B30A00")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8B31700", Offset = "0x8B30100", VA = "0x188B31700")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8B318E0", Offset = "0x8B302E0", VA = "0x188B318E0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F880", Offset = "0x8B2E280", VA = "0x188B2F880")]
		public void AddShouldHaveUnityRigidbodyToken(object DHNMCOFINFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8B30EB0", Offset = "0x8B2F8B0", VA = "0x188B30EB0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object DHNMCOFINFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8B2FC80", Offset = "0x8B2E680", VA = "0x188B2FC80")]
		public void ApplyForceVelocityChange(EMGABCFDBHM PFPHBPGCIJC, Vector3 MIHCFDPADLM, float AEKMACFDPEA, float KMBMIIIBPKJ = 8f, float NIOPKGJILOE = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8B2FB80", Offset = "0x8B2E580", VA = "0x188B2FB80")]
		public void ApplyAngularVelocityChange(EGBIDPNJAII NEBGCLAOOFM, Vector3 OHKPPKKOGOO, float CMEMBNCINMC = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8B2FD40", Offset = "0x8B2E740", VA = "0x188B2FD40")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(EGBIDPNJAII NEBGCLAOOFM, Vector3 JCDLBIBEGAF, float CJEJBOIPPOH = 7f, float HEFIEBMJIFJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8B2FAB0", Offset = "0x8B2E4B0", VA = "0x188B2FAB0")]
		public bool AllowedScaleChange(float OBEKFMJKMIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F9E0", Offset = "0x8B2E3E0", VA = "0x188B2F9E0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx MINGOFMFDGO, object DHNMCOFINFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8B30F20", Offset = "0x8B2F920", VA = "0x188B30F20")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object DHNMCOFINFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8B30D50", Offset = "0x8B2F750", VA = "0x188B30D50", Slot = "13")]
		private void PPGJJJNAMEP(BIHHMEGLCGA HCLPHJDKMCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8B31AE0", Offset = "0x8B304E0", VA = "0x188B31AE0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xB24200", Offset = "0xB22C00", VA = "0x180B24200", Slot = "4")]
		private GameObject FINBHJMEGDP()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAB2D40", Offset = "0xAB1740", VA = "0x180AB2D40", Slot = "10")]
		private bool OELMCBECINB()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class FCFBBPCHFFO
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8B1D650", Offset = "0x8B1C050", VA = "0x188B1D650")]
	public static MMLAFIMCODN EJHJDCLJFLF(this RigidbodyEx NMIAFFNIHJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(PFAEHKIBDIO), new string[] { })]
public class HAGMJNPGKIB : PFAEHKIBDIO, JHNMFGKPECO
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly MEBJEIOEDLD HJHMNJLNNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private BFEMJLNKDOB JDNAAPNIDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private GHIBHIHCDHN JEKIBMPMPOF;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BFEMJLNKDOB NJNPDNFAPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public GHIBHIHCDHN NBGGKBBPCJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8B20B70", Offset = "0x8B1F570", VA = "0x188B20B70", Slot = "7")]
	public void InitReferences(JFKAHIBHGGP INBLNPFFLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8B209A0", Offset = "0x8B1F3A0", VA = "0x188B209A0", Slot = "6")]
	public MMLAFIMCODN CJFOAAKDLEF(RigidbodyEx NMIAFFNIHJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public HAGMJNPGKIB()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static HPDJJKCNBLF UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int KGCPOLAGKHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int GPANMADOHGG;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F2A0", Offset = "0x8B2DCA0", VA = "0x188B2F2A0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F2E0", Offset = "0x8B2DCE0", VA = "0x188B2F2E0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F2C0", Offset = "0x8B2DCC0", VA = "0x188B2F2C0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string ONGDPODJNBL, [Optional] UnityEngine.Object HCLPHJDKMCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string ONGDPODJNBL, [Optional] UnityEngine.Object HCLPHJDKMCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F3F0", Offset = "0x8B2DDF0", VA = "0x188B2F3F0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HNDEMGFJFDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class IMIMJJAIBAG : DGLAKMOPOGI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA959D0", Offset = "0xA943D0", VA = "0x180A959D0", Slot = "4")]
		public Vector3 GCNOMKMEMAK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA959D0", Offset = "0xA943D0", VA = "0x180A959D0", Slot = "5")]
		public Vector3 MBEODNLKAIE()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "6")]
		public bool MMLODNAEAAP(float PPCMLIONOBJ, float MECGKDBKAPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public IMIMJJAIBAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static DGLAKMOPOGI NGDOGKJFJPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B21F00", Offset = "0x8B20900", VA = "0x188B21F00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KKIJBEKIILD
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode PHIIPJEHMEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NNIEBIADIDG();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MCAOLJHKCGA(bool GOIPONBKIOC);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPPOPHJFKPB(bool GOIPONBKIOC);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IGJFCJNGABF(Rigidbody HKGIPJIFHEP);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PNDFOINNMEN(Vector3 PNELABKCNPL, [Out] RaycastHit MEEEMKCEJJG, float JFEGIFCHDHH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KGGKECKALDC : IDisposable, JGOGLEAHDPN
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	OGPMHIGIIEC JLPNBOJDJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<CNMJFAPGOOG, CNMJFAPGOOG> JKLCEJHAMJM;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NNIEBIADIDG();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface GHIBHIHCDHN
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LLPDNILPCEJ MNMFDEPOKGK(MMLAFIMCODN JDFAIEBLNPJ);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FIINEACBKKN ADMKOHAHCJO(MMLAFIMCODN JDFAIEBLNPJ);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JDMMPNJFBNC PIJBPLNNCNA(MMLAFIMCODN JDFAIEBLNPJ);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LJGHBOJMKAO BDCFLBBJHCG(MMLAFIMCODN JDFAIEBLNPJ);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PFMFOADJDLF IIKGNJJEEOL(MMLAFIMCODN JDFAIEBLNPJ);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KGGKECKALDC GGKCALECAJO(MMLAFIMCODN JDFAIEBLNPJ);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OAOEDPHKBCI IBIFDIOAPKD(MMLAFIMCODN JDFAIEBLNPJ);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LEOHGIDENDM DDLGLPOGPLL(MMLAFIMCODN JDFAIEBLNPJ);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KKIJBEKIILD LDMDGPMJIFM(MMLAFIMCODN JDFAIEBLNPJ);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BAEPOGKCJGC BNEGNNMNNLN(MMLAFIMCODN JDFAIEBLNPJ);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NMHOGNBLBEK ELJMHIFLJBD(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HIBMPBPKNIA GNLKMGGLLGB(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	JKFJAJIINIK FGEFDHBLDEI(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ADJDGPIHJLF GJCODEJKBBH(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OGOGKNEMOBB FDLLCDMNKFO(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MMLAFIMCODN CJFOAAKDLEF(RigidbodyEx NMIAFFNIHJH, GCPMEGPNIPL GPCDCFCPGFK, PFAEHKIBDIO NKHELPOPPEM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LEOHGIDENDM
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DMBHGCHPGPK(Vector3 FGLPKBNAEFO, ForceMode NOOEBPMMLLP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OJINILMGELK(Vector3 FGLPKBNAEFO, Vector3 DDIHIBMHCDH, ForceMode NOOEBPMMLLP);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KBJPHLNFFMK(Vector3 FDCHPHOPBKP, ForceMode NOOEBPMMLLP = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KIJOPLOFMCA(Vector3 FDCHPHOPBKP, ForceMode NOOEBPMMLLP = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BAEPOGKCJGC
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool FBNNNDBMHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IGJFCJNGABF(Rigidbody HKGIPJIFHEP);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KOPDFLJCPIJ(Rigidbody HKGIPJIFHEP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LLPDNILPCEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<MMLAFIMCODN> HKEHHJOLJKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	MMLAFIMCODN BDILIHENIPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	MMLAFIMCODN KJNLPEJOCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event PMGMHKJLJEM FOBOOLGLKEN;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event PMGMHKJLJEM NKOBCKDNMNB;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event EPALFMCEDOH CFPOIIHIAED;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action HDEAOBDKGEF;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action FOGNNBNMDAO;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<MMLAFIMCODN> IKCEFJEJABF;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<MMLAFIMCODN> CCHLFFFNPNE;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action IFKAFKFOOOH;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<MMLAFIMCODN> PGLBFCHCMKA;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DLABGJNHMMB(MMLAFIMCODN OGINNIAMBHJ, bool CKECAKCIDFF = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JDMMPNJFBNC
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 MOCDNAMKLNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 LMFMICLIBEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPEKEBPNAFO(MMLAFIMCODN DFKFFPKHNCH, object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DFIJNHAGBEM(object DHNMCOFINFM);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ADJDGPIHJLF
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 DMFLCNMJJDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 NGLOFMOALJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float OMOMNNFCNDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float NIFJCPJBHGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 CJDFBDMKPHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion IJHMHCACLHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event PMGMHKJLJEM BGPINBDLBNF;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BKBKDJEMBEH((Quaternion rot, Vector3 moments) PGJAAKEMFIF);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JIKDCKCLMDB();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AHGJIKACHPE();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DHBEFOGJGEG();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IGJFCJNGABF(Rigidbody HKGIPJIFHEP);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KOPDFLJCPIJ(Rigidbody HKGIPJIFHEP);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PGAIPEOLOGC();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JKFJAJIINIK
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNIEBIADIDG();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJFHCNFIPDC(object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMIFPEBNKGK(object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CMCJFCHCPDL(MMLAFIMCODN NMIAFFNIHJH);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJNGBJOKPIC(MMLAFIMCODN NMIAFFNIHJH);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HJIAEENAFJM();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OAOEDPHKBCI
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HPPMJJEPHIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event PMGMHKJLJEM CFHBNJFKLML;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DJMLGFKNHEE(object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ALOMKLJEIFO(object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PFKCBJNBECL(object DHNMCOFINFM, bool MMPDJFBCAKB);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IGJFCJNGABF(Rigidbody HKGICDHJGKC);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KOPDFLJCPIJ(Rigidbody HKGIPJIFHEP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HIBMPBPKNIA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool ADGOFAPFAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DOBFHAMEJEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event PMGMHKJLJEM LKMHENLPOKA;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NNIEBIADIDG();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HAKOMIIENAH(MMLAFIMCODN DFKFFPKHNCH);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KMBCOMFNGBM(MMLAFIMCODN DFKFFPKHNCH);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface OGOGKNEMOBB
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool KNHCPPDKNII
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool FAGPPLNFANB
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints IBMPDFKHEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IGJFCJNGABF(Rigidbody HKGIPJIFHEP);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KOPDFLJCPIJ(Rigidbody HKGIPJIFHEP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LJGHBOJMKAO
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float FENIPLPAEMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float CAONAEAGFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IGJFCJNGABF(Rigidbody HKGIPJIFHEP);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KOPDFLJCPIJ(Rigidbody HKGIPJIFHEP);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PFMFOADJDLF
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool AIIPNFNAABI;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event PMGMHKJLJEM GEKNPPMHBPN;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NNIEBIADIDG();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PLPEPHOKPLL();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IOMNJMCEOAL();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PHDMEMAEOAJ();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DPHFGKMAJEJ();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KFFNEIGJPCB();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MADJMFECEDE(bool OLPJEAPLGEO);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FLHCOPCMOMB();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NMHOGNBLBEK
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody LJNAKNEMDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool GNHFOLPBGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNIEBIADIDG();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ANLADLKBIOP(object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IFCMEPJHFFK(object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PNFHDHOEOHI();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FIINEACBKKN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	DGLAKMOPOGI LIJEDFPFLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	OHIMHKLKCME KKPKJPAGCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 MHCMKJOJAIP
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 PIPFAEEEJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 BMGLMJHMMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 JFLCKKDPHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float LDCEPJGJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool ANIFKINJJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NNIEBIADIDG();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MHCOPMABAFB(object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EKDDFJEBKCC(EGBIDPNJAII NEBGCLAOOFM, Vector3 OHKPPKKOGOO, float CMEMBNCINMC = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MOKKBPHGLAB(EMGABCFDBHM PFPHBPGCIJC, Vector3 MIHCFDPADLM, float AEKMACFDPEA, float KMBMIIIBPKJ = 8f, float NIOPKGJILOE = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MAEJPNAMJJB(EGBIDPNJAII NEBGCLAOOFM, Vector3 JCDLBIBEGAF, float CJEJBOIPPOH = 7f, float HEFIEBMJIFJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HGPNMHPKFEN();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void EMGPFCKNMKL();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IEFJDOPFLEI();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void DNEEDJKLNIB();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IGJFCJNGABF(Rigidbody HKGIPJIFHEP);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 EEGNKMABDNP(Vector3 GINLPEHDJCD);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void AFHIKKLBPJF(object DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void IBKKKPAMPOH(Vector3 OKFMKEDPMEK);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void EGPDAJIPHOF(Vector3 BBHLJFHPKAN, Vector3 KIOBGDPGDBB);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void NIOCLKDODIO(Vector3 EEPILHBAMLB, Vector3 KGBOAKKNPDH);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 GPAKIMFLKML(Vector3 EEEABJHHEDN);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 EOALJNHEOJB(Vector3 PFBBHDKAPNO);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface BFEMJLNKDOB
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool KOOOIKFOCBB
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEOGGPFMKBP(string GFHOJCCMEDK);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HABPMLFGJHI(RigidbodyEx NMIAFFNIHJH, Action FOAIPBIEILM);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JCLKHJLKHJD GIENBKDGANC(int DGLMMGHKNIO);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GDEFEDFGNFE(Vector3 EJFCBBHCJOC, float AHGAANHJNBN, Color EDNHAEBPHJD);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface PFAEHKIBDIO
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	BFEMJLNKDOB NJNPDNFAPNI
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GHIBHIHCDHN NBGGKBBPCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MMLAFIMCODN CJFOAAKDLEF(RigidbodyEx NMIAFFNIHJH);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KHKOPEPIFLM : MMLAFIMCODN, IDisposable, BLIFCGDMDCH
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool KOJGPBHGAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly PFAEHKIBDIO NKHELPOPPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal LLPDNILPCEJ LANNHJEFEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal JKFJAJIINIK NBEEAECOIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal HIBMPBPKNIA DOIKHKNDOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal FIINEACBKKN GINLPEHDJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal JDMMPNJFBNC MOCMFGDIDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal ADJDGPIHJLF DKJDOJCNABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal LJGHBOJMKAO JCLHBKKELLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal BAEPOGKCJGC FDGDLOLOALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal PFMFOADJDLF NMKPCGCLDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal KGGKECKALDC GIBIMKNPCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal OAOEDPHKBCI ECDPJAJNEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal LEOHGIDENDM FGLPKBNAEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal OGOGKNEMOBB MFEOCKCALHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal NMHOGNBLBEK HKGIPJIFHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal KKIJBEKIILD CPCNBJCCHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable HGKJCCCDDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool NEKHDOHCAHH;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public DOIIIDJCDGH OBCMHECAHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "22")]
		get
		{
			return default(DOIIIDJCDGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public GAMCEIADCLK NJIDBNBABCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xAEE0F0", Offset = "0xAECAF0", VA = "0x180AEE0F0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xB40620", Offset = "0xB3F020", VA = "0x180B40620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject GNMGDLNMGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA89DE0", Offset = "0xA887E0", VA = "0x180A89DE0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA89E50", Offset = "0xA88850", VA = "0x180A89E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform AMPAFLPNFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xB406B0", Offset = "0xB3F0B0", VA = "0x180B406B0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xB405B0", Offset = "0xB3EFB0", VA = "0x180B405B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody LJNAKNEMDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8B25150", Offset = "0x8B23B50", VA = "0x188B25150", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public MMLAFIMCODN KJNLPEJOCLG
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8B292B0", Offset = "0x8B27CB0", VA = "0x188B292B0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8B274A0", Offset = "0x8B25EA0", VA = "0x188B274A0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int HLBJDIIHOPD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8B27D90", Offset = "0x8B26790", VA = "0x188B27D90", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public MMLAFIMCODN BDILIHENIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8B257A0", Offset = "0x8B241A0", VA = "0x188B257A0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool BPOKPLLNDNE
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B40", Offset = "0x8B26540", VA = "0x188B27B40", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool ADGOFAPFAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8B287D0", Offset = "0x8B271D0", VA = "0x188B287D0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool DOBFHAMEJEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8B277B0", Offset = "0x8B261B0", VA = "0x188B277B0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public DGLAKMOPOGI LIJEDFPFLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8B27240", Offset = "0x8B25C40", VA = "0x188B27240", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8B25E30", Offset = "0x8B24830", VA = "0x188B25E30", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public OHIMHKLKCME KKPKJPAGCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8B24A60", Offset = "0x8B23460", VA = "0x188B24A60", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8B293A0", Offset = "0x8B27DA0", VA = "0x188B293A0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float LDCEPJGJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8B25840", Offset = "0x8B24240", VA = "0x188B25840", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8B27AE0", Offset = "0x8B264E0", VA = "0x188B27AE0", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 PIPFAEEEJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8B29400", Offset = "0x8B27E00", VA = "0x188B29400", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8B29B50", Offset = "0x8B28550", VA = "0x188B29B50", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 JFLCKKDPHAF
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8B27290", Offset = "0x8B25C90", VA = "0x188B27290", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8B29C90", Offset = "0x8B28690", VA = "0x188B29C90", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 MHCMKJOJAIP
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8B254F0", Offset = "0x8B23EF0", VA = "0x188B254F0", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8B26CB0", Offset = "0x8B256B0", VA = "0x188B26CB0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 BMGLMJHMMNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8B24C10", Offset = "0x8B23610", VA = "0x188B24C10", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8B28500", Offset = "0x8B26F00", VA = "0x188B28500", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool LIGIFBDPOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8B26E60", Offset = "0x8B25860", VA = "0x188B26E60", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool CHBDDICKFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8B29960", Offset = "0x8B28360", VA = "0x188B29960", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool CEFEHAKKFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8B24550", Offset = "0x8B22F50", VA = "0x188B24550", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool ANIFKINJJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8B296E0", Offset = "0x8B280E0", VA = "0x188B296E0", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 MOCDNAMKLNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B26BE0", Offset = "0x8B255E0", VA = "0x188B26BE0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 LMFMICLIBEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8B2A500", Offset = "0x8B28F00", VA = "0x188B2A500", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 DMFLCNMJJDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8B27BA0", Offset = "0x8B265A0", VA = "0x188B27BA0", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8B27160", Offset = "0x8B25B60", VA = "0x188B27160", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 NGLOFMOALJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B29790", Offset = "0x8B28190", VA = "0x188B29790", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float OMOMNNFCNDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8B28950", Offset = "0x8B27350", VA = "0x188B28950", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float NIFJCPJBHGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B265E0", Offset = "0x8B24FE0", VA = "0x188B265E0", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8B29C30", Offset = "0x8B28630", VA = "0x188B29C30", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 CJDFBDMKPHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B289A0", Offset = "0x8B273A0", VA = "0x188B289A0", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion IJHMHCACLHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8B252E0", Offset = "0x8B23CE0", VA = "0x188B252E0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float FENIPLPAEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B27850", Offset = "0x8B26250", VA = "0x188B27850", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B28100", Offset = "0x8B26B00", VA = "0x188B28100", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float CAONAEAGFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8B24770", Offset = "0x8B23170", VA = "0x188B24770", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B29300", Offset = "0x8B27D00", VA = "0x188B29300", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool FBNNNDBMHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8B24BC0", Offset = "0x8B235C0", VA = "0x188B24BC0", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B25DD0", Offset = "0x8B247D0", VA = "0x188B25DD0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public OGPMHIGIIEC JLPNBOJDJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8B28160", Offset = "0x8B26B60", VA = "0x188B28160", Slot = "70")]
		get
		{
			return default(OGPMHIGIIEC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8B28820", Offset = "0x8B27220", VA = "0x188B28820", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool HPPMJJEPHIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8B257F0", Offset = "0x8B241F0", VA = "0x188B257F0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform DHCIHHENNMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xB406B0", Offset = "0xB3F0B0", VA = "0x180B406B0", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 AIIJAKFFIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8B2A0F0", Offset = "0x8B28AF0", VA = "0x188B2A0F0", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B2A400", Offset = "0x8B28E00", VA = "0x188B2A400", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float COPGMFFJDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8B27A70", Offset = "0x8B26470", VA = "0x188B27A70", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B27070", Offset = "0x8B25A70", VA = "0x188B27070", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float MNLMOEGEBNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B260E0", Offset = "0x8B24AE0", VA = "0x188B260E0", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B25FC0", Offset = "0x8B249C0", VA = "0x188B25FC0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion KCMJHAANMND
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B25F20", Offset = "0x8B24920", VA = "0x188B25F20", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B295A0", Offset = "0x8B27FA0", VA = "0x188B295A0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 PKNMOJAEEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B29360", Offset = "0x8B27D60", VA = "0x188B29360", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8B278A0", Offset = "0x8B262A0", VA = "0x188B278A0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion NGNBDBJMMAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8B29FB0", Offset = "0x8B289B0", VA = "0x188B29FB0", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8B26350", Offset = "0x8B24D50", VA = "0x188B26350", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints IBMPDFKHEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8B29B00", Offset = "0x8B28500", VA = "0x188B29B00", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8B28210", Offset = "0x8B26C10", VA = "0x188B28210", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool KNHCPPDKNII
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B28640", Offset = "0x8B27040", VA = "0x188B28640", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8B26EB0", Offset = "0x8B258B0", VA = "0x188B26EB0", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode PHIIPJEHMEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8B255D0", Offset = "0x8B23FD0", VA = "0x188B255D0", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B2A850", Offset = "0x8B29250", VA = "0x188B2A850", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool EIIHGHALIEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8B24630", Offset = "0x8B23030", VA = "0x188B24630", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool EIBOJNNMCDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B25620", Offset = "0x8B24020", VA = "0x188B25620", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event PMGMHKJLJEM FOBOOLGLKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8B244F0", Offset = "0x8B22EF0", VA = "0x188B244F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8B25280", Offset = "0x8B23C80", VA = "0x188B25280", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event PMGMHKJLJEM NKOBCKDNMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8B28770", Offset = "0x8B27170", VA = "0x188B28770", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8B29730", Offset = "0x8B28130", VA = "0x188B29730", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event EPALFMCEDOH CFPOIIHIAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8B278E0", Offset = "0x8B262E0", VA = "0x188B278E0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8B27100", Offset = "0x8B25B00", VA = "0x188B27100", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event PMGMHKJLJEM LKMHENLPOKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8B27D30", Offset = "0x8B26730", VA = "0x188B27D30", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8B28A80", Offset = "0x8B27480", VA = "0x188B28A80", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event PMGMHKJLJEM BOAMOHFIEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8B24B60", Offset = "0x8B23560", VA = "0x188B24B60", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8B26820", Offset = "0x8B25220", VA = "0x188B26820", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event PMGMHKJLJEM GEKNPPMHBPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8B24A00", Offset = "0x8B23400", VA = "0x188B24A00", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B27580", Offset = "0x8B25F80", VA = "0x188B27580", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<CNMJFAPGOOG, CNMJFAPGOOG> JKLCEJHAMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8B25490", Offset = "0x8B23E90", VA = "0x188B25490", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8B26F10", Offset = "0x8B25910", VA = "0x188B26F10", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event PMGMHKJLJEM CFHBNJFKLML
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8B263D0", Offset = "0x8B24DD0", VA = "0x188B263D0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8B251A0", Offset = "0x8B23BA0", VA = "0x188B251A0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event PMGMHKJLJEM JPFDLBIHAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B27C80", Offset = "0x8B26680", VA = "0x188B27C80", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B24AB0", Offset = "0x8B234B0", VA = "0x188B24AB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8B2AC50", Offset = "0x8B29650", VA = "0x188B2AC50")]
	public KHKOPEPIFLM(GameObject CEENMGBCJEJ, RigidbodyEx LKBHNBGNNKC, PFAEHKIBDIO NKHELPOPPEM, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8B25890", Offset = "0x8B24290", VA = "0x188B25890", Slot = "139")]
	protected virtual void CKEFFCHGCPB(PFAEHKIBDIO NKHELPOPPEM, GCPMEGPNIPL GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8B26430", Offset = "0x8B24E30", VA = "0x188B26430", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8B299C0", Offset = "0x8B283C0", VA = "0x188B299C0", Slot = "93")]
	public void NNIEBIADIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8B26FE0", Offset = "0x8B259E0", VA = "0x188B26FE0", Slot = "94")]
	public void FNPJNHJCKAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8B26E00", Offset = "0x8B25800", VA = "0x188B26E00", Slot = "95")]
	public void FDGDCCMGBDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8B260C0", Offset = "0x8B24AC0", VA = "0x188B260C0", Slot = "96")]
	public void DBLBMHDLGJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8B28F20", Offset = "0x8B27920", VA = "0x188B28F20")]
	private void MADJMFECEDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8B27500", Offset = "0x8B25F00", VA = "0x188B27500")]
	private void GJGGMEPCLEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8B285E0", Offset = "0x8B26FE0", VA = "0x188B285E0")]
	private void KFFNEIGJPCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8B25200", Offset = "0x8B23C00", VA = "0x188B25200", Slot = "30")]
	public MMLAFIMCODN BODPJDOINLI(int FILGHJLFKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8B261A0", Offset = "0x8B24BA0", VA = "0x188B261A0", Slot = "98")]
	public void DLABGJNHMMB(MMLAFIMCODN PDKJBMPOMNC, bool CKECAKCIDFF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8B29680", Offset = "0x8B28080", VA = "0x188B29680", Slot = "99")]
	public void NDPIPFFKCOG(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8B27E50", Offset = "0x8B26850", VA = "0x188B27E50", Slot = "100")]
	public void JDOLDOPDPAA(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8B26AE0", Offset = "0x8B254E0", VA = "0x188B26AE0", Slot = "101")]
	public Vector3 EOALJNHEOJB(Vector3 PFBBHDKAPNO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8B275E0", Offset = "0x8B25FE0", VA = "0x188B275E0", Slot = "102")]
	public Vector3 GPAKIMFLKML(Vector3 EEEABJHHEDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8B26380", Offset = "0x8B24D80", VA = "0x188B26380", Slot = "103")]
	public void DNEEDJKLNIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8B26A90", Offset = "0x8B25490", VA = "0x188B26A90", Slot = "104")]
	public void EMGPFCKNMKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8B27800", Offset = "0x8B26200", VA = "0x188B27800", Slot = "105")]
	public void HGPNMHPKFEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x8B29870", Offset = "0x8B28270", VA = "0x188B29870", Slot = "106")]
	public void NIOCLKDODIO(Vector3 EEPILHBAMLB, Vector3 KGBOAKKNPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8B26730", Offset = "0x8B25130", VA = "0x188B26730", Slot = "107")]
	public void EGPDAJIPHOF(Vector3 BBHLJFHPKAN, Vector3 KIOBGDPGDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x8B27940", Offset = "0x8B26340", VA = "0x188B27940", Slot = "108")]
	public void IBKKKPAMPOH(Vector3 OKFMKEDPMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8B294E0", Offset = "0x8B27EE0", VA = "0x188B294E0", Slot = "109")]
	public void MOKKBPHGLAB(EMGABCFDBHM PFPHBPGCIJC, Vector3 MIHCFDPADLM, float AEKMACFDPEA, float KMBMIIIBPKJ = 8f, float NIOPKGJILOE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8B26880", Offset = "0x8B25280", VA = "0x188B26880", Slot = "110")]
	public void EKDDFJEBKCC(EGBIDPNJAII NEBGCLAOOFM, Vector3 OHKPPKKOGOO, float CMEMBNCINMC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8B291A0", Offset = "0x8B27BA0", VA = "0x188B291A0", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void MAEJPNAMJJB(EGBIDPNJAII NEBGCLAOOFM, Vector3 JCDLBIBEGAF, float CJEJBOIPPOH = 7f, float HEFIEBMJIFJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8B26630", Offset = "0x8B25030", VA = "0x188B26630", Slot = "112")]
	public Vector3 EEGNKMABDNP(Vector3 PDKJBMPOMNC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8B29FF0", Offset = "0x8B289F0", VA = "0x188B29FF0", Slot = "113")]
	public Vector3 PACGDALLACG(Vector3 PDKJBMPOMNC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8B27A20", Offset = "0x8B26420", VA = "0x188B27A20", Slot = "114")]
	public void IEFJDOPFLEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8B26D90", Offset = "0x8B25790", VA = "0x188B26D90", Slot = "115")]
	public void FDBMOAPMGDA(MMLAFIMCODN MINGOFMFDGO, object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8B281B0", Offset = "0x8B26BB0", VA = "0x188B281B0", Slot = "116")]
	public void JONIEBKKLGG(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8B24CF0", Offset = "0x8B236F0", VA = "0x188B24CF0", Slot = "63")]
	public void BKBKDJEMBEH((Quaternion rot, Vector3 moments) PGJAAKEMFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8B247C0", Offset = "0x8B231C0", VA = "0x188B247C0", Slot = "117")]
	public void AHGJIKACHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8B280B0", Offset = "0x8B26AB0", VA = "0x188B280B0", Slot = "118")]
	public void JIKDCKCLMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8B260F0", Offset = "0x8B24AF0", VA = "0x188B260F0", Slot = "119")]
	public void DHBEFOGJGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8B2A4B0", Offset = "0x8B28EB0", VA = "0x188B2A4B0", Slot = "120")]
	public bool PLPEPHOKPLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8B2A3B0", Offset = "0x8B28DB0", VA = "0x188B2A3B0", Slot = "97")]
	public void PHDMEMAEOAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8B26F70", Offset = "0x8B25970", VA = "0x188B26F70", Slot = "121")]
	public void FLHCOPCMOMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8B26140", Offset = "0x8B24B40", VA = "0x188B26140", Slot = "122")]
	public void DJMLGFKNHEE(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8B24940", Offset = "0x8B23340", VA = "0x188B24940", Slot = "123")]
	public void ALOMKLJEIFO(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x8B2A1A0", Offset = "0x8B28BA0", VA = "0x188B2A1A0", Slot = "124")]
	public void PFKCBJNBECL(object DHNMCOFINFM, bool MMPDJFBCAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8B27EB0", Offset = "0x8B268B0", VA = "0x188B27EB0", Slot = "125")]
	public void JGDGFIHONPB(Vector3 PJNPHLDNCIO, Quaternion BMJDLPCICGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8B27370", Offset = "0x8B25D70", VA = "0x188B27370", Slot = "126")]
	public void GINAOIBLIMK(Vector3 JAEJANFNLKM, Quaternion POCCBMCKNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8B27E00", Offset = "0x8B26800", VA = "0x188B27E00", Slot = "127")]
	public bool IMMHAGBIHBL(float OBEKFMJKMIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8B26210", Offset = "0x8B24C10", VA = "0x188B26210", Slot = "128")]
	public void DLDCOENJKIO(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8B25B80", Offset = "0x8B24580", VA = "0x188B25B80", Slot = "129")]
	public void CKMPJBOGADD(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8B249A0", Offset = "0x8B233A0", VA = "0x188B249A0", Slot = "130")]
	public void ANLADLKBIOP(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8B27A80", Offset = "0x8B26480", VA = "0x188B27A80", Slot = "131")]
	public void IFCMEPJHFFK(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8B26270", Offset = "0x8B24C70", VA = "0x188B26270", Slot = "132")]
	public void DMBHGCHPGPK(Vector3 FGLPKBNAEFO, ForceMode NOOEBPMMLLP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8B29EA0", Offset = "0x8B288A0", VA = "0x188B29EA0", Slot = "133")]
	public void OJINILMGELK(Vector3 FGLPKBNAEFO, Vector3 DDIHIBMHCDH, ForceMode NOOEBPMMLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8B28270", Offset = "0x8B26C70", VA = "0x188B28270", Slot = "134")]
	public void KBJPHLNFFMK(Vector3 FDCHPHOPBKP, ForceMode NOOEBPMMLLP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8B28690", Offset = "0x8B27090", VA = "0x188B28690", Slot = "135")]
	public void KIJOPLOFMCA(Vector3 FDCHPHOPBKP, ForceMode NOOEBPMMLLP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8B2A750", Offset = "0x8B29150", VA = "0x188B2A750", Slot = "136")]
	public bool PNDFOINNMEN(Vector3 PNELABKCNPL, [Out] RaycastHit MEEEMKCEJJG, float JFEGIFCHDHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8B2A210", Offset = "0x8B28C10", VA = "0x188B2A210", Slot = "137")]
	public void PGAIPEOLOGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8B2AC10", Offset = "0x8B29610", VA = "0x188B2AC10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8B253B0", Offset = "0x8B23DB0", VA = "0x188B253B0")]
	private void CEPCBGOAALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8B26980", Offset = "0x8B25380", VA = "0x188B26980")]
	private void ELHHGCEBPIC(MMLAFIMCODN DFKFFPKHNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8B25BE0", Offset = "0x8B245E0", VA = "0x188B25BE0")]
	private void CLCJGCHHNPH(MMLAFIMCODN DFKFFPKHNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8B26530", Offset = "0x8B24F30", VA = "0x188B26530")]
	private void EAAONFMHAOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8B24810", Offset = "0x8B23210", VA = "0x188B24810")]
	private void AKBFKACHNBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8B28350", Offset = "0x8B26D50", VA = "0x188B28350")]
	private void KBPIDEDDGIE(MMLAFIMCODN PLGDJOLKAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8B276E0", Offset = "0x8B260E0", VA = "0x188B276E0")]
	private void HAKOMIIENAH(MMLAFIMCODN DFKFFPKHNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8B28880", Offset = "0x8B27280", VA = "0x188B28880")]
	private void KMBCOMFNGBM(MMLAFIMCODN DFKFFPKHNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8B2A260", Offset = "0x8B28C60", VA = "0x188B2A260")]
	private void PGLKKLJFKEK(GAMCEIADCLK DFKFFPKHNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8B28AE0", Offset = "0x8B274E0", VA = "0x188B28AE0", Slot = "142")]
	protected virtual void LNIFIJJJKHN(GAMCEIADCLK NMIAFFNIHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8B2A8B0", Offset = "0x8B292B0", VA = "0x188B2A8B0")]
	protected void PPNHLCLMDLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8B24DD0", Offset = "0x8B237D0", VA = "0x188B24DD0")]
	protected void BKMAKBNBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8B29D70", Offset = "0x8B28770", VA = "0x188B29D70")]
	private void OIKDAHGIDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8B2A5E0", Offset = "0x8B28FE0", VA = "0x188B2A5E0")]
	private void PMFPFDDIMDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class AAHMAPFIOOA
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8B18730", Offset = "0x8B17130", VA = "0x188B18730")]
	public static MMLAFIMCODN HKHELLAFEJP(this MMLAFIMCODN NMIAFFNIHJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8B187F0", Offset = "0x8B171F0", VA = "0x188B187F0")]
	public static bool IKBMNJLBAML(this MMLAFIMCODN NMIAFFNIHJH, MMLAFIMCODN BBKMHEEDCPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8B18890", Offset = "0x8B17290", VA = "0x188B18890")]
	public static bool LOPNLAAKBOM(this MMLAFIMCODN NMIAFFNIHJH, MMLAFIMCODN FHJNBGOPKKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8B18930", Offset = "0x8B17330", VA = "0x188B18930")]
	public static GAMCEIADCLK MHABAILPPHN(this MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8B186B0", Offset = "0x8B170B0", VA = "0x188B186B0")]
	public static KHKOPEPIFLM CFGBHOCDHJJ(this MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HLBNIHLPKMI : GHIBHIHCDHN
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8B21E60", Offset = "0x8B20860", VA = "0x188B21E60", Slot = "19")]
	public MMLAFIMCODN CJFOAAKDLEF(RigidbodyEx NMIAFFNIHJH, GCPMEGPNIPL GPCDCFCPGFK, PFAEHKIBDIO NKHELPOPPEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "4")]
	public LLPDNILPCEJ MNMFDEPOKGK(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "5")]
	public FIINEACBKKN ADMKOHAHCJO(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "6")]
	public JDMMPNJFBNC PIJBPLNNCNA(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "7")]
	public LJGHBOJMKAO BDCFLBBJHCG(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "8")]
	public PFMFOADJDLF IIKGNJJEEOL(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "9")]
	public KGGKECKALDC GGKCALECAJO(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "10")]
	public OAOEDPHKBCI IBIFDIOAPKD(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "11")]
	public LEOHGIDENDM DDLGLPOGPLL(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "12")]
	public KKIJBEKIILD LDMDGPMJIFM(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "13")]
	public BAEPOGKCJGC BNEGNNMNNLN(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50")]
	public NMHOGNBLBEK ELJMHIFLJBD(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50")]
	public HIBMPBPKNIA GNLKMGGLLGB(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50")]
	public JKFJAJIINIK FGEFDHBLDEI(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50")]
	public ADJDGPIHJLF GJCODEJKBBH(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50")]
	public OGOGKNEMOBB FDLLCDMNKFO(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public HLBNIHLPKMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "14")]
	private NMHOGNBLBEK FCCFJIDMJAF(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "15")]
	private HIBMPBPKNIA PLIDLGFBOMJ(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "16")]
	private JKFJAJIINIK NMCCGAIBDBA(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "17")]
	private ADJDGPIHJLF FEKANPJIFAD(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "18")]
	private OGOGKNEMOBB OCFJLDJPHLP(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(GHIBHIHCDHN), new string[] { })]
public class GCGMLJFCJMF : GHIBHIHCDHN, JHNMFGKPECO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly GHIBHIHCDHN EKFPCGFFHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly GHIBHIHCDHN DPLEFEIOEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private CAABBDAJAFF AOABIFNBEPN;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private GHIBHIHCDHN NBGGKBBPCJL
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8B1E4E0", Offset = "0x8B1CEE0", VA = "0x188B1E4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8B1E2B0", Offset = "0x8B1CCB0", VA = "0x188B1E2B0", Slot = "20")]
	public void InitReferences(JFKAHIBHGGP INBLNPFFLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8B1E3A0", Offset = "0x8B1CDA0", VA = "0x188B1E3A0", Slot = "4")]
	public LLPDNILPCEJ MNMFDEPOKGK(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8B1D990", Offset = "0x8B1C390", VA = "0x188B1D990", Slot = "5")]
	public FIINEACBKKN ADMKOHAHCJO(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8B1E440", Offset = "0x8B1CE40", VA = "0x188B1E440", Slot = "6")]
	public JDMMPNJFBNC PIJBPLNNCNA(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8B1DA30", Offset = "0x8B1C430", VA = "0x188B1DA30", Slot = "7")]
	public LJGHBOJMKAO BDCFLBBJHCG(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8B1E210", Offset = "0x8B1CC10", VA = "0x188B1E210", Slot = "8")]
	public PFMFOADJDLF IIKGNJJEEOL(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8B1E020", Offset = "0x8B1CA20", VA = "0x188B1E020", Slot = "9")]
	public KGGKECKALDC GGKCALECAJO(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8B1E170", Offset = "0x8B1CB70", VA = "0x188B1E170", Slot = "10")]
	public OAOEDPHKBCI IBIFDIOAPKD(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8B1DCC0", Offset = "0x8B1C6C0", VA = "0x188B1DCC0", Slot = "11")]
	public LEOHGIDENDM DDLGLPOGPLL(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8B1E300", Offset = "0x8B1CD00", VA = "0x188B1E300", Slot = "12")]
	public KKIJBEKIILD LDMDGPMJIFM(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8B1DAD0", Offset = "0x8B1C4D0", VA = "0x188B1DAD0", Slot = "13")]
	public BAEPOGKCJGC BNEGNNMNNLN(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8B1DD60", Offset = "0x8B1C760", VA = "0x188B1DD60")]
	public NMHOGNBLBEK ELJMHIFLJBD(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8B1E0C0", Offset = "0x8B1CAC0", VA = "0x188B1E0C0")]
	public HIBMPBPKNIA GNLKMGGLLGB(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8B1DF70", Offset = "0x8B1C970", VA = "0x188B1DF70")]
	public JKFJAJIINIK FGEFDHBLDEI(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x8B1DEC0", Offset = "0x8B1C8C0", VA = "0x188B1DEC0")]
	public ADJDGPIHJLF GJCODEJKBBH(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8B1DE10", Offset = "0x8B1C810", VA = "0x188B1DE10")]
	public OGOGKNEMOBB FDLLCDMNKFO(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x8B1DB70", Offset = "0x8B1C570", VA = "0x188B1DB70", Slot = "19")]
	public MMLAFIMCODN CJFOAAKDLEF(RigidbodyEx NMIAFFNIHJH, GCPMEGPNIPL GPCDCFCPGFK, PFAEHKIBDIO NKHELPOPPEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x8B1E540", Offset = "0x8B1CF40", VA = "0x188B1E540")]
	public GCGMLJFCJMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8B1DD60", Offset = "0x8B1C760", VA = "0x188B1DD60", Slot = "14")]
	private NMHOGNBLBEK FCCFJIDMJAF(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8B1E0C0", Offset = "0x8B1CAC0", VA = "0x188B1E0C0", Slot = "15")]
	private HIBMPBPKNIA PLIDLGFBOMJ(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8B1DF70", Offset = "0x8B1C970", VA = "0x188B1DF70", Slot = "16")]
	private JKFJAJIINIK NMCCGAIBDBA(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x8B1DEC0", Offset = "0x8B1C8C0", VA = "0x188B1DEC0", Slot = "17")]
	private ADJDGPIHJLF FEKANPJIFAD(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x8B1DE10", Offset = "0x8B1C810", VA = "0x188B1DE10", Slot = "18")]
	private OGOGKNEMOBB OCFJLDJPHLP(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface LNAALELPPIG : LLPDNILPCEJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGEKGIEHAKM(MMLAFIMCODN NMIAFFNIHJH);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMMIACLMIFE(MMLAFIMCODN NMIAFFNIHJH);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HECIGACJLIB(MMLAFIMCODN PLGDJOLKAAK);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HLMAOCKCHFN(MMLAFIMCODN PLGDJOLKAAK);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KOEHOEHPNJC : JDMMPNJFBNC
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	FPJAFDMBCOF<MMLAFIMCODN> AKELFBNDFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	MMLAFIMCODN LBLBJLOAHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KBPJIPMJHBP : ADJDGPIHJLF
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) JMKGBNFKKOD(Rigidbody HIOJNONAPLC);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface LBDLBALMEDO : HIBMPBPKNIA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	RRNetworkView IFGBKJGGLBC
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class HPFALBBIFPL : KKIJBEKIILD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly KHKOPEPIFLM NMIAFFNIHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode JFCHAKMLCCK;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody LJNAKNEMDOK
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8B1EF00", Offset = "0x8B1D900", VA = "0x188B1EF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode PHIIPJEHMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8B21FD0", Offset = "0x8B209D0", VA = "0x188B21FD0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8B22510", Offset = "0x8B20F10", VA = "0x188B22510", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x8B1D5C0", Offset = "0x8B1BFC0", VA = "0x188B1D5C0")]
	public HPFALBBIFPL(MMLAFIMCODN NMIAFFNIHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x8B222A0", Offset = "0x8B20CA0", VA = "0x188B222A0", Slot = "6")]
	public void NNIEBIADIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x8B220E0", Offset = "0x8B20AE0", VA = "0x188B220E0", Slot = "9")]
	public void IGJFCJNGABF(Rigidbody HKGIPJIFHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x8B22170", Offset = "0x8B20B70", VA = "0x188B22170", Slot = "7")]
	public void MCAOLJHKCGA(bool GOIPONBKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x8B22160", Offset = "0x8B20B60", VA = "0x188B22160", Slot = "8")]
	public void IPPOPHJFKPB(bool GOIPONBKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x8B223B0", Offset = "0x8B20DB0", VA = "0x188B223B0", Slot = "10")]
	public bool PNDFOINNMEN(Vector3 PNELABKCNPL, [Out] RaycastHit MEEEMKCEJJG, float JFEGIFCHDHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x8B22180", Offset = "0x8B20B80", VA = "0x188B22180")]
	private void NCFEHPPOOLG(bool GOIPONBKIOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class CMBKJHKJGKE : KGGKECKALDC, IDisposable, JGOGLEAHDPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KHKOPEPIFLM NMIAFFNIHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private OGPMHIGIIEC AHHPBEEHMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private JCLKHJLKHJD NGKNAFBMGMP;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public OGPMHIGIIEC JLPNBOJDJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8B1C1A0", Offset = "0x8B1ABA0", VA = "0x188B1C1A0", Slot = "6")]
		get
		{
			return default(OGPMHIGIIEC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8B1C2F0", Offset = "0x8B1ACF0", VA = "0x188B1C2F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform LLNPGCMLCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xE22D70", Offset = "0xE21770", VA = "0x180E22D70", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<CNMJFAPGOOG, CNMJFAPGOOG> JKLCEJHAMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8B1BFF0", Offset = "0x8B1A9F0", VA = "0x188B1BFF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8B1C0F0", Offset = "0x8B1AAF0", VA = "0x188B1C0F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x8B1C630", Offset = "0x8B1B030", VA = "0x188B1C630")]
	public CMBKJHKJGKE(MMLAFIMCODN NMIAFFNIHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x8B1C3C0", Offset = "0x8B1ADC0", VA = "0x188B1C3C0", Slot = "8")]
	public void NNIEBIADIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x8B1C0A0", Offset = "0x8B1AAA0", VA = "0x188B1C0A0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1331250", Offset = "0x132FC50", VA = "0x181331250", Slot = "11")]
	private void PLPKLAPLGMK(CNMJFAPGOOG FPOENPNJHPI, CNMJFAPGOOG OIEELJPGCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "12")]
	private void GLENLGAEHOP(bool MJDKKJPHIGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LOGKPIFAGKM : GHIBHIHCDHN
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8B2BC80", Offset = "0x8B2A680", VA = "0x188B2BC80", Slot = "4")]
	public LLPDNILPCEJ MNMFDEPOKGK(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8B2AE00", Offset = "0x8B29800", VA = "0x188B2AE00", Slot = "5")]
	public FIINEACBKKN ADMKOHAHCJO(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8B2BD70", Offset = "0x8B2A770", VA = "0x188B2BD70", Slot = "6")]
	public JDMMPNJFBNC PIJBPLNNCNA(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8B2AF30", Offset = "0x8B29930", VA = "0x188B2AF30", Slot = "7")]
	public LJGHBOJMKAO BDCFLBBJHCG(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x8B2BAF0", Offset = "0x8B2A4F0", VA = "0x188B2BAF0", Slot = "8")]
	public PFMFOADJDLF IIKGNJJEEOL(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8B2B770", Offset = "0x8B2A170", VA = "0x188B2B770", Slot = "9")]
	public KGGKECKALDC GGKCALECAJO(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8B2B9D0", Offset = "0x8B2A3D0", VA = "0x188B2B9D0", Slot = "10")]
	public OAOEDPHKBCI IBIFDIOAPKD(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8B2B1C0", Offset = "0x8B29BC0", VA = "0x188B2B1C0", Slot = "11")]
	public LEOHGIDENDM DDLGLPOGPLL(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8B2BBC0", Offset = "0x8B2A5C0", VA = "0x188B2BBC0", Slot = "12")]
	public KKIJBEKIILD LDMDGPMJIFM(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8B2AFB0", Offset = "0x8B299B0", VA = "0x188B2AFB0", Slot = "13")]
	public BAEPOGKCJGC BNEGNNMNNLN(MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8B2B280", Offset = "0x8B29C80", VA = "0x188B2B280")]
	public NMHOGNBLBEK ELJMHIFLJBD(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8B2B840", Offset = "0x8B2A240", VA = "0x188B2B840")]
	public HIBMPBPKNIA GNLKMGGLLGB(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8B2B640", Offset = "0x8B2A040", VA = "0x188B2B640")]
	public JKFJAJIINIK FGEFDHBLDEI(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8B2B4A0", Offset = "0x8B29EA0", VA = "0x188B2B4A0")]
	public ADJDGPIHJLF GJCODEJKBBH(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8B2B3C0", Offset = "0x8B29DC0", VA = "0x188B2B3C0")]
	public OGOGKNEMOBB FDLLCDMNKFO(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8B2B070", Offset = "0x8B29A70", VA = "0x188B2B070", Slot = "19")]
	public MMLAFIMCODN CJFOAAKDLEF(RigidbodyEx NMIAFFNIHJH, GCPMEGPNIPL GPCDCFCPGFK, PFAEHKIBDIO NKHELPOPPEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public LOGKPIFAGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8B2B280", Offset = "0x8B29C80", VA = "0x188B2B280", Slot = "14")]
	private NMHOGNBLBEK FCCFJIDMJAF(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8B2B840", Offset = "0x8B2A240", VA = "0x188B2B840", Slot = "15")]
	private HIBMPBPKNIA PLIDLGFBOMJ(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8B2B640", Offset = "0x8B2A040", VA = "0x188B2B640", Slot = "16")]
	private JKFJAJIINIK NMCCGAIBDBA(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8B2B4A0", Offset = "0x8B29EA0", VA = "0x188B2B4A0", Slot = "17")]
	private ADJDGPIHJLF FEKANPJIFAD(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8B2B3C0", Offset = "0x8B29DC0", VA = "0x188B2B3C0", Slot = "18")]
	private OGOGKNEMOBB OCFJLDJPHLP(MMLAFIMCODN JDFAIEBLNPJ, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class GJGJEOMPDCO : LEOHGIDENDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly KHKOPEPIFLM NMIAFFNIHJH;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody LJNAKNEMDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8B1EF00", Offset = "0x8B1D900", VA = "0x188B1EF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool HPPMJJEPHIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8B1EF50", Offset = "0x8B1D950", VA = "0x188B1EF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool BPOKPLLNDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8B1E9C0", Offset = "0x8B1D3C0", VA = "0x188B1E9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private MMLAFIMCODN KJNLPEJOCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8B1F4C0", Offset = "0x8B1DEC0", VA = "0x188B1F4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8B1D5C0", Offset = "0x8B1BFC0", VA = "0x188B1D5C0")]
	public GJGJEOMPDCO(MMLAFIMCODN NMIAFFNIHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8B1EFA0", Offset = "0x8B1D9A0", VA = "0x188B1EFA0", Slot = "4")]
	public void DMBHGCHPGPK(Vector3 FGLPKBNAEFO, ForceMode NOOEBPMMLLP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8B1FA00", Offset = "0x8B1E400", VA = "0x188B1FA00")]
	private void PGFGFCIINMB(Vector3 FGLPKBNAEFO, ForceMode NOOEBPMMLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x8B1F780", Offset = "0x8B1E180", VA = "0x188B1F780", Slot = "5")]
	public void OJINILMGELK(Vector3 FGLPKBNAEFO, Vector3 DDIHIBMHCDH, ForceMode NOOEBPMMLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x8B1F100", Offset = "0x8B1DB00", VA = "0x188B1F100", Slot = "6")]
	public void KBJPHLNFFMK(Vector3 FDCHPHOPBKP, ForceMode NOOEBPMMLLP = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8B1F520", Offset = "0x8B1DF20", VA = "0x188B1F520")]
	private void NOJIAMMLGCE(Vector3 FDCHPHOPBKP, ForceMode NOOEBPMMLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8B1F260", Offset = "0x8B1DC60", VA = "0x188B1F260", Slot = "7")]
	public void KIJOPLOFMCA(Vector3 FDCHPHOPBKP, ForceMode NOOEBPMMLLP = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class EDIOAPFBKPL : BAEPOGKCJGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly KHKOPEPIFLM NMIAFFNIHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool AMLLLOCNFCP;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool FBNNNDBMHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAD3450", Offset = "0xAD1E50", VA = "0x180AD3450", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D410", Offset = "0x8B1BE10", VA = "0x188B1D410", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8B1D5C0", Offset = "0x8B1BFC0", VA = "0x188B1D5C0")]
	public EDIOAPFBKPL(MMLAFIMCODN NMIAFFNIHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x8B1D520", Offset = "0x8B1BF20", VA = "0x188B1D520", Slot = "6")]
	public void IGJFCJNGABF(Rigidbody HKGIPJIFHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x8B1D550", Offset = "0x8B1BF50", VA = "0x188B1D550", Slot = "7")]
	public void KOPDFLJCPIJ(Rigidbody HKGIPJIFHEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class KENMGNFJEDM : LNAALELPPIG, LLPDNILPCEJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly MMLAFIMCODN NMIAFFNIHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<MMLAFIMCODN> GKCMIFJJHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private MMLAFIMCODN PJFDNMGHMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private MMLAFIMCODN DFKFFPKHNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform CGKHGKIJJCB;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform AMPAFLPNFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8B23CA0", Offset = "0x8B226A0", VA = "0x188B23CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public MMLAFIMCODN KJNLPEJOCLG
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA841F0", Offset = "0xA82BF0", VA = "0x180A841F0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8B23440", Offset = "0x8B21E40", VA = "0x188B23440", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public MMLAFIMCODN BDILIHENIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA841B0", Offset = "0xA82BB0", VA = "0x180A841B0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<MMLAFIMCODN> HKEHHJOLJKI
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA841E0", Offset = "0xA82BE0", VA = "0x180A841E0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event PMGMHKJLJEM FOBOOLGLKEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8B22640", Offset = "0x8B21040", VA = "0x188B22640", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8B22970", Offset = "0x8B21370", VA = "0x188B22970", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event PMGMHKJLJEM NKOBCKDNMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8B23D00", Offset = "0x8B22700", VA = "0x188B23D00", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8B23F80", Offset = "0x8B22980", VA = "0x188B23F80", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event EPALFMCEDOH CFPOIIHIAED
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8B23AD0", Offset = "0x8B224D0", VA = "0x188B23AD0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8B232B0", Offset = "0x8B21CB0", VA = "0x188B232B0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action HDEAOBDKGEF
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8B22820", Offset = "0x8B21220", VA = "0x188B22820", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8B23DA0", Offset = "0x8B227A0", VA = "0x188B23DA0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action FOGNNBNMDAO
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8B23E40", Offset = "0x8B22840", VA = "0x188B23E40", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8B24020", Offset = "0x8B22A20", VA = "0x188B24020", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<MMLAFIMCODN> IKCEFJEJABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8B242C0", Offset = "0x8B22CC0", VA = "0x188B242C0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8B24210", Offset = "0x8B22C10", VA = "0x188B24210", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<MMLAFIMCODN> CCHLFFFNPNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8B23450", Offset = "0x8B21E50", VA = "0x188B23450", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8B24160", Offset = "0x8B22B60", VA = "0x188B24160", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action IFKAFKFOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8B22A10", Offset = "0x8B21410", VA = "0x188B22A10", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8B23500", Offset = "0x8B21F00", VA = "0x188B23500", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<MMLAFIMCODN> PGLBFCHCMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8B23200", Offset = "0x8B21C00", VA = "0x188B23200", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8B228C0", Offset = "0x8B212C0", VA = "0x188B228C0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x8B24430", Offset = "0x8B22E30", VA = "0x188B24430")]
	public KENMGNFJEDM(MMLAFIMCODN NMIAFFNIHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x8B23030", Offset = "0x8B21A30", VA = "0x188B23030", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x8B22AB0", Offset = "0x8B214B0", VA = "0x188B22AB0", Slot = "30")]
	public void DLABGJNHMMB(MMLAFIMCODN OGINNIAMBHJ, bool CKECAKCIDFF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x8B235A0", Offset = "0x8B21FA0", VA = "0x188B235A0", Slot = "6")]
	public void HECIGACJLIB(MMLAFIMCODN PLGDJOLKAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x8B23850", Offset = "0x8B22250", VA = "0x188B23850", Slot = "7")]
	public void HLMAOCKCHFN(MMLAFIMCODN PLGDJOLKAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8B23350", Offset = "0x8B21D50", VA = "0x188B23350", Slot = "4")]
	public void GGEKGIEHAKM(MMLAFIMCODN NMIAFFNIHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x8B240C0", Offset = "0x8B22AC0", VA = "0x188B240C0", Slot = "5")]
	public void NMMIACLMIFE(MMLAFIMCODN NMIAFFNIHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x8B23EE0", Offset = "0x8B228E0", VA = "0x188B23EE0")]
	private void MJBLAANBAIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x8B23810", Offset = "0x8B22210", VA = "0x188B23810")]
	private void HLJOHADCEGI(MMLAFIMCODN PLGDJOLKAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x8B226E0", Offset = "0x8B210E0", VA = "0x188B226E0")]
	private void ANLFCIAJFGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x8B230D0", Offset = "0x8B21AD0", VA = "0x188B230D0")]
	private void FCBKGHJKNOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x8B23B70", Offset = "0x8B22570", VA = "0x188B23B70")]
	private void IEOMCMOPJJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x8B24370", Offset = "0x8B22D70", VA = "0x188B24370")]
	[CompilerGenerated]
	private object PLKELLJIOPE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class DGIPOLGDKNM
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x8B1D350", Offset = "0x8B1BD50", VA = "0x188B1D350")]
	public static LNAALELPPIG DMOHGBMKEGC(this MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class DEGKCHOJCIF : KOEHOEHPNJC, JDMMPNJFBNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly KHKOPEPIFLM NMIAFFNIHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly FPJAFDMBCOF<MMLAFIMCODN> BNAPLMBIMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool DDPMCMIMEBN;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public FPJAFDMBCOF<MMLAFIMCODN> AKELFBNDFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 MOCDNAMKLNA
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CC20", Offset = "0x8B1B620", VA = "0x188B1CC20", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 LMFMICLIBEN
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D090", Offset = "0x8B1BA90", VA = "0x188B1D090", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 MHCMKJOJAIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8B1C730", Offset = "0x8B1B130", VA = "0x188B1C730")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public MMLAFIMCODN LBLBJLOAHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CC50", Offset = "0x8B1B650", VA = "0x188B1CC50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x8B1D250", Offset = "0x8B1BC50", VA = "0x188B1D250")]
	public DEGKCHOJCIF(MMLAFIMCODN NMIAFFNIHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x8B1C6C0", Offset = "0x8B1B0C0", VA = "0x188B1C6C0", Slot = "8")]
	public void BPEKEBPNAFO(MMLAFIMCODN DFKFFPKHNCH, object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x8B1C820", Offset = "0x8B1B220", VA = "0x188B1C820", Slot = "9")]
	public void DFIJNHAGBEM(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x8B1C880", Offset = "0x8B1B280", VA = "0x188B1C880")]
	private Vector3 DICGNCLDGFG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x8B1CD00", Offset = "0x8B1B700", VA = "0x188B1CD00")]
	private void KHPMJPAHCBK(MMLAFIMCODN ODEHMBKCEPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class LGHPGDKFCAM
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8B2AD40", Offset = "0x8B29740", VA = "0x188B2AD40")]
	public static KOEHOEHPNJC NOJBMHBLPCB(this MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class MDICAOPAABH : KBPJIPMJHBP, ADJDGPIHJLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly KHKOPEPIFLM NMIAFFNIHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 LMOJGFOMNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 OKPCFNDIFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float KDAIFIBAGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float KFPCCKLODAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 ALMJDPCGOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? BOFAILPOFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? DGLBECOLDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool CLMPCOOONIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool OKELKJKKCKA;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 DMFLCNMJJDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x188AB40", Offset = "0x1889540", VA = "0x18188AB40", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B2CAB0", Offset = "0x8B2B4B0", VA = "0x188B2CAB0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 NGLOFMOALJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E140", Offset = "0x8B2CB40", VA = "0x188B2E140", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float OMOMNNFCNDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xE48A00", Offset = "0xE47400", VA = "0x180E48A00", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E230", Offset = "0x8B2CC30", VA = "0x188B2E230")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float NIFJCPJBHGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xD3A060", Offset = "0xD38A60", VA = "0x180D3A060", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8B2CC40", Offset = "0x8B2B640", VA = "0x188B2CC40", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 CJDFBDMKPHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B2DF10", Offset = "0x8B2C910", VA = "0x188B2DF10", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion IJHMHCACLHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C600", Offset = "0x8B2B000", VA = "0x188B2C600", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody LJNAKNEMDOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B1FD20", Offset = "0x8B1E720", VA = "0x188B1FD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event PMGMHKJLJEM BGPINBDLBNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E0A0", Offset = "0x8B2CAA0", VA = "0x188B2E0A0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C190", Offset = "0x8B2AB90", VA = "0x188B2C190", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8B2E7D0", Offset = "0x8B2D1D0", VA = "0x188B2E7D0")]
	public MDICAOPAABH(MMLAFIMCODN NMIAFFNIHJH, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8B2C070", Offset = "0x8B2AA70", VA = "0x188B2C070", Slot = "17")]
	public void AHGJIKACHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8B2CCF0", Offset = "0x8B2B6F0", VA = "0x188B2CCF0", Slot = "16")]
	public void JIKDCKCLMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8B2CB60", Offset = "0x8B2B560", VA = "0x188B2CB60", Slot = "19")]
	public void IGJFCJNGABF(Rigidbody HKGIPJIFHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8B2DC40", Offset = "0x8B2C640", VA = "0x188B2DC40", Slot = "20")]
	public void KOPDFLJCPIJ(Rigidbody HKGIPJIFHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8B2C780", Offset = "0x8B2B180", VA = "0x188B2C780", Slot = "18")]
	public void DHBEFOGJGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8B2E340", Offset = "0x8B2CD40", VA = "0x188B2E340", Slot = "21")]
	public void PGAIPEOLOGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8B2CAB0", Offset = "0x8B2B4B0", VA = "0x188B2CAB0")]
	private void LAPPBPLBMEN(Vector3 PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8B2DE20", Offset = "0x8B2C820", VA = "0x188B2DE20")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 KPEBEPLBFKL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8B2E230", Offset = "0x8B2CC30", VA = "0x188B2E230")]
	private void PAJGLJNLJDB(float PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8B2CC40", Offset = "0x8B2B640", VA = "0x188B2CC40")]
	private void IJIIPCPLNOG(float PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8B2C230", Offset = "0x8B2AC30", VA = "0x188B2C230")]
	private Vector3 BAPKEIKLBHH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8B2C3D0", Offset = "0x8B2ADD0", VA = "0x188B2C3D0", Slot = "15")]
	public void BKBKDJEMBEH((Quaternion rot, Vector3 moments) PGJAAKEMFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8B2C930", Offset = "0x8B2B330", VA = "0x188B2C930")]
	private Quaternion DNMPAKACIAN()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8B2DB70", Offset = "0x8B2C570", VA = "0x188B2DB70")]
	public void JMKGBNFKKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8B2CDD0", Offset = "0x8B2B7D0", VA = "0x188B2CDD0", Slot = "4")]
	public (float, Vector3) JMKGBNFKKOD(Rigidbody HIOJNONAPLC)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class JOHBIGLAOKM
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8B22580", Offset = "0x8B20F80", VA = "0x188B22580")]
	public static KBPJIPMJHBP CLGIINDEEME(this MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class PMFMIPEEACF : JKFJAJIINIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly KHKOPEPIFLM NMIAFFNIHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CNFJHBAFEIK OJEFANENIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly EJPCFNJKDCP PNNMBEKNGNK;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool PFIHBLBLBAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1A885A0", Offset = "0x1A86FA0", VA = "0x181A885A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public EJPCFNJKDCP NJCNLKCAINL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120", Slot = "11")]
		get
		{
			return default(EJPCFNJKDCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8B2EF60", Offset = "0x8B2D960", VA = "0x188B2EF60")]
	public PMFMIPEEACF(MMLAFIMCODN NMIAFFNIHJH, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8B2EE60", Offset = "0x8B2D860", VA = "0x188B2EE60", Slot = "4")]
	public void NNIEBIADIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8B2EDC0", Offset = "0x8B2D7C0", VA = "0x188B2EDC0")]
	private bool KFKPIKCCPAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8B2ED90", Offset = "0x8B2D790", VA = "0x188B2ED90", Slot = "5")]
	public void IJFHCNFIPDC(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8B2EF30", Offset = "0x8B2D930", VA = "0x188B2EF30", Slot = "6")]
	public void PMIFPEBNKGK(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8B2EC50", Offset = "0x8B2D650", VA = "0x188B2EC50", Slot = "9")]
	public void HJIAEENAFJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8B2E930", Offset = "0x8B2D330", VA = "0x188B2E930")]
	private void AILFBJIAGBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8B2EAD0", Offset = "0x8B2D4D0", VA = "0x188B2EAD0")]
	private void EEEMENBFNCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8B2EA90", Offset = "0x8B2D490", VA = "0x188B2EA90", Slot = "8")]
	public void DJNGBJOKPIC(MMLAFIMCODN NMIAFFNIHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8B2EA50", Offset = "0x8B2D450", VA = "0x188B2EA50", Slot = "7")]
	public void CMCJFCHCPDL(MMLAFIMCODN NMIAFFNIHJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class HGBPLEIFKPG : OAOEDPHKBCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly KHKOPEPIFLM NMIAFFNIHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly CNFJHBAFEIK NBKMEDBNNLF;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool HPPMJJEPHIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8B21A10", Offset = "0x8B20410", VA = "0x188B21A10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event PMGMHKJLJEM CFHBNJFKLML
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B21AD0", Offset = "0x8B204D0", VA = "0x188B21AD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8B21970", Offset = "0x8B20370", VA = "0x188B21970", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8B21D70", Offset = "0x8B20770", VA = "0x188B21D70")]
	public HGBPLEIFKPG(MMLAFIMCODN NMIAFFNIHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8B21AC0", Offset = "0x8B204C0", VA = "0x188B21AC0", Slot = "7")]
	public void DJMLGFKNHEE(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x8B21960", Offset = "0x8B20360", VA = "0x188B21960", Slot = "8")]
	public void ALOMKLJEIFO(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8B21C60", Offset = "0x8B20660", VA = "0x188B21C60", Slot = "9")]
	public void PFKCBJNBECL(object DHNMCOFINFM, bool MMPDJFBCAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x8B21B70", Offset = "0x8B20570", VA = "0x188B21B70", Slot = "12")]
	public void GGPBNJENEEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x8B21BB0", Offset = "0x8B205B0", VA = "0x188B21BB0", Slot = "10")]
	public void IGJFCJNGABF(Rigidbody HKGICDHJGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x8B21C30", Offset = "0x8B20630", VA = "0x188B21C30", Slot = "11")]
	public void KOPDFLJCPIJ(Rigidbody HKGIPJIFHEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class HFJAOFPKCMK : LBDLBALMEDO, HIBMPBPKNIA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly KHKOPEPIFLM NMIAFFNIHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private RRNetworkView FFIKJGPFGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool NFDCGDKKABC;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public RRNetworkView IFGBKJGGLBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool ADGOFAPFAGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8B21360", Offset = "0x8B1FD60", VA = "0x188B21360", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool DOBFHAMEJEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xC33050", Offset = "0xC31A50", VA = "0x180C33050", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event PMGMHKJLJEM LKMHENLPOKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B21050", Offset = "0x8B1FA50", VA = "0x188B21050", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8B214E0", Offset = "0x8B1FEE0", VA = "0x188B214E0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8B21800", Offset = "0x8B20200", VA = "0x188B21800")]
	public HFJAOFPKCMK(MMLAFIMCODN NMIAFFNIHJH, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x8B216D0", Offset = "0x8B200D0", VA = "0x188B216D0", Slot = "9")]
	public void NNIEBIADIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x8B20DE0", Offset = "0x8B1F7E0", VA = "0x188B20DE0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x8B20EE0", Offset = "0x8B1F8E0", VA = "0x188B20EE0", Slot = "10")]
	public void HAKOMIIENAH(MMLAFIMCODN DFKFFPKHNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x8B21370", Offset = "0x8B1FD70", VA = "0x188B21370", Slot = "11")]
	public void KMBCOMFNGBM(MMLAFIMCODN DFKFFPKHNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x8B20C70", Offset = "0x8B1F670", VA = "0x188B20C70")]
	private void AEGKPEEKCDF(RRNetworkView OKEFHEOGPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x8B21580", Offset = "0x8B1FF80", VA = "0x188B21580")]
	private void NNFCPLPFPDE(GAMCEIADCLK FKNLPPHBPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x8B210F0", Offset = "0x8B1FAF0", VA = "0x188B210F0")]
	private void IMNPAJJIMBP(RRNetworkView EBOMNLFOPAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class MCLPMPBNELL
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x8B2BFB0", Offset = "0x8B2A9B0", VA = "0x188B2BFB0")]
	public static LBDLBALMEDO FDPHPBFBJPK(this MMLAFIMCODN JDFAIEBLNPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class PPOEIBPHMMN : OGOGKNEMOBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly KHKOPEPIFLM NMIAFFNIHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints AMKDAJKEPNO;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool KNHCPPDKNII
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xB3DD70", Offset = "0xB3C770", VA = "0x180B3DD70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xE64D60", Offset = "0xE63760", VA = "0x180E64D60", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool FAGPPLNFANB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xB3DB20", Offset = "0xB3C520", VA = "0x180B3DB20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xE64620", Offset = "0xE63020", VA = "0x180E64620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints IBMPDFKHEOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8B2F090", Offset = "0x8B2DA90", VA = "0x188B2F090", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x8B2F1F0", Offset = "0x8B2DBF0", VA = "0x188B2F1F0")]
	public PPOEIBPHMMN(MMLAFIMCODN NMIAFFNIHJH, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x8B2F060", Offset = "0x8B2DA60", VA = "0x188B2F060", Slot = "9")]
	public void IGJFCJNGABF(Rigidbody HKGIPJIFHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x8B2F1C0", Offset = "0x8B2DBC0", VA = "0x188B2F1C0", Slot = "10")]
	public void KOPDFLJCPIJ(Rigidbody HKGIPJIFHEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class FFCGCONMOGN : LJGHBOJMKAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly MMLAFIMCODN NMIAFFNIHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float GOBMCPDJAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float PPMELLOMIIG;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float FENIPLPAEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xADE030", Offset = "0xADCA30", VA = "0x180ADE030", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D710", Offset = "0x8B1C110", VA = "0x188B1D710", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float CAONAEAGFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xADE3F0", Offset = "0xADCDF0", VA = "0x180ADE3F0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8B1D880", Offset = "0x8B1C280", VA = "0x188B1D880", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8B1D950", Offset = "0x8B1C350", VA = "0x188B1D950")]
	public FFCGCONMOGN(MMLAFIMCODN NMIAFFNIHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x8B1D6C0", Offset = "0x8B1C0C0", VA = "0x188B1D6C0", Slot = "8")]
	public void IGJFCJNGABF(Rigidbody HKGIPJIFHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x8B1D7E0", Offset = "0x8B1C1E0", VA = "0x188B1D7E0", Slot = "9")]
	public void KOPDFLJCPIJ(Rigidbody HKGIPJIFHEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class GKBHFKBOJLG : PFMFOADJDLF
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly MEBJEIOEDLD FFOHILHLHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly KHKOPEPIFLM NMIAFFNIHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool BKCFPGKEGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool CBILJKKIMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int AOJHCGLBGJJ;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody LJNAKNEMDOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8B1FD20", Offset = "0x8B1E720", VA = "0x188B1FD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool EIIHGHALIEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8B1FC60", Offset = "0x8B1E660", VA = "0x188B1FC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private MMLAFIMCODN KJNLPEJOCLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8B205A0", Offset = "0x8B1EFA0", VA = "0x188B205A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool BPOKPLLNDNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B201B0", Offset = "0x8B1EBB0", VA = "0x188B201B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event PMGMHKJLJEM GEKNPPMHBPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8B1FC80", Offset = "0x8B1E680", VA = "0x188B1FC80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8B20110", Offset = "0x8B1EB10", VA = "0x188B20110", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8B20910", Offset = "0x8B1F310", VA = "0x188B20910")]
	public GKBHFKBOJLG(MMLAFIMCODN NMIAFFNIHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8B20600", Offset = "0x8B1F000", VA = "0x188B20600", Slot = "6")]
	public void NNIEBIADIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x8B20210", Offset = "0x8B1EC10", VA = "0x188B20210", Slot = "8")]
	public void IOMNJMCEOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8B20730", Offset = "0x8B1F130", VA = "0x188B20730", Slot = "7")]
	public bool PLPEPHOKPLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x8B20690", Offset = "0x8B1F090", VA = "0x188B20690", Slot = "9")]
	public void PHDMEMAEOAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8B20070", Offset = "0x8B1EA70", VA = "0x188B20070", Slot = "13")]
	public void FLHCOPCMOMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8B20470", Offset = "0x8B1EE70", VA = "0x188B20470", Slot = "12")]
	public void MADJMFECEDE(bool OLPJEAPLGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8B20000", Offset = "0x8B1EA00", VA = "0x188B20000", Slot = "10")]
	public bool DPHFGKMAJEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8B203B0", Offset = "0x8B1EDB0", VA = "0x188B203B0", Slot = "11")]
	public bool KFFNEIGJPCB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8B1FD70", Offset = "0x8B1E770", VA = "0x188B1FD70")]
	private bool DCLPPKKBKOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8B20220", Offset = "0x8B1EC20", VA = "0x188B20220")]
	private void KCAKDBAHHLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class GHJFFPIDJGK : NMHOGNBLBEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly KHKOPEPIFLM NMIAFFNIHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly CNFJHBAFEIK EDGAEEHHJBO;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody LJNAKNEMDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xA86520", Offset = "0xA84F20", VA = "0x180A86520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool BPOKPLLNDNE
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x8B1E9C0", Offset = "0x8B1D3C0", VA = "0x188B1E9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool GNHFOLPBGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1A885A0", Offset = "0x1A86FA0", VA = "0x181A885A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8B1EDF0", Offset = "0x8B1D7F0", VA = "0x188B1EDF0")]
	public GHJFFPIDJGK(MMLAFIMCODN NMIAFFNIHJH, [In] GCPMEGPNIPL GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8B1EA20", Offset = "0x8B1D420", VA = "0x188B1EA20", Slot = "5")]
	public void NNIEBIADIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x8B1E7E0", Offset = "0x8B1D1E0", VA = "0x188B1E7E0", Slot = "7")]
	public void ANLADLKBIOP(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x8B1E990", Offset = "0x8B1D390", VA = "0x188B1E990", Slot = "8")]
	public void IFCMEPJHFFK(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8B1EAC0", Offset = "0x8B1D4C0", VA = "0x188B1EAC0", Slot = "9")]
	public void PNFHDHOEOHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8B1E5F0", Offset = "0x8B1CFF0", VA = "0x188B1E5F0", Slot = "10")]
	public void ALBCCGCPAEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x8B1E810", Offset = "0x8B1D210", VA = "0x188B1E810", Slot = "11")]
	public void DMJPEJNJDMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class BKMDHJCBJOO : FIINEACBKKN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly KHKOPEPIFLM NMIAFFNIHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly CNFJHBAFEIK KEFMPPNCHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float FOKPMGJBGBH;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public DGLAKMOPOGI LIJEDFPFLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA86500", Offset = "0xA84F00", VA = "0x180A86500", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA864D0", Offset = "0xA84ED0", VA = "0x180A864D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public OHIMHKLKCME KKPKJPAGCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA864A0", Offset = "0xA84EA0", VA = "0x180A864A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA86510", Offset = "0xA84F10", VA = "0x180A86510", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 MHCMKJOJAIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8B190A0", Offset = "0x8B17AA0", VA = "0x188B190A0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8B1A050", Offset = "0x8B18A50", VA = "0x188B1A050", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 PIPFAEEEJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8B1B4E0", Offset = "0x8B19EE0", VA = "0x188B1B4E0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8B1BEA0", Offset = "0x8B1A8A0", VA = "0x188B1BEA0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 BMGLMJHMMNC
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8B18AB0", Offset = "0x8B174B0", VA = "0x188B18AB0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8B1AE60", Offset = "0x8B19860", VA = "0x188B1AE60", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 JFLCKKDPHAF
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8B1A5A0", Offset = "0x8B18FA0", VA = "0x188B1A5A0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8B1BED0", Offset = "0x8B1A8D0", VA = "0x188B1BED0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float LDCEPJGJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xADE3E0", Offset = "0xADCDE0", VA = "0x180ADE3E0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8B189A0", Offset = "0x8B173A0", VA = "0x188B189A0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool ANIFKINJJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x24E3FA0", Offset = "0x24E29A0", VA = "0x1824E3FA0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private LEOHGIDENDM MFIEDGEFICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x806D2A0", Offset = "0x806BCA0", VA = "0x18806D2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool EIIHGHALIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8B18980", Offset = "0x8B17380", VA = "0x188B18980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x8B1BF00", Offset = "0x8B1A900", VA = "0x188B1BF00")]
	public BKMDHJCBJOO(MMLAFIMCODN NMIAFFNIHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8B191F0", Offset = "0x8B17BF0", VA = "0x188B191F0", Slot = "19")]
	public void NNIEBIADIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x8B192A0", Offset = "0x8B17CA0", VA = "0x188B192A0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8B1AC10", Offset = "0x8B19610", VA = "0x188B1AC10", Slot = "28")]
	public void IGJFCJNGABF(Rigidbody HKGIPJIFHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x18440A0", Offset = "0x1842AA0", VA = "0x1818440A0", Slot = "20")]
	public void MHCOPMABAFB(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x1844A80", Offset = "0x1843480", VA = "0x181844A80", Slot = "30")]
	public void AFHIKKLBPJF(object DHNMCOFINFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8B198D0", Offset = "0x8B182D0", VA = "0x188B198D0", Slot = "35")]
	public Vector3 EOALJNHEOJB(Vector3 PFBBHDKAPNO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8B1A6C0", Offset = "0x8B190C0", VA = "0x188B1A6C0", Slot = "34")]
	public Vector3 GPAKIMFLKML(Vector3 EEEABJHHEDN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x8B191F0", Offset = "0x8B17BF0", VA = "0x188B191F0", Slot = "27")]
	public void DNEEDJKLNIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8B19870", Offset = "0x8B18270", VA = "0x188B19870", Slot = "25")]
	public void EMGPFCKNMKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8B1A880", Offset = "0x8B19280", VA = "0x188B1A880", Slot = "24")]
	public void HGPNMHPKFEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x8B1BC60", Offset = "0x8B1A660", VA = "0x188B1BC60", Slot = "33")]
	public void NIOCLKDODIO(Vector3 EEPILHBAMLB, Vector3 KGBOAKKNPDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8B19580", Offset = "0x8B17F80", VA = "0x188B19580", Slot = "32")]
	public void EGPDAJIPHOF(Vector3 BBHLJFHPKAN, Vector3 KIOBGDPGDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8B1A8E0", Offset = "0x8B192E0", VA = "0x188B1A8E0", Slot = "31")]
	public void IBKKKPAMPOH(Vector3 OKFMKEDPMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x8B1B600", Offset = "0x8B1A000", VA = "0x188B1B600", Slot = "22")]
	public void MOKKBPHGLAB(EMGABCFDBHM PFPHBPGCIJC, Vector3 MIHCFDPADLM, float AEKMACFDPEA, float KMBMIIIBPKJ = 8f, float NIOPKGJILOE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8B195E0", Offset = "0x8B17FE0", VA = "0x188B195E0", Slot = "21")]
	public void EKDDFJEBKCC(EGBIDPNJAII NEBGCLAOOFM, Vector3 OHKPPKKOGOO, float CMEMBNCINMC = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8B1AFD0", Offset = "0x8B199D0", VA = "0x188B1AFD0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void MAEJPNAMJJB(EGBIDPNJAII NEBGCLAOOFM, Vector3 JCDLBIBEGAF, float CJEJBOIPPOH = 7f, float HEFIEBMJIFJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x1994D80", Offset = "0x1993780", VA = "0x181994D80")]
	private static void GONMPDIGLAA(Vector3 GINLPEHDJCD, Vector3 HKIFHFOHPEK, [Out] Vector3 FBBDLPHLPFD, [Out] Vector3 ADANANPFKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8B194A0", Offset = "0x8B17EA0", VA = "0x188B194A0", Slot = "29")]
	public Vector3 EEGNKMABDNP(Vector3 GINLPEHDJCD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8B1AA80", Offset = "0x8B19480", VA = "0x188B1AA80", Slot = "26")]
	public void IEFJDOPFLEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8B189A0", Offset = "0x8B173A0", VA = "0x188B189A0")]
	private void AIFEBKOOBHE(float PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x8B19300", Offset = "0x8B17D00", VA = "0x188B19300")]
	private void EAGLCONPEPP(Vector3 OHKPPKKOGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x8B1AD40", Offset = "0x8B19740", VA = "0x188B1AD40")]
	private Vector3 KCLJDAIGFBD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8B1A110", Offset = "0x8B18B10", VA = "0x188B1A110")]
	private void FFKDFKGPFNN(Vector3 EEEABJHHEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8B1B3C0", Offset = "0x8B19DC0", VA = "0x188B1B3C0")]
	private Vector3 MBEODNLKAIE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x8B18C10", Offset = "0x8B17610", VA = "0x188B18C10")]
	private void CELPANPEAJF(Vector3 PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8B19AB0", Offset = "0x8B184B0", VA = "0x188B19AB0")]
	private void EPEPIBKMKDM(Vector3 EEEABJHHEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8B1AF20", Offset = "0x8B19920", VA = "0x188B1AF20")]
	private void LJDNADCOGOE()
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
