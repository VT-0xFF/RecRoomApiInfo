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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
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
		[Cpp2IlInjected.Address(RVA = "0x8CEEAC0", Offset = "0x8CED8C0", VA = "0x188CEEAC0", Slot = "4")]
		public override void DELFABVRANX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		private int[] TDVEOKFWPNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset GMAWWHUIGYL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86D4F80", Offset = "0x86D3D80", VA = "0x1886D4F80", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF830", Offset = "0x8CFE630", VA = "0x188CFF830")]
		private void BUNBWTHGJFJ(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8CFFB10", Offset = "0x8CFE910", VA = "0x188CFFB10", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8CFFB70", Offset = "0x8CFE970", VA = "0x188CFFB70")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, EMPROCEKPQD, ZICDSLSKRWK, SHUXAXTXKYA
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log XONYJGYQIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool PZDNXTBXSNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private VTYDTFHUYHL QMNWPXZLFEW;

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
		private Transform USOPKZZNRGC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal VTYDTFHUYHL RBNEYNJDKBM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8CFBB30", Offset = "0x8CFA930", VA = "0x188CFBB30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private VTYDTFHUYHL ZMAHOXPMGDW
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int XIEGCBTMSRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC290", Offset = "0x8CFB090", VA = "0x188CFC290")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx HTQSNQVFSPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC5F0", Offset = "0x8CFB3F0", VA = "0x188CFC5F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx JNMQCQBFHQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC530", Offset = "0x8CFB330", VA = "0x188CFC530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx YTPNFINVAEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD1F0", Offset = "0x8CFBFF0", VA = "0x188CFD1F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8CFE6F0", Offset = "0x8CFD4F0", VA = "0x188CFE6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8090280", Offset = "0x808F080", VA = "0x188090280", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x80903D0", Offset = "0x808F1D0", VA = "0x1880903D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform SKWHCKDVCZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x23B5E50", Offset = "0x23B4C50", VA = "0x1823B5E50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform RLWTLBZQQDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x23B5E50", Offset = "0x23B4C50", VA = "0x1823B5E50", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform QYLDWWUBZWP
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x23B5E50", Offset = "0x23B4C50", VA = "0x1823B5E50", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate YRTCCDUEYSX
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC2F0", Offset = "0x8CFB0F0", VA = "0x188CFC2F0")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDEA0", Offset = "0x8CFCCA0", VA = "0x188CFDEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool YRGBXFXWFAI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC900", Offset = "0x8CFB700", VA = "0x188CFC900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool HDTQQJZEDWO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC410", Offset = "0x8CFB210", VA = "0x188CFC410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public HWSRBBGWKCF GGDAZCAMPVM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC840", Offset = "0x8CFB640", VA = "0x188CFC840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8CFE060", Offset = "0x8CFCE60", VA = "0x188CFE060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public CNBBDIFDYIQ MEAHVDUSSOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC7E0", Offset = "0x8CFB5E0", VA = "0x188CFC7E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDFF0", Offset = "0x8CFCDF0", VA = "0x188CFDFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool QHYARYUAFUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC730", Offset = "0x8CFB530", VA = "0x188CFC730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody YBYPUZZMAYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC790", Offset = "0x8CFB590", VA = "0x188CFC790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool EVDIHWFIEAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC470", Offset = "0x8CFB270", VA = "0x188CFC470")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDF10", Offset = "0x8CFCD10", VA = "0x188CFDF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool LXZQWGCEMWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x17E4C20", Offset = "0x17E3A20", VA = "0x1817E4C20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float LOUHJNCNIYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD190", Offset = "0x8CFBF90", VA = "0x188CFD190")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float WOIAULMBFVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD130", Offset = "0x8CFBF30", VA = "0x188CFD130")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8CFE680", Offset = "0x8CFD480", VA = "0x188CFE680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float FGBRENLRYHM
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8CFCB60", Offset = "0x8CFB960", VA = "0x188CFCB60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8CFE300", Offset = "0x8CFD100", VA = "0x188CFE300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float OWPVFYRJWMY
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC960", Offset = "0x8CFB760", VA = "0x188CFC960")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8CFE0D0", Offset = "0x8CFCED0", VA = "0x188CFE0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool ANMMGQTJMIL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD740", Offset = "0x8CFC540", VA = "0x188CFD740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8CFEC30", Offset = "0x8CFDA30", VA = "0x188CFEC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 QMHSFJKXURZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8CFCF10", Offset = "0x8CFBD10", VA = "0x188CFCF10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8CFE450", Offset = "0x8CFD250", VA = "0x188CFE450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 DMDTSHMTWPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD880", Offset = "0x8CFC680", VA = "0x188CFD880")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode DFNWRYOWBJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8CFCAA0", Offset = "0x8CFB8A0", VA = "0x188CFCAA0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8CFE220", Offset = "0x8CFD020", VA = "0x188CFE220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float XPVRHQGDZYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC4D0", Offset = "0x8CFB2D0", VA = "0x188CFC4D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDF80", Offset = "0x8CFCD80", VA = "0x188CFDF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints VNDFNBZFWLW
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8CFCB00", Offset = "0x8CFB900", VA = "0x188CFCB00")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8CFE290", Offset = "0x8CFD090", VA = "0x188CFE290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 CLHNGCWTCJU
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD2B0", Offset = "0x8CFC0B0", VA = "0x188CFD2B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 EIHAZZNKBPM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD2B0", Offset = "0x8CFC0B0", VA = "0x188CFD2B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8CFEA10", Offset = "0x8CFD810", VA = "0x188CFEA10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float RCFJIWEOFNT
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8CFCFF0", Offset = "0x8CFBDF0", VA = "0x188CFCFF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8CFE530", Offset = "0x8CFD330", VA = "0x188CFE530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float ZYELEEHURXI
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD6E0", Offset = "0x8CFC4E0", VA = "0x188CFD6E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8CFEBC0", Offset = "0x8CFD9C0", VA = "0x188CFEBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion XIABPLPSXVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD390", Offset = "0x8CFC190", VA = "0x188CFD390")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8CFE790", Offset = "0x8CFD590", VA = "0x188CFE790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion MPGPLANLHDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD610", Offset = "0x8CFC410", VA = "0x188CFD610")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8CFEAF0", Offset = "0x8CFD8F0", VA = "0x188CFEAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 WRBZEPAGBRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD460", Offset = "0x8CFC260", VA = "0x188CFD460")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8CFE860", Offset = "0x8CFD660", VA = "0x188CFE860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion VVKLQJZOSMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD540", Offset = "0x8CFC340", VA = "0x188CFD540")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8CFE940", Offset = "0x8CFD740", VA = "0x188CFE940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 TSZUKVFTJMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD7A0", Offset = "0x8CFC5A0", VA = "0x188CFD7A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8CFECA0", Offset = "0x8CFDAA0", VA = "0x188CFECA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 TXMQJXJOFUY
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD050", Offset = "0x8CFBE50", VA = "0x188CFD050")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8CFE5A0", Offset = "0x8CFD3A0", VA = "0x188CFE5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 VMJNHDYZFJP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC9C0", Offset = "0x8CFB7C0", VA = "0x188CFC9C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8CFE140", Offset = "0x8CFCF40", VA = "0x188CFE140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 OEFLKZZDIRW
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8CFCE30", Offset = "0x8CFBC30", VA = "0x188CFCE30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8CFE370", Offset = "0x8CFD170", VA = "0x188CFE370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 UVCAKMQZFVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8CFCCF0", Offset = "0x8CFBAF0", VA = "0x188CFCCF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion CXGSQIQPZWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8CFCC20", Offset = "0x8CFBA20", VA = "0x188CFCC20")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 YYTBFGVOMMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDA40", Offset = "0x8CFC840", VA = "0x188CFDA40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 MZDOZYFEQUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8CFD960", Offset = "0x8CFC760", VA = "0x188CFD960")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool YUUXSAFJCXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8CFCDD0", Offset = "0x8CFBBD0", VA = "0x188CFCDD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool SVUHEAYSRNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC8A0", Offset = "0x8CFB6A0", VA = "0x188CFC8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool YAGUUQCSJXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC3B0", Offset = "0x8CFB1B0", VA = "0x188CFC3B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool JJANCIXGITC
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC350", Offset = "0x8CFB150", VA = "0x188CFC350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool LSKKBTYRTAN
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC230", Offset = "0x8CFB030", VA = "0x188CFC230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool ZGFNQMFJUTK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8CFCBC0", Offset = "0x8CFB9C0", VA = "0x188CFCBC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool JUHXHEXIQPQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xBD8F50", Offset = "0xBD7D50", VA = "0x180BD8F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction AKXZSQKVIJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC150", Offset = "0x8CFAF50", VA = "0x188CFC150")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDDC0", Offset = "0x8CFCBC0", VA = "0x188CFDDC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction UCCXETMUZEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8CFBEC0", Offset = "0x8CFACC0", VA = "0x188CFBEC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDB20", Offset = "0x8CFC920", VA = "0x188CFDB20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction VQIUBNUHTJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8CFBF20", Offset = "0x8CFAD20", VA = "0x188CFBF20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDB90", Offset = "0x8CFC990", VA = "0x188CFDB90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction OFWZSFENFEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC070", Offset = "0x8CFAE70", VA = "0x188CFC070")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDCE0", Offset = "0x8CFCAE0", VA = "0x188CFDCE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> HSGTGVJPAYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC000", Offset = "0x8CFAE00", VA = "0x188CFC000")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDC70", Offset = "0x8CFCA70", VA = "0x188CFDC70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction ROLQMOUYBGR
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC0E0", Offset = "0x8CFAEE0", VA = "0x188CFC0E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDD50", Offset = "0x8CFCB50", VA = "0x188CFDD50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction VILIBZTPIID
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8CFC1C0", Offset = "0x8CFAFC0", VA = "0x188CFC1C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDE30", Offset = "0x8CFCC30", VA = "0x188CFDE30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction RPTCFYQJSNU
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8CFBF90", Offset = "0x8CFAD90", VA = "0x188CFBF90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8CFDC00", Offset = "0x8CFCA00", VA = "0x188CFDC00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAC8C40", Offset = "0xAC7A40", VA = "0x180AC8C40", Slot = "8")]
		private void KATQAKFQGJS(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA820", Offset = "0x8CF9620", VA = "0x188CFA820", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8CFAE10", Offset = "0x8CF9C10", VA = "0x188CFAE10")]
		internal void THYDJSMHDXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8CFBBE0", Offset = "0x8CFA9E0", VA = "0x188CFBBE0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA570", Offset = "0x8CF9370", VA = "0x188CFA570")]
		public EMPROCEKPQD GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB790", Offset = "0x8CFA590", VA = "0x188CFB790")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA1C0", Offset = "0x8CF8FC0", VA = "0x188CFA1C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8CFBA20", Offset = "0x8CFA820", VA = "0x188CFBA20")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8CFBB30", Offset = "0x8CFA930", VA = "0x188CFBB30")]
		private VTYDTFHUYHL ZVZLQCVJAZE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8CFAC90", Offset = "0x8CF9A90", VA = "0x188CFAC90")]
		private void NRKVJJKJWDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8CFAF60", Offset = "0x8CF9D60", VA = "0x188CFAF60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8CFAEA0", Offset = "0x8CF9CA0", VA = "0x188CFAEA0")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8CFAE10", Offset = "0x8CF9C10", VA = "0x188CFAE10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8CFAF00", Offset = "0x8CF9D00", VA = "0x188CFAF00")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8CFAFC0", Offset = "0x8CF9DC0", VA = "0x188CFAFC0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8CF97B0", Offset = "0x8CF85B0", VA = "0x188CF97B0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB020", Offset = "0x8CF9E20", VA = "0x188CFB020")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA510", Offset = "0x8CF9310", VA = "0x188CFA510")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8CFAC30", Offset = "0x8CF9A30", VA = "0x188CFAC30")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB8F0", Offset = "0x8CFA6F0", VA = "0x188CFB8F0")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB330", Offset = "0x8CFA130", VA = "0x188CFB330")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA8B0", Offset = "0x8CF96B0", VA = "0x188CFA8B0")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA9B0", Offset = "0x8CF97B0", VA = "0x188CFA9B0")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9A20", Offset = "0x8CF8820", VA = "0x188CF9A20")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB090", Offset = "0x8CF9E90", VA = "0x188CFB090")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9A90", Offset = "0x8CF8890", VA = "0x188CF9A90")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB100", Offset = "0x8CF9F00", VA = "0x188CFB100")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB870", Offset = "0x8CFA670", VA = "0x188CFB870")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB690", Offset = "0x8CFA490", VA = "0x188CFB690")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB590", Offset = "0x8CFA390", VA = "0x188CFB590")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA710", Offset = "0x8CF9510", VA = "0x188CFA710")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA600", Offset = "0x8CF9400", VA = "0x188CFA600")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9930", Offset = "0x8CF8730", VA = "0x188CF9930")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9820", Offset = "0x8CF8620", VA = "0x188CF9820")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9C60", Offset = "0x8CF8A60", VA = "0x188CF9C60")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9B00", Offset = "0x8CF8900", VA = "0x188CF9B00")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8CFBCB0", Offset = "0x8CFAAB0", VA = "0x188CFBCB0")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8CFAB20", Offset = "0x8CF9920", VA = "0x188CFAB20")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA4B0", Offset = "0x8CF92B0", VA = "0x188CFA4B0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA450", Offset = "0x8CF9250", VA = "0x188CFA450")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA3F0", Offset = "0x8CF91F0", VA = "0x188CFA3F0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA390", Offset = "0x8CF9190", VA = "0x188CFA390")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB490", Offset = "0x8CFA290", VA = "0x188CFB490")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB390", Offset = "0x8CFA190", VA = "0x188CFB390")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB250", Offset = "0x8CFA050", VA = "0x188CFB250")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8CFBA30", Offset = "0x8CFA830", VA = "0x188CFBA30")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8CFAAB0", Offset = "0x8CF98B0", VA = "0x188CFAAB0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB9C0", Offset = "0x8CFA7C0", VA = "0x188CFB9C0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8CFBC50", Offset = "0x8CFAA50", VA = "0x188CFBC50")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9BF0", Offset = "0x8CF89F0", VA = "0x188CF9BF0")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB170", Offset = "0x8CF9F70", VA = "0x188CFB170")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9FF0", Offset = "0x8CF8DF0", VA = "0x188CF9FF0")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9EF0", Offset = "0x8CF8CF0", VA = "0x188CF9EF0")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA0B0", Offset = "0x8CF8EB0", VA = "0x188CFA0B0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9E20", Offset = "0x8CF8C20", VA = "0x188CF9E20")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9D50", Offset = "0x8CF8B50", VA = "0x188CF9D50")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB1E0", Offset = "0x8CF9FE0", VA = "0x188CFB1E0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8CFAB10", Offset = "0x8CF9910", VA = "0x188CFAB10", Slot = "13")]
		private void JMOZZTPDPTR(XGUFFTROOLL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8CFBE50", Offset = "0x8CFAC50", VA = "0x188CFBE50")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x12DE3A0", Offset = "0x12DD1A0", VA = "0x1812DE3A0", Slot = "4")]
		private GameObject HQSADPQYSEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAF3460", Offset = "0xAF2260", VA = "0x180AF3460", Slot = "10")]
		private bool QTWCUGTDLUJ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class WGKZEAATYWI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF6F0", Offset = "0x8CFE4F0", VA = "0x188CFF6F0")]
		public static VTYDTFHUYHL RBNEYNJDKBM(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(WRFETHLVKCS), new string[] { })]
	public class RigidbodyExManager : WRFETHLVKCS, EYUUBVPPSNU
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private FLGKUZEUFUV FDATSQVYVNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private BPMJRKKZCFO BAKYNTXCIPA;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public FLGKUZEUFUV RIAWDMJTZTG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public BPMJRKKZCFO GSVTOQLBLYS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8CF94E0", Offset = "0x8CF82E0", VA = "0x188CF94E0", Slot = "7")]
		public void InitReferences(ODEDMYTJIPB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9550", Offset = "0x8CF8350", VA = "0x188CF9550", Slot = "6")]
		public VTYDTFHUYHL QNURALBXZLQ(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static KMRHHFCXZOG UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int EGMHRJRTKCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int RWBJHJQZEFW;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8CF73D0", Offset = "0x8CF61D0", VA = "0x188CF73D0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8CF7450", Offset = "0x8CF6250", VA = "0x188CF7450")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8CF73F0", Offset = "0x8CF61F0", VA = "0x188CF73F0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8CF7550", Offset = "0x8CF6350", VA = "0x188CF7550")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class YXVBVPFGQZO
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class UXGHJLQBCKE : HWSRBBGWKCF, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAD74C0", Offset = "0xAD62C0", VA = "0x180AD74C0", Slot = "4")]
			public Vector3 UYBLEYOGHPH()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAD74C0", Offset = "0xAD62C0", VA = "0x180AD74C0", Slot = "5")]
			public Vector3 SGMJRYNGROE()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "6")]
			public bool XOTEFVPOMUT(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public UXGHJLQBCKE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static HWSRBBGWKCF GEWDHYKICZT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8CFF760", Offset = "0x8CFE560", VA = "0x188CFF760")]
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
	public interface BFMNSAIGVKR
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CollisionDetectionMode NNMNLFZXKBK
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
		void EPBPJKSWVWE(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AOFGHDUOEMD(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZKLOUXNZQIZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool EODMHWROVGE(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface PYTCNKKVUWW : IDisposable, YYJRABEDHZK
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		TransformTrackRate YRTCCDUEYSX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> HSGTGVJPAYY;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface BPMJRKKZCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		BEARRGDCUTT BUBCUIORNNB(VTYDTFHUYHL a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		WZVIOSNNMXP ASPNKEXGNKP(VTYDTFHUYHL a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DIRKANQLDSO TQZIAFVBLBK(VTYDTFHUYHL a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		GYOMDFYFYMP ZXCKFZNYMQB(VTYDTFHUYHL a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		GFDJHUBNMNH HJYQCBHQATR(VTYDTFHUYHL a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		PYTCNKKVUWW UDNEHHVPHWY(VTYDTFHUYHL a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		UKIURXUCANR DBFAYWSURHX(VTYDTFHUYHL a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		QQULRGKNYTP FHOHHBRLUFF(VTYDTFHUYHL a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		BFMNSAIGVKR JXKLVPIXFBJ(VTYDTFHUYHL a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		TCPJQICAXHS SDFPRKXGAYK(VTYDTFHUYHL a);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		MTTYDTMWWBI NBULIVXTFAA(VTYDTFHUYHL a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		BADRHFAUDTI BQMXWYOQEUA(VTYDTFHUYHL a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		QSTVAHUHPJG SJNXUWCRFTA(VTYDTFHUYHL a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		SCQWRCDVNYQ LDLCSPAYXVU(VTYDTFHUYHL a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		INOTHOVMCQI MHHMZAJUYQW(VTYDTFHUYHL a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		VTYDTFHUYHL QNURALBXZLQ(RigidbodyEx a, RigidbodyExData b, WRFETHLVKCS c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface QQULRGKNYTP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LHGGDPWVKCC(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ZULCJNDOBBS(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CSNTDCSDBVL(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PQZKVHSOXVT(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface TCPJQICAXHS
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool SUPSUJBHAET
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
		void ZKLOUXNZQIZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QAHCTGFHQWW(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface BEARRGDCUTT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IReadOnlyList<VTYDTFHUYHL> MQSXNWJMIMY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		VTYDTFHUYHL JNMQCQBFHQM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		VTYDTFHUYHL VEEIKBNANOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction UCCXETMUZEY;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction VQIUBNUHTJM;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction TPVWGGLXKQM;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action JQWEXGTIOYZ;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action IUUXRSEZOFM;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<VTYDTFHUYHL> NBBGPPNMMKX;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<VTYDTFHUYHL> MOPOLIEYWAE;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action NIFXVHFFQGX;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<VTYDTFHUYHL> SFZLLHEKAYU;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(VTYDTFHUYHL newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface DIRKANQLDSO
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Vector3 YEJBGGYXMYF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Vector3 JRFEAAFAGID
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TZVNAKDBTSD(VTYDTFHUYHL a, object b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VTZAUOUPJBK(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface SCQWRCDVNYQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 CBQJDUKQXWD
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 VYXHYDMQMAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float AEBEGJJZDAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		float BIGGNULVKDV
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Vector3 WGMDWNAFTHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		Quaternion FQMLRQKHXWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction DERVLKPCOJE;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void FTHCFIMYMPJ((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void AQFPJARNBCO();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void WHRFQCUWDQZ();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void CPWJIVHVIOX();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ZKLOUXNZQIZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void QAHCTGFHQWW(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface QSTVAHUHPJG
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LKFGGTLXTUT(object a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TDWTQHMKDWG(object a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XWJIIEQZUKK(VTYDTFHUYHL a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VZAEEZULEQR(VTYDTFHUYHL a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void FVBHBFVKPMO();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface UKIURXUCANR
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool KVYCCPHUQMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction OMOTRHQXKWH;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YSMJXGLOCAU(object a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RCJPBOFOCBL(object a);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AJJMVUGYEQV(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void ZKLOUXNZQIZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void QAHCTGFHQWW(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface BADRHFAUDTI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool YRGBXFXWFAI
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool HDTQQJZEDWO
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction QRTOHDTVSWH;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XUDELYZYFKI(VTYDTFHUYHL a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void GQBZCLGBVTS(VTYDTFHUYHL a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface INOTHOVMCQI
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool EVDIHWFIEAX
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool WQOUONKBEAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		RigidbodyConstraints VMSQYQISVUY
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
		void ZKLOUXNZQIZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void QAHCTGFHQWW(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface GYOMDFYFYMP
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		float RVMRATVCUQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		float ZMGLCBYNOZW
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
		void ZKLOUXNZQIZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void QAHCTGFHQWW(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface GFDJHUBNMNH
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		static bool VFUPHLFFUXH;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction KDDQOCTRCGF;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool SQGMZITGAVD();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DALHTZSQTJF();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool SPUQLJYDFCL();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool AOQMSARUDVY();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void JRYEICWGHMI(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void UHFPMSVQBBH();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface MTTYDTMWWBI
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		Rigidbody YBYPUZZMAYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool WQNBKROSDCR
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
		void MJMPBLHEZFJ(object a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void WKUOSNWIZLM(object a);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void INSVOXGPNDF();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface WZVIOSNNMXP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		HWSRBBGWKCF GGDAZCAMPVM
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		CNBBDIFDYIQ MEAHVDUSSOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Vector3 NRCHFMZYSHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Vector3 CRGQXOGSCDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		Vector3 BMRHGYZZSSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 UVEHQKAHZZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		float XPVRHQGDZYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool QHYARYUAFUN
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
		void LKSDIUWPGAX(object a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void TEIHQNGZLTH(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void JCNJCCOWVQM(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void XCBPBVAEFNY(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void UGWNBEIXWGC();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void BKCEIHPCLIH();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void CXLILHYXUAO();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void PQTAXTWXDCK();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void ZKLOUXNZQIZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 FAQDRQAECLR(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void OBJCMJIVOXU(object a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void LCQGZCKDSQK(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void BZSIXLIPMDR(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void BXCTJWQDWES(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 SRDLYAWMJVD(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 ACLSZKWDQLV(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface FLGKUZEUFUV
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool AXYUNGUCEJI
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UHMYVOGTHII(string a);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ICGBCZPQVIX(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IMYMLYJLOCB RFRJPMDLDOG(int a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GZWLZPYMSGW(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface WRFETHLVKCS
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		FLGKUZEUFUV RIAWDMJTZTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		BPMJRKKZCFO GSVTOQLBLYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		VTYDTFHUYHL QNURALBXZLQ(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class PTTJIYWBTQY : VTYDTFHUYHL, IDisposable, DTTJKZNGMLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal readonly WRFETHLVKCS JTGRNIXZGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal BEARRGDCUTT RBRESLWJZJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal QSTVAHUHPJG DZRANNDFETI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal BADRHFAUDTI MIBKNUZXIGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal WZVIOSNNMXP TSZUKVFTJMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal DIRKANQLDSO PBBCSWNRYEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal SCQWRCDVNYQ EFXVHLIWJEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal GYOMDFYFYMP QGXTFPKEPPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal TCPJQICAXHS ESUJKKLRPSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal GFDJHUBNMNH JGBZPJYTNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal PYTCNKKVUWW IWWRBODWBGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal UKIURXUCANR AILIOIVHWXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal QQULRGKNYTP YHWPNSHKYUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal INOTHOVMCQI FZMJYVTSVDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal MTTYDTMWWBI QJTUCOCBUZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal BFMNSAIGVKR IQXOMCVBMYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal IDisposable PSWVPDAHTZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool VDQHRGHIABG;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ObjectLocalId PLFZISAFCHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public EMPROCEKPQD PZMQLIKUMOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xBAD820", Offset = "0xBAC620", VA = "0x180BAD820", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xC67370", Offset = "0xC66170", VA = "0x180C67370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject NKLBEGPZYIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xACDA90", Offset = "0xACC890", VA = "0x180ACDA90", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xACDA30", Offset = "0xACC830", VA = "0x180ACDA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform RGLPWOKCTFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xC82770", Offset = "0xC81570", VA = "0x180C82770", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xDD7120", Offset = "0xDD5F20", VA = "0x180DD7120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody YBYPUZZMAYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x8CF5130", Offset = "0x8CF3F30", VA = "0x188CF5130", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public VTYDTFHUYHL VEEIKBNANOI
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8CF4AA0", Offset = "0x8CF38A0", VA = "0x188CF4AA0", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8CF50D0", Offset = "0x8CF3ED0", VA = "0x188CF50D0", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int XIEGCBTMSRL
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8CF20B0", Offset = "0x8CF0EB0", VA = "0x188CF20B0", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public VTYDTFHUYHL JNMQCQBFHQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8CF1740", Offset = "0x8CF0540", VA = "0x188CF1740", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool SBOVGFLTFVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8CF0F70", Offset = "0x8CEFD70", VA = "0x188CF0F70", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool YRGBXFXWFAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8CF2120", Offset = "0x8CF0F20", VA = "0x188CF2120", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool HDTQQJZEDWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8CF5DB0", Offset = "0x8CF4BB0", VA = "0x188CF5DB0", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public HWSRBBGWKCF GGDAZCAMPVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8CF7120", Offset = "0x8CF5F20", VA = "0x188CF7120", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8CF6940", Offset = "0x8CF5740", VA = "0x188CF6940", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public CNBBDIFDYIQ MEAHVDUSSOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8CF6210", Offset = "0x8CF5010", VA = "0x188CF6210", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8CF5580", Offset = "0x8CF4380", VA = "0x188CF5580", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float XPVRHQGDZYD
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8CF5E50", Offset = "0x8CF4C50", VA = "0x188CF5E50", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8CF70C0", Offset = "0x8CF5EC0", VA = "0x188CF70C0", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 CRGQXOGSCDO
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8CF2170", Offset = "0x8CF0F70", VA = "0x188CF2170", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8CF5290", Offset = "0x8CF4090", VA = "0x188CF5290", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 UVEHQKAHZZS
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8CF1C90", Offset = "0x8CF0A90", VA = "0x188CF1C90", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8CF4B40", Offset = "0x8CF3940", VA = "0x188CF4B40", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 NRCHFMZYSHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8CF6BE0", Offset = "0x8CF59E0", VA = "0x188CF6BE0", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8CF36D0", Offset = "0x8CF24D0", VA = "0x188CF36D0", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 BMRHGYZZSSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8CF6F80", Offset = "0x8CF5D80", VA = "0x188CF6F80", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8CF34C0", Offset = "0x8CF22C0", VA = "0x188CF34C0", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool YAGUUQCSJXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8CF5180", Offset = "0x8CF3F80", VA = "0x188CF5180", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool JJANCIXGITC
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8CF3160", Offset = "0x8CF1F60", VA = "0x188CF3160", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool LSKKBTYRTAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8CF6B00", Offset = "0x8CF5900", VA = "0x188CF6B00", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool QHYARYUAFUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8CF6CC0", Offset = "0x8CF5AC0", VA = "0x188CF6CC0", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 YEJBGGYXMYF
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x8CF35A0", Offset = "0x8CF23A0", VA = "0x188CF35A0", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 JRFEAAFAGID
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x8CF2E20", Offset = "0x8CF1C20", VA = "0x188CF2E20", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 CBQJDUKQXWD
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x8CF2250", Offset = "0x8CF1050", VA = "0x188CF2250", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8CF4FC0", Offset = "0x8CF3DC0", VA = "0x188CF4FC0", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 VYXHYDMQMAI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8CF11C0", Offset = "0x8CEFFC0", VA = "0x188CF11C0", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float AEBEGJJZDAE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8CF28A0", Offset = "0x8CF16A0", VA = "0x188CF28A0", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float BIGGNULVKDV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8CF1790", Offset = "0x8CF0590", VA = "0x188CF1790", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8CF7280", Offset = "0x8CF6080", VA = "0x188CF7280", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 WGMDWNAFTHV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8CF2390", Offset = "0x8CF1190", VA = "0x188CF2390", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion FQMLRQKHXWR
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8CF27D0", Offset = "0x8CF15D0", VA = "0x188CF27D0", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float RVMRATVCUQK
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x8CF3290", Offset = "0x8CF2090", VA = "0x188CF3290", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8CF60A0", Offset = "0x8CF4EA0", VA = "0x188CF60A0", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float ZMGLCBYNOZW
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x8CF40C0", Offset = "0x8CF2EC0", VA = "0x188CF40C0", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x8CF2470", Offset = "0x8CF1270", VA = "0x188CF2470", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool SUPSUJBHAET
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x8CF4300", Offset = "0x8CF3100", VA = "0x188CF4300", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x8CF3670", Offset = "0x8CF2470", VA = "0x188CF3670", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate YRTCCDUEYSX
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x8CF0FD0", Offset = "0x8CEFDD0", VA = "0x188CF0FD0", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x8CF6160", Offset = "0x8CF4F60", VA = "0x188CF6160", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool KVYCCPHUQMV
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8CF4AF0", Offset = "0x8CF38F0", VA = "0x188CF4AF0", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform QYLDWWUBZWP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xC82770", Offset = "0xC81570", VA = "0x180C82770", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 IQVHXOWUHFB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x8CF46F0", Offset = "0x8CF34F0", VA = "0x188CF46F0", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x8CF6780", Offset = "0x8CF5580", VA = "0x188CF6780", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float IXNRTWAQTYN
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x8CF42F0", Offset = "0x8CF30F0", VA = "0x188CF42F0", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8CF4400", Offset = "0x8CF3200", VA = "0x188CF4400", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float QSHSHXOQBCW
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x8CF5570", Offset = "0x8CF4370", VA = "0x188CF5570", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x8CF25D0", Offset = "0x8CF13D0", VA = "0x188CF25D0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion JYUJNGQECAS
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8CF4570", Offset = "0x8CF3370", VA = "0x188CF4570", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8CF32E0", Offset = "0x8CF20E0", VA = "0x188CF32E0", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 QPBSZOXKJKI
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8CF3120", Offset = "0x8CF1F20", VA = "0x188CF3120", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8CF5730", Offset = "0x8CF4530", VA = "0x188CF5730", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion DOPWTFCDMUN
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8CF2F00", Offset = "0x8CF1D00", VA = "0x188CF2F00", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8CF50A0", Offset = "0x8CF3EA0", VA = "0x188CF50A0", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints VMSQYQISVUY
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8CF5E00", Offset = "0x8CF4C00", VA = "0x188CF5E00", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x8CF3D70", Offset = "0x8CF2B70", VA = "0x188CF3D70", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool EVDIHWFIEAX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8CF4DE0", Offset = "0x8CF3BE0", VA = "0x188CF4DE0", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8CF51D0", Offset = "0x8CF3FD0", VA = "0x188CF51D0", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode NNMNLFZXKBK
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8CF3420", Offset = "0x8CF2220", VA = "0x188CF3420", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8CF4800", Offset = "0x8CF3600", VA = "0x188CF4800", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool EJSKHUZFRQL
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8CF5430", Offset = "0x8CF4230", VA = "0x188CF5430", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool SVUHEAYSRNY
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8CF5F20", Offset = "0x8CF4D20", VA = "0x188CF5F20", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction UCCXETMUZEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8CF47A0", Offset = "0x8CF35A0", VA = "0x188CF47A0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8CF29A0", Offset = "0x8CF17A0", VA = "0x188CF29A0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction VQIUBNUHTJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8CF4060", Offset = "0x8CF2E60", VA = "0x188CF4060", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8CF37B0", Offset = "0x8CF25B0", VA = "0x188CF37B0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction TPVWGGLXKQM
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8CF33C0", Offset = "0x8CF21C0", VA = "0x188CF33C0", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8CF0DF0", Offset = "0x8CEFBF0", VA = "0x188CF0DF0", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction QRTOHDTVSWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8CF53D0", Offset = "0x8CF41D0", VA = "0x188CF53D0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8CF5D50", Offset = "0x8CF4B50", VA = "0x188CF5D50", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction OFWZSFENFEO
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x8CF38D0", Offset = "0x8CF26D0", VA = "0x188CF38D0", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x8CF1160", Offset = "0x8CEFF60", VA = "0x188CF1160", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction KDDQOCTRCGF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8CF6100", Offset = "0x8CF4F00", VA = "0x188CF6100", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8CF7060", Offset = "0x8CF5E60", VA = "0x188CF7060", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> HSGTGVJPAYY
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x8CF4D80", Offset = "0x8CF3B80", VA = "0x188CF4D80", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x8CF4E30", Offset = "0x8CF3C30", VA = "0x188CF4E30", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction OMOTRHQXKWH
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8CF5230", Offset = "0x8CF4030", VA = "0x188CF5230", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x8CF6260", Offset = "0x8CF5060", VA = "0x188CF6260", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction RPTCFYQJSNU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8CF49F0", Offset = "0x8CF37F0", VA = "0x188CF49F0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x8CF4350", Offset = "0x8CF3150", VA = "0x188CF4350", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8CF72E0", Offset = "0x8CF60E0", VA = "0x188CF72E0")]
		public PTTJIYWBTQY(GameObject a, RigidbodyEx b, WRFETHLVKCS c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1DC0", Offset = "0x8CF0BC0", VA = "0x188CF1DC0", Slot = "139")]
		protected virtual void CYAYYYIWMFG(WRFETHLVKCS a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8CF24D0", Offset = "0x8CF12D0", VA = "0x188CF24D0", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1020", Offset = "0x8CEFE20", VA = "0x188CF1020", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8CF4CF0", Offset = "0x8CF3AF0", VA = "0x188CF4CF0", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8CF4C40", Offset = "0x8CF3A40", VA = "0x188CF4C40", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8CF4C20", Offset = "0x8CF3A20", VA = "0x188CF4C20", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8CF3DD0", Offset = "0x8CF2BD0", VA = "0x188CF3DD0")]
		private void JRYEICWGHMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0C00", Offset = "0x8CEFA00", VA = "0x188CF0C00")]
		private void ABANHNBITGR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0EC0", Offset = "0x8CEFCC0", VA = "0x188CF0EC0")]
		private void AOQMSARUDVY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8CF5EA0", Offset = "0x8CF4CA0", VA = "0x188CF5EA0", Slot = "30")]
		public VTYDTFHUYHL VHZSODRSRNM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8CF5970", Offset = "0x8CF4770", VA = "0x188CF5970", Slot = "98")]
		public void SetParent(VTYDTFHUYHL value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8CF2330", Offset = "0x8CF1130", VA = "0x188CF2330", Slot = "99")]
		public void DHWAYMPLUEJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8CF12A0", Offset = "0x8CF00A0", VA = "0x188CF12A0", Slot = "100")]
		public void BFOCBZNYQLK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0C80", Offset = "0x8CEFA80", VA = "0x188CF0C80", Slot = "101")]
		public Vector3 ACLSZKWDQLV(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8CF5630", Offset = "0x8CF4430", VA = "0x188CF5630", Slot = "102")]
		public Vector3 SRDLYAWMJVD(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8CF4E90", Offset = "0x8CF3C90", VA = "0x188CF4E90", Slot = "103")]
		public void PQTAXTWXDCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1300", Offset = "0x8CF0100", VA = "0x188CF1300", Slot = "104")]
		public void BKCEIHPCLIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8CF5C90", Offset = "0x8CF4A90", VA = "0x188CF5C90", Slot = "105")]
		public void UGWNBEIXWGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8CF17E0", Offset = "0x8CF05E0", VA = "0x188CF17E0", Slot = "106")]
		public void BXCTJWQDWES(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8CF18D0", Offset = "0x8CF06D0", VA = "0x188CF18D0", Slot = "107")]
		public void BZSIXLIPMDR(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8CF4490", Offset = "0x8CF3290", VA = "0x188CF4490", Slot = "108")]
		public void LCQGZCKDSQK(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8CF3810", Offset = "0x8CF2610", VA = "0x188CF3810", Slot = "109")]
		public void JCNJCCOWVQM(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8CF5A30", Offset = "0x8CF4830", VA = "0x188CF5A30", Slot = "110")]
		public void TEIHQNGZLTH(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8CF6830", Offset = "0x8CF5630", VA = "0x188CF6830", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void XCBPBVAEFNY(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8CF2A00", Offset = "0x8CF1800", VA = "0x188CF2A00", Slot = "112")]
		public Vector3 FAQDRQAECLR(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8CF3020", Offset = "0x8CF1E20", VA = "0x188CF3020", Slot = "113")]
		public Vector3 GDAHZUDJDAV(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1D70", Offset = "0x8CF0B70", VA = "0x188CF1D70", Slot = "114")]
		public void CXLILHYXUAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0E50", Offset = "0x8CEFC50", VA = "0x188CF0E50", Slot = "115")]
		public void ALJAEKXEEIM(VTYDTFHUYHL a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8CF19C0", Offset = "0x8CF07C0", VA = "0x188CF19C0", Slot = "116")]
		public void CBQEVPSZFUB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8CF2F40", Offset = "0x8CF1D40", VA = "0x188CF2F40", Slot = "63")]
		public void FTHCFIMYMPJ((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8CF61C0", Offset = "0x8CF4FC0", VA = "0x188CF61C0", Slot = "117")]
		public void WHRFQCUWDQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0F20", Offset = "0x8CEFD20", VA = "0x188CF0F20", Slot = "118")]
		public void AQFPJARNBCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1B00", Offset = "0x8CF0900", VA = "0x188CF1B00", Slot = "119")]
		public void CPWJIVHVIOX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8CF55E0", Offset = "0x8CF43E0", VA = "0x188CF55E0", Slot = "120")]
		public bool SQGMZITGAVD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8CF59E0", Offset = "0x8CF47E0", VA = "0x188CF59E0", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8CF5CE0", Offset = "0x8CF4AE0", VA = "0x188CF5CE0", Slot = "121")]
		public void UHFPMSVQBBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8CF6D10", Offset = "0x8CF5B10", VA = "0x188CF6D10", Slot = "122")]
		public void YSMJXGLOCAU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8CF5370", Offset = "0x8CF4170", VA = "0x188CF5370", Slot = "123")]
		public void RCJPBOFOCBL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0D80", Offset = "0x8CEFB80", VA = "0x188CF0D80", Slot = "124")]
		public void AJJMVUGYEQV(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8CF5770", Offset = "0x8CF4570", VA = "0x188CF5770", Slot = "125")]
		public void SYYRKIQHJWX(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8CF48C0", Offset = "0x8CF36C0", VA = "0x188CF48C0", Slot = "126")]
		public void MSPJMURYXMP(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8CF3470", Offset = "0x8CF2270", VA = "0x188CF3470", Slot = "127")]
		public bool IMPBHLLLCDQ(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1B50", Offset = "0x8CF0950", VA = "0x188CF1B50", Slot = "128")]
		public void CRFQYKWCQPJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8CF6F20", Offset = "0x8CF5D20", VA = "0x188CF6F20", Slot = "129")]
		public void ZAMHBLDLOLK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8CF4860", Offset = "0x8CF3660", VA = "0x188CF4860", Slot = "130")]
		public void MJMPBLHEZFJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8CF62C0", Offset = "0x8CF50C0", VA = "0x188CF62C0", Slot = "131")]
		public void WKUOSNWIZLM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8CF4610", Offset = "0x8CF3410", VA = "0x188CF4610", Slot = "132")]
		public void LHGGDPWVKCC(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8CF7170", Offset = "0x8CF5F70", VA = "0x188CF7170", Slot = "133")]
		public void ZULCJNDOBBS(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1BB0", Offset = "0x8CF09B0", VA = "0x188CF1BB0", Slot = "134")]
		public void CSNTDCSDBVL(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8CF4EE0", Offset = "0x8CF3CE0", VA = "0x188CF4EE0", Slot = "135")]
		public void PQZKVHSOXVT(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8CF26D0", Offset = "0x8CF14D0", VA = "0x188CF26D0", Slot = "136")]
		public bool EODMHWROVGE(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8CF4CA0", Offset = "0x8CF3AA0", VA = "0x188CF4CA0", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8CF5C50", Offset = "0x8CF4A50", VA = "0x188CF5C50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1A20", Offset = "0x8CF0820", VA = "0x188CF1A20")]
		private void CFUJVTWNPAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8CF6670", Offset = "0x8CF5470", VA = "0x188CF6670")]
		private void WLOHQHHEDVA(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8CF4110", Offset = "0x8CF2F10", VA = "0x188CF4110")]
		private void KPSDHZNKUQV(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8CF28F0", Offset = "0x8CF16F0", VA = "0x188CF28F0")]
		private void EWUBFQPFOMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1610", Offset = "0x8CF0410", VA = "0x188CF1610")]
		private void BUDQXEQEBQL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8CF6D70", Offset = "0x8CF5B70", VA = "0x188CF6D70")]
		private void YTFMPWSEWBV(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8CF6A30", Offset = "0x8CF5830", VA = "0x188CF6A30")]
		private void XUDELYZYFKI(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8CF31C0", Offset = "0x8CF1FC0", VA = "0x188CF31C0")]
		private void GQBZCLGBVTS(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8CF14C0", Offset = "0x8CF02C0", VA = "0x188CF14C0")]
		private void BPDXPNFKDKN(EMPROCEKPQD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8CF3930", Offset = "0x8CF2730", VA = "0x188CF3930", Slot = "142")]
		protected virtual void JHPPQNMWTOW(EMPROCEKPQD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8CF2B00", Offset = "0x8CF1900", VA = "0x188CF2B00")]
		protected void FEWSQLMFVGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8CF6320", Offset = "0x8CF5120", VA = "0x188CF6320")]
		protected void WKWKORHTOPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8CF5B30", Offset = "0x8CF4930", VA = "0x188CF5B30")]
		private void TGNGSEAMQNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8CF1350", Offset = "0x8CF0150", VA = "0x188CF1350")]
		private void BKUFEQLXAYH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class LDBVZMSYCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE910", Offset = "0x8CED710", VA = "0x188CEE910")]
		public static VTYDTFHUYHL CDUFQSABVTR(this VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8CEEA20", Offset = "0x8CED820", VA = "0x188CEEA20")]
		public static bool WKCPZMEGBTQ(this VTYDTFHUYHL a, VTYDTFHUYHL b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE7F0", Offset = "0x8CED5F0", VA = "0x188CEE7F0")]
		public static bool BJWVQNRVFQY(this VTYDTFHUYHL a, VTYDTFHUYHL b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE9D0", Offset = "0x8CED7D0", VA = "0x188CEE9D0")]
		public static EMPROCEKPQD CWSGRHWSPUW(this VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE890", Offset = "0x8CED690", VA = "0x188CEE890")]
		public static PTTJIYWBTQY Base(this VTYDTFHUYHL impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class PRYSNMVHXXP : BPMJRKKZCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0850", Offset = "0x8CEF650", VA = "0x188CF0850", Slot = "19")]
		public VTYDTFHUYHL QNURALBXZLQ(RigidbodyEx a, RigidbodyExData b, WRFETHLVKCS c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "4")]
		public BEARRGDCUTT BUBCUIORNNB(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "5")]
		public WZVIOSNNMXP ASPNKEXGNKP(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "6")]
		public DIRKANQLDSO TQZIAFVBLBK(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "7")]
		public GYOMDFYFYMP ZXCKFZNYMQB(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "8")]
		public GFDJHUBNMNH HJYQCBHQATR(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "9")]
		public PYTCNKKVUWW UDNEHHVPHWY(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "10")]
		public UKIURXUCANR DBFAYWSURHX(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "11")]
		public QQULRGKNYTP FHOHHBRLUFF(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "12")]
		public BFMNSAIGVKR JXKLVPIXFBJ(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "13")]
		public TCPJQICAXHS SDFPRKXGAYK(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0")]
		public MTTYDTMWWBI NBULIVXTFAA(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0")]
		public BADRHFAUDTI BQMXWYOQEUA(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0")]
		public QSTVAHUHPJG SJNXUWCRFTA(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0")]
		public SCQWRCDVNYQ LDLCSPAYXVU(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0")]
		public INOTHOVMCQI MHHMZAJUYQW(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public PRYSNMVHXXP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "14")]
		private MTTYDTMWWBI FWOZSFBSWQU(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "15")]
		private BADRHFAUDTI UVIONUGPGXC(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "16")]
		private QSTVAHUHPJG CPTPDBLBSMC(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "17")]
		private SCQWRCDVNYQ JMNTCYSRRNE(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "18")]
		private INOTHOVMCQI AADMSWZJQYO(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(BPMJRKKZCFO), new string[] { })]
	public class EUFXPEGBWDK : BPMJRKKZCFO, EYUUBVPPSNU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly BPMJRKKZCFO OFZQWQONTSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly BPMJRKKZCFO WVWIJITCUQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private UGWTDQTLBCO ECUXRZDCAQN;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private BPMJRKKZCFO GSVTOQLBLYS
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x8CE7260", Offset = "0x8CE6060", VA = "0x188CE7260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x8CE72C0", Offset = "0x8CE60C0", VA = "0x188CE72C0", Slot = "20")]
		public void InitReferences(ODEDMYTJIPB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6E80", Offset = "0x8CE5C80", VA = "0x188CE6E80", Slot = "4")]
		public BEARRGDCUTT BUBCUIORNNB(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6D30", Offset = "0x8CE5B30", VA = "0x188CE6D30", Slot = "5")]
		public WZVIOSNNMXP ASPNKEXGNKP(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8CE7650", Offset = "0x8CE6450", VA = "0x188CE7650", Slot = "6")]
		public DIRKANQLDSO TQZIAFVBLBK(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8CE7790", Offset = "0x8CE6590", VA = "0x188CE7790", Slot = "7")]
		public GYOMDFYFYMP ZXCKFZNYMQB(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8CE71C0", Offset = "0x8CE5FC0", VA = "0x188CE71C0", Slot = "8")]
		public GFDJHUBNMNH HJYQCBHQATR(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8CE76F0", Offset = "0x8CE64F0", VA = "0x188CE76F0", Slot = "9")]
		public PYTCNKKVUWW UDNEHHVPHWY(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6FD0", Offset = "0x8CE5DD0", VA = "0x188CE6FD0", Slot = "10")]
		public UKIURXUCANR DBFAYWSURHX(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8CE7070", Offset = "0x8CE5E70", VA = "0x188CE7070", Slot = "11")]
		public QQULRGKNYTP FHOHHBRLUFF(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8CE73C0", Offset = "0x8CE61C0", VA = "0x188CE73C0", Slot = "12")]
		public BFMNSAIGVKR JXKLVPIXFBJ(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8CE75B0", Offset = "0x8CE63B0", VA = "0x188CE75B0", Slot = "13")]
		public TCPJQICAXHS SDFPRKXGAYK(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8CE7110", Offset = "0x8CE5F10", VA = "0x188CE7110")]
		public MTTYDTMWWBI NBULIVXTFAA(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6DD0", Offset = "0x8CE5BD0", VA = "0x188CE6DD0")]
		public BADRHFAUDTI BQMXWYOQEUA(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6F20", Offset = "0x8CE5D20", VA = "0x188CE6F20")]
		public QSTVAHUHPJG SJNXUWCRFTA(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8CE7310", Offset = "0x8CE6110", VA = "0x188CE7310")]
		public SCQWRCDVNYQ LDLCSPAYXVU(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6C80", Offset = "0x8CE5A80", VA = "0x188CE6C80")]
		public INOTHOVMCQI MHHMZAJUYQW(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8CE7460", Offset = "0x8CE6260", VA = "0x188CE7460", Slot = "19")]
		public VTYDTFHUYHL QNURALBXZLQ(RigidbodyEx a, RigidbodyExData b, WRFETHLVKCS c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8CE7830", Offset = "0x8CE6630", VA = "0x188CE7830")]
		public EUFXPEGBWDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8CE7110", Offset = "0x8CE5F10", VA = "0x188CE7110", Slot = "14")]
		private MTTYDTMWWBI FWOZSFBSWQU(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6DD0", Offset = "0x8CE5BD0", VA = "0x188CE6DD0", Slot = "15")]
		private BADRHFAUDTI UVIONUGPGXC(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6F20", Offset = "0x8CE5D20", VA = "0x188CE6F20", Slot = "16")]
		private QSTVAHUHPJG CPTPDBLBSMC(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8CE7310", Offset = "0x8CE6110", VA = "0x188CE7310", Slot = "17")]
		private SCQWRCDVNYQ JMNTCYSRRNE(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6C80", Offset = "0x8CE5A80", VA = "0x188CE6C80", Slot = "18")]
		private INOTHOVMCQI AADMSWZJQYO(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface YLMAPMBCGGE : BEARRGDCUTT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KLYJQYWESGP(VTYDTFHUYHL a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void YLWQMJCBONU(VTYDTFHUYHL a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void BNVULTXXZIF(VTYDTFHUYHL a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FCEWLMUHUZW(VTYDTFHUYHL a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface OMMOQJXGVCD : DIRKANQLDSO
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		FZVJRKFVIDV<VTYDTFHUYHL> HNCVOTFPRDE
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		VTYDTFHUYHL CNCGUVAIBIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface VHZAFZINRMT : SCQWRCDVNYQ
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) ASMRTXPLXZM(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface ZSROLGBNRLF : BADRHFAUDTI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		RRNetworkView DLBEWNPWDLN
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal sealed class ISQAOTLJIYS : BFMNSAIGVKR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly PTTJIYWBTQY UOKDJIGYPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CollisionDetectionMode KETYKPXTSEK;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private Rigidbody YBYPUZZMAYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x8CEB740", Offset = "0x8CEA540", VA = "0x188CEB740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode NNMNLFZXKBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x8CEC1F0", Offset = "0x8CEAFF0", VA = "0x188CEC1F0", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x8CEC300", Offset = "0x8CEB100", VA = "0x188CEC300", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8CEBED0", Offset = "0x8CEACD0", VA = "0x188CEBED0")]
		public ISQAOTLJIYS(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8CEBF70", Offset = "0x8CEAD70", VA = "0x188CEBF70", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8CEC490", Offset = "0x8CEB290", VA = "0x188CEC490", Slot = "9")]
		public void ZKLOUXNZQIZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8CEC1E0", Offset = "0x8CEAFE0", VA = "0x188CEC1E0", Slot = "7")]
		public void EPBPJKSWVWE(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8CEBF60", Offset = "0x8CEAD60", VA = "0x188CEBF60", Slot = "8")]
		public void AOFGHDUOEMD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8CEC080", Offset = "0x8CEAE80", VA = "0x188CEC080", Slot = "10")]
		public bool EODMHWROVGE(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8CEC370", Offset = "0x8CEB170", VA = "0x188CEC370")]
		private void SXWZVZJEIMM(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class FSIHAIBQZRZ : PYTCNKKVUWW, IDisposable, YYJRABEDHZK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly PTTJIYWBTQY UOKDJIGYPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TransformTrackRate PGDSREHSBMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private IMYMLYJLOCB CSFBKNTFPYD;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TransformTrackRate YRTCCDUEYSX
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x8CEA260", Offset = "0x8CE9060", VA = "0x188CEA260", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x8CEA7D0", Offset = "0x8CE95D0", VA = "0x188CEA7D0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform XFAUZXFTAGU
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x8CEA8A0", Offset = "0x8CE96A0", VA = "0x188CEA8A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> HSGTGVJPAYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x8CEA670", Offset = "0x8CE9470", VA = "0x188CEA670", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x8CEA720", Offset = "0x8CE9520", VA = "0x188CEA720", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA8C0", Offset = "0x8CE96C0", VA = "0x188CEA8C0")]
		public FSIHAIBQZRZ(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA3B0", Offset = "0x8CE91B0", VA = "0x188CEA3B0", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA620", Offset = "0x8CE9420", VA = "0x188CEA620", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1196A60", Offset = "0x1195860", VA = "0x181196A60", Slot = "11")]
		private void EKPJDCZAAYT(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "12")]
		private void QBEFTWUUJZB(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class PRYSNMVHXXP : BPMJRKKZCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8CEFF00", Offset = "0x8CEED00", VA = "0x188CEFF00", Slot = "4")]
		public BEARRGDCUTT BUBCUIORNNB(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8CEFC20", Offset = "0x8CEEA20", VA = "0x188CEFC20", Slot = "5")]
		public WZVIOSNNMXP ASPNKEXGNKP(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8CF09A0", Offset = "0x8CEF7A0", VA = "0x188CF09A0", Slot = "6")]
		public DIRKANQLDSO TQZIAFVBLBK(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0B90", Offset = "0x8CEF990", VA = "0x188CF0B90", Slot = "7")]
		public GYOMDFYFYMP ZXCKFZNYMQB(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0400", Offset = "0x8CEF200", VA = "0x188CF0400", Slot = "8")]
		public GFDJHUBNMNH HJYQCBHQATR(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0AC0", Offset = "0x8CEF8C0", VA = "0x188CF0AC0", Slot = "9")]
		public PYTCNKKVUWW UDNEHHVPHWY(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0100", Offset = "0x8CEEF00", VA = "0x188CF0100", Slot = "10")]
		public UKIURXUCANR DBFAYWSURHX(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0210", Offset = "0x8CEF010", VA = "0x188CF0210", Slot = "11")]
		public QQULRGKNYTP FHOHHBRLUFF(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0650", Offset = "0x8CEF450", VA = "0x188CF0650", Slot = "12")]
		public BFMNSAIGVKR JXKLVPIXFBJ(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8CF08E0", Offset = "0x8CEF6E0", VA = "0x188CF08E0", Slot = "13")]
		public TCPJQICAXHS SDFPRKXGAYK(VTYDTFHUYHL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8CF02D0", Offset = "0x8CEF0D0", VA = "0x188CF02D0")]
		public MTTYDTMWWBI NBULIVXTFAA(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8CEFD30", Offset = "0x8CEEB30", VA = "0x188CEFD30")]
		public BADRHFAUDTI BQMXWYOQEUA(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8CEFFE0", Offset = "0x8CEEDE0", VA = "0x188CEFFE0")]
		public QSTVAHUHPJG SJNXUWCRFTA(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8CF04C0", Offset = "0x8CEF2C0", VA = "0x188CF04C0")]
		public SCQWRCDVNYQ LDLCSPAYXVU(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8CEFB50", Offset = "0x8CEE950", VA = "0x188CEFB50")]
		public INOTHOVMCQI MHHMZAJUYQW(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0710", Offset = "0x8CEF510", VA = "0x188CF0710", Slot = "19")]
		public VTYDTFHUYHL QNURALBXZLQ(RigidbodyEx a, RigidbodyExData b, WRFETHLVKCS c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public PRYSNMVHXXP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8CF02D0", Offset = "0x8CEF0D0", VA = "0x188CF02D0", Slot = "14")]
		private MTTYDTMWWBI FWOZSFBSWQU(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8CF0B80", Offset = "0x8CEF980", VA = "0x188CF0B80", Slot = "15")]
		private BADRHFAUDTI UVIONUGPGXC(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8CEFFE0", Offset = "0x8CEEDE0", VA = "0x188CEFFE0", Slot = "16")]
		private QSTVAHUHPJG CPTPDBLBSMC(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8CF04C0", Offset = "0x8CEF2C0", VA = "0x188CF04C0", Slot = "17")]
		private SCQWRCDVNYQ JMNTCYSRRNE(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8CEFB50", Offset = "0x8CEE950", VA = "0x188CEFB50", Slot = "18")]
		private INOTHOVMCQI AADMSWZJQYO(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal sealed class GWLYYSUVTBC : QQULRGKNYTP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly PTTJIYWBTQY UOKDJIGYPQV;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody YBYPUZZMAYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x8CEB740", Offset = "0x8CEA540", VA = "0x188CEB740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool KVYCCPHUQMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x8CEB490", Offset = "0x8CEA290", VA = "0x188CEB490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool SBOVGFLTFVC
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x8CEB110", Offset = "0x8CE9F10", VA = "0x188CEB110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private VTYDTFHUYHL VEEIKBNANOI
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x8CEB430", Offset = "0x8CEA230", VA = "0x188CEB430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8CEBED0", Offset = "0x8CEACD0", VA = "0x188CEBED0")]
		public GWLYYSUVTBC(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB2D0", Offset = "0x8CEA0D0", VA = "0x188CEB2D0", Slot = "4")]
		public void LHGGDPWVKCC(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB790", Offset = "0x8CEA590", VA = "0x188CEB790")]
		private void XIOWCSIFYFD(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8CEBC50", Offset = "0x8CEAA50", VA = "0x188CEBC50", Slot = "5")]
		public void ZULCJNDOBBS(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB170", Offset = "0x8CE9F70", VA = "0x188CEB170", Slot = "6")]
		public void CSNTDCSDBVL(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB9F0", Offset = "0x8CEA7F0", VA = "0x188CEB9F0")]
		private void ZCUMBXRAGUM(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB4E0", Offset = "0x8CEA2E0", VA = "0x188CEB4E0", Slot = "7")]
		public void PQZKVHSOXVT(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class TREYWQDGXAV : TCPJQICAXHS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly PTTJIYWBTQY UOKDJIGYPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool ANMMGQTJMIL;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool SUPSUJBHAET
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xC70C00", Offset = "0xC6FA00", VA = "0x180C70C00", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x8CFF540", Offset = "0x8CFE340", VA = "0x188CFF540", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8CEBED0", Offset = "0x8CEACD0", VA = "0x188CEBED0")]
		public TREYWQDGXAV(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF6C0", Offset = "0x8CFE4C0", VA = "0x188CFF6C0", Slot = "6")]
		public void ZKLOUXNZQIZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF650", Offset = "0x8CFE450", VA = "0x188CFF650", Slot = "7")]
		public void QAHCTGFHQWW(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RbexHierarchy : YLMAPMBCGGE, BEARRGDCUTT, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly VTYDTFHUYHL UOKDJIGYPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<VTYDTFHUYHL> DVTRXUDHEKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private VTYDTFHUYHL WYBQGJRULHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private VTYDTFHUYHL YTPNFINVAEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform ZQHCSVJARET;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private Transform RGLPWOKCTFW
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x8CF7C10", Offset = "0x8CF6A10", VA = "0x188CF7C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public VTYDTFHUYHL VEEIKBNANOI
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xAC63F0", Offset = "0xAC51F0", VA = "0x180AC63F0", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x8CF8AA0", Offset = "0x8CF78A0", VA = "0x188CF8AA0", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public VTYDTFHUYHL JNMQCQBFHQM
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xAC6130", Offset = "0xAC4F30", VA = "0x180AC6130", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<VTYDTFHUYHL> MQSXNWJMIMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xAC6140", Offset = "0xAC4F40", VA = "0x180AC6140", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction UCCXETMUZEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x8CF8770", Offset = "0x8CF7570", VA = "0x188CF8770", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x8CF7DC0", Offset = "0x8CF6BC0", VA = "0x188CF7DC0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction VQIUBNUHTJM
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x8CF8420", Offset = "0x8CF7220", VA = "0x188CF8420", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x8CF8380", Offset = "0x8CF7180", VA = "0x188CF8380", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction TPVWGGLXKQM
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x8CF8240", Offset = "0x8CF7040", VA = "0x188CF8240", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x8CF7850", Offset = "0x8CF6650", VA = "0x188CF7850", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action JQWEXGTIOYZ
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9200", Offset = "0x8CF8000", VA = "0x188CF9200", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x8CF8A00", Offset = "0x8CF7800", VA = "0x188CF8A00", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action IUUXRSEZOFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x8CF88C0", Offset = "0x8CF76C0", VA = "0x188CF88C0", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x8CF8960", Offset = "0x8CF7760", VA = "0x188CF8960", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<VTYDTFHUYHL> NBBGPPNMMKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x8CF77A0", Offset = "0x8CF65A0", VA = "0x188CF77A0", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x8CF7D10", Offset = "0x8CF6B10", VA = "0x188CF7D10", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<VTYDTFHUYHL> MOPOLIEYWAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x8CF8810", Offset = "0x8CF7610", VA = "0x188CF8810", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9150", Offset = "0x8CF7F50", VA = "0x188CF9150", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action NIFXVHFFQGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x8CF81A0", Offset = "0x8CF6FA0", VA = "0x188CF81A0", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x8CF84C0", Offset = "0x8CF72C0", VA = "0x188CF84C0", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<VTYDTFHUYHL> SFZLLHEKAYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x8CF7B60", Offset = "0x8CF6960", VA = "0x188CF7B60", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x8CF92A0", Offset = "0x8CF80A0", VA = "0x188CF92A0", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9430", Offset = "0x8CF8230", VA = "0x188CF9430")]
		public RbexHierarchy(VTYDTFHUYHL rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8CF7C70", Offset = "0x8CF6A70", VA = "0x188CF7C70", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8CF8BE0", Offset = "0x8CF79E0", VA = "0x188CF8BE0", Slot = "30")]
		public void SetParent(VTYDTFHUYHL newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8CF78F0", Offset = "0x8CF66F0", VA = "0x188CF78F0", Slot = "6")]
		public void BNVULTXXZIF(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8CF7E60", Offset = "0x8CF6C60", VA = "0x188CF7E60", Slot = "7")]
		public void FCEWLMUHUZW(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8CF8560", Offset = "0x8CF7360", VA = "0x188CF8560", Slot = "4")]
		public void KLYJQYWESGP(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9390", Offset = "0x8CF8190", VA = "0x188CF9390", Slot = "5")]
		public void YLWQMJCBONU(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8CF82E0", Offset = "0x8CF70E0", VA = "0x188CF82E0")]
		private void HPPIOOTXAFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8CF9350", Offset = "0x8CF8150", VA = "0x188CF9350")]
		private void XWVKKFFRVIE(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8CF7660", Offset = "0x8CF6460", VA = "0x188CF7660")]
		private void ADFUSMSXOWR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8CF8AB0", Offset = "0x8CF78B0", VA = "0x188CF8AB0")]
		private void QTOUYWHUFWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8CF8650", Offset = "0x8CF7450", VA = "0x188CF8650")]
		private void KOMXRRKAXOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8CF80E0", Offset = "0x8CF6EE0", VA = "0x188CF80E0")]
		[CompilerGenerated]
		private object FPGPMVJZYBG()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class ABJPAMAWIGS
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3B50", Offset = "0x8CE2950", VA = "0x188CE3B50")]
		public static YLMAPMBCGGE DNWPIGKIECX(this VTYDTFHUYHL a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class KDXHTRJUJPV : OMMOQJXGVCD, DIRKANQLDSO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly PTTJIYWBTQY UOKDJIGYPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly FZVJRKFVIDV<VTYDTFHUYHL> NYJCXUYGSGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool TRGFDCJNMEH;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public FZVJRKFVIDV<VTYDTFHUYHL> HNCVOTFPRDE
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 YEJBGGYXMYF
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x8CEDD30", Offset = "0x8CECB30", VA = "0x188CEDD30", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 JRFEAAFAGID
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x8CEDA30", Offset = "0x8CEC830", VA = "0x188CEDA30", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 NRCHFMZYSHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE570", Offset = "0x8CED370", VA = "0x188CEE570")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public VTYDTFHUYHL CNCGUVAIBIQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE650", Offset = "0x8CED450", VA = "0x188CEE650", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE700", Offset = "0x8CED500", VA = "0x188CEE700")]
		public KDXHTRJUJPV(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE4A0", Offset = "0x8CED2A0", VA = "0x188CEE4A0", Slot = "8")]
		public void TZVNAKDBTSD(VTYDTFHUYHL a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE510", Offset = "0x8CED310", VA = "0x188CEE510", Slot = "9")]
		public void VTZAUOUPJBK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE100", Offset = "0x8CECF00", VA = "0x188CEE100")]
		private Vector3 PKUBLIVEUDT()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8CEDD60", Offset = "0x8CECB60", VA = "0x188CEDD60")]
		private void IUDWFZTQZVI(VTYDTFHUYHL a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class BIORWMFUACN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6BC0", Offset = "0x8CE59C0", VA = "0x188CE6BC0")]
		public static OMMOQJXGVCD IXUKLSGFHAI(this VTYDTFHUYHL a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class FOPTNESDWYT : VHZAFZINRMT, SCQWRCDVNYQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly PTTJIYWBTQY UOKDJIGYPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly OverridableVector3 IOSKLCVWAFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly OverridableVector3 GOQAESJELLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private float WOIAULMBFVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float LOUHJNCNIYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3 QMHSFJKXURZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Vector3? UVCAKMQZFVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Quaternion? CXGSQIQPZWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool NGWQWXZNVXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool LGSPJSEKVLP;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 CBQJDUKQXWD
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1CAFC70", Offset = "0x1CAEA70", VA = "0x181CAFC70", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x8CE93E0", Offset = "0x8CE81E0", VA = "0x188CE93E0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 VYXHYDMQMAI
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x8CE8820", Offset = "0x8CE7620", VA = "0x188CE8820", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float AEBEGJJZDAE
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xB193A0", Offset = "0xB181A0", VA = "0x180B193A0", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x8CE9C20", Offset = "0x8CE8A20", VA = "0x188CE9C20")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float BIGGNULVKDV
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xB193B0", Offset = "0xB181B0", VA = "0x180B193B0", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x8CE9F70", Offset = "0x8CE8D70", VA = "0x188CE9F70", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 WGMDWNAFTHV
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x8CE8AE0", Offset = "0x8CE78E0", VA = "0x188CE8AE0", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion FQMLRQKHXWR
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x8CE8D10", Offset = "0x8CE7B10", VA = "0x188CE8D10", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody YBYPUZZMAYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x8CE9BD0", Offset = "0x8CE89D0", VA = "0x188CE9BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction DERVLKPCOJE
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8CE8C70", Offset = "0x8CE7A70", VA = "0x188CE8C70", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8CE9950", Offset = "0x8CE8750", VA = "0x188CE9950", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA100", Offset = "0x8CE8F00", VA = "0x188CEA100")]
		public FOPTNESDWYT(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8CE9E50", Offset = "0x8CE8C50", VA = "0x188CE9E50", Slot = "17")]
		public void WHRFQCUWDQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8CE78D0", Offset = "0x8CE66D0", VA = "0x188CE78D0", Slot = "16")]
		public void AQFPJARNBCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA020", Offset = "0x8CE8E20", VA = "0x188CEA020", Slot = "19")]
		public void ZKLOUXNZQIZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8CE99F0", Offset = "0x8CE87F0", VA = "0x188CE99F0", Slot = "20")]
		public void QAHCTGFHQWW(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8CE8940", Offset = "0x8CE7740", VA = "0x188CE8940", Slot = "18")]
		public void CPWJIVHVIOX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8CE9490", Offset = "0x8CE8290", VA = "0x188CE9490", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8CE93E0", Offset = "0x8CE81E0", VA = "0x188CE93E0")]
		private void ONWZAJCTEVR(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8CE9D30", Offset = "0x8CE8B30", VA = "0x188CE9D30")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 UFXWPICIWRC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8CE9C20", Offset = "0x8CE8A20", VA = "0x188CE9C20")]
		private void ZILQSJOXONG(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8CE9F70", Offset = "0x8CE8D70", VA = "0x188CE9F70")]
		private void XQCLTDONKTF(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8CE9240", Offset = "0x8CE8040", VA = "0x188CE9240")]
		private Vector3 LAIIFHPQRTJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8CE8E90", Offset = "0x8CE7C90", VA = "0x188CE8E90", Slot = "15")]
		public void FTHCFIMYMPJ((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8CE90C0", Offset = "0x8CE7EC0", VA = "0x188CE90C0")]
		private Quaternion KUOGXKLNHZH()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8CE8750", Offset = "0x8CE7550", VA = "0x188CE8750")]
		public void ASMRTXPLXZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8CE79B0", Offset = "0x8CE67B0", VA = "0x188CE79B0", Slot = "4")]
		public (float, Vector3) ASMRTXPLXZM(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class RUJQLQIYIDX
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8CF75A0", Offset = "0x8CF63A0", VA = "0x188CF75A0")]
		public static VHZAFZINRMT XGGJYRCCSAG(this VTYDTFHUYHL a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class GKTEOHHXQMR : QSTVAHUHPJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly PTTJIYWBTQY UOKDJIGYPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly ZCWEIRQKNNA EDUMQGRIJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly RbexInterpolationMode NCHVLICIYIZ;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool VLCJROLEMRP
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1928EE0", Offset = "0x1927CE0", VA = "0x181928EE0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode YUSYSEDRHCT
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xAD8650", Offset = "0xAD7450", VA = "0x180AD8650", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB020", Offset = "0x8CE9E20", VA = "0x188CEB020")]
		public GKTEOHHXQMR(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8CEAA10", Offset = "0x8CE9810", VA = "0x188CEAA10", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8CEADC0", Offset = "0x8CE9BC0", VA = "0x188CEADC0")]
		private bool SDQARHCDPWZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8CEAD90", Offset = "0x8CE9B90", VA = "0x188CEAD90", Slot = "5")]
		public void LKFGGTLXTUT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8CEAE60", Offset = "0x8CE9C60", VA = "0x188CEAE60", Slot = "6")]
		public void TDWTQHMKDWG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8CEAAE0", Offset = "0x8CE98E0", VA = "0x188CEAAE0", Slot = "9")]
		public void FVBHBFVKPMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8CEAE90", Offset = "0x8CE9C90", VA = "0x188CEAE90")]
		private void UIWJZFWNXUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8CEAC10", Offset = "0x8CE9A10", VA = "0x188CEAC10")]
		private void INVXTNHEUUB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8CEAFA0", Offset = "0x8CE9DA0", VA = "0x188CEAFA0", Slot = "8")]
		public void VZAEEZULEQR(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8CEAFE0", Offset = "0x8CE9DE0", VA = "0x188CEAFE0", Slot = "7")]
		public void XWJIIEQZUKK(VTYDTFHUYHL a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class TFDHEUFBUGG : UKIURXUCANR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly PTTJIYWBTQY UOKDJIGYPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly ZCWEIRQKNNA KQDROUSYBKX;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool KVYCCPHUQMV
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x8CFF1A0", Offset = "0x8CFDFA0", VA = "0x188CFF1A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction OMOTRHQXKWH
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x8CFF280", Offset = "0x8CFE080", VA = "0x188CFF280", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x8CFF330", Offset = "0x8CFE130", VA = "0x188CFF330", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF460", Offset = "0x8CFE260", VA = "0x188CFF460")]
		public TFDHEUFBUGG(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF3D0", Offset = "0x8CFE1D0", VA = "0x188CFF3D0", Slot = "7")]
		public void YSMJXGLOCAU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF320", Offset = "0x8CFE120", VA = "0x188CFF320", Slot = "8")]
		public void RCJPBOFOCBL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF050", Offset = "0x8CFDE50", VA = "0x188CFF050", Slot = "9")]
		public void AJJMVUGYEQV(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF160", Offset = "0x8CFDF60", VA = "0x188CFF160", Slot = "12")]
		public void EAXBHRWJFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF3E0", Offset = "0x8CFE1E0", VA = "0x188CFF3E0", Slot = "10")]
		public void ZKLOUXNZQIZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF250", Offset = "0x8CFE050", VA = "0x188CFF250", Slot = "11")]
		public void QAHCTGFHQWW(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class OHIGAOVFDQX : ZSROLGBNRLF, BADRHFAUDTI, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private WeakReference<VTYDTFHUYHL> FMULDAUCISK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly PTTJIYWBTQY UOKDJIGYPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private RRNetworkView HVVFUIPRWCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool BNULULUIBZY;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public RRNetworkView DLBEWNPWDLN
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool YRGBXFXWFAI
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8CEECF0", Offset = "0x8CEDAF0", VA = "0x188CEECF0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool HDTQQJZEDWO
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xB20690", Offset = "0xB1F490", VA = "0x180B20690", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction QRTOHDTVSWH
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8CEF300", Offset = "0x8CEE100", VA = "0x188CEF300", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x8CEF510", Offset = "0x8CEE310", VA = "0x188CEF510", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8CEF9B0", Offset = "0x8CEE7B0", VA = "0x188CEF9B0")]
		public OHIGAOVFDQX(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8CEEBC0", Offset = "0x8CED9C0", VA = "0x188CEEBC0", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8CEED00", Offset = "0x8CEDB00", VA = "0x188CEED00", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8CEF820", Offset = "0x8CEE620", VA = "0x188CEF820", Slot = "10")]
		public void XUDELYZYFKI(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8CEF180", Offset = "0x8CEDF80", VA = "0x188CEF180", Slot = "11")]
		public void GQBZCLGBVTS(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8CEF3A0", Offset = "0x8CEE1A0", VA = "0x188CEF3A0")]
		private void SZKPJHYBDMA(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8CEF030", Offset = "0x8CEDE30", VA = "0x188CEF030")]
		private void EXUKUDLINCY(EMPROCEKPQD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8CEF5B0", Offset = "0x8CEE3B0", VA = "0x188CEF5B0")]
		private void VIDSPLORLLT(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class FYVVICRDCZD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA950", Offset = "0x8CE9750", VA = "0x188CEA950")]
		public static ZSROLGBNRLF Lifecycle(this VTYDTFHUYHL impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class AARJPZFNFXJ : INOTHOVMCQI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly PTTJIYWBTQY UOKDJIGYPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private RigidbodyConstraints VNDFNBZFWLW;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool EVDIHWFIEAX
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xC6FE00", Offset = "0xC6EC00", VA = "0x180C6FE00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xCA8D50", Offset = "0xCA7B50", VA = "0x180CA8D50", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool WQOUONKBEAW
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xCA8BA0", Offset = "0xCA79A0", VA = "0x180CA8BA0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xCA8DC0", Offset = "0xCA7BC0", VA = "0x180CA8DC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints VMSQYQISVUY
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xAD4260", Offset = "0xAD3060", VA = "0x180AD4260", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x8CE3910", Offset = "0x8CE2710", VA = "0x188CE3910", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3AA0", Offset = "0x8CE28A0", VA = "0x188CE3AA0")]
		public AARJPZFNFXJ(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3A70", Offset = "0x8CE2870", VA = "0x188CE3A70", Slot = "9")]
		public void ZKLOUXNZQIZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3A40", Offset = "0x8CE2840", VA = "0x188CE3A40", Slot = "10")]
		public void QAHCTGFHQWW(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class TEPPMRXWSZK : GYOMDFYFYMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly VTYDTFHUYHL UOKDJIGYPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private float FGBRENLRYHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private float OWPVFYRJWMY;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public float RVMRATVCUQK
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xB1F7E0", Offset = "0xB1E5E0", VA = "0x180B1F7E0", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8CFEEF0", Offset = "0x8CFDCF0", VA = "0x188CFEEF0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float ZMGLCBYNOZW
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xB1F7D0", Offset = "0xB1E5D0", VA = "0x180B1F7D0", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8CFED80", Offset = "0x8CFDB80", VA = "0x188CFED80", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8CFF010", Offset = "0x8CFDE10", VA = "0x188CFF010")]
		public TEPPMRXWSZK(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8CFEFC0", Offset = "0x8CFDDC0", VA = "0x188CFEFC0", Slot = "8")]
		public void ZKLOUXNZQIZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8CFEE50", Offset = "0x8CFDC50", VA = "0x188CFEE50", Slot = "9")]
		public void QAHCTGFHQWW(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class JQOAHQYYYSA : GFDJHUBNMNH
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly Log EIRKIAGPVQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly PTTJIYWBTQY UOKDJIGYPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool OYFEQJCBPIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool IXOZKVBOEUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int HCKZWRRXGOG;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private Rigidbody YBYPUZZMAYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x8CE9BD0", Offset = "0x8CE89D0", VA = "0x188CE9BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool EJSKHUZFRQL
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8CECA20", Offset = "0x8CEB820", VA = "0x188CECA20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private VTYDTFHUYHL VEEIKBNANOI
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x8CEC9C0", Offset = "0x8CEB7C0", VA = "0x188CEC9C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool SBOVGFLTFVC
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x8CEC600", Offset = "0x8CEB400", VA = "0x188CEC600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction KDDQOCTRCGF
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x8CECD70", Offset = "0x8CEBB70", VA = "0x188CECD70", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8CECE10", Offset = "0x8CEBC10", VA = "0x188CECE10", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8CED100", Offset = "0x8CEBF00", VA = "0x188CED100")]
		public JQOAHQYYYSA(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8CEC660", Offset = "0x8CEB460", VA = "0x188CEC660", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8CEC6F0", Offset = "0x8CEB4F0", VA = "0x188CEC6F0", Slot = "8")]
		public void DALHTZSQTJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8CECAB0", Offset = "0x8CEB8B0", VA = "0x188CECAB0", Slot = "7")]
		public bool SQGMZITGAVD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8CECC00", Offset = "0x8CEBA00", VA = "0x188CECC00", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8CECCD0", Offset = "0x8CEBAD0", VA = "0x188CECCD0", Slot = "13")]
		public void UHFPMSVQBBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8CEC890", Offset = "0x8CEB690", VA = "0x188CEC890", Slot = "12")]
		public void JRYEICWGHMI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8CECA40", Offset = "0x8CEB840", VA = "0x188CECA40", Slot = "10")]
		public bool SPUQLJYDFCL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8CEC510", Offset = "0x8CEB310", VA = "0x188CEC510", Slot = "11")]
		public bool AOQMSARUDVY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8CECEB0", Offset = "0x8CEBCB0", VA = "0x188CECEB0")]
		private bool ZQMLYGYVFCM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8CEC700", Offset = "0x8CEB500", VA = "0x188CEC700")]
		private void HNUTPGYSZAW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class JTAITJATRIZ : MTTYDTMWWBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly PTTJIYWBTQY UOKDJIGYPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly ZCWEIRQKNNA CAVLBDMEADT;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Rigidbody YBYPUZZMAYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C30", Offset = "0xAC7A30", VA = "0x180AC8C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool SBOVGFLTFVC
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x8CEB110", Offset = "0x8CE9F10", VA = "0x188CEB110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool WQNBKROSDCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1928EE0", Offset = "0x1927CE0", VA = "0x181928EE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8CED930", Offset = "0x8CEC730", VA = "0x188CED930")]
		public JTAITJATRIZ(VTYDTFHUYHL a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8CED190", Offset = "0x8CEBF90", VA = "0x188CED190", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8CED6E0", Offset = "0x8CEC4E0", VA = "0x188CED6E0", Slot = "7")]
		public void MJMPBLHEZFJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8CED900", Offset = "0x8CEC700", VA = "0x188CED900", Slot = "8")]
		public void WKUOSNWIZLM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8CED3B0", Offset = "0x8CEC1B0", VA = "0x188CED3B0", Slot = "9")]
		public void INSVOXGPNDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8CED710", Offset = "0x8CEC510", VA = "0x188CED710", Slot = "10")]
		public void UPSMYGIYZKU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8CED230", Offset = "0x8CEC030", VA = "0x188CED230", Slot = "11")]
		public void EMOGWSRVQCP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class ARRYGTYXJQK : WZVIOSNNMXP, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly PTTJIYWBTQY UOKDJIGYPQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly ZCWEIRQKNNA XXOSAPDNCOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private float OVGXVHSSQIP;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public HWSRBBGWKCF GGDAZCAMPVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C40", Offset = "0xAC7A40", VA = "0x180AC8C40", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public CNBBDIFDYIQ MEAHVDUSSOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xAD0080", Offset = "0xACEE80", VA = "0x180AD0080", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 NRCHFMZYSHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x8CE6630", Offset = "0x8CE5430", VA = "0x188CE6630", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x8CE4AF0", Offset = "0x8CE38F0", VA = "0x188CE4AF0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 CRGQXOGSCDO
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x8CE4660", Offset = "0x8CE3460", VA = "0x188CE4660", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8CE5A40", Offset = "0x8CE4840", VA = "0x188CE5A40", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 BMRHGYZZSSF
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x8CE67F0", Offset = "0x8CE55F0", VA = "0x188CE67F0", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x8CE4A30", Offset = "0x8CE3830", VA = "0x188CE4A30", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 UVEHQKAHZZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x8CE4340", Offset = "0x8CE3140", VA = "0x188CE4340", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8CE5A10", Offset = "0x8CE4810", VA = "0x188CE5A10", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float XPVRHQGDZYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xB1F710", Offset = "0xB1E510", VA = "0x180B1F710", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8CE4920", Offset = "0x8CE3720", VA = "0x188CE4920", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool QHYARYUAFUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x23AAE00", Offset = "0x23A9C00", VA = "0x1823AAE00", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private QQULRGKNYTP OFUASLEATKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x8230E40", Offset = "0x822FC40", VA = "0x188230E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool EJSKHUZFRQL
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x8CE5A70", Offset = "0x8CE4870", VA = "0x188CE5A70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6AE0", Offset = "0x8CE58E0", VA = "0x188CE6AE0")]
		public ARRYGTYXJQK(VTYDTFHUYHL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3DF0", Offset = "0x8CE2BF0", VA = "0x188CE3DF0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8CE47E0", Offset = "0x8CE35E0", VA = "0x188CE47E0", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8CE69B0", Offset = "0x8CE57B0", VA = "0x188CE69B0", Slot = "28")]
		public void ZKLOUXNZQIZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x16D56A0", Offset = "0x16D44A0", VA = "0x1816D56A0", Slot = "20")]
		public void LKSDIUWPGAX(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x16D56C0", Offset = "0x16D44C0", VA = "0x1816D56C0", Slot = "30")]
		public void OBJCMJIVOXU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3C10", Offset = "0x8CE2A10", VA = "0x188CE3C10", Slot = "35")]
		public Vector3 ACLSZKWDQLV(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5C20", Offset = "0x8CE4A20", VA = "0x188CE5C20", Slot = "34")]
		public Vector3 SRDLYAWMJVD(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3DF0", Offset = "0x8CE2BF0", VA = "0x188CE3DF0", Slot = "27")]
		public void PQTAXTWXDCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3EA0", Offset = "0x8CE2CA0", VA = "0x188CE3EA0", Slot = "25")]
		public void BKCEIHPCLIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6060", Offset = "0x8CE4E60", VA = "0x188CE6060", Slot = "24")]
		public void UGWNBEIXWGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8CE40A0", Offset = "0x8CE2EA0", VA = "0x188CE40A0", Slot = "33")]
		public void BXCTJWQDWES(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8CE42E0", Offset = "0x8CE30E0", VA = "0x188CE42E0", Slot = "32")]
		public void BZSIXLIPMDR(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5870", Offset = "0x8CE4670", VA = "0x188CE5870", Slot = "31")]
		public void LCQGZCKDSQK(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8CE4BB0", Offset = "0x8CE39B0", VA = "0x188CE4BB0", Slot = "22")]
		public void JCNJCCOWVQM(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5DE0", Offset = "0x8CE4BE0", VA = "0x188CE5DE0", Slot = "21")]
		public void TEIHQNGZLTH(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8CE60C0", Offset = "0x8CE4EC0", VA = "0x188CE60C0", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void XCBPBVAEFNY(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1833FF0", Offset = "0x1832DF0", VA = "0x181833FF0")]
		private static void SLHTRZYYJQW(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8CE4840", Offset = "0x8CE3640", VA = "0x188CE4840", Slot = "29")]
		public Vector3 FAQDRQAECLR(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8CE44D0", Offset = "0x8CE32D0", VA = "0x188CE44D0", Slot = "26")]
		public void CXLILHYXUAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8CE4920", Offset = "0x8CE3720", VA = "0x188CE4920")]
		private void HKJRRYPACYH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3F00", Offset = "0x8CE2D00", VA = "0x188CE3F00")]
		private void BVNJPIBLPOT(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8CE64B0", Offset = "0x8CE52B0", VA = "0x188CE64B0")]
		private Vector3 XLITZZAVIGU()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5580", Offset = "0x8CE4380", VA = "0x188CE5580")]
		private void KMXLJYAXZKU(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5A90", Offset = "0x8CE4890", VA = "0x188CE5A90")]
		private Vector3 SGMJRYNGROE()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5100", Offset = "0x8CE3F00", VA = "0x188CE5100")]
		private void JHGFMXCQCFO(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private void ZBJOGNKDGQT(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private void UWYTRZLHKWV()
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
