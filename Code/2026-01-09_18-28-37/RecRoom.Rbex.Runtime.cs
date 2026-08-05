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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
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
		[Cpp2IlInjected.Address(RVA = "0x89C1A50", Offset = "0x89C0E50", VA = "0x1889C1A50", Slot = "4")]
		public override void MKOAUOREKWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		private int[] NXGLGIJHSDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset XVMTEOAFOEZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83B9A70", Offset = "0x83B8E70", VA = "0x1883B9A70", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89D8060", Offset = "0x89D7460", VA = "0x1889D8060")]
		private void CRWDOIATXLP(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89D8340", Offset = "0x89D7740", VA = "0x1889D8340", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x89D83A0", Offset = "0x89D77A0", VA = "0x1889D83A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, HUFBFJCMRYV, BOJTUJLTPPK, JLRXPIRKBHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log WJQKGVLQZHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool MOTNQRPGFVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private MDCMMOLPXKD VLGTINZOLTO;

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
		private Transform YZTYANYVEYA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal MDCMMOLPXKD QIQQQQEHKTC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x89C8260", Offset = "0x89C7660", VA = "0x1889C8260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private MDCMMOLPXKD MOYMQQEVWYC
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int TJIWMDMPAZV
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x89C97F0", Offset = "0x89C8BF0", VA = "0x1889C97F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx QYAHVALXEWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x89C9B50", Offset = "0x89C8F50", VA = "0x1889C9B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx TMZYFPRTZJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x89C9A90", Offset = "0x89C8E90", VA = "0x1889C9A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx ZXFWECNPPKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x89CA750", Offset = "0x89C9B50", VA = "0x1889CA750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x89CBC50", Offset = "0x89CB050", VA = "0x1889CBC50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7DBCB90", Offset = "0x7DBBF90", VA = "0x187DBCB90", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7DBCCE0", Offset = "0x7DBC0E0", VA = "0x187DBCCE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform FSOLSSJPOTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2309FA0", Offset = "0x23093A0", VA = "0x182309FA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform LCGYRYQQIFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2309FA0", Offset = "0x23093A0", VA = "0x182309FA0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform NSXXMNYPWZL
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2309FA0", Offset = "0x23093A0", VA = "0x182309FA0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate ZGTBVLTOFYJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x89C9850", Offset = "0x89C8C50", VA = "0x1889C9850")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x89CB400", Offset = "0x89CA800", VA = "0x1889CB400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool JUNNLNCQZYK
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x89C9E60", Offset = "0x89C9260", VA = "0x1889C9E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool FVFPRBKGTII
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x89C9970", Offset = "0x89C8D70", VA = "0x1889C9970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public XVPZTDGMZUH FJTLXJRRRFC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x89C9DA0", Offset = "0x89C91A0", VA = "0x1889C9DA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x89CB5C0", Offset = "0x89CA9C0", VA = "0x1889CB5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TLELRAOYGZE FTOHZJUUMFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x89C9D40", Offset = "0x89C9140", VA = "0x1889C9D40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x89CB550", Offset = "0x89CA950", VA = "0x1889CB550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool XLGWMCPNLYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x89C9C90", Offset = "0x89C9090", VA = "0x1889C9C90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody GAGOAANQFGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x89C9CF0", Offset = "0x89C90F0", VA = "0x1889C9CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool VZYSUFANUWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x89C99D0", Offset = "0x89C8DD0", VA = "0x1889C99D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x89CB470", Offset = "0x89CA870", VA = "0x1889CB470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool WSEQRESYWZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x16F24E0", Offset = "0x16F18E0", VA = "0x1816F24E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float NQTYBLKJNEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x89CA6F0", Offset = "0x89C9AF0", VA = "0x1889CA6F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float OFYNKIBRSGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x89CA690", Offset = "0x89C9A90", VA = "0x1889CA690")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x89CBBE0", Offset = "0x89CAFE0", VA = "0x1889CBBE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float OFNYXEHXYRK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x89CA0C0", Offset = "0x89C94C0", VA = "0x1889CA0C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x89CB860", Offset = "0x89CAC60", VA = "0x1889CB860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float SAVMORBXMVQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x89C9EC0", Offset = "0x89C92C0", VA = "0x1889C9EC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x89CB630", Offset = "0x89CAA30", VA = "0x1889CB630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool WFMKDBQFYMF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x89CACA0", Offset = "0x89CA0A0", VA = "0x1889CACA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x89CC190", Offset = "0x89CB590", VA = "0x1889CC190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 LPWXVTIPJOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x89CA470", Offset = "0x89C9870", VA = "0x1889CA470")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x89CB9B0", Offset = "0x89CADB0", VA = "0x1889CB9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 WZFJSZSEQWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x89CADE0", Offset = "0x89CA1E0", VA = "0x1889CADE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode VMBHPSWWRDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x89CA000", Offset = "0x89C9400", VA = "0x1889CA000")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x89CB780", Offset = "0x89CAB80", VA = "0x1889CB780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float LVTYNGFZNTH
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x89C9A30", Offset = "0x89C8E30", VA = "0x1889C9A30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x89CB4E0", Offset = "0x89CA8E0", VA = "0x1889CB4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints XYYIDYRHUCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x89CA060", Offset = "0x89C9460", VA = "0x1889CA060")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x89CB7F0", Offset = "0x89CABF0", VA = "0x1889CB7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 DPWLYPZXMCU
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x89CA810", Offset = "0x89C9C10", VA = "0x1889CA810")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 IKGRELIRMYY
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x89CA810", Offset = "0x89C9C10", VA = "0x1889CA810")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x89CBF70", Offset = "0x89CB370", VA = "0x1889CBF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float MTKIEGCGTPF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x89CA550", Offset = "0x89C9950", VA = "0x1889CA550")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x89CBA90", Offset = "0x89CAE90", VA = "0x1889CBA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float NIONXFGMTOU
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x89CAC40", Offset = "0x89CA040", VA = "0x1889CAC40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x89CC120", Offset = "0x89CB520", VA = "0x1889CC120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion WISEIZYEMWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x89CA8F0", Offset = "0x89C9CF0", VA = "0x1889CA8F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x89CBCF0", Offset = "0x89CB0F0", VA = "0x1889CBCF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion DXLYRDCZVDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x89CAB70", Offset = "0x89C9F70", VA = "0x1889CAB70")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x89CC050", Offset = "0x89CB450", VA = "0x1889CC050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 NOZWOVZZWLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x89CA9C0", Offset = "0x89C9DC0", VA = "0x1889CA9C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x89CBDC0", Offset = "0x89CB1C0", VA = "0x1889CBDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion TZRKGJGGPOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x89CAAA0", Offset = "0x89C9EA0", VA = "0x1889CAAA0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x89CBEA0", Offset = "0x89CB2A0", VA = "0x1889CBEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 VTAAIVYJOER
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x89CAD00", Offset = "0x89CA100", VA = "0x1889CAD00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x89CC200", Offset = "0x89CB600", VA = "0x1889CC200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 JOVMOBLIHYC
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x89CA5B0", Offset = "0x89C99B0", VA = "0x1889CA5B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x89CBB00", Offset = "0x89CAF00", VA = "0x1889CBB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 UKKNEWULPCD
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x89C9F20", Offset = "0x89C9320", VA = "0x1889C9F20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x89CB6A0", Offset = "0x89CAAA0", VA = "0x1889CB6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 WPEIYJFFSTE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x89CA390", Offset = "0x89C9790", VA = "0x1889CA390")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x89CB8D0", Offset = "0x89CACD0", VA = "0x1889CB8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 XDTHTRSBLGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x89CA250", Offset = "0x89C9650", VA = "0x1889CA250")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion UYTJQKECIMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x89CA180", Offset = "0x89C9580", VA = "0x1889CA180")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 SHSPQNWZYVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x89CAFA0", Offset = "0x89CA3A0", VA = "0x1889CAFA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 LSCEQBUCCJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x89CAEC0", Offset = "0x89CA2C0", VA = "0x1889CAEC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool VNHHABICURR
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x89CA330", Offset = "0x89C9730", VA = "0x1889CA330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool TCBVDLZRTHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x89C9E00", Offset = "0x89C9200", VA = "0x1889C9E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool VIPNMFQAMZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x89C9910", Offset = "0x89C8D10", VA = "0x1889C9910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool FKESJWGDEHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x89C98B0", Offset = "0x89C8CB0", VA = "0x1889C98B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool MRWEKSWZJNN
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x89C9790", Offset = "0x89C8B90", VA = "0x1889C9790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool FZAWWNXQMLU
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x89CA120", Offset = "0x89C9520", VA = "0x1889CA120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool ZDENQPSNMIA
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xB662B0", Offset = "0xB656B0", VA = "0x180B662B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction ELQQOBGRMYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x89C96B0", Offset = "0x89C8AB0", VA = "0x1889C96B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x89CB320", Offset = "0x89CA720", VA = "0x1889CB320")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction OQRUKSQEWFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x89C9420", Offset = "0x89C8820", VA = "0x1889C9420")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x89CB080", Offset = "0x89CA480", VA = "0x1889CB080")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction HFLCASXGJYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x89C9480", Offset = "0x89C8880", VA = "0x1889C9480")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x89CB0F0", Offset = "0x89CA4F0", VA = "0x1889CB0F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction GKBXISMLQLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x89C95D0", Offset = "0x89C89D0", VA = "0x1889C95D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x89CB240", Offset = "0x89CA640", VA = "0x1889CB240")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> MAPGQCYHJBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x89C9560", Offset = "0x89C8960", VA = "0x1889C9560")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x89CB1D0", Offset = "0x89CA5D0", VA = "0x1889CB1D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction SCOUQWFIWQD
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x89C9640", Offset = "0x89C8A40", VA = "0x1889C9640")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x89CB2B0", Offset = "0x89CA6B0", VA = "0x1889CB2B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction UFXCDFANLIV
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x89C9720", Offset = "0x89C8B20", VA = "0x1889C9720")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x89CB390", Offset = "0x89CA790", VA = "0x1889CB390")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction RAXTRIFNWYU
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x89C94F0", Offset = "0x89C88F0", VA = "0x1889C94F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x89CB160", Offset = "0x89CA560", VA = "0x1889CB160")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAA3C10", Offset = "0xAA3010", VA = "0x180AA3C10", Slot = "8")]
		private void VPTAHOTOVQO(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x89C7DF0", Offset = "0x89C71F0", VA = "0x1889C7DF0", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x89C8490", Offset = "0x89C7890", VA = "0x1889C8490")]
		internal void XPQLMFDEPJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x89C9150", Offset = "0x89C8550", VA = "0x1889C9150")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x89C7B40", Offset = "0x89C6F40", VA = "0x1889C7B40")]
		public HUFBFJCMRYV GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x89C8E10", Offset = "0x89C8210", VA = "0x1889C8E10")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x89C77A0", Offset = "0x89C6BA0", VA = "0x1889C77A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x89C90A0", Offset = "0x89C84A0", VA = "0x1889C90A0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x89C8260", Offset = "0x89C7660", VA = "0x1889C8260")]
		private MDCMMOLPXKD NDOMSRPINWU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x89C7E80", Offset = "0x89C7280", VA = "0x1889C7E80")]
		private void HGSJECSPXBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x89C85E0", Offset = "0x89C79E0", VA = "0x1889C85E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x89C8520", Offset = "0x89C7920", VA = "0x1889C8520")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x89C8490", Offset = "0x89C7890", VA = "0x1889C8490")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x89C8580", Offset = "0x89C7980", VA = "0x1889C8580")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x89C8640", Offset = "0x89C7A40", VA = "0x1889C8640")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x89C6DF0", Offset = "0x89C61F0", VA = "0x1889C6DF0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x89C86A0", Offset = "0x89C7AA0", VA = "0x1889C86A0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x89C7AE0", Offset = "0x89C6EE0", VA = "0x1889C7AE0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x89C8420", Offset = "0x89C7820", VA = "0x1889C8420")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x89C8F70", Offset = "0x89C8370", VA = "0x1889C8F70")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x89C89B0", Offset = "0x89C7DB0", VA = "0x1889C89B0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x89C8000", Offset = "0x89C7400", VA = "0x1889C8000")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x89C8100", Offset = "0x89C7500", VA = "0x1889C8100")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x89C7060", Offset = "0x89C6460", VA = "0x1889C7060")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x89C8710", Offset = "0x89C7B10", VA = "0x1889C8710")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x89C70D0", Offset = "0x89C64D0", VA = "0x1889C70D0")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x89C8780", Offset = "0x89C7B80", VA = "0x1889C8780")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x89C8EF0", Offset = "0x89C82F0", VA = "0x1889C8EF0")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x89C8D10", Offset = "0x89C8110", VA = "0x1889C8D10")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x89C8C10", Offset = "0x89C8010", VA = "0x1889C8C10")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x89C7CE0", Offset = "0x89C70E0", VA = "0x1889C7CE0")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x89C7BD0", Offset = "0x89C6FD0", VA = "0x1889C7BD0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x89C6F70", Offset = "0x89C6370", VA = "0x1889C6F70")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x89C6E60", Offset = "0x89C6260", VA = "0x1889C6E60")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x89C72A0", Offset = "0x89C66A0", VA = "0x1889C72A0")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x89C7140", Offset = "0x89C6540", VA = "0x1889C7140")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x89C9220", Offset = "0x89C8620", VA = "0x1889C9220")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x89C8310", Offset = "0x89C7710", VA = "0x1889C8310")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x89C7A80", Offset = "0x89C6E80", VA = "0x1889C7A80")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x89C7A20", Offset = "0x89C6E20", VA = "0x1889C7A20")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x89C79C0", Offset = "0x89C6DC0", VA = "0x1889C79C0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x89C7960", Offset = "0x89C6D60", VA = "0x1889C7960")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x89C8B10", Offset = "0x89C7F10", VA = "0x1889C8B10")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x89C8A10", Offset = "0x89C7E10", VA = "0x1889C8A10")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x89C88D0", Offset = "0x89C7CD0", VA = "0x1889C88D0")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x89C90B0", Offset = "0x89C84B0", VA = "0x1889C90B0")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x89C8200", Offset = "0x89C7600", VA = "0x1889C8200")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x89C9040", Offset = "0x89C8440", VA = "0x1889C9040")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x89C91C0", Offset = "0x89C85C0", VA = "0x1889C91C0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x89C7230", Offset = "0x89C6630", VA = "0x1889C7230")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x89C87F0", Offset = "0x89C7BF0", VA = "0x1889C87F0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x89C7630", Offset = "0x89C6A30", VA = "0x1889C7630")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x89C7530", Offset = "0x89C6930", VA = "0x1889C7530")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x89C76F0", Offset = "0x89C6AF0", VA = "0x1889C76F0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x89C7460", Offset = "0x89C6860", VA = "0x1889C7460")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x89C7390", Offset = "0x89C6790", VA = "0x1889C7390")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x89C8860", Offset = "0x89C7C60", VA = "0x1889C8860")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x89C8480", Offset = "0x89C7880", VA = "0x1889C8480", Slot = "13")]
		private void NBQJZPPKLOB(WOSVSDXEFID a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x89C93B0", Offset = "0x89C87B0", VA = "0x1889C93B0")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x121BD40", Offset = "0x121B140", VA = "0x18121BD40", Slot = "4")]
		private GameObject QELGLCMEGUI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAD03D0", Offset = "0xACF7D0", VA = "0x180AD03D0", Slot = "10")]
		private bool WNYETKALIBJ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class WRQWPAZGYXY
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x89D4C80", Offset = "0x89D4080", VA = "0x1889D4C80")]
		public static MDCMMOLPXKD QIQQQQEHKTC(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(KEIZMDCLJHW), new string[] { })]
	public class RigidbodyExManager : KEIZMDCLJHW, RMHBMYLEQGQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log UMMIJRFVMAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private RTRJWYCNDCD NLKAWVWHGGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private VEDCPKGAPMG NJTXWXGMZSM;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public RTRJWYCNDCD NUMTHIFTGSO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public VEDCPKGAPMG YWXOFAQUDSE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x89C6D00", Offset = "0x89C6100", VA = "0x1889C6D00", Slot = "7")]
		public void InitReferences(KHYDBENZVLP services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x89C6BD0", Offset = "0x89C5FD0", VA = "0x1889C6BD0", Slot = "6")]
		public MDCMMOLPXKD IGPQBOZBJVG(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static OAGBKHNZSHS UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int HJTPQUJCTRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int DNMXHDIRJTI;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x89C4B90", Offset = "0x89C3F90", VA = "0x1889C4B90")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x89C4C10", Offset = "0x89C4010", VA = "0x1889C4C10")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x89C4BB0", Offset = "0x89C3FB0", VA = "0x1889C4BB0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x89C4D00", Offset = "0x89C4100", VA = "0x1889C4D00")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class ENMLWYYCXTI
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class WONIDBGEZNM : XVPZTDGMZUH, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAB3440", Offset = "0xAB2840", VA = "0x180AB3440", Slot = "4")]
			public Vector3 UCSGFPDJWYT()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAB3440", Offset = "0xAB2840", VA = "0x180AB3440", Slot = "5")]
			public Vector3 AZGPHHWJGBE()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "6")]
			public bool ASWAJQYMRAR(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public WONIDBGEZNM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static XVPZTDGMZUH VEHTEJFFJQT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x89BC520", Offset = "0x89BB920", VA = "0x1889BC520")]
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
	public interface MSZSMGXJANF
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CollisionDetectionMode WYCZRLWWHWS
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
		void OYKLSUCXYNQ(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HTWTFUTPSXX(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZSCTQMNMGFR(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool OZXAPHGOSBE(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface PKDKVZYIFSQ : IDisposable, VBOHQQBGZUW
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		TransformTrackRate ZGTBVLTOFYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> MAPGQCYHJBY;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface VEDCPKGAPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		GIMYCJMBBBJ MBTGZPKXHYF(MDCMMOLPXKD a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		XIXJQSHJILR AROCNJMZYOB(MDCMMOLPXKD a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ITYASBIMWZG EEPZBPWBBWW(MDCMMOLPXKD a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IHRHFZODEKV XQXXLKJZUXZ(MDCMMOLPXKD a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		KBNDWBWAEBF KVQBDYPBHND(MDCMMOLPXKD a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		PKDKVZYIFSQ YHJJMYNLRYG(MDCMMOLPXKD a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		QQXQUWVWPLX GSGKCKEKGDF(MDCMMOLPXKD a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		JYYSBSDWVFJ CNYYRTJVXTL(MDCMMOLPXKD a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		MSZSMGXJANF XQLUDXBXLZD(MDCMMOLPXKD a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		FADLVXJDTQG WXLMFMFWBKU(MDCMMOLPXKD a);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		TVIMXTVYVEQ EELVKJSOJAO(MDCMMOLPXKD a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		NNNANBSPYNO GONDBOJKJLY(MDCMMOLPXKD a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		DOKBZBOQYLM RJLIYHQWIYM(MDCMMOLPXKD a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		FTXBYMNAVEG RPYGFSUKZAA(MDCMMOLPXKD a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		FMVGGBEYATY WJXDEGGSOAA(MDCMMOLPXKD a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		MDCMMOLPXKD IGPQBOZBJVG(RigidbodyEx a, RigidbodyExData b, KEIZMDCLJHW c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface JYYSBSDWVFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JWJNDDMYPPG(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void VNNQQBROZTQ(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RMFGNVBSGHZ(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FWHFKCRIQCD(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface FADLVXJDTQG
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool HMFPZDQOODP
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
		void ZSCTQMNMGFR(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HNCZHDOLSGI(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface GIMYCJMBBBJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IReadOnlyList<MDCMMOLPXKD> WXUTBMGGOVM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		MDCMMOLPXKD TMZYFPRTZJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		MDCMMOLPXKD LKSGBNNQMMS
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction OQRUKSQEWFQ;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction HFLCASXGJYY;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction IXPRILFNLXU;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action QTQJFNXBRUT;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action ZUIZOUMZVEI;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<MDCMMOLPXKD> OALPTJTJAKJ;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<MDCMMOLPXKD> XZAAKWNMCUO;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action WCODNSHPMTL;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<MDCMMOLPXKD> GWSMLNNXIBA;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(MDCMMOLPXKD newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface ITYASBIMWZG
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Vector3 TCCPPNTQYJR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Vector3 PAAPPZUGMVP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MMMLWRUNLGZ(MDCMMOLPXKD a, object b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KOWADWCEIHA(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface FTXBYMNAVEG
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 MNHZRTTAMUV
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 RQTGPCNHYOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float BYNOGWEDGMK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		float YICQGZBHIAV
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Vector3 XELOOSQFCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		Quaternion ZDDEZHSTXNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction BEEUSRWWYGA;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void NILVGTYSAQF((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void HRHPCOBGVIA();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ENRDHSNYGCT();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void XELUODSCXEV();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ZSCTQMNMGFR(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void HNCZHDOLSGI(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface DOKBZBOQYLM
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IANTGJMUCFH(object a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MRSYMLCWTWA(object a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DLNTHJSLEAY(MDCMMOLPXKD a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LRUVBOBUDEX(MDCMMOLPXKD a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void WJXNZGSVRYQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface QQXQUWVWPLX
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool PXHGYOAGTPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction JTLONOAONAN;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JULOZYNYIWW(object a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VDHQAJFEBSD(object a);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GANJDVPZUFF(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZSCTQMNMGFR(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void HNCZHDOLSGI(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface NNNANBSPYNO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool JUNNLNCQZYK
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool FVFPRBKGTII
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction AFIIIPSPZMZ;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void KDLWWRDQWTY(MDCMMOLPXKD a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void PHFKUMCJXOW(MDCMMOLPXKD a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface FMVGGBEYATY
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool VZYSUFANUWF
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool FPYFQCGLQWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		RigidbodyConstraints GEJOIYWIOOS
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
		void ZSCTQMNMGFR(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void HNCZHDOLSGI(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface IHRHFZODEKV
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		float CNHPCPBRRZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		float WXKKLNHXPTY
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
		void ZSCTQMNMGFR(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HNCZHDOLSGI(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface KBNDWBWAEBF
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		static bool OBNFSZBZAHZ;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction SUIKJSCKBIH;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool QMHAXSZAZJJ();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PGHNTVRXCRD();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool OYHYLOUPTFP();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool WBNYLEQFIRW();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void WLCAVZCIYEG(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void NVVEDRPICJN();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface TVIMXTVYVEQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		Rigidbody GAGOAANQFGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool UKBLOVDCFAP
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
		void BWVBBEUAVAR(object a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void MUXRAKWSKBC(object a);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void CKKBKCXIFUJ();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface XIXJQSHJILR : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		XVPZTDGMZUH FJTLXJRRRFC
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		TLELRAOYGZE FTOHZJUUMFN
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Vector3 XELGSHAKRXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Vector3 NVGRKLERKBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		Vector3 ZRHPETCQSPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 EMZYRXTARGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		float LVTYNGFZNTH
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool XLGWMCPNLYL
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
		void JDHFQVXJOSF(object a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void LWECQOKYRYT(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void OYOPQLSKYBY(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void AMJZSFXTBYY(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void YCZUHBNVTEU();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void EOLGOZXMJJX();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void TGMXTJNVUWA();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void ADFXFYZZPZO();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void ZSCTQMNMGFR(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 SVYRDAHFPKR(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void MBWWEFHQYUE(object a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void OYYGEOQOSWY(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void GJROQISHZUV(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void TEZNATNIPJC(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 XVUIMHUOZRZ(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 MPQWIBSWUHT(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface RTRJWYCNDCD
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool WMUOPGKFZMY
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LYKVIWKWESW(string a);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KEEIKCFPAUB(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		VXLRQMMFLYX NZTPNMSMEMI(int a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BTFHFVXELPC(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface KEIZMDCLJHW
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		RTRJWYCNDCD NUMTHIFTGSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		VEDCPKGAPMG YWXOFAQUDSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MDCMMOLPXKD IGPQBOZBJVG(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class TDUDGQTHQOO : MDCMMOLPXKD, IDisposable, HPCIOWLZPEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal readonly KEIZMDCLJHW HQTUECNYSDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal GIMYCJMBBBJ NHAMNPIXBHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal DOKBZBOQYLM XFYOLAJQSHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal NNNANBSPYNO LPJUGZPYMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal XIXJQSHJILR VTAAIVYJOER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal ITYASBIMWZG ZMRTTBYXFKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal FTXBYMNAVEG LOGRHEXMITC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal IHRHFZODEKV WZAMYZYFFVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal FADLVXJDTQG JRIVDUTHRAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal KBNDWBWAEBF GUQCNZKLMKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal PKDKVZYIFSQ ZHYRRNOZYBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal QQXQUWVWPLX WFRPUBAALYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal JYYSBSDWVFJ PIPKAVYXYHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal FMVGGBEYATY XEEHSMPKJPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal TVIMXTVYVEQ UJXIOAFQLES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal MSZSMGXJANF VPCICUGORDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal IDisposable CVGABJKVCUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool ATWHULTBNQG;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ObjectLocalId OPIDKLOKEFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public HUFBFJCMRYV QTMMNBIOKAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xBB52C0", Offset = "0xBB46C0", VA = "0x180BB52C0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xBB4530", Offset = "0xBB3930", VA = "0x180BB4530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject OSUNCBRTTSP
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xAA46D0", Offset = "0xAA3AD0", VA = "0x180AA46D0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAA46E0", Offset = "0xAA3AE0", VA = "0x180AA46E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform XYFLSXQBLLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xC461E0", Offset = "0xC455E0", VA = "0x180C461E0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xD1B620", Offset = "0xD1AA20", VA = "0x180D1B620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody GAGOAANQFGW
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x89CF310", Offset = "0x89CE710", VA = "0x1889CF310", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MDCMMOLPXKD LKSGBNNQMMS
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x89CE990", Offset = "0x89CDD90", VA = "0x1889CE990", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x89D03E0", Offset = "0x89CF7E0", VA = "0x1889D03E0", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int TJIWMDMPAZV
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x89CCFC0", Offset = "0x89CC3C0", VA = "0x1889CCFC0", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public MDCMMOLPXKD TMZYFPRTZJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x89D0310", Offset = "0x89CF710", VA = "0x1889D0310", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool CYTBCWJLFFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x89D28D0", Offset = "0x89D1CD0", VA = "0x1889D28D0", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool JUNNLNCQZYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x89CD130", Offset = "0x89CC530", VA = "0x1889CD130", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool FVFPRBKGTII
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x89CD650", Offset = "0x89CCA50", VA = "0x1889CD650", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public XVPZTDGMZUH FJTLXJRRRFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x89CCA80", Offset = "0x89CBE80", VA = "0x1889CCA80", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x89CD560", Offset = "0x89CC960", VA = "0x1889CD560", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public TLELRAOYGZE FTOHZJUUMFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x89D0E20", Offset = "0x89D0220", VA = "0x1889D0E20", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x89D1230", Offset = "0x89D0630", VA = "0x1889D1230", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float LVTYNGFZNTH
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x89CD0E0", Offset = "0x89CC4E0", VA = "0x1889CD0E0", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x89D1D80", Offset = "0x89D1180", VA = "0x1889D1D80", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 NVGRKLERKBU
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x89CF9E0", Offset = "0x89CEDE0", VA = "0x1889CF9E0", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x89CCCE0", Offset = "0x89CC0E0", VA = "0x1889CCCE0", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 EMZYRXTARGC
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x89CEAC0", Offset = "0x89CDEC0", VA = "0x1889CEAC0", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x89D1290", Offset = "0x89D0690", VA = "0x1889D1290", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 XELGSHAKRXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x89CFAC0", Offset = "0x89CEEC0", VA = "0x1889CFAC0", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x89CD350", Offset = "0x89CC750", VA = "0x1889CD350", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 ZRHPETCQSPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x89CD180", Offset = "0x89CC580", VA = "0x1889CD180", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x89D05E0", Offset = "0x89CF9E0", VA = "0x1889D05E0", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool VIPNMFQAMZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x89CDB70", Offset = "0x89CCF70", VA = "0x1889CDB70", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool FKESJWGDEHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x89CCC80", Offset = "0x89CC080", VA = "0x1889CCC80", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool MRWEKSWZJNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x89D1E40", Offset = "0x89D1240", VA = "0x1889D1E40", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool XLGWMCPNLYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x89CD6A0", Offset = "0x89CCAA0", VA = "0x1889CD6A0", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 TCCPPNTQYJR
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x89D0B90", Offset = "0x89CFF90", VA = "0x1889D0B90", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 PAAPPZUGMVP
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x89D1FE0", Offset = "0x89D13E0", VA = "0x1889D1FE0", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 MNHZRTTAMUV
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x89CDC70", Offset = "0x89CD070", VA = "0x1889CDC70", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x89D0440", Offset = "0x89CF840", VA = "0x1889D0440", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 RQTGPCNHYOK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x89D2A30", Offset = "0x89D1E30", VA = "0x1889D2A30", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float BYNOGWEDGMK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x89D0FB0", Offset = "0x89D03B0", VA = "0x1889D0FB0", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float YICQGZBHIAV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x89CDDF0", Offset = "0x89CD1F0", VA = "0x1889CDDF0", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x89CDE90", Offset = "0x89CD290", VA = "0x1889CDE90", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 XELOOSQFCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x89CE380", Offset = "0x89CD780", VA = "0x1889CE380", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion ZDDEZHSTXNZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x89CE460", Offset = "0x89CD860", VA = "0x1889CE460", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float CNHPCPBRRZG
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x89D1370", Offset = "0x89D0770", VA = "0x1889D1370", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x89D0520", Offset = "0x89CF920", VA = "0x1889D0520", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float WXKKLNHXPTY
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x89CD430", Offset = "0x89CC830", VA = "0x1889CD430", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x89CDA10", Offset = "0x89CCE10", VA = "0x1889CDA10", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool HMFPZDQOODP
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x89D1B10", Offset = "0x89D0F10", VA = "0x1889D1B10", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x89D1F20", Offset = "0x89D1320", VA = "0x1889D1F20", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate ZGTBVLTOFYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x89D2990", Offset = "0x89D1D90", VA = "0x1889D2990", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x89CE680", Offset = "0x89CDA80", VA = "0x1889CE680", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool PXHGYOAGTPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x89CDE40", Offset = "0x89CD240", VA = "0x1889CDE40", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform NSXXMNYPWZL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xC461E0", Offset = "0xC455E0", VA = "0x180C461E0", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 KMKLBTWMTNL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x89CFDB0", Offset = "0x89CF1B0", VA = "0x1889CFDB0", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x89D0180", Offset = "0x89CF580", VA = "0x1889D0180", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float FNTSUXDNKBN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x89CE730", Offset = "0x89CDB30", VA = "0x1889CE730", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x89D2840", Offset = "0x89D1C40", VA = "0x1889D2840", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float WYZTQIREHDW
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x89D03D0", Offset = "0x89CF7D0", VA = "0x1889D03D0", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x89CF610", Offset = "0x89CEA10", VA = "0x1889CF610", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion WJVYEAVDQHW
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x89D00E0", Offset = "0x89CF4E0", VA = "0x1889D00E0", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x89CD480", Offset = "0x89CC880", VA = "0x1889CD480", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 RIJDFRYHRYS
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x89D0CB0", Offset = "0x89D00B0", VA = "0x1889D0CB0", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x89CE860", Offset = "0x89CDC60", VA = "0x1889CE860", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion PCCERHSNATV
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x89CCAD0", Offset = "0x89CBED0", VA = "0x1889CCAD0", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x89CD260", Offset = "0x89CC660", VA = "0x1889CD260", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints GEJOIYWIOOS
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x89CEBA0", Offset = "0x89CDFA0", VA = "0x1889CEBA0", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x89D2ED0", Offset = "0x89D22D0", VA = "0x1889D2ED0", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool VZYSUFANUWF
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x89CC9E0", Offset = "0x89CBDE0", VA = "0x1889CC9E0", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x89CF4B0", Offset = "0x89CE8B0", VA = "0x1889CF4B0", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode WYCZRLWWHWS
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x89CE6E0", Offset = "0x89CDAE0", VA = "0x1889CE6E0", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x89CFF20", Offset = "0x89CF320", VA = "0x1889CFF20", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool UYZVDSLOIDT
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x89CE240", Offset = "0x89CD640", VA = "0x1889CE240", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool TCBVDLZRTHK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x89CF190", Offset = "0x89CE590", VA = "0x1889CF190", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction OQRUKSQEWFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x89D0580", Offset = "0x89CF980", VA = "0x1889D0580", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x89D22F0", Offset = "0x89D16F0", VA = "0x1889D22F0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction HFLCASXGJYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x89D2350", Offset = "0x89D1750", VA = "0x1889D2350", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x89D2F80", Offset = "0x89D2380", VA = "0x1889D2F80", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction IXPRILFNLXU
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x89CCC20", Offset = "0x89CC020", VA = "0x1889CCC20", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x89CFE60", Offset = "0x89CF260", VA = "0x1889CFE60", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction AFIIIPSPZMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x89D0E70", Offset = "0x89D0270", VA = "0x1889D0E70", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x89CCB10", Offset = "0x89CBF10", VA = "0x1889CCB10", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction GKBXISMLQLO
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x89D1000", Offset = "0x89D0400", VA = "0x1889D1000", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x89CE9E0", Offset = "0x89CDDE0", VA = "0x1889CE9E0", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction SUIKJSCKBIH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x89CF710", Offset = "0x89CEB10", VA = "0x1889CF710", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x89CEBF0", Offset = "0x89CDFF0", VA = "0x1889CEBF0", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> MAPGQCYHJBY
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x89D2B10", Offset = "0x89D1F10", VA = "0x1889D2B10", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x89CF8B0", Offset = "0x89CECB0", VA = "0x1889CF8B0", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction JTLONOAONAN
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x89D0A60", Offset = "0x89CFE60", VA = "0x1889D0A60", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x89D11D0", Offset = "0x89D05D0", VA = "0x1889D11D0", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction RAXTRIFNWYU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x89CD030", Offset = "0x89CC430", VA = "0x1889CD030", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x89D0CF0", Offset = "0x89D00F0", VA = "0x1889D0CF0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x89D2FE0", Offset = "0x89D23E0", VA = "0x1889D2FE0")]
		public TDUDGQTHQOO(GameObject a, RigidbodyEx b, KEIZMDCLJHW c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x89CEEA0", Offset = "0x89CE2A0", VA = "0x1889CEEA0", Slot = "139")]
		protected virtual void HZJSFPGOVBU(KEIZMDCLJHW a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x89CDA70", Offset = "0x89CCE70", VA = "0x1889CDA70", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x89CCDC0", Offset = "0x89CC1C0", VA = "0x1889CCDC0", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x89D09D0", Offset = "0x89CFDD0", VA = "0x1889D09D0", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x89D0920", Offset = "0x89CFD20", VA = "0x1889D0920", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x89D0900", Offset = "0x89CFD00", VA = "0x1889D0900", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x89D25C0", Offset = "0x89D19C0", VA = "0x1889D25C0")]
		private void WLCAVZCIYEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x89D0DA0", Offset = "0x89D01A0", VA = "0x1889D0DA0")]
		private void RASQYSUNGDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x89D23B0", Offset = "0x89D17B0", VA = "0x1889D23B0")]
		private void WBNYLEQFIRW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x89CEA40", Offset = "0x89CDE40", VA = "0x1889CEA40", Slot = "30")]
		public MDCMMOLPXKD HAERVOXZOOA(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x89D1910", Offset = "0x89D0D10", VA = "0x1889D1910", Slot = "98")]
		public void SetParent(MDCMMOLPXKD value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x89D2CA0", Offset = "0x89D20A0", VA = "0x1889D2CA0", Slot = "99")]
		public void XQLREUXQSPF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x89CD2F0", Offset = "0x89CC6F0", VA = "0x1889CD2F0", Slot = "100")]
		public void CFYMVTDLTFM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x89CFF80", Offset = "0x89CF380", VA = "0x1889CFF80", Slot = "101")]
		public Vector3 MPQWIBSWUHT(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x89D2DD0", Offset = "0x89D21D0", VA = "0x1889D2DD0", Slot = "102")]
		public Vector3 XVUIMHUOZRZ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x89CCA30", Offset = "0x89CBE30", VA = "0x1889CCA30", Slot = "103")]
		public void ADFXFYZZPZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x89CDDA0", Offset = "0x89CD1A0", VA = "0x1889CDDA0", Slot = "104")]
		public void EOLGOZXMJJX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x89D2F30", Offset = "0x89D2330", VA = "0x1889D2F30", Slot = "105")]
		public void YCZUHBNVTEU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x89D19D0", Offset = "0x89D0DD0", VA = "0x1889D19D0", Slot = "106")]
		public void TEZNATNIPJC(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x89CE8A0", Offset = "0x89CDCA0", VA = "0x1889CE8A0", Slot = "107")]
		public void GJROQISHZUV(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x89D0780", Offset = "0x89CFB80", VA = "0x1889D0780", Slot = "108")]
		public void OYYGEOQOSWY(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x89D06C0", Offset = "0x89CFAC0", VA = "0x1889D06C0", Slot = "109")]
		public void OYOPQLSKYBY(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x89CFCB0", Offset = "0x89CF0B0", VA = "0x1889CFCB0", Slot = "110")]
		public void LWECQOKYRYT(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x89CCB70", Offset = "0x89CBF70", VA = "0x1889CCB70", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void AMJZSFXTBYY(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x89D13C0", Offset = "0x89D07C0", VA = "0x1889D13C0", Slot = "112")]
		public Vector3 SVYRDAHFPKR(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x89CF510", Offset = "0x89CE910", VA = "0x1889CF510", Slot = "113")]
		public Vector3 JLETSQAPMWX(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x89D1AC0", Offset = "0x89D0EC0", VA = "0x1889D1AC0", Slot = "114")]
		public void TGMXTJNVUWA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x89CCF00", Offset = "0x89CC300", VA = "0x1889CCF00", Slot = "115")]
		public void BAWODJQOYSS(MDCMMOLPXKD a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x89D2930", Offset = "0x89D1D30", VA = "0x1889D2930", Slot = "116")]
		public void WVVDNCAERAT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x89D0230", Offset = "0x89CF630", VA = "0x1889D0230", Slot = "63")]
		public void NILVGTYSAQF((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x89CDD50", Offset = "0x89CD150", VA = "0x1889CDD50", Slot = "117")]
		public void ENRDHSNYGCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x89CEE50", Offset = "0x89CE250", VA = "0x1889CEE50", Slot = "118")]
		public void HRHPCOBGVIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x89D29E0", Offset = "0x89D1DE0", VA = "0x1889D29E0", Slot = "119")]
		public void XELUODSCXEV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x89D0C60", Offset = "0x89D0060", VA = "0x1889D0C60", Slot = "120")]
		public bool QMHAXSZAZJJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x89D1980", Offset = "0x89D0D80", VA = "0x1889D1980", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x89D0360", Offset = "0x89CF760", VA = "0x1889D0360", Slot = "121")]
		public void NVVEDRPICJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x89CF770", Offset = "0x89CEB70", VA = "0x1889CF770", Slot = "122")]
		public void JULOZYNYIWW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x89D1F80", Offset = "0x89D1380", VA = "0x1889D1F80", Slot = "123")]
		public void VDHQAJFEBSD(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x89CE610", Offset = "0x89CDA10", VA = "0x1889CE610", Slot = "124")]
		public void GANJDVPZUFF(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x89CEC50", Offset = "0x89CE050", VA = "0x1889CEC50", Slot = "125")]
		public void HMWLASNDYIZ(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x89D2B70", Offset = "0x89D1F70", VA = "0x1889D2B70", Slot = "126")]
		public void XPFPBRXJTXL(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x89CCF70", Offset = "0x89CC370", VA = "0x1889CCF70", Slot = "127")]
		public bool BCHIVHXOACY(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x89CFEC0", Offset = "0x89CF2C0", VA = "0x1889CFEC0", Slot = "128")]
		public void MIDJWDZANLP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x89D1DE0", Offset = "0x89D11E0", VA = "0x1889D1DE0", Slot = "129")]
		public void UOFPMUMLZLQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x89CD290", Offset = "0x89CC690", VA = "0x1889CD290", Slot = "130")]
		public void BWVBBEUAVAR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x89D0080", Offset = "0x89CF480", VA = "0x1889D0080", Slot = "131")]
		public void MUXRAKWSKBC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x89CF7D0", Offset = "0x89CEBD0", VA = "0x1889CF7D0", Slot = "132")]
		public void JWJNDDMYPPG(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x89D21E0", Offset = "0x89D15E0", VA = "0x1889D21E0", Slot = "133")]
		public void VNNQQBROZTQ(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x89D0ED0", Offset = "0x89D02D0", VA = "0x1889D0ED0", Slot = "134")]
		public void RMFGNVBSGHZ(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x89CE530", Offset = "0x89CD930", VA = "0x1889CE530", Slot = "135")]
		public void FWHFKCRIQCD(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x89D0860", Offset = "0x89CFC60", VA = "0x1889D0860", Slot = "136")]
		public bool OZXAPHGOSBE(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x89D0980", Offset = "0x89CFD80", VA = "0x1889D0980", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x89D1D40", Offset = "0x89D1140", VA = "0x1889D1D40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x89D2D00", Offset = "0x89D2100", VA = "0x1889D2D00")]
		private void XRVKOQRFCNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x89CFBA0", Offset = "0x89CEFA0", VA = "0x1889CFBA0")]
		private void LRYRXKIBBOY(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x89D1B60", Offset = "0x89D0F60", VA = "0x1889D1B60")]
		private void TTHGMCLRDVR(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x89CDBC0", Offset = "0x89CCFC0", VA = "0x1889CDBC0")]
		private void EITUQTPHHYA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x89CE740", Offset = "0x89CDB40", VA = "0x1889CE740")]
		private void GFLUCDHWOVD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x89D2410", Offset = "0x89D1810", VA = "0x1889D2410")]
		private void WGWSOXLNTLD(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x89CF910", Offset = "0x89CED10", VA = "0x1889CF910")]
		private void KDLWWRDQWTY(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x89D0AC0", Offset = "0x89CFEC0", VA = "0x1889D0AC0")]
		private void PHFKUMCJXOW(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x89CF360", Offset = "0x89CE760", VA = "0x1889CF360")]
		private void ITSPPUPHJSP(HUFBFJCMRYV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x89D14C0", Offset = "0x89D08C0", VA = "0x1889D14C0", Slot = "142")]
		protected virtual void SYCVJTESQEU(HUFBFJCMRYV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x89CD6F0", Offset = "0x89CCAF0", VA = "0x1889CD6F0")]
		protected void DVPJTJUCDXE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x89CDEF0", Offset = "0x89CD2F0", VA = "0x1889CDEF0")]
		protected void FJFCHJZRAWK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x89D20C0", Offset = "0x89D14C0", VA = "0x1889D20C0")]
		private void VMBOXKIYVFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x89D1060", Offset = "0x89D0460", VA = "0x1889D1060")]
		private void SGHONKUDQSJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class MFHQFUPIDXO
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x89C1BC0", Offset = "0x89C0FC0", VA = "0x1889C1BC0")]
		public static MDCMMOLPXKD HVQIITIHWWF(this MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x89C1C80", Offset = "0x89C1080", VA = "0x1889C1C80")]
		public static bool NANZLLKGTSQ(this MDCMMOLPXKD a, MDCMMOLPXKD b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x89C1D20", Offset = "0x89C1120", VA = "0x1889C1D20")]
		public static bool WAGYMOVJKAW(this MDCMMOLPXKD a, MDCMMOLPXKD b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x89C1DC0", Offset = "0x89C11C0", VA = "0x1889C1DC0")]
		public static HUFBFJCMRYV ZUSDZNZJCRW(this MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x89C1B50", Offset = "0x89C0F50", VA = "0x1889C1B50")]
		public static TDUDGQTHQOO Base(this MDCMMOLPXKD impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class MHVSUTSBVAD : VEDCPKGAPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x89C2630", Offset = "0x89C1A30", VA = "0x1889C2630", Slot = "19")]
		public MDCMMOLPXKD IGPQBOZBJVG(RigidbodyEx a, RigidbodyExData b, KEIZMDCLJHW c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "4")]
		public GIMYCJMBBBJ MBTGZPKXHYF(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "5")]
		public XIXJQSHJILR AROCNJMZYOB(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "6")]
		public ITYASBIMWZG EEPZBPWBBWW(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "7")]
		public IHRHFZODEKV XQXXLKJZUXZ(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "8")]
		public KBNDWBWAEBF KVQBDYPBHND(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "9")]
		public PKDKVZYIFSQ YHJJMYNLRYG(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "10")]
		public QQXQUWVWPLX GSGKCKEKGDF(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "11")]
		public JYYSBSDWVFJ CNYYRTJVXTL(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "12")]
		public MSZSMGXJANF XQLUDXBXLZD(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "13")]
		public FADLVXJDTQG WXLMFMFWBKU(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160")]
		public TVIMXTVYVEQ EELVKJSOJAO(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160")]
		public NNNANBSPYNO GONDBOJKJLY(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160")]
		public DOKBZBOQYLM RJLIYHQWIYM(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160")]
		public FTXBYMNAVEG RPYGFSUKZAA(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160")]
		public FMVGGBEYATY WJXDEGGSOAA(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public MHVSUTSBVAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "14")]
		private TVIMXTVYVEQ WVBETPUCYFQ(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "15")]
		private NNNANBSPYNO KPOYTSKGXJE(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "16")]
		private DOKBZBOQYLM NOLLNHKCRUQ(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "17")]
		private FTXBYMNAVEG AAPNGBKMZMY(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "18")]
		private FMVGGBEYATY UHSBZOTUCYA(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(VEDCPKGAPMG), new string[] { })]
	public class GRTPNQDMWJE : VEDCPKGAPMG, RMHBMYLEQGQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly VEDCPKGAPMG WBSYHLCIPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly VEDCPKGAPMG UZWPCSCHPXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private KCCOGZSLVTW EOHFEXQYYDN;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private VEDCPKGAPMG YWXOFAQUDSE
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x89C0660", Offset = "0x89BFA60", VA = "0x1889C0660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x89C0420", Offset = "0x89BF820", VA = "0x1889C0420", Slot = "20")]
		public void InitReferences(KHYDBENZVLP services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x89C0510", Offset = "0x89BF910", VA = "0x1889C0510", Slot = "4")]
		public GIMYCJMBBBJ MBTGZPKXHYF(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x89BFF60", Offset = "0x89BF360", VA = "0x1889BFF60", Slot = "5")]
		public XIXJQSHJILR AROCNJMZYOB(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x89C0150", Offset = "0x89BF550", VA = "0x1889C0150", Slot = "6")]
		public ITYASBIMWZG EEPZBPWBBWW(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x89C08B0", Offset = "0x89BFCB0", VA = "0x1889C08B0", Slot = "7")]
		public IHRHFZODEKV XQXXLKJZUXZ(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x89C0470", Offset = "0x89BF870", VA = "0x1889C0470", Slot = "8")]
		public KBNDWBWAEBF KVQBDYPBHND(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x89C0950", Offset = "0x89BFD50", VA = "0x1889C0950", Slot = "9")]
		public PKDKVZYIFSQ YHJJMYNLRYG(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x89C02A0", Offset = "0x89BF6A0", VA = "0x1889C02A0", Slot = "10")]
		public QQXQUWVWPLX GSGKCKEKGDF(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x89C0000", Offset = "0x89BF400", VA = "0x1889C0000", Slot = "11")]
		public JYYSBSDWVFJ CNYYRTJVXTL(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x89C0810", Offset = "0x89BFC10", VA = "0x1889C0810", Slot = "12")]
		public MSZSMGXJANF XQLUDXBXLZD(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x89C0770", Offset = "0x89BFB70", VA = "0x1889C0770", Slot = "13")]
		public FADLVXJDTQG WXLMFMFWBKU(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x89C00A0", Offset = "0x89BF4A0", VA = "0x1889C00A0")]
		public TVIMXTVYVEQ EELVKJSOJAO(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x89C01F0", Offset = "0x89BF5F0", VA = "0x1889C01F0")]
		public NNNANBSPYNO GONDBOJKJLY(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x89C05B0", Offset = "0x89BF9B0", VA = "0x1889C05B0")]
		public DOKBZBOQYLM RJLIYHQWIYM(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x89BFEB0", Offset = "0x89BF2B0", VA = "0x1889BFEB0")]
		public FTXBYMNAVEG RPYGFSUKZAA(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x89C06C0", Offset = "0x89BFAC0", VA = "0x1889C06C0")]
		public FMVGGBEYATY WJXDEGGSOAA(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x89C0340", Offset = "0x89BF740", VA = "0x1889C0340", Slot = "19")]
		public MDCMMOLPXKD IGPQBOZBJVG(RigidbodyEx a, RigidbodyExData b, KEIZMDCLJHW c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x89C09F0", Offset = "0x89BFDF0", VA = "0x1889C09F0")]
		public GRTPNQDMWJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x89C00A0", Offset = "0x89BF4A0", VA = "0x1889C00A0", Slot = "14")]
		private TVIMXTVYVEQ WVBETPUCYFQ(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x89C01F0", Offset = "0x89BF5F0", VA = "0x1889C01F0", Slot = "15")]
		private NNNANBSPYNO KPOYTSKGXJE(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x89C05B0", Offset = "0x89BF9B0", VA = "0x1889C05B0", Slot = "16")]
		private DOKBZBOQYLM NOLLNHKCRUQ(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x89BFEB0", Offset = "0x89BF2B0", VA = "0x1889BFEB0", Slot = "17")]
		private FTXBYMNAVEG AAPNGBKMZMY(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x89C06C0", Offset = "0x89BFAC0", VA = "0x1889C06C0", Slot = "18")]
		private FMVGGBEYATY UHSBZOTUCYA(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface XIJLQTOIFNA : GIMYCJMBBBJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SSSGUVRVYSN(MDCMMOLPXKD a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SKXJPRWJZVG(MDCMMOLPXKD a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void XHCFPBMVHJR(MDCMMOLPXKD a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VKBRKLHKAPI(MDCMMOLPXKD a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface KIRXPPWADHT : ITYASBIMWZG
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		IBLAFFKFFOJ<MDCMMOLPXKD> XVIDNDCNCJS
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		MDCMMOLPXKD JDUBUXDLVHQ
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface OVLNXRDBCWB : FTXBYMNAVEG
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) YMLVVRJRVHG(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface RKDAGPVYYBL : NNNANBSPYNO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		RRNetworkView AYVNQCZKTYJ
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal sealed class YJKSOWHOMPG : MSZSMGXJANF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly TDUDGQTHQOO KVPEERSNLOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CollisionDetectionMode BAHHXDDIXLS;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private Rigidbody GAGOAANQFGW
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x89D33E0", Offset = "0x89D27E0", VA = "0x1889D33E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode WYCZRLWWHWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x89D7740", Offset = "0x89D6B40", VA = "0x1889D7740", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x89D7860", Offset = "0x89D6C60", VA = "0x1889D7860", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x89D3E30", Offset = "0x89D3230", VA = "0x1889D3E30")]
		public YJKSOWHOMPG(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x89D7630", Offset = "0x89D6A30", VA = "0x1889D7630", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x89D7B60", Offset = "0x89D6F60", VA = "0x1889D7B60", Slot = "9")]
		public void ZSCTQMNMGFR(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x89D78D0", Offset = "0x89D6CD0", VA = "0x1889D78D0", Slot = "7")]
		public void OYKLSUCXYNQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x89D7850", Offset = "0x89D6C50", VA = "0x1889D7850", Slot = "8")]
		public void HTWTFUTPSXX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x89D78E0", Offset = "0x89D6CE0", VA = "0x1889D78E0", Slot = "10")]
		public bool OZXAPHGOSBE(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x89D7A40", Offset = "0x89D6E40", VA = "0x1889D7A40")]
		private void YRUOWYOTZWS(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class MQMLNXBDVJT : PKDKVZYIFSQ, IDisposable, VBOHQQBGZUW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly TDUDGQTHQOO KVPEERSNLOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TransformTrackRate NFVOZNAANPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private VXLRQMMFLYX QCZJGXXEVNL;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TransformTrackRate ZGTBVLTOFYJ
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x89C3BA0", Offset = "0x89C2FA0", VA = "0x1889C3BA0", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x89C3A00", Offset = "0x89C2E00", VA = "0x1889C3A00", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform OYPGRZJNEUS
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x89C3B80", Offset = "0x89C2F80", VA = "0x1889C3B80", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> MAPGQCYHJBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x89C3CE0", Offset = "0x89C30E0", VA = "0x1889C3CE0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x89C3AD0", Offset = "0x89C2ED0", VA = "0x1889C3AD0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x89C3D90", Offset = "0x89C3190", VA = "0x1889C3D90")]
		public MQMLNXBDVJT(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x89C3740", Offset = "0x89C2B40", VA = "0x1889C3740", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x89C39B0", Offset = "0x89C2DB0", VA = "0x1889C39B0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x10DF720", Offset = "0x10DEB20", VA = "0x1810DF720", Slot = "11")]
		private void SYSTGDQESVD(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "12")]
		private void MIFWCBQGQZX(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class MHVSUTSBVAD : VEDCPKGAPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x89C28C0", Offset = "0x89C1CC0", VA = "0x1889C28C0", Slot = "4")]
		public GIMYCJMBBBJ MBTGZPKXHYF(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x89C1F90", Offset = "0x89C1390", VA = "0x1889C1F90", Slot = "5")]
		public XIXJQSHJILR AROCNJMZYOB(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x89C2280", Offset = "0x89C1680", VA = "0x1889C2280", Slot = "6")]
		public ITYASBIMWZG EEPZBPWBBWW(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x89C2D10", Offset = "0x89C2110", VA = "0x1889C2D10", Slot = "7")]
		public IHRHFZODEKV XQXXLKJZUXZ(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x89C2800", Offset = "0x89C1C00", VA = "0x1889C2800", Slot = "8")]
		public KBNDWBWAEBF KVQBDYPBHND(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x89C2D80", Offset = "0x89C2180", VA = "0x1889C2D80", Slot = "9")]
		public PKDKVZYIFSQ YHJJMYNLRYG(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x89C2520", Offset = "0x89C1920", VA = "0x1889C2520", Slot = "10")]
		public QQXQUWVWPLX GSGKCKEKGDF(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x89C20A0", Offset = "0x89C14A0", VA = "0x1889C20A0", Slot = "11")]
		public JYYSBSDWVFJ CNYYRTJVXTL(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x89C2C50", Offset = "0x89C2050", VA = "0x1889C2C50", Slot = "12")]
		public MSZSMGXJANF XQLUDXBXLZD(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x89C2B90", Offset = "0x89C1F90", VA = "0x1889C2B90", Slot = "13")]
		public FADLVXJDTQG WXLMFMFWBKU(MDCMMOLPXKD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x89C2160", Offset = "0x89C1560", VA = "0x1889C2160")]
		public TVIMXTVYVEQ EELVKJSOJAO(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x89C23A0", Offset = "0x89C17A0", VA = "0x1889C23A0")]
		public NNNANBSPYNO GONDBOJKJLY(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x89C29A0", Offset = "0x89C1DA0", VA = "0x1889C29A0")]
		public DOKBZBOQYLM RJLIYHQWIYM(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x89C1E10", Offset = "0x89C1210", VA = "0x1889C1E10")]
		public FTXBYMNAVEG RPYGFSUKZAA(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x89C2AC0", Offset = "0x89C1EC0", VA = "0x1889C2AC0")]
		public FMVGGBEYATY WJXDEGGSOAA(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x89C26C0", Offset = "0x89C1AC0", VA = "0x1889C26C0", Slot = "19")]
		public MDCMMOLPXKD IGPQBOZBJVG(RigidbodyEx a, RigidbodyExData b, KEIZMDCLJHW c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public MHVSUTSBVAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x89C2160", Offset = "0x89C1560", VA = "0x1889C2160", Slot = "14")]
		private TVIMXTVYVEQ WVBETPUCYFQ(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x89C23A0", Offset = "0x89C17A0", VA = "0x1889C23A0", Slot = "15")]
		private NNNANBSPYNO KPOYTSKGXJE(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x89C29A0", Offset = "0x89C1DA0", VA = "0x1889C29A0", Slot = "16")]
		private DOKBZBOQYLM NOLLNHKCRUQ(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x89C1E10", Offset = "0x89C1210", VA = "0x1889C1E10", Slot = "17")]
		private FTXBYMNAVEG AAPNGBKMZMY(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x89C2AC0", Offset = "0x89C1EC0", VA = "0x1889C2AC0", Slot = "18")]
		private FMVGGBEYATY UHSBZOTUCYA(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal sealed class UMKMCHUJSUG : JYYSBSDWVFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly TDUDGQTHQOO KVPEERSNLOT;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody GAGOAANQFGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x89D33E0", Offset = "0x89D27E0", VA = "0x1889D33E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool PXHGYOAGTPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x89D30D0", Offset = "0x89D24D0", VA = "0x1889D30D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool CYTBCWJLFFU
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x89C35E0", Offset = "0x89C29E0", VA = "0x1889C35E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private MDCMMOLPXKD LKSGBNNQMMS
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x89D3380", Offset = "0x89D2780", VA = "0x1889D3380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x89D3E30", Offset = "0x89D3230", VA = "0x1889D3E30")]
		public UMKMCHUJSUG(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x89D3430", Offset = "0x89D2830", VA = "0x1889D3430", Slot = "4")]
		public void JWJNDDMYPPG(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x89D37F0", Offset = "0x89D2BF0", VA = "0x1889D37F0")]
		private void OQMGHULADRN(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x89D3BB0", Offset = "0x89D2FB0", VA = "0x1889D3BB0", Slot = "5")]
		public void VNNQQBROZTQ(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x89D3A50", Offset = "0x89D2E50", VA = "0x1889D3A50", Slot = "6")]
		public void RMFGNVBSGHZ(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x89D3590", Offset = "0x89D2990", VA = "0x1889D3590")]
		private void LLZPDGZMLWO(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x89D3120", Offset = "0x89D2520", VA = "0x1889D3120", Slot = "7")]
		public void FWHFKCRIQCD(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class ZYRJROXNRGT : FADLVXJDTQG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly TDUDGQTHQOO KVPEERSNLOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool WFMKDBQFYMF;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool HMFPZDQOODP
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xBFA2C0", Offset = "0xBF96C0", VA = "0x180BFA2C0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x89D7F20", Offset = "0x89D7320", VA = "0x1889D7F20", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x89D3E30", Offset = "0x89D3230", VA = "0x1889D3E30")]
		public ZYRJROXNRGT(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x89D8030", Offset = "0x89D7430", VA = "0x1889D8030", Slot = "6")]
		public void ZSCTQMNMGFR(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x89D7EB0", Offset = "0x89D72B0", VA = "0x1889D7EB0", Slot = "7")]
		public void HNCZHDOLSGI(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RbexHierarchy : XIJLQTOIFNA, GIMYCJMBBBJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly MDCMMOLPXKD KVPEERSNLOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<MDCMMOLPXKD> DSQJNDSJIVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private MDCMMOLPXKD BRWFJBTAWNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private MDCMMOLPXKD ZXFWECNPPKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform LKCPZJPCHKR;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private Transform XYFLSXQBLLI
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x89C56E0", Offset = "0x89C4AE0", VA = "0x1889C56E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public MDCMMOLPXKD LKSGBNNQMMS
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xAA7C60", Offset = "0xAA7060", VA = "0x180AA7C60", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x89C5740", Offset = "0x89C4B40", VA = "0x1889C5740", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public MDCMMOLPXKD TMZYFPRTZJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6630", Offset = "0xAA5A30", VA = "0x180AA6630", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<MDCMMOLPXKD> WXUTBMGGOVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xAA68C0", Offset = "0xAA5CC0", VA = "0x180AA68C0", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction OQRUKSQEWFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x89C5750", Offset = "0x89C4B50", VA = "0x1889C5750", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x89C6550", Offset = "0x89C5950", VA = "0x1889C6550", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction HFLCASXGJYY
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x89C65F0", Offset = "0x89C59F0", VA = "0x1889C65F0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x89C6A80", Offset = "0x89C5E80", VA = "0x1889C6A80", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction IXPRILFNLXU
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x89C4DF0", Offset = "0x89C41F0", VA = "0x1889C4DF0", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x89C53F0", Offset = "0x89C47F0", VA = "0x1889C53F0", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action QTQJFNXBRUT
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x89C6730", Offset = "0x89C5B30", VA = "0x1889C6730", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x89C4D50", Offset = "0x89C4150", VA = "0x1889C4D50", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action ZUIZOUMZVEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x89C6690", Offset = "0x89C5A90", VA = "0x1889C6690", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x89C4E90", Offset = "0x89C4290", VA = "0x1889C4E90", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<MDCMMOLPXKD> OALPTJTJAKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x89C4F30", Offset = "0x89C4330", VA = "0x1889C4F30", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x89C5340", Offset = "0x89C4740", VA = "0x1889C5340", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<MDCMMOLPXKD> XZAAKWNMCUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x89C5290", Offset = "0x89C4690", VA = "0x1889C5290", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x89C5B20", Offset = "0x89C4F20", VA = "0x1889C5B20", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action WCODNSHPMTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x89C6230", Offset = "0x89C5630", VA = "0x1889C6230", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x89C5090", Offset = "0x89C4490", VA = "0x1889C5090", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<MDCMMOLPXKD> GWSMLNNXIBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x89C5930", Offset = "0x89C4D30", VA = "0x1889C5930", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x89C4FE0", Offset = "0x89C43E0", VA = "0x1889C4FE0", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x89C6B20", Offset = "0x89C5F20", VA = "0x1889C6B20")]
		public RbexHierarchy(MDCMMOLPXKD rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x89C5130", Offset = "0x89C4530", VA = "0x1889C5130", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x89C5CC0", Offset = "0x89C50C0", VA = "0x1889C5CC0", Slot = "30")]
		public void SetParent(MDCMMOLPXKD newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x89C67D0", Offset = "0x89C5BD0", VA = "0x1889C67D0", Slot = "6")]
		public void XHCFPBMVHJR(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x89C62D0", Offset = "0x89C56D0", VA = "0x1889C62D0", Slot = "7")]
		public void VKBRKLHKAPI(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x89C5BD0", Offset = "0x89C4FD0", VA = "0x1889C5BD0", Slot = "4")]
		public void SSSGUVRVYSN(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x89C5A80", Offset = "0x89C4E80", VA = "0x1889C5A80", Slot = "5")]
		public void SKXJPRWJZVG(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x89C59E0", Offset = "0x89C4DE0", VA = "0x1889C59E0")]
		private void SEXKARWRQUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x89C6A40", Offset = "0x89C5E40", VA = "0x1889C6A40")]
		private void XZVKVDJZEUG(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x89C57F0", Offset = "0x89C4BF0", VA = "0x1889C57F0")]
		private void OUOTSHHWKOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x89C5490", Offset = "0x89C4890", VA = "0x1889C5490")]
		private void MSHZJJGHYNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x89C55C0", Offset = "0x89C49C0", VA = "0x1889C55C0")]
		private void NOACEKOIIDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x89C51D0", Offset = "0x89C45D0", VA = "0x1889C51D0")]
		[CompilerGenerated]
		private object HVAOOIRJYLI()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class EMRMFPVCNAA
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x89BC460", Offset = "0x89BB860", VA = "0x1889BC460")]
		public static XIJLQTOIFNA OPKKMVPCFGF(this MDCMMOLPXKD a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class VEJCHVVRNKF : KIRXPPWADHT, ITYASBIMWZG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly TDUDGQTHQOO KVPEERSNLOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly IBLAFFKFFOJ<MDCMMOLPXKD> GHFMDSASKLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool ULKERFEPOZD;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public IBLAFFKFFOJ<MDCMMOLPXKD> XVIDNDCNCJS
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 TCCPPNTQYJR
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x89D4410", Offset = "0x89D3810", VA = "0x1889D4410", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 PAAPPZUGMVP
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x89D47E0", Offset = "0x89D3BE0", VA = "0x1889D47E0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 XELGSHAKRXT
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x89D42C0", Offset = "0x89D36C0", VA = "0x1889D42C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public MDCMMOLPXKD JDUBUXDLVHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x89D4AE0", Offset = "0x89D3EE0", VA = "0x1889D4AE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x89D4B90", Offset = "0x89D3F90", VA = "0x1889D4B90")]
		public VEJCHVVRNKF(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x89D43A0", Offset = "0x89D37A0", VA = "0x1889D43A0", Slot = "8")]
		public void MMMLWRUNLGZ(MDCMMOLPXKD a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x89D4260", Offset = "0x89D3660", VA = "0x1889D4260", Slot = "9")]
		public void KOWADWCEIHA(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x89D4440", Offset = "0x89D3840", VA = "0x1889D4440")]
		private Vector3 QONMLWKFTHV()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x89D3EC0", Offset = "0x89D32C0", VA = "0x1889D3EC0")]
		private void IRTCYHEMRUQ(MDCMMOLPXKD a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class EZCSCOXFSSH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x89BC5E0", Offset = "0x89BB9E0", VA = "0x1889BC5E0")]
		public static KIRXPPWADHT BFKXFTSNPMG(this MDCMMOLPXKD a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class XUBVKVKMSAV : OVLNXRDBCWB, FTXBYMNAVEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly TDUDGQTHQOO KVPEERSNLOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly OverridableVector3 ZSNEIJYWEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly OverridableVector3 JAEUXDPRXER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private float OFYNKIBRSGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float NQTYBLKJNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3 LPWXVTIPJOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Vector3? XDTHTRSBLGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Quaternion? UYTJQKECIMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool RXIBFMYWGVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool UDVLFVXPVHR;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 MNHZRTTAMUV
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1CBCD10", Offset = "0x1CBC110", VA = "0x181CBCD10", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x89D56B0", Offset = "0x89D4AB0", VA = "0x1889D56B0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 RQTGPCNHYOK
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x89D6460", Offset = "0x89D5860", VA = "0x1889D6460", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float BYNOGWEDGMK
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xAF3800", Offset = "0xAF2C00", VA = "0x180AF3800", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x89D5AB0", Offset = "0x89D4EB0", VA = "0x1889D5AB0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float YICQGZBHIAV
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xAF3810", Offset = "0xAF2C10", VA = "0x180AF3810", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x89D4E10", Offset = "0x89D4210", VA = "0x1889D4E10", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 XELOOSQFCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x89D4EC0", Offset = "0x89D42C0", VA = "0x1889D4EC0", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion ZDDEZHSTXNZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x89D5050", Offset = "0x89D4450", VA = "0x1889D5050", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody GAGOAANQFGW
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x89C4090", Offset = "0x89C3490", VA = "0x1889C4090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction BEEUSRWWYGA
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x89D5610", Offset = "0x89D4A10", VA = "0x1889D5610", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x89D6080", Offset = "0x89D5480", VA = "0x1889D6080", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x89D74D0", Offset = "0x89D68D0", VA = "0x1889D74D0")]
		public XUBVKVKMSAV(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x89D4CF0", Offset = "0x89D40F0", VA = "0x1889D4CF0", Slot = "17")]
		public void ENRDHSNYGCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x89D53B0", Offset = "0x89D47B0", VA = "0x1889D53B0", Slot = "16")]
		public void HRHPCOBGVIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x89D73F0", Offset = "0x89D67F0", VA = "0x1889D73F0", Slot = "19")]
		public void ZSCTQMNMGFR(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x89D51D0", Offset = "0x89D45D0", VA = "0x1889D51D0", Slot = "20")]
		public void HNCZHDOLSGI(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x89D62C0", Offset = "0x89D56C0", VA = "0x1889D62C0", Slot = "18")]
		public void XELUODSCXEV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x89D5BC0", Offset = "0x89D4FC0", VA = "0x1889D5BC0", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x89D56B0", Offset = "0x89D4AB0", VA = "0x1889D56B0")]
		private void MTYFURSKBNH(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x89D5990", Offset = "0x89D4D90", VA = "0x1889D5990")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 OMGNOOEXOLM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x89D5AB0", Offset = "0x89D4EB0", VA = "0x1889D5AB0")]
		private void OWXWUYXDARA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x89D4E10", Offset = "0x89D4210", VA = "0x1889D4E10")]
		private void NFEWAAUQCSR(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x89D6120", Offset = "0x89D5520", VA = "0x1889D6120")]
		private Vector3 PEUJTGCAELD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x89D5760", Offset = "0x89D4B60", VA = "0x1889D5760", Slot = "15")]
		public void NILVGTYSAQF((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x89D5490", Offset = "0x89D4890", VA = "0x1889D5490")]
		private Quaternion KKVQQEJWGOP()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x89D6580", Offset = "0x89D5980", VA = "0x1889D6580")]
		public void YMLVVRJRVHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x89D6650", Offset = "0x89D5A50", VA = "0x1889D6650", Slot = "4")]
		public (float, Vector3) YMLVVRJRVHG(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class NRXSFNJQPST
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x89C3E20", Offset = "0x89C3220", VA = "0x1889C3E20")]
		public static OVLNXRDBCWB SQPAPYJKFVK(this MDCMMOLPXKD a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class SKUNYERKWFJ : DOKBZBOQYLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly TDUDGQTHQOO KVPEERSNLOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly JGNLWQGOMVG QYWOYRFCMEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly RbexInterpolationMode JIOIMXTWYFB;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool TRRGQRVLTAD
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1850A20", Offset = "0x184FE20", VA = "0x181850A20", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode OBBIKPCYHUV
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xAB46D0", Offset = "0xAB3AD0", VA = "0x180AB46D0", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x89CC8F0", Offset = "0x89CBCF0", VA = "0x1889CC8F0")]
		public SKUNYERKWFJ(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x89CC2E0", Offset = "0x89CB6E0", VA = "0x1889CC2E0", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x89CC500", Offset = "0x89CB900", VA = "0x1889CC500")]
		private bool HEKALJKWOCX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x89CC5A0", Offset = "0x89CB9A0", VA = "0x1889CC5A0", Slot = "5")]
		public void IANTGJMUCFH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x89CC610", Offset = "0x89CBA10", VA = "0x1889CC610", Slot = "6")]
		public void MRSYMLCWTWA(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x89CC7C0", Offset = "0x89CBBC0", VA = "0x1889CC7C0", Slot = "9")]
		public void WJXNZGSVRYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x89CC3F0", Offset = "0x89CB7F0", VA = "0x1889CC3F0")]
		private void GLMMOJPIDYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x89CC640", Offset = "0x89CBA40", VA = "0x1889CC640")]
		private void NZQKBWLNRDR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x89CC5D0", Offset = "0x89CB9D0", VA = "0x1889CC5D0", Slot = "8")]
		public void LRUVBOBUDEX(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x89CC3B0", Offset = "0x89CB7B0", VA = "0x1889CC3B0", Slot = "7")]
		public void DLNTHJSLEAY(MDCMMOLPXKD a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class EDIUFXFYJIQ : QQXQUWVWPLX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly TDUDGQTHQOO KVPEERSNLOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly JGNLWQGOMVG ARVXCEOALER;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool PXHGYOAGTPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x89BBF70", Offset = "0x89BB370", VA = "0x1889BBF70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction JTLONOAONAN
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x89BC170", Offset = "0x89BB570", VA = "0x1889BC170", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x89BC210", Offset = "0x89BB610", VA = "0x1889BC210", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x89BC380", Offset = "0x89BB780", VA = "0x1889BC380")]
		public EDIUFXFYJIQ(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x89BC160", Offset = "0x89BB560", VA = "0x1889BC160", Slot = "7")]
		public void JULOZYNYIWW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x89BC2B0", Offset = "0x89BB6B0", VA = "0x1889BC2B0", Slot = "8")]
		public void VDHQAJFEBSD(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x89BC020", Offset = "0x89BB420", VA = "0x1889BC020", Slot = "9")]
		public void GANJDVPZUFF(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x89BC2C0", Offset = "0x89BB6C0", VA = "0x1889BC2C0", Slot = "12")]
		public void XXZEGXGYRKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x89BC300", Offset = "0x89BB700", VA = "0x1889BC300", Slot = "10")]
		public void ZSCTQMNMGFR(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x89BC130", Offset = "0x89BB530", VA = "0x1889BC130", Slot = "11")]
		public void HNCZHDOLSGI(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class GZZCXXBJJZP : RKDAGPVYYBL, NNNANBSPYNO, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly TDUDGQTHQOO KVPEERSNLOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private RRNetworkView BOXXBDGJMZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool TFZHVLLHCQE;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public RRNetworkView AYVNQCZKTYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool JUNNLNCQZYK
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x89C0C60", Offset = "0x89C0060", VA = "0x1889C0C60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool FVFPRBKGTII
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xCA7840", Offset = "0xCA6C40", VA = "0x180CA7840", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction AFIIIPSPZMZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x89C11B0", Offset = "0x89C05B0", VA = "0x1889C11B0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x89C0A90", Offset = "0x89BFE90", VA = "0x1889C0A90", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x89C1610", Offset = "0x89C0A10", VA = "0x1889C1610")]
		public GZZCXXBJJZP(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x89C0B30", Offset = "0x89BFF30", VA = "0x1889C0B30", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x89C0C70", Offset = "0x89C0070", VA = "0x1889C0C70", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x89C0ED0", Offset = "0x89C02D0", VA = "0x1889C0ED0", Slot = "10")]
		public void KDLWWRDQWTY(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x89C1040", Offset = "0x89C0440", VA = "0x1889C1040", Slot = "11")]
		public void PHFKUMCJXOW(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x89C0D60", Offset = "0x89C0160", VA = "0x1889C0D60")]
		private void EBFGIAZJSHY(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x89C1250", Offset = "0x89C0650", VA = "0x1889C1250")]
		private void TBZIXVDVKFY(HUFBFJCMRYV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x89C13A0", Offset = "0x89C07A0", VA = "0x1889C13A0")]
		private void YBOBKKYPEIL(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class LKOKIHFMCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x89C1990", Offset = "0x89C0D90", VA = "0x1889C1990")]
		public static RKDAGPVYYBL Lifecycle(this MDCMMOLPXKD impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class IICPYHIGTNH : FMVGGBEYATY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly TDUDGQTHQOO KVPEERSNLOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private RigidbodyConstraints XYYIDYRHUCK;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool VZYSUFANUWF
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xBDC170", Offset = "0xBDB570", VA = "0x180BDC170", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xBDBA60", Offset = "0xBDAE60", VA = "0x180BDBA60", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool FPYFQCGLQWM
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xBDBDE0", Offset = "0xBDB1E0", VA = "0x180BDBDE0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xBDBD70", Offset = "0xBDB170", VA = "0x180BDBD70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints GEJOIYWIOOS
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xAA8420", Offset = "0xAA7820", VA = "0x180AA8420", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x89C1790", Offset = "0x89C0B90", VA = "0x1889C1790", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x89C18F0", Offset = "0x89C0CF0", VA = "0x1889C18F0")]
		public IICPYHIGTNH(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x89C18C0", Offset = "0x89C0CC0", VA = "0x1889C18C0", Slot = "9")]
		public void ZSCTQMNMGFR(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x89C1760", Offset = "0x89C0B60", VA = "0x1889C1760", Slot = "10")]
		public void HNCZHDOLSGI(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class ZHSTSBGYOJQ : IHRHFZODEKV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly MDCMMOLPXKD KVPEERSNLOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private float OFNYXEHXYRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private float SAVMORBXMVQ;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public float CNHPCPBRRZG
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xAFF8D0", Offset = "0xAFECD0", VA = "0x180AFF8D0", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x89D7D50", Offset = "0x89D7150", VA = "0x1889D7D50", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float WXKKLNHXPTY
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xAFF8F0", Offset = "0xAFECF0", VA = "0x180AFF8F0", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x89D7BE0", Offset = "0x89D6FE0", VA = "0x1889D7BE0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x89D7E70", Offset = "0x89D7270", VA = "0x1889D7E70")]
		public ZHSTSBGYOJQ(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x89D7E20", Offset = "0x89D7220", VA = "0x1889D7E20", Slot = "8")]
		public void ZSCTQMNMGFR(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x89D7CB0", Offset = "0x89D70B0", VA = "0x1889D7CB0", Slot = "9")]
		public void HNCZHDOLSGI(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class PYCUNLFZETA : KBNDWBWAEBF
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly Log OUSCYDFJMIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly TDUDGQTHQOO KVPEERSNLOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool TCMTHNRXGEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool LFVBCLDRGYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int KHCWYVOBDEM;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private Rigidbody GAGOAANQFGW
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x89C4090", Offset = "0x89C3490", VA = "0x1889C4090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool UYZVDSLOIDT
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x89C3F70", Offset = "0x89C3370", VA = "0x1889C3F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private MDCMMOLPXKD LKSGBNNQMMS
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x89C3F90", Offset = "0x89C3390", VA = "0x1889C3F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool CYTBCWJLFFU
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x89C4A20", Offset = "0x89C3E20", VA = "0x1889C4A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction SUIKJSCKBIH
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x89C40E0", Offset = "0x89C34E0", VA = "0x1889C40E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x89C3FF0", Offset = "0x89C33F0", VA = "0x1889C3FF0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x89C4B00", Offset = "0x89C3F00", VA = "0x1889C4B00")]
		public PYCUNLFZETA(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x89C3EE0", Offset = "0x89C32E0", VA = "0x1889C3EE0", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x89C4290", Offset = "0x89C3690", VA = "0x1889C4290", Slot = "8")]
		public void PGHNTVRXCRD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x89C4460", Offset = "0x89C3860", VA = "0x1889C4460", Slot = "7")]
		public bool QMHAXSZAZJJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x89C4740", Offset = "0x89C3B40", VA = "0x1889C4740", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x89C4180", Offset = "0x89C3580", VA = "0x1889C4180", Slot = "13")]
		public void NVVEDRPICJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x89C4900", Offset = "0x89C3D00", VA = "0x1889C4900", Slot = "12")]
		public void WLCAVZCIYEG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x89C4220", Offset = "0x89C3620", VA = "0x1889C4220", Slot = "10")]
		public bool OYHYLOUPTFP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x89C4810", Offset = "0x89C3C10", VA = "0x1889C4810", Slot = "11")]
		public bool WBNYLEQFIRW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x89C42A0", Offset = "0x89C36A0", VA = "0x1889C42A0")]
		private bool POOAAPKIYFU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x89C45B0", Offset = "0x89C39B0", VA = "0x1889C45B0")]
		private void RSQMIWHIMDS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class MQFYVIXGAFZ : TVIMXTVYVEQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly TDUDGQTHQOO KVPEERSNLOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly JGNLWQGOMVG MGXEXMKKYGX;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Rigidbody GAGOAANQFGW
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C00", Offset = "0xAA3000", VA = "0x180AA3C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool CYTBCWJLFFU
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x89C35E0", Offset = "0x89C29E0", VA = "0x1889C35E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool UKBLOVDCFAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1850A20", Offset = "0x184FE20", VA = "0x181850A20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x89C3640", Offset = "0x89C2A40", VA = "0x1889C3640")]
		public MQFYVIXGAFZ(MDCMMOLPXKD a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x89C3030", Offset = "0x89C2430", VA = "0x1889C3030", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x89C30D0", Offset = "0x89C24D0", VA = "0x1889C30D0", Slot = "7")]
		public void BWVBBEUAVAR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x89C35B0", Offset = "0x89C29B0", VA = "0x1889C35B0", Slot = "8")]
		public void MUXRAKWSKBC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x89C3100", Offset = "0x89C2500", VA = "0x1889C3100", Slot = "9")]
		public void CKKBKCXIFUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x89C2E40", Offset = "0x89C2240", VA = "0x1889C2E40", Slot = "10")]
		public void ANYUEQQLURQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x89C3430", Offset = "0x89C2830", VA = "0x1889C3430", Slot = "11")]
		public void GHIEORFBXXL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class GBIUYDXPNLK : XIXJQSHJILR, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly TDUDGQTHQOO KVPEERSNLOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly JGNLWQGOMVG AQEGCXOIMRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private float LBKSDQFAIQR;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public XVPZTDGMZUH FJTLXJRRRFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C10", Offset = "0xAA3010", VA = "0x180AA3C10", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public TLELRAOYGZE FTOHZJUUMFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BD0", Offset = "0xAA2FD0", VA = "0x180AA3BD0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 XELGSHAKRXT
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x89BD9E0", Offset = "0x89BCDE0", VA = "0x1889BD9E0", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x89BCF40", Offset = "0x89BC340", VA = "0x1889BCF40", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 NVGRKLERKBU
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x89BD860", Offset = "0x89BCC60", VA = "0x1889BD860", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x89BCBC0", Offset = "0x89BBFC0", VA = "0x1889BCBC0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 ZRHPETCQSPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x89BCD80", Offset = "0x89BC180", VA = "0x1889BCD80", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x89BDFF0", Offset = "0x89BD3F0", VA = "0x1889BDFF0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 EMZYRXTARGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x89BD5C0", Offset = "0x89BC9C0", VA = "0x1889BD5C0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x89BEA90", Offset = "0x89BDE90", VA = "0x1889BEA90", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float LVTYNGFZNTH
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xAFF8E0", Offset = "0xAFECE0", VA = "0x180AFF8E0", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x89BD750", Offset = "0x89BCB50", VA = "0x1889BD750", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool XLGWMCPNLYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x2304780", Offset = "0x2303B80", VA = "0x182304780", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private JYYSBSDWVFJ CHSLYKDNRBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x7F46BA0", Offset = "0x7F45FA0", VA = "0x187F46BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool UYZVDSLOIDT
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x89BD540", Offset = "0x89BC940", VA = "0x1889BD540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x89BFDD0", Offset = "0x89BF1D0", VA = "0x1889BFDD0")]
		public GBIUYDXPNLK(MDCMMOLPXKD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x89BC6A0", Offset = "0x89BBAA0", VA = "0x1889BC6A0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x89BD480", Offset = "0x89BC880", VA = "0x1889BD480", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x89BFCA0", Offset = "0x89BF0A0", VA = "0x1889BFCA0", Slot = "28")]
		public void ZSCTQMNMGFR(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x1611F80", Offset = "0x1611380", VA = "0x181611F80", Slot = "20")]
		public void JDHFQVXJOSF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1612080", Offset = "0x1611480", VA = "0x181612080", Slot = "30")]
		public void MBWWEFHQYUE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x89BDE10", Offset = "0x89BD210", VA = "0x1889BDE10", Slot = "35")]
		public Vector3 MPQWIBSWUHT(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x89BF4A0", Offset = "0x89BE8A0", VA = "0x1889BF4A0", Slot = "34")]
		public Vector3 XVUIMHUOZRZ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x89BC6A0", Offset = "0x89BBAA0", VA = "0x1889BC6A0", Slot = "27")]
		public void ADFXFYZZPZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x89BD4E0", Offset = "0x89BC8E0", VA = "0x1889BD4E0", Slot = "25")]
		public void EOLGOZXMJJX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x89BF660", Offset = "0x89BEA60", VA = "0x1889BF660", Slot = "24")]
		public void YCZUHBNVTEU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x89BEBA0", Offset = "0x89BDFA0", VA = "0x1889BEBA0", Slot = "33")]
		public void TEZNATNIPJC(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x89BD560", Offset = "0x89BC960", VA = "0x1889BD560", Slot = "32")]
		public void GJROQISHZUV(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x89BE750", Offset = "0x89BDB50", VA = "0x1889BE750", Slot = "31")]
		public void OYYGEOQOSWY(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x89BE0B0", Offset = "0x89BD4B0", VA = "0x1889BE0B0", Slot = "22")]
		public void OYOPQLSKYBY(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x89BDB90", Offset = "0x89BCF90", VA = "0x1889BDB90", Slot = "21")]
		public void LWECQOKYRYT(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x89BC740", Offset = "0x89BBB40", VA = "0x1889BC740", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void AMJZSFXTBYY(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1744560", Offset = "0x1743960", VA = "0x181744560")]
		private static void ENKAWZSWQOI(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x89BEAC0", Offset = "0x89BDEC0", VA = "0x1889BEAC0", Slot = "29")]
		public Vector3 SVYRDAHFPKR(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x89BEDE0", Offset = "0x89BE1E0", VA = "0x1889BEDE0", Slot = "26")]
		public void TGMXTJNVUWA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x89BD750", Offset = "0x89BCB50", VA = "0x1889BD750")]
		private void JSQTEDPIQHL(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x89BE8F0", Offset = "0x89BDCF0", VA = "0x1889BE8F0")]
		private void PFKLGUCPISZ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x89BFB20", Offset = "0x89BEF20", VA = "0x1889BFB20")]
		private Vector3 YQKWLIBPUOO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x89BEF70", Offset = "0x89BE370", VA = "0x1889BEF70")]
		private void UWUNLEZKJUC(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x89BCBF0", Offset = "0x89BBFF0", VA = "0x1889BCBF0")]
		private Vector3 AZGPHHWJGBE()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x89BD000", Offset = "0x89BC400", VA = "0x1889BD000")]
		private void DWXGCRMQJBE(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x89BF6C0", Offset = "0x89BEAC0", VA = "0x1889BF6C0")]
		private void YIFYZVVJZOF(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x89BF3F0", Offset = "0x89BE7F0", VA = "0x1889BF3F0")]
		private void XULHPHUOCTV()
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
