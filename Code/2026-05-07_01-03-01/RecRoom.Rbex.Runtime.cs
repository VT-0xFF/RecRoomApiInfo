using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using RecRoom.Core;
using RecRoom.Core.Culling;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Service;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.NoEngine.DataStructures.Tokens;
using RecRoom.ObjectModel;
using RecRoom.Rbex;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCFB750", Offset = "0xCFA150", VA = "0x180CFB750")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA0118F0", Offset = "0xA0102F0", VA = "0x18A0118F0", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] QBWAEFIMHOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset GKXUUHBMTQD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x99F45D0", Offset = "0x99F2FD0", VA = "0x1899F45D0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA020510", Offset = "0xA01EF10", VA = "0x18A020510")]
		private void QLHWPSDGGQL(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA0207F0", Offset = "0xA01F1F0", VA = "0x18A0207F0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA020850", Offset = "0xA01F250", VA = "0x18A020850")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, KMOQKJRUHKT, PTRCHJDLDBY, RWKYZGEUVVW
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log HLNJOLQFFMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool AGUPXMUGJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private ZQMLMNOMZOF MUZYCYCCAKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[AutofillOptional(AutofillType.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[AutofillOptional(AutofillType.SelfAndParent, true, false, false)]
		private RRNetworkView rrNetworkView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private RbexInterpolationMode physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[TooltipAttribute("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x65")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[TooltipAttribute("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Transform NJEFYJMPUZU;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal ZQMLMNOMZOF VMWARCELWOG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA015970", Offset = "0xA014370", VA = "0x18A015970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private ZQMLMNOMZOF UYMJPTVKLKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int XAOOVQUVFEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA017340", Offset = "0xA015D40", VA = "0x18A017340")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx VLBKOVEWCTQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA0176A0", Offset = "0xA0160A0", VA = "0x18A0176A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx LJEDQXPUPWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA0175E0", Offset = "0xA015FE0", VA = "0x18A0175E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx TSUTPHIUZAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA0182A0", Offset = "0xA016CA0", VA = "0x18A0182A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA0197A0", Offset = "0xA0181A0", VA = "0x18A0197A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9398600", Offset = "0x9397000", VA = "0x189398600", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9398750", Offset = "0x9397150", VA = "0x189398750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform MOIDUDMLUHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x25E1F20", Offset = "0x25E0920", VA = "0x1825E1F20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform IQEMAJJEUQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x25E1F20", Offset = "0x25E0920", VA = "0x1825E1F20", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform UNYDUFSWWET
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x25E1F20", Offset = "0x25E0920", VA = "0x1825E1F20", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate EVUDKCJGMVV
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA0173A0", Offset = "0xA015DA0", VA = "0x18A0173A0")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA018F50", Offset = "0xA017950", VA = "0x18A018F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool UPULZZDYYNO
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA0179B0", Offset = "0xA0163B0", VA = "0x18A0179B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool OOZXOXOZHXA
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xA0174C0", Offset = "0xA015EC0", VA = "0x18A0174C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ZOVUKJMZZZX AOKCYJWQPTE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xA0178F0", Offset = "0xA0162F0", VA = "0x18A0178F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA019110", Offset = "0xA017B10", VA = "0x18A019110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public VHPXXKFPOWQ NKQIKWRUTWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA017890", Offset = "0xA016290", VA = "0x18A017890")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA0190A0", Offset = "0xA017AA0", VA = "0x18A0190A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool UGGLONJZEKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA0177E0", Offset = "0xA0161E0", VA = "0x18A0177E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody KHYJRPPXAYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA017840", Offset = "0xA016240", VA = "0x18A017840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool TEABYKKZBIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA017520", Offset = "0xA015F20", VA = "0x18A017520")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA018FC0", Offset = "0xA0179C0", VA = "0x18A018FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool YFCLYFNLWNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x19FF020", Offset = "0x19FDA20", VA = "0x1819FF020", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float QMVUVLDZUSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA018240", Offset = "0xA016C40", VA = "0x18A018240")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float APYIFBQHTLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA0181E0", Offset = "0xA016BE0", VA = "0x18A0181E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA019730", Offset = "0xA018130", VA = "0x18A019730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float EMEWXVDOGEW
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA017C10", Offset = "0xA016610", VA = "0x18A017C10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA0193B0", Offset = "0xA017DB0", VA = "0x18A0193B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float EIUOWYYDWWY
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA017A10", Offset = "0xA016410", VA = "0x18A017A10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA019180", Offset = "0xA017B80", VA = "0x18A019180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool GZPTVSXSXZB
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA0187F0", Offset = "0xA0171F0", VA = "0x18A0187F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA019CE0", Offset = "0xA0186E0", VA = "0x18A019CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 NFZPKENITAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xA017FC0", Offset = "0xA0169C0", VA = "0x18A017FC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA019500", Offset = "0xA017F00", VA = "0x18A019500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 LZFGXFBRQAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA018930", Offset = "0xA017330", VA = "0x18A018930")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode RYXBEDMVVIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA017B50", Offset = "0xA016550", VA = "0x18A017B50")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA0192D0", Offset = "0xA017CD0", VA = "0x18A0192D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float IDSRIGGLLPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA017580", Offset = "0xA015F80", VA = "0x18A017580")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA019030", Offset = "0xA017A30", VA = "0x18A019030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints ZLEFJCDYHCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA017BB0", Offset = "0xA0165B0", VA = "0x18A017BB0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA019340", Offset = "0xA017D40", VA = "0x18A019340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 VYYANUULARA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA018360", Offset = "0xA016D60", VA = "0x18A018360")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 VFXTUGKMKJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA018360", Offset = "0xA016D60", VA = "0x18A018360")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA019AC0", Offset = "0xA0184C0", VA = "0x18A019AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float XYWCVPKWPQB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA0180A0", Offset = "0xA016AA0", VA = "0x18A0180A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA0195E0", Offset = "0xA017FE0", VA = "0x18A0195E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float UVTFAFXLBES
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA018790", Offset = "0xA017190", VA = "0x18A018790")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA019C70", Offset = "0xA018670", VA = "0x18A019C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion YHSAMFMWTIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA018440", Offset = "0xA016E40", VA = "0x18A018440")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA019840", Offset = "0xA018240", VA = "0x18A019840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion LLONOFYJSYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA0186C0", Offset = "0xA0170C0", VA = "0x18A0186C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA019BA0", Offset = "0xA0185A0", VA = "0x18A019BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 UVBRAOXPPLR
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA018510", Offset = "0xA016F10", VA = "0x18A018510")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA019910", Offset = "0xA018310", VA = "0x18A019910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion OUUHZRDVCOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA0185F0", Offset = "0xA016FF0", VA = "0x18A0185F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA0199F0", Offset = "0xA0183F0", VA = "0x18A0199F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 PGSFAILWSQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA018850", Offset = "0xA017250", VA = "0x18A018850")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA019D50", Offset = "0xA018750", VA = "0x18A019D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 MSXTKZCCPBC
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA018100", Offset = "0xA016B00", VA = "0x18A018100")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA019650", Offset = "0xA018050", VA = "0x18A019650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 LESCFWMRAVH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA017A70", Offset = "0xA016470", VA = "0x18A017A70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA0191F0", Offset = "0xA017BF0", VA = "0x18A0191F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 EUZAFHYTCVC
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA017EE0", Offset = "0xA0168E0", VA = "0x18A017EE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA019420", Offset = "0xA017E20", VA = "0x18A019420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 CNLGXSJTHTJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA017DA0", Offset = "0xA0167A0", VA = "0x18A017DA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion ZGRDQAJHYVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA017CD0", Offset = "0xA0166D0", VA = "0x18A017CD0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 SANYEPNWSHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA018AF0", Offset = "0xA0174F0", VA = "0x18A018AF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 HBQCKLGZPGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA018A10", Offset = "0xA017410", VA = "0x18A018A10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool FZNYWHVFMEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA017E80", Offset = "0xA016880", VA = "0x18A017E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool JFIXCPFMHIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA017950", Offset = "0xA016350", VA = "0x18A017950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool VRZBNSGLLEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA017460", Offset = "0xA015E60", VA = "0x18A017460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool RUWVMCCDWAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA017400", Offset = "0xA015E00", VA = "0x18A017400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool LNWEFXCQRWN
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA0172E0", Offset = "0xA015CE0", VA = "0x18A0172E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool GIADCQKDIVS
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA017C70", Offset = "0xA016670", VA = "0x18A017C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool XGVRADRHOYC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xDF8DB0", Offset = "0xDF77B0", VA = "0x180DF8DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction UIPSMYTDILK
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA017200", Offset = "0xA015C00", VA = "0x18A017200")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA018E70", Offset = "0xA017870", VA = "0x18A018E70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction JSHYSEORPJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA016F70", Offset = "0xA015970", VA = "0x18A016F70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA018BD0", Offset = "0xA0175D0", VA = "0x18A018BD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction NCOVUYOXOIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA016FD0", Offset = "0xA0159D0", VA = "0x18A016FD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA018C40", Offset = "0xA017640", VA = "0x18A018C40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction YVFIPOZKCPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA017120", Offset = "0xA015B20", VA = "0x18A017120")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA018D90", Offset = "0xA017790", VA = "0x18A018D90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> IJJTPQCCHKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA0170B0", Offset = "0xA015AB0", VA = "0x18A0170B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA018D20", Offset = "0xA017720", VA = "0x18A018D20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction AORDKPBNGSJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA017190", Offset = "0xA015B90", VA = "0x18A017190")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA018E00", Offset = "0xA017800", VA = "0x18A018E00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction FNHAPWHGMHZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA017270", Offset = "0xA015C70", VA = "0x18A017270")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA018EE0", Offset = "0xA0178E0", VA = "0x18A018EE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction PMOPKNNGYQC
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA017040", Offset = "0xA015A40", VA = "0x18A017040")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA018CB0", Offset = "0xA0176B0", VA = "0x18A018CB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCD27E0", Offset = "0xCD11E0", VA = "0x180CD27E0", Slot = "8")]
		private void PNGVOQJWVQM(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA0158E0", Offset = "0xA0142E0", VA = "0x18A0158E0", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA015DF0", Offset = "0xA0147F0", VA = "0x18A015DF0")]
		internal void NZUXMJBILOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA016B10", Offset = "0xA015510", VA = "0x18A016B10")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA015630", Offset = "0xA014030", VA = "0x18A015630")]
		public KMOQKJRUHKT GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA016770", Offset = "0xA015170", VA = "0x18A016770")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA015280", Offset = "0xA013C80", VA = "0x18A015280")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA016A00", Offset = "0xA015400", VA = "0x18A016A00")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA015970", Offset = "0xA014370", VA = "0x18A015970")]
		private ZQMLMNOMZOF WJQTPMFQIOW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA016B80", Offset = "0xA015580", VA = "0x18A016B80")]
		private void VQZGAVQPNPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA015F40", Offset = "0xA014940", VA = "0x18A015F40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA015E80", Offset = "0xA014880", VA = "0x18A015E80")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA015DF0", Offset = "0xA0147F0", VA = "0x18A015DF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA015EE0", Offset = "0xA0148E0", VA = "0x18A015EE0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA015FA0", Offset = "0xA0149A0", VA = "0x18A015FA0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA014870", Offset = "0xA013270", VA = "0x18A014870")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA016000", Offset = "0xA014A00", VA = "0x18A016000")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA0155D0", Offset = "0xA013FD0", VA = "0x18A0155D0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA015D90", Offset = "0xA014790", VA = "0x18A015D90")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA0168D0", Offset = "0xA0152D0", VA = "0x18A0168D0")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA016310", Offset = "0xA014D10", VA = "0x18A016310")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA015A20", Offset = "0xA014420", VA = "0x18A015A20")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA015B20", Offset = "0xA014520", VA = "0x18A015B20")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA014AE0", Offset = "0xA0134E0", VA = "0x18A014AE0")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA016070", Offset = "0xA014A70", VA = "0x18A016070")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA014B50", Offset = "0xA013550", VA = "0x18A014B50")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA0160E0", Offset = "0xA014AE0", VA = "0x18A0160E0")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA016850", Offset = "0xA015250", VA = "0x18A016850")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA016670", Offset = "0xA015070", VA = "0x18A016670")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA016570", Offset = "0xA014F70", VA = "0x18A016570")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA0157D0", Offset = "0xA0141D0", VA = "0x18A0157D0")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA0156C0", Offset = "0xA0140C0", VA = "0x18A0156C0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA0149F0", Offset = "0xA0133F0", VA = "0x18A0149F0")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA0148E0", Offset = "0xA0132E0", VA = "0x18A0148E0")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA014D20", Offset = "0xA013720", VA = "0x18A014D20")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA014BC0", Offset = "0xA0135C0", VA = "0x18A014BC0")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA016D60", Offset = "0xA015760", VA = "0x18A016D60")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA015C80", Offset = "0xA014680", VA = "0x18A015C80")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA015570", Offset = "0xA013F70", VA = "0x18A015570")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA015510", Offset = "0xA013F10", VA = "0x18A015510")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA0154B0", Offset = "0xA013EB0", VA = "0x18A0154B0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA015450", Offset = "0xA013E50", VA = "0x18A015450")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA016470", Offset = "0xA014E70", VA = "0x18A016470")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA016370", Offset = "0xA014D70", VA = "0x18A016370")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA016230", Offset = "0xA014C30", VA = "0x18A016230")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA016A10", Offset = "0xA015410", VA = "0x18A016A10")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA015C20", Offset = "0xA014620", VA = "0x18A015C20")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA0169A0", Offset = "0xA0153A0", VA = "0x18A0169A0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA016D00", Offset = "0xA015700", VA = "0x18A016D00")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA014CB0", Offset = "0xA0136B0", VA = "0x18A014CB0")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA016150", Offset = "0xA014B50", VA = "0x18A016150")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA0150B0", Offset = "0xA013AB0", VA = "0x18A0150B0")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA014FB0", Offset = "0xA0139B0", VA = "0x18A014FB0")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA015170", Offset = "0xA013B70", VA = "0x18A015170")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA014EE0", Offset = "0xA0138E0", VA = "0x18A014EE0")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA014E10", Offset = "0xA013810", VA = "0x18A014E10")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA0161C0", Offset = "0xA014BC0", VA = "0x18A0161C0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8C26DC0", Offset = "0x8C257C0", VA = "0x188C26DC0", Slot = "13")]
		private void CEPTDDAWYSD(RMAVRNNVPKV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA016F00", Offset = "0xA015900", VA = "0x18A016F00")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x14FEB40", Offset = "0x14FD540", VA = "0x1814FEB40", Slot = "4")]
		private GameObject VFWSPBTLVNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xCFDF90", Offset = "0xCFC990", VA = "0x180CFDF90", Slot = "10")]
		private bool VNZXCOUZTQF()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class PTDSJDFZMLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA011FF0", Offset = "0xA0109F0", VA = "0x18A011FF0")]
		public static ZQMLMNOMZOF VMWARCELWOG(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(KVZHTVWWSES), new string[] { })]
	public class RigidbodyExManager : KVZHTVWWSES, ZVXNWENCXPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private ZTBKOTRXIAV UPGGCETSTNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private IQECWWRWFGM HNAAFZXCFRU;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ZTBKOTRXIAV JHPMBRTMJYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public IQECWWRWFGM IFBYJSGXLWC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA0145A0", Offset = "0xA012FA0", VA = "0x18A0145A0", Slot = "7")]
		public void InitReferences(GZOGVDISCYD services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA014610", Offset = "0xA013010", VA = "0x18A014610", Slot = "6")]
		public ZQMLMNOMZOF YXLXPOFLABM(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static BQUYOYJDJCS UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int ZRUIIFZZMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int QVPEGAACEUU;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA012060", Offset = "0xA010A60", VA = "0x18A012060")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA0120E0", Offset = "0xA010AE0", VA = "0x18A0120E0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA012080", Offset = "0xA010A80", VA = "0x18A012080")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA0121E0", Offset = "0xA010BE0", VA = "0x18A0121E0")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class DJVDQVBYTUI
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class UJERIXOZVIA : ZOVUKJMZZZX, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xCE14C0", Offset = "0xCDFEC0", VA = "0x180CE14C0", Slot = "4")]
			public Vector3 AWRBJHDCQWZ()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCE14C0", Offset = "0xCDFEC0", VA = "0x180CE14C0", Slot = "5")]
			public Vector3 WYEALHDXNIU()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "6")]
			public bool OCDRMXCHSYX(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public UJERIXOZVIA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static ZOVUKJMZZZX LICQPMQJLBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA009B10", Offset = "0xA008510", VA = "0x18A009B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
}
namespace RecRoom.Rbex
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface RVAFLBLRQWB
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CollisionDetectionMode CUQKHVLOPTW
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XDLGTGYSZCI(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void QSECELRHJCH(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SFLOTVZQTMB(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool NGVDFSMQMKU(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface WKHVWTCWKAO : IDisposable, YJYLSAGECOQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		TransformTrackRate EVUDKCJGMVV
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> IJJTPQCCHKE;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface IQECWWRWFGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JKEEENUOKZL MACGIBKYWPV(ZQMLMNOMZOF a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NQVNXSUUNLP QCKALGMOCED(ZQMLMNOMZOF a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		JHTMSQWZJJE TXHRPAFBBYY(ZQMLMNOMZOF a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		QPIAOFKJHLJ FVFNFPLCTYZ(ZQMLMNOMZOF a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GJHJGMOJGDP LNYAAZUTQZB(ZQMLMNOMZOF a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		WKHVWTCWKAO NJASMTRNNGE(ZQMLMNOMZOF a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		GAAGZQTFUMH VTWJOCWGDRX(ZQMLMNOMZOF a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		JEWHYFATOIB GVFOKBRVOAT(ZQMLMNOMZOF a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		RVAFLBLRQWB TWHWUBGTLGT(ZQMLMNOMZOF a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		EKTYBHJFZKQ CNOUAMRBNCO(ZQMLMNOMZOF a);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		GYIYVUOMNCG EACOSQACLEE(ZQMLMNOMZOF a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		ZFDUUIXZDZA NVICJMYMHXK(ZQMLMNOMZOF a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		SNNDTLSZBHG UMSZGCNJLIS(ZQMLMNOMZOF a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		KKKSIOWAIWM WZFDWQCFVQK(ZQMLMNOMZOF a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		CWRRGTKENCU WCNNVGKLPXQ(ZQMLMNOMZOF a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		ZQMLMNOMZOF YXLXPOFLABM(RigidbodyEx a, RigidbodyExData b, KVZHTVWWSES c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface JEWHYFATOIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GKJMLDQMPPI(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void XUZKGSGBWEU(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void XZHSZBOKJON(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LOALQDTSCIF(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface EKTYBHJFZKQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool XBTGJQDHCAX
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SFLOTVZQTMB(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IZYWWPLXOZM(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface JKEEENUOKZL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IReadOnlyList<ZQMLMNOMZOF> JQSYRUQJNGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		ZQMLMNOMZOF LJEDQXPUPWM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		ZQMLMNOMZOF JRPWOYBYXDS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction JSHYSEORPJS;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction NCOVUYOXOIW;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction HFBDPZFCSXK;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action QIQOYTOVAEN;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action GEIOHSUZIDU;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<ZQMLMNOMZOF> VNDXYTGHXBZ;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<ZQMLMNOMZOF> BMDIGRIZSNW;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action QTKEDVXMQGL;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<ZQMLMNOMZOF> UASIKDWRSDC;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(ZQMLMNOMZOF newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface JHTMSQWZJJE
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Vector3 XHKDYATUGUB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Vector3 YWLBZGMWSJV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RTLNHPRCOST(ZQMLMNOMZOF a, object b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KFKFCROKLXS(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface KKKSIOWAIWM
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 RTSRSJGUZUD
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 JUKRVYKYXIY
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float FKZAPSBNKFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		float LIJZLPMOYEX
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Vector3 OHPFTSWFABZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		Quaternion KTUEOSYXGBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction KRWPXBXGVNU;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void BQHFSGTYFXJ((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void KZPXHKZDQGW();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void IDSDGUINODT();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void OCOWWDWRTCP();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void SFLOTVZQTMB(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void IZYWWPLXOZM(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface SNNDTLSZBHG
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void TGALTDNZKCP(object a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CMVRWTOEGUS(object a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ODYENNELAAC(ZQMLMNOMZOF a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OQUIPOUHCGR(ZQMLMNOMZOF a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GAOEWZDTZHE();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface GAAGZQTFUMH
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool AFOBOGMJGQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction GZAUIERVCUH;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PAHPFVUNPZK(object a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BAFTEKBKLSZ(object a);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OGOSDAOGOQJ(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void SFLOTVZQTMB(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void IZYWWPLXOZM(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface ZFDUUIXZDZA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool UPULZZDYYNO
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool OOZXOXOZHXA
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction TJCGOVKNSRN;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FXMPDVLCSQM(ZQMLMNOMZOF a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void GHREAUXCFTG(ZQMLMNOMZOF a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface CWRRGTKENCU
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool TEABYKKZBIH
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool CICJRTSVIKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		RigidbodyConstraints QAVYICNEWFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(Slot = "4")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void SFLOTVZQTMB(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void IZYWWPLXOZM(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface QPIAOFKJHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		float UTUKDVVIXFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		float YNPJGOPKEOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SFLOTVZQTMB(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void IZYWWPLXOZM(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface GJHJGMOJGDP
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		static bool XUEWUCZKEUJ;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction EZKQRLZNXRX;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool IOVKONZTROR();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IRFSDQCMLMD();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool XSFUDDBFDJJ();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool NRYNWDHXDYO();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void YXQJBVLYDEE(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void JUTDFRJASKN();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface GYIYVUOMNCG
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		Rigidbody KHYJRPPXAYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool TLWXIGUCRUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DXKCMOTVTOD(object a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SJBKOBVMAWG(object a);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void VJVVOZSMGRZ();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface NQVNXSUUNLP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		ZOVUKJMZZZX AOKCYJWQPTE
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		VHPXXKFPOWQ NKQIKWRUTWB
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Vector3 RRMSKUFHRKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Vector3 JIKKNTHRKPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		Vector3 YDFIVHFCMMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 SRVMSSDTLQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		float IDSRIGGLLPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool UGGLONJZEKR
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void VCVIRJPCGTN(object a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void CMRSIBZELEJ(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void BWVSFQYSBMQ(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void PDOVLGASFHY(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void ZHKANFLSSCG();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void IPEHKIECNGX();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void PELUKPZRVUW();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void RYCXBTSDDBQ();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void SFLOTVZQTMB(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 LVCGTJTZAHV(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void EKQIPZZIGAO(object a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void BOHURHYOJVQ(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void SFBTBVIHMQD(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void XYWNSMXCFWW(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 ZVJHSEUXEDP(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 SMGJFHJSFJZ(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface ZTBKOTRXIAV
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool DKPTJCPBOTQ
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LRDASYWDBWY(string a);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IPFCGKGPKLR(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		RYPBBHHSWRP THGFRGUTDLA(int a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GHHHJOJAUNE(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface KVZHTVWWSES
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		ZTBKOTRXIAV JHPMBRTMJYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		IQECWWRWFGM IFBYJSGXLWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ZQMLMNOMZOF YXLXPOFLABM(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class HIFNLBPIGGE : ZQMLMNOMZOF, IDisposable, QQLSGEOIHHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal readonly KVZHTVWWSES WOYAAPKNHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal JKEEENUOKZL HPHNRAKIMXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal SNNDTLSZBHG OYQHTARKGEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal ZFDUUIXZDZA KPNPRGMIVEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal NQVNXSUUNLP PGSFAILWSQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal JHTMSQWZJJE AKOKMKLTBMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal KKKSIOWAIWM QMFXPJUOYBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal QPIAOFKJHLJ TKPGAGDMXGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal EKTYBHJFZKQ AZJVAGWKGFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal GJHJGMOJGDP FLHYCSTLTEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal WKHVWTCWKAO UEWEEICQNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal GAAGZQTFUMH SPVYFYNVWNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal JEWHYFATOIB PKUGURHYXJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal CWRRGTKENCU PSNBQTAQDEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal GYIYVUOMNCG DBUEHDFZAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal RVAFLBLRQWB UFYLHGCCUHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal IDisposable HSURXGYHPWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool KMJHUOBQMTO;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ObjectLocalId ZETEDTZZFWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public KMOQKJRUHKT HZDAJVCTQRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xDA8860", Offset = "0xDA7260", VA = "0x180DA8860", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xE62180", Offset = "0xE60B80", VA = "0x180E62180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject ICUGWAERVKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xCDA8F0", Offset = "0xCD92F0", VA = "0x180CDA8F0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xCDA8D0", Offset = "0xCD92D0", VA = "0x180CDA8D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform QSGLKOZVOYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xE77DF0", Offset = "0xE767F0", VA = "0x180E77DF0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xFF36E0", Offset = "0xFF20E0", VA = "0x180FF36E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody KHYJRPPXAYM
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xA00BEF0", Offset = "0xA00A8F0", VA = "0x18A00BEF0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public ZQMLMNOMZOF JRPWOYBYXDS
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xA00ABD0", Offset = "0xA0095D0", VA = "0x18A00ABD0", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xA00CCD0", Offset = "0xA00B6D0", VA = "0x18A00CCD0", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int XAOOVQUVFEV
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA00D960", Offset = "0xA00C360", VA = "0x18A00D960", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public ZQMLMNOMZOF LJEDQXPUPWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xA00F800", Offset = "0xA00E200", VA = "0x18A00F800", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool QXSCYEDOSSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xA00D680", Offset = "0xA00C080", VA = "0x18A00D680", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool UPULZZDYYNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA00F510", Offset = "0xA00DF10", VA = "0x18A00F510", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool OOZXOXOZHXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA00FD90", Offset = "0xA00E790", VA = "0x18A00FD90", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public ZOVUKJMZZZX AOKCYJWQPTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xA00D3B0", Offset = "0xA00BDB0", VA = "0x18A00D3B0", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xA010320", Offset = "0xA00ED20", VA = "0x18A010320", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public VHPXXKFPOWQ NKQIKWRUTWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA00B920", Offset = "0xA00A320", VA = "0x18A00B920", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA00BE90", Offset = "0xA00A890", VA = "0x18A00BE90", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float IDSRIGGLLPB
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xA00A960", Offset = "0xA009360", VA = "0x18A00A960", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xA00F160", Offset = "0xA00DB60", VA = "0x18A00F160", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 JIKKNTHRKPC
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xA00EE50", Offset = "0xA00D850", VA = "0x18A00EE50", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xA00E790", Offset = "0xA00D190", VA = "0x18A00E790", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 SRVMSSDTLQQ
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA00FE40", Offset = "0xA00E840", VA = "0x18A00FE40", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA00D2D0", Offset = "0xA00BCD0", VA = "0x18A00D2D0", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 RRMSKUFHRKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xA00DE20", Offset = "0xA00C820", VA = "0x18A00DE20", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA00C080", Offset = "0xA00AA80", VA = "0x18A00C080", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 YDFIVHFCMMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA00B250", Offset = "0xA009C50", VA = "0x18A00B250", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA00BD30", Offset = "0xA00A730", VA = "0x18A00BD30", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool VRZBNSGLLEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA010280", Offset = "0xA00EC80", VA = "0x18A010280", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool RUWVMCCDWAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA00B9D0", Offset = "0xA00A3D0", VA = "0x18A00B9D0", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool LNWEFXCQRWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA010160", Offset = "0xA00EB60", VA = "0x18A010160", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool UGGLONJZEKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA00BE40", Offset = "0xA00A840", VA = "0x18A00BE40", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 XHKDYATUGUB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xA00E6C0", Offset = "0xA00D0C0", VA = "0x18A00E6C0", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 YWLBZGMWSJV
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xA00BFA0", Offset = "0xA00A9A0", VA = "0x18A00BFA0", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 RTSRSJGUZUD
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xA00AEC0", Offset = "0xA0098C0", VA = "0x18A00AEC0", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xA00D4A0", Offset = "0xA00BEA0", VA = "0x18A00D4A0", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 JUKRVYKYXIY
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA00FF20", Offset = "0xA00E920", VA = "0x18A00FF20", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float FKZAPSBNKFK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xA00E920", Offset = "0xA00D320", VA = "0x18A00E920", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float LIJZLPMOYEX
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xA0102D0", Offset = "0xA00ECD0", VA = "0x18A0102D0", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xA00ED30", Offset = "0xA00D730", VA = "0x18A00ED30", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 OHPFTSWFABZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xA010F60", Offset = "0xA00F960", VA = "0x18A010F60", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion KTUEOSYXGBL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA00F960", Offset = "0xA00E360", VA = "0x18A00F960", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float UTUKDVVIXFI
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xA00C850", Offset = "0xA00B250", VA = "0x18A00C850", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xA00E870", Offset = "0xA00D270", VA = "0x18A00E870", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float YNPJGOPKEOI
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xA010C80", Offset = "0xA00F680", VA = "0x18A010C80", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xA00B110", Offset = "0xA009B10", VA = "0x18A00B110", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool XBTGJQDHCAX
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xA00CC80", Offset = "0xA00B680", VA = "0x18A00CC80", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xA00FD30", Offset = "0xA00E730", VA = "0x18A00FD30", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate EVUDKCJGMVV
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA00E8D0", Offset = "0xA00D2D0", VA = "0x18A00E8D0", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xA00ED90", Offset = "0xA00D790", VA = "0x18A00ED90", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool AFOBOGMJGQR
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xA00EA30", Offset = "0xA00D430", VA = "0x18A00EA30", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform UNYDUFSWWET
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xE77DF0", Offset = "0xE767F0", VA = "0x180E77DF0", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 KTLLGOTLHUX
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA010810", Offset = "0xA00F210", VA = "0x18A010810", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA010000", Offset = "0xA00EA00", VA = "0x18A010000", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float BHARUBFJFYR
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xA00C840", Offset = "0xA00B240", VA = "0x18A00C840", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA00EF30", Offset = "0xA00D930", VA = "0x18A00EF30", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float YRCLGCUIWQC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xA00FC30", Offset = "0xA00E630", VA = "0x18A00FC30", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xA00F2B0", Offset = "0xA00DCB0", VA = "0x18A00F2B0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion GRORAHEHWTI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xA00D400", Offset = "0xA00BE00", VA = "0x18A00D400", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xA00BAF0", Offset = "0xA00A4F0", VA = "0x18A00BAF0", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 OYWTYXOICNS
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xA00CF00", Offset = "0xA00B900", VA = "0x18A00CF00", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xA00D7C0", Offset = "0xA00C1C0", VA = "0x18A00D7C0", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion SILHDFYWFMV
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xA010240", Offset = "0xA00EC40", VA = "0x18A010240", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xA00BE10", Offset = "0xA00A810", VA = "0x18A00BE10", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints QAVYICNEWFG
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA00D630", Offset = "0xA00C030", VA = "0x18A00D630", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA00C360", Offset = "0xA00AD60", VA = "0x18A00C360", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool TEABYKKZBIH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xA00CE50", Offset = "0xA00B850", VA = "0x18A00CE50", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA00C160", Offset = "0xA00AB60", VA = "0x18A00C160", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode CUQKHVLOPTW
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xA00DC40", Offset = "0xA00C640", VA = "0x18A00DC40", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA00B970", Offset = "0xA00A370", VA = "0x18A00B970", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool VKCHPPNDMAD
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xA00A9B0", Offset = "0xA0093B0", VA = "0x18A00A9B0", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool JFIXCPFMHIO
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xA00EA80", Offset = "0xA00D480", VA = "0x18A00EA80", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction JSHYSEORPJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xA00AB70", Offset = "0xA009570", VA = "0x18A00AB70", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xA00D9D0", Offset = "0xA00C3D0", VA = "0x18A00D9D0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction NCOVUYOXOIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xA00FCD0", Offset = "0xA00E6D0", VA = "0x18A00FCD0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xA00EDF0", Offset = "0xA00D7F0", VA = "0x18A00EDF0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction HFBDPZFCSXK
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xA010410", Offset = "0xA00EE10", VA = "0x18A010410", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xA00CC20", Offset = "0xA00B620", VA = "0x18A00CC20", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction TJCGOVKNSRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xA00CAD0", Offset = "0xA00B4D0", VA = "0x18A00CAD0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA00BA30", Offset = "0xA00A430", VA = "0x18A00BA30", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction YVFIPOZKCPI
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xA00E9D0", Offset = "0xA00D3D0", VA = "0x18A00E9D0", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xA00BF40", Offset = "0xA00A940", VA = "0x18A00BF40", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction EZKQRLZNXRX
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xA00BCD0", Offset = "0xA00A6D0", VA = "0x18A00BCD0", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xA00FDE0", Offset = "0xA00E7E0", VA = "0x18A00FDE0", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> IJJTPQCCHKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xA00E970", Offset = "0xA00D370", VA = "0x18A00E970", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xA00D5D0", Offset = "0xA00BFD0", VA = "0x18A00D5D0", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction GZAUIERVCUH
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA00E0C0", Offset = "0xA00CAC0", VA = "0x18A00E0C0", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xA010580", Offset = "0xA00EF80", VA = "0x18A010580", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction PMOPKNNGYQC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA00DA30", Offset = "0xA00C430", VA = "0x18A00DA30", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA00C3C0", Offset = "0xA00ADC0", VA = "0x18A00C3C0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA011040", Offset = "0xA00FA40", VA = "0x18A011040")]
		public HIFNLBPIGGE(GameObject a, RigidbodyEx b, KVZHTVWWSES c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA00C550", Offset = "0xA00AF50", VA = "0x18A00C550", Slot = "139")]
		protected virtual void GRJZBWFENLC(KVZHTVWWSES a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA00BBD0", Offset = "0xA00A5D0", VA = "0x18A00BBD0", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA00AC20", Offset = "0xA009620", VA = "0x18A00AC20", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA00DFD0", Offset = "0xA00C9D0", VA = "0x18A00DFD0", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA00DF20", Offset = "0xA00C920", VA = "0x18A00DF20", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA00DF00", Offset = "0xA00C900", VA = "0x18A00DF00", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA0108C0", Offset = "0xA00F2C0", VA = "0x18A0108C0")]
		private void YXQJBVLYDEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA00CA50", Offset = "0xA00B450", VA = "0x18A00CA50")]
		private void HUUIAHGMYUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA00DC90", Offset = "0xA00C690", VA = "0x18A00DC90")]
		private void NRYNWDHXDYO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA00AAF0", Offset = "0xA0094F0", VA = "0x18A00AAF0", Slot = "30")]
		public ZQMLMNOMZOF AOZKAPIMUAG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA00F560", Offset = "0xA00DF60", VA = "0x18A00F560", Slot = "98")]
		public void SetParent(ZQMLMNOMZOF value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA00DBE0", Offset = "0xA00C5E0", VA = "0x18A00DBE0", Slot = "99")]
		public void NIGRQYCUFCF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA00D900", Offset = "0xA00C300", VA = "0x18A00D900", Slot = "100")]
		public void MAVVFILWOVS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA00F410", Offset = "0xA00DE10", VA = "0x18A00F410", Slot = "101")]
		public Vector3 SMGJFHJSFJZ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA010E00", Offset = "0xA00F800", VA = "0x18A010E00", Slot = "102")]
		public Vector3 ZVJHSEUXEDP(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA00F110", Offset = "0xA00DB10", VA = "0x18A00F110", Slot = "103")]
		public void RYCXBTSDDBQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA00CBD0", Offset = "0xA00B5D0", VA = "0x18A00CBD0", Slot = "104")]
		public void IPEHKIECNGX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA010CD0", Offset = "0xA00F6D0", VA = "0x18A010CD0", Slot = "105")]
		public void ZHKANFLSSCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA0105E0", Offset = "0xA00EFE0", VA = "0x18A0105E0", Slot = "106")]
		public void XYWNSMXCFWW(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA00F1C0", Offset = "0xA00DBC0", VA = "0x18A00F1C0", Slot = "107")]
		public void SFBTBVIHMQD(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA00B170", Offset = "0xA009B70", VA = "0x18A00B170", Slot = "108")]
		public void BOHURHYOJVQ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA00B410", Offset = "0xA009E10", VA = "0x18A00B410", Slot = "109")]
		public void BWVSFQYSBMQ(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA00B820", Offset = "0xA00A220", VA = "0x18A00B820", Slot = "110")]
		public void CMRSIBZELEJ(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA00E120", Offset = "0xA00CB20", VA = "0x18A00E120", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void PDOVLGASFHY(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA00D800", Offset = "0xA00C200", VA = "0x18A00D800", Slot = "112")]
		public Vector3 LVCGTJTZAHV(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA00ADC0", Offset = "0xA0097C0", VA = "0x18A00ADC0", Slot = "113")]
		public Vector3 BEECOPKQTIR(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA00E230", Offset = "0xA00CC30", VA = "0x18A00E230", Slot = "114")]
		public void PELUKPZRVUW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA00DDB0", Offset = "0xA00C7B0", VA = "0x18A00DDB0", Slot = "115")]
		public void OLRDBCKXNEU(ZQMLMNOMZOF a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA0107B0", Offset = "0xA00F1B0", VA = "0x18A0107B0", Slot = "116")]
		public void YFMAXEPRRUN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA00B330", Offset = "0xA009D30", VA = "0x18A00B330", Slot = "63")]
		public void BQHFSGTYFXJ((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA00CB30", Offset = "0xA00B530", VA = "0x18A00CB30", Slot = "117")]
		public void IDSDGUINODT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA00D580", Offset = "0xA00BF80", VA = "0x18A00D580", Slot = "118")]
		public void KZPXHKZDQGW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA00DCF0", Offset = "0xA00C6F0", VA = "0x18A00DCF0", Slot = "119")]
		public void OCOWWDWRTCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA00CB80", Offset = "0xA00B580", VA = "0x18A00CB80", Slot = "120")]
		public bool IOVKONZTROR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA00F5D0", Offset = "0xA00DFD0", VA = "0x18A00F5D0", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA00CF40", Offset = "0xA00B940", VA = "0x18A00CF40", Slot = "121")]
		public void JUTDFRJASKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA00E060", Offset = "0xA00CA60", VA = "0x18A00E060", Slot = "122")]
		public void PAHPFVUNPZK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA00AD60", Offset = "0xA009760", VA = "0x18A00AD60", Slot = "123")]
		public void BAFTEKBKLSZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA00DD40", Offset = "0xA00C740", VA = "0x18A00DD40", Slot = "124")]
		public void OGOSDAOGOQJ(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA00FA30", Offset = "0xA00E430", VA = "0x18A00FA30", Slot = "125")]
		public void TPUYHIGAYKH(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA010B50", Offset = "0xA00F550", VA = "0x18A010B50", Slot = "126")]
		public void ZCEGLEGOTAT(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA00FC40", Offset = "0xA00E640", VA = "0x18A00FC40", Slot = "127")]
		public bool TWYJUBLVPDQ(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA00CEA0", Offset = "0xA00B8A0", VA = "0x18A00CEA0", Slot = "128")]
		public void JNAJBSJDBEX(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA010F00", Offset = "0xA00F900", VA = "0x18A010F00", Slot = "129")]
		public void ZWYGEBYOBDC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA90", Offset = "0xA00A490", VA = "0x18A00BA90", Slot = "130")]
		public void DXKCMOTVTOD(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA00F3B0", Offset = "0xA00DDB0", VA = "0x18A00F3B0", Slot = "131")]
		public void SJBKOBVMAWG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA00C470", Offset = "0xA00AE70", VA = "0x18A00C470", Slot = "132")]
		public void GKJMLDQMPPI(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA010470", Offset = "0xA00EE70", VA = "0x18A010470", Slot = "133")]
		public void XUZKGSGBWEU(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA0106D0", Offset = "0xA00F0D0", VA = "0x18A0106D0", Slot = "134")]
		public void XZHSZBOKJON(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA00D6E0", Offset = "0xA00C0E0", VA = "0x18A00D6E0", Slot = "135")]
		public void LOALQDTSCIF(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA00DAE0", Offset = "0xA00C4E0", VA = "0x18A00DAE0", Slot = "136")]
		public bool NGVDFSMQMKU(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xA00DF80", Offset = "0xA00C980", VA = "0x18A00DF80", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA00FC90", Offset = "0xA00E690", VA = "0x18A00FC90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA010D20", Offset = "0xA00F720", VA = "0x18A010D20")]
		private void ZJBABJXRHHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA00F850", Offset = "0xA00E250", VA = "0x18A00F850")]
		private void TJWLCMUMONQ(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA00F620", Offset = "0xA00E020", VA = "0x18A00F620")]
		private void TCPZNBEYFJT(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA0100B0", Offset = "0xA00EAB0", VA = "0x18A0100B0")]
		private void WFVIRILOEQC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xA00EC00", Offset = "0xA00D600", VA = "0x18A00EC00")]
		private void RBQVMOOEBXR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA00C8A0", Offset = "0xA00B2A0", VA = "0x18A00C8A0")]
		private void HSHAIBBFUSX(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA00C1C0", Offset = "0xA00ABC0", VA = "0x18A00C1C0")]
		private void FXMPDVLCSQM(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA00C290", Offset = "0xA00AC90", VA = "0x18A00C290")]
		private void GHREAUXCFTG(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA00EFC0", Offset = "0xA00D9C0", VA = "0x18A00EFC0")]
		private void RTXZLRJASKF(KMOQKJRUHKT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA00E280", Offset = "0xA00CC80", VA = "0x18A00E280", Slot = "142")]
		protected virtual void PHSVOLJKTFM(KMOQKJRUHKT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA00CFB0", Offset = "0xA00B9B0", VA = "0x18A00CFB0")]
		protected void JUUNBRYNFTS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA00B4D0", Offset = "0xA009ED0", VA = "0x18A00B4D0")]
		protected void CDFWOTRZVPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA00CD30", Offset = "0xA00B730", VA = "0x18A00CD30")]
		private void JFZYJCGPGCS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA00AFA0", Offset = "0xA0099A0", VA = "0x18A00AFA0")]
		private void BLWGVRTSKAL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class TNQNVEKMULE
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA019FC0", Offset = "0xA0189C0", VA = "0x18A019FC0")]
		public static ZQMLMNOMZOF SVIDRMKEXKH(this ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA01A120", Offset = "0xA018B20", VA = "0x18A01A120")]
		public static bool VNFOAFIRUXY(this ZQMLMNOMZOF a, ZQMLMNOMZOF b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA01A080", Offset = "0xA018A80", VA = "0x18A01A080")]
		public static bool SYMYGRPPEYI(this ZQMLMNOMZOF a, ZQMLMNOMZOF b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA019F70", Offset = "0xA018970", VA = "0x18A019F70")]
		public static KMOQKJRUHKT CBGYDWPAKRE(this ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA019EF0", Offset = "0xA0188F0", VA = "0x18A019EF0")]
		public static HIFNLBPIGGE Base(this ZQMLMNOMZOF impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BFGEMMXLWSZ : IQECWWRWFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA0063E0", Offset = "0xA004DE0", VA = "0x18A0063E0", Slot = "19")]
		public ZQMLMNOMZOF YXLXPOFLABM(RigidbodyEx a, RigidbodyExData b, KVZHTVWWSES c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "4")]
		public JKEEENUOKZL MACGIBKYWPV(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "5")]
		public NQVNXSUUNLP QCKALGMOCED(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "6")]
		public JHTMSQWZJJE TXHRPAFBBYY(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "7")]
		public QPIAOFKJHLJ FVFNFPLCTYZ(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "8")]
		public GJHJGMOJGDP LNYAAZUTQZB(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "9")]
		public WKHVWTCWKAO NJASMTRNNGE(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "10")]
		public GAAGZQTFUMH VTWJOCWGDRX(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "11")]
		public JEWHYFATOIB GVFOKBRVOAT(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "12")]
		public RVAFLBLRQWB TWHWUBGTLGT(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "13")]
		public EKTYBHJFZKQ CNOUAMRBNCO(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0")]
		public GYIYVUOMNCG EACOSQACLEE(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0")]
		public ZFDUUIXZDZA NVICJMYMHXK(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0")]
		public SNNDTLSZBHG UMSZGCNJLIS(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0")]
		public KKKSIOWAIWM WZFDWQCFVQK(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0")]
		public CWRRGTKENCU WCNNVGKLPXQ(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public BFGEMMXLWSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "14")]
		private GYIYVUOMNCG KGFPFCCVKIY(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "15")]
		private ZFDUUIXZDZA AQKKMDYUOPO(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "16")]
		private SNNDTLSZBHG PSRWKQOLRBA(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "17")]
		private KKKSIOWAIWM YRLKZJUYJBY(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "18")]
		private CWRRGTKENCU COBGMVEMGDE(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(IQECWWRWFGM), new string[] { })]
	public class VBEFKBTLOCQ : IQECWWRWFGM, ZVXNWENCXPY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly IQECWWRWFGM BXRBUPETPDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly IQECWWRWFGM DHVYCSEIEDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private BIHWTDLPPPA SMDKTASSUOF;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private IQECWWRWFGM IFBYJSGXLWC
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xA01C590", Offset = "0xA01AF90", VA = "0x18A01C590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA01C210", Offset = "0xA01AC10", VA = "0x18A01C210", Slot = "20")]
		public void InitReferences(GZOGVDISCYD services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xA01C300", Offset = "0xA01AD00", VA = "0x18A01C300", Slot = "4")]
		public JKEEENUOKZL MACGIBKYWPV(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xA01C4F0", Offset = "0xA01AEF0", VA = "0x18A01C4F0", Slot = "5")]
		public NQVNXSUUNLP QCKALGMOCED(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xA01C690", Offset = "0xA01B090", VA = "0x18A01C690", Slot = "6")]
		public JHTMSQWZJJE TXHRPAFBBYY(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA01C0D0", Offset = "0xA01AAD0", VA = "0x18A01C0D0", Slot = "7")]
		public QPIAOFKJHLJ FVFNFPLCTYZ(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA01C260", Offset = "0xA01AC60", VA = "0x18A01C260", Slot = "8")]
		public GJHJGMOJGDP LNYAAZUTQZB(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xA01C3A0", Offset = "0xA01ADA0", VA = "0x18A01C3A0", Slot = "9")]
		public WKHVWTCWKAO NJASMTRNNGE(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xA01C730", Offset = "0xA01B130", VA = "0x18A01C730", Slot = "10")]
		public GAAGZQTFUMH VTWJOCWGDRX(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xA01C170", Offset = "0xA01AB70", VA = "0x18A01C170", Slot = "11")]
		public JEWHYFATOIB GVFOKBRVOAT(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xA01C5F0", Offset = "0xA01AFF0", VA = "0x18A01C5F0", Slot = "12")]
		public RVAFLBLRQWB TWHWUBGTLGT(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA01BED0", Offset = "0xA01A8D0", VA = "0x18A01BED0", Slot = "13")]
		public EKTYBHJFZKQ CNOUAMRBNCO(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xA01C020", Offset = "0xA01AA20", VA = "0x18A01C020")]
		public GYIYVUOMNCG EACOSQACLEE(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA01BE20", Offset = "0xA01A820", VA = "0x18A01BE20")]
		public ZFDUUIXZDZA NVICJMYMHXK(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA01C440", Offset = "0xA01AE40", VA = "0x18A01C440")]
		public SNNDTLSZBHG UMSZGCNJLIS(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA01C7D0", Offset = "0xA01B1D0", VA = "0x18A01C7D0")]
		public KKKSIOWAIWM WZFDWQCFVQK(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA01BF70", Offset = "0xA01A970", VA = "0x18A01BF70")]
		public CWRRGTKENCU WCNNVGKLPXQ(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA01C880", Offset = "0xA01B280", VA = "0x18A01C880", Slot = "19")]
		public ZQMLMNOMZOF YXLXPOFLABM(RigidbodyEx a, RigidbodyExData b, KVZHTVWWSES c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xA01C9D0", Offset = "0xA01B3D0", VA = "0x18A01C9D0")]
		public VBEFKBTLOCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xA01C020", Offset = "0xA01AA20", VA = "0x18A01C020", Slot = "14")]
		private GYIYVUOMNCG KGFPFCCVKIY(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xA01BE20", Offset = "0xA01A820", VA = "0x18A01BE20", Slot = "15")]
		private ZFDUUIXZDZA AQKKMDYUOPO(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA01C440", Offset = "0xA01AE40", VA = "0x18A01C440", Slot = "16")]
		private SNNDTLSZBHG PSRWKQOLRBA(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xA01C7D0", Offset = "0xA01B1D0", VA = "0x18A01C7D0", Slot = "17")]
		private KKKSIOWAIWM YRLKZJUYJBY(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA01BF70", Offset = "0xA01A970", VA = "0x18A01BF70", Slot = "18")]
		private CWRRGTKENCU COBGMVEMGDE(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface LTMANSUKJGM : JKEEENUOKZL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JTOEXZFXZXN(ZQMLMNOMZOF a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DPCKNIKDXKK(ZQMLMNOMZOF a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JTHTSCJWGLX(ZQMLMNOMZOF a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BNKEOKUUZXS(ZQMLMNOMZOF a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface RBVCPYHKBFR : JHTMSQWZJJE
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		HBQPAPOSXVR<ZQMLMNOMZOF> EOAJMUEBFBE
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		ZQMLMNOMZOF SVLKQHSFGXS
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface JYKOPPSOABB : KKKSIOWAIWM
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) ETSXEXGVDYK(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface OMIPUXXCFTB : ZFDUUIXZDZA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		RRNetworkView TLRGPGOSVGL
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal sealed class OKVUQHAYGYG : RVAFLBLRQWB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly HIFNLBPIGGE BKIOWGXMFXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CollisionDetectionMode GMPFYUCEFLE;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private Rigidbody KHYJRPPXAYM
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xA011B70", Offset = "0xA010570", VA = "0x18A011B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode CUQKHVLOPTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xA011E40", Offset = "0xA010840", VA = "0x18A011E40", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xA011B00", Offset = "0xA010500", VA = "0x18A011B00", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xA009FD0", Offset = "0xA0089D0", VA = "0x18A009FD0")]
		public OKVUQHAYGYG(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xA0119F0", Offset = "0xA0103F0", VA = "0x18A0119F0", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA011F60", Offset = "0xA010960", VA = "0x18A011F60", Slot = "9")]
		public void SFLOTVZQTMB(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xA011FE0", Offset = "0xA0109E0", VA = "0x18A011FE0", Slot = "7")]
		public void XDLGTGYSZCI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xA011F50", Offset = "0xA010950", VA = "0x18A011F50", Slot = "8")]
		public void QSECELRHJCH(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA011CE0", Offset = "0xA0106E0", VA = "0x18A011CE0", Slot = "10")]
		public bool NGVDFSMQMKU(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA011BC0", Offset = "0xA0105C0", VA = "0x18A011BC0")]
		private void LTQBUMSDIAY(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class BRUSRJCDPTZ : WKHVWTCWKAO, IDisposable, YJYLSAGECOQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly HIFNLBPIGGE BKIOWGXMFXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TransformTrackRate ONABLTCMSGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private RYPBBHHSWRP YAQWZXOOTQH;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TransformTrackRate EVUDKCJGMVV
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xA006800", Offset = "0xA005200", VA = "0x18A006800", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xA006A00", Offset = "0xA005400", VA = "0x18A006A00", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform LPUJMUFUMUE
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xA0067E0", Offset = "0xA0051E0", VA = "0x18A0067E0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> IJJTPQCCHKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0xA006950", Offset = "0xA005350", VA = "0x18A006950", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xA006730", Offset = "0xA005130", VA = "0x18A006730", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xA006AD0", Offset = "0xA0054D0", VA = "0x18A006AD0")]
		public BRUSRJCDPTZ(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xA006470", Offset = "0xA004E70", VA = "0x18A006470", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA0066E0", Offset = "0xA0050E0", VA = "0x18A0066E0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x13A1DA0", Offset = "0x13A07A0", VA = "0x1813A1DA0", Slot = "11")]
		private void GDGCTUAUJUT(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "12")]
		private void JJZDSGGWVZF(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class BFGEMMXLWSZ : IQECWWRWFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xA005880", Offset = "0xA004280", VA = "0x18A005880", Slot = "4")]
		public JKEEENUOKZL MACGIBKYWPV(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA005D10", Offset = "0xA004710", VA = "0x18A005D10", Slot = "5")]
		public NQVNXSUUNLP QCKALGMOCED(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA005EE0", Offset = "0xA0048E0", VA = "0x18A005EE0", Slot = "6")]
		public JHTMSQWZJJE TXHRPAFBBYY(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA005690", Offset = "0xA004090", VA = "0x18A005690", Slot = "7")]
		public QPIAOFKJHLJ FVFNFPLCTYZ(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA0057C0", Offset = "0xA0041C0", VA = "0x18A0057C0", Slot = "8")]
		public GJHJGMOJGDP LNYAAZUTQZB(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xA005960", Offset = "0xA004360", VA = "0x18A005960", Slot = "9")]
		public WKHVWTCWKAO NJASMTRNNGE(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA006000", Offset = "0xA004A00", VA = "0x18A006000", Slot = "10")]
		public GAAGZQTFUMH VTWJOCWGDRX(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA005700", Offset = "0xA004100", VA = "0x18A005700", Slot = "11")]
		public JEWHYFATOIB GVFOKBRVOAT(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xA005E20", Offset = "0xA004820", VA = "0x18A005E20", Slot = "12")]
		public RVAFLBLRQWB TWHWUBGTLGT(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA0053D0", Offset = "0xA003DD0", VA = "0x18A0053D0", Slot = "13")]
		public EKTYBHJFZKQ CNOUAMRBNCO(ZQMLMNOMZOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA005560", Offset = "0xA003F60", VA = "0x18A005560")]
		public GYIYVUOMNCG EACOSQACLEE(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA005A20", Offset = "0xA004420", VA = "0x18A005A20")]
		public ZFDUUIXZDZA NVICJMYMHXK(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA005BF0", Offset = "0xA0045F0", VA = "0x18A005BF0")]
		public SNNDTLSZBHG UMSZGCNJLIS(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xA006110", Offset = "0xA004B10", VA = "0x18A006110")]
		public KKKSIOWAIWM WZFDWQCFVQK(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xA005490", Offset = "0xA003E90", VA = "0x18A005490")]
		public CWRRGTKENCU WCNNVGKLPXQ(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xA0062A0", Offset = "0xA004CA0", VA = "0x18A0062A0", Slot = "19")]
		public ZQMLMNOMZOF YXLXPOFLABM(RigidbodyEx a, RigidbodyExData b, KVZHTVWWSES c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public BFGEMMXLWSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xA005560", Offset = "0xA003F60", VA = "0x18A005560", Slot = "14")]
		private GYIYVUOMNCG KGFPFCCVKIY(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xA0053C0", Offset = "0xA003DC0", VA = "0x18A0053C0", Slot = "15")]
		private ZFDUUIXZDZA AQKKMDYUOPO(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xA005BF0", Offset = "0xA0045F0", VA = "0x18A005BF0", Slot = "16")]
		private SNNDTLSZBHG PSRWKQOLRBA(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xA006110", Offset = "0xA004B10", VA = "0x18A006110", Slot = "17")]
		private KKKSIOWAIWM YRLKZJUYJBY(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA005490", Offset = "0xA003E90", VA = "0x18A005490", Slot = "18")]
		private CWRRGTKENCU COBGMVEMGDE(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal sealed class ZMDWZIIZEEE : JEWHYFATOIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly HIFNLBPIGGE BKIOWGXMFXL;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody KHYJRPPXAYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0xA011B70", Offset = "0xA010570", VA = "0x18A011B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool AFOBOGMJGQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xA01FE10", Offset = "0xA01E810", VA = "0x18A01FE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool QXSCYEDOSSQ
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0xA00A4A0", Offset = "0xA008EA0", VA = "0x18A00A4A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private ZQMLMNOMZOF JRPWOYBYXDS
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0xA01F530", Offset = "0xA01DF30", VA = "0x18A01F530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA009FD0", Offset = "0xA0089D0", VA = "0x18A009FD0")]
		public ZMDWZIIZEEE(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA01F590", Offset = "0xA01DF90", VA = "0x18A01F590", Slot = "4")]
		public void GKJMLDQMPPI(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xA01FBB0", Offset = "0xA01E5B0", VA = "0x18A01FBB0")]
		private void QHDWGFTXNIV(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xA01FE60", Offset = "0xA01E860", VA = "0x18A01FE60", Slot = "5")]
		public void XUZKGSGBWEU(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xA0200E0", Offset = "0xA01EAE0", VA = "0x18A0200E0", Slot = "6")]
		public void XZHSZBOKJON(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xA01F950", Offset = "0xA01E350", VA = "0x18A01F950")]
		private void OLZXFWOZEUQ(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA01F6F0", Offset = "0xA01E0F0", VA = "0x18A01F6F0", Slot = "7")]
		public void LOALQDTSCIF(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class DRDTJYFPLRX : EKTYBHJFZKQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly HIFNLBPIGGE BKIOWGXMFXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool GZPTVSXSXZB;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool XBTGJQDHCAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xE70C80", Offset = "0xE6F680", VA = "0x180E70C80", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xA009EC0", Offset = "0xA0088C0", VA = "0x18A009EC0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA009FD0", Offset = "0xA0089D0", VA = "0x18A009FD0")]
		public DRDTJYFPLRX(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xA009E90", Offset = "0xA008890", VA = "0x18A009E90", Slot = "6")]
		public void SFLOTVZQTMB(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xA009E20", Offset = "0xA008820", VA = "0x18A009E20", Slot = "7")]
		public void IZYWWPLXOZM(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RbexHierarchy : LTMANSUKJGM, JKEEENUOKZL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly ZQMLMNOMZOF BKIOWGXMFXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<ZQMLMNOMZOF> HJRGCJDGPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private ZQMLMNOMZOF XBKNLMWAWOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private ZQMLMNOMZOF TSUTPHIUZAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform MLBLVOKIMED;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private Transform QSGLKOZVOYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0xA013AB0", Offset = "0xA0124B0", VA = "0x18A013AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public ZQMLMNOMZOF JRPWOYBYXDS
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xCDB1B0", Offset = "0xCD9BB0", VA = "0x180CDB1B0", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xA0130C0", Offset = "0xA011AC0", VA = "0x18A0130C0", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public ZQMLMNOMZOF LJEDQXPUPWM
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xCD9880", Offset = "0xCD8280", VA = "0x180CD9880", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<ZQMLMNOMZOF> JQSYRUQJNGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xCD5900", Offset = "0xCD4300", VA = "0x180CD5900", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction JSHYSEORPJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0xA012880", Offset = "0xA011280", VA = "0x18A012880", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0xA0136C0", Offset = "0xA0120C0", VA = "0x18A0136C0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction NCOVUYOXOIW
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0xA0141C0", Offset = "0xA012BC0", VA = "0x18A0141C0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xA013A10", Offset = "0xA012410", VA = "0x18A013A10", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction HFBDPZFCSXK
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0xA0143B0", Offset = "0xA012DB0", VA = "0x18A0143B0", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0xA013020", Offset = "0xA011A20", VA = "0x18A013020", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action QIQOYTOVAEN
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xA014450", Offset = "0xA012E50", VA = "0x18A014450", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0xA013760", Offset = "0xA012160", VA = "0x18A013760", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action GEIOHSUZIDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xA012D80", Offset = "0xA011780", VA = "0x18A012D80", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0xA012F80", Offset = "0xA011980", VA = "0x18A012F80", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<ZQMLMNOMZOF> VNDXYTGHXBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0xA0127D0", Offset = "0xA0111D0", VA = "0x18A0127D0", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xA012720", Offset = "0xA011120", VA = "0x18A012720", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<ZQMLMNOMZOF> BMDIGRIZSNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0xA012E20", Offset = "0xA011820", VA = "0x18A012E20", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0xA012ED0", Offset = "0xA0118D0", VA = "0x18A012ED0", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action QTKEDVXMQGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0xA013620", Offset = "0xA012020", VA = "0x18A013620", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0xA012CE0", Offset = "0xA0116E0", VA = "0x18A012CE0", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<ZQMLMNOMZOF> UASIKDWRSDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0xA013800", Offset = "0xA012200", VA = "0x18A013800", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0xA014260", Offset = "0xA012C60", VA = "0x18A014260", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA0144F0", Offset = "0xA012EF0", VA = "0x18A0144F0")]
		public RbexHierarchy(ZQMLMNOMZOF rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA012C40", Offset = "0xA011640", VA = "0x18A012C40", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA013C50", Offset = "0xA012650", VA = "0x18A013C50", Slot = "30")]
		public void SetParent(ZQMLMNOMZOF newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xA0130D0", Offset = "0xA011AD0", VA = "0x18A0130D0", Slot = "6")]
		public void JTHTSCJWGLX(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA012920", Offset = "0xA011320", VA = "0x18A012920", Slot = "7")]
		public void BNKEOKUUZXS(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xA013340", Offset = "0xA011D40", VA = "0x18A013340", Slot = "4")]
		public void JTOEXZFXZXN(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xA012BA0", Offset = "0xA0115A0", VA = "0x18A012BA0", Slot = "5")]
		public void DPCKNIKDXKK(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xA014310", Offset = "0xA012D10", VA = "0x18A014310")]
		private void XKBVTNOYEUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xA0139D0", Offset = "0xA0123D0", VA = "0x18A0139D0")]
		private void QHPYOQCIFLK(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA013B10", Offset = "0xA012510", VA = "0x18A013B10")]
		private void SSEWXLPDBPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA0134F0", Offset = "0xA011EF0", VA = "0x18A0134F0")]
		private void MBRXUZZLGVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA0138B0", Offset = "0xA0122B0", VA = "0x18A0138B0")]
		private void PPTZMFHSJZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA013430", Offset = "0xA011E30", VA = "0x18A013430")]
		[CompilerGenerated]
		private object KFTMCBDGEZC()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class TFQZYCGZCQC
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xA019E30", Offset = "0xA018830", VA = "0x18A019E30")]
		public static LTMANSUKJGM ELOFUECFTHN(this ZQMLMNOMZOF a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class AADXXSGMVNV : RBVCPYHKBFR, JHTMSQWZJJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly HIFNLBPIGGE BKIOWGXMFXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly HBQPAPOSXVR<ZQMLMNOMZOF> DGRZIMJDLKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool JDXMJJTTDGD;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public HBQPAPOSXVR<ZQMLMNOMZOF> EOAJMUEBFBE
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 XHKDYATUGUB
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xA005180", Offset = "0xA003B80", VA = "0x18A005180", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 YWLBZGMWSJV
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xA004600", Offset = "0xA003000", VA = "0x18A004600", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 RRMSKUFHRKD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xA0050A0", Offset = "0xA003AA0", VA = "0x18A0050A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public ZQMLMNOMZOF SVLKQHSFGXS
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xA005220", Offset = "0xA003C20", VA = "0x18A005220", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA0052D0", Offset = "0xA003CD0", VA = "0x18A0052D0")]
		public AADXXSGMVNV(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA0051B0", Offset = "0xA003BB0", VA = "0x18A0051B0", Slot = "8")]
		public void RTLNHPRCOST(ZQMLMNOMZOF a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA004900", Offset = "0xA003300", VA = "0x18A004900", Slot = "9")]
		public void KFKFCROKLXS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA004D00", Offset = "0xA003700", VA = "0x18A004D00")]
		private Vector3 MAVKOTEVMLP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA004960", Offset = "0xA003360", VA = "0x18A004960")]
		private void LFVTHOCPXBM(ZQMLMNOMZOF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class XNCPJVPDMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA01CB30", Offset = "0xA01B530", VA = "0x18A01CB30")]
		public static RBVCPYHKBFR OTSYKFGAFJS(this ZQMLMNOMZOF a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class YACWFPHJMYP : JYKOPPSOABB, KKKSIOWAIWM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly HIFNLBPIGGE BKIOWGXMFXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly OverridableVector3 GGIJWRPKBVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly OverridableVector3 MKXDVVTFQKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private float APYIFBQHTLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float QMVUVLDZUSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3 NFZPKENITAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Vector3? CNLGXSJTHTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Quaternion? ZGRDQAJHYVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool TOFEOWQBRCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool WRWAZCBIQWB;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 RTSRSJGUZUD
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1ECC680", Offset = "0x1ECB080", VA = "0x181ECC680", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xA01DE30", Offset = "0xA01C830", VA = "0x18A01DE30", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 JUKRVYKYXIY
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0xA01EF00", Offset = "0xA01D900", VA = "0x18A01EF00", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float FKZAPSBNKFK
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xD23370", Offset = "0xD21D70", VA = "0x180D23370", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xA01EB90", Offset = "0xA01D590", VA = "0x18A01EB90")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float LIJZLPMOYEX
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xD23380", Offset = "0xD21D80", VA = "0x180D23380", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xA01EAE0", Offset = "0xA01D4E0", VA = "0x18A01EAE0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 OHPFTSWFABZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xA01F240", Offset = "0xA01DC40", VA = "0x18A01F240", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion KTUEOSYXGBL
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xA01ED80", Offset = "0xA01D780", VA = "0x18A01ED80", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody KHYJRPPXAYM
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xA01A370", Offset = "0xA018D70", VA = "0x18A01A370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction KRWPXBXGVNU
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xA01E1E0", Offset = "0xA01CBE0", VA = "0x18A01E1E0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xA01F020", Offset = "0xA01DA20", VA = "0x18A01F020", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xA01F3D0", Offset = "0xA01DDD0", VA = "0x18A01F3D0")]
		public YACWFPHJMYP(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA01DEE0", Offset = "0xA01C8E0", VA = "0x18A01DEE0", Slot = "17")]
		public void IDSDGUINODT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA01E280", Offset = "0xA01CC80", VA = "0x18A01E280", Slot = "16")]
		public void KZPXHKZDQGW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA01ECA0", Offset = "0xA01D6A0", VA = "0x18A01ECA0", Slot = "19")]
		public void SFLOTVZQTMB(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA01E000", Offset = "0xA01CA00", VA = "0x18A01E000", Slot = "20")]
		public void IZYWWPLXOZM(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA01E480", Offset = "0xA01CE80", VA = "0x18A01E480", Slot = "18")]
		public void OCOWWDWRTCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA01E620", Offset = "0xA01D020", VA = "0x18A01E620", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA01DE30", Offset = "0xA01C830", VA = "0x18A01DE30")]
		private void GUBYKMFRKKD(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA01E360", Offset = "0xA01CD60", VA = "0x18A01E360")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 MBODMGFKGEQ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xA01EB90", Offset = "0xA01D590", VA = "0x18A01EB90")]
		private void XNQEMTLRCLG(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xA01EAE0", Offset = "0xA01D4E0", VA = "0x18A01EAE0")]
		private void PLIBBLCHQOD(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xA01DC90", Offset = "0xA01C690", VA = "0x18A01DC90")]
		private Vector3 EXAPFCPGOJV()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xA01CBF0", Offset = "0xA01B5F0", VA = "0x18A01CBF0", Slot = "15")]
		public void BQHFSGTYFXJ((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xA01F0C0", Offset = "0xA01DAC0", VA = "0x18A01F0C0")]
		private Quaternion YHNATNTARAF()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xA01CE20", Offset = "0xA01B820", VA = "0x18A01CE20")]
		public void ETSXEXGVDYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA01CEF0", Offset = "0xA01B8F0", VA = "0x18A01CEF0", Slot = "4")]
		public (float, Vector3) ETSXEXGVDYK(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class IGOSVCMXFXX
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xA011130", Offset = "0xA00FB30", VA = "0x18A011130")]
		public static JYKOPPSOABB HXENHROSQUS(this ZQMLMNOMZOF a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class KZORFPHTMGJ : SNNDTLSZBHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly HIFNLBPIGGE BKIOWGXMFXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly OZHUFMCFCAS XXGMPGNJBSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly RbexInterpolationMode BYIXLUHOLQJ;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool UUSIYHXQHUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1B59A10", Offset = "0x1B58410", VA = "0x181B59A10", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode GJZIEZBJWHB
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xCE2550", Offset = "0xCE0F50", VA = "0x180CE2550", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA011800", Offset = "0xA010200", VA = "0x18A011800")]
		public KZORFPHTMGJ(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA0111F0", Offset = "0xA00FBF0", VA = "0x18A0111F0", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA011530", Offset = "0xA00FF30", VA = "0x18A011530")]
		private bool KRYTZVNBWVD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA0117D0", Offset = "0xA0101D0", VA = "0x18A0117D0", Slot = "5")]
		public void TGALTDNZKCP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA0112C0", Offset = "0xA00FCC0", VA = "0x18A0112C0", Slot = "6")]
		public void CMVRWTOEGUS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA0112F0", Offset = "0xA00FCF0", VA = "0x18A0112F0", Slot = "9")]
		public void GAOEWZDTZHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA011420", Offset = "0xA00FE20", VA = "0x18A011420")]
		private void KLHPBEBQUPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA011650", Offset = "0xA010050", VA = "0x18A011650")]
		private void REXKRRTUJSV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA011610", Offset = "0xA010010", VA = "0x18A011610", Slot = "8")]
		public void OQUIPOUHCGR(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA0115D0", Offset = "0xA00FFD0", VA = "0x18A0115D0", Slot = "7")]
		public void ODYENNELAAC(ZQMLMNOMZOF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class QZAEZAEKPOO : GAAGZQTFUMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly HIFNLBPIGGE BKIOWGXMFXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly OZHUFMCFCAS TQFBVWDXVBV;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool AFOBOGMJGQR
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xA012430", Offset = "0xA010E30", VA = "0x18A012430", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction GZAUIERVCUH
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xA012390", Offset = "0xA010D90", VA = "0x18A012390", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xA0125A0", Offset = "0xA010FA0", VA = "0x18A0125A0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA012640", Offset = "0xA011040", VA = "0x18A012640")]
		public QZAEZAEKPOO(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA012380", Offset = "0xA010D80", VA = "0x18A012380", Slot = "7")]
		public void PAHPFVUNPZK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA012230", Offset = "0xA010C30", VA = "0x18A012230", Slot = "8")]
		public void BAFTEKBKLSZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA012270", Offset = "0xA010C70", VA = "0x18A012270", Slot = "9")]
		public void OGOSDAOGOQJ(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA012560", Offset = "0xA010F60", VA = "0x18A012560", Slot = "12")]
		public void WKWKJGNLMYX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA0124E0", Offset = "0xA010EE0", VA = "0x18A0124E0", Slot = "10")]
		public void SFLOTVZQTMB(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA012240", Offset = "0xA010C40", VA = "0x18A012240", Slot = "11")]
		public void IZYWWPLXOZM(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class USSQRITFFHN : OMIPUXXCFTB, ZFDUUIXZDZA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private WeakReference<ZQMLMNOMZOF> WQTLWEKMUUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly HIFNLBPIGGE BKIOWGXMFXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private RRNetworkView UHBOOXCZBSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool ANQVBKQXAMK;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public RRNetworkView TLRGPGOSVGL
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool UPULZZDYYNO
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xA01BC70", Offset = "0xA01A670", VA = "0x18A01BC70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool OOZXOXOZHXA
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xD2E420", Offset = "0xD2CE20", VA = "0x180D2E420", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction TJCGOVKNSRN
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xA01BA60", Offset = "0xA01A460", VA = "0x18A01BA60", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xA01B110", Offset = "0xA019B10", VA = "0x18A01B110", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA01BC80", Offset = "0xA01A680", VA = "0x18A01BC80")]
		public USSQRITFFHN(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA01AE90", Offset = "0xA019890", VA = "0x18A01AE90", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xA01B1B0", Offset = "0xA019BB0", VA = "0x18A01B1B0", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA01B4E0", Offset = "0xA019EE0", VA = "0x18A01B4E0", Slot = "10")]
		public void FXMPDVLCSQM(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA01B670", Offset = "0xA01A070", VA = "0x18A01B670", Slot = "11")]
		public void GHREAUXCFTG(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA01BB00", Offset = "0xA01A500", VA = "0x18A01BB00")]
		private void QWBWHEVXUBW(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA01AFC0", Offset = "0xA0199C0", VA = "0x18A01AFC0")]
		private void BEPPQMOZERK(KMOQKJRUHKT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA01B7F0", Offset = "0xA01A1F0", VA = "0x18A01B7F0")]
		private void HGFVCBYDANP(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class WYAWJHPSUHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA01CA70", Offset = "0xA01B470", VA = "0x18A01CA70")]
		public static OMIPUXXCFTB Lifecycle(this ZQMLMNOMZOF impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class DNOHKQBXLWP : CWRRGTKENCU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly HIFNLBPIGGE BKIOWGXMFXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private RigidbodyConstraints ZLEFJCDYHCQ;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool TEABYKKZBIH
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xE6DD30", Offset = "0xE6C730", VA = "0x180E6DD30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xEB1710", Offset = "0xEB0110", VA = "0x180EB1710", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool CICJRTSVIKW
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xEB0FE0", Offset = "0xEAF9E0", VA = "0x180EB0FE0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xEB1190", Offset = "0xEAFB90", VA = "0x180EB1190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints QAVYICNEWFG
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xCD36A0", Offset = "0xCD20A0", VA = "0x180CD36A0", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xA009BE0", Offset = "0xA0085E0", VA = "0x18A009BE0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA009D70", Offset = "0xA008770", VA = "0x18A009D70")]
		public DNOHKQBXLWP(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xA009D40", Offset = "0xA008740", VA = "0x18A009D40", Slot = "9")]
		public void SFLOTVZQTMB(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA009D10", Offset = "0xA008710", VA = "0x18A009D10", Slot = "10")]
		public void IZYWWPLXOZM(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class ZQPOHEILRVC : QPIAOFKJHLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly ZQMLMNOMZOF BKIOWGXMFXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private float EMEWXVDOGEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private float EIUOWYYDWWY;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public float UTUKDVVIXFI
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xD38780", Offset = "0xD37180", VA = "0x180D38780", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xA0203B0", Offset = "0xA01EDB0", VA = "0x18A0203B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float YNPJGOPKEOI
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xD38790", Offset = "0xD37190", VA = "0x180D38790", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xA020240", Offset = "0xA01EC40", VA = "0x18A020240", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA0204D0", Offset = "0xA01EED0", VA = "0x18A0204D0")]
		public ZQPOHEILRVC(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA020480", Offset = "0xA01EE80", VA = "0x18A020480", Slot = "8")]
		public void SFLOTVZQTMB(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA020310", Offset = "0xA01ED10", VA = "0x18A020310", Slot = "9")]
		public void IZYWWPLXOZM(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class UGKGCSJLSEQ : GJHJGMOJGDP
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly Log RDMBDTFBSJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly HIFNLBPIGGE BKIOWGXMFXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool IUZPKYTUYRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool RAZINZMZBQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int LXDSVJEHHZA;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private Rigidbody KHYJRPPXAYM
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xA01A370", Offset = "0xA018D70", VA = "0x18A01A370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool VKCHPPNDMAD
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xA01A1C0", Offset = "0xA018BC0", VA = "0x18A01A1C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private ZQMLMNOMZOF JRPWOYBYXDS
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0xA01A1E0", Offset = "0xA018BE0", VA = "0x18A01A1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool QXSCYEDOSSQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xA01A910", Offset = "0xA019310", VA = "0x18A01A910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction EZKQRLZNXRX
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0xA01A2D0", Offset = "0xA018CD0", VA = "0x18A01A2D0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xA01AB30", Offset = "0xA019530", VA = "0x18A01AB30", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA01AE00", Offset = "0xA019800", VA = "0x18A01AE00")]
		public UGKGCSJLSEQ(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA01A240", Offset = "0xA018C40", VA = "0x18A01A240", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA01A6A0", Offset = "0xA0190A0", VA = "0x18A01A6A0", Slot = "8")]
		public void IRFSDQCMLMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA01A550", Offset = "0xA018F50", VA = "0x18A01A550", Slot = "7")]
		public bool IOVKONZTROR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA01AA60", Offset = "0xA019460", VA = "0x18A01AA60", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xA01A6B0", Offset = "0xA0190B0", VA = "0x18A01A6B0", Slot = "13")]
		public void JUTDFRJASKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xA01AC40", Offset = "0xA019640", VA = "0x18A01AC40", Slot = "12")]
		public void YXQJBVLYDEE(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA01ABD0", Offset = "0xA0195D0", VA = "0x18A01ABD0", Slot = "10")]
		public bool XSFUDDBFDJJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA01A970", Offset = "0xA019370", VA = "0x18A01A970", Slot = "11")]
		public bool NRYNWDHXDYO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA01A750", Offset = "0xA019150", VA = "0x18A01A750")]
		private bool KSOSXCAFOEI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA01A3C0", Offset = "0xA018DC0", VA = "0x18A01A3C0")]
		private void FHNYWXQGYBE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class EZDJEXZELND : GYIYVUOMNCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly HIFNLBPIGGE BKIOWGXMFXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly OZHUFMCFCAS LFNVIEZNUZD;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Rigidbody KHYJRPPXAYM
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xCD27D0", Offset = "0xCD11D0", VA = "0x180CD27D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool QXSCYEDOSSQ
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0xA00A4A0", Offset = "0xA008EA0", VA = "0x18A00A4A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool TLWXIGUCRUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1B59A10", Offset = "0x1B58410", VA = "0x181B59A10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA00A860", Offset = "0xA009260", VA = "0x18A00A860")]
		public EZDJEXZELND(ZQMLMNOMZOF a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA00A060", Offset = "0xA008A60", VA = "0x18A00A060", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA00A2F0", Offset = "0xA008CF0", VA = "0x18A00A2F0", Slot = "7")]
		public void DXKCMOTVTOD(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xA00A500", Offset = "0xA008F00", VA = "0x18A00A500", Slot = "8")]
		public void SJBKOBVMAWG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA00A530", Offset = "0xA008F30", VA = "0x18A00A530", Slot = "9")]
		public void VJVVOZSMGRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA00A100", Offset = "0xA008B00", VA = "0x18A00A100", Slot = "10")]
		public void BYFRZTQCRCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA00A320", Offset = "0xA008D20", VA = "0x18A00A320", Slot = "11")]
		public void KZZUNQJEJSX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class CMFHMCOPZPQ : NQVNXSUUNLP, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly HIFNLBPIGGE BKIOWGXMFXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly OZHUFMCFCAS XINGOIEUIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private float RNDOLPYZEVR;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public ZOVUKJMZZZX AOKCYJWQPTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xCD27E0", Offset = "0xCD11E0", VA = "0x180CD27E0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public VHPXXKFPOWQ NKQIKWRUTWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CD0", Offset = "0xCD26D0", VA = "0x180CD3CD0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CE0", Offset = "0xCD26E0", VA = "0x180CD3CE0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 RRMSKUFHRKD
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xA007DD0", Offset = "0xA0067D0", VA = "0x18A007DD0", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xA007A20", Offset = "0xA006420", VA = "0x18A007A20", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 JIKKNTHRKPC
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xA008540", Offset = "0xA006F40", VA = "0x18A008540", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0xA008510", Offset = "0xA006F10", VA = "0x18A008510", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 YDFIVHFCMMV
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xA006DD0", Offset = "0xA0057D0", VA = "0x18A006DD0", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xA007960", Offset = "0xA006360", VA = "0x18A007960", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 SRVMSSDTLQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xA008B40", Offset = "0xA007540", VA = "0x18A008B40", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xA007CC0", Offset = "0xA0066C0", VA = "0x18A007CC0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float IDSRIGGLLPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xD38680", Offset = "0xD37080", VA = "0x180D38680", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xA0086C0", Offset = "0xA0070C0", VA = "0x18A0086C0", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool UGGLONJZEKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x25DC180", Offset = "0x25DAB80", VA = "0x1825DC180", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private JEWHYFATOIB DAGYHBQIMHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x953C390", Offset = "0x953AD90", VA = "0x18953C390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool VKCHPPNDMAD
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0xA006B60", Offset = "0xA005560", VA = "0x18A006B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA009A30", Offset = "0xA008430", VA = "0x18A009A30")]
		public CMFHMCOPZPQ(ZQMLMNOMZOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA006B80", Offset = "0xA005580", VA = "0x18A006B80", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA007900", Offset = "0xA006300", VA = "0x18A007900", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA008830", Offset = "0xA007230", VA = "0x18A008830", Slot = "28")]
		public void SFLOTVZQTMB(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x18E4870", Offset = "0x18E3270", VA = "0x1818E4870", Slot = "20")]
		public void VCVIRJPCGTN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x18E63A0", Offset = "0x18E4DA0", VA = "0x1818E63A0", Slot = "30")]
		public void EKQIPZZIGAO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA008960", Offset = "0xA007360", VA = "0x18A008960", Slot = "35")]
		public Vector3 SMGJFHJSFJZ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA009870", Offset = "0xA008270", VA = "0x18A009870", Slot = "34")]
		public Vector3 ZVJHSEUXEDP(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA006B80", Offset = "0xA005580", VA = "0x18A006B80", Slot = "27")]
		public void RYCXBTSDDBQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA007AE0", Offset = "0xA0064E0", VA = "0x18A007AE0", Slot = "25")]
		public void IPEHKIECNGX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA009810", Offset = "0xA008210", VA = "0x18A009810", Slot = "24")]
		public void ZHKANFLSSCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA0092E0", Offset = "0xA007CE0", VA = "0x18A0092E0", Slot = "33")]
		public void XYWNSMXCFWW(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA0087D0", Offset = "0xA0071D0", VA = "0x18A0087D0", Slot = "32")]
		public void SFBTBVIHMQD(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA006C30", Offset = "0xA005630", VA = "0x18A006C30", Slot = "31")]
		public void BOHURHYOJVQ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA007130", Offset = "0xA005B30", VA = "0x18A007130", Slot = "22")]
		public void BWVSFQYSBMQ(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA007680", Offset = "0xA006080", VA = "0x18A007680", Slot = "21")]
		public void CMRSIBZELEJ(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA007F90", Offset = "0xA006990", VA = "0x18A007F90", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void PDOVLGASFHY(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1A45680", Offset = "0x1A44080", VA = "0x181A45680")]
		private static void CSOCTYNSGJE(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xA007CF0", Offset = "0xA0066F0", VA = "0x18A007CF0", Slot = "29")]
		public Vector3 LVCGTJTZAHV(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xA008380", Offset = "0xA006D80", VA = "0x18A008380", Slot = "26")]
		public void PELUKPZRVUW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA0086C0", Offset = "0xA0070C0", VA = "0x18A0086C0")]
		private void VMGSHYNAUWX(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA006F90", Offset = "0xA005990", VA = "0x18A006F90")]
		private void BUFKCECWQXZ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA007B40", Offset = "0xA006540", VA = "0x18A007B40")]
		private Vector3 KEMPFJKMMNK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA009520", Offset = "0xA007F20", VA = "0x18A009520")]
		private void YZQKMJTXVAU(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA009150", Offset = "0xA007B50", VA = "0x18A009150")]
		private Vector3 WYEALHDXNIU()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA008CD0", Offset = "0xA0076D0", VA = "0x18A008CD0")]
		private void WUFWHKWRPOM(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		private void NBRNLARBZOH(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		private void ZVMDUEJXEFL()
		{
		}
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
