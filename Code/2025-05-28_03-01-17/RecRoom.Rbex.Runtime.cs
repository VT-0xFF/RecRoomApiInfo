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
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x85675F0", Offset = "0x85663F0", VA = "0x1885675F0", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x20D9300", Offset = "0x20D8100", VA = "0x1820D9300", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x857A230", Offset = "0x8579030", VA = "0x18857A230")]
		private void OCIJCOAIOEO(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x857A540", Offset = "0x8579340", VA = "0x18857A540", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x857A5A0", Offset = "0x85793A0", VA = "0x18857A5A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, DJKODAHGDFK, GCNHNEMJEGC, PJMNNLIOKLG
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly IEBEPMGFCGH LJLBGELJOLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool CECPDLCJHJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private BNEBJELOGPG JKHMJIJBOFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[HIEDJMGIPME(CBEHFHOOABN.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[HIEDJMGIPME(CBEHFHOOABN.SelfAndParent, true, false, false)]
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
		private JFLNIIIFAEP physicsInterpolation;

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
		private Transform DDLGHMMPBFM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal BNEBJELOGPG COAOHHEADPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8574D40", Offset = "0x8573B40", VA = "0x188574D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private BNEBJELOGPG GBKGLBMACOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int NKEJNNNELDL
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8577700", Offset = "0x8576500", VA = "0x188577700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx GKFPPNIIGNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8577A60", Offset = "0x8576860", VA = "0x188577A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx NLFMPGFBLLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x85779A0", Offset = "0x85767A0", VA = "0x1885779A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx BOGJJGPKPIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8578670", Offset = "0x8577470", VA = "0x188578670")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8579BA0", Offset = "0x85789A0", VA = "0x188579BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool BHAGMIIGHDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x81BC210", Offset = "0x81BB010", VA = "0x1881BC210", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x81BB410", Offset = "0x81BA210", VA = "0x1881BB410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform MAAFBDAKBJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1F053A0", Offset = "0x1F041A0", VA = "0x181F053A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform OFFEHAJMANB
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1F053A0", Offset = "0x1F041A0", VA = "0x181F053A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform MDGKGHNFJPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1F053A0", Offset = "0x1F041A0", VA = "0x181F053A0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public HGOCJAJAHJN PGJAPNAKKJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8577760", Offset = "0x8576560", VA = "0x188577760")]
			get
			{
				return default(HGOCJAJAHJN);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8579350", Offset = "0x8578150", VA = "0x188579350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool OBEEEOBKNAD
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8577D70", Offset = "0x8576B70", VA = "0x188577D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool HGOEAGNGJNI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8577880", Offset = "0x8576680", VA = "0x188577880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FDHABFHCHKN OMKJBICJOEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8577CB0", Offset = "0x8576AB0", VA = "0x188577CB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8579510", Offset = "0x8578310", VA = "0x188579510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public MOFBPFIADAD MCPIALHDBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8577C50", Offset = "0x8576A50", VA = "0x188577C50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x85794A0", Offset = "0x85782A0", VA = "0x1885794A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OBIOFDBDDHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8577BA0", Offset = "0x85769A0", VA = "0x188577BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody FHACEMLODOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8577C00", Offset = "0x8576A00", VA = "0x188577C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool KLMCKAAMJHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x85778E0", Offset = "0x85766E0", VA = "0x1885778E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x85793C0", Offset = "0x85781C0", VA = "0x1885793C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool FDJCMEEJGNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x17005E0", Offset = "0x16FF3E0", VA = "0x1817005E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float EAPKNENOEOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8578610", Offset = "0x8577410", VA = "0x188578610")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float NADMIGILEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x85785B0", Offset = "0x85773B0", VA = "0x1885785B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8579B30", Offset = "0x8578930", VA = "0x188579B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float LBCDGKAHFJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8577FD0", Offset = "0x8576DD0", VA = "0x188577FD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x85797B0", Offset = "0x85785B0", VA = "0x1885797B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float ABGFEBJEBMA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8577DD0", Offset = "0x8576BD0", VA = "0x188577DD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8579580", Offset = "0x8578380", VA = "0x188579580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool FOJOLIKPONN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8578BF0", Offset = "0x85779F0", VA = "0x188578BF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x857A0E0", Offset = "0x8578EE0", VA = "0x18857A0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 NABAHGCCFFO
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8578390", Offset = "0x8577190", VA = "0x188578390")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8579900", Offset = "0x8578700", VA = "0x188579900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 OLENGDONHJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8578D30", Offset = "0x8577B30", VA = "0x188578D30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode LIJAODJIECH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8577F10", Offset = "0x8576D10", VA = "0x188577F10")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x85796D0", Offset = "0x85784D0", VA = "0x1885796D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float AEBOBMEJAAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8577940", Offset = "0x8576740", VA = "0x188577940")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8579430", Offset = "0x8578230", VA = "0x188579430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints JLLEEMLPJAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8577F70", Offset = "0x8576D70", VA = "0x188577F70")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8579740", Offset = "0x8578540", VA = "0x188579740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 GEELHADHEEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8578730", Offset = "0x8577530", VA = "0x188578730")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 MLAEGLPHOCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8578730", Offset = "0x8577530", VA = "0x188578730")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8579EC0", Offset = "0x8578CC0", VA = "0x188579EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float HNMJCJFPGDA
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8578470", Offset = "0x8577270", VA = "0x188578470")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x85799E0", Offset = "0x85787E0", VA = "0x1885799E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float PEEEKBHEDIB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8578B90", Offset = "0x8577990", VA = "0x188578B90")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x857A070", Offset = "0x8578E70", VA = "0x18857A070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion PLPCBPBBKGK
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8578810", Offset = "0x8577610", VA = "0x188578810")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8579C40", Offset = "0x8578A40", VA = "0x188579C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion GNOJBGBHDMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8578AB0", Offset = "0x85778B0", VA = "0x188578AB0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8579FA0", Offset = "0x8578DA0", VA = "0x188579FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 PKCOOMJEHEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x85788F0", Offset = "0x85776F0", VA = "0x1885788F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8579D10", Offset = "0x8578B10", VA = "0x188579D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion FJIDIGHPGND
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x85789D0", Offset = "0x85777D0", VA = "0x1885789D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8579DF0", Offset = "0x8578BF0", VA = "0x188579DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 GPBPHJJLKFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8578C50", Offset = "0x8577A50", VA = "0x188578C50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x857A150", Offset = "0x8578F50", VA = "0x18857A150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 EKLGFNDJLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x85784D0", Offset = "0x85772D0", VA = "0x1885784D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8579A50", Offset = "0x8578850", VA = "0x188579A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 MFGCBODNMPM
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8577E30", Offset = "0x8576C30", VA = "0x188577E30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x85795F0", Offset = "0x85783F0", VA = "0x1885795F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 OJFGKMMJPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x85782B0", Offset = "0x85770B0", VA = "0x1885782B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8579820", Offset = "0x8578620", VA = "0x188579820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 AHJDHJIPGEH
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8578170", Offset = "0x8576F70", VA = "0x188578170")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion BLDKPPGJBJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8578090", Offset = "0x8576E90", VA = "0x188578090")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 EKBOMDNLKDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8578EF0", Offset = "0x8577CF0", VA = "0x188578EF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 BIDABMDAAKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8578E10", Offset = "0x8577C10", VA = "0x188578E10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool GJCAAIAAPHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8578250", Offset = "0x8577050", VA = "0x188578250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool JAMFLBLKLCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8577D10", Offset = "0x8576B10", VA = "0x188577D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool IJCDCBNNFJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8577820", Offset = "0x8576620", VA = "0x188577820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool HFOKOBOEGEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x85777C0", Offset = "0x85765C0", VA = "0x1885777C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool CEKBMCHJIHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x85776A0", Offset = "0x85764A0", VA = "0x1885776A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool KIOJFIGDIIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8578030", Offset = "0x8576E30", VA = "0x188578030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool KNAODMGEKMM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x23DEAB0", Offset = "0x23DD8B0", VA = "0x1823DEAB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event GLOLNKBBBNH GAOBLOFINPI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x85775C0", Offset = "0x85763C0", VA = "0x1885775C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8579270", Offset = "0x8578070", VA = "0x188579270")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event MIOLGGFIPGF JBDBHPAPKOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8577330", Offset = "0x8576130", VA = "0x188577330")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8578FD0", Offset = "0x8577DD0", VA = "0x188578FD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event MIOLGGFIPGF OMPAMMEAHDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8577390", Offset = "0x8576190", VA = "0x188577390")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8579040", Offset = "0x8577E40", VA = "0x188579040")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event MIOLGGFIPGF ECEHECCAFCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x85774E0", Offset = "0x85762E0", VA = "0x1885774E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8579190", Offset = "0x8577F90", VA = "0x188579190")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<MOCFDENFFJA, MOCFDENFFJA> PJDFMBOFOKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8577470", Offset = "0x8576270", VA = "0x188577470")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8579120", Offset = "0x8577F20", VA = "0x188579120")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event MIOLGGFIPGF JIDJGAHGIKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8577550", Offset = "0x8576350", VA = "0x188577550")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8579200", Offset = "0x8578000", VA = "0x188579200")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event MIOLGGFIPGF FCFCLNLHBLO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8577630", Offset = "0x8576430", VA = "0x188577630")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x85792E0", Offset = "0x85780E0", VA = "0x1885792E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event MIOLGGFIPGF ABKDDFPNAPP
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8577400", Offset = "0x8576200", VA = "0x188577400")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x85790B0", Offset = "0x8577EB0", VA = "0x1885790B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40", Slot = "8")]
		private void JGACOLELNHP(BNEBJELOGPG OMKBHAHHOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8575E30", Offset = "0x8574C30", VA = "0x188575E30", Slot = "9")]
		public MGCLLADFKEL GetData()
		{
			return default(MGCLLADFKEL);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8575910", Offset = "0x8574710", VA = "0x188575910")]
		internal void CMNFHABEBNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8577050", Offset = "0x8575E50", VA = "0x188577050")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody NHFMMANDNBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8575B80", Offset = "0x8574980", VA = "0x188575B80")]
		public DJKODAHGDFK GetChild(int GLAOLHCPLLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8576D10", Offset = "0x8575B10", VA = "0x188576D10")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) AHPJADDOMJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8575740", Offset = "0x8574540", VA = "0x188575740")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8576FA0", Offset = "0x8575DA0", VA = "0x188576FA0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8574D40", Offset = "0x8573B40", VA = "0x188574D40")]
		private BNEBJELOGPG JJGKOMAPJFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8575EC0", Offset = "0x8574CC0", VA = "0x188575EC0")]
		private void HLJFBNEKAGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x85764E0", Offset = "0x85752E0", VA = "0x1885764E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8576420", Offset = "0x8575220", VA = "0x188576420")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8575910", Offset = "0x8574710", VA = "0x188575910")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8576480", Offset = "0x8575280", VA = "0x188576480")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8576540", Offset = "0x8575340", VA = "0x188576540")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8574DF0", Offset = "0x8573BF0", VA = "0x188574DF0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object JLFLGDNCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x85765A0", Offset = "0x85753A0", VA = "0x1885765A0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object JLFLGDNCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8575B20", Offset = "0x8574920", VA = "0x188575B20")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x85763B0", Offset = "0x85751B0", VA = "0x1885763B0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8576E70", Offset = "0x8575C70", VA = "0x188576E70")]
		public void SetParent(RigidbodyEx OAIIHELJHLG, bool EJHHHIDNFHE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x85768B0", Offset = "0x85756B0", VA = "0x1885768B0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8576040", Offset = "0x8574E40", VA = "0x188576040")]
		public bool IsRigidbodyAncestor(RigidbodyEx DGLJECBLJJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8576140", Offset = "0x8574F40", VA = "0x188576140")]
		public bool IsRigidbodyDescendant(RigidbodyEx LPPAACKLBDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8575060", Offset = "0x8573E60", VA = "0x188575060")]
		public void AddInterpolationRestriction(object JLFLGDNCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8576610", Offset = "0x8575410", VA = "0x188576610")]
		public void RemoveInterpolationRestriction(object JLFLGDNCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x85750D0", Offset = "0x8573ED0", VA = "0x1885750D0")]
		public void AddKinematic(object JLFLGDNCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8576680", Offset = "0x8575480", VA = "0x188576680")]
		public void RemoveKinematic(object JLFLGDNCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8576DF0", Offset = "0x8575BF0", VA = "0x188576DF0")]
		public void SetKinematic(object JLFLGDNCANL, bool OHLMJEAGLOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8576C10", Offset = "0x8575A10", VA = "0x188576C10")]
		public void SetDiscontinuousPositionAndRotation(Vector3 CJHBACNEMHB, Quaternion PLDKEAJHIEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8576B10", Offset = "0x8575910", VA = "0x188576B10")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 MNIAPMAMIPF, Quaternion HLNCFPIIEDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8575D20", Offset = "0x8574B20", VA = "0x188575D20")]
		public Vector3 GetConstrainedVelocity(Vector3 GPBPHJJLKFP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8575C10", Offset = "0x8574A10", VA = "0x188575C10")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 MFGCBODNMPM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8574F70", Offset = "0x8573D70", VA = "0x188574F70")]
		public void AddForce(Vector3 PGBCKJJIOAA, ForceMode FHPLDJIAAMG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8574E60", Offset = "0x8573C60", VA = "0x188574E60")]
		public void AddForceAtPosition(Vector3 PGBCKJJIOAA, Vector3 NPJPCFKLMHD, ForceMode FHPLDJIAAMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x85752A0", Offset = "0x85740A0", VA = "0x1885752A0")]
		public void AddTorque(Vector3 BFBHEICBECE, ForceMode FHPLDJIAAMG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8575140", Offset = "0x8573F40", VA = "0x188575140")]
		public void AddRelativeTorque(Vector3 BFBHEICBECE, ForceMode FHPLDJIAAMG = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8577120", Offset = "0x8575F20", VA = "0x188577120")]
		public Vector3 WorldToLocalVelocity(Vector3 LNIADJMLGIK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x85762A0", Offset = "0x85750A0", VA = "0x1885762A0")]
		public Vector3 LocalToWorldVelocity(Vector3 EKLGFNDJLMJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8575AC0", Offset = "0x85748C0", VA = "0x188575AC0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8575A60", Offset = "0x8574860", VA = "0x188575A60")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8575A00", Offset = "0x8574800", VA = "0x188575A00")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x85759A0", Offset = "0x85747A0", VA = "0x1885759A0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8576A10", Offset = "0x8575810", VA = "0x188576A10")]
		public void ResetVelocityWorldSpace(Vector3 JJEBPBJEEKD, Vector3 EILMIBFNCJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8576910", Offset = "0x8575710", VA = "0x188576910")]
		public void ResetVelocityLocalSpace(Vector3 JHLPMGHHGEG, Vector3 OJFGKMMJPLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x85767D0", Offset = "0x85755D0", VA = "0x1885767D0")]
		public void ResetLinearVelocityLocalSpace(Vector3 JHLPMGHHGEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8576FB0", Offset = "0x8575DB0", VA = "0x188576FB0")]
		public bool SweepTest(Vector3 MACLBEFOGKL, [Out] RaycastHit EMIJFAALBFB, float HBKDKLDLCIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8576240", Offset = "0x8575040", VA = "0x188576240")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8576F40", Offset = "0x8575D40", VA = "0x188576F40")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x85770C0", Offset = "0x8575EC0", VA = "0x1885770C0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8575230", Offset = "0x8574030", VA = "0x188575230")]
		public void AddShouldHaveUnityRigidbodyToken(object JLFLGDNCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x85766F0", Offset = "0x85754F0", VA = "0x1885766F0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object JLFLGDNCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x85755D0", Offset = "0x85743D0", VA = "0x1885755D0")]
		public void ApplyForceVelocityChange(AIPGFHKOAOH LMIHCDIEAAL, Vector3 CEINDOKFBOP, float LKBJKLCFGIN, float FADCPNGFJEM = 8f, float OHMJMHHACPJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8575530", Offset = "0x8574330", VA = "0x188575530")]
		public void ApplyAngularVelocityChange(OIHNMBFPFKI HMKMOJFBDLP, Vector3 BIDDHJCLFLK, float PDNOMCMHGEH = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8575690", Offset = "0x8574490", VA = "0x188575690")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(OIHNMBFPFKI HMKMOJFBDLP, Vector3 LJIHJJKHDDH, float KGIMKDKAEAH = 7f, float AAIDDDOHLBA = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8575460", Offset = "0x8574260", VA = "0x188575460")]
		public bool AllowedScaleChange(float LILMPFGODPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8575390", Offset = "0x8574190", VA = "0x188575390")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx HKHABADDJLA, object JLFLGDNCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8576760", Offset = "0x8575560", VA = "0x188576760")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object JLFLGDNCANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8576410", Offset = "0x8575210", VA = "0x188576410", Slot = "12")]
		private void NIIGMILKAAH(GHEBJLJHKJI JAPGNGDBBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x85772C0", Offset = "0x85760C0", VA = "0x1885772C0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xBF26D0", Offset = "0xBF14D0", VA = "0x180BF26D0", Slot = "4")]
		private GameObject IHCHECPCALA()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA36800", Offset = "0xA35600", VA = "0x180A36800", Slot = "10")]
		private bool IICCIPPFFJD()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class JMHFFIAOIAF
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8564A60", Offset = "0x8563860", VA = "0x188564A60")]
	public static BNEBJELOGPG COAOHHEADPC(this RigidbodyEx OEGPMEHPDFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(MFNDJOPNJBH), new string[] { })]
public class APFKLOMBGGO : MFNDJOPNJBH, GACJOGFPDAE
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private GAFKLILLNOO LKIBPKBGCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private PMKPKFGMFHA IPBPDGOKPLK;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public GAFKLILLNOO NLOFNFPCHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public PMKPKFGMFHA FJBFLELDBCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x855E520", Offset = "0x855D320", VA = "0x18855E520", Slot = "7")]
	public void InitReferences(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x855E590", Offset = "0x855D390", VA = "0x18855E590", Slot = "6")]
	public BNEBJELOGPG JMDOHNHPAPH(RigidbodyEx OEGPMEHPDFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public APFKLOMBGGO()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static LLEAAEBCCKF UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int EPNPMPCDAFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int BLNKBEBHIBD;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8574BA0", Offset = "0x85739A0", VA = "0x188574BA0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8574BE0", Offset = "0x85739E0", VA = "0x188574BE0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8574BC0", Offset = "0x85739C0", VA = "0x188574BC0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string NJJDPBHNDPA, [Optional] UnityEngine.Object JAPGNGDBBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string NJJDPBHNDPA, [Optional] UnityEngine.Object JAPGNGDBBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8574CF0", Offset = "0x8573AF0", VA = "0x188574CF0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FKNIOOMJABH
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class JACJOPCPAAJ : FDHABFHCHKN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA19880", Offset = "0xA18680", VA = "0x180A19880", Slot = "4")]
		public Vector3 MIPMAEIOAPO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA19880", Offset = "0xA18680", VA = "0x180A19880", Slot = "5")]
		public Vector3 IEGLNGDHEDI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "6")]
		public bool CNNBFLBOMNG(float BPNOBGCHENI, float DDNJBIIKMIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JACJOPCPAAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static FDHABFHCHKN NDMIFMHBAFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8564000", Offset = "0x8562E00", VA = "0x188564000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HHAIBMMEMCB
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode MBHLFDEDGLG
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
	void IKNOEPKPIAO();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KNGHFLHLNNM(bool GJCAAIAAPHK);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JCFAKNNJDPN(bool GJCAAIAAPHK);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NDNKMHONEJJ(Rigidbody BLDBEDPDIGK);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DMLBCABMIIE(Vector3 MACLBEFOGKL, [Out] RaycastHit EMIJFAALBFB, float HBKDKLDLCIL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LDIFFGANMLL : IDisposable, OCIHNCJEHMB
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	HGOCJAJAHJN PGJAPNAKKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<MOCFDENFFJA, MOCFDENFFJA> PJDFMBOFOKG;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IKNOEPKPIAO();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface PMKPKFGMFHA
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HPCGJIHAKOF GPHGFKNAKPO(BNEBJELOGPG OMKBHAHHOCG);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LLHHCOPAKEB KEGJGHJDMIK(BNEBJELOGPG OMKBHAHHOCG);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DNPNLKDFADL FMKPPMLIPGC(BNEBJELOGPG OMKBHAHHOCG);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MCJOABAJJKH PJINEOJEPBP(BNEBJELOGPG OMKBHAHHOCG);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EDAIIDCODDL OANGGBFLGAA(BNEBJELOGPG OMKBHAHHOCG);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LDIFFGANMLL JJDFIKPEIHO(BNEBJELOGPG OMKBHAHHOCG);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CNBHBJCJNPH NDCNKCAHOGG(BNEBJELOGPG OMKBHAHHOCG);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MHOHOIEADFP CFCOIDOFGIM(BNEBJELOGPG OMKBHAHHOCG);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HHAIBMMEMCB PADKOHONIJI(BNEBJELOGPG OMKBHAHHOCG);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEAJDPNPOFP PJIGNLAPBLN(BNEBJELOGPG OMKBHAHHOCG);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FBBGHOMHJPO PCNMCCGKGPE(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	AKEEFDHPAKM JKJLBHPIPAG(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	JMCINIMLHLG CJFACGELLLO(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FBDBHAONFFI DKKAFOIFHIJ(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NOKIAGOHPFA KOLOHGKOLNK(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BNEBJELOGPG JMDOHNHPAPH(RigidbodyEx OEGPMEHPDFC, MGCLLADFKEL FFEMKICJPKP, MFNDJOPNJBH HBNPNMJNNHB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MHOHOIEADFP
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPCEOCNDDPG(Vector3 PGBCKJJIOAA, ForceMode FHPLDJIAAMG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCAGEDKPBII(Vector3 PGBCKJJIOAA, Vector3 NPJPCFKLMHD, ForceMode FHPLDJIAAMG);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJIBJJAPPOF(Vector3 BFBHEICBECE, ForceMode FHPLDJIAAMG = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FGKAGPOMBIC(Vector3 BFBHEICBECE, ForceMode FHPLDJIAAMG = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IEAJDPNPOFP
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool EBJPLFMKHIH
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
	void NDNKMHONEJJ(Rigidbody BLDBEDPDIGK);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BLHHEJJAOEF(Rigidbody BLDBEDPDIGK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HPCGJIHAKOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<BNEBJELOGPG> HFDJOFOJABH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	BNEBJELOGPG NLFMPGFBLLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	BNEBJELOGPG DPEBHIBHPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event MIOLGGFIPGF JBDBHPAPKOK;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event MIOLGGFIPGF OMPAMMEAHDD;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event GLOLNKBBBNH OKNIDFBIFFC;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action IJNCPAKFDGH;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action JJGBAEHJEPM;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<BNEBJELOGPG> BMCEEFFCONN;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<BNEBJELOGPG> PMMPBAMPOHM;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action EFLLKDKECHH;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<BNEBJELOGPG> CNMFHLCLIMC;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void GPAFCMPBBMA(BNEBJELOGPG JDMAEDJOOLD, bool EJHHHIDNFHE = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DNPNLKDFADL
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 MPGGIIMEIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 GJANFFGOPNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IAKCBPDKAFB(BNEBJELOGPG BOGJJGPKPIJ, object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LBIBOBFGGDL(object JLFLGDNCANL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FBDBHAONFFI
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 OPDEFFENGDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 KAIGLKCPEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float GECFBCCDCEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float JEDJMEDNLAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 ACFCFCBFMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion CLFAOPEJMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event MIOLGGFIPGF MMGJNCGCJCA;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GBENDDAIJNE((Quaternion rot, Vector3 moments) AHPJADDOMJM);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LDPOIEOIEFI();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OKJBFNLGKOD();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DPBIBMLABPL();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NDNKMHONEJJ(Rigidbody BLDBEDPDIGK);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BLHHEJJAOEF(Rigidbody BLDBEDPDIGK);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NAFCDPGBHMM();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JMCINIMLHLG
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKNOEPKPIAO();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDGGPMJDCLG(object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IOMKJLJBBJG(object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IOKBCONGHGE(BNEBJELOGPG OEGPMEHPDFC);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GONAAPHMPAO(BNEBJELOGPG OEGPMEHPDFC);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MEJPMENMHDO();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CNBHBJCJNPH
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool ENAMOGMAFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event MIOLGGFIPGF OHJCBMMIPBF;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LPEJKIINIKC(object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EOPGKHIKMGP(object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CCOFIEADNPD(object JLFLGDNCANL, bool OHLMJEAGLOD);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NDNKMHONEJJ(Rigidbody HDAOKPJKILI);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BLHHEJJAOEF(Rigidbody BLDBEDPDIGK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AKEEFDHPAKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool OBEEEOBKNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool HGOEAGNGJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event MIOLGGFIPGF ICELLOHJAFI;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IKNOEPKPIAO();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PDADFDJJKLH(BNEBJELOGPG BOGJJGPKPIJ);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LIICNJPIJCF(BNEBJELOGPG BOGJJGPKPIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface NOKIAGOHPFA
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool KLMCKAAMJHE
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool GLOAOAKMAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints EGIODLEBJHF
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
	void NDNKMHONEJJ(Rigidbody BLDBEDPDIGK);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BLHHEJJAOEF(Rigidbody BLDBEDPDIGK);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MCJOABAJJKH
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float IPKLHPEKCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float ICBKCCDGPOA
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
	void NDNKMHONEJJ(Rigidbody BLDBEDPDIGK);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BLHHEJJAOEF(Rigidbody BLDBEDPDIGK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EDAIIDCODDL
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool BNIHGILKJNH;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event MIOLGGFIPGF DNCDKDMCKMI;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IKNOEPKPIAO();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DIDHAIJMHEI();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DAFGFMJKANP();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AHDGJLDDOBD();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool FHNPDMMLIOI();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PBKLMENIEMG();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OGMODNJGLJH(bool GKDCAPIJGKO);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OCGFJCJDBAP();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FBBGHOMHJPO
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody FHACEMLODOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool PFAAFPLKNOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKNOEPKPIAO();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PAIOOOAKCBF(object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FEJODPCJEIF(object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OKOHNOFEHAA();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LLHHCOPAKEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	FDHABFHCHKN OMKJBICJOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	MOFBPFIADAD MCPIALHDBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 BEKHCNOKDBD
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 KJHEABGPCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 IBJNIIMABAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 AKAPJDGKLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float AEBOBMEJAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool OBIOFDBDDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void IKNOEPKPIAO();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BFEAIDNPLEH(object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BCAIEPCMGIL(OIHNMBFPFKI HMKMOJFBDLP, Vector3 BIDDHJCLFLK, float PDNOMCMHGEH = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PEBDPNDGMFB(AIPGFHKOAOH LMIHCDIEAAL, Vector3 CEINDOKFBOP, float LKBJKLCFGIN, float FADCPNGFJEM = 8f, float OHMJMHHACPJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JJDKCJPJDJL(OIHNMBFPFKI HMKMOJFBDLP, Vector3 LJIHJJKHDDH, float KGIMKDKAEAH = 7f, float AAIDDDOHLBA = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EIBNPBBNFGP();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void BKHMMDNEKOE();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NHFPIBLBNGD();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void PFJBHMKCPGL();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NDNKMHONEJJ(Rigidbody BLDBEDPDIGK);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 PJNHGDBDEGL(Vector3 GPBPHJJLKFP);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DLAEMPAMAAH(object JLFLGDNCANL);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NPAAIGDMLIN(Vector3 HGKCDPFNIKC);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CIHNMCAEGFP(Vector3 JHLPMGHHGEG, Vector3 OJFGKMMJPLJ);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void LFDGAMHBFAH(Vector3 JJEBPBJEEKD, Vector3 EILMIBFNCJC);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 FGOBHOLAFPK(Vector3 EKLGFNDJLMJ);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 KIPAKEBLEGJ(Vector3 LNIADJMLGIK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface GAFKLILLNOO
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool PGEJONHIOOH
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CGOJEKGFIPA(string NGENEEODOJL);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AEJBBOINPMN(RigidbodyEx OEGPMEHPDFC, Action CFDGGKIIHOI);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PJDHIPHKKMB MIAGLKMFJLF(int BFFPJNBFCLK);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IFDELNNMPLB(Vector3 OLENGDONHJK, float OKPEAAJJCLB, Color DEJLIDMJHPI);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface MFNDJOPNJBH
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	GAFKLILLNOO NLOFNFPCHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	PMKPKFGMFHA FJBFLELDBCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BNEBJELOGPG JMDOHNHPAPH(RigidbodyEx OEGPMEHPDFC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NOCKABCIGGP : BNEBJELOGPG, IDisposable, NCMPOFENEKP
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool AMMGJOCPMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly MFNDJOPNJBH HBNPNMJNNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal HPCGJIHAKOF JHIOCMNHFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal JMCINIMLHLG GHGLJJCJFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal AKEEFDHPAKM JFICJDHDKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal LLHHCOPAKEB GPBPHJJLKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal DNPNLKDFADL DIIDCBGDKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal FBDBHAONFFI DJFPCDFNCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal MCJOABAJJKH MEPGGPKIIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal IEAJDPNPOFP HJILJDIOCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal EDAIIDCODDL LMAKAFKJONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal LDIFFGANMLL ABAHKCLHBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal CNBHBJCJNPH LEIBEOJKCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal MHOHOIEADFP PGBCKJJIOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal NOKIAGOHPFA GHMAGCNCLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal FBBGHOMHJPO BLDBEDPDIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal HHAIBMMEMCB JJEMNNOAJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable DINFLBLCFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool GMAOLNNOOOK;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public JBBGAMGOICI EEMOFDIIGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "22")]
		get
		{
			return default(JBBGAMGOICI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public DJKODAHGDFK IOEOEPMNAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xCFC430", Offset = "0xCFB230", VA = "0x180CFC430", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xE8AF40", Offset = "0xE89D40", VA = "0x180E8AF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject DIBJMNKHENG
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA0BC20", Offset = "0xA0AA20", VA = "0x180A0BC20", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA0BC50", Offset = "0xA0AA50", VA = "0x180A0BC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform MNFKMLBDMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xD8BC60", Offset = "0xD8AA60", VA = "0x180D8BC60", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xE8DAA0", Offset = "0xE8C8A0", VA = "0x180E8DAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody FHACEMLODOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x856B740", Offset = "0x856A540", VA = "0x18856B740", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public BNEBJELOGPG DPEBHIBHPBC
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x856F280", Offset = "0x856E080", VA = "0x18856F280", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x856EB30", Offset = "0x856D930", VA = "0x18856EB30", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int NKEJNNNELDL
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x856FCC0", Offset = "0x856EAC0", VA = "0x18856FCC0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public BNEBJELOGPG NLFMPGFBLLI
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x856FC20", Offset = "0x856EA20", VA = "0x18856FC20", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool LFGLGHMNANE
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x856BF00", Offset = "0x856AD00", VA = "0x18856BF00", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool OBEEEOBKNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x856E280", Offset = "0x856D080", VA = "0x18856E280", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool HGOEAGNGJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x856EAE0", Offset = "0x856D8E0", VA = "0x18856EAE0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public FDHABFHCHKN OMKJBICJOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x856E780", Offset = "0x856D580", VA = "0x18856E780", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x856D9B0", Offset = "0x856C7B0", VA = "0x18856D9B0", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public MOFBPFIADAD MCPIALHDBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x856EC60", Offset = "0x856DA60", VA = "0x18856EC60", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x856B8E0", Offset = "0x856A6E0", VA = "0x18856B8E0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float AEBOBMEJAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x856AD50", Offset = "0x8569B50", VA = "0x18856AD50", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8571290", Offset = "0x8570090", VA = "0x188571290", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 KJHEABGPCEP
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x856F610", Offset = "0x856E410", VA = "0x18856F610", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x856BE20", Offset = "0x856AC20", VA = "0x18856BE20", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 AKAPJDGKLNI
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x856ECB0", Offset = "0x856DAB0", VA = "0x18856ECB0", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x856CEF0", Offset = "0x856BCF0", VA = "0x18856CEF0", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 BEKHCNOKDBD
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x856FB40", Offset = "0x856E940", VA = "0x18856FB40", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x856F7B0", Offset = "0x856E5B0", VA = "0x18856F7B0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 IBJNIIMABAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x856F990", Offset = "0x856E790", VA = "0x18856F990", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x85707F0", Offset = "0x856F5F0", VA = "0x1885707F0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool IJCDCBNNFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x856B120", Offset = "0x8569F20", VA = "0x18856B120", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool HFOKOBOEGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x856B880", Offset = "0x856A680", VA = "0x18856B880", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool CEKBMCHJIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x856ADA0", Offset = "0x8569BA0", VA = "0x18856ADA0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool OBIOFDBDDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x856D060", Offset = "0x856BE60", VA = "0x18856D060", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 MPGGIIMEIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x85702A0", Offset = "0x856F0A0", VA = "0x1885702A0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 GJANFFGOPNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x856CE10", Offset = "0x856BC10", VA = "0x18856CE10", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 OPDEFFENGDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x856F530", Offset = "0x856E330", VA = "0x18856F530", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x85703E0", Offset = "0x856F1E0", VA = "0x1885703E0", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 KAIGLKCPEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8571000", Offset = "0x856FE00", VA = "0x188571000", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float GECFBCCDCEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x856F0F0", Offset = "0x856DEF0", VA = "0x18856F0F0", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float JEDJMEDNLAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x856DC30", Offset = "0x856CA30", VA = "0x18856DC30", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x856AED0", Offset = "0x8569CD0", VA = "0x18856AED0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 ACFCFCBFMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x856C200", Offset = "0x856B000", VA = "0x18856C200", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion CLFAOPEJMKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x856DCE0", Offset = "0x856CAE0", VA = "0x18856DCE0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float IPKLHPEKCJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x856B350", Offset = "0x856A150", VA = "0x18856B350", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x856CFD0", Offset = "0x856BDD0", VA = "0x18856CFD0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float ICBKCCDGPOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x856B400", Offset = "0x856A200", VA = "0x18856B400", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x856E090", Offset = "0x856CE90", VA = "0x18856E090", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool EBJPLFMKHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x856DB00", Offset = "0x856C900", VA = "0x18856DB00", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x856C690", Offset = "0x856B490", VA = "0x18856C690", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public HGOCJAJAHJN PGJAPNAKKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x856F890", Offset = "0x856E690", VA = "0x18856F890", Slot = "70")]
		get
		{
			return default(HGOCJAJAHJN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x856EC00", Offset = "0x856DA00", VA = "0x18856EC00", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool ENAMOGMAFCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x856B4C0", Offset = "0x856A2C0", VA = "0x18856B4C0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform MDGKGHNFJPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xD8BC60", Offset = "0xD8AA60", VA = "0x180D8BC60", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 AAIGDBLJPBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x856CB90", Offset = "0x856B990", VA = "0x18856CB90", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x856C5E0", Offset = "0x856B3E0", VA = "0x18856C5E0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float LAHLNKMHAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x856C0A0", Offset = "0x856AEA0", VA = "0x18856C0A0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8570930", Offset = "0x856F730", VA = "0x188570930", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float PHCDLLGNBGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x856E080", Offset = "0x856CE80", VA = "0x18856E080", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x856C6F0", Offset = "0x856B4F0", VA = "0x18856C6F0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion MBEOEIHHPIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x856E380", Offset = "0x856D180", VA = "0x18856E380", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x856DE60", Offset = "0x856CC60", VA = "0x18856DE60", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 EGIJBOFOPNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x856EFF0", Offset = "0x856DDF0", VA = "0x18856EFF0", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x856D120", Offset = "0x856BF20", VA = "0x18856D120", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion DGDGJCDLDBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x856BC00", Offset = "0x856AA00", VA = "0x18856BC00", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x856D030", Offset = "0x856BE30", VA = "0x18856D030", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints EGIODLEBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x856BA80", Offset = "0x856A880", VA = "0x18856BA80", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x856B9C0", Offset = "0x856A7C0", VA = "0x18856B9C0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool KLMCKAAMJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x85712F0", Offset = "0x85700F0", VA = "0x1885712F0", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x856D450", Offset = "0x856C250", VA = "0x18856D450", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode MBHLFDEDGLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x856C1B0", Offset = "0x856AFB0", VA = "0x18856C1B0", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x856B1C0", Offset = "0x8569FC0", VA = "0x18856B1C0", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool EEKHMIGPLDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x856C330", Offset = "0x856B130", VA = "0x18856C330", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool JAMFLBLKLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8570040", Offset = "0x856EE40", VA = "0x188570040", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event MIOLGGFIPGF JBDBHPAPKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x856B030", Offset = "0x8569E30", VA = "0x18856B030", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x856EF90", Offset = "0x856DD90", VA = "0x18856EF90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event MIOLGGFIPGF OMPAMMEAHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x856BA20", Offset = "0x856A820", VA = "0x18856BA20", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x856CCA0", Offset = "0x856BAA0", VA = "0x18856CCA0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event GLOLNKBBBNH OKNIDFBIFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8571130", Offset = "0x856FF30", VA = "0x188571130", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x856F030", Offset = "0x856DE30", VA = "0x18856F030", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event MIOLGGFIPGF ICELLOHJAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x856DC80", Offset = "0x856CA80", VA = "0x18856DC80", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x856C470", Offset = "0x856B270", VA = "0x18856C470", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event MIOLGGFIPGF ECEHECCAFCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x856F090", Offset = "0x856DE90", VA = "0x18856F090", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x856AFD0", Offset = "0x8569DD0", VA = "0x18856AFD0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event MIOLGGFIPGF DNCDKDMCKMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x856D5D0", Offset = "0x856C3D0", VA = "0x18856D5D0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x856F6F0", Offset = "0x856E4F0", VA = "0x18856F6F0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<MOCFDENFFJA, MOCFDENFFJA> PJDFMBOFOKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x856B3A0", Offset = "0x856A1A0", VA = "0x18856B3A0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x856D4B0", Offset = "0x856C2B0", VA = "0x18856D4B0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event MIOLGGFIPGF OHJCBMMIPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x856D570", Offset = "0x856C370", VA = "0x18856D570", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x856D510", Offset = "0x856C310", VA = "0x18856D510", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event MIOLGGFIPGF ABKDDFPNAPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x856F8E0", Offset = "0x856E6E0", VA = "0x18856F8E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x856DDB0", Offset = "0x856CBB0", VA = "0x18856DDB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8571380", Offset = "0x8570180", VA = "0x188571380")]
	public NOCKABCIGGP(GameObject MMMAEDGEACA, RigidbodyEx HFNBKDBKMMI, MFNDJOPNJBH HBNPNMJNNHB, [In] MGCLLADFKEL FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x856D160", Offset = "0x856BF60", VA = "0x18856D160", Slot = "139")]
	protected virtual void GPOEPBOFHDO(MFNDJOPNJBH HBNPNMJNNHB, MGCLLADFKEL FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x856C0B0", Offset = "0x856AEB0", VA = "0x18856C0B0", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x856DF40", Offset = "0x856CD40", VA = "0x18856DF40", Slot = "93")]
	public void IKNOEPKPIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x856B090", Offset = "0x8569E90", VA = "0x18856B090", Slot = "94")]
	public void BIBFJNBONAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x856E220", Offset = "0x856D020", VA = "0x18856E220", Slot = "95")]
	public void JFJBEMBOGGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x856CA90", Offset = "0x856B890", VA = "0x18856CA90", Slot = "96")]
	public void FHJNPCOBAGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x85704C0", Offset = "0x856F2C0", VA = "0x1885704C0")]
	private void OGMODNJGLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x856B940", Offset = "0x856A740", VA = "0x18856B940")]
	private void COFDIDCLHMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x85709C0", Offset = "0x856F7C0", VA = "0x1885709C0")]
	private void PBKLMENIEMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x856B6C0", Offset = "0x856A4C0", VA = "0x18856B6C0", Slot = "30")]
	public BNEBJELOGPG CFMPECDEIMF(int GLAOLHCPLLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x856D0B0", Offset = "0x856BEB0", VA = "0x18856D0B0", Slot = "98")]
	public void GPAFCMPBBMA(BNEBJELOGPG OAIIHELJHLG, bool EJHHHIDNFHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x856C7F0", Offset = "0x856B5F0", VA = "0x18856C7F0", Slot = "99")]
	public void FDJJKNMADBE(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x856CC40", Offset = "0x856BA40", VA = "0x18856CC40", Slot = "100")]
	public void GCJCHIMMGIK(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x856EE90", Offset = "0x856DC90", VA = "0x18856EE90", Slot = "101")]
	public Vector3 KIPAKEBLEGJ(Vector3 LNIADJMLGIK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x856C990", Offset = "0x856B790", VA = "0x18856C990", Slot = "102")]
	public Vector3 FGOBHOLAFPK(Vector3 EKLGFNDJLMJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x85710E0", Offset = "0x856FEE0", VA = "0x1885710E0", Slot = "103")]
	public void PFJBHMKCPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x856B170", Offset = "0x8569F70", VA = "0x18856B170", Slot = "104")]
	public void BKHMMDNEKOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x856C2E0", Offset = "0x856B0E0", VA = "0x18856C2E0", Slot = "105")]
	public void EIBNPBBNFGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x856F190", Offset = "0x856DF90", VA = "0x18856F190", Slot = "106")]
	public void LFDGAMHBFAH(Vector3 JJEBPBJEEKD, Vector3 EILMIBFNCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x856B790", Offset = "0x856A590", VA = "0x18856B790", Slot = "107")]
	public void CIHNMCAEGFP(Vector3 JHLPMGHHGEG, Vector3 OJFGKMMJPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x85701C0", Offset = "0x856EFC0", VA = "0x1885701C0", Slot = "108")]
	public void NPAAIGDMLIN(Vector3 HGKCDPFNIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8570F40", Offset = "0x856FD40", VA = "0x188570F40", Slot = "109")]
	public void PEBDPNDGMFB(AIPGFHKOAOH LMIHCDIEAAL, Vector3 CEINDOKFBOP, float LKBJKLCFGIN, float FADCPNGFJEM = 8f, float OHMJMHHACPJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x856AF30", Offset = "0x8569D30", VA = "0x18856AF30", Slot = "110")]
	public void BCAIEPCMGIL(OIHNMBFPFKI HMKMOJFBDLP, Vector3 BIDDHJCLFLK, float PDNOMCMHGEH = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x856E2D0", Offset = "0x856D0D0", VA = "0x18856E2D0", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JJDKCJPJDJL(OIHNMBFPFKI HMKMOJFBDLP, Vector3 LJIHJJKHDDH, float KGIMKDKAEAH = 7f, float AAIDDDOHLBA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8571190", Offset = "0x856FF90", VA = "0x188571190", Slot = "112")]
	public Vector3 PJNHGDBDEGL(Vector3 OAIIHELJHLG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x856ED90", Offset = "0x856DB90", VA = "0x18856ED90", Slot = "113")]
	public Vector3 KIDJIBFNIHP(Vector3 OAIIHELJHLG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x856FFF0", Offset = "0x856EDF0", VA = "0x18856FFF0", Slot = "114")]
	public void NHFPIBLBNGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x856EB90", Offset = "0x856D990", VA = "0x18856EB90", Slot = "115")]
	public void KHABNJPMIPE(BNEBJELOGPG HKHABADDJLA, object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x856DAA0", Offset = "0x856C8A0", VA = "0x18856DAA0", Slot = "116")]
	public void HMEONHIJHCB(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x856CAB0", Offset = "0x856B8B0", VA = "0x18856CAB0", Slot = "63")]
	public void GBENDDAIJNE((Quaternion rot, Vector3 moments) AHPJADDOMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x85707A0", Offset = "0x856F5A0", VA = "0x1885707A0", Slot = "117")]
	public void OKJBFNLGKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x856F140", Offset = "0x856DF40", VA = "0x18856F140", Slot = "118")]
	public void LDPOIEOIEFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x856C000", Offset = "0x856AE00", VA = "0x18856C000", Slot = "119")]
	public void DPBIBMLABPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x856BAD0", Offset = "0x856A8D0", VA = "0x18856BAD0", Slot = "120")]
	public bool DIDHAIJMHEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x856AE80", Offset = "0x8569C80", VA = "0x18856AE80", Slot = "97")]
	public void AHDGJLDDOBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8570370", Offset = "0x856F170", VA = "0x188570370", Slot = "121")]
	public void OCGFJCJDBAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x856F750", Offset = "0x856E550", VA = "0x18856F750", Slot = "122")]
	public void LPEJKIINIKC(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x856C580", Offset = "0x856B380", VA = "0x18856C580", Slot = "123")]
	public void EOPGKHIKMGP(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x856B450", Offset = "0x856A250", VA = "0x18856B450", Slot = "124")]
	public void CCOFIEADNPD(object JLFLGDNCANL, bool OHLMJEAGLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x856E7D0", Offset = "0x856D5D0", VA = "0x18856E7D0", Slot = "125")]
	public void JPMKMKMHJNH(Vector3 CJHBACNEMHB, Quaternion PLDKEAJHIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x856B220", Offset = "0x856A020", VA = "0x18856B220", Slot = "126")]
	public void BNMNFFMBIPD(Vector3 MNIAPMAMIPF, Quaternion HLNCFPIIEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x856C050", Offset = "0x856AE50", VA = "0x18856C050", Slot = "127")]
	public bool DPDBJILLEGF(float LILMPFGODPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x856F4D0", Offset = "0x856E2D0", VA = "0x18856F4D0", Slot = "128")]
	public void LIPPCGMPIHE(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8570740", Offset = "0x856F540", VA = "0x188570740", Slot = "129")]
	public void OJGPHHPDAPA(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x85708D0", Offset = "0x856F6D0", VA = "0x1885708D0", Slot = "130")]
	public void PAIOOOAKCBF(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x856C850", Offset = "0x856B650", VA = "0x18856C850", Slot = "131")]
	public void FEJODPCJEIF(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x856DB50", Offset = "0x856C950", VA = "0x18856DB50", Slot = "132")]
	public void HPCEOCNDDPG(Vector3 PGBCKJJIOAA, ForceMode FHPLDJIAAMG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x856E9D0", Offset = "0x856D7D0", VA = "0x18856E9D0", Slot = "133")]
	public void KCAGEDKPBII(Vector3 PGBCKJJIOAA, Vector3 NPJPCFKLMHD, ForceMode FHPLDJIAAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x856BB20", Offset = "0x856A920", VA = "0x18856BB20", Slot = "134")]
	public void DJIBJJAPPOF(Vector3 BFBHEICBECE, ForceMode FHPLDJIAAMG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x856C8B0", Offset = "0x856B6B0", VA = "0x18856C8B0", Slot = "135")]
	public void FGKAGPOMBIC(Vector3 BFBHEICBECE, ForceMode FHPLDJIAAMG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x856BF60", Offset = "0x856AD60", VA = "0x18856BF60", Slot = "136")]
	public bool DMLBCABMIIE(Vector3 MACLBEFOGKL, [Out] RaycastHit EMIJFAALBFB, float HBKDKLDLCIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x856FC70", Offset = "0x856EA70", VA = "0x18856FC70", Slot = "137")]
	public void NAFCDPGBHMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8571340", Offset = "0x8570140", VA = "0x188571340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x856FA70", Offset = "0x856E870", VA = "0x18856FA70")]
	private void MHFDCFDONBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x856CD00", Offset = "0x856BB00", VA = "0x18856CD00")]
	private void GGEFBKKOAPE(BNEBJELOGPG BOGJJGPKPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x856BC40", Offset = "0x856AA40", VA = "0x18856BC40")]
	private void DLMPBAJPHMK(BNEBJELOGPG BOGJJGPKPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x856C4D0", Offset = "0x856B2D0", VA = "0x18856C4D0")]
	private void ENOADAIFEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x856F2D0", Offset = "0x856E0D0", VA = "0x18856F2D0")]
	private void LGFHNLBJMIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x856B510", Offset = "0x856A310", VA = "0x18856B510")]
	private void CEEKGEALDBP(BNEBJELOGPG CGLAMIGJBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8570E70", Offset = "0x856FC70", VA = "0x188570E70")]
	private void PDADFDJJKLH(BNEBJELOGPG BOGJJGPKPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x856F400", Offset = "0x856E200", VA = "0x18856F400")]
	private void LIICNJPIJCF(BNEBJELOGPG BOGJJGPKPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x856FEA0", Offset = "0x856ECA0", VA = "0x18856FEA0")]
	private void NGBPNGIKOEJ(DJKODAHGDFK BOGJJGPKPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8570A20", Offset = "0x856F820", VA = "0x188570A20", Slot = "142")]
	protected virtual void PCPHLAIFMGB(DJKODAHGDFK OEGPMEHPDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x856E420", Offset = "0x856D220", VA = "0x18856E420")]
	protected void JMNFMELJKOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x856D630", Offset = "0x856C430", VA = "0x18856D630")]
	protected void HGLPADELCKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x856E0F0", Offset = "0x856CEF0", VA = "0x18856E0F0")]
	private void JCKLKGBDJLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x856FD30", Offset = "0x856EB30", VA = "0x18856FD30")]
	private void NCFOOLCDDKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class EGCCGAGCHGN
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8561560", Offset = "0x8560360", VA = "0x188561560")]
	public static BNEBJELOGPG DLEPANIELIK(this BNEBJELOGPG OEGPMEHPDFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8561620", Offset = "0x8560420", VA = "0x188561620")]
	public static bool EDFHAOLIDHK(this BNEBJELOGPG OEGPMEHPDFC, BNEBJELOGPG DGLJECBLJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8561780", Offset = "0x8560580", VA = "0x188561780")]
	public static bool OFJIBOFANNF(this BNEBJELOGPG OEGPMEHPDFC, BNEBJELOGPG LPPAACKLBDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x85616C0", Offset = "0x85604C0", VA = "0x1885616C0")]
	public static DJKODAHGDFK GLPKJPPEOAJ(this BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8561710", Offset = "0x8560510", VA = "0x188561710")]
	public static NOCKABCIGGP GNJJGEBODNC(this BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HNPLGFCDAKK : PMKPKFGMFHA
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x85640D0", Offset = "0x8562ED0", VA = "0x1885640D0", Slot = "19")]
	public BNEBJELOGPG JMDOHNHPAPH(RigidbodyEx OEGPMEHPDFC, MGCLLADFKEL FFEMKICJPKP, MFNDJOPNJBH HBNPNMJNNHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "4")]
	public HPCGJIHAKOF GPHGFKNAKPO(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "5")]
	public LLHHCOPAKEB KEGJGHJDMIK(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "6")]
	public DNPNLKDFADL FMKPPMLIPGC(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "7")]
	public MCJOABAJJKH PJINEOJEPBP(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "8")]
	public EDAIIDCODDL OANGGBFLGAA(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "9")]
	public LDIFFGANMLL JJDFIKPEIHO(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "10")]
	public CNBHBJCJNPH NDCNKCAHOGG(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "11")]
	public MHOHOIEADFP CFCOIDOFGIM(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "12")]
	public HHAIBMMEMCB PADKOHONIJI(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "13")]
	public IEAJDPNPOFP PJIGNLAPBLN(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0")]
	public FBBGHOMHJPO PCNMCCGKGPE(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0")]
	public AKEEFDHPAKM JKJLBHPIPAG(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0")]
	public JMCINIMLHLG CJFACGELLLO(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0")]
	public FBDBHAONFFI DKKAFOIFHIJ(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0")]
	public NOKIAGOHPFA KOLOHGKOLNK(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public HNPLGFCDAKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "14")]
	private FBBGHOMHJPO HANNLPOEMLG(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "15")]
	private AKEEFDHPAKM HHBAJILCDML(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "16")]
	private JMCINIMLHLG IKEJDPFNLKM(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "17")]
	private FBDBHAONFFI DHBBJOKJFPC(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "18")]
	private NOKIAGOHPFA PEACLILENOK(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(PMKPKFGMFHA), new string[] { })]
public class DNMCEAGEFFK : PMKPKFGMFHA, GACJOGFPDAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly PMKPKFGMFHA BNFLHHNPCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly PMKPKFGMFHA FDFIJELGGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private MMLPDOJJIBI MPONGKDCCKF;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private PMKPKFGMFHA FJBFLELDBCE
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x85611D0", Offset = "0x855FFD0", VA = "0x1885611D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8560E10", Offset = "0x855FC10", VA = "0x188560E10", Slot = "20")]
	public void InitReferences(LFBEMDOHFPC EPHKCBICOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8560C10", Offset = "0x855FA10", VA = "0x188560C10", Slot = "4")]
	public HPCGJIHAKOF GPHGFKNAKPO(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8560FE0", Offset = "0x855FDE0", VA = "0x188560FE0", Slot = "5")]
	public LLHHCOPAKEB KEGJGHJDMIK(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8560B70", Offset = "0x855F970", VA = "0x188560B70", Slot = "6")]
	public DNPNLKDFADL FMKPPMLIPGC(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8561410", Offset = "0x8560210", VA = "0x188561410", Slot = "7")]
	public MCJOABAJJKH PJINEOJEPBP(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8561230", Offset = "0x8560030", VA = "0x188561230", Slot = "8")]
	public EDAIIDCODDL OANGGBFLGAA(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8560E60", Offset = "0x855FC60", VA = "0x188560E60", Slot = "9")]
	public LDIFFGANMLL JJDFIKPEIHO(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8561130", Offset = "0x855FF30", VA = "0x188561130", Slot = "10")]
	public CNBHBJCJNPH NDCNKCAHOGG(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8560970", Offset = "0x855F770", VA = "0x188560970", Slot = "11")]
	public MHOHOIEADFP CFCOIDOFGIM(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x85612D0", Offset = "0x85600D0", VA = "0x1885612D0", Slot = "12")]
	public HHAIBMMEMCB PADKOHONIJI(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8561370", Offset = "0x8560170", VA = "0x188561370", Slot = "13")]
	public IEAJDPNPOFP PJIGNLAPBLN(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8560CB0", Offset = "0x855FAB0", VA = "0x188560CB0")]
	public FBBGHOMHJPO PCNMCCGKGPE(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8560D60", Offset = "0x855FB60", VA = "0x188560D60")]
	public AKEEFDHPAKM JKJLBHPIPAG(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8560A10", Offset = "0x855F810", VA = "0x188560A10")]
	public JMCINIMLHLG CJFACGELLLO(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x8560AC0", Offset = "0x855F8C0", VA = "0x188560AC0")]
	public FBDBHAONFFI DKKAFOIFHIJ(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8561080", Offset = "0x855FE80", VA = "0x188561080")]
	public NOKIAGOHPFA KOLOHGKOLNK(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x8560F00", Offset = "0x855FD00", VA = "0x188560F00", Slot = "19")]
	public BNEBJELOGPG JMDOHNHPAPH(RigidbodyEx OEGPMEHPDFC, MGCLLADFKEL FFEMKICJPKP, MFNDJOPNJBH HBNPNMJNNHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x85614B0", Offset = "0x85602B0", VA = "0x1885614B0")]
	public DNMCEAGEFFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8560CB0", Offset = "0x855FAB0", VA = "0x188560CB0", Slot = "14")]
	private FBBGHOMHJPO HANNLPOEMLG(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8560D60", Offset = "0x855FB60", VA = "0x188560D60", Slot = "15")]
	private AKEEFDHPAKM HHBAJILCDML(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8560A10", Offset = "0x855F810", VA = "0x188560A10", Slot = "16")]
	private JMCINIMLHLG IKEJDPFNLKM(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x8560AC0", Offset = "0x855F8C0", VA = "0x188560AC0", Slot = "17")]
	private FBDBHAONFFI DHBBJOKJFPC(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x8561080", Offset = "0x855FE80", VA = "0x188561080", Slot = "18")]
	private NOKIAGOHPFA PEACLILENOK(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface CHCBLHLFGPA : HPCGJIHAKOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFKKBLFBGKA(BNEBJELOGPG OEGPMEHPDFC);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KCIJCMNCKHE(BNEBJELOGPG OEGPMEHPDFC);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CPDJCAGNOHN(BNEBJELOGPG CGLAMIGJBHH);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OCINIAPJFIH(BNEBJELOGPG CGLAMIGJBHH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OIEJKLJLJMA : DNPNLKDFADL
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	JHOPGPBCAJJ<BNEBJELOGPG> DMDMAEBPBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	BNEBJELOGPG IAMGKMIHPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NNNCGKLBEPC : FBDBHAONFFI
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) OGLGLIGICDA(Rigidbody LNCDCFIHCID);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface ICIAJGIEMHM : AKEEFDHPAKM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	RRNetworkView INMIGFFJCEC
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class NFEOHHKMBDJ : HHAIBMMEMCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly NOCKABCIGGP OEGPMEHPDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode KHFKPKHLOIH;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody FHACEMLODOL
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8565E00", Offset = "0x8564C00", VA = "0x188565E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode MBHLFDEDGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x856A6A0", Offset = "0x85694A0", VA = "0x18856A6A0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x856A4D0", Offset = "0x85692D0", VA = "0x18856A4D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x855E3D0", Offset = "0x855D1D0", VA = "0x18855E3D0")]
	public NFEOHHKMBDJ(BNEBJELOGPG OEGPMEHPDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x856A8D0", Offset = "0x85696D0", VA = "0x18856A8D0", Slot = "6")]
	public void IKNOEPKPIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x856AA00", Offset = "0x8569800", VA = "0x18856AA00", Slot = "9")]
	public void NDNKMHONEJJ(Rigidbody BLDBEDPDIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x856A9F0", Offset = "0x85697F0", VA = "0x18856A9F0", Slot = "7")]
	public void KNGHFLHLNNM(bool GJCAAIAAPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x856A9E0", Offset = "0x85697E0", VA = "0x18856A9E0", Slot = "8")]
	public void JCFAKNNJDPN(bool GJCAAIAAPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x856A540", Offset = "0x8569340", VA = "0x18856A540", Slot = "10")]
	public bool DMLBCABMIIE(Vector3 MACLBEFOGKL, [Out] RaycastHit EMIJFAALBFB, float HBKDKLDLCIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x856A7B0", Offset = "0x85695B0", VA = "0x18856A7B0")]
	private void HIBCJBLEJIA(bool GJCAAIAAPHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class IJANGHEAPGL : LDIFFGANMLL, IDisposable, OCIHNCJEHMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NOCKABCIGGP OEGPMEHPDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private HGOCJAJAHJN FEGJJNIAJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private PJDHIPHKKMB JNEDCNFJOEA;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public HGOCJAJAHJN PGJAPNAKKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8564660", Offset = "0x8563460", VA = "0x188564660", Slot = "6")]
		get
		{
			return default(HGOCJAJAHJN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8564590", Offset = "0x8563390", VA = "0x188564590", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform DNAALGDOCMA
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xCE49E0", Offset = "0xCE37E0", VA = "0x180CE49E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<MOCFDENFFJA, MOCFDENFFJA> PJDFMBOFOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8564170", Offset = "0x8562F70", VA = "0x188564170", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8564270", Offset = "0x8563070", VA = "0x188564270", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x85647A0", Offset = "0x85635A0", VA = "0x1885647A0")]
	public IJANGHEAPGL(BNEBJELOGPG OEGPMEHPDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x8564320", Offset = "0x8563120", VA = "0x188564320", Slot = "8")]
	public void IKNOEPKPIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x8564220", Offset = "0x8563020", VA = "0x188564220", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1206240", Offset = "0x1205040", VA = "0x181206240", Slot = "11")]
	private void BIBHEGCDOPH(MOCFDENFFJA POKFHBLLJAE, MOCFDENFFJA KCFKGDKIEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "12")]
	private void FHNNFPEFKPK(bool GKLLNNLGJLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KDFEODGDGGD : PMKPKFGMFHA
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8564F80", Offset = "0x8563D80", VA = "0x188564F80", Slot = "4")]
	public HPCGJIHAKOF GPHGFKNAKPO(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8565560", Offset = "0x8564360", VA = "0x188565560", Slot = "5")]
	public LLHHCOPAKEB KEGJGHJDMIK(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8564E50", Offset = "0x8563C50", VA = "0x188564E50", Slot = "6")]
	public DNPNLKDFADL FMKPPMLIPGC(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8565AD0", Offset = "0x85648D0", VA = "0x188565AD0", Slot = "7")]
	public MCJOABAJJKH PJINEOJEPBP(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x8565880", Offset = "0x8564680", VA = "0x188565880", Slot = "8")]
	public EDAIIDCODDL OANGGBFLGAA(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8565340", Offset = "0x8564140", VA = "0x188565340", Slot = "9")]
	public LDIFFGANMLL JJDFIKPEIHO(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8565760", Offset = "0x8564560", VA = "0x188565760", Slot = "10")]
	public CNBHBJCJNPH NDCNKCAHOGG(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8564AD0", Offset = "0x85638D0", VA = "0x188564AD0", Slot = "11")]
	public MHOHOIEADFP CFCOIDOFGIM(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8565950", Offset = "0x8564750", VA = "0x188565950", Slot = "12")]
	public HHAIBMMEMCB PADKOHONIJI(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8565A10", Offset = "0x8564810", VA = "0x188565A10", Slot = "13")]
	public IEAJDPNPOFP PJIGNLAPBLN(BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8565070", Offset = "0x8563E70", VA = "0x188565070")]
	public FBBGHOMHJPO PCNMCCGKGPE(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x85651B0", Offset = "0x8563FB0", VA = "0x1885651B0")]
	public AKEEFDHPAKM JKJLBHPIPAG(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8564B90", Offset = "0x8563990", VA = "0x188564B90")]
	public JMCINIMLHLG CJFACGELLLO(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8564CC0", Offset = "0x8563AC0", VA = "0x188564CC0")]
	public FBDBHAONFFI DKKAFOIFHIJ(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8565680", Offset = "0x8564480", VA = "0x188565680")]
	public NOKIAGOHPFA KOLOHGKOLNK(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8565410", Offset = "0x8564210", VA = "0x188565410", Slot = "19")]
	public BNEBJELOGPG JMDOHNHPAPH(RigidbodyEx OEGPMEHPDFC, MGCLLADFKEL FFEMKICJPKP, MFNDJOPNJBH HBNPNMJNNHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public KDFEODGDGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8565070", Offset = "0x8563E70", VA = "0x188565070", Slot = "14")]
	private FBBGHOMHJPO HANNLPOEMLG(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x85651B0", Offset = "0x8563FB0", VA = "0x1885651B0", Slot = "15")]
	private AKEEFDHPAKM HHBAJILCDML(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8564B90", Offset = "0x8563990", VA = "0x188564B90", Slot = "16")]
	private JMCINIMLHLG IKEJDPFNLKM(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8564CC0", Offset = "0x8563AC0", VA = "0x188564CC0", Slot = "17")]
	private FBDBHAONFFI DHBBJOKJFPC(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8565680", Offset = "0x8564480", VA = "0x188565680", Slot = "18")]
	private NOKIAGOHPFA PEACLILENOK(BNEBJELOGPG OMKBHAHHOCG, [In] MGCLLADFKEL FFEMKICJPKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class KJNGGNFGBON : MHOHOIEADFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly NOCKABCIGGP OEGPMEHPDFC;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody FHACEMLODOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8565E00", Offset = "0x8564C00", VA = "0x188565E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool ENAMOGMAFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8565DB0", Offset = "0x8564BB0", VA = "0x188565DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool LFGLGHMNANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x85636F0", Offset = "0x85624F0", VA = "0x1885636F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private BNEBJELOGPG DPEBHIBHPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8566850", Offset = "0x8565650", VA = "0x188566850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x855E3D0", Offset = "0x855D1D0", VA = "0x18855E3D0")]
	public KJNGGNFGBON(BNEBJELOGPG OEGPMEHPDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8566470", Offset = "0x8565270", VA = "0x188566470", Slot = "4")]
	public void HPCEOCNDDPG(Vector3 PGBCKJJIOAA, ForceMode FHPLDJIAAMG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8565E50", Offset = "0x8564C50", VA = "0x188565E50")]
	private void CIBKMNLMLMN(Vector3 PGBCKJJIOAA, ForceMode FHPLDJIAAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x85665D0", Offset = "0x85653D0", VA = "0x1885665D0", Slot = "5")]
	public void KCAGEDKPBII(Vector3 PGBCKJJIOAA, Vector3 NPJPCFKLMHD, ForceMode FHPLDJIAAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x85660B0", Offset = "0x8564EB0", VA = "0x1885660B0", Slot = "6")]
	public void DJIBJJAPPOF(Vector3 BFBHEICBECE, ForceMode FHPLDJIAAMG = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8565B50", Offset = "0x8564950", VA = "0x188565B50")]
	private void BDAPDIBEEPB(Vector3 BFBHEICBECE, ForceMode FHPLDJIAAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8566210", Offset = "0x8565010", VA = "0x188566210", Slot = "7")]
	public void FGKAGPOMBIC(Vector3 BFBHEICBECE, ForceMode FHPLDJIAAMG = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class AGCGEGFBICC : IEAJDPNPOFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly NOCKABCIGGP OEGPMEHPDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool FOJOLIKPONN;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool EBJPLFMKHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0C50", VA = "0x180AC1E50", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x855E290", Offset = "0x855D090", VA = "0x18855E290", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x855E3D0", Offset = "0x855D1D0", VA = "0x18855E3D0")]
	public AGCGEGFBICC(BNEBJELOGPG OEGPMEHPDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x855E3A0", Offset = "0x855D1A0", VA = "0x18855E3A0", Slot = "6")]
	public void NDNKMHONEJJ(Rigidbody BLDBEDPDIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x855E220", Offset = "0x855D020", VA = "0x18855E220", Slot = "7")]
	public void BLHHEJJAOEF(Rigidbody BLDBEDPDIGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class FAPKHFPDHIG : CHCBLHLFGPA, HPCGJIHAKOF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly BNEBJELOGPG OEGPMEHPDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<BNEBJELOGPG> BNOOGMAKJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private BNEBJELOGPG IPCOMOHMNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private BNEBJELOGPG BOGJJGPKPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform HKBBDCIKDGF;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform MNFKMLBDMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8562910", Offset = "0x8561710", VA = "0x188562910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public BNEBJELOGPG DPEBHIBHPBC
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECC0", Offset = "0xA0DAC0", VA = "0x180A0ECC0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8562AD0", Offset = "0x85618D0", VA = "0x188562AD0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public BNEBJELOGPG NLFMPGFBLLI
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA0D040", Offset = "0xA0BE40", VA = "0x180A0D040", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<BNEBJELOGPG> HFDJOFOJABH
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFF0", Offset = "0xA0BDF0", VA = "0x180A0CFF0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event MIOLGGFIPGF JBDBHPAPKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8561820", Offset = "0x8560620", VA = "0x188561820", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8562B80", Offset = "0x8561980", VA = "0x188562B80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event MIOLGGFIPGF OMPAMMEAHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8561E80", Offset = "0x8560C80", VA = "0x188561E80", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8562110", Offset = "0x8560F10", VA = "0x188562110", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event GLOLNKBBBNH OKNIDFBIFFC
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x85634B0", Offset = "0x85622B0", VA = "0x1885634B0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8562CC0", Offset = "0x8561AC0", VA = "0x188562CC0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action IJNCPAKFDGH
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8561FC0", Offset = "0x8560DC0", VA = "0x188561FC0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8563590", Offset = "0x8562390", VA = "0x188563590", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action JJGBAEHJEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8562AE0", Offset = "0x85618E0", VA = "0x188562AE0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8562C20", Offset = "0x8561A20", VA = "0x188562C20", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<BNEBJELOGPG> BMCEEFFCONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8561A10", Offset = "0x8560810", VA = "0x188561A10", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8562060", Offset = "0x8560E60", VA = "0x188562060", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<BNEBJELOGPG> PMMPBAMPOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8562860", Offset = "0x8561660", VA = "0x188562860", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8561AC0", Offset = "0x85608C0", VA = "0x188561AC0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action EFLLKDKECHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8563410", Offset = "0x8562210", VA = "0x188563410", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x85618C0", Offset = "0x85606C0", VA = "0x1885618C0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<BNEBJELOGPG> CNMFHLCLIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8562E90", Offset = "0x8561C90", VA = "0x188562E90", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8561960", Offset = "0x8560760", VA = "0x188561960", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x8563630", Offset = "0x8562430", VA = "0x188563630")]
	public FAPKHFPDHIG(BNEBJELOGPG OEGPMEHPDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x8561F20", Offset = "0x8560D20", VA = "0x188561F20", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x85622E0", Offset = "0x85610E0", VA = "0x1885622E0", Slot = "30")]
	public void GPAFCMPBBMA(BNEBJELOGPG JDMAEDJOOLD, bool EJHHHIDNFHE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x8561C10", Offset = "0x8560A10", VA = "0x188561C10", Slot = "6")]
	public void CPDJCAGNOHN(BNEBJELOGPG CGLAMIGJBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x8562F40", Offset = "0x8561D40", VA = "0x188562F40", Slot = "7")]
	public void OCINIAPJFIH(BNEBJELOGPG CGLAMIGJBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x85631C0", Offset = "0x8561FC0", VA = "0x1885631C0", Slot = "4")]
	public void OFKKBLFBGKA(BNEBJELOGPG OEGPMEHPDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x8562A30", Offset = "0x8561830", VA = "0x188562A30", Slot = "5")]
	public void KCIJCMNCKHE(BNEBJELOGPG OEGPMEHPDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x8561B70", Offset = "0x8560970", VA = "0x188561B70")]
	private void CCCNNFGLLKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x8563550", Offset = "0x8562350", VA = "0x188563550")]
	private void PJEALNPEPJG(BNEBJELOGPG CGLAMIGJBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x85632D0", Offset = "0x85620D0", VA = "0x1885632D0")]
	private void OHGMEBDBMBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x85621B0", Offset = "0x8560FB0", VA = "0x1885621B0")]
	private void GKMKFGEKIGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x8562D60", Offset = "0x8561B60", VA = "0x188562D60")]
	private void MPNDMHCDCFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x8562970", Offset = "0x8561770", VA = "0x188562970")]
	[CompilerGenerated]
	private object IMOFGEKEGIL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class DHOLLMJGNGD
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x85608B0", Offset = "0x855F6B0", VA = "0x1885608B0")]
	public static CHCBLHLFGPA DHHINDFAFIL(this BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class CJHNJNDLKAL : OIEJKLJLJMA, DNPNLKDFADL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NOCKABCIGGP OEGPMEHPDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly JHOPGPBCAJJ<BNEBJELOGPG> KIHHPDFDHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool MMLKAKFACMG;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public JHOPGPBCAJJ<BNEBJELOGPG> DMDMAEBPBKO
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 MPGGIIMEIPE
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x855FCB0", Offset = "0x855EAB0", VA = "0x18855FCB0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 GJANFFGOPNF
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x855F880", Offset = "0x855E680", VA = "0x18855F880", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 BEKHCNOKDBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x855FBC0", Offset = "0x855E9C0", VA = "0x18855FBC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public BNEBJELOGPG IAMGKMIHPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x855FB10", Offset = "0x855E910", VA = "0x18855FB10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x8560080", Offset = "0x855EE80", VA = "0x188560080")]
	public CJHNJNDLKAL(BNEBJELOGPG OEGPMEHPDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x855FA40", Offset = "0x855E840", VA = "0x18855FA40", Slot = "8")]
	public void IAKCBPDKAFB(BNEBJELOGPG BOGJJGPKPIJ, object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x855FAB0", Offset = "0x855E8B0", VA = "0x18855FAB0", Slot = "9")]
	public void LBIBOBFGGDL(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x855FCE0", Offset = "0x855EAE0", VA = "0x18855FCE0")]
	private Vector3 OKGKKNFJMIL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x855F4F0", Offset = "0x855E2F0", VA = "0x18855F4F0")]
	private void DBEFIJPJFAN(BNEBJELOGPG FHBGOGLJLML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class CAGBAGCOIIF
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x855E750", Offset = "0x855D550", VA = "0x18855E750")]
	public static OIEJKLJLJMA HIEDIMEGKAE(this BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class MHDHGABIJLH : NNNCGKLBEPC, FBDBHAONFFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly NOCKABCIGGP OEGPMEHPDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 NLHEABDFAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 BJKCDGABEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float NADMIGILEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float EAPKNENOEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 NABAHGCCFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? AHJDHJIPGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? BLDKPPGJBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool PJEFEHBIOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool FJKHJLLLGDK;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 OPDEFFENGDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1674950", Offset = "0x1673750", VA = "0x181674950", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8568390", Offset = "0x8567190", VA = "0x188568390", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 KAIGLKCPEPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8569D80", Offset = "0x8568B80", VA = "0x188569D80", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float GECFBCCDCEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xD08900", Offset = "0xD07700", VA = "0x180D08900", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x85686C0", Offset = "0x85674C0", VA = "0x1885686C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float JEDJMEDNLAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xC27A90", Offset = "0xC26890", VA = "0x180C27A90", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8567700", Offset = "0x8566500", VA = "0x188567700", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 ACFCFCBFMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8567C30", Offset = "0x8566A30", VA = "0x188567C30", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion CLFAOPEJMKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8568210", Offset = "0x8567010", VA = "0x188568210", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody FHACEMLODOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8566BE0", Offset = "0x85659E0", VA = "0x188566BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event MIOLGGFIPGF MMGJNCGCJCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8568D40", Offset = "0x8567B40", VA = "0x188568D40", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8568170", Offset = "0x8566F70", VA = "0x188568170", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8569E70", Offset = "0x8568C70", VA = "0x188569E70")]
	public MHDHGABIJLH(BNEBJELOGPG OEGPMEHPDFC, [In] MGCLLADFKEL FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8569C60", Offset = "0x8568A60", VA = "0x188569C60", Slot = "17")]
	public void OKJBFNLGKOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x85685E0", Offset = "0x85673E0", VA = "0x1885685E0", Slot = "16")]
	public void LDPOIEOIEFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8568C60", Offset = "0x8567A60", VA = "0x188568C60", Slot = "19")]
	public void NDNKMHONEJJ(Rigidbody BLDBEDPDIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x85677B0", Offset = "0x85665B0", VA = "0x1885677B0", Slot = "20")]
	public void BLHHEJJAOEF(Rigidbody BLDBEDPDIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8567A80", Offset = "0x8566880", VA = "0x188567A80", Slot = "18")]
	public void DPBIBMLABPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x85687D0", Offset = "0x85675D0", VA = "0x1885687D0", Slot = "21")]
	public void NAFCDPGBHMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8568390", Offset = "0x8567190", VA = "0x188568390")]
	private void INPALKKHFBM(Vector3 OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8567990", Offset = "0x8566790", VA = "0x188567990")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 CFHPOABPAIH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x85686C0", Offset = "0x85674C0", VA = "0x1885686C0")]
	private void LPAHKODAJIB(float OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8567700", Offset = "0x8566500", VA = "0x188567700")]
	private void OAHCLGLLDNO(float OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8568440", Offset = "0x8567240", VA = "0x188568440")]
	private Vector3 KFNAHEAAAAG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8567DC0", Offset = "0x8566BC0", VA = "0x188567DC0", Slot = "15")]
	public void GBENDDAIJNE((Quaternion rot, Vector3 moments) AHPJADDOMJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8567FF0", Offset = "0x8566DF0", VA = "0x188567FF0")]
	private Quaternion HDFFGFELKFK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8569B90", Offset = "0x8568990", VA = "0x188569B90")]
	public void OGLGLIGICDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8568DE0", Offset = "0x8567BE0", VA = "0x188568DE0", Slot = "4")]
	public (float, Vector3) OGLGLIGICDA(Rigidbody LNCDCFIHCID)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class AMKFGFBOOIA
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x855E460", Offset = "0x855D260", VA = "0x18855E460")]
	public static NNNCGKLBEPC EPKPIGPEPHI(this BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class DBNLHKPAIPE : JMCINIMLHLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly NOCKABCIGGP OEGPMEHPDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly GHLDACEJKIG FDAPFNAKKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly JFLNIIIFAEP GHLLJKOAGBP;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool OKEIAKAHELO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x185FFA0", Offset = "0x185EDA0", VA = "0x18185FFA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public JFLNIIIFAEP DNGIHJBBHGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00", Slot = "11")]
		get
		{
			return default(JFLNIIIFAEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x85607B0", Offset = "0x855F5B0", VA = "0x1885607B0")]
	public DBNLHKPAIPE(BNEBJELOGPG OEGPMEHPDFC, [In] MGCLLADFKEL FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8560380", Offset = "0x855F180", VA = "0x188560380", Slot = "4")]
	public void IKNOEPKPIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8560180", Offset = "0x855EF80", VA = "0x188560180")]
	private bool BLFAEHOAGCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8560780", Offset = "0x855F580", VA = "0x188560780", Slot = "5")]
	public void NDGGPMJDCLG(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8560490", Offset = "0x855F290", VA = "0x188560490", Slot = "6")]
	public void IOMKJLJBBJG(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8560640", Offset = "0x855F440", VA = "0x188560640", Slot = "9")]
	public void MEJPMENMHDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8560220", Offset = "0x855F020", VA = "0x188560220")]
	private void DDCDDIADIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x85604C0", Offset = "0x855F2C0", VA = "0x1885604C0")]
	private void LLEKGFOMIPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8560340", Offset = "0x855F140", VA = "0x188560340", Slot = "8")]
	public void GONAAPHMPAO(BNEBJELOGPG OEGPMEHPDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8560450", Offset = "0x855F250", VA = "0x188560450", Slot = "7")]
	public void IOKBCONGHGE(BNEBJELOGPG OEGPMEHPDFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class NAFNMFMNJGE : CNBHBJCJNPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly NOCKABCIGGP OEGPMEHPDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly GHLDACEJKIG OOMGOEDLLPE;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool ENAMOGMAFCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x856A110", Offset = "0x8568F10", VA = "0x18856A110", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event MIOLGGFIPGF OHJCBMMIPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x856A270", Offset = "0x8569070", VA = "0x18856A270", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x856A1D0", Offset = "0x8568FD0", VA = "0x18856A1D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x856A3E0", Offset = "0x85691E0", VA = "0x18856A3E0")]
	public NAFNMFMNJGE(BNEBJELOGPG OEGPMEHPDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x856A310", Offset = "0x8569110", VA = "0x18856A310", Slot = "7")]
	public void LPEJKIINIKC(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x856A1C0", Offset = "0x8568FC0", VA = "0x18856A1C0", Slot = "8")]
	public void EOPGKHIKMGP(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x856A000", Offset = "0x8568E00", VA = "0x18856A000", Slot = "9")]
	public void CCOFIEADNPD(object JLFLGDNCANL, bool OHLMJEAGLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x856A320", Offset = "0x8569120", VA = "0x18856A320", Slot = "12")]
	public void NCBLPCPNGOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x856A360", Offset = "0x8569160", VA = "0x18856A360", Slot = "10")]
	public void NDNKMHONEJJ(Rigidbody HDAOKPJKILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x8569FD0", Offset = "0x8568DD0", VA = "0x188569FD0", Slot = "11")]
	public void BLHHEJJAOEF(Rigidbody BLDBEDPDIGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class CDELICLBCNC : ICIAJGIEMHM, AKEEFDHPAKM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly NOCKABCIGGP OEGPMEHPDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private RRNetworkView DNCCNJDOKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool CHBPPLBBCOJ;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public RRNetworkView INMIGFFJCEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool OBEEEOBKNAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x855F0B0", Offset = "0x855DEB0", VA = "0x18855F0B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool HGOEAGNGJNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xDD8CC0", Offset = "0xDD7AC0", VA = "0x180DD8CC0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event MIOLGGFIPGF ICELLOHJAFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x855EEE0", Offset = "0x855DCE0", VA = "0x18855EEE0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x855E910", Offset = "0x855D710", VA = "0x18855E910", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x855F3A0", Offset = "0x855E1A0", VA = "0x18855F3A0")]
	public CDELICLBCNC(BNEBJELOGPG OEGPMEHPDFC, [In] MGCLLADFKEL FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x855EF80", Offset = "0x855DD80", VA = "0x18855EF80", Slot = "9")]
	public void IKNOEPKPIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x855E810", Offset = "0x855D610", VA = "0x18855E810", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x855F230", Offset = "0x855E030", VA = "0x18855F230", Slot = "10")]
	public void PDADFDJJKLH(BNEBJELOGPG BOGJJGPKPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x855F0C0", Offset = "0x855DEC0", VA = "0x18855F0C0", Slot = "11")]
	public void LIICNJPIJCF(BNEBJELOGPG BOGJJGPKPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x855ED70", Offset = "0x855DB70", VA = "0x18855ED70")]
	private void HOCCCGDKBPJ(RRNetworkView KFMMAMODNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x855EC20", Offset = "0x855DA20", VA = "0x18855EC20")]
	private void HHMNPJNPBJD(DJKODAHGDFK FKLALKEDALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x855E9B0", Offset = "0x855D7B0", VA = "0x18855E9B0")]
	private void GIDKMDGACOK(RRNetworkView GGCLKFLJMNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class OPFFJDLDJCG
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x8574AE0", Offset = "0x85738E0", VA = "0x188574AE0")]
	public static ICIAJGIEMHM JNOIHODKNIC(this BNEBJELOGPG OMKBHAHHOCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class IPOGPGOGGPD : NOKIAGOHPFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly NOCKABCIGGP OEGPMEHPDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints JLLEEMLPJAH;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool KLMCKAAMJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA574D0", Offset = "0xA562D0", VA = "0x180A574D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xD49CB0", Offset = "0xD48AB0", VA = "0x180D49CB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool GLOAOAKMAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xD49C90", Offset = "0xD48A90", VA = "0x180D49C90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xD49CA0", Offset = "0xD48AA0", VA = "0x180D49CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints EGIODLEBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8564860", Offset = "0x8563660", VA = "0x188564860", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x85649C0", Offset = "0x85637C0", VA = "0x1885649C0")]
	public IPOGPGOGGPD(BNEBJELOGPG OEGPMEHPDFC, [In] MGCLLADFKEL FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x8564990", Offset = "0x8563790", VA = "0x188564990", Slot = "9")]
	public void NDNKMHONEJJ(Rigidbody BLDBEDPDIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x8564830", Offset = "0x8563630", VA = "0x188564830", Slot = "10")]
	public void BLHHEJJAOEF(Rigidbody BLDBEDPDIGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class NMDGNIJJJCA : MCJOABAJJKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly BNEBJELOGPG OEGPMEHPDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float LBCDGKAHFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float ABGFEBJEBMA;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float IPKLHPEKCJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xF09910", Offset = "0xF08710", VA = "0x180F09910", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x856AB20", Offset = "0x8569920", VA = "0x18856AB20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float ICBKCCDGPOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xD6DF10", Offset = "0xD6CD10", VA = "0x180D6DF10", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x856ABF0", Offset = "0x85699F0", VA = "0x18856ABF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x856AD10", Offset = "0x8569B10", VA = "0x18856AD10")]
	public NMDGNIJJJCA(BNEBJELOGPG OEGPMEHPDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x856ACC0", Offset = "0x8569AC0", VA = "0x18856ACC0", Slot = "8")]
	public void NDNKMHONEJJ(Rigidbody BLDBEDPDIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x856AA80", Offset = "0x8569880", VA = "0x18856AA80", Slot = "9")]
	public void BLHHEJJAOEF(Rigidbody BLDBEDPDIGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class KOJJFKDNIKD : EDAIIDCODDL
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly IEBEPMGFCGH OMJJNIEPGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly NOCKABCIGGP OEGPMEHPDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool CAHFIGINKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool EOMBNGCPOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int HHDPAPLCKKF;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody FHACEMLODOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8566BE0", Offset = "0x85659E0", VA = "0x188566BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool EEKHMIGPLDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8566DF0", Offset = "0x8565BF0", VA = "0x188566DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private BNEBJELOGPG DPEBHIBHPBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8567140", Offset = "0x8565F40", VA = "0x188567140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool LFGLGHMNANE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8566D90", Offset = "0x8565B90", VA = "0x188566D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event MIOLGGFIPGF DNCDKDMCKMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8566E80", Offset = "0x8565C80", VA = "0x188566E80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x85671A0", Offset = "0x8565FA0", VA = "0x1885671A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8567560", Offset = "0x8566360", VA = "0x188567560")]
	public KOJJFKDNIKD(BNEBJELOGPG OEGPMEHPDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8566F20", Offset = "0x8565D20", VA = "0x188566F20", Slot = "6")]
	public void IKNOEPKPIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x8566C30", Offset = "0x8565A30", VA = "0x188566C30", Slot = "8")]
	public void DAFGFMJKANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8566C40", Offset = "0x8565A40", VA = "0x188566C40", Slot = "7")]
	public bool DIDHAIJMHEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x85668B0", Offset = "0x85656B0", VA = "0x1885668B0", Slot = "9")]
	public void AHDGJLDDOBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8567240", Offset = "0x8566040", VA = "0x188567240", Slot = "13")]
	public void OCGFJCJDBAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x85672E0", Offset = "0x85660E0", VA = "0x1885672E0", Slot = "12")]
	public void OGMODNJGLJH(bool GKDCAPIJGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8566E10", Offset = "0x8565C10", VA = "0x188566E10", Slot = "10")]
	public bool FHNPDMMLIOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8567410", Offset = "0x8566210", VA = "0x188567410", Slot = "11")]
	public bool PBKLMENIEMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8566950", Offset = "0x8565750", VA = "0x188566950")]
	private bool BBOEKAFAGAM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8566FB0", Offset = "0x8565DB0", VA = "0x188566FB0")]
	private void JKILHPECNFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class FGLFFHCPJAP : FBBGHOMHJPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly NOCKABCIGGP OEGPMEHPDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly GHLDACEJKIG ODAOFGCLCMF;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody FHACEMLODOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool LFGLGHMNANE
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x85636F0", Offset = "0x85624F0", VA = "0x1885636F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool PFAAFPLKNOI
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x185FFA0", Offset = "0x185EDA0", VA = "0x18185FFA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8563EF0", Offset = "0x8562CF0", VA = "0x188563EF0")]
	public FGLFFHCPJAP(BNEBJELOGPG OEGPMEHPDFC, [In] MGCLLADFKEL FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8563780", Offset = "0x8562580", VA = "0x188563780", Slot = "5")]
	public void IKNOEPKPIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x8563D40", Offset = "0x8562B40", VA = "0x188563D40", Slot = "7")]
	public void PAIOOOAKCBF(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x8563750", Offset = "0x8562550", VA = "0x188563750", Slot = "8")]
	public void FEJODPCJEIF(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8563A10", Offset = "0x8562810", VA = "0x188563A10", Slot = "9")]
	public void OKOHNOFEHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8563820", Offset = "0x8562620", VA = "0x188563820", Slot = "10")]
	public void LOKGGCLHLFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x8563D70", Offset = "0x8562B70", VA = "0x188563D70", Slot = "11")]
	public void POEMKMGOENC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class OIKBIKJBKEJ : LLHHCOPAKEB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly NOCKABCIGGP OEGPMEHPDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly GHLDACEJKIG FMOPOLJDIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float OGJIMPJBAGB;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public FDHABFHCHKN OMKJBICJOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public MOFBPFIADAD MCPIALHDBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 BEKHCNOKDBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8573C40", Offset = "0x8572A40", VA = "0x188573C40", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8573A20", Offset = "0x8572820", VA = "0x188573A20", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 KJHEABGPCEP
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8573900", Offset = "0x8572700", VA = "0x188573900", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8571F90", Offset = "0x8570D90", VA = "0x188571F90", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 IBJNIIMABAD
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8573AE0", Offset = "0x85728E0", VA = "0x188573AE0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x85741F0", Offset = "0x8572FF0", VA = "0x1885741F0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 AKAPJDGKLNI
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x85733C0", Offset = "0x85721C0", VA = "0x1885733C0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8572310", Offset = "0x8571110", VA = "0x188572310", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float AEBOBMEJAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xF0D320", Offset = "0xF0C120", VA = "0x180F0D320", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8571470", Offset = "0x8570270", VA = "0x188571470", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool OBIOFDBDDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x2166370", Offset = "0x2165170", VA = "0x182166370", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private MHOHOIEADFP DNGLLNCHGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7B27310", Offset = "0x7B26110", VA = "0x187B27310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool EEKHMIGPLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8572080", Offset = "0x8570E80", VA = "0x188572080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x85749F0", Offset = "0x85737F0", VA = "0x1885749F0")]
	public OIKBIKJBKEJ(BNEBJELOGPG OEGPMEHPDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8572460", Offset = "0x8571260", VA = "0x188572460", Slot = "19")]
	public void IKNOEPKPIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x8571FC0", Offset = "0x8570DC0", VA = "0x188571FC0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8573D90", Offset = "0x8572B90", VA = "0x188573D90", Slot = "28")]
	public void NDNKMHONEJJ(Rigidbody BLDBEDPDIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x162C240", Offset = "0x162B040", VA = "0x18162C240", Slot = "20")]
	public void BFEAIDNPLEH(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x162B3E0", Offset = "0x162A1E0", VA = "0x18162B3E0", Slot = "30")]
	public void DLAEMPAMAAH(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x85734E0", Offset = "0x85722E0", VA = "0x1885734E0", Slot = "35")]
	public Vector3 KIPAKEBLEGJ(Vector3 LNIADJMLGIK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x85720A0", Offset = "0x8570EA0", VA = "0x1885720A0", Slot = "34")]
	public Vector3 FGOBHOLAFPK(Vector3 EKLGFNDJLMJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x8572460", Offset = "0x8571260", VA = "0x188572460", Slot = "27")]
	public void PFJBHMKCPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8571930", Offset = "0x8570730", VA = "0x188571930", Slot = "25")]
	public void BKHMMDNEKOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8572020", Offset = "0x8570E20", VA = "0x188572020", Slot = "24")]
	public void EIBNPBBNFGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x85736C0", Offset = "0x85724C0", VA = "0x1885736C0", Slot = "33")]
	public void LFDGAMHBFAH(Vector3 JJEBPBJEEKD, Vector3 EILMIBFNCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8571F30", Offset = "0x8570D30", VA = "0x188571F30", Slot = "32")]
	public void CIHNMCAEGFP(Vector3 JHLPMGHHGEG, Vector3 OJFGKMMJPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8574050", Offset = "0x8572E50", VA = "0x188574050", Slot = "31")]
	public void NPAAIGDMLIN(Vector3 HGKCDPFNIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x85742B0", Offset = "0x85730B0", VA = "0x1885742B0", Slot = "22")]
	public void PEBDPNDGMFB(AIPGFHKOAOH LMIHCDIEAAL, Vector3 CEINDOKFBOP, float LKBJKLCFGIN, float FADCPNGFJEM = 8f, float OHMJMHHACPJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8571580", Offset = "0x8570380", VA = "0x188571580", Slot = "21")]
	public void BCAIEPCMGIL(OIHNMBFPFKI HMKMOJFBDLP, Vector3 BIDDHJCLFLK, float PDNOMCMHGEH = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8572510", Offset = "0x8571310", VA = "0x188572510", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JJDKCJPJDJL(OIHNMBFPFKI HMKMOJFBDLP, Vector3 LJIHJJKHDDH, float KGIMKDKAEAH = 7f, float AAIDDDOHLBA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x1751F10", Offset = "0x1750D10", VA = "0x181751F10")]
	private static void CEDFEDBAKJK(Vector3 GPBPHJJLKFP, Vector3 KODPDAPHGHG, [Out] Vector3 NDCPECJBBLC, [Out] Vector3 FAIOFPMKOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8574910", Offset = "0x8573710", VA = "0x188574910", Slot = "29")]
	public Vector3 PJNHGDBDEGL(Vector3 GPBPHJJLKFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8573EC0", Offset = "0x8572CC0", VA = "0x188573EC0", Slot = "26")]
	public void NHFPIBLBNGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8571470", Offset = "0x8570270", VA = "0x188571470")]
	private void ANMKGHCOMOH(float OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x8572D90", Offset = "0x8571B90", VA = "0x188572D90")]
	private void KAFOIOEAFEO(Vector3 BIDDHJCLFLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x8571810", Offset = "0x8570610", VA = "0x188571810")]
	private Vector3 BDIIPEENDPD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8572900", Offset = "0x8571700", VA = "0x188572900")]
	private void JNHMLPHHNIC(Vector3 EKLGFNDJLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8572340", Offset = "0x8571140", VA = "0x188572340")]
	private Vector3 IEGLNGDHEDI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x8572F30", Offset = "0x8571D30", VA = "0x188572F30")]
	private void KEAHDINAFGP(Vector3 OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8571990", Offset = "0x8570790", VA = "0x188571990")]
	private void CHLOFFPGJAL(Vector3 EKLGFNDJLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8572260", Offset = "0x8571060", VA = "0x188572260")]
	private void FJDLGOMBGNN()
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
