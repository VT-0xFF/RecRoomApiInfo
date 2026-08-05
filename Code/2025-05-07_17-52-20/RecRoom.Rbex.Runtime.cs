using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0x83D47C0", Offset = "0x83D37C0", VA = "0x1883D47C0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x204FCB0", Offset = "0x204ECB0", VA = "0x18204FCB0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83E78D0", Offset = "0x83E68D0", VA = "0x1883E78D0")]
		private void MEMPKEBCMCB(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83E7BD0", Offset = "0x83E6BD0", VA = "0x1883E7BD0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83E7C30", Offset = "0x83E6C30", VA = "0x1883E7C30")]
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
		private PhotonView photonView;

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
			[Cpp2IlInjected.Address(RVA = "0x83E37F0", Offset = "0x83E27F0", VA = "0x1883E37F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private AEHCCAJOAGK JDJLOEOKOGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int GGKEEFPNDLI
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x83E4DE0", Offset = "0x83E3DE0", VA = "0x1883E4DE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx PIIDGMAMFHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x83E5140", Offset = "0x83E4140", VA = "0x1883E5140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx FMDIEJKNFGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x83E5080", Offset = "0x83E4080", VA = "0x1883E5080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx JHDAOHEONAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x83E5D40", Offset = "0x83E4D40", VA = "0x1883E5D40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x83E7240", Offset = "0x83E6240", VA = "0x1883E7240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool OECNNBLFMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x803EFE0", Offset = "0x803DFE0", VA = "0x18803EFE0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x803CF70", Offset = "0x803BF70", VA = "0x18803CF70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform KOOMPFGMBLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1E853B0", Offset = "0x1E843B0", VA = "0x181E853B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform OBJHFHNBHMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1E853B0", Offset = "0x1E843B0", VA = "0x181E853B0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform BBBFMBKGKMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1E853B0", Offset = "0x1E843B0", VA = "0x181E853B0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public DINEBAHNNBA COBALJIKJEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x83E4E40", Offset = "0x83E3E40", VA = "0x1883E4E40")]
			get
			{
				return default(DINEBAHNNBA);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x83E69F0", Offset = "0x83E59F0", VA = "0x1883E69F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool BNFOGIBLEGI
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x83E5450", Offset = "0x83E4450", VA = "0x1883E5450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool LMGPENNCPHI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x83E4F60", Offset = "0x83E3F60", VA = "0x1883E4F60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public FGHLALPKLCB GPHCHFOOBEF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x83E5390", Offset = "0x83E4390", VA = "0x1883E5390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x83E6BB0", Offset = "0x83E5BB0", VA = "0x1883E6BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public EKDAONPNEDM PFHAOKHAIMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x83E5330", Offset = "0x83E4330", VA = "0x1883E5330")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x83E6B40", Offset = "0x83E5B40", VA = "0x1883E6B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ACLAGMPFHFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x83E5280", Offset = "0x83E4280", VA = "0x1883E5280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody LJPLOMDHOKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x83E52E0", Offset = "0x83E42E0", VA = "0x1883E52E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool GOEFNOABCHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x83E4FC0", Offset = "0x83E3FC0", VA = "0x1883E4FC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x83E6A60", Offset = "0x83E5A60", VA = "0x1883E6A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool BLMJJKMHDAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x167B000", Offset = "0x167A000", VA = "0x18167B000", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float HKPAAKFJDAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x83E5CE0", Offset = "0x83E4CE0", VA = "0x1883E5CE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float APNMIMOLDBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x83E5C80", Offset = "0x83E4C80", VA = "0x1883E5C80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x83E71D0", Offset = "0x83E61D0", VA = "0x1883E71D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float IFIDNLLDPOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x83E56B0", Offset = "0x83E46B0", VA = "0x1883E56B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x83E6E50", Offset = "0x83E5E50", VA = "0x1883E6E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float FKHPPHJNCJO
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x83E54B0", Offset = "0x83E44B0", VA = "0x1883E54B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x83E6C20", Offset = "0x83E5C20", VA = "0x1883E6C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool KEKCOAKJGJK
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x83E6290", Offset = "0x83E5290", VA = "0x1883E6290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x83E7780", Offset = "0x83E6780", VA = "0x1883E7780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 KKKCDJBMGCA
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x83E5A60", Offset = "0x83E4A60", VA = "0x1883E5A60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x83E6FA0", Offset = "0x83E5FA0", VA = "0x1883E6FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 PCINKCAOPDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x83E63D0", Offset = "0x83E53D0", VA = "0x1883E63D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode PJCEBBJIIHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x83E55F0", Offset = "0x83E45F0", VA = "0x1883E55F0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x83E6D70", Offset = "0x83E5D70", VA = "0x1883E6D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float KAAKNIDJMKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x83E5020", Offset = "0x83E4020", VA = "0x1883E5020")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x83E6AD0", Offset = "0x83E5AD0", VA = "0x1883E6AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints OPFLPGHGOHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x83E5650", Offset = "0x83E4650", VA = "0x1883E5650")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x83E6DE0", Offset = "0x83E5DE0", VA = "0x1883E6DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 GDGFGOIEGCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x83E5E00", Offset = "0x83E4E00", VA = "0x1883E5E00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 EHBPFGEJFFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x83E5E00", Offset = "0x83E4E00", VA = "0x1883E5E00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x83E7560", Offset = "0x83E6560", VA = "0x1883E7560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float MJAHKCHDPBO
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x83E5B40", Offset = "0x83E4B40", VA = "0x1883E5B40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x83E7080", Offset = "0x83E6080", VA = "0x1883E7080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float JIJAPFEFCAD
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x83E6230", Offset = "0x83E5230", VA = "0x1883E6230")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x83E7710", Offset = "0x83E6710", VA = "0x1883E7710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion EMIKDPPMMHB
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x83E5EE0", Offset = "0x83E4EE0", VA = "0x1883E5EE0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x83E72E0", Offset = "0x83E62E0", VA = "0x1883E72E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion EDAJKKBNMIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x83E6160", Offset = "0x83E5160", VA = "0x1883E6160")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x83E7640", Offset = "0x83E6640", VA = "0x1883E7640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 MPAPMMINNFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x83E5FB0", Offset = "0x83E4FB0", VA = "0x1883E5FB0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x83E73B0", Offset = "0x83E63B0", VA = "0x1883E73B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion BEBIDKGLHFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x83E6090", Offset = "0x83E5090", VA = "0x1883E6090")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x83E7490", Offset = "0x83E6490", VA = "0x1883E7490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 NPNMEIDGLAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x83E62F0", Offset = "0x83E52F0", VA = "0x1883E62F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x83E77F0", Offset = "0x83E67F0", VA = "0x1883E77F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 OCDMHIHKCOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x83E5BA0", Offset = "0x83E4BA0", VA = "0x1883E5BA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x83E70F0", Offset = "0x83E60F0", VA = "0x1883E70F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 NAPJPBKPLFK
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x83E5510", Offset = "0x83E4510", VA = "0x1883E5510")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x83E6C90", Offset = "0x83E5C90", VA = "0x1883E6C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 MKJAKHMCJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x83E5980", Offset = "0x83E4980", VA = "0x1883E5980")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x83E6EC0", Offset = "0x83E5EC0", VA = "0x1883E6EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 KKFMLGCMMFA
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x83E5840", Offset = "0x83E4840", VA = "0x1883E5840")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion CNGGDPNDMNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x83E5770", Offset = "0x83E4770", VA = "0x1883E5770")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 FBLIIEJGLCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x83E6590", Offset = "0x83E5590", VA = "0x1883E6590")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 LDNMJNBOHKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x83E64B0", Offset = "0x83E54B0", VA = "0x1883E64B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool AALDEOKANFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x83E5920", Offset = "0x83E4920", VA = "0x1883E5920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool MEJBNGFPHHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x83E53F0", Offset = "0x83E43F0", VA = "0x1883E53F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool CEDPDMFFJEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x83E4F00", Offset = "0x83E3F00", VA = "0x1883E4F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool DDMKCNDEBIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x83E4EA0", Offset = "0x83E3EA0", VA = "0x1883E4EA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool AAHPAEKNPDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x83E4D80", Offset = "0x83E3D80", VA = "0x1883E4D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool AHMMIHALMAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x83E5710", Offset = "0x83E4710", VA = "0x1883E5710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool DINPHDIMOPN
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2352740", Offset = "0x2351740", VA = "0x182352740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event GNDLKMBGIHB CBMAJHIIKKP
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x83E4CA0", Offset = "0x83E3CA0", VA = "0x1883E4CA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x83E6910", Offset = "0x83E5910", VA = "0x1883E6910")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event PNBPECEEHKD AOKFEFCGPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x83E4A10", Offset = "0x83E3A10", VA = "0x1883E4A10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x83E6670", Offset = "0x83E5670", VA = "0x1883E6670")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event PNBPECEEHKD GIBENIPGOKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x83E4A70", Offset = "0x83E3A70", VA = "0x1883E4A70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x83E66E0", Offset = "0x83E56E0", VA = "0x1883E66E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event PNBPECEEHKD GPEMFODEPMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x83E4BC0", Offset = "0x83E3BC0", VA = "0x1883E4BC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x83E6830", Offset = "0x83E5830", VA = "0x1883E6830")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<MEACMOOJHJN, MEACMOOJHJN> CEBDFAKFDNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x83E4B50", Offset = "0x83E3B50", VA = "0x1883E4B50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x83E67C0", Offset = "0x83E57C0", VA = "0x1883E67C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event PNBPECEEHKD HHEPGOOKNGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x83E4C30", Offset = "0x83E3C30", VA = "0x1883E4C30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x83E68A0", Offset = "0x83E58A0", VA = "0x1883E68A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event PNBPECEEHKD BPLHKONLIME
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x83E4D10", Offset = "0x83E3D10", VA = "0x1883E4D10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x83E6980", Offset = "0x83E5980", VA = "0x1883E6980")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event PNBPECEEHKD GMDAEOELBFI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x83E4AE0", Offset = "0x83E3AE0", VA = "0x1883E4AE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x83E6750", Offset = "0x83E5750", VA = "0x1883E6750")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0", Slot = "8")]
		private void HJGFFMLCPLL(AEHCCAJOAGK HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83E3500", Offset = "0x83E2500", VA = "0x1883E3500", Slot = "9")]
		public JOBMDEJONPK GetData()
		{
			return default(JOBMDEJONPK);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83E38A0", Offset = "0x83E28A0", VA = "0x1883E38A0")]
		internal void KLKFPKPKFPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83E4730", Offset = "0x83E3730", VA = "0x1883E4730")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody MHLPIBDABBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83E3250", Offset = "0x83E2250", VA = "0x1883E3250")]
		public HAIPDKCGNLO GetChild(int OHHMJGCBCKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x83E4390", Offset = "0x83E3390", VA = "0x1883E4390")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) CKBACCDPBIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x83E2D20", Offset = "0x83E1D20", VA = "0x1883E2D20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x83E4620", Offset = "0x83E3620", VA = "0x1883E4620")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x83E37F0", Offset = "0x83E27F0", VA = "0x1883E37F0")]
		private AEHCCAJOAGK KKNJGDNBFGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x83E30D0", Offset = "0x83E20D0", VA = "0x1883E30D0")]
		private void EEBICEODLFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x83E3B60", Offset = "0x83E2B60", VA = "0x1883E3B60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x83E3AA0", Offset = "0x83E2AA0", VA = "0x1883E3AA0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x83E38A0", Offset = "0x83E28A0", VA = "0x1883E38A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x83E3B00", Offset = "0x83E2B00", VA = "0x1883E3B00")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x83E3BC0", Offset = "0x83E2BC0", VA = "0x1883E3BC0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x83E2310", Offset = "0x83E1310", VA = "0x1883E2310")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x83E3C20", Offset = "0x83E2C20", VA = "0x1883E3C20")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x83E3070", Offset = "0x83E2070", VA = "0x1883E3070")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x83E3A40", Offset = "0x83E2A40", VA = "0x1883E3A40")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x83E44F0", Offset = "0x83E34F0", VA = "0x1883E44F0")]
		public void SetParent(RigidbodyEx OHLIHBDBKCE, bool CCADIPLOOPF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x83E3F30", Offset = "0x83E2F30", VA = "0x1883E3F30")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83E3590", Offset = "0x83E2590", VA = "0x1883E3590")]
		public bool IsRigidbodyAncestor(RigidbodyEx NJNGODBLHLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x83E3690", Offset = "0x83E2690", VA = "0x1883E3690")]
		public bool IsRigidbodyDescendant(RigidbodyEx IJFDGHHLJBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x83E2580", Offset = "0x83E1580", VA = "0x1883E2580")]
		public void AddInterpolationRestriction(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x83E3C90", Offset = "0x83E2C90", VA = "0x1883E3C90")]
		public void RemoveInterpolationRestriction(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x83E25F0", Offset = "0x83E15F0", VA = "0x1883E25F0")]
		public void AddKinematic(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x83E3D00", Offset = "0x83E2D00", VA = "0x1883E3D00")]
		public void RemoveKinematic(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83E4470", Offset = "0x83E3470", VA = "0x1883E4470")]
		public void SetKinematic(object EJJDDFFADPC, bool GFJJBICPGBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x83E4290", Offset = "0x83E3290", VA = "0x1883E4290")]
		public void SetDiscontinuousPositionAndRotation(Vector3 DPNBIIDKBAI, Quaternion JFHALMAIDBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x83E4190", Offset = "0x83E3190", VA = "0x1883E4190")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 MELCAIBPDLF, Quaternion IFIPONJHJJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x83E33F0", Offset = "0x83E23F0", VA = "0x1883E33F0")]
		public Vector3 GetConstrainedVelocity(Vector3 NPNMEIDGLAE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x83E32E0", Offset = "0x83E22E0", VA = "0x1883E32E0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 NAPJPBKPLFK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83E2490", Offset = "0x83E1490", VA = "0x1883E2490")]
		public void AddForce(Vector3 ECOALLGHBMI, ForceMode FMAPMNGMDMD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x83E2380", Offset = "0x83E1380", VA = "0x1883E2380")]
		public void AddForceAtPosition(Vector3 ECOALLGHBMI, Vector3 EPCLGOKLIPO, ForceMode FMAPMNGMDMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x83E27C0", Offset = "0x83E17C0", VA = "0x1883E27C0")]
		public void AddTorque(Vector3 LLLAFEEDFHF, ForceMode FMAPMNGMDMD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x83E2660", Offset = "0x83E1660", VA = "0x1883E2660")]
		public void AddRelativeTorque(Vector3 LLLAFEEDFHF, ForceMode FMAPMNGMDMD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x83E4800", Offset = "0x83E3800", VA = "0x1883E4800")]
		public Vector3 WorldToLocalVelocity(Vector3 BNPCCEGFLAG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x83E3930", Offset = "0x83E2930", VA = "0x1883E3930")]
		public Vector3 LocalToWorldVelocity(Vector3 OCDMHIHKCOM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x83E3010", Offset = "0x83E2010", VA = "0x1883E3010")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x83E2FB0", Offset = "0x83E1FB0", VA = "0x1883E2FB0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x83E2F50", Offset = "0x83E1F50", VA = "0x1883E2F50")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x83E2EF0", Offset = "0x83E1EF0", VA = "0x1883E2EF0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x83E4090", Offset = "0x83E3090", VA = "0x1883E4090")]
		public void ResetVelocityWorldSpace(Vector3 BFCMGGLPKOG, Vector3 CFMHHLGNOMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x83E3F90", Offset = "0x83E2F90", VA = "0x1883E3F90")]
		public void ResetVelocityLocalSpace(Vector3 FHHDANGJANF, Vector3 MKJAKHMCJFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x83E3E50", Offset = "0x83E2E50", VA = "0x1883E3E50")]
		public void ResetLinearVelocityLocalSpace(Vector3 FHHDANGJANF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x83E4630", Offset = "0x83E3630", VA = "0x1883E4630")]
		public bool SweepTest(Vector3 IGEMMIGMOOK, [Out] RaycastHit CHOONAICPAA, float JPGIFEODCKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x83E3790", Offset = "0x83E2790", VA = "0x1883E3790")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x83E45C0", Offset = "0x83E35C0", VA = "0x1883E45C0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x83E47A0", Offset = "0x83E37A0", VA = "0x1883E47A0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x83E2750", Offset = "0x83E1750", VA = "0x1883E2750")]
		public void AddShouldHaveUnityRigidbodyToken(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x83E3D70", Offset = "0x83E2D70", VA = "0x1883E3D70")]
		public void RemoveShouldHaveUnityRigidbodyToken(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x83E2B50", Offset = "0x83E1B50", VA = "0x1883E2B50")]
		public void ApplyForceVelocityChange(OCNBACAEJKA IIPHGHABFEI, Vector3 FBJOGNFJNKE, float GINNKEFNNNJ, float AGKFEOKGNFN = 8f, float LKKCFIBADJL = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x83E2A50", Offset = "0x83E1A50", VA = "0x1883E2A50")]
		public void ApplyAngularVelocityChange(GNGBJGPGOGK DMMOCNOPLNI, Vector3 CFIMLPPLPIK, float KMIIDKLEDDJ = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x83E2C10", Offset = "0x83E1C10", VA = "0x1883E2C10")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(GNGBJGPGOGK DMMOCNOPLNI, Vector3 OOBEGCNALKF, float LNKOBALGGOE = 7f, float OKOMENKNBDN = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x83E2980", Offset = "0x83E1980", VA = "0x1883E2980")]
		public bool AllowedScaleChange(float KDJJCHBMFBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x83E28B0", Offset = "0x83E18B0", VA = "0x1883E28B0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx GHCGIEELPNO, object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x83E3DE0", Offset = "0x83E2DE0", VA = "0x1883E3DE0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x83E2300", Offset = "0x83E1300", VA = "0x1883E2300", Slot = "12")]
		private void AICFFOPEAAD(IDHOFIHAGPL INLEBAAACKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x83E49A0", Offset = "0x83E39A0", VA = "0x1883E49A0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xB8E1B0", Offset = "0xB8D1B0", VA = "0x180B8E1B0", Slot = "4")]
		private GameObject MOEMGAEMJNH()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA1D840", Offset = "0xA1C840", VA = "0x180A1D840", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x83D3D20", Offset = "0x83D2D20", VA = "0x1883D3D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public EBILOFLAHOD OGKNHGHLAPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x83E1200", Offset = "0x83E0200", VA = "0x1883E1200", Slot = "7")]
	public void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x83E1270", Offset = "0x83E0270", VA = "0x1883E1270", Slot = "6")]
	public AEHCCAJOAGK JAOMOKLNDKI(RigidbodyEx DPBHNMFBAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
		[Cpp2IlInjected.Address(RVA = "0x83E2160", Offset = "0x83E1160", VA = "0x1883E2160")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x83E21A0", Offset = "0x83E11A0", VA = "0x1883E21A0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x83E2180", Offset = "0x83E1180", VA = "0x1883E2180")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string NAAMEAFIHJI, [Optional] UnityEngine.Object INLEBAAACKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string NAAMEAFIHJI, [Optional] UnityEngine.Object INLEBAAACKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x83E22B0", Offset = "0x83E12B0", VA = "0x1883E22B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA009F0", Offset = "0x9FF9F0", VA = "0x180A009F0", Slot = "4")]
		public Vector3 KHMLNLOJDIG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA009F0", Offset = "0x9FF9F0", VA = "0x180A009F0", Slot = "5")]
		public Vector3 PCGDBHDCGFH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "6")]
		public bool GNDAJCOACJJ(float CLFAAEDMDHI, float FBDABLGDOKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BNPIIMENNPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static FGHLALPKLCB EIPDKGPNADH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x83E0440", Offset = "0x83DF440", VA = "0x1883E0440")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "22")]
		get
		{
			return default(PKENAFNLEAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public HAIPDKCGNLO JONJPMBBDAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xCC02E0", Offset = "0xCBF2E0", VA = "0x180CC02E0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xE32260", Offset = "0xE31260", VA = "0x180E32260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject ACLMMAOCLNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9FC4A0", Offset = "0x9FB4A0", VA = "0x1809FC4A0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9FC4C0", Offset = "0x9FB4C0", VA = "0x1809FC4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform IOFGLPCMIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xC0CEE0", Offset = "0xC0BEE0", VA = "0x180C0CEE0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xE430C0", Offset = "0xE420C0", VA = "0x180E430C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody LJPLOMDHOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x83DD250", Offset = "0x83DC250", VA = "0x1883DD250", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public AEHCCAJOAGK LHCPKJJPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x83DD890", Offset = "0x83DC890", VA = "0x1883DD890", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x83DF300", Offset = "0x83DE300", VA = "0x1883DF300", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int GGKEEFPNDLI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x83D97E0", Offset = "0x83D87E0", VA = "0x1883D97E0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public AEHCCAJOAGK FMDIEJKNFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x83DEDA0", Offset = "0x83DDDA0", VA = "0x1883DEDA0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool MPKPPHOFPOF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x83DF8E0", Offset = "0x83DE8E0", VA = "0x1883DF8E0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool BNFOGIBLEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x83DF760", Offset = "0x83DE760", VA = "0x1883DF760", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool LMGPENNCPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x83DE6F0", Offset = "0x83DD6F0", VA = "0x1883DE6F0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public FGHLALPKLCB GPHCHFOOBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x83D9950", Offset = "0x83D8950", VA = "0x1883D9950", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x83D9E20", Offset = "0x83D8E20", VA = "0x1883D9E20", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public EKDAONPNEDM PFHAOKHAIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x83D98A0", Offset = "0x83D88A0", VA = "0x1883D98A0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x83DEB60", Offset = "0x83DDB60", VA = "0x1883DEB60", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float KAAKNIDJMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x83DD640", Offset = "0x83DC640", VA = "0x1883DD640", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x83D9730", Offset = "0x83D8730", VA = "0x1883D9730", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 MBONAKJIGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x83DCE70", Offset = "0x83DBE70", VA = "0x1883DCE70", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x83DF150", Offset = "0x83DE150", VA = "0x1883DF150", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 PPKJNICDJFO
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x83DF940", Offset = "0x83DE940", VA = "0x1883DF940", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x83DEEC0", Offset = "0x83DDEC0", VA = "0x1883DEEC0", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 MHHKMIMGCEN
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x83DF7B0", Offset = "0x83DE7B0", VA = "0x1883DF7B0", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x83DE570", Offset = "0x83DD570", VA = "0x1883DE570", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 NGPCALAEKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x83DCFB0", Offset = "0x83DBFB0", VA = "0x1883DCFB0", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x83DB070", Offset = "0x83DA070", VA = "0x1883DB070", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool CEDPDMFFJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x83DE6A0", Offset = "0x83DD6A0", VA = "0x1883DE6A0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool DDMKCNDEBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x83DCE10", Offset = "0x83DBE10", VA = "0x1883DCE10", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool AAHPAEKNPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x83DD750", Offset = "0x83DC750", VA = "0x1883DD750", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool ACLAGMPFHFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x83DF0B0", Offset = "0x83DE0B0", VA = "0x1883DF0B0", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 IKEEOKKFNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x83DF450", Offset = "0x83DE450", VA = "0x1883DF450", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 PPOEAMFJKMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x83DA140", Offset = "0x83D9140", VA = "0x1883DA140", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 DIFEGNJKDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x83DBE50", Offset = "0x83DAE50", VA = "0x1883DBE50", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x83DF580", Offset = "0x83DE580", VA = "0x1883DF580", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 GDHCBFHODJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x83D9B80", Offset = "0x83D8B80", VA = "0x1883D9B80", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float ILIOIANLCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x83DE780", Offset = "0x83DD780", VA = "0x1883DE780", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float IMNDBPGANOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x83DD090", Offset = "0x83DC090", VA = "0x1883DD090", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x83DA2D0", Offset = "0x83D92D0", VA = "0x1883DA2D0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 KCEMHIHMFPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x83DC1B0", Offset = "0x83DB1B0", VA = "0x1883DC1B0", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion NEFBFOAEHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x83DF230", Offset = "0x83DE230", VA = "0x1883DF230", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float HLOJOBIKJAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x83DE7D0", Offset = "0x83DD7D0", VA = "0x1883DE7D0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x83D96A0", Offset = "0x83D86A0", VA = "0x1883D96A0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float AEIOPPGFCCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x83DE650", Offset = "0x83DD650", VA = "0x1883DE650", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x83DDC90", Offset = "0x83DCC90", VA = "0x1883DDC90", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool KNIBBPIGMCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x83DC060", Offset = "0x83DB060", VA = "0x1883DC060", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x83DAC40", Offset = "0x83D9C40", VA = "0x1883DAC40", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public DINEBAHNNBA COBALJIKJEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x83D9790", Offset = "0x83D8790", VA = "0x1883D9790", Slot = "70")]
		get
		{
			return default(DINEBAHNNBA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x83DA540", Offset = "0x83D9540", VA = "0x1883DA540", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool KGPPIMBCPCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x83DF100", Offset = "0x83DE100", VA = "0x1883DF100", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform BBBFMBKGKMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xC0CEE0", Offset = "0xC0BEE0", VA = "0x180C0CEE0", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 OAPICFGGNEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x83D9D70", Offset = "0x83D8D70", VA = "0x1883D9D70", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x83DD1A0", Offset = "0x83DC1A0", VA = "0x1883DD1A0", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float JLKGIJBFPNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x83DEDF0", Offset = "0x83DDDF0", VA = "0x1883DEDF0", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x83DD330", Offset = "0x83DC330", VA = "0x1883DD330", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float LAJMIGPLNOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x83DA5A0", Offset = "0x83D95A0", VA = "0x1883DA5A0", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x83DF660", Offset = "0x83DE660", VA = "0x1883DF660", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion MHHJHPJKLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x83DD940", Offset = "0x83DC940", VA = "0x1883DD940", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x83D9490", Offset = "0x83D8490", VA = "0x1883D9490", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 HOKNMKCMKBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x83DA3E0", Offset = "0x83D93E0", VA = "0x1883DA3E0", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x83DC170", Offset = "0x83DB170", VA = "0x1883DC170", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion OIMDLFMMKJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x83DE740", Offset = "0x83DD740", VA = "0x1883DE740", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x83D9700", Offset = "0x83D8700", VA = "0x1883D9700", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints NDDPBBNBEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x83DDEE0", Offset = "0x83DCEE0", VA = "0x1883DDEE0", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x83DA220", Offset = "0x83D9220", VA = "0x1883DA220", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool GOEFNOABCHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x83DBE00", Offset = "0x83DAE00", VA = "0x1883DBE00", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x83D9D10", Offset = "0x83D8D10", VA = "0x1883D9D10", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode JJAOGKDDDON
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x83D9C60", Offset = "0x83D8C60", VA = "0x1883D9C60", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x83DB4D0", Offset = "0x83DA4D0", VA = "0x1883DB4D0", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool KHKHNOEIDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x83DE430", Offset = "0x83DD430", VA = "0x1883DE430", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool MEJBNGFPHHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x83DDAC0", Offset = "0x83DCAC0", VA = "0x1883DDAC0", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event PNBPECEEHKD AOKFEFCGPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x83DD830", Offset = "0x83DC830", VA = "0x1883DD830", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x83D9F10", Offset = "0x83D8F10", VA = "0x1883D9F10", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event PNBPECEEHKD GIBENIPGOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x83DF520", Offset = "0x83DE520", VA = "0x1883DF520", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x83D9320", Offset = "0x83D8320", VA = "0x1883D9320", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event GNDLKMBGIHB KIAKJBHJBDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x83DDE80", Offset = "0x83DCE80", VA = "0x1883DDE80", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x83DC000", Offset = "0x83DB000", VA = "0x1883DC000", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event PNBPECEEHKD HMGIPDEBDGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x83DE1E0", Offset = "0x83DD1E0", VA = "0x1883DE1E0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x83DEE00", Offset = "0x83DDE00", VA = "0x1883DEE00", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event PNBPECEEHKD GPEMFODEPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x83DABE0", Offset = "0x83D9BE0", VA = "0x1883DABE0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x83DD690", Offset = "0x83DC690", VA = "0x1883DD690", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event PNBPECEEHKD OEJFEEIDNPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x83DCF50", Offset = "0x83DBF50", VA = "0x1883DCF50", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x83DD8E0", Offset = "0x83DC8E0", VA = "0x1883DD8E0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<MEACMOOJHJN, MEACMOOJHJN> CEBDFAKFDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x83DEFA0", Offset = "0x83DDFA0", VA = "0x1883DEFA0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x83DD6F0", Offset = "0x83DC6F0", VA = "0x1883DD6F0", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event PNBPECEEHKD GMAEPBAHAJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x83D9CB0", Offset = "0x83D8CB0", VA = "0x1883D9CB0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x83DC570", Offset = "0x83DB570", VA = "0x1883DC570", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event PNBPECEEHKD GMDAEOELBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x83DA330", Offset = "0x83D9330", VA = "0x1883DA330", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x83DDCF0", Offset = "0x83DCCF0", VA = "0x1883DDCF0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x83DFA60", Offset = "0x83DEA60", VA = "0x1883DFA60")]
	public OBOFCNBAJCN(GameObject CEKGANCAJPA, RigidbodyEx IBNAICKPLEA, LONCFKCDDMN PAKPDHLKNJE, [In] JOBMDEJONPK APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x83DA8F0", Offset = "0x83D98F0", VA = "0x1883DA8F0", Slot = "139")]
	protected virtual void EFIIBBIHNML(LONCFKCDDMN PAKPDHLKNJE, JOBMDEJONPK APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x83DA5B0", Offset = "0x83D95B0", VA = "0x1883DA5B0", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x83DE040", Offset = "0x83DD040", VA = "0x1883DE040", Slot = "93")]
	public void LLGFJHIIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x83DD2A0", Offset = "0x83DC2A0", VA = "0x1883DD2A0", Slot = "94")]
	public void JAINDIDLLHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x83DEE60", Offset = "0x83DDE60", VA = "0x1883DEE60", Slot = "95")]
	public void OIABCBMEMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x83DECA0", Offset = "0x83DDCA0", VA = "0x1883DECA0", Slot = "96")]
	public void NKDGHBONJAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x83DACA0", Offset = "0x83D9CA0", VA = "0x1883DACA0")]
	private void ENCOGDACOEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x83D9F70", Offset = "0x83D8F70", VA = "0x1883D9F70")]
	private void CJPABMMJAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x83DB1B0", Offset = "0x83DA1B0", VA = "0x1883DB1B0")]
	private void FGHMOILEBNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x83DF360", Offset = "0x83DE360", VA = "0x1883DF360", Slot = "30")]
	public AEHCCAJOAGK PFAEDCJHGFC(int OHHMJGCBCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x83DF3E0", Offset = "0x83DE3E0", VA = "0x1883DF3E0", Slot = "98")]
	public void PFEAOMFGIPC(AEHCCAJOAGK OHLIHBDBKCE, bool CCADIPLOOPF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x83DC620", Offset = "0x83DB620", VA = "0x1883DC620", Slot = "99")]
	public void IBEAKFJFBKO(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x83D98F0", Offset = "0x83D88F0", VA = "0x1883D98F0", Slot = "100")]
	public void BKNOHCLGOHB(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x83DCD10", Offset = "0x83DBD10", VA = "0x1883DCD10", Slot = "101")]
	public Vector3 IIACFCKBMEK(Vector3 BNPCCEGFLAG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x83DAF70", Offset = "0x83D9F70", VA = "0x1883DAF70", Slot = "102")]
	public Vector3 FABBPJPCFND(Vector3 OCDMHIHKCOM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x83DC880", Offset = "0x83DB880", VA = "0x1883DC880", Slot = "103")]
	public void IDLPDECABCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x83DA0F0", Offset = "0x83D90F0", VA = "0x1883DA0F0", Slot = "104")]
	public void CLGDPDBNAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x83DA420", Offset = "0x83D9420", VA = "0x1883DA420", Slot = "105")]
	public void DIIEGPIOIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x83DE340", Offset = "0x83DD340", VA = "0x1883DE340", Slot = "106")]
	public void MBNADKIEICD(Vector3 BFCMGGLPKOG, Vector3 CFMHHLGNOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x83DB630", Offset = "0x83DA630", VA = "0x1883DB630", Slot = "107")]
	public void FOPCBHBBKFA(Vector3 FHHDANGJANF, Vector3 MKJAKHMCJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x83DDDA0", Offset = "0x83DCDA0", VA = "0x1883DDDA0", Slot = "108")]
	public void LANBKIAKANC(Vector3 PBPCDIDONHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x83DD0E0", Offset = "0x83DC0E0", VA = "0x1883DD0E0", Slot = "109")]
	public void IOFCEMOCNKJ(OCNBACAEJKA IIPHGHABFEI, Vector3 FBJOGNFJNKE, float GINNKEFNNNJ, float AGKFEOKGNFN = 8f, float LKKCFIBADJL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x83D9FF0", Offset = "0x83D8FF0", VA = "0x1883D9FF0", Slot = "110")]
	public void CKHAMKNHENO(GNGBJGPGOGK DMMOCNOPLNI, Vector3 CFIMLPPLPIK, float KMIIDKLEDDJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x83DD3C0", Offset = "0x83DC3C0", VA = "0x1883DD3C0", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JBLCNFLLANL(GNGBJGPGOGK DMMOCNOPLNI, Vector3 OOBEGCNALKF, float LNKOBALGGOE = 7f, float OKOMENKNBDN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x83D9A10", Offset = "0x83D8A10", VA = "0x1883D9A10", Slot = "112")]
	public Vector3 BMCODDGJPBA(Vector3 OHLIHBDBKCE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x83DB530", Offset = "0x83DA530", VA = "0x1883DB530", Slot = "113")]
	public Vector3 FODFMHBJNNH(Vector3 OHLIHBDBKCE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x83DF060", Offset = "0x83DE060", VA = "0x1883DF060", Slot = "114")]
	public void ONIIAKFKNGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x83DC0B0", Offset = "0x83DB0B0", VA = "0x1883DC0B0", Slot = "115")]
	public void GMDBJOIEBEK(AEHCCAJOAGK GHCGIEELPNO, object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x83DC360", Offset = "0x83DB360", VA = "0x1883DC360", Slot = "116")]
	public void HCJADAIAMEA(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x83DECC0", Offset = "0x83DDCC0", VA = "0x1883DECC0", Slot = "63")]
	public void NMOLEIEJHFM((Quaternion rot, Vector3 moments) CKBACCDPBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x83D9850", Offset = "0x83D8850", VA = "0x1883D9850", Slot = "117")]
	public void BHIHKAKKCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x83DC5D0", Offset = "0x83DB5D0", VA = "0x1883DC5D0", Slot = "118")]
	public void HPBGKAMNHIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x83DDC40", Offset = "0x83DCC40", VA = "0x1883DDC40", Slot = "119")]
	public void KLLMDLAJOMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x83DC120", Offset = "0x83DB120", VA = "0x1883DC120", Slot = "120")]
	public bool GMPMKPGGEJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x83DF890", Offset = "0x83DE890", VA = "0x1883DF890", Slot = "97")]
	public void PLELPHGDIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x83D9B10", Offset = "0x83D8B10", VA = "0x1883D9B10", Slot = "121")]
	public void BOLEDFNDLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x83DC3C0", Offset = "0x83DB3C0", VA = "0x1883DC3C0", Slot = "122")]
	public void HHNGPMIMDOO(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x83DA890", Offset = "0x83D9890", VA = "0x1883DA890", Slot = "123")]
	public void ECLLEAMJHDE(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x83D99A0", Offset = "0x83D89A0", VA = "0x1883D99A0", Slot = "124")]
	public void BLLMHFJJADE(object EJJDDFFADPC, bool GFJJBICPGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x83DC680", Offset = "0x83DB680", VA = "0x1883DC680", Slot = "125")]
	public void ICKOCOBMLLD(Vector3 DPNBIIDKBAI, Quaternion JFHALMAIDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x83DB3A0", Offset = "0x83DA3A0", VA = "0x1883DB3A0", Slot = "126")]
	public void FNKNCAGNOEC(Vector3 MELCAIBPDLF, Quaternion IFIPONJHJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x83DA280", Offset = "0x83D9280", VA = "0x1883DA280", Slot = "127")]
	public bool DEJIONOLPFN(float KDJJCHBMFBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x83DE820", Offset = "0x83DD820", VA = "0x1883DE820", Slot = "128")]
	public void MPHIBMNGJNG(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x83DB150", Offset = "0x83DA150", VA = "0x1883DB150", Slot = "129")]
	public void FGCBCNACPMH(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x83DF000", Offset = "0x83DE000", VA = "0x1883DF000", Slot = "130")]
	public void OLPGEFNAPKA(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x83DE180", Offset = "0x83DD180", VA = "0x1883DE180", Slot = "131")]
	public void LLJCOJABAHE(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x83DB210", Offset = "0x83DA210", VA = "0x1883DB210", Slot = "132")]
	public void FGIFEHKDDPN(Vector3 ECOALLGHBMI, ForceMode FMAPMNGMDMD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x83DDF30", Offset = "0x83DCF30", VA = "0x1883DDF30", Slot = "133")]
	public void LGOCIELBIIK(Vector3 ECOALLGHBMI, Vector3 EPCLGOKLIPO, ForceMode FMAPMNGMDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x83DD9E0", Offset = "0x83DC9E0", VA = "0x1883DD9E0", Slot = "134")]
	public void KKOKDJLJLLK(Vector3 LLLAFEEDFHF, ForceMode FMAPMNGMDMD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x83DEBC0", Offset = "0x83DDBC0", VA = "0x1883DEBC0", Slot = "135")]
	public void NJFLMALDHNB(Vector3 LLLAFEEDFHF, ForceMode FMAPMNGMDMD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x83DE240", Offset = "0x83DD240", VA = "0x1883DE240", Slot = "136")]
	public bool LMNOMKFELDH(Vector3 IGEMMIGMOOK, [Out] RaycastHit CHOONAICPAA, float JPGIFEODCKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x83DAF20", Offset = "0x83D9F20", VA = "0x1883DAF20", Slot = "137")]
	public void EPCDCICFCMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x83DFA20", Offset = "0x83DEA20", VA = "0x1883DFA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x83DBF30", Offset = "0x83DAF30", VA = "0x1883DBF30")]
	private void GFPPDIJKEPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x83D9380", Offset = "0x83D8380", VA = "0x1883D9380")]
	private void BANHNHDNKML(AEHCCAJOAGK JHDAOHEONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x83DA6B0", Offset = "0x83D96B0", VA = "0x1883DA6B0")]
	private void ECBIIHFFCLE(AEHCCAJOAGK JHDAOHEONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x83DB2F0", Offset = "0x83DA2F0", VA = "0x1883DB2F0")]
	private void FHIFJMJDDEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x83D9570", Offset = "0x83D8570", VA = "0x1883D9570")]
	private void BBINBMFEGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x83DE880", Offset = "0x83DD880", VA = "0x1883DE880")]
	private void NCMCCOPDOBD(AEHCCAJOAGK CKMMPPDMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x83DA470", Offset = "0x83D9470", VA = "0x1883DA470")]
	private void DIPLHBJMKEM(AEHCCAJOAGK JHDAOHEONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x83DC290", Offset = "0x83DB290", VA = "0x1883DC290")]
	private void HCCCGLGGJNO(AEHCCAJOAGK JHDAOHEONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x83DC420", Offset = "0x83DB420", VA = "0x1883DC420")]
	private void HLGDAICPDLG(HAIPDKCGNLO JHDAOHEONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x83DC8D0", Offset = "0x83DB8D0", VA = "0x1883DC8D0", Slot = "142")]
	protected virtual void IGDIHBHNKJO(HAIPDKCGNLO DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x83DBAA0", Offset = "0x83DAAA0", VA = "0x1883DBAA0")]
	protected void FPNDJJLKHIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x83DB720", Offset = "0x83DA720", VA = "0x1883DB720")]
	protected void FPIAGMKIMNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x83DEA30", Offset = "0x83DDA30", VA = "0x1883DEA30")]
	private void NGMEJIGJEBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x83DD4D0", Offset = "0x83DC4D0", VA = "0x1883DD4D0")]
	private void JCHECBCPJOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class EMJIOCLPPFC
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x83CF560", Offset = "0x83CE560", VA = "0x1883CF560")]
	public static AEHCCAJOAGK CJEJILIIJMC(this AEHCCAJOAGK DPBHNMFBAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x83CF620", Offset = "0x83CE620", VA = "0x1883CF620")]
	public static bool GLOMNCDHBHI(this AEHCCAJOAGK DPBHNMFBAMI, AEHCCAJOAGK NJNGODBLHLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x83CF4C0", Offset = "0x83CE4C0", VA = "0x1883CF4C0")]
	public static bool AOHCJCEAKII(this AEHCCAJOAGK DPBHNMFBAMI, AEHCCAJOAGK IJFDGHHLJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x83CF730", Offset = "0x83CE730", VA = "0x1883CF730")]
	public static HAIPDKCGNLO MDBGFNLELLG(this AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x83CF6C0", Offset = "0x83CE6C0", VA = "0x1883CF6C0")]
	public static OBOFCNBAJCN HCBBCLIMFLM(this AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JOGBJAFFIJN : EBILOFLAHOD
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x83D3C80", Offset = "0x83D2C80", VA = "0x1883D3C80", Slot = "19")]
	public AEHCCAJOAGK JAOMOKLNDKI(RigidbodyEx DPBHNMFBAMI, JOBMDEJONPK APDBNIMCPID, LONCFKCDDMN PAKPDHLKNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "4")]
	public BJGKLNFEMFG EFEBEPANAHM(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "5")]
	public KNHPLJKDFKI LIGMAIIODBK(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "6")]
	public GCDMBAAHIPA BPBEFMHDKIA(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "7")]
	public AMEOAJBEAJH HHOAOKAAJAK(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "8")]
	public HDGJFEKHLEF CFFINFLKEPO(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "9")]
	public OHDDGMFNMNC FOAJOBADFED(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "10")]
	public DDJELBIHLCK JGJLPKPIJMG(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "11")]
	public KGLLPODCDJM DOIJEDHCGLI(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "12")]
	public HKOLHAKECHJ FLNNJJGHOKD(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "13")]
	public ONLILAHHPMI AMNOMNAJEAI(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230")]
	public FIJOPHMCOJO FJDCEPANACK(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230")]
	public DPANBNHFCKB CLKBBGLCOFF(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230")]
	public GABJBCBBIKD JFAIAHOCEBJ(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230")]
	public JAEJCPLCJMA LIHHJIOLDMA(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230")]
	public JGFBLFFIGMO IJJAJPKMLEG(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public JOGBJAFFIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "14")]
	private FIJOPHMCOJO CHAMIPHFKHO(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "15")]
	private DPANBNHFCKB GILEOKHCPBE(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "16")]
	private GABJBCBBIKD PCPADDACGGO(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "17")]
	private JAEJCPLCJMA CKHBOBJCMPO(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x83D2920", Offset = "0x83D1920", VA = "0x1883D2920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x83D2A30", Offset = "0x83D1A30", VA = "0x1883D2A30", Slot = "20")]
	public void InitReferences(APJCDBKKFBB IDEMOBALCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x83D26A0", Offset = "0x83D16A0", VA = "0x1883D26A0", Slot = "4")]
	public BJGKLNFEMFG EFEBEPANAHM(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x83D2D20", Offset = "0x83D1D20", VA = "0x1883D2D20", Slot = "5")]
	public KNHPLJKDFKI LIGMAIIODBK(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x83D22B0", Offset = "0x83D12B0", VA = "0x1883D22B0", Slot = "6")]
	public GCDMBAAHIPA BPBEFMHDKIA(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x83D2880", Offset = "0x83D1880", VA = "0x1883D2880", Slot = "7")]
	public AMEOAJBEAJH HHOAOKAAJAK(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x83D2350", Offset = "0x83D1350", VA = "0x1883D2350", Slot = "8")]
	public HDGJFEKHLEF CFFINFLKEPO(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x83D27E0", Offset = "0x83D17E0", VA = "0x1883D27E0", Slot = "9")]
	public OHDDGMFNMNC FOAJOBADFED(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x83D2C80", Offset = "0x83D1C80", VA = "0x1883D2C80", Slot = "10")]
	public DDJELBIHLCK JGJLPKPIJMG(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x83D2600", Offset = "0x83D1600", VA = "0x1883D2600", Slot = "11")]
	public KGLLPODCDJM DOIJEDHCGLI(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x83D2740", Offset = "0x83D1740", VA = "0x1883D2740", Slot = "12")]
	public HKOLHAKECHJ FLNNJJGHOKD(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x83D2210", Offset = "0x83D1210", VA = "0x1883D2210", Slot = "13")]
	public ONLILAHHPMI AMNOMNAJEAI(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x83D23F0", Offset = "0x83D13F0", VA = "0x1883D23F0")]
	public FIJOPHMCOJO FJDCEPANACK(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x83D2550", Offset = "0x83D1550", VA = "0x1883D2550")]
	public DPANBNHFCKB CLKBBGLCOFF(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x83D2BD0", Offset = "0x83D1BD0", VA = "0x1883D2BD0")]
	public GABJBCBBIKD JFAIAHOCEBJ(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x83D24A0", Offset = "0x83D14A0", VA = "0x1883D24A0")]
	public JAEJCPLCJMA LIHHJIOLDMA(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x83D2980", Offset = "0x83D1980", VA = "0x1883D2980")]
	public JGFBLFFIGMO IJJAJPKMLEG(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x83D2A80", Offset = "0x83D1A80", VA = "0x1883D2A80", Slot = "19")]
	public AEHCCAJOAGK JAOMOKLNDKI(RigidbodyEx DPBHNMFBAMI, JOBMDEJONPK APDBNIMCPID, LONCFKCDDMN PAKPDHLKNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x83D2DC0", Offset = "0x83D1DC0", VA = "0x1883D2DC0")]
	public FPJDFNBODAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x83D23F0", Offset = "0x83D13F0", VA = "0x1883D23F0", Slot = "14")]
	private FIJOPHMCOJO CHAMIPHFKHO(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x83D2550", Offset = "0x83D1550", VA = "0x1883D2550", Slot = "15")]
	private DPANBNHFCKB GILEOKHCPBE(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x83D2BD0", Offset = "0x83D1BD0", VA = "0x1883D2BD0", Slot = "16")]
	private GABJBCBBIKD PCPADDACGGO(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x83D24A0", Offset = "0x83D14A0", VA = "0x1883D24A0", Slot = "17")]
	private JAEJCPLCJMA CKHBOBJCMPO(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x83D2980", Offset = "0x83D1980", VA = "0x1883D2980", Slot = "18")]
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
	PhotonView PFFFFPLBLDM
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
		[Cpp2IlInjected.Address(RVA = "0x83D4A30", Offset = "0x83D3A30", VA = "0x1883D4A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode JJAOGKDDDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x83D8D70", Offset = "0x83D7D70", VA = "0x1883D8D70", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x83D8F20", Offset = "0x83D7F20", VA = "0x1883D8F20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x83D4000", Offset = "0x83D3000", VA = "0x1883D4000")]
	public NGOCDBPPKOH(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x83D8F90", Offset = "0x83D7F90", VA = "0x1883D8F90", Slot = "6")]
	public void LLGFJHIIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x83D8E90", Offset = "0x83D7E90", VA = "0x1883D8E90", Slot = "9")]
	public void DAAJDDOAIDE(Rigidbody OHEGODNMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x83D8E80", Offset = "0x83D7E80", VA = "0x1883D8E80", Slot = "7")]
	public void CPMGCGEAHFH(bool AALDEOKANFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x83D8F10", Offset = "0x83D7F10", VA = "0x1883D8F10", Slot = "8")]
	public void ECEPNMAFMKB(bool AALDEOKANFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x83D90A0", Offset = "0x83D80A0", VA = "0x1883D90A0", Slot = "10")]
	public bool LMNOMKFELDH(Vector3 IGEMMIGMOOK, [Out] RaycastHit CHOONAICPAA, float JPGIFEODCKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x83D9200", Offset = "0x83D8200", VA = "0x1883D9200")]
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
		[Cpp2IlInjected.Address(RVA = "0x83DFD80", Offset = "0x83DED80", VA = "0x1883DFD80", Slot = "6")]
		get
		{
			return default(DINEBAHNNBA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x83DFEC0", Offset = "0x83DEEC0", VA = "0x1883DFEC0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform EDEDOFJCJCC
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xCA8820", Offset = "0xCA7820", VA = "0x180CA8820", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<MEACMOOJHJN, MEACMOOJHJN> CEBDFAKFDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x83E0300", Offset = "0x83DF300", VA = "0x1883E0300", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x83DFFE0", Offset = "0x83DEFE0", VA = "0x1883DFFE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x83E03B0", Offset = "0x83DF3B0", VA = "0x1883E03B0")]
	public OIGFEMPOEAL(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x83E0090", Offset = "0x83DF090", VA = "0x1883E0090", Slot = "8")]
	public void LLGFJHIIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x83DFF90", Offset = "0x83DEF90", VA = "0x1883DFF90", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x116F3D0", Offset = "0x116E3D0", VA = "0x18116F3D0", Slot = "11")]
	private void NABCKMAHPNM(MEACMOOJHJN MMOFILFNFGF, MEACMOOJHJN NAOJMHGIKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "12")]
	private void COMNIEOGHHG(bool MLHEEDKLBBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class DMLJKEANOOO : EBILOFLAHOD
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x83CCD50", Offset = "0x83CBD50", VA = "0x1883CCD50", Slot = "4")]
	public BJGKLNFEMFG EFEBEPANAHM(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x83CD4D0", Offset = "0x83CC4D0", VA = "0x1883CD4D0", Slot = "5")]
	public KNHPLJKDFKI LIGMAIIODBK(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x83CC630", Offset = "0x83CB630", VA = "0x1883CC630", Slot = "6")]
	public GCDMBAAHIPA BPBEFMHDKIA(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x83CCFD0", Offset = "0x83CBFD0", VA = "0x1883CCFD0", Slot = "7")]
	public AMEOAJBEAJH HHOAOKAAJAK(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x83CC760", Offset = "0x83CB760", VA = "0x1883CC760", Slot = "8")]
	public HDGJFEKHLEF CFFINFLKEPO(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x83CCF00", Offset = "0x83CBF00", VA = "0x1883CCF00", Slot = "9")]
	public OHDDGMFNMNC FOAJOBADFED(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x83CD3B0", Offset = "0x83CC3B0", VA = "0x1883CD3B0", Slot = "10")]
	public DDJELBIHLCK JGJLPKPIJMG(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x83CCC90", Offset = "0x83CBC90", VA = "0x1883CCC90", Slot = "11")]
	public KGLLPODCDJM DOIJEDHCGLI(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x83CCE40", Offset = "0x83CBE40", VA = "0x1883CCE40", Slot = "12")]
	public HKOLHAKECHJ FLNNJJGHOKD(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x83CC570", Offset = "0x83CB570", VA = "0x1883CC570", Slot = "13")]
	public ONLILAHHPMI AMNOMNAJEAI(AEHCCAJOAGK HCAMONPFOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x83CC830", Offset = "0x83CB830", VA = "0x1883CC830")]
	public FIJOPHMCOJO FJDCEPANACK(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x83CCB00", Offset = "0x83CBB00", VA = "0x1883CCB00")]
	public DPANBNHFCKB CLKBBGLCOFF(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x83CD280", Offset = "0x83CC280", VA = "0x1883CD280")]
	public GABJBCBBIKD JFAIAHOCEBJ(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x83CC970", Offset = "0x83CB970", VA = "0x1883CC970")]
	public JAEJCPLCJMA LIHHJIOLDMA(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x83CD050", Offset = "0x83CC050", VA = "0x1883CD050")]
	public JGFBLFFIGMO IJJAJPKMLEG(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x83CD130", Offset = "0x83CC130", VA = "0x1883CD130", Slot = "19")]
	public AEHCCAJOAGK JAOMOKLNDKI(RigidbodyEx DPBHNMFBAMI, JOBMDEJONPK APDBNIMCPID, LONCFKCDDMN PAKPDHLKNJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public DMLJKEANOOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x83CC830", Offset = "0x83CB830", VA = "0x1883CC830", Slot = "14")]
	private FIJOPHMCOJO CHAMIPHFKHO(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x83CCB00", Offset = "0x83CBB00", VA = "0x1883CCB00", Slot = "15")]
	private DPANBNHFCKB GILEOKHCPBE(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x83CD280", Offset = "0x83CC280", VA = "0x1883CD280", Slot = "16")]
	private GABJBCBBIKD PCPADDACGGO(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x83CC970", Offset = "0x83CB970", VA = "0x1883CC970", Slot = "17")]
	private JAEJCPLCJMA CKHBOBJCMPO(AEHCCAJOAGK HCAMONPFOJM, [In] JOBMDEJONPK APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x83CD050", Offset = "0x83CC050", VA = "0x1883CD050", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x83D4A30", Offset = "0x83D3A30", VA = "0x1883D4A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool KGPPIMBCPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x83D55E0", Offset = "0x83D45E0", VA = "0x1883D55E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool MPKPPHOFPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x83D3610", Offset = "0x83D2610", VA = "0x1883D3610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private AEHCCAJOAGK LHCPKJJPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x83D4A80", Offset = "0x83D3A80", VA = "0x1883D4A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x83D4000", Offset = "0x83D3000", VA = "0x1883D4000")]
	public MIIDGJFBMGL(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x83D48D0", Offset = "0x83D38D0", VA = "0x1883D48D0", Slot = "4")]
	public void FGIFEHKDDPN(Vector3 ECOALLGHBMI, ForceMode FMAPMNGMDMD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x83D5120", Offset = "0x83D4120", VA = "0x1883D5120")]
	private void NDEKLMINPNO(Vector3 ECOALLGHBMI, ForceMode FMAPMNGMDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x83D4C40", Offset = "0x83D3C40", VA = "0x1883D4C40", Slot = "5")]
	public void LGOCIELBIIK(Vector3 ECOALLGHBMI, Vector3 EPCLGOKLIPO, ForceMode FMAPMNGMDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x83D4AE0", Offset = "0x83D3AE0", VA = "0x1883D4AE0", Slot = "6")]
	public void KKOKDJLJLLK(Vector3 LLLAFEEDFHF, ForceMode FMAPMNGMDMD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x83D4EC0", Offset = "0x83D3EC0", VA = "0x1883D4EC0")]
	private void MNMDBFLGFKD(Vector3 LLLAFEEDFHF, ForceMode FMAPMNGMDMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x83D5380", Offset = "0x83D4380", VA = "0x1883D5380", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA5F80", Offset = "0xAA4F80", VA = "0x180AA5F80", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x83D3E80", Offset = "0x83D2E80", VA = "0x1883D3E80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x83D4000", Offset = "0x83D3000", VA = "0x1883D4000")]
	public LAMHKMCAKMA(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x83D3E50", Offset = "0x83D2E50", VA = "0x1883D3E50", Slot = "6")]
	public void DAAJDDOAIDE(Rigidbody OHEGODNMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x83D3F90", Offset = "0x83D2F90", VA = "0x1883D3F90", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x83CE410", Offset = "0x83CD410", VA = "0x1883CE410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public AEHCCAJOAGK LHCPKJJPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CE0", Offset = "0x9F3CE0", VA = "0x1809F4CE0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x83CEAB0", Offset = "0x83CDAB0", VA = "0x1883CEAB0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public AEHCCAJOAGK FMDIEJKNFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CF0", Offset = "0x9F3CF0", VA = "0x1809F4CF0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<AEHCCAJOAGK> DEMICCKDBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9F46F0", Offset = "0x9F36F0", VA = "0x1809F46F0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event PNBPECEEHKD AOKFEFCGPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x83CDEC0", Offset = "0x83CCEC0", VA = "0x1883CDEC0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x83CD7E0", Offset = "0x83CC7E0", VA = "0x1883CD7E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event PNBPECEEHKD GIBENIPGOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x83CF360", Offset = "0x83CE360", VA = "0x1883CF360", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x83CD690", Offset = "0x83CC690", VA = "0x1883CD690", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event GNDLKMBGIHB KIAKJBHJBDD
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x83CE0B0", Offset = "0x83CD0B0", VA = "0x1883CE0B0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x83CDAA0", Offset = "0x83CCAA0", VA = "0x1883CDAA0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action ALLBGBJDNPF
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x83CDC50", Offset = "0x83CCC50", VA = "0x1883CDC50", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x83CDA00", Offset = "0x83CCA00", VA = "0x1883CDA00", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action EGIDEGKAHHI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x83CE470", Offset = "0x83CD470", VA = "0x1883CE470", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x83CE370", Offset = "0x83CD370", VA = "0x1883CE370", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<AEHCCAJOAGK> FDEJNPJMBLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x83CDF60", Offset = "0x83CCF60", VA = "0x1883CDF60", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x83CE640", Offset = "0x83CD640", VA = "0x1883CE640", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<AEHCCAJOAGK> MOGLNKNFOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x83CED30", Offset = "0x83CDD30", VA = "0x1883CED30", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x83CE210", Offset = "0x83CD210", VA = "0x1883CE210", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action GEFBCEJKHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x83CD5F0", Offset = "0x83CC5F0", VA = "0x1883CD5F0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x83CE010", Offset = "0x83CD010", VA = "0x1883CE010", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<AEHCCAJOAGK> KONPFMJBHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x83CE2C0", Offset = "0x83CD2C0", VA = "0x1883CE2C0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x83CD730", Offset = "0x83CC730", VA = "0x1883CD730", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x83CF400", Offset = "0x83CE400", VA = "0x1883CF400")]
	public DPGMANGLAKJ(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x83CD880", Offset = "0x83CC880", VA = "0x1883CD880", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x83CEDE0", Offset = "0x83CDDE0", VA = "0x1883CEDE0", Slot = "30")]
	public void PFEAOMFGIPC(AEHCCAJOAGK FAMAONKAFDI, bool CCADIPLOOPF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x83CEAC0", Offset = "0x83CDAC0", VA = "0x1883CEAC0", Slot = "6")]
	public void PBPFICIFFFM(AEHCCAJOAGK CKMMPPDMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x83CE830", Offset = "0x83CD830", VA = "0x1883CE830", Slot = "7")]
	public void OOLLCDHEGFE(AEHCCAJOAGK CKMMPPDMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x83CDB40", Offset = "0x83CCB40", VA = "0x1883CDB40", Slot = "4")]
	public void JHHBOOEOKAN(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x83CDE20", Offset = "0x83CCE20", VA = "0x1883CDE20", Slot = "5")]
	public void JPCCIBAAOGI(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x83CD960", Offset = "0x83CC960", VA = "0x1883CD960")]
	private void FGEBAJKBNEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x83CD920", Offset = "0x83CC920", VA = "0x1883CD920")]
	private void EHJEFHIILKG(AEHCCAJOAGK CKMMPPDMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x83CE6F0", Offset = "0x83CD6F0", VA = "0x1883CE6F0")]
	private void OJNDEMCGJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x83CE510", Offset = "0x83CD510", VA = "0x1883CE510")]
	private void ODJMHPKMBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x83CDCF0", Offset = "0x83CCCF0", VA = "0x1883CDCF0")]
	private void JNHIMGNKHMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x83CE150", Offset = "0x83CD150", VA = "0x1883CE150")]
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
	[Cpp2IlInjected.Address(RVA = "0x83CF780", Offset = "0x83CE780", VA = "0x1883CF780")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 IKEEOKKFNOG
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x83E1F40", Offset = "0x83E0F40", VA = "0x1883E1F40", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 PPOEAMFJKMH
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x83E1870", Offset = "0x83E0870", VA = "0x1883E1870", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 MHHKMIMGCEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x83E1F70", Offset = "0x83E0F70", VA = "0x1883E1F70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public AEHCCAJOAGK EAKDMDHIIDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x83E1E90", Offset = "0x83E0E90", VA = "0x1883E1E90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x83E2060", Offset = "0x83E1060", VA = "0x1883E2060")]
	public PPNAAIDLLAP(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x83E1E20", Offset = "0x83E0E20", VA = "0x1883E1E20", Slot = "8")]
	public void LCIGENBHIIO(AEHCCAJOAGK JHDAOHEONAC, object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x83E1DC0", Offset = "0x83E0DC0", VA = "0x1883E1DC0", Slot = "9")]
	public void JPAPBHMBHOL(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x83E14D0", Offset = "0x83E04D0", VA = "0x1883E14D0")]
	private Vector3 BCCJJHNEGJG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x83E1A30", Offset = "0x83E0A30", VA = "0x1883E1A30")]
	private void IAAJLNDMIFG(AEHCCAJOAGK PDNMPAHMCNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class NFINNNIFLKJ
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x83D8CB0", Offset = "0x83D7CB0", VA = "0x1883D8CB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x15F3650", Offset = "0x15F2650", VA = "0x1815F3650", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x83CF900", Offset = "0x83CE900", VA = "0x1883CF900", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 GDHCBFHODJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x83CFBE0", Offset = "0x83CEBE0", VA = "0x1883CFBE0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float ILIOIANLCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xCCE460", Offset = "0xCCD460", VA = "0x180CCE460", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x83CFAD0", Offset = "0x83CEAD0", VA = "0x1883CFAD0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float IMNDBPGANOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xBFBC10", Offset = "0xBFAC10", VA = "0x180BFBC10", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x83CFDB0", Offset = "0x83CEDB0", VA = "0x1883CFDB0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 KCEMHIHMFPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x83D1200", Offset = "0x83D0200", VA = "0x1883D1200", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion NEFBFOAEHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x83D1F30", Offset = "0x83D0F30", VA = "0x1883D1F30", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody LJPLOMDHOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x83D1510", Offset = "0x83D0510", VA = "0x1883D1510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event PNBPECEEHKD CINAFJPLFMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x83D02F0", Offset = "0x83CF2F0", VA = "0x1883D02F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x83D1470", Offset = "0x83D0470", VA = "0x1883D1470", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x83D20B0", Offset = "0x83D10B0", VA = "0x1883D20B0")]
	public FLMHLDONDEL(AEHCCAJOAGK DPBHNMFBAMI, [In] JOBMDEJONPK APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x83CF9B0", Offset = "0x83CE9B0", VA = "0x1883CF9B0", Slot = "17")]
	public void BHIHKAKKCLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x83D1390", Offset = "0x83D0390", VA = "0x1883D1390", Slot = "16")]
	public void HPBGKAMNHIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x83CFCD0", Offset = "0x83CECD0", VA = "0x1883CFCD0", Slot = "19")]
	public void DAAJDDOAIDE(Rigidbody OHEGODNMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x83D1D50", Offset = "0x83D0D50", VA = "0x1883D1D50", Slot = "20")]
	public void OANECBGNIHD(Rigidbody OHEGODNMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x83D1650", Offset = "0x83D0650", VA = "0x1883D1650", Slot = "18")]
	public void KLLMDLAJOMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x83CFE60", Offset = "0x83CEE60", VA = "0x1883CFE60", Slot = "21")]
	public void EPCDCICFCMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x83CF900", Offset = "0x83CE900", VA = "0x1883CF900")]
	private void ADDLOKNLDAB(Vector3 OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x83D1560", Offset = "0x83D0560", VA = "0x1883D1560")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 KAABCIHEILP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x83CFAD0", Offset = "0x83CEAD0", VA = "0x1883CFAD0")]
	private void BJHFPODEBLI(float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x83CFDB0", Offset = "0x83CEDB0", VA = "0x1883CFDB0")]
	private void HOMPCMLLJDF(float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x83D1800", Offset = "0x83D0800", VA = "0x1883D1800")]
	private Vector3 LMDHJNMJANK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x83D1B20", Offset = "0x83D0B20", VA = "0x1883D1B20", Slot = "15")]
	public void NMOLEIEJHFM((Quaternion rot, Vector3 moments) CKBACCDPBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x83D19A0", Offset = "0x83D09A0", VA = "0x1883D19A0")]
	private Quaternion NKFPCLGBNJC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x83D1130", Offset = "0x83D0130", VA = "0x1883D1130")]
	public void GMGHPDIOJHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x83D0390", Offset = "0x83CF390", VA = "0x1883D0390", Slot = "4")]
	public (float, Vector3) GMGHPDIOJHP(Rigidbody KEHLPGHPHHH)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class KCOLMBHBMFJ
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x83D3D90", Offset = "0x83D2D90", VA = "0x1883D3D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x1793330", Offset = "0x1792330", VA = "0x181793330", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public KDGIOFPALDJ KFOHGIONJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640", Slot = "11")]
		get
		{
			return default(KDGIOFPALDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x83D46C0", Offset = "0x83D36C0", VA = "0x1883D46C0")]
	public LGMPJABHCEJ(AEHCCAJOAGK DPBHNMFBAMI, [In] JOBMDEJONPK APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x83D43A0", Offset = "0x83D33A0", VA = "0x1883D43A0", Slot = "4")]
	public void LLGFJHIIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x83D4470", Offset = "0x83D3470", VA = "0x1883D4470")]
	private bool LNNOLMDOCEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x83D40D0", Offset = "0x83D30D0", VA = "0x1883D40D0", Slot = "5")]
	public void GNAGMCHKEPB(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x83D4510", Offset = "0x83D3510", VA = "0x1883D4510", Slot = "6")]
	public void OBLODMOAEKG(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x83D4100", Offset = "0x83D3100", VA = "0x1883D4100", Slot = "9")]
	public void IHJCPCJCJFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x83D4240", Offset = "0x83D3240", VA = "0x1883D4240")]
	private void IJCJOKPNINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x83D4540", Offset = "0x83D3540", VA = "0x1883D4540")]
	private void OMNPGPNGBGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x83D4090", Offset = "0x83D3090", VA = "0x1883D4090", Slot = "8")]
	public void DLHHCDEJEBM(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x83D4360", Offset = "0x83D3360", VA = "0x1883D4360", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x83D3AA0", Offset = "0x83D2AA0", VA = "0x1883D3AA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event PNBPECEEHKD GMAEPBAHAJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x83D3890", Offset = "0x83D2890", VA = "0x1883D3890", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x83D39D0", Offset = "0x83D29D0", VA = "0x1883D39D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x83D3B90", Offset = "0x83D2B90", VA = "0x1883D3B90")]
	public IJLBIHINJMA(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x83D39C0", Offset = "0x83D29C0", VA = "0x1883D39C0", Slot = "7")]
	public void HHNGPMIMDOO(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x83D39B0", Offset = "0x83D29B0", VA = "0x1883D39B0", Slot = "8")]
	public void ECLLEAMJHDE(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x83D3780", Offset = "0x83D2780", VA = "0x1883D3780", Slot = "9")]
	public void BLLMHFJJADE(object EJJDDFFADPC, bool GFJJBICPGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x83D3B50", Offset = "0x83D2B50", VA = "0x1883D3B50", Slot = "12")]
	public void PMBDLBOMHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x83D3930", Offset = "0x83D2930", VA = "0x1883D3930", Slot = "10")]
	public void DAAJDDOAIDE(Rigidbody FFHIAOPJEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x83D3A70", Offset = "0x83D2A70", VA = "0x1883D3A70", Slot = "11")]
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
	private PhotonView EGLHICHHNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool JCCCJEGELOB;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public PhotonView PFFFFPLBLDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool BNFOGIBLEGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x83CC130", Offset = "0x83CB130", VA = "0x1883CC130", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool LMGPENNCPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xDA98B0", Offset = "0xDA88B0", VA = "0x180DA98B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event PNBPECEEHKD HMGIPDEBDGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x83CBC30", Offset = "0x83CAC30", VA = "0x1883CBC30", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x83CC090", Offset = "0x83CB090", VA = "0x1883CC090", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x83CC150", Offset = "0x83CB150", VA = "0x1883CC150")]
	public ANJCCFMIBBJ(AEHCCAJOAGK DPBHNMFBAMI, [In] JOBMDEJONPK APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x83CBB00", Offset = "0x83CAB00", VA = "0x1883CBB00", Slot = "9")]
	public void LLGFJHIIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x83CB720", Offset = "0x83CA720", VA = "0x1883CB720", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x83CB5B0", Offset = "0x83CA5B0", VA = "0x1883CB5B0", Slot = "10")]
	public void DIPLHBJMKEM(AEHCCAJOAGK JHDAOHEONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x83CB820", Offset = "0x83CA820", VA = "0x1883CB820", Slot = "11")]
	public void HCCCGLGGJNO(AEHCCAJOAGK JHDAOHEONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x83CB990", Offset = "0x83CA990", VA = "0x1883CB990")]
	private void HKPAAAJJPHM(PhotonView MBPGHHNDAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x83CBCD0", Offset = "0x83CACD0", VA = "0x1883CBCD0")]
	private void LOACIKIHMEM(HAIPDKCGNLO AAGGHIFABAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x83CBE20", Offset = "0x83CAE20", VA = "0x1883CBE20")]
	private void LOJDHMFMMJM(PhotonView CCGOAOBJLNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class FBGBLNBELBB
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x83CF840", Offset = "0x83CE840", VA = "0x1883CF840")]
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
		[Cpp2IlInjected.Address(RVA = "0xA41D50", Offset = "0xA40D50", VA = "0x180A41D50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xD073A0", Offset = "0xD063A0", VA = "0x180D073A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool NGHCBIDJJPG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xD07970", Offset = "0xD06970", VA = "0x180D07970", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xD079F0", Offset = "0xD069F0", VA = "0x180D079F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints NDDPBBNBEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x83DFB80", Offset = "0x83DEB80", VA = "0x1883DFB80", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x83DFCE0", Offset = "0x83DECE0", VA = "0x1883DFCE0")]
	public OCLBPMECEMI(AEHCCAJOAGK DPBHNMFBAMI, [In] JOBMDEJONPK APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x83DFB50", Offset = "0x83DEB50", VA = "0x1883DFB50", Slot = "9")]
	public void DAAJDDOAIDE(Rigidbody OHEGODNMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x83DFCB0", Offset = "0x83DECB0", VA = "0x1883DFCB0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0xECEA30", Offset = "0xECDA30", VA = "0x180ECEA30", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x83CC2A0", Offset = "0x83CB2A0", VA = "0x1883CC2A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float AEIOPPGFCCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17E40", VA = "0x180D18E40", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x83CC3C0", Offset = "0x83CB3C0", VA = "0x1883CC3C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x83CC530", Offset = "0x83CB530", VA = "0x1883CC530")]
	public BEDCMJAJONO(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x83CC370", Offset = "0x83CB370", VA = "0x1883CC370", Slot = "8")]
	public void DAAJDDOAIDE(Rigidbody OHEGODNMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x83CC490", Offset = "0x83CB490", VA = "0x1883CC490", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x83D1510", Offset = "0x83D0510", VA = "0x1883D1510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool KHKHNOEIDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x83E0FC0", Offset = "0x83DFFC0", VA = "0x1883E0FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private AEHCCAJOAGK LHCPKJJPDMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x83E0DC0", Offset = "0x83DFDC0", VA = "0x1883E0DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool MPKPPHOFPOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x83E1080", Offset = "0x83E0080", VA = "0x1883E1080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event PNBPECEEHKD OEJFEEIDNPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x83E0D20", Offset = "0x83DFD20", VA = "0x1883E0D20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x83E0E20", Offset = "0x83DFE20", VA = "0x1883E0E20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x83E1170", Offset = "0x83E0170", VA = "0x1883E1170")]
	public PLJPMANDLKC(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x83E0F30", Offset = "0x83DFF30", VA = "0x1883E0F30", Slot = "6")]
	public void LLGFJHIIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x83E0D10", Offset = "0x83DFD10", VA = "0x1883E0D10", Slot = "8")]
	public void IIAGPMFFLGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x83E0BC0", Offset = "0x83DFBC0", VA = "0x1883E0BC0", Slot = "7")]
	public bool GMPMKPGGEJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x83E0FE0", Offset = "0x83DFFE0", VA = "0x1883E0FE0", Slot = "9")]
	public void PLELPHGDIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x83E0510", Offset = "0x83DF510", VA = "0x1883E0510", Slot = "13")]
	public void BOLEDFNDLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x83E09D0", Offset = "0x83DF9D0", VA = "0x1883E09D0", Slot = "12")]
	public void ENCOGDACOEB(bool JKDOKIEEKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x83E0EC0", Offset = "0x83DFEC0", VA = "0x1883E0EC0", Slot = "10")]
	public bool LCLIEIIFEMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x83E0B00", Offset = "0x83DFB00", VA = "0x1883E0B00", Slot = "11")]
	public bool FGHMOILEBNK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x83E0740", Offset = "0x83DF740", VA = "0x1883E0740")]
	private bool DELCGMBILLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x83E05B0", Offset = "0x83DF5B0", VA = "0x1883E05B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool MPKPPHOFPOF
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x83D3610", Offset = "0x83D2610", VA = "0x1883D3610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool AJOEBCDDACN
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1793330", Offset = "0x1792330", VA = "0x181793330", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x83D3670", Offset = "0x83D2670", VA = "0x1883D3670")]
	public IHPLEHILJBO(AEHCCAJOAGK DPBHNMFBAMI, [In] JOBMDEJONPK APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x83D31E0", Offset = "0x83D21E0", VA = "0x1883D31E0", Slot = "5")]
	public void LLGFJHIIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x83D35E0", Offset = "0x83D25E0", VA = "0x1883D35E0", Slot = "7")]
	public void OLPGEFNAPKA(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x83D3280", Offset = "0x83D2280", VA = "0x1883D3280", Slot = "8")]
	public void LLJCOJABAHE(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x83D32B0", Offset = "0x83D22B0", VA = "0x1883D32B0", Slot = "9")]
	public void MJPDMBEMBIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x83D2E70", Offset = "0x83D1E70", VA = "0x1883D2E70", Slot = "10")]
	public void BNALDMBCGNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x83D3060", Offset = "0x83D2060", VA = "0x1883D3060", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public EKDAONPNEDM PFHAOKHAIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 MHHKMIMGCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x83D88A0", Offset = "0x83D78A0", VA = "0x1883D88A0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x83D84D0", Offset = "0x83D74D0", VA = "0x1883D84D0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 MBONAKJIGKG
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x83D6E50", Offset = "0x83D5E50", VA = "0x1883D6E50", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x83D8750", Offset = "0x83D7750", VA = "0x1883D8750", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 NGPCALAEKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x83D6F70", Offset = "0x83D5F70", VA = "0x1883D6F70", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x83D6900", Offset = "0x83D5900", VA = "0x1883D6900", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 PPKJNICDJFO
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x83D8AA0", Offset = "0x83D7AA0", VA = "0x1883D8AA0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x83D8590", Offset = "0x83D7590", VA = "0x1883D8590", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float KAAKNIDJMKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xED2390", Offset = "0xED1390", VA = "0x180ED2390", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x83D5BE0", Offset = "0x83D4BE0", VA = "0x1883D5BE0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool ACLAGMPFHFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x20D7950", Offset = "0x20D6950", VA = "0x1820D7950", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private KGLLPODCDJM GOAPBLIKEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x79F1F40", Offset = "0x79F0F40", VA = "0x1879F1F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool KHKHNOEIDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x83D84B0", Offset = "0x83D74B0", VA = "0x1883D84B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x83D8BC0", Offset = "0x83D7BC0", VA = "0x1883D8BC0")]
	public MLOLDEBBPON(AEHCCAJOAGK DPBHNMFBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x83D6BC0", Offset = "0x83D5BC0", VA = "0x1883D6BC0", Slot = "19")]
	public void LLGFJHIIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x83D6250", Offset = "0x83D5250", VA = "0x1883D6250", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x83D60C0", Offset = "0x83D50C0", VA = "0x1883D60C0", Slot = "28")]
	public void DAAJDDOAIDE(Rigidbody OHEGODNMMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x15B4CD0", Offset = "0x15B3CD0", VA = "0x1815B4CD0", Slot = "20")]
	public void PHNPIGPKCIB(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x15B3530", Offset = "0x15B2530", VA = "0x1815B3530", Slot = "30")]
	public void ILOOIMLILFL(object EJJDDFFADPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x83D6C70", Offset = "0x83D5C70", VA = "0x1883D6C70", Slot = "35")]
	public Vector3 IIACFCKBMEK(Vector3 BNPCCEGFLAG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x83D6740", Offset = "0x83D5740", VA = "0x1883D6740", Slot = "34")]
	public Vector3 FABBPJPCFND(Vector3 OCDMHIHKCOM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x83D6BC0", Offset = "0x83D5BC0", VA = "0x1883D6BC0", Slot = "27")]
	public void IDLPDECABCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x83D6060", Offset = "0x83D5060", VA = "0x1883D6060", Slot = "25")]
	public void CLGDPDBNAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x83D61F0", Offset = "0x83D51F0", VA = "0x1883D61F0", Slot = "24")]
	public void DIIEGPIOIEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x83D8270", Offset = "0x83D7270", VA = "0x1883D8270", Slot = "33")]
	public void MBNADKIEICD(Vector3 BFCMGGLPKOG, Vector3 CFMHHLGNOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x83D6B60", Offset = "0x83D5B60", VA = "0x1883D6B60", Slot = "32")]
	public void FOPCBHBBKFA(Vector3 FHHDANGJANF, Vector3 MKJAKHMCJFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x83D80D0", Offset = "0x83D70D0", VA = "0x1883D80D0", Slot = "31")]
	public void LANBKIAKANC(Vector3 PBPCDIDONHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x83D70D0", Offset = "0x83D60D0", VA = "0x1883D70D0", Slot = "22")]
	public void IOFCEMOCNKJ(OCNBACAEJKA IIPHGHABFEI, Vector3 FBJOGNFJNKE, float GINNKEFNNNJ, float AGKFEOKGNFN = 8f, float LKKCFIBADJL = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x83D5DD0", Offset = "0x83D4DD0", VA = "0x1883D5DD0", Slot = "21")]
	public void CKHAMKNHENO(GNGBJGPGOGK DMMOCNOPLNI, Vector3 CFIMLPPLPIK, float KMIIDKLEDDJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x83D7730", Offset = "0x83D6730", VA = "0x1883D7730", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JBLCNFLLANL(GNGBJGPGOGK DMMOCNOPLNI, Vector3 OOBEGCNALKF, float LNKOBALGGOE = 7f, float OKOMENKNBDN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x16CA340", Offset = "0x16C9340", VA = "0x1816CA340")]
	private static void GPJIEMGDAAL(Vector3 NPNMEIDGLAE, Vector3 HPAMHMBDLLL, [Out] Vector3 JLJIPIBAPIH, [Out] Vector3 NFDBLLNJKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x83D5CF0", Offset = "0x83D4CF0", VA = "0x1883D5CF0", Slot = "29")]
	public Vector3 BMCODDGJPBA(Vector3 NPNMEIDGLAE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x83D85C0", Offset = "0x83D75C0", VA = "0x1883D85C0", Slot = "26")]
	public void ONIIAKFKNGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x83D5BE0", Offset = "0x83D4BE0", VA = "0x1883D5BE0")]
	private void HAGKGDEMHHO(float OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x83D69C0", Offset = "0x83D59C0", VA = "0x1883D69C0")]
	private void FGCKAIIFCJC(Vector3 CFIMLPPLPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x83D7B20", Offset = "0x83D6B20", VA = "0x1883D7B20")]
	private Vector3 KMAALFIECPO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x83D7C40", Offset = "0x83D6C40", VA = "0x1883D7C40")]
	private void KOCOFLKLFJF(Vector3 OCDMHIHKCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x83D8780", Offset = "0x83D7780", VA = "0x1883D8780")]
	private Vector3 PCGDBHDCGFH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x83D62B0", Offset = "0x83D52B0", VA = "0x1883D62B0")]
	private void EGABAHFECHD(Vector3 OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x83D5630", Offset = "0x83D4630", VA = "0x1883D5630")]
	private void ACGICFBGDFK(Vector3 OCDMHIHKCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x83D89F0", Offset = "0x83D79F0", VA = "0x1883D89F0")]
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
