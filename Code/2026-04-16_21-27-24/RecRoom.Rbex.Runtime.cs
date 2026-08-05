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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA017640", Offset = "0xA016440", VA = "0x18A017640", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		private int[] SSKDGXUXNDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset DGANWLFFZHC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x99F59E0", Offset = "0x99F47E0", VA = "0x1899F59E0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA0224D0", Offset = "0xA0212D0", VA = "0x18A0224D0")]
		private void TZCLDGRTUGE(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA022470", Offset = "0xA021270", VA = "0x18A022470", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA0227B0", Offset = "0xA0215B0", VA = "0x18A0227B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, QPQCJTUZEKK, YVVTQPZHVXT, BLJXLPZXGFN
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log QVSDGTVEWHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool YVROBGPGTOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private XDKPDVFGOFK GFAUAXWHGGP;

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
		private Transform GZAWWSQTFEF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal XDKPDVFGOFK QDBVPLSAZIH
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA01BD00", Offset = "0xA01AB00", VA = "0x18A01BD00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private XDKPDVFGOFK ERKSKOPJOUH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int LMPCHQDGLHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA01D6D0", Offset = "0xA01C4D0", VA = "0x18A01D6D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx IZOQGLOFHAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA01DA30", Offset = "0xA01C830", VA = "0x18A01DA30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx YXDZNKGUVHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA01D970", Offset = "0xA01C770", VA = "0x18A01D970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx WKYFTFFHETD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA01E630", Offset = "0xA01D430", VA = "0x18A01E630")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA01FB30", Offset = "0xA01E930", VA = "0x18A01FB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x939D030", Offset = "0x939BE30", VA = "0x18939D030", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x939D180", Offset = "0x939BF80", VA = "0x18939D180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform TKCNCOJLDNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x25DB4F0", Offset = "0x25DA2F0", VA = "0x1825DB4F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform WUGKRHXYUUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x25DB4F0", Offset = "0x25DA2F0", VA = "0x1825DB4F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform JTQPGKDHPIE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x25DB4F0", Offset = "0x25DA2F0", VA = "0x1825DB4F0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate GWEQOLAMXSO
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA01D730", Offset = "0xA01C530", VA = "0x18A01D730")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA01F2E0", Offset = "0xA01E0E0", VA = "0x18A01F2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool IANMPCTXZDV
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xA01DD40", Offset = "0xA01CB40", VA = "0x18A01DD40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool KHYHTOJFTMT
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xA01D850", Offset = "0xA01C650", VA = "0x18A01D850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public HDDJQUXOAWW KLJVFWSFIJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xA01DC80", Offset = "0xA01CA80", VA = "0x18A01DC80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA01F4A0", Offset = "0xA01E2A0", VA = "0x18A01F4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public JNTLKZADWBL DBXPLMJHYAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xA01DC20", Offset = "0xA01CA20", VA = "0x18A01DC20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA01F430", Offset = "0xA01E230", VA = "0x18A01F430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool ETNHVNIQBZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA01DB70", Offset = "0xA01C970", VA = "0x18A01DB70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody TSUTETVWVXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA01DBD0", Offset = "0xA01C9D0", VA = "0x18A01DBD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool BDYESYTIKSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA01D8B0", Offset = "0xA01C6B0", VA = "0x18A01D8B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA01F350", Offset = "0xA01E150", VA = "0x18A01F350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool XRLWASFFWFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1A10870", Offset = "0x1A0F670", VA = "0x181A10870", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float SIVHJSWSRMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA01E5D0", Offset = "0xA01D3D0", VA = "0x18A01E5D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float TQWBWKTQQCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA01E570", Offset = "0xA01D370", VA = "0x18A01E570")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA01FAC0", Offset = "0xA01E8C0", VA = "0x18A01FAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float OYJMGFVZVRR
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA01DFA0", Offset = "0xA01CDA0", VA = "0x18A01DFA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA01F740", Offset = "0xA01E540", VA = "0x18A01F740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float SOFNTCVHTMH
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA01DDA0", Offset = "0xA01CBA0", VA = "0x18A01DDA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA01F510", Offset = "0xA01E310", VA = "0x18A01F510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool QCABZPGCPAC
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA01EB80", Offset = "0xA01D980", VA = "0x18A01EB80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA020070", Offset = "0xA01EE70", VA = "0x18A020070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 PIUUOJATRJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xA01E350", Offset = "0xA01D150", VA = "0x18A01E350")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA01F890", Offset = "0xA01E690", VA = "0x18A01F890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 WZQHFSGVAOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA01ECC0", Offset = "0xA01DAC0", VA = "0x18A01ECC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode CIXPXIUSJND
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA01DEE0", Offset = "0xA01CCE0", VA = "0x18A01DEE0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA01F660", Offset = "0xA01E460", VA = "0x18A01F660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float FOXHCFVUYTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA01D910", Offset = "0xA01C710", VA = "0x18A01D910")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA01F3C0", Offset = "0xA01E1C0", VA = "0x18A01F3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints SPNQCTQRWGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA01DF40", Offset = "0xA01CD40", VA = "0x18A01DF40")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA01F6D0", Offset = "0xA01E4D0", VA = "0x18A01F6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 HPLQHPQDJJT
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xA01E6F0", Offset = "0xA01D4F0", VA = "0x18A01E6F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 EDGKIPSHQCD
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA01E6F0", Offset = "0xA01D4F0", VA = "0x18A01E6F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA01FE50", Offset = "0xA01EC50", VA = "0x18A01FE50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float SNGWOZXULZY
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA01E430", Offset = "0xA01D230", VA = "0x18A01E430")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA01F970", Offset = "0xA01E770", VA = "0x18A01F970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float VLFORICXUZF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA01EB20", Offset = "0xA01D920", VA = "0x18A01EB20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA020000", Offset = "0xA01EE00", VA = "0x18A020000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion QODMEPZHBPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA01E7D0", Offset = "0xA01D5D0", VA = "0x18A01E7D0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA01FBD0", Offset = "0xA01E9D0", VA = "0x18A01FBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion WHSQAFDDPNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA01EA50", Offset = "0xA01D850", VA = "0x18A01EA50")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA01FF30", Offset = "0xA01ED30", VA = "0x18A01FF30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 YHEUZOXZCMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA01E8A0", Offset = "0xA01D6A0", VA = "0x18A01E8A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA01FCA0", Offset = "0xA01EAA0", VA = "0x18A01FCA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion ATXEOCVIBDX
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA01E980", Offset = "0xA01D780", VA = "0x18A01E980")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA01FD80", Offset = "0xA01EB80", VA = "0x18A01FD80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 HLJQEHWQTDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA01EBE0", Offset = "0xA01D9E0", VA = "0x18A01EBE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA0200E0", Offset = "0xA01EEE0", VA = "0x18A0200E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 ZFOUAGMARLF
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA01E490", Offset = "0xA01D290", VA = "0x18A01E490")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA01F9E0", Offset = "0xA01E7E0", VA = "0x18A01F9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 NLAJIDIDBVE
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA01DE00", Offset = "0xA01CC00", VA = "0x18A01DE00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA01F580", Offset = "0xA01E380", VA = "0x18A01F580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 MNFBITAOKVP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA01E270", Offset = "0xA01D070", VA = "0x18A01E270")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA01F7B0", Offset = "0xA01E5B0", VA = "0x18A01F7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 NTTBJMCTPQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA01E130", Offset = "0xA01CF30", VA = "0x18A01E130")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion JGZHECCIWXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA01E060", Offset = "0xA01CE60", VA = "0x18A01E060")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 PMUZQDDIJYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA01EE80", Offset = "0xA01DC80", VA = "0x18A01EE80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 UBBWKGSNQTM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA01EDA0", Offset = "0xA01DBA0", VA = "0x18A01EDA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool LVVJDFPCLGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA01E210", Offset = "0xA01D010", VA = "0x18A01E210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool QZMYDJZELNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xA01DCE0", Offset = "0xA01CAE0", VA = "0x18A01DCE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool LSUOEYYLJXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA01D7F0", Offset = "0xA01C5F0", VA = "0x18A01D7F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool VUHNUVYJKAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA01D790", Offset = "0xA01C590", VA = "0x18A01D790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool OHULPTRHOII
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA01D670", Offset = "0xA01C470", VA = "0x18A01D670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool SWCVYKRBGRV
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA01E000", Offset = "0xA01CE00", VA = "0x18A01E000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool YJTUVSGDJFT
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xE00520", Offset = "0xDFF320", VA = "0x180E00520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction QQSSQJBWUCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA01D590", Offset = "0xA01C390", VA = "0x18A01D590")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA01F200", Offset = "0xA01E000", VA = "0x18A01F200")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction ICUBVGDMBRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xA01D300", Offset = "0xA01C100", VA = "0x18A01D300")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA01EF60", Offset = "0xA01DD60", VA = "0x18A01EF60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction RDLNGAGGJAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA01D360", Offset = "0xA01C160", VA = "0x18A01D360")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA01EFD0", Offset = "0xA01DDD0", VA = "0x18A01EFD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction DGWSQUNKABH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA01D4B0", Offset = "0xA01C2B0", VA = "0x18A01D4B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xA01F120", Offset = "0xA01DF20", VA = "0x18A01F120")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> SMFLNJZLJAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xA01D440", Offset = "0xA01C240", VA = "0x18A01D440")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA01F0B0", Offset = "0xA01DEB0", VA = "0x18A01F0B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction GDBAJZJISNI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA01D520", Offset = "0xA01C320", VA = "0x18A01D520")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA01F190", Offset = "0xA01DF90", VA = "0x18A01F190")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction PAEERFHNIXS
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA01D600", Offset = "0xA01C400", VA = "0x18A01D600")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA01F270", Offset = "0xA01E070", VA = "0x18A01F270")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction POXMWURXFZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA01D3D0", Offset = "0xA01C1D0", VA = "0x18A01D3D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA01F040", Offset = "0xA01DE40", VA = "0x18A01F040")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCE7530", Offset = "0xCE6330", VA = "0x180CE7530", Slot = "8")]
		private void MWZBNWUXDTH(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA01BC70", Offset = "0xA01AA70", VA = "0x18A01BC70", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA01C120", Offset = "0xA01AF20", VA = "0x18A01C120")]
		internal void MFGHLKIKPUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA01D020", Offset = "0xA01BE20", VA = "0x18A01D020")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA01B9C0", Offset = "0xA01A7C0", VA = "0x18A01B9C0")]
		public QPQCJTUZEKK GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA01CC80", Offset = "0xA01BA80", VA = "0x18A01CC80")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA01B610", Offset = "0xA01A410", VA = "0x18A01B610")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA01CF10", Offset = "0xA01BD10", VA = "0x18A01CF10")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA01BD00", Offset = "0xA01AB00", VA = "0x18A01BD00")]
		private XDKPDVFGOFK HVPKJSVXJBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA01C390", Offset = "0xA01B190", VA = "0x18A01C390")]
		private void RKCBVVMJUOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA01C2D0", Offset = "0xA01B0D0", VA = "0x18A01C2D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA01C210", Offset = "0xA01B010", VA = "0x18A01C210")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA01C120", Offset = "0xA01AF20", VA = "0x18A01C120")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA01C270", Offset = "0xA01B070", VA = "0x18A01C270")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA01C330", Offset = "0xA01B130", VA = "0x18A01C330")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA01AC00", Offset = "0xA019A00", VA = "0x18A01AC00")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA01C510", Offset = "0xA01B310", VA = "0x18A01C510")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA01B960", Offset = "0xA01A760", VA = "0x18A01B960")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA01C1B0", Offset = "0xA01AFB0", VA = "0x18A01C1B0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA01CDE0", Offset = "0xA01BBE0", VA = "0x18A01CDE0")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA01C820", Offset = "0xA01B620", VA = "0x18A01C820")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA01BDB0", Offset = "0xA01ABB0", VA = "0x18A01BDB0")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA01BEB0", Offset = "0xA01ACB0", VA = "0x18A01BEB0")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA01AE70", Offset = "0xA019C70", VA = "0x18A01AE70")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA01C580", Offset = "0xA01B380", VA = "0x18A01C580")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA01AEE0", Offset = "0xA019CE0", VA = "0x18A01AEE0")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA01C5F0", Offset = "0xA01B3F0", VA = "0x18A01C5F0")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA01CD60", Offset = "0xA01BB60", VA = "0x18A01CD60")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA01CB80", Offset = "0xA01B980", VA = "0x18A01CB80")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA01CA80", Offset = "0xA01B880", VA = "0x18A01CA80")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA01BB60", Offset = "0xA01A960", VA = "0x18A01BB60")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA01BA50", Offset = "0xA01A850", VA = "0x18A01BA50")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA01AD80", Offset = "0xA019B80", VA = "0x18A01AD80")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA01AC70", Offset = "0xA019A70", VA = "0x18A01AC70")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA01B0B0", Offset = "0xA019EB0", VA = "0x18A01B0B0")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA01AF50", Offset = "0xA019D50", VA = "0x18A01AF50")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA01D0F0", Offset = "0xA01BEF0", VA = "0x18A01D0F0")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA01C010", Offset = "0xA01AE10", VA = "0x18A01C010")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA01B900", Offset = "0xA01A700", VA = "0x18A01B900")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA01B8A0", Offset = "0xA01A6A0", VA = "0x18A01B8A0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA01B840", Offset = "0xA01A640", VA = "0x18A01B840")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA01B7E0", Offset = "0xA01A5E0", VA = "0x18A01B7E0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA01C980", Offset = "0xA01B780", VA = "0x18A01C980")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA01C880", Offset = "0xA01B680", VA = "0x18A01C880")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA01C740", Offset = "0xA01B540", VA = "0x18A01C740")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA01CF20", Offset = "0xA01BD20", VA = "0x18A01CF20")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA01BFB0", Offset = "0xA01ADB0", VA = "0x18A01BFB0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA01CEB0", Offset = "0xA01BCB0", VA = "0x18A01CEB0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA01D090", Offset = "0xA01BE90", VA = "0x18A01D090")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA01B040", Offset = "0xA019E40", VA = "0x18A01B040")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA01C660", Offset = "0xA01B460", VA = "0x18A01C660")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA01B440", Offset = "0xA01A240", VA = "0x18A01B440")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA01B340", Offset = "0xA01A140", VA = "0x18A01B340")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA01B500", Offset = "0xA01A300", VA = "0x18A01B500")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA01B270", Offset = "0xA01A070", VA = "0x18A01B270")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA01B1A0", Offset = "0xA019FA0", VA = "0x18A01B1A0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA01C6D0", Offset = "0xA01B4D0", VA = "0x18A01C6D0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8C2C9B0", Offset = "0x8C2B7B0", VA = "0x188C2C9B0", Slot = "13")]
		private void CVZNLIRWQMC(LRDITXVMCHW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA01D290", Offset = "0xA01C090", VA = "0x18A01D290")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x14FD2E0", Offset = "0x14FC0E0", VA = "0x1814FD2E0", Slot = "4")]
		private GameObject KMPIXWTIJHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xD128A0", Offset = "0xD116A0", VA = "0x180D128A0", Slot = "10")]
		private bool NWWERDTVSXE()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class SLJTHDOOQQX
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA0206B0", Offset = "0xA01F4B0", VA = "0x18A0206B0")]
		public static XDKPDVFGOFK QDBVPLSAZIH(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(FCZRZYWQJRH), new string[] { })]
	public class RigidbodyExManager : FCZRZYWQJRH, YWYIFNCKTFV
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private VJYADRDFHKG BGDHEBCZSVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private GFSHHAICVPH IVQJNLXDFIV;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public VJYADRDFHKG XCEZNPPPYEL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public GFSHHAICVPH XYWIUEQPXOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA01A930", Offset = "0xA019730", VA = "0x18A01A930", Slot = "7")]
		public void InitReferences(IKBIXEGYPOI services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA01A9A0", Offset = "0xA0197A0", VA = "0x18A01A9A0", Slot = "6")]
		public XDKPDVFGOFK XZHSNXKHEHN(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static DYNHRMPGIXT UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int BOUWOKGBNLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int QWASQJJOXJP;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA0188E0", Offset = "0xA0176E0", VA = "0x18A0188E0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA018960", Offset = "0xA017760", VA = "0x18A018960")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA018900", Offset = "0xA017700", VA = "0x18A018900")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA018A60", Offset = "0xA017860", VA = "0x18A018A60")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class MSHUNPRZOPH
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class IGFVCSDSJFX : HDDJQUXOAWW, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5250", VA = "0x180CF6450", Slot = "4")]
			public Vector3 JLHJTBXRBDC()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5250", VA = "0x180CF6450", Slot = "5")]
			public Vector3 IDKSPSNPIXV()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "6")]
			public bool HKBHQWQXQXM(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public IGFVCSDSJFX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static HDDJQUXOAWW CQNMGFIEKYI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA017800", Offset = "0xA016600", VA = "0x18A017800")]
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
	public interface LQSEGCRROWG
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CollisionDetectionMode KWWCQHRIDVL
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
		void WSJWUHQEGGH(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FKNGFDCVJRU(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JJNPVIZIWYQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool NMUZZZOCWBB(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface QBIGZYPSMTR : IDisposable, JRMZITKTWCL
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		TransformTrackRate GWEQOLAMXSO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> SMFLNJZLJAX;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface GFSHHAICVPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		OAZXDJYJUWI WKLMROPUEIM(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		YBVLSZTJXGO LRMEXXUZWSK(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		WSBCCCPFUUH DVXFEBKVXYD(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		LDPQNIZZQXG JSBCPHWUUKA(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		JFLTWRSMKHO XGIVAFBMDOE(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		QBIGZYPSMTR UOZQHVDEPOX(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		EVFGQKPYFLA OOZVLDMTIJA(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		SXCVSPRDTLW JZWIMOYZMFO(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		LQSEGCRROWG UICYNLIBJYW(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		NPQPCPZEPCZ JZUOCGUUCQR(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		UFFXESXPRCN DCSVZANNCVL(XDKPDVFGOFK a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		FZPHAAVUQBZ RTFSVJQQQSP(XDKPDVFGOFK a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		NPJQOEFKIGN WPYSUSPBLIV(XDKPDVFGOFK a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		RESOWLLUWXN RYGYHLDUROL(XDKPDVFGOFK a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		NGYLGUWSWCH LUBEPARFCML(XDKPDVFGOFK a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		XDKPDVFGOFK XZHSNXKHEHN(RigidbodyEx a, RigidbodyExData b, FCZRZYWQJRH c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface SXCVSPRDTLW
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ROGGJHZQFGT(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QOMPMQFLUON(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GCRXOERCTCO(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KLTXQQPRTXM(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface NPQPCPZEPCZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool VSFABRCABNY
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
		void JJNPVIZIWYQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VSIVIBEZXAV(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface OAZXDJYJUWI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IReadOnlyList<XDKPDVFGOFK> UWJZIMKMPEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		XDKPDVFGOFK YXDZNKGUVHX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		XDKPDVFGOFK ADEQLFZZGJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction ICUBVGDMBRD;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction RDLNGAGGJAT;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction ILKEMHRFFPF;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action UBNLFUZOTEC;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action JYMRFMLYEAX;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<XDKPDVFGOFK> WQRQGCTHDGG;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<XDKPDVFGOFK> JYSFKEUXZIB;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action UNXRNKLKGZM;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<XDKPDVFGOFK> JJXZXBNRGGT;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(XDKPDVFGOFK newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface WSBCCCPFUUH
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Vector3 OSKZRDGRKJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Vector3 QTDLKISJGHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void WBLEKNPLYYY(XDKPDVFGOFK a, object b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SREKNKJLLPP(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface RESOWLLUWXN
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 GKMCEXVKXPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 QZKHMUZNXJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float EBBREICYYEV
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		float OIXEVPTPQIS
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Vector3 SYMUMNVLXWU
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		Quaternion XLCPJAHXBKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction SLRBIDUQSRR;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void PVKGDTTFWNU((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void GWJEKIVMKDP();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void XHZCAUKHNPM();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void LOXIYFMFRJS();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void JJNPVIZIWYQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void VSIVIBEZXAV(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface NPJQOEFKIGN
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ZQCENFLIOTY(object a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void WBSEVKPEKPT(object a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QXMBABPCSHT(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FYVCDNBCFHO(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NFTOUJDAKDL();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface EVFGQKPYFLA
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool ENRYSIDDJTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction LJVLHYINPRI;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void WVSRRFVENQZ(object a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PWSJSLYVASG(object a);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PLORMZKPNME(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JJNPVIZIWYQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void VSIVIBEZXAV(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface FZPHAAVUQBZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool IANMPCTXZDV
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool KHYHTOJFTMT
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction XRUORDVSSXK;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void DKDXBVHNABF(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void OWYAIQTJUPV(XDKPDVFGOFK a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface NGYLGUWSWCH
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool BDYESYTIKSM
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool UTQCTIVQUCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		RigidbodyConstraints PLHIPBVAQGT
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
		void JJNPVIZIWYQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void VSIVIBEZXAV(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface LDPQNIZZQXG
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		float HYHLOCXSQQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		float PIQMEIKTJPR
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
		void JJNPVIZIWYQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void VSIVIBEZXAV(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface JFLTWRSMKHO
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		static bool LHEYSDOJCUA;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction REUZHCXVZYM;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool ZXQJNWFYETO();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ODLGHJZSHAS();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool YEUOKZMPIEU();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool TIAQGQSKQQZ();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void KBLCRAWEBAH(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void DKZBOGCQDUA();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface UFFXESXPRCN
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		Rigidbody TSUTETVWVXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool THMHIMFQJPG
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
		void HEJFIFOXNLU(object a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PDQFADQHMKZ(object a);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GIFZYXYUGIA();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface YBVLSZTJXGO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		HDDJQUXOAWW KLJVFWSFIJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		JNTLKZADWBL DBXPLMJHYAW
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Vector3 NLMPJGSUZDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Vector3 XPUTKDOVZZR
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		Vector3 QFJOPKMFEGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 SKBHGFOYDNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		float FOXHCFVUYTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool ETNHVNIQBZK
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
		void CEQZQIBUQEC(object a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void BFCSZEOCPGM(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void UIGIYLQCWTL(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void GCXLIQGUSJJ(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void SNEKHQMKOJV();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void KONNPWBFTAM();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void FVYSROMJIMB();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void TRLIIBNVRMJ();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void JJNPVIZIWYQ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 YIWWEIZGLWS(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void CPUBGBNQCWV(object a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void PEVFMJBEDZD(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void SEZPMDFOUBO(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void RGRXZTJGEJD(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 BWKMVMIGISA(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 OTBAGGXPLFQ(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface VJYADRDFHKG
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool SPLZRBBUOHP
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GGQNZSEEUBB(string a);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NKETQZJJBJE(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PDFHAFPZZPA IWOOHZQYBTL(int a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EZBHVOJKXBF(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface FCZRZYWQJRH
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		VJYADRDFHKG XCEZNPPPYEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		GFSHHAICVPH XYWIUEQPXOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		XDKPDVFGOFK XZHSNXKHEHN(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class CGICJSTLYPF : XDKPDVFGOFK, IDisposable, WIZVBGOCJRN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal readonly FCZRZYWQJRH OHQUMFIDCOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal OAZXDJYJUWI IFFYBAZUSGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal NPJQOEFKIGN BJQFGEGZDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal FZPHAAVUQBZ IZVDVWEGGVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal YBVLSZTJXGO HLJQEHWQTDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal WSBCCCPFUUH EJBMKELXKSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal RESOWLLUWXN EGBXTUZJKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal LDPQNIZZQXG UKGITRXFRBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal NPQPCPZEPCZ RMAODKQBYIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal JFLTWRSMKHO ANHFCZQDLDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal QBIGZYPSMTR TZOOIQGRDFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal EVFGQKPYFLA AMCNVULZIXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal SXCVSPRDTLW FKKSVYWKPHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal NGYLGUWSWCH KLQCERKUMTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal UFFXESXPRCN YQDUDRNNFYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal LQSEGCRROWG GLGGZLQAYXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal IDisposable DUYJMKSZAYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool CIQVTHMNLXT;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ObjectLocalId FXJADZEOZOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public QPQCJTUZEKK VHFLMTZOGCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xDC75F0", Offset = "0xDC63F0", VA = "0x180DC75F0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xE82A70", Offset = "0xE81870", VA = "0x180E82A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject YQYZFFQUMDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xCE9E60", Offset = "0xCE8C60", VA = "0x180CE9E60", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xCE9E70", Offset = "0xCE8C70", VA = "0x180CE9E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform WNFEIFLAAOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xEA3E30", Offset = "0xEA2C30", VA = "0x180EA3E30", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x1005370", Offset = "0x1004170", VA = "0x181005370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody TSUTETVWVXT
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xA00E1E0", Offset = "0xA00CFE0", VA = "0x18A00E1E0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public XDKPDVFGOFK ADEQLFZZGJP
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xA009580", Offset = "0xA008380", VA = "0x18A009580", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xA00A610", Offset = "0xA009410", VA = "0x18A00A610", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int LMPCHQDGLHO
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA00A380", Offset = "0xA009180", VA = "0x18A00A380", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public XDKPDVFGOFK YXDZNKGUVHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xA00C140", Offset = "0xA00AF40", VA = "0x18A00C140", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool VXAXYNFGLID
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xA00AC10", Offset = "0xA009A10", VA = "0x18A00AC10", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool IANMPCTXZDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA009A50", Offset = "0xA008850", VA = "0x18A009A50", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool KHYHTOJFTMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA00E6F0", Offset = "0xA00D4F0", VA = "0x18A00E6F0", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public HDDJQUXOAWW KLJVFWSFIJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xA00BF80", Offset = "0xA00AD80", VA = "0x18A00BF80", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xA00E0F0", Offset = "0xA00CEF0", VA = "0x18A00E0F0", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public JNTLKZADWBL DBXPLMJHYAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA009F50", Offset = "0xA008D50", VA = "0x18A009F50", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA00D800", Offset = "0xA00C600", VA = "0x18A00D800", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float FOXHCFVUYTY
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xA00D200", Offset = "0xA00C000", VA = "0x18A00D200", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xA00F0D0", Offset = "0xA00DED0", VA = "0x18A00F0D0", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 XPUTKDOVZZR
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xA00A480", Offset = "0xA009280", VA = "0x18A00A480", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xA00AF30", Offset = "0xA009D30", VA = "0x18A00AF30", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 SKBHGFOYDNL
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA00BD80", Offset = "0xA00AB80", VA = "0x18A00BD80", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA00DC10", Offset = "0xA00CA10", VA = "0x18A00DC10", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 NLMPJGSUZDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xA00F7B0", Offset = "0xA00E5B0", VA = "0x18A00F7B0", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA00EFF0", Offset = "0xA00DDF0", VA = "0x18A00EFF0", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 QFJOPKMFEGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA00CF70", Offset = "0xA00BD70", VA = "0x18A00CF70", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA00E530", Offset = "0xA00D330", VA = "0x18A00E530", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool LSUOEYYLJXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA00FAD0", Offset = "0xA00E8D0", VA = "0x18A00FAD0", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool VUHNUVYJKAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA00A1C0", Offset = "0xA008FC0", VA = "0x18A00A1C0", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool OHULPTRHOII
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA00B010", Offset = "0xA009E10", VA = "0x18A00B010", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool ETNHVNIQBZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA00E4E0", Offset = "0xA00D2E0", VA = "0x18A00E4E0", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 OSKZRDGRKJM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xA00BEB0", Offset = "0xA00ACB0", VA = "0x18A00BEB0", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 QTDLKISJGHM
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xA009FA0", Offset = "0xA008DA0", VA = "0x18A009FA0", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 GKMCEXVKXPG
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xA00FB20", Offset = "0xA00E920", VA = "0x18A00FB20", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xA009DB0", Offset = "0xA008BB0", VA = "0x18A009DB0", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 QZKHMUZNXJB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA00F9F0", Offset = "0xA00E7F0", VA = "0x18A00F9F0", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float EBBREICYYEV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xA00EA10", Offset = "0xA00D810", VA = "0x18A00EA10", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float OIXEVPTPQIS
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xA00D390", Offset = "0xA00C190", VA = "0x18A00D390", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xA00E090", Offset = "0xA00CE90", VA = "0x18A00E090", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 SYMUMNVLXWU
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0xA00BAD0", Offset = "0xA00A8D0", VA = "0x18A00BAD0", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion XLCPJAHXBKC
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA00DDA0", Offset = "0xA00CBA0", VA = "0x18A00DDA0", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float HYHLOCXSQQX
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xA00E660", Offset = "0xA00D460", VA = "0x18A00E660", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xA00E9B0", Offset = "0xA00D7B0", VA = "0x18A00E9B0", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float PIQMEIKTJPR
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xA00D730", Offset = "0xA00C530", VA = "0x18A00D730", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xA00AD70", Offset = "0xA009B70", VA = "0x18A00AD70", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool VSFABRCABNY
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xA00BCD0", Offset = "0xA00AAD0", VA = "0x18A00BCD0", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xA00C0E0", Offset = "0xA00AEE0", VA = "0x18A00C0E0", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate GWEQOLAMXSO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA00F5C0", Offset = "0xA00E3C0", VA = "0x18A00F5C0", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xA00A560", Offset = "0xA009360", VA = "0x18A00A560", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool ENRYSIDDJTY
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0xA00D490", Offset = "0xA00C290", VA = "0x18A00D490", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform JTQPGKDHPIE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xEA3E30", Offset = "0xEA2C30", VA = "0x180EA3E30", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 UUZOEMAAMGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA00F890", Offset = "0xA00E690", VA = "0x18A00F890", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA00C390", Offset = "0xA00B190", VA = "0x18A00C390", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float CZFKYAZTUDY
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xA00F5B0", Offset = "0xA00E3B0", VA = "0x18A00F5B0", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xA00D4E0", Offset = "0xA00C2E0", VA = "0x18A00D4E0", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float MHEXLZZNCCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xA00EE40", Offset = "0xA00DC40", VA = "0x18A00EE40", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xA00ADD0", Offset = "0xA009BD0", VA = "0x18A00ADD0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion GCTNCJVDRCB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xA00DF60", Offset = "0xA00CD60", VA = "0x18A00DF60", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xA00F130", Offset = "0xA00DF30", VA = "0x18A00F130", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 RIRFUTNLMYH
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xA00F710", Offset = "0xA00E510", VA = "0x18A00F710", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xA00E050", Offset = "0xA00CE50", VA = "0x18A00E050", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion JNDLMIYHMJY
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xA009D70", Offset = "0xA008B70", VA = "0x18A009D70", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xA00A3F0", Offset = "0xA0091F0", VA = "0x18A00A3F0", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints PLHIPBVAQGT
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA00D570", Offset = "0xA00C370", VA = "0x18A00D570", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA00EA60", Offset = "0xA00D860", VA = "0x18A00EA60", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool BDYESYTIKSM
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xA00C880", Offset = "0xA00B680", VA = "0x18A00C880", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA0097B0", Offset = "0xA0085B0", VA = "0x18A0097B0", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode KWWCQHRIDVL
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xA00F940", Offset = "0xA00E740", VA = "0x18A00F940", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xA0096F0", Offset = "0xA0084F0", VA = "0x18A0096F0", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool HMOWTZNAXLK
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xA00EE50", Offset = "0xA00DC50", VA = "0x18A00EE50", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool QZMYDJZELNF
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xA00D860", Offset = "0xA00C660", VA = "0x18A00D860", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction ICUBVGDMBRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xA00F990", Offset = "0xA00E790", VA = "0x18A00F990", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xA00B8B0", Offset = "0xA00A6B0", VA = "0x18A00B8B0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction RDLNGAGGJAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xA00B400", Offset = "0xA00A200", VA = "0x18A00B400", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xA009EF0", Offset = "0xA008CF0", VA = "0x18A009EF0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction ILKEMHRFFPF
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xA00E2F0", Offset = "0xA00D0F0", VA = "0x18A00E2F0", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xA00A670", Offset = "0xA009470", VA = "0x18A00A670", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction XRUORDVSSXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xA00BD20", Offset = "0xA00AB20", VA = "0x18A00BD20", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA00A320", Offset = "0xA009120", VA = "0x18A00A320", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction DGWSQUNKABH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xA00DAD0", Offset = "0xA00C8D0", VA = "0x18A00DAD0", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xA009CB0", Offset = "0xA008AB0", VA = "0x18A009CB0", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction REUZHCXVZYM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0xA00EDE0", Offset = "0xA00DBE0", VA = "0x18A00EDE0", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xA00D6D0", Offset = "0xA00C4D0", VA = "0x18A00D6D0", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> SMFLNJZLJAX
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xA00BFD0", Offset = "0xA00ADD0", VA = "0x18A00BFD0", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xA00F750", Offset = "0xA00E550", VA = "0x18A00F750", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction LJVLHYINPRI
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA00B910", Offset = "0xA00A710", VA = "0x18A00B910", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xA009E90", Offset = "0xA008C90", VA = "0x18A009E90", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction POXMWURXFZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA00D3E0", Offset = "0xA00C1E0", VA = "0x18A00D3E0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA00DCF0", Offset = "0xA00CAF0", VA = "0x18A00DCF0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA00FC50", Offset = "0xA00EA50", VA = "0x18A00FC50")]
		public CGICJSTLYPF(GameObject a, RigidbodyEx b, FCZRZYWQJRH c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA00F270", Offset = "0xA00E070", VA = "0x18A00F270", Slot = "139")]
		protected virtual void XGGFVIYJLDT(FCZRZYWQJRH a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA00A220", Offset = "0xA009020", VA = "0x18A00A220", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA009810", Offset = "0xA008610", VA = "0x18A009810", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA00CEE0", Offset = "0xA00BCE0", VA = "0x18A00CEE0", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA00CE30", Offset = "0xA00BC30", VA = "0x18A00CE30", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA00CE10", Offset = "0xA00BC10", VA = "0x18A00CE10", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA00B620", Offset = "0xA00A420", VA = "0x18A00B620")]
		private void KBLCRAWEBAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA00D780", Offset = "0xA00C580", VA = "0x18A00D780")]
		private void QVQNLMKANHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA00E480", Offset = "0xA00D280", VA = "0x18A00E480")]
		private void TIAQGQSKQQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA50", Offset = "0xA00A850", VA = "0x18A00BA50", Slot = "30")]
		public XDKPDVFGOFK KMTFXKABZGL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA00E230", Offset = "0xA00D030", VA = "0x18A00E230", Slot = "98")]
		public void SetParent(XDKPDVFGOFK value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA009750", Offset = "0xA008550", VA = "0x18A009750", Slot = "99")]
		public void AYMKAHRFLGI(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA009D10", Offset = "0xA008B10", VA = "0x18A009D10", Slot = "100")]
		public void CKWXFZHLGIT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA00CAD0", Offset = "0xA00B8D0", VA = "0x18A00CAD0", Slot = "101")]
		public Vector3 OTBAGGXPLFQ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA009AA0", Offset = "0xA0088A0", VA = "0x18A009AA0", Slot = "102")]
		public Vector3 BWKMVMIGISA(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA00E610", Offset = "0xA00D410", VA = "0x18A00E610", Slot = "103")]
		public void TRLIIBNVRMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA00BBB0", Offset = "0xA00A9B0", VA = "0x18A00BBB0", Slot = "104")]
		public void KONNPWBFTAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA00E000", Offset = "0xA00CE00", VA = "0x18A00E000", Slot = "105")]
		public void SNEKHQMKOJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA00D9E0", Offset = "0xA00C7E0", VA = "0x18A00D9E0", Slot = "106")]
		public void RGRXZTJGEJD(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA00DE70", Offset = "0xA00CC70", VA = "0x18A00DE70", Slot = "107")]
		public void SEZPMDFOUBO(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA00D0B0", Offset = "0xA00BEB0", VA = "0x18A00D0B0", Slot = "108")]
		public void PEVFMJBEDZD(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA00E740", Offset = "0xA00D540", VA = "0x18A00E740", Slot = "109")]
		public void UIGIYLQCWTL(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA009950", Offset = "0xA008750", VA = "0x18A009950", Slot = "110")]
		public void BFCSZEOCPGM(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA00A7B0", Offset = "0xA0095B0", VA = "0x18A00A7B0", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void GCXLIQGUSJJ(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA00F610", Offset = "0xA00E410", VA = "0x18A00F610", Slot = "112")]
		public Vector3 YIWWEIZGLWS(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA00C290", Offset = "0xA00B090", VA = "0x18A00C290", Slot = "113")]
		public Vector3 NQAMZICCDKW(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA00A5C0", Offset = "0xA0093C0", VA = "0x18A00A5C0", Slot = "114")]
		public void FVYSROMJIMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA00B5B0", Offset = "0xA00A3B0", VA = "0x18A00B5B0", Slot = "115")]
		public void JWMNWCDOBYB(XDKPDVFGOFK a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA00A420", Offset = "0xA009220", VA = "0x18A00A420", Slot = "116")]
		public void ETCJCMXKEFE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA00D250", Offset = "0xA00C050", VA = "0x18A00D250", Slot = "63")]
		public void PVKGDTTFWNU((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA00F560", Offset = "0xA00E360", VA = "0x18A00F560", Slot = "117")]
		public void XHZCAUKHNPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA00AC70", Offset = "0xA009A70", VA = "0x18A00AC70", Slot = "118")]
		public void GWJEKIVMKDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA00BE60", Offset = "0xA00AC60", VA = "0x18A00BE60", Slot = "119")]
		public void LOXIYFMFRJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA00FC00", Offset = "0xA00EA00", VA = "0x18A00FC00", Slot = "120")]
		public bool ZXQJNWFYETO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA00E2A0", Offset = "0xA00D0A0", VA = "0x18A00E2A0", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA00A150", Offset = "0xA008F50", VA = "0x18A00A150", Slot = "121")]
		public void DKZBOGCQDUA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA00F210", Offset = "0xA00E010", VA = "0x18A00F210", Slot = "122")]
		public void WVSRRFVENQZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA00D330", Offset = "0xA00C130", VA = "0x18A00D330", Slot = "123")]
		public void PWSJSLYVASG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA00D190", Offset = "0xA00BF90", VA = "0x18A00D190", Slot = "124")]
		public void PLORMZKPNME(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA00C8D0", Offset = "0xA00B6D0", VA = "0x18A00C8D0", Slot = "125")]
		public void OGCYMNXOKTS(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA00B2D0", Offset = "0xA00A0D0", VA = "0x18A00B2D0", Slot = "126")]
		public void IWYHPALLJAU(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA00ACC0", Offset = "0xA009AC0", VA = "0x18A00ACC0", Slot = "127")]
		public bool HCIZMAESUPV(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA00AED0", Offset = "0xA009CD0", VA = "0x18A00AED0", Slot = "128")]
		public void IMCWNIJTWXC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA00EF90", Offset = "0xA00DD90", VA = "0x18A00EF90", Slot = "129")]
		public void VVHXBGYKUWV(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xA00AD10", Offset = "0xA009B10", VA = "0x18A00AD10", Slot = "130")]
		public void HEJFIFOXNLU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA00D050", Offset = "0xA00BE50", VA = "0x18A00D050", Slot = "131")]
		public void PDQFADQHMKZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA00DB30", Offset = "0xA00C930", VA = "0x18A00DB30", Slot = "132")]
		public void ROGGJHZQFGT(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA00D5C0", Offset = "0xA00C3C0", VA = "0x18A00D5C0", Slot = "133")]
		public void QOMPMQFLUON(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA00A6D0", Offset = "0xA0094D0", VA = "0x18A00A6D0", Slot = "134")]
		public void GCRXOERCTCO(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA00B970", Offset = "0xA00A770", VA = "0x18A00B970", Slot = "135")]
		public void KLTXQQPRTXM(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA00C190", Offset = "0xA00AF90", VA = "0x18A00C190", Slot = "136")]
		public bool NMUZZZOCWBB(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xA00CE90", Offset = "0xA00BC90", VA = "0x18A00CE90", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA00E6B0", Offset = "0xA00D4B0", VA = "0x18A00E6B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA00BC00", Offset = "0xA00AA00", VA = "0x18A00BC00")]
		private void KPIBPYDCJHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA009BA0", Offset = "0xA0089A0", VA = "0x18A009BA0")]
		private void CEOMOZKCYAX(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA00B0F0", Offset = "0xA009EF0", VA = "0x18A00B0F0")]
		private void IVTCNAWLYJW(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA00C030", Offset = "0xA00AE30", VA = "0x18A00C030")]
		private void NAOUGKVUHQL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xA00E350", Offset = "0xA00D150", VA = "0x18A00E350")]
		private void TFOUONISAES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA00E800", Offset = "0xA00D600", VA = "0x18A00E800")]
		private void UINJWKWKBBS(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA00A080", Offset = "0xA008E80", VA = "0x18A00A080")]
		private void DKDXBVHNABF(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA00CBD0", Offset = "0xA00B9D0", VA = "0x18A00CBD0")]
		private void OWYAIQTJUPV(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA00B460", Offset = "0xA00A260", VA = "0x18A00B460")]
		private void JSAXISXCTEK(QPQCJTUZEKK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA00C440", Offset = "0xA00B240", VA = "0x18A00C440", Slot = "142")]
		protected virtual void OCMFTABHFID(QPQCJTUZEKK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA00EAC0", Offset = "0xA00D8C0", VA = "0x18A00EAC0")]
		protected void UYLFOOVTVJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA00A8C0", Offset = "0xA0096C0", VA = "0x18A00A8C0")]
		protected void GDGQRXBRWAT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA0095D0", Offset = "0xA0083D0", VA = "0x18A0095D0")]
		private void AJUOJELOCAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA00CCA0", Offset = "0xA00BAA0", VA = "0x18A00CCA0")]
		private void OYMRJVDQEZY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class SNZABMYKHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA020920", Offset = "0xA01F720", VA = "0x18A020920")]
		public static XDKPDVFGOFK XLZMDEMKEMO(this XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA020880", Offset = "0xA01F680", VA = "0x18A020880")]
		public static bool HSQYCTJKTGV(this XDKPDVFGOFK a, XDKPDVFGOFK b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA0207E0", Offset = "0xA01F5E0", VA = "0x18A0207E0")]
		public static bool EEJHOEYAGKP(this XDKPDVFGOFK a, XDKPDVFGOFK b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA020720", Offset = "0xA01F520", VA = "0x18A020720")]
		public static QPQCJTUZEKK AVVDJHUUNRJ(this XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA020770", Offset = "0xA01F570", VA = "0x18A020770")]
		public static CGICJSTLYPF Base(this XDKPDVFGOFK impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DFACHIOZIBQ : GFSHHAICVPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA010DF0", Offset = "0xA00FBF0", VA = "0x18A010DF0", Slot = "19")]
		public XDKPDVFGOFK XZHSNXKHEHN(RigidbodyEx a, RigidbodyExData b, FCZRZYWQJRH c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "4")]
		public OAZXDJYJUWI WKLMROPUEIM(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "5")]
		public YBVLSZTJXGO LRMEXXUZWSK(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "6")]
		public WSBCCCPFUUH DVXFEBKVXYD(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "7")]
		public LDPQNIZZQXG JSBCPHWUUKA(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "8")]
		public JFLTWRSMKHO XGIVAFBMDOE(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "9")]
		public QBIGZYPSMTR UOZQHVDEPOX(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "10")]
		public EVFGQKPYFLA OOZVLDMTIJA(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "11")]
		public SXCVSPRDTLW JZWIMOYZMFO(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "12")]
		public LQSEGCRROWG UICYNLIBJYW(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "13")]
		public NPQPCPZEPCZ JZUOCGUUCQR(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160")]
		public UFFXESXPRCN DCSVZANNCVL(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160")]
		public FZPHAAVUQBZ RTFSVJQQQSP(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160")]
		public NPJQOEFKIGN WPYSUSPBLIV(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160")]
		public RESOWLLUWXN RYGYHLDUROL(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160")]
		public NGYLGUWSWCH LUBEPARFCML(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public DFACHIOZIBQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "14")]
		private UFFXESXPRCN WTIHJVOTFNL(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "15")]
		private FZPHAAVUQBZ FKVHXCEWAYH(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "16")]
		private NPJQOEFKIGN VQRBQQBFPYB(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "17")]
		private RESOWLLUWXN FDMYSOYFMYH(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "18")]
		private NGYLGUWSWCH LOOYASLOZFB(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(GFSHHAICVPH), new string[] { })]
	public class ZYBLEOGPURV : GFSHHAICVPH, YWYIFNCKTFV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly GFSHHAICVPH EUBDSRTSPBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly GFSHHAICVPH CEHEDSLBLXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private QQNVIVNKCIN QEIIJOPYLYM;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private GFSHHAICVPH XYWIUEQPXOB
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xA021EF0", Offset = "0xA020CF0", VA = "0x18A021EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA021AD0", Offset = "0xA0208D0", VA = "0x18A021AD0", Slot = "20")]
		public void InitReferences(IKBIXEGYPOI services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xA022140", Offset = "0xA020F40", VA = "0x18A022140", Slot = "4")]
		public OAZXDJYJUWI WKLMROPUEIM(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xA021DB0", Offset = "0xA020BB0", VA = "0x18A021DB0", Slot = "5")]
		public YBVLSZTJXGO LRMEXXUZWSK(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xA0218D0", Offset = "0xA0206D0", VA = "0x18A0218D0", Slot = "6")]
		public WSBCCCPFUUH DVXFEBKVXYD(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA021B20", Offset = "0xA020920", VA = "0x18A021B20", Slot = "7")]
		public LDPQNIZZQXG JSBCPHWUUKA(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xA0221E0", Offset = "0xA020FE0", VA = "0x18A0221E0", Slot = "8")]
		public JFLTWRSMKHO XGIVAFBMDOE(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xA021FF0", Offset = "0xA020DF0", VA = "0x18A021FF0", Slot = "9")]
		public QBIGZYPSMTR UOZQHVDEPOX(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xA021E50", Offset = "0xA020C50", VA = "0x18A021E50", Slot = "10")]
		public EVFGQKPYFLA OOZVLDMTIJA(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xA021C60", Offset = "0xA020A60", VA = "0x18A021C60", Slot = "11")]
		public SXCVSPRDTLW JZWIMOYZMFO(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xA021F50", Offset = "0xA020D50", VA = "0x18A021F50", Slot = "12")]
		public LQSEGCRROWG UICYNLIBJYW(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA021BC0", Offset = "0xA0209C0", VA = "0x18A021BC0", Slot = "13")]
		public NPQPCPZEPCZ JZUOCGUUCQR(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xA021820", Offset = "0xA020620", VA = "0x18A021820")]
		public UFFXESXPRCN DCSVZANNCVL(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xA021A20", Offset = "0xA020820", VA = "0x18A021A20")]
		public FZPHAAVUQBZ RTFSVJQQQSP(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xA022090", Offset = "0xA020E90", VA = "0x18A022090")]
		public NPJQOEFKIGN WPYSUSPBLIV(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xA021970", Offset = "0xA020770", VA = "0x18A021970")]
		public RESOWLLUWXN RYGYHLDUROL(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xA021D00", Offset = "0xA020B00", VA = "0x18A021D00")]
		public NGYLGUWSWCH LUBEPARFCML(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xA022280", Offset = "0xA021080", VA = "0x18A022280", Slot = "19")]
		public XDKPDVFGOFK XZHSNXKHEHN(RigidbodyEx a, RigidbodyExData b, FCZRZYWQJRH c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xA0223D0", Offset = "0xA0211D0", VA = "0x18A0223D0")]
		public ZYBLEOGPURV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0xA021820", Offset = "0xA020620", VA = "0x18A021820", Slot = "14")]
		private UFFXESXPRCN WTIHJVOTFNL(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0xA021A20", Offset = "0xA020820", VA = "0x18A021A20", Slot = "15")]
		private FZPHAAVUQBZ FKVHXCEWAYH(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xA022090", Offset = "0xA020E90", VA = "0x18A022090", Slot = "16")]
		private NPJQOEFKIGN VQRBQQBFPYB(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0xA021970", Offset = "0xA020770", VA = "0x18A021970", Slot = "17")]
		private RESOWLLUWXN FDMYSOYFMYH(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA021D00", Offset = "0xA020B00", VA = "0x18A021D00", Slot = "18")]
		private NGYLGUWSWCH LOOYASLOZFB(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface UIXEWRGBGEN : OAZXDJYJUWI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BICMCWKPHLE(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EOMKGWFKIHD(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JRXRFQQIFMI(XDKPDVFGOFK a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OZVDCNYRLLH(XDKPDVFGOFK a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface TVTQXYYOBWS : WSBCCCPFUUH
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		TNYRCSLYBCO<XDKPDVFGOFK> YEVTMPZTTZX
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		XDKPDVFGOFK XJWLTUIIPUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface AFNWSZNIONG : RESOWLLUWXN
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) IBOQPRVOCKV(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface WSTLQIGIDKG : FZPHAAVUQBZ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		RRNetworkView GTUIIBIREKS
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal sealed class VLWOMEVQZHN : LQSEGCRROWG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CollisionDetectionMode CPAGSNZALGZ;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private Rigidbody TSUTETVWVXT
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xA016770", Offset = "0xA015570", VA = "0x18A016770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode KWWCQHRIDVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xA021030", Offset = "0xA01FE30", VA = "0x18A021030", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0xA020B90", Offset = "0xA01F990", VA = "0x18A020B90", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xA016A20", Offset = "0xA015820", VA = "0x18A016A20")]
		public VLWOMEVQZHN(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0xA020C00", Offset = "0xA01FA00", VA = "0x18A020C00", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0xA020D20", Offset = "0xA01FB20", VA = "0x18A020D20", Slot = "9")]
		public void JJNPVIZIWYQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0xA021020", Offset = "0xA01FE20", VA = "0x18A021020", Slot = "7")]
		public void WSJWUHQEGGH(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xA020D10", Offset = "0xA01FB10", VA = "0x18A020D10", Slot = "8")]
		public void FKNGFDCVJRU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0xA020DA0", Offset = "0xA01FBA0", VA = "0x18A020DA0", Slot = "10")]
		public bool NMUZZZOCWBB(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA020F00", Offset = "0xA01FD00", VA = "0x18A020F00")]
		private void QUJGTBBFEWN(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class YGTHUFAPGBG : QBIGZYPSMTR, IDisposable, JRMZITKTWCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TransformTrackRate WQTAGHHPQSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private PDFHAFPZZPA EXKSTGJEWZU;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TransformTrackRate GWEQOLAMXSO
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xA0215A0", Offset = "0xA0203A0", VA = "0x18A0215A0", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xA021400", Offset = "0xA020200", VA = "0x18A021400", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform PNBZSMYWYOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xA021580", Offset = "0xA020380", VA = "0x18A021580", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> SMFLNJZLJAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0xA0214D0", Offset = "0xA0202D0", VA = "0x18A0214D0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xA0216E0", Offset = "0xA0204E0", VA = "0x18A0216E0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xA021790", Offset = "0xA020590", VA = "0x18A021790")]
		public YGTHUFAPGBG(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xA021140", Offset = "0xA01FF40", VA = "0x18A021140", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA0213B0", Offset = "0xA0201B0", VA = "0x18A0213B0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x13BA100", Offset = "0x13B8F00", VA = "0x1813BA100", Slot = "11")]
		private void GGIFVPNTPPY(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "12")]
		private void OHEWXGYBBJM(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class DFACHIOZIBQ : GFSHHAICVPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xA010B10", Offset = "0xA00F910", VA = "0x18A010B10", Slot = "4")]
		public OAZXDJYJUWI WKLMROPUEIM(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xA010490", Offset = "0xA00F290", VA = "0x18A010490", Slot = "5")]
		public YBVLSZTJXGO LRMEXXUZWSK(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA00FF20", Offset = "0xA00ED20", VA = "0x18A00FF20", Slot = "6")]
		public WSBCCCPFUUH DVXFEBKVXYD(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA0101D0", Offset = "0xA00EFD0", VA = "0x18A0101D0", Slot = "7")]
		public LDPQNIZZQXG JSBCPHWUUKA(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xA010BF0", Offset = "0xA00F9F0", VA = "0x18A010BF0", Slot = "8")]
		public JFLTWRSMKHO XGIVAFBMDOE(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xA010930", Offset = "0xA00F730", VA = "0x18A010930", Slot = "9")]
		public QBIGZYPSMTR UOZQHVDEPOX(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA0105A0", Offset = "0xA00F3A0", VA = "0x18A0105A0", Slot = "10")]
		public EVFGQKPYFLA OOZVLDMTIJA(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA010300", Offset = "0xA00F100", VA = "0x18A010300", Slot = "11")]
		public SXCVSPRDTLW JZWIMOYZMFO(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xA010870", Offset = "0xA00F670", VA = "0x18A010870", Slot = "12")]
		public LQSEGCRROWG UICYNLIBJYW(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA010240", Offset = "0xA00F040", VA = "0x18A010240", Slot = "13")]
		public NPQPCPZEPCZ JZUOCGUUCQR(XDKPDVFGOFK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA00FE00", Offset = "0xA00EC00", VA = "0x18A00FE00")]
		public UFFXESXPRCN DCSVZANNCVL(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA0106B0", Offset = "0xA00F4B0", VA = "0x18A0106B0")]
		public FZPHAAVUQBZ RTFSVJQQQSP(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA0109F0", Offset = "0xA00F7F0", VA = "0x18A0109F0")]
		public NPJQOEFKIGN WPYSUSPBLIV(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xA010040", Offset = "0xA00EE40", VA = "0x18A010040")]
		public RESOWLLUWXN RYGYHLDUROL(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xA0103C0", Offset = "0xA00F1C0", VA = "0x18A0103C0")]
		public NGYLGUWSWCH LUBEPARFCML(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0xA010CB0", Offset = "0xA00FAB0", VA = "0x18A010CB0", Slot = "19")]
		public XDKPDVFGOFK XZHSNXKHEHN(RigidbodyEx a, RigidbodyExData b, FCZRZYWQJRH c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public DFACHIOZIBQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xA00FE00", Offset = "0xA00EC00", VA = "0x18A00FE00", Slot = "14")]
		private UFFXESXPRCN WTIHJVOTFNL(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xA0101C0", Offset = "0xA00EFC0", VA = "0x18A0101C0", Slot = "15")]
		private FZPHAAVUQBZ FKVHXCEWAYH(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xA0109F0", Offset = "0xA00F7F0", VA = "0x18A0109F0", Slot = "16")]
		private NPJQOEFKIGN VQRBQQBFPYB(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xA010040", Offset = "0xA00EE40", VA = "0x18A010040", Slot = "17")]
		private RESOWLLUWXN FDMYSOYFMYH(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA0103C0", Offset = "0xA00F1C0", VA = "0x18A0103C0", Slot = "18")]
		private NGYLGUWSWCH LOOYASLOZFB(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal sealed class GNHCUSYRXYT : SXCVSPRDTLW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody TSUTETVWVXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0xA016770", Offset = "0xA015570", VA = "0x18A016770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool ENRYSIDDJTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xA0160E0", Offset = "0xA014EE0", VA = "0x18A0160E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool VXAXYNFGLID
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0xA015E20", Offset = "0xA014C20", VA = "0x18A015E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private XDKPDVFGOFK ADEQLFZZGJP
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0xA015C60", Offset = "0xA014A60", VA = "0x18A015C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA016A20", Offset = "0xA015820", VA = "0x18A016A20")]
		public GNHCUSYRXYT(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA0163B0", Offset = "0xA0151B0", VA = "0x18A0163B0", Slot = "4")]
		public void ROGGJHZQFGT(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xA016510", Offset = "0xA015310", VA = "0x18A016510")]
		private void SODXCECPSDU(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xA016130", Offset = "0xA014F30", VA = "0x18A016130", Slot = "5")]
		public void QOMPMQFLUON(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xA015CC0", Offset = "0xA014AC0", VA = "0x18A015CC0", Slot = "6")]
		public void GCRXOERCTCO(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xA0167C0", Offset = "0xA0155C0", VA = "0x18A0167C0")]
		private void TENMJZHMANT(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA015E80", Offset = "0xA014C80", VA = "0x18A015E80", Slot = "7")]
		public void KLTXQQPRTXM(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class UUSPXDRIPQG : NPQPCPZEPCZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool QCABZPGCPAC;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool VSFABRCABNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xE92720", Offset = "0xE91520", VA = "0x180E92720", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xA020A10", Offset = "0xA01F810", VA = "0x18A020A10", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA016A20", Offset = "0xA015820", VA = "0x18A016A20")]
		public UUSPXDRIPQG(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xA0209E0", Offset = "0xA01F7E0", VA = "0x18A0209E0", Slot = "6")]
		public void JJNPVIZIWYQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xA020B20", Offset = "0xA01F920", VA = "0x18A020B20", Slot = "7")]
		public void VSIVIBEZXAV(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RbexHierarchy : UIXEWRGBGEN, OAZXDJYJUWI, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly XDKPDVFGOFK SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<XDKPDVFGOFK> LJNSXJHVHGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private XDKPDVFGOFK NEXPSVAOOPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private XDKPDVFGOFK WKYFTFFHETD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform QQDXLOVDUAA;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private Transform WNFEIFLAAOD
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0xA019270", Offset = "0xA018070", VA = "0x18A019270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public XDKPDVFGOFK ADEQLFZZGJP
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B60", Offset = "0xCE6960", VA = "0x180CE7B60", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xA019120", Offset = "0xA017F20", VA = "0x18A019120", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public XDKPDVFGOFK YXDZNKGUVHX
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B40", Offset = "0xCE6940", VA = "0x180CE7B40", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<XDKPDVFGOFK> UWJZIMKMPEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xCEB600", Offset = "0xCEA400", VA = "0x180CEB600", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction ICUBVGDMBRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0xA01A740", Offset = "0xA019540", VA = "0x18A01A740", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0xA0195E0", Offset = "0xA0183E0", VA = "0x18A0195E0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction RDLNGAGGJAT
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0xA0192D0", Offset = "0xA0180D0", VA = "0x18A0192D0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xA018DB0", Offset = "0xA017BB0", VA = "0x18A018DB0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction ILKEMHRFFPF
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0xA01A180", Offset = "0xA018F80", VA = "0x18A01A180", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0xA019130", Offset = "0xA017F30", VA = "0x18A019130", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action UBNLFUZOTEC
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xA0199B0", Offset = "0xA0187B0", VA = "0x18A0199B0", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0xA018E50", Offset = "0xA017C50", VA = "0x18A018E50", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action JYMRFMLYEAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xA01A7E0", Offset = "0xA0195E0", VA = "0x18A01A7E0", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0xA018B70", Offset = "0xA017970", VA = "0x18A018B70", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<XDKPDVFGOFK> WQRQGCTHDGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0xA019680", Offset = "0xA018480", VA = "0x18A019680", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0xA018EF0", Offset = "0xA017CF0", VA = "0x18A018EF0", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<XDKPDVFGOFK> JYSFKEUXZIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0xA01A2C0", Offset = "0xA0190C0", VA = "0x18A01A2C0", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0xA01A370", Offset = "0xA019170", VA = "0x18A01A370", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action UNXRNKLKGZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0xA0191D0", Offset = "0xA017FD0", VA = "0x18A0191D0", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0xA019A50", Offset = "0xA018850", VA = "0x18A019A50", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<XDKPDVFGOFK> JJXZXBNRGGT
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0xA018D00", Offset = "0xA017B00", VA = "0x18A018D00", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0xA01A550", Offset = "0xA019350", VA = "0x18A01A550", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA01A880", Offset = "0xA019680", VA = "0x18A01A880")]
		public RbexHierarchy(XDKPDVFGOFK rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA018FA0", Offset = "0xA017DA0", VA = "0x18A018FA0", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA019C10", Offset = "0xA018A10", VA = "0x18A019C10", Slot = "30")]
		public void SetParent(XDKPDVFGOFK newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xA019370", Offset = "0xA018170", VA = "0x18A019370", Slot = "6")]
		public void JRXRFQQIFMI(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA019730", Offset = "0xA018530", VA = "0x18A019730", Slot = "7")]
		public void OZVDCNYRLLH(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xA018C10", Offset = "0xA017A10", VA = "0x18A018C10", Slot = "4")]
		public void BICMCWKPHLE(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xA019040", Offset = "0xA017E40", VA = "0x18A019040", Slot = "5")]
		public void EOMKGWFKIHD(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xA01A220", Offset = "0xA019020", VA = "0x18A01A220")]
		private void TKQXXGUKMKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xA0190E0", Offset = "0xA017EE0", VA = "0x18A0190E0")]
		private void FYXIULZBBDJ(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA01A600", Offset = "0xA019400", VA = "0x18A01A600")]
		private void XTQLZASGOZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA01A420", Offset = "0xA019220", VA = "0x18A01A420")]
		private void VFOXRYOXYHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA019AF0", Offset = "0xA0188F0", VA = "0x18A019AF0")]
		private void SZWWATXVMOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA018AB0", Offset = "0xA0178B0", VA = "0x18A018AB0")]
		[CompilerGenerated]
		private object AJVQVWZUPCB()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class CWBGXHNHPND
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xA00FD40", Offset = "0xA00EB40", VA = "0x18A00FD40")]
		public static UIXEWRGBGEN EBHQKPMKXQA(this XDKPDVFGOFK a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class FGWANOGIWVG : TVTQXYYOBWS, WSBCCCPFUUH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly TNYRCSLYBCO<XDKPDVFGOFK> VQHNVAAVBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool XBJJOCERCQS;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public TNYRCSLYBCO<XDKPDVFGOFK> YEVTMPZTTZX
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 OSKZRDGRKJM
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xA012C60", Offset = "0xA011A60", VA = "0x18A012C60", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 QTDLKISJGHM
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xA0128B0", Offset = "0xA0116B0", VA = "0x18A0128B0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 NLMPJGSUZDG
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0xA013100", Offset = "0xA011F00", VA = "0x18A013100")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public XDKPDVFGOFK XJWLTUIIPUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0xA012BB0", Offset = "0xA0119B0", VA = "0x18A012BB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA0131E0", Offset = "0xA011FE0", VA = "0x18A0131E0")]
		public FGWANOGIWVG(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA013090", Offset = "0xA011E90", VA = "0x18A013090", Slot = "8")]
		public void WBLEKNPLYYY(XDKPDVFGOFK a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA013030", Offset = "0xA011E30", VA = "0x18A013030", Slot = "9")]
		public void SREKNKJLLPP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA012510", Offset = "0xA011310", VA = "0x18A012510")]
		private Vector3 BNCTUNGUITO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA012C90", Offset = "0xA011A90", VA = "0x18A012C90")]
		private void QSMTMRDSWGB(XDKPDVFGOFK a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class HOOXGTZLJDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA016CE0", Offset = "0xA015AE0", VA = "0x18A016CE0")]
		public static TVTQXYYOBWS EXNMBFCGZLV(this XDKPDVFGOFK a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class GCFNIFCFGUS : AFNWSZNIONG, RESOWLLUWXN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly OverridableVector3 OSRCMBJTTGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly OverridableVector3 PAULDXCAQNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private float TQWBWKTQQCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float SIVHJSWSRMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3 PIUUOJATRJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Vector3? NTTBJMCTPQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Quaternion? JGZHECCIWXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool HAAAJVZUWRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool OGRBZUVWEGG;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 GKMCEXVKXPG
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1EC1260", Offset = "0x1EC0060", VA = "0x181EC1260", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xA013610", Offset = "0xA012410", VA = "0x18A013610", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 QZKHMUZNXJB
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0xA0159E0", Offset = "0xA0147E0", VA = "0x18A0159E0", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float EBBREICYYEV
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xD37FC0", Offset = "0xD36DC0", VA = "0x180D37FC0", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xA0149E0", Offset = "0xA0137E0", VA = "0x18A0149E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float OIXEVPTPQIS
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xD37FD0", Offset = "0xD36DD0", VA = "0x180D37FD0", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xA014930", Offset = "0xA013730", VA = "0x18A014930", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 SYMUMNVLXWU
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xA014AF0", Offset = "0xA0138F0", VA = "0x18A014AF0", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion XLCPJAHXBKC
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xA015510", Offset = "0xA014310", VA = "0x18A015510", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody TSUTETVWVXT
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xA015690", Offset = "0xA014490", VA = "0x18A015690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction SLRBIDUQSRR
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xA013570", Offset = "0xA012370", VA = "0x18A013570", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xA0136C0", Offset = "0xA0124C0", VA = "0x18A0136C0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xA015B00", Offset = "0xA014900", VA = "0x18A015B00")]
		public GCFNIFCFGUS(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA0158C0", Offset = "0xA0146C0", VA = "0x18A0158C0", Slot = "17")]
		public void XHZCAUKHNPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA013760", Offset = "0xA012560", VA = "0x18A013760", Slot = "16")]
		public void GWJEKIVMKDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA014850", Offset = "0xA013650", VA = "0x18A014850", Slot = "19")]
		public void JJNPVIZIWYQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA0156E0", Offset = "0xA0144E0", VA = "0x18A0156E0", Slot = "20")]
		public void VSIVIBEZXAV(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA014C80", Offset = "0xA013A80", VA = "0x18A014C80", Slot = "18")]
		public void LOXIYFMFRJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA014E20", Offset = "0xA013C20", VA = "0x18A014E20", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA013610", Offset = "0xA012410", VA = "0x18A013610")]
		private void PEBNNAXGHQC(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA013450", Offset = "0xA012250", VA = "0x18A013450")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 BVXFBOOINWF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xA0149E0", Offset = "0xA0137E0", VA = "0x18A0149E0")]
		private void KFBNBRUEASP(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xA014930", Offset = "0xA013730", VA = "0x18A014930")]
		private void JOYOORZWWKU(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xA0146B0", Offset = "0xA0134B0", VA = "0x18A0146B0")]
		private Vector3 ITLPUFRBFQW()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xA0152E0", Offset = "0xA0140E0", VA = "0x18A0152E0", Slot = "15")]
		public void PVKGDTTFWNU((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xA0132D0", Offset = "0xA0120D0", VA = "0x18A0132D0")]
		private Quaternion AZLZXVPUBPW()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xA013840", Offset = "0xA012640", VA = "0x18A013840")]
		public void IBOQPRVOCKV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA013910", Offset = "0xA012710", VA = "0x18A013910", Slot = "4")]
		public (float, Vector3) IBOQPRVOCKV(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class NIZIDNBWXGQ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xA018550", Offset = "0xA017350", VA = "0x18A018550")]
		public static AFNWSZNIONG KKICRCIZOJR(this XDKPDVFGOFK a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class EGYZBKPYUEK : NPJQOEFKIGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly CFODDVOSBJL LKGFQHAYKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly RbexInterpolationMode KUSSYZBSNOE;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool TLOVCHEVLGI
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x1B53450", Offset = "0x1B52250", VA = "0x181B53450", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode FZKHSZNZYHI
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xCF75E0", Offset = "0xCF63E0", VA = "0x180CF75E0", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA011490", Offset = "0xA010290", VA = "0x18A011490")]
		public EGYZBKPYUEK(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA010E80", Offset = "0xA00FC80", VA = "0x18A010E80", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA010F90", Offset = "0xA00FD90", VA = "0x18A010F90")]
		private bool KCOMSPKZVUG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA011460", Offset = "0xA010260", VA = "0x18A011460", Slot = "5")]
		public void ZQCENFLIOTY(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA0112B0", Offset = "0xA0100B0", VA = "0x18A0112B0", Slot = "6")]
		public void WBSEVKPEKPT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA011140", Offset = "0xA00FF40", VA = "0x18A011140", Slot = "9")]
		public void NFTOUJDAKDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA011030", Offset = "0xA00FE30", VA = "0x18A011030")]
		private void LTRULCROELU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA0112E0", Offset = "0xA0100E0", VA = "0x18A0112E0")]
		private void WNKAXFGJYKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA010F50", Offset = "0xA00FD50", VA = "0x18A010F50", Slot = "8")]
		public void FYVCDNBCFHO(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA011270", Offset = "0xA010070", VA = "0x18A011270", Slot = "7")]
		public void QXMBABPCSHT(XDKPDVFGOFK a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class SLBADPVUVEN : EVFGQKPYFLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly CFODDVOSBJL VTSKUEXHLTK;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool ENRYSIDDJTY
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xA0204A0", Offset = "0xA01F2A0", VA = "0x18A0204A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction LJVLHYINPRI
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xA0202E0", Offset = "0xA01F0E0", VA = "0x18A0202E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xA0201C0", Offset = "0xA01EFC0", VA = "0x18A0201C0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA0205D0", Offset = "0xA01F3D0", VA = "0x18A0205D0")]
		public SLBADPVUVEN(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA0205C0", Offset = "0xA01F3C0", VA = "0x18A0205C0", Slot = "7")]
		public void WVSRRFVENQZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA020490", Offset = "0xA01F290", VA = "0x18A020490", Slot = "8")]
		public void PWSJSLYVASG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA020380", Offset = "0xA01F180", VA = "0x18A020380", Slot = "9")]
		public void PLORMZKPNME(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA020550", Offset = "0xA01F350", VA = "0x18A020550", Slot = "12")]
		public void UBMBOMQJSHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA020260", Offset = "0xA01F060", VA = "0x18A020260", Slot = "10")]
		public void JJNPVIZIWYQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA020590", Offset = "0xA01F390", VA = "0x18A020590", Slot = "11")]
		public void VSIVIBEZXAV(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class FANRVXYZOMY : WSTLQIGIDKG, FZPHAAVUQBZ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private WeakReference<XDKPDVFGOFK> HGEOECXPIAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private RRNetworkView PEYTLAHKVZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private bool BIGWPVLURSH;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public RRNetworkView GTUIIBIREKS
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool IANMPCTXZDV
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xA0116B0", Offset = "0xA0104B0", VA = "0x18A0116B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool KHYHTOJFTMT
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xD44660", Offset = "0xD43460", VA = "0x180D44660", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction XRUORDVSSXK
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xA011D70", Offset = "0xA010B70", VA = "0x18A011D70", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xA011CD0", Offset = "0xA010AD0", VA = "0x18A011CD0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA012370", Offset = "0xA011170", VA = "0x18A012370")]
		public FANRVXYZOMY(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA011580", Offset = "0xA010380", VA = "0x18A011580", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xA0119A0", Offset = "0xA0107A0", VA = "0x18A0119A0", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA011810", Offset = "0xA010610", VA = "0x18A011810", Slot = "10")]
		public void DKDXBVHNABF(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA011E10", Offset = "0xA010C10", VA = "0x18A011E10", Slot = "11")]
		public void OWYAIQTJUPV(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA012200", Offset = "0xA011000", VA = "0x18A012200")]
		private void YSFITUULUVL(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA0116C0", Offset = "0xA0104C0", VA = "0x18A0116C0")]
		private void DJWABVSWRKX(QPQCJTUZEKK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA011F90", Offset = "0xA010D90", VA = "0x18A011F90")]
		private void VZMMEXXLPCI(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class MRGOVTVGMFY
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA017740", Offset = "0xA016540", VA = "0x18A017740")]
		public static WSTLQIGIDKG Lifecycle(this XDKPDVFGOFK impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class GUGKEDRDNVQ : NGYLGUWSWCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private RigidbodyConstraints SPNQCTQRWGD;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool BDYESYTIKSM
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xE8E790", Offset = "0xE8D590", VA = "0x180E8E790", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xEB8230", Offset = "0xEB7030", VA = "0x180EB8230", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool UTQCTIVQUCD
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xEB8CC0", Offset = "0xEB7AC0", VA = "0x180EB8CC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xEB86A0", Offset = "0xEB74A0", VA = "0x180EB86A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints PLHIPBVAQGT
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xCED330", Offset = "0xCEC130", VA = "0x180CED330", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0xA016AE0", Offset = "0xA0158E0", VA = "0x18A016AE0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA016C40", Offset = "0xA015A40", VA = "0x18A016C40")]
		public GUGKEDRDNVQ(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xA016AB0", Offset = "0xA0158B0", VA = "0x18A016AB0", Slot = "9")]
		public void JJNPVIZIWYQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA016C10", Offset = "0xA015A10", VA = "0x18A016C10", Slot = "10")]
		public void VSIVIBEZXAV(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class PQDJIMXZADD : LDPQNIZZQXG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly XDKPDVFGOFK SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private float OYJMGFVZVRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private float SOFNTCVHTMH;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public float HYHLOCXSQQX
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xD4D5B0", Offset = "0xD4C3B0", VA = "0x180D4D5B0", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xA018730", Offset = "0xA017530", VA = "0x18A018730", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float PIQMEIKTJPR
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xD4D630", Offset = "0xD4C430", VA = "0x180D4D630", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0xA018610", Offset = "0xA017410", VA = "0x18A018610", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA0188A0", Offset = "0xA0176A0", VA = "0x18A0188A0")]
		public PQDJIMXZADD(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA0186E0", Offset = "0xA0174E0", VA = "0x18A0186E0", Slot = "8")]
		public void JJNPVIZIWYQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA018800", Offset = "0xA017600", VA = "0x18A018800", Slot = "9")]
		public void VSIVIBEZXAV(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class NIONFGFKOCL : JFLTWRSMKHO
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly Log XGXOPNOJKEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool ZLXHHBMETXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool MYTXODKUSSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int GNSFBIEDYUB;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private Rigidbody TSUTETVWVXT
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xA015690", Offset = "0xA014490", VA = "0x18A015690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool HMOWTZNAXLK
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xA018250", Offset = "0xA017050", VA = "0x18A018250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private XDKPDVFGOFK ADEQLFZZGJP
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0xA0178D0", Offset = "0xA0166D0", VA = "0x18A0178D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool VXAXYNFGLID
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xA017A60", Offset = "0xA016860", VA = "0x18A017A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction REUZHCXVZYM
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0xA018020", Offset = "0xA016E20", VA = "0x18A018020", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xA017C00", Offset = "0xA016A00", VA = "0x18A017C00", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA0184C0", Offset = "0xA0172C0", VA = "0x18A0184C0")]
		public NIONFGFKOCL(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA017930", Offset = "0xA016730", VA = "0x18A017930", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA017BF0", Offset = "0xA0169F0", VA = "0x18A017BF0", Slot = "8")]
		public void ODLGHJZSHAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA0182E0", Offset = "0xA0170E0", VA = "0x18A0182E0", Slot = "7")]
		public bool ZXQJNWFYETO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA017E60", Offset = "0xA016C60", VA = "0x18A017E60", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xA0179C0", Offset = "0xA0167C0", VA = "0x18A0179C0", Slot = "13")]
		public void DKZBOGCQDUA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xA017AC0", Offset = "0xA0168C0", VA = "0x18A017AC0", Slot = "12")]
		public void KBLCRAWEBAH(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA018270", Offset = "0xA017070", VA = "0x18A018270", Slot = "10")]
		public bool YEUOKZMPIEU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA017F30", Offset = "0xA016D30", VA = "0x18A017F30", Slot = "11")]
		public bool TIAQGQSKQQZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA017CA0", Offset = "0xA016AA0", VA = "0x18A017CA0")]
		private bool RZZMFDQSDSX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA0180C0", Offset = "0xA016EC0", VA = "0x18A0180C0")]
		private void VCIIKVZMLAD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class KVDNUQUVYQM : UFFXESXPRCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly CFODDVOSBJL RECXQFUTSZW;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Rigidbody TSUTETVWVXT
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xCE7520", Offset = "0xCE6320", VA = "0x180CE7520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool VXAXYNFGLID
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0xA015E20", Offset = "0xA014C20", VA = "0x18A015E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool THMHIMFQJPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1B53450", Offset = "0x1B52250", VA = "0x181B53450", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA017540", Offset = "0xA016340", VA = "0x18A017540")]
		public KVDNUQUVYQM(XDKPDVFGOFK a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA016DA0", Offset = "0xA015BA0", VA = "0x18A016DA0", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA017170", Offset = "0xA015F70", VA = "0x18A017170", Slot = "7")]
		public void HEJFIFOXNLU(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xA0171A0", Offset = "0xA015FA0", VA = "0x18A0171A0", Slot = "8")]
		public void PDQFADQHMKZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA016E40", Offset = "0xA015C40", VA = "0x18A016E40", Slot = "9")]
		public void GIFZYXYUGIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA0171D0", Offset = "0xA015FD0", VA = "0x18A0171D0", Slot = "10")]
		public void RVOLMTMFXHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA0173C0", Offset = "0xA0161C0", VA = "0x18A0173C0", Slot = "11")]
		public void WUUCOHOVKYQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class BWSZGSAMRVJ : YBVLSZTJXGO, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly CGICJSTLYPF SOMLTKFETKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly CFODDVOSBJL TYEJUNLWXMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private float DSHCVNDGWOS;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public HDDJQUXOAWW KLJVFWSFIJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xCE7530", Offset = "0xCE6330", VA = "0x180CE7530", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public JNTLKZADWBL DBXPLMJHYAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xCED340", Offset = "0xCEC140", VA = "0x180CED340", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 NLMPJGSUZDG
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xA0092E0", Offset = "0xA0080E0", VA = "0x18A0092E0", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xA009140", Offset = "0xA007F40", VA = "0x18A009140", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 XPUTKDOVZZR
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xA006CA0", Offset = "0xA005AA0", VA = "0x18A006CA0", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0xA007820", Offset = "0xA006620", VA = "0x18A007820", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 QFJOPKMFEGA
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xA008370", Offset = "0xA007170", VA = "0x18A008370", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0xA008B10", Offset = "0xA007910", VA = "0x18A008B10", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 SKBHGFOYDNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0xA0079E0", Offset = "0xA0067E0", VA = "0x18A0079E0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xA008A20", Offset = "0xA007820", VA = "0x18A008A20", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float FOXHCFVUYTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xD4D5A0", Offset = "0xD4C3A0", VA = "0x180D4D5A0", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0xA008910", Offset = "0xA007710", VA = "0x18A008910", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool ETNHVNIQBZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x25D5980", Offset = "0x25D4780", VA = "0x1825D5980", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private SXCVSPRDTLW VIIEARTAJXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x9536EB0", Offset = "0x9535CB0", VA = "0x189536EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool HMOWTZNAXLK
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0xA009120", Offset = "0xA007F20", VA = "0x18A009120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA0094A0", Offset = "0xA0082A0", VA = "0x18A0094A0")]
		public BWSZGSAMRVJ(XDKPDVFGOFK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA0065D0", Offset = "0xA0053D0", VA = "0x18A0065D0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA006AC0", Offset = "0xA0058C0", VA = "0x18A006AC0", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA007850", Offset = "0xA006650", VA = "0x18A007850", Slot = "28")]
		public void JJNPVIZIWYQ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x18F9380", Offset = "0x18F8180", VA = "0x1818F9380", Slot = "20")]
		public void CEQZQIBUQEC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x18F8F10", Offset = "0x18F7D10", VA = "0x1818F8F10", Slot = "30")]
		public void CPUBGBNQCWV(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA008190", Offset = "0xA006F90", VA = "0x18A008190", Slot = "35")]
		public Vector3 OTBAGGXPLFQ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA006900", Offset = "0xA005700", VA = "0x18A006900", Slot = "34")]
		public Vector3 BWKMVMIGISA(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA0065D0", Offset = "0xA0053D0", VA = "0x18A0065D0", Slot = "27")]
		public void TRLIIBNVRMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA007980", Offset = "0xA006780", VA = "0x18A007980", Slot = "25")]
		public void KONNPWBFTAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA008AB0", Offset = "0xA0078B0", VA = "0x18A008AB0", Slot = "24")]
		public void SNEKHQMKOJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA0086D0", Offset = "0xA0074D0", VA = "0x18A0086D0", Slot = "33")]
		public void RGRXZTJGEJD(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA008A50", Offset = "0xA007850", VA = "0x18A008A50", Slot = "32")]
		public void SEZPMDFOUBO(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA008530", Offset = "0xA007330", VA = "0x18A008530", Slot = "31")]
		public void PEVFMJBEDZD(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA008BD0", Offset = "0xA0079D0", VA = "0x18A008BD0", Slot = "22")]
		public void UIGIYLQCWTL(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA006680", Offset = "0xA005480", VA = "0x18A006680", Slot = "21")]
		public void BFCSZEOCPGM(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA006FB0", Offset = "0xA005DB0", VA = "0x18A006FB0", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void GCXLIQGUSJJ(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x1A55730", Offset = "0x1A54530", VA = "0x181A55730")]
		private static void QDXVLIRARAB(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xA009200", Offset = "0xA008000", VA = "0x18A009200", Slot = "29")]
		public Vector3 YIWWEIZGLWS(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xA006E20", Offset = "0xA005C20", VA = "0x18A006E20", Slot = "26")]
		public void FVYSROMJIMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA008910", Offset = "0xA007710", VA = "0x18A008910")]
		private void RHCYFADFAUM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA007FF0", Offset = "0xA006DF0", VA = "0x18A007FF0")]
		private void NRPOEHPZQFQ(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA006B20", Offset = "0xA005920", VA = "0x18A006B20")]
		private Vector3 EHIJOWFUQJX()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA0073A0", Offset = "0xA0061A0", VA = "0x18A0073A0")]
		private void HBRZFKUKOJL(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA007690", Offset = "0xA006490", VA = "0x18A007690")]
		private Vector3 IDKSPSNPIXV()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA007B70", Offset = "0xA006970", VA = "0x18A007B70")]
		private void LMFJTOJSFPN(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		private void ROKTAZRVWQA(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		private void WRQDNTKCQRA()
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
