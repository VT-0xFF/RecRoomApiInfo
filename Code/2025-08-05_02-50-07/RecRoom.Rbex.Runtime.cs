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
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBF20", Offset = "0x8ADB320", VA = "0x188ADBF20", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x846E210", Offset = "0x846D610", VA = "0x18846E210", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8AED5F0", Offset = "0x8AEC9F0", VA = "0x188AED5F0")]
		private void GBFKFENBIAE(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8AED8F0", Offset = "0x8AECCF0", VA = "0x188AED8F0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8AED950", Offset = "0x8AECD50", VA = "0x188AED950")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, HHMPDIJPAEB, FBNDMBMKCOM, DOMLIJNADCE
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly AKNCNLDICPO JNMFMDOFPDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool DOCDCNEPKJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private ANFFNMLLNBD JFFCMECAKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[OCPKILIHCKA(FIPBCJPBODB.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[OCPKILIHCKA(FIPBCJPBODB.SelfAndParent, true, false, false)]
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
		private IAOENOOJLJP physicsInterpolation;

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
		private Transform IHGGOBCKNGM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal ANFFNMLLNBD FCFIAGBFEJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8AE8DE0", Offset = "0x8AE81E0", VA = "0x188AE8DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private ANFFNMLLNBD ALFJKAEAJPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int KMJPCKADHMA
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8AEAB00", Offset = "0x8AE9F00", VA = "0x188AEAB00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx HHMDAAEKGII
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8AEAE60", Offset = "0x8AEA260", VA = "0x188AEAE60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx NDDFGLPMAHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8AEADA0", Offset = "0x8AEA1A0", VA = "0x188AEADA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx JIECBJMGMAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8AEBA60", Offset = "0x8AEAE60", VA = "0x188AEBA60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8AECF60", Offset = "0x8AEC360", VA = "0x188AECF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool MDHGNPMONEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8706B30", Offset = "0x8705F30", VA = "0x188706B30", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8707820", Offset = "0x8706C20", VA = "0x188707820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform GANAIKEBLIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x24FB900", Offset = "0x24FAD00", VA = "0x1824FB900", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform NFIGBFKLJJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x24FB900", Offset = "0x24FAD00", VA = "0x1824FB900", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform GFKDPMFHONJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x24FB900", Offset = "0x24FAD00", VA = "0x1824FB900", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public LDGMPMKAKEN FBMLKEHDEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8AEAB60", Offset = "0x8AE9F60", VA = "0x188AEAB60")]
			get
			{
				return default(LDGMPMKAKEN);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC710", Offset = "0x8AEBB10", VA = "0x188AEC710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool LFPFNEMDNPA
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB170", Offset = "0x8AEA570", VA = "0x188AEB170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool OLDGACHJNBG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8AEAC80", Offset = "0x8AEA080", VA = "0x188AEAC80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public LLFNGCOOPGE MLBJGFMIACD
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB0B0", Offset = "0x8AEA4B0", VA = "0x188AEB0B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC8D0", Offset = "0x8AEBCD0", VA = "0x188AEC8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public BNNLLMJJDPO JIANNGPCJGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB050", Offset = "0x8AEA450", VA = "0x188AEB050")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC860", Offset = "0x8AEBC60", VA = "0x188AEC860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GFOJNPBFEHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8AEAFA0", Offset = "0x8AEA3A0", VA = "0x188AEAFA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody GKLCHHJFEJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB000", Offset = "0x8AEA400", VA = "0x188AEB000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool LKGHGHPGKJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8AEACE0", Offset = "0x8AEA0E0", VA = "0x188AEACE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC780", Offset = "0x8AEBB80", VA = "0x188AEC780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool AOHOACHBAMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1023F10", Offset = "0x1023310", VA = "0x181023F10", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float FNDAHMHLJCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8AEBA00", Offset = "0x8AEAE00", VA = "0x188AEBA00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float EJJOEPLPAGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB9A0", Offset = "0x8AEADA0", VA = "0x188AEB9A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8AECEF0", Offset = "0x8AEC2F0", VA = "0x188AECEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float DIJLKGIKLBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB3D0", Offset = "0x8AEA7D0", VA = "0x188AEB3D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8AECB70", Offset = "0x8AEBF70", VA = "0x188AECB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float OLLOEFCLBJG
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB1D0", Offset = "0x8AEA5D0", VA = "0x188AEB1D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC940", Offset = "0x8AEBD40", VA = "0x188AEC940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool HLHGHFPOCHH
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8AEBFB0", Offset = "0x8AEB3B0", VA = "0x188AEBFB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8AED4A0", Offset = "0x8AEC8A0", VA = "0x188AED4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 IBKAPAEFFBI
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB780", Offset = "0x8AEAB80", VA = "0x188AEB780")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8AECCC0", Offset = "0x8AEC0C0", VA = "0x188AECCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 EGOPGCIFLMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC0F0", Offset = "0x8AEB4F0", VA = "0x188AEC0F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode BFEFOENFDAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB310", Offset = "0x8AEA710", VA = "0x188AEB310")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8AECA90", Offset = "0x8AEBE90", VA = "0x188AECA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float ICCECLDBIHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8AEAD40", Offset = "0x8AEA140", VA = "0x188AEAD40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC7F0", Offset = "0x8AEBBF0", VA = "0x188AEC7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints LALLJGKPOOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB370", Offset = "0x8AEA770", VA = "0x188AEB370")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8AECB00", Offset = "0x8AEBF00", VA = "0x188AECB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 DJMCODDNPOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8AEBB20", Offset = "0x8AEAF20", VA = "0x188AEBB20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 IBDJNGEPJGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8AEBB20", Offset = "0x8AEAF20", VA = "0x188AEBB20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8AED280", Offset = "0x8AEC680", VA = "0x188AED280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float PDCCLEJABHI
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB860", Offset = "0x8AEAC60", VA = "0x188AEB860")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8AECDA0", Offset = "0x8AEC1A0", VA = "0x188AECDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float JMHMPNGIJLH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8AEBF50", Offset = "0x8AEB350", VA = "0x188AEBF50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8AED430", Offset = "0x8AEC830", VA = "0x188AED430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion DHOLDFBAINF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8AEBC00", Offset = "0x8AEB000", VA = "0x188AEBC00")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8AED000", Offset = "0x8AEC400", VA = "0x188AED000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion JPPJEADFMPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8AEBE80", Offset = "0x8AEB280", VA = "0x188AEBE80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8AED360", Offset = "0x8AEC760", VA = "0x188AED360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 CHLIMKENEAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8AEBCD0", Offset = "0x8AEB0D0", VA = "0x188AEBCD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8AED0D0", Offset = "0x8AEC4D0", VA = "0x188AED0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion IAPDJKKNLCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8AEBDB0", Offset = "0x8AEB1B0", VA = "0x188AEBDB0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8AED1B0", Offset = "0x8AEC5B0", VA = "0x188AED1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 PODFFOEBFLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC010", Offset = "0x8AEB410", VA = "0x188AEC010")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8AED510", Offset = "0x8AEC910", VA = "0x188AED510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 MIAAPPECFHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB8C0", Offset = "0x8AEACC0", VA = "0x188AEB8C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8AECE10", Offset = "0x8AEC210", VA = "0x188AECE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 NBPDCMBDPJL
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB230", Offset = "0x8AEA630", VA = "0x188AEB230")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC9B0", Offset = "0x8AEBDB0", VA = "0x188AEC9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 IGINODMGIBP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB6A0", Offset = "0x8AEAAA0", VA = "0x188AEB6A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8AECBE0", Offset = "0x8AEBFE0", VA = "0x188AECBE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 PPLCOJDNDDL
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB560", Offset = "0x8AEA960", VA = "0x188AEB560")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion EDAMCMCIKGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB490", Offset = "0x8AEA890", VA = "0x188AEB490")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 JLGEBMOBGEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC2B0", Offset = "0x8AEB6B0", VA = "0x188AEC2B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 JNJOICNEBPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC1D0", Offset = "0x8AEB5D0", VA = "0x188AEC1D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool MLGIMEMLELE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB640", Offset = "0x8AEAA40", VA = "0x188AEB640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BEHIPMAANFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB110", Offset = "0x8AEA510", VA = "0x188AEB110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool FPCMCBBMDOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8AEAC20", Offset = "0x8AEA020", VA = "0x188AEAC20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool MCFLDOOEFGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8AEABC0", Offset = "0x8AE9FC0", VA = "0x188AEABC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool ELIKEPNCGPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8AEAAA0", Offset = "0x8AE9EA0", VA = "0x188AEAAA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool NCEAFIHOHCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8AEB430", Offset = "0x8AEA830", VA = "0x188AEB430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool OEKNIBMILKH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x26C2E20", Offset = "0x26C2220", VA = "0x1826C2E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event MBOJNAFHAKB BHPBEDNADAM
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8AEA9C0", Offset = "0x8AE9DC0", VA = "0x188AEA9C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC630", Offset = "0x8AEBA30", VA = "0x188AEC630")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event CIOBHEEBBCO KMKICDNANGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8AEA730", Offset = "0x8AE9B30", VA = "0x188AEA730")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC390", Offset = "0x8AEB790", VA = "0x188AEC390")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event CIOBHEEBBCO DLLONEOIIFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8AEA790", Offset = "0x8AE9B90", VA = "0x188AEA790")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC400", Offset = "0x8AEB800", VA = "0x188AEC400")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event CIOBHEEBBCO EIMNEJBGAEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8AEA8E0", Offset = "0x8AE9CE0", VA = "0x188AEA8E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC550", Offset = "0x8AEB950", VA = "0x188AEC550")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<IEEJIDPBMPL, IEEJIDPBMPL> MDCACKDOAIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8AEA870", Offset = "0x8AE9C70", VA = "0x188AEA870")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC4E0", Offset = "0x8AEB8E0", VA = "0x188AEC4E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event CIOBHEEBBCO MOIGGMJBAAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8AEA950", Offset = "0x8AE9D50", VA = "0x188AEA950")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC5C0", Offset = "0x8AEB9C0", VA = "0x188AEC5C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event CIOBHEEBBCO PNKOOIABDNO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8AEAA30", Offset = "0x8AE9E30", VA = "0x188AEAA30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC6A0", Offset = "0x8AEBAA0", VA = "0x188AEC6A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event CIOBHEEBBCO FHJBMOPMOKC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8AEA800", Offset = "0x8AE9C00", VA = "0x188AEA800")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC470", Offset = "0x8AEB870", VA = "0x188AEC470")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0", Slot = "8")]
		private void AFFGBMFGBKE(ANFFNMLLNBD FCHDCHMAIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9140", Offset = "0x8AE8540", VA = "0x188AE9140", Slot = "9")]
		public KPDFEHPKBMM GetData()
		{
			return default(KPDFEHPKBMM);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8AE95C0", Offset = "0x8AE89C0", VA = "0x188AE95C0")]
		internal void JIEHHGHKLFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8AEA450", Offset = "0x8AE9850", VA = "0x188AEA450")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody PLMDAJNBAGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8E90", Offset = "0x8AE8290", VA = "0x188AE8E90")]
		public HHMPDIJPAEB GetChild(int NOEININIMIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8AEA0B0", Offset = "0x8AE94B0", VA = "0x188AEA0B0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) AMFBBMEJKPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8A30", Offset = "0x8AE7E30", VA = "0x188AE8A30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8AEA340", Offset = "0x8AE9740", VA = "0x188AEA340")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8DE0", Offset = "0x8AE81E0", VA = "0x188AE8DE0")]
		private ANFFNMLLNBD FCFHJJMHOCD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE91E0", Offset = "0x8AE85E0", VA = "0x188AE91E0")]
		private void IPJPKJAMFMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9880", Offset = "0x8AE8C80", VA = "0x188AE9880")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8AE97C0", Offset = "0x8AE8BC0", VA = "0x188AE97C0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8AE95C0", Offset = "0x8AE89C0", VA = "0x188AE95C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9820", Offset = "0x8AE8C20", VA = "0x188AE9820")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8AE98E0", Offset = "0x8AE8CE0", VA = "0x188AE98E0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8020", Offset = "0x8AE7420", VA = "0x188AE8020")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9940", Offset = "0x8AE8D40", VA = "0x188AE9940")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8D80", Offset = "0x8AE8180", VA = "0x188AE8D80")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9760", Offset = "0x8AE8B60", VA = "0x188AE9760")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8AEA210", Offset = "0x8AE9610", VA = "0x188AEA210")]
		public void SetParent(RigidbodyEx CBMEHPPMEEA, bool FLJJABAPNLC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9C50", Offset = "0x8AE9050", VA = "0x188AE9C50")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9360", Offset = "0x8AE8760", VA = "0x188AE9360")]
		public bool IsRigidbodyAncestor(RigidbodyEx OPLHDHHEBBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9460", Offset = "0x8AE8860", VA = "0x188AE9460")]
		public bool IsRigidbodyDescendant(RigidbodyEx PDIKGICAEJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8290", Offset = "0x8AE7690", VA = "0x188AE8290")]
		public void AddInterpolationRestriction(object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE99B0", Offset = "0x8AE8DB0", VA = "0x188AE99B0")]
		public void RemoveInterpolationRestriction(object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8300", Offset = "0x8AE7700", VA = "0x188AE8300")]
		public void AddKinematic(object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9A20", Offset = "0x8AE8E20", VA = "0x188AE9A20")]
		public void RemoveKinematic(object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8AEA190", Offset = "0x8AE9590", VA = "0x188AEA190")]
		public void SetKinematic(object MONGIMOHLAO, bool GHMABHCPHDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9FB0", Offset = "0x8AE93B0", VA = "0x188AE9FB0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 LKOMPDMLLGJ, Quaternion MONBLLPGNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9EB0", Offset = "0x8AE92B0", VA = "0x188AE9EB0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 NLDEGBJACOA, Quaternion OAEOLICGPGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9030", Offset = "0x8AE8430", VA = "0x188AE9030")]
		public Vector3 GetConstrainedVelocity(Vector3 PODFFOEBFLC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8F20", Offset = "0x8AE8320", VA = "0x188AE8F20")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 NBPDCMBDPJL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8AE81A0", Offset = "0x8AE75A0", VA = "0x188AE81A0")]
		public void AddForce(Vector3 KBIBIFOFAKG, ForceMode MIGBGLJJIBM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8090", Offset = "0x8AE7490", VA = "0x188AE8090")]
		public void AddForceAtPosition(Vector3 KBIBIFOFAKG, Vector3 LBCFHLNAPLC, ForceMode MIGBGLJJIBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8AE84D0", Offset = "0x8AE78D0", VA = "0x188AE84D0")]
		public void AddTorque(Vector3 BJPPJIIAPFL, ForceMode MIGBGLJJIBM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8370", Offset = "0x8AE7770", VA = "0x188AE8370")]
		public void AddRelativeTorque(Vector3 BJPPJIIAPFL, ForceMode MIGBGLJJIBM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8AEA520", Offset = "0x8AE9920", VA = "0x188AEA520")]
		public Vector3 WorldToLocalVelocity(Vector3 DDEFJFOMGFG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9650", Offset = "0x8AE8A50", VA = "0x188AE9650")]
		public Vector3 LocalToWorldVelocity(Vector3 MIAAPPECFHB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8D20", Offset = "0x8AE8120", VA = "0x188AE8D20")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8CC0", Offset = "0x8AE80C0", VA = "0x188AE8CC0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8C60", Offset = "0x8AE8060", VA = "0x188AE8C60")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8C00", Offset = "0x8AE8000", VA = "0x188AE8C00")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9DB0", Offset = "0x8AE91B0", VA = "0x188AE9DB0")]
		public void ResetVelocityWorldSpace(Vector3 PABEIKNKFPG, Vector3 FBIPAGEENGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9CB0", Offset = "0x8AE90B0", VA = "0x188AE9CB0")]
		public void ResetVelocityLocalSpace(Vector3 PLHEOKHEDMJ, Vector3 IGINODMGIBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9B70", Offset = "0x8AE8F70", VA = "0x188AE9B70")]
		public void ResetLinearVelocityLocalSpace(Vector3 PLHEOKHEDMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8AEA350", Offset = "0x8AE9750", VA = "0x188AEA350")]
		public bool SweepTest(Vector3 NLDMHMFAEEN, [Out] RaycastHit EACMJKDJDDD, float ICEDCEOLBDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9560", Offset = "0x8AE8960", VA = "0x188AE9560")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8AEA2E0", Offset = "0x8AE96E0", VA = "0x188AEA2E0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8AEA4C0", Offset = "0x8AE98C0", VA = "0x188AEA4C0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8460", Offset = "0x8AE7860", VA = "0x188AE8460")]
		public void AddShouldHaveUnityRigidbodyToken(object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9A90", Offset = "0x8AE8E90", VA = "0x188AE9A90")]
		public void RemoveShouldHaveUnityRigidbodyToken(object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8860", Offset = "0x8AE7C60", VA = "0x188AE8860")]
		public void ApplyForceVelocityChange(DLGHIGIHDGD JJEMFOJGMKG, Vector3 PEJHAMCEMGO, float LBCMHCOCBKI, float EIHOHPGGLMO = 8f, float CCOOALGJJEJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8760", Offset = "0x8AE7B60", VA = "0x188AE8760")]
		public void ApplyAngularVelocityChange(EPFKLCJJAED ABMEPGCCPLP, Vector3 OGPLLELJPBM, float CDDONLBHEGI = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8920", Offset = "0x8AE7D20", VA = "0x188AE8920")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(EPFKLCJJAED ABMEPGCCPLP, Vector3 EMLGDFFEJED, float MCLHJJMOIDC = 7f, float NCKPOIOOOGF = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8AE8690", Offset = "0x8AE7A90", VA = "0x188AE8690")]
		public bool AllowedScaleChange(float ECDGIBOACGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8AE85C0", Offset = "0x8AE79C0", VA = "0x188AE85C0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx HAMLJAHLKDM, object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE9B00", Offset = "0x8AE8F00", VA = "0x188AE9B00")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE91D0", Offset = "0x8AE85D0", VA = "0x188AE91D0", Slot = "13")]
		private void HHHFBKOMGDM(JHFFNIJDHNE HFJHENFIDEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8AEA6C0", Offset = "0x8AE9AC0", VA = "0x188AEA6C0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xB0C030", Offset = "0xB0B430", VA = "0x180B0C030", Slot = "4")]
		private GameObject FNKKPMDBBOC()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA9B060", Offset = "0xA9A460", VA = "0x180A9B060", Slot = "10")]
		private bool CPFAEMKBANH()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class FGNHMMNDPGI
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4330", Offset = "0x8AD3730", VA = "0x188AD4330")]
	public static ANFFNMLLNBD FCFIAGBFEJI(this RigidbodyEx PAIBDGNODBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(COCGKILJEEG), new string[] { })]
public class AFLJPCBJAMB : COCGKILJEEG, FMPNPCDDCKO
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private KAJOMAMKMPE LHIJBEJLBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private ALADMNPDLLG ICOOAKNILLJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public KAJOMAMKMPE JDGMIPEIBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ALADMNPDLLG LLNENMCGDDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x8AD1220", Offset = "0x8AD0620", VA = "0x188AD1220", Slot = "7")]
	public void InitReferences(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8AD1050", Offset = "0x8AD0450", VA = "0x188AD1050", Slot = "6")]
	public ANFFNMLLNBD AJJBALBLDHA(RigidbodyEx PAIBDGNODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public AFLJPCBJAMB()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static OFFOKCJIMNI UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int LIOIJHJNAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int ADJGGEIEGBL;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7E80", Offset = "0x8AE7280", VA = "0x188AE7E80")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7EC0", Offset = "0x8AE72C0", VA = "0x188AE7EC0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7EA0", Offset = "0x8AE72A0", VA = "0x188AE7EA0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string AFDNIPHJHMO, [Optional] UnityEngine.Object HFJHENFIDEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string AFDNIPHJHMO, [Optional] UnityEngine.Object HFJHENFIDEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7FD0", Offset = "0x8AE73D0", VA = "0x188AE7FD0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BJABONCGBCE
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class LLIJIIJBEKD : LLFNGCOOPGE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB70", Offset = "0xA7DF70", VA = "0x180A7EB70", Slot = "4")]
		public Vector3 GFEBPILLHGG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA7EB70", Offset = "0xA7DF70", VA = "0x180A7EB70", Slot = "5")]
		public Vector3 EOEFKHCGNPP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "6")]
		public bool LPFDPFFEEAK(float DKICOKAOCCL, float AEGKBKICDDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LLIJIIJBEKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static LLFNGCOOPGE KCCLODCAOAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8AD2050", Offset = "0x8AD1450", VA = "0x188AD2050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DPNLCKOHKCE
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode FDGANLMDOKB
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
	void PFPNBAHGKKL();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GCAINLJBCAH(bool MLGIMEMLELE);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HFHPBDEEEIF(bool MLGIMEMLELE);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CNKCBDNCOIH(Rigidbody DGOBDNAOFBB);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ELNPMFAIDPO(Vector3 NLDMHMFAEEN, [Out] RaycastHit EACMJKDJDDD, float ICEDCEOLBDI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PKNHEFDICDP : IDisposable, INHLNNHCEPE
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	LDGMPMKAKEN FBMLKEHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<IEEJIDPBMPL, IEEJIDPBMPL> MDCACKDOAIF;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PFPNBAHGKKL();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface ALADMNPDLLG
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JJDIMONCJFK MOMAFKJAFLP(ANFFNMLLNBD FCHDCHMAIKA);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CGJJNKBKOOE INEJGFPMPHH(ANFFNMLLNBD FCHDCHMAIKA);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDNMFGCJMEC MBJCKDMKCAM(ANFFNMLLNBD FCHDCHMAIKA);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ALLBJOKKIBJ LAAKOBGNJPF(ANFFNMLLNBD FCHDCHMAIKA);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NOCDGEAGHGP PGPFDHLLMPD(ANFFNMLLNBD FCHDCHMAIKA);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PKNHEFDICDP OMLOCDLDCHG(ANFFNMLLNBD FCHDCHMAIKA);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OFAJGOCKOIF EHCNEPNHLKO(ANFFNMLLNBD FCHDCHMAIKA);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ENHBBKNCELK KNNFCDGHLHM(ANFFNMLLNBD FCHDCHMAIKA);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DPNLCKOHKCE HFMKGHFGJGB(ANFFNMLLNBD FCHDCHMAIKA);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CFBPHOJIFDC CLDHAOBNOHN(ANFFNMLLNBD FCHDCHMAIKA);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LLGCHGOKKLD JCIEHDIEEIB(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	JADJEDPLHLB PAMJLKJOIML(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LECIONDANLL JGFGNPNFDIO(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	APEPAHBNFKB PCOAMLBEDOI(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OIAAAPKLFDB MEOBKOFOBEC(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ANFFNMLLNBD AJJBALBLDHA(RigidbodyEx PAIBDGNODBA, KPDFEHPKBMM NGIAGNLBILI, COCGKILJEEG JPGAFCLKGNM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ENHBBKNCELK
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALKPCGBNCBJ(Vector3 KBIBIFOFAKG, ForceMode MIGBGLJJIBM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBFECIAIEKD(Vector3 KBIBIFOFAKG, Vector3 LBCFHLNAPLC, ForceMode MIGBGLJJIBM);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GOPABEPLFHG(Vector3 BJPPJIIAPFL, ForceMode MIGBGLJJIBM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MLNBEBIEEOK(Vector3 BJPPJIIAPFL, ForceMode MIGBGLJJIBM = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CFBPHOJIFDC
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool IJMGAJGOEOJ
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
	void CNKCBDNCOIH(Rigidbody DGOBDNAOFBB);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AHADBFIGHGD(Rigidbody DGOBDNAOFBB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JJDIMONCJFK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<ANFFNMLLNBD> KJIFEPKKFHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ANFFNMLLNBD NDDFGLPMAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	ANFFNMLLNBD BIMLAPPNEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event CIOBHEEBBCO KMKICDNANGK;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event CIOBHEEBBCO DLLONEOIIFN;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event MBOJNAFHAKB MPECPIOGIDN;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action IDDGBHOGHGM;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action KCBIKKFKLNI;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<ANFFNMLLNBD> GJABMDAICJK;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<ANFFNMLLNBD> BDAPBPCFLPL;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action LMNJGOBHDPF;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<ANFFNMLLNBD> IMPKAOIPNPA;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PPKDCGAIMAJ(ANFFNMLLNBD LPICKFBBMGL, bool FLJJABAPNLC = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IDNMFGCJMEC
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 OAGNCLJEPLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 IEGOLHEPHID
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMMDNALMKMC(ANFFNMLLNBD JIECBJMGMAC, object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBPOKNHMMAL(object MONGIMOHLAO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface APEPAHBNFKB
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 HDFKHPAMOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 AOACKPCHPOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float IJKIJHPMLJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float CIKHNEOEHHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 KIDPHBFLJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion MFJGOBAIBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event CIOBHEEBBCO ICBDCPLPFEB;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LNIJCCJEKMJ((Quaternion rot, Vector3 moments) AMFBBMEJKPC);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CHBHLGLNPJK();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ENHLDHHICDM();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MIOIMAEDDIO();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CNKCBDNCOIH(Rigidbody DGOBDNAOFBB);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AHADBFIGHGD(Rigidbody DGOBDNAOFBB);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BGNDJKEFEMN();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LECIONDANLL
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFPNBAHGKKL();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNAEOHHGCPM(object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OICHOONHOOO(object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FGPOIFHFGFE(ANFFNMLLNBD PAIBDGNODBA);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CLPDCKCOKIA(ANFFNMLLNBD PAIBDGNODBA);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PGOAOKAIAFL();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OFAJGOCKOIF
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HKJHCJNDBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event CIOBHEEBBCO HAMHFGOADKA;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BLMFBLLAHBD(object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EMMIHPCFILD(object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AFBJHDBFHKA(object MONGIMOHLAO, bool GHMABHCPHDE);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CNKCBDNCOIH(Rigidbody JAFLLGIEKOM);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AHADBFIGHGD(Rigidbody DGOBDNAOFBB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JADJEDPLHLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool LFPFNEMDNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool OLDGACHJNBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event CIOBHEEBBCO NACADNJMMHN;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PFPNBAHGKKL();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EEPCOMMMKNI(ANFFNMLLNBD JIECBJMGMAC);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MLJJCCPBKCD(ANFFNMLLNBD JIECBJMGMAC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface OIAAAPKLFDB
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool LKGHGHPGKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool GNPAJNDHPPN
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints KKEJJCCKHDI
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
	void CNKCBDNCOIH(Rigidbody DGOBDNAOFBB);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AHADBFIGHGD(Rigidbody DGOBDNAOFBB);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ALLBJOKKIBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float KACFOJIAIFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float OMBMPLDENDA
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
	void CNKCBDNCOIH(Rigidbody DGOBDNAOFBB);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AHADBFIGHGD(Rigidbody DGOBDNAOFBB);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface NOCDGEAGHGP
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool CLNPNEOAOAA;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event CIOBHEEBBCO FCAKFDDLEJN;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFPNBAHGKKL();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool COOIHAEOEHK();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PEGHCMBIHKK();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AELDHAAAHGC();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BFOHNGOENJL();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EELMLIMHMBG();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LMCCOBDLDHL(bool BJGCGBLKAFH);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NPIAHGMDHCB();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LLGCHGOKKLD
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody GKLCHHJFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool EAKOFMPDLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PFPNBAHGKKL();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PLDBGMIIOCJ(object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HEBJHCHCMEF(object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AGKEMPIPCMM();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CGJJNKBKOOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	LLFNGCOOPGE MLBJGFMIACD
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	BNNLLMJJDPO JIANNGPCJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 PMMAEKMJMAD
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 DCFGNKAPHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 HCLKOEFECIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 BKDGJEFAIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float ICCECLDBIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool GFOJNPBFEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PFPNBAHGKKL();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ACCJAKAPIPH(object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JLDELFHKIIM(EPFKLCJJAED ABMEPGCCPLP, Vector3 OGPLLELJPBM, float CDDONLBHEGI = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CBCJLHNCKAK(DLGHIGIHDGD JJEMFOJGMKG, Vector3 PEJHAMCEMGO, float LBCMHCOCBKI, float EIHOHPGGLMO = 8f, float CCOOALGJJEJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KPJFGOHALMI(EPFKLCJJAED ABMEPGCCPLP, Vector3 EMLGDFFEJED, float MCLHJJMOIDC = 7f, float NCKPOIOOOGF = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KKABJONKKLB();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FCDBAFEMNKF();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MBEICEELOON();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void DGOJJNBLAOE();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CNKCBDNCOIH(Rigidbody DGOBDNAOFBB);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 CCDKCMOKFPN(Vector3 PODFFOEBFLC);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CEKJNBHHIJF(object MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void CJMGIGGKHMA(Vector3 NHCNIILPJKC);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void HKFEKAPGFDA(Vector3 PLHEOKHEDMJ, Vector3 IGINODMGIBP);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void PAPIHDOEIPB(Vector3 PABEIKNKFPG, Vector3 FBIPAGEENGH);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 KAPGKHJAMCO(Vector3 MIAAPPECFHB);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 KCCLBLKIBBD(Vector3 DDEFJFOMGFG);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface KAJOMAMKMPE
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool MIKCPHBKHBH
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIINPGNKCMP(string FKPCAPOIAIK);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HHJDDHBOFDB(RigidbodyEx PAIBDGNODBA, Action ENDEKEOKCCM);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LPDOOAPPEAF OGPIFGAJNIE(int GGNPDJKPPHB);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BHNANGKPOFJ(Vector3 EGOPGCIFLMP, float AIAKBICBFDB, Color IFBOGFLAOGG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface COCGKILJEEG
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	KAJOMAMKMPE JDGMIPEIBAC
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	ALADMNPDLLG LLNENMCGDDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ANFFNMLLNBD AJJBALBLDHA(RigidbodyEx PAIBDGNODBA);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PBLBJBJHCDM : ANFFNMLLNBD, IDisposable, PKDPNMJBNHM
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool BBIDDPGGJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly COCGKILJEEG JPGAFCLKGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal JJDIMONCJFK KBKKNFFIIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal LECIONDANLL JCAGECOGNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal JADJEDPLHLB OCBNGEOHAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal CGJJNKBKOOE PODFFOEBFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal IDNMFGCJMEC KJHBDGOAFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal APEPAHBNFKB KHIIFDFBDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal ALLBJOKKIBJ NIPNNAJPEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal CFBPHOJIFDC IECLIKJPKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal NOCDGEAGHGP PMFCHPFOBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal PKNHEFDICDP AKDPJDIIMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal OFAJGOCKOIF NNFAEAAFNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal ENHBBKNCELK KBIBIFOFAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal OIAAAPKLFDB NIDIFBMPBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal LLGCHGOKKLD DGOBDNAOFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal DPNLCKOHKCE CIOLBKNLNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable BJNFONNHCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool BEAFLOGGBAO;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public NAIIODHHNBF CABGCDLEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "22")]
		get
		{
			return default(NAIIODHHNBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public HHMPDIJPAEB LAHHNIHOPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xB1F0B0", Offset = "0xB1E4B0", VA = "0x180B1F0B0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xB1F110", Offset = "0xB1E510", VA = "0x180B1F110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject KBGJEENOIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA76C50", Offset = "0xA76050", VA = "0x180A76C50", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA76BE0", Offset = "0xA75FE0", VA = "0x180A76BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform MDOMHAEDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xB1ED30", Offset = "0xB1E130", VA = "0x180B1ED30", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xB1F130", Offset = "0xB1E530", VA = "0x180B1F130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody GKLCHHJFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6380", Offset = "0x8AE5780", VA = "0x188AE6380", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public ANFFNMLLNBD BIMLAPPNEIO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6250", Offset = "0x8AE5650", VA = "0x188AE6250", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8AE28E0", Offset = "0x8AE1CE0", VA = "0x188AE28E0", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int KMJPCKADHMA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8AE40C0", Offset = "0x8AE34C0", VA = "0x188AE40C0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public ANFFNMLLNBD NDDFGLPMAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3470", Offset = "0x8AE2870", VA = "0x188AE3470", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool NHNICGNNADL
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3270", Offset = "0x8AE2670", VA = "0x188AE3270", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool LFPFNEMDNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2410", Offset = "0x8AE1810", VA = "0x188AE2410", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool OLDGACHJNBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1B90", Offset = "0x8AE0F90", VA = "0x188AE1B90", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public LLFNGCOOPGE MLBJGFMIACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2CF0", Offset = "0x8AE20F0", VA = "0x188AE2CF0", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5A60", Offset = "0x8AE4E60", VA = "0x188AE5A60", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public BNNLLMJJDPO JIANNGPCJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6200", Offset = "0x8AE5600", VA = "0x188AE6200", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1590", Offset = "0x8AE0990", VA = "0x188AE1590", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float ICCECLDBIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6ED0", Offset = "0x8AE62D0", VA = "0x188AE6ED0", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3BC0", Offset = "0x8AE2FC0", VA = "0x188AE3BC0", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 DCFGNKAPHPB
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5F70", Offset = "0x8AE5370", VA = "0x188AE5F70", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7130", Offset = "0x8AE6530", VA = "0x188AE7130", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 BKDGJEFAIOP
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE30E0", Offset = "0x8AE24E0", VA = "0x188AE30E0", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5E90", Offset = "0x8AE5290", VA = "0x188AE5E90", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 PMMAEKMJMAD
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8AE38A0", Offset = "0x8AE2CA0", VA = "0x188AE38A0", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8AE34C0", Offset = "0x8AE28C0", VA = "0x188AE34C0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 HCLKOEFECIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8AE11A0", Offset = "0x8AE05A0", VA = "0x188AE11A0", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8AE44C0", Offset = "0x8AE38C0", VA = "0x188AE44C0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool FPCMCBBMDOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2DA0", Offset = "0x8AE21A0", VA = "0x188AE2DA0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool MCFLDOOEFGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4E60", Offset = "0x8AE4260", VA = "0x188AE4E60", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool ELIKEPNCGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8AE63D0", Offset = "0x8AE57D0", VA = "0x188AE63D0", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool GFOJNPBFEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8AE26E0", Offset = "0x8AE1AE0", VA = "0x188AE26E0", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 OAGNCLJEPLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5B50", Offset = "0x8AE4F50", VA = "0x188AE5B50", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 IEGOLHEPHID
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2330", Offset = "0x8AE1730", VA = "0x188AE2330", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 HDFKHPAMOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4370", Offset = "0x8AE3770", VA = "0x188AE4370", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2A90", Offset = "0x8AE1E90", VA = "0x188AE2A90", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 AOACKPCHPOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1EA0", Offset = "0x8AE12A0", VA = "0x188AE1EA0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float IJKIJHPMLJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2A40", Offset = "0x8AE1E40", VA = "0x188AE2A40", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float CIKHNEOEHHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2690", Offset = "0x8AE1A90", VA = "0x188AE2690", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1FD0", Offset = "0x8AE13D0", VA = "0x188AE1FD0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 KIDPHBFLJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8AE62A0", Offset = "0x8AE56A0", VA = "0x188AE62A0", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion MFJGOBAIBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8AE64B0", Offset = "0x8AE58B0", VA = "0x188AE64B0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float KACFOJIAIFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8AE46F0", Offset = "0x8AE3AF0", VA = "0x188AE46F0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8AE73A0", Offset = "0x8AE67A0", VA = "0x188AE73A0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float OMBMPLDENDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8AE31C0", Offset = "0x8AE25C0", VA = "0x188AE31C0", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8AE53B0", Offset = "0x8AE47B0", VA = "0x188AE53B0", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool IJMGAJGOEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7350", Offset = "0x8AE6750", VA = "0x188AE7350", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3C20", Offset = "0x8AE3020", VA = "0x188AE3C20", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public LDGMPMKAKEN FBMLKEHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1F80", Offset = "0x8AE1380", VA = "0x188AE1F80", Slot = "70")]
		get
		{
			return default(LDGMPMKAKEN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4880", Offset = "0x8AE3C80", VA = "0x188AE4880", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool HKJHCJNDBLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5E40", Offset = "0x8AE5240", VA = "0x188AE5E40", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform GFKDPMFHONJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xB1ED30", Offset = "0xB1E130", VA = "0x180B1ED30", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 MFPBOIJJBPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6A60", Offset = "0x8AE5E60", VA = "0x188AE6A60", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1380", Offset = "0x8AE0780", VA = "0x188AE1380", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float KDBDCMOKGLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5C20", Offset = "0x8AE5020", VA = "0x188AE5C20", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3050", Offset = "0x8AE2450", VA = "0x188AE3050", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float MJGMGCOGIGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8AE53A0", Offset = "0x8AE47A0", VA = "0x188AE53A0", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8AE50B0", Offset = "0x8AE44B0", VA = "0x188AE50B0", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion DOALJHOHDAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6580", Offset = "0x8AE5980", VA = "0x188AE6580", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4740", Offset = "0x8AE3B40", VA = "0x188AE4740", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 CGGNGHCCNLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8AE49E0", Offset = "0x8AE3DE0", VA = "0x188AE49E0", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4F60", Offset = "0x8AE4360", VA = "0x188AE4F60", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion BNPIKAOEGBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4EC0", Offset = "0x8AE42C0", VA = "0x188AE4EC0", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6900", Offset = "0x8AE5D00", VA = "0x188AE6900", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints KKEJJCCKHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2E50", Offset = "0x8AE2250", VA = "0x188AE2E50", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1BE0", Offset = "0x8AE0FE0", VA = "0x188AE1BE0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool LKGHGHPGKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2CA0", Offset = "0x8AE20A0", VA = "0x188AE2CA0", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4820", Offset = "0x8AE3C20", VA = "0x188AE4820", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode FDGANLMDOKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2940", Offset = "0x8AE1D40", VA = "0x188AE2940", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2DF0", Offset = "0x8AE21F0", VA = "0x188AE2DF0", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool JGJBIJJGLPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4130", Offset = "0x8AE3530", VA = "0x188AE4130", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool BEHIPMAANFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8AE39E0", Offset = "0x8AE2DE0", VA = "0x188AE39E0", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event CIOBHEEBBCO KMKICDNANGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2D40", Offset = "0x8AE2140", VA = "0x188AE2D40", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8AE68A0", Offset = "0x8AE5CA0", VA = "0x188AE68A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event CIOBHEEBBCO DLLONEOIIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4F00", Offset = "0x8AE4300", VA = "0x188AE4F00", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8AE3210", Offset = "0x8AE2610", VA = "0x188AE3210", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event MBOJNAFHAKB MPECPIOGIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4CA0", Offset = "0x8AE40A0", VA = "0x188AE4CA0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8AE70D0", Offset = "0x8AE64D0", VA = "0x188AE70D0", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event CIOBHEEBBCO NACADNJMMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6A00", Offset = "0x8AE5E00", VA = "0x188AE6A00", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8AE22D0", Offset = "0x8AE16D0", VA = "0x188AE22D0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event CIOBHEEBBCO EIMNEJBGAEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8AE16B0", Offset = "0x8AE0AB0", VA = "0x188AE16B0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8AE29E0", Offset = "0x8AE1DE0", VA = "0x188AE29E0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event CIOBHEEBBCO FCAKFDDLEJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7450", Offset = "0x8AE6850", VA = "0x188AE7450", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2270", Offset = "0x8AE1670", VA = "0x188AE2270", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<IEEJIDPBMPL, IEEJIDPBMPL> MDCACKDOAIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5D90", Offset = "0x8AE5190", VA = "0x188AE5D90", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8AE2130", Offset = "0x8AE1530", VA = "0x188AE2130", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event CIOBHEEBBCO HAMHFGOADKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8AE69A0", Offset = "0x8AE5DA0", VA = "0x188AE69A0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8AE6F20", Offset = "0x8AE6320", VA = "0x188AE6F20", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event CIOBHEEBBCO FHJBMOPMOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8AE1430", Offset = "0x8AE0830", VA = "0x188AE1430", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4D00", Offset = "0x8AE4100", VA = "0x188AE4D00", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8AE77C0", Offset = "0x8AE6BC0", VA = "0x188AE77C0")]
	public PBLBJBJHCDM(GameObject JBJNKCGNJKP, RigidbodyEx HIJGLGEOKHK, COCGKILJEEG JPGAFCLKGNM, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8AE5690", Offset = "0x8AE4A90", VA = "0x188AE5690", Slot = "139")]
	protected virtual void LMMNFPCAJMG(COCGKILJEEG JPGAFCLKGNM, KPDFEHPKBMM NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8AE2460", Offset = "0x8AE1860", VA = "0x188AE2460", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8AE7210", Offset = "0x8AE6610", VA = "0x188AE7210", Slot = "93")]
	public void PFPNBAHGKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8AE21E0", Offset = "0x8AE15E0", VA = "0x188AE21E0", Slot = "94")]
	public void DHKJLAFONKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x8AE3980", Offset = "0x8AE2D80", VA = "0x188AE3980", Slot = "95")]
	public void IBPAEEDCKLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x8AE1280", Offset = "0x8AE0680", VA = "0x188AE1280", Slot = "96")]
	public void AKLLODDLMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8AE5410", Offset = "0x8AE4810", VA = "0x188AE5410")]
	private void LMCCOBDLDHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8AE4C20", Offset = "0x8AE4020", VA = "0x188AE4C20")]
	private void KDPKKMGLFPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8AE2560", Offset = "0x8AE1960", VA = "0x188AE2560")]
	private void EELMLIMHMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8AE1060", Offset = "0x8AE0460", VA = "0x188AE1060", Slot = "30")]
	public ANFFNMLLNBD ABHJEFONKKD(int NOEININIMIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8AE7710", Offset = "0x8AE6B10", VA = "0x188AE7710", Slot = "98")]
	public void PPKDCGAIMAJ(ANFFNMLLNBD CBMEHPPMEEA, bool FLJJABAPNLC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8AE6F80", Offset = "0x8AE6380", VA = "0x188AE6F80", Slot = "99")]
	public void PAOBJJAJAEB(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8AE4E00", Offset = "0x8AE4200", VA = "0x188AE4E00", Slot = "100")]
	public void KLEODOBJDCF(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8AE4B20", Offset = "0x8AE3F20", VA = "0x188AE4B20", Slot = "101")]
	public Vector3 KCCLBLKIBBD(Vector3 DDEFJFOMGFG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8AE4A20", Offset = "0x8AE3E20", VA = "0x188AE4A20", Slot = "102")]
	public Vector3 KAPGKHJAMCO(Vector3 MIAAPPECFHB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8AE2190", Offset = "0x8AE1590", VA = "0x188AE2190", Slot = "103")]
	public void DGOJJNBLAOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8AE2990", Offset = "0x8AE1D90", VA = "0x188AE2990", Slot = "104")]
	public void FCDBAFEMNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8AE4DB0", Offset = "0x8AE41B0", VA = "0x188AE4DB0", Slot = "105")]
	public void KKABJONKKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x8AE6FE0", Offset = "0x8AE63E0", VA = "0x188AE6FE0", Slot = "106")]
	public void PAPIHDOEIPB(Vector3 PABEIKNKFPG, Vector3 FBIPAGEENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8AE35A0", Offset = "0x8AE29A0", VA = "0x188AE35A0", Slot = "107")]
	public void HKFEKAPGFDA(Vector3 PLHEOKHEDMJ, Vector3 IGINODMGIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x8AE1DC0", Offset = "0x8AE11C0", VA = "0x188AE1DC0", Slot = "108")]
	public void CJMGIGGKHMA(Vector3 NHCNIILPJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8AE15F0", Offset = "0x8AE09F0", VA = "0x188AE15F0", Slot = "109")]
	public void CBCJLHNCKAK(DLGHIGIHDGD JJEMFOJGMKG, Vector3 PEJHAMCEMGO, float LBCMHCOCBKI, float EIHOHPGGLMO = 8f, float CCOOALGJJEJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8AE48E0", Offset = "0x8AE3CE0", VA = "0x188AE48E0", Slot = "110")]
	public void JLDELFHKIIM(EPFKLCJJAED ABMEPGCCPLP, Vector3 OGPLLELJPBM, float CDDONLBHEGI = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8AE4FA0", Offset = "0x8AE43A0", VA = "0x188AE4FA0", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void KPJFGOHALMI(EPFKLCJJAED ABMEPGCCPLP, Vector3 EMLGDFFEJED, float MCLHJJMOIDC = 7f, float NCKPOIOOOGF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8AE1710", Offset = "0x8AE0B10", VA = "0x188AE1710", Slot = "112")]
	public Vector3 CCDKCMOKFPN(Vector3 CBMEHPPMEEA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x8AE4270", Offset = "0x8AE3670", VA = "0x188AE4270", Slot = "113")]
	public Vector3 IOPOEGOFCMI(Vector3 CBMEHPPMEEA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x8AE5C30", Offset = "0x8AE5030", VA = "0x188AE5C30", Slot = "114")]
	public void MBEICEELOON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8AE4450", Offset = "0x8AE3850", VA = "0x188AE4450", Slot = "115")]
	public void JAFBLENMJGF(ANFFNMLLNBD HAMLJAHLKDM, object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8AE6E70", Offset = "0x8AE6270", VA = "0x188AE6E70", Slot = "116")]
	public void OOLJOCJMIDC(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8AE5980", Offset = "0x8AE4D80", VA = "0x188AE5980", Slot = "63")]
	public void LNIJCCJEKMJ((Quaternion rot, Vector3 moments) AMFBBMEJKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x8AE2890", Offset = "0x8AE1C90", VA = "0x188AE2890", Slot = "117")]
	public void ENHLDHHICDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8AE1D70", Offset = "0x8AE1170", VA = "0x188AE1D70", Slot = "118")]
	public void CHBHLGLNPJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8AE5DF0", Offset = "0x8AE51F0", VA = "0x188AE5DF0", Slot = "119")]
	public void MIOIMAEDDIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8AE2030", Offset = "0x8AE1430", VA = "0x188AE2030", Slot = "120")]
	public bool COOIHAEOEHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8AE10E0", Offset = "0x8AE04E0", VA = "0x188AE10E0", Slot = "97")]
	public void AELDHAAAHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8AE6930", Offset = "0x8AE5D30", VA = "0x188AE6930", Slot = "121")]
	public void NPIAHGMDHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8AE1530", Offset = "0x8AE0930", VA = "0x188AE1530", Slot = "122")]
	public void BLMFBLLAHBD(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8AE2830", Offset = "0x8AE1C30", VA = "0x188AE2830", Slot = "123")]
	public void EMMIHPCFILD(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x8AE1130", Offset = "0x8AE0530", VA = "0x188AE1130", Slot = "124")]
	public void AFBJHDBFHKA(object MONGIMOHLAO, bool GHMABHCPHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x8AE7510", Offset = "0x8AE6910", VA = "0x188AE7510", Slot = "125")]
	public void PNHKMKPKMHB(Vector3 LKOMPDMLLGJ, Quaternion MONBLLPGNBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8AE2B70", Offset = "0x8AE1F70", VA = "0x188AE2B70", Slot = "126")]
	public void FFMIKBMNCFN(Vector3 NLDEGBJACOA, Quaternion OAEOLICGPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8AE7400", Offset = "0x8AE6800", VA = "0x188AE7400", Slot = "127")]
	public bool PJJEEKPMEKJ(float ECDGIBOACGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x8AE33B0", Offset = "0x8AE27B0", VA = "0x188AE33B0", Slot = "128")]
	public void HCIPJGNLINC(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8AE3B60", Offset = "0x8AE2F60", VA = "0x188AE3B60", Slot = "129")]
	public void ICBGEBNIKAO(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8AE74B0", Offset = "0x8AE68B0", VA = "0x188AE74B0", Slot = "130")]
	public void PLDBGMIIOCJ(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8AE3410", Offset = "0x8AE2810", VA = "0x188AE3410", Slot = "131")]
	public void HEBJHCHCMEF(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8AE12A0", Offset = "0x8AE06A0", VA = "0x188AE12A0", Slot = "132")]
	public void ALKPCGBNCBJ(Vector3 KBIBIFOFAKG, ForceMode MIGBGLJJIBM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8AE5C80", Offset = "0x8AE5080", VA = "0x188AE5C80", Slot = "133")]
	public void MBFECIAIEKD(Vector3 KBIBIFOFAKG, Vector3 LBCFHLNAPLC, ForceMode MIGBGLJJIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8AE32D0", Offset = "0x8AE26D0", VA = "0x188AE32D0", Slot = "134")]
	public void GOPABEPLFHG(Vector3 BJPPJIIAPFL, ForceMode MIGBGLJJIBM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8AE6120", Offset = "0x8AE5520", VA = "0x188AE6120", Slot = "135")]
	public void MLNBEBIEEOK(Vector3 BJPPJIIAPFL, ForceMode MIGBGLJJIBM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8AE2730", Offset = "0x8AE1B30", VA = "0x188AE2730", Slot = "136")]
	public bool ELNPMFAIDPO(Vector3 NLDMHMFAEEN, [Out] RaycastHit EACMJKDJDDD, float ICEDCEOLBDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8AE14E0", Offset = "0x8AE08E0", VA = "0x188AE14E0", Slot = "137")]
	public void BGNDJKEFEMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8AE7780", Offset = "0x8AE6B80", VA = "0x188AE7780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8AE3690", Offset = "0x8AE2A90", VA = "0x188AE3690")]
	private void HPDNFMDIJIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8AE6620", Offset = "0x8AE5A20", VA = "0x188AE6620")]
	private void NLELKKEEBOM(ANFFNMLLNBD JIECBJMGMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x8AE51B0", Offset = "0x8AE45B0", VA = "0x188AE51B0")]
	private void LFDELDBAKLK(ANFFNMLLNBD JIECBJMGMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8AE2080", Offset = "0x8AE1480", VA = "0x188AE2080")]
	private void COOKCJNOANC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8AE1C40", Offset = "0x8AE1040", VA = "0x188AE1C40")]
	private void CEIDLFEBAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8AE2EA0", Offset = "0x8AE22A0", VA = "0x188AE2EA0")]
	private void GFFBKNEFOLK(ANFFNMLLNBD MODBGDDFPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8AE25C0", Offset = "0x8AE19C0", VA = "0x188AE25C0")]
	private void EEPCOMMMKNI(ANFFNMLLNBD JIECBJMGMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8AE6050", Offset = "0x8AE5450", VA = "0x188AE6050")]
	private void MLJJCCPBKCD(ANFFNMLLNBD JIECBJMGMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8AE45A0", Offset = "0x8AE39A0", VA = "0x188AE45A0")]
	private void JFIHKDOBLPA(HHMPDIJPAEB JIECBJMGMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8AE3C80", Offset = "0x8AE3080", VA = "0x188AE3C80", Slot = "142")]
	protected virtual void IMCGKOEDLMN(HHMPDIJPAEB PAIBDGNODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8AE6B10", Offset = "0x8AE5F10", VA = "0x188AE6B10")]
	protected void ONPGJOHNLEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8AE1810", Offset = "0x8AE0C10", VA = "0x188AE1810")]
	protected void CCEAFLPMPOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8AE3770", Offset = "0x8AE2B70", VA = "0x188AE3770")]
	private void IACMEJCGJHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8AE6730", Offset = "0x8AE5B30", VA = "0x188AE6730")]
	private void NMJNLDPCLDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class MJCCOOGDEPD
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC890", Offset = "0x8ADBC90", VA = "0x188ADC890")]
	public static ANFFNMLLNBD PAMGMMHJFMG(this ANFFNMLLNBD PAIBDGNODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC7F0", Offset = "0x8ADBBF0", VA = "0x188ADC7F0")]
	public static bool LIBJPDIKPLD(this ANFFNMLLNBD PAIBDGNODBA, ANFFNMLLNBD OPLHDHHEBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC6D0", Offset = "0x8ADBAD0", VA = "0x188ADC6D0")]
	public static bool GNJHLOAFPNH(this ANFFNMLLNBD PAIBDGNODBA, ANFFNMLLNBD PDIKGICAEJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC680", Offset = "0x8ADBA80", VA = "0x188ADC680")]
	public static HHMPDIJPAEB EDKMOFKFDNM(this ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC770", Offset = "0x8ADBB70", VA = "0x188ADC770")]
	public static PBLBJBJHCDM LCJHJFJHHAN(this ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MEGFLHJMILJ : ALADMNPDLLG
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC5E0", Offset = "0x8ADB9E0", VA = "0x188ADC5E0", Slot = "19")]
	public ANFFNMLLNBD AJJBALBLDHA(RigidbodyEx PAIBDGNODBA, KPDFEHPKBMM NGIAGNLBILI, COCGKILJEEG JPGAFCLKGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "4")]
	public JJDIMONCJFK MOMAFKJAFLP(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "5")]
	public CGJJNKBKOOE INEJGFPMPHH(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "6")]
	public IDNMFGCJMEC MBJCKDMKCAM(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "7")]
	public ALLBJOKKIBJ LAAKOBGNJPF(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "8")]
	public NOCDGEAGHGP PGPFDHLLMPD(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "9")]
	public PKNHEFDICDP OMLOCDLDCHG(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "10")]
	public OFAJGOCKOIF EHCNEPNHLKO(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "11")]
	public ENHBBKNCELK KNNFCDGHLHM(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "12")]
	public DPNLCKOHKCE HFMKGHFGJGB(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "13")]
	public CFBPHOJIFDC CLDHAOBNOHN(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80")]
	public LLGCHGOKKLD JCIEHDIEEIB(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80")]
	public JADJEDPLHLB PAMJLKJOIML(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80")]
	public LECIONDANLL JGFGNPNFDIO(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80")]
	public APEPAHBNFKB PCOAMLBEDOI(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80")]
	public OIAAAPKLFDB MEOBKOFOBEC(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public MEGFLHJMILJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "14")]
	private LLGCHGOKKLD LLMPIDAFHGC(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "15")]
	private JADJEDPLHLB GHANNAIMPAF(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "16")]
	private LECIONDANLL FOIFPPNNEJD(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "17")]
	private APEPAHBNFKB FKKIEPBNKOG(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "18")]
	private OIAAAPKLFDB EPJJHJFLJLF(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(ALADMNPDLLG), new string[] { })]
public class HOGMJEKGJBJ : ALADMNPDLLG, FMPNPCDDCKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly ALADMNPDLLG GGIINHADJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly ALADMNPDLLG INGBCONOOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private BEPNILIBKJG DGNMEMCDCIJ;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private ALADMNPDLLG LLNENMCGDDM
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5240", Offset = "0x8AD4640", VA = "0x188AD5240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5340", Offset = "0x8AD4740", VA = "0x188AD5340", Slot = "20")]
	public void InitReferences(BBKOKELKFDM HPIMCEEIPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5620", Offset = "0x8AD4A20", VA = "0x188AD5620", Slot = "4")]
	public JJDIMONCJFK MOMAFKJAFLP(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8AD52A0", Offset = "0x8AD46A0", VA = "0x188AD52A0", Slot = "5")]
	public CGJJNKBKOOE INEJGFPMPHH(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5580", Offset = "0x8AD4980", VA = "0x188AD5580", Slot = "6")]
	public IDNMFGCJMEC MBJCKDMKCAM(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8AD54E0", Offset = "0x8AD48E0", VA = "0x188AD54E0", Slot = "7")]
	public ALLBJOKKIBJ LAAKOBGNJPF(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5760", Offset = "0x8AD4B60", VA = "0x188AD5760", Slot = "8")]
	public NOCDGEAGHGP PGPFDHLLMPD(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8AD56C0", Offset = "0x8AD4AC0", VA = "0x188AD56C0", Slot = "9")]
	public PKNHEFDICDP OMLOCDLDCHG(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4E40", Offset = "0x8AD4240", VA = "0x188AD4E40", Slot = "10")]
	public OFAJGOCKOIF EHCNEPNHLKO(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5440", Offset = "0x8AD4840", VA = "0x188AD5440", Slot = "11")]
	public ENHBBKNCELK KNNFCDGHLHM(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8AD51A0", Offset = "0x8AD45A0", VA = "0x188AD51A0", Slot = "12")]
	public DPNLCKOHKCE HFMKGHFGJGB(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4DA0", Offset = "0x8AD41A0", VA = "0x188AD4DA0", Slot = "13")]
	public CFBPHOJIFDC CLDHAOBNOHN(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5390", Offset = "0x8AD4790", VA = "0x188AD5390")]
	public LLGCHGOKKLD JCIEHDIEEIB(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8AD50F0", Offset = "0x8AD44F0", VA = "0x188AD50F0")]
	public JADJEDPLHLB PAMJLKJOIML(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5040", Offset = "0x8AD4440", VA = "0x188AD5040")]
	public LECIONDANLL JGFGNPNFDIO(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4F90", Offset = "0x8AD4390", VA = "0x188AD4F90")]
	public APEPAHBNFKB PCOAMLBEDOI(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4EE0", Offset = "0x8AD42E0", VA = "0x188AD4EE0")]
	public OIAAAPKLFDB MEOBKOFOBEC(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4C50", Offset = "0x8AD4050", VA = "0x188AD4C50", Slot = "19")]
	public ANFFNMLLNBD AJJBALBLDHA(RigidbodyEx PAIBDGNODBA, KPDFEHPKBMM NGIAGNLBILI, COCGKILJEEG JPGAFCLKGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5800", Offset = "0x8AD4C00", VA = "0x188AD5800")]
	public HOGMJEKGJBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5390", Offset = "0x8AD4790", VA = "0x188AD5390", Slot = "14")]
	private LLGCHGOKKLD LLMPIDAFHGC(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8AD50F0", Offset = "0x8AD44F0", VA = "0x188AD50F0", Slot = "15")]
	private JADJEDPLHLB GHANNAIMPAF(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5040", Offset = "0x8AD4440", VA = "0x188AD5040", Slot = "16")]
	private LECIONDANLL FOIFPPNNEJD(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4F90", Offset = "0x8AD4390", VA = "0x188AD4F90", Slot = "17")]
	private APEPAHBNFKB FKKIEPBNKOG(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4EE0", Offset = "0x8AD42E0", VA = "0x188AD4EE0", Slot = "18")]
	private OIAAAPKLFDB EPJJHJFLJLF(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface ALOEMLAEPIB : JJDIMONCJFK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLKFHPNBABH(ANFFNMLLNBD PAIBDGNODBA);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IAOMNBKJBHP(ANFFNMLLNBD PAIBDGNODBA);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NOOFMPECOEG(ANFFNMLLNBD MODBGDDFPPH);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EKCKNJPDFNN(ANFFNMLLNBD MODBGDDFPPH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JHKFGMKJICA : IDNMFGCJMEC
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	BIMJFEECNNG<ANFFNMLLNBD> ABIGJMGGJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	ANFFNMLLNBD LNFPLNGKAPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface PDNPAHIHKJD : APEPAHBNFKB
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) LHGKFDEJDFB(Rigidbody OAOADCODLNM);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface BLEHNHDNKJN : JADJEDPLHLB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	RRNetworkView IAFHLIIKKHK
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class MBHDJKFABAK : DPNLCKOHKCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly PBLBJBJHCDM PAIBDGNODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode PDOCODNNFDM;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody GKLCHHJFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3AF0", Offset = "0x8AD2EF0", VA = "0x188AD3AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode FDGANLMDOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC330", Offset = "0x8ADB730", VA = "0x188ADC330", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC440", Offset = "0x8ADB840", VA = "0x188ADC440", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x8AD3DA0", Offset = "0x8AD31A0", VA = "0x188AD3DA0")]
	public MBHDJKFABAK(ANFFNMLLNBD PAIBDGNODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC4D0", Offset = "0x8ADB8D0", VA = "0x188ADC4D0", Slot = "6")]
	public void PFPNBAHGKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC150", Offset = "0x8ADB550", VA = "0x188ADC150", Slot = "9")]
	public void CNKCBDNCOIH(Rigidbody DGOBDNAOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC4B0", Offset = "0x8ADB8B0", VA = "0x188ADC4B0", Slot = "7")]
	public void GCAINLJBCAH(bool MLGIMEMLELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC4C0", Offset = "0x8ADB8C0", VA = "0x188ADC4C0", Slot = "8")]
	public void HFHPBDEEEIF(bool MLGIMEMLELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC1D0", Offset = "0x8ADB5D0", VA = "0x188ADC1D0", Slot = "10")]
	public bool ELNPMFAIDPO(Vector3 NLDMHMFAEEN, [Out] RaycastHit EACMJKDJDDD, float ICEDCEOLBDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC030", Offset = "0x8ADB430", VA = "0x188ADC030")]
	private void AMLFEIKCHOA(bool MLGIMEMLELE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class CDBJENBAOGI : PKNHEFDICDP, IDisposable, INHLNNHCEPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly PBLBJBJHCDM PAIBDGNODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private LDGMPMKAKEN DJKOHLBFNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private LPDOOAPPEAF DJAFMEJKJGE;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public LDGMPMKAKEN FBMLKEHDEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8AD2120", Offset = "0x8AD1520", VA = "0x188AD2120", Slot = "6")]
		get
		{
			return default(LDGMPMKAKEN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8AD2370", Offset = "0x8AD1770", VA = "0x188AD2370", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform IKHEAAPPIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xE0BB20", Offset = "0xE0AF20", VA = "0x180E0BB20", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<IEEJIDPBMPL, IEEJIDPBMPL> MDCACKDOAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8AD2440", Offset = "0x8AD1840", VA = "0x188AD2440", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8AD2270", Offset = "0x8AD1670", VA = "0x188AD2270", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x8AD2760", Offset = "0x8AD1B60", VA = "0x188AD2760")]
	public CDBJENBAOGI(ANFFNMLLNBD PAIBDGNODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x8AD24F0", Offset = "0x8AD18F0", VA = "0x188AD24F0", Slot = "8")]
	public void PFPNBAHGKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x8AD2320", Offset = "0x8AD1720", VA = "0x188AD2320", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1310C70", Offset = "0x1310070", VA = "0x181310C70", Slot = "11")]
	private void LNCNCLGCDNF(IEEJIDPBMPL CNIHMDOKJPK, IEEJIDPBMPL LPBMCEDKMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "12")]
	private void NGNOCIOOJFO(bool NKIKDGHHLIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class IBLDDBGEBNG : ALADMNPDLLG
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8570", Offset = "0x8AD7970", VA = "0x188AD8570", Slot = "4")]
	public JJDIMONCJFK MOMAFKJAFLP(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8090", Offset = "0x8AD7490", VA = "0x188AD8090", Slot = "5")]
	public CGJJNKBKOOE INEJGFPMPHH(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8440", Offset = "0x8AD7840", VA = "0x188AD8440", Slot = "6")]
	public IDNMFGCJMEC MBJCKDMKCAM(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x8AD83C0", Offset = "0x8AD77C0", VA = "0x188AD83C0", Slot = "7")]
	public ALLBJOKKIBJ LAAKOBGNJPF(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8730", Offset = "0x8AD7B30", VA = "0x188AD8730", Slot = "8")]
	public NOCDGEAGHGP PGPFDHLLMPD(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8660", Offset = "0x8AD7A60", VA = "0x188AD8660", Slot = "9")]
	public PKNHEFDICDP OMLOCDLDCHG(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7970", Offset = "0x8AD6D70", VA = "0x188AD7970", Slot = "10")]
	public OFAJGOCKOIF EHCNEPNHLKO(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8300", Offset = "0x8AD7700", VA = "0x188AD8300", Slot = "11")]
	public ENHBBKNCELK KNNFCDGHLHM(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7FD0", Offset = "0x8AD73D0", VA = "0x188AD7FD0", Slot = "12")]
	public DPNLCKOHKCE HFMKGHFGJGB(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8AD78B0", Offset = "0x8AD6CB0", VA = "0x188AD78B0", Slot = "13")]
	public CFBPHOJIFDC CLDHAOBNOHN(ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8AD81C0", Offset = "0x8AD75C0", VA = "0x188AD81C0")]
	public LLGCHGOKKLD JCIEHDIEEIB(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7E40", Offset = "0x8AD7240", VA = "0x188AD7E40")]
	public JADJEDPLHLB PAMJLKJOIML(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7D10", Offset = "0x8AD7110", VA = "0x188AD7D10")]
	public LECIONDANLL JGFGNPNFDIO(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7B70", Offset = "0x8AD6F70", VA = "0x188AD7B70")]
	public APEPAHBNFKB PCOAMLBEDOI(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7A90", Offset = "0x8AD6E90", VA = "0x188AD7A90")]
	public OIAAAPKLFDB MEOBKOFOBEC(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7760", Offset = "0x8AD6B60", VA = "0x188AD7760", Slot = "19")]
	public ANFFNMLLNBD AJJBALBLDHA(RigidbodyEx PAIBDGNODBA, KPDFEHPKBMM NGIAGNLBILI, COCGKILJEEG JPGAFCLKGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public IBLDDBGEBNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8AD81C0", Offset = "0x8AD75C0", VA = "0x188AD81C0", Slot = "14")]
	private LLGCHGOKKLD LLMPIDAFHGC(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7E40", Offset = "0x8AD7240", VA = "0x188AD7E40", Slot = "15")]
	private JADJEDPLHLB GHANNAIMPAF(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7D10", Offset = "0x8AD7110", VA = "0x188AD7D10", Slot = "16")]
	private LECIONDANLL FOIFPPNNEJD(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7B70", Offset = "0x8AD6F70", VA = "0x188AD7B70", Slot = "17")]
	private APEPAHBNFKB FKKIEPBNKOG(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7A90", Offset = "0x8AD6E90", VA = "0x188AD7A90", Slot = "18")]
	private OIAAAPKLFDB EPJJHJFLJLF(ANFFNMLLNBD FCHDCHMAIKA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class ECNCBEDPLOF : ENHBBKNCELK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly PBLBJBJHCDM PAIBDGNODBA;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody GKLCHHJFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3AF0", Offset = "0x8AD2EF0", VA = "0x188AD3AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool HKJHCJNDBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8AD37E0", Offset = "0x8AD2BE0", VA = "0x188AD37E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool NHNICGNNADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8AD33A0", Offset = "0x8AD27A0", VA = "0x188AD33A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private ANFFNMLLNBD BIMLAPPNEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3A90", Offset = "0x8AD2E90", VA = "0x188AD3A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8AD3DA0", Offset = "0x8AD31A0", VA = "0x188AD3DA0")]
	public ECNCBEDPLOF(ANFFNMLLNBD PAIBDGNODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8AD2FE0", Offset = "0x8AD23E0", VA = "0x188AD2FE0", Slot = "4")]
	public void ALKPCGBNCBJ(Vector3 KBIBIFOFAKG, ForceMode MIGBGLJJIBM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8AD3140", Offset = "0x8AD2540", VA = "0x188AD3140")]
	private void DEFHAICKENN(Vector3 KBIBIFOFAKG, ForceMode MIGBGLJJIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x8AD3560", Offset = "0x8AD2960", VA = "0x188AD3560", Slot = "5")]
	public void MBFECIAIEKD(Vector3 KBIBIFOFAKG, Vector3 LBCFHLNAPLC, ForceMode MIGBGLJJIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x8AD3400", Offset = "0x8AD2800", VA = "0x188AD3400", Slot = "6")]
	public void GOPABEPLFHG(Vector3 BJPPJIIAPFL, ForceMode MIGBGLJJIBM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8AD3B40", Offset = "0x8AD2F40", VA = "0x188AD3B40")]
	private void PEEFOPFNHAA(Vector3 BJPPJIIAPFL, ForceMode MIGBGLJJIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x8AD3830", Offset = "0x8AD2C30", VA = "0x188AD3830", Slot = "7")]
	public void MLNBEBIEEOK(Vector3 BJPPJIIAPFL, ForceMode MIGBGLJJIBM = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class NKEJOGPLOPC : CFBPHOJIFDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PBLBJBJHCDM PAIBDGNODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool HLHGHFPOCHH;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool IJMGAJGOEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xAC6D20", Offset = "0xAC6120", VA = "0x180AC6D20", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8ADC9F0", Offset = "0x8ADBDF0", VA = "0x188ADC9F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x8AD3DA0", Offset = "0x8AD31A0", VA = "0x188AD3DA0")]
	public NKEJOGPLOPC(ANFFNMLLNBD PAIBDGNODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC9C0", Offset = "0x8ADBDC0", VA = "0x188ADC9C0", Slot = "6")]
	public void CNKCBDNCOIH(Rigidbody DGOBDNAOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x8ADC950", Offset = "0x8ADBD50", VA = "0x188ADC950", Slot = "7")]
	public void AHADBFIGHGD(Rigidbody DGOBDNAOFBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class HOIOMLGLGOK : ALOEMLAEPIB, JJDIMONCJFK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly ANFFNMLLNBD PAIBDGNODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<ANFFNMLLNBD> OPJOODAPIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private ANFFNMLLNBD LDEPDDDHLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private ANFFNMLLNBD JIECBJMGMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform CDOHKFPBAEC;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform MDOMHAEDEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5C20", Offset = "0x8AD5020", VA = "0x188AD5C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public ANFFNMLLNBD BIMLAPPNEIO
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA703E0", Offset = "0xA6F7E0", VA = "0x180A703E0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6040", Offset = "0x8AD5440", VA = "0x188AD6040", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public ANFFNMLLNBD NDDFGLPMAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA70440", Offset = "0xA6F840", VA = "0x180A70440", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<ANFFNMLLNBD> KJIFEPKKFHM
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA74030", Offset = "0xA73430", VA = "0x180A74030", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event CIOBHEEBBCO KMKICDNANGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6100", Offset = "0x8AD5500", VA = "0x188AD6100", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6CC0", Offset = "0x8AD60C0", VA = "0x188AD6CC0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event CIOBHEEBBCO DLLONEOIIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8AD68B0", Offset = "0x8AD5CB0", VA = "0x188AD68B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6250", Offset = "0x8AD5650", VA = "0x188AD6250", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event MBOJNAFHAKB MPECPIOGIDN
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6810", Offset = "0x8AD5C10", VA = "0x188AD6810", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD7080", Offset = "0x8AD6480", VA = "0x188AD7080", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action IDDGBHOGHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5FA0", Offset = "0x8AD53A0", VA = "0x188AD5FA0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6770", Offset = "0x8AD5B70", VA = "0x188AD6770", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action KCBIKKFKLNI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5A20", Offset = "0x8AD4E20", VA = "0x188AD5A20", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5B80", Offset = "0x8AD4F80", VA = "0x188AD5B80", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<ANFFNMLLNBD> GJABMDAICJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6FD0", Offset = "0x8AD63D0", VA = "0x188AD6FD0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6050", Offset = "0x8AD5450", VA = "0x188AD6050", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<ANFFNMLLNBD> BDAPBPCFLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8AD61A0", Offset = "0x8AD55A0", VA = "0x188AD61A0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8AD64E0", Offset = "0x8AD58E0", VA = "0x188AD64E0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action LMNJGOBHDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6B30", Offset = "0x8AD5F30", VA = "0x188AD6B30", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8AD62F0", Offset = "0x8AD56F0", VA = "0x188AD62F0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<ANFFNMLLNBD> IMPKAOIPNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6950", Offset = "0x8AD5D50", VA = "0x188AD6950", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6390", Offset = "0x8AD5790", VA = "0x188AD6390", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x8AD76A0", Offset = "0x8AD6AA0", VA = "0x188AD76A0")]
	public HOIOMLGLGOK(ANFFNMLLNBD PAIBDGNODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5C80", Offset = "0x8AD5080", VA = "0x188AD5C80", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x8AD7120", Offset = "0x8AD6520", VA = "0x188AD7120", Slot = "30")]
	public void PPKDCGAIMAJ(ANFFNMLLNBD LPICKFBBMGL, bool FLJJABAPNLC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x8AD6D60", Offset = "0x8AD6160", VA = "0x188AD6D60", Slot = "6")]
	public void NOOFMPECOEG(ANFFNMLLNBD MODBGDDFPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5D20", Offset = "0x8AD5120", VA = "0x188AD5D20", Slot = "7")]
	public void EKCKNJPDFNN(ANFFNMLLNBD MODBGDDFPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8AD6BD0", Offset = "0x8AD5FD0", VA = "0x188AD6BD0", Slot = "4")]
	public void NLKFHPNBABH(ANFFNMLLNBD PAIBDGNODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x8AD6590", Offset = "0x8AD5990", VA = "0x188AD6590", Slot = "5")]
	public void IAOMNBKJBHP(ANFFNMLLNBD PAIBDGNODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x8AD6440", Offset = "0x8AD5840", VA = "0x188AD6440")]
	private void HJOADFFNFNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x8AD58B0", Offset = "0x8AD4CB0", VA = "0x188AD58B0")]
	private void ADMDKEAPAFC(ANFFNMLLNBD MODBGDDFPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x8AD6630", Offset = "0x8AD5A30", VA = "0x188AD6630")]
	private void KAIMCGMJLIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x8AD58F0", Offset = "0x8AD4CF0", VA = "0x188AD58F0")]
	private void AHBEPKOAKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x8AD6A00", Offset = "0x8AD5E00", VA = "0x188AD6A00")]
	private void LONMANKHMBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5AC0", Offset = "0x8AD4EC0", VA = "0x188AD5AC0")]
	[CompilerGenerated]
	private object BHCGKDCDDME()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class PCFLDNBHNGG
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x8AE78B0", Offset = "0x8AE6CB0", VA = "0x188AE78B0")]
	public static ALOEMLAEPIB OFBDFJKOLCM(this ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class KIKNLHEHMLD : JHKFGMKJICA, IDNMFGCJMEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly PBLBJBJHCDM PAIBDGNODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly BIMJFEECNNG<ANFFNMLLNBD> HIJDEEHEEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool EIMIKDAONIG;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public BIMJFEECNNG<ANFFNMLLNBD> ABIGJMGGJLC
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 OAGNCLJEPLM
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBD90", Offset = "0x8ADB190", VA = "0x188ADBD90", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 IEGOLHEPHID
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB500", Offset = "0x8ADA900", VA = "0x188ADB500", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 PMMAEKMJMAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBCB0", Offset = "0x8ADB0B0", VA = "0x188ADBCB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public ANFFNMLLNBD LNFPLNGKAPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8ADB800", Offset = "0x8ADAC00", VA = "0x188ADB800", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x8ADBE20", Offset = "0x8ADB220", VA = "0x188ADBE20")]
	public KIKNLHEHMLD(ANFFNMLLNBD PAIBDGNODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB8B0", Offset = "0x8ADACB0", VA = "0x188ADB8B0", Slot = "8")]
	public void GMMDNALMKMC(ANFFNMLLNBD JIECBJMGMAC, object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x8ADBDC0", Offset = "0x8ADB1C0", VA = "0x188ADBDC0", Slot = "9")]
	public void MBPOKNHMMAL(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB160", Offset = "0x8ADA560", VA = "0x188ADB160")]
	private Vector3 BIEINGCNPFM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB920", Offset = "0x8ADAD20", VA = "0x188ADB920")]
	private void GPCCPPJFBFP(ANFFNMLLNBD CNGCPPECLKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class EANMNMGGMAC
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x8AD2F20", Offset = "0x8AD2320", VA = "0x188AD2F20")]
	public static JHKFGMKJICA BLOPNKPKJOG(this ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class JKBLGPEJION : PDNPAHIHKJD, APEPAHBNFKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly PBLBJBJHCDM PAIBDGNODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 FDILJFDIMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 DMDGKBPCGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float EJJOEPLPAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float FNDAHMHLJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 IBKAPAEFFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? PPLCOJDNDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? EDAMCMCIKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool LIDHFIEGNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool FPMCPHAAACC;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 HDFKHPAMOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x188B160", Offset = "0x188A560", VA = "0x18188B160", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9550", Offset = "0x8AD8950", VA = "0x188AD9550", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 AOACKPCHPOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9110", Offset = "0x8AD8510", VA = "0x188AD9110", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float IJKIJHPMLJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xE32DB0", Offset = "0xE321B0", VA = "0x180E32DB0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9000", Offset = "0x8AD8400", VA = "0x188AD9000")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float CIKHNEOEHHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xD22450", Offset = "0xD21850", VA = "0x180D22450", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x8AD92E0", Offset = "0x8AD86E0", VA = "0x188AD92E0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 KIDPHBFLJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8ADAAB0", Offset = "0x8AD9EB0", VA = "0x188ADAAB0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion MFJGOBAIBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8ADAC40", Offset = "0x8ADA040", VA = "0x188ADAC40", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody GKLCHHJFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8AD1B70", Offset = "0x8AD0F70", VA = "0x188AD1B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event CIOBHEEBBCO ICBDCPLPFEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8ADADC0", Offset = "0x8ADA1C0", VA = "0x188ADADC0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8AD9390", Offset = "0x8AD8790", VA = "0x188AD9390", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8ADB000", Offset = "0x8ADA400", VA = "0x188ADB000")]
	public JKBLGPEJION(ANFFNMLLNBD PAIBDGNODBA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9430", Offset = "0x8AD8830", VA = "0x188AD9430", Slot = "17")]
	public void ENHLDHHICDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8F20", Offset = "0x8AD8320", VA = "0x188AD8F20", Slot = "16")]
	public void CHBHLGLNPJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9200", Offset = "0x8AD8600", VA = "0x188AD9200", Slot = "19")]
	public void CNKCBDNCOIH(Rigidbody DGOBDNAOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8AD88C0", Offset = "0x8AD7CC0", VA = "0x188AD88C0", Slot = "20")]
	public void AHADBFIGHGD(Rigidbody DGOBDNAOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8ADA910", Offset = "0x8AD9D10", VA = "0x188ADA910", Slot = "18")]
	public void MIOIMAEDDIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8AA0", Offset = "0x8AD7EA0", VA = "0x188AD8AA0", Slot = "21")]
	public void BGNDJKEFEMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9550", Offset = "0x8AD8950", VA = "0x188AD9550")]
	private void KKMFALDIDDD(Vector3 CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9780", Offset = "0x8AD8B80", VA = "0x188AD9780")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 HMJDBEFKDDG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9000", Offset = "0x8AD8400", VA = "0x188AD9000")]
	private void MJIHBGGIKJA(float CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8AD92E0", Offset = "0x8AD86E0", VA = "0x188AD92E0")]
	private void GIOJONADIOJ(float CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8ADAE60", Offset = "0x8ADA260", VA = "0x188ADAE60")]
	private Vector3 OKNKPLOOAGM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8ADA6E0", Offset = "0x8AD9AE0", VA = "0x188ADA6E0", Slot = "15")]
	public void LNIJCCJEKMJ((Quaternion rot, Vector3 moments) AMFBBMEJKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9600", Offset = "0x8AD8A00", VA = "0x188AD9600")]
	private Quaternion GCEMCFCIPGO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8ADA610", Offset = "0x8AD9A10", VA = "0x188ADA610")]
	public void LHGKFDEJDFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8AD9870", Offset = "0x8AD8C70", VA = "0x188AD9870", Slot = "4")]
	public (float, Vector3) LHGKFDEJDFB(Rigidbody OAOADCODLNM)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class OAHCACKGILJ
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8ADCB00", Offset = "0x8ADBF00", VA = "0x188ADCB00")]
	public static PDNPAHIHKJD GCFHFBEMDCK(this ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class CPDNKAOCDLD : LECIONDANLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PBLBJBJHCDM PAIBDGNODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CKBPAEHADCP OJMLPBJOBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly IAOENOOJLJP MMGBJKAOGPE;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool OBMMDBHHHCN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1A8AA60", Offset = "0x1A89E60", VA = "0x181A8AA60", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public IAOENOOJLJP JCKDHHDDAGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xACA830", Offset = "0xAC9C30", VA = "0x180ACA830", Slot = "11")]
		get
		{
			return default(IAOENOOJLJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8AD2E20", Offset = "0x8AD2220", VA = "0x188AD2E20")]
	public CPDNKAOCDLD(ANFFNMLLNBD PAIBDGNODBA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8AD2C10", Offset = "0x8AD2010", VA = "0x188AD2C10", Slot = "4")]
	public void PFPNBAHGKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8AD2B10", Offset = "0x8AD1F10", VA = "0x188AD2B10")]
	private bool KPHBIKAPDIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8AD2BB0", Offset = "0x8AD1FB0", VA = "0x188AD2BB0", Slot = "5")]
	public void NNAEOHHGCPM(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8AD2BE0", Offset = "0x8AD1FE0", VA = "0x188AD2BE0", Slot = "6")]
	public void OICHOONHOOO(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8AD2CE0", Offset = "0x8AD20E0", VA = "0x188AD2CE0", Slot = "9")]
	public void PGOAOKAIAFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8AD29F0", Offset = "0x8AD1DF0", VA = "0x188AD29F0")]
	private void KAOGLCOECOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8AD2870", Offset = "0x8AD1C70", VA = "0x188AD2870")]
	private void JCPFBBINMHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8AD27F0", Offset = "0x8AD1BF0", VA = "0x188AD27F0", Slot = "8")]
	public void CLPDCKCOKIA(ANFFNMLLNBD PAIBDGNODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8AD2830", Offset = "0x8AD1C30", VA = "0x188AD2830", Slot = "7")]
	public void FGPOIFHFGFE(ANFFNMLLNBD PAIBDGNODBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class ELGMGLDOJNH : OFAJGOCKOIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly PBLBJBJHCDM PAIBDGNODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly CKBPAEHADCP CACDOHFJOGK;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool HKJHCJNDBLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4050", Offset = "0x8AD3450", VA = "0x188AD4050", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event CIOBHEEBBCO HAMHFGOADKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4100", Offset = "0x8AD3500", VA = "0x188AD4100", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8AD41A0", Offset = "0x8AD35A0", VA = "0x188AD41A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4240", Offset = "0x8AD3640", VA = "0x188AD4240")]
	public ELGMGLDOJNH(ANFFNMLLNBD PAIBDGNODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8AD3F70", Offset = "0x8AD3370", VA = "0x188AD3F70", Slot = "7")]
	public void BLMFBLLAHBD(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4000", Offset = "0x8AD3400", VA = "0x188AD4000", Slot = "8")]
	public void EMMIHPCFILD(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8AD3E30", Offset = "0x8AD3230", VA = "0x188AD3E30", Slot = "9")]
	public void AFBJHDBFHKA(object MONGIMOHLAO, bool GHMABHCPHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4010", Offset = "0x8AD3410", VA = "0x188AD4010", Slot = "12")]
	public void HNIHPMBODEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x8AD3F80", Offset = "0x8AD3380", VA = "0x188AD3F80", Slot = "10")]
	public void CNKCBDNCOIH(Rigidbody JAFLLGIEKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x8AD3F40", Offset = "0x8AD3340", VA = "0x188AD3F40", Slot = "11")]
	public void AHADBFIGHGD(Rigidbody DGOBDNAOFBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class OHEDMODKDID : BLEHNHDNKJN, JADJEDPLHLB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly PBLBJBJHCDM PAIBDGNODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private RRNetworkView PKMDJAGDKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool PKELMKBJAID;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public RRNetworkView IAFHLIIKKHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool LFPFNEMDNPA
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCDD0", Offset = "0x8ADC1D0", VA = "0x188ADCDD0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool OLDGACHJNBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xC1A7E0", Offset = "0xC19BE0", VA = "0x180C1A7E0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event CIOBHEEBBCO NACADNJMMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8ADD580", Offset = "0x8ADC980", VA = "0x188ADD580", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8ADCD30", Offset = "0x8ADC130", VA = "0x188ADCD30", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8ADD750", Offset = "0x8ADCB50", VA = "0x188ADD750")]
	public OHEDMODKDID(ANFFNMLLNBD PAIBDGNODBA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x8ADD620", Offset = "0x8ADCA20", VA = "0x188ADD620", Slot = "9")]
	public void PFPNBAHGKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x8ADCDE0", Offset = "0x8ADC1E0", VA = "0x188ADCDE0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x8ADCEE0", Offset = "0x8ADC2E0", VA = "0x188ADCEE0", Slot = "10")]
	public void EEPCOMMMKNI(ANFFNMLLNBD JIECBJMGMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x8ADD410", Offset = "0x8ADC810", VA = "0x188ADD410", Slot = "11")]
	public void MLJJCCPBKCD(ANFFNMLLNBD JIECBJMGMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x8ADCBC0", Offset = "0x8ADBFC0", VA = "0x188ADCBC0")]
	private void DGEGDAFHCOI(RRNetworkView AAFKCDDPMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x8ADD2C0", Offset = "0x8ADC6C0", VA = "0x188ADD2C0")]
	private void KBJFPNNNPCG(HHMPDIJPAEB JOLAKMNPDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x8ADD050", Offset = "0x8ADC450", VA = "0x188ADD050")]
	private void JLIBIOLEEAH(RRNetworkView KBFIOMIFLKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class IDCNNOJBABN
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x8AD8800", Offset = "0x8AD7C00", VA = "0x188AD8800")]
	public static BLEHNHDNKJN FOLHKCJJDBI(this ANFFNMLLNBD FCHDCHMAIKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class PLOHNLNJAOC : OIAAAPKLFDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly PBLBJBJHCDM PAIBDGNODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints LALLJGKPOOD;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool LKGHGHPGKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xB259A0", Offset = "0xB24DA0", VA = "0x180B259A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xE55AD0", Offset = "0xE54ED0", VA = "0x180E55AD0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool GNPAJNDHPPN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xB25B00", Offset = "0xB24F00", VA = "0x180B25B00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xE55A20", Offset = "0xE54E20", VA = "0x180E55A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints KKEJJCCKHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7C70", Offset = "0x8AE7070", VA = "0x188AE7C70", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x8AE7DD0", Offset = "0x8AE71D0", VA = "0x188AE7DD0")]
	public PLOHNLNJAOC(ANFFNMLLNBD PAIBDGNODBA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x8AE7DA0", Offset = "0x8AE71A0", VA = "0x188AE7DA0", Slot = "9")]
	public void CNKCBDNCOIH(Rigidbody DGOBDNAOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x8AE7C40", Offset = "0x8AE7040", VA = "0x188AE7C40", Slot = "10")]
	public void AHADBFIGHGD(Rigidbody DGOBDNAOFBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class PLHBFCLBODB : ALLBJOKKIBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly ANFFNMLLNBD PAIBDGNODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float DIJLKGIKLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float OLLOEFCLBJG;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float KACFOJIAIFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xABFF30", Offset = "0xABF330", VA = "0x180ABFF30", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7B30", Offset = "0x8AE6F30", VA = "0x188AE7B30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float OMBMPLDENDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xABFF40", Offset = "0xABF340", VA = "0x180ABFF40", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8AE7A60", Offset = "0x8AE6E60", VA = "0x188AE7A60", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8AE7C00", Offset = "0x8AE7000", VA = "0x188AE7C00")]
	public PLHBFCLBODB(ANFFNMLLNBD PAIBDGNODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x8AE7A10", Offset = "0x8AE6E10", VA = "0x188AE7A10", Slot = "8")]
	public void CNKCBDNCOIH(Rigidbody DGOBDNAOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x8AE7970", Offset = "0x8AE6D70", VA = "0x188AE7970", Slot = "9")]
	public void AHADBFIGHGD(Rigidbody DGOBDNAOFBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class AMGIDGJNGMI : NOCDGEAGHGP
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly AKNCNLDICPO PGBIPONMPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly PBLBJBJHCDM PAIBDGNODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool MOCEILDMKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool ILDNNLMJADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int JFPBCPONFPO;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody GKLCHHJFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8AD1B70", Offset = "0x8AD0F70", VA = "0x188AD1B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool JGJBIJJGLPC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8AD19C0", Offset = "0x8AD0DC0", VA = "0x188AD19C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private ANFFNMLLNBD BIMLAPPNEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x8AD1B10", Offset = "0x8AD0F10", VA = "0x188AD1B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool NHNICGNNADL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8AD1960", Offset = "0x8AD0D60", VA = "0x188AD1960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event CIOBHEEBBCO FCAKFDDLEJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8AD1E90", Offset = "0x8AD1290", VA = "0x188AD1E90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8AD1580", Offset = "0x8AD0980", VA = "0x188AD1580", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x8AD1FC0", Offset = "0x8AD13C0", VA = "0x188AD1FC0")]
	public AMGIDGJNGMI(ANFFNMLLNBD PAIBDGNODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x8AD1E00", Offset = "0x8AD1200", VA = "0x188AD1E00", Slot = "6")]
	public void PFPNBAHGKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x8AD1DF0", Offset = "0x8AD11F0", VA = "0x188AD1DF0", Slot = "8")]
	public void PEGHCMBIHKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x8AD1430", Offset = "0x8AD0830", VA = "0x188AD1430", Slot = "7")]
	public bool COOIHAEOEHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x8AD1320", Offset = "0x8AD0720", VA = "0x188AD1320", Slot = "9")]
	public void AELDHAAAHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x8AD1BC0", Offset = "0x8AD0FC0", VA = "0x188AD1BC0", Slot = "13")]
	public void NPIAHGMDHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8AD19E0", Offset = "0x8AD0DE0", VA = "0x188AD19E0", Slot = "12")]
	public void LMCCOBDLDHL(bool BJGCGBLKAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8AD13C0", Offset = "0x8AD07C0", VA = "0x188AD13C0", Slot = "10")]
	public bool BFOHNGOENJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8AD18A0", Offset = "0x8AD0CA0", VA = "0x188AD18A0", Slot = "11")]
	public bool EELMLIMHMBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8AD1620", Offset = "0x8AD0A20", VA = "0x188AD1620")]
	private bool DPLGPACKFLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8AD1C60", Offset = "0x8AD1060", VA = "0x188AD1C60")]
	private void OLHHLLJLMBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class FNJABFLBFAF : LLGCHGOKKLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly PBLBJBJHCDM PAIBDGNODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly CKBPAEHADCP OMKKNHLIJEI;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody GKLCHHJFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool NHNICGNNADL
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD33A0", Offset = "0x8AD27A0", VA = "0x188AD33A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool EAKOFMPDLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1A8AA60", Offset = "0x1A89E60", VA = "0x181A8AA60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4B40", Offset = "0x8AD3F40", VA = "0x188AD4B40")]
	public FNJABFLBFAF(ANFFNMLLNBD PAIBDGNODBA, [In] KPDFEHPKBMM NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4A70", Offset = "0x8AD3E70", VA = "0x188AD4A70", Slot = "5")]
	public void PFPNBAHGKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4B10", Offset = "0x8AD3F10", VA = "0x188AD4B10", Slot = "7")]
	public void PLDBGMIIOCJ(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x8AD4A40", Offset = "0x8AD3E40", VA = "0x188AD4A40", Slot = "8")]
	public void HEBJHCHCMEF(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x8AD43A0", Offset = "0x8AD37A0", VA = "0x188AD43A0", Slot = "9")]
	public void AGKEMPIPCMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x8AD46D0", Offset = "0x8AD3AD0", VA = "0x188AD46D0", Slot = "10")]
	public void ALHDGFEBEOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x8AD48C0", Offset = "0x8AD3CC0", VA = "0x188AD48C0", Slot = "11")]
	public void DBKHNHFEHKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class OPLJPLDFLJA : CGJJNKBKOOE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly PBLBJBJHCDM PAIBDGNODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly CKBPAEHADCP BGAGACJHDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float JILCGKJACAE;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public LLFNGCOOPGE MLBJGFMIACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public BNNLLMJJDPO JIANNGPCJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 PMMAEKMJMAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8ADF3A0", Offset = "0x8ADE7A0", VA = "0x188ADF3A0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8ADEE00", Offset = "0x8ADE200", VA = "0x188ADEE00", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 DCFGNKAPHPB
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8AE0AD0", Offset = "0x8ADFED0", VA = "0x188AE0AD0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8AE0F40", Offset = "0x8AE0340", VA = "0x188AE0F40", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 HCLKOEFECIN
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8ADDD30", Offset = "0x8ADD130", VA = "0x188ADDD30", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8ADFC40", Offset = "0x8ADF040", VA = "0x188ADFC40", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 BKDGJEFAIOP
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8ADEAF0", Offset = "0x8ADDEF0", VA = "0x188ADEAF0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8AE0AA0", Offset = "0x8ADFEA0", VA = "0x188AE0AA0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float ICCECLDBIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xABFF20", Offset = "0xABF320", VA = "0x180ABFF20", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8ADF560", Offset = "0x8ADE960", VA = "0x188ADF560", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool GFOJNPBFEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x24ED630", Offset = "0x24ECA30", VA = "0x1824ED630", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private ENHBBKNCELK DFDDDIOOMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8006290", Offset = "0x8005690", VA = "0x188006290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool JGJBIJJGLPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8ADFC20", Offset = "0x8ADF020", VA = "0x188ADFC20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x8AE0F70", Offset = "0x8AE0370", VA = "0x188AE0F70")]
	public OPLJPLDFLJA(ANFFNMLLNBD PAIBDGNODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x8ADE7F0", Offset = "0x8ADDBF0", VA = "0x188ADE7F0", Slot = "19")]
	public void PFPNBAHGKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x8ADE8A0", Offset = "0x8ADDCA0", VA = "0x188ADE8A0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8ADE6C0", Offset = "0x8ADDAC0", VA = "0x188ADE6C0", Slot = "28")]
	public void CNKCBDNCOIH(Rigidbody DGOBDNAOFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x184DB10", Offset = "0x184CF10", VA = "0x18184DB10", Slot = "20")]
	public void ACCJAKAPIPH(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x184BDC0", Offset = "0x184B1C0", VA = "0x18184BDC0", Slot = "30")]
	public void CEKJNBHHIJF(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8AE02E0", Offset = "0x8ADF6E0", VA = "0x188AE02E0", Slot = "35")]
	public Vector3 KCCLBLKIBBD(Vector3 DDEFJFOMGFG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x8AE0120", Offset = "0x8ADF520", VA = "0x188AE0120", Slot = "34")]
	public Vector3 KAPGKHJAMCO(Vector3 MIAAPPECFHB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x8ADE7F0", Offset = "0x8ADDBF0", VA = "0x188ADE7F0", Slot = "27")]
	public void DGOJJNBLAOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8ADEA90", Offset = "0x8ADDE90", VA = "0x188ADEA90", Slot = "25")]
	public void FCDBAFEMNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8AE04C0", Offset = "0x8ADF8C0", VA = "0x188AE04C0", Slot = "24")]
	public void KKABJONKKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x8AE0D00", Offset = "0x8AE0100", VA = "0x188AE0D00", Slot = "33")]
	public void PAPIHDOEIPB(Vector3 PABEIKNKFPG, Vector3 FBIPAGEENGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8ADEEC0", Offset = "0x8ADE2C0", VA = "0x188ADEEC0", Slot = "32")]
	public void HKFEKAPGFDA(Vector3 PLHEOKHEDMJ, Vector3 IGINODMGIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8ADE520", Offset = "0x8ADD920", VA = "0x188ADE520", Slot = "31")]
	public void CJMGIGGKHMA(Vector3 NHCNIILPJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x8ADDEF0", Offset = "0x8ADD2F0", VA = "0x188ADDEF0", Slot = "22")]
	public void CBCJLHNCKAK(DLGHIGIHDGD JJEMFOJGMKG, Vector3 PEJHAMCEMGO, float LBCMHCOCBKI, float EIHOHPGGLMO = 8f, float CCOOALGJJEJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8ADFD00", Offset = "0x8ADF100", VA = "0x188ADFD00", Slot = "21")]
	public void JLDELFHKIIM(EPFKLCJJAED ABMEPGCCPLP, Vector3 OGPLLELJPBM, float CDDONLBHEGI = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8AE0520", Offset = "0x8ADF920", VA = "0x188AE0520", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void KPJFGOHALMI(EPFKLCJJAED ABMEPGCCPLP, Vector3 EMLGDFFEJED, float MCLHJJMOIDC = 7f, float NCKPOIOOOGF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x19935E0", Offset = "0x19929E0", VA = "0x1819935E0")]
	private static void ABAIEDGCGCO(Vector3 PODFFOEBFLC, Vector3 KIAHAFCJEPK, [Out] Vector3 GFKGDBNIPLI, [Out] Vector3 ICCOIOGIBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8ADE440", Offset = "0x8ADD840", VA = "0x188ADE440", Slot = "29")]
	public Vector3 CCDKCMOKFPN(Vector3 PODFFOEBFLC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8AE0910", Offset = "0x8ADFD10", VA = "0x188AE0910", Slot = "26")]
	public void MBEICEELOON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8ADF560", Offset = "0x8ADE960", VA = "0x188ADF560")]
	private void KCIOHECHGFN(float CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x8ADFF80", Offset = "0x8ADF380", VA = "0x188ADFF80")]
	private void JPDBPBIOKNB(Vector3 OGPLLELJPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x8ADEC80", Offset = "0x8ADE080", VA = "0x188ADEC80")]
	private Vector3 HIMPJDOAPKI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x8ADEF20", Offset = "0x8ADE320", VA = "0x188ADEF20")]
	private void IAPIBGMBEHM(Vector3 MIAAPPECFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x8ADE900", Offset = "0x8ADDD00", VA = "0x188ADE900")]
	private Vector3 EOEFKHCGNPP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x8ADD8B0", Offset = "0x8ADCCB0", VA = "0x188ADD8B0")]
	private void AGMBEBEGNNO(Vector3 CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x8ADF670", Offset = "0x8ADEA70", VA = "0x188ADF670")]
	private void IHKKONEIILO(Vector3 MIAAPPECFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x8AE0C50", Offset = "0x8AE0050", VA = "0x188AE0C50")]
	private void OEELEACHHHD()
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
