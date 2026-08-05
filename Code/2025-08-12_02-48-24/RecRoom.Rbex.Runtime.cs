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
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8C9B110", Offset = "0x8C99710", VA = "0x188C9B110", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8623C50", Offset = "0x8622250", VA = "0x188623C50", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8CA70E0", Offset = "0x8CA56E0", VA = "0x188CA70E0")]
		private void DHALDHDBNEP(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8CA73F0", Offset = "0x8CA59F0", VA = "0x188CA73F0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8CA7450", Offset = "0x8CA5A50", VA = "0x188CA7450")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, FFEDAAPDFJC, AAJMNAIDLEH, NFDMFLCLDKG
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly IDGHEFJHGEI KCKOMKAMMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool DDCKILLHJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private PLDICLLJPJP DFMENEBFAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[MKKFIBEOMHP(BMGFACECMPD.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[MKKFIBEOMHP(BMGFACECMPD.SelfAndParent, true, false, false)]
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
		private DJKEJGBLBEI physicsInterpolation;

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
		private Transform HNGLPJEGNPF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal PLDICLLJPJP EGGOLHOFHFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8CA29C0", Offset = "0x8CA0FC0", VA = "0x188CA29C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private PLDICLLJPJP DJJMAMAELJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int KGPMDALJGCO
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8CA45F0", Offset = "0x8CA2BF0", VA = "0x188CA45F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx FELCKEMBGBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4950", Offset = "0x8CA2F50", VA = "0x188CA4950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx KFENKPOKOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4890", Offset = "0x8CA2E90", VA = "0x188CA4890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx IGDHFGFJBMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5550", Offset = "0x8CA3B50", VA = "0x188CA5550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6A50", Offset = "0x8CA5050", VA = "0x188CA6A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool MLKJKKPIIAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x88A88C0", Offset = "0x88A6EC0", VA = "0x1888A88C0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x88A6890", Offset = "0x88A4E90", VA = "0x1888A6890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform JAHKFPBBGHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2540150", Offset = "0x253E750", VA = "0x182540150", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform CDECFEHCEKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2540150", Offset = "0x253E750", VA = "0x182540150", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform PFJFLENGLLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2540150", Offset = "0x253E750", VA = "0x182540150", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MMEGJHMINAN OFBLHGPDGCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4650", Offset = "0x8CA2C50", VA = "0x188CA4650")]
			get
			{
				return default(MMEGJHMINAN);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6200", Offset = "0x8CA4800", VA = "0x188CA6200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool HEKMOFNACBN
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4C60", Offset = "0x8CA3260", VA = "0x188CA4C60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool BNBDFJENCAD
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4770", Offset = "0x8CA2D70", VA = "0x188CA4770")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GMILAJLHIHL GHNHKBGKCPE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4BA0", Offset = "0x8CA31A0", VA = "0x188CA4BA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8CA63C0", Offset = "0x8CA49C0", VA = "0x188CA63C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public CAFAOJANFEB IADNEHFBALF
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4B40", Offset = "0x8CA3140", VA = "0x188CA4B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6350", Offset = "0x8CA4950", VA = "0x188CA6350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GGNDCMPEAJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4A90", Offset = "0x8CA3090", VA = "0x188CA4A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody CLHIEGMEABN
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4AF0", Offset = "0x8CA30F0", VA = "0x188CA4AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool CCPFHDGJAOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8CA47D0", Offset = "0x8CA2DD0", VA = "0x188CA47D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6270", Offset = "0x8CA4870", VA = "0x188CA6270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PPBGKJPBHFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1068290", Offset = "0x1066890", VA = "0x181068290", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float EFHOLEINOIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8CA54F0", Offset = "0x8CA3AF0", VA = "0x188CA54F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float CJLHMOPKCKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5490", Offset = "0x8CA3A90", VA = "0x188CA5490")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8CA69E0", Offset = "0x8CA4FE0", VA = "0x188CA69E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float KAAAMHOCBNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4EC0", Offset = "0x8CA34C0", VA = "0x188CA4EC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6660", Offset = "0x8CA4C60", VA = "0x188CA6660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float LFAINPAOKPB
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4CC0", Offset = "0x8CA32C0", VA = "0x188CA4CC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6430", Offset = "0x8CA4A30", VA = "0x188CA6430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool KIDPFJDELFG
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5AA0", Offset = "0x8CA40A0", VA = "0x188CA5AA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6F90", Offset = "0x8CA5590", VA = "0x188CA6F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 HMHODBKOENA
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5270", Offset = "0x8CA3870", VA = "0x188CA5270")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8CA67B0", Offset = "0x8CA4DB0", VA = "0x188CA67B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 NLGGHMLFBKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5BE0", Offset = "0x8CA41E0", VA = "0x188CA5BE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode MOIEGEEHFBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4E00", Offset = "0x8CA3400", VA = "0x188CA4E00")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6580", Offset = "0x8CA4B80", VA = "0x188CA6580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float MPNFMFDJKGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4830", Offset = "0x8CA2E30", VA = "0x188CA4830")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8CA62E0", Offset = "0x8CA48E0", VA = "0x188CA62E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints DEJICCKHMKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4E60", Offset = "0x8CA3460", VA = "0x188CA4E60")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8CA65F0", Offset = "0x8CA4BF0", VA = "0x188CA65F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 COFPCKLEHIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5610", Offset = "0x8CA3C10", VA = "0x188CA5610")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 BBAMNPFHOGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5610", Offset = "0x8CA3C10", VA = "0x188CA5610")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6D70", Offset = "0x8CA5370", VA = "0x188CA6D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float FHGHMAANLMC
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5350", Offset = "0x8CA3950", VA = "0x188CA5350")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6890", Offset = "0x8CA4E90", VA = "0x188CA6890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float HBCNDGFGJHA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5A40", Offset = "0x8CA4040", VA = "0x188CA5A40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6F20", Offset = "0x8CA5520", VA = "0x188CA6F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion AKKIDDGDPBE
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8CA56F0", Offset = "0x8CA3CF0", VA = "0x188CA56F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6AF0", Offset = "0x8CA50F0", VA = "0x188CA6AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion GBCPIPHPNMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5970", Offset = "0x8CA3F70", VA = "0x188CA5970")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6E50", Offset = "0x8CA5450", VA = "0x188CA6E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 BPHFIGGIEBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8CA57C0", Offset = "0x8CA3DC0", VA = "0x188CA57C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6BC0", Offset = "0x8CA51C0", VA = "0x188CA6BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion POAOPEHNMHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8CA58A0", Offset = "0x8CA3EA0", VA = "0x188CA58A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6CA0", Offset = "0x8CA52A0", VA = "0x188CA6CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 NCEIMCLGMCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5B00", Offset = "0x8CA4100", VA = "0x188CA5B00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8CA7000", Offset = "0x8CA5600", VA = "0x188CA7000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 ECJAEJHHBNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8CA53B0", Offset = "0x8CA39B0", VA = "0x188CA53B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6900", Offset = "0x8CA4F00", VA = "0x188CA6900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 EHALKHPCJIA
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4D20", Offset = "0x8CA3320", VA = "0x188CA4D20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8CA64A0", Offset = "0x8CA4AA0", VA = "0x188CA64A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 MPFAFOAJOIH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5190", Offset = "0x8CA3790", VA = "0x188CA5190")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8CA66D0", Offset = "0x8CA4CD0", VA = "0x188CA66D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 JFAHPEHHCEG
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5050", Offset = "0x8CA3650", VA = "0x188CA5050")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion EGBMJDKPNIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4F80", Offset = "0x8CA3580", VA = "0x188CA4F80")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 MKAIFBMINCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5DA0", Offset = "0x8CA43A0", VA = "0x188CA5DA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 AMNPDABMODI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5CC0", Offset = "0x8CA42C0", VA = "0x188CA5CC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool MPKAGAKAHMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5130", Offset = "0x8CA3730", VA = "0x188CA5130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool KGAPCBCJLHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4C00", Offset = "0x8CA3200", VA = "0x188CA4C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool PLENCFJBOCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4710", Offset = "0x8CA2D10", VA = "0x188CA4710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool AIIEPILKLLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8CA46B0", Offset = "0x8CA2CB0", VA = "0x188CA46B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool CDAHPKKLMEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4590", Offset = "0x8CA2B90", VA = "0x188CA4590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool IMKEFELCOLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4F20", Offset = "0x8CA3520", VA = "0x188CA4F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool MMNPCHICOFF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x27379A0", Offset = "0x2735FA0", VA = "0x1827379A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event CJEGOOJGBEM FLMKCBNCIFE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8CA44B0", Offset = "0x8CA2AB0", VA = "0x188CA44B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6120", Offset = "0x8CA4720", VA = "0x188CA6120")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event OICGOOGFDLN JJKHKPBNKIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4220", Offset = "0x8CA2820", VA = "0x188CA4220")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5E80", Offset = "0x8CA4480", VA = "0x188CA5E80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event OICGOOGFDLN NHJNLCICBMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4280", Offset = "0x8CA2880", VA = "0x188CA4280")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5EF0", Offset = "0x8CA44F0", VA = "0x188CA5EF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event OICGOOGFDLN ECGHOCKKCMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8CA43D0", Offset = "0x8CA29D0", VA = "0x188CA43D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6040", Offset = "0x8CA4640", VA = "0x188CA6040")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<JGCNGACGAAH, JGCNGACGAAH> MFJELJEDPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4360", Offset = "0x8CA2960", VA = "0x188CA4360")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5FD0", Offset = "0x8CA45D0", VA = "0x188CA5FD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event OICGOOGFDLN FJEPNLNEJOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4440", Offset = "0x8CA2A40", VA = "0x188CA4440")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8CA60B0", Offset = "0x8CA46B0", VA = "0x188CA60B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event OICGOOGFDLN GMFFIDCGHID
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8CA4520", Offset = "0x8CA2B20", VA = "0x188CA4520")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8CA6190", Offset = "0x8CA4790", VA = "0x188CA6190")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event OICGOOGFDLN HLLCPJOLMPI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8CA42F0", Offset = "0x8CA28F0", VA = "0x188CA42F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8CA5F60", Offset = "0x8CA4560", VA = "0x188CA5F60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70", Slot = "8")]
		private void EHCMFFKOMEH(PLDICLLJPJP FCFHEFKEJPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2D30", Offset = "0x8CA1330", VA = "0x188CA2D30", Slot = "9")]
		public HAPFNJKACCD GetData()
		{
			return default(HAPFNJKACCD);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2750", Offset = "0x8CA0D50", VA = "0x188CA2750")]
		internal void CAMILNCAPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3F40", Offset = "0x8CA2540", VA = "0x188CA3F40")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody GACCHOIDNLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2A80", Offset = "0x8CA1080", VA = "0x188CA2A80")]
		public FFEDAAPDFJC GetChild(int LEPAEEGOBDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3C00", Offset = "0x8CA2200", VA = "0x188CA3C00")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) ALGBGLDGENP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2580", Offset = "0x8CA0B80", VA = "0x188CA2580")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3E90", Offset = "0x8CA2490", VA = "0x188CA3E90")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8CA29C0", Offset = "0x8CA0FC0", VA = "0x188CA29C0")]
		private PLDICLLJPJP MAAEIDAFAIG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3310", Offset = "0x8CA1910", VA = "0x188CA3310")]
		private void PNHKIAJGEDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3250", Offset = "0x8CA1850", VA = "0x188CA3250")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3190", Offset = "0x8CA1790", VA = "0x188CA3190")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2750", Offset = "0x8CA0D50", VA = "0x188CA2750")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8CA31F0", Offset = "0x8CA17F0", VA = "0x188CA31F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8CA32B0", Offset = "0x8CA18B0", VA = "0x188CA32B0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8CA1BD0", Offset = "0x8CA01D0", VA = "0x188CA1BD0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object HNGIMMGBLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3490", Offset = "0x8CA1A90", VA = "0x188CA3490")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object HNGIMMGBLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2960", Offset = "0x8CA0F60", VA = "0x188CA2960")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3130", Offset = "0x8CA1730", VA = "0x188CA3130")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3D60", Offset = "0x8CA2360", VA = "0x188CA3D60")]
		public void SetParent(RigidbodyEx FKMNCAKIOFK, bool EAPOMGLHHCP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8CA37A0", Offset = "0x8CA1DA0", VA = "0x188CA37A0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2DC0", Offset = "0x8CA13C0", VA = "0x188CA2DC0")]
		public bool IsRigidbodyAncestor(RigidbodyEx FMGFBCOJOON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2EC0", Offset = "0x8CA14C0", VA = "0x188CA2EC0")]
		public bool IsRigidbodyDescendant(RigidbodyEx KCHLDHAPLAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8CA1E40", Offset = "0x8CA0440", VA = "0x188CA1E40")]
		public void AddInterpolationRestriction(object HNGIMMGBLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3500", Offset = "0x8CA1B00", VA = "0x188CA3500")]
		public void RemoveInterpolationRestriction(object HNGIMMGBLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8CA1EB0", Offset = "0x8CA04B0", VA = "0x188CA1EB0")]
		public void AddKinematic(object HNGIMMGBLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3570", Offset = "0x8CA1B70", VA = "0x188CA3570")]
		public void RemoveKinematic(object HNGIMMGBLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3CE0", Offset = "0x8CA22E0", VA = "0x188CA3CE0")]
		public void SetKinematic(object HNGIMMGBLII, bool DHIOOCFCCAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3B00", Offset = "0x8CA2100", VA = "0x188CA3B00")]
		public void SetDiscontinuousPositionAndRotation(Vector3 CMNDAAHGGNG, Quaternion CCFILMDIOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3A00", Offset = "0x8CA2000", VA = "0x188CA3A00")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 MMOFCAILDPO, Quaternion HNJFMDBMALE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2C20", Offset = "0x8CA1220", VA = "0x188CA2C20")]
		public Vector3 GetConstrainedVelocity(Vector3 NCEIMCLGMCB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2B10", Offset = "0x8CA1110", VA = "0x188CA2B10")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 EHALKHPCJIA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8CA1D50", Offset = "0x8CA0350", VA = "0x188CA1D50")]
		public void AddForce(Vector3 MKJGBAFLMBJ, ForceMode LLLMFFEODME = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8CA1C40", Offset = "0x8CA0240", VA = "0x188CA1C40")]
		public void AddForceAtPosition(Vector3 MKJGBAFLMBJ, Vector3 AANGPKCDGHO, ForceMode LLLMFFEODME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2080", Offset = "0x8CA0680", VA = "0x188CA2080")]
		public void AddTorque(Vector3 CLJPODDAMOF, ForceMode LLLMFFEODME = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8CA1F20", Offset = "0x8CA0520", VA = "0x188CA1F20")]
		public void AddRelativeTorque(Vector3 CLJPODDAMOF, ForceMode LLLMFFEODME = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8CA4010", Offset = "0x8CA2610", VA = "0x188CA4010")]
		public Vector3 WorldToLocalVelocity(Vector3 AOFGNGADMDL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3020", Offset = "0x8CA1620", VA = "0x188CA3020")]
		public Vector3 LocalToWorldVelocity(Vector3 ECJAEJHHBNF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2900", Offset = "0x8CA0F00", VA = "0x188CA2900")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8CA28A0", Offset = "0x8CA0EA0", VA = "0x188CA28A0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2840", Offset = "0x8CA0E40", VA = "0x188CA2840")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8CA27E0", Offset = "0x8CA0DE0", VA = "0x188CA27E0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3900", Offset = "0x8CA1F00", VA = "0x188CA3900")]
		public void ResetVelocityWorldSpace(Vector3 PHJHLLDKOJF, Vector3 DPFKBGCGGPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3800", Offset = "0x8CA1E00", VA = "0x188CA3800")]
		public void ResetVelocityLocalSpace(Vector3 LOHJNHEMLOP, Vector3 MPFAFOAJOIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8CA36C0", Offset = "0x8CA1CC0", VA = "0x188CA36C0")]
		public void ResetLinearVelocityLocalSpace(Vector3 LOHJNHEMLOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3EA0", Offset = "0x8CA24A0", VA = "0x188CA3EA0")]
		public bool SweepTest(Vector3 FANJPCNJGDA, [Out] RaycastHit JKJAABNABOH, float LHLABDNDDPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2FC0", Offset = "0x8CA15C0", VA = "0x188CA2FC0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3E30", Offset = "0x8CA2430", VA = "0x188CA3E30")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3FB0", Offset = "0x8CA25B0", VA = "0x188CA3FB0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2010", Offset = "0x8CA0610", VA = "0x188CA2010")]
		public void AddShouldHaveUnityRigidbodyToken(object HNGIMMGBLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8CA35E0", Offset = "0x8CA1BE0", VA = "0x188CA35E0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object HNGIMMGBLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2410", Offset = "0x8CA0A10", VA = "0x188CA2410")]
		public void ApplyForceVelocityChange(MILMBLMNICG IOFMKIHBING, Vector3 CGEBBGCIENO, float EPAAIIHMNGB, float EHJKHHAKCNE = 8f, float BCAICAPEAID = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2310", Offset = "0x8CA0910", VA = "0x188CA2310")]
		public void ApplyAngularVelocityChange(AJEKPFKLAEG KCELOENKKEK, Vector3 OEJOJNFFOKK, float CDOHNMIAGPG = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8CA24D0", Offset = "0x8CA0AD0", VA = "0x188CA24D0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(AJEKPFKLAEG KCELOENKKEK, Vector3 NEOIPHFFLHF, float LCJCHDBLDCK = 7f, float FELCNEKKNNF = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2240", Offset = "0x8CA0840", VA = "0x188CA2240")]
		public bool AllowedScaleChange(float DFPGIFAKBHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2170", Offset = "0x8CA0770", VA = "0x188CA2170")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx CFPPCACOMOG, object HNGIMMGBLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8CA3650", Offset = "0x8CA1C50", VA = "0x188CA3650")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object HNGIMMGBLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8CA2A70", Offset = "0x8CA1070", VA = "0x188CA2A70", Slot = "13")]
		private void GJABPHKDLGC(BECEKGEMHAB HHPFOCCGJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8CA41B0", Offset = "0x8CA27B0", VA = "0x188CA41B0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xB4AA30", Offset = "0xB49030", VA = "0x180B4AA30", Slot = "4")]
		private GameObject OCGNMKNPJKN()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAC1BD0", Offset = "0xAC01D0", VA = "0x180AC1BD0", Slot = "10")]
		private bool AOHMGIEGEBD()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class NJFCGPPBGKP
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8CA0DD0", Offset = "0x8C9F3D0", VA = "0x188CA0DD0")]
	public static PLDICLLJPJP EGGOLHOFHFO(this RigidbodyEx IJBOEHJOLPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(IHKOCNIDNCO), new string[] { })]
public class ADACICMIDIG : IHKOCNIDNCO, DPFKFJLGBCO
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly IDGHEFJHGEI FEFALLLFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private BJFMAPGJELN KEBEIAGOJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private PEMPFLGBFOB ADHHBCIGKAK;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BJFMAPGJELN AJBOAIOJBCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public PEMPFLGBFOB EDAEJDJPIHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8C8AD70", Offset = "0x8C89370", VA = "0x188C8AD70", Slot = "7")]
	public void InitReferences(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8C8AC40", Offset = "0x8C89240", VA = "0x188C8AC40", Slot = "6")]
	public PLDICLLJPJP DGBMGKAIBJJ(RigidbodyEx IJBOEHJOLPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public ADACICMIDIG()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static HBPNKKOKOOA UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int GEHPKHPOFNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int DFKCKJAKGFL;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8CA1A30", Offset = "0x8CA0030", VA = "0x188CA1A30")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8CA1A70", Offset = "0x8CA0070", VA = "0x188CA1A70")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8CA1A50", Offset = "0x8CA0050", VA = "0x188CA1A50")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string IFEHDCDCFPK, [Optional] UnityEngine.Object HHPFOCCGJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string IFEHDCDCFPK, [Optional] UnityEngine.Object HHPFOCCGJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8CA1B80", Offset = "0x8CA0180", VA = "0x188CA1B80")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class COMNLDNEKLK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class LBFNGDBJFMJ : GMILAJLHIHL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xAA5B60", Offset = "0xAA4160", VA = "0x180AA5B60", Slot = "4")]
		public Vector3 HOEMJAMGLAN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xAA5B60", Offset = "0xAA4160", VA = "0x180AA5B60", Slot = "5")]
		public Vector3 BHEDMPCICNL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "6")]
		public bool KOCEHMKAPIH(float OALKIIAHIOB, float IEPIOJNAPKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public LBFNGDBJFMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static GMILAJLHIHL FBBMGKIFPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8C940A0", Offset = "0x8C926A0", VA = "0x188C940A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BLFDBJKOFAP
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode INDJBNAOLNH
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
	void IPAAAFNGFFP();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BPNBOAJCIHB(bool MPKAGAKAHMM);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBIDAGEELEE(bool MPKAGAKAHMM);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DFCOIFJKDHH(Rigidbody LGAEALOIBKG);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NNBGLIOEJNK(Vector3 FANJPCNJGDA, [Out] RaycastHit JKJAABNABOH, float LHLABDNDDPG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FLAPDHHOOOF : IDisposable, LNDEJGNNFBO
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	MMEGJHMINAN OFBLHGPDGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<JGCNGACGAAH, JGCNGACGAAH> MFJELJEDPMJ;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPAAAFNGFFP();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface PEMPFLGBFOB
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LGOAKADPMHP BCEKNECOPEP(PLDICLLJPJP FCFHEFKEJPB);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NPMNJKMFHED LHHJIEHAFCB(PLDICLLJPJP FCFHEFKEJPB);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KAHJDDJMFJK LODDEEADKLM(PLDICLLJPJP FCFHEFKEJPB);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ICFCJEOGKBH ALHOCANFGPD(PLDICLLJPJP FCFHEFKEJPB);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HDEFBLMJDIC OGCEPGHFDMH(PLDICLLJPJP FCFHEFKEJPB);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FLAPDHHOOOF AKACOBJJKKF(PLDICLLJPJP FCFHEFKEJPB);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BOAFDABLKEJ AOIHOJPPICJ(PLDICLLJPJP FCFHEFKEJPB);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OOAJDKPDCGI FKPAIOLFFMC(PLDICLLJPJP FCFHEFKEJPB);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BLFDBJKOFAP FNFLINMCBGN(PLDICLLJPJP FCFHEFKEJPB);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JDKCHCHAHCH BLNICCHMKKG(PLDICLLJPJP FCFHEFKEJPB);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HNNFBOBCKAA HCBNAADGDEA(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KAGNOCNDELF AEMAODGFMMK(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	BGFKPDEBMLI NHKDDDGENCL(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GPMCHLMMEPF NENHCEKOOGJ(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CNKLEFKBHPH BOPJMMCAKGP(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	PLDICLLJPJP DGBMGKAIBJJ(RigidbodyEx IJBOEHJOLPI, HAPFNJKACCD DAJAOHIJHHL, IHKOCNIDNCO BIAJFLEJGFD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OOAJDKPDCGI
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAHAIGFAGKH(Vector3 MKJGBAFLMBJ, ForceMode LLLMFFEODME = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHHLLAIOPOO(Vector3 MKJGBAFLMBJ, Vector3 AANGPKCDGHO, ForceMode LLLMFFEODME);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEJFHACKMHM(Vector3 CLJPODDAMOF, ForceMode LLLMFFEODME = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ANPPPLFDIHO(Vector3 CLJPODDAMOF, ForceMode LLLMFFEODME = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JDKCHCHAHCH
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool EIHMNFIPHPF
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
	void DFCOIFJKDHH(Rigidbody LGAEALOIBKG);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ODEPCPHAJKB(Rigidbody LGAEALOIBKG);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LGOAKADPMHP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<PLDICLLJPJP> IDPBBHKDDNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	PLDICLLJPJP KFENKPOKOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	PLDICLLJPJP DHPGFGLBJLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event OICGOOGFDLN JJKHKPBNKIK;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event OICGOOGFDLN NHJNLCICBMB;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event CJEGOOJGBEM MKFINJCHJMK;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action OABBIEIKEKA;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action PECDPFAOMMD;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<PLDICLLJPJP> MJDEEAPICED;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<PLDICLLJPJP> LMBBJEFDELG;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action DBGNAGLOPAC;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<PLDICLLJPJP> GCCAOLMIALA;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MBGDBGDPEAA(PLDICLLJPJP GHOEBAIBIJA, bool EAPOMGLHHCP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KAHJDDJMFJK
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 IIJIBBGLIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 INODLPFDIBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EFFGNEIFOGH(PLDICLLJPJP IGDHFGFJBMG, object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KHAHHAILDGM(object HNGIMMGBLII);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GPMCHLMMEPF
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 GLMKMJCCMFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 DNILPNFLHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float NJLFNJHOGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float FOBMOJJLBHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 PEKCLGMLGCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion DHIIINIAGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event OICGOOGFDLN DBCFGLGIEAN;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CEJCFBDIFHI((Quaternion rot, Vector3 moments) ALGBGLDGENP);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MAOPACCHBPE();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OHKMNDOPGAB();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DBEFIDEPKFJ();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DFCOIFJKDHH(Rigidbody LGAEALOIBKG);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ODEPCPHAJKB(Rigidbody LGAEALOIBKG);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void APDJCIBGIJM();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BGFKPDEBMLI
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPAAAFNGFFP();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INMCFPMNNCE(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JHLHACFPCMJ(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HLDEHJHDEFG(PLDICLLJPJP IJBOEHJOLPI);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LGMDNOJJMEI(PLDICLLJPJP IJBOEHJOLPI);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IPLDOBNDFMA();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BOAFDABLKEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool MCNFPMEGDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event OICGOOGFDLN MFLBPACFDJN;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ONLHPHHECIP(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DGNOOINKJNB(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BJEFIKGNLAO(object HNGIMMGBLII, bool DHIOOCFCCAJ);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DFCOIFJKDHH(Rigidbody JBKOGKCDDOF);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ODEPCPHAJKB(Rigidbody LGAEALOIBKG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KAGNOCNDELF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool HEKMOFNACBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool BNBDFJENCAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event OICGOOGFDLN FMPAJDHFJFA;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPAAAFNGFFP();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KAEMEIPDGOB(PLDICLLJPJP IGDHFGFJBMG);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ADLPKEDLIEF(PLDICLLJPJP IGDHFGFJBMG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CNKLEFKBHPH
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool CCPFHDGJAOH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool FABMDJHCNGI
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints OKJBFKCHAKK
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
	void DFCOIFJKDHH(Rigidbody LGAEALOIBKG);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ODEPCPHAJKB(Rigidbody LGAEALOIBKG);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ICFCJEOGKBH
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float PMANGOFGHII
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float ONJNNFJBIMC
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
	void DFCOIFJKDHH(Rigidbody LGAEALOIBKG);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ODEPCPHAJKB(Rigidbody LGAEALOIBKG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HDEFBLMJDIC
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool CJONFADKGHD;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event OICGOOGFDLN DEMIOKNLJCO;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IPAAAFNGFFP();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LPKIDOLJMEI();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPEDNLNNOFG();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MFIKAIGMEOM();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NGHBJPCKDCC();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HHHMLDEGGOE();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IDKFKBHMBNP(bool JGGJDFHIBCH);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HNKCBEMPAEE();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HNNFBOBCKAA
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody CLHIEGMEABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool GEMDHGOGNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPAAAFNGFFP();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HMMOKBBCAPF(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OCGIEAAEOMB(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CIJFLOMMIBN();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NPMNJKMFHED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	GMILAJLHIHL GHNHKBGKCPE
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	CAFAOJANFEB IADNEHFBALF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 HJDKOMOPEEB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 LOBPBIDCCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 AOPBBIIEBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 DBCICGFIPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float MPNFMFDJKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool GGNDCMPEAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IPAAAFNGFFP();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MCAOMLPFNNL(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JHFAPBDGALA(AJEKPFKLAEG KCELOENKKEK, Vector3 OEJOJNFFOKK, float CDOHNMIAGPG = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EKFCJPEDPKI(MILMBLMNICG IOFMKIHBING, Vector3 CGEBBGCIENO, float EPAAIIHMNGB, float EHJKHHAKCNE = 8f, float BCAICAPEAID = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LFCBDCAHKHC(AJEKPFKLAEG KCELOENKKEK, Vector3 NEOIPHFFLHF, float LCJCHDBLDCK = 7f, float FELCNEKKNNF = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ICFFCJEMLOL();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void PEIEDHEIIDL();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JHFDPCGJHMO();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void LELKILHBIMM();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DFCOIFJKDHH(Rigidbody LGAEALOIBKG);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 IHMJIAJEBDO(Vector3 NCEIMCLGMCB);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NMIJBGAIDDB(object HNGIMMGBLII);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void CAOIBOCPLFB(Vector3 NIGGFNPPODK);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NGAHBCOFFOH(Vector3 LOHJNHEMLOP, Vector3 MPFAFOAJOIH);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void HFNJMCGIBDL(Vector3 PHJHLLDKOJF, Vector3 DPFKBGCGGPA);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 KLMGPDGEODJ(Vector3 ECJAEJHHBNF);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 MBADFDKJKOF(Vector3 AOFGNGADMDL);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface BJFMAPGJELN
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool DMIAJNBLEFA
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KLAKHFCAMAA(string GJJJIJGCEEO);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGAILOPOHKF(RigidbodyEx IJBOEHJOLPI, Action CBDPHPPPDFI);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FNKHPMOHMOL EBFIPDNAPEF(int AICHOBBFINJ);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BGHKHHBLAJF(Vector3 NLGGHMLFBKA, float EEGNHPFODFO, Color ONDGBPEOGJF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface IHKOCNIDNCO
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	BJFMAPGJELN AJBOAIOJBCO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	PEMPFLGBFOB EDAEJDJPIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PLDICLLJPJP DGBMGKAIBJJ(RigidbodyEx IJBOEHJOLPI);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class CGIBJHLBEOL : PLDICLLJPJP, IDisposable, DLFCPJIPOGI
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool DIHGAJJPBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly IHKOCNIDNCO BIAJFLEJGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal LGOAKADPMHP OFEABOHNFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal BGFKPDEBMLI GJHNJBJJBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal KAGNOCNDELF LGLHEBBKPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal NPMNJKMFHED NCEIMCLGMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal KAHJDDJMFJK AFMKCMKONDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal GPMCHLMMEPF HFHCHIIKLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal ICFCJEOGKBH EANDKANPPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal JDKCHCHAHCH EBOEDCODNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal HDEFBLMJDIC LOAHOAKJCLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal FLAPDHHOOOF HGDJBDOFHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal BOAFDABLKEJ BJOFBOKDGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal OOAJDKPDCGI MKJGBAFLMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal CNKLEFKBHPH LFNOKCEPMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal HNNFBOBCKAA LGAEALOIBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal BLFDBJKOFAP HCAMMEEHGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable GLEBOGEEDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool CHKILIPPOKO;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public JPDMABGMGFC CBLBADGPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "22")]
		get
		{
			return default(JPDMABGMGFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public FFEDAAPDFJC DOBFHBMCOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xB65DA0", Offset = "0xB643A0", VA = "0x180B65DA0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xB65E50", Offset = "0xB64450", VA = "0x180B65E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject OKIANKCJMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA9F180", Offset = "0xA9D780", VA = "0x180A9F180", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA9F110", Offset = "0xA9D710", VA = "0x180A9F110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform ADNKINOHCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xB66230", Offset = "0xB64830", VA = "0x180B66230", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xB66210", Offset = "0xB64810", VA = "0x180B66210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody CLHIEGMEABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8C91970", Offset = "0x8C8FF70", VA = "0x188C91970", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public PLDICLLJPJP DHPGFGLBJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8C92140", Offset = "0x8C90740", VA = "0x188C92140", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8C91FC0", Offset = "0x8C905C0", VA = "0x188C91FC0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int KGPMDALJGCO
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8C8EDF0", Offset = "0x8C8D3F0", VA = "0x188C8EDF0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public PLDICLLJPJP KFENKPOKOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8C915E0", Offset = "0x8C8FBE0", VA = "0x188C915E0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool HGAPFBEBFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8C93460", Offset = "0x8C91A60", VA = "0x188C93460", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool HEKMOFNACBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8C8D900", Offset = "0x8C8BF00", VA = "0x188C8D900", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool BNBDFJENCAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E3A0", Offset = "0x8C8C9A0", VA = "0x188C8E3A0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public GMILAJLHIHL GHNHKBGKCPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8C8FB80", Offset = "0x8C8E180", VA = "0x188C8FB80", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8C8F500", Offset = "0x8C8DB00", VA = "0x188C8F500", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public CAFAOJANFEB IADNEHFBALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8C8FBD0", Offset = "0x8C8E1D0", VA = "0x188C8FBD0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8C8FA40", Offset = "0x8C8E040", VA = "0x188C8FA40", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float MPNFMFDJKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DE50", Offset = "0x8C8C450", VA = "0x188C8DE50", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8C92800", Offset = "0x8C90E00", VA = "0x188C92800", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 LOBPBIDCCFC
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E2C0", Offset = "0x8C8C8C0", VA = "0x188C8E2C0", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8C92C60", Offset = "0x8C91260", VA = "0x188C92C60", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 DBCICGFIPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8C90720", Offset = "0x8C8ED20", VA = "0x188C90720", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8C913C0", Offset = "0x8C8F9C0", VA = "0x188C913C0", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 HJDKOMOPEEB
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8C936F0", Offset = "0x8C91CF0", VA = "0x188C936F0", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8C919C0", Offset = "0x8C8FFC0", VA = "0x188C919C0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 AOPBBIIEBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8C93560", Offset = "0x8C91B60", VA = "0x188C93560", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8C91EE0", Offset = "0x8C904E0", VA = "0x188C91EE0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool PLENCFJBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8C8F4B0", Offset = "0x8C8DAB0", VA = "0x188C8F4B0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool AIIEPILKLLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E040", Offset = "0x8C8C640", VA = "0x188C8E040", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool CDAHPKKLMEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8C8D950", Offset = "0x8C8BF50", VA = "0x188C8D950", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool GGNDCMPEAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8C92760", Offset = "0x8C90D60", VA = "0x188C92760", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 IIJIBBGLIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8C8FC20", Offset = "0x8C8E220", VA = "0x188C8FC20", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 INODLPFDIBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8C90150", Offset = "0x8C8E750", VA = "0x188C90150", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 GLMKMJCCMFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8C8FD30", Offset = "0x8C8E330", VA = "0x188C8FD30", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8C91B70", Offset = "0x8C90170", VA = "0x188C91B70", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 DNILPNFLHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8C91CB0", Offset = "0x8C902B0", VA = "0x188C91CB0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float NJLFNJHOGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8C8ECA0", Offset = "0x8C8D2A0", VA = "0x188C8ECA0", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float FOBMOJJLBHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8C8FB30", Offset = "0x8C8E130", VA = "0x188C8FB30", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E3F0", Offset = "0x8C8C9F0", VA = "0x188C8E3F0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 PEKCLGMLGCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E450", Offset = "0x8C8CA50", VA = "0x188C8E450", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion DHIIINIAGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8C90930", Offset = "0x8C8EF30", VA = "0x188C90930", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float PMANGOFGHII
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8C93BF0", Offset = "0x8C921F0", VA = "0x188C93BF0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8C91300", Offset = "0x8C8F900", VA = "0x188C91300", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float ONJNNFJBIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8C912B0", Offset = "0x8C8F8B0", VA = "0x188C912B0", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8C8FAD0", Offset = "0x8C8E0D0", VA = "0x188C8FAD0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool EIHMNFIPHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DEA0", Offset = "0x8C8C4A0", VA = "0x188C8DEA0", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8C8D8A0", Offset = "0x8C8BEA0", VA = "0x188C8D8A0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public MMEGJHMINAN OFBLHGPDGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8C93640", Offset = "0x8C91C40", VA = "0x188C93640", Slot = "70")]
		get
		{
			return default(MMEGJHMINAN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8C8D710", Offset = "0x8C8BD10", VA = "0x188C8D710", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool MCNFPMEGDEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8C93820", Offset = "0x8C91E20", VA = "0x188C93820", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform PFJFLENGLLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xB66230", Offset = "0xB64830", VA = "0x180B66230", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 FCCPKFEGACO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8C90F20", Offset = "0x8C8F520", VA = "0x188C90F20", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8C90E70", Offset = "0x8C8F470", VA = "0x188C90E70", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float OJBPHIEOEOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DFD0", Offset = "0x8C8C5D0", VA = "0x188C8DFD0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8C90460", Offset = "0x8C8EA60", VA = "0x188C90460", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float CIDGLEKGCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8C90A00", Offset = "0x8C8F000", VA = "0x188C90A00", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E9E0", Offset = "0x8C8CFE0", VA = "0x188C8E9E0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion OOOFHBFIALB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8C90230", Offset = "0x8C8E830", VA = "0x188C90230", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8C8F2B0", Offset = "0x8C8D8B0", VA = "0x188C8F2B0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 GBLBIHIAFHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8C93B50", Offset = "0x8C92150", VA = "0x188C93B50", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8C8FCF0", Offset = "0x8C8E2F0", VA = "0x188C8FCF0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion ABMIOHAELPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8C91630", Offset = "0x8C8FC30", VA = "0x188C91630", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8C8FAA0", Offset = "0x8C8E0A0", VA = "0x188C8FAA0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints OKJBFKCHAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E670", Offset = "0x8C8CC70", VA = "0x188C8E670", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8C90FD0", Offset = "0x8C8F5D0", VA = "0x188C90FD0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool CCPFHDGJAOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8C92600", Offset = "0x8C90C00", VA = "0x188C92600", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8C92240", Offset = "0x8C90840", VA = "0x188C92240", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode INDJBNAOLNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E6C0", Offset = "0x8C8CCC0", VA = "0x188C8E6C0", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8C93C40", Offset = "0x8C92240", VA = "0x188C93C40", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool PHIIPJINHBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8C92A20", Offset = "0x8C91020", VA = "0x188C92A20", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool KGAPCBCJLHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8C91130", Offset = "0x8C8F730", VA = "0x188C91130", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event OICGOOGFDLN JJKHKPBNKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8C90070", Offset = "0x8C8E670", VA = "0x188C90070", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8C906C0", Offset = "0x8C8ECC0", VA = "0x188C906C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event OICGOOGFDLN NHJNLCICBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8C8D770", Offset = "0x8C8BD70", VA = "0x188C8D770", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DFE0", Offset = "0x8C8C5E0", VA = "0x188C8DFE0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event CJEGOOJGBEM MKFINJCHJMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E610", Offset = "0x8C8CC10", VA = "0x188C8E610", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8C92D40", Offset = "0x8C91340", VA = "0x188C92D40", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event OICGOOGFDLN FMPAJDHFJFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8C8FE10", Offset = "0x8C8E410", VA = "0x188C8FE10", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8C92DA0", Offset = "0x8C913A0", VA = "0x188C92DA0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event OICGOOGFDLN ECGHOCKKCMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8C8F5F0", Offset = "0x8C8DBF0", VA = "0x188C8F5F0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8C93080", Offset = "0x8C91680", VA = "0x188C93080", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event OICGOOGFDLN DEMIOKNLJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8C902D0", Offset = "0x8C8E8D0", VA = "0x188C902D0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8C92E00", Offset = "0x8C91400", VA = "0x188C92E00", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<JGCNGACGAAH, JGCNGACGAAH> MFJELJEDPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8C8E0A0", Offset = "0x8C8C6A0", VA = "0x188C8E0A0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8C8EBE0", Offset = "0x8C8D1E0", VA = "0x188C8EBE0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event OICGOOGFDLN MFLBPACFDJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8C92090", Offset = "0x8C90690", VA = "0x188C92090", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8C93B90", Offset = "0x8C92190", VA = "0x188C93B90", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event OICGOOGFDLN HLLCPJOLMPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8C92B60", Offset = "0x8C91160", VA = "0x188C92B60", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8C939F0", Offset = "0x8C91FF0", VA = "0x188C939F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8C93CE0", Offset = "0x8C922E0", VA = "0x188C93CE0")]
	public CGIBJHLBEOL(GameObject EGMHLHLEIMH, RigidbodyEx CFNFOEHEKEP, IHKOCNIDNCO BIAJFLEJGFD, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8C8DB60", Offset = "0x8C8C160", VA = "0x188C8DB60", Slot = "139")]
	protected virtual void BAIOLBONENI(IHKOCNIDNCO BIAJFLEJGFD, HAPFNJKACCD DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8C8ECF0", Offset = "0x8C8D2F0", VA = "0x188C8ECF0", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8C914A0", Offset = "0x8C8FAA0", VA = "0x188C914A0", Slot = "93")]
	public void IPAAAFNGFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8C8FFE0", Offset = "0x8C8E5E0", VA = "0x188C8FFE0", Slot = "94")]
	public void GMBGDNHKJIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8C8F450", Offset = "0x8C8DA50", VA = "0x188C8F450", Slot = "95")]
	public void ENEOFGGEKEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8C904F0", Offset = "0x8C8EAF0", VA = "0x188C904F0", Slot = "96")]
	public void HFJFABIJJAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8C90B90", Offset = "0x8C8F190", VA = "0x188C90B90")]
	private void IDKFKBHMBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8C900D0", Offset = "0x8C8E6D0", VA = "0x188C900D0")]
	private void GNEJCMNPJHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8C90660", Offset = "0x8C8EC60", VA = "0x188C90660")]
	private void HHHMLDEGGOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8C93870", Offset = "0x8C91E70", VA = "0x188C93870", Slot = "30")]
	public PLDICLLJPJP OHMJFBCBFPF(int LEPAEEGOBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8C929B0", Offset = "0x8C90FB0", VA = "0x188C929B0", Slot = "98")]
	public void MBGDBGDPEAA(PLDICLLJPJP FKMNCAKIOFK, bool EAPOMGLHHCP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8C90E10", Offset = "0x8C8F410", VA = "0x188C90E10", Slot = "99")]
	public void IDNBJLPAHBC(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8C90860", Offset = "0x8C8EE60", VA = "0x188C90860", Slot = "100")]
	public void HNGDEMIJHKG(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8C928B0", Offset = "0x8C90EB0", VA = "0x188C928B0", Slot = "101")]
	public Vector3 MBADFDKJKOF(Vector3 AOFGNGADMDL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8C91DE0", Offset = "0x8C903E0", VA = "0x188C91DE0", Slot = "102")]
	public Vector3 KLMGPDGEODJ(Vector3 ECJAEJHHBNF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8C920F0", Offset = "0x8C906F0", VA = "0x188C920F0", Slot = "103")]
	public void LELKILHBIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8C93B00", Offset = "0x8C92100", VA = "0x188C93B00", Slot = "104")]
	public void PEIEDHEIIDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8C90B40", Offset = "0x8C8F140", VA = "0x188C90B40", Slot = "105")]
	public void ICFFCJEMLOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x8C90510", Offset = "0x8C8EB10", VA = "0x188C90510", Slot = "106")]
	public void HFNJMCGIBDL(Vector3 PHJHLLDKOJF, Vector3 DPFKBGCGGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8C92F90", Offset = "0x8C91590", VA = "0x188C92F90", Slot = "107")]
	public void NGAHBCOFFOH(Vector3 LOHJNHEMLOP, Vector3 MPFAFOAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x8C8E530", Offset = "0x8C8CB30", VA = "0x188C8E530", Slot = "108")]
	public void CAOIBOCPLFB(Vector3 NIGGFNPPODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8C8F390", Offset = "0x8C8D990", VA = "0x188C8F390", Slot = "109")]
	public void EKFCJPEDPKI(MILMBLMNICG IOFMKIHBING, Vector3 CGEBBGCIENO, float EPAAIIHMNGB, float EHJKHHAKCNE = 8f, float BCAICAPEAID = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8C91820", Offset = "0x8C8FE20", VA = "0x188C91820", Slot = "110")]
	public void JHFAPBDGALA(AJEKPFKLAEG KCELOENKKEK, Vector3 OEJOJNFFOKK, float CDOHNMIAGPG = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8C92190", Offset = "0x8C90790", VA = "0x188C92190", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void LFCBDCAHKHC(AJEKPFKLAEG KCELOENKKEK, Vector3 NEOIPHFFLHF, float LCJCHDBLDCK = 7f, float FELCNEKKNNF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8C91030", Offset = "0x8C8F630", VA = "0x188C91030", Slot = "112")]
	public Vector3 IHMJIAJEBDO(Vector3 FKMNCAKIOFK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8C938F0", Offset = "0x8C91EF0", VA = "0x188C938F0", Slot = "113")]
	public Vector3 OKAHJKAHAIB(Vector3 FKMNCAKIOFK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8C91920", Offset = "0x8C8FF20", VA = "0x188C91920", Slot = "114")]
	public void JHFDPCGJHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8C92020", Offset = "0x8C90620", VA = "0x188C92020", Slot = "115")]
	public void LBLPAGHAEHK(PLDICLLJPJP CFPPCACOMOG, object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8C91C50", Offset = "0x8C90250", VA = "0x188C91C50", Slot = "116")]
	public void KCJMIODDFDE(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8C8E710", Offset = "0x8C8CD10", VA = "0x188C8E710", Slot = "63")]
	public void CEJCFBDIFHI((Quaternion rot, Vector3 moments) ALGBGLDGENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8C937D0", Offset = "0x8C91DD0", VA = "0x188C937D0", Slot = "117")]
	public void OHKMNDOPGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8C92860", Offset = "0x8C90E60", VA = "0x188C92860", Slot = "118")]
	public void MAOPACCHBPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8C8EB90", Offset = "0x8C8D190", VA = "0x188C8EB90", Slot = "119")]
	public void DBEFIDEPKFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8C927B0", Offset = "0x8C90DB0", VA = "0x188C927B0", Slot = "120")]
	public bool LPKIDOLJMEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8C92C10", Offset = "0x8C91210", VA = "0x188C92C10", Slot = "97")]
	public void MFIKAIGMEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8C908C0", Offset = "0x8C8EEC0", VA = "0x188C908C0", Slot = "121")]
	public void HNKCBEMPAEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8C93AA0", Offset = "0x8C920A0", VA = "0x188C93AA0", Slot = "122")]
	public void ONLHPHHECIP(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8C8EC40", Offset = "0x8C8D240", VA = "0x188C8EC40", Slot = "123")]
	public void DGNOOINKJNB(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x8C8E100", Offset = "0x8C8C700", VA = "0x188C8E100", Slot = "124")]
	public void BJEFIKGNLAO(object HNGIMMGBLII, bool DHIOOCFCCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8C8F840", Offset = "0x8C8DE40", VA = "0x188C8F840", Slot = "125")]
	public void FGEKGNFEBND(Vector3 CMNDAAHGGNG, Quaternion CCFILMDIOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8C90330", Offset = "0x8C8E930", VA = "0x188C90330", Slot = "126")]
	public void HEAMKNBMIEN(Vector3 MMOFCAILDPO, Quaternion HNJFMDBMALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8C91D90", Offset = "0x8C90390", VA = "0x188C91D90", Slot = "127")]
	public bool KIKJOMOLPIE(float DFPGIFAKBHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8C91360", Offset = "0x8C8F960", VA = "0x188C91360", Slot = "128")]
	public void IOBEJKGHPIC(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8C90600", Offset = "0x8C8EC00", VA = "0x188C90600", Slot = "129")]
	public void HGMMGBPKFBB(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8C90800", Offset = "0x8C8EE00", VA = "0x188C90800", Slot = "130")]
	public void HMMOKBBCAPF(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8C93690", Offset = "0x8C91C90", VA = "0x188C93690", Slot = "131")]
	public void OCGIEAAEOMB(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8C8D630", Offset = "0x8C8BC30", VA = "0x188C8D630", Slot = "132")]
	public void AAHAIGFAGKH(Vector3 MKJGBAFLMBJ, ForceMode LLLMFFEODME = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8C92650", Offset = "0x8C90C50", VA = "0x188C92650", Slot = "133")]
	public void LHHLLAIOPOO(Vector3 MKJGBAFLMBJ, Vector3 AANGPKCDGHO, ForceMode LLLMFFEODME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8C8DEF0", Offset = "0x8C8C4F0", VA = "0x188C8DEF0", Slot = "134")]
	public void BEJFHACKMHM(Vector3 CLJPODDAMOF, ForceMode LLLMFFEODME = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8C8DA30", Offset = "0x8C8C030", VA = "0x188C8DA30", Slot = "135")]
	public void ANPPPLFDIHO(Vector3 CLJPODDAMOF, ForceMode LLLMFFEODME = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8C934C0", Offset = "0x8C91AC0", VA = "0x188C934C0", Slot = "136")]
	public bool NNBGLIOEJNK(Vector3 FANJPCNJGDA, [Out] RaycastHit JKJAABNABOH, float LHLABDNDDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8C8DB10", Offset = "0x8C8C110", VA = "0x188C8DB10", Slot = "137")]
	public void APDJCIBGIJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8C93CA0", Offset = "0x8C922A0", VA = "0x188C93CA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8C8E900", Offset = "0x8C8CF00", VA = "0x188C8E900")]
	private void CHMEJFEHEOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8C8E7F0", Offset = "0x8C8CDF0", VA = "0x188C8E7F0")]
	private void CFFKGFMIOBJ(PLDICLLJPJP IGDHFGFJBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8C8F650", Offset = "0x8C8DC50", VA = "0x188C8F650")]
	private void FGCELBMBJDH(PLDICLLJPJP IGDHFGFJBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8C8EAE0", Offset = "0x8C8D0E0", VA = "0x188C8EAE0")]
	private void DANILOKABJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8C92E60", Offset = "0x8C91460", VA = "0x188C92E60")]
	private void NFNKKDJIKCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8C91670", Offset = "0x8C8FC70", VA = "0x188C91670")]
	private void JHALHPNHKMF(PLDICLLJPJP PMBAFINBOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8C91AA0", Offset = "0x8C900A0", VA = "0x188C91AA0")]
	private void KAEMEIPDGOB(PLDICLLJPJP IGDHFGFJBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8C8D7D0", Offset = "0x8C8BDD0", VA = "0x188C8D7D0")]
	private void ADLPKEDLIEF(PLDICLLJPJP IGDHFGFJBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8C8E170", Offset = "0x8C8C770", VA = "0x188C8E170")]
	private void BKKDKBEMDHB(FFEDAAPDFJC IGDHFGFJBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8C8EE60", Offset = "0x8C8D460", VA = "0x188C8EE60", Slot = "142")]
	protected virtual void EDODOFHIIAH(FFEDAAPDFJC IJBOEHJOLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8C922A0", Offset = "0x8C908A0", VA = "0x188C922A0")]
	protected void LHDOPFKJJFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8C930E0", Offset = "0x8C916E0", VA = "0x188C930E0")]
	protected void NLMBEOHNEOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8C90A10", Offset = "0x8C8F010", VA = "0x188C90A10")]
	private void IALGCHHLANO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8C8FE70", Offset = "0x8C8E470", VA = "0x188C8FE70")]
	private void GLGANIDNNMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class CPODBICKOBF
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8C94210", Offset = "0x8C92810", VA = "0x188C94210")]
	public static PLDICLLJPJP GHDKLEPBMAD(this PLDICLLJPJP IJBOEHJOLPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8C94170", Offset = "0x8C92770", VA = "0x188C94170")]
	public static bool BCHJIAFJFAC(this PLDICLLJPJP IJBOEHJOLPI, PLDICLLJPJP FMGFBCOJOON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8C94320", Offset = "0x8C92920", VA = "0x188C94320")]
	public static bool KKMKGOGMEPL(this PLDICLLJPJP IJBOEHJOLPI, PLDICLLJPJP KCHLDHAPLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8C942D0", Offset = "0x8C928D0", VA = "0x188C942D0")]
	public static FFEDAAPDFJC JEIPKFKCKEP(this PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8C943C0", Offset = "0x8C929C0", VA = "0x188C943C0")]
	public static CGIBJHLBEOL LHCKNCJDPMD(this PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JHJJDLMHPNJ : PEMPFLGBFOB
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8C98410", Offset = "0x8C96A10", VA = "0x188C98410", Slot = "19")]
	public PLDICLLJPJP DGBMGKAIBJJ(RigidbodyEx IJBOEHJOLPI, HAPFNJKACCD DAJAOHIJHHL, IHKOCNIDNCO BIAJFLEJGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "4")]
	public LGOAKADPMHP BCEKNECOPEP(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "5")]
	public NPMNJKMFHED LHHJIEHAFCB(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "6")]
	public KAHJDDJMFJK LODDEEADKLM(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "7")]
	public ICFCJEOGKBH ALHOCANFGPD(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "8")]
	public HDEFBLMJDIC OGCEPGHFDMH(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "9")]
	public FLAPDHHOOOF AKACOBJJKKF(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "10")]
	public BOAFDABLKEJ AOIHOJPPICJ(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "11")]
	public OOAJDKPDCGI FKPAIOLFFMC(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "12")]
	public BLFDBJKOFAP FNFLINMCBGN(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "13")]
	public JDKCHCHAHCH BLNICCHMKKG(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0")]
	public HNNFBOBCKAA HCBNAADGDEA(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0")]
	public KAGNOCNDELF AEMAODGFMMK(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0")]
	public BGFKPDEBMLI NHKDDDGENCL(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0")]
	public GPMCHLMMEPF NENHCEKOOGJ(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0")]
	public CNKLEFKBHPH BOPJMMCAKGP(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public JHJJDLMHPNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "14")]
	private HNNFBOBCKAA MBIFKPAPJJI(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "15")]
	private KAGNOCNDELF FEAGDEEGEMJ(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "16")]
	private BGFKPDEBMLI GFBCFJLFFOM(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "17")]
	private GPMCHLMMEPF AGNNPHMNKNN(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0", Slot = "18")]
	private CNKLEFKBHPH FNDEHIAOFOK(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(PEMPFLGBFOB), new string[] { })]
public class OCBGAHBECGB : PEMPFLGBFOB, DPFKFJLGBCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly PEMPFLGBFOB KDKPNKOEFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly PEMPFLGBFOB FKPELLCKDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private DBPBMPDMPEK HODLHFOBLDF;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private PEMPFLGBFOB EDAEJDJPIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8CA1740", Offset = "0x8C9FD40", VA = "0x188CA1740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8CA16F0", Offset = "0x8C9FCF0", VA = "0x188CA16F0", Slot = "20")]
	public void InitReferences(MKDGNELEFKI MMELACBKGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8CA1180", Offset = "0x8C9F780", VA = "0x188CA1180", Slot = "4")]
	public LGOAKADPMHP BCEKNECOPEP(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8CA17A0", Offset = "0x8C9FDA0", VA = "0x188CA17A0", Slot = "5")]
	public NPMNJKMFHED LHHJIEHAFCB(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8CA1840", Offset = "0x8C9FE40", VA = "0x188CA1840", Slot = "6")]
	public KAHJDDJMFJK LODDEEADKLM(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8CA1040", Offset = "0x8C9F640", VA = "0x188CA1040", Slot = "7")]
	public ICFCJEOGKBH ALHOCANFGPD(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8CA18E0", Offset = "0x8C9FEE0", VA = "0x188CA18E0", Slot = "8")]
	public HDEFBLMJDIC OGCEPGHFDMH(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8CA0FA0", Offset = "0x8C9F5A0", VA = "0x188CA0FA0", Slot = "9")]
	public FLAPDHHOOOF AKACOBJJKKF(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8CA10E0", Offset = "0x8C9F6E0", VA = "0x188CA10E0", Slot = "10")]
	public BOAFDABLKEJ AOIHOJPPICJ(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8CA1450", Offset = "0x8C9FA50", VA = "0x188CA1450", Slot = "11")]
	public OOAJDKPDCGI FKPAIOLFFMC(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8CA14F0", Offset = "0x8C9FAF0", VA = "0x188CA14F0", Slot = "12")]
	public BLFDBJKOFAP FNFLINMCBGN(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8CA1220", Offset = "0x8C9F820", VA = "0x188CA1220", Slot = "13")]
	public JDKCHCHAHCH BLNICCHMKKG(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8CA1640", Offset = "0x8C9FC40", VA = "0x188CA1640")]
	public HNNFBOBCKAA HCBNAADGDEA(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8CA0E40", Offset = "0x8C9F440", VA = "0x188CA0E40")]
	public KAGNOCNDELF AEMAODGFMMK(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8CA1590", Offset = "0x8C9FB90", VA = "0x188CA1590")]
	public BGFKPDEBMLI NHKDDDGENCL(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x8CA0EF0", Offset = "0x8C9F4F0", VA = "0x188CA0EF0")]
	public GPMCHLMMEPF NENHCEKOOGJ(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8CA12C0", Offset = "0x8C9F8C0", VA = "0x188CA12C0")]
	public CNKLEFKBHPH BOPJMMCAKGP(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x8CA1370", Offset = "0x8C9F970", VA = "0x188CA1370", Slot = "19")]
	public PLDICLLJPJP DGBMGKAIBJJ(RigidbodyEx IJBOEHJOLPI, HAPFNJKACCD DAJAOHIJHHL, IHKOCNIDNCO BIAJFLEJGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x8CA1980", Offset = "0x8C9FF80", VA = "0x188CA1980")]
	public OCBGAHBECGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8CA1640", Offset = "0x8C9FC40", VA = "0x188CA1640", Slot = "14")]
	private HNNFBOBCKAA MBIFKPAPJJI(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8CA0E40", Offset = "0x8C9F440", VA = "0x188CA0E40", Slot = "15")]
	private KAGNOCNDELF FEAGDEEGEMJ(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8CA1590", Offset = "0x8C9FB90", VA = "0x188CA1590", Slot = "16")]
	private BGFKPDEBMLI GFBCFJLFFOM(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x8CA0EF0", Offset = "0x8C9F4F0", VA = "0x188CA0EF0", Slot = "17")]
	private GPMCHLMMEPF AGNNPHMNKNN(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x8CA12C0", Offset = "0x8C9F8C0", VA = "0x188CA12C0", Slot = "18")]
	private CNKLEFKBHPH FNDEHIAOFOK(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FGMEJBOADAD : LGOAKADPMHP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIHCHEDEEEJ(PLDICLLJPJP IJBOEHJOLPI);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIDHOBEDGKE(PLDICLLJPJP IJBOEHJOLPI);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OOGIFMEOHMB(PLDICLLJPJP PMBAFINBOGP);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GPDOAKIDPAP(PLDICLLJPJP PMBAFINBOGP);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface AIDOMGKBOCG : KAHJDDJMFJK
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CJOALINNILP<PLDICLLJPJP> KKPBOGMDGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	PLDICLLJPJP ALHLMGJKLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface LOHGKNGOLFD : GPMCHLMMEPF
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) EEIGIIAKPMG(Rigidbody DLJHKAMHMCM);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface BNLIPANDPGF : KAGNOCNDELF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	RRNetworkView GLEINKGNCDL
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class GPNGPEMIEJK : BLFDBJKOFAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly CGIBJHLBEOL IJBOEHJOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode FCELGDKHIEP;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody CLHIEGMEABN
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8C97410", Offset = "0x8C95A10", VA = "0x188C97410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode INDJBNAOLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8C97170", Offset = "0x8C95770", VA = "0x188C97170", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8C975D0", Offset = "0x8C95BD0", VA = "0x188C975D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x8C945F0", Offset = "0x8C92BF0", VA = "0x188C945F0")]
	public GPNGPEMIEJK(PLDICLLJPJP IJBOEHJOLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x8C97300", Offset = "0x8C95900", VA = "0x188C97300", Slot = "6")]
	public void IPAAAFNGFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x8C97280", Offset = "0x8C95880", VA = "0x188C97280", Slot = "9")]
	public void DFCOIFJKDHH(Rigidbody LGAEALOIBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x8C97160", Offset = "0x8C95760", VA = "0x188C97160", Slot = "7")]
	public void BPNBOAJCIHB(bool MPKAGAKAHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x8C97460", Offset = "0x8C95A60", VA = "0x188C97460", Slot = "8")]
	public void KBIDAGEELEE(bool MPKAGAKAHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x8C97470", Offset = "0x8C95A70", VA = "0x188C97470", Slot = "10")]
	public bool NNBGLIOEJNK(Vector3 FANJPCNJGDA, [Out] RaycastHit JKJAABNABOH, float LHLABDNDDPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x8C97040", Offset = "0x8C95640", VA = "0x188C97040")]
	private void BELGOAHNPKH(bool MPKAGAKAHMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class JMEIELHMHCA : FLAPDHHOOOF, IDisposable, LNDEJGNNFBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CGIBJHLBEOL IJBOEHJOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private MMEGJHMINAN CLAKDENKIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private FNKHPMOHMOL EFJMHHPPEHI;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public MMEGJHMINAN OFBLHGPDGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8C989A0", Offset = "0x8C96FA0", VA = "0x188C989A0", Slot = "6")]
		get
		{
			return default(MMEGJHMINAN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8C984B0", Offset = "0x8C96AB0", VA = "0x188C984B0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform CKJEIPPKGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xE4CDB0", Offset = "0xE4B3B0", VA = "0x180E4CDB0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<JGCNGACGAAH, JGCNGACGAAH> MFJELJEDPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8C98580", Offset = "0x8C96B80", VA = "0x188C98580", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8C98630", Offset = "0x8C96C30", VA = "0x188C98630", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x8C98AF0", Offset = "0x8C970F0", VA = "0x188C98AF0")]
	public JMEIELHMHCA(PLDICLLJPJP IJBOEHJOLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x8C98730", Offset = "0x8C96D30", VA = "0x188C98730", Slot = "8")]
	public void IPAAAFNGFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x8C986E0", Offset = "0x8C96CE0", VA = "0x188C986E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1367BC0", Offset = "0x13661C0", VA = "0x181367BC0", Slot = "11")]
	private void ECJGPFHHKPK(JGCNGACGAAH OGFDBLBDNLG, JGCNGACGAAH IBPAHBGEPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "12")]
	private void CKJJOOHJPOG(bool BPEBLCNNACG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KMBIPFLKBEM : PEMPFLGBFOB
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8C99360", Offset = "0x8C97960", VA = "0x188C99360", Slot = "4")]
	public LGOAKADPMHP BCEKNECOPEP(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8C99B30", Offset = "0x8C98130", VA = "0x188C99B30", Slot = "5")]
	public NPMNJKMFHED LHHJIEHAFCB(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8C99C60", Offset = "0x8C98260", VA = "0x188C99C60", Slot = "6")]
	public KAHJDDJMFJK LODDEEADKLM(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8C991C0", Offset = "0x8C977C0", VA = "0x188C991C0", Slot = "7")]
	public ICFCJEOGKBH ALHOCANFGPD(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x8C99D90", Offset = "0x8C98390", VA = "0x188C99D90", Slot = "8")]
	public HDEFBLMJDIC OGCEPGHFDMH(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8C990F0", Offset = "0x8C976F0", VA = "0x188C990F0", Slot = "9")]
	public FLAPDHHOOOF AKACOBJJKKF(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8C99240", Offset = "0x8C97840", VA = "0x188C99240", Slot = "10")]
	public BOAFDABLKEJ AOIHOJPPICJ(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8C99740", Offset = "0x8C97D40", VA = "0x188C99740", Slot = "11")]
	public OOAJDKPDCGI FKPAIOLFFMC(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8C99800", Offset = "0x8C97E00", VA = "0x188C99800", Slot = "12")]
	public BLFDBJKOFAP FNFLINMCBGN(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8C99450", Offset = "0x8C97A50", VA = "0x188C99450", Slot = "13")]
	public JDKCHCHAHCH BLNICCHMKKG(PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8C999F0", Offset = "0x8C97FF0", VA = "0x188C999F0")]
	public HNNFBOBCKAA HCBNAADGDEA(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8C98DC0", Offset = "0x8C973C0", VA = "0x188C98DC0")]
	public KAGNOCNDELF AEMAODGFMMK(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8C998C0", Offset = "0x8C97EC0", VA = "0x188C998C0")]
	public BGFKPDEBMLI NHKDDDGENCL(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8C98F50", Offset = "0x8C97550", VA = "0x188C98F50")]
	public GPMCHLMMEPF NENHCEKOOGJ(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8C99510", Offset = "0x8C97B10", VA = "0x188C99510")]
	public CNKLEFKBHPH BOPJMMCAKGP(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8C995F0", Offset = "0x8C97BF0", VA = "0x188C995F0", Slot = "19")]
	public PLDICLLJPJP DGBMGKAIBJJ(RigidbodyEx IJBOEHJOLPI, HAPFNJKACCD DAJAOHIJHHL, IHKOCNIDNCO BIAJFLEJGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public KMBIPFLKBEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8C999F0", Offset = "0x8C97FF0", VA = "0x188C999F0", Slot = "14")]
	private HNNFBOBCKAA MBIFKPAPJJI(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8C98DC0", Offset = "0x8C973C0", VA = "0x188C98DC0", Slot = "15")]
	private KAGNOCNDELF FEAGDEEGEMJ(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8C998C0", Offset = "0x8C97EC0", VA = "0x188C998C0", Slot = "16")]
	private BGFKPDEBMLI GFBCFJLFFOM(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8C98F50", Offset = "0x8C97550", VA = "0x188C98F50", Slot = "17")]
	private GPMCHLMMEPF AGNNPHMNKNN(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8C99510", Offset = "0x8C97B10", VA = "0x188C99510", Slot = "18")]
	private CNKLEFKBHPH FNDEHIAOFOK(PLDICLLJPJP FCFHEFKEJPB, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class IOGBEKMMFKC : OOAJDKPDCGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CGIBJHLBEOL IJBOEHJOLPI;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody CLHIEGMEABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8C97410", Offset = "0x8C95A10", VA = "0x188C97410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool MCNFPMEGDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8C983C0", Offset = "0x8C969C0", VA = "0x188C983C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool HGAPFBEBFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8C8D310", Offset = "0x8C8B910", VA = "0x188C8D310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private PLDICLLJPJP DHPGFGLBJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8C97E80", Offset = "0x8C96480", VA = "0x188C97E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8C945F0", Offset = "0x8C92BF0", VA = "0x188C945F0")]
	public IOGBEKMMFKC(PLDICLLJPJP IJBOEHJOLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8C97700", Offset = "0x8C95D00", VA = "0x188C97700", Slot = "4")]
	public void AAHAIGFAGKH(Vector3 MKJGBAFLMBJ, ForceMode LLLMFFEODME = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8C97C20", Offset = "0x8C96220", VA = "0x188C97C20")]
	private void DIKMAFEDGIG(Vector3 MKJGBAFLMBJ, ForceMode LLLMFFEODME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x8C97EE0", Offset = "0x8C964E0", VA = "0x188C97EE0", Slot = "5")]
	public void LHHLLAIOPOO(Vector3 MKJGBAFLMBJ, Vector3 AANGPKCDGHO, ForceMode LLLMFFEODME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x8C97AC0", Offset = "0x8C960C0", VA = "0x188C97AC0", Slot = "6")]
	public void BEJFHACKMHM(Vector3 CLJPODDAMOF, ForceMode LLLMFFEODME = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8C98160", Offset = "0x8C96760", VA = "0x188C98160")]
	private void LOLHOFDBHOM(Vector3 CLJPODDAMOF, ForceMode LLLMFFEODME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8C97860", Offset = "0x8C95E60", VA = "0x188C97860", Slot = "7")]
	public void ANPPPLFDIHO(Vector3 CLJPODDAMOF, ForceMode LLLMFFEODME = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class DGHKHPDCKBA : JDKCHCHAHCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly CGIBJHLBEOL IJBOEHJOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool KIDPFJDELFG;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool EIHMNFIPHPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAEAC60", Offset = "0xAE9260", VA = "0x180AEAC60", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8C94440", Offset = "0x8C92A40", VA = "0x188C94440", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8C945F0", Offset = "0x8C92BF0", VA = "0x188C945F0")]
	public DGHKHPDCKBA(PLDICLLJPJP IJBOEHJOLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x8C94550", Offset = "0x8C92B50", VA = "0x188C94550", Slot = "6")]
	public void DFCOIFJKDHH(Rigidbody LGAEALOIBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x8C94580", Offset = "0x8C92B80", VA = "0x188C94580", Slot = "7")]
	public void ODEPCPHAJKB(Rigidbody LGAEALOIBKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class ALJJJGMLHHC : FGMEJBOADAD, LGOAKADPMHP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly PLDICLLJPJP IJBOEHJOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<PLDICLLJPJP> BPOIOOLGAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private PLDICLLJPJP PPOKNBNEDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private PLDICLLJPJP IGDHFGFJBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform PMFBKBHELBO;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform ADNKINOHCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8C8BB90", Offset = "0x8C8A190", VA = "0x188C8BB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public PLDICLLJPJP DHPGFGLBJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA99380", Offset = "0xA97980", VA = "0x180A99380", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8C8BFB0", Offset = "0x8C8A5B0", VA = "0x188C8BFB0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public PLDICLLJPJP KFENKPOKOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA962A0", Offset = "0xA948A0", VA = "0x180A962A0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<PLDICLLJPJP> IDPBBHKDDNH
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA962D0", Offset = "0xA948D0", VA = "0x180A962D0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event OICGOOGFDLN JJKHKPBNKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8C8B5B0", Offset = "0x8C89BB0", VA = "0x188C8B5B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8C8BAB0", Offset = "0x8C8A0B0", VA = "0x188C8BAB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event OICGOOGFDLN NHJNLCICBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8C8AF10", Offset = "0x8C89510", VA = "0x188C8AF10", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8C8B050", Offset = "0x8C89650", VA = "0x188C8B050", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event CJEGOOJGBEM MKFINJCHJMK
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8C8B190", Offset = "0x8C89790", VA = "0x188C8B190", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C800", Offset = "0x8C8AE00", VA = "0x188C8C800", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action OABBIEIKEKA
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8C8BDE0", Offset = "0x8C8A3E0", VA = "0x188C8BDE0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8C8AE70", Offset = "0x8C89470", VA = "0x188C8AE70", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action PECDPFAOMMD
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8C8B0F0", Offset = "0x8C896F0", VA = "0x188C8B0F0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C8A0", Offset = "0x8C8AEA0", VA = "0x188C8C8A0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<PLDICLLJPJP> MJDEEAPICED
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C750", Offset = "0x8C8AD50", VA = "0x188C8C750", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8C8BA00", Offset = "0x8C8A000", VA = "0x188C8BA00", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<PLDICLLJPJP> LMBBJEFDELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8C8B320", Offset = "0x8C89920", VA = "0x188C8B320", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8C8BBF0", Offset = "0x8C8A1F0", VA = "0x188C8BBF0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action DBGNAGLOPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8C8B510", Offset = "0x8C89B10", VA = "0x188C8B510", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C080", Offset = "0x8C8A680", VA = "0x188C8C080", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<PLDICLLJPJP> GCCAOLMIALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C120", Offset = "0x8C8A720", VA = "0x188C8C120", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C940", Offset = "0x8C8AF40", VA = "0x188C8C940", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x8C8CC60", Offset = "0x8C8B260", VA = "0x188C8CC60")]
	public ALJJJGMLHHC(PLDICLLJPJP IJBOEHJOLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x8C8B470", Offset = "0x8C89A70", VA = "0x188C8B470", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x8C8C1D0", Offset = "0x8C8A7D0", VA = "0x188C8C1D0", Slot = "30")]
	public void MBGDBGDPEAA(PLDICLLJPJP GHOEBAIBIJA, bool EAPOMGLHHCP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x8C8C9F0", Offset = "0x8C8AFF0", VA = "0x188C8C9F0", Slot = "6")]
	public void OOGIFMEOHMB(PLDICLLJPJP PMBAFINBOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x8C8B650", Offset = "0x8C89C50", VA = "0x188C8B650", Slot = "7")]
	public void GPDOAKIDPAP(PLDICLLJPJP PMBAFINBOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8C8B230", Offset = "0x8C89830", VA = "0x188C8B230", Slot = "4")]
	public void CIHCHEDEEEJ(PLDICLLJPJP IJBOEHJOLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x8C8AFB0", Offset = "0x8C895B0", VA = "0x188C8AFB0", Slot = "5")]
	public void AIDHOBEDGKE(PLDICLLJPJP IJBOEHJOLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x8C8B3D0", Offset = "0x8C899D0", VA = "0x188C8B3D0")]
	private void DDCMCGKHKIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x8C8BB50", Offset = "0x8C8A150", VA = "0x188C8BB50")]
	private void JHIOGIBHLNG(PLDICLLJPJP PMBAFINBOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x8C8BCA0", Offset = "0x8C8A2A0", VA = "0x188C8BCA0")]
	private void JPGNKLFKPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x8C8BE80", Offset = "0x8C8A480", VA = "0x188C8BE80")]
	private void KKKDCAPBLAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x8C8B8D0", Offset = "0x8C89ED0", VA = "0x188C8B8D0")]
	private void HANGLBKFCOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x8C8BFC0", Offset = "0x8C8A5C0", VA = "0x188C8BFC0")]
	[CompilerGenerated]
	private object LFADABMOPLE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class GPHCHIGDOHF
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x8C96F80", Offset = "0x8C95580", VA = "0x188C96F80")]
	public static FGMEJBOADAD PPPIHOJNMPG(this PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class NHKMLOLNFJA : AIDOMGKBOCG, KAHJDDJMFJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly CGIBJHLBEOL IJBOEHJOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly CJOALINNILP<PLDICLLJPJP> POIGENADBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool EELIHFMNNIO;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public CJOALINNILP<PLDICLLJPJP> KKPBOGMDGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 IIJIBBGLIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8C9FA00", Offset = "0x8C9E000", VA = "0x188C9FA00", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 INODLPFDIBB
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8C9FA30", Offset = "0x8C9E030", VA = "0x188C9FA30", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 HJDKOMOPEEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8C9FD90", Offset = "0x8C9E390", VA = "0x188C9FD90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public PLDICLLJPJP ALHLMGJKLGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8C9F950", Offset = "0x8C9DF50", VA = "0x188C9F950", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x8CA05A0", Offset = "0x8C9EBA0", VA = "0x188CA05A0")]
	public NHKMLOLNFJA(PLDICLLJPJP IJBOEHJOLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x8C9F8E0", Offset = "0x8C9DEE0", VA = "0x188C9F8E0", Slot = "8")]
	public void EFFGNEIFOGH(PLDICLLJPJP IGDHFGFJBMG, object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x8C9FD30", Offset = "0x8C9E330", VA = "0x188C9FD30", Slot = "9")]
	public void KHAHHAILDGM(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x8C9FE70", Offset = "0x8C9E470", VA = "0x188C9FE70")]
	private Vector3 OGNADAOLGBG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x8CA0210", Offset = "0x8C9E810", VA = "0x188CA0210")]
	private void OIMEDAOPGID(PLDICLLJPJP LPAPACCOGKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class NEALBPNIJFM
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8C9F820", Offset = "0x8C9DE20", VA = "0x188C9F820")]
	public static AIDOMGKBOCG GBJGGJHIBBJ(this PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class FLMNGNCNBGI : LOHGKNGOLFD, GPMCHLMMEPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly CGIBJHLBEOL IJBOEHJOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 PLICJHAOKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 NHEBLHFDEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float CJLHMOPKCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float EFHOLEINOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 HMHODBKOENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? JFAHPEHHCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? EGBMJDKPNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool IJCOEFIAPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool OHBOEENEDKK;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 GLMKMJCCMFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1910AA0", Offset = "0x190F0A0", VA = "0x181910AA0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8C968A0", Offset = "0x8C94EA0", VA = "0x188C968A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 DNILPNFLHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8C96950", Offset = "0x8C94F50", VA = "0x188C96950", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float NJLFNJHOGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xE71F20", Offset = "0xE70520", VA = "0x180E71F20", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8C96070", Offset = "0x8C94670", VA = "0x188C96070")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float FOBMOJJLBHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xD5D9C0", Offset = "0xD5BFC0", VA = "0x180D5D9C0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8C94680", Offset = "0x8C92C80", VA = "0x188C94680", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 PEKCLGMLGCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8C94BB0", Offset = "0x8C931B0", VA = "0x188C94BB0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion DHIIINIAGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8C96180", Offset = "0x8C94780", VA = "0x188C96180", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody CLHIEGMEABN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8C96850", Offset = "0x8C94E50", VA = "0x188C96850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event OICGOOGFDLN DBCFGLGIEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C963F0", Offset = "0x8C949F0", VA = "0x188C963F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8C967B0", Offset = "0x8C94DB0", VA = "0x188C967B0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8C96E20", Offset = "0x8C95420", VA = "0x188C96E20")]
	public FLMNGNCNBGI(PLDICLLJPJP IJBOEHJOLPI, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8C96D00", Offset = "0x8C95300", VA = "0x188C96D00", Slot = "17")]
	public void OHKMNDOPGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8C96A40", Offset = "0x8C95040", VA = "0x188C96A40", Slot = "16")]
	public void MAOPACCHBPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8C95110", Offset = "0x8C93710", VA = "0x188C95110", Slot = "19")]
	public void DFCOIFJKDHH(Rigidbody LGAEALOIBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8C96B20", Offset = "0x8C95120", VA = "0x188C96B20", Slot = "20")]
	public void ODEPCPHAJKB(Rigidbody LGAEALOIBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8C94F70", Offset = "0x8C93570", VA = "0x188C94F70", Slot = "18")]
	public void DBEFIDEPKFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8C94730", Offset = "0x8C92D30", VA = "0x188C94730", Slot = "21")]
	public void APDJCIBGIJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8C968A0", Offset = "0x8C94EA0", VA = "0x188C968A0")]
	private void KPLFDLALANL(Vector3 FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8C96300", Offset = "0x8C94900", VA = "0x188C96300")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 IHBPNFLDODJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8C96070", Offset = "0x8C94670", VA = "0x188C96070")]
	private void OGMFALNAJKD(float FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8C94680", Offset = "0x8C92C80", VA = "0x188C94680")]
	private void ADPCDKMPFAE(float FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8C96490", Offset = "0x8C94A90", VA = "0x188C96490")]
	private Vector3 JAIPIBPPKCP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8C94D40", Offset = "0x8C93340", VA = "0x188C94D40", Slot = "15")]
	public void CEJCFBDIFHI((Quaternion rot, Vector3 moments) ALGBGLDGENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8C96630", Offset = "0x8C94C30", VA = "0x188C96630")]
	private Quaternion JFBOPJEMBLP()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8C95FA0", Offset = "0x8C945A0", VA = "0x188C95FA0")]
	public void EEIGIIAKPMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8C951F0", Offset = "0x8C937F0", VA = "0x188C951F0", Slot = "4")]
	public (float, Vector3) EEIGIIAKPMG(Rigidbody DLJHKAMHMCM)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class LCFNGMECPFB
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8C9B050", Offset = "0x8C99650", VA = "0x188C9B050")]
	public static LOHGKNGOLFD APPPJBNDCIP(this PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class NIJBHACBOFJ : BGFKPDEBMLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly CGIBJHLBEOL IJBOEHJOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly JHDOLFBOEBO CBFAOPAIOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly DJKEJGBLBEI PNGGNDMGCFO;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool NGBFFMMIJON
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1AD8590", Offset = "0x1AD6B90", VA = "0x181AD8590", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public DJKEJGBLBEI KAJJANDGHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xAEE830", Offset = "0xAECE30", VA = "0x180AEE830", Slot = "11")]
		get
		{
			return default(DJKEJGBLBEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8CA0CD0", Offset = "0x8C9F2D0", VA = "0x188CA0CD0")]
	public NIJBHACBOFJ(PLDICLLJPJP IJBOEHJOLPI, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8CA0A50", Offset = "0x8C9F050", VA = "0x188CA0A50", Slot = "4")]
	public void IPAAAFNGFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8CA0940", Offset = "0x8C9EF40", VA = "0x188CA0940")]
	private bool GDIHMBCMKNL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8CA0A20", Offset = "0x8C9F020", VA = "0x188CA0A20", Slot = "5")]
	public void INMCFPMNNCE(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8CA0C60", Offset = "0x8C9F260", VA = "0x188CA0C60", Slot = "6")]
	public void JHLHACFPCMJ(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8CA0B20", Offset = "0x8C9F120", VA = "0x188CA0B20", Slot = "9")]
	public void IPLDOBNDFMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8CA0820", Offset = "0x8C9EE20", VA = "0x188CA0820")]
	private void DCJDMLBDAFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8CA06A0", Offset = "0x8C9ECA0", VA = "0x188CA06A0")]
	private void AODKBEJENNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8CA0C90", Offset = "0x8C9F290", VA = "0x188CA0C90", Slot = "8")]
	public void LGMDNOJJMEI(PLDICLLJPJP IJBOEHJOLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8CA09E0", Offset = "0x8C9EFE0", VA = "0x188CA09E0", Slot = "7")]
	public void HLDEHJHDEFG(PLDICLLJPJP IJBOEHJOLPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class LADOBJCJBGO : BOAFDABLKEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly CGIBJHLBEOL IJBOEHJOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly JHDOLFBOEBO PJOELDAIIBE;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool MCNFPMEGDEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8C9AE00", Offset = "0x8C99400", VA = "0x188C9AE00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event OICGOOGFDLN MFLBPACFDJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8C9AD30", Offset = "0x8C99330", VA = "0x188C9AD30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8C9AEC0", Offset = "0x8C994C0", VA = "0x188C9AEC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8C9AF60", Offset = "0x8C99560", VA = "0x188C9AF60")]
	public LADOBJCJBGO(PLDICLLJPJP IJBOEHJOLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8C9AEB0", Offset = "0x8C994B0", VA = "0x188C9AEB0", Slot = "7")]
	public void ONLHPHHECIP(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x8C9ACE0", Offset = "0x8C992E0", VA = "0x188C9ACE0", Slot = "8")]
	public void DGNOOINKJNB(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8C9AB50", Offset = "0x8C99150", VA = "0x188C9AB50", Slot = "9")]
	public void BJEFIKGNLAO(object HNGIMMGBLII, bool DHIOOCFCCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x8C9ACF0", Offset = "0x8C992F0", VA = "0x188C9ACF0", Slot = "12")]
	public void EOEICIMFMAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x8C9AC60", Offset = "0x8C99260", VA = "0x188C9AC60", Slot = "10")]
	public void DFCOIFJKDHH(Rigidbody JBKOGKCDDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x8C9ADD0", Offset = "0x8C993D0", VA = "0x188C9ADD0", Slot = "11")]
	public void ODEPCPHAJKB(Rigidbody LGAEALOIBKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class KPGMDBAPJEG : BNLIPANDPGF, KAGNOCNDELF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly CGIBJHLBEOL IJBOEHJOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private RRNetworkView HPPGNKNPKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool CCDNHLBGCAD;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public RRNetworkView GLEINKGNCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool HEKMOFNACBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8C99FD0", Offset = "0x8C985D0", VA = "0x188C99FD0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool BNBDFJENCAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xC3A790", Offset = "0xC38D90", VA = "0x180C3A790", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event OICGOOGFDLN FMPAJDHFJFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8C9A4A0", Offset = "0x8C98AA0", VA = "0x188C9A4A0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8C9A950", Offset = "0x8C98F50", VA = "0x188C9A950", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8C9A9F0", Offset = "0x8C98FF0", VA = "0x188C9A9F0")]
	public KPGMDBAPJEG(PLDICLLJPJP IJBOEHJOLPI, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x8C9A6B0", Offset = "0x8C98CB0", VA = "0x188C9A6B0", Slot = "9")]
	public void IPAAAFNGFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x8C9A130", Offset = "0x8C98730", VA = "0x188C9A130", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x8C9A7E0", Offset = "0x8C98DE0", VA = "0x188C9A7E0", Slot = "10")]
	public void KAEMEIPDGOB(PLDICLLJPJP IGDHFGFJBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x8C99E60", Offset = "0x8C98460", VA = "0x188C99E60", Slot = "11")]
	public void ADLPKEDLIEF(PLDICLLJPJP IGDHFGFJBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x8C9A540", Offset = "0x8C98B40", VA = "0x188C9A540")]
	private void HAAPEHMJONM(RRNetworkView NEDLPPKGNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x8C99FE0", Offset = "0x8C985E0", VA = "0x188C99FE0")]
	private void DLIKKFNALNJ(FFEDAAPDFJC PKKOOFMJNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x8C9A230", Offset = "0x8C98830", VA = "0x188C9A230")]
	private void FMHLDFMBGMO(RRNetworkView DFJDJAKBIAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class HCFIEJMNNLE
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x8C97640", Offset = "0x8C95C40", VA = "0x188C97640")]
	public static BNLIPANDPGF HHINGAKJBCE(this PLDICLLJPJP FCFHEFKEJPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class JNJBDNELKOJ : CNKLEFKBHPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly CGIBJHLBEOL IJBOEHJOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints DEJICCKHMKI;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool CCPFHDGJAOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xB52370", Offset = "0xB50970", VA = "0x180B52370", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xE8C4B0", Offset = "0xE8AAB0", VA = "0x180E8C4B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool FABMDJHCNGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xB521E0", Offset = "0xB507E0", VA = "0x180B521E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xE8BCB0", Offset = "0xE8A2B0", VA = "0x180E8BCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints OKJBFKCHAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xA9D650", Offset = "0xA9BC50", VA = "0x180A9D650", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8C98BB0", Offset = "0x8C971B0", VA = "0x188C98BB0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x8C98D10", Offset = "0x8C97310", VA = "0x188C98D10")]
	public JNJBDNELKOJ(PLDICLLJPJP IJBOEHJOLPI, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x8C98B80", Offset = "0x8C97180", VA = "0x188C98B80", Slot = "9")]
	public void DFCOIFJKDHH(Rigidbody LGAEALOIBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x8C98CE0", Offset = "0x8C972E0", VA = "0x188C98CE0", Slot = "10")]
	public void ODEPCPHAJKB(Rigidbody LGAEALOIBKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class COBLGCHKLLP : ICFCJEOGKBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly PLDICLLJPJP IJBOEHJOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float KAAAMHOCBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float LFAINPAOKPB;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float PMANGOFGHII
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xAF2AF0", Offset = "0xAF10F0", VA = "0x180AF2AF0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8C93EF0", Offset = "0x8C924F0", VA = "0x188C93EF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float ONJNNFJBIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xAF2EB0", Offset = "0xAF14B0", VA = "0x180AF2EB0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8C93E20", Offset = "0x8C92420", VA = "0x188C93E20", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8C94060", Offset = "0x8C92660", VA = "0x188C94060")]
	public COBLGCHKLLP(PLDICLLJPJP IJBOEHJOLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x8C93DD0", Offset = "0x8C923D0", VA = "0x188C93DD0", Slot = "8")]
	public void DFCOIFJKDHH(Rigidbody LGAEALOIBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x8C93FC0", Offset = "0x8C925C0", VA = "0x188C93FC0", Slot = "9")]
	public void ODEPCPHAJKB(Rigidbody LGAEALOIBKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class MOPCLIJPHMA : HDEFBLMJDIC
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly IDGHEFJHGEI HFPDMELPDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly CGIBJHLBEOL IJBOEHJOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool JDJHIDLFDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool OCNEBHPHBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int BOHOPGKBLIK;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody CLHIEGMEABN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8C96850", Offset = "0x8C94E50", VA = "0x188C96850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool PHIIPJINHBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8C9B930", Offset = "0x8C99F30", VA = "0x188C9B930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private PLDICLLJPJP DHPGFGLBJLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8C9B780", Offset = "0x8C99D80", VA = "0x188C9B780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool HGAPFBEBFEO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8C9BB00", Offset = "0x8C9A100", VA = "0x188C9BB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event OICGOOGFDLN DEMIOKNLJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8C9B3B0", Offset = "0x8C999B0", VA = "0x188C9B3B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8C9B9F0", Offset = "0x8C99FF0", VA = "0x188C9B9F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8C9BE70", Offset = "0x8C9A470", VA = "0x188C9BE70")]
	public MOPCLIJPHMA(PLDICLLJPJP IJBOEHJOLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8C9B6E0", Offset = "0x8C99CE0", VA = "0x188C9B6E0", Slot = "6")]
	public void IPAAAFNGFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x8C9B770", Offset = "0x8C99D70", VA = "0x188C9B770", Slot = "8")]
	public void IPEDNLNNOFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8C9B7E0", Offset = "0x8C99DE0", VA = "0x188C9B7E0", Slot = "7")]
	public bool LPKIDOLJMEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x8C9B950", Offset = "0x8C99F50", VA = "0x188C9B950", Slot = "9")]
	public void MFIKAIGMEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8C9B510", Offset = "0x8C99B10", VA = "0x188C9B510", Slot = "13")]
	public void HNKCBEMPAEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8C9B5B0", Offset = "0x8C99BB0", VA = "0x188C9B5B0", Slot = "12")]
	public void IDKFKBHMBNP(bool JGGJDFHIBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8C9BA90", Offset = "0x8C9A090", VA = "0x188C9BA90", Slot = "10")]
	public bool NGHBJPCKDCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8C9B450", Offset = "0x8C99A50", VA = "0x188C9B450", Slot = "11")]
	public bool HHHMLDEGGOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8C9BB60", Offset = "0x8C9A160", VA = "0x188C9BB60")]
	private bool OPENCPCAMGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8C9B220", Offset = "0x8C99820", VA = "0x188C9B220")]
	private void BPJPOGGEMFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class BDDBHJJNDAC : HNNFBOBCKAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly CGIBJHLBEOL IJBOEHJOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly JHDOLFBOEBO JKNAKGLMJLB;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody CLHIEGMEABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xA98C70", Offset = "0xA97270", VA = "0x180A98C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool HGAPFBEBFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x8C8D310", Offset = "0x8C8B910", VA = "0x188C8D310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool GEMDHGOGNDB
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1AD8590", Offset = "0x1AD6B90", VA = "0x181AD8590", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8C8D520", Offset = "0x8C8BB20", VA = "0x188C8D520")]
	public BDDBHJJNDAC(PLDICLLJPJP IJBOEHJOLPI, [In] HAPFNJKACCD DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8C8D270", Offset = "0x8C8B870", VA = "0x188C8D270", Slot = "5")]
	public void IPAAAFNGFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x8C8D240", Offset = "0x8C8B840", VA = "0x188C8D240", Slot = "7")]
	public void HMMOKBBCAPF(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x8C8D370", Offset = "0x8C8B970", VA = "0x188C8D370", Slot = "8")]
	public void OCGIEAAEOMB(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8C8CD20", Offset = "0x8C8B320", VA = "0x188C8CD20", Slot = "9")]
	public void CIJFLOMMIBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8C8D050", Offset = "0x8C8B650", VA = "0x188C8D050", Slot = "10")]
	public void GHPJOMAIPBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x8C8D3A0", Offset = "0x8C8B9A0", VA = "0x188C8D3A0", Slot = "11")]
	public void OMPPOLLLEEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class NBOJPINNGAE : NPMNJKMFHED, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly CGIBJHLBEOL IJBOEHJOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly JHDOLFBOEBO JIKNPDJJALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float KCCPFDPCEPO;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public GMILAJLHIHL GHNHKBGKCPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA94FF0", Offset = "0xA935F0", VA = "0x180A94FF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA991A0", VA = "0x180A9ABA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CAFAOJANFEB IADNEHFBALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA95010", Offset = "0xA93610", VA = "0x180A95010", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB80", Offset = "0xA99180", VA = "0x180A9AB80", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 HJDKOMOPEEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8C9F370", Offset = "0x8C9D970", VA = "0x188C9F370", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8C9E180", Offset = "0x8C9C780", VA = "0x188C9E180", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 LOBPBIDCCFC
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8C9C510", Offset = "0x8C9AB10", VA = "0x188C9C510", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8C9EB60", Offset = "0x8C9D160", VA = "0x188C9EB60", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 AOPBBIIEBFD
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8C9F1A0", Offset = "0x8C9D7A0", VA = "0x188C9F1A0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8C9E400", Offset = "0x8C9CA00", VA = "0x188C9E400", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 DBCICGFIPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8C9D730", Offset = "0x8C9BD30", VA = "0x188C9D730", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8C9DB10", Offset = "0x8C9C110", VA = "0x188C9DB10", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float MPNFMFDJKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xAF2EC0", Offset = "0xAF14C0", VA = "0x180AF2EC0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8C9D8C0", Offset = "0x8C9BEC0", VA = "0x188C9D8C0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool GGNDCMPEAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2537F30", Offset = "0x2536530", VA = "0x182537F30", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private OOAJDKPDCGI JGCABONHCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x81B7090", Offset = "0x81B5690", VA = "0x1881B7090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool PHIIPJINHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8C9EB40", Offset = "0x8C9D140", VA = "0x188C9EB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x8C9F730", Offset = "0x8C9DD30", VA = "0x188C9F730")]
	public NBOJPINNGAE(PLDICLLJPJP IJBOEHJOLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8C9DB40", Offset = "0x8C9C140", VA = "0x188C9DB40", Slot = "19")]
	public void IPAAAFNGFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x8C9CDE0", Offset = "0x8C9B3E0", VA = "0x188C9CDE0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8C9CCB0", Offset = "0x8C9B2B0", VA = "0x188C9CCB0", Slot = "28")]
	public void DFCOIFJKDHH(Rigidbody LGAEALOIBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x189BC80", Offset = "0x189A280", VA = "0x18189BC80", Slot = "20")]
	public void MCAOMLPFNNL(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x189C160", Offset = "0x189A760", VA = "0x18189C160", Slot = "30")]
	public void NMIJBGAIDDB(object HNGIMMGBLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8C9E960", Offset = "0x8C9CF60", VA = "0x188C9E960", Slot = "35")]
	public Vector3 MBADFDKJKOF(Vector3 AOFGNGADMDL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8C9E240", Offset = "0x8C9C840", VA = "0x188C9E240", Slot = "34")]
	public Vector3 KLMGPDGEODJ(Vector3 ECJAEJHHBNF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x8C9DB40", Offset = "0x8C9C140", VA = "0x188C9DB40", Slot = "27")]
	public void LELKILHBIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8C9F6D0", Offset = "0x8C9DCD0", VA = "0x188C9F6D0", Slot = "25")]
	public void PEIEDHEIIDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8C9D9D0", Offset = "0x8C9BFD0", VA = "0x188C9D9D0", Slot = "24")]
	public void ICFFCJEMLOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x8C9D4F0", Offset = "0x8C9BAF0", VA = "0x188C9D4F0", Slot = "33")]
	public void HFNJMCGIBDL(Vector3 PHJHLLDKOJF, Vector3 DPFKBGCGGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8C9F140", Offset = "0x8C9D740", VA = "0x188C9F140", Slot = "32")]
	public void NGAHBCOFFOH(Vector3 LOHJNHEMLOP, Vector3 MPFAFOAJOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8C9CB10", Offset = "0x8C9B110", VA = "0x188C9CB10", Slot = "31")]
	public void CAOIBOCPLFB(Vector3 NIGGFNPPODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x8C9CE40", Offset = "0x8C9B440", VA = "0x188C9CE40", Slot = "22")]
	public void EKFCJPEDPKI(MILMBLMNICG IOFMKIHBING, Vector3 CGEBBGCIENO, float EPAAIIHMNGB, float EHJKHHAKCNE = 8f, float BCAICAPEAID = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8C9DBF0", Offset = "0x8C9C1F0", VA = "0x188C9DBF0", Slot = "21")]
	public void JHFAPBDGALA(AJEKPFKLAEG KCELOENKKEK, Vector3 OEJOJNFFOKK, float CDOHNMIAGPG = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8C9E4C0", Offset = "0x8C9CAC0", VA = "0x188C9E4C0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void LFCBDCAHKHC(AJEKPFKLAEG KCELOENKKEK, Vector3 NEOIPHFFLHF, float LCJCHDBLDCK = 7f, float FELCNEKKNNF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x19E5C60", Offset = "0x19E4260", VA = "0x1819E5C60")]
	private static void CJIDPMBFHHH(Vector3 NCEIMCLGMCB, Vector3 NNMAALGIDJM, [Out] Vector3 OFJCFGHJEMB, [Out] Vector3 OCAPJLGEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8C9DA30", Offset = "0x8C9C030", VA = "0x188C9DA30", Slot = "29")]
	public Vector3 IHMJIAJEBDO(Vector3 NCEIMCLGMCB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8C9DE70", Offset = "0x8C9C470", VA = "0x188C9DE70", Slot = "26")]
	public void JHFDPCGJHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8C9D8C0", Offset = "0x8C9BEC0", VA = "0x188C9D8C0")]
	private void IBDNABIKHNC(float FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x8C9F530", Offset = "0x8C9DB30", VA = "0x188C9F530")]
	private void OGFIDPLMOPM(Vector3 OEJOJNFFOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x8C9E000", Offset = "0x8C9C600", VA = "0x188C9E000")]
	private Vector3 JJPHHLOBBGJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8C9C690", Offset = "0x8C9AC90", VA = "0x188C9C690")]
	private void BPHDOHNECNJ(Vector3 ECJAEJHHBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8C9C380", Offset = "0x8C9A980", VA = "0x188C9C380")]
	private Vector3 BHEDMPCICNL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x8C9BF00", Offset = "0x8C9A500", VA = "0x188C9BF00")]
	private void ALBNFIGOEBM(Vector3 FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8C9EB90", Offset = "0x8C9D190", VA = "0x188C9EB90")]
	private void MJIGFEPBKMH(Vector3 ECJAEJHHBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8C9E8B0", Offset = "0x8C9CEB0", VA = "0x188C9E8B0")]
	private void LFJAKKNMIPB()
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
