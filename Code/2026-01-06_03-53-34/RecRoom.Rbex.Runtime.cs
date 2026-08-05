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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE09F0", Offset = "0xADF3F0", VA = "0x180AE09F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AF67C0", Offset = "0x8AF51C0", VA = "0x188AF67C0", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		private int[] TVXWIVSLKTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset EJWMBZOWMVA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84ED650", Offset = "0x84EC050", VA = "0x1884ED650", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8B0A9B0", Offset = "0x8B093B0", VA = "0x188B0A9B0")]
		private void ANRTHLCVEKO(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AC90", Offset = "0x8B09690", VA = "0x188B0AC90", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8B0ACF0", Offset = "0x8B096F0", VA = "0x188B0ACF0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, MPIPBSKHYUA, POKLIYYXBNR, ZHZKZDOVLTT
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly Log ONQFICMHZCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool ZPUXGTJDXAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private FLAXIIDFDDM EJWMKRXNDKZ;

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
		private Transform ZUQVUONXFRJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal FLAXIIDFDDM RYIUERPQILX
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8AFADF0", Offset = "0x8AF97F0", VA = "0x188AFADF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private FLAXIIDFDDM PKABGVTPIKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int DINRXQBFBGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC630", Offset = "0x8AFB030", VA = "0x188AFC630")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx PRNLAKCNLLR
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC990", Offset = "0x8AFB390", VA = "0x188AFC990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx XQVYPEOBNLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC8D0", Offset = "0x8AFB2D0", VA = "0x188AFC8D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx HJMDDSQJNLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8AFD590", Offset = "0x8AFBF90", VA = "0x188AFD590")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8AFEA90", Offset = "0x8AFD490", VA = "0x188AFEA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7EF0890", Offset = "0x7EEF290", VA = "0x187EF0890", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7EF09E0", Offset = "0x7EEF3E0", VA = "0x187EF09E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform UPSIZUKXNNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2320600", Offset = "0x231F000", VA = "0x182320600", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform EBJRASNMZDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2320600", Offset = "0x231F000", VA = "0x182320600", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform SIWRJIGIFJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2320600", Offset = "0x231F000", VA = "0x182320600", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate UKACRFWZOII
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC690", Offset = "0x8AFB090", VA = "0x188AFC690")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE240", Offset = "0x8AFCC40", VA = "0x188AFE240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool KHFMOKTPUJX
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8AFCCA0", Offset = "0x8AFB6A0", VA = "0x188AFCCA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool EHUTLADODAR
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC7B0", Offset = "0x8AFB1B0", VA = "0x188AFC7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ZMTWMPCAWEU EWXOLEHLJQF
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8AFCBE0", Offset = "0x8AFB5E0", VA = "0x188AFCBE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE400", Offset = "0x8AFCE00", VA = "0x188AFE400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public RTQGHSHOPHZ XIHZDOJZUOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8AFCB80", Offset = "0x8AFB580", VA = "0x188AFCB80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE390", Offset = "0x8AFCD90", VA = "0x188AFE390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NYZKQSIKQLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8AFCAD0", Offset = "0x8AFB4D0", VA = "0x188AFCAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody BGOHCCWKOGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8AFCB30", Offset = "0x8AFB530", VA = "0x188AFCB30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool GTXRIZMIKHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC810", Offset = "0x8AFB210", VA = "0x188AFC810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE2B0", Offset = "0x8AFCCB0", VA = "0x188AFE2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool NSRENAIPNIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1704CA0", Offset = "0x17036A0", VA = "0x181704CA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float VLVJKAVEYOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8AFD530", Offset = "0x8AFBF30", VA = "0x188AFD530")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float UXMDYZHRZZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8AFD4D0", Offset = "0x8AFBED0", VA = "0x188AFD4D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8AFEA20", Offset = "0x8AFD420", VA = "0x188AFEA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float WBFXCEXZZOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8AFCF00", Offset = "0x8AFB900", VA = "0x188AFCF00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE6A0", Offset = "0x8AFD0A0", VA = "0x188AFE6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float NNUZUONMTUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8AFCD00", Offset = "0x8AFB700", VA = "0x188AFCD00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE470", Offset = "0x8AFCE70", VA = "0x188AFE470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool UJUPEWMEQFG
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8AFDAE0", Offset = "0x8AFC4E0", VA = "0x188AFDAE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8AFEFD0", Offset = "0x8AFD9D0", VA = "0x188AFEFD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 IXOIWQLMSDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8AFD2B0", Offset = "0x8AFBCB0", VA = "0x188AFD2B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE7F0", Offset = "0x8AFD1F0", VA = "0x188AFE7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 SCHKYTZGGQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8AFDC20", Offset = "0x8AFC620", VA = "0x188AFDC20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode FLHLRANLAXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8AFCE40", Offset = "0x8AFB840", VA = "0x188AFCE40")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE5C0", Offset = "0x8AFCFC0", VA = "0x188AFE5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float FNDQULDQCMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC870", Offset = "0x8AFB270", VA = "0x188AFC870")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE320", Offset = "0x8AFCD20", VA = "0x188AFE320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints TQLBXCJMYMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8AFCEA0", Offset = "0x8AFB8A0", VA = "0x188AFCEA0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE630", Offset = "0x8AFD030", VA = "0x188AFE630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 MEXSANLVTIH
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8AFD650", Offset = "0x8AFC050", VA = "0x188AFD650")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 MLJVIZDWRWB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8AFD650", Offset = "0x8AFC050", VA = "0x188AFD650")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8AFEDB0", Offset = "0x8AFD7B0", VA = "0x188AFEDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float PARXDQARUKA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8AFD390", Offset = "0x8AFBD90", VA = "0x188AFD390")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE8D0", Offset = "0x8AFD2D0", VA = "0x188AFE8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float MUPDKXEKOMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8AFDA80", Offset = "0x8AFC480", VA = "0x188AFDA80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8AFEF60", Offset = "0x8AFD960", VA = "0x188AFEF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion PLKGJBGDRKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8AFD730", Offset = "0x8AFC130", VA = "0x188AFD730")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8AFEB30", Offset = "0x8AFD530", VA = "0x188AFEB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion DZHTWOOGJSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8AFD9B0", Offset = "0x8AFC3B0", VA = "0x188AFD9B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8AFEE90", Offset = "0x8AFD890", VA = "0x188AFEE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 XGAGMLQUTDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8AFD800", Offset = "0x8AFC200", VA = "0x188AFD800")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8AFEC00", Offset = "0x8AFD600", VA = "0x188AFEC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion ZOUGKWJGLVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8AFD8E0", Offset = "0x8AFC2E0", VA = "0x188AFD8E0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8AFECE0", Offset = "0x8AFD6E0", VA = "0x188AFECE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 MNACKULGLVW
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8AFDB40", Offset = "0x8AFC540", VA = "0x188AFDB40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8AFF040", Offset = "0x8AFDA40", VA = "0x188AFF040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 XIKCFTARQQB
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8AFD3F0", Offset = "0x8AFBDF0", VA = "0x188AFD3F0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE940", Offset = "0x8AFD340", VA = "0x188AFE940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 UOSTQBKNYEY
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8AFCD60", Offset = "0x8AFB760", VA = "0x188AFCD60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE4E0", Offset = "0x8AFCEE0", VA = "0x188AFE4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 OIRKAXPXCGP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8AFD1D0", Offset = "0x8AFBBD0", VA = "0x188AFD1D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE710", Offset = "0x8AFD110", VA = "0x188AFE710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 SONKUUPZXDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8AFD090", Offset = "0x8AFBA90", VA = "0x188AFD090")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion MYGSEUVQQSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8AFCFC0", Offset = "0x8AFB9C0", VA = "0x188AFCFC0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 VDIINRGWDWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8AFDDE0", Offset = "0x8AFC7E0", VA = "0x188AFDDE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 BLMQXCBWAMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8AFDD00", Offset = "0x8AFC700", VA = "0x188AFDD00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DRAMGOHHWZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8AFD170", Offset = "0x8AFBB70", VA = "0x188AFD170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool RGJPKLDBPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8AFCC40", Offset = "0x8AFB640", VA = "0x188AFCC40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool VVHPMWWZGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC750", Offset = "0x8AFB150", VA = "0x188AFC750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool THYCZDLZSXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC6F0", Offset = "0x8AFB0F0", VA = "0x188AFC6F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool HONUZQFNXYW
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC5D0", Offset = "0x8AFAFD0", VA = "0x188AFC5D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool SRRLDUEWDYN
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8AFCF60", Offset = "0x8AFB960", VA = "0x188AFCF60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool BXPTSGXIQZR
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xB78C60", Offset = "0xB77660", VA = "0x180B78C60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction SSFHSTCASID
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC4F0", Offset = "0x8AFAEF0", VA = "0x188AFC4F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE160", Offset = "0x8AFCB60", VA = "0x188AFE160")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction TPHRZPYKYMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC260", Offset = "0x8AFAC60", VA = "0x188AFC260")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8AFDEC0", Offset = "0x8AFC8C0", VA = "0x188AFDEC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction BUHZDFMKFIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC2C0", Offset = "0x8AFACC0", VA = "0x188AFC2C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8AFDF30", Offset = "0x8AFC930", VA = "0x188AFDF30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction NIKMCVBLYZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC410", Offset = "0x8AFAE10", VA = "0x188AFC410")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE080", Offset = "0x8AFCA80", VA = "0x188AFE080")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> EHNWSTRYUOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC3A0", Offset = "0x8AFADA0", VA = "0x188AFC3A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE010", Offset = "0x8AFCA10", VA = "0x188AFE010")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction VUGQUZXYCYE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC480", Offset = "0x8AFAE80", VA = "0x188AFC480")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE0F0", Offset = "0x8AFCAF0", VA = "0x188AFE0F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction PLPEENWCYMG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC560", Offset = "0x8AFAF60", VA = "0x188AFC560")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8AFE1D0", Offset = "0x8AFCBD0", VA = "0x188AFE1D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction ITVOCFFSDDD
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC330", Offset = "0x8AFAD30", VA = "0x188AFC330")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8AFDFA0", Offset = "0x8AFC9A0", VA = "0x188AFDFA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340", Slot = "8")]
		private void RATARUKRYYH(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8AFAD60", Offset = "0x8AF9760", VA = "0x188AFAD60", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB270", Offset = "0x8AF9C70", VA = "0x188AFB270")]
		internal void PSVCXWXPMHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBF90", Offset = "0x8AFA990", VA = "0x188AFBF90")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8AFAAB0", Offset = "0x8AF94B0", VA = "0x188AFAAB0")]
		public MPIPBSKHYUA GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBBF0", Offset = "0x8AFA5F0", VA = "0x188AFBBF0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA570", Offset = "0x8AF8F70", VA = "0x188AFA570")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBE80", Offset = "0x8AFA880", VA = "0x188AFBE80")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8AFADF0", Offset = "0x8AF97F0", VA = "0x188AFADF0")]
		private FLAXIIDFDDM WGEIWVXVDOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA740", Offset = "0x8AF9140", VA = "0x188AFA740")]
		private void BDNHZJHRRDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB3C0", Offset = "0x8AF9DC0", VA = "0x188AFB3C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB300", Offset = "0x8AF9D00", VA = "0x188AFB300")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB270", Offset = "0x8AF9C70", VA = "0x188AFB270")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB360", Offset = "0x8AF9D60", VA = "0x188AFB360")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB420", Offset = "0x8AF9E20", VA = "0x188AFB420")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9B60", Offset = "0x8AF8560", VA = "0x188AF9B60")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB480", Offset = "0x8AF9E80", VA = "0x188AFB480")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8AFAA40", Offset = "0x8AF9440", VA = "0x188AFAA40")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB210", Offset = "0x8AF9C10", VA = "0x188AFB210")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBD50", Offset = "0x8AFA750", VA = "0x188AFBD50")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB790", Offset = "0x8AFA190", VA = "0x188AFB790")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8AFAEA0", Offset = "0x8AF98A0", VA = "0x188AFAEA0")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8AFAFA0", Offset = "0x8AF99A0", VA = "0x188AFAFA0")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9DD0", Offset = "0x8AF87D0", VA = "0x188AF9DD0")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB4F0", Offset = "0x8AF9EF0", VA = "0x188AFB4F0")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9E40", Offset = "0x8AF8840", VA = "0x188AF9E40")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB560", Offset = "0x8AF9F60", VA = "0x188AFB560")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBCD0", Offset = "0x8AFA6D0", VA = "0x188AFBCD0")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBAF0", Offset = "0x8AFA4F0", VA = "0x188AFBAF0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB9F0", Offset = "0x8AFA3F0", VA = "0x188AFB9F0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8AFAC50", Offset = "0x8AF9650", VA = "0x188AFAC50")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8AFAB40", Offset = "0x8AF9540", VA = "0x188AFAB40")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9CE0", Offset = "0x8AF86E0", VA = "0x188AF9CE0")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9BD0", Offset = "0x8AF85D0", VA = "0x188AF9BD0")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA010", Offset = "0x8AF8A10", VA = "0x188AFA010")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9EB0", Offset = "0x8AF88B0", VA = "0x188AF9EB0")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC060", Offset = "0x8AFAA60", VA = "0x188AFC060")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB100", Offset = "0x8AF9B00", VA = "0x188AFB100")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA9E0", Offset = "0x8AF93E0", VA = "0x188AFA9E0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA980", Offset = "0x8AF9380", VA = "0x188AFA980")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA920", Offset = "0x8AF9320", VA = "0x188AFA920")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA8C0", Offset = "0x8AF92C0", VA = "0x188AFA8C0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB8F0", Offset = "0x8AFA2F0", VA = "0x188AFB8F0")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB7F0", Offset = "0x8AFA1F0", VA = "0x188AFB7F0")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB6B0", Offset = "0x8AFA0B0", VA = "0x188AFB6B0")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBE90", Offset = "0x8AFA890", VA = "0x188AFBE90")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB0A0", Offset = "0x8AF9AA0", VA = "0x188AFB0A0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBE20", Offset = "0x8AFA820", VA = "0x188AFBE20")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC000", Offset = "0x8AFAA00", VA = "0x188AFC000")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9FA0", Offset = "0x8AF89A0", VA = "0x188AF9FA0")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB5D0", Offset = "0x8AF9FD0", VA = "0x188AFB5D0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA3A0", Offset = "0x8AF8DA0", VA = "0x188AFA3A0")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA2A0", Offset = "0x8AF8CA0", VA = "0x188AFA2A0")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA460", Offset = "0x8AF8E60", VA = "0x188AFA460")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA1D0", Offset = "0x8AF8BD0", VA = "0x188AFA1D0")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8AFA100", Offset = "0x8AF8B00", VA = "0x188AFA100")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8AFB640", Offset = "0x8AFA040", VA = "0x188AFB640")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8AFAAA0", Offset = "0x8AF94A0", VA = "0x188AFAAA0", Slot = "13")]
		private void GBFJPAATHLO(WQKTEDFFTLA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC1F0", Offset = "0x8AFABF0", VA = "0x188AFC1F0")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x122FFB0", Offset = "0x122E9B0", VA = "0x18122FFB0", Slot = "4")]
		private GameObject KGPSGMEOCQH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAE21E0", Offset = "0xAE0BE0", VA = "0x180AE21E0", Slot = "10")]
		private bool DRKPYICDKEI()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class IGLVXCQXUAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5090", Offset = "0x8AF3A90", VA = "0x188AF5090")]
		public static FLAXIIDFDDM RYIUERPQILX(this RigidbodyEx a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(LVGTUOGKEEX), new string[] { })]
	public class RigidbodyExManager : LVGTUOGKEEX, IPQERUQWVJD
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private JEFTMLWGVDG EMVJUYYRCBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LKKROKFZAWP JHODQKWTNEL;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public JEFTMLWGVDG BJCBYCQOIKZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public LKKROKFZAWP UEIEJSDGUZF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9A70", Offset = "0x8AF8470", VA = "0x188AF9A70", Slot = "7")]
		public void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8AF98A0", Offset = "0x8AF82A0", VA = "0x188AF98A0", Slot = "6")]
		public FLAXIIDFDDM EIXMERDYXEB(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static MWKYWAOJZRV UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int KEYLGSXASLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int UCIBGZBHFBJ;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7860", Offset = "0x8AF6260", VA = "0x188AF7860")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8AF78E0", Offset = "0x8AF62E0", VA = "0x188AF78E0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7880", Offset = "0x8AF6280", VA = "0x188AF7880")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8AF79D0", Offset = "0x8AF63D0", VA = "0x188AF79D0")]
		public PhysicsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class CTMQASHVLNZ
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class AHBOTGTGLEL : ZMTWMPCAWEU, IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAC62D0", Offset = "0xAC4CD0", VA = "0x180AC62D0", Slot = "4")]
			public Vector3 PEGDFRBXTAK()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAC62D0", Offset = "0xAC4CD0", VA = "0x180AC62D0", Slot = "5")]
			public Vector3 IHVZXTDRDNH()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0", Slot = "6")]
			public bool XASGAWYFNAQ(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public AHBOTGTGLEL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static ZMTWMPCAWEU FUULMSDNKLE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8AF2860", Offset = "0x8AF1260", VA = "0x188AF2860")]
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
	public interface YPRXVLQAWAI
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		CollisionDetectionMode UWKYBWBMPLV
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
		void LGTBLRGOYZX(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void ZZDMRWJOTIQ(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void MYVGUYFYLGS(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool JYAJLSHIFHT(Vector3 a, [Out] RaycastHit b, float c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface OFAILNGDQYV : IDisposable, JCEANAOEZKB
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		TransformTrackRate UKACRFWZOII
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action<UpdateLOD, UpdateLOD> EHNWSTRYUOF;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[ServiceLifetime(Lifetime.Application)]
	public interface LKKROKFZAWP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		KCMFVCQXRWS AGKELJEYDWO(FLAXIIDFDDM a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ADQTVWKPJFC GHHNEVLNTRW(FLAXIIDFDDM a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TKDKXZQKCER QWJAEOHOEJL(FLAXIIDFDDM a);

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		BJLDBBWNAOS CNJNSJGHUZQ(FLAXIIDFDDM a);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IMTJMUAGWWG NZIASXSWIHA(FLAXIIDFDDM a);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		OFAILNGDQYV TVVWQAKQNCB(FLAXIIDFDDM a);

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		LTSLVRFELFC QMSBCYLSWCY(FLAXIIDFDDM a);

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		SEUTCTARQZA CDIIVCWKQEW(FLAXIIDFDDM a);

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		YPRXVLQAWAI FWKSLCZEVXS(FLAXIIDFDDM a);

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		CXWEJHDDATZ TUNQPXTMRDZ(FLAXIIDFDDM a);

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		GSTISZZNMWT NSHNSFRDTNF(FLAXIIDFDDM a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		YXGCDGIWJWJ IRISATZYHZP(FLAXIIDFDDM a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "12")]
		OHVJDROOUGD YWLDUFFCHOL(FLAXIIDFDDM a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "13")]
		YETDUGNTKHL RUGBDILHSOR(FLAXIIDFDDM a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		ZBZZLINQTMF BZLMIMVZUUV(FLAXIIDFDDM a, [In] RigidbodyExData data);

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		FLAXIIDFDDM EIXMERDYXEB(RigidbodyEx a, RigidbodyExData b, LVGTUOGKEEX c);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface SEUTCTARQZA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FYMUGNLOQGB(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FAHMGMBFGJJ(Vector3 a, Vector3 b, ForceMode c);

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ORBAMLWUUBS(Vector3 a, ForceMode b = ForceMode.Force);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LEUZHWFIWEU(Vector3 a, ForceMode b = ForceMode.Force);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface CXWEJHDDATZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool KYJNNQJYWLC
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
		void MYVGUYFYLGS(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LEEORNZPXDZ(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface KCMFVCQXRWS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		IReadOnlyList<FLAXIIDFDDM> POFFWQKAIPZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		FLAXIIDFDDM XQVYPEOBNLV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		FLAXIIDFDDM KYXHYZREABR
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event RbexAction TPHRZPYKYMX;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event RbexAction BUHZDFMKFIV;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event RbexParentChangeAction BOMWDECCPLX;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action WWNVFWCCRLS;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action WKXUIJHWHSV;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<FLAXIIDFDDM> UJNELIJHYQA;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<FLAXIIDFDDM> MQCMUSECIZF;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action NPBZNEWFXSU;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<FLAXIIDFDDM> KSZMLQJGEJD;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void SetParent(FLAXIIDFDDM newParent, bool isPhysicallyDetachedOnly = false);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface TKDKXZQKCER
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		Vector3 JIEBZKHYMFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Vector3 JZAYFVJXHHW
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ULVFIXJDPVQ(FLAXIIDFDDM a, object b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XUZZTJUGMUX(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface YETDUGNTKHL
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		Vector3 WBMMJBJGBHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Vector3 BODXQJLKRUB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float JTOZPLOYRVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		float NNIRLUFQVOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		Vector3 BWAHXXTTQNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		Quaternion OEVTXFXHXNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event RbexAction QBJCGGCHEAR;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void DJVGOIHFCUE((Quaternion rot, Vector3 moments) tensor);

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void XVKONZDITXB();

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void BWIMOVRHZTG();

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void KHMNBOKGZJY();

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void MYVGUYFYLGS(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void LEEORNZPXDZ(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void OnDrawGizmosSelected();
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface OHVJDROOUGD
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KAIOZASSZTW(object a);

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TPBJKNPKSIL(object a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XWEWTTBCNOD(FLAXIIDFDDM a);

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void YNAATAGMNHI(FLAXIIDFDDM a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void XJJWUULXQRB();
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface LTSLVRFELFC
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool PSMKSNHRWPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event RbexAction SOFVDXQITKE;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EHRMZIGLHUP(object a);

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PTXZWXHRDJK(object a);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZWMPMWMKJUO(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void MYVGUYFYLGS(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void LEEORNZPXDZ(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface YXGCDGIWJWJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool KHFMOKTPUJX
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool EHUTLADODAR
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event RbexAction CCLOKUJHAJY;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GMLMPTPRJDD(FLAXIIDFDDM a);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void MMRWLDTBIUN(FLAXIIDFDDM a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface ZBZZLINQTMF
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool GTXRIZMIKHU
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool IZVNTIZYRSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		RigidbodyConstraints VHDDUGYFSQJ
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
		void MYVGUYFYLGS(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void LEEORNZPXDZ(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface BJLDBBWNAOS
	{
		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		float KIZNHPRTSWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		float KPDYGHQRDQJ
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
		void MYVGUYFYLGS(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LEEORNZPXDZ(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface IMTJMUAGWWG
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		static bool RKKTQTEIPQW;

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event RbexAction OTUPUUBHMDM;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Awake();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool VZRYQKTJZDM();

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DUDNTVVQNOY();

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Sleep();

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool WLGTIHGCVPE();

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool CGJURPXSKBZ();

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void CXFMMMVEQTX(bool a);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void CSIVDQEXQWC();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface GSTISZZNMWT
	{
		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		Rigidbody BGOHCCWKOGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool GZBCAOAWTCC
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
		void GJPYSWLQTCE(object a);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void KVFFGSXRTDB(object a);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AMVTNASUVAK();
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface ADQTVWKPJFC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		ZMTWMPCAWEU EWXOLEHLJQF
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		RTQGHSHOPHZ XIHZDOJZUOU
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		Vector3 FITKFMCGXGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		Vector3 WBDPTOWQUSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		Vector3 IGQBUSPCNOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Vector3 GHLUXTSNDMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		float FNDQULDQCMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool NYZKQSIKQLI
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
		void LWDNNATHMNS(object a);

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void RJBOBMTNCPE(RbexRotationType a, Vector3 b, float c = 1f / 0f);

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void ZNUBIDZFUEL(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f);

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void GMGTXVVWBAV(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void KRGSPSWJWCF();

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void GOUKBDOZGZQ();

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void XKQXRAVLLDF();

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void WDLTQJCFAFN();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void MYVGUYFYLGS(Rigidbody a);

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "25")]
		Vector3 YGKWEEYFHPK(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void OLZDBQUXTQP(object a);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void LRKHYJRZYNR(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void BGBOOAVERTQ(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void CZIRHLUKVQH(Vector3 a, Vector3 b);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "30")]
		Vector3 ELLRGFOLSLU(Vector3 a);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Vector3 NIOYPYEQKWQ(Vector3 a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ServiceLifetime(Lifetime.Application)]
	public interface JEFTMLWGVDG
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool RBHLGKKAXZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NUUBEEEAVSZ(string a);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HUGYLVCUBGA(RigidbodyEx a, Action b);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		EDWMDUTPURO NIKUZKHDXKP(int a);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NKRCTXWMZYR(Vector3 a, float b, Color c);
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[ServiceLifetime(Lifetime.Application)]
	public interface LVGTUOGKEEX
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		JEFTMLWGVDG BJCBYCQOIKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		LKKROKFZAWP UEIEJSDGUZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "2")]
		FLAXIIDFDDM EIXMERDYXEB(RigidbodyEx a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class TMFOVSNWHWZ : FLAXIIDFDDM, IDisposable, HHKVZSHDDXX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal readonly LVGTUOGKEEX VTSSGIVZARQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal KCMFVCQXRWS YIPPOBOVVZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal OHVJDROOUGD SWYVWBKPNKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		internal YXGCDGIWJWJ MCJOHRRECNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal ADQTVWKPJFC MNACKULGLVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		internal TKDKXZQKCER XSLIBUEIRIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal YETDUGNTKHL DPFGREJBCWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal BJLDBBWNAOS CSZIUAWIZWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal CXWEJHDDATZ CRWFXVYNCZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		internal IMTJMUAGWWG KHUFFGRXKPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		internal OFAILNGDQYV AKTZITFWPKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		internal LTSLVRFELFC EUKMNMCQAVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		internal SEUTCTARQZA MJUNYQQAYTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		internal ZBZZLINQTMF SCFAUZOFRNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		internal GSTISZZNMWT WARAMAVSWML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal YPRXVLQAWAI FRKRAVBPWRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		internal IDisposable WYYCYTEDWVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private bool LQPNYXXTJDV;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public ObjectLocalId CEFGVHVDNXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public MPIPBSKHYUA WDUYFRVXQCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xBC9B00", Offset = "0xBC8500", VA = "0x180BC9B00", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xBC8BF0", Offset = "0xBC75F0", VA = "0x180BC8BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject GQVQNJZVHPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xAC0C50", Offset = "0xABF650", VA = "0x180AC0C50", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAC0C10", Offset = "0xABF610", VA = "0x180AC0C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform YTQQQFYHIEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xC4EB80", Offset = "0xC4D580", VA = "0x180C4EB80", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xD27500", Offset = "0xD25F00", VA = "0x180D27500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody BGOHCCWKOGX
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x8B04430", Offset = "0x8B02E30", VA = "0x188B04430", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public FLAXIIDFDDM KYXHYZREABR
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8B02900", Offset = "0x8B01300", VA = "0x188B02900", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8B05A30", Offset = "0x8B04430", VA = "0x188B05A30", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int DINRXQBFBGC
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8B01780", Offset = "0x8B00180", VA = "0x188B01780", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public FLAXIIDFDDM XQVYPEOBNLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8B03AD0", Offset = "0x8B024D0", VA = "0x188B03AD0", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool MDJGMOLRPTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8B013C0", Offset = "0x8AFFDC0", VA = "0x188B013C0", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool KHFMOKTPUJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8B058D0", Offset = "0x8B042D0", VA = "0x188B058D0", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool EHUTLADODAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8B02520", Offset = "0x8B00F20", VA = "0x188B02520", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public ZMTWMPCAWEU EWXOLEHLJQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8B02C50", Offset = "0x8B01650", VA = "0x188B02C50", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8B03CA0", Offset = "0x8B026A0", VA = "0x188B03CA0", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public RTQGHSHOPHZ XIHZDOJZUOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8AFF860", Offset = "0x8AFE260", VA = "0x188AFF860", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8B00C20", Offset = "0x8AFF620", VA = "0x188B00C20", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float FNDQULDQCMQ
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8B018A0", Offset = "0x8B002A0", VA = "0x188B018A0", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8B04920", Offset = "0x8B03320", VA = "0x188B04920", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 WBDPTOWQUSF
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8B02B70", Offset = "0x8B01570", VA = "0x188B02B70", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8B04EA0", Offset = "0x8B038A0", VA = "0x188B04EA0", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 GHLUXTSNDMP
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8B034F0", Offset = "0x8B01EF0", VA = "0x188B034F0", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8B04480", Offset = "0x8B02E80", VA = "0x188B04480", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 FITKFMCGXGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8B029B0", Offset = "0x8B013B0", VA = "0x188B029B0", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8B04840", Offset = "0x8B03240", VA = "0x188B04840", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 IGQBUSPCNOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8B01CE0", Offset = "0x8B006E0", VA = "0x188B01CE0", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x8AFF780", Offset = "0x8AFE180", VA = "0x188AFF780", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool VVHPMWWZGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8B05880", Offset = "0x8B04280", VA = "0x188B05880", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool THYCZDLZSXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8B05280", Offset = "0x8B03C80", VA = "0x188B05280", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool HONUZQFNXYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x8B00300", Offset = "0x8AFED00", VA = "0x188B00300", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool NYZKQSIKQLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8B01650", Offset = "0x8B00050", VA = "0x188B01650", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 JIEBZKHYMFC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x8B018F0", Offset = "0x8B002F0", VA = "0x188B018F0", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 JZAYFVJXHHW
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x8B016A0", Offset = "0x8B000A0", VA = "0x188B016A0", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 WBMMJBJGBHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x8B04D70", Offset = "0x8B03770", VA = "0x188B04D70", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8B03B80", Offset = "0x8B02580", VA = "0x188B03B80", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 BODXQJLKRUB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8B03EC0", Offset = "0x8B028C0", VA = "0x188B03EC0", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float JTOZPLOYRVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8B00DE0", Offset = "0x8AFF7E0", VA = "0x188B00DE0", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float NNIRLUFQVOE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8B007B0", Offset = "0x8AFF1B0", VA = "0x188B007B0", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8AFF910", Offset = "0x8AFE310", VA = "0x188AFF910", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 BWAHXXTTQNA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8B02FD0", Offset = "0x8B019D0", VA = "0x188B02FD0", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion OEVTXFXHXNS
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8B04730", Offset = "0x8B03130", VA = "0x188B04730", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float KIZNHPRTSWF
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x8B04B50", Offset = "0x8B03550", VA = "0x188B04B50", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8B00B60", Offset = "0x8AFF560", VA = "0x188B00B60", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float KPDYGHQRDQJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x8B05C10", Offset = "0x8B04610", VA = "0x188B05C10", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x8B05920", Offset = "0x8B04320", VA = "0x188B05920", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool KYJNNQJYWLC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x8B02E80", Offset = "0x8B01880", VA = "0x188B02E80", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x8B02E20", Offset = "0x8B01820", VA = "0x188B02E20", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate UKACRFWZOII
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x8B05B50", Offset = "0x8B04550", VA = "0x188B05B50", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x8B04BA0", Offset = "0x8B035A0", VA = "0x188B04BA0", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool PSMKSNHRWPK
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8B00C80", Offset = "0x8AFF680", VA = "0x188B00C80", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform SIWRJIGIFJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xC4EB80", Offset = "0xC4D580", VA = "0x180C4EB80", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 QMBEDJTHAPA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x8B02670", Offset = "0x8B01070", VA = "0x188B02670", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x8B02D70", Offset = "0x8B01770", VA = "0x188B02D70", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float DFKTCQSGONC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x8B051C0", Offset = "0x8B03BC0", VA = "0x188B051C0", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8B04C60", Offset = "0x8B03660", VA = "0x188B04C60", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float KGIUASCOKEX
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x8B050F0", Offset = "0x8B03AF0", VA = "0x188B050F0", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x8AFFDC0", Offset = "0x8AFE7C0", VA = "0x188AFFDC0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion OZAVPLTBBCL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x8B020C0", Offset = "0x8B00AC0", VA = "0x188B020C0", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x8B004C0", Offset = "0x8AFEEC0", VA = "0x188B004C0", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 YDDTOFVMNHD
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8B03C60", Offset = "0x8B02660", VA = "0x188B03C60", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x8B01320", Offset = "0x8AFFD20", VA = "0x188B01320", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion HKVUIACYTTW
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8B043F0", Offset = "0x8B02DF0", VA = "0x188B043F0", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8B03D90", Offset = "0x8B02790", VA = "0x188B03D90", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints VHDDUGYFSQJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8B045C0", Offset = "0x8B02FC0", VA = "0x188B045C0", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x8B00BC0", Offset = "0x8AFF5C0", VA = "0x188B00BC0", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool GTXRIZMIKHU
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8B03690", Offset = "0x8B02090", VA = "0x188B03690", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8B011E0", Offset = "0x8AFFBE0", VA = "0x188B011E0", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode UWKYBWBMPLV
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x8B00760", Offset = "0x8AFF160", VA = "0x188B00760", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8B02060", Offset = "0x8B00A60", VA = "0x188B02060", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool GBCQTREPYTA
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8B040A0", Offset = "0x8B02AA0", VA = "0x188B040A0", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool RGJPKLDBPPH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x8B01EE0", Offset = "0x8B008E0", VA = "0x188B01EE0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction TPHRZPYKYMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8B017F0", Offset = "0x8B001F0", VA = "0x188B017F0", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8B04560", Offset = "0x8B02F60", VA = "0x188B04560", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction BUHZDFMKFIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8B05030", Offset = "0x8B03A30", VA = "0x188B05030", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8B046D0", Offset = "0x8B030D0", VA = "0x188B046D0", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction BOMWDECCPLX
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8B04F80", Offset = "0x8B03980", VA = "0x188B04F80", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8B04390", Offset = "0x8B02D90", VA = "0x188B04390", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction CCLOKUJHAJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8B04AF0", Offset = "0x8B034F0", VA = "0x188B04AF0", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8B04A90", Offset = "0x8B03490", VA = "0x188B04A90", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction NIKMCVBLYZB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x8B05220", Offset = "0x8B03C20", VA = "0x188B05220", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x8B024C0", Offset = "0x8B00EC0", VA = "0x188B024C0", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction OTUPUUBHMDM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8AFF8B0", Offset = "0x8AFE2B0", VA = "0x188AFF8B0", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8B00600", Offset = "0x8AFF000", VA = "0x188B00600", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> EHNWSTRYUOF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x8B04C00", Offset = "0x8B03600", VA = "0x188B04C00", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x8AFF720", Offset = "0x8AFE120", VA = "0x188AFF720", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction SOFVDXQITKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8B00E30", Offset = "0x8AFF830", VA = "0x188B00E30", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x8B005A0", Offset = "0x8AFEFA0", VA = "0x188B005A0", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction ITVOCFFSDDD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x8B02340", Offset = "0x8B00D40", VA = "0x188B02340", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x8AFFBA0", Offset = "0x8AFE5A0", VA = "0x188AFFBA0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8B05DD0", Offset = "0x8B047D0", VA = "0x188B05DD0")]
		public TMFOVSNWHWZ(GameObject a, RigidbodyEx b, LVGTUOGKEEX c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8B052E0", Offset = "0x8B03CE0", VA = "0x188B052E0", Slot = "139")]
		protected virtual void YDKCNNDQEKT(LVGTUOGKEEX a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8B00660", Offset = "0x8AFF060", VA = "0x188B00660", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8AFF970", Offset = "0x8AFE370", VA = "0x188AFF970", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8B03A40", Offset = "0x8B02440", VA = "0x188B03A40", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8B03990", Offset = "0x8B02390", VA = "0x188B03990", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8B03970", Offset = "0x8B02370", VA = "0x188B03970", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8AFFF90", Offset = "0x8AFE990", VA = "0x188AFFF90")]
		private void CXFMMMVEQTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8B04CF0", Offset = "0x8B036F0", VA = "0x188B04CF0")]
		private void VSZCNDHGSXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8AFFEC0", Offset = "0x8AFE8C0", VA = "0x188AFFEC0")]
		private void CGJURPXSKBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8B036E0", Offset = "0x8B020E0", VA = "0x188B036E0", Slot = "30")]
		public FLAXIIDFDDM OORXWWIMDMR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8B04610", Offset = "0x8B03010", VA = "0x188B04610", Slot = "98")]
		public void SetParent(FLAXIIDFDDM value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8B05090", Offset = "0x8B03A90", VA = "0x188B05090", Slot = "99")]
		public void WKZFPRWTMYK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8B03630", Offset = "0x8B02030", VA = "0x188B03630", Slot = "100")]
		public void OAPHFDHNVUZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8B02ED0", Offset = "0x8B018D0", VA = "0x188B02ED0", Slot = "101")]
		public Vector3 NIOYPYEQKWQ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8B00A60", Offset = "0x8AFF460", VA = "0x188B00A60", Slot = "102")]
		public Vector3 ELLRGFOLSLU(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8B04FE0", Offset = "0x8B039E0", VA = "0x188B04FE0", Slot = "103")]
		public void WDLTQJCFAFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8B01600", Offset = "0x8B00000", VA = "0x188B01600", Slot = "104")]
		public void GOUKBDOZGZQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8B02770", Offset = "0x8B01170", VA = "0x188B02770", Slot = "105")]
		public void KRGSPSWJWCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8B00210", Offset = "0x8AFEC10", VA = "0x188B00210", Slot = "106")]
		public void CZIRHLUKVQH(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8AFFAB0", Offset = "0x8AFE4B0", VA = "0x188AFFAB0", Slot = "107")]
		public void BGBOOAVERTQ(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8B02A90", Offset = "0x8B01490", VA = "0x188B02A90", Slot = "108")]
		public void LRKHYJRZYNR(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8B05A90", Offset = "0x8B04490", VA = "0x188B05A90", Slot = "109")]
		public void ZNUBIDZFUEL(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8B03DC0", Offset = "0x8B027C0", VA = "0x188B03DC0", Slot = "110")]
		public void RJBOBMTNCPE(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8B01420", Offset = "0x8AFFE20", VA = "0x188B01420", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void GMGTXVVWBAV(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8B05780", Offset = "0x8B04180", VA = "0x188B05780", Slot = "112")]
		public Vector3 YGKWEEYFHPK(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B03FA0", Offset = "0x8B029A0", VA = "0x188B03FA0", Slot = "113")]
		public Vector3 RLOSZECUKFO(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8B05170", Offset = "0x8B03B70", VA = "0x188B05170", Slot = "114")]
		public void XKQXRAVLLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8B05100", Offset = "0x8B03B00", VA = "0x188B05100", Slot = "115")]
		public void WSQQGLUCVKP(FLAXIIDFDDM a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8B04330", Offset = "0x8B02D30", VA = "0x188B04330", Slot = "116")]
		public void SBAFROQWRGY(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B003E0", Offset = "0x8AFEDE0", VA = "0x188B003E0", Slot = "63")]
		public void DJVGOIHFCUE((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8AFFD70", Offset = "0x8AFE770", VA = "0x188AFFD70", Slot = "117")]
		public void BWIMOVRHZTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B051D0", Offset = "0x8B03BD0", VA = "0x188B051D0", Slot = "118")]
		public void XVKONZDITXB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B02720", Offset = "0x8B01120", VA = "0x188B02720", Slot = "119")]
		public void KHMNBOKGZJY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B04E50", Offset = "0x8B03850", VA = "0x188B04E50", Slot = "120")]
		public bool VZRYQKTJZDM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8B04680", Offset = "0x8B03080", VA = "0x188B04680", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8AFFF20", Offset = "0x8AFE920", VA = "0x188AFFF20", Slot = "121")]
		public void CSIVDQEXQWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8B00A00", Offset = "0x8AFF400", VA = "0x188B00A00", Slot = "122")]
		public void EHRMZIGLHUP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B03B20", Offset = "0x8B02520", VA = "0x188B03B20", Slot = "123")]
		public void PTXZWXHRDJK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B05BA0", Offset = "0x8B045A0", VA = "0x188B05BA0", Slot = "124")]
		public void ZWMPMWMKJUO(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8B00800", Offset = "0x8AFF200", VA = "0x188B00800", Slot = "125")]
		public void EHFYBMOAIES(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8B03840", Offset = "0x8B02240", VA = "0x188B03840", Slot = "126")]
		public void OXMDDROJNKK(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8B01850", Offset = "0x8B00250", VA = "0x188B01850", Slot = "127")]
		public bool HPJZVLREOYZ(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8B035D0", Offset = "0x8B01FD0", VA = "0x188B035D0", Slot = "128")]
		public void NSPEYYRNIAS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8B02950", Offset = "0x8B01350", VA = "0x188B02950", Slot = "129")]
		public void LKKPBETUOBJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8B01360", Offset = "0x8AFFD60", VA = "0x188B01360", Slot = "130")]
		public void GJPYSWLQTCE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B027C0", Offset = "0x8B011C0", VA = "0x188B027C0", Slot = "131")]
		public void KVFFGSXRTDB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8B01240", Offset = "0x8AFFC40", VA = "0x188B01240", Slot = "132")]
		public void FYMUGNLOQGB(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8B00CD0", Offset = "0x8AFF6D0", VA = "0x188B00CD0", Slot = "133")]
		public void FAHMGMBFGJJ(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8B03760", Offset = "0x8B02160", VA = "0x188B03760", Slot = "134")]
		public void ORBAMLWUUBS(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B02820", Offset = "0x8B01220", VA = "0x188B02820", Slot = "135")]
		public void LEUZHWFIWEU(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B02570", Offset = "0x8B00F70", VA = "0x188B02570", Slot = "136")]
		public bool JYAJLSHIFHT(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8B039F0", Offset = "0x8B023F0", VA = "0x188B039F0", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8B04800", Offset = "0x8B03200", VA = "0x188B04800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8B023F0", Offset = "0x8B00DF0", VA = "0x188B023F0")]
		private void JHSJIJJYFWD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8B04980", Offset = "0x8B03380", VA = "0x188B04980")]
		private void URWLYLASINP(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8B02160", Offset = "0x8B00B60", VA = "0x188B02160")]
		private void IZYZCTKGHDA(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8B05980", Offset = "0x8B04380", VA = "0x188B05980")]
		private void ZKLLSDRBKDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8AFFC50", Offset = "0x8AFE650", VA = "0x188AFFC50")]
		private void BVRRWFXEDOQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8B055D0", Offset = "0x8B03FD0", VA = "0x188B055D0")]
		private void YGKGGDYZMNU(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8B01530", Offset = "0x8AFFF30", VA = "0x188B01530")]
		private void GMLMPTPRJDD(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B02CA0", Offset = "0x8B016A0", VA = "0x188B02CA0")]
		private void MMRWLDTBIUN(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8B041E0", Offset = "0x8B02BE0", VA = "0x188B041E0")]
		private void RXDFCKOMKTC(MPIPBSKHYUA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8B030B0", Offset = "0x8B01AB0", VA = "0x188B030B0", Slot = "142")]
		protected virtual void NLRBFCGOFCF(MPIPBSKHYUA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8B019C0", Offset = "0x8B003C0", VA = "0x188B019C0")]
		protected void IBQGSYWTTEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8B00E90", Offset = "0x8AFF890", VA = "0x188B00E90")]
		protected void FOHMUILLKIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8B01DC0", Offset = "0x8B007C0", VA = "0x188B01DC0")]
		private void IMBCTFITRWF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8B05C60", Offset = "0x8B04660", VA = "0x188B05C60")]
		private void ZXJZNPUHDKQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class CXJAAGTVQRF
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2A80", Offset = "0x8AF1480", VA = "0x188AF2A80")]
		public static FLAXIIDFDDM NVABNPJHAGQ(this FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2B40", Offset = "0x8AF1540", VA = "0x188AF2B40")]
		public static bool WXPRPKYFALN(this FLAXIIDFDDM a, FLAXIIDFDDM b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8AF29E0", Offset = "0x8AF13E0", VA = "0x188AF29E0")]
		public static bool NSYVWGVSOAN(this FLAXIIDFDDM a, FLAXIIDFDDM b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2990", Offset = "0x8AF1390", VA = "0x188AF2990")]
		public static MPIPBSKHYUA GPAQUCNVSLX(this FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2920", Offset = "0x8AF1320", VA = "0x188AF2920")]
		public static TMFOVSNWHWZ Base(this FLAXIIDFDDM impl)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class WDSDLHDRQBO : LKKROKFZAWP
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8B06F70", Offset = "0x8B05970", VA = "0x188B06F70", Slot = "19")]
		public FLAXIIDFDDM EIXMERDYXEB(RigidbodyEx a, RigidbodyExData b, LVGTUOGKEEX c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "4")]
		public KCMFVCQXRWS AGKELJEYDWO(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "5")]
		public ADQTVWKPJFC GHHNEVLNTRW(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "6")]
		public TKDKXZQKCER QWJAEOHOEJL(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "7")]
		public BJLDBBWNAOS CNJNSJGHUZQ(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "8")]
		public IMTJMUAGWWG NZIASXSWIHA(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "9")]
		public OFAILNGDQYV TVVWQAKQNCB(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "10")]
		public LTSLVRFELFC QMSBCYLSWCY(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "11")]
		public SEUTCTARQZA CDIIVCWKQEW(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "12")]
		public YPRXVLQAWAI FWKSLCZEVXS(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "13")]
		public CXWEJHDDATZ TUNQPXTMRDZ(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980")]
		public GSTISZZNMWT NSHNSFRDTNF(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980")]
		public YXGCDGIWJWJ IRISATZYHZP(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980")]
		public OHVJDROOUGD YWLDUFFCHOL(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980")]
		public YETDUGNTKHL RUGBDILHSOR(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980")]
		public ZBZZLINQTMF BZLMIMVZUUV(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public WDSDLHDRQBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "14")]
		private GSTISZZNMWT EQOAJOXWDGP(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "15")]
		private YXGCDGIWJWJ FWNGOTWDJMF(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "16")]
		private OHVJDROOUGD HNOKAZSOIZF(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "17")]
		private YETDUGNTKHL LKUNRPMVPQN(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAB6980", Offset = "0xAB5380", VA = "0x180AB6980", Slot = "18")]
		private ZBZZLINQTMF UFSLGFPFSNH(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(LKKROKFZAWP), new string[] { })]
	public class GTETPMZYZEZ : LKKROKFZAWP, IPQERUQWVJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly LKKROKFZAWP OSQSTOAKQAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly LKKROKFZAWP MUZNPQMTXOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private OGFUVDETSHZ VNKEUZDKHZI;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private LKKROKFZAWP UEIEJSDGUZF
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x8AF3FF0", Offset = "0x8AF29F0", VA = "0x188AF3FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF44F0", Offset = "0x8AF2EF0", VA = "0x188AF44F0", Slot = "20")]
		public void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3D60", Offset = "0x8AF2760", VA = "0x188AF3D60", Slot = "4")]
		public KCMFVCQXRWS AGKELJEYDWO(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8AF43A0", Offset = "0x8AF2DA0", VA = "0x188AF43A0", Slot = "5")]
		public ADQTVWKPJFC GHHNEVLNTRW(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4730", Offset = "0x8AF3130", VA = "0x188AF4730", Slot = "6")]
		public TKDKXZQKCER QWJAEOHOEJL(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3F50", Offset = "0x8AF2950", VA = "0x188AF3F50", Slot = "7")]
		public BJLDBBWNAOS CNJNSJGHUZQ(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8AF45F0", Offset = "0x8AF2FF0", VA = "0x188AF45F0", Slot = "8")]
		public IMTJMUAGWWG NZIASXSWIHA(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4870", Offset = "0x8AF3270", VA = "0x188AF4870", Slot = "9")]
		public OFAILNGDQYV TVVWQAKQNCB(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4690", Offset = "0x8AF3090", VA = "0x188AF4690", Slot = "10")]
		public LTSLVRFELFC QMSBCYLSWCY(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3EB0", Offset = "0x8AF28B0", VA = "0x188AF3EB0", Slot = "11")]
		public SEUTCTARQZA CDIIVCWKQEW(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4250", Offset = "0x8AF2C50", VA = "0x188AF4250", Slot = "12")]
		public YPRXVLQAWAI FWKSLCZEVXS(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8AF47D0", Offset = "0x8AF31D0", VA = "0x188AF47D0", Slot = "13")]
		public CXWEJHDDATZ TUNQPXTMRDZ(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF41A0", Offset = "0x8AF2BA0", VA = "0x188AF41A0")]
		public GSTISZZNMWT NSHNSFRDTNF(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF42F0", Offset = "0x8AF2CF0", VA = "0x188AF42F0")]
		public YXGCDGIWJWJ IRISATZYHZP(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4440", Offset = "0x8AF2E40", VA = "0x188AF4440")]
		public OHVJDROOUGD YWLDUFFCHOL(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4540", Offset = "0x8AF2F40", VA = "0x188AF4540")]
		public YETDUGNTKHL RUGBDILHSOR(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3E00", Offset = "0x8AF2800", VA = "0x188AF3E00")]
		public ZBZZLINQTMF BZLMIMVZUUV(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4050", Offset = "0x8AF2A50", VA = "0x188AF4050", Slot = "19")]
		public FLAXIIDFDDM EIXMERDYXEB(RigidbodyEx a, RigidbodyExData b, LVGTUOGKEEX c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4910", Offset = "0x8AF3310", VA = "0x188AF4910")]
		public GTETPMZYZEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8AF41A0", Offset = "0x8AF2BA0", VA = "0x188AF41A0", Slot = "14")]
		private GSTISZZNMWT EQOAJOXWDGP(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8AF42F0", Offset = "0x8AF2CF0", VA = "0x188AF42F0", Slot = "15")]
		private YXGCDGIWJWJ FWNGOTWDJMF(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4440", Offset = "0x8AF2E40", VA = "0x188AF4440", Slot = "16")]
		private OHVJDROOUGD HNOKAZSOIZF(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4540", Offset = "0x8AF2F40", VA = "0x188AF4540", Slot = "17")]
		private YETDUGNTKHL LKUNRPMVPQN(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3E00", Offset = "0x8AF2800", VA = "0x188AF3E00", Slot = "18")]
		private ZBZZLINQTMF UFSLGFPFSNH(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
}
namespace RecRoom.Rbex.Legacy
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public interface UERWRAHCCNZ : KCMFVCQXRWS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JHPMQEXBLAQ(FLAXIIDFDDM a);

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HSJKUHOTIDJ(FLAXIIDFDDM a);

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IOZMECBOEKG(FLAXIIDFDDM a);

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VQCEJMBNPUT(FLAXIIDFDDM a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface HYVIOJHJCQE : TKDKXZQKCER
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		ZEKHVQDUFNO<FLAXIIDFDDM> UDVRQLYCAJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		FLAXIIDFDDM TJTCNDRUGZR
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface NXUBJZLTEOC : YETDUGNTKHL
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		(float, Vector3) XSWSNMHLISL(Rigidbody a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface VZXSSLUPNVO : YXGCDGIWJWJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		RRNetworkView ZVIYIMAHYWQ
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal sealed class SRLNTUBRUQR : YPRXVLQAWAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly TMFOVSNWHWZ QKFVGCKHFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CollisionDetectionMode CYRDLAHCBZF;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		private Rigidbody BGOHCCWKOGX
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x8AFF6C0", Offset = "0x8AFE0C0", VA = "0x188AFF6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode UWKYBWBMPLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x8AFF230", Offset = "0x8AFDC30", VA = "0x188AFF230", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x8AFF340", Offset = "0x8AFDD40", VA = "0x188AFF340", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6670", Offset = "0x8AF5070", VA = "0x188AF6670")]
		public SRLNTUBRUQR(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8AFF120", Offset = "0x8AFDB20", VA = "0x188AFF120", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8AFF640", Offset = "0x8AFE040", VA = "0x188AFF640", Slot = "9")]
		public void MYVGUYFYLGS(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8AFF510", Offset = "0x8AFDF10", VA = "0x188AFF510", Slot = "7")]
		public void LGTBLRGOYZX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8AFF710", Offset = "0x8AFE110", VA = "0x188AFF710", Slot = "8")]
		public void ZZDMRWJOTIQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8AFF3B0", Offset = "0x8AFDDB0", VA = "0x188AFF3B0", Slot = "10")]
		public bool JYAJLSHIFHT(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8AFF520", Offset = "0x8AFDF20", VA = "0x188AFF520")]
		private void MUKMKETWJSH(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class HPYJFACIVJM : OFAILNGDQYV, IDisposable, JCEANAOEZKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly TMFOVSNWHWZ QKFVGCKHFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TransformTrackRate JPGXCHCCGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private EDWMDUTPURO ADEBGLPEXDW;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public TransformTrackRate UKACRFWZOII
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x8AF4EC0", Offset = "0x8AF38C0", VA = "0x188AF4EC0", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x8AF4D40", Offset = "0x8AF3740", VA = "0x188AF4D40", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform CCJDXPXRUFF
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x8AF4CD0", Offset = "0x8AF36D0", VA = "0x188AF4CD0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> EHNWSTRYUOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x8AF4E10", Offset = "0x8AF3810", VA = "0x188AF4E10", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x8AF49B0", Offset = "0x8AF33B0", VA = "0x188AF49B0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5000", Offset = "0x8AF3A00", VA = "0x188AF5000")]
		public HPYJFACIVJM(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4A60", Offset = "0x8AF3460", VA = "0x188AF4A60", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF4CF0", Offset = "0x8AF36F0", VA = "0x188AF4CF0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1100900", Offset = "0x10FF300", VA = "0x181100900", Slot = "11")]
		private void NKKTYLINKYM(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "12")]
		private void XCYYSXNOBKU(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class WDSDLHDRQBO : LKKROKFZAWP
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8B06C90", Offset = "0x8B05690", VA = "0x188B06C90", Slot = "4")]
		public KCMFVCQXRWS AGKELJEYDWO(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8B074A0", Offset = "0x8B05EA0", VA = "0x188B074A0", Slot = "5")]
		public ADQTVWKPJFC GHHNEVLNTRW(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8B07A20", Offset = "0x8B06420", VA = "0x188B07A20", Slot = "6")]
		public TKDKXZQKCER QWJAEOHOEJL(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8B06F00", Offset = "0x8B05900", VA = "0x188B06F00", Slot = "7")]
		public BJLDBBWNAOS CNJNSJGHUZQ(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8B07850", Offset = "0x8B06250", VA = "0x188B07850", Slot = "8")]
		public IMTJMUAGWWG NZIASXSWIHA(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8B07C00", Offset = "0x8B06600", VA = "0x188B07C00", Slot = "9")]
		public OFAILNGDQYV TVVWQAKQNCB(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8B07910", Offset = "0x8B06310", VA = "0x188B07910", Slot = "10")]
		public LTSLVRFELFC QMSBCYLSWCY(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8B06E40", Offset = "0x8B05840", VA = "0x188B06E40", Slot = "11")]
		public SEUTCTARQZA CDIIVCWKQEW(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8B07260", Offset = "0x8B05C60", VA = "0x188B07260", Slot = "12")]
		public YPRXVLQAWAI FWKSLCZEVXS(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8B07B40", Offset = "0x8B06540", VA = "0x188B07B40", Slot = "13")]
		public CXWEJHDDATZ TUNQPXTMRDZ(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8B07140", Offset = "0x8B05B40", VA = "0x188B07140")]
		public GSTISZZNMWT NSHNSFRDTNF(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8B07320", Offset = "0x8B05D20", VA = "0x188B07320")]
		public YXGCDGIWJWJ IRISATZYHZP(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8B075B0", Offset = "0x8B05FB0", VA = "0x188B075B0")]
		public OHVJDROOUGD YWLDUFFCHOL(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8B076D0", Offset = "0x8B060D0", VA = "0x188B076D0")]
		public YETDUGNTKHL RUGBDILHSOR(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8B06D70", Offset = "0x8B05770", VA = "0x188B06D70")]
		public ZBZZLINQTMF BZLMIMVZUUV(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8B07000", Offset = "0x8B05A00", VA = "0x188B07000", Slot = "19")]
		public FLAXIIDFDDM EIXMERDYXEB(RigidbodyEx a, RigidbodyExData b, LVGTUOGKEEX c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public WDSDLHDRQBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8B07140", Offset = "0x8B05B40", VA = "0x188B07140", Slot = "14")]
		private GSTISZZNMWT EQOAJOXWDGP(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8B07320", Offset = "0x8B05D20", VA = "0x188B07320", Slot = "15")]
		private YXGCDGIWJWJ FWNGOTWDJMF(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8B075B0", Offset = "0x8B05FB0", VA = "0x188B075B0", Slot = "16")]
		private OHVJDROOUGD HNOKAZSOIZF(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8B076D0", Offset = "0x8B060D0", VA = "0x188B076D0", Slot = "17")]
		private YETDUGNTKHL LKUNRPMVPQN(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8B06D70", Offset = "0x8B05770", VA = "0x188B06D70", Slot = "18")]
		private ZBZZLINQTMF UFSLGFPFSNH(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal sealed class VYMECNCZQBD : SEUTCTARQZA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly TMFOVSNWHWZ QKFVGCKHFEK;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		private Rigidbody BGOHCCWKOGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x8AFF6C0", Offset = "0x8AFE0C0", VA = "0x188AFF6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool PSMKSNHRWPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x8B05F80", Offset = "0x8B04980", VA = "0x188B05F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool MDJGMOLRPTX
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x8AEEFA0", Offset = "0x8AED9A0", VA = "0x188AEEFA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private FLAXIIDFDDM KYXHYZREABR
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x8B06610", Offset = "0x8B05010", VA = "0x188B06610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6670", Offset = "0x8AF5070", VA = "0x188AF6670")]
		public VYMECNCZQBD(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8B06250", Offset = "0x8B04C50", VA = "0x188B06250", Slot = "4")]
		public void FYMUGNLOQGB(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8B06A30", Offset = "0x8B05430", VA = "0x188B06A30")]
		private void WTMSKMWCWAY(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8B05FD0", Offset = "0x8B049D0", VA = "0x188B05FD0", Slot = "5")]
		public void FAHMGMBFGJJ(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8B06670", Offset = "0x8B05070", VA = "0x188B06670", Slot = "6")]
		public void ORBAMLWUUBS(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8B067D0", Offset = "0x8B051D0", VA = "0x188B067D0")]
		private void RDIFXOYHBBR(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8B063B0", Offset = "0x8B04DB0", VA = "0x188B063B0", Slot = "7")]
		public void LEUZHWFIWEU(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class KTUQHXTNXUI : CXWEJHDDATZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly TMFOVSNWHWZ QKFVGCKHFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool UJUPEWMEQFG;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool KYJNNQJYWLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0xBF80A0", Offset = "0xBF6AA0", VA = "0x180BF80A0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6560", Offset = "0x8AF4F60", VA = "0x188AF6560", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6670", Offset = "0x8AF5070", VA = "0x188AF6670")]
		public KTUQHXTNXUI(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6530", Offset = "0x8AF4F30", VA = "0x188AF6530", Slot = "6")]
		public void MYVGUYFYLGS(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8AF64C0", Offset = "0x8AF4EC0", VA = "0x188AF64C0", Slot = "7")]
		public void LEEORNZPXDZ(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal sealed class RbexHierarchy : UERWRAHCCNZ, KCMFVCQXRWS, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly FLAXIIDFDDM QKFVGCKHFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<FLAXIIDFDDM> TLBTOOFMWKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private FLAXIIDFDDM OQYAWLRTKSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private FLAXIIDFDDM HJMDDSQJNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private Transform HDOCDVPQHKS;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private Transform YTQQQFYHIEF
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x8AF7D90", Offset = "0x8AF6790", VA = "0x188AF7D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public FLAXIIDFDDM KYXHYZREABR
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xAB5130", Offset = "0xAB3B30", VA = "0x180AB5130", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x8AF97E0", Offset = "0x8AF81E0", VA = "0x188AF97E0", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public FLAXIIDFDDM XQVYPEOBNLV
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5180", Offset = "0xAB3B80", VA = "0x180AB5180", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<FLAXIIDFDDM> POFFWQKAIPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xAB5170", Offset = "0xAB3B70", VA = "0x180AB5170", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction TPHRZPYKYMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x8AF7EA0", Offset = "0x8AF68A0", VA = "0x188AF7EA0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x8AF8B80", Offset = "0x8AF7580", VA = "0x188AF8B80", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction BUHZDFMKFIV
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x8AF9740", Offset = "0x8AF8140", VA = "0x188AF9740", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x8AF9230", Offset = "0x8AF7C30", VA = "0x188AF9230", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction BOMWDECCPLX
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x8AF96A0", Offset = "0x8AF80A0", VA = "0x188AF96A0", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x8AF8A30", Offset = "0x8AF7430", VA = "0x188AF8A30", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action WWNVFWCCRLS
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x8AF9600", Offset = "0x8AF8000", VA = "0x188AF9600", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x8AF8660", Offset = "0x8AF7060", VA = "0x188AF8660", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action WKXUIJHWHSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x8AF8700", Offset = "0x8AF7100", VA = "0x188AF8700", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x8AF7A20", Offset = "0x8AF6420", VA = "0x188AF7A20", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<FLAXIIDFDDM> UJNELIJHYQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x8AF8980", Offset = "0x8AF7380", VA = "0x188AF8980", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x8AF9550", Offset = "0x8AF7F50", VA = "0x188AF9550", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<FLAXIIDFDDM> MQCMUSECIZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x8AF87A0", Offset = "0x8AF71A0", VA = "0x188AF87A0", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x8AF8AD0", Offset = "0x8AF74D0", VA = "0x188AF8AD0", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action NPBZNEWFXSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x8AF7BB0", Offset = "0x8AF65B0", VA = "0x188AF7BB0", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x8AF7CF0", Offset = "0x8AF66F0", VA = "0x188AF7CF0", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<FLAXIIDFDDM> KSZMLQJGEJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x8AF7DF0", Offset = "0x8AF67F0", VA = "0x188AF7DF0", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x8AF7B00", Offset = "0x8AF6500", VA = "0x188AF7B00", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF97F0", Offset = "0x8AF81F0", VA = "0x188AF97F0")]
		public RbexHierarchy(FLAXIIDFDDM rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7C50", Offset = "0x8AF6650", VA = "0x188AF7C50", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8C20", Offset = "0x8AF7620", VA = "0x188AF8C20", Slot = "30")]
		public void SetParent(FLAXIIDFDDM newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8100", Offset = "0x8AF6B00", VA = "0x188AF8100", Slot = "6")]
		public void IOZMECBOEKG(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8AF92D0", Offset = "0x8AF7CD0", VA = "0x188AF92D0", Slot = "7")]
		public void VQCEJMBNPUT(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8430", Offset = "0x8AF6E30", VA = "0x188AF8430", Slot = "4")]
		public void JHPMQEXBLAQ(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7F40", Offset = "0x8AF6940", VA = "0x188AF7F40", Slot = "5")]
		public void HSJKUHOTIDJ(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9190", Offset = "0x8AF7B90", VA = "0x188AF9190")]
		private void TAPWDQGXPOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7AC0", Offset = "0x8AF64C0", VA = "0x188AF7AC0")]
		private void BDKIITRPAWV(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8520", Offset = "0x8AF6F20", VA = "0x188AF8520")]
		private void KNXOUHEPIWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8850", Offset = "0x8AF7250", VA = "0x188AF8850")]
		private void PLWRCWWUMZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7FE0", Offset = "0x8AF69E0", VA = "0x188AF7FE0")]
		private void IOSXZUHFOMX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF8370", Offset = "0x8AF6D70", VA = "0x188AF8370")]
		[CompilerGenerated]
		private object JEZYQYWRNVJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal static class WMVXGPOQUAH
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8B07CC0", Offset = "0x8B066C0", VA = "0x188B07CC0")]
		public static UERWRAHCCNZ CMNXENCFQPY(this FLAXIIDFDDM a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	internal sealed class GEKRHZYGGOS : HYVIOJHJCQE, TKDKXZQKCER
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly TMFOVSNWHWZ QKFVGCKHFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly ZEKHVQDUFNO<FLAXIIDFDDM> EOAQMSJOLTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool MKQZGNFUQGM;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public ZEKHVQDUFNO<FLAXIIDFDDM> UDVRQLYCAJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 JIEBZKHYMFC
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x8AF3140", Offset = "0x8AF1B40", VA = "0x188AF3140", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 JZAYFVJXHHW
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x8AF2F80", Offset = "0x8AF1980", VA = "0x188AF2F80", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 FITKFMCGXGG
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x8AF3220", Offset = "0x8AF1C20", VA = "0x188AF3220")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public FLAXIIDFDDM TJTCNDRUGZR
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x8AF3170", Offset = "0x8AF1B70", VA = "0x188AF3170", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3780", Offset = "0x8AF2180", VA = "0x188AF3780")]
		public GEKRHZYGGOS(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8AF36B0", Offset = "0x8AF20B0", VA = "0x188AF36B0", Slot = "8")]
		public void ULVFIXJDPVQ(FLAXIIDFDDM a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3720", Offset = "0x8AF2120", VA = "0x188AF3720", Slot = "9")]
		public void XUZZTJUGMUX(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2BE0", Offset = "0x8AF15E0", VA = "0x188AF2BE0")]
		private Vector3 CNWOFOQUDOK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3310", Offset = "0x8AF1D10", VA = "0x188AF3310")]
		private void UGOJQEGZOVZ(FLAXIIDFDDM a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class LMLLHXMFGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6700", Offset = "0x8AF5100", VA = "0x188AF6700")]
		public static HYVIOJHJCQE RFCJSANXPRX(this FLAXIIDFDDM a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	internal sealed class XDGGMVWADDS : NXUBJZLTEOC, YETDUGNTKHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly TMFOVSNWHWZ QKFVGCKHFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly OverridableVector3 JPVPQTQAPPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly OverridableVector3 HFKLNJMZGTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private float UXMDYZHRZZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private float VLVJKAVEYOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Vector3 IXOIWQLMSDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private Vector3? SONKUUPZXDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private Quaternion? MYGSEUVQQSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private bool OSMVXQBAYHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private bool SNHGUKZVNLS;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Vector3 WBMMJBJGBHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x1CD0730", Offset = "0x1CCF130", VA = "0x181CD0730", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x8B09220", Offset = "0x8B07C20", VA = "0x188B09220", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 BODXQJLKRUB
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x8B092D0", Offset = "0x8B07CD0", VA = "0x188B092D0", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float JTOZPLOYRVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xB076B0", Offset = "0xB060B0", VA = "0x180B076B0", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x8B08440", Offset = "0x8B06E40", VA = "0x188B08440")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float NNIRLUFQVOE
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xB076C0", Offset = "0xB060C0", VA = "0x180B076C0", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x8B07EA0", Offset = "0x8B068A0", VA = "0x188B07EA0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 BWAHXXTTQNA
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x8B08BD0", Offset = "0x8B075D0", VA = "0x188B08BD0", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion OEVTXFXHXNS
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x8B093F0", Offset = "0x8B07DF0", VA = "0x188B093F0", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody BGOHCCWKOGX
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x8AF59D0", Offset = "0x8AF43D0", VA = "0x188AF59D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction QBJCGGCHEAR
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8B08550", Offset = "0x8B06F50", VA = "0x188B08550", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8B0A3E0", Offset = "0x8B08DE0", VA = "0x188B0A3E0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B0A560", Offset = "0x8B08F60", VA = "0x188B0A560")]
		public XDGGMVWADDS(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8B07F50", Offset = "0x8B06950", VA = "0x188B07F50", Slot = "17")]
		public void BWIMOVRHZTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8B0A480", Offset = "0x8B08E80", VA = "0x188B0A480", Slot = "16")]
		public void XVKONZDITXB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B08AF0", Offset = "0x8B074F0", VA = "0x188B08AF0", Slot = "19")]
		public void MYVGUYFYLGS(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B08790", Offset = "0x8B07190", VA = "0x188B08790", Slot = "20")]
		public void LEEORNZPXDZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B085F0", Offset = "0x8B06FF0", VA = "0x188B085F0", Slot = "18")]
		public void KHMNBOKGZJY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B08D60", Offset = "0x8B07760", VA = "0x188B08D60", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8B09220", Offset = "0x8B07C20", VA = "0x188B09220")]
		private void ZGSMLWBXDGA(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B07D80", Offset = "0x8B06780", VA = "0x188B07D80")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 AUKKLZWCLLJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8B08440", Offset = "0x8B06E40", VA = "0x188B08440")]
		private void GYJEESPYGNL(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B07EA0", Offset = "0x8B068A0", VA = "0x188B07EA0")]
		private void BRFDKABIRDQ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8B08070", Offset = "0x8B06A70", VA = "0x188B08070")]
		private Vector3 DEPONVOEGOU()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B08210", Offset = "0x8B06C10", VA = "0x188B08210", Slot = "15")]
		public void DJVGOIHFCUE((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8B08970", Offset = "0x8B07370", VA = "0x188B08970")]
		private Quaternion MJNWUPDXLQK()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8B0A310", Offset = "0x8B08D10", VA = "0x188B0A310")]
		public void XSWSNMHLISL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B09570", Offset = "0x8B07F70", VA = "0x188B09570", Slot = "4")]
		public (float, Vector3) XSWSNMHLISL(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class XODFLAIUMOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8B0A6C0", Offset = "0x8B090C0", VA = "0x188B0A6C0")]
		public static NXUBJZLTEOC XUNLLTZGDAR(this FLAXIIDFDDM a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	internal sealed class KGFOFVETLGE : OHVJDROOUGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly TMFOVSNWHWZ QKFVGCKHFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly ONVESPKROXV RKGKRIWUCQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly RbexInterpolationMode QYVEUQDRYTY;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool PHFZQCRVPNY
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x18578A0", Offset = "0x18562A0", VA = "0x1818578A0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode FZFJHADPKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8AF63D0", Offset = "0x8AF4DD0", VA = "0x188AF63D0")]
		public KGFOFVETLGE(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5DC0", Offset = "0x8AF47C0", VA = "0x188AF5DC0", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5FA0", Offset = "0x8AF49A0", VA = "0x188AF5FA0")]
		private bool JOOERGUDDNG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6040", Offset = "0x8AF4A40", VA = "0x188AF6040", Slot = "5")]
		public void KAIOZASSZTW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6070", Offset = "0x8AF4A70", VA = "0x188AF6070", Slot = "6")]
		public void TPBJKNPKSIL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8AF60A0", Offset = "0x8AF4AA0", VA = "0x188AF60A0", Slot = "9")]
		public void XJJWUULXQRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5E90", Offset = "0x8AF4890", VA = "0x188AF5E90")]
		private void HZMAHMPDOPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6210", Offset = "0x8AF4C10", VA = "0x188AF6210")]
		private void YJGHQLHTEMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6390", Offset = "0x8AF4D90", VA = "0x188AF6390", Slot = "8")]
		public void YNAATAGMNHI(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8AF61D0", Offset = "0x8AF4BD0", VA = "0x188AF61D0", Slot = "7")]
		public void XWEWTTBCNOD(FLAXIIDFDDM a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class GJWDBJDOIVR : LTSLVRFELFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly TMFOVSNWHWZ QKFVGCKHFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly ONVESPKROXV YHWDPMRTZDY;

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool PSMKSNHRWPK
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x8AF3920", Offset = "0x8AF2320", VA = "0x188AF3920", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction SOFVDXQITKE
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x8AF39D0", Offset = "0x8AF23D0", VA = "0x188AF39D0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x8AF3870", Offset = "0x8AF2270", VA = "0x188AF3870", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3C80", Offset = "0x8AF2680", VA = "0x188AF3C80")]
		public GJWDBJDOIVR(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3910", Offset = "0x8AF2310", VA = "0x188AF3910", Slot = "7")]
		public void EHRMZIGLHUP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3B20", Offset = "0x8AF2520", VA = "0x188AF3B20", Slot = "8")]
		public void PTXZWXHRDJK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3B70", Offset = "0x8AF2570", VA = "0x188AF3B70", Slot = "9")]
		public void ZWMPMWMKJUO(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3B30", Offset = "0x8AF2530", VA = "0x188AF3B30", Slot = "12")]
		public void QYUUGTSGDGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3AA0", Offset = "0x8AF24A0", VA = "0x188AF3AA0", Slot = "10")]
		public void MYVGUYFYLGS(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x8AF3A70", Offset = "0x8AF2470", VA = "0x188AF3A70", Slot = "11")]
		public void LEEORNZPXDZ(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class MZQZQQKGMBI : VZXSSLUPNVO, YXGCDGIWJWJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly TMFOVSNWHWZ QKFVGCKHFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private RRNetworkView HIWFAXHKEEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool KJVMOXJNKKZ;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public RRNetworkView ZVIYIMAHYWQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool KHFMOKTPUJX
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8AF7430", Offset = "0x8AF5E30", VA = "0x188AF7430", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool EHUTLADODAR
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F20", Offset = "0xCB1920", VA = "0x180CB2F20", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction CCLOKUJHAJY
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8AF7240", Offset = "0x8AF5C40", VA = "0x188AF7240", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6F30", Offset = "0x8AF5930", VA = "0x188AF6F30", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7440", Offset = "0x8AF5E40", VA = "0x188AF7440")]
		public MZQZQQKGMBI(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8AF68C0", Offset = "0x8AF52C0", VA = "0x188AF68C0", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8AF69F0", Offset = "0x8AF53F0", VA = "0x188AF69F0", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6C50", Offset = "0x8AF5650", VA = "0x188AF6C50", Slot = "10")]
		public void GMLMPTPRJDD(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6DC0", Offset = "0x8AF57C0", VA = "0x188AF6DC0", Slot = "11")]
		public void MMRWLDTBIUN(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6AE0", Offset = "0x8AF54E0", VA = "0x188AF6AE0")]
		private void FWPIMNXLUSL(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8AF72E0", Offset = "0x8AF5CE0", VA = "0x188AF72E0")]
		private void VPQMHEPOSER(MPIPBSKHYUA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6FD0", Offset = "0x8AF59D0", VA = "0x188AF6FD0")]
		private void UYHZUPZGVUK(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class UROMTEGXKUY
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8B05EC0", Offset = "0x8B048C0", VA = "0x188B05EC0")]
		public static VZXSSLUPNVO Lifecycle(this FLAXIIDFDDM impl)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal sealed class YZJWTUYKLCQ : ZBZZLINQTMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly TMFOVSNWHWZ QKFVGCKHFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private RigidbodyConstraints TQLBXCJMYMR;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool GTXRIZMIKHU
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xC027C0", Offset = "0xC011C0", VA = "0x180C027C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xC02030", Offset = "0xC00A30", VA = "0x180C02030", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool IZVNTIZYRSZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xC02330", Offset = "0xC00D30", VA = "0x180C02330", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xC02500", Offset = "0xC00F00", VA = "0x180C02500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints VHDDUGYFSQJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x8B0A780", Offset = "0x8B09180", VA = "0x188B0A780", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8B0A910", Offset = "0x8B09310", VA = "0x188B0A910")]
		public YZJWTUYKLCQ(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B0A8E0", Offset = "0x8B092E0", VA = "0x188B0A8E0", Slot = "9")]
		public void MYVGUYFYLGS(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B0A8B0", Offset = "0x8B092B0", VA = "0x188B0A8B0", Slot = "10")]
		public void LEEORNZPXDZ(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class OQRNFMMYUCL : BJLDBBWNAOS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly FLAXIIDFDDM QKFVGCKHFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private float WBFXCEXZZOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private float NNUZUONMTUZ;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public float KIZNHPRTSWF
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xB06880", Offset = "0xB05280", VA = "0x180B06880", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8AF7590", Offset = "0x8AF5F90", VA = "0x188AF7590", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float KPDYGHQRDQJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xB06870", Offset = "0xB05270", VA = "0x180B06870", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8AF7750", Offset = "0x8AF6150", VA = "0x188AF7750", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7820", Offset = "0x8AF6220", VA = "0x188AF7820")]
		public OQRNFMMYUCL(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7700", Offset = "0x8AF6100", VA = "0x188AF7700", Slot = "8")]
		public void MYVGUYFYLGS(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7660", Offset = "0x8AF6060", VA = "0x188AF7660", Slot = "9")]
		public void LEEORNZPXDZ(Rigidbody a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class IPUOQTSTQLL : IMTJMUAGWWG
	{
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly Log FFQIRDTVFSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly TMFOVSNWHWZ QKFVGCKHFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool PUVOWMDTSAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool KJXRDARBFOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int OSHFRIXDQRV;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private Rigidbody BGOHCCWKOGX
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x8AF59D0", Offset = "0x8AF43D0", VA = "0x188AF59D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool GBCQTREPYTA
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8AF59B0", Offset = "0x8AF43B0", VA = "0x188AF59B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private FLAXIIDFDDM KYXHYZREABR
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x8AF5950", Offset = "0x8AF4350", VA = "0x188AF5950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool MDJGMOLRPTX
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x8AF5720", Offset = "0x8AF4120", VA = "0x188AF5720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction OTUPUUBHMDM
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x8AF5100", Offset = "0x8AF3B00", VA = "0x188AF5100", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8AF5680", Offset = "0x8AF4080", VA = "0x188AF5680", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5D30", Offset = "0x8AF4730", VA = "0x188AF5D30")]
		public IPUOQTSTQLL(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8AF51A0", Offset = "0x8AF3BA0", VA = "0x188AF51A0", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5670", Offset = "0x8AF4070", VA = "0x188AF5670", Slot = "8")]
		public void DUDNTVVQNOY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5AF0", Offset = "0x8AF44F0", VA = "0x188AF5AF0", Slot = "7")]
		public bool VZRYQKTJZDM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5A20", Offset = "0x8AF4420", VA = "0x188AF5A20", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8AF54B0", Offset = "0x8AF3EB0", VA = "0x188AF54B0", Slot = "13")]
		public void CSIVDQEXQWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5550", Offset = "0x8AF3F50", VA = "0x188AF5550", Slot = "12")]
		public void CXFMMMVEQTX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5C40", Offset = "0x8AF4640", VA = "0x188AF5C40", Slot = "10")]
		public bool WLGTIHGCVPE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5230", Offset = "0x8AF3C30", VA = "0x188AF5230", Slot = "11")]
		public bool CGJURPXSKBZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5780", Offset = "0x8AF4180", VA = "0x188AF5780")]
		private bool HNEVTEQTWEJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5320", Offset = "0x8AF3D20", VA = "0x188AF5320")]
		private void CIUKINRWWGB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal sealed class AWKTAZORFVM : GSTISZZNMWT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly TMFOVSNWHWZ QKFVGCKHFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly ONVESPKROXV YERHHANTSVA;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public Rigidbody BGOHCCWKOGX
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool MDJGMOLRPTX
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x8AEEFA0", Offset = "0x8AED9A0", VA = "0x188AEEFA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool GZBCAOAWTCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x18578A0", Offset = "0x18562A0", VA = "0x1818578A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF220", Offset = "0x8AEDC20", VA = "0x188AEF220")]
		public AWKTAZORFVM(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8AEED50", Offset = "0x8AED750", VA = "0x188AEED50", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8AEEF70", Offset = "0x8AED970", VA = "0x188AEEF70", Slot = "7")]
		public void GJPYSWLQTCE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF000", Offset = "0x8AEDA00", VA = "0x188AEF000", Slot = "8")]
		public void KVFFGSXRTDB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8AEEA20", Offset = "0x8AED420", VA = "0x188AEEA20", Slot = "9")]
		public void AMVTNASUVAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF030", Offset = "0x8AEDA30", VA = "0x188AEF030", Slot = "10")]
		public void OFTZSGVHOUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8AEEDF0", Offset = "0x8AED7F0", VA = "0x188AEEDF0", Slot = "11")]
		public void EEDQOGKVDWS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal sealed class CAKSKMFSCCR : ADQTVWKPJFC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly TMFOVSNWHWZ QKFVGCKHFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly ONVESPKROXV WFOFREKQQNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private float RKBUHTYRHRC;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public ZMTWMPCAWEU EWXOLEHLJQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xAB85B0", Offset = "0xAB6FB0", VA = "0x180AB85B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xAB8340", Offset = "0xAB6D40", VA = "0x180AB8340", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public RTQGHSHOPHZ XIHZDOJZUOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 FITKFMCGXGG
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x8AF11B0", Offset = "0x8AEFBB0", VA = "0x188AF11B0", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x8AF1DD0", Offset = "0x8AF07D0", VA = "0x188AF1DD0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 WBDPTOWQUSF
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x8AF14A0", Offset = "0x8AEFEA0", VA = "0x188AF14A0", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8AF1E90", Offset = "0x8AF0890", VA = "0x188AF1E90", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 IGQBUSPCNOC
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x8AF0D40", Offset = "0x8AEF740", VA = "0x188AF0D40", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x8AEF320", Offset = "0x8AEDD20", VA = "0x188AEF320", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 GHLUXTSNDMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x8AF18D0", Offset = "0x8AF02D0", VA = "0x188AF18D0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x8AF1C90", Offset = "0x8AF0690", VA = "0x188AF1C90", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float FNDQULDQCMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xB066D0", Offset = "0xB050D0", VA = "0x180B066D0", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8AF1CC0", Offset = "0x8AF06C0", VA = "0x188AF1CC0", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool NYZKQSIKQLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x2314C60", Offset = "0x2313660", VA = "0x182314C60", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private SEUTCTARQZA HGYUYITXBZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x8075200", Offset = "0x8073C00", VA = "0x188075200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool GBCQTREPYTA
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x8AF1C70", Offset = "0x8AF0670", VA = "0x188AF1C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2780", Offset = "0x8AF1180", VA = "0x188AF2780")]
		public CAKSKMFSCCR(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF3E0", Offset = "0x8AEDDE0", VA = "0x188AEF3E0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8AF00B0", Offset = "0x8AEEAB0", VA = "0x188AF00B0", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8AF15C0", Offset = "0x8AEFFC0", VA = "0x188AF15C0", Slot = "28")]
		public void MYVGUYFYLGS(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x1624070", Offset = "0x1622A70", VA = "0x181624070", Slot = "20")]
		public void LWDNNATHMNS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x1625B80", Offset = "0x1624580", VA = "0x181625B80", Slot = "30")]
		public void OLZDBQUXTQP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF16F0", Offset = "0x8AF00F0", VA = "0x188AF16F0", Slot = "35")]
		public Vector3 NIOYPYEQKWQ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF0110", Offset = "0x8AEEB10", VA = "0x188AF0110", Slot = "34")]
		public Vector3 ELLRGFOLSLU(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF3E0", Offset = "0x8AEDDE0", VA = "0x188AEF3E0", Slot = "27")]
		public void WDLTQJCFAFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF0860", Offset = "0x8AEF260", VA = "0x188AF0860", Slot = "25")]
		public void GOUKBDOZGZQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF0FB0", Offset = "0x8AEF9B0", VA = "0x188AF0FB0", Slot = "24")]
		public void KRGSPSWJWCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF9F0", Offset = "0x8AEE3F0", VA = "0x188AEF9F0", Slot = "33")]
		public void CZIRHLUKVQH(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF8E0", Offset = "0x8AEE2E0", VA = "0x188AEF8E0", Slot = "32")]
		public void BGBOOAVERTQ(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1300", Offset = "0x8AEFD00", VA = "0x188AF1300", Slot = "31")]
		public void LRKHYJRZYNR(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2130", Offset = "0x8AF0B30", VA = "0x188AF2130", Slot = "22")]
		public void ZNUBIDZFUEL(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8AF19F0", Offset = "0x8AF03F0", VA = "0x188AF19F0", Slot = "21")]
		public void RJBOBMTNCPE(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8AF03E0", Offset = "0x8AEEDE0", VA = "0x188AF03E0", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void GMGTXVVWBAV(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x175DBF0", Offset = "0x175C5F0", VA = "0x18175DBF0")]
		private static void JGRDAPUCRGH(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2050", Offset = "0x8AF0A50", VA = "0x188AF2050", Slot = "29")]
		public Vector3 YGKWEEYFHPK(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1EC0", Offset = "0x8AF08C0", VA = "0x188AF1EC0", Slot = "26")]
		public void XKQXRAVLLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1CC0", Offset = "0x8AF06C0", VA = "0x188AF1CC0")]
		private void TQRYALWWXCO(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF1010", Offset = "0x8AEFA10", VA = "0x188AF1010")]
		private void LNYSDVPPYVK(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF02D0", Offset = "0x8AEECD0", VA = "0x188AF02D0")]
		private Vector3 FJJRIBAMUOX()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8AEFC30", Offset = "0x8AEE630", VA = "0x188AEFC30")]
		private void DFTCKAQXDRB(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8AF0E90", Offset = "0x8AEF890", VA = "0x188AF0E90")]
		private Vector3 IHVZXTDRDNH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8AF08C0", Offset = "0x8AEF2C0", VA = "0x188AF08C0")]
		private void HJPKZUFDEPT(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF480", Offset = "0x8AEDE80", VA = "0x188AEF480")]
		private void BEMASCDJHWK(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8AEF940", Offset = "0x8AEE340", VA = "0x188AEF940")]
		private void BWJJWUJBUBC()
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
