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
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8924B70", Offset = "0x8923770", VA = "0x188924B70", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82BC380", Offset = "0x82BAF80", VA = "0x1882BC380", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x892CFD0", Offset = "0x892BBD0", VA = "0x18892CFD0")]
		private void GAOPLNBGOGD(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x892D2D0", Offset = "0x892BED0", VA = "0x18892D2D0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x892D330", Offset = "0x892BF30", VA = "0x18892D330")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, HAGJDPFPLEP, HKJBNPOGLFP, OFHCPBDAGAI
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly PEOHNMCPNIJ HIJECPEBMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool PMJGMDPAFEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private CEKLINLDBIH IIELAAKJGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[FBGDLCLCGKH(AFILHNGOOLF.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[FBGDLCLCGKH(AFILHNGOOLF.SelfAndParent, true, false, false)]
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
		private KEMCMOHNHFH physicsInterpolation;

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
		private Transform AMEHDMMJIGH;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal CEKLINLDBIH GJMJLNIDJBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8928F80", Offset = "0x8927B80", VA = "0x188928F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private CEKLINLDBIH DICMBNHCAIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int NECJKPCNJKH
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x892A4E0", Offset = "0x89290E0", VA = "0x18892A4E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx PMINLEFHFKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x892A840", Offset = "0x8929440", VA = "0x18892A840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx AMCBICJEEBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x892A780", Offset = "0x8929380", VA = "0x18892A780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx IEPNOLIPIDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x892B440", Offset = "0x892A040", VA = "0x18892B440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x892C940", Offset = "0x892B540", VA = "0x18892C940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool LODEDLFDNDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x85468C0", Offset = "0x85454C0", VA = "0x1885468C0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8545B10", Offset = "0x8544710", VA = "0x188545B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform LMGPODOPMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x24A2870", Offset = "0x24A1470", VA = "0x1824A2870", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform OEGICFEGPLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x24A2870", Offset = "0x24A1470", VA = "0x1824A2870", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform GLDHBONKBIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x24A2870", Offset = "0x24A1470", VA = "0x1824A2870", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public CFBMCAPEOOJ HMFLAPHOAJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x892A540", Offset = "0x8929140", VA = "0x18892A540")]
			get
			{
				return default(CFBMCAPEOOJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x892C0F0", Offset = "0x892ACF0", VA = "0x18892C0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool PJIDGBEFLKK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x892AB50", Offset = "0x8929750", VA = "0x18892AB50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool JHBJJHAFIOO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x892A660", Offset = "0x8929260", VA = "0x18892A660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public EJBNNOGLELE BMPAMCJNMMP
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x892AA90", Offset = "0x8929690", VA = "0x18892AA90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x892C2B0", Offset = "0x892AEB0", VA = "0x18892C2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public KHBKNBENECM EPBIIECPPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x892AA30", Offset = "0x8929630", VA = "0x18892AA30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x892C240", Offset = "0x892AE40", VA = "0x18892C240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool CDFAGPGKFDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x892A980", Offset = "0x8929580", VA = "0x18892A980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody PMNEJLBAAMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x892A9E0", Offset = "0x89295E0", VA = "0x18892A9E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool PPILPIAEABO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x892A6C0", Offset = "0x89292C0", VA = "0x18892A6C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x892C160", Offset = "0x892AD60", VA = "0x18892C160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool JDKOBFPNHNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8545B30", Offset = "0x8544730", VA = "0x188545B30", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float MFLJIEIOHEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x892B3E0", Offset = "0x8929FE0", VA = "0x18892B3E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float GANANGCGCCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x892B380", Offset = "0x8929F80", VA = "0x18892B380")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x892C8D0", Offset = "0x892B4D0", VA = "0x18892C8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float ILGBGMMHMGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x892ADB0", Offset = "0x89299B0", VA = "0x18892ADB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x892C550", Offset = "0x892B150", VA = "0x18892C550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float KDBGDFEJKCH
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x892ABB0", Offset = "0x89297B0", VA = "0x18892ABB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x892C320", Offset = "0x892AF20", VA = "0x18892C320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool BPNPKMOFPFO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x892B990", Offset = "0x892A590", VA = "0x18892B990")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x892CE80", Offset = "0x892BA80", VA = "0x18892CE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 BIMEFJCMLBL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x892B160", Offset = "0x8929D60", VA = "0x18892B160")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x892C6A0", Offset = "0x892B2A0", VA = "0x18892C6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 EMOOCOFACGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x892BAD0", Offset = "0x892A6D0", VA = "0x18892BAD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode GAIPLAKJBAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x892ACF0", Offset = "0x89298F0", VA = "0x18892ACF0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x892C470", Offset = "0x892B070", VA = "0x18892C470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float PFEGNGGGEMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x892A720", Offset = "0x8929320", VA = "0x18892A720")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x892C1D0", Offset = "0x892ADD0", VA = "0x18892C1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints HOGJHFPIEIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x892AD50", Offset = "0x8929950", VA = "0x18892AD50")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x892C4E0", Offset = "0x892B0E0", VA = "0x18892C4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 BIHPANEEEPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x892B500", Offset = "0x892A100", VA = "0x18892B500")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 JBHIDFMGLKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x892B500", Offset = "0x892A100", VA = "0x18892B500")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x892CC60", Offset = "0x892B860", VA = "0x18892CC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float ECOEJMIBMGD
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x892B240", Offset = "0x8929E40", VA = "0x18892B240")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x892C780", Offset = "0x892B380", VA = "0x18892C780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float AHAMEBNOBFE
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x892B930", Offset = "0x892A530", VA = "0x18892B930")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x892CE10", Offset = "0x892BA10", VA = "0x18892CE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion HNPJMJENNOP
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x892B5E0", Offset = "0x892A1E0", VA = "0x18892B5E0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x892C9E0", Offset = "0x892B5E0", VA = "0x18892C9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion MKDCJPGKILG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x892B860", Offset = "0x892A460", VA = "0x18892B860")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x892CD40", Offset = "0x892B940", VA = "0x18892CD40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 NOIPIGEDENG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x892B6B0", Offset = "0x892A2B0", VA = "0x18892B6B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x892CAB0", Offset = "0x892B6B0", VA = "0x18892CAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion FNAHCMINCHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x892B790", Offset = "0x892A390", VA = "0x18892B790")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x892CB90", Offset = "0x892B790", VA = "0x18892CB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 ANDGMPFHLOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x892B9F0", Offset = "0x892A5F0", VA = "0x18892B9F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x892CEF0", Offset = "0x892BAF0", VA = "0x18892CEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 CCLLMHLHBKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x892B2A0", Offset = "0x8929EA0", VA = "0x18892B2A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x892C7F0", Offset = "0x892B3F0", VA = "0x18892C7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 JGLAFHCCNMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x892AC10", Offset = "0x8929810", VA = "0x18892AC10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x892C390", Offset = "0x892AF90", VA = "0x18892C390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 LFGIFPMDCKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x892B080", Offset = "0x8929C80", VA = "0x18892B080")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x892C5C0", Offset = "0x892B1C0", VA = "0x18892C5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 PNNDPFLBCFP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x892AF40", Offset = "0x8929B40", VA = "0x18892AF40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion NBCHBPMFOIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x892AE70", Offset = "0x8929A70", VA = "0x18892AE70")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 NMDJGLMKFCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x892BC90", Offset = "0x892A890", VA = "0x18892BC90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 ADBNNGOIAPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x892BBB0", Offset = "0x892A7B0", VA = "0x18892BBB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool LKDPCJAPFJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x892B020", Offset = "0x8929C20", VA = "0x18892B020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool KPJILPMBBBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x892AAF0", Offset = "0x89296F0", VA = "0x18892AAF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool ICGDNMHNKII
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x892A600", Offset = "0x8929200", VA = "0x18892A600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool NAIMFOOJIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x892A5A0", Offset = "0x89291A0", VA = "0x18892A5A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool PFPHEKLBOOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x892A480", Offset = "0x8929080", VA = "0x18892A480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool CCMFCHGFOAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x892AE10", Offset = "0x8929A10", VA = "0x18892AE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool MIILNIMFKPO
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2683C80", Offset = "0x2682880", VA = "0x182683C80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event MILLMPDEFNN DAPCIMAPAGN
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x892A3A0", Offset = "0x8928FA0", VA = "0x18892A3A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x892C010", Offset = "0x892AC10", VA = "0x18892C010")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event KDFLOOJFLHN MACKADHCHOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x892A110", Offset = "0x8928D10", VA = "0x18892A110")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x892BD70", Offset = "0x892A970", VA = "0x18892BD70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event KDFLOOJFLHN PKELLEMGAGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x892A170", Offset = "0x8928D70", VA = "0x18892A170")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x892BDE0", Offset = "0x892A9E0", VA = "0x18892BDE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event KDFLOOJFLHN LKINGNCHJDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x892A2C0", Offset = "0x8928EC0", VA = "0x18892A2C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x892BF30", Offset = "0x892AB30", VA = "0x18892BF30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<AFJPHDDPDEH, AFJPHDDPDEH> GMAIEGKLGNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x892A250", Offset = "0x8928E50", VA = "0x18892A250")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x892BEC0", Offset = "0x892AAC0", VA = "0x18892BEC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event KDFLOOJFLHN AJEIMPGEBBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x892A330", Offset = "0x8928F30", VA = "0x18892A330")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x892BFA0", Offset = "0x892ABA0", VA = "0x18892BFA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event KDFLOOJFLHN LJIBEODNBDK
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x892A410", Offset = "0x8929010", VA = "0x18892A410")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x892C080", Offset = "0x892AC80", VA = "0x18892C080")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event KDFLOOJFLHN AOGCOCHNMCH
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x892A1E0", Offset = "0x8928DE0", VA = "0x18892A1E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x892BE50", Offset = "0x892AA50", VA = "0x18892BE50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7A0", Offset = "0xA5B3A0", VA = "0x180A5C7A0", Slot = "8")]
		private void DONGBOKEHKI(CEKLINLDBIH EIFNOCFPPHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8928C80", Offset = "0x8927880", VA = "0x188928C80", Slot = "9")]
		public HDIANNLONJN GetData()
		{
			return default(HDIANNLONJN);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8928940", Offset = "0x8927540", VA = "0x188928940")]
		internal void EMNMLNOFCFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8929E30", Offset = "0x8928A30", VA = "0x188929E30")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody OBCMDENLDPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x89289D0", Offset = "0x89275D0", VA = "0x1889289D0")]
		public HAGJDPFPLEP GetChild(int LCCBBMBENOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8929A90", Offset = "0x8928690", VA = "0x188929A90")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) EJBGAGMOFGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8928410", Offset = "0x8927010", VA = "0x188928410")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8929D20", Offset = "0x8928920", VA = "0x188929D20")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8928F80", Offset = "0x8927B80", VA = "0x188928F80")]
		private CEKLINLDBIH NMKMODPDGEB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x89285E0", Offset = "0x89271E0", VA = "0x1889285E0")]
		private void CBACPPGGEHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8929260", Offset = "0x8927E60", VA = "0x188929260")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x89291A0", Offset = "0x8927DA0", VA = "0x1889291A0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8928940", Offset = "0x8927540", VA = "0x188928940")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8929200", Offset = "0x8927E00", VA = "0x188929200")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x89292C0", Offset = "0x8927EC0", VA = "0x1889292C0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8927A00", Offset = "0x8926600", VA = "0x188927A00")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object DANCOEFIHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8929320", Offset = "0x8927F20", VA = "0x188929320")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object DANCOEFIHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x89288E0", Offset = "0x89274E0", VA = "0x1889288E0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8929140", Offset = "0x8927D40", VA = "0x188929140")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8929BF0", Offset = "0x89287F0", VA = "0x188929BF0")]
		public void SetParent(RigidbodyEx BKMPCFIAHIG, bool EBMHMKKDKEC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8929630", Offset = "0x8928230", VA = "0x188929630")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8928D10", Offset = "0x8927910", VA = "0x188928D10")]
		public bool IsRigidbodyAncestor(RigidbodyEx OOIAELAEDJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8928E10", Offset = "0x8927A10", VA = "0x188928E10")]
		public bool IsRigidbodyDescendant(RigidbodyEx FKPPFDCICPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8927C70", Offset = "0x8926870", VA = "0x188927C70")]
		public void AddInterpolationRestriction(object DANCOEFIHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8929390", Offset = "0x8927F90", VA = "0x188929390")]
		public void RemoveInterpolationRestriction(object DANCOEFIHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8927CE0", Offset = "0x89268E0", VA = "0x188927CE0")]
		public void AddKinematic(object DANCOEFIHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8929400", Offset = "0x8928000", VA = "0x188929400")]
		public void RemoveKinematic(object DANCOEFIHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8929B70", Offset = "0x8928770", VA = "0x188929B70")]
		public void SetKinematic(object DANCOEFIHDF, bool ECALHGIKDNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8929990", Offset = "0x8928590", VA = "0x188929990")]
		public void SetDiscontinuousPositionAndRotation(Vector3 MNKBKFBLFHE, Quaternion EOAIOFAPIOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8929890", Offset = "0x8928490", VA = "0x188929890")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 NNAMNFGCMPA, Quaternion KMDPOPFNNLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8928B70", Offset = "0x8927770", VA = "0x188928B70")]
		public Vector3 GetConstrainedVelocity(Vector3 ANDGMPFHLOF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8928A60", Offset = "0x8927660", VA = "0x188928A60")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 JGLAFHCCNMJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8927B80", Offset = "0x8926780", VA = "0x188927B80")]
		public void AddForce(Vector3 GPAPPOJDLEG, ForceMode AMEHCBIAODE = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8927A70", Offset = "0x8926670", VA = "0x188927A70")]
		public void AddForceAtPosition(Vector3 GPAPPOJDLEG, Vector3 FEMJLOIOGIK, ForceMode AMEHCBIAODE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8927EB0", Offset = "0x8926AB0", VA = "0x188927EB0")]
		public void AddTorque(Vector3 MIKOHEOLMMB, ForceMode AMEHCBIAODE = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8927D50", Offset = "0x8926950", VA = "0x188927D50")]
		public void AddRelativeTorque(Vector3 MIKOHEOLMMB, ForceMode AMEHCBIAODE = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8929F00", Offset = "0x8928B00", VA = "0x188929F00")]
		public Vector3 WorldToLocalVelocity(Vector3 ICMJMFHDHFK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8929030", Offset = "0x8927C30", VA = "0x188929030")]
		public Vector3 LocalToWorldVelocity(Vector3 CCLLMHLHBKA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8928880", Offset = "0x8927480", VA = "0x188928880")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8928820", Offset = "0x8927420", VA = "0x188928820")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x89287C0", Offset = "0x89273C0", VA = "0x1889287C0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8928760", Offset = "0x8927360", VA = "0x188928760")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8929790", Offset = "0x8928390", VA = "0x188929790")]
		public void ResetVelocityWorldSpace(Vector3 EBAFNFHBEDD, Vector3 AEJLGCCIIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8929690", Offset = "0x8928290", VA = "0x188929690")]
		public void ResetVelocityLocalSpace(Vector3 PLOCPBPGBGG, Vector3 LFGIFPMDCKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8929550", Offset = "0x8928150", VA = "0x188929550")]
		public void ResetLinearVelocityLocalSpace(Vector3 PLOCPBPGBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8929D30", Offset = "0x8928930", VA = "0x188929D30")]
		public bool SweepTest(Vector3 DBIJDHDPOAF, [Out] RaycastHit JBNHJJJOKID, float FKJNFPHAHOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8928F10", Offset = "0x8927B10", VA = "0x188928F10")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8929CC0", Offset = "0x89288C0", VA = "0x188929CC0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8929EA0", Offset = "0x8928AA0", VA = "0x188929EA0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8927E40", Offset = "0x8926A40", VA = "0x188927E40")]
		public void AddShouldHaveUnityRigidbodyToken(object DANCOEFIHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8929470", Offset = "0x8928070", VA = "0x188929470")]
		public void RemoveShouldHaveUnityRigidbodyToken(object DANCOEFIHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8928240", Offset = "0x8926E40", VA = "0x188928240")]
		public void ApplyForceVelocityChange(PCHGDODKJCD IECKMLOLLAN, Vector3 LBNBIHKIOIO, float HHHBDIGBKHH, float GNKOCPBPGOP = 8f, float CDMKNLFCMMB = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8928140", Offset = "0x8926D40", VA = "0x188928140")]
		public void ApplyAngularVelocityChange(IKFAIOFMFBF ADADEDHMFPP, Vector3 OIHODILJFBC, float KPJKKEJMCJB = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8928300", Offset = "0x8926F00", VA = "0x188928300")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(IKFAIOFMFBF ADADEDHMFPP, Vector3 DINDLKHALMD, float PAGFHHDENOC = 7f, float ADHDDLNAIBP = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8928070", Offset = "0x8926C70", VA = "0x188928070")]
		public bool AllowedScaleChange(float MPBOAKIOADM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8927FA0", Offset = "0x8926BA0", VA = "0x188927FA0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx NBDKHHCCEKD, object DANCOEFIHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x89294E0", Offset = "0x89280E0", VA = "0x1889294E0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object DANCOEFIHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8928F70", Offset = "0x8927B70", VA = "0x188928F70", Slot = "13")]
		private void JILDLECPCCO(HBNCMEMJHAL PBHLPKLGFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x892A0A0", Offset = "0x8928CA0", VA = "0x18892A0A0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAFB320", Offset = "0xAF9F20", VA = "0x180AFB320", Slot = "4")]
		private GameObject MJDMICMGGGI()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA89010", Offset = "0xA87C10", VA = "0x180A89010", Slot = "10")]
		private bool JHHMLKIFGCE()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class HMGGPJODKCH
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x891D240", Offset = "0x891BE40", VA = "0x18891D240")]
	public static CEKLINLDBIH GJMJLNIDJBI(this RigidbodyEx HOAOIBONAAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(OAHGPOMAOEF), new string[] { })]
public class FAPHKPDEPGA : OAHGPOMAOEF, PNNOEJFPBEL
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private NGMDHBGLODF FFBAIGJFNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private LJMONBJLPFE EABIJIFEHML;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NGMDHBGLODF CGPJPJAKIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public LJMONBJLPFE FFHEHGDIIHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8912D00", Offset = "0x8911900", VA = "0x188912D00", Slot = "7")]
	public void InitReferences(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8912D70", Offset = "0x8911970", VA = "0x188912D70", Slot = "6")]
	public CEKLINLDBIH LBDPLDPBLMM(RigidbodyEx HOAOIBONAAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public FAPHKPDEPGA()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static LKKDMOCNJPN UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int OIGIOFFHCNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int NBAODOMGPEF;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8927860", Offset = "0x8926460", VA = "0x188927860")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x89278A0", Offset = "0x89264A0", VA = "0x1889278A0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8927880", Offset = "0x8926480", VA = "0x188927880")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string HLMEMBFCHLD, [Optional] UnityEngine.Object PBHLPKLGFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string HLMEMBFCHLD, [Optional] UnityEngine.Object PBHLPKLGFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x89279B0", Offset = "0x89265B0", VA = "0x1889279B0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KNDCNPKOIOD
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class BCICLAOBCGN : EJBNNOGLELE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA6CA00", Offset = "0xA6B600", VA = "0x180A6CA00", Slot = "4")]
		public Vector3 KPKHHAHAGPG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA6CA00", Offset = "0xA6B600", VA = "0x180A6CA00", Slot = "5")]
		public Vector3 NKPDMLGDLLJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "6")]
		public bool EGKKLCIOMLK(float EIMCADGNNHE, float IOMHEFDJGGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public BCICLAOBCGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static EJBNNOGLELE LCDIPDMPBEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x89247D0", Offset = "0x89233D0", VA = "0x1889247D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface APCHDDCIFBI
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode KAABIOCDHDF
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
	void ONFOCPIMDHM();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CAOKPMFIHHJ(bool LKDPCJAPFJF);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FCLJBMDLPGN(bool LKDPCJAPFJF);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ANAMKNBANEP(Rigidbody DOFJCHNPJLB);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LEKOBKOCPOJ(Vector3 DBIJDHDPOAF, [Out] RaycastHit JBNHJJJOKID, float FKJNFPHAHOE);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IBOHJGDPPNF : IDisposable, FPMLDBOMIMK
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CFBMCAPEOOJ HMFLAPHOAJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<AFJPHDDPDEH, AFJPHDDPDEH> GMAIEGKLGNB;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ONFOCPIMDHM();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface LJMONBJLPFE
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JOLOHABLFBJ GONBHMBNBCN(CEKLINLDBIH EIFNOCFPPHB);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EJBPLOLBJGC DPOCFNCNCHE(CEKLINLDBIH EIFNOCFPPHB);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PPDJKLMBOIN FBNBBMHHPHI(CEKLINLDBIH EIFNOCFPPHB);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PIKFGBDJPFB HKDCAJILFMC(CEKLINLDBIH EIFNOCFPPHB);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AGPAOKBNBKA JJPJFFOAFED(CEKLINLDBIH EIFNOCFPPHB);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IBOHJGDPPNF AHFKHKJFODA(CEKLINLDBIH EIFNOCFPPHB);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CIJLOGENBCE MMKLLBJBHHA(CEKLINLDBIH EIFNOCFPPHB);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FGCLMHBNCKE JKCNNKOHFMP(CEKLINLDBIH EIFNOCFPPHB);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	APCHDDCIFBI PEFCLNIHEJB(CEKLINLDBIH EIFNOCFPPHB);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EANBDNNMBIE IDJACLOHFBO(CEKLINLDBIH EIFNOCFPPHB);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LNJHOJNIHDF ELBAEEJAAML(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IJAPONALCNM BEOLBNNAKBA(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CCELJKECGMA MIBPBHGFPBI(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ADIOPMIHGBD DPMILDNCBMI(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	PBBEPGAHIME MKAAGLOKGJG(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CEKLINLDBIH LBDPLDPBLMM(RigidbodyEx HOAOIBONAAE, HDIANNLONJN CBCNBAPLLJM, OAHGPOMAOEF GHKGDJLGKOB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FGCLMHBNCKE
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAEKOHELFJN(Vector3 GPAPPOJDLEG, ForceMode AMEHCBIAODE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFEAIHHIIJM(Vector3 GPAPPOJDLEG, Vector3 FEMJLOIOGIK, ForceMode AMEHCBIAODE);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BDGNECNFKAL(Vector3 MIKOHEOLMMB, ForceMode AMEHCBIAODE = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PEODOFOLCED(Vector3 MIKOHEOLMMB, ForceMode AMEHCBIAODE = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EANBDNNMBIE
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool EENJDGCHOGB
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
	void ANAMKNBANEP(Rigidbody DOFJCHNPJLB);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LKEAKBMEADH(Rigidbody DOFJCHNPJLB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JOLOHABLFBJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<CEKLINLDBIH> KIFPPFGMJJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	CEKLINLDBIH AMCBICJEEBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	CEKLINLDBIH CCBOMPENMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event KDFLOOJFLHN MACKADHCHOH;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event KDFLOOJFLHN PKELLEMGAGL;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event MILLMPDEFNN CNNKFACOEDF;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action BAKEFMCLGKD;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action GBFLMLADHGL;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<CEKLINLDBIH> KPHBJEIBCJN;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<CEKLINLDBIH> AEDCCKNOOCA;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action BOMJMGNIAMO;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<CEKLINLDBIH> DHCLJCACCOP;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PLPIOCHBPFK(CEKLINLDBIH AHLLNEDBFNM, bool EBMHMKKDKEC = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PPDJKLMBOIN
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 FABOEKFBBOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 AICFMLECCOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OLKLCNBNPBI(CEKLINLDBIH IEPNOLIPIDE, object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BOFCGGDPFLE(object DANCOEFIHDF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ADIOPMIHGBD
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 GCNKCLAILKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 ICBPPCKNBEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float KCNLEBIFBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float LDBMPJOKFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 MBMECPLEMMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion NNJPNMKDKJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event KDFLOOJFLHN KHAPDBBIHLK;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GJMBNHOMFAE((Quaternion rot, Vector3 moments) EJBGAGMOFGM);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KFPIDAKOPLJ();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PBCPOACMOCA();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MLFMMCGKDJF();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ANAMKNBANEP(Rigidbody DOFJCHNPJLB);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LKEAKBMEADH(Rigidbody DOFJCHNPJLB);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KDLPNIDDPNH();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CCELJKECGMA
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONFOCPIMDHM();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HCLJHNJBKHH(object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PPNHOKCIBDC(object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BPLNEFKDIPP(CEKLINLDBIH HOAOIBONAAE);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJELIOPBAIM(CEKLINLDBIH HOAOIBONAAE);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BKGKKFJJCOE();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CIJLOGENBCE
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool ANMAKICIKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event KDFLOOJFLHN FPONHHIEHIG;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JDODPBODCKL(object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FGDECALMIGB(object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KPGOPEHNJMM(object DANCOEFIHDF, bool ECALHGIKDNF);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ANAMKNBANEP(Rigidbody NHJGDBOOFHP);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LKEAKBMEADH(Rigidbody DOFJCHNPJLB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface IJAPONALCNM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool PJIDGBEFLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool JHBJJHAFIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event KDFLOOJFLHN KBHEDGMHFHA;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ONFOCPIMDHM();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HIDPHGNOAAI(CEKLINLDBIH IEPNOLIPIDE);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KAFALBIEPHC(CEKLINLDBIH IEPNOLIPIDE);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PBBEPGAHIME
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool PPILPIAEABO
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool LPMIDFNBKCP
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints BEJNLFNPDJF
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
	void ANAMKNBANEP(Rigidbody DOFJCHNPJLB);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LKEAKBMEADH(Rigidbody DOFJCHNPJLB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PIKFGBDJPFB
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float CELIGADKLDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float PGCNBHPEPLD
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
	void ANAMKNBANEP(Rigidbody DOFJCHNPJLB);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LKEAKBMEADH(Rigidbody DOFJCHNPJLB);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface AGPAOKBNBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool MLDNNCFECHD;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event KDFLOOJFLHN JKNHPKPBNPA;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ONFOCPIMDHM();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DHPGIJPNDIH();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OLAMEOEEKGB();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NLEACNAAILG();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OOACKKFFEHA();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool GJFEPBNPPHO();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DLKLFODEKBO(bool JJALHFAPCGF);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OMFOFKNHABI();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LNJHOJNIHDF
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody PMNEJLBAAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool KPBENLFLPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ONFOCPIMDHM();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PMBPNBLIEBN(object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FGJJNLGGGMM(object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GMCGOCMFMJK();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface EJBPLOLBJGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	EJBNNOGLELE BMPAMCJNMMP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	KHBKNBENECM EPBIIECPPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 HGMBOAAPBMO
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 AMDMGIFFLMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 GHBMHGJDHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 NFFPEAGEGMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float PFEGNGGGEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool CDFAGPGKFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ONFOCPIMDHM();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KPCJLKIKOHB(object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OJPAEDLNLIM(IKFAIOFMFBF ADADEDHMFPP, Vector3 OIHODILJFBC, float KPJKKEJMCJB = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JNJCJDMBOOA(PCHGDODKJCD IECKMLOLLAN, Vector3 LBNBIHKIOIO, float HHHBDIGBKHH, float GNKOCPBPGOP = 8f, float CDMKNLFCMMB = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void AJFHCOLINMN(IKFAIOFMFBF ADADEDHMFPP, Vector3 DINDLKHALMD, float PAGFHHDENOC = 7f, float ADHDDLNAIBP = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void AAFFFJAFDNH();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HNCFODKEKDL();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HLLCNPIJCKM();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MPEDPLGIDOC();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ANAMKNBANEP(Rigidbody DOFJCHNPJLB);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 NFNKMEFHGOJ(Vector3 ANDGMPFHLOF);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void BMBLBMFDEFA(object DANCOEFIHDF);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void PDLLFBAMNBN(Vector3 ELHAEEMJDEC);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void EEEIEBHMPGI(Vector3 PLOCPBPGBGG, Vector3 LFGIFPMDCKJ);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void IMPMLNLNEBI(Vector3 EBAFNFHBEDD, Vector3 AEJLGCCIIMH);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 JDIDCCAMIDB(Vector3 CCLLMHLHBKA);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 JBAHILFFAAI(Vector3 ICMJMFHDHFK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface NGMDHBGLODF
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool LFEEFHHGBFN
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NOPBEPMFGJP(string PDIIGKEPNLO);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNEMAHJIGPN(RigidbodyEx HOAOIBONAAE, Action KLIEOOEGDML);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DOKHKFPJPGF KLEGJJFAFAF(int EJLLMEFCCGP);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GPFPNNMOBMG(Vector3 EMOOCOFACGA, float COAAKCFKDFO, Color MGBNCENPLKH);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface OAHGPOMAOEF
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	NGMDHBGLODF CGPJPJAKIMH
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	LJMONBJLPFE FFHEHGDIIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CEKLINLDBIH LBDPLDPBLMM(RigidbodyEx HOAOIBONAAE);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KIFEAJLFEAL : CEKLINLDBIH, IDisposable, GLMGEEDFKHK
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool ILAMKALJBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly OAHGPOMAOEF GHKGDJLGKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal JOLOHABLFBJ EJLIMJDFHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal CCELJKECGMA EJMCFNKKGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal IJAPONALCNM CEKCALGINOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal EJBPLOLBJGC ANDGMPFHLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal PPDJKLMBOIN HMNKPOLBBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal ADIOPMIHGBD OCLJKFNCPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal PIKFGBDJPFB GFMJPCKDFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal EANBDNNMBIE CIIKENJNOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal AGPAOKBNBKA OBLOLDHOBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal IBOHJGDPPNF BDPDKKCEJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal CIJLOGENBCE LINDKALIHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal FGCLMHBNCKE GPAPPOJDLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal PBBEPGAHIME EPKHMKEFNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal LNJHOJNIHDF DOFJCHNPJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal APCHDDCIFBI GPOOIACDGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable MBKDIBFDAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool PDNECCLBHJL;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public CFFDHOCCNNL IGKJKJNOIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "22")]
		get
		{
			return default(CFFDHOCCNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public HAGJDPFPLEP IBNBDEMMHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xAC0610", Offset = "0xABF210", VA = "0x180AC0610", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xB0C9D0", Offset = "0xB0B5D0", VA = "0x180B0C9D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject LKABGMIDCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA65BC0", Offset = "0xA647C0", VA = "0x180A65BC0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA65C30", Offset = "0xA64830", VA = "0x180A65C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform AJOIPBDPHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xB0CA10", Offset = "0xB0B610", VA = "0x180B0CA10", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xB0CA60", Offset = "0xB0B660", VA = "0x180B0CA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody PMNEJLBAAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x891F9F0", Offset = "0x891E5F0", VA = "0x18891F9F0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public CEKLINLDBIH CCBOMPENMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8921C10", Offset = "0x8920810", VA = "0x188921C10", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8920580", Offset = "0x891F180", VA = "0x188920580", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int NECJKPCNJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x891FBF0", Offset = "0x891E7F0", VA = "0x18891FBF0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public CEKLINLDBIH AMCBICJEEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x891DFF0", Offset = "0x891CBF0", VA = "0x18891DFF0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool CAHBCLGMMLH
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8920980", Offset = "0x891F580", VA = "0x188920980", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool PJIDGBEFLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8920870", Offset = "0x891F470", VA = "0x188920870", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool JHBJJHAFIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x89205E0", Offset = "0x891F1E0", VA = "0x1889205E0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public EJBNNOGLELE BMPAMCJNMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8923260", Offset = "0x8921E60", VA = "0x188923260", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8921110", Offset = "0x891FD10", VA = "0x188921110", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public KHBKNBENECM EPBIIECPPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8923C90", Offset = "0x8922890", VA = "0x188923C90", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8920370", Offset = "0x891EF70", VA = "0x188920370", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float PFEGNGGGEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8920D80", Offset = "0x891F980", VA = "0x188920D80", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8921050", Offset = "0x891FC50", VA = "0x188921050", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 AMDMGIFFLMH
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8923430", Offset = "0x8922030", VA = "0x188923430", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8920DD0", Offset = "0x891F9D0", VA = "0x188920DD0", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 NFFPEAGEGMB
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8920190", Offset = "0x891ED90", VA = "0x188920190", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x891FB10", Offset = "0x891E710", VA = "0x18891FB10", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 HGMBOAAPBMO
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x891F910", Offset = "0x891E510", VA = "0x18891F910", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8920A90", Offset = "0x891F690", VA = "0x188920A90", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 GHBMHGJDHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8921A50", Offset = "0x8920650", VA = "0x188921A50", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8923130", Offset = "0x8921D30", VA = "0x188923130", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool ICGDNMHNKII
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8920820", Offset = "0x891F420", VA = "0x188920820", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool NAIMFOOJIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x891F5F0", Offset = "0x891E1F0", VA = "0x18891F5F0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool PFPHEKLBOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x891F750", Offset = "0x891E350", VA = "0x18891F750", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool CDFAGPGKFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8924580", Offset = "0x8923180", VA = "0x188924580", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 FABOEKFBBOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8921200", Offset = "0x891FE00", VA = "0x188921200", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 AICFMLECCOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x89244A0", Offset = "0x89230A0", VA = "0x1889244A0", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 GCNKCLAILKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8921CC0", Offset = "0x89208C0", VA = "0x188921CC0", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8921550", Offset = "0x8920150", VA = "0x188921550", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 ICBPPCKNBEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8923CE0", Offset = "0x89228E0", VA = "0x188923CE0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float KCNLEBIFBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8920A40", Offset = "0x891F640", VA = "0x188920A40", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float LDBMPJOKFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x89238C0", Offset = "0x89224C0", VA = "0x1889238C0", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8923860", Offset = "0x8922460", VA = "0x188923860", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 MBMECPLEMMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8921B30", Offset = "0x8920730", VA = "0x188921B30", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion NNJPNMKDKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x89232B0", Offset = "0x8921EB0", VA = "0x1889232B0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float CELIGADKLDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8922D60", Offset = "0x8921960", VA = "0x188922D60", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8921920", Offset = "0x8920520", VA = "0x188921920", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float PGCNBHPEPLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x891FEE0", Offset = "0x891EAE0", VA = "0x18891FEE0", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x89242B0", Offset = "0x8922EB0", VA = "0x1889242B0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool EENJDGCHOGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8920630", Offset = "0x891F230", VA = "0x188920630", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8923600", Offset = "0x8922200", VA = "0x188923600", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public CFBMCAPEOOJ HMFLAPHOAJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x891F830", Offset = "0x891E430", VA = "0x18891F830", Slot = "70")]
		get
		{
			return default(CFBMCAPEOOJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x89207C0", Offset = "0x891F3C0", VA = "0x1889207C0", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool ANMAKICIKMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8923510", Offset = "0x8922110", VA = "0x188923510", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform GLDHBONKBIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xB0CA10", Offset = "0xB0B610", VA = "0x180B0CA10", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 JMDAEAGPOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8921700", Offset = "0x8920300", VA = "0x188921700", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8922860", Offset = "0x8921460", VA = "0x188922860", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float ABHHLMFPFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x891F6E0", Offset = "0x891E2E0", VA = "0x18891F6E0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x89227D0", Offset = "0x89213D0", VA = "0x1889227D0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float PNPNMBHHMJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8921E90", Offset = "0x8920A90", VA = "0x188921E90", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8922600", Offset = "0x8921200", VA = "0x188922600", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion FABGMLDCLKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8923090", Offset = "0x8921C90", VA = "0x188923090", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8922460", Offset = "0x8921060", VA = "0x188922460", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 IFBKCLIOOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8921330", Offset = "0x891FF30", VA = "0x188921330", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8923A40", Offset = "0x8922640", VA = "0x188923A40", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion MNNHAPKBCKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8920B70", Offset = "0x891F770", VA = "0x188920B70", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x891F8E0", Offset = "0x891E4E0", VA = "0x18891F8E0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints BEJNLFNPDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x891E6D0", Offset = "0x891D2D0", VA = "0x18891E6D0", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x891F590", Offset = "0x891E190", VA = "0x18891F590", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool PPILPIAEABO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x89233E0", Offset = "0x8921FE0", VA = "0x1889233E0", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8920520", Offset = "0x891F120", VA = "0x188920520", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode KAABIOCDHDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8923210", Offset = "0x8921E10", VA = "0x188923210", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8920680", Offset = "0x891F280", VA = "0x188920680", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool JJIDLIPJIFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x891E590", Offset = "0x891D190", VA = "0x18891E590", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool KPJILPMBBBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8922F10", Offset = "0x8921B10", VA = "0x188922F10", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event KDFLOOJFLHN MACKADHCHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x89212D0", Offset = "0x891FED0", VA = "0x1889212D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8922DB0", Offset = "0x89219B0", VA = "0x188922DB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event KDFLOOJFLHN PKELLEMGAGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x891F880", Offset = "0x891E480", VA = "0x18891F880", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x891F6F0", Offset = "0x891E2F0", VA = "0x18891F6F0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event MILLMPDEFNN CNNKFACOEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8922160", Offset = "0x8920D60", VA = "0x188922160", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x891E0A0", Offset = "0x891CCA0", VA = "0x18891E0A0", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event KDFLOOJFLHN KBHEDGMHFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8921C60", Offset = "0x8920860", VA = "0x188921C60", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8920D20", Offset = "0x891F920", VA = "0x188920D20", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event KDFLOOJFLHN LKINGNCHJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x891FF30", Offset = "0x891EB30", VA = "0x18891FF30", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8923C30", Offset = "0x8922830", VA = "0x188923C30", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event KDFLOOJFLHN JKNHPKPBNPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x89219F0", Offset = "0x89205F0", VA = "0x1889219F0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8922320", Offset = "0x8920F20", VA = "0x188922320", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<AFJPHDDPDEH, AFJPHDDPDEH> GMAIEGKLGNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8923380", Offset = "0x8921F80", VA = "0x188923380", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x89210B0", Offset = "0x891FCB0", VA = "0x1889210B0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event KDFLOOJFLHN FPONHHIEHIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8922380", Offset = "0x8920F80", VA = "0x188922380", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x891E040", Offset = "0x891CC40", VA = "0x18891E040", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event KDFLOOJFLHN AOGCOCHNMCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8924310", Offset = "0x8922F10", VA = "0x188924310", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8921FA0", Offset = "0x8920BA0", VA = "0x188921FA0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x89246E0", Offset = "0x89232E0", VA = "0x1889246E0")]
	public KIFEAJLFEAL(GameObject HLOIBGDKPID, RigidbodyEx CCGNIJAGHIO, OAHGPOMAOEF GHKGDJLGKOB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x891EA80", Offset = "0x891D680", VA = "0x18891EA80", Slot = "139")]
	protected virtual void BEHNLCODJLG(OAHGPOMAOEF GHKGDJLGKOB, HDIANNLONJN CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8920270", Offset = "0x891EE70", VA = "0x188920270", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8924040", Offset = "0x8922C40", VA = "0x188924040", Slot = "93")]
	public void ONFOCPIMDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x891F650", Offset = "0x891E250", VA = "0x18891F650", Slot = "94")]
	public void BONJIOFKLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x89236B0", Offset = "0x89222B0", VA = "0x1889236B0", Slot = "95")]
	public void NFEBDHLMMEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x891FA40", Offset = "0x891E640", VA = "0x18891FA40", Slot = "96")]
	public void DCPLJGLHOAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x891FC60", Offset = "0x891E860", VA = "0x18891FC60")]
	private void DLKLFODEKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x89223E0", Offset = "0x8920FE0", VA = "0x1889223E0")]
	private void JINBMFCLDLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8920EB0", Offset = "0x891FAB0", VA = "0x188920EB0")]
	private void GJFEPBNPPHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x891ED70", Offset = "0x891D970", VA = "0x18891ED70", Slot = "30")]
	public CEKLINLDBIH BFGJLKKPLNE(int LCCBBMBENOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x89245D0", Offset = "0x89231D0", VA = "0x1889245D0", Slot = "98")]
	public void PLPIOCHBPFK(CEKLINLDBIH BKMPCFIAHIG, bool EBMHMKKDKEC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8920F10", Offset = "0x891FB10", VA = "0x188920F10", Slot = "99")]
	public void GJJNANBCHIL(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x89208C0", Offset = "0x891F4C0", VA = "0x1889208C0", Slot = "100")]
	public void FFDLEPMPADF(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8921EA0", Offset = "0x8920AA0", VA = "0x188921EA0", Slot = "101")]
	public Vector3 JBAHILFFAAI(Vector3 ICMJMFHDHFK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x89221C0", Offset = "0x8920DC0", VA = "0x1889221C0", Slot = "102")]
	public Vector3 JDIDCCAMIDB(Vector3 CCLLMHLHBKA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8923660", Offset = "0x8922260", VA = "0x188923660", Slot = "103")]
	public void MPEDPLGIDOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8921800", Offset = "0x8920400", VA = "0x188921800", Slot = "104")]
	public void HNCFODKEKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x891DFA0", Offset = "0x891CBA0", VA = "0x18891DFA0", Slot = "105")]
	public void AAFFFJAFDNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x8921DA0", Offset = "0x89209A0", VA = "0x188921DA0", Slot = "106")]
	public void IMPMLNLNEBI(Vector3 EBAFNFHBEDD, Vector3 AEJLGCCIIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8920430", Offset = "0x891F030", VA = "0x188920430", Slot = "107")]
	public void EEEIEBHMPGI(Vector3 PLOCPBPGBGG, Vector3 LFGIFPMDCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x89241D0", Offset = "0x8922DD0", VA = "0x1889241D0", Slot = "108")]
	public void PDLLFBAMNBN(Vector3 ELHAEEMJDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8922540", Offset = "0x8921140", VA = "0x188922540", Slot = "109")]
	public void JNJCJDMBOOA(PCHGDODKJCD IECKMLOLLAN, Vector3 LBNBIHKIOIO, float HHHBDIGBKHH, float GNKOCPBPGOP = 8f, float CDMKNLFCMMB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8923DC0", Offset = "0x89229C0", VA = "0x188923DC0", Slot = "110")]
	public void OJPAEDLNLIM(IKFAIOFMFBF ADADEDHMFPP, Vector3 OIHODILJFBC, float KPJKKEJMCJB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x891E480", Offset = "0x891D080", VA = "0x18891E480", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void AJFHCOLINMN(IKFAIOFMFBF ADADEDHMFPP, Vector3 DINDLKHALMD, float PAGFHHDENOC = 7f, float ADHDDLNAIBP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8923710", Offset = "0x8922310", VA = "0x188923710", Slot = "112")]
	public Vector3 NFNKMEFHGOJ(Vector3 BKMPCFIAHIG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8922AC0", Offset = "0x89216C0", VA = "0x188922AC0", Slot = "113")]
	public Vector3 KJOCHDKPJGB(Vector3 BKMPCFIAHIG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x89217B0", Offset = "0x89203B0", VA = "0x1889217B0", Slot = "114")]
	public void HLLCNPIJCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8921980", Offset = "0x8920580", VA = "0x188921980", Slot = "115")]
	public void IHILOPDDPEC(CEKLINLDBIH NBDKHHCCEKD, object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x89203D0", Offset = "0x891EFD0", VA = "0x1889203D0", Slot = "116")]
	public void EDGPOGJHMIB(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8920F70", Offset = "0x891FB70", VA = "0x188920F70", Slot = "63")]
	public void GJMBNHOMFAE((Quaternion rot, Vector3 moments) EJBGAGMOFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8924180", Offset = "0x8922D80", VA = "0x188924180", Slot = "117")]
	public void PBCPOACMOCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8922A70", Offset = "0x8921670", VA = "0x188922A70", Slot = "118")]
	public void KFPIDAKOPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x89235B0", Offset = "0x89221B0", VA = "0x1889235B0", Slot = "119")]
	public void MLFMMCGKDJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x891FAC0", Offset = "0x891E6C0", VA = "0x18891FAC0", Slot = "120")]
	public bool DHPGIJPNDIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8923810", Offset = "0x8922410", VA = "0x188923810", Slot = "97")]
	public void NLEACNAAILG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8923F20", Offset = "0x8922B20", VA = "0x188923F20", Slot = "121")]
	public void OMFOFKNHABI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x89222C0", Offset = "0x8920EC0", VA = "0x1889222C0", Slot = "122")]
	public void JDODPBODCKL(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8920920", Offset = "0x891F520", VA = "0x188920920", Slot = "123")]
	public void FGDECALMIGB(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x8922CF0", Offset = "0x89218F0", VA = "0x188922CF0", Slot = "124")]
	public void KPGOPEHNJMM(object DANCOEFIHDF, bool ECALHGIKDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x891FF90", Offset = "0x891EB90", VA = "0x18891FF90", Slot = "125")]
	public void DPDKEHJIDJD(Vector3 MNKBKFBLFHE, Quaternion EOAIOFAPIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x891E870", Offset = "0x891D470", VA = "0x18891E870", Slot = "126")]
	public void BCHHLEDJLAP(Vector3 NNAMNFGCMPA, Quaternion KMDPOPFNNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8923560", Offset = "0x8922160", VA = "0x188923560", Slot = "127")]
	public bool MKNEHCNEFEP(float MPBOAKIOADM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x891FA60", Offset = "0x891E660", VA = "0x18891FA60", Slot = "128")]
	public void DDHJKLMIPMN(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8923EC0", Offset = "0x8922AC0", VA = "0x188923EC0", Slot = "129")]
	public void OLEKAAGHADB(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8924640", Offset = "0x8923240", VA = "0x188924640", Slot = "130")]
	public void PMBPNBLIEBN(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x89209E0", Offset = "0x891F5E0", VA = "0x1889209E0", Slot = "131")]
	public void FGJJNLGGGMM(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x89206E0", Offset = "0x891F2E0", VA = "0x1889206E0", Slot = "132")]
	public void FAEKOHELFJN(Vector3 GPAPPOJDLEG, ForceMode AMEHCBIAODE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8922960", Offset = "0x8921560", VA = "0x188922960", Slot = "133")]
	public void KFEAIHHIIJM(Vector3 GPAPPOJDLEG, Vector3 FEMJLOIOGIK, ForceMode AMEHCBIAODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x891E9A0", Offset = "0x891D5A0", VA = "0x18891E9A0", Slot = "134")]
	public void BDGNECNFKAL(Vector3 MIKOHEOLMMB, ForceMode AMEHCBIAODE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x89243C0", Offset = "0x8922FC0", VA = "0x1889243C0", Slot = "135")]
	public void PEODOFOLCED(Vector3 MIKOHEOLMMB, ForceMode AMEHCBIAODE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8922E10", Offset = "0x8921A10", VA = "0x188922E10", Slot = "136")]
	public bool LEKOBKOCPOJ(Vector3 DBIJDHDPOAF, [Out] RaycastHit JBNHJJJOKID, float FKJNFPHAHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8922910", Offset = "0x8921510", VA = "0x188922910", Slot = "137")]
	public void KDLPNIDDPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x89246A0", Offset = "0x89232A0", VA = "0x1889246A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8921850", Offset = "0x8920450", VA = "0x188921850")]
	private void HPCKPKJPDIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8922050", Offset = "0x8920C50", VA = "0x188922050")]
	private void JBOGBLHBOEM(CEKLINLDBIH IEPNOLIPIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8921370", Offset = "0x891FF70", VA = "0x188921370")]
	private void HFPCJCOJNKH(CEKLINLDBIH IEPNOLIPIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8923F90", Offset = "0x8922B90", VA = "0x188923F90")]
	private void ONEKJDMEBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8922BC0", Offset = "0x89217C0", VA = "0x188922BC0")]
	private void KLDGGHBCAKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8923A80", Offset = "0x8922680", VA = "0x188923A80")]
	private void OCOGLKFIMKN(CEKLINLDBIH FBDLNDCFCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8921630", Offset = "0x8920230", VA = "0x188921630")]
	private void HIDPHGNOAAI(CEKLINLDBIH IEPNOLIPIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8922700", Offset = "0x8921300", VA = "0x188922700")]
	private void KAFALBIEPHC(CEKLINLDBIH IEPNOLIPIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x891E720", Offset = "0x891D320", VA = "0x18891E720")]
	private void BCAOPNKEJBM(HAGJDPFPLEP IEPNOLIPIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x891F150", Offset = "0x891DD50", VA = "0x18891F150", Slot = "142")]
	protected virtual void BJKCNCFLKEJ(HAGJDPFPLEP HOAOIBONAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x891EDF0", Offset = "0x891D9F0", VA = "0x18891EDF0")]
	protected void BGJOAFGEFHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x891E100", Offset = "0x891CD00", VA = "0x18891E100")]
	protected void AIDBCPNDJDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8923910", Offset = "0x8922510", VA = "0x188923910")]
	private void OBPIKMCNPNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8920BB0", Offset = "0x891F7B0", VA = "0x188920BB0")]
	private void FPHMKAAPPOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class FFAGFJNFDFA
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8915A40", Offset = "0x8914640", VA = "0x188915A40")]
	public static CEKLINLDBIH KJCLCCBMBDP(this CEKLINLDBIH HOAOIBONAAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8915B00", Offset = "0x8914700", VA = "0x188915B00")]
	public static bool LPFLALGLFKF(this CEKLINLDBIH HOAOIBONAAE, CEKLINLDBIH OOIAELAEDJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8915950", Offset = "0x8914550", VA = "0x188915950")]
	public static bool EEDIOJNMCEI(this CEKLINLDBIH HOAOIBONAAE, CEKLINLDBIH FKPPFDCICPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x89159F0", Offset = "0x89145F0", VA = "0x1889159F0")]
	public static HAGJDPFPLEP IEMEPLKEFGJ(this CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x89158E0", Offset = "0x89144E0", VA = "0x1889158E0")]
	public static KIFEAJLFEAL BIPNPDBKLME(this CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ONCGNEMLAND : LJMONBJLPFE
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8926240", Offset = "0x8924E40", VA = "0x188926240", Slot = "19")]
	public CEKLINLDBIH LBDPLDPBLMM(RigidbodyEx HOAOIBONAAE, HDIANNLONJN CBCNBAPLLJM, OAHGPOMAOEF GHKGDJLGKOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "4")]
	public JOLOHABLFBJ GONBHMBNBCN(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "5")]
	public EJBPLOLBJGC DPOCFNCNCHE(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "6")]
	public PPDJKLMBOIN FBNBBMHHPHI(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "7")]
	public PIKFGBDJPFB HKDCAJILFMC(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "8")]
	public AGPAOKBNBKA JJPJFFOAFED(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "9")]
	public IBOHJGDPPNF AHFKHKJFODA(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "10")]
	public CIJLOGENBCE MMKLLBJBHHA(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "11")]
	public FGCLMHBNCKE JKCNNKOHFMP(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "12")]
	public APCHDDCIFBI PEFCLNIHEJB(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "13")]
	public EANBDNNMBIE IDJACLOHFBO(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030")]
	public LNJHOJNIHDF ELBAEEJAAML(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030")]
	public IJAPONALCNM BEOLBNNAKBA(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030")]
	public CCELJKECGMA MIBPBHGFPBI(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030")]
	public ADIOPMIHGBD DPMILDNCBMI(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030")]
	public PBBEPGAHIME MKAAGLOKGJG(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public ONCGNEMLAND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "14")]
	private LNJHOJNIHDF AFACMIAKDMH(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "15")]
	private IJAPONALCNM LBLPBICGGIL(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "16")]
	private CCELJKECGMA BLKKDDKNNDA(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "17")]
	private ADIOPMIHGBD LACALDIJIFL(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "18")]
	private PBBEPGAHIME DEHPKJJEAIG(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(LJMONBJLPFE), new string[] { })]
public class GIKOILAMHCG : LJMONBJLPFE, PNNOEJFPBEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly LJMONBJLPFE NALMCIFFHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly LJMONBJLPFE PEIABBHLIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private DFPKEHOKJNP PHJEKGELBEN;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private LJMONBJLPFE FFHEHGDIIHE
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8917600", Offset = "0x8916200", VA = "0x188917600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8917840", Offset = "0x8916440", VA = "0x188917840", Slot = "20")]
	public void InitReferences(MDHHMAKNOBB HKAENDMEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8917660", Offset = "0x8916260", VA = "0x188917660", Slot = "4")]
	public JOLOHABLFBJ GONBHMBNBCN(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x89174C0", Offset = "0x89160C0", VA = "0x1889174C0", Slot = "5")]
	public EJBPLOLBJGC DPOCFNCNCHE(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8917560", Offset = "0x8916160", VA = "0x188917560", Slot = "6")]
	public PPDJKLMBOIN FBNBBMHHPHI(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8917700", Offset = "0x8916300", VA = "0x188917700", Slot = "7")]
	public PIKFGBDJPFB HKDCAJILFMC(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8917890", Offset = "0x8916490", VA = "0x188917890", Slot = "8")]
	public AGPAOKBNBKA JJPJFFOAFED(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8917160", Offset = "0x8915D60", VA = "0x188917160", Slot = "9")]
	public IBOHJGDPPNF AHFKHKJFODA(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8917B20", Offset = "0x8916720", VA = "0x188917B20", Slot = "10")]
	public CIJLOGENBCE MMKLLBJBHHA(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8917930", Offset = "0x8916530", VA = "0x188917930", Slot = "11")]
	public FGCLMHBNCKE JKCNNKOHFMP(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8917BC0", Offset = "0x89167C0", VA = "0x188917BC0", Slot = "12")]
	public APCHDDCIFBI PEFCLNIHEJB(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x89177A0", Offset = "0x89163A0", VA = "0x1889177A0", Slot = "13")]
	public EANBDNNMBIE IDJACLOHFBO(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x89170B0", Offset = "0x8915CB0", VA = "0x1889170B0")]
	public LNJHOJNIHDF ELBAEEJAAML(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8917200", Offset = "0x8915E00", VA = "0x188917200")]
	public IJAPONALCNM BEOLBNNAKBA(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x89172B0", Offset = "0x8915EB0", VA = "0x1889172B0")]
	public CCELJKECGMA MIBPBHGFPBI(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x8917410", Offset = "0x8916010", VA = "0x188917410")]
	public ADIOPMIHGBD DPMILDNCBMI(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8917360", Offset = "0x8915F60", VA = "0x188917360")]
	public PBBEPGAHIME MKAAGLOKGJG(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x89179D0", Offset = "0x89165D0", VA = "0x1889179D0", Slot = "19")]
	public CEKLINLDBIH LBDPLDPBLMM(RigidbodyEx HOAOIBONAAE, HDIANNLONJN CBCNBAPLLJM, OAHGPOMAOEF GHKGDJLGKOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x8917C60", Offset = "0x8916860", VA = "0x188917C60")]
	public GIKOILAMHCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x89170B0", Offset = "0x8915CB0", VA = "0x1889170B0", Slot = "14")]
	private LNJHOJNIHDF AFACMIAKDMH(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8917200", Offset = "0x8915E00", VA = "0x188917200", Slot = "15")]
	private IJAPONALCNM LBLPBICGGIL(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x89172B0", Offset = "0x8915EB0", VA = "0x1889172B0", Slot = "16")]
	private CCELJKECGMA BLKKDDKNNDA(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x8917410", Offset = "0x8916010", VA = "0x188917410", Slot = "17")]
	private ADIOPMIHGBD LACALDIJIFL(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x8917360", Offset = "0x8915F60", VA = "0x188917360", Slot = "18")]
	private PBBEPGAHIME DEHPKJJEAIG(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HINFNAGEGIL : JOLOHABLFBJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PLLMLKANMJK(CEKLINLDBIH HOAOIBONAAE);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOKPCMLCIEN(CEKLINLDBIH HOAOIBONAAE);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FPFECGLCKCC(CEKLINLDBIH FBDLNDCFCLJ);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FIMIDLLPFAC(CEKLINLDBIH FBDLNDCFCLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PKIODEEHBHI : PPDJKLMBOIN
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	EPJDJILHGKF<CEKLINLDBIH> EBJEAGLABBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	CEKLINLDBIH MIKCFBKJCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HPOFOAJCIMH : ADIOPMIHGBD
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) DMIHLFJBPHL(Rigidbody BHNIJIGBJFA);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface BBEPDMBAFFJ : IJAPONALCNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	RRNetworkView DPHMGPJCLBK
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class GBGHJGNOEEM : APCHDDCIFBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly KIFEAJLFEAL HOAOIBONAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode JNIGAJFOEKM;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody PMNEJLBAAMD
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8915E60", Offset = "0x8914A60", VA = "0x188915E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode KAABIOCDHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x89161B0", Offset = "0x8914DB0", VA = "0x1889161B0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8915EB0", Offset = "0x8914AB0", VA = "0x188915EB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x8911550", Offset = "0x8910150", VA = "0x188911550")]
	public GBGHJGNOEEM(CEKLINLDBIH HOAOIBONAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x89162C0", Offset = "0x8914EC0", VA = "0x1889162C0", Slot = "6")]
	public void ONFOCPIMDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x8915DD0", Offset = "0x89149D0", VA = "0x188915DD0", Slot = "9")]
	public void ANAMKNBANEP(Rigidbody DOFJCHNPJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x8915E50", Offset = "0x8914A50", VA = "0x188915E50", Slot = "7")]
	public void CAOKPMFIHHJ(bool LKDPCJAPFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x8915F20", Offset = "0x8914B20", VA = "0x188915F20", Slot = "8")]
	public void FCLJBMDLPGN(bool LKDPCJAPFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x8916050", Offset = "0x8914C50", VA = "0x188916050", Slot = "10")]
	public bool LEKOBKOCPOJ(Vector3 DBIJDHDPOAF, [Out] RaycastHit JBNHJJJOKID, float FKJNFPHAHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x8915F30", Offset = "0x8914B30", VA = "0x188915F30")]
	private void KCDMBJBLICL(bool LKDPCJAPFJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class AFFMOOPLMON : IBOHJGDPPNF, IDisposable, FPMLDBOMIMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly KIFEAJLFEAL HOAOIBONAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private CFBMCAPEOOJ GFDCDKHEHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private DOKHKFPJPGF JLAJCFDPBBP;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public CFBMCAPEOOJ HMFLAPHOAJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8910CE0", Offset = "0x890F8E0", VA = "0x188910CE0", Slot = "6")]
		get
		{
			return default(CFBMCAPEOOJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8910E70", Offset = "0x890FA70", VA = "0x188910E70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform JPEKANLKACP
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xDEE8B0", Offset = "0xDED4B0", VA = "0x180DEE8B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<AFJPHDDPDEH, AFJPHDDPDEH> GMAIEGKLGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8910FF0", Offset = "0x890FBF0", VA = "0x188910FF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8910F40", Offset = "0x890FB40", VA = "0x188910F40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x8911310", Offset = "0x890FF10", VA = "0x188911310")]
	public AFFMOOPLMON(CEKLINLDBIH HOAOIBONAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x89110A0", Offset = "0x890FCA0", VA = "0x1889110A0", Slot = "8")]
	public void ONFOCPIMDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x8910E20", Offset = "0x890FA20", VA = "0x188910E20", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x12E2560", Offset = "0x12E1160", VA = "0x1812E2560", Slot = "11")]
	private void FMDDBJAGGJP(AFJPHDDPDEH KJMHACFAJAA, AFJPHDDPDEH JDEINKMLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "12")]
	private void IFKGMFIAGLB(bool JOGHHJHGGAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PGPLDLKMLPE : LJMONBJLPFE
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8927170", Offset = "0x8925D70", VA = "0x188927170", Slot = "4")]
	public JOLOHABLFBJ GONBHMBNBCN(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8926F20", Offset = "0x8925B20", VA = "0x188926F20", Slot = "5")]
	public EJBPLOLBJGC DPOCFNCNCHE(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8927040", Offset = "0x8925C40", VA = "0x188927040", Slot = "6")]
	public PPDJKLMBOIN FBNBBMHHPHI(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8927260", Offset = "0x8925E60", VA = "0x188927260", Slot = "7")]
	public PIKFGBDJPFB HKDCAJILFMC(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x89273A0", Offset = "0x8925FA0", VA = "0x1889273A0", Slot = "8")]
	public AGPAOKBNBKA JJPJFFOAFED(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8926920", Offset = "0x8925520", VA = "0x188926920", Slot = "9")]
	public IBOHJGDPPNF AHFKHKJFODA(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8927680", Offset = "0x8926280", VA = "0x188927680", Slot = "10")]
	public CIJLOGENBCE MMKLLBJBHHA(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8927470", Offset = "0x8926070", VA = "0x188927470", Slot = "11")]
	public FGCLMHBNCKE JKCNNKOHFMP(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x89277A0", Offset = "0x89263A0", VA = "0x1889277A0", Slot = "12")]
	public APCHDDCIFBI PEFCLNIHEJB(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x89272E0", Offset = "0x8925EE0", VA = "0x1889272E0", Slot = "13")]
	public EANBDNNMBIE IDJACLOHFBO(CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x89267E0", Offset = "0x89253E0", VA = "0x1889267E0")]
	public LNJHOJNIHDF ELBAEEJAAML(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x89269F0", Offset = "0x89255F0", VA = "0x1889269F0")]
	public IJAPONALCNM BEOLBNNAKBA(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8926B80", Offset = "0x8925780", VA = "0x188926B80")]
	public CCELJKECGMA MIBPBHGFPBI(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8926D90", Offset = "0x8925990", VA = "0x188926D90")]
	public ADIOPMIHGBD DPMILDNCBMI(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8926CB0", Offset = "0x89258B0", VA = "0x188926CB0")]
	public PBBEPGAHIME MKAAGLOKGJG(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8927530", Offset = "0x8926130", VA = "0x188927530", Slot = "19")]
	public CEKLINLDBIH LBDPLDPBLMM(RigidbodyEx HOAOIBONAAE, HDIANNLONJN CBCNBAPLLJM, OAHGPOMAOEF GHKGDJLGKOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public PGPLDLKMLPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x89267E0", Offset = "0x89253E0", VA = "0x1889267E0", Slot = "14")]
	private LNJHOJNIHDF AFACMIAKDMH(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x89269F0", Offset = "0x89255F0", VA = "0x1889269F0", Slot = "15")]
	private IJAPONALCNM LBLPBICGGIL(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8926B80", Offset = "0x8925780", VA = "0x188926B80", Slot = "16")]
	private CCELJKECGMA BLKKDDKNNDA(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8926D90", Offset = "0x8925990", VA = "0x188926D90", Slot = "17")]
	private ADIOPMIHGBD LACALDIJIFL(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8926CB0", Offset = "0x89258B0", VA = "0x188926CB0", Slot = "18")]
	private PBBEPGAHIME DEHPKJJEAIG(CEKLINLDBIH EIFNOCFPPHB, [In] HDIANNLONJN CBCNBAPLLJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class OAODFBAGMJO : FGCLMHBNCKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly KIFEAJLFEAL HOAOIBONAAE;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody PMNEJLBAAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8915E60", Offset = "0x8914A60", VA = "0x188915E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool ANMAKICIKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8925ED0", Offset = "0x8924AD0", VA = "0x188925ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool CAHBCLGMMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x89117D0", Offset = "0x89103D0", VA = "0x1889117D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private CEKLINLDBIH CCBOMPENMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8925BF0", Offset = "0x89247F0", VA = "0x188925BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8911550", Offset = "0x8910150", VA = "0x188911550")]
	public OAODFBAGMJO(CEKLINLDBIH HOAOIBONAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8925830", Offset = "0x8924430", VA = "0x188925830", Slot = "4")]
	public void FAEKOHELFJN(Vector3 GPAPPOJDLEG, ForceMode AMEHCBIAODE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x89255D0", Offset = "0x89241D0", VA = "0x1889255D0")]
	private void DKPAHEKCCPM(Vector3 GPAPPOJDLEG, ForceMode AMEHCBIAODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x8925C50", Offset = "0x8924850", VA = "0x188925C50", Slot = "5")]
	public void KFEAIHHIIJM(Vector3 GPAPPOJDLEG, Vector3 FEMJLOIOGIK, ForceMode AMEHCBIAODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x8925470", Offset = "0x8924070", VA = "0x188925470", Slot = "6")]
	public void BDGNECNFKAL(Vector3 MIKOHEOLMMB, ForceMode AMEHCBIAODE = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8925990", Offset = "0x8924590", VA = "0x188925990")]
	private void GHEKLNFHJBF(Vector3 MIKOHEOLMMB, ForceMode AMEHCBIAODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8925F20", Offset = "0x8924B20", VA = "0x188925F20", Slot = "7")]
	public void PEODOFOLCED(Vector3 MIKOHEOLMMB, ForceMode AMEHCBIAODE = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class AIHNGCNMALL : EANBDNNMBIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly KIFEAJLFEAL HOAOIBONAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool BPNPKMOFPFO;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool EENJDGCHOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAB4C80", Offset = "0xAB3880", VA = "0x180AB4C80", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8911440", Offset = "0x8910040", VA = "0x188911440", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8911550", Offset = "0x8910150", VA = "0x188911550")]
	public AIHNGCNMALL(CEKLINLDBIH HOAOIBONAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x89113A0", Offset = "0x890FFA0", VA = "0x1889113A0", Slot = "6")]
	public void ANAMKNBANEP(Rigidbody DOFJCHNPJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x89113D0", Offset = "0x890FFD0", VA = "0x1889113D0", Slot = "7")]
	public void LKEAKBMEADH(Rigidbody DOFJCHNPJLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class HHMNFBJLMOA : HINFNAGEGIL, JOLOHABLFBJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly CEKLINLDBIH HOAOIBONAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<CEKLINLDBIH> ECMGPJBGEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private CEKLINLDBIH OLIIIAEGOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private CEKLINLDBIH IEPNOLIPIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform KFBBBGHGJLE;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform AJOIPBDPHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x891C630", Offset = "0x891B230", VA = "0x18891C630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public CEKLINLDBIH CCBOMPENMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B440", Offset = "0xA5A040", VA = "0x180A5B440", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x891B810", Offset = "0x891A410", VA = "0x18891B810", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public CEKLINLDBIH AMCBICJEEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA5B760", Offset = "0xA5A360", VA = "0x180A5B760", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<CEKLINLDBIH> KIFPPFGMJJH
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA633E0", Offset = "0xA61FE0", VA = "0x180A633E0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event KDFLOOJFLHN MACKADHCHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x891C050", Offset = "0x891AC50", VA = "0x18891C050", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x891C4F0", Offset = "0x891B0F0", VA = "0x18891C4F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event KDFLOOJFLHN PKELLEMGAGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x891B620", Offset = "0x891A220", VA = "0x18891B620", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x891B580", Offset = "0x891A180", VA = "0x18891B580", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event MILLMPDEFNN CNNKFACOEDF
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x891C240", Offset = "0x891AE40", VA = "0x18891C240", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x891B390", Offset = "0x8919F90", VA = "0x18891B390", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action BAKEFMCLGKD
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x891C590", Offset = "0x891B190", VA = "0x18891C590", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x891C7D0", Offset = "0x891B3D0", VA = "0x18891C7D0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action GBFLMLADHGL
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x891B430", Offset = "0x891A030", VA = "0x18891B430", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x891C320", Offset = "0x891AF20", VA = "0x18891C320", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<CEKLINLDBIH> KPHBJEIBCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x891C190", Offset = "0x891AD90", VA = "0x18891C190", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x891B4D0", Offset = "0x891A0D0", VA = "0x18891B4D0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<CEKLINLDBIH> AEDCCKNOOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x891C870", Offset = "0x891B470", VA = "0x18891C870", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x891C9C0", Offset = "0x891B5C0", VA = "0x18891C9C0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action BOMJMGNIAMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x891C920", Offset = "0x891B520", VA = "0x18891C920", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x891CA70", Offset = "0x891B670", VA = "0x18891CA70", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<CEKLINLDBIH> DHCLJCACCOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x891BFA0", Offset = "0x891ABA0", VA = "0x18891BFA0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x891B6C0", Offset = "0x891A2C0", VA = "0x18891B6C0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x891D180", Offset = "0x891BD80", VA = "0x18891D180")]
	public HHMNFBJLMOA(CEKLINLDBIH HOAOIBONAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x891B770", Offset = "0x891A370", VA = "0x18891B770", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x891CC00", Offset = "0x891B800", VA = "0x18891CC00", Slot = "30")]
	public void PLPIOCHBPFK(CEKLINLDBIH AHLLNEDBFNM, bool EBMHMKKDKEC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x891BC70", Offset = "0x891A870", VA = "0x18891BC70", Slot = "6")]
	public void FPFECGLCKCC(CEKLINLDBIH FBDLNDCFCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x891B9F0", Offset = "0x891A5F0", VA = "0x18891B9F0", Slot = "7")]
	public void FIMIDLLPFAC(CEKLINLDBIH FBDLNDCFCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x891CB10", Offset = "0x891B710", VA = "0x18891CB10", Slot = "4")]
	public void PLLMLKANMJK(CEKLINLDBIH HOAOIBONAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x891B820", Offset = "0x891A420", VA = "0x18891B820", Slot = "5")]
	public void EOKPCMLCIEN(CEKLINLDBIH HOAOIBONAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x891C0F0", Offset = "0x891ACF0", VA = "0x18891C0F0")]
	private void HCHJFIJKDAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x891C2E0", Offset = "0x891AEE0", VA = "0x18891C2E0")]
	private void JGGPFCPJDNH(CEKLINLDBIH FBDLNDCFCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x891C690", Offset = "0x891B290", VA = "0x18891C690")]
	private void MJDJGNPKNBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x891B8C0", Offset = "0x891A4C0", VA = "0x18891B8C0")]
	private void FECPMEGPGED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x891C3C0", Offset = "0x891AFC0", VA = "0x18891C3C0")]
	private void KCEKIGLACCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x891BEE0", Offset = "0x891AAE0", VA = "0x18891BEE0")]
	[CompilerGenerated]
	private object GAOHDACLFDM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class OIFMICKMCDM
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x8926180", Offset = "0x8924D80", VA = "0x188926180")]
	public static HINFNAGEGIL PLCEFDJJMGA(this CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class CEHMJENOICC : PKIODEEHBHI, PPDJKLMBOIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly KIFEAJLFEAL HOAOIBONAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly EPJDJILHGKF<CEKLINLDBIH> DCGKIBGNILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool ELGCBLCCBDC;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public EPJDJILHGKF<CEKLINLDBIH> EBJEAGLABBE
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 FABOEKFBBOL
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8912100", Offset = "0x8910D00", VA = "0x188912100", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 AICFMLECCOH
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8912980", Offset = "0x8911580", VA = "0x188912980", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 HGMBOAAPBMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8912010", Offset = "0x8910C10", VA = "0x188912010")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public CEKLINLDBIH MIKCFBKJCHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8912130", Offset = "0x8910D30", VA = "0x188912130", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x8912B40", Offset = "0x8911740", VA = "0x188912B40")]
	public CEHMJENOICC(CEKLINLDBIH HOAOIBONAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x8912910", Offset = "0x8911510", VA = "0x188912910", Slot = "8")]
	public void OLKLCNBNPBI(CEKLINLDBIH IEPNOLIPIDE, object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x8911FB0", Offset = "0x8910BB0", VA = "0x188911FB0", Slot = "9")]
	public void BOFCGGDPFLE(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x89121E0", Offset = "0x8910DE0", VA = "0x1889121E0")]
	private Vector3 JOJDALBPCCF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x8912580", Offset = "0x8911180", VA = "0x188912580")]
	private void MGDKOPBBMKC(CEKLINLDBIH APFHKNKMCBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class CDADHFCBMAK
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8911EF0", Offset = "0x8910AF0", VA = "0x188911EF0")]
	public static PKIODEEHBHI GDHJGGFIBJF(this CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class FCMFHCBOBHF : HPOFOAJCIMH, ADIOPMIHGBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly KIFEAJLFEAL HOAOIBONAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 HEBFOFDKFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 OGFANHGPNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float GANANGCGCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float MFLJIEIOHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 BIMEFJCMLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? PNNDPFLBCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? NBCHBPMFOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool LAOLOEEABOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool MMPCEBHJEML;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 GCNKCLAILKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x183C940", Offset = "0x183B540", VA = "0x18183C940", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8914410", Offset = "0x8913010", VA = "0x188914410", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 ICBPPCKNBEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8915480", Offset = "0x8914080", VA = "0x188915480", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float KCNLEBIFBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xE17120", Offset = "0xE15D20", VA = "0x180E17120", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8914300", Offset = "0x8912F00", VA = "0x188914300")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float LDBMPJOKFBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15F40", VA = "0x180D17340", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8914250", Offset = "0x8912E50", VA = "0x188914250", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 MBMECPLEMMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8914870", Offset = "0x8913470", VA = "0x188914870", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion NNJPNMKDKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8915150", Offset = "0x8913D50", VA = "0x188915150", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody PMNEJLBAAMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x89131F0", Offset = "0x8911DF0", VA = "0x1889131F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event KDFLOOJFLHN KHAPDBBIHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8913150", Offset = "0x8911D50", VA = "0x188913150", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x89130B0", Offset = "0x8911CB0", VA = "0x1889130B0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8915780", Offset = "0x8914380", VA = "0x188915780")]
	public FCMFHCBOBHF(CEKLINLDBIH HOAOIBONAAE, [In] HDIANNLONJN CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8915570", Offset = "0x8914170", VA = "0x188915570", Slot = "17")]
	public void PBCPOACMOCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8914E90", Offset = "0x8913A90", VA = "0x188914E90", Slot = "16")]
	public void KFPIDAKOPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8912FD0", Offset = "0x8911BD0", VA = "0x188912FD0", Slot = "19")]
	public void ANAMKNBANEP(Rigidbody DOFJCHNPJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8914F70", Offset = "0x8913B70", VA = "0x188914F70", Slot = "20")]
	public void LKEAKBMEADH(Rigidbody DOFJCHNPJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x89152D0", Offset = "0x8913ED0", VA = "0x1889152D0", Slot = "18")]
	public void MLFMMCGKDJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8914A00", Offset = "0x8913600", VA = "0x188914A00", Slot = "21")]
	public void KDLPNIDDPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8914410", Offset = "0x8913010", VA = "0x188914410")]
	private void ENOLCCOEELC(Vector3 BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8915690", Offset = "0x8914290", VA = "0x188915690")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 PMKGILKAFKE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8914300", Offset = "0x8912F00", VA = "0x188914300")]
	private void FBJIFMFPFLE(float BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8914250", Offset = "0x8912E50", VA = "0x188914250")]
	private void ECKNIOIHPNL(float BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8913240", Offset = "0x8911E40", VA = "0x188913240")]
	private Vector3 DKNBAHCHJLG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8914640", Offset = "0x8913240", VA = "0x188914640", Slot = "15")]
	public void GJMBNHOMFAE((Quaternion rot, Vector3 moments) EJBGAGMOFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x89144C0", Offset = "0x89130C0", VA = "0x1889144C0")]
	private Quaternion FHDECGNEOIM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x89133E0", Offset = "0x8911FE0", VA = "0x1889133E0")]
	public void DMIHLFJBPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x89134B0", Offset = "0x89120B0", VA = "0x1889134B0", Slot = "4")]
	public (float, Vector3) DMIHLFJBPHL(Rigidbody BHNIJIGBJFA)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class EAIDMBEGNHG
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8912C40", Offset = "0x8911840", VA = "0x188912C40")]
	public static HPOFOAJCIMH LODLHCLNHII(this CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class NLDABLJCLGC : CCELJKECGMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly KIFEAJLFEAL HOAOIBONAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly IACMJMJNBEK BBLEOFHKLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly KEMCMOHNHFH GHPLEABLMHG;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool KHMLEFGJKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1A12150", Offset = "0x1A10D50", VA = "0x181A12150", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public KEMCMOHNHFH BFKHBBHBGNA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xAB6800", Offset = "0xAB5400", VA = "0x180AB6800", Slot = "11")]
		get
		{
			return default(KEMCMOHNHFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x89252B0", Offset = "0x8923EB0", VA = "0x1889252B0")]
	public NLDABLJCLGC(CEKLINLDBIH HOAOIBONAAE, [In] HDIANNLONJN CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8925090", Offset = "0x8923C90", VA = "0x188925090", Slot = "4")]
	public void ONFOCPIMDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8924FB0", Offset = "0x8923BB0", VA = "0x188924FB0")]
	private bool JIDLPLJEHMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8924F80", Offset = "0x8923B80", VA = "0x188924F80", Slot = "5")]
	public void HCLJHNJBKHH(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8925280", Offset = "0x8923E80", VA = "0x188925280", Slot = "6")]
	public void PPNHOKCIBDC(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8924C80", Offset = "0x8923880", VA = "0x188924C80", Slot = "9")]
	public void BKGKKFJJCOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8925160", Offset = "0x8923D60", VA = "0x188925160")]
	private void PGLCHBEOGBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8924E00", Offset = "0x8923A00", VA = "0x188924E00")]
	private void EBDIADPKKHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8925050", Offset = "0x8923C50", VA = "0x188925050", Slot = "8")]
	public void OJELIOPBAIM(CEKLINLDBIH HOAOIBONAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8924DC0", Offset = "0x89239C0", VA = "0x188924DC0", Slot = "7")]
	public void BPLNEFKDIPP(CEKLINLDBIH HOAOIBONAAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class OOLHODFGAIN : CIJLOGENBCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly KIFEAJLFEAL HOAOIBONAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly IACMJMJNBEK KHALGIOIOLL;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool ANMAKICIKMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8926640", Offset = "0x8925240", VA = "0x188926640", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event KDFLOOJFLHN FPONHHIEHIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8926460", Offset = "0x8925060", VA = "0x188926460", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x89262E0", Offset = "0x8924EE0", VA = "0x1889262E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x89266F0", Offset = "0x89252F0", VA = "0x1889266F0")]
	public OOLHODFGAIN(CEKLINLDBIH HOAOIBONAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8926450", Offset = "0x8925050", VA = "0x188926450", Slot = "7")]
	public void JDODPBODCKL(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x8926400", Offset = "0x8925000", VA = "0x188926400", Slot = "8")]
	public void FGDECALMIGB(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8926500", Offset = "0x8925100", VA = "0x188926500", Slot = "9")]
	public void KPGOPEHNJMM(object DANCOEFIHDF, bool ECALHGIKDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x8926410", Offset = "0x8925010", VA = "0x188926410", Slot = "12")]
	public void IJFBHCNNLMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x8926380", Offset = "0x8924F80", VA = "0x188926380", Slot = "10")]
	public void ANAMKNBANEP(Rigidbody NHJGDBOOFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x8926610", Offset = "0x8925210", VA = "0x188926610", Slot = "11")]
	public void LKEAKBMEADH(Rigidbody DOFJCHNPJLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class GCHEFNNEHKG : BBEPDMBAFFJ, IJAPONALCNM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly KIFEAJLFEAL HOAOIBONAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private RRNetworkView IECIOIOJDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool HOIIMEIGBPJ;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public RRNetworkView DPHMGPJCLBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool PJIDGBEFLKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8916620", Offset = "0x8915220", VA = "0x188916620", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool JHBJJHAFIOO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xAC0B50", Offset = "0xABF750", VA = "0x180AC0B50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event KDFLOOJFLHN KBHEDGMHFHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8916840", Offset = "0x8915440", VA = "0x188916840", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8916630", Offset = "0x8915230", VA = "0x188916630", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8916F60", Offset = "0x8915B60", VA = "0x188916F60")]
	public GCHEFNNEHKG(CEKLINLDBIH HOAOIBONAAE, [In] HDIANNLONJN CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x8916E30", Offset = "0x8915A30", VA = "0x188916E30", Slot = "9")]
	public void ONFOCPIMDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x8916520", Offset = "0x8915120", VA = "0x188916520", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x89166D0", Offset = "0x89152D0", VA = "0x1889166D0", Slot = "10")]
	public void HIDPHGNOAAI(CEKLINLDBIH IEPNOLIPIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x89168E0", Offset = "0x89154E0", VA = "0x1889168E0", Slot = "11")]
	public void KAFALBIEPHC(CEKLINLDBIH IEPNOLIPIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x8916CC0", Offset = "0x89158C0", VA = "0x188916CC0")]
	private void OAOPLHFHOAC(RRNetworkView MPDJOHOAHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x89163D0", Offset = "0x8914FD0", VA = "0x1889163D0")]
	private void ABDMOCCFFJL(HAGJDPFPLEP MJJKCDFIJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x8916A50", Offset = "0x8915650", VA = "0x188916A50")]
	private void LPEJMBNBPBJ(RRNetworkView LGFDCNOOLEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class NLHHKJFFMHD
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x89253B0", Offset = "0x8923FB0", VA = "0x1889253B0")]
	public static BBEPDMBAFFJ NBGGDPCAGBB(this CEKLINLDBIH EIFNOCFPPHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class FPHBOIKCLCB : PBBEPGAHIME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly KIFEAJLFEAL HOAOIBONAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints HOGJHFPIEIG;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool PPILPIAEABO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xB04E70", Offset = "0xB03A70", VA = "0x180B04E70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xE4BE80", Offset = "0xE4AA80", VA = "0x180E4BE80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool LPMIDFNBKCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xB04EF0", Offset = "0xB03AF0", VA = "0x180B04EF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xE4BC10", Offset = "0xE4A810", VA = "0x180E4BC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints BEJNLFNPDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xA5EBA0", Offset = "0xA5D7A0", VA = "0x180A5EBA0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8915BD0", Offset = "0x89147D0", VA = "0x188915BD0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x8915D30", Offset = "0x8914930", VA = "0x188915D30")]
	public FPHBOIKCLCB(CEKLINLDBIH HOAOIBONAAE, [In] HDIANNLONJN CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x8915BA0", Offset = "0x89147A0", VA = "0x188915BA0", Slot = "9")]
	public void ANAMKNBANEP(Rigidbody DOFJCHNPJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x8915D00", Offset = "0x8914900", VA = "0x188915D00", Slot = "10")]
	public void LKEAKBMEADH(Rigidbody DOFJCHNPJLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class KOFGNLKOMML : PIKFGBDJPFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly CEKLINLDBIH HOAOIBONAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float ILGBGMMHMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float KDBGDFEJKCH;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float CELIGADKLDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xAB55B0", Offset = "0xAB41B0", VA = "0x180AB55B0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x89248F0", Offset = "0x89234F0", VA = "0x1889248F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float PGCNBHPEPLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xAB56A0", Offset = "0xAB42A0", VA = "0x180AB56A0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8924A60", Offset = "0x8923660", VA = "0x188924A60", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8924B30", Offset = "0x8923730", VA = "0x188924B30")]
	public KOFGNLKOMML(CEKLINLDBIH HOAOIBONAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x89248A0", Offset = "0x89234A0", VA = "0x1889248A0", Slot = "8")]
	public void ANAMKNBANEP(Rigidbody DOFJCHNPJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x89249C0", Offset = "0x89235C0", VA = "0x1889249C0", Slot = "9")]
	public void LKEAKBMEADH(Rigidbody DOFJCHNPJLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class JFAGHDLECEI : AGPAOKBNBKA
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly PEOHNMCPNIJ NPFACGEOAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly KIFEAJLFEAL HOAOIBONAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool GAFAGODJMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool FNOBEOBOPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int KBAFIDGBPPN;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody PMNEJLBAAMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x89131F0", Offset = "0x8911DF0", VA = "0x1889131F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool JJIDLIPJIFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x891D2B0", Offset = "0x891BEB0", VA = "0x18891D2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private CEKLINLDBIH CCBOMPENMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x891DB30", Offset = "0x891C730", VA = "0x18891DB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool CAHBCLGMMLH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x891D6E0", Offset = "0x891C2E0", VA = "0x18891D6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event KDFLOOJFLHN JKNHPKPBNPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x891DA90", Offset = "0x891C690", VA = "0x18891DA90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x891DB90", Offset = "0x891C790", VA = "0x18891DB90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x891DF10", Offset = "0x891CB10", VA = "0x18891DF10")]
	public JFAGHDLECEI(CEKLINLDBIH HOAOIBONAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x891DD80", Offset = "0x891C980", VA = "0x18891DD80", Slot = "6")]
	public void ONFOCPIMDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x891DCD0", Offset = "0x891C8D0", VA = "0x18891DCD0", Slot = "8")]
	public void OLAMEOEEKGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x891D460", Offset = "0x891C060", VA = "0x18891D460", Slot = "7")]
	public bool DHPGIJPNDIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x891DC30", Offset = "0x891C830", VA = "0x18891DC30", Slot = "9")]
	public void NLEACNAAILG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x891DCE0", Offset = "0x891C8E0", VA = "0x18891DCE0", Slot = "13")]
	public void OMFOFKNHABI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x891D5B0", Offset = "0x891C1B0", VA = "0x18891D5B0", Slot = "12")]
	public void DLKLFODEKBO(bool JJALHFAPCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x891DE10", Offset = "0x891CA10", VA = "0x18891DE10", Slot = "10")]
	public bool OOACKKFFEHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x891D740", Offset = "0x891C340", VA = "0x18891D740", Slot = "11")]
	public bool GJFEPBNPPHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x891D800", Offset = "0x891C400", VA = "0x18891D800")]
	private bool HDDMIOJGKPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x891D2D0", Offset = "0x891BED0", VA = "0x18891D2D0")]
	private void BIPIECHPJNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class BBMOKGLHKAM : LNJHOJNIHDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly KIFEAJLFEAL HOAOIBONAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IACMJMJNBEK MPKIJACGBDA;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody PMNEJLBAAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xA5C7A0", Offset = "0xA5B3A0", VA = "0x180A5C7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool CAHBCLGMMLH
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x89117D0", Offset = "0x89103D0", VA = "0x1889117D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool KPBENLFLPLN
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1A12150", Offset = "0x1A10D50", VA = "0x181A12150", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8911DE0", Offset = "0x89109E0", VA = "0x188911DE0")]
	public BBMOKGLHKAM(CEKLINLDBIH HOAOIBONAAE, [In] HDIANNLONJN CBCNBAPLLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8911D10", Offset = "0x8910910", VA = "0x188911D10", Slot = "5")]
	public void ONFOCPIMDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x8911DB0", Offset = "0x89109B0", VA = "0x188911DB0", Slot = "7")]
	public void PMBPNBLIEBN(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x8911830", Offset = "0x8910430", VA = "0x188911830", Slot = "8")]
	public void FGJJNLGGGMM(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8911860", Offset = "0x8910460", VA = "0x188911860", Slot = "9")]
	public void GMCGOCMFMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x89115E0", Offset = "0x89101E0", VA = "0x1889115E0", Slot = "10")]
	public void BLBNAGAHOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x8911B90", Offset = "0x8910790", VA = "0x188911B90", Slot = "11")]
	public void HGLBBDBODLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class GMBPIJFBLPN : EJBPLOLBJGC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly KIFEAJLFEAL HOAOIBONAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly IACMJMJNBEK BDIIMPABONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float OPDGOLDLPBM;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public EJBNNOGLELE BMPAMCJNMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA66FD0", VA = "0x180A683D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public KHBKNBENECM EPBIIECPPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA5FCB0", Offset = "0xA5E8B0", VA = "0x180A5FCB0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 HGMBOAAPBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8918BD0", Offset = "0x89177D0", VA = "0x188918BD0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8918FE0", Offset = "0x8917BE0", VA = "0x188918FE0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 AMDMGIFFLMH
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x891AAA0", Offset = "0x89196A0", VA = "0x18891AAA0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x89190A0", Offset = "0x8917CA0", VA = "0x1889190A0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 GHBMHGJDHEN
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x89193D0", Offset = "0x8917FD0", VA = "0x1889193D0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x891A9E0", Offset = "0x89195E0", VA = "0x18891A9E0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 NFFPEAGEGMB
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8918D50", Offset = "0x8917950", VA = "0x188918D50", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8918D20", Offset = "0x8917920", VA = "0x188918D20", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float PFEGNGGGEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xAB56B0", Offset = "0xAB42B0", VA = "0x180AB56B0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x89190D0", Offset = "0x8917CD0", VA = "0x1889190D0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool CDFAGPGKFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x236AF20", Offset = "0x2369B20", VA = "0x18236AF20", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private FGCLMHBNCKE FJICNDKDENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7E64E50", Offset = "0x7E63A50", VA = "0x187E64E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool JJIDLIPJIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8918290", Offset = "0x8916E90", VA = "0x188918290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x891B2A0", Offset = "0x8919EA0", VA = "0x18891B2A0")]
	public GMBPIJFBLPN(CEKLINLDBIH HOAOIBONAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x891ABC0", Offset = "0x89197C0", VA = "0x18891ABC0", Slot = "19")]
	public void ONFOCPIMDHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x8918E70", Offset = "0x8917A70", VA = "0x188918E70", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8918160", Offset = "0x8916D60", VA = "0x188918160", Slot = "28")]
	public void ANAMKNBANEP(Rigidbody DOFJCHNPJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x17F18A0", Offset = "0x17F04A0", VA = "0x1817F18A0", Slot = "20")]
	public void KPCJLKIKOHB(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x17F1720", Offset = "0x17F0320", VA = "0x1817F1720", Slot = "30")]
	public void BMBLBMFDEFA(object DANCOEFIHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8919D20", Offset = "0x8918920", VA = "0x188919D20", Slot = "35")]
	public Vector3 JBAHILFFAAI(Vector3 ICMJMFHDHFK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8919F00", Offset = "0x8918B00", VA = "0x188919F00", Slot = "34")]
	public Vector3 JDIDCCAMIDB(Vector3 CCLLMHLHBKA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x891ABC0", Offset = "0x89197C0", VA = "0x18891ABC0", Slot = "27")]
	public void MPEDPLGIDOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8919370", Offset = "0x8917F70", VA = "0x188919370", Slot = "25")]
	public void HNCFODKEKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8917D10", Offset = "0x8916910", VA = "0x188917D10", Slot = "24")]
	public void AAFFFJAFDNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x8919530", Offset = "0x8918130", VA = "0x188919530", Slot = "33")]
	public void IMPMLNLNEBI(Vector3 EBAFNFHBEDD, Vector3 AEJLGCCIIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8918ED0", Offset = "0x8917AD0", VA = "0x188918ED0", Slot = "32")]
	public void EEEIEBHMPGI(Vector3 PLOCPBPGBGG, Vector3 LFGIFPMDCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x891B100", Offset = "0x8919D00", VA = "0x18891B100", Slot = "31")]
	public void PDLLFBAMNBN(Vector3 ELHAEEMJDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x891A1E0", Offset = "0x8918DE0", VA = "0x18891A1E0", Slot = "22")]
	public void JNJCJDMBOOA(PCHGDODKJCD IECKMLOLLAN, Vector3 LBNBIHKIOIO, float HHHBDIGBKHH, float GNKOCPBPGOP = 8f, float CDMKNLFCMMB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x891AE70", Offset = "0x8919A70", VA = "0x18891AE70", Slot = "21")]
	public void OJPAEDLNLIM(IKFAIOFMFBF ADADEDHMFPP, Vector3 OIHODILJFBC, float KPJKKEJMCJB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8917D70", Offset = "0x8916970", VA = "0x188917D70", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void AJFHCOLINMN(IKFAIOFMFBF ADADEDHMFPP, Vector3 DINDLKHALMD, float PAGFHHDENOC = 7f, float ADHDDLNAIBP = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x1948D40", Offset = "0x1947940", VA = "0x181948D40")]
	private static void IPNENMAJMFJ(Vector3 ANDGMPFHLOF, Vector3 JMBLGBJKENI, [Out] Vector3 MNACLENOCBD, [Out] Vector3 FDDLDBFJPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x891AC70", Offset = "0x8919870", VA = "0x18891AC70", Slot = "29")]
	public Vector3 NFNKMEFHGOJ(Vector3 ANDGMPFHLOF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x89191E0", Offset = "0x8917DE0", VA = "0x1889191E0", Slot = "26")]
	public void HLLCNPIJCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x89190D0", Offset = "0x8917CD0", VA = "0x1889190D0")]
	private void NBNFKAKPNMF(float BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x891A840", Offset = "0x8919440", VA = "0x18891A840")]
	private void KDMPGHPALDG(Vector3 OIHODILJFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x891A0C0", Offset = "0x8918CC0", VA = "0x18891A0C0")]
	private Vector3 JJOIEGNNPJA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8918740", Offset = "0x8917340", VA = "0x188918740")]
	private void CHALDMIODAO(Vector3 CCLLMHLHBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x891AD50", Offset = "0x8919950", VA = "0x18891AD50")]
	private Vector3 NKPDMLGDLLJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x89182B0", Offset = "0x8916EB0", VA = "0x1889182B0")]
	private void BFDDMKKNCMJ(Vector3 BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8919770", Offset = "0x8918370", VA = "0x188919770")]
	private void IPPELBCBLNL(Vector3 CCLLMHLHBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8918F30", Offset = "0x8917B30", VA = "0x188918F30")]
	private void EOJLFNCNPLJ()
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
