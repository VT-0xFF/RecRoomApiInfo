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
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A3B0", Offset = "0x8D38DB0", VA = "0x188D3A3B0", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86BB110", Offset = "0x86B9B10", VA = "0x1886BB110", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8D43240", Offset = "0x8D41C40", VA = "0x188D43240")]
		private void OFEEGALAMNF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D43550", Offset = "0x8D41F50", VA = "0x188D43550", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8D435B0", Offset = "0x8D41FB0", VA = "0x188D435B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, ANNBNLPJGPM, GBAIPNMDKIG, ONOGEDAKJOF
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly OLFEOKKCIEG DPMDAKEOKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool CHKIELLCFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private GIFDOEAHBPA OHAMBBEIKAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[JOGPDLJFLHG(EAHEBLGAGFP.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[JOGPDLJFLHG(EAHEBLGAGFP.SelfAndParent, true, false, false)]
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
		private ILMFIJFBGOM physicsInterpolation;

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
		private Transform OAEEPEDFFEE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal GIFDOEAHBPA NODABNICMJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8D3F040", Offset = "0x8D3DA40", VA = "0x188D3F040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private GIFDOEAHBPA NMHGHHCLJPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int AKHAHMFNAJG
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8D40750", Offset = "0x8D3F150", VA = "0x188D40750")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx HDFMBFDKMJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8D40AB0", Offset = "0x8D3F4B0", VA = "0x188D40AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx GLKLCNOCKAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8D409F0", Offset = "0x8D3F3F0", VA = "0x188D409F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx AEMEEJKFKNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8D416B0", Offset = "0x8D400B0", VA = "0x188D416B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8D42BB0", Offset = "0x8D415B0", VA = "0x188D42BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool GKHDDIPMIFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8963EF0", Offset = "0x89628F0", VA = "0x188963EF0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8963E60", Offset = "0x8962860", VA = "0x188963E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform HALOMIKDIAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x25994F0", Offset = "0x2597EF0", VA = "0x1825994F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform DNMFJNEKJDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x25994F0", Offset = "0x2597EF0", VA = "0x1825994F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform IPBJAMDPKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x25994F0", Offset = "0x2597EF0", VA = "0x1825994F0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public FMHNBNKGEEA EMHMEMCBIHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8D407B0", Offset = "0x8D3F1B0", VA = "0x188D407B0")]
			get
			{
				return default(FMHNBNKGEEA);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8D42360", Offset = "0x8D40D60", VA = "0x188D42360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool JCPKGNGOBOI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8D40DC0", Offset = "0x8D3F7C0", VA = "0x188D40DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool DCJPCDJNIHO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8D408D0", Offset = "0x8D3F2D0", VA = "0x188D408D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public DNNEGEPPCEJ NOHOGNPFBCI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8D40D00", Offset = "0x8D3F700", VA = "0x188D40D00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8D42520", Offset = "0x8D40F20", VA = "0x188D42520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public CGLIKLHAHPB NDMOFMEBCLD
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8D40CA0", Offset = "0x8D3F6A0", VA = "0x188D40CA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8D424B0", Offset = "0x8D40EB0", VA = "0x188D424B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool PFPMNLHFNCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8D40BF0", Offset = "0x8D3F5F0", VA = "0x188D40BF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody LFNIPFIPBBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8D40C50", Offset = "0x8D3F650", VA = "0x188D40C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool BGFNOMAKOCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8D40930", Offset = "0x8D3F330", VA = "0x188D40930")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8D423D0", Offset = "0x8D40DD0", VA = "0x188D423D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool ENCHKFGGMLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x18D8070", Offset = "0x18D6A70", VA = "0x1818D8070", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float JEMLCPLEHHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8D41650", Offset = "0x8D40050", VA = "0x188D41650")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float LKFOHOGKNPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8D415F0", Offset = "0x8D3FFF0", VA = "0x188D415F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8D42B40", Offset = "0x8D41540", VA = "0x188D42B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float OCHHEAADHMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8D41020", Offset = "0x8D3FA20", VA = "0x188D41020")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8D427C0", Offset = "0x8D411C0", VA = "0x188D427C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float INLOFGGNMAB
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8D40E20", Offset = "0x8D3F820", VA = "0x188D40E20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8D42590", Offset = "0x8D40F90", VA = "0x188D42590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool AIBDJMBFJLP
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8D41C00", Offset = "0x8D40600", VA = "0x188D41C00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8D430F0", Offset = "0x8D41AF0", VA = "0x188D430F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 EGCEEHODFBM
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8D413D0", Offset = "0x8D3FDD0", VA = "0x188D413D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8D42910", Offset = "0x8D41310", VA = "0x188D42910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 OICNKBOHKBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8D41D40", Offset = "0x8D40740", VA = "0x188D41D40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode BBEDNJOAJDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8D40F60", Offset = "0x8D3F960", VA = "0x188D40F60")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8D426E0", Offset = "0x8D410E0", VA = "0x188D426E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float FNELBDCMICJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8D40990", Offset = "0x8D3F390", VA = "0x188D40990")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8D42440", Offset = "0x8D40E40", VA = "0x188D42440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints IJBEKBPICAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8D40FC0", Offset = "0x8D3F9C0", VA = "0x188D40FC0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8D42750", Offset = "0x8D41150", VA = "0x188D42750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 MIFNMHCIDDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8D41770", Offset = "0x8D40170", VA = "0x188D41770")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 HFMMNEKPHLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8D41770", Offset = "0x8D40170", VA = "0x188D41770")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8D42ED0", Offset = "0x8D418D0", VA = "0x188D42ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float OELEAGMCOIE
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8D414B0", Offset = "0x8D3FEB0", VA = "0x188D414B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8D429F0", Offset = "0x8D413F0", VA = "0x188D429F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float HNPGAPCLBII
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8D41BA0", Offset = "0x8D405A0", VA = "0x188D41BA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8D43080", Offset = "0x8D41A80", VA = "0x188D43080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion NMPFEKFCJNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8D41850", Offset = "0x8D40250", VA = "0x188D41850")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8D42C50", Offset = "0x8D41650", VA = "0x188D42C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion JPNIBOFIBEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8D41AD0", Offset = "0x8D404D0", VA = "0x188D41AD0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8D42FB0", Offset = "0x8D419B0", VA = "0x188D42FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 JFMBGICJNBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8D41920", Offset = "0x8D40320", VA = "0x188D41920")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8D42D20", Offset = "0x8D41720", VA = "0x188D42D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion NKPPDGJLGFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8D41A00", Offset = "0x8D40400", VA = "0x188D41A00")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8D42E00", Offset = "0x8D41800", VA = "0x188D42E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 GMOGCJLCJBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8D41C60", Offset = "0x8D40660", VA = "0x188D41C60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8D43160", Offset = "0x8D41B60", VA = "0x188D43160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 PKCKKEIEJJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8D41510", Offset = "0x8D3FF10", VA = "0x188D41510")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8D42A60", Offset = "0x8D41460", VA = "0x188D42A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 LIDKIKJAOJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8D40E80", Offset = "0x8D3F880", VA = "0x188D40E80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8D42600", Offset = "0x8D41000", VA = "0x188D42600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 BGDJKDINADB
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8D412F0", Offset = "0x8D3FCF0", VA = "0x188D412F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8D42830", Offset = "0x8D41230", VA = "0x188D42830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 HLKAHPEJGCP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8D411B0", Offset = "0x8D3FBB0", VA = "0x188D411B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion PFDDJKNAFBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8D410E0", Offset = "0x8D3FAE0", VA = "0x188D410E0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 AKBFBGDBHCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8D41F00", Offset = "0x8D40900", VA = "0x188D41F00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 KIBDBKMOKFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8D41E20", Offset = "0x8D40820", VA = "0x188D41E20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool MBOJGJOFHGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8D41290", Offset = "0x8D3FC90", VA = "0x188D41290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool CPCNPNJKJCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8D40D60", Offset = "0x8D3F760", VA = "0x188D40D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool BNEGLBGNMDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8D40870", Offset = "0x8D3F270", VA = "0x188D40870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool FHNNMHDLDNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8D40810", Offset = "0x8D3F210", VA = "0x188D40810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool JBMANPDAEDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8D406F0", Offset = "0x8D3F0F0", VA = "0x188D406F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool KJCGFPJIHGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8D41080", Offset = "0x8D3FA80", VA = "0x188D41080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool FHLCJJBHDMI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2781C50", Offset = "0x2780650", VA = "0x182781C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event JJNGNENMLJJ OOKOFJMAIHO
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8D40610", Offset = "0x8D3F010", VA = "0x188D40610")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8D42280", Offset = "0x8D40C80", VA = "0x188D42280")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event PGINMDCPPIJ JKMJOEIKEHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8D40380", Offset = "0x8D3ED80", VA = "0x188D40380")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8D41FE0", Offset = "0x8D409E0", VA = "0x188D41FE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event PGINMDCPPIJ HKKGGLPNLHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8D403E0", Offset = "0x8D3EDE0", VA = "0x188D403E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8D42050", Offset = "0x8D40A50", VA = "0x188D42050")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event PGINMDCPPIJ DBEEIDAMNHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8D40530", Offset = "0x8D3EF30", VA = "0x188D40530")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8D421A0", Offset = "0x8D40BA0", VA = "0x188D421A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<ACOJACDAJIP, ACOJACDAJIP> GNOBOLCEDGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8D404C0", Offset = "0x8D3EEC0", VA = "0x188D404C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8D42130", Offset = "0x8D40B30", VA = "0x188D42130")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event PGINMDCPPIJ FBHHELGHDDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8D405A0", Offset = "0x8D3EFA0", VA = "0x188D405A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8D42210", Offset = "0x8D40C10", VA = "0x188D42210")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event PGINMDCPPIJ JICNEBLIAAA
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8D40680", Offset = "0x8D3F080", VA = "0x188D40680")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8D422F0", Offset = "0x8D40CF0", VA = "0x188D422F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event PGINMDCPPIJ OMIAOHKHACJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8D40450", Offset = "0x8D3EE50", VA = "0x188D40450")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8D420C0", Offset = "0x8D40AC0", VA = "0x188D420C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130", Slot = "8")]
		private void AHAMKJFFPKK(GIFDOEAHBPA FDMAPEJEBGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3ED40", Offset = "0x8D3D740", VA = "0x188D3ED40", Slot = "9")]
		public BMDNLBHNEKE GetData()
		{
			return default(BMDNLBHNEKE);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F3E0", Offset = "0x8D3DDE0", VA = "0x188D3F3E0")]
		internal void NADHLJJCELJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8D400A0", Offset = "0x8D3EAA0", VA = "0x188D400A0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody OAOFECMFMGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EA90", Offset = "0x8D3D490", VA = "0x188D3EA90")]
		public ANNBNLPJGPM GetChild(int KABGMIEBEFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FD60", Offset = "0x8D3E760", VA = "0x188D3FD60")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) FPHHKNIAPKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E6E0", Offset = "0x8D3D0E0", VA = "0x188D3E6E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FFF0", Offset = "0x8D3E9F0", VA = "0x188D3FFF0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F040", Offset = "0x8D3DA40", VA = "0x188D3F040")]
		private GIFDOEAHBPA JIFIKHOLNDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F0F0", Offset = "0x8D3DAF0", VA = "0x188D3F0F0")]
		private void LHEJPJMHOBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F530", Offset = "0x8D3DF30", VA = "0x188D3F530")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F470", Offset = "0x8D3DE70", VA = "0x188D3F470")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F3E0", Offset = "0x8D3DDE0", VA = "0x188D3F3E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F4D0", Offset = "0x8D3DED0", VA = "0x188D3F4D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F590", Offset = "0x8D3DF90", VA = "0x188D3F590")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DD30", Offset = "0x8D3C730", VA = "0x188D3DD30")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object MFKHKDDANII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F5F0", Offset = "0x8D3DFF0", VA = "0x188D3F5F0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object MFKHKDDANII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EA30", Offset = "0x8D3D430", VA = "0x188D3EA30")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F380", Offset = "0x8D3DD80", VA = "0x188D3F380")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FEC0", Offset = "0x8D3E8C0", VA = "0x188D3FEC0")]
		public void SetParent(RigidbodyEx KMAFNKGMDCF, bool NFCKHMKCNGK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F900", Offset = "0x8D3E300", VA = "0x188D3F900")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EDE0", Offset = "0x8D3D7E0", VA = "0x188D3EDE0")]
		public bool IsRigidbodyAncestor(RigidbodyEx KMBKKMFGMEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EEE0", Offset = "0x8D3D8E0", VA = "0x188D3EEE0")]
		public bool IsRigidbodyDescendant(RigidbodyEx IBMCFNHBJIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DFA0", Offset = "0x8D3C9A0", VA = "0x188D3DFA0")]
		public void AddInterpolationRestriction(object MFKHKDDANII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F660", Offset = "0x8D3E060", VA = "0x188D3F660")]
		public void RemoveInterpolationRestriction(object MFKHKDDANII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E010", Offset = "0x8D3CA10", VA = "0x188D3E010")]
		public void AddKinematic(object MFKHKDDANII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F6D0", Offset = "0x8D3E0D0", VA = "0x188D3F6D0")]
		public void RemoveKinematic(object MFKHKDDANII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FE40", Offset = "0x8D3E840", VA = "0x188D3FE40")]
		public void SetKinematic(object MFKHKDDANII, bool JMGOCMABGNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FC60", Offset = "0x8D3E660", VA = "0x188D3FC60")]
		public void SetDiscontinuousPositionAndRotation(Vector3 MJBMEPCOMAJ, Quaternion BPFKODHFGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FB60", Offset = "0x8D3E560", VA = "0x188D3FB60")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 MLLJOKPHMGD, Quaternion JNEDEPPGFHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EC30", Offset = "0x8D3D630", VA = "0x188D3EC30")]
		public Vector3 GetConstrainedVelocity(Vector3 GMOGCJLCJBF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EB20", Offset = "0x8D3D520", VA = "0x188D3EB20")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 LIDKIKJAOJJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DEB0", Offset = "0x8D3C8B0", VA = "0x188D3DEB0")]
		public void AddForce(Vector3 KEJIJALNLAM, ForceMode KJEKHPEBEEH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DDA0", Offset = "0x8D3C7A0", VA = "0x188D3DDA0")]
		public void AddForceAtPosition(Vector3 KEJIJALNLAM, Vector3 KFJFDPLEJOD, ForceMode KJEKHPEBEEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E1E0", Offset = "0x8D3CBE0", VA = "0x188D3E1E0")]
		public void AddTorque(Vector3 BOIMOPECEPM, ForceMode KJEKHPEBEEH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E080", Offset = "0x8D3CA80", VA = "0x188D3E080")]
		public void AddRelativeTorque(Vector3 BOIMOPECEPM, ForceMode KJEKHPEBEEH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8D40170", Offset = "0x8D3EB70", VA = "0x188D40170")]
		public Vector3 WorldToLocalVelocity(Vector3 HBCKENKNHBM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F270", Offset = "0x8D3DC70", VA = "0x188D3F270")]
		public Vector3 LocalToWorldVelocity(Vector3 PKCKKEIEJJG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E9D0", Offset = "0x8D3D3D0", VA = "0x188D3E9D0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E970", Offset = "0x8D3D370", VA = "0x188D3E970")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E910", Offset = "0x8D3D310", VA = "0x188D3E910")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E8B0", Offset = "0x8D3D2B0", VA = "0x188D3E8B0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FA60", Offset = "0x8D3E460", VA = "0x188D3FA60")]
		public void ResetVelocityWorldSpace(Vector3 MCGFEPBEJMH, Vector3 JMHODIHNCOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F960", Offset = "0x8D3E360", VA = "0x188D3F960")]
		public void ResetVelocityLocalSpace(Vector3 MPEGMNNICAA, Vector3 BGDJKDINADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F820", Offset = "0x8D3E220", VA = "0x188D3F820")]
		public void ResetLinearVelocityLocalSpace(Vector3 MPEGMNNICAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8D40000", Offset = "0x8D3EA00", VA = "0x188D40000")]
		public bool SweepTest(Vector3 HLNPPHJBENM, [Out] RaycastHit JMACOIIAFBO, float EFLCGLGNONM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EFE0", Offset = "0x8D3D9E0", VA = "0x188D3EFE0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FF90", Offset = "0x8D3E990", VA = "0x188D3FF90")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8D40110", Offset = "0x8D3EB10", VA = "0x188D40110")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E170", Offset = "0x8D3CB70", VA = "0x188D3E170")]
		public void AddShouldHaveUnityRigidbodyToken(object MFKHKDDANII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F740", Offset = "0x8D3E140", VA = "0x188D3F740")]
		public void RemoveShouldHaveUnityRigidbodyToken(object MFKHKDDANII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E570", Offset = "0x8D3CF70", VA = "0x188D3E570")]
		public void ApplyForceVelocityChange(ILIKBONEJOO GPDAHHPDDKG, Vector3 ECAJAFJNDJO, float PLMCHHBJBJF, float LKIAJOBMEOM = 8f, float CKNNLHJFOKK = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E470", Offset = "0x8D3CE70", VA = "0x188D3E470")]
		public void ApplyAngularVelocityChange(MPBOJIIMMCC NIOFENKCHOC, Vector3 DGNINMFNFAK, float ICLMNIBGAOB = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E630", Offset = "0x8D3D030", VA = "0x188D3E630")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(MPBOJIIMMCC NIOFENKCHOC, Vector3 AMHDLJKDJBK, float DIJFDBBAGON = 7f, float JADLGMEJNLI = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E3A0", Offset = "0x8D3CDA0", VA = "0x188D3E3A0")]
		public bool AllowedScaleChange(float NMALOKPPLFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E2D0", Offset = "0x8D3CCD0", VA = "0x188D3E2D0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx KMIGKJKHCFM, object MFKHKDDANII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8D3F7B0", Offset = "0x8D3E1B0", VA = "0x188D3F7B0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object MFKHKDDANII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EDD0", Offset = "0x8D3D7D0", VA = "0x188D3EDD0", Slot = "13")]
		private void IAACJMPBOCD(DMCPBIKBILF IJNPIDPIBFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8D40310", Offset = "0x8D3ED10", VA = "0x188D40310")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xB64410", Offset = "0xB62E10", VA = "0x180B64410", Slot = "4")]
		private GameObject NBJCALKAPNN()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xADAB70", Offset = "0xAD9570", VA = "0x180ADAB70", Slot = "10")]
		private bool NNIBCAIEOLK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class MDLOBBJNLKP
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8D3B0E0", Offset = "0x8D39AE0", VA = "0x188D3B0E0")]
	public static GIFDOEAHBPA NODABNICMJE(this RigidbodyEx OPGHIHFJADP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(BMFCNNFCELK), new string[] { })]
public class PAACLBPKJDM : BMFCNNFCELK, BOHILICPPOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private IMDIJHAGAED ADCMGLPBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private HMDAGBBKBAG AFJOMIGMCGG;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IMDIJHAGAED BCDAFCHHCGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public HMDAGBBKBAG EDNAGEADCKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8D3CB90", Offset = "0x8D3B590", VA = "0x188D3CB90", Slot = "7")]
	public void InitReferences(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8D3CA60", Offset = "0x8D3B460", VA = "0x188D3CA60", Slot = "6")]
	public GIFDOEAHBPA AKHBCKCEPDN(RigidbodyEx OPGHIHFJADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public PAACLBPKJDM()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static EBDGCEEEFPM UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int HDPDMHCDMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int ODDGDHOEMJI;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DB90", Offset = "0x8D3C590", VA = "0x188D3DB90")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DBD0", Offset = "0x8D3C5D0", VA = "0x188D3DBD0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DBB0", Offset = "0x8D3C5B0", VA = "0x188D3DBB0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string JEBOHIALEMJ, [Optional] UnityEngine.Object IJNPIDPIBFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string JEBOHIALEMJ, [Optional] UnityEngine.Object IJNPIDPIBFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DCE0", Offset = "0x8D3C6E0", VA = "0x188D3DCE0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EFDBGAJLKDD
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class LEFNGMJFOJB : DNNEGEPPCEJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xABD840", Offset = "0xABC240", VA = "0x180ABD840", Slot = "4")]
		public Vector3 KJNHGBCILCI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xABD840", Offset = "0xABC240", VA = "0x180ABD840", Slot = "5")]
		public Vector3 OAACKNNBMOM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "6")]
		public bool PCOLIIIMNJN(float IPJDJEBBIGC, float NHJDIAECBGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public LEFNGMJFOJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static DNNEGEPPCEJ GELABMGGNLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8D29590", Offset = "0x8D27F90", VA = "0x188D29590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BFGDPDKKBDC
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode PHKMHGCLFCM
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
	void JEALAPEIAJO();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FAHDIEEEIPB(bool MBOJGJOFHGG);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNLNDHJHCCH(bool MBOJGJOFHGG);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FIOCJLGFJAL(Rigidbody ELBJAFIJOCC);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PPOFEJAAPPP(Vector3 HLNPPHJBENM, [Out] RaycastHit JMACOIIAFBO, float EFLCGLGNONM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ALADACOLBDI : IDisposable, MFMLODIOEBD
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	FMHNBNKGEEA EMHMEMCBIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<ACOJACDAJIP, ACOJACDAJIP> GNOBOLCEDGK;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JEALAPEIAJO();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface HMDAGBBKBAG
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MDNEHDFHFCK GMODEKLDKDL(GIFDOEAHBPA FDMAPEJEBGO);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FPLOPMDPNJN IDBODKHLGEO(GIFDOEAHBPA FDMAPEJEBGO);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ACCAHCKFOPM GGFNGENCNCH(GIFDOEAHBPA FDMAPEJEBGO);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IKKNGLPMJGB KPCMCFMLMCE(GIFDOEAHBPA FDMAPEJEBGO);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MDECIBJJMMG LLOGLIEGNMJ(GIFDOEAHBPA FDMAPEJEBGO);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ALADACOLBDI KOBBPIJOGOG(GIFDOEAHBPA FDMAPEJEBGO);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DBMJCLJAFLA KGDCGGENCEN(GIFDOEAHBPA FDMAPEJEBGO);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HKBGLIABNEF NDJANJICCAB(GIFDOEAHBPA FDMAPEJEBGO);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BFGDPDKKBDC DJPNCFMNEBI(GIFDOEAHBPA FDMAPEJEBGO);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ADCOCLEJBHN CIBNNIAKEDG(GIFDOEAHBPA FDMAPEJEBGO);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CJMBACAMIIP BHLOHLDKLIN(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HKHDMOJBCDM MJEINGFCPEE(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MGCDAPEPIGD MNJDCEIDKMA(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	CKMINPINJLL EBCJMOMOIOB(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OBCDAFKIDPL DMNKNDLNGBH(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GIFDOEAHBPA AKHBCKCEPDN(RigidbodyEx OPGHIHFJADP, BMDNLBHNEKE BLPDDGCLNPE, BMFCNNFCELK KFMMGFEJHFC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HKBGLIABNEF
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIFOEHKDHAD(Vector3 KEJIJALNLAM, ForceMode KJEKHPEBEEH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ONCJODFGKOD(Vector3 KEJIJALNLAM, Vector3 KFJFDPLEJOD, ForceMode KJEKHPEBEEH);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BMOOFAOLDJA(Vector3 BOIMOPECEPM, ForceMode KJEKHPEBEEH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JBMHCGLJDMB(Vector3 BOIMOPECEPM, ForceMode KJEKHPEBEEH = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ADCOCLEJBHN
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool EFDEBDPIPGA
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
	void FIOCJLGFJAL(Rigidbody ELBJAFIJOCC);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JPIGHADADLL(Rigidbody ELBJAFIJOCC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MDNEHDFHFCK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<GIFDOEAHBPA> NHJJODDGEBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	GIFDOEAHBPA GLKLCNOCKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	GIFDOEAHBPA AJFLBGMINPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event PGINMDCPPIJ JKMJOEIKEHG;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event PGINMDCPPIJ HKKGGLPNLHM;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event JJNGNENMLJJ GCHNFJIEJPP;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action EIAABMBKIHL;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action MFKGFOAHCNH;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<GIFDOEAHBPA> EMPCJEBNCEC;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<GIFDOEAHBPA> PGAIIKOMHOH;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action IPLMMNCNCOH;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<GIFDOEAHBPA> IILPBMPKJNB;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IEBALGDGBAK(GIFDOEAHBPA CCBBLDBOMGE, bool NFCKHMKCNGK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ACCAHCKFOPM
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 FIFLACCEFFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 AMHKJCKDPPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EBDMBOFJIAH(GIFDOEAHBPA AEMEEJKFKNN, object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNCAJMFANIP(object MFKHKDDANII);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CKMINPINJLL
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 BIBEEELBBND
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 DMPACHBPOJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float AJAKBBEPOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float CNAKECDMPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 ICPJGPOABEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion DNBENHGJNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event PGINMDCPPIJ GIBCGGAIBIM;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LKGGAPCDBAA((Quaternion rot, Vector3 moments) FPHHKNIAPKM);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IAFKMCKDEBI();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PEBJHMLKJCP();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void CMKDBEHLHLC();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FIOCJLGFJAL(Rigidbody ELBJAFIJOCC);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JPIGHADADLL(Rigidbody ELBJAFIJOCC);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void INHIAHKPLBK();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MGCDAPEPIGD
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JEALAPEIAJO();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GIAMPAOGMCN(object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJOKGNNFCLI(object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CGIDDFADLKK(GIFDOEAHBPA OPGHIHFJADP);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IKLJLIGNGMN(GIFDOEAHBPA OPGHIHFJADP);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GNAADEJODMB();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DBMJCLJAFLA
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool DPDLMKLLGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event PGINMDCPPIJ FBLJFEAKDPL;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AEGKLGLDCBB(object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OEOHIKGOKGN(object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DIHDMBNDKJC(object MFKHKDDANII, bool JMGOCMABGNJ);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FIOCJLGFJAL(Rigidbody CAOCACBOIHN);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JPIGHADADLL(Rigidbody ELBJAFIJOCC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HKHDMOJBCDM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool JCPKGNGOBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool DCJPCDJNIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event PGINMDCPPIJ EPHOAKNPHDO;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JEALAPEIAJO();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CELDGJFPGDA(GIFDOEAHBPA AEMEEJKFKNN);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HFFGMDBIPDK(GIFDOEAHBPA AEMEEJKFKNN);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface OBCDAFKIDPL
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool BGFNOMAKOCE
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool IDNPCENDDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints KCECLKHHDJD
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
	void FIOCJLGFJAL(Rigidbody ELBJAFIJOCC);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JPIGHADADLL(Rigidbody ELBJAFIJOCC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IKKNGLPMJGB
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float OBIIGODIOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float FNGOOOIJEDP
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
	void FIOCJLGFJAL(Rigidbody ELBJAFIJOCC);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JPIGHADADLL(Rigidbody ELBJAFIJOCC);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MDECIBJJMMG
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool LHLOPGCPNAM;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event PGINMDCPPIJ JNOGJPGDPEF;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JEALAPEIAJO();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KKFLCFNHKBJ();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PEOCEDLEMAI();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LACPEDJKBHI();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JDDNKALIHME();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ILMHPMMOJMM();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OKKLLBBBPAJ(bool DMBPPMAIPDM);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MNDIMBHHAOD();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CJMBACAMIIP
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody LFNIPFIPBBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool ONIHDGIFOCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JEALAPEIAJO();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBKIHFOMNCB(object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BLEKJKOOFIB(object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HLNGMFADIKA();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FPLOPMDPNJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	DNNEGEPPCEJ NOHOGNPFBCI
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	CGLIKLHAHPB NDMOFMEBCLD
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 OPBKGMDLBFP
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 OCEPNBECDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 BEJKHPCMANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 JKJEPGLHIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float FNELBDCMICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool PFPMNLHFNCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JEALAPEIAJO();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GHBMFGKPHEP(object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CKDLJGADBGC(MPBOJIIMMCC NIOFENKCHOC, Vector3 DGNINMFNFAK, float ICLMNIBGAOB = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JGCLCKCNNIA(ILIKBONEJOO GPDAHHPDDKG, Vector3 ECAJAFJNDJO, float PLMCHHBJBJF, float LKIAJOBMEOM = 8f, float CKNNLHJFOKK = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KHIIONODKED(MPBOJIIMMCC NIOFENKCHOC, Vector3 AMHDLJKDJBK, float DIJFDBBAGON = 7f, float JADLGMEJNLI = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LAJLEHMLEEI();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void JJJJNDBENCB();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FNLMDJNHPCO();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void BGNNKMEGKCB();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FIOCJLGFJAL(Rigidbody ELBJAFIJOCC);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 APJANGIKMKO(Vector3 GMOGCJLCJBF);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void AEMMBDMIOCA(object MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MMADJBHMKAL(Vector3 ELDEDOKAACG);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JDKJPMDJMPC(Vector3 MPEGMNNICAA, Vector3 BGDJKDINADB);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void KMMDEOGFIOG(Vector3 MCGFEPBEJMH, Vector3 JMHODIHNCOE);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 JLFPAOGPFMO(Vector3 PKCKKEIEJJG);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 BOFPKOFOGEF(Vector3 HBCKENKNHBM);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface IMDIJHAGAED
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool KIDBBPJOEIK
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ABJEDLFCKHP(string IHPAEKNOMOJ);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KDNPPDCHLEL(RigidbodyEx OPGHIHFJADP, Action FCCCPABHDPG);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	APPPHJAKOPF MACBJPMEKII(int OEJNIDFBMJL);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HIBPFHMDGIM(Vector3 OICNKBOHKBH, float MKCLMEMGFDD, Color EOGEFFOIIOP);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface BMFCNNFCELK
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	IMDIJHAGAED BCDAFCHHCGD
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	HMDAGBBKBAG EDNAGEADCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GIFDOEAHBPA AKHBCKCEPDN(RigidbodyEx OPGHIHFJADP);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class IGMOBNOOFLK : GIFDOEAHBPA, IDisposable, KNCEOGMDJKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal readonly BMFCNNFCELK KFMMGFEJHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal MDNEHDFHFCK KAJADHIAMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal MGCDAPEPIGD FPFJGPIBGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal HKHDMOJBCDM DHENGGDFPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal FPLOPMDPNJN GMOGCJLCJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal ACCAHCKFOPM HJDOOBFLNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal CKMINPINJLL FNNMCKJOFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal IKKNGLPMJGB AIECPDLNGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal ADCOCLEJBHN GLGKKPKPNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal MDECIBJJMMG KAEFCAJHAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal ALADACOLBDI GGMCCMHMIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal DBMJCLJAFLA IFBMMJDGIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal HKBGLIABNEF KEJIJALNLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal OBCDAFKIDPL HMFGHKJDPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal CJMBACAMIIP ELBJAFIJOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal BFGDPDKKBDC FFLDNKDEJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal IDisposable GGCFALCCGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private bool BLBHEKBJMKJ;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "22")]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public ANNBNLPJGPM PKDPEMEHBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xB79620", Offset = "0xB78020", VA = "0x180B79620", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xB795D0", Offset = "0xB77FD0", VA = "0x180B795D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject DKIONLOHAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xAB9520", Offset = "0xAB7F20", VA = "0x180AB9520", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xAB9490", Offset = "0xAB7E90", VA = "0x180AB9490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform AJEDGAAHNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xB793D0", Offset = "0xB77DD0", VA = "0x180B793D0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xB795F0", Offset = "0xB77FF0", VA = "0x180B795F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody LFNIPFIPBBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F3C0", Offset = "0x8D2DDC0", VA = "0x188D2F3C0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public GIFDOEAHBPA AJFLBGMINPD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E7D0", Offset = "0x8D2D1D0", VA = "0x188D2E7D0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8D2C2D0", Offset = "0x8D2ACD0", VA = "0x188D2C2D0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int AKHAHMFNAJG
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F2E0", Offset = "0x8D2DCE0", VA = "0x188D2F2E0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public GIFDOEAHBPA GLKLCNOCKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8D31540", Offset = "0x8D2FF40", VA = "0x188D31540", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool CDGODCGHBAH
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E3A0", Offset = "0x8D2CDA0", VA = "0x188D2E3A0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool JCPKGNGOBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E1C0", Offset = "0x8D2CBC0", VA = "0x188D2E1C0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool DCJPCDJNIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8D31CC0", Offset = "0x8D306C0", VA = "0x188D31CC0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public DNNEGEPPCEJ NOHOGNPFBCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E270", Offset = "0x8D2CC70", VA = "0x188D2E270", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8D31100", Offset = "0x8D2FB00", VA = "0x188D31100", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public CGLIKLHAHPB NDMOFMEBCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F9F0", Offset = "0x8D2E3F0", VA = "0x188D2F9F0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E9A0", Offset = "0x8D2D3A0", VA = "0x188D2E9A0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float FNELBDCMICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8D2DA90", Offset = "0x8D2C490", VA = "0x188D2DA90", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8D30180", Offset = "0x8D2EB80", VA = "0x188D30180", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 OCEPNBECDIO
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F470", Offset = "0x8D2DE70", VA = "0x188D2F470", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8D32620", Offset = "0x8D31020", VA = "0x188D32620", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 JKJEPGLHIAC
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D900", Offset = "0x8D2C300", VA = "0x188D2D900", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8D30D40", Offset = "0x8D2F740", VA = "0x188D30D40", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 OPBKGMDLBFP
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D820", Offset = "0x8D2C220", VA = "0x188D2D820", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8D32390", Offset = "0x8D30D90", VA = "0x188D32390", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 BEJKHPCMANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E4A0", Offset = "0x8D2CEA0", VA = "0x188D2E4A0", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8D2ECA0", Offset = "0x8D2D6A0", VA = "0x188D2ECA0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool BNEGLBGNMDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E400", Offset = "0x8D2CE00", VA = "0x188D2E400", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool FHNNMHDLDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8D2EE50", Offset = "0x8D2D850", VA = "0x188D2EE50", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool JBMANPDAEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FFA0", Offset = "0x8D2E9A0", VA = "0x188D2FFA0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool PFPMNLHFNCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8D31C30", Offset = "0x8D30630", VA = "0x188D31C30", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 FIFLACCEFFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8D2CCB0", Offset = "0x8D2B6B0", VA = "0x188D2CCB0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 AMHKJCKDPPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E2C0", Offset = "0x8D2CCC0", VA = "0x188D2E2C0", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 BIBEEELBBND
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E580", Offset = "0x8D2CF80", VA = "0x188D2E580", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FEC0", Offset = "0x8D2E8C0", VA = "0x188D2FEC0", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 DMPACHBPOJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8D31400", Offset = "0x8D2FE00", VA = "0x188D31400", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float AJAKBBEPOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8D2EC50", Offset = "0x8D2D650", VA = "0x188D2EC50", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float CNAKECDMPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8D2C390", Offset = "0x8D2AD90", VA = "0x188D2C390", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8D30E20", Offset = "0x8D2F820", VA = "0x188D30E20", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 ICPJGPOABEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FD90", Offset = "0x8D2E790", VA = "0x188D2FD90", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion DNBENHGJNAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8D2DAE0", Offset = "0x8D2C4E0", VA = "0x188D2DAE0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float OBIIGODIOGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D580", Offset = "0x8D2BF80", VA = "0x188D2D580", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E700", Offset = "0x8D2D100", VA = "0x188D2E700", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float FNGOOOIJEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8D31590", Offset = "0x8D2FF90", VA = "0x188D31590", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8D302F0", Offset = "0x8D2ECF0", VA = "0x188D302F0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool EFDEBDPIPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F6C0", Offset = "0x8D2E0C0", VA = "0x188D2F6C0", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F610", Offset = "0x8D2E010", VA = "0x188D2F610", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public FMHNBNKGEEA EMHMEMCBIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E030", Offset = "0x8D2CA30", VA = "0x188D2E030", Slot = "70")]
		get
		{
			return default(FMHNBNKGEEA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8D2C210", Offset = "0x8D2AC10", VA = "0x188D2C210", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool DPDLMKLLGFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E6B0", Offset = "0x8D2D0B0", VA = "0x188D2E6B0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform IPBJAMDPKCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xB793D0", Offset = "0xB77DD0", VA = "0x180B793D0", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 AJCPJAHJBDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8D2EFB0", Offset = "0x8D2D9B0", VA = "0x188D2EFB0", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8D2EBA0", Offset = "0x8D2D5A0", VA = "0x188D2EBA0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float JPGCGFKHDAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E7C0", Offset = "0x8D2D1C0", VA = "0x188D2E7C0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8D30CB0", Offset = "0x8D2F6B0", VA = "0x188D30CB0", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float ELCNLMLKKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8D310F0", Offset = "0x8D2FAF0", VA = "0x188D310F0", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8D311F0", Offset = "0x8D2FBF0", VA = "0x188D311F0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion OMKCHIKPOAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8D31D70", Offset = "0x8D30770", VA = "0x188D31D70", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8D31E70", Offset = "0x8D30870", VA = "0x188D31E70", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 DMEKCHJJJFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8D31C80", Offset = "0x8D30680", VA = "0x188D31C80", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8D2CAD0", Offset = "0x8D2B4D0", VA = "0x188D2CAD0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion LJJEACHFGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E180", Offset = "0x8D2CB80", VA = "0x188D2E180", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8D31F50", Offset = "0x8D30950", VA = "0x188D31F50", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints KCECLKHHDJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E080", Offset = "0x8D2CA80", VA = "0x188D2E080", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8D2EA00", Offset = "0x8D2D400", VA = "0x188D2EA00", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool BGFNOMAKOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D240", Offset = "0x8D2BC40", VA = "0x188D2D240", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8D2DFD0", Offset = "0x8D2C9D0", VA = "0x188D2DFD0", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode PHKMHGCLFCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E660", Offset = "0x8D2D060", VA = "0x188D2E660", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8D2CA20", Offset = "0x8D2B420", VA = "0x188D2CA20", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool PIOHMLELOAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F0E0", Offset = "0x8D2DAE0", VA = "0x188D2F0E0", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool CPCNPNJKJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E820", Offset = "0x8D2D220", VA = "0x188D2E820", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event PGINMDCPPIJ JKMJOEIKEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E760", Offset = "0x8D2D160", VA = "0x188D2E760", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8D31F80", Offset = "0x8D30980", VA = "0x188D31F80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event PGINMDCPPIJ HKKGGLPNLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F410", Offset = "0x8D2DE10", VA = "0x188D2F410", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D370", Offset = "0x8D2BD70", VA = "0x188D2D370", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event JJNGNENMLJJ GCHNFJIEJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8D301E0", Offset = "0x8D2EBE0", VA = "0x188D301E0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8D2C150", Offset = "0x8D2AB50", VA = "0x188D2C150", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event PGINMDCPPIJ EPHOAKNPHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8D30F60", Offset = "0x8D2F960", VA = "0x188D30F60", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8D2CB10", Offset = "0x8D2B510", VA = "0x188D2CB10", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event PGINMDCPPIJ DBEEIDAMNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8D303B0", Offset = "0x8D2EDB0", VA = "0x188D303B0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D31D10", Offset = "0x8D30710", VA = "0x188D31D10", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event PGINMDCPPIJ JNOGJPGDPEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8D314E0", Offset = "0x8D2FEE0", VA = "0x188D314E0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8D2DF70", Offset = "0x8D2C970", VA = "0x188D2DF70", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<ACOJACDAJIP, ACOJACDAJIP> GNOBOLCEDGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8D30350", Offset = "0x8D2ED50", VA = "0x188D30350", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8D2DA30", Offset = "0x8D2C430", VA = "0x188D2DA30", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event PGINMDCPPIJ FBLJFEAKDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8D31FE0", Offset = "0x8D309E0", VA = "0x188D31FE0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8D2DF10", Offset = "0x8D2C910", VA = "0x188D2DF10", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event PGINMDCPPIJ OMIAOHKHACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E0D0", Offset = "0x8D2CAD0", VA = "0x188D2E0D0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8D2EA60", Offset = "0x8D2D460", VA = "0x188D2EA60", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8D327E0", Offset = "0x8D311E0", VA = "0x188D327E0")]
	public IGMOBNOOFLK(GameObject FNCBMCHNDJI, RigidbodyEx KDDFHDDPLEF, BMFCNNFCELK KFMMGFEJHFC, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8D2CD80", Offset = "0x8D2B780", VA = "0x188D2CD80", Slot = "139")]
	protected virtual void BOBCAAAOPEJ(BMFCNNFCELK KFMMGFEJHFC, BMDNLBHNEKE BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8D2DE10", Offset = "0x8D2C810", VA = "0x188D2DE10", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8D2FB90", Offset = "0x8D2E590", VA = "0x188D2FB90", Slot = "93")]
	public void JEALAPEIAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8D2EB10", Offset = "0x8D2D510", VA = "0x188D2EB10", Slot = "94")]
	public void HCIJLAOPINK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8D2C270", Offset = "0x8D2AC70", VA = "0x188D2C270", Slot = "95")]
	public void AFEHIMDIEIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8D2D800", Offset = "0x8D2C200", VA = "0x188D2D800", Slot = "96")]
	public void CLLGOEBCMJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8D32040", Offset = "0x8D30A40", VA = "0x188D32040")]
	private void OKKLLBBBPAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8D30810", Offset = "0x8D2F210", VA = "0x188D30810")]
	private void KOPNCLNOFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8D2F5B0", Offset = "0x8D2DFB0", VA = "0x188D2F5B0")]
	private void ILMHPMMOJMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8D2F060", Offset = "0x8D2DA60", VA = "0x188D2F060", Slot = "30")]
	public GIFDOEAHBPA HNAFJFOBHHG(int KABGMIEBEFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8D2F350", Offset = "0x8D2DD50", VA = "0x188D2F350", Slot = "98")]
	public void IEBALGDGBAK(GIFDOEAHBPA KMAFNKGMDCF, bool NFCKHMKCNGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8D2DDB0", Offset = "0x8D2C7B0", VA = "0x188D2DDB0", Slot = "99")]
	public void DNMIHIPMFPJ(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8D2C330", Offset = "0x8D2AD30", VA = "0x188D2C330", Slot = "100")]
	public void ANJHGHKAODE(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8D2D070", Offset = "0x8D2BA70", VA = "0x188D2D070", Slot = "101")]
	public Vector3 BOFPKOFOGEF(Vector3 HBCKENKNHBM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8D30080", Offset = "0x8D2EA80", VA = "0x188D30080", Slot = "102")]
	public Vector3 JLFPAOGPFMO(Vector3 PKCKKEIEJJG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8D2CA80", Offset = "0x8D2B480", VA = "0x188D2CA80", Slot = "103")]
	public void BGNNKMEGKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8D2FE70", Offset = "0x8D2E870", VA = "0x188D2FE70", Slot = "104")]
	public void JJJJNDBENCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8D30C60", Offset = "0x8D2F660", VA = "0x188D30C60", Slot = "105")]
	public void LAJLEHMLEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x8D30460", Offset = "0x8D2EE60", VA = "0x188D30460", Slot = "106")]
	public void KMMDEOGFIOG(Vector3 MCGFEPBEJMH, Vector3 JMHODIHNCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8D2FAA0", Offset = "0x8D2E4A0", VA = "0x188D2FAA0", Slot = "107")]
	public void JDKJPMDJMPC(Vector3 MPEGMNNICAA, Vector3 BGDJKDINADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x8D315E0", Offset = "0x8D2FFE0", VA = "0x188D315E0", Slot = "108")]
	public void MMADJBHMKAL(Vector3 ELDEDOKAACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8D2FCD0", Offset = "0x8D2E6D0", VA = "0x188D2FCD0", Slot = "109")]
	public void JGCLCKCNNIA(ILIKBONEJOO GPDAHHPDDKG, Vector3 ECAJAFJNDJO, float PLMCHHBJBJF, float LKIAJOBMEOM = 8f, float CKNNLHJFOKK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8D2D5D0", Offset = "0x8D2BFD0", VA = "0x188D2D5D0", Slot = "110")]
	public void CKDLJGADBGC(MPBOJIIMMCC NIOFENKCHOC, Vector3 DGNINMFNFAK, float ICLMNIBGAOB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8D30240", Offset = "0x8D2EC40", VA = "0x188D30240", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void KHIIONODKED(MPBOJIIMMCC NIOFENKCHOC, Vector3 AMHDLJKDJBK, float DIJFDBBAGON = 7f, float JADLGMEJNLI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8D2C3E0", Offset = "0x8D2ADE0", VA = "0x188D2C3E0", Slot = "112")]
	public Vector3 APJANGIKMKO(Vector3 KMAFNKGMDCF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8D2EEB0", Offset = "0x8D2D8B0", VA = "0x188D2EEB0", Slot = "113")]
	public Vector3 HKJIOEPIHLG(Vector3 KMAFNKGMDCF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8D2E450", Offset = "0x8D2CE50", VA = "0x188D2E450", Slot = "114")]
	public void FNLMDJNHPCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8D2F270", Offset = "0x8D2DC70", VA = "0x188D2F270", Slot = "115")]
	public void ICMPLOMBNCI(GIFDOEAHBPA KMIGKJKHCFM, object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8D2DD50", Offset = "0x8D2C750", VA = "0x188D2DD50", Slot = "116")]
	public void DLHPBEJDCGD(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8D30E80", Offset = "0x8D2F880", VA = "0x188D30E80", Slot = "63")]
	public void LKGGAPCDBAA((Quaternion rot, Vector3 moments) FPHHKNIAPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8D325D0", Offset = "0x8D30FD0", VA = "0x188D325D0", Slot = "117")]
	public void PEBJHMLKJCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8D2F220", Offset = "0x8D2DC20", VA = "0x188D2F220", Slot = "118")]
	public void IAFKMCKDEBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8D2D9E0", Offset = "0x8D2C3E0", VA = "0x188D2D9E0", Slot = "119")]
	public void CMKDBEHLHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8D30410", Offset = "0x8D2EE10", VA = "0x188D30410", Slot = "120")]
	public bool KKFLCFNHKBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8D30C10", Offset = "0x8D2F610", VA = "0x188D30C10", Slot = "97")]
	public void LACPEDJKBHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8D31B10", Offset = "0x8D30510", VA = "0x188D31B10", Slot = "121")]
	public void MNDIMBHHAOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8D2C1B0", Offset = "0x8D2ABB0", VA = "0x188D2C1B0", Slot = "122")]
	public void AEGKLGLDCBB(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8D31E10", Offset = "0x8D30810", VA = "0x188D31E10", Slot = "123")]
	public void OEOHIKGOKGN(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x8D2DBB0", Offset = "0x8D2C5B0", VA = "0x188D2DBB0", Slot = "124")]
	public void DIHDMBNDKJC(object MFKHKDDANII, bool JMGOCMABGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8D2F710", Offset = "0x8D2E110", VA = "0x188D2F710", Slot = "125")]
	public void JBFAKNCLACI(Vector3 MJBMEPCOMAJ, Quaternion BPFKODHFGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8D2DC20", Offset = "0x8D2C620", VA = "0x188D2DC20", Slot = "126")]
	public void DKBIEOOBEHA(Vector3 MLLJOKPHMGD, Quaternion JNEDEPPGFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8D32580", Offset = "0x8D30F80", VA = "0x188D32580", Slot = "127")]
	public bool PBGJDADAPEN(float NMALOKPPLFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8D2F550", Offset = "0x8D2DF50", VA = "0x188D2F550", Slot = "128")]
	public void ILEFJILMPAC(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8D2FA40", Offset = "0x8D2E440", VA = "0x188D2FA40", Slot = "129")]
	public void JCOHEJDLFKL(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8D2E210", Offset = "0x8D2CC10", VA = "0x188D2E210", Slot = "130")]
	public void FBKIHFOMNCB(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8D2CB70", Offset = "0x8D2B570", VA = "0x188D2CB70", Slot = "131")]
	public void BLEKJKOOFIB(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8D2D290", Offset = "0x8D2BC90", VA = "0x188D2D290", Slot = "132")]
	public void CIFOEHKDHAD(Vector3 KEJIJALNLAM, ForceMode KJEKHPEBEEH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8D32470", Offset = "0x8D30E70", VA = "0x188D32470", Slot = "133")]
	public void ONCJODFGKOD(Vector3 KEJIJALNLAM, Vector3 KFJFDPLEJOD, ForceMode KJEKHPEBEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8D2CBD0", Offset = "0x8D2B5D0", VA = "0x188D2CBD0", Slot = "134")]
	public void BMOOFAOLDJA(Vector3 BOIMOPECEPM, ForceMode KJEKHPEBEEH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8D2F910", Offset = "0x8D2E310", VA = "0x188D2F910", Slot = "135")]
	public void JBMHCGLJDMB(Vector3 BOIMOPECEPM, ForceMode KJEKHPEBEEH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8D32700", Offset = "0x8D31100", VA = "0x188D32700", Slot = "136")]
	public bool PPOFEJAAPPP(Vector3 HLNPPHJBENM, [Out] RaycastHit JMACOIIAFBO, float EFLCGLGNONM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8D2F670", Offset = "0x8D2E070", VA = "0x188D2F670", Slot = "137")]
	public void INHIAHKPLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8D327A0", Offset = "0x8D311A0", VA = "0x188D327A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8D322C0", Offset = "0x8D30CC0", VA = "0x188D322C0")]
	private void OLFGGJAKKEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8D312F0", Offset = "0x8D2FCF0", VA = "0x188D312F0")]
	private void MAKGICNLDMN(GIFDOEAHBPA AEMEEJKFKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8D2C840", Offset = "0x8D2B240", VA = "0x188D2C840")]
	private void BDDAEEFKMHC(GIFDOEAHBPA AEMEEJKFKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8D31B80", Offset = "0x8D30580", VA = "0x188D31B80")]
	private void MPIPCBDJGDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8D2D6D0", Offset = "0x8D2C0D0", VA = "0x188D2D6D0")]
	private void CKFIOKEEFMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8D2D3D0", Offset = "0x8D2BDD0", VA = "0x188D2D3D0")]
	private void CJMFFBDFKAG(GIFDOEAHBPA AMFLFGLLLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8D2D170", Offset = "0x8D2BB70", VA = "0x188D2D170")]
	private void CELDGJFPGDA(GIFDOEAHBPA AEMEEJKFKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8D2ED80", Offset = "0x8D2D780", VA = "0x188D2ED80")]
	private void HFFGMDBIPDK(GIFDOEAHBPA AEMEEJKFKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8D306C0", Offset = "0x8D2F0C0", VA = "0x188D306C0")]
	private void KOFDJEIAMFG(ANNBNLPJGPM AEMEEJKFKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8D316C0", Offset = "0x8D300C0", VA = "0x188D316C0", Slot = "142")]
	protected virtual void MMAKCODOLEN(ANNBNLPJGPM OPGHIHFJADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8D2C4E0", Offset = "0x8D2AEE0", VA = "0x188D2C4E0")]
	protected void BBHKKJCLBFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8D30890", Offset = "0x8D2F290", VA = "0x188D30890")]
	protected void KPLGNBEKBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8D30FC0", Offset = "0x8D2F9C0", VA = "0x188D30FC0")]
	private void LOLCCPOFDGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8D30550", Offset = "0x8D2EF50", VA = "0x188D30550")]
	private void KNGPEPDFOFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class LDNPBLCBLKG
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8D369E0", Offset = "0x8D353E0", VA = "0x188D369E0")]
	public static GIFDOEAHBPA MPBKMGDHOCM(this GIFDOEAHBPA OPGHIHFJADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8D36880", Offset = "0x8D35280", VA = "0x188D36880")]
	public static bool FMCACMDFBEB(this GIFDOEAHBPA OPGHIHFJADP, GIFDOEAHBPA KMBKKMFGMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8D367E0", Offset = "0x8D351E0", VA = "0x188D367E0")]
	public static bool BBNAMABDOHG(this GIFDOEAHBPA OPGHIHFJADP, GIFDOEAHBPA IBMCFNHBJIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8D36920", Offset = "0x8D35320", VA = "0x188D36920")]
	public static ANNBNLPJGPM INPMEKLDJEM(this GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8D36970", Offset = "0x8D35370", VA = "0x188D36970")]
	public static IGMOBNOOFLK MCAEALEBFGF(this GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BCKCKBHCNIC : HMDAGBBKBAG
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8D27640", Offset = "0x8D26040", VA = "0x188D27640", Slot = "19")]
	public GIFDOEAHBPA AKHBCKCEPDN(RigidbodyEx OPGHIHFJADP, BMDNLBHNEKE BLPDDGCLNPE, BMFCNNFCELK KFMMGFEJHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "4")]
	public MDNEHDFHFCK GMODEKLDKDL(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "5")]
	public FPLOPMDPNJN IDBODKHLGEO(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "6")]
	public ACCAHCKFOPM GGFNGENCNCH(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "7")]
	public IKKNGLPMJGB KPCMCFMLMCE(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "8")]
	public MDECIBJJMMG LLOGLIEGNMJ(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "9")]
	public ALADACOLBDI KOBBPIJOGOG(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "10")]
	public DBMJCLJAFLA KGDCGGENCEN(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "11")]
	public HKBGLIABNEF NDJANJICCAB(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "12")]
	public BFGDPDKKBDC DJPNCFMNEBI(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "13")]
	public ADCOCLEJBHN CIBNNIAKEDG(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570")]
	public CJMBACAMIIP BHLOHLDKLIN(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570")]
	public HKHDMOJBCDM MJEINGFCPEE(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570")]
	public MGCDAPEPIGD MNJDCEIDKMA(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570")]
	public CKMINPINJLL EBCJMOMOIOB(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570")]
	public OBCDAFKIDPL DMNKNDLNGBH(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public BCKCKBHCNIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "14")]
	private CJMBACAMIIP JEOKLLODIBG(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "15")]
	private HKHDMOJBCDM KHDMJIGIBCK(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "16")]
	private MGCDAPEPIGD PBMOBEPNBLD(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "17")]
	private CKMINPINJLL OFPIEPHCIJA(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "18")]
	private OBCDAFKIDPL OAAJFPMAKIC(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(HMDAGBBKBAG), new string[] { })]
public class EOOKNIILMPN : HMDAGBBKBAG, BOHILICPPOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly HMDAGBBKBAG MFILAHBGNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly HMDAGBBKBAG CLDGALIJMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private OCGDPOEPBCD IHLLGJEMFID;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private HMDAGBBKBAG EDNAGEADCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8D2A990", Offset = "0x8D29390", VA = "0x188D2A990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8D2AA90", Offset = "0x8D29490", VA = "0x188D2AA90", Slot = "20")]
	public void InitReferences(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A8F0", Offset = "0x8D292F0", VA = "0x188D2A8F0", Slot = "4")]
	public MDNEHDFHFCK GMODEKLDKDL(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A9F0", Offset = "0x8D293F0", VA = "0x188D2A9F0", Slot = "5")]
	public FPLOPMDPNJN IDBODKHLGEO(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A850", Offset = "0x8D29250", VA = "0x188D2A850", Slot = "6")]
	public ACCAHCKFOPM GGFNGENCNCH(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8D2ACD0", Offset = "0x8D296D0", VA = "0x188D2ACD0", Slot = "7")]
	public IKKNGLPMJGB KPCMCFMLMCE(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8D2AD70", Offset = "0x8D29770", VA = "0x188D2AD70", Slot = "8")]
	public MDECIBJJMMG LLOGLIEGNMJ(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8D2AC30", Offset = "0x8D29630", VA = "0x188D2AC30", Slot = "9")]
	public ALADACOLBDI KOBBPIJOGOG(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8D2AAE0", Offset = "0x8D294E0", VA = "0x188D2AAE0", Slot = "10")]
	public DBMJCLJAFLA KGDCGGENCEN(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8D2AEC0", Offset = "0x8D298C0", VA = "0x188D2AEC0", Slot = "11")]
	public HKBGLIABNEF NDJANJICCAB(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A650", Offset = "0x8D29050", VA = "0x188D2A650", Slot = "12")]
	public BFGDPDKKBDC DJPNCFMNEBI(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A5B0", Offset = "0x8D28FB0", VA = "0x188D2A5B0", Slot = "13")]
	public ADCOCLEJBHN CIBNNIAKEDG(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A500", Offset = "0x8D28F00", VA = "0x188D2A500")]
	public CJMBACAMIIP BHLOHLDKLIN(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8D2AB80", Offset = "0x8D29580", VA = "0x188D2AB80")]
	public HKHDMOJBCDM MJEINGFCPEE(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8D2AE10", Offset = "0x8D29810", VA = "0x188D2AE10")]
	public MGCDAPEPIGD MNJDCEIDKMA(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A7A0", Offset = "0x8D291A0", VA = "0x188D2A7A0")]
	public CKMINPINJLL EBCJMOMOIOB(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A6F0", Offset = "0x8D290F0", VA = "0x188D2A6F0")]
	public OBCDAFKIDPL DMNKNDLNGBH(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A420", Offset = "0x8D28E20", VA = "0x188D2A420", Slot = "19")]
	public GIFDOEAHBPA AKHBCKCEPDN(RigidbodyEx OPGHIHFJADP, BMDNLBHNEKE BLPDDGCLNPE, BMFCNNFCELK KFMMGFEJHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x8D2AF60", Offset = "0x8D29960", VA = "0x188D2AF60")]
	public EOOKNIILMPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A500", Offset = "0x8D28F00", VA = "0x188D2A500", Slot = "14")]
	private CJMBACAMIIP JEOKLLODIBG(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8D2AB80", Offset = "0x8D29580", VA = "0x188D2AB80", Slot = "15")]
	private HKHDMOJBCDM KHDMJIGIBCK(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8D2AE10", Offset = "0x8D29810", VA = "0x188D2AE10", Slot = "16")]
	private MGCDAPEPIGD PBMOBEPNBLD(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A7A0", Offset = "0x8D291A0", VA = "0x188D2A7A0", Slot = "17")]
	private CKMINPINJLL OFPIEPHCIJA(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A6F0", Offset = "0x8D290F0", VA = "0x188D2A6F0", Slot = "18")]
	private OBCDAFKIDPL OAAJFPMAKIC(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface DBACKGDAFHN : MDNEHDFHFCK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBDIIGPKEMJ(GIFDOEAHBPA OPGHIHFJADP);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOHEKDOPJMN(GIFDOEAHBPA OPGHIHFJADP);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EFLCEGMIFIJ(GIFDOEAHBPA AMFLFGLLLNF);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EJJDMICBABI(GIFDOEAHBPA AMFLFGLLLNF);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DGPBJBFNOAP : ACCAHCKFOPM
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	BCNGACGHJNM<GIFDOEAHBPA> NLJBONNGPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	GIFDOEAHBPA EKJDAMNEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface JBLJPIHCECM : CKMINPINJLL
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) CJHOFLMDHAF(Rigidbody HAJFEEJJBCF);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface HHGEFMODCHC : HKHDMOJBCDM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	RRNetworkView GANCFMNDAGF
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class AKLBMIBDJMP : BFGDPDKKBDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly IGMOBNOOFLK OPGHIHFJADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private CollisionDetectionMode CFLILNMMELO;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody LFNIPFIPBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8D271D0", Offset = "0x8D25BD0", VA = "0x188D271D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode PHKMHGCLFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8D270C0", Offset = "0x8D25AC0", VA = "0x188D270C0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8D26FB0", Offset = "0x8D259B0", VA = "0x188D26FB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x8D275B0", Offset = "0x8D25FB0", VA = "0x188D275B0")]
	public AKLBMIBDJMP(GIFDOEAHBPA OPGHIHFJADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x8D27220", Offset = "0x8D25C20", VA = "0x188D27220", Slot = "6")]
	public void JEALAPEIAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x8D27040", Offset = "0x8D25A40", VA = "0x188D27040", Slot = "9")]
	public void FIOCJLGFJAL(Rigidbody ELBJAFIJOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x8D27030", Offset = "0x8D25A30", VA = "0x188D27030", Slot = "7")]
	public void FAHDIEEEIPB(bool MBOJGJOFHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x8D27020", Offset = "0x8D25A20", VA = "0x188D27020", Slot = "8")]
	public void DNLNDHJHCCH(bool MBOJGJOFHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x8D27450", Offset = "0x8D25E50", VA = "0x188D27450", Slot = "10")]
	public bool PPOFEJAAPPP(Vector3 HLNPPHJBENM, [Out] RaycastHit JMACOIIAFBO, float EFLCGLGNONM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x8D27330", Offset = "0x8D25D30", VA = "0x188D27330")]
	private void KLEOFJFMMBL(bool MBOJGJOFHGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class KGJGGHDFHJM : ALADACOLBDI, IDisposable, MFMLODIOEBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly IGMOBNOOFLK OPGHIHFJADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private FMHNBNKGEEA CINOGNHKMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private APPPHJAKOPF CJHFIJOKNOM;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public FMHNBNKGEEA EMHMEMCBIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8D339F0", Offset = "0x8D323F0", VA = "0x188D339F0", Slot = "6")]
		get
		{
			return default(FMHNBNKGEEA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8D33820", Offset = "0x8D32220", VA = "0x188D33820", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform MFBMOABIMGB
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xE6EBC0", Offset = "0xE6D5C0", VA = "0x180E6EBC0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<ACOJACDAJIP, ACOJACDAJIP> GNOBOLCEDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8D33DA0", Offset = "0x8D327A0", VA = "0x188D33DA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8D338F0", Offset = "0x8D322F0", VA = "0x188D338F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x8D33E50", Offset = "0x8D32850", VA = "0x188D33E50")]
	public KGJGGHDFHJM(GIFDOEAHBPA OPGHIHFJADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x8D33B30", Offset = "0x8D32530", VA = "0x188D33B30", Slot = "8")]
	public void JEALAPEIAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x8D339A0", Offset = "0x8D323A0", VA = "0x188D339A0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x13BA580", Offset = "0x13B8F80", VA = "0x1813BA580", Slot = "11")]
	private void EOMHFKCECOM(ACOJACDAJIP KBLNLHCDNNB, ACOJACDAJIP GHJCHGJCFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "12")]
	private void ENAGCKFGNJL(bool JCIGGBOEPEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class GDDMFEOJMIH : HMDAGBBKBAG
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8D2B7C0", Offset = "0x8D2A1C0", VA = "0x188D2B7C0", Slot = "4")]
	public MDNEHDFHFCK GMODEKLDKDL(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8D2B8B0", Offset = "0x8D2A2B0", VA = "0x188D2B8B0", Slot = "5")]
	public FPLOPMDPNJN IDBODKHLGEO(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8D2B690", Offset = "0x8D2A090", VA = "0x188D2B690", Slot = "6")]
	public ACCAHCKFOPM GGFNGENCNCH(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8D2BD50", Offset = "0x8D2A750", VA = "0x188D2BD50", Slot = "7")]
	public IKKNGLPMJGB KPCMCFMLMCE(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x8D2BDD0", Offset = "0x8D2A7D0", VA = "0x188D2BDD0", Slot = "8")]
	public MDECIBJJMMG LLOGLIEGNMJ(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8D2BC80", Offset = "0x8D2A680", VA = "0x188D2BC80", Slot = "9")]
	public ALADACOLBDI KOBBPIJOGOG(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8D2B9D0", Offset = "0x8D2A3D0", VA = "0x188D2B9D0", Slot = "10")]
	public DBMJCLJAFLA KGDCGGENCEN(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8D2BFD0", Offset = "0x8D2A9D0", VA = "0x188D2BFD0", Slot = "11")]
	public HKBGLIABNEF NDJANJICCAB(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8D2B360", Offset = "0x8D29D60", VA = "0x188D2B360", Slot = "12")]
	public BFGDPDKKBDC DJPNCFMNEBI(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8D2B2A0", Offset = "0x8D29CA0", VA = "0x188D2B2A0", Slot = "13")]
	public ADCOCLEJBHN CIBNNIAKEDG(GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8D2B160", Offset = "0x8D29B60", VA = "0x188D2B160")]
	public CJMBACAMIIP BHLOHLDKLIN(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8D2BAF0", Offset = "0x8D2A4F0", VA = "0x188D2BAF0")]
	public HKHDMOJBCDM MJEINGFCPEE(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8D2BEA0", Offset = "0x8D2A8A0", VA = "0x188D2BEA0")]
	public MGCDAPEPIGD MNJDCEIDKMA(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8D2B500", Offset = "0x8D29F00", VA = "0x188D2B500")]
	public CKMINPINJLL EBCJMOMOIOB(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8D2B420", Offset = "0x8D29E20", VA = "0x188D2B420")]
	public OBCDAFKIDPL DMNKNDLNGBH(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8D2B010", Offset = "0x8D29A10", VA = "0x188D2B010", Slot = "19")]
	public GIFDOEAHBPA AKHBCKCEPDN(RigidbodyEx OPGHIHFJADP, BMDNLBHNEKE BLPDDGCLNPE, BMFCNNFCELK KFMMGFEJHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public GDDMFEOJMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8D2B160", Offset = "0x8D29B60", VA = "0x188D2B160", Slot = "14")]
	private CJMBACAMIIP JEOKLLODIBG(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8D2BAF0", Offset = "0x8D2A4F0", VA = "0x188D2BAF0", Slot = "15")]
	private HKHDMOJBCDM KHDMJIGIBCK(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8D2BEA0", Offset = "0x8D2A8A0", VA = "0x188D2BEA0", Slot = "16")]
	private MGCDAPEPIGD PBMOBEPNBLD(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8D2B500", Offset = "0x8D29F00", VA = "0x188D2B500", Slot = "17")]
	private CKMINPINJLL OFPIEPHCIJA(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8D2B420", Offset = "0x8D29E20", VA = "0x188D2B420", Slot = "18")]
	private OBCDAFKIDPL OAAJFPMAKIC(GIFDOEAHBPA FDMAPEJEBGO, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class OPAAIMKPMCI : HKBGLIABNEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly IGMOBNOOFLK OPGHIHFJADP;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody LFNIPFIPBBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8D271D0", Offset = "0x8D25BD0", VA = "0x188D271D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool DPDLMKLLGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C270", Offset = "0x8D3AC70", VA = "0x188D3C270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool CDGODCGHBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B330", Offset = "0x8D39D30", VA = "0x188D3B330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private GIFDOEAHBPA AJFLBGMINPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C2C0", Offset = "0x8D3ACC0", VA = "0x188D3C2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8D275B0", Offset = "0x8D25FB0", VA = "0x188D275B0")]
	public OPAAIMKPMCI(GIFDOEAHBPA OPGHIHFJADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8D3BEB0", Offset = "0x8D3A8B0", VA = "0x188D3BEB0", Slot = "4")]
	public void CIFOEHKDHAD(Vector3 KEJIJALNLAM, ForceMode KJEKHPEBEEH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8D3C800", Offset = "0x8D3B200", VA = "0x188D3C800")]
	private void PHBJKKAGMLI(Vector3 KEJIJALNLAM, ForceMode KJEKHPEBEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x8D3C580", Offset = "0x8D3AF80", VA = "0x188D3C580", Slot = "5")]
	public void ONCJODFGKOD(Vector3 KEJIJALNLAM, Vector3 KFJFDPLEJOD, ForceMode KJEKHPEBEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x8D3BD50", Offset = "0x8D3A750", VA = "0x188D3BD50", Slot = "6")]
	public void BMOOFAOLDJA(Vector3 BOIMOPECEPM, ForceMode KJEKHPEBEEH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8D3C010", Offset = "0x8D3AA10", VA = "0x188D3C010")]
	private void FHJIIKCJKEM(Vector3 BOIMOPECEPM, ForceMode KJEKHPEBEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8D3C320", Offset = "0x8D3AD20", VA = "0x188D3C320", Slot = "7")]
	public void JBMHCGLJDMB(Vector3 BOIMOPECEPM, ForceMode KJEKHPEBEEH = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class JOGCHFHACON : ADCOCLEJBHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly IGMOBNOOFLK OPGHIHFJADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool AIBDJMBFJLP;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool EFDEBDPIPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xB36DB0", Offset = "0xB357B0", VA = "0x180B36DB0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8D336A0", Offset = "0x8D320A0", VA = "0x188D336A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8D275B0", Offset = "0x8D25FB0", VA = "0x188D275B0")]
	public JOGCHFHACON(GIFDOEAHBPA OPGHIHFJADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x8D33670", Offset = "0x8D32070", VA = "0x188D33670", Slot = "6")]
	public void FIOCJLGFJAL(Rigidbody ELBJAFIJOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x8D337B0", Offset = "0x8D321B0", VA = "0x188D337B0", Slot = "7")]
	public void JPIGHADADLL(Rigidbody ELBJAFIJOCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class CCEKANIGKOJ : DBACKGDAFHN, MDNEHDFHFCK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly GIFDOEAHBPA OPGHIHFJADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly List<GIFDOEAHBPA> GJKKECFLMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private GIFDOEAHBPA FAIGKPPBFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private GIFDOEAHBPA AEMEEJKFKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private Transform NLOJNOAIBPH;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform AJEDGAAHNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8D28330", Offset = "0x8D26D30", VA = "0x188D28330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public GIFDOEAHBPA AJFLBGMINPD
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8D27840", Offset = "0x8D26240", VA = "0x188D27840", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public GIFDOEAHBPA GLKLCNOCKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<GIFDOEAHBPA> NHJJODDGEBF
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event PGINMDCPPIJ JKMJOEIKEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8D28430", Offset = "0x8D26E30", VA = "0x188D28430", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8D29100", Offset = "0x8D27B00", VA = "0x188D29100", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event PGINMDCPPIJ HKKGGLPNLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8D28A50", Offset = "0x8D27450", VA = "0x188D28A50", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8D27A90", Offset = "0x8D26490", VA = "0x188D27A90", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event JJNGNENMLJJ GCHNFJIEJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8D28AF0", Offset = "0x8D274F0", VA = "0x188D28AF0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8D276E0", Offset = "0x8D260E0", VA = "0x188D276E0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action EIAABMBKIHL
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8D28F80", Offset = "0x8D27980", VA = "0x188D28F80", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8D27B30", Offset = "0x8D26530", VA = "0x188D27B30", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action MFKGFOAHCNH
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8D27C70", Offset = "0x8D26670", VA = "0x188D27C70", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8D28390", Offset = "0x8D26D90", VA = "0x188D28390", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<GIFDOEAHBPA> EMPCJEBNCEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8D28B90", Offset = "0x8D27590", VA = "0x188D28B90", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8D291A0", Offset = "0x8D27BA0", VA = "0x188D291A0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<GIFDOEAHBPA> PGAIIKOMHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8D28E20", Offset = "0x8D27820", VA = "0x188D28E20", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8D28ED0", Offset = "0x8D278D0", VA = "0x188D28ED0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action IPLMMNCNCOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8D29020", Offset = "0x8D27A20", VA = "0x188D29020", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8D29430", Offset = "0x8D27E30", VA = "0x188D29430", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<GIFDOEAHBPA> IILPBMPKJNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8D28C40", Offset = "0x8D27640", VA = "0x188D28C40", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8D27850", Offset = "0x8D26250", VA = "0x188D27850", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x8D294D0", Offset = "0x8D27ED0", VA = "0x188D294D0")]
	public CCEKANIGKOJ(GIFDOEAHBPA OPGHIHFJADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x8D27BD0", Offset = "0x8D265D0", VA = "0x188D27BD0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x8D284D0", Offset = "0x8D26ED0", VA = "0x188D284D0", Slot = "30")]
	public void IEBALGDGBAK(GIFDOEAHBPA CCBBLDBOMGE, bool NFCKHMKCNGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x8D27D10", Offset = "0x8D26710", VA = "0x188D27D10", Slot = "6")]
	public void EFLCEGMIFIJ(GIFDOEAHBPA AMFLFGLLLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x8D27F80", Offset = "0x8D26980", VA = "0x188D27F80", Slot = "7")]
	public void EJJDMICBABI(GIFDOEAHBPA AMFLFGLLLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8D279A0", Offset = "0x8D263A0", VA = "0x188D279A0", Slot = "4")]
	public void CBDIIGPKEMJ(GIFDOEAHBPA OPGHIHFJADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x8D27900", Offset = "0x8D26300", VA = "0x188D27900", Slot = "5")]
	public void BOHEKDOPJMN(GIFDOEAHBPA OPGHIHFJADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x8D29250", Offset = "0x8D27C50", VA = "0x188D29250")]
	private void PCIDKBNDJDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x8D290C0", Offset = "0x8D27AC0", VA = "0x188D290C0")]
	private void MKEMLEHEOCH(GIFDOEAHBPA AMFLFGLLLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x8D292F0", Offset = "0x8D27CF0", VA = "0x188D292F0")]
	private void PENBPHGHKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x8D28200", Offset = "0x8D26C00", VA = "0x188D28200")]
	private void FJBJFGCNMLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x8D28CF0", Offset = "0x8D276F0", VA = "0x188D28CF0")]
	private void KPHLLAJMDHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x8D27780", Offset = "0x8D26180", VA = "0x188D27780")]
	[CompilerGenerated]
	private object AGMABBPILOB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class IOHCNJEGDCN
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x8D328D0", Offset = "0x8D312D0", VA = "0x188D328D0")]
	public static DBACKGDAFHN KNPLINAIFGD(this GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class ELEPEDKDJAK : DGPBJBFNOAP, ACCAHCKFOPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly IGMOBNOOFLK OPGHIHFJADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly BCNGACGHJNM<GIFDOEAHBPA> FFPGJLDNPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool OINKEKBNMPA;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public BCNGACGHJNM<GIFDOEAHBPA> NLJBONNGPNF
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 FIFLACCEFFK
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8D29660", Offset = "0x8D28060", VA = "0x188D29660", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 AMHKJCKDPPN
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8D298F0", Offset = "0x8D282F0", VA = "0x188D298F0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 OPBKGMDLBFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8D29690", Offset = "0x8D28090", VA = "0x188D29690")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public GIFDOEAHBPA EKJDAMNEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8D29770", Offset = "0x8D28170", VA = "0x188D29770", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x8D2A320", Offset = "0x8D28D20", VA = "0x188D2A320")]
	public ELEPEDKDJAK(GIFDOEAHBPA OPGHIHFJADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x8D29880", Offset = "0x8D28280", VA = "0x188D29880", Slot = "8")]
	public void EBDMBOFJIAH(GIFDOEAHBPA AEMEEJKFKNN, object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x8D29820", Offset = "0x8D28220", VA = "0x188D29820", Slot = "9")]
	public void DNCAJMFANIP(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x8D29F80", Offset = "0x8D28980", VA = "0x188D29F80")]
	private Vector3 MLOAJFOLIPC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x8D29BF0", Offset = "0x8D285F0", VA = "0x188D29BF0")]
	private void HJOAFONDENE(GIFDOEAHBPA JEBLAEGHNKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class AJBBACCBPFL
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8D26EF0", Offset = "0x8D258F0", VA = "0x188D26EF0")]
	public static DGPBJBFNOAP BCDCOLHAPLP(this GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class KMPDFPAJDKA : JBLJPIHCECM, CKMINPINJLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IGMOBNOOFLK OPGHIHFJADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly OverridableVector3 MFBACALNCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 IGMAEHILBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private float LKFOHOGKNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float JEMLCPLEHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private Vector3 EGCEEHODFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3? HLKAHPEJGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Quaternion? PFDDJKNAFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private bool OFLLKEKALEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool IOEFDILHLLJ;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 BIBEEELBBND
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1961890", Offset = "0x1960290", VA = "0x181961890", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8D35170", Offset = "0x8D33B70", VA = "0x188D35170", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 DMPACHBPOJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8D36230", Offset = "0x8D34C30", VA = "0x188D36230", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float AJAKBBEPOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xE96F40", Offset = "0xE95940", VA = "0x180E96F40", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D36120", Offset = "0x8D34B20", VA = "0x188D36120")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float CNAKECDMPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xD84490", Offset = "0xD82E90", VA = "0x180D84490", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8D35430", Offset = "0x8D33E30", VA = "0x188D35430", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 ICPJGPOABEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8D35960", Offset = "0x8D34360", VA = "0x188D35960", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion DNBENHGJNAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8D34FF0", Offset = "0x8D339F0", VA = "0x188D34FF0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody LFNIPFIPBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8D353E0", Offset = "0x8D33DE0", VA = "0x188D353E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event PGINMDCPPIJ GIBCGGAIBIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8D36320", Offset = "0x8D34D20", VA = "0x188D36320", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8D35E50", Offset = "0x8D34850", VA = "0x188D35E50", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8D36680", Offset = "0x8D35080", VA = "0x188D36680")]
	public KMPDFPAJDKA(GIFDOEAHBPA OPGHIHFJADP, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8D36560", Offset = "0x8D34F60", VA = "0x188D36560", Slot = "17")]
	public void PEBJHMLKJCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8D35300", Offset = "0x8D33D00", VA = "0x188D35300", Slot = "16")]
	public void IAFKMCKDEBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8D35220", Offset = "0x8D33C20", VA = "0x188D35220", Slot = "19")]
	public void FIOCJLGFJAL(Rigidbody ELBJAFIJOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8D35AF0", Offset = "0x8D344F0", VA = "0x188D35AF0", Slot = "20")]
	public void JPIGHADADLL(Rigidbody ELBJAFIJOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8D34E50", Offset = "0x8D33850", VA = "0x188D34E50", Slot = "18")]
	public void CMKDBEHLHLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8D354E0", Offset = "0x8D33EE0", VA = "0x188D354E0", Slot = "21")]
	public void INHIAHKPLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8D35170", Offset = "0x8D33B70", VA = "0x188D35170")]
	private void DMIHHLFPCHM(Vector3 KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8D34D60", Offset = "0x8D33760", VA = "0x188D34D60")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 CLCKMNLIKFP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8D36120", Offset = "0x8D34B20", VA = "0x188D36120")]
	private void MBGPLCBIJHL(float KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8D35430", Offset = "0x8D33E30", VA = "0x188D35430")]
	private void IKPHBBNPLFD(float KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8D363C0", Offset = "0x8D34DC0", VA = "0x188D363C0")]
	private Vector3 NFJPBONOKHD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8D35EF0", Offset = "0x8D348F0", VA = "0x188D35EF0", Slot = "15")]
	public void LKGGAPCDBAA((Quaternion rot, Vector3 moments) FPHHKNIAPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8D35CD0", Offset = "0x8D346D0", VA = "0x188D35CD0")]
	private Quaternion KCHPPHKOJPD()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8D33EE0", Offset = "0x8D328E0", VA = "0x188D33EE0")]
	public void CJHOFLMDHAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8D33FB0", Offset = "0x8D329B0", VA = "0x188D33FB0", Slot = "4")]
	public (float, Vector3) CJHOFLMDHAF(Rigidbody HAJFEEJJBCF)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class OBJADGBBJJF
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8D3BA60", Offset = "0x8D3A460", VA = "0x188D3BA60")]
	public static JBLJPIHCECM KBENFMPMPIE(this GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class PPMCDDBIKOA : MGCDAPEPIGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly IGMOBNOOFLK OPGHIHFJADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly GBIFDHMBLCB CMOHIHJOHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly ILMFIJFBGOM FFDCMGDPJAK;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool PMDAMFIFDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1B38F40", Offset = "0x1B37940", VA = "0x181B38F40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public ILMFIJFBGOM ALNCFHODKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380", Slot = "11")]
		get
		{
			return default(ILMFIJFBGOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8D3DA90", Offset = "0x8D3C490", VA = "0x188D3DA90")]
	public PPMCDDBIKOA(GIFDOEAHBPA OPGHIHFJADP, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D990", Offset = "0x8D3C390", VA = "0x188D3D990", Slot = "4")]
	public void JEALAPEIAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D620", Offset = "0x8D3C020", VA = "0x188D3D620")]
	private bool GBLGGAMKOLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D6C0", Offset = "0x8D3C0C0", VA = "0x188D3D6C0", Slot = "5")]
	public void GIAMPAOGMCN(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8D3DA60", Offset = "0x8D3C460", VA = "0x188D3DA60", Slot = "6")]
	public void PJOKGNNFCLI(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D810", Offset = "0x8D3C210", VA = "0x188D3D810", Slot = "9")]
	public void GNAADEJODMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D6F0", Offset = "0x8D3C0F0", VA = "0x188D3D6F0")]
	private void GKHENGBEMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D460", Offset = "0x8D3BE60", VA = "0x188D3D460")]
	private void AOGPFPJMHBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D950", Offset = "0x8D3C350", VA = "0x188D3D950", Slot = "8")]
	public void IKLJLIGNGMN(GIFDOEAHBPA OPGHIHFJADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D5E0", Offset = "0x8D3BFE0", VA = "0x188D3D5E0", Slot = "7")]
	public void CGIDDFADLKK(GIFDOEAHBPA OPGHIHFJADP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class PDGDJJBPMGJ : DBMJCLJAFLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly IGMOBNOOFLK OPGHIHFJADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly GBIFDHMBLCB JAKLJLICLGJ;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool DPDLMKLLGFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CF10", Offset = "0x8D3B910", VA = "0x188D3CF10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event PGINMDCPPIJ FBLJFEAKDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D000", Offset = "0x8D3BA00", VA = "0x188D3D000", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CDF0", Offset = "0x8D3B7F0", VA = "0x188D3CDF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D0A0", Offset = "0x8D3BAA0", VA = "0x188D3D0A0")]
	public PDGDJJBPMGJ(GIFDOEAHBPA OPGHIHFJADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8D3CC90", Offset = "0x8D3B690", VA = "0x188D3CC90", Slot = "7")]
	public void AEGKLGLDCBB(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x8D3CFF0", Offset = "0x8D3B9F0", VA = "0x188D3CFF0", Slot = "8")]
	public void OEOHIKGOKGN(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8D3CCA0", Offset = "0x8D3B6A0", VA = "0x188D3CCA0", Slot = "9")]
	public void DIHDMBNDKJC(object MFKHKDDANII, bool JMGOCMABGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x8D3CDB0", Offset = "0x8D3B7B0", VA = "0x188D3CDB0", Slot = "12")]
	public void DKKLNDPLIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x8D3CE90", Offset = "0x8D3B890", VA = "0x188D3CE90", Slot = "10")]
	public void FIOCJLGFJAL(Rigidbody CAOCACBOIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x8D3CFC0", Offset = "0x8D3B9C0", VA = "0x188D3CFC0", Slot = "11")]
	public void JPIGHADADLL(Rigidbody ELBJAFIJOCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class JNKIDNKFOML : HHGEFMODCHC, HKHDMOJBCDM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly IGMOBNOOFLK OPGHIHFJADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private RRNetworkView GDCMHMJHJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private bool OJADMLHAKBJ;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public RRNetworkView GANCFMNDAGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool JCPKGNGOBOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8D32E10", Offset = "0x8D31810", VA = "0x188D32E10", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool DCJPCDJNIHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xC5E960", Offset = "0xC5D360", VA = "0x180C5E960", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event PGINMDCPPIJ EPHOAKNPHDO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8D33330", Offset = "0x8D31D30", VA = "0x188D33330", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8D32B00", Offset = "0x8D31500", VA = "0x188D32B00", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8D33520", Offset = "0x8D31F20", VA = "0x188D33520")]
	public JNKIDNKFOML(GIFDOEAHBPA OPGHIHFJADP, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x8D33200", Offset = "0x8D31C00", VA = "0x188D33200", Slot = "9")]
	public void JEALAPEIAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x8D32D10", Offset = "0x8D31710", VA = "0x188D32D10", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x8D32BA0", Offset = "0x8D315A0", VA = "0x188D32BA0", Slot = "10")]
	public void CELDGJFPGDA(GIFDOEAHBPA AEMEEJKFKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x8D33090", Offset = "0x8D31A90", VA = "0x188D33090", Slot = "11")]
	public void HFFGMDBIPDK(GIFDOEAHBPA AEMEEJKFKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x8D32990", Offset = "0x8D31390", VA = "0x188D32990")]
	private void ACDGPNENIAH(RRNetworkView JDFEIAJKEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x8D333D0", Offset = "0x8D31DD0", VA = "0x188D333D0")]
	private void OGNDFAFKLND(ANNBNLPJGPM GOFAGEOPLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x8D32E20", Offset = "0x8D31820", VA = "0x188D32E20")]
	private void GKNEFDIMACI(RRNetworkView FFJCCDAKFDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class GLABCEIJFOK
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x8D2C090", Offset = "0x8D2AA90", VA = "0x188D2C090")]
	public static HHGEFMODCHC DLDDPBMFJKH(this GIFDOEAHBPA FDMAPEJEBGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class OMMDHKPBCDH : OBCDAFKIDPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly IGMOBNOOFLK OPGHIHFJADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private RigidbodyConstraints IJBEKBPICAE;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool BGFNOMAKOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xB7AFD0", Offset = "0xB799D0", VA = "0x180B7AFD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xEC7F80", Offset = "0xEC6980", VA = "0x180EC7F80", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool IDNPCENDDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xB7B030", Offset = "0xB79A30", VA = "0x180B7B030", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xEC7F90", Offset = "0xEC6990", VA = "0x180EC7F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints KCECLKHHDJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8D3BB50", Offset = "0x8D3A550", VA = "0x188D3BB50", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x8D3BCB0", Offset = "0x8D3A6B0", VA = "0x188D3BCB0")]
	public OMMDHKPBCDH(GIFDOEAHBPA OPGHIHFJADP, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x8D3BB20", Offset = "0x8D3A520", VA = "0x188D3BB20", Slot = "9")]
	public void FIOCJLGFJAL(Rigidbody ELBJAFIJOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x8D3BC80", Offset = "0x8D3A680", VA = "0x188D3BC80", Slot = "10")]
	public void JPIGHADADLL(Rigidbody ELBJAFIJOCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class PPFKEFMJDMF : IKKNGLPMJGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly GIFDOEAHBPA OPGHIHFJADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private float OCHHEAADHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float INLOFGGNMAB;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float OBIIGODIOGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xB05990", Offset = "0xB04390", VA = "0x180B05990", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D1E0", Offset = "0x8D3BBE0", VA = "0x188D3D1E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float FNGOOOIJEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xB059A0", Offset = "0xB043A0", VA = "0x180B059A0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D350", Offset = "0x8D3BD50", VA = "0x188D3D350", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D420", Offset = "0x8D3BE20", VA = "0x188D3D420")]
	public PPFKEFMJDMF(GIFDOEAHBPA OPGHIHFJADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D190", Offset = "0x8D3BB90", VA = "0x188D3D190", Slot = "8")]
	public void FIOCJLGFJAL(Rigidbody ELBJAFIJOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x8D3D2B0", Offset = "0x8D3BCB0", VA = "0x188D3D2B0", Slot = "9")]
	public void JPIGHADADLL(Rigidbody ELBJAFIJOCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class MDLNPMPEGDD : MDECIBJJMMG
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly OLFEOKKCIEG HBBJMFHEHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly IGMOBNOOFLK OPGHIHFJADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private bool IDBDGELPLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool DMHMMPCKDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int GGHAJNEJNFI;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody LFNIPFIPBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8D353E0", Offset = "0x8D33DE0", VA = "0x188D353E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool PIOHMLELOAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A7B0", Offset = "0x8D391B0", VA = "0x188D3A7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private GIFDOEAHBPA AJFLBGMINPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A750", Offset = "0x8D39150", VA = "0x188D3A750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool CDGODCGHBAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A560", Offset = "0x8D38F60", VA = "0x188D3A560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event PGINMDCPPIJ JNOGJPGDPEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AD40", Offset = "0x8D39740", VA = "0x188D3AD40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A4C0", Offset = "0x8D38EC0", VA = "0x188D3A4C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8D3B050", Offset = "0x8D39A50", VA = "0x188D3B050")]
	public MDLNPMPEGDD(GIFDOEAHBPA OPGHIHFJADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8D3A900", Offset = "0x8D39300", VA = "0x188D3A900", Slot = "6")]
	public void JEALAPEIAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x8D3AFB0", Offset = "0x8D399B0", VA = "0x188D3AFB0", Slot = "8")]
	public void PEOCEDLEMAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8D3AB50", Offset = "0x8D39550", VA = "0x188D3AB50", Slot = "7")]
	public bool KKFLCFNHKBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x8D3ACA0", Offset = "0x8D396A0", VA = "0x188D3ACA0", Slot = "9")]
	public void LACPEDJKBHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8D3ADE0", Offset = "0x8D397E0", VA = "0x188D3ADE0", Slot = "13")]
	public void MNDIMBHHAOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8D3AE80", Offset = "0x8D39880", VA = "0x188D3AE80", Slot = "12")]
	public void OKKLLBBBPAJ(bool DMBPPMAIPDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8D3A890", Offset = "0x8D39290", VA = "0x188D3A890", Slot = "10")]
	public bool JDDNKALIHME()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8D3A7D0", Offset = "0x8D391D0", VA = "0x188D3A7D0", Slot = "11")]
	public bool ILMHPMMOJMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8D3A990", Offset = "0x8D39390", VA = "0x188D3A990")]
	private bool KBDEKFPGFNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8D3A5C0", Offset = "0x8D38FC0", VA = "0x188D3A5C0")]
	private void FPKCOOJCJPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class MFIFMLKAEPG : CJMBACAMIIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly IGMOBNOOFLK OPGHIHFJADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly GBIFDHMBLCB ENNCIDKLJLO;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody LFNIPFIPBBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool CDGODCGHBAH
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B330", Offset = "0x8D39D30", VA = "0x188D3B330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool ONIHDGIFOCH
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1B38F40", Offset = "0x1B37940", VA = "0x181B38F40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8D3B950", Offset = "0x8D3A350", VA = "0x188D3B950")]
	public MFIFMLKAEPG(GIFDOEAHBPA OPGHIHFJADP, [In] BMDNLBHNEKE BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8D3B8B0", Offset = "0x8D3A2B0", VA = "0x188D3B8B0", Slot = "5")]
	public void JEALAPEIAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x8D3B300", Offset = "0x8D39D00", VA = "0x188D3B300", Slot = "7")]
	public void FBKIHFOMNCB(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x8D3B150", Offset = "0x8D39B50", VA = "0x188D3B150", Slot = "8")]
	public void BLEKJKOOFIB(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8D3B580", Offset = "0x8D39F80", VA = "0x188D3B580", Slot = "9")]
	public void HLNGMFADIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8D3B390", Offset = "0x8D39D90", VA = "0x188D3B390", Slot = "10")]
	public void GNIDFDKCBLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x8D3B180", Offset = "0x8D39B80", VA = "0x188D3B180", Slot = "11")]
	public void EDLKJGGGNGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class LKIEIEPKPBI : FPLOPMDPNJN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly IGMOBNOOFLK OPGHIHFJADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly GBIFDHMBLCB MIEFHAJNGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private float GFOEKPBFPMM;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public DNNEGEPPCEJ NOHOGNPFBCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CGLIKLHAHPB NDMOFMEBCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 OPBKGMDLBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8D37090", Offset = "0x8D35A90", VA = "0x188D37090", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A030", Offset = "0x8D38A30", VA = "0x188D3A030", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 OCEPNBECDIO
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8D383D0", Offset = "0x8D36DD0", VA = "0x188D383D0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A0F0", Offset = "0x8D38AF0", VA = "0x188D3A0F0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 BEJKHPCMANK
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8D37700", Offset = "0x8D36100", VA = "0x188D37700", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8D382F0", Offset = "0x8D36CF0", VA = "0x188D382F0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 JKJEPGLHIAC
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8D37250", Offset = "0x8D35C50", VA = "0x188D37250", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8D39CD0", Offset = "0x8D386D0", VA = "0x188D39CD0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float FNELBDCMICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xB05AA0", Offset = "0xB044A0", VA = "0x180B05AA0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8D39480", Offset = "0x8D37E80", VA = "0x188D39480", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool PFPMNLHFNCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2592F80", Offset = "0x2591980", VA = "0x182592F80", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private HKBGLIABNEF AHCJCPAELKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x822E920", Offset = "0x822D320", VA = "0x18822E920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool PIOHMLELOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8D383B0", Offset = "0x8D36DB0", VA = "0x188D383B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x8D3A2C0", Offset = "0x8D38CC0", VA = "0x188D3A2C0")]
	public LKIEIEPKPBI(GIFDOEAHBPA OPGHIHFJADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8D36B80", Offset = "0x8D35580", VA = "0x188D36B80", Slot = "19")]
	public void JEALAPEIAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x8D373E0", Offset = "0x8D35DE0", VA = "0x188D373E0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8D37440", Offset = "0x8D35E40", VA = "0x188D37440", Slot = "28")]
	public void FIOCJLGFJAL(Rigidbody ELBJAFIJOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x18EA7C0", Offset = "0x18E91C0", VA = "0x1818EA7C0", Slot = "20")]
	public void GHBMFGKPHEP(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x18EBE90", Offset = "0x18EA890", VA = "0x1818EBE90", Slot = "30")]
	public void AEMMBDMIOCA(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8D36C30", Offset = "0x8D35630", VA = "0x188D36C30", Slot = "35")]
	public Vector3 BOFPKOFOGEF(Vector3 HBCKENKNHBM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8D392C0", Offset = "0x8D37CC0", VA = "0x188D392C0", Slot = "34")]
	public Vector3 JLFPAOGPFMO(Vector3 PKCKKEIEJJG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x8D36B80", Offset = "0x8D35580", VA = "0x188D36B80", Slot = "27")]
	public void BGNNKMEGKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8D39260", Offset = "0x8D37C60", VA = "0x188D39260", Slot = "25")]
	public void JJJJNDBENCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8D39C70", Offset = "0x8D38670", VA = "0x188D39C70", Slot = "24")]
	public void LAJLEHMLEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x8D39A30", Offset = "0x8D38430", VA = "0x188D39A30", Slot = "33")]
	public void KMMDEOGFIOG(Vector3 MCGFEPBEJMH, Vector3 JMHODIHNCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8D38B50", Offset = "0x8D37550", VA = "0x188D38B50", Slot = "32")]
	public void JDKJPMDJMPC(Vector3 MPEGMNNICAA, Vector3 BGDJKDINADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8D39D00", Offset = "0x8D38700", VA = "0x188D39D00", Slot = "31")]
	public void MMADJBHMKAL(Vector3 ELDEDOKAACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x8D38BB0", Offset = "0x8D375B0", VA = "0x188D38BB0", Slot = "22")]
	public void JGCLCKCNNIA(ILIKBONEJOO GPDAHHPDDKG, Vector3 ECAJAFJNDJO, float PLMCHHBJBJF, float LKIAJOBMEOM = 8f, float CKNNLHJFOKK = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8D36E10", Offset = "0x8D35810", VA = "0x188D36E10", Slot = "21")]
	public void CKDLJGADBGC(MPBOJIIMMCC NIOFENKCHOC, Vector3 DGNINMFNFAK, float ICLMNIBGAOB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8D39590", Offset = "0x8D37F90", VA = "0x188D39590", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void KHIIONODKED(MPBOJIIMMCC NIOFENKCHOC, Vector3 AMHDLJKDJBK, float DIJFDBBAGON = 7f, float JADLGMEJNLI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x1A49A30", Offset = "0x1A48430", VA = "0x181A49A30")]
	private static void KHAIGMPOPIB(Vector3 GMOGCJLCJBF, Vector3 BJGHDDIMDNJ, [Out] Vector3 LPGDAIAAFIP, [Out] Vector3 NIJLDGDAPNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8D36AA0", Offset = "0x8D354A0", VA = "0x188D36AA0", Slot = "29")]
	public Vector3 APJANGIKMKO(Vector3 GMOGCJLCJBF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8D37570", Offset = "0x8D35F70", VA = "0x188D37570", Slot = "26")]
	public void FNLMDJNHPCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8D39480", Offset = "0x8D37E80", VA = "0x188D39480")]
	private void LECAHIONNOP(float KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x8D3A120", Offset = "0x8D38B20", VA = "0x188D3A120")]
	private void PMBOOELDBNL(Vector3 DGNINMFNFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x8D38550", Offset = "0x8D36F50", VA = "0x188D38550")]
	private Vector3 IKOKPKJNGEO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8D37E70", Offset = "0x8D36870", VA = "0x188D37E70")]
	private void GEHOEMFLKDN(Vector3 PKCKKEIEJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8D39EA0", Offset = "0x8D388A0", VA = "0x188D39EA0")]
	private Vector3 OAACKNNBMOM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x8D386D0", Offset = "0x8D370D0", VA = "0x188D386D0")]
	private void IPOPJNJFBEH(Vector3 KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8D378D0", Offset = "0x8D362D0", VA = "0x188D378D0")]
	private void FOOKDFPADNI(Vector3 PKCKKEIEJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8D39980", Offset = "0x8D38380", VA = "0x188D39980")]
	private void KHMPMHHFBJH()
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
