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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x83BAD80", Offset = "0x83B9380", VA = "0x1883BAD80", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2064230", Offset = "0x2062830", VA = "0x182064230", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83CDE70", Offset = "0x83CC470", VA = "0x1883CDE70")]
		private void MEMPKEBCMCB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83CE170", Offset = "0x83CC770", VA = "0x1883CE170", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83CE1D0", Offset = "0x83CC7D0", VA = "0x1883CE1D0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, HAIPDKCGNLO, FHBMACKKPGL, MECOHKFOCBB
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly JBBHIJHGEPM DKFBEIPEILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool MFEGGMHGFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private AEHCCAJOAGK PMPECDOGJAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[JFJLIIJLCAB(JINCPHMLLKA.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[JFJLIIJLCAB(JINCPHMLLKA.SelfAndParent, true, false, false)]
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
		private KDGIOFPALDJ physicsInterpolation;

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
		private Transform KGPIBDKDEPB;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal AEHCCAJOAGK PJAGFJDHAKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x83C9DA0", Offset = "0x83C83A0", VA = "0x1883C9DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private AEHCCAJOAGK JDJLOEOKOGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int GGKEEFPNDLI
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x83CB380", Offset = "0x83C9980", VA = "0x1883CB380")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx PIIDGMAMFHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x83CB6E0", Offset = "0x83C9CE0", VA = "0x1883CB6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx FMDIEJKNFGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x83CB620", Offset = "0x83C9C20", VA = "0x1883CB620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx JHDAOHEONAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x83CC2E0", Offset = "0x83CA8E0", VA = "0x1883CC2E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x83CD7E0", Offset = "0x83CBDE0", VA = "0x1883CD7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool OECNNBLFMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x802D3B0", Offset = "0x802B9B0", VA = "0x18802D3B0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x802B360", Offset = "0x8029960", VA = "0x18802B360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform KOOMPFGMBLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1E9AFB0", Offset = "0x1E995B0", VA = "0x181E9AFB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform OBJHFHNBHMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1E9AFB0", Offset = "0x1E995B0", VA = "0x181E9AFB0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform BBBFMBKGKMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1E9AFB0", Offset = "0x1E995B0", VA = "0x181E9AFB0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public DINEBAHNNBA COBALJIKJEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x83CB3E0", Offset = "0x83C99E0", VA = "0x1883CB3E0")]
			get
			{
				return default(DINEBAHNNBA);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x83CCF90", Offset = "0x83CB590", VA = "0x1883CCF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool BNFOGIBLEGI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x83CB9F0", Offset = "0x83C9FF0", VA = "0x1883CB9F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool LMGPENNCPHI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x83CB500", Offset = "0x83C9B00", VA = "0x1883CB500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FGHLALPKLCB GPHCHFOOBEF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x83CB930", Offset = "0x83C9F30", VA = "0x1883CB930")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x83CD150", Offset = "0x83CB750", VA = "0x1883CD150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public EKDAONPNEDM PFHAOKHAIMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x83CB8D0", Offset = "0x83C9ED0", VA = "0x1883CB8D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x83CD0E0", Offset = "0x83CB6E0", VA = "0x1883CD0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ACLAGMPFHFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x83CB820", Offset = "0x83C9E20", VA = "0x1883CB820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody LJPLOMDHOKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x83CB880", Offset = "0x83C9E80", VA = "0x1883CB880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool GOEFNOABCHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x83CB560", Offset = "0x83C9B60", VA = "0x1883CB560")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x83CD000", Offset = "0x83CB600", VA = "0x1883CD000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool BLMJJKMHDAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1695D30", Offset = "0x1694330", VA = "0x181695D30", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float HKPAAKFJDAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x83CC280", Offset = "0x83CA880", VA = "0x1883CC280")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float APNMIMOLDBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x83CC220", Offset = "0x83CA820", VA = "0x1883CC220")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x83CD770", Offset = "0x83CBD70", VA = "0x1883CD770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float IFIDNLLDPOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x83CBC50", Offset = "0x83CA250", VA = "0x1883CBC50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x83CD3F0", Offset = "0x83CB9F0", VA = "0x1883CD3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float FKHPPHJNCJO
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x83CBA50", Offset = "0x83CA050", VA = "0x1883CBA50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x83CD1C0", Offset = "0x83CB7C0", VA = "0x1883CD1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool KEKCOAKJGJK
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x83CC830", Offset = "0x83CAE30", VA = "0x1883CC830")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x83CDD20", Offset = "0x83CC320", VA = "0x1883CDD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 KKKCDJBMGCA
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x83CC000", Offset = "0x83CA600", VA = "0x1883CC000")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x83CD540", Offset = "0x83CBB40", VA = "0x1883CD540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 PCINKCAOPDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x83CC970", Offset = "0x83CAF70", VA = "0x1883CC970")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode PJCEBBJIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x83CBB90", Offset = "0x83CA190", VA = "0x1883CBB90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x83CD310", Offset = "0x83CB910", VA = "0x1883CD310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float KAAKNIDJMKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x83CB5C0", Offset = "0x83C9BC0", VA = "0x1883CB5C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x83CD070", Offset = "0x83CB670", VA = "0x1883CD070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints OPFLPGHGOHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x83CBBF0", Offset = "0x83CA1F0", VA = "0x1883CBBF0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x83CD380", Offset = "0x83CB980", VA = "0x1883CD380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 GDGFGOIEGCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x83CC3A0", Offset = "0x83CA9A0", VA = "0x1883CC3A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 EHBPFGEJFFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x83CC3A0", Offset = "0x83CA9A0", VA = "0x1883CC3A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x83CDB00", Offset = "0x83CC100", VA = "0x1883CDB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float MJAHKCHDPBO
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x83CC0E0", Offset = "0x83CA6E0", VA = "0x1883CC0E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x83CD620", Offset = "0x83CBC20", VA = "0x1883CD620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float JIJAPFEFCAD
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x83CC7D0", Offset = "0x83CADD0", VA = "0x1883CC7D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x83CDCB0", Offset = "0x83CC2B0", VA = "0x1883CDCB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion EMIKDPPMMHB
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x83CC480", Offset = "0x83CAA80", VA = "0x1883CC480")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x83CD880", Offset = "0x83CBE80", VA = "0x1883CD880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion EDAJKKBNMIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x83CC700", Offset = "0x83CAD00", VA = "0x1883CC700")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x83CDBE0", Offset = "0x83CC1E0", VA = "0x1883CDBE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 MPAPMMINNFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x83CC550", Offset = "0x83CAB50", VA = "0x1883CC550")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x83CD950", Offset = "0x83CBF50", VA = "0x1883CD950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion BEBIDKGLHFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x83CC630", Offset = "0x83CAC30", VA = "0x1883CC630")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x83CDA30", Offset = "0x83CC030", VA = "0x1883CDA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 NPNMEIDGLAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x83CC890", Offset = "0x83CAE90", VA = "0x1883CC890")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x83CDD90", Offset = "0x83CC390", VA = "0x1883CDD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 OCDMHIHKCOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x83CC140", Offset = "0x83CA740", VA = "0x1883CC140")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x83CD690", Offset = "0x83CBC90", VA = "0x1883CD690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 NAPJPBKPLFK
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x83CBAB0", Offset = "0x83CA0B0", VA = "0x1883CBAB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x83CD230", Offset = "0x83CB830", VA = "0x1883CD230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 MKJAKHMCJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x83CBF20", Offset = "0x83CA520", VA = "0x1883CBF20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x83CD460", Offset = "0x83CBA60", VA = "0x1883CD460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 KKFMLGCMMFA
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x83CBDE0", Offset = "0x83CA3E0", VA = "0x1883CBDE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion CNGGDPNDMNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x83CBD10", Offset = "0x83CA310", VA = "0x1883CBD10")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 FBLIIEJGLCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x83CCB30", Offset = "0x83CB130", VA = "0x1883CCB30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 LDNMJNBOHKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x83CCA50", Offset = "0x83CB050", VA = "0x1883CCA50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool AALDEOKANFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x83CBEC0", Offset = "0x83CA4C0", VA = "0x1883CBEC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool MEJBNGFPHHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x83CB990", Offset = "0x83C9F90", VA = "0x1883CB990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool CEDPDMFFJEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x83CB4A0", Offset = "0x83C9AA0", VA = "0x1883CB4A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool DDMKCNDEBIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x83CB440", Offset = "0x83C9A40", VA = "0x1883CB440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool AAHPAEKNPDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x83CB320", Offset = "0x83C9920", VA = "0x1883CB320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool AHMMIHALMAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x83CBCB0", Offset = "0x83CA2B0", VA = "0x1883CBCB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool DINPHDIMOPN
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x236AB60", Offset = "0x2369160", VA = "0x18236AB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event GNDLKMBGIHB CBMAJHIIKKP
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x83CB240", Offset = "0x83C9840", VA = "0x1883CB240")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x83CCEB0", Offset = "0x83CB4B0", VA = "0x1883CCEB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event PNBPECEEHKD AOKFEFCGPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x83CAFB0", Offset = "0x83C95B0", VA = "0x1883CAFB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x83CCC10", Offset = "0x83CB210", VA = "0x1883CCC10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event PNBPECEEHKD GIBENIPGOKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x83CB010", Offset = "0x83C9610", VA = "0x1883CB010")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x83CCC80", Offset = "0x83CB280", VA = "0x1883CCC80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event PNBPECEEHKD GPEMFODEPMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x83CB160", Offset = "0x83C9760", VA = "0x1883CB160")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x83CCDD0", Offset = "0x83CB3D0", VA = "0x1883CCDD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<MEACMOOJHJN, MEACMOOJHJN> CEBDFAKFDNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x83CB0F0", Offset = "0x83C96F0", VA = "0x1883CB0F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x83CCD60", Offset = "0x83CB360", VA = "0x1883CCD60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event PNBPECEEHKD HHEPGOOKNGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x83CB1D0", Offset = "0x83C97D0", VA = "0x1883CB1D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x83CCE40", Offset = "0x83CB440", VA = "0x1883CCE40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event PNBPECEEHKD BPLHKONLIME
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x83CB2B0", Offset = "0x83C98B0", VA = "0x1883CB2B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x83CCF20", Offset = "0x83CB520", VA = "0x1883CCF20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event PNBPECEEHKD GMDAEOELBFI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x83CB080", Offset = "0x83C9680", VA = "0x1883CB080")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x83CCCF0", Offset = "0x83CB2F0", VA = "0x1883CCCF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0", Slot = "8")]
		private void HJGFFMLCPLL(AEHCCAJOAGK HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83C9AB0", Offset = "0x83C80B0", VA = "0x1883C9AB0", Slot = "9")]
		public JOBMDEJONPK GetData()
		{
			return default(JOBMDEJONPK);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83C9E50", Offset = "0x83C8450", VA = "0x1883C9E50")]
		internal void KLKFPKPKFPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83CACE0", Offset = "0x83C92E0", VA = "0x1883CACE0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody MHLPIBDABBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83C9800", Offset = "0x83C7E00", VA = "0x1883C9800")]
		public HAIPDKCGNLO GetChild(int OHHMJGCBCKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x83CA940", Offset = "0x83C8F40", VA = "0x1883CA940")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) CKBACCDPBIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x83C92D0", Offset = "0x83C78D0", VA = "0x1883C92D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x83CABD0", Offset = "0x83C91D0", VA = "0x1883CABD0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x83C9DA0", Offset = "0x83C83A0", VA = "0x1883C9DA0")]
		private AEHCCAJOAGK KKNJGDNBFGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x83C9680", Offset = "0x83C7C80", VA = "0x1883C9680")]
		private void EEBICEODLFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x83CA110", Offset = "0x83C8710", VA = "0x1883CA110")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x83CA050", Offset = "0x83C8650", VA = "0x1883CA050")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x83C9E50", Offset = "0x83C8450", VA = "0x1883C9E50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x83CA0B0", Offset = "0x83C86B0", VA = "0x1883CA0B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x83CA170", Offset = "0x83C8770", VA = "0x1883CA170")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x83C88C0", Offset = "0x83C6EC0", VA = "0x1883C88C0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x83CA1D0", Offset = "0x83C87D0", VA = "0x1883CA1D0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x83C9620", Offset = "0x83C7C20", VA = "0x1883C9620")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x83C9FF0", Offset = "0x83C85F0", VA = "0x1883C9FF0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x83CAAA0", Offset = "0x83C90A0", VA = "0x1883CAAA0")]
		public void SetParent(RigidbodyEx OHLIHBDBKCE, bool CCADIPLOOPF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x83CA4E0", Offset = "0x83C8AE0", VA = "0x1883CA4E0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83C9B40", Offset = "0x83C8140", VA = "0x1883C9B40")]
		public bool IsRigidbodyAncestor(RigidbodyEx NJNGODBLHLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x83C9C40", Offset = "0x83C8240", VA = "0x1883C9C40")]
		public bool IsRigidbodyDescendant(RigidbodyEx IJFDGHHLJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x83C8B30", Offset = "0x83C7130", VA = "0x1883C8B30")]
		public void AddInterpolationRestriction(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x83CA240", Offset = "0x83C8840", VA = "0x1883CA240")]
		public void RemoveInterpolationRestriction(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x83C8BA0", Offset = "0x83C71A0", VA = "0x1883C8BA0")]
		public void AddKinematic(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x83CA2B0", Offset = "0x83C88B0", VA = "0x1883CA2B0")]
		public void RemoveKinematic(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83CAA20", Offset = "0x83C9020", VA = "0x1883CAA20")]
		public void SetKinematic(object EJJDDFFADPC, bool GFJJBICPGBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x83CA840", Offset = "0x83C8E40", VA = "0x1883CA840")]
		public void SetDiscontinuousPositionAndRotation(Vector3 DPNBIIDKBAI, Quaternion JFHALMAIDBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x83CA740", Offset = "0x83C8D40", VA = "0x1883CA740")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 MELCAIBPDLF, Quaternion IFIPONJHJJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x83C99A0", Offset = "0x83C7FA0", VA = "0x1883C99A0")]
		public Vector3 GetConstrainedVelocity(Vector3 NPNMEIDGLAE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x83C9890", Offset = "0x83C7E90", VA = "0x1883C9890")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 NAPJPBKPLFK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83C8A40", Offset = "0x83C7040", VA = "0x1883C8A40")]
		public void AddForce(Vector3 ECOALLGHBMI, ForceMode FMAPMNGMDMD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x83C8930", Offset = "0x83C6F30", VA = "0x1883C8930")]
		public void AddForceAtPosition(Vector3 ECOALLGHBMI, Vector3 EPCLGOKLIPO, ForceMode FMAPMNGMDMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x83C8D70", Offset = "0x83C7370", VA = "0x1883C8D70")]
		public void AddTorque(Vector3 LLLAFEEDFHF, ForceMode FMAPMNGMDMD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x83C8C10", Offset = "0x83C7210", VA = "0x1883C8C10")]
		public void AddRelativeTorque(Vector3 LLLAFEEDFHF, ForceMode FMAPMNGMDMD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x83CADB0", Offset = "0x83C93B0", VA = "0x1883CADB0")]
		public Vector3 WorldToLocalVelocity(Vector3 BNPCCEGFLAG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x83C9EE0", Offset = "0x83C84E0", VA = "0x1883C9EE0")]
		public Vector3 LocalToWorldVelocity(Vector3 OCDMHIHKCOM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x83C95C0", Offset = "0x83C7BC0", VA = "0x1883C95C0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x83C9560", Offset = "0x83C7B60", VA = "0x1883C9560")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x83C9500", Offset = "0x83C7B00", VA = "0x1883C9500")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x83C94A0", Offset = "0x83C7AA0", VA = "0x1883C94A0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x83CA640", Offset = "0x83C8C40", VA = "0x1883CA640")]
		public void ResetVelocityWorldSpace(Vector3 BFCMGGLPKOG, Vector3 CFMHHLGNOMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x83CA540", Offset = "0x83C8B40", VA = "0x1883CA540")]
		public void ResetVelocityLocalSpace(Vector3 FHHDANGJANF, Vector3 MKJAKHMCJFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x83CA400", Offset = "0x83C8A00", VA = "0x1883CA400")]
		public void ResetLinearVelocityLocalSpace(Vector3 FHHDANGJANF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x83CABE0", Offset = "0x83C91E0", VA = "0x1883CABE0")]
		public bool SweepTest(Vector3 IGEMMIGMOOK, [Out] RaycastHit CHOONAICPAA, float JPGIFEODCKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x83C9D40", Offset = "0x83C8340", VA = "0x1883C9D40")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x83CAB70", Offset = "0x83C9170", VA = "0x1883CAB70")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x83CAD50", Offset = "0x83C9350", VA = "0x1883CAD50")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x83C8D00", Offset = "0x83C7300", VA = "0x1883C8D00")]
		public void AddShouldHaveUnityRigidbodyToken(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x83CA320", Offset = "0x83C8920", VA = "0x1883CA320")]
		public void RemoveShouldHaveUnityRigidbodyToken(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x83C9100", Offset = "0x83C7700", VA = "0x1883C9100")]
		public void ApplyForceVelocityChange(OCNBACAEJKA IIPHGHABFEI, Vector3 FBJOGNFJNKE, float GINNKEFNNNJ, float AGKFEOKGNFN = 8f, float LKKCFIBADJL = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x83C9000", Offset = "0x83C7600", VA = "0x1883C9000")]
		public void ApplyAngularVelocityChange(GNGBJGPGOGK DMMOCNOPLNI, Vector3 CFIMLPPLPIK, float KMIIDKLEDDJ = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x83C91C0", Offset = "0x83C77C0", VA = "0x1883C91C0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(GNGBJGPGOGK DMMOCNOPLNI, Vector3 OOBEGCNALKF, float LNKOBALGGOE = 7f, float OKOMENKNBDN = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x83C8F30", Offset = "0x83C7530", VA = "0x1883C8F30")]
		public bool AllowedScaleChange(float KDJJCHBMFBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x83C8E60", Offset = "0x83C7460", VA = "0x1883C8E60")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx GHCGIEELPNO, object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x83CA390", Offset = "0x83C8990", VA = "0x1883CA390")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x83C88B0", Offset = "0x83C6EB0", VA = "0x1883C88B0", Slot = "12")]
		private void AICFFOPEAAD(IDHOFIHAGPL INLEBAAACKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x83CAF40", Offset = "0x83C9540", VA = "0x1883CAF40")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xBD0030", Offset = "0xBCE630", VA = "0x180BD0030", Slot = "4")]
		private GameObject MOEMGAEMJNH()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA17AF0", Offset = "0xA160F0", VA = "0x180A17AF0", Slot = "10")]
		private bool OAGFDLFCCPO()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class KCAMCPCCCFL
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x83BA300", Offset = "0x83B8900", VA = "0x1883BA300")]
	public static AEHCCAJOAGK PJAGFJDHAKD(this RigidbodyEx DPBHNMFBAMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(LONCFKCDDMN), new string[] { })]
public class PMHHFBIMKIC : LONCFKCDDMN, PNPJOMLIBJD
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private JIKJBOBICND DHJEDIPMPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EBILOFLAHOD JGONMCGPFPB;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public JIKJBOBICND PLBPABECHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public EBILOFLAHOD OGKNHGHLAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x83C77E0", Offset = "0x83C5DE0", VA = "0x1883C77E0", Slot = "7")]
	public void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x83C7850", Offset = "0x83C5E50", VA = "0x1883C7850", Slot = "6")]
	public AEHCCAJOAGK JAOMOKLNDKI(RigidbodyEx DPBHNMFBAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PMHHFBIMKIC()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static GCADBNOOJOM UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int MGGIPLDPANF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int FLBNGNHJJBK;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x83C8730", Offset = "0x83C6D30", VA = "0x1883C8730")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x83C8770", Offset = "0x83C6D70", VA = "0x1883C8770")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x83C8750", Offset = "0x83C6D50", VA = "0x1883C8750")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string NAAMEAFIHJI, [Optional] UnityEngine.Object INLEBAAACKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string NAAMEAFIHJI, [Optional] UnityEngine.Object INLEBAAACKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x83C8860", Offset = "0x83C6E60", VA = "0x1883C8860")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PACOJPNHHBH
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class BNPIIMENNPN : FGHLALPKLCB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9FA9E0", Offset = "0x9F8FE0", VA = "0x1809FA9E0", Slot = "4")]
		public Vector3 KHMLNLOJDIG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9FA9E0", Offset = "0x9F8FE0", VA = "0x1809FA9E0", Slot = "5")]
		public Vector3 PCGDBHDCGFH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "6")]
		public bool GNDAJCOACJJ(float CLFAAEDMDHI, float FBDABLGDOKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BNPIIMENNPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static FGHLALPKLCB EIPDKGPNADH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x83C6A50", Offset = "0x83C5050", VA = "0x1883C6A50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HKOLHAKECHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode JJAOGKDDDON
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
	void LLGFJHIIOAB();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CPMGCGEAHFH(bool AALDEOKANFC);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ECEPNMAFMKB(bool AALDEOKANFC);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DAAJDDOAIDE(Rigidbody OHEGODNMMIN);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LMNOMKFELDH(Vector3 IGEMMIGMOOK, [Out] RaycastHit CHOONAICPAA, float JPGIFEODCKP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OHDDGMFNMNC : IDisposable, CLLFLKHFPNF
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DINEBAHNNBA COBALJIKJEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<MEACMOOJHJN, MEACMOOJHJN> CEBDFAKFDNI;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LLGFJHIIOAB();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface EBILOFLAHOD
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BJGKLNFEMFG EFEBEPANAHM(AEHCCAJOAGK HCAMONPFOJM);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KNHPLJKDFKI LIGMAIIODBK(AEHCCAJOAGK HCAMONPFOJM);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GCDMBAAHIPA BPBEFMHDKIA(AEHCCAJOAGK HCAMONPFOJM);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AMEOAJBEAJH HHOAOKAAJAK(AEHCCAJOAGK HCAMONPFOJM);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HDGJFEKHLEF CFFINFLKEPO(AEHCCAJOAGK HCAMONPFOJM);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OHDDGMFNMNC FOAJOBADFED(AEHCCAJOAGK HCAMONPFOJM);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DDJELBIHLCK JGJLPKPIJMG(AEHCCAJOAGK HCAMONPFOJM);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KGLLPODCDJM DOIJEDHCGLI(AEHCCAJOAGK HCAMONPFOJM);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HKOLHAKECHJ FLNNJJGHOKD(AEHCCAJOAGK HCAMONPFOJM);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ONLILAHHPMI AMNOMNAJEAI(AEHCCAJOAGK HCAMONPFOJM);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FIJOPHMCOJO FJDCEPANACK(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DPANBNHFCKB CLKBBGLCOFF(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GABJBCBBIKD JFAIAHOCEBJ(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	JAEJCPLCJMA LIHHJIOLDMA(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JGFBLFFIGMO IJJAJPKMLEG(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AEHCCAJOAGK JAOMOKLNDKI(RigidbodyEx DPBHNMFBAMI, JOBMDEJONPK APDBNIMCPID, LONCFKCDDMN PAKPDHLKNJE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KGLLPODCDJM
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGIFEHKDDPN(Vector3 ECOALLGHBMI, ForceMode FMAPMNGMDMD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LGOCIELBIIK(Vector3 ECOALLGHBMI, Vector3 EPCLGOKLIPO, ForceMode FMAPMNGMDMD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KKOKDJLJLLK(Vector3 LLLAFEEDFHF, ForceMode FMAPMNGMDMD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NJFLMALDHNB(Vector3 LLLAFEEDFHF, ForceMode FMAPMNGMDMD = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ONLILAHHPMI
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool KNIBBPIGMCF
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
	void DAAJDDOAIDE(Rigidbody OHEGODNMMIN);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OANECBGNIHD(Rigidbody OHEGODNMMIN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BJGKLNFEMFG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<AEHCCAJOAGK> DEMICCKDBKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	AEHCCAJOAGK FMDIEJKNFGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	AEHCCAJOAGK LHCPKJJPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event PNBPECEEHKD AOKFEFCGPPH;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event PNBPECEEHKD GIBENIPGOKD;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event GNDLKMBGIHB KIAKJBHJBDD;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action ALLBGBJDNPF;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action EGIDEGKAHHI;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<AEHCCAJOAGK> FDEJNPJMBLG;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<AEHCCAJOAGK> MOGLNKNFOPP;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action GEFBCEJKHND;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<AEHCCAJOAGK> KONPFMJBHEC;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PFEAOMFGIPC(AEHCCAJOAGK FAMAONKAFDI, bool CCADIPLOOPF = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GCDMBAAHIPA
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 IKEEOKKFNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 PPOEAMFJKMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LCIGENBHIIO(AEHCCAJOAGK JHDAOHEONAC, object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JPAPBHMBHOL(object EJJDDFFADPC);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface JAEJCPLCJMA
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 DIFEGNJKDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 GDHCBFHODJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float ILIOIANLCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float IMNDBPGANOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 KCEMHIHMFPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion NEFBFOAEHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event PNBPECEEHKD CINAFJPLFMK;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NMOLEIEJHFM((Quaternion rot, Vector3 moments) CKBACCDPBIH);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HPBGKAMNHIG();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BHIHKAKKCLF();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KLLMDLAJOMO();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DAAJDDOAIDE(Rigidbody OHEGODNMMIN);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OANECBGNIHD(Rigidbody OHEGODNMMIN);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EPCDCICFCMJ();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GABJBCBBIKD
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLGFJHIIOAB();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNAGMCHKEPB(object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OBLODMOAEKG(object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JLNEKFGGPEJ(AEHCCAJOAGK DPBHNMFBAMI);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DLHHCDEJEBM(AEHCCAJOAGK DPBHNMFBAMI);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IHJCPCJCJFJ();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DDJELBIHLCK
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool KGPPIMBCPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event PNBPECEEHKD GMAEPBAHAJE;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HHNGPMIMDOO(object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ECLLEAMJHDE(object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BLLMHFJJADE(object EJJDDFFADPC, bool GFJJBICPGBM);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DAAJDDOAIDE(Rigidbody FFHIAOPJEJF);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OANECBGNIHD(Rigidbody OHEGODNMMIN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DPANBNHFCKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool BNFOGIBLEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool LMGPENNCPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event PNBPECEEHKD HMGIPDEBDGF;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LLGFJHIIOAB();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DIPLHBJMKEM(AEHCCAJOAGK JHDAOHEONAC);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HCCCGLGGJNO(AEHCCAJOAGK JHDAOHEONAC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JGFBLFFIGMO
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool GOEFNOABCHI
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool NGHCBIDJJPG
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints NDDPBBNBEMM
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
	void DAAJDDOAIDE(Rigidbody OHEGODNMMIN);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OANECBGNIHD(Rigidbody OHEGODNMMIN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AMEOAJBEAJH
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float HLOJOBIKJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float AEIOPPGFCCH
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
	void DAAJDDOAIDE(Rigidbody OHEGODNMMIN);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OANECBGNIHD(Rigidbody OHEGODNMMIN);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HDGJFEKHLEF
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool MBNDMLLGALA;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event PNBPECEEHKD OEJFEEIDNPB;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLGFJHIIOAB();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GMPMKPGGEJG();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IIAGPMFFLGD();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PLELPHGDIGK();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LCLIEIIFEMH();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FGHMOILEBNK();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ENCOGDACOEB(bool JKDOKIEEKLK);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BOLEDFNDLNO();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface FIJOPHMCOJO
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody LJPLOMDHOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool AJOEBCDDACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLGFJHIIOAB();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OLPGEFNAPKA(object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LLJCOJABAHE(object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MJPDMBEMBIP();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface KNHPLJKDFKI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	FGHLALPKLCB GPHCHFOOBEF
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	EKDAONPNEDM PFHAOKHAIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 MHHKMIMGCEN
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 MBONAKJIGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 NGPCALAEKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 PPKJNICDJFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float KAAKNIDJMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool ACLAGMPFHFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LLGFJHIIOAB();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PHNPIGPKCIB(object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CKHAMKNHENO(GNGBJGPGOGK DMMOCNOPLNI, Vector3 CFIMLPPLPIK, float KMIIDKLEDDJ = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void IOFCEMOCNKJ(OCNBACAEJKA IIPHGHABFEI, Vector3 FBJOGNFJNKE, float GINNKEFNNNJ, float AGKFEOKGNFN = 8f, float LKKCFIBADJL = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JBLCNFLLANL(GNGBJGPGOGK DMMOCNOPLNI, Vector3 OOBEGCNALKF, float LNKOBALGGOE = 7f, float OKOMENKNBDN = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DIIEGPIOIEF();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void CLGDPDBNAMG();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ONIIAKFKNGM();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void IDLPDECABCM();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void DAAJDDOAIDE(Rigidbody OHEGODNMMIN);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 BMCODDGJPBA(Vector3 NPNMEIDGLAE);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ILOOIMLILFL(object EJJDDFFADPC);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LANBKIAKANC(Vector3 PBPCDIDONHL);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FOPCBHBBKFA(Vector3 FHHDANGJANF, Vector3 MKJAKHMCJFJ);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MBNADKIEICD(Vector3 BFCMGGLPKOG, Vector3 CFMHHLGNOMG);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 FABBPJPCFND(Vector3 OCDMHIHKCOM);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 IIACFCKBMEK(Vector3 BNPCCEGFLAG);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface JIKJBOBICND
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool NHGNKHJLJPN
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLCIKPEJEGN(string JHEMEKBLBHP);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EKGLMIFCNFL(RigidbodyEx DPBHNMFBAMI, Action BDCLNIJAFBF);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JGMGMHCDANN LFMNGMBGDGC(int GHOFAPABKKA);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IGDADFADADH(Vector3 PCINKCAOPDB, float EFHADBJGAPC, Color NGGKCKILBNF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface LONCFKCDDMN
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	JIKJBOBICND PLBPABECHPB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	EBILOFLAHOD OGKNHGHLAPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AEHCCAJOAGK JAOMOKLNDKI(RigidbodyEx DPBHNMFBAMI);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OBOFCNBAJCN : AEHCCAJOAGK, IDisposable, PLBHICEOMKN
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool LINNHOJLAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly LONCFKCDDMN PAKPDHLKNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal BJGKLNFEMFG EBBCJEKFBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal GABJBCBBIKD OJFFAOGHMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal DPANBNHFCKB KNJOHLFGHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal KNHPLJKDFKI NPNMEIDGLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal GCDMBAAHIPA ECBHFMKCMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal JAEJCPLCJMA JMCHFJPNMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal AMEOAJBEAJH KMMPMJPJHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal ONLILAHHPMI KDEGDBKIFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal HDGJFEKHLEF BANIHFJJCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal OHDDGMFNMNC HHMNOKNDOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal DDJELBIHLCK KIJABMKEMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal KGLLPODCDJM ECOALLGHBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal JGFBLFFIGMO AEHGLKFOMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal FIJOPHMCOJO OHEGODNMMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal HKOLHAKECHJ LGHLJHCNEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable HMHGCLEKALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool DNAGOIEKLGG;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public PKENAFNLEAO PPAJLDLBJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "22")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public HAIPDKCGNLO JONJPMBBDAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xCD6750", Offset = "0xCD4D50", VA = "0x180CD6750", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xE59ED0", Offset = "0xE584D0", VA = "0x180E59ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject ACLMMAOCLNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9F64A0", Offset = "0x9F4AA0", VA = "0x1809F64A0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9F64C0", Offset = "0x9F4AC0", VA = "0x1809F64C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform IOFGLPCMIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xD65080", Offset = "0xD63680", VA = "0x180D65080", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xE6ABC0", Offset = "0xE691C0", VA = "0x180E6ABC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody LJPLOMDHOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x83C3840", Offset = "0x83C1E40", VA = "0x1883C3840", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public AEHCCAJOAGK LHCPKJJPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x83C3E80", Offset = "0x83C2480", VA = "0x1883C3E80", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x83C58F0", Offset = "0x83C3EF0", VA = "0x1883C58F0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int GGKEEFPNDLI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x83BFDB0", Offset = "0x83BE3B0", VA = "0x1883BFDB0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public AEHCCAJOAGK FMDIEJKNFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x83C5390", Offset = "0x83C3990", VA = "0x1883C5390", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool MPKPPHOFPOF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x83C5ED0", Offset = "0x83C44D0", VA = "0x1883C5ED0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool BNFOGIBLEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x83C5D50", Offset = "0x83C4350", VA = "0x1883C5D50", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool LMGPENNCPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x83C4CE0", Offset = "0x83C32E0", VA = "0x1883C4CE0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public FGHLALPKLCB GPHCHFOOBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x83BFF20", Offset = "0x83BE520", VA = "0x1883BFF20", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x83C03F0", Offset = "0x83BE9F0", VA = "0x1883C03F0", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public EKDAONPNEDM PFHAOKHAIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x83BFE70", Offset = "0x83BE470", VA = "0x1883BFE70", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x83C5150", Offset = "0x83C3750", VA = "0x1883C5150", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float KAAKNIDJMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x83C3C30", Offset = "0x83C2230", VA = "0x1883C3C30", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x83BFD00", Offset = "0x83BE300", VA = "0x1883BFD00", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 MBONAKJIGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x83C3460", Offset = "0x83C1A60", VA = "0x1883C3460", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x83C5740", Offset = "0x83C3D40", VA = "0x1883C5740", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 PPKJNICDJFO
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x83C5F30", Offset = "0x83C4530", VA = "0x1883C5F30", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x83C54B0", Offset = "0x83C3AB0", VA = "0x1883C54B0", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 MHHKMIMGCEN
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x83C5DA0", Offset = "0x83C43A0", VA = "0x1883C5DA0", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x83C4B60", Offset = "0x83C3160", VA = "0x1883C4B60", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 NGPCALAEKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x83C35A0", Offset = "0x83C1BA0", VA = "0x1883C35A0", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x83C1650", Offset = "0x83BFC50", VA = "0x1883C1650", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool CEDPDMFFJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x83C4C90", Offset = "0x83C3290", VA = "0x1883C4C90", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool DDMKCNDEBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x83C3400", Offset = "0x83C1A00", VA = "0x1883C3400", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool AAHPAEKNPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x83C3D40", Offset = "0x83C2340", VA = "0x1883C3D40", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool ACLAGMPFHFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x83C56A0", Offset = "0x83C3CA0", VA = "0x1883C56A0", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 IKEEOKKFNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x83C5A40", Offset = "0x83C4040", VA = "0x1883C5A40", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 PPOEAMFJKMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x83C0710", Offset = "0x83BED10", VA = "0x1883C0710", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 DIFEGNJKDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x83C2430", Offset = "0x83C0A30", VA = "0x1883C2430", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x83C5B70", Offset = "0x83C4170", VA = "0x1883C5B70", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 GDHCBFHODJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x83C0150", Offset = "0x83BE750", VA = "0x1883C0150", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float ILIOIANLCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x83C4D70", Offset = "0x83C3370", VA = "0x1883C4D70", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float IMNDBPGANOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x83C3680", Offset = "0x83C1C80", VA = "0x1883C3680", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x83C08A0", Offset = "0x83BEEA0", VA = "0x1883C08A0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 KCEMHIHMFPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x83C27A0", Offset = "0x83C0DA0", VA = "0x1883C27A0", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion NEFBFOAEHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x83C5820", Offset = "0x83C3E20", VA = "0x1883C5820", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float HLOJOBIKJAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x83C4DC0", Offset = "0x83C33C0", VA = "0x1883C4DC0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x83BFC70", Offset = "0x83BE270", VA = "0x1883BFC70", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float AEIOPPGFCCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x83C4C40", Offset = "0x83C3240", VA = "0x1883C4C40", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x83C4280", Offset = "0x83C2880", VA = "0x1883C4280", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool KNIBBPIGMCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x83C2650", Offset = "0x83C0C50", VA = "0x1883C2650", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x83C1220", Offset = "0x83BF820", VA = "0x1883C1220", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public DINEBAHNNBA COBALJIKJEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x83BFD60", Offset = "0x83BE360", VA = "0x1883BFD60", Slot = "70")]
		get
		{
			return default(DINEBAHNNBA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x83C0B10", Offset = "0x83BF110", VA = "0x1883C0B10", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool KGPPIMBCPCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x83C56F0", Offset = "0x83C3CF0", VA = "0x1883C56F0", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform BBBFMBKGKMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xD65080", Offset = "0xD63680", VA = "0x180D65080", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 OAPICFGGNEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x83C0340", Offset = "0x83BE940", VA = "0x1883C0340", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x83C3790", Offset = "0x83C1D90", VA = "0x1883C3790", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float JLKGIJBFPNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x83C53E0", Offset = "0x83C39E0", VA = "0x1883C53E0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x83C3920", Offset = "0x83C1F20", VA = "0x1883C3920", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float LAJMIGPLNOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x83C0B70", Offset = "0x83BF170", VA = "0x1883C0B70", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x83C5C50", Offset = "0x83C4250", VA = "0x1883C5C50", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion MHHJHPJKLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x83C3F30", Offset = "0x83C2530", VA = "0x1883C3F30", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x83BFA60", Offset = "0x83BE060", VA = "0x1883BFA60", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 HOKNMKCMKBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x83C09B0", Offset = "0x83BEFB0", VA = "0x1883C09B0", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x83C2760", Offset = "0x83C0D60", VA = "0x1883C2760", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion OIMDLFMMKJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x83C4D30", Offset = "0x83C3330", VA = "0x1883C4D30", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x83BFCD0", Offset = "0x83BE2D0", VA = "0x1883BFCD0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints NDDPBBNBEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x83C44D0", Offset = "0x83C2AD0", VA = "0x1883C44D0", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x83C07F0", Offset = "0x83BEDF0", VA = "0x1883C07F0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool GOEFNOABCHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x83C23E0", Offset = "0x83C09E0", VA = "0x1883C23E0", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x83C02E0", Offset = "0x83BE8E0", VA = "0x1883C02E0", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode JJAOGKDDDON
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x83C0230", Offset = "0x83BE830", VA = "0x1883C0230", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x83C1AB0", Offset = "0x83C00B0", VA = "0x1883C1AB0", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool KHKHNOEIDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x83C4A20", Offset = "0x83C3020", VA = "0x1883C4A20", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool MEJBNGFPHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x83C40B0", Offset = "0x83C26B0", VA = "0x1883C40B0", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event PNBPECEEHKD AOKFEFCGPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x83C3E20", Offset = "0x83C2420", VA = "0x1883C3E20", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x83C04E0", Offset = "0x83BEAE0", VA = "0x1883C04E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event PNBPECEEHKD GIBENIPGOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x83C5B10", Offset = "0x83C4110", VA = "0x1883C5B10", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x83BF8F0", Offset = "0x83BDEF0", VA = "0x1883BF8F0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event GNDLKMBGIHB KIAKJBHJBDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x83C4470", Offset = "0x83C2A70", VA = "0x1883C4470", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x83C25F0", Offset = "0x83C0BF0", VA = "0x1883C25F0", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event PNBPECEEHKD HMGIPDEBDGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x83C47D0", Offset = "0x83C2DD0", VA = "0x1883C47D0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x83C53F0", Offset = "0x83C39F0", VA = "0x1883C53F0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event PNBPECEEHKD GPEMFODEPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x83C11C0", Offset = "0x83BF7C0", VA = "0x1883C11C0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x83C3C80", Offset = "0x83C2280", VA = "0x1883C3C80", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event PNBPECEEHKD OEJFEEIDNPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x83C3540", Offset = "0x83C1B40", VA = "0x1883C3540", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x83C3ED0", Offset = "0x83C24D0", VA = "0x1883C3ED0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<MEACMOOJHJN, MEACMOOJHJN> CEBDFAKFDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x83C5590", Offset = "0x83C3B90", VA = "0x1883C5590", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x83C3CE0", Offset = "0x83C22E0", VA = "0x1883C3CE0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event PNBPECEEHKD GMAEPBAHAJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x83C0280", Offset = "0x83BE880", VA = "0x1883C0280", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x83C2B60", Offset = "0x83C1160", VA = "0x1883C2B60", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event PNBPECEEHKD GMDAEOELBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x83C0900", Offset = "0x83BEF00", VA = "0x1883C0900", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x83C42E0", Offset = "0x83C28E0", VA = "0x1883C42E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x83C6050", Offset = "0x83C4650", VA = "0x1883C6050")]
	public OBOFCNBAJCN(GameObject CEKGANCAJPA, RigidbodyEx IBNAICKPLEA, LONCFKCDDMN PAKPDHLKNJE, [In] JOBMDEJONPK APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x83C0ED0", Offset = "0x83BF4D0", VA = "0x1883C0ED0", Slot = "139")]
	protected virtual void EFIIBBIHNML(LONCFKCDDMN PAKPDHLKNJE, JOBMDEJONPK APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x83C0B80", Offset = "0x83BF180", VA = "0x1883C0B80", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x83C4630", Offset = "0x83C2C30", VA = "0x1883C4630", Slot = "93")]
	public void LLGFJHIIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x83C3890", Offset = "0x83C1E90", VA = "0x1883C3890", Slot = "94")]
	public void JAINDIDLLHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x83C5450", Offset = "0x83C3A50", VA = "0x1883C5450", Slot = "95")]
	public void OIABCBMEMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x83C5290", Offset = "0x83C3890", VA = "0x1883C5290", Slot = "96")]
	public void NKDGHBONJAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x83C1280", Offset = "0x83BF880", VA = "0x1883C1280")]
	private void ENCOGDACOEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x83C0540", Offset = "0x83BEB40", VA = "0x1883C0540")]
	private void CJPABMMJAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x83C1790", Offset = "0x83BFD90", VA = "0x1883C1790")]
	private void FGHMOILEBNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x83C5950", Offset = "0x83C3F50", VA = "0x1883C5950", Slot = "30")]
	public AEHCCAJOAGK PFAEDCJHGFC(int OHHMJGCBCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x83C59D0", Offset = "0x83C3FD0", VA = "0x1883C59D0", Slot = "98")]
	public void PFEAOMFGIPC(AEHCCAJOAGK OHLIHBDBKCE, bool CCADIPLOOPF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x83C2C10", Offset = "0x83C1210", VA = "0x1883C2C10", Slot = "99")]
	public void IBEAKFJFBKO(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x83BFEC0", Offset = "0x83BE4C0", VA = "0x1883BFEC0", Slot = "100")]
	public void BKNOHCLGOHB(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x83C3300", Offset = "0x83C1900", VA = "0x1883C3300", Slot = "101")]
	public Vector3 IIACFCKBMEK(Vector3 BNPCCEGFLAG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x83C1550", Offset = "0x83BFB50", VA = "0x1883C1550", Slot = "102")]
	public Vector3 FABBPJPCFND(Vector3 OCDMHIHKCOM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x83C2E70", Offset = "0x83C1470", VA = "0x1883C2E70", Slot = "103")]
	public void IDLPDECABCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x83C06C0", Offset = "0x83BECC0", VA = "0x1883C06C0", Slot = "104")]
	public void CLGDPDBNAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x83C09F0", Offset = "0x83BEFF0", VA = "0x1883C09F0", Slot = "105")]
	public void DIIEGPIOIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x83C4930", Offset = "0x83C2F30", VA = "0x1883C4930", Slot = "106")]
	public void MBNADKIEICD(Vector3 BFCMGGLPKOG, Vector3 CFMHHLGNOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x83C1C10", Offset = "0x83C0210", VA = "0x1883C1C10", Slot = "107")]
	public void FOPCBHBBKFA(Vector3 FHHDANGJANF, Vector3 MKJAKHMCJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x83C4390", Offset = "0x83C2990", VA = "0x1883C4390", Slot = "108")]
	public void LANBKIAKANC(Vector3 PBPCDIDONHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x83C36D0", Offset = "0x83C1CD0", VA = "0x1883C36D0", Slot = "109")]
	public void IOFCEMOCNKJ(OCNBACAEJKA IIPHGHABFEI, Vector3 FBJOGNFJNKE, float GINNKEFNNNJ, float AGKFEOKGNFN = 8f, float LKKCFIBADJL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x83C05C0", Offset = "0x83BEBC0", VA = "0x1883C05C0", Slot = "110")]
	public void CKHAMKNHENO(GNGBJGPGOGK DMMOCNOPLNI, Vector3 CFIMLPPLPIK, float KMIIDKLEDDJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x83C39B0", Offset = "0x83C1FB0", VA = "0x1883C39B0", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JBLCNFLLANL(GNGBJGPGOGK DMMOCNOPLNI, Vector3 OOBEGCNALKF, float LNKOBALGGOE = 7f, float OKOMENKNBDN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x83BFFE0", Offset = "0x83BE5E0", VA = "0x1883BFFE0", Slot = "112")]
	public Vector3 BMCODDGJPBA(Vector3 OHLIHBDBKCE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x83C1B10", Offset = "0x83C0110", VA = "0x1883C1B10", Slot = "113")]
	public Vector3 FODFMHBJNNH(Vector3 OHLIHBDBKCE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x83C5650", Offset = "0x83C3C50", VA = "0x1883C5650", Slot = "114")]
	public void ONIIAKFKNGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x83C26A0", Offset = "0x83C0CA0", VA = "0x1883C26A0", Slot = "115")]
	public void GMDBJOIEBEK(AEHCCAJOAGK GHCGIEELPNO, object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x83C2950", Offset = "0x83C0F50", VA = "0x1883C2950", Slot = "116")]
	public void HCJADAIAMEA(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x83C52B0", Offset = "0x83C38B0", VA = "0x1883C52B0", Slot = "63")]
	public void NMOLEIEJHFM((Quaternion rot, Vector3 moments) CKBACCDPBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x83BFE20", Offset = "0x83BE420", VA = "0x1883BFE20", Slot = "117")]
	public void BHIHKAKKCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x83C2BC0", Offset = "0x83C11C0", VA = "0x1883C2BC0", Slot = "118")]
	public void HPBGKAMNHIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x83C4230", Offset = "0x83C2830", VA = "0x1883C4230", Slot = "119")]
	public void KLLMDLAJOMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x83C2710", Offset = "0x83C0D10", VA = "0x1883C2710", Slot = "120")]
	public bool GMPMKPGGEJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x83C5E80", Offset = "0x83C4480", VA = "0x1883C5E80", Slot = "97")]
	public void PLELPHGDIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x83C00E0", Offset = "0x83BE6E0", VA = "0x1883C00E0", Slot = "121")]
	public void BOLEDFNDLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x83C29B0", Offset = "0x83C0FB0", VA = "0x1883C29B0", Slot = "122")]
	public void HHNGPMIMDOO(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x83C0E70", Offset = "0x83BF470", VA = "0x1883C0E70", Slot = "123")]
	public void ECLLEAMJHDE(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x83BFF70", Offset = "0x83BE570", VA = "0x1883BFF70", Slot = "124")]
	public void BLLMHFJJADE(object EJJDDFFADPC, bool GFJJBICPGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x83C2C70", Offset = "0x83C1270", VA = "0x1883C2C70", Slot = "125")]
	public void ICKOCOBMLLD(Vector3 DPNBIIDKBAI, Quaternion JFHALMAIDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x83C1980", Offset = "0x83BFF80", VA = "0x1883C1980", Slot = "126")]
	public void FNKNCAGNOEC(Vector3 MELCAIBPDLF, Quaternion IFIPONJHJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x83C0850", Offset = "0x83BEE50", VA = "0x1883C0850", Slot = "127")]
	public bool DEJIONOLPFN(float KDJJCHBMFBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x83C4E10", Offset = "0x83C3410", VA = "0x1883C4E10", Slot = "128")]
	public void MPHIBMNGJNG(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x83C1730", Offset = "0x83BFD30", VA = "0x1883C1730", Slot = "129")]
	public void FGCBCNACPMH(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x83C55F0", Offset = "0x83C3BF0", VA = "0x1883C55F0", Slot = "130")]
	public void OLPGEFNAPKA(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x83C4770", Offset = "0x83C2D70", VA = "0x1883C4770", Slot = "131")]
	public void LLJCOJABAHE(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x83C17F0", Offset = "0x83BFDF0", VA = "0x1883C17F0", Slot = "132")]
	public void FGIFEHKDDPN(Vector3 ECOALLGHBMI, ForceMode FMAPMNGMDMD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x83C4520", Offset = "0x83C2B20", VA = "0x1883C4520", Slot = "133")]
	public void LGOCIELBIIK(Vector3 ECOALLGHBMI, Vector3 EPCLGOKLIPO, ForceMode FMAPMNGMDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x83C3FD0", Offset = "0x83C25D0", VA = "0x1883C3FD0", Slot = "134")]
	public void KKOKDJLJLLK(Vector3 LLLAFEEDFHF, ForceMode FMAPMNGMDMD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x83C51B0", Offset = "0x83C37B0", VA = "0x1883C51B0", Slot = "135")]
	public void NJFLMALDHNB(Vector3 LLLAFEEDFHF, ForceMode FMAPMNGMDMD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x83C4830", Offset = "0x83C2E30", VA = "0x1883C4830", Slot = "136")]
	public bool LMNOMKFELDH(Vector3 IGEMMIGMOOK, [Out] RaycastHit CHOONAICPAA, float JPGIFEODCKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x83C1500", Offset = "0x83BFB00", VA = "0x1883C1500", Slot = "137")]
	public void EPCDCICFCMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x83C6010", Offset = "0x83C4610", VA = "0x1883C6010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x83C2510", Offset = "0x83C0B10", VA = "0x1883C2510")]
	private void GFPPDIJKEPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x83BF950", Offset = "0x83BDF50", VA = "0x1883BF950")]
	private void BANHNHDNKML(AEHCCAJOAGK JHDAOHEONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x83C0C80", Offset = "0x83BF280", VA = "0x1883C0C80")]
	private void ECBIIHFFCLE(AEHCCAJOAGK JHDAOHEONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x83C18D0", Offset = "0x83BFED0", VA = "0x1883C18D0")]
	private void FHIFJMJDDEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x83BFB40", Offset = "0x83BE140", VA = "0x1883BFB40")]
	private void BBINBMFEGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x83C4E70", Offset = "0x83C3470", VA = "0x1883C4E70")]
	private void NCMCCOPDOBD(AEHCCAJOAGK CKMMPPDMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x83C0A40", Offset = "0x83BF040", VA = "0x1883C0A40")]
	private void DIPLHBJMKEM(AEHCCAJOAGK JHDAOHEONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x83C2880", Offset = "0x83C0E80", VA = "0x1883C2880")]
	private void HCCCGLGGJNO(AEHCCAJOAGK JHDAOHEONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x83C2A10", Offset = "0x83C1010", VA = "0x1883C2A10")]
	private void HLGDAICPDLG(HAIPDKCGNLO JHDAOHEONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x83C2EC0", Offset = "0x83C14C0", VA = "0x1883C2EC0", Slot = "142")]
	protected virtual void IGDIHBHNKJO(HAIPDKCGNLO DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x83C2080", Offset = "0x83C0680", VA = "0x1883C2080")]
	protected void FPNDJJLKHIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x83C1D00", Offset = "0x83C0300", VA = "0x1883C1D00")]
	protected void FPIAGMKIMNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x83C5020", Offset = "0x83C3620", VA = "0x1883C5020")]
	private void NGMEJIGJEBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x83C3AC0", Offset = "0x83C20C0", VA = "0x1883C3AC0")]
	private void JCHECBCPJOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class EMJIOCLPPFC
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x83B5B30", Offset = "0x83B4130", VA = "0x1883B5B30")]
	public static AEHCCAJOAGK CJEJILIIJMC(this AEHCCAJOAGK DPBHNMFBAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x83B5BF0", Offset = "0x83B41F0", VA = "0x1883B5BF0")]
	public static bool GLOMNCDHBHI(this AEHCCAJOAGK DPBHNMFBAMI, AEHCCAJOAGK NJNGODBLHLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x83B5A90", Offset = "0x83B4090", VA = "0x1883B5A90")]
	public static bool AOHCJCEAKII(this AEHCCAJOAGK DPBHNMFBAMI, AEHCCAJOAGK IJFDGHHLJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x83B5D10", Offset = "0x83B4310", VA = "0x1883B5D10")]
	public static HAIPDKCGNLO MDBGFNLELLG(this AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x83B5C90", Offset = "0x83B4290", VA = "0x1883B5C90")]
	public static OBOFCNBAJCN HCBBCLIMFLM(this AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JOGBJAFFIJN : EBILOFLAHOD
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x83BA260", Offset = "0x83B8860", VA = "0x1883BA260", Slot = "19")]
	public AEHCCAJOAGK JAOMOKLNDKI(RigidbodyEx DPBHNMFBAMI, JOBMDEJONPK APDBNIMCPID, LONCFKCDDMN PAKPDHLKNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "4")]
	public BJGKLNFEMFG EFEBEPANAHM(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "5")]
	public KNHPLJKDFKI LIGMAIIODBK(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "6")]
	public GCDMBAAHIPA BPBEFMHDKIA(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "7")]
	public AMEOAJBEAJH HHOAOKAAJAK(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "8")]
	public HDGJFEKHLEF CFFINFLKEPO(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "9")]
	public OHDDGMFNMNC FOAJOBADFED(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "10")]
	public DDJELBIHLCK JGJLPKPIJMG(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "11")]
	public KGLLPODCDJM DOIJEDHCGLI(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "12")]
	public HKOLHAKECHJ FLNNJJGHOKD(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "13")]
	public ONLILAHHPMI AMNOMNAJEAI(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230")]
	public FIJOPHMCOJO FJDCEPANACK(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230")]
	public DPANBNHFCKB CLKBBGLCOFF(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230")]
	public GABJBCBBIKD JFAIAHOCEBJ(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230")]
	public JAEJCPLCJMA LIHHJIOLDMA(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230")]
	public JGFBLFFIGMO IJJAJPKMLEG(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public JOGBJAFFIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "14")]
	private FIJOPHMCOJO CHAMIPHFKHO(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "15")]
	private DPANBNHFCKB GILEOKHCPBE(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "16")]
	private GABJBCBBIKD PCPADDACGGO(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "17")]
	private JAEJCPLCJMA CKHBOBJCMPO(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "18")]
	private JGFBLFFIGMO JLFDAHONKHJ(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(EBILOFLAHOD), new string[] { })]
public class FPJDFNBODAI : EBILOFLAHOD, PNPJOMLIBJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly EBILOFLAHOD NMOIELLJIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly EBILOFLAHOD FIOIFOJKKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private IEMPDOBFCIM ABCLNEAOIBC;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private EBILOFLAHOD OGKNHGHLAPH
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x83B8F00", Offset = "0x83B7500", VA = "0x1883B8F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x83B9010", Offset = "0x83B7610", VA = "0x1883B9010", Slot = "20")]
	public void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x83B8C80", Offset = "0x83B7280", VA = "0x1883B8C80", Slot = "4")]
	public BJGKLNFEMFG EFEBEPANAHM(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x83B9300", Offset = "0x83B7900", VA = "0x1883B9300", Slot = "5")]
	public KNHPLJKDFKI LIGMAIIODBK(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x83B8890", Offset = "0x83B6E90", VA = "0x1883B8890", Slot = "6")]
	public GCDMBAAHIPA BPBEFMHDKIA(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x83B8E60", Offset = "0x83B7460", VA = "0x1883B8E60", Slot = "7")]
	public AMEOAJBEAJH HHOAOKAAJAK(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x83B8930", Offset = "0x83B6F30", VA = "0x1883B8930", Slot = "8")]
	public HDGJFEKHLEF CFFINFLKEPO(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x83B8DC0", Offset = "0x83B73C0", VA = "0x1883B8DC0", Slot = "9")]
	public OHDDGMFNMNC FOAJOBADFED(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x83B9260", Offset = "0x83B7860", VA = "0x1883B9260", Slot = "10")]
	public DDJELBIHLCK JGJLPKPIJMG(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x83B8BE0", Offset = "0x83B71E0", VA = "0x1883B8BE0", Slot = "11")]
	public KGLLPODCDJM DOIJEDHCGLI(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x83B8D20", Offset = "0x83B7320", VA = "0x1883B8D20", Slot = "12")]
	public HKOLHAKECHJ FLNNJJGHOKD(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x83B87F0", Offset = "0x83B6DF0", VA = "0x1883B87F0", Slot = "13")]
	public ONLILAHHPMI AMNOMNAJEAI(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x83B89D0", Offset = "0x83B6FD0", VA = "0x1883B89D0")]
	public FIJOPHMCOJO FJDCEPANACK(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x83B8B30", Offset = "0x83B7130", VA = "0x1883B8B30")]
	public DPANBNHFCKB CLKBBGLCOFF(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x83B91B0", Offset = "0x83B77B0", VA = "0x1883B91B0")]
	public GABJBCBBIKD JFAIAHOCEBJ(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x83B8A80", Offset = "0x83B7080", VA = "0x1883B8A80")]
	public JAEJCPLCJMA LIHHJIOLDMA(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x83B8F60", Offset = "0x83B7560", VA = "0x1883B8F60")]
	public JGFBLFFIGMO IJJAJPKMLEG(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x83B9060", Offset = "0x83B7660", VA = "0x1883B9060", Slot = "19")]
	public AEHCCAJOAGK JAOMOKLNDKI(RigidbodyEx DPBHNMFBAMI, JOBMDEJONPK APDBNIMCPID, LONCFKCDDMN PAKPDHLKNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x83B93A0", Offset = "0x83B79A0", VA = "0x1883B93A0")]
	public FPJDFNBODAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x83B89D0", Offset = "0x83B6FD0", VA = "0x1883B89D0", Slot = "14")]
	private FIJOPHMCOJO CHAMIPHFKHO(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x83B8B30", Offset = "0x83B7130", VA = "0x1883B8B30", Slot = "15")]
	private DPANBNHFCKB GILEOKHCPBE(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x83B91B0", Offset = "0x83B77B0", VA = "0x1883B91B0", Slot = "16")]
	private GABJBCBBIKD PCPADDACGGO(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x83B8A80", Offset = "0x83B7080", VA = "0x1883B8A80", Slot = "17")]
	private JAEJCPLCJMA CKHBOBJCMPO(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x83B8F60", Offset = "0x83B7560", VA = "0x1883B8F60", Slot = "18")]
	private JGFBLFFIGMO JLFDAHONKHJ(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface EODMBPODEHO : BJGKLNFEMFG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHHBOOEOKAN(AEHCCAJOAGK DPBHNMFBAMI);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPCCIBAAOGI(AEHCCAJOAGK DPBHNMFBAMI);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBPFICIFFFM(AEHCCAJOAGK CKMMPPDMABF);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OOLLCDHEGFE(AEHCCAJOAGK CKMMPPDMABF);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JKMMCOILAOB : GCDMBAAHIPA
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	GCBGOACHPCG<AEHCCAJOAGK> CLBALIBDHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	AEHCCAJOAGK EAKDMDHIIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KEOJJJNPDKI : JAEJCPLCJMA
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) GMGHPDIOJHP(Rigidbody KEHLPGHPHHH);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface GBJOEEJHELP : DPANBNHFCKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	RRNetworkView PFFFFPLBLDM
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class NGOCDBPPKOH : HKOLHAKECHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly OBOFCNBAJCN DPBHNMFBAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode LIJAHILONNJ;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody LJPLOMDHOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x83BAFF0", Offset = "0x83B95F0", VA = "0x1883BAFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode JJAOGKDDDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x83BF340", Offset = "0x83BD940", VA = "0x1883BF340", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x83BF4F0", Offset = "0x83BDAF0", VA = "0x1883BF4F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x83BA5E0", Offset = "0x83B8BE0", VA = "0x1883BA5E0")]
	public NGOCDBPPKOH(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x83BF560", Offset = "0x83BDB60", VA = "0x1883BF560", Slot = "6")]
	public void LLGFJHIIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x83BF460", Offset = "0x83BDA60", VA = "0x1883BF460", Slot = "9")]
	public void DAAJDDOAIDE(Rigidbody OHEGODNMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x83BF450", Offset = "0x83BDA50", VA = "0x1883BF450", Slot = "7")]
	public void CPMGCGEAHFH(bool AALDEOKANFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x83BF4E0", Offset = "0x83BDAE0", VA = "0x1883BF4E0", Slot = "8")]
	public void ECEPNMAFMKB(bool AALDEOKANFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x83BF670", Offset = "0x83BDC70", VA = "0x1883BF670", Slot = "10")]
	public bool LMNOMKFELDH(Vector3 IGEMMIGMOOK, [Out] RaycastHit CHOONAICPAA, float JPGIFEODCKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x83BF7D0", Offset = "0x83BDDD0", VA = "0x1883BF7D0")]
	private void OAPIPEPLHKH(bool AALDEOKANFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class OIGFEMPOEAL : OHDDGMFNMNC, IDisposable, CLLFLKHFPNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly OBOFCNBAJCN DPBHNMFBAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private DINEBAHNNBA KCGCBDALFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private JGMGMHCDANN NOGAFAGCPOO;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public DINEBAHNNBA COBALJIKJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x83C6380", Offset = "0x83C4980", VA = "0x1883C6380", Slot = "6")]
		get
		{
			return default(DINEBAHNNBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x83C64D0", Offset = "0x83C4AD0", VA = "0x1883C64D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform EDEDOFJCJCC
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xCBEE20", Offset = "0xCBD420", VA = "0x180CBEE20", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<MEACMOOJHJN, MEACMOOJHJN> CEBDFAKFDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x83C6910", Offset = "0x83C4F10", VA = "0x1883C6910", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x83C65F0", Offset = "0x83C4BF0", VA = "0x1883C65F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x83C69C0", Offset = "0x83C4FC0", VA = "0x1883C69C0")]
	public OIGFEMPOEAL(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x83C66A0", Offset = "0x83C4CA0", VA = "0x1883C66A0", Slot = "8")]
	public void LLGFJHIIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x83C65A0", Offset = "0x83C4BA0", VA = "0x1883C65A0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x119CC60", Offset = "0x119B260", VA = "0x18119CC60", Slot = "11")]
	private void NABCKMAHPNM(MEACMOOJHJN MMOFILFNFGF, MEACMOOJHJN NAOJMHGIKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "12")]
	private void COMNIEOGHHG(bool MLHEEDKLBBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class DMLJKEANOOO : EBILOFLAHOD
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x83B3310", Offset = "0x83B1910", VA = "0x1883B3310", Slot = "4")]
	public BJGKLNFEMFG EFEBEPANAHM(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x83B3A90", Offset = "0x83B2090", VA = "0x1883B3A90", Slot = "5")]
	public KNHPLJKDFKI LIGMAIIODBK(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x83B2BF0", Offset = "0x83B11F0", VA = "0x1883B2BF0", Slot = "6")]
	public GCDMBAAHIPA BPBEFMHDKIA(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x83B3590", Offset = "0x83B1B90", VA = "0x1883B3590", Slot = "7")]
	public AMEOAJBEAJH HHOAOKAAJAK(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x83B2D20", Offset = "0x83B1320", VA = "0x1883B2D20", Slot = "8")]
	public HDGJFEKHLEF CFFINFLKEPO(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x83B34C0", Offset = "0x83B1AC0", VA = "0x1883B34C0", Slot = "9")]
	public OHDDGMFNMNC FOAJOBADFED(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x83B3970", Offset = "0x83B1F70", VA = "0x1883B3970", Slot = "10")]
	public DDJELBIHLCK JGJLPKPIJMG(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x83B3250", Offset = "0x83B1850", VA = "0x1883B3250", Slot = "11")]
	public KGLLPODCDJM DOIJEDHCGLI(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x83B3400", Offset = "0x83B1A00", VA = "0x1883B3400", Slot = "12")]
	public HKOLHAKECHJ FLNNJJGHOKD(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x83B2B30", Offset = "0x83B1130", VA = "0x1883B2B30", Slot = "13")]
	public ONLILAHHPMI AMNOMNAJEAI(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x83B2DF0", Offset = "0x83B13F0", VA = "0x1883B2DF0")]
	public FIJOPHMCOJO FJDCEPANACK(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x83B30C0", Offset = "0x83B16C0", VA = "0x1883B30C0")]
	public DPANBNHFCKB CLKBBGLCOFF(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x83B3840", Offset = "0x83B1E40", VA = "0x1883B3840")]
	public GABJBCBBIKD JFAIAHOCEBJ(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x83B2F30", Offset = "0x83B1530", VA = "0x1883B2F30")]
	public JAEJCPLCJMA LIHHJIOLDMA(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x83B3610", Offset = "0x83B1C10", VA = "0x1883B3610")]
	public JGFBLFFIGMO IJJAJPKMLEG(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x83B36F0", Offset = "0x83B1CF0", VA = "0x1883B36F0", Slot = "19")]
	public AEHCCAJOAGK JAOMOKLNDKI(RigidbodyEx DPBHNMFBAMI, JOBMDEJONPK APDBNIMCPID, LONCFKCDDMN PAKPDHLKNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public DMLJKEANOOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x83B2DF0", Offset = "0x83B13F0", VA = "0x1883B2DF0", Slot = "14")]
	private FIJOPHMCOJO CHAMIPHFKHO(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x83B30C0", Offset = "0x83B16C0", VA = "0x1883B30C0", Slot = "15")]
	private DPANBNHFCKB GILEOKHCPBE(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x83B3840", Offset = "0x83B1E40", VA = "0x1883B3840", Slot = "16")]
	private GABJBCBBIKD PCPADDACGGO(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x83B2F30", Offset = "0x83B1530", VA = "0x1883B2F30", Slot = "17")]
	private JAEJCPLCJMA CKHBOBJCMPO(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x83B3610", Offset = "0x83B1C10", VA = "0x1883B3610", Slot = "18")]
	private JGFBLFFIGMO JLFDAHONKHJ(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class MIIDGJFBMGL : KGLLPODCDJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly OBOFCNBAJCN DPBHNMFBAMI;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody LJPLOMDHOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x83BAFF0", Offset = "0x83B95F0", VA = "0x1883BAFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool KGPPIMBCPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x83BBBA0", Offset = "0x83BA1A0", VA = "0x1883BBBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool MPKPPHOFPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x83B9BF0", Offset = "0x83B81F0", VA = "0x1883B9BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private AEHCCAJOAGK LHCPKJJPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x83BB040", Offset = "0x83B9640", VA = "0x1883BB040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x83BA5E0", Offset = "0x83B8BE0", VA = "0x1883BA5E0")]
	public MIIDGJFBMGL(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x83BAE90", Offset = "0x83B9490", VA = "0x1883BAE90", Slot = "4")]
	public void FGIFEHKDDPN(Vector3 ECOALLGHBMI, ForceMode FMAPMNGMDMD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x83BB6E0", Offset = "0x83B9CE0", VA = "0x1883BB6E0")]
	private void NDEKLMINPNO(Vector3 ECOALLGHBMI, ForceMode FMAPMNGMDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x83BB200", Offset = "0x83B9800", VA = "0x1883BB200", Slot = "5")]
	public void LGOCIELBIIK(Vector3 ECOALLGHBMI, Vector3 EPCLGOKLIPO, ForceMode FMAPMNGMDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x83BB0A0", Offset = "0x83B96A0", VA = "0x1883BB0A0", Slot = "6")]
	public void KKOKDJLJLLK(Vector3 LLLAFEEDFHF, ForceMode FMAPMNGMDMD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x83BB480", Offset = "0x83B9A80", VA = "0x1883BB480")]
	private void MNMDBFLGFKD(Vector3 LLLAFEEDFHF, ForceMode FMAPMNGMDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x83BB940", Offset = "0x83B9F40", VA = "0x1883BB940", Slot = "7")]
	public void NJFLMALDHNB(Vector3 LLLAFEEDFHF, ForceMode FMAPMNGMDMD = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class LAMHKMCAKMA : ONLILAHHPMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly OBOFCNBAJCN DPBHNMFBAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool KEKCOAKJGJK;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool KNIBBPIGMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAB6E90", Offset = "0xAB5490", VA = "0x180AB6E90", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x83BA460", Offset = "0x83B8A60", VA = "0x1883BA460", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x83BA5E0", Offset = "0x83B8BE0", VA = "0x1883BA5E0")]
	public LAMHKMCAKMA(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x83BA430", Offset = "0x83B8A30", VA = "0x1883BA430", Slot = "6")]
	public void DAAJDDOAIDE(Rigidbody OHEGODNMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x83BA570", Offset = "0x83B8B70", VA = "0x1883BA570", Slot = "7")]
	public void OANECBGNIHD(Rigidbody OHEGODNMMIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class DPGMANGLAKJ : EODMBPODEHO, BJGKLNFEMFG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly AEHCCAJOAGK DPBHNMFBAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<AEHCCAJOAGK> PFPOPNGDHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private AEHCCAJOAGK KNNDNAPJIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private AEHCCAJOAGK JHDAOHEONAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform OGOBBEIFGPP;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform IOFGLPCMIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x83B49E0", Offset = "0x83B2FE0", VA = "0x1883B49E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public AEHCCAJOAGK LHCPKJJPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9EECE0", Offset = "0x9ED2E0", VA = "0x1809EECE0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x83B5080", Offset = "0x83B3680", VA = "0x1883B5080", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public AEHCCAJOAGK FMDIEJKNFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9EECF0", Offset = "0x9ED2F0", VA = "0x1809EECF0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<AEHCCAJOAGK> DEMICCKDBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6E0", Offset = "0x9ECCE0", VA = "0x1809EE6E0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event PNBPECEEHKD AOKFEFCGPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x83B4490", Offset = "0x83B2A90", VA = "0x1883B4490", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x83B3DB0", Offset = "0x83B23B0", VA = "0x1883B3DB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event PNBPECEEHKD GIBENIPGOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x83B5930", Offset = "0x83B3F30", VA = "0x1883B5930", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x83B3C60", Offset = "0x83B2260", VA = "0x1883B3C60", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event GNDLKMBGIHB KIAKJBHJBDD
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x83B4680", Offset = "0x83B2C80", VA = "0x1883B4680", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x83B4070", Offset = "0x83B2670", VA = "0x1883B4070", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action ALLBGBJDNPF
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x83B4220", Offset = "0x83B2820", VA = "0x1883B4220", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x83B3FD0", Offset = "0x83B25D0", VA = "0x1883B3FD0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action EGIDEGKAHHI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x83B4A40", Offset = "0x83B3040", VA = "0x1883B4A40", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x83B4940", Offset = "0x83B2F40", VA = "0x1883B4940", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<AEHCCAJOAGK> FDEJNPJMBLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x83B4530", Offset = "0x83B2B30", VA = "0x1883B4530", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x83B4C10", Offset = "0x83B3210", VA = "0x1883B4C10", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<AEHCCAJOAGK> MOGLNKNFOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x83B5300", Offset = "0x83B3900", VA = "0x1883B5300", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x83B47E0", Offset = "0x83B2DE0", VA = "0x1883B47E0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action GEFBCEJKHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x83B3BC0", Offset = "0x83B21C0", VA = "0x1883B3BC0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x83B45E0", Offset = "0x83B2BE0", VA = "0x1883B45E0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<AEHCCAJOAGK> KONPFMJBHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x83B4890", Offset = "0x83B2E90", VA = "0x1883B4890", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x83B3D00", Offset = "0x83B2300", VA = "0x1883B3D00", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x83B59D0", Offset = "0x83B3FD0", VA = "0x1883B59D0")]
	public DPGMANGLAKJ(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x83B3E50", Offset = "0x83B2450", VA = "0x1883B3E50", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x83B53B0", Offset = "0x83B39B0", VA = "0x1883B53B0", Slot = "30")]
	public void PFEAOMFGIPC(AEHCCAJOAGK FAMAONKAFDI, bool CCADIPLOOPF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x83B5090", Offset = "0x83B3690", VA = "0x1883B5090", Slot = "6")]
	public void PBPFICIFFFM(AEHCCAJOAGK CKMMPPDMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x83B4E00", Offset = "0x83B3400", VA = "0x1883B4E00", Slot = "7")]
	public void OOLLCDHEGFE(AEHCCAJOAGK CKMMPPDMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x83B4110", Offset = "0x83B2710", VA = "0x1883B4110", Slot = "4")]
	public void JHHBOOEOKAN(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x83B43F0", Offset = "0x83B29F0", VA = "0x1883B43F0", Slot = "5")]
	public void JPCCIBAAOGI(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x83B3F30", Offset = "0x83B2530", VA = "0x1883B3F30")]
	private void FGEBAJKBNEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x83B3EF0", Offset = "0x83B24F0", VA = "0x1883B3EF0")]
	private void EHJEFHIILKG(AEHCCAJOAGK CKMMPPDMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x83B4CC0", Offset = "0x83B32C0", VA = "0x1883B4CC0")]
	private void OJNDEMCGJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x83B4AE0", Offset = "0x83B30E0", VA = "0x1883B4AE0")]
	private void ODJMHPKMBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x83B42C0", Offset = "0x83B28C0", VA = "0x1883B42C0")]
	private void JNHIMGNKHMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x83B4720", Offset = "0x83B2D20", VA = "0x1883B4720")]
	[CompilerGenerated]
	private object LLKEONNOBMH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class FAPPBPEKAJA
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x83B5D60", Offset = "0x83B4360", VA = "0x1883B5D60")]
	public static EODMBPODEHO OFIGOOBGDCB(this AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class PPNAAIDLLAP : JKMMCOILAOB, GCDMBAAHIPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly OBOFCNBAJCN DPBHNMFBAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly GCBGOACHPCG<AEHCCAJOAGK> JAFDIAJLFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool GPMPCJLDMNK;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public GCBGOACHPCG<AEHCCAJOAGK> CLBALIBDHED
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 IKEEOKKFNOG
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x83C8510", Offset = "0x83C6B10", VA = "0x1883C8510", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 PPOEAMFJKMH
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x83C7E40", Offset = "0x83C6440", VA = "0x1883C7E40", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 MHHKMIMGCEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x83C8540", Offset = "0x83C6B40", VA = "0x1883C8540")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public AEHCCAJOAGK EAKDMDHIIDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x83C8460", Offset = "0x83C6A60", VA = "0x1883C8460", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x83C8630", Offset = "0x83C6C30", VA = "0x1883C8630")]
	public PPNAAIDLLAP(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x83C83F0", Offset = "0x83C69F0", VA = "0x1883C83F0", Slot = "8")]
	public void LCIGENBHIIO(AEHCCAJOAGK JHDAOHEONAC, object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x83C8390", Offset = "0x83C6990", VA = "0x1883C8390", Slot = "9")]
	public void JPAPBHMBHOL(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x83C7AA0", Offset = "0x83C60A0", VA = "0x1883C7AA0")]
	private Vector3 BCCJJHNEGJG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x83C8000", Offset = "0x83C6600", VA = "0x1883C8000")]
	private void IAAJLNDMIFG(AEHCCAJOAGK PDNMPAHMCNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class NFINNNIFLKJ
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x83BF280", Offset = "0x83BD880", VA = "0x1883BF280")]
	public static JKMMCOILAOB CKCBFDJPAGE(this AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class FLMHLDONDEL : KEOJJJNPDKI, JAEJCPLCJMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly OBOFCNBAJCN DPBHNMFBAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 BPGNLFEJJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 IHADCAGHIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float APNMIMOLDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float HKPAAKFJDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 KKKCDJBMGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? KKFMLGCMMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? CNGGDPNDMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool CODHNACFEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool PFLBBNINGLI;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 DIFEGNJKDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x160DE00", Offset = "0x160C400", VA = "0x18160DE00", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x83B5EE0", Offset = "0x83B44E0", VA = "0x1883B5EE0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 GDHCBFHODJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x83B61C0", Offset = "0x83B47C0", VA = "0x1883B61C0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float ILIOIANLCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xCE2E50", Offset = "0xCE1450", VA = "0x180CE2E50", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x83B60B0", Offset = "0x83B46B0", VA = "0x1883B60B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float IMNDBPGANOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xC07210", Offset = "0xC05810", VA = "0x180C07210", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x83B6390", Offset = "0x83B4990", VA = "0x1883B6390", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 KCEMHIHMFPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x83B77E0", Offset = "0x83B5DE0", VA = "0x1883B77E0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion NEFBFOAEHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x83B8510", Offset = "0x83B6B10", VA = "0x1883B8510", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody LJPLOMDHOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x83B7AF0", Offset = "0x83B60F0", VA = "0x1883B7AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event PNBPECEEHKD CINAFJPLFMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x83B68D0", Offset = "0x83B4ED0", VA = "0x1883B68D0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x83B7A50", Offset = "0x83B6050", VA = "0x1883B7A50", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x83B8690", Offset = "0x83B6C90", VA = "0x1883B8690")]
	public FLMHLDONDEL(AEHCCAJOAGK DPBHNMFBAMI, [In] JOBMDEJONPK APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x83B5F90", Offset = "0x83B4590", VA = "0x1883B5F90", Slot = "17")]
	public void BHIHKAKKCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x83B7970", Offset = "0x83B5F70", VA = "0x1883B7970", Slot = "16")]
	public void HPBGKAMNHIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x83B62B0", Offset = "0x83B48B0", VA = "0x1883B62B0", Slot = "19")]
	public void DAAJDDOAIDE(Rigidbody OHEGODNMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x83B8330", Offset = "0x83B6930", VA = "0x1883B8330", Slot = "20")]
	public void OANECBGNIHD(Rigidbody OHEGODNMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x83B7C30", Offset = "0x83B6230", VA = "0x1883B7C30", Slot = "18")]
	public void KLLMDLAJOMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x83B6440", Offset = "0x83B4A40", VA = "0x1883B6440", Slot = "21")]
	public void EPCDCICFCMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x83B5EE0", Offset = "0x83B44E0", VA = "0x1883B5EE0")]
	private void ADDLOKNLDAB(Vector3 OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x83B7B40", Offset = "0x83B6140", VA = "0x1883B7B40")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 KAABCIHEILP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x83B60B0", Offset = "0x83B46B0", VA = "0x1883B60B0")]
	private void BJHFPODEBLI(float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x83B6390", Offset = "0x83B4990", VA = "0x1883B6390")]
	private void HOMPCMLLJDF(float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x83B7DE0", Offset = "0x83B63E0", VA = "0x1883B7DE0")]
	private Vector3 LMDHJNMJANK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x83B8100", Offset = "0x83B6700", VA = "0x1883B8100", Slot = "15")]
	public void NMOLEIEJHFM((Quaternion rot, Vector3 moments) CKBACCDPBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x83B7F80", Offset = "0x83B6580", VA = "0x1883B7F80")]
	private Quaternion NKFPCLGBNJC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x83B7710", Offset = "0x83B5D10", VA = "0x1883B7710")]
	public void GMGHPDIOJHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x83B6970", Offset = "0x83B4F70", VA = "0x1883B6970", Slot = "4")]
	public (float, Vector3) GMGHPDIOJHP(Rigidbody KEHLPGHPHHH)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class KCOLMBHBMFJ
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x83BA370", Offset = "0x83B8970", VA = "0x1883BA370")]
	public static KEOJJJNPDKI FFMKBJEPBCM(this AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class LGMPJABHCEJ : GABJBCBBIKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly OBOFCNBAJCN DPBHNMFBAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly PHIGNGELHED NOJNOLGEIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly KDGIOFPALDJ KAHHOMCKKDN;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool AMCLNIJBPLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x17CC760", Offset = "0x17CAD60", VA = "0x1817CC760", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public KDGIOFPALDJ KFOHGIONJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280", Slot = "11")]
		get
		{
			return default(KDGIOFPALDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x83BAC80", Offset = "0x83B9280", VA = "0x1883BAC80")]
	public LGMPJABHCEJ(AEHCCAJOAGK DPBHNMFBAMI, [In] JOBMDEJONPK APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x83BA960", Offset = "0x83B8F60", VA = "0x1883BA960", Slot = "4")]
	public void LLGFJHIIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x83BAA30", Offset = "0x83B9030", VA = "0x1883BAA30")]
	private bool LNNOLMDOCEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x83BA6B0", Offset = "0x83B8CB0", VA = "0x1883BA6B0", Slot = "5")]
	public void GNAGMCHKEPB(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x83BAAD0", Offset = "0x83B90D0", VA = "0x1883BAAD0", Slot = "6")]
	public void OBLODMOAEKG(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x83BA6E0", Offset = "0x83B8CE0", VA = "0x1883BA6E0", Slot = "9")]
	public void IHJCPCJCJFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x83BA810", Offset = "0x83B8E10", VA = "0x1883BA810")]
	private void IJCJOKPNINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x83BAB00", Offset = "0x83B9100", VA = "0x1883BAB00")]
	private void OMNPGPNGBGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x83BA670", Offset = "0x83B8C70", VA = "0x1883BA670", Slot = "8")]
	public void DLHHCDEJEBM(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x83BA920", Offset = "0x83B8F20", VA = "0x1883BA920", Slot = "7")]
	public void JLNEKFGGPEJ(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class IJLBIHINJMA : DDJELBIHLCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly OBOFCNBAJCN DPBHNMFBAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly PHIGNGELHED OIHLKMFIEJJ;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool KGPPIMBCPCK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x83BA080", Offset = "0x83B8680", VA = "0x1883BA080", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event PNBPECEEHKD GMAEPBAHAJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x83B9E70", Offset = "0x83B8470", VA = "0x1883B9E70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x83B9FB0", Offset = "0x83B85B0", VA = "0x1883B9FB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x83BA170", Offset = "0x83B8770", VA = "0x1883BA170")]
	public IJLBIHINJMA(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x83B9FA0", Offset = "0x83B85A0", VA = "0x1883B9FA0", Slot = "7")]
	public void HHNGPMIMDOO(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x83B9F90", Offset = "0x83B8590", VA = "0x1883B9F90", Slot = "8")]
	public void ECLLEAMJHDE(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x83B9D60", Offset = "0x83B8360", VA = "0x1883B9D60", Slot = "9")]
	public void BLLMHFJJADE(object EJJDDFFADPC, bool GFJJBICPGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x83BA130", Offset = "0x83B8730", VA = "0x1883BA130", Slot = "12")]
	public void PMBDLBOMHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x83B9F10", Offset = "0x83B8510", VA = "0x1883B9F10", Slot = "10")]
	public void DAAJDDOAIDE(Rigidbody FFHIAOPJEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x83BA050", Offset = "0x83B8650", VA = "0x1883BA050", Slot = "11")]
	public void OANECBGNIHD(Rigidbody OHEGODNMMIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class ANJCCFMIBBJ : GBJOEEJHELP, DPANBNHFCKB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly OBOFCNBAJCN DPBHNMFBAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private RRNetworkView EGLHICHHNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool JCCCJEGELOB;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public RRNetworkView PFFFFPLBLDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool BNFOGIBLEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x83B26F0", Offset = "0x83B0CF0", VA = "0x1883B26F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool LMGPENNCPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xDBBFE0", Offset = "0xDBA5E0", VA = "0x180DBBFE0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event PNBPECEEHKD HMGIPDEBDGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x83B21F0", Offset = "0x83B07F0", VA = "0x1883B21F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x83B2650", Offset = "0x83B0C50", VA = "0x1883B2650", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x83B2700", Offset = "0x83B0D00", VA = "0x1883B2700")]
	public ANJCCFMIBBJ(AEHCCAJOAGK DPBHNMFBAMI, [In] JOBMDEJONPK APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x83B20C0", Offset = "0x83B06C0", VA = "0x1883B20C0", Slot = "9")]
	public void LLGFJHIIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x83B1CE0", Offset = "0x83B02E0", VA = "0x1883B1CE0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x83B1B70", Offset = "0x83B0170", VA = "0x1883B1B70", Slot = "10")]
	public void DIPLHBJMKEM(AEHCCAJOAGK JHDAOHEONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x83B1DE0", Offset = "0x83B03E0", VA = "0x1883B1DE0", Slot = "11")]
	public void HCCCGLGGJNO(AEHCCAJOAGK JHDAOHEONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x83B1F50", Offset = "0x83B0550", VA = "0x1883B1F50")]
	private void HKPAAAJJPHM(RRNetworkView MBPGHHNDAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x83B2290", Offset = "0x83B0890", VA = "0x1883B2290")]
	private void LOACIKIHMEM(HAIPDKCGNLO AAGGHIFABAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x83B23E0", Offset = "0x83B09E0", VA = "0x1883B23E0")]
	private void LOJDHMFMMJM(RRNetworkView CCGOAOBJLNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class FBGBLNBELBB
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x83B5E20", Offset = "0x83B4420", VA = "0x1883B5E20")]
	public static GBJOEEJHELP EMIMCJJICOH(this AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class OCLBPMECEMI : JGFBLFFIGMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly OBOFCNBAJCN DPBHNMFBAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints OPFLPGHGOHH;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool GOEFNOABCHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA3C270", Offset = "0xA3A870", VA = "0x180A3C270", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xD1E5E0", Offset = "0xD1CBE0", VA = "0x180D1E5E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool NGHCBIDJJPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xD1EBB0", Offset = "0xD1D1B0", VA = "0x180D1EBB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xD1EC30", Offset = "0xD1D230", VA = "0x180D1EC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints NDDPBBNBEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x83C6170", Offset = "0x83C4770", VA = "0x1883C6170", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x83C62D0", Offset = "0x83C48D0", VA = "0x1883C62D0")]
	public OCLBPMECEMI(AEHCCAJOAGK DPBHNMFBAMI, [In] JOBMDEJONPK APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x83C6140", Offset = "0x83C4740", VA = "0x1883C6140", Slot = "9")]
	public void DAAJDDOAIDE(Rigidbody OHEGODNMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x83C62A0", Offset = "0x83C48A0", VA = "0x1883C62A0", Slot = "10")]
	public void OANECBGNIHD(Rigidbody OHEGODNMMIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class BEDCMJAJONO : AMEOAJBEAJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly AEHCCAJOAGK DPBHNMFBAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float IFIDNLLDPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float FKHPPHJNCJO;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float HLOJOBIKJAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xEDF1A0", Offset = "0xEDD7A0", VA = "0x180EDF1A0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x83B2860", Offset = "0x83B0E60", VA = "0x1883B2860", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float AEIOPPGFCCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xD47950", Offset = "0xD45F50", VA = "0x180D47950", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x83B2980", Offset = "0x83B0F80", VA = "0x1883B2980", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x83B2AF0", Offset = "0x83B10F0", VA = "0x1883B2AF0")]
	public BEDCMJAJONO(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x83B2930", Offset = "0x83B0F30", VA = "0x1883B2930", Slot = "8")]
	public void DAAJDDOAIDE(Rigidbody OHEGODNMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x83B2A50", Offset = "0x83B1050", VA = "0x1883B2A50", Slot = "9")]
	public void OANECBGNIHD(Rigidbody OHEGODNMMIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class PLJPMANDLKC : HDGJFEKHLEF
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly JBBHIJHGEPM AGHOFCDHBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly OBOFCNBAJCN DPBHNMFBAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool PFAIIOJLKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool CIPKHEELPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int FCMIPCKKHIK;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody LJPLOMDHOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x83B7AF0", Offset = "0x83B60F0", VA = "0x1883B7AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool KHKHNOEIDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x83C75B0", Offset = "0x83C5BB0", VA = "0x1883C75B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private AEHCCAJOAGK LHCPKJJPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x83C73B0", Offset = "0x83C59B0", VA = "0x1883C73B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool MPKPPHOFPOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x83C7670", Offset = "0x83C5C70", VA = "0x1883C7670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event PNBPECEEHKD OEJFEEIDNPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x83C7310", Offset = "0x83C5910", VA = "0x1883C7310", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x83C7410", Offset = "0x83C5A10", VA = "0x1883C7410", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x83C7750", Offset = "0x83C5D50", VA = "0x1883C7750")]
	public PLJPMANDLKC(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x83C7520", Offset = "0x83C5B20", VA = "0x1883C7520", Slot = "6")]
	public void LLGFJHIIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x83C7300", Offset = "0x83C5900", VA = "0x1883C7300", Slot = "8")]
	public void IIAGPMFFLGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x83C71B0", Offset = "0x83C57B0", VA = "0x1883C71B0", Slot = "7")]
	public bool GMPMKPGGEJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x83C75D0", Offset = "0x83C5BD0", VA = "0x1883C75D0", Slot = "9")]
	public void PLELPHGDIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x83C6B20", Offset = "0x83C5120", VA = "0x1883C6B20", Slot = "13")]
	public void BOLEDFNDLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x83C6FD0", Offset = "0x83C55D0", VA = "0x1883C6FD0", Slot = "12")]
	public void ENCOGDACOEB(bool JKDOKIEEKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x83C74B0", Offset = "0x83C5AB0", VA = "0x1883C74B0", Slot = "10")]
	public bool LCLIEIIFEMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x83C70F0", Offset = "0x83C56F0", VA = "0x1883C70F0", Slot = "11")]
	public bool FGHMOILEBNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x83C6D50", Offset = "0x83C5350", VA = "0x1883C6D50")]
	private bool DELCGMBILLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x83C6BC0", Offset = "0x83C51C0", VA = "0x1883C6BC0")]
	private void CJGMGHEFJCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class IHPLEHILJBO : FIJOPHMCOJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly OBOFCNBAJCN DPBHNMFBAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly PHIGNGELHED IOJPAPMIMJO;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody LJPLOMDHOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool MPKPPHOFPOF
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x83B9BF0", Offset = "0x83B81F0", VA = "0x1883B9BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool AJOEBCDDACN
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x17CC760", Offset = "0x17CAD60", VA = "0x1817CC760", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x83B9C50", Offset = "0x83B8250", VA = "0x1883B9C50")]
	public IHPLEHILJBO(AEHCCAJOAGK DPBHNMFBAMI, [In] JOBMDEJONPK APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x83B97C0", Offset = "0x83B7DC0", VA = "0x1883B97C0", Slot = "5")]
	public void LLGFJHIIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x83B9BC0", Offset = "0x83B81C0", VA = "0x1883B9BC0", Slot = "7")]
	public void OLPGEFNAPKA(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x83B9860", Offset = "0x83B7E60", VA = "0x1883B9860", Slot = "8")]
	public void LLJCOJABAHE(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x83B9890", Offset = "0x83B7E90", VA = "0x1883B9890", Slot = "9")]
	public void MJPDMBEMBIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x83B9450", Offset = "0x83B7A50", VA = "0x1883B9450", Slot = "10")]
	public void BNALDMBCGNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x83B9640", Offset = "0x83B7C40", VA = "0x1883B9640", Slot = "11")]
	public void CPNCOCGKHPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class MLOLDEBBPON : KNHPLJKDFKI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly OBOFCNBAJCN DPBHNMFBAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly PHIGNGELHED JLDCAOIFDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float MNPGOIABGFO;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public FGHLALPKLCB GPHCHFOOBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public EKDAONPNEDM PFHAOKHAIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 MHHKMIMGCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x83BEE70", Offset = "0x83BD470", VA = "0x1883BEE70", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x83BEAA0", Offset = "0x83BD0A0", VA = "0x1883BEAA0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 MBONAKJIGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x83BD3D0", Offset = "0x83BB9D0", VA = "0x1883BD3D0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x83BED20", Offset = "0x83BD320", VA = "0x1883BED20", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 NGPCALAEKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x83BD4F0", Offset = "0x83BBAF0", VA = "0x1883BD4F0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x83BCE90", Offset = "0x83BB490", VA = "0x1883BCE90", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 PPKJNICDJFO
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x83BF070", Offset = "0x83BD670", VA = "0x1883BF070", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x83BEB60", Offset = "0x83BD160", VA = "0x1883BEB60", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float KAAKNIDJMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xEE2AF0", Offset = "0xEE10F0", VA = "0x180EE2AF0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x83BC190", Offset = "0x83BA790", VA = "0x1883BC190", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool ACLAGMPFHFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x20EB4D0", Offset = "0x20E9AD0", VA = "0x1820EB4D0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private KGLLPODCDJM GOAPBLIKEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x79C1B60", Offset = "0x79C0160", VA = "0x1879C1B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool KHKHNOEIDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x83BEA80", Offset = "0x83BD080", VA = "0x1883BEA80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x83BF190", Offset = "0x83BD790", VA = "0x1883BF190")]
	public MLOLDEBBPON(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x83BD150", Offset = "0x83BB750", VA = "0x1883BD150", Slot = "19")]
	public void LLGFJHIIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x83BC7F0", Offset = "0x83BADF0", VA = "0x1883BC7F0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x83BC660", Offset = "0x83BAC60", VA = "0x1883BC660", Slot = "28")]
	public void DAAJDDOAIDE(Rigidbody OHEGODNMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x15CFB40", Offset = "0x15CE140", VA = "0x1815CFB40", Slot = "20")]
	public void PHNPIGPKCIB(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x15CE3B0", Offset = "0x15CC9B0", VA = "0x1815CE3B0", Slot = "30")]
	public void ILOOIMLILFL(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x83BD1F0", Offset = "0x83BB7F0", VA = "0x1883BD1F0", Slot = "35")]
	public Vector3 IIACFCKBMEK(Vector3 BNPCCEGFLAG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x83BCCD0", Offset = "0x83BB2D0", VA = "0x1883BCCD0", Slot = "34")]
	public Vector3 FABBPJPCFND(Vector3 OCDMHIHKCOM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x83BD150", Offset = "0x83BB750", VA = "0x1883BD150", Slot = "27")]
	public void IDLPDECABCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x83BC600", Offset = "0x83BAC00", VA = "0x1883BC600", Slot = "25")]
	public void CLGDPDBNAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x83BC790", Offset = "0x83BAD90", VA = "0x1883BC790", Slot = "24")]
	public void DIIEGPIOIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x83BE840", Offset = "0x83BCE40", VA = "0x1883BE840", Slot = "33")]
	public void MBNADKIEICD(Vector3 BFCMGGLPKOG, Vector3 CFMHHLGNOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x83BD0F0", Offset = "0x83BB6F0", VA = "0x1883BD0F0", Slot = "32")]
	public void FOPCBHBBKFA(Vector3 FHHDANGJANF, Vector3 MKJAKHMCJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x83BE6A0", Offset = "0x83BCCA0", VA = "0x1883BE6A0", Slot = "31")]
	public void LANBKIAKANC(Vector3 PBPCDIDONHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x83BD640", Offset = "0x83BBC40", VA = "0x1883BD640", Slot = "22")]
	public void IOFCEMOCNKJ(OCNBACAEJKA IIPHGHABFEI, Vector3 FBJOGNFJNKE, float GINNKEFNNNJ, float AGKFEOKGNFN = 8f, float LKKCFIBADJL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x83BC380", Offset = "0x83BA980", VA = "0x1883BC380", Slot = "21")]
	public void CKHAMKNHENO(GNGBJGPGOGK DMMOCNOPLNI, Vector3 CFIMLPPLPIK, float KMIIDKLEDDJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x83BDC90", Offset = "0x83BC290", VA = "0x1883BDC90", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JBLCNFLLANL(GNGBJGPGOGK DMMOCNOPLNI, Vector3 OOBEGCNALKF, float LNKOBALGGOE = 7f, float OKOMENKNBDN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x16F8B90", Offset = "0x16F7190", VA = "0x1816F8B90")]
	private static void GPJIEMGDAAL(Vector3 NPNMEIDGLAE, Vector3 HPAMHMBDLLL, [Out] Vector3 JLJIPIBAPIH, [Out] Vector3 NFDBLLNJKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x83BC2A0", Offset = "0x83BA8A0", VA = "0x1883BC2A0", Slot = "29")]
	public Vector3 BMCODDGJPBA(Vector3 NPNMEIDGLAE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x83BEB90", Offset = "0x83BD190", VA = "0x1883BEB90", Slot = "26")]
	public void ONIIAKFKNGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x83BC190", Offset = "0x83BA790", VA = "0x1883BC190")]
	private void HAGKGDEMHHO(float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x83BCF50", Offset = "0x83BB550", VA = "0x1883BCF50")]
	private void FGCKAIIFCJC(Vector3 CFIMLPPLPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x83BE110", Offset = "0x83BC710", VA = "0x1883BE110")]
	private Vector3 KMAALFIECPO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x83BE220", Offset = "0x83BC820", VA = "0x1883BE220")]
	private void KOCOFLKLFJF(Vector3 OCDMHIHKCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x83BED50", Offset = "0x83BD350", VA = "0x1883BED50")]
	private Vector3 PCGDBHDCGFH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x83BC850", Offset = "0x83BAE50", VA = "0x1883BC850")]
	private void EGABAHFECHD(Vector3 OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x83BBBF0", Offset = "0x83BA1F0", VA = "0x1883BBBF0")]
	private void ACGICFBGDFK(Vector3 OCDMHIHKCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x83BEFC0", Offset = "0x83BD5C0", VA = "0x1883BEFC0")]
	private void POKBBOEDHIM()
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
