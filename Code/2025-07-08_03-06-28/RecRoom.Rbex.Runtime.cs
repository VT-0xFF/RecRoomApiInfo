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
	public class LogRegistrationIndex : LLMIPJJKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x88C7D70", Offset = "0x88C6B70", VA = "0x1888C7D70", Slot = "4")]
		public override void HIMDKAKGPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8278050", Offset = "0x8276E50", VA = "0x188278050", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x88D1A40", Offset = "0x88D0840", VA = "0x1888D1A40")]
		private void AFKHLAMEPCM(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x88D1D50", Offset = "0x88D0B50", VA = "0x1888D1D50", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x88D1DB0", Offset = "0x88D0BB0", VA = "0x1888D1DB0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, OPDBNCCBFHO, OAGHPAJECPH, HAHNHFHBMDO
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly PHLHEDGDBJO LKFJJLBMAEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool KKJFMLOHCJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private DPBLEIDODAC CPHMOFIELBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[GHCBEJGHGJA(NKIOFDIBBLL.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[GHCBEJGHGJA(NKIOFDIBBLL.SelfAndParent, true, false, false)]
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
		private CLOJPGAOOMI physicsInterpolation;

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
		private Transform KHPPIFGNOJD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal DPBLEIDODAC OMAGLDJIKDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x88CD8C0", Offset = "0x88CC6C0", VA = "0x1888CD8C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private DPBLEIDODAC CAFMJBMAJPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int PMOGKCHOIFH
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x88CEF50", Offset = "0x88CDD50", VA = "0x1888CEF50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx IMFJJJDINJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x88CF2B0", Offset = "0x88CE0B0", VA = "0x1888CF2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx KBGGJKBKACF
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x88CF1F0", Offset = "0x88CDFF0", VA = "0x1888CF1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx CMDMCJGFCDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x88CFEB0", Offset = "0x88CECB0", VA = "0x1888CFEB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x88D13B0", Offset = "0x88D01B0", VA = "0x1888D13B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool MFHPJONMPOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x84F0270", Offset = "0x84EF070", VA = "0x1884F0270", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x84F0260", Offset = "0x84EF060", VA = "0x1884F0260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform OLPMPAIMKPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2464EE0", Offset = "0x2463CE0", VA = "0x182464EE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform CGPFCMAJJNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2464EE0", Offset = "0x2463CE0", VA = "0x182464EE0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform JJFFAELKOEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2464EE0", Offset = "0x2463CE0", VA = "0x182464EE0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CBJAHEEHPCM OJAJFEEKJFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x88CEFB0", Offset = "0x88CDDB0", VA = "0x1888CEFB0")]
			get
			{
				return default(CBJAHEEHPCM);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x88D0B60", Offset = "0x88CF960", VA = "0x1888D0B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool OLOGEBJDKLN
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x88CF5C0", Offset = "0x88CE3C0", VA = "0x1888CF5C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool JFHEADJNHGE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x88CF0D0", Offset = "0x88CDED0", VA = "0x1888CF0D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FHIEKILDCOB GKEEJIGDEKI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x88CF500", Offset = "0x88CE300", VA = "0x1888CF500")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x88D0D20", Offset = "0x88CFB20", VA = "0x1888D0D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PAAFNDDMBFD NPFBHJHKOMD
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x88CF4A0", Offset = "0x88CE2A0", VA = "0x1888CF4A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x88D0CB0", Offset = "0x88CFAB0", VA = "0x1888D0CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool LDLFJPGODMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x88CF3F0", Offset = "0x88CE1F0", VA = "0x1888CF3F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody OPIDLFEPEBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x88CF450", Offset = "0x88CE250", VA = "0x1888CF450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool CAIMGNIAKBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x88CF130", Offset = "0x88CDF30", VA = "0x1888CF130")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x88D0BD0", Offset = "0x88CF9D0", VA = "0x1888D0BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool BEDOJAICHOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x84F0B40", Offset = "0x84EF940", VA = "0x1884F0B40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float IAGOBGHHDIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x88CFE50", Offset = "0x88CEC50", VA = "0x1888CFE50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float LHKAFEIBHKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x88CFDF0", Offset = "0x88CEBF0", VA = "0x1888CFDF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x88D1340", Offset = "0x88D0140", VA = "0x1888D1340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float IKBPJPOMDFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x88CF820", Offset = "0x88CE620", VA = "0x1888CF820")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x88D0FC0", Offset = "0x88CFDC0", VA = "0x1888D0FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float AFJPJKDLJMG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x88CF620", Offset = "0x88CE420", VA = "0x1888CF620")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x88D0D90", Offset = "0x88CFB90", VA = "0x1888D0D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool GLKFLGDIOBC
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x88D0400", Offset = "0x88CF200", VA = "0x1888D0400")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x88D18F0", Offset = "0x88D06F0", VA = "0x1888D18F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MEKIJFHCBNI
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x88CFBD0", Offset = "0x88CE9D0", VA = "0x1888CFBD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x88D1110", Offset = "0x88CFF10", VA = "0x1888D1110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 GKCPAEAGGML
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x88D0540", Offset = "0x88CF340", VA = "0x1888D0540")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode AMJBABAPIJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x88CF760", Offset = "0x88CE560", VA = "0x1888CF760")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x88D0EE0", Offset = "0x88CFCE0", VA = "0x1888D0EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float ALOEDFDDPML
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x88CF190", Offset = "0x88CDF90", VA = "0x1888CF190")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x88D0C40", Offset = "0x88CFA40", VA = "0x1888D0C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints PNCGHFMOGAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x88CF7C0", Offset = "0x88CE5C0", VA = "0x1888CF7C0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x88D0F50", Offset = "0x88CFD50", VA = "0x1888D0F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 EMIEBLBHMJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x88CFF70", Offset = "0x88CED70", VA = "0x1888CFF70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 PEFNHLDAGHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x88CFF70", Offset = "0x88CED70", VA = "0x1888CFF70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x88D16D0", Offset = "0x88D04D0", VA = "0x1888D16D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float JPCENJALCCP
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x88CFCB0", Offset = "0x88CEAB0", VA = "0x1888CFCB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x88D11F0", Offset = "0x88CFFF0", VA = "0x1888D11F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float OFNGIJCLGMN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x88D03A0", Offset = "0x88CF1A0", VA = "0x1888D03A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x88D1880", Offset = "0x88D0680", VA = "0x1888D1880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion IKLLBLCHFDO
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x88D0050", Offset = "0x88CEE50", VA = "0x1888D0050")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x88D1450", Offset = "0x88D0250", VA = "0x1888D1450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion GPIBIOCOFLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x88D02D0", Offset = "0x88CF0D0", VA = "0x1888D02D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x88D17B0", Offset = "0x88D05B0", VA = "0x1888D17B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 DDNAFNIPDIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x88D0120", Offset = "0x88CEF20", VA = "0x1888D0120")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x88D1520", Offset = "0x88D0320", VA = "0x1888D1520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion GPLKCJFNAPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x88D0200", Offset = "0x88CF000", VA = "0x1888D0200")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x88D1600", Offset = "0x88D0400", VA = "0x1888D1600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 LNGDDNPHJHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x88D0460", Offset = "0x88CF260", VA = "0x1888D0460")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x88D1960", Offset = "0x88D0760", VA = "0x1888D1960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 LLAKBEKJKJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x88CFD10", Offset = "0x88CEB10", VA = "0x1888CFD10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x88D1260", Offset = "0x88D0060", VA = "0x1888D1260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 BBFHLEIKDJM
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x88CF680", Offset = "0x88CE480", VA = "0x1888CF680")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x88D0E00", Offset = "0x88CFC00", VA = "0x1888D0E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 DMILHKKHJKK
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x88CFAF0", Offset = "0x88CE8F0", VA = "0x1888CFAF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x88D1030", Offset = "0x88CFE30", VA = "0x1888D1030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 PPKCHBCCHIP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x88CF9B0", Offset = "0x88CE7B0", VA = "0x1888CF9B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion EOMJHFCHJBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x88CF8E0", Offset = "0x88CE6E0", VA = "0x1888CF8E0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 EMEEKCDFGLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x88D0700", Offset = "0x88CF500", VA = "0x1888D0700")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 CJMJIGJFELD
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x88D0620", Offset = "0x88CF420", VA = "0x1888D0620")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool MMHMJBCCKLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x88CFA90", Offset = "0x88CE890", VA = "0x1888CFA90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool MENIBLCOEKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x88CF560", Offset = "0x88CE360", VA = "0x1888CF560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool MOLDNMJKALN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x88CF070", Offset = "0x88CDE70", VA = "0x1888CF070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool BDIAGIILAFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x88CF010", Offset = "0x88CDE10", VA = "0x1888CF010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool ELPKNLHNDAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x88CEEF0", Offset = "0x88CDCF0", VA = "0x1888CEEF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool FBFNHAIHAFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x88CF880", Offset = "0x88CE680", VA = "0x1888CF880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool LJEKCHIHJOL
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x262CF00", Offset = "0x262BD00", VA = "0x18262CF00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event EBILHFJIDMN GAAGIFDHIAO
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x88CEE10", Offset = "0x88CDC10", VA = "0x1888CEE10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x88D0A80", Offset = "0x88CF880", VA = "0x1888D0A80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event NCFBIGMDCOK HIIENGHKEIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x88CEB80", Offset = "0x88CD980", VA = "0x1888CEB80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x88D07E0", Offset = "0x88CF5E0", VA = "0x1888D07E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event NCFBIGMDCOK POIAJKFOIJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x88CEBE0", Offset = "0x88CD9E0", VA = "0x1888CEBE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x88D0850", Offset = "0x88CF650", VA = "0x1888D0850")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event NCFBIGMDCOK IJMJHFCNAJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x88CED30", Offset = "0x88CDB30", VA = "0x1888CED30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x88D09A0", Offset = "0x88CF7A0", VA = "0x1888D09A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<CNPJGKPMCGN, CNPJGKPMCGN> AEOPKKKILGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x88CECC0", Offset = "0x88CDAC0", VA = "0x1888CECC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x88D0930", Offset = "0x88CF730", VA = "0x1888D0930")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event NCFBIGMDCOK OMEKGNAAEHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x88CEDA0", Offset = "0x88CDBA0", VA = "0x1888CEDA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x88D0A10", Offset = "0x88CF810", VA = "0x1888D0A10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event NCFBIGMDCOK BKCFPDGEPGP
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x88CEE80", Offset = "0x88CDC80", VA = "0x1888CEE80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x88D0AF0", Offset = "0x88CF8F0", VA = "0x1888D0AF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event NCFBIGMDCOK BDCDDPPKIEO
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x88CEC50", Offset = "0x88CDA50", VA = "0x1888CEC50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x88D08C0", Offset = "0x88CF6C0", VA = "0x1888D08C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA595B0", Offset = "0xA583B0", VA = "0x180A595B0", Slot = "8")]
		private void DPFGGAALBBJ(DPBLEIDODAC HJPGLGOFFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x88CD5D0", Offset = "0x88CC3D0", VA = "0x1888CD5D0", Slot = "9")]
		public IDNEBGPAEGO GetData()
		{
			return default(IDNEBGPAEGO);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x88CC530", Offset = "0x88CB330", VA = "0x1888CC530")]
		internal void AJDIDMPDBMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88CE8A0", Offset = "0x88CD6A0", VA = "0x1888CE8A0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody OBAPGEABIGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88CD320", Offset = "0x88CC120", VA = "0x1888CD320")]
		public OPDBNCCBFHO GetChild(int CKFKPOAGPKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x88CE560", Offset = "0x88CD360", VA = "0x1888CE560")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) KOAILPGHGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x88CCF70", Offset = "0x88CBD70", VA = "0x1888CCF70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x88CE7F0", Offset = "0x88CD5F0", VA = "0x1888CE7F0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x88CD8C0", Offset = "0x88CC6C0", VA = "0x1888CD8C0")]
		private DPBLEIDODAC KCGKMNKPJIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x88CDAF0", Offset = "0x88CC8F0", VA = "0x1888CDAF0")]
		private void ONJHMMKMDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x88CDD30", Offset = "0x88CCB30", VA = "0x1888CDD30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x88CDC70", Offset = "0x88CCA70", VA = "0x1888CDC70")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x88CC530", Offset = "0x88CB330", VA = "0x1888CC530")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x88CDCD0", Offset = "0x88CCAD0", VA = "0x1888CDCD0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x88CDD90", Offset = "0x88CCB90", VA = "0x1888CDD90")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x88CC5C0", Offset = "0x88CB3C0", VA = "0x1888CC5C0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object OCGDLEBGIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x88CDDF0", Offset = "0x88CCBF0", VA = "0x1888CDDF0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object OCGDLEBGIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x88CD2C0", Offset = "0x88CC0C0", VA = "0x1888CD2C0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x88CDA90", Offset = "0x88CC890", VA = "0x1888CDA90")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x88CE6C0", Offset = "0x88CD4C0", VA = "0x1888CE6C0")]
		public void SetParent(RigidbodyEx BNECONOIKOE, bool DJGMHEMHHPA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x88CE100", Offset = "0x88CCF00", VA = "0x1888CE100")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x88CD660", Offset = "0x88CC460", VA = "0x1888CD660")]
		public bool IsRigidbodyAncestor(RigidbodyEx JFPHJDFLGAG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x88CD760", Offset = "0x88CC560", VA = "0x1888CD760")]
		public bool IsRigidbodyDescendant(RigidbodyEx DEHCHAALFBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x88CC830", Offset = "0x88CB630", VA = "0x1888CC830")]
		public void AddInterpolationRestriction(object OCGDLEBGIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x88CDE60", Offset = "0x88CCC60", VA = "0x1888CDE60")]
		public void RemoveInterpolationRestriction(object OCGDLEBGIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x88CC8A0", Offset = "0x88CB6A0", VA = "0x1888CC8A0")]
		public void AddKinematic(object OCGDLEBGIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x88CDED0", Offset = "0x88CCCD0", VA = "0x1888CDED0")]
		public void RemoveKinematic(object OCGDLEBGIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x88CE640", Offset = "0x88CD440", VA = "0x1888CE640")]
		public void SetKinematic(object OCGDLEBGIMO, bool FGMALLCGIFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x88CE460", Offset = "0x88CD260", VA = "0x1888CE460")]
		public void SetDiscontinuousPositionAndRotation(Vector3 NEDCMPBJGFN, Quaternion KPABIJHGHOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x88CE360", Offset = "0x88CD160", VA = "0x1888CE360")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 EEJOIEKMLLG, Quaternion IEMENDNBBCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x88CD4C0", Offset = "0x88CC2C0", VA = "0x1888CD4C0")]
		public Vector3 GetConstrainedVelocity(Vector3 LNGDDNPHJHH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x88CD3B0", Offset = "0x88CC1B0", VA = "0x1888CD3B0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 BBFHLEIKDJM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x88CC740", Offset = "0x88CB540", VA = "0x1888CC740")]
		public void AddForce(Vector3 ADJOPEHJOFG, ForceMode GGOMBHIMGME = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x88CC630", Offset = "0x88CB430", VA = "0x1888CC630")]
		public void AddForceAtPosition(Vector3 ADJOPEHJOFG, Vector3 EMECBHNHILC, ForceMode GGOMBHIMGME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x88CCA70", Offset = "0x88CB870", VA = "0x1888CCA70")]
		public void AddTorque(Vector3 KNBKEDMLLME, ForceMode GGOMBHIMGME = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x88CC910", Offset = "0x88CB710", VA = "0x1888CC910")]
		public void AddRelativeTorque(Vector3 KNBKEDMLLME, ForceMode GGOMBHIMGME = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x88CE970", Offset = "0x88CD770", VA = "0x1888CE970")]
		public Vector3 WorldToLocalVelocity(Vector3 DEEDLFLENGK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x88CD970", Offset = "0x88CC770", VA = "0x1888CD970")]
		public Vector3 LocalToWorldVelocity(Vector3 LLAKBEKJKJD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x88CD260", Offset = "0x88CC060", VA = "0x1888CD260")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x88CD200", Offset = "0x88CC000", VA = "0x1888CD200")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x88CD1A0", Offset = "0x88CBFA0", VA = "0x1888CD1A0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x88CD140", Offset = "0x88CBF40", VA = "0x1888CD140")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x88CE260", Offset = "0x88CD060", VA = "0x1888CE260")]
		public void ResetVelocityWorldSpace(Vector3 BLBNBDFIMNA, Vector3 BPPNHBPFKIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x88CE160", Offset = "0x88CCF60", VA = "0x1888CE160")]
		public void ResetVelocityLocalSpace(Vector3 ADFHMMCFFLO, Vector3 DMILHKKHJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x88CE020", Offset = "0x88CCE20", VA = "0x1888CE020")]
		public void ResetLinearVelocityLocalSpace(Vector3 ADFHMMCFFLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x88CE800", Offset = "0x88CD600", VA = "0x1888CE800")]
		public bool SweepTest(Vector3 NCJMIJBPLIB, [Out] RaycastHit MKFBNOBLHEA, float NGOCCMOBNDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x88CD860", Offset = "0x88CC660", VA = "0x1888CD860")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x88CE790", Offset = "0x88CD590", VA = "0x1888CE790")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x88CE910", Offset = "0x88CD710", VA = "0x1888CE910")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x88CCA00", Offset = "0x88CB800", VA = "0x1888CCA00")]
		public void AddShouldHaveUnityRigidbodyToken(object OCGDLEBGIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x88CDF40", Offset = "0x88CCD40", VA = "0x1888CDF40")]
		public void RemoveShouldHaveUnityRigidbodyToken(object OCGDLEBGIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x88CCE00", Offset = "0x88CBC00", VA = "0x1888CCE00")]
		public void ApplyForceVelocityChange(HABPAFPJJJJ KLNJBBBKJCO, Vector3 DOOFBAFADGL, float LCINEAPPHPI, float GECGBFGHNIB = 8f, float IAOKKLJMKPD = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x88CCD00", Offset = "0x88CBB00", VA = "0x1888CCD00")]
		public void ApplyAngularVelocityChange(HDKAGLOAMDF HHPOMFKHONG, Vector3 FHDIIOHIJPM, float FALGOEEDNBH = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x88CCEC0", Offset = "0x88CBCC0", VA = "0x1888CCEC0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(HDKAGLOAMDF HHPOMFKHONG, Vector3 NOLDGDLLBBL, float MOJCPCKJGIA = 7f, float OEOJAMPNJLC = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x88CCC30", Offset = "0x88CBA30", VA = "0x1888CCC30")]
		public bool AllowedScaleChange(float PGBCNNCAMLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x88CCB60", Offset = "0x88CB960", VA = "0x1888CCB60")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx IMDHGEHNKDM, object OCGDLEBGIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x88CDFB0", Offset = "0x88CCDB0", VA = "0x1888CDFB0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object OCGDLEBGIMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x88CDA80", Offset = "0x88CC880", VA = "0x1888CDA80", Slot = "13")]
		private void MDPJBIMIOGE(HLIDELEPHMC IEOOLFDDEEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x88CEB10", Offset = "0x88CD910", VA = "0x1888CEB10")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAF69F0", Offset = "0xAF57F0", VA = "0x180AF69F0", Slot = "4")]
		private GameObject GGKMOCNLPIN()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA85C10", Offset = "0xA84A10", VA = "0x180A85C10", Slot = "10")]
		private bool JGCGIJJFOGK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class LGNDDFFPBAN
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x88C7D00", Offset = "0x88C6B00", VA = "0x1888C7D00")]
	public static DPBLEIDODAC OMAGLDJIKDO(this RigidbodyEx BNHFIJBCOJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(HCOKNMINHIL), new string[] { })]
public class ABCGAONGNNB : HCOKNMINHIL, BIBHAKFMBDN
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private CEBPCLKEHHO JBNGHMBPLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private FFILCINMDKK INCLLIEODJL;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public CEBPCLKEHHO HLIHHKGELEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public FFILCINMDKK JOCCBBMELAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x88B5750", Offset = "0x88B4550", VA = "0x1888B5750", Slot = "7")]
	public void InitReferences(GFFDGLCCIJL HOEHAJENLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x88B5620", Offset = "0x88B4420", VA = "0x1888B5620", Slot = "6")]
	public DPBLEIDODAC GJOIJGJKLEB(RigidbodyEx BNHFIJBCOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public ABCGAONGNNB()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static EPBKGABEMJJ UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int NFMDNKGGAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int HPFLAPEMBJB;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x88CC390", Offset = "0x88CB190", VA = "0x1888CC390")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x88CC3D0", Offset = "0x88CB1D0", VA = "0x1888CC3D0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x88CC3B0", Offset = "0x88CB1B0", VA = "0x1888CC3B0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string IIHOFBLPONF, [Optional] UnityEngine.Object IEOOLFDDEEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string IIHOFBLPONF, [Optional] UnityEngine.Object IEOOLFDDEEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x88CC4E0", Offset = "0x88CB2E0", VA = "0x1888CC4E0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PGPGFGNCOIL
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class FCGONJLKKIO : FHIEKILDCOB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA689C0", Offset = "0xA677C0", VA = "0x180A689C0", Slot = "4")]
		public Vector3 DBKBIHOFMMN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA689C0", Offset = "0xA677C0", VA = "0x180A689C0", Slot = "5")]
		public Vector3 DGFLKJKEIAO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "6")]
		public bool OBEBKFJCBBO(float MGHHGMFMBKD, float LDMDANBILND)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FCGONJLKKIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static FHIEKILDCOB EGCHIJPCDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x88CBDC0", Offset = "0x88CABC0", VA = "0x1888CBDC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DNIFKCNJLNB
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode PHENLJMPFJE
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
	void NBAJAKOOJPL();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CBPKKJPPCBJ(bool MMHMJBCCKLM);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MNHKIAPNFLB(bool MMHMJBCCKLM);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CIIHBMLFPGN(Rigidbody GEEACKEHDDE);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool AJNBGOOKCDE(Vector3 NCJMIJBPLIB, [Out] RaycastHit MKFBNOBLHEA, float NGOCCMOBNDC);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KKPCHBOBOPH : IDisposable, PLEJMOEMKPB
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CBJAHEEHPCM OJAJFEEKJFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<CNPJGKPMCGN, CNPJGKPMCGN> AEOPKKKILGM;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NBAJAKOOJPL();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface FFILCINMDKK
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IFPHBDKDLPP NCGIMKBKFAK(DPBLEIDODAC HJPGLGOFFHP);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ONIOBBCBFDO KHKBMDLNOGP(DPBLEIDODAC HJPGLGOFFHP);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDLOOMFFNMN HGAGHPLAIHI(DPBLEIDODAC HJPGLGOFFHP);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PHNHCJAADGJ JAELMLCCNEC(DPBLEIDODAC HJPGLGOFFHP);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NPGNHCMCFGK OMAFBJKLDMJ(DPBLEIDODAC HJPGLGOFFHP);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KKPCHBOBOPH ALMKIGIBGCH(DPBLEIDODAC HJPGLGOFFHP);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KDBENFNMCPJ DJGILOLKFIO(DPBLEIDODAC HJPGLGOFFHP);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FPHDOLLFMEK JLPOCILIGBN(DPBLEIDODAC HJPGLGOFFHP);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DNIFKCNJLNB LLHKELHFENC(DPBLEIDODAC HJPGLGOFFHP);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NKIHNCFDPJB LKFPPLFCHID(DPBLEIDODAC HJPGLGOFFHP);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HKEPGHJDNLH CAMONIIPNEJ(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ONKKKKFGNHD GGMONKBPJAG(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LDDCNFEFPPF KEOMKAFMIHN(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BOCBKPGFKAD LJLGKHIGGKA(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HLMGMHALCNI LJFAHFFPLLE(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DPBLEIDODAC GJOIJGJKLEB(RigidbodyEx BNHFIJBCOJI, IDNEBGPAEGO BOIPFNOKGBJ, HCOKNMINHIL HEJIJKOGOJP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FPHDOLLFMEK
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OMAFGAKEBCC(Vector3 ADJOPEHJOFG, ForceMode GGOMBHIMGME = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHBECMPPEIJ(Vector3 ADJOPEHJOFG, Vector3 EMECBHNHILC, ForceMode GGOMBHIMGME);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JIDEELPJIKP(Vector3 KNBKEDMLLME, ForceMode GGOMBHIMGME = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CNAMIAHONOJ(Vector3 KNBKEDMLLME, ForceMode GGOMBHIMGME = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NKIHNCFDPJB
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool NFNDCILINAC
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
	void CIIHBMLFPGN(Rigidbody GEEACKEHDDE);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LOKINGOJELK(Rigidbody GEEACKEHDDE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IFPHBDKDLPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<DPBLEIDODAC> KKLLAIOIIJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	DPBLEIDODAC KBGGJKBKACF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	DPBLEIDODAC BOOKBNFDCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event NCFBIGMDCOK HIIENGHKEIH;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event NCFBIGMDCOK POIAJKFOIJG;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event EBILHFJIDMN HKFFKBEFDOH;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action NOIPMHONIEB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action MPDKLMNPBFH;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<DPBLEIDODAC> OCMCHCHGILG;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<DPBLEIDODAC> GBDOCONOOKG;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action OHFCOINGNEP;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<DPBLEIDODAC> BJJAOIIDFCK;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IALDJKPIPLJ(DPBLEIDODAC HCGMLNGABFM, bool DJGMHEMHHPA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IDLOOMFFNMN
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 HPPAPHLGNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 KPKIPNFFABG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHOKANNDMHK(DPBLEIDODAC CMDMCJGFCDK, object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LNDOHCPGFCF(object OCGDLEBGIMO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface BOCBKPGFKAD
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 AKLIPNIGHGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 GLMFMPGHMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float ELNFAFPIPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float IALPHLPGMLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 LMMHGMMJPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion JFMGCINFADD
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event NCFBIGMDCOK DMCIOKHHNPD;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MJFGNCJKDGI((Quaternion rot, Vector3 moments) KOAILPGHGOM);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LOAAIBACFCK();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DFCHELDJHDP();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void AILODFEAFEE();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CIIHBMLFPGN(Rigidbody GEEACKEHDDE);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LOKINGOJELK(Rigidbody GEEACKEHDDE);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LEEMBAJDKPG();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LDDCNFEFPPF
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBAJAKOOJPL();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGIJFCJBDDI(object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGPODNGCHPJ(object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DIAMDBMNODL(DPBLEIDODAC BNHFIJBCOJI);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IOFLDLFIIIL(DPBLEIDODAC BNHFIJBCOJI);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IKBGFMPCCNE();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KDBENFNMCPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool NHFGNMMGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event NCFBIGMDCOK DAJHEHJOCME;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JJKBGICHEAL(object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KOMKILCDHBE(object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CKHEDNCAHPO(object OCGDLEBGIMO, bool FGMALLCGIFL);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CIIHBMLFPGN(Rigidbody GFGAJJMHNJH);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LOKINGOJELK(Rigidbody GEEACKEHDDE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ONKKKKFGNHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool OLOGEBJDKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool JFHEADJNHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event NCFBIGMDCOK FFAOAODBIJN;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NBAJAKOOJPL();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IEPHGPJPMHA(DPBLEIDODAC CMDMCJGFCDK);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HOJJOEEIDGD(DPBLEIDODAC CMDMCJGFCDK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HLMGMHALCNI
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool CAIMGNIAKBO
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool BGEFJGMEEJC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints HBAOEIKODDK
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
	void CIIHBMLFPGN(Rigidbody GEEACKEHDDE);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LOKINGOJELK(Rigidbody GEEACKEHDDE);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PHNHCJAADGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float BBJBPNLBEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float LOPDJJCJILO
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
	void CIIHBMLFPGN(Rigidbody GEEACKEHDDE);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LOKINGOJELK(Rigidbody GEEACKEHDDE);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NPGNHCMCFGK
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool CJEDDHMDKCE;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event NCFBIGMDCOK BMCAJPHDEFL;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NBAJAKOOJPL();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DIACFMMGCLC();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NEDBAJKJMPD();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LOAANMKDKIJ();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CIGPNEAEJAK();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool AHLCOGNMOBB();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DHGDIIPNFLG(bool ONAGHIEMLKH);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CMKADIODPEO();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HKEPGHJDNLH
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody OPIDLFEPEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool MOEGBGBBMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NBAJAKOOJPL();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OIPNOACLCAI(object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AHKKFALKFJA(object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FJFGGPDKAOK();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface ONIOBBCBFDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	FHIEKILDCOB GKEEJIGDEKI
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	PAAFNDDMBFD NPFBHJHKOMD
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 EPHIJFBBDFL
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 PJEFBKPCBNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 EPJELJJHJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 PPFBKGBPFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float ALOEDFDDPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool LDLFJPGODMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NBAJAKOOJPL();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HOHKHODHAEL(object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AECKGAOBPJD(HDKAGLOAMDF HHPOMFKHONG, Vector3 FHDIIOHIJPM, float FALGOEEDNBH = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NEHDDKABHFH(HABPAFPJJJJ KLNJBBBKJCO, Vector3 DOOFBAFADGL, float LCINEAPPHPI, float GECGBFGHNIB = 8f, float IAOKKLJMKPD = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DACPAKELHKF(HDKAGLOAMDF HHPOMFKHONG, Vector3 NOLDGDLLBBL, float MOJCPCKJGIA = 7f, float OEOJAMPNJLC = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GECEDJONIFI();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void AELBOKFFMOD();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PCBIKLDEPOD();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void LFOOCAGFFJK();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CIIHBMLFPGN(Rigidbody GEEACKEHDDE);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 IHMGJAOIHIF(Vector3 LNGDDNPHJHH);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void FNBGGFEIMHI(object OCGDLEBGIMO);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DLIMHJKELMI(Vector3 BPMIEEKMOOO);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LLGPEKAKLEB(Vector3 ADFHMMCFFLO, Vector3 DMILHKKHJKK);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void LDBJJPBFJOG(Vector3 BLBNBDFIMNA, Vector3 BPPNHBPFKIK);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 EPKGFAPFPHD(Vector3 LLAKBEKJKJD);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 PGMCIMFBFFL(Vector3 DEEDLFLENGK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface CEBPCLKEHHO
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool DPLIINIMPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HENAKBFHBBF(string BKBLOMKNEFC);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NINCJHGAOBM(RigidbodyEx BNHFIJBCOJI, Action LJIGAFKJJAI);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MHLDPIEPPBM AJBHHLELOFI(int NHILFCCDNKD);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CECCNKMBGCF(Vector3 GKCPAEAGGML, float EDJINMHJHJB, Color PFKMCINIKNC);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface HCOKNMINHIL
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	CEBPCLKEHHO HLIHHKGELEG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	FFILCINMDKK JOCCBBMELAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DPBLEIDODAC GJOIJGJKLEB(RigidbodyEx BNHFIJBCOJI);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KFIFCKKAFNJ : DPBLEIDODAC, IDisposable, AKKOEBCFIEF
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool GNNOMNHIMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly HCOKNMINHIL HEJIJKOGOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal IFPHBDKDLPP FDEBGGJNHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal LDDCNFEFPPF HLLLOACGBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal ONKKKKFGNHD PNIONOLMFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal ONIOBBCBFDO LNGDDNPHJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal IDLOOMFFNMN JKOGLLOGCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal BOCBKPGFKAD HHKMCMEOGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal PHNHCJAADGJ DHNHPECIEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal NKIHNCFDPJB BJFKFLOFFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal NPGNHCMCFGK GKJDEOPBPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal KKPCHBOBOPH JKBFBAFIAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal KDBENFNMCPJ PCDBDFLJHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal FPHDOLLFMEK ADJOPEHJOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal HLMGMHALCNI NNDNPBFPGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal HKEPGHJDNLH GEEACKEHDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal DNIFKCNJLNB MKPCKDNCGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable JGBFDNBIHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool CJMAPNKKAPO;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public JDKDDPDJCCM BNDONJACCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "22")]
		get
		{
			return default(JDKDDPDJCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public OPDBNCCBFHO KMPJPDOJMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xABC2D0", Offset = "0xABB0D0", VA = "0x180ABC2D0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xB0E290", Offset = "0xB0D090", VA = "0x180B0E290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject GJPFCDPKGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA65C30", Offset = "0xA64A30", VA = "0x180A65C30", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA65C10", Offset = "0xA64A10", VA = "0x180A65C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform HBAFPBAGLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xB0E4E0", Offset = "0xB0D2E0", VA = "0x180B0E4E0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xB0E440", Offset = "0xB0D240", VA = "0x180B0E440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody OPIDLFEPEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x88C3C60", Offset = "0x88C2A60", VA = "0x1888C3C60", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public DPBLEIDODAC BOOKBNFDCLA
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x88C35C0", Offset = "0x88C23C0", VA = "0x1888C35C0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x88C1B50", Offset = "0x88C0950", VA = "0x1888C1B50", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int PMOGKCHOIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x88C37F0", Offset = "0x88C25F0", VA = "0x1888C37F0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public DPBLEIDODAC KBGGJKBKACF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x88C29B0", Offset = "0x88C17B0", VA = "0x1888C29B0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool HOLBLDFKNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x88BD830", Offset = "0x88BC630", VA = "0x1888BD830", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool OLOGEBJDKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x88C3170", Offset = "0x88C1F70", VA = "0x1888C3170", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool JFHEADJNHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x88C0A90", Offset = "0x88BF890", VA = "0x1888C0A90", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public FHIEKILDCOB GKEEJIGDEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x88C0A40", Offset = "0x88BF840", VA = "0x1888C0A40", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x88C2A00", Offset = "0x88C1800", VA = "0x1888C2A00", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public PAAFNDDMBFD NPFBHJHKOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x88BD7E0", Offset = "0x88BC5E0", VA = "0x1888BD7E0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x88C23F0", Offset = "0x88C11F0", VA = "0x1888C23F0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float ALOEDFDDPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x88C26C0", Offset = "0x88C14C0", VA = "0x1888C26C0", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x88C00D0", Offset = "0x88BEED0", VA = "0x1888C00D0", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 PJEFBKPCBNL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x88C3210", Offset = "0x88C2010", VA = "0x1888C3210", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x88BFF90", Offset = "0x88BED90", VA = "0x1888BFF90", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 PPFBKGBPFLL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x88BE890", Offset = "0x88BD690", VA = "0x1888BE890", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x88C2540", Offset = "0x88C1340", VA = "0x1888C2540", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 EPHIJFBBDFL
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x88C32F0", Offset = "0x88C20F0", VA = "0x1888C32F0", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x88C06F0", Offset = "0x88BF4F0", VA = "0x1888C06F0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 EPJELJJHJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x88C1600", Offset = "0x88C0400", VA = "0x1888C1600", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x88C0BE0", Offset = "0x88BF9E0", VA = "0x1888C0BE0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool MOLDNMJKALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x88C08F0", Offset = "0x88BF6F0", VA = "0x1888C08F0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool BDIAGIILAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x88BF3B0", Offset = "0x88BE1B0", VA = "0x1888BF3B0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool ELPKNLHNDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x88C14C0", Offset = "0x88C02C0", VA = "0x1888C14C0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool LDLFJPGODMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x88BD790", Offset = "0x88BC590", VA = "0x1888BD790", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 HPPAPHLGNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x88BE440", Offset = "0x88BD240", VA = "0x1888BE440", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 KPKIPNFFABG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x88BF820", Offset = "0x88BE620", VA = "0x1888BF820", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 AKLIPNIGHGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x88BFA00", Offset = "0x88BE800", VA = "0x1888BFA00", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x88C3090", Offset = "0x88C1E90", VA = "0x1888C3090", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 GLMFMPGHMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x88C0420", Offset = "0x88BF220", VA = "0x1888C0420", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float ELNFAFPIPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x88C3510", Offset = "0x88C2310", VA = "0x1888C3510", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float IALPHLPGMLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x88BF090", Offset = "0x88BDE90", VA = "0x1888BF090", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x88BE0D0", Offset = "0x88BCED0", VA = "0x1888BE0D0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 LMMHGMMJPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x88BEFB0", Offset = "0x88BDDB0", VA = "0x1888BEFB0", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion JFMGCINFADD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x88BD890", Offset = "0x88BC690", VA = "0x1888BD890", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float BBJBPNLBEDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x88BFEF0", Offset = "0x88BECF0", VA = "0x1888BFEF0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x88C3BF0", Offset = "0x88C29F0", VA = "0x1888C3BF0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float LOPDJJCJILO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x88BEF10", Offset = "0x88BDD10", VA = "0x1888BEF10", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x88BF6E0", Offset = "0x88BE4E0", VA = "0x1888BF6E0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool NFNDCILINAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x88BEA30", Offset = "0x88BD830", VA = "0x1888BEA30", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x88BF740", Offset = "0x88BE540", VA = "0x1888BF740", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public CBJAHEEHPCM OJAJFEEKJFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x88C06A0", Offset = "0x88BF4A0", VA = "0x1888C06A0", Slot = "70")]
		get
		{
			return default(CBJAHEEHPCM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x88BE020", Offset = "0x88BCE20", VA = "0x1888BE020", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool NHFGNMMGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x88BECA0", Offset = "0x88BDAA0", VA = "0x1888BECA0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform JJFFAELKOEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xB0E4E0", Offset = "0xB0D2E0", VA = "0x180B0E4E0", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 HOPBKGMFHAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x88C2E30", Offset = "0x88C1C30", VA = "0x1888C2E30", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x88C27C0", Offset = "0x88C15C0", VA = "0x1888C27C0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float EBBHPDLLJMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x88C3C50", Offset = "0x88C2A50", VA = "0x1888C3C50", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x88C2360", Offset = "0x88C1160", VA = "0x1888C2360", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float BHBLGOFMAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x88C3500", Offset = "0x88C2300", VA = "0x1888C3500", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x88C0CC0", Offset = "0x88BFAC0", VA = "0x1888C0CC0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion LPHDFMFPCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x88BE970", Offset = "0x88BD770", VA = "0x1888BE970", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x88C16E0", Offset = "0x88C04E0", VA = "0x1888C16E0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 NHPCBBHHNDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x88BE1D0", Offset = "0x88BCFD0", VA = "0x1888BE1D0", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x88C0B40", Offset = "0x88BF940", VA = "0x1888C0B40", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion HAEAKBALEAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x88C37B0", Offset = "0x88C25B0", VA = "0x1888C37B0", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x88BF650", Offset = "0x88BE450", VA = "0x1888BF650", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints HBAOEIKODDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x88C07D0", Offset = "0x88BF5D0", VA = "0x1888C07D0", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x88BEA80", Offset = "0x88BD880", VA = "0x1888BEA80", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool CAIMGNIAKBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x88C31C0", Offset = "0x88C1FC0", VA = "0x1888C31C0", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x88C0500", Offset = "0x88BF300", VA = "0x1888C0500", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode PHENLJMPFJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x88C0130", Offset = "0x88BEF30", VA = "0x1888C0130", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x88C1A90", Offset = "0x88C0890", VA = "0x1888C1A90", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool JAJIBNJEDLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x88C2CF0", Offset = "0x88C1AF0", VA = "0x1888C2CF0", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool MENIBLCOEKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x88BE210", Offset = "0x88BD010", VA = "0x1888BE210", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event NCFBIGMDCOK HIIENGHKEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x88C0B80", Offset = "0x88BF980", VA = "0x1888C0B80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x88BEE50", Offset = "0x88BDC50", VA = "0x1888BEE50", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event NCFBIGMDCOK POIAJKFOIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x88C3920", Offset = "0x88C2720", VA = "0x1888C3920", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x88BFB40", Offset = "0x88BE940", VA = "0x1888BFB40", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event EBILHFJIDMN HKFFKBEFDOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x88C0AE0", Offset = "0x88BF8E0", VA = "0x1888C0AE0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x88BF680", Offset = "0x88BE480", VA = "0x1888BF680", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event NCFBIGMDCOK FFAOAODBIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x88C0180", Offset = "0x88BEF80", VA = "0x1888C0180", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x88C3750", Offset = "0x88C2550", VA = "0x1888C3750", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event NCFBIGMDCOK IJMJHFCNAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x88BF410", Offset = "0x88BE210", VA = "0x1888BF410", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x88C33D0", Offset = "0x88C21D0", VA = "0x1888C33D0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event NCFBIGMDCOK BMCAJPHDEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x88C15A0", Offset = "0x88C03A0", VA = "0x1888C15A0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x88C3610", Offset = "0x88C2410", VA = "0x1888C3610", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<CNPJGKPMCGN, CNPJGKPMCGN> AEOPKKKILGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x88BFBA0", Offset = "0x88BE9A0", VA = "0x1888BFBA0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x88C19E0", Offset = "0x88C07E0", VA = "0x1888C19E0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event NCFBIGMDCOK DAJHEHJOCME
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x88BDAB0", Offset = "0x88BC8B0", VA = "0x1888BDAB0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x88BFAE0", Offset = "0x88BE8E0", VA = "0x1888BFAE0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event NCFBIGMDCOK BDCDDPPKIEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x88BEDA0", Offset = "0x88BDBA0", VA = "0x1888BEDA0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x88BE390", Offset = "0x88BD190", VA = "0x1888BE390", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x88C3CF0", Offset = "0x88C2AF0", VA = "0x1888C3CF0")]
	public KFIFCKKAFNJ(GameObject JLNNGPHDMLM, RigidbodyEx BGLGCACIJBO, HCOKNMINHIL HEJIJKOGOJP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x88BFC00", Offset = "0x88BEA00", VA = "0x1888BFC00", Slot = "139")]
	protected virtual void FLAACGNPJOJ(HCOKNMINHIL HEJIJKOGOJP, IDNEBGPAEGO BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x88BF550", Offset = "0x88BE350", VA = "0x1888BF550", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x88C2AF0", Offset = "0x88C18F0", VA = "0x1888C2AF0", Slot = "93")]
	public void NBAJAKOOJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x88C0390", Offset = "0x88BF190", VA = "0x1888C0390", Slot = "94")]
	public void HEMMENFMKAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x88C0070", Offset = "0x88BEE70", VA = "0x1888C0070", Slot = "95")]
	public void GKAMMBGMKJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x88BEA10", Offset = "0x88BD810", VA = "0x1888BEA10", Slot = "96")]
	public void BOPGCJILNLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x88BF0E0", Offset = "0x88BDEE0", VA = "0x1888BF0E0")]
	private void DHGDIIPNFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x88C0310", Offset = "0x88BF110", VA = "0x1888C0310")]
	private void HCLIKLCHADP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x88BDFC0", Offset = "0x88BCDC0", VA = "0x1888BDFC0")]
	private void AHLCOGNMOBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x88BF7A0", Offset = "0x88BE5A0", VA = "0x1888BF7A0", Slot = "30")]
	public DPBLEIDODAC EIFCKAIBFKK(int CKFKPOAGPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x88C0630", Offset = "0x88BF430", VA = "0x1888C0630", Slot = "98")]
	public void IALDJKPIPLJ(DPBLEIDODAC BNECONOIKOE, bool DJGMHEMHHPA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x88C1CE0", Offset = "0x88C0AE0", VA = "0x1888C1CE0", Slot = "99")]
	public void LAFNKMOEHGF(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x88C2950", Offset = "0x88C1750", VA = "0x1888C2950", Slot = "100")]
	public void MJGBMMDLPMN(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x88C3980", Offset = "0x88C2780", VA = "0x1888C3980", Slot = "101")]
	public Vector3 PGMCIMFBFFL(Vector3 DEEDLFLENGK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x88BF900", Offset = "0x88BE700", VA = "0x1888BF900", Slot = "102")]
	public Vector3 EPKGFAPFPHD(Vector3 LLAKBEKJKJD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x88C1EE0", Offset = "0x88C0CE0", VA = "0x1888C1EE0", Slot = "103")]
	public void LFOOCAGFFJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x88BDA60", Offset = "0x88BC860", VA = "0x1888BDA60", Slot = "104")]
	public void AELBOKFFMOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x88BFF40", Offset = "0x88BED40", VA = "0x1888BFF40", Slot = "105")]
	public void GECEDJONIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x88C1D40", Offset = "0x88C0B40", VA = "0x1888C1D40", Slot = "106")]
	public void LDBJJPBFJOG(Vector3 BLBNBDFIMNA, Vector3 BPPNHBPFKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x88C2450", Offset = "0x88C1250", VA = "0x1888C2450", Slot = "107")]
	public void LLGPEKAKLEB(Vector3 ADFHMMCFFLO, Vector3 DMILHKKHJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x88BF470", Offset = "0x88BE270", VA = "0x1888BF470", Slot = "108")]
	public void DLIMHJKELMI(Vector3 BPMIEEKMOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x88C2C30", Offset = "0x88C1A30", VA = "0x1888C2C30", Slot = "109")]
	public void NEHDDKABHFH(HABPAFPJJJJ KLNJBBBKJCO, Vector3 DOOFBAFADGL, float LCINEAPPHPI, float GECGBFGHNIB = 8f, float IAOKKLJMKPD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x88BD960", Offset = "0x88BC760", VA = "0x1888BD960", Slot = "110")]
	public void AECKGAOBPJD(HDKAGLOAMDF HHPOMFKHONG, Vector3 FHDIIOHIJPM, float FALGOEEDNBH = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x88BECF0", Offset = "0x88BDAF0", VA = "0x1888BECF0", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void DACPAKELHKF(HDKAGLOAMDF HHPOMFKHONG, Vector3 NOLDGDLLBBL, float MOJCPCKJGIA = 7f, float OEOJAMPNJLC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x88C0940", Offset = "0x88BF740", VA = "0x1888C0940", Slot = "112")]
	public Vector3 IHMGJAOIHIF(Vector3 BNECONOIKOE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x88C2110", Offset = "0x88C0F10", VA = "0x1888C2110", Slot = "113")]
	public Vector3 LHONBILCJGP(Vector3 BNECONOIKOE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x88C3860", Offset = "0x88C2660", VA = "0x1888C3860", Slot = "114")]
	public void PCBIKLDEPOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x88C38B0", Offset = "0x88C26B0", VA = "0x1888C38B0", Slot = "115")]
	public void PEHENHDBJIB(DPBLEIDODAC IMDHGEHNKDM, object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x88BEEB0", Offset = "0x88BDCB0", VA = "0x1888BEEB0", Slot = "116")]
	public void DCLLLLMNLKG(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x88C2870", Offset = "0x88C1670", VA = "0x1888C2870", Slot = "63")]
	public void MJFGNCJKDGI((Quaternion rot, Vector3 moments) KOAILPGHGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x88BEF60", Offset = "0x88BDD60", VA = "0x1888BEF60", Slot = "117")]
	public void DFCHELDJHDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x88C2620", Offset = "0x88C1420", VA = "0x1888C2620", Slot = "118")]
	public void LOAAIBACFCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x88BE080", Offset = "0x88BCE80", VA = "0x1888BE080", Slot = "119")]
	public void AILODFEAFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x88BF360", Offset = "0x88BE160", VA = "0x1888BF360", Slot = "120")]
	public bool DIACFMMGCLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x88C2670", Offset = "0x88C1470", VA = "0x1888C2670", Slot = "97")]
	public void LOAANMKDKIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x88BEB50", Offset = "0x88BD950", VA = "0x1888BEB50", Slot = "121")]
	public void CMKADIODPEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x88C10A0", Offset = "0x88BFEA0", VA = "0x1888C10A0", Slot = "122")]
	public void JJKBGICHEAL(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x88C1AF0", Offset = "0x88C08F0", VA = "0x1888C1AF0", Slot = "123")]
	public void KOMKILCDHBE(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x88BEAE0", Offset = "0x88BD8E0", VA = "0x1888BEAE0", Slot = "124")]
	public void CKHEDNCAHPO(object OCGDLEBGIMO, bool FGMALLCGIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x88C0DC0", Offset = "0x88BFBC0", VA = "0x1888C0DC0", Slot = "125")]
	public void JHDMBLACBGC(Vector3 NEDCMPBJGFN, Quaternion KPABIJHGHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x88C01E0", Offset = "0x88BEFE0", VA = "0x1888C01E0", Slot = "126")]
	public void GPMBLDOEFGA(Vector3 EEJOIEKMLLG, Quaternion IEMENDNBBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x88C1A40", Offset = "0x88C0840", VA = "0x1888C1A40", Slot = "127")]
	public bool KNECLCJKENB(float PGBCNNCAMLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x88C1100", Offset = "0x88BFF00", VA = "0x1888C1100", Slot = "128")]
	public void JJPAKMAIGII(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x88C1E30", Offset = "0x88C0C30", VA = "0x1888C1E30", Slot = "129")]
	public void LDLIPDINNFN(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x88C3560", Offset = "0x88C2360", VA = "0x1888C3560", Slot = "130")]
	public void OIPNOACLCAI(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x88BDF60", Offset = "0x88BCD60", VA = "0x1888BDF60", Slot = "131")]
	public void AHKKFALKFJA(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x88C3670", Offset = "0x88C2470", VA = "0x1888C3670", Slot = "132")]
	public void OMAFGAKEBCC(Vector3 ADJOPEHJOFG, ForceMode GGOMBHIMGME = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x88C17C0", Offset = "0x88C05C0", VA = "0x1888C17C0", Slot = "133")]
	public void KHBECMPPEIJ(Vector3 ADJOPEHJOFG, Vector3 EMECBHNHILC, ForceMode GGOMBHIMGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x88C0FC0", Offset = "0x88BFDC0", VA = "0x1888C0FC0", Slot = "134")]
	public void JIDEELPJIKP(Vector3 KNBKEDMLLME, ForceMode GGOMBHIMGME = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x88BEBC0", Offset = "0x88BD9C0", VA = "0x1888BEBC0", Slot = "135")]
	public void CNAMIAHONOJ(Vector3 KNBKEDMLLME, ForceMode GGOMBHIMGME = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x88BE130", Offset = "0x88BCF30", VA = "0x1888BE130", Slot = "136")]
	public bool AJNBGOOKCDE(Vector3 NCJMIJBPLIB, [Out] RaycastHit MKFBNOBLHEA, float NGOCCMOBNDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x88C1E90", Offset = "0x88C0C90", VA = "0x1888C1E90", Slot = "137")]
	public void LEEMBAJDKPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x88C3CB0", Offset = "0x88C2AB0", VA = "0x1888C3CB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x88C3430", Offset = "0x88C2230", VA = "0x1888C3430")]
	private void ODFOEGPIEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x88C18D0", Offset = "0x88C06D0", VA = "0x1888C18D0")]
	private void KHONEGFCEBP(DPBLEIDODAC CMDMCJGFCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x88C1F30", Offset = "0x88C0D30", VA = "0x1888C1F30")]
	private void LGBOJMGIMMF(DPBLEIDODAC CMDMCJGFCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x88C2710", Offset = "0x88C1510", VA = "0x1888C2710")]
	private void LPHLLBDEEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x88BD660", Offset = "0x88BC460", VA = "0x1888BD660")]
	private void AAJAJOCFCBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x88C2EE0", Offset = "0x88C1CE0", VA = "0x1888C2EE0")]
	private void NGBIGPEHBHB(DPBLEIDODAC GAALPIBIDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x88C0820", Offset = "0x88BF620", VA = "0x1888C0820")]
	private void IEPHGPJPMHA(DPBLEIDODAC CMDMCJGFCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x88C0560", Offset = "0x88BF360", VA = "0x1888C0560")]
	private void HOJJOEEIDGD(DPBLEIDODAC CMDMCJGFCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x88C2210", Offset = "0x88C1010", VA = "0x1888C2210")]
	private void LHOPIOFGBHN(OPDBNCCBFHO CMDMCJGFCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x88BDB10", Offset = "0x88BC910", VA = "0x1888BDB10", Slot = "142")]
	protected virtual void AHICCDGJBKA(OPDBNCCBFHO BNHFIJBCOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x88C1160", Offset = "0x88BFF60", VA = "0x1888C1160")]
	protected void JMPMPBIIPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x88BE510", Offset = "0x88BD310", VA = "0x1888BE510")]
	protected void BIIMCJEPEHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x88C1BB0", Offset = "0x88C09B0", VA = "0x1888C1BB0")]
	private void LADBNKKMKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x88C3A80", Offset = "0x88C2880", VA = "0x1888C3A80")]
	private void PIIFKJGJKNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class NGIFIGHMLPP
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x88CA6A0", Offset = "0x88C94A0", VA = "0x1888CA6A0")]
	public static DPBLEIDODAC KHNKJMJPAHC(this DPBLEIDODAC BNHFIJBCOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x88CA760", Offset = "0x88C9560", VA = "0x1888CA760")]
	public static bool LMCOMDMFOKA(this DPBLEIDODAC BNHFIJBCOJI, DPBLEIDODAC JFPHJDFLGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x88CA600", Offset = "0x88C9400", VA = "0x1888CA600")]
	public static bool JHJBFIKENNK(this DPBLEIDODAC BNHFIJBCOJI, DPBLEIDODAC DEHCHAALFBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x88CA870", Offset = "0x88C9670", VA = "0x1888CA870")]
	public static OPDBNCCBFHO OGEBIIBLEDD(this DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x88CA800", Offset = "0x88C9600", VA = "0x1888CA800")]
	public static KFIFCKKAFNJ LMENFEJIFCB(this DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DFDIOOJJCFM : FFILCINMDKK
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x88B82D0", Offset = "0x88B70D0", VA = "0x1888B82D0", Slot = "19")]
	public DPBLEIDODAC GJOIJGJKLEB(RigidbodyEx BNHFIJBCOJI, IDNEBGPAEGO BOIPFNOKGBJ, HCOKNMINHIL HEJIJKOGOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "4")]
	public IFPHBDKDLPP NCGIMKBKFAK(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "5")]
	public ONIOBBCBFDO KHKBMDLNOGP(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "6")]
	public IDLOOMFFNMN HGAGHPLAIHI(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "7")]
	public PHNHCJAADGJ JAELMLCCNEC(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "8")]
	public NPGNHCMCFGK OMAFBJKLDMJ(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "9")]
	public KKPCHBOBOPH ALMKIGIBGCH(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "10")]
	public KDBENFNMCPJ DJGILOLKFIO(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "11")]
	public FPHDOLLFMEK JLPOCILIGBN(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "12")]
	public DNIFKCNJLNB LLHKELHFENC(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "13")]
	public NKIHNCFDPJB LKFPPLFCHID(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420")]
	public HKEPGHJDNLH CAMONIIPNEJ(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420")]
	public ONKKKKFGNHD GGMONKBPJAG(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420")]
	public LDDCNFEFPPF KEOMKAFMIHN(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420")]
	public BOCBKPGFKAD LJLGKHIGGKA(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420")]
	public HLMGMHALCNI LJFAHFFPLLE(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public DFDIOOJJCFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "14")]
	private HKEPGHJDNLH GFGEFPLHFCK(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "15")]
	private ONKKKKFGNHD KEHJEHAPOLN(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "16")]
	private LDDCNFEFPPF GFFNFKIEFNI(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "17")]
	private BOCBKPGFKAD LPJGOFGPBHG(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "18")]
	private HLMGMHALCNI CKINMKEEOBP(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(FFILCINMDKK), new string[] { })]
public class KADLKMFMLEB : FFILCINMDKK, BIBHAKFMBDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly FFILCINMDKK DHJLKJBELOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly FFILCINMDKK BDMEPNIKLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private AEEMGADOCFD PAIJGDKGMLA;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private FFILCINMDKK JOCCBBMELAO
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x88BD410", Offset = "0x88BC210", VA = "0x1888BD410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x88BCFF0", Offset = "0x88BBDF0", VA = "0x1888BCFF0", Slot = "20")]
	public void InitReferences(GFFDGLCCIJL HOEHAJENLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x88BD470", Offset = "0x88BC270", VA = "0x1888BD470", Slot = "4")]
	public IFPHBDKDLPP NCGIMKBKFAK(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x88BD180", Offset = "0x88BBF80", VA = "0x1888BD180", Slot = "5")]
	public ONIOBBCBFDO KHKBMDLNOGP(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x88BCF50", Offset = "0x88BBD50", VA = "0x1888BCF50", Slot = "6")]
	public IDLOOMFFNMN HGAGHPLAIHI(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x88BD040", Offset = "0x88BBE40", VA = "0x1888BD040", Slot = "7")]
	public PHNHCJAADGJ JAELMLCCNEC(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x88BD510", Offset = "0x88BC310", VA = "0x1888BD510", Slot = "8")]
	public NPGNHCMCFGK OMAFBJKLDMJ(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x88BCA70", Offset = "0x88BB870", VA = "0x1888BCA70", Slot = "9")]
	public KKPCHBOBOPH ALMKIGIBGCH(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x88BCC70", Offset = "0x88BBA70", VA = "0x1888BCC70", Slot = "10")]
	public KDBENFNMCPJ DJGILOLKFIO(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x88BD0E0", Offset = "0x88BBEE0", VA = "0x1888BD0E0", Slot = "11")]
	public FPHDOLLFMEK JLPOCILIGBN(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x88BD370", Offset = "0x88BC170", VA = "0x1888BD370", Slot = "12")]
	public DNIFKCNJLNB LLHKELHFENC(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x88BD2D0", Offset = "0x88BC0D0", VA = "0x1888BD2D0", Slot = "13")]
	public NKIHNCFDPJB LKFPPLFCHID(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x88BCB10", Offset = "0x88BB910", VA = "0x1888BCB10")]
	public HKEPGHJDNLH CAMONIIPNEJ(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x88BCDC0", Offset = "0x88BBBC0", VA = "0x1888BCDC0")]
	public ONKKKKFGNHD GGMONKBPJAG(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x88BCD10", Offset = "0x88BBB10", VA = "0x1888BCD10")]
	public LDDCNFEFPPF KEOMKAFMIHN(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x88BD220", Offset = "0x88BC020", VA = "0x1888BD220")]
	public BOCBKPGFKAD LJLGKHIGGKA(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x88BCBC0", Offset = "0x88BB9C0", VA = "0x1888BCBC0")]
	public HLMGMHALCNI LJFAHFFPLLE(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x88BCE70", Offset = "0x88BBC70", VA = "0x1888BCE70", Slot = "19")]
	public DPBLEIDODAC GJOIJGJKLEB(RigidbodyEx BNHFIJBCOJI, IDNEBGPAEGO BOIPFNOKGBJ, HCOKNMINHIL HEJIJKOGOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x88BD5B0", Offset = "0x88BC3B0", VA = "0x1888BD5B0")]
	public KADLKMFMLEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x88BCB10", Offset = "0x88BB910", VA = "0x1888BCB10", Slot = "14")]
	private HKEPGHJDNLH GFGEFPLHFCK(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x88BCDC0", Offset = "0x88BBBC0", VA = "0x1888BCDC0", Slot = "15")]
	private ONKKKKFGNHD KEHJEHAPOLN(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x88BCD10", Offset = "0x88BBB10", VA = "0x1888BCD10", Slot = "16")]
	private LDDCNFEFPPF GFFNFKIEFNI(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x88BD220", Offset = "0x88BC020", VA = "0x1888BD220", Slot = "17")]
	private BOCBKPGFKAD LPJGOFGPBHG(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x88BCBC0", Offset = "0x88BB9C0", VA = "0x1888BCBC0", Slot = "18")]
	private HLMGMHALCNI CKINMKEEOBP(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface IMKCDEKNDCM : IFPHBDKDLPP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPPKNGDDBDO(DPBLEIDODAC BNHFIJBCOJI);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDEDMMPBEFN(DPBLEIDODAC BNHFIJBCOJI);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLPCJPMLICO(DPBLEIDODAC GAALPIBIDLB);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DHMBJKKKEKK(DPBLEIDODAC GAALPIBIDLB);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface POBOGCFEAIB : IDLOOMFFNMN
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	NMLCKLLMNLK<DPBLEIDODAC> APFDLNICKGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	DPBLEIDODAC GPGIFGNEIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NGDMPKGJFKA : BOCBKPGFKAD
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) LDHJLCKPNPF(Rigidbody LBNBCMKGFNF);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface BIHPNPELPHF : ONKKKKFGNHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	RRNetworkView IBOMAJMCOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class KFLBEJLPFPM : DNIFKCNJLNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly KFIFCKKAFNJ BNHFIJBCOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode EIBHGACBPDK;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody OPIDLFEPEBF
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x88C4390", Offset = "0x88C3190", VA = "0x1888C4390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode PHENLJMPFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x88C40F0", Offset = "0x88C2EF0", VA = "0x1888C40F0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x88C4200", Offset = "0x88C3000", VA = "0x1888C4200", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x88BAA70", Offset = "0x88B9870", VA = "0x1888BAA70")]
	public KFLBEJLPFPM(DPBLEIDODAC BNHFIJBCOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x88C4280", Offset = "0x88C3080", VA = "0x1888C4280", Slot = "6")]
	public void NBAJAKOOJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x88C3F50", Offset = "0x88C2D50", VA = "0x1888C3F50", Slot = "9")]
	public void CIIHBMLFPGN(Rigidbody GEEACKEHDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x88C3F40", Offset = "0x88C2D40", VA = "0x1888C3F40", Slot = "7")]
	public void CBPKKJPPCBJ(bool MMHMJBCCKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x88C4270", Offset = "0x88C3070", VA = "0x1888C4270", Slot = "8")]
	public void MNHKIAPNFLB(bool MMHMJBCCKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x88C3DE0", Offset = "0x88C2BE0", VA = "0x1888C3DE0", Slot = "10")]
	public bool AJNBGOOKCDE(Vector3 NCJMIJBPLIB, [Out] RaycastHit MKFBNOBLHEA, float NGOCCMOBNDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x88C3FD0", Offset = "0x88C2DD0", VA = "0x1888C3FD0")]
	private void FMADNEFGPCN(bool MMHMJBCCKLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FEDIBJBKHHI : KKPCHBOBOPH, IDisposable, PLEJMOEMKPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KFIFCKKAFNJ BNHFIJBCOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private CBJAHEEHPCM OAKGDEELILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private MHLDPIEPPBM FGPHAOJKKHP;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public CBJAHEEHPCM OJAJFEEKJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x88B9ED0", Offset = "0x88B8CD0", VA = "0x1888B9ED0", Slot = "6")]
		get
		{
			return default(CBJAHEEHPCM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x88B9D00", Offset = "0x88B8B00", VA = "0x1888B9D00", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform HHLCJJMMIMH
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xDE8080", Offset = "0xDE6E80", VA = "0x180DE8080", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<CNPJGKPMCGN, CNPJGKPMCGN> AEOPKKKILGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x88B9E20", Offset = "0x88B8C20", VA = "0x1888B9E20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x88BA010", Offset = "0x88B8E10", VA = "0x1888BA010", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x88BA330", Offset = "0x88B9130", VA = "0x1888BA330")]
	public FEDIBJBKHHI(DPBLEIDODAC BNHFIJBCOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x88BA0C0", Offset = "0x88B8EC0", VA = "0x1888BA0C0", Slot = "8")]
	public void NBAJAKOOJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x88B9DD0", Offset = "0x88B8BD0", VA = "0x1888B9DD0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x12C9B10", Offset = "0x12C8910", VA = "0x1812C9B10", Slot = "11")]
	private void FPHGIFFCDGM(CNPJGKPMCGN BPJAEOCDPBE, CNPJGKPMCGN NCHCOBIEDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "12")]
	private void CHELNAIBOIC(bool ELBEIBGFCLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class FBAJNDALKEL : FFILCINMDKK
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x88B9B40", Offset = "0x88B8940", VA = "0x1888B9B40", Slot = "4")]
	public IFPHBDKDLPP NCGIMKBKFAK(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x88B9710", Offset = "0x88B8510", VA = "0x1888B9710", Slot = "5")]
	public ONIOBBCBFDO KHKBMDLNOGP(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x88B94A0", Offset = "0x88B82A0", VA = "0x1888B94A0", Slot = "6")]
	public IDLOOMFFNMN HGAGHPLAIHI(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x88B95D0", Offset = "0x88B83D0", VA = "0x1888B95D0", Slot = "7")]
	public PHNHCJAADGJ JAELMLCCNEC(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x88B9C30", Offset = "0x88B8A30", VA = "0x1888B9C30", Slot = "8")]
	public NPGNHCMCFGK OMAFBJKLDMJ(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x88B8C80", Offset = "0x88B7A80", VA = "0x1888B8C80", Slot = "9")]
	public KKPCHBOBOPH ALMKIGIBGCH(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x88B8F70", Offset = "0x88B7D70", VA = "0x1888B8F70", Slot = "10")]
	public KDBENFNMCPJ DJGILOLKFIO(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x88B9650", Offset = "0x88B8450", VA = "0x1888B9650", Slot = "11")]
	public FPHDOLLFMEK JLPOCILIGBN(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x88B9A80", Offset = "0x88B8880", VA = "0x1888B9A80", Slot = "12")]
	public DNIFKCNJLNB LLHKELHFENC(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x88B99C0", Offset = "0x88B87C0", VA = "0x1888B99C0", Slot = "13")]
	public NKIHNCFDPJB LKFPPLFCHID(DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x88B8D50", Offset = "0x88B7B50", VA = "0x1888B8D50")]
	public HKEPGHJDNLH CAMONIIPNEJ(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x88B91C0", Offset = "0x88B7FC0", VA = "0x1888B91C0")]
	public ONKKKKFGNHD GGMONKBPJAG(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x88B9090", Offset = "0x88B7E90", VA = "0x1888B9090")]
	public LDDCNFEFPPF KEOMKAFMIHN(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x88B9830", Offset = "0x88B8630", VA = "0x1888B9830")]
	public BOCBKPGFKAD LJLGKHIGGKA(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x88B8E90", Offset = "0x88B7C90", VA = "0x1888B8E90")]
	public HLMGMHALCNI LJFAHFFPLLE(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x88B9350", Offset = "0x88B8150", VA = "0x1888B9350", Slot = "19")]
	public DPBLEIDODAC GJOIJGJKLEB(RigidbodyEx BNHFIJBCOJI, IDNEBGPAEGO BOIPFNOKGBJ, HCOKNMINHIL HEJIJKOGOJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public FBAJNDALKEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x88B8D50", Offset = "0x88B7B50", VA = "0x1888B8D50", Slot = "14")]
	private HKEPGHJDNLH GFGEFPLHFCK(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x88B91C0", Offset = "0x88B7FC0", VA = "0x1888B91C0", Slot = "15")]
	private ONKKKKFGNHD KEHJEHAPOLN(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x88B9090", Offset = "0x88B7E90", VA = "0x1888B9090", Slot = "16")]
	private LDDCNFEFPPF GFFNFKIEFNI(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x88B9830", Offset = "0x88B8630", VA = "0x1888B9830", Slot = "17")]
	private BOCBKPGFKAD LPJGOFGPBHG(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x88B8E90", Offset = "0x88B7C90", VA = "0x1888B8E90", Slot = "18")]
	private HLMGMHALCNI CKINMKEEOBP(DPBLEIDODAC HJPGLGOFFHP, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class NOMFBHOPJDN : FPHDOLLFMEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly KFIFCKKAFNJ BNHFIJBCOJI;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody OPIDLFEPEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x88C4390", Offset = "0x88C3190", VA = "0x1888C4390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool NHFGNMMGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x88CB310", Offset = "0x88CA110", VA = "0x1888CB310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool HOLBLDFKNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x88B8370", Offset = "0x88B7170", VA = "0x1888B8370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private DPBLEIDODAC BOOKBNFDCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x88CBC00", Offset = "0x88CAA00", VA = "0x1888CBC00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x88BAA70", Offset = "0x88B9870", VA = "0x1888BAA70")]
	public NOMFBHOPJDN(DPBLEIDODAC BNHFIJBCOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x88CBC60", Offset = "0x88CAA60", VA = "0x1888CBC60", Slot = "4")]
	public void OMAFGAKEBCC(Vector3 ADJOPEHJOFG, ForceMode GGOMBHIMGME = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x88CB360", Offset = "0x88CA160", VA = "0x1888CB360")]
	private void HHMNOLFMKDB(Vector3 ADJOPEHJOFG, ForceMode GGOMBHIMGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x88CB720", Offset = "0x88CA520", VA = "0x1888CB720", Slot = "5")]
	public void KHBECMPPEIJ(Vector3 ADJOPEHJOFG, Vector3 EMECBHNHILC, ForceMode GGOMBHIMGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x88CB5C0", Offset = "0x88CA3C0", VA = "0x1888CB5C0", Slot = "6")]
	public void JIDEELPJIKP(Vector3 KNBKEDMLLME, ForceMode GGOMBHIMGME = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x88CB9A0", Offset = "0x88CA7A0", VA = "0x1888CB9A0")]
	private void NCHKLBKPEPD(Vector3 KNBKEDMLLME, ForceMode GGOMBHIMGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x88CB0B0", Offset = "0x88C9EB0", VA = "0x1888CB0B0", Slot = "7")]
	public void CNAMIAHONOJ(Vector3 KNBKEDMLLME, ForceMode GGOMBHIMGME = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class HPEFMJMOKON : NKIHNCFDPJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly KFIFCKKAFNJ BNHFIJBCOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool GLKFLGDIOBC;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool NFNDCILINAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAAA5A0", Offset = "0xAA93A0", VA = "0x180AAA5A0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x88BA8F0", Offset = "0x88B96F0", VA = "0x1888BA8F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x88BAA70", Offset = "0x88B9870", VA = "0x1888BAA70")]
	public HPEFMJMOKON(DPBLEIDODAC BNHFIJBCOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x88BA8C0", Offset = "0x88B96C0", VA = "0x1888BA8C0", Slot = "6")]
	public void CIIHBMLFPGN(Rigidbody GEEACKEHDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x88BAA00", Offset = "0x88B9800", VA = "0x1888BAA00", Slot = "7")]
	public void LOKINGOJELK(Rigidbody GEEACKEHDDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class JLGILOGDMEG : IMKCDEKNDCM, IFPHBDKDLPP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly DPBLEIDODAC BNHFIJBCOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<DPBLEIDODAC> MBGGCNGDHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private DPBLEIDODAC EGPDFGOHLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private DPBLEIDODAC CMDMCJGFCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform AGHIILCHOJF;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform HBAFPBAGLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x88BB9F0", Offset = "0x88BA7F0", VA = "0x1888BB9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public DPBLEIDODAC BOOKBNFDCLA
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E190", VA = "0x180A5F390", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x88BC2B0", Offset = "0x88BB0B0", VA = "0x1888BC2B0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public DPBLEIDODAC KBGGJKBKACF
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA5F320", Offset = "0xA5E120", VA = "0x180A5F320", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<DPBLEIDODAC> KKLLAIOIIJO
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA5F380", Offset = "0xA5E180", VA = "0x180A5F380", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event NCFBIGMDCOK HIIENGHKEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x88BC070", Offset = "0x88BAE70", VA = "0x1888BC070", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x88BB070", Offset = "0x88B9E70", VA = "0x1888BB070", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event NCFBIGMDCOK POIAJKFOIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x88BC730", Offset = "0x88BB530", VA = "0x1888BC730", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x88BB6C0", Offset = "0x88BA4C0", VA = "0x1888BB6C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event EBILHFJIDMN HKFFKBEFDOH
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x88BBFD0", Offset = "0x88BADD0", VA = "0x1888BBFD0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x88BB4D0", Offset = "0x88BA2D0", VA = "0x1888BB4D0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action NOIPMHONIEB
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x88BADB0", Offset = "0x88B9BB0", VA = "0x1888BADB0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x88BB810", Offset = "0x88BA610", VA = "0x1888BB810", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action MPDKLMNPBFH
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x88BC2C0", Offset = "0x88BB0C0", VA = "0x1888BC2C0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x88BB8B0", Offset = "0x88BA6B0", VA = "0x1888BB8B0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<DPBLEIDODAC> OCMCHCHGILG
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x88BC110", Offset = "0x88BAF10", VA = "0x1888BC110", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x88BB570", Offset = "0x88BA370", VA = "0x1888BB570", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<DPBLEIDODAC> GBDOCONOOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x88BB760", Offset = "0x88BA560", VA = "0x1888BB760", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x88BC900", Offset = "0x88BB700", VA = "0x1888BC900", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action OHFCOINGNEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x88BB620", Offset = "0x88BA420", VA = "0x1888BB620", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x88BC690", Offset = "0x88BB490", VA = "0x1888BC690", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<DPBLEIDODAC> BJJAOIIDFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x88BAE90", Offset = "0x88B9C90", VA = "0x1888BAE90", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x88BAD00", Offset = "0x88B9B00", VA = "0x1888BAD00", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x88BC9B0", Offset = "0x88BB7B0", VA = "0x1888BC9B0")]
	public JLGILOGDMEG(DPBLEIDODAC BNHFIJBCOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x88BB430", Offset = "0x88BA230", VA = "0x1888BB430", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x88BBA50", Offset = "0x88BA850", VA = "0x1888BBA50", Slot = "30")]
	public void IALDJKPIPLJ(DPBLEIDODAC HCGMLNGABFM, bool DJGMHEMHHPA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x88BC420", Offset = "0x88BB220", VA = "0x1888BC420", Slot = "6")]
	public void LLPCJPMLICO(DPBLEIDODAC GAALPIBIDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x88BB1B0", Offset = "0x88B9FB0", VA = "0x1888BB1B0", Slot = "7")]
	public void DHMBJKKKEKK(DPBLEIDODAC GAALPIBIDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x88BC1C0", Offset = "0x88BAFC0", VA = "0x1888BC1C0", Slot = "4")]
	public void JPPKNGDDBDO(DPBLEIDODAC BNHFIJBCOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x88BB110", Offset = "0x88B9F10", VA = "0x1888BB110", Slot = "5")]
	public void DDEDMMPBEFN(DPBLEIDODAC BNHFIJBCOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x88BB950", Offset = "0x88BA750", VA = "0x1888BB950")]
	private void HFEPLEMBKCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x88BAE50", Offset = "0x88B9C50", VA = "0x1888BAE50")]
	private void CHELFDLHJNP(DPBLEIDODAC GAALPIBIDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x88BABC0", Offset = "0x88B99C0", VA = "0x1888BABC0")]
	private void AAOLJCMFPLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x88BC7D0", Offset = "0x88BB5D0", VA = "0x1888BC7D0")]
	private void PNFHCIIOOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x88BAF40", Offset = "0x88B9D40", VA = "0x1888BAF40")]
	private void DCIIOICICEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x88BC360", Offset = "0x88BB160", VA = "0x1888BC360")]
	[CompilerGenerated]
	private object LJMMBHPCJCG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class IDAHFKKAADI
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x88BAB00", Offset = "0x88B9900", VA = "0x1888BAB00")]
	public static IMKCDEKNDCM LAFFJBHBIDC(this DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class MDEEBKAEGBC : POBOGCFEAIB, IDLOOMFFNMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly KFIFCKKAFNJ BNHFIJBCOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly NMLCKLLMNLK<DPBLEIDODAC> MACFAKHDNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool FLBFOGPIOBD;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public NMLCKLLMNLK<DPBLEIDODAC> APFDLNICKGG
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 HPPAPHLGNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x88C8B60", Offset = "0x88C7960", VA = "0x1888C8B60", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 KPKIPNFFABG
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x88C8C40", Offset = "0x88C7A40", VA = "0x1888C8C40", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 EPHIJFBBDFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x88C9740", Offset = "0x88C8540", VA = "0x1888C9740")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public DPBLEIDODAC GPGIFGNEIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x88C8B90", Offset = "0x88C7990", VA = "0x1888C8B90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x88C9820", Offset = "0x88C8620", VA = "0x1888C9820")]
	public MDEEBKAEGBC(DPBLEIDODAC BNHFIJBCOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x88C92D0", Offset = "0x88C80D0", VA = "0x1888C92D0", Slot = "8")]
	public void IHOKANNDMHK(DPBLEIDODAC CMDMCJGFCDK, object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x88C9340", Offset = "0x88C8140", VA = "0x1888C9340", Slot = "9")]
	public void LNDOHCPGFCF(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x88C93A0", Offset = "0x88C81A0", VA = "0x1888C93A0")]
	private Vector3 MAENILMHOAK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x88C8F40", Offset = "0x88C7D40", VA = "0x1888C8F40")]
	private void FELLFFHJHIB(DPBLEIDODAC APLBNMFLNGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class NGKANHGDPEL
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x88CA8C0", Offset = "0x88C96C0", VA = "0x1888CA8C0")]
	public static POBOGCFEAIB PIHNFCNCGOJ(this DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class BENDJAENPHK : NGDMPKGJFKA, BOCBKPGFKAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly KFIFCKKAFNJ BNHFIJBCOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 PPFGELDDKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 IIMONNAPLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float LHKAFEIBHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float IAGOBGHHDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 MEKIJFHCBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? PPKCHBCCHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? EOMJHFCHJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool NKHGNABBMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool MIAGNOGECLH;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 AKLIPNIGHGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1819AB0", Offset = "0x18188B0", VA = "0x181819AB0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x88B7E00", Offset = "0x88B6C00", VA = "0x1888B7E00", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 GLMFMPGHMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x88B6200", Offset = "0x88B5000", VA = "0x1888B6200", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float ELNFAFPIPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xE0E800", Offset = "0xE0D600", VA = "0x180E0E800", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x88B60F0", Offset = "0x88B4EF0", VA = "0x1888B60F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float IALPHLPGMLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xD06540", Offset = "0xD05340", VA = "0x180D06540", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x88B5CB0", Offset = "0x88B4AB0", VA = "0x1888B5CB0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 LMMHGMMJPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x88B5F60", Offset = "0x88B4D60", VA = "0x1888B5F60", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion JFMGCINFADD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x88B58F0", Offset = "0x88B46F0", VA = "0x1888B58F0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody OPIDLFEPEBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x88B7FA0", Offset = "0x88B6DA0", VA = "0x1888B7FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event NCFBIGMDCOK DMCIOKHHNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x88B5A70", Offset = "0x88B4870", VA = "0x1888B5A70", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x88B5850", Offset = "0x88B4650", VA = "0x1888B5850", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x88B7FF0", Offset = "0x88B6DF0", VA = "0x1888B7FF0")]
	public BENDJAENPHK(DPBLEIDODAC BNHFIJBCOJI, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x88B5E40", Offset = "0x88B4C40", VA = "0x1888B5E40", Slot = "17")]
	public void DFCHELDJHDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x88B7910", Offset = "0x88B6710", VA = "0x1888B7910", Slot = "16")]
	public void LOAAIBACFCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x88B5D60", Offset = "0x88B4B60", VA = "0x1888B5D60", Slot = "19")]
	public void CIIHBMLFPGN(Rigidbody GEEACKEHDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x88B79F0", Offset = "0x88B67F0", VA = "0x1888B79F0", Slot = "20")]
	public void LOKINGOJELK(Rigidbody GEEACKEHDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x88B5B10", Offset = "0x88B4910", VA = "0x1888B5B10", Slot = "18")]
	public void AILODFEAFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x88B7490", Offset = "0x88B6290", VA = "0x1888B7490", Slot = "21")]
	public void LEEMBAJDKPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x88B7E00", Offset = "0x88B6C00", VA = "0x1888B7E00")]
	private void PFMAAMPGAKI(Vector3 BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x88B7EB0", Offset = "0x88B6CB0", VA = "0x1888B7EB0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 OAKCIHOEPIB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x88B60F0", Offset = "0x88B4EF0", VA = "0x1888B60F0")]
	private void KIICIOOKNFE(float BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x88B5CB0", Offset = "0x88B4AB0", VA = "0x1888B5CB0")]
	private void NLPAAADIEMB(float BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x88B62F0", Offset = "0x88B50F0", VA = "0x1888B62F0")]
	private Vector3 IDNHJPONPEF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x88B7BD0", Offset = "0x88B69D0", VA = "0x1888B7BD0", Slot = "15")]
	public void MJFGNCJKDGI((Quaternion rot, Vector3 moments) KOAILPGHGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x88B6490", Offset = "0x88B5290", VA = "0x1888B6490")]
	private Quaternion KBMALACLKPH()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x88B73C0", Offset = "0x88B61C0", VA = "0x1888B73C0")]
	public void LDHJLCKPNPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x88B6610", Offset = "0x88B5410", VA = "0x1888B6610", Slot = "4")]
	public (float, Vector3) LDHJLCKPNPF(Rigidbody LBNBCMKGFNF)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class BHCIDBMEAJJ
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x88B8150", Offset = "0x88B6F50", VA = "0x1888B8150")]
	public static NGDMPKGJFKA BFBKJKOKCOI(this DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class NKGMPADGKBB : LDDCNFEFPPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly KFIFCKKAFNJ BNHFIJBCOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly JDCOMPLHBHF EHEDLLAPGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly CLOJPGAOOMI CJGCNOHEHKE;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool LDIMJFLJFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x19F44A0", Offset = "0x19F32A0", VA = "0x1819F44A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public CLOJPGAOOMI KIOHFGMLJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xAAEA50", Offset = "0xAAD850", VA = "0x180AAEA50", Slot = "11")]
		get
		{
			return default(CLOJPGAOOMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x88CAFB0", Offset = "0x88C9DB0", VA = "0x1888CAFB0")]
	public NKGMPADGKBB(DPBLEIDODAC BNHFIJBCOJI, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x88CAEE0", Offset = "0x88C9CE0", VA = "0x1888CAEE0", Slot = "4")]
	public void NBAJAKOOJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x88CABA0", Offset = "0x88C99A0", VA = "0x1888CABA0")]
	private bool HPMABLBDPKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x88CA9B0", Offset = "0x88C97B0", VA = "0x1888CA9B0", Slot = "5")]
	public void CGIJFCJBDDI(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x88CA980", Offset = "0x88C9780", VA = "0x1888CA980", Slot = "6")]
	public void AGPODNGCHPJ(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x88CAC40", Offset = "0x88C9A40", VA = "0x1888CAC40", Slot = "9")]
	public void IKBGFMPCCNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x88CADC0", Offset = "0x88C9BC0", VA = "0x1888CADC0")]
	private void LCCJKDCCMEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x88CAA20", Offset = "0x88C9820", VA = "0x1888CAA20")]
	private void EJAMNFFIFGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x88CAD80", Offset = "0x88C9B80", VA = "0x1888CAD80", Slot = "8")]
	public void IOFLDLFIIIL(DPBLEIDODAC BNHFIJBCOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x88CA9E0", Offset = "0x88C97E0", VA = "0x1888CA9E0", Slot = "7")]
	public void DIAMDBMNODL(DPBLEIDODAC BNHFIJBCOJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class PMFHCFOMHFE : KDBENFNMCPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly KFIFCKKAFNJ BNHFIJBCOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly JDCOMPLHBHF NAGECIKMLNB;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool NHFGNMMGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x88CC0C0", Offset = "0x88CAEC0", VA = "0x1888CC0C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event NCFBIGMDCOK DAJHEHJOCME
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x88CBE90", Offset = "0x88CAC90", VA = "0x1888CBE90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x88CC170", Offset = "0x88CAF70", VA = "0x1888CC170", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x88CC2A0", Offset = "0x88CB0A0", VA = "0x1888CC2A0")]
	public PMFHCFOMHFE(DPBLEIDODAC BNHFIJBCOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x88CC210", Offset = "0x88CB010", VA = "0x1888CC210", Slot = "7")]
	public void JJKBGICHEAL(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x88CC220", Offset = "0x88CB020", VA = "0x1888CC220", Slot = "8")]
	public void KOMKILCDHBE(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x88CBFB0", Offset = "0x88CADB0", VA = "0x1888CBFB0", Slot = "9")]
	public void CKHEDNCAHPO(object OCGDLEBGIMO, bool FGMALLCGIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x88CC260", Offset = "0x88CB060", VA = "0x1888CC260", Slot = "12")]
	public void PKPLJNIKJME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x88CBF30", Offset = "0x88CAD30", VA = "0x1888CBF30", Slot = "10")]
	public void CIIHBMLFPGN(Rigidbody GFGAJJMHNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x88CC230", Offset = "0x88CB030", VA = "0x1888CC230", Slot = "11")]
	public void LOKINGOJELK(Rigidbody GEEACKEHDDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class NFIGMIGJBDB : BIHPNPELPHF, ONKKKKFGNHD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly KFIFCKKAFNJ BNHFIJBCOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private RRNetworkView JPJFDCGGAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool OODFHFJKBOI;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public RRNetworkView IBOMAJMCOMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool OLOGEBJDKLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x88CA400", Offset = "0x88C9200", VA = "0x1888CA400", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool JFHEADJNHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xABC810", Offset = "0xABB610", VA = "0x180ABC810", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event NCFBIGMDCOK FFAOAODBIJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x88C9B70", Offset = "0x88C8970", VA = "0x1888C9B70", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x88CA410", Offset = "0x88C9210", VA = "0x1888CA410", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x88CA4B0", Offset = "0x88C92B0", VA = "0x1888CA4B0")]
	public NFIGMIGJBDB(DPBLEIDODAC BNHFIJBCOJI, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x88CA160", Offset = "0x88C8F60", VA = "0x1888CA160", Slot = "9")]
	public void NBAJAKOOJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x88C9A70", Offset = "0x88C8870", VA = "0x1888C9A70", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x88C9D80", Offset = "0x88C8B80", VA = "0x1888C9D80", Slot = "10")]
	public void IEPHGPJPMHA(DPBLEIDODAC CMDMCJGFCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x88C9C10", Offset = "0x88C8A10", VA = "0x1888C9C10", Slot = "11")]
	public void HOJJOEEIDGD(DPBLEIDODAC CMDMCJGFCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x88CA290", Offset = "0x88C9090", VA = "0x1888CA290")]
	private void NHCKFADBHCE(RRNetworkView MHCHMOMCKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x88C9920", Offset = "0x88C8720", VA = "0x1888C9920")]
	private void BIDEFHMELJF(OPDBNCCBFHO JPEDPLPKOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x88C9EF0", Offset = "0x88C8CF0", VA = "0x1888C9EF0")]
	private void KOMKODJHNIN(RRNetworkView AOALCNMDDHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class CDNLEHEBGJD
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x88B8210", Offset = "0x88B7010", VA = "0x1888B8210")]
	public static BIHPNPELPHF GDKLMBJEOJM(this DPBLEIDODAC HJPGLGOFFHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class HAEOLGLOMOM : HLMGMHALCNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly KFIFCKKAFNJ BNHFIJBCOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints PNCGHFMOGAI;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool CAIMGNIAKBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xB0D250", Offset = "0xB0C050", VA = "0x180B0D250", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xE42BA0", Offset = "0xE419A0", VA = "0x180E42BA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool BGEFJGMEEJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xB0CBB0", Offset = "0xB0B9B0", VA = "0x180B0CBB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xE42DD0", Offset = "0xE41BD0", VA = "0x180E42DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints HBAOEIKODDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xA5E620", Offset = "0xA5D420", VA = "0x180A5E620", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x88BA3C0", Offset = "0x88B91C0", VA = "0x1888BA3C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x88BA550", Offset = "0x88B9350", VA = "0x1888BA550")]
	public HAEOLGLOMOM(DPBLEIDODAC BNHFIJBCOJI, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x88BA4F0", Offset = "0x88B92F0", VA = "0x1888BA4F0", Slot = "9")]
	public void CIIHBMLFPGN(Rigidbody GEEACKEHDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x88BA520", Offset = "0x88B9320", VA = "0x1888BA520", Slot = "10")]
	public void LOKINGOJELK(Rigidbody GEEACKEHDDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class HNGPCKHGIEG : PHNHCJAADGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly DPBLEIDODAC BNHFIJBCOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float IKBPJPOMDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float AFJPJKDLJMG;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float BBJBPNLBEDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xAB2D70", Offset = "0xAB1B70", VA = "0x180AB2D70", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x88BA7B0", Offset = "0x88B95B0", VA = "0x1888BA7B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float LOPDJJCJILO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xAB30B0", Offset = "0xAB1EB0", VA = "0x180AB30B0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x88BA640", Offset = "0x88B9440", VA = "0x1888BA640", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x88BA880", Offset = "0x88B9680", VA = "0x1888BA880")]
	public HNGPCKHGIEG(DPBLEIDODAC BNHFIJBCOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x88BA5F0", Offset = "0x88B93F0", VA = "0x1888BA5F0", Slot = "8")]
	public void CIIHBMLFPGN(Rigidbody GEEACKEHDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x88BA710", Offset = "0x88B9510", VA = "0x1888BA710", Slot = "9")]
	public void LOKINGOJELK(Rigidbody GEEACKEHDDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class MBAFFDFNMKE : NPGNHCMCFGK
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly PHLHEDGDBJO PDJNHNIIGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly KFIFCKKAFNJ BNHFIJBCOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool PHKGLNKAMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool HHKPJFBIGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int COBLIMDGLGG;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody OPIDLFEPEBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x88B7FA0", Offset = "0x88B6DA0", VA = "0x1888B7FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool JAJIBNJEDLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x88C8510", Offset = "0x88C7310", VA = "0x1888C8510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private DPBLEIDODAC BOOKBNFDCLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x88C8940", Offset = "0x88C7740", VA = "0x1888C8940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool HOLBLDFKNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x88C7E80", Offset = "0x88C6C80", VA = "0x1888C7E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event NCFBIGMDCOK BMCAJPHDEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x88C8330", Offset = "0x88C7130", VA = "0x1888C8330", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x88C89A0", Offset = "0x88C77A0", VA = "0x1888C89A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x88C8AD0", Offset = "0x88C78D0", VA = "0x1888C8AD0")]
	public MBAFFDFNMKE(DPBLEIDODAC BNHFIJBCOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x88C8470", Offset = "0x88C7270", VA = "0x1888C8470", Slot = "6")]
	public void NBAJAKOOJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x88C8500", Offset = "0x88C7300", VA = "0x1888C8500", Slot = "8")]
	public void NEDBAJKJMPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x88C81E0", Offset = "0x88C6FE0", VA = "0x1888C81E0", Slot = "7")]
	public bool DIACFMMGCLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x88C83D0", Offset = "0x88C71D0", VA = "0x1888C83D0", Slot = "9")]
	public void LOAANMKDKIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x88C8010", Offset = "0x88C6E10", VA = "0x1888C8010", Slot = "13")]
	public void CMKADIODPEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x88C80B0", Offset = "0x88C6EB0", VA = "0x1888C80B0", Slot = "12")]
	public void DHGDIIPNFLG(bool ONAGHIEMLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x88C7FA0", Offset = "0x88C6DA0", VA = "0x1888C7FA0", Slot = "10")]
	public bool CIGPNEAEJAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x88C7EE0", Offset = "0x88C6CE0", VA = "0x1888C7EE0", Slot = "11")]
	public bool AHLCOGNMOBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x88C8530", Offset = "0x88C7330", VA = "0x1888C8530")]
	private bool NFNMBGBMBKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x88C87B0", Offset = "0x88C75B0", VA = "0x1888C87B0")]
	private void OEEKGDPBKPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class EBCHPBKCBIN : HKEPGHJDNLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly KFIFCKKAFNJ BNHFIJBCOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly JDCOMPLHBHF PGADJDGDFHP;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody OPIDLFEPEBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xA595B0", Offset = "0xA583B0", VA = "0x180A595B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool HOLBLDFKNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x88B8370", Offset = "0x88B7170", VA = "0x1888B8370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool MOEGBGBBMAA
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x19F44A0", Offset = "0x19F32A0", VA = "0x1819F44A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x88B8B70", Offset = "0x88B7970", VA = "0x1888B8B70")]
	public EBCHPBKCBIN(DPBLEIDODAC BNHFIJBCOJI, [In] IDNEBGPAEGO BOIPFNOKGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x88B8920", Offset = "0x88B7720", VA = "0x1888B8920", Slot = "5")]
	public void NBAJAKOOJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x88B89C0", Offset = "0x88B77C0", VA = "0x1888B89C0", Slot = "7")]
	public void OIPNOACLCAI(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x88B83D0", Offset = "0x88B71D0", VA = "0x1888B83D0", Slot = "8")]
	public void AHKKFALKFJA(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x88B85F0", Offset = "0x88B73F0", VA = "0x1888B85F0", Slot = "9")]
	public void FJFGGPDKAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x88B8400", Offset = "0x88B7200", VA = "0x1888B8400", Slot = "10")]
	public void EJDAIGHCLDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x88B89F0", Offset = "0x88B77F0", VA = "0x1888B89F0", Slot = "11")]
	public void POOKGEAOGOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class KGJONFLEDDI : ONIOBBCBFDO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly KFIFCKKAFNJ BNHFIJBCOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly JDCOMPLHBHF IABNCAOJMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float GOMMACADPEP;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public FHIEKILDCOB GKEEJIGDEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA59830", Offset = "0xA58630", VA = "0x180A59830", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public PAAFNDDMBFD NPFBHJHKOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA59890", Offset = "0xA58690", VA = "0x180A59890", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 EPHIJFBBDFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x88C7540", Offset = "0x88C6340", VA = "0x1888C7540", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x88C60C0", Offset = "0x88C4EC0", VA = "0x1888C60C0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 PJEFBKPCBNL
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x88C73C0", Offset = "0x88C61C0", VA = "0x1888C73C0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x88C54E0", Offset = "0x88C42E0", VA = "0x1888C54E0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 EPJELJJHJHO
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x88C6320", Offset = "0x88C5120", VA = "0x1888C6320", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x88C6260", Offset = "0x88C5060", VA = "0x1888C6260", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 PPFBKGBPFLL
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x88C47D0", Offset = "0x88C35D0", VA = "0x1888C47D0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x88C6840", Offset = "0x88C5640", VA = "0x1888C6840", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float ALOEDFDDPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xAB2D60", Offset = "0xAB1B60", VA = "0x180AB2D60", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x88C43E0", Offset = "0x88C31E0", VA = "0x1888C43E0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool LDLFJPGODMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x232DF40", Offset = "0x232CD40", VA = "0x18232DF40", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private FPHDOLLFMEK GKOJIFFDGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7E385A0", Offset = "0x7E373A0", VA = "0x187E385A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool JAJIBNJEDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x88C73A0", Offset = "0x88C61A0", VA = "0x1888C73A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x88C7C10", Offset = "0x88C6A10", VA = "0x1888C7C10")]
	public KGJONFLEDDI(DPBLEIDODAC BNHFIJBCOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x88C6730", Offset = "0x88C5530", VA = "0x1888C6730", Slot = "19")]
	public void NBAJAKOOJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x88C5260", Offset = "0x88C4060", VA = "0x1888C5260", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x88C4A10", Offset = "0x88C3810", VA = "0x1888C4A10", Slot = "28")]
	public void CIIHBMLFPGN(Rigidbody GEEACKEHDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x17D8120", Offset = "0x17D6F20", VA = "0x1817D8120", Slot = "20")]
	public void HOHKHODHAEL(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x17D9470", Offset = "0x17D8270", VA = "0x1817D9470", Slot = "30")]
	public void FNBGGFEIMHI(object OCGDLEBGIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x88C7890", Offset = "0x88C6690", VA = "0x1888C7890", Slot = "35")]
	public Vector3 PGMCIMFBFFL(Vector3 DEEDLFLENGK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x88C52C0", Offset = "0x88C40C0", VA = "0x1888C52C0", Slot = "34")]
	public Vector3 EPKGFAPFPHD(Vector3 LLAKBEKJKJD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x88C6730", Offset = "0x88C5530", VA = "0x1888C6730", Slot = "27")]
	public void LFOOCAGFFJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x88C4770", Offset = "0x88C3570", VA = "0x1888C4770", Slot = "25")]
	public void AELBOKFFMOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x88C5480", Offset = "0x88C4280", VA = "0x1888C5480", Slot = "24")]
	public void GECEDJONIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x88C64F0", Offset = "0x88C52F0", VA = "0x1888C64F0", Slot = "33")]
	public void LDBJJPBFJOG(Vector3 BLBNBDFIMNA, Vector3 BPPNHBPFKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x88C67E0", Offset = "0x88C55E0", VA = "0x1888C67E0", Slot = "32")]
	public void LLGPEKAKLEB(Vector3 ADFHMMCFFLO, Vector3 DMILHKKHJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x88C50C0", Offset = "0x88C3EC0", VA = "0x1888C50C0", Slot = "31")]
	public void DLIMHJKELMI(Vector3 BPMIEEKMOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x88C6CF0", Offset = "0x88C5AF0", VA = "0x1888C6CF0", Slot = "22")]
	public void NEHDDKABHFH(HABPAFPJJJJ KLNJBBBKJCO, Vector3 DOOFBAFADGL, float LCINEAPPHPI, float GECGBFGHNIB = 8f, float IAOKKLJMKPD = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x88C44F0", Offset = "0x88C32F0", VA = "0x1888C44F0", Slot = "21")]
	public void AECKGAOBPJD(HDKAGLOAMDF HHPOMFKHONG, Vector3 FHDIIOHIJPM, float FALGOEEDNBH = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x88C4B40", Offset = "0x88C3940", VA = "0x1888C4B40", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void DACPAKELHKF(HDKAGLOAMDF HHPOMFKHONG, Vector3 NOLDGDLLBBL, float MOJCPCKJGIA = 7f, float OEOJAMPNJLC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x1921B60", Offset = "0x1920960", VA = "0x181921B60")]
	private static void BABEEPMPOEK(Vector3 LNGDDNPHJHH, Vector3 LCJFLGICHDD, [Out] Vector3 BBLNPBNIPKD, [Out] Vector3 BGBIBLBGEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x88C6180", Offset = "0x88C4F80", VA = "0x1888C6180", Slot = "29")]
	public Vector3 IHMGJAOIHIF(Vector3 LNGDDNPHJHH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x88C7700", Offset = "0x88C6500", VA = "0x1888C7700", Slot = "26")]
	public void PCBIKLDEPOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x88C43E0", Offset = "0x88C31E0", VA = "0x1888C43E0")]
	private void ADMNFNFLKFI(float BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x88C7A70", Offset = "0x88C6870", VA = "0x1888C7A70")]
	private void PNHEBFLCDHE(Vector3 FHDIIOHIJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x88C5F40", Offset = "0x88C4D40", VA = "0x1888C5F40")]
	private Vector3 HBPPAOGBOBH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x88C5AC0", Offset = "0x88C48C0", VA = "0x1888C5AC0")]
	private void GOCLCOPFGAF(Vector3 LLAKBEKJKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x88C4F30", Offset = "0x88C3D30", VA = "0x1888C4F30")]
	private Vector3 DGFLKJKEIAO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x88C6870", Offset = "0x88C5670", VA = "0x1888C6870")]
	private void LNAFFGNLCFP(Vector3 BNECONOIKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x88C5510", Offset = "0x88C4310", VA = "0x1888C5510")]
	private void GNGPPHBLGEC(Vector3 LLAKBEKJKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x88C4960", Offset = "0x88C3760", VA = "0x1888C4960")]
	private void BMFCFCFGCIJ()
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
