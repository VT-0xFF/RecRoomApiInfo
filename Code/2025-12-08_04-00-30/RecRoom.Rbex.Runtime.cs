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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x89F4340", Offset = "0x89F2B40", VA = "0x1889F4340", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA15F0", Offset = "0xA9FDF0", VA = "0x180AA15F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83EA140", Offset = "0x83E8940", VA = "0x1883EA140", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A08520", Offset = "0x8A06D20", VA = "0x188A08520")]
		private void ANRTHLCVEKO(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A08800", Offset = "0x8A07000", VA = "0x188A08800", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8A08860", Offset = "0x8A07060", VA = "0x188A08860")]
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
			[Cpp2IlInjected.Address(RVA = "0x89F8960", Offset = "0x89F7160", VA = "0x1889F8960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private FLAXIIDFDDM PKABGVTPIKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAA15F0", Offset = "0xA9FDF0", VA = "0x180AA15F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int DINRXQBFBGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x89FA1A0", Offset = "0x89F89A0", VA = "0x1889FA1A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx PRNLAKCNLLR
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x89FA500", Offset = "0x89F8D00", VA = "0x1889FA500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx XQVYPEOBNLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x89FA440", Offset = "0x89F8C40", VA = "0x1889FA440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx HJMDDSQJNLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x89FB100", Offset = "0x89F9900", VA = "0x1889FB100")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x89FC600", Offset = "0x89FAE00", VA = "0x1889FC600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7DED430", Offset = "0x7DEBC30", VA = "0x187DED430", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7DED580", Offset = "0x7DEBD80", VA = "0x187DED580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform UPSIZUKXNNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x230A930", Offset = "0x2309130", VA = "0x18230A930", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform EBJRASNMZDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x230A930", Offset = "0x2309130", VA = "0x18230A930", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform SIWRJIGIFJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x230A930", Offset = "0x2309130", VA = "0x18230A930", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TransformTrackRate UKACRFWZOII
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x89FA200", Offset = "0x89F8A00", VA = "0x1889FA200")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x89FBDB0", Offset = "0x89FA5B0", VA = "0x1889FBDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool KHFMOKTPUJX
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x89FA810", Offset = "0x89F9010", VA = "0x1889FA810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool EHUTLADODAR
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x89FA320", Offset = "0x89F8B20", VA = "0x1889FA320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ZMTWMPCAWEU EWXOLEHLJQF
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x89FA750", Offset = "0x89F8F50", VA = "0x1889FA750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x89FBF70", Offset = "0x89FA770", VA = "0x1889FBF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public RTQGHSHOPHZ XIHZDOJZUOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x89FA6F0", Offset = "0x89F8EF0", VA = "0x1889FA6F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x89FBF00", Offset = "0x89FA700", VA = "0x1889FBF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NYZKQSIKQLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x89FA640", Offset = "0x89F8E40", VA = "0x1889FA640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody BGOHCCWKOGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x89FA6A0", Offset = "0x89F8EA0", VA = "0x1889FA6A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool GTXRIZMIKHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x89FA380", Offset = "0x89F8B80", VA = "0x1889FA380")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x89FBE20", Offset = "0x89FA620", VA = "0x1889FBE20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool NSRENAIPNIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x16ED1B0", Offset = "0x16EB9B0", VA = "0x1816ED1B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float VLVJKAVEYOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x89FB0A0", Offset = "0x89F98A0", VA = "0x1889FB0A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float UXMDYZHRZZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x89FB040", Offset = "0x89F9840", VA = "0x1889FB040")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x89FC590", Offset = "0x89FAD90", VA = "0x1889FC590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float WBFXCEXZZOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x89FAA70", Offset = "0x89F9270", VA = "0x1889FAA70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x89FC210", Offset = "0x89FAA10", VA = "0x1889FC210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float NNUZUONMTUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x89FA870", Offset = "0x89F9070", VA = "0x1889FA870")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x89FBFE0", Offset = "0x89FA7E0", VA = "0x1889FBFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool UJUPEWMEQFG
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x89FB650", Offset = "0x89F9E50", VA = "0x1889FB650")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x89FCB40", Offset = "0x89FB340", VA = "0x1889FCB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 IXOIWQLMSDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x89FAE20", Offset = "0x89F9620", VA = "0x1889FAE20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x89FC360", Offset = "0x89FAB60", VA = "0x1889FC360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 SCHKYTZGGQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x89FB790", Offset = "0x89F9F90", VA = "0x1889FB790")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode FLHLRANLAXB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x89FA9B0", Offset = "0x89F91B0", VA = "0x1889FA9B0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x89FC130", Offset = "0x89FA930", VA = "0x1889FC130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float FNDQULDQCMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x89FA3E0", Offset = "0x89F8BE0", VA = "0x1889FA3E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x89FBE90", Offset = "0x89FA690", VA = "0x1889FBE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints TQLBXCJMYMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x89FAA10", Offset = "0x89F9210", VA = "0x1889FAA10")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x89FC1A0", Offset = "0x89FA9A0", VA = "0x1889FC1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 MEXSANLVTIH
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x89FB1C0", Offset = "0x89F99C0", VA = "0x1889FB1C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 MLJVIZDWRWB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x89FB1C0", Offset = "0x89F99C0", VA = "0x1889FB1C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x89FC920", Offset = "0x89FB120", VA = "0x1889FC920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float PARXDQARUKA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x89FAF00", Offset = "0x89F9700", VA = "0x1889FAF00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x89FC440", Offset = "0x89FAC40", VA = "0x1889FC440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float MUPDKXEKOMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x89FB5F0", Offset = "0x89F9DF0", VA = "0x1889FB5F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x89FCAD0", Offset = "0x89FB2D0", VA = "0x1889FCAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion PLKGJBGDRKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x89FB2A0", Offset = "0x89F9AA0", VA = "0x1889FB2A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x89FC6A0", Offset = "0x89FAEA0", VA = "0x1889FC6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion DZHTWOOGJSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x89FB520", Offset = "0x89F9D20", VA = "0x1889FB520")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x89FCA00", Offset = "0x89FB200", VA = "0x1889FCA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 XGAGMLQUTDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x89FB370", Offset = "0x89F9B70", VA = "0x1889FB370")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x89FC770", Offset = "0x89FAF70", VA = "0x1889FC770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion ZOUGKWJGLVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x89FB450", Offset = "0x89F9C50", VA = "0x1889FB450")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x89FC850", Offset = "0x89FB050", VA = "0x1889FC850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 MNACKULGLVW
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x89FB6B0", Offset = "0x89F9EB0", VA = "0x1889FB6B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x89FCBB0", Offset = "0x89FB3B0", VA = "0x1889FCBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 XIKCFTARQQB
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x89FAF60", Offset = "0x89F9760", VA = "0x1889FAF60")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x89FC4B0", Offset = "0x89FACB0", VA = "0x1889FC4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 UOSTQBKNYEY
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x89FA8D0", Offset = "0x89F90D0", VA = "0x1889FA8D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x89FC050", Offset = "0x89FA850", VA = "0x1889FC050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 OIRKAXPXCGP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x89FAD40", Offset = "0x89F9540", VA = "0x1889FAD40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x89FC280", Offset = "0x89FAA80", VA = "0x1889FC280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 SONKUUPZXDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x89FAC00", Offset = "0x89F9400", VA = "0x1889FAC00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion MYGSEUVQQSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x89FAB30", Offset = "0x89F9330", VA = "0x1889FAB30")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 VDIINRGWDWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x89FB950", Offset = "0x89FA150", VA = "0x1889FB950")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 BLMQXCBWAMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x89FB870", Offset = "0x89FA070", VA = "0x1889FB870")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DRAMGOHHWZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x89FACE0", Offset = "0x89F94E0", VA = "0x1889FACE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool RGJPKLDBPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x89FA7B0", Offset = "0x89F8FB0", VA = "0x1889FA7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool VVHPMWWZGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x89FA2C0", Offset = "0x89F8AC0", VA = "0x1889FA2C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool THYCZDLZSXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x89FA260", Offset = "0x89F8A60", VA = "0x1889FA260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool HONUZQFNXYW
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x89FA140", Offset = "0x89F8940", VA = "0x1889FA140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool SRRLDUEWDYN
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x89FAAD0", Offset = "0x89F92D0", VA = "0x1889FAAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool BXPTSGXIQZR
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xB61AB0", Offset = "0xB602B0", VA = "0x180B61AB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event RbexParentChangeAction SSFHSTCASID
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x89FA060", Offset = "0x89F8860", VA = "0x1889FA060")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x89FBCD0", Offset = "0x89FA4D0", VA = "0x1889FBCD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event RbexAction TPHRZPYKYMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x89F9DD0", Offset = "0x89F85D0", VA = "0x1889F9DD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x89FBA30", Offset = "0x89FA230", VA = "0x1889FBA30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event RbexAction BUHZDFMKFIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x89F9E30", Offset = "0x89F8630", VA = "0x1889F9E30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x89FBAA0", Offset = "0x89FA2A0", VA = "0x1889FBAA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event RbexAction NIKMCVBLYZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x89F9F80", Offset = "0x89F8780", VA = "0x1889F9F80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x89FBBF0", Offset = "0x89FA3F0", VA = "0x1889FBBF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<UpdateLOD, UpdateLOD> EHNWSTRYUOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x89F9F10", Offset = "0x89F8710", VA = "0x1889F9F10")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x89FBB80", Offset = "0x89FA380", VA = "0x1889FBB80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event RbexAction VUGQUZXYCYE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x89F9FF0", Offset = "0x89F87F0", VA = "0x1889F9FF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x89FBC60", Offset = "0x89FA460", VA = "0x1889FBC60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event RbexAction PLPEENWCYMG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x89FA0D0", Offset = "0x89F88D0", VA = "0x1889FA0D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x89FBD40", Offset = "0x89FA540", VA = "0x1889FBD40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event RbexAction ITVOCFFSDDD
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x89F9EA0", Offset = "0x89F86A0", VA = "0x1889F9EA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x89FBB10", Offset = "0x89FA310", VA = "0x1889FBB10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAA1380", Offset = "0xA9FB80", VA = "0x180AA1380", Slot = "8")]
		private void RATARUKRYYH(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x89F88D0", Offset = "0x89F70D0", VA = "0x1889F88D0", Slot = "9")]
		public RigidbodyExData GetData()
		{
			return default(RigidbodyExData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x89F8DE0", Offset = "0x89F75E0", VA = "0x1889F8DE0")]
		internal void PSVCXWXPMHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x89F9B00", Offset = "0x89F8300", VA = "0x1889F9B00")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody rb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x89F8620", Offset = "0x89F6E20", VA = "0x1889F8620")]
		public MPIPBSKHYUA GetChild(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x89F9760", Offset = "0x89F7F60", VA = "0x1889F9760")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x89F80F0", Offset = "0x89F68F0", VA = "0x1889F80F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x89F99F0", Offset = "0x89F81F0", VA = "0x1889F99F0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x89F8960", Offset = "0x89F7160", VA = "0x1889F8960")]
		private FLAXIIDFDDM WGEIWVXVDOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x89F82B0", Offset = "0x89F6AB0", VA = "0x1889F82B0")]
		private void BDNHZJHRRDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x89F8F30", Offset = "0x89F7730", VA = "0x1889F8F30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x89F8E70", Offset = "0x89F7670", VA = "0x1889F8E70")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x89F8DE0", Offset = "0x89F75E0", VA = "0x1889F8DE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x89F8ED0", Offset = "0x89F76D0", VA = "0x1889F8ED0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x89F8F90", Offset = "0x89F7790", VA = "0x1889F8F90")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x89F76E0", Offset = "0x89F5EE0", VA = "0x1889F76E0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x89F8FF0", Offset = "0x89F77F0", VA = "0x1889F8FF0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x89F85B0", Offset = "0x89F6DB0", VA = "0x1889F85B0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x89F8D80", Offset = "0x89F7580", VA = "0x1889F8D80")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x89F98C0", Offset = "0x89F80C0", VA = "0x1889F98C0")]
		public void SetParent(RigidbodyEx value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x89F9300", Offset = "0x89F7B00", VA = "0x1889F9300")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x89F8A10", Offset = "0x89F7210", VA = "0x1889F8A10")]
		public bool IsRigidbodyAncestor(RigidbodyEx possibleAncestor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B10", Offset = "0x89F7310", VA = "0x1889F8B10")]
		public bool IsRigidbodyDescendant(RigidbodyEx possibleDescendant)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x89F7950", Offset = "0x89F6150", VA = "0x1889F7950")]
		public void AddInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x89F9060", Offset = "0x89F7860", VA = "0x1889F9060")]
		public void RemoveInterpolationRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x89F79C0", Offset = "0x89F61C0", VA = "0x1889F79C0")]
		public void AddKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x89F90D0", Offset = "0x89F78D0", VA = "0x1889F90D0")]
		public void RemoveKinematic(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x89F9840", Offset = "0x89F8040", VA = "0x1889F9840")]
		public void SetKinematic(object token, bool setKinematic)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x89F9660", Offset = "0x89F7E60", VA = "0x1889F9660")]
		public void SetDiscontinuousPositionAndRotation(Vector3 newPosition, Quaternion newRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x89F9560", Offset = "0x89F7D60", VA = "0x1889F9560")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 newLocalPosition, Quaternion newLocalRotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x89F87C0", Offset = "0x89F6FC0", VA = "0x1889F87C0")]
		public Vector3 GetConstrainedVelocity(Vector3 velocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x89F86B0", Offset = "0x89F6EB0", VA = "0x1889F86B0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 angularVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x89F7860", Offset = "0x89F6060", VA = "0x1889F7860")]
		public void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x89F7750", Offset = "0x89F5F50", VA = "0x1889F7750")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x89F7B90", Offset = "0x89F6390", VA = "0x1889F7B90")]
		public void AddTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x89F7A30", Offset = "0x89F6230", VA = "0x1889F7A30")]
		public void AddRelativeTorque(Vector3 torque, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x89F9BD0", Offset = "0x89F83D0", VA = "0x1889F9BD0")]
		public Vector3 WorldToLocalVelocity(Vector3 worldVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x89F8C70", Offset = "0x89F7470", VA = "0x1889F8C70")]
		public Vector3 LocalToWorldVelocity(Vector3 localVelocity)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x89F8550", Offset = "0x89F6D50", VA = "0x1889F8550")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x89F84F0", Offset = "0x89F6CF0", VA = "0x1889F84F0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x89F8490", Offset = "0x89F6C90", VA = "0x1889F8490")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x89F8430", Offset = "0x89F6C30", VA = "0x1889F8430")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x89F9460", Offset = "0x89F7C60", VA = "0x1889F9460")]
		public void ResetVelocityWorldSpace(Vector3 worldLinearVelocity, Vector3 worldAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x89F9360", Offset = "0x89F7B60", VA = "0x1889F9360")]
		public void ResetVelocityLocalSpace(Vector3 localLinearVelocity, Vector3 localAngularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x89F9220", Offset = "0x89F7A20", VA = "0x1889F9220")]
		public void ResetLinearVelocityLocalSpace(Vector3 localLinearVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x89F9A00", Offset = "0x89F8200", VA = "0x1889F9A00")]
		public bool SweepTest(Vector3 direction, [Out] RaycastHit hitInfo, float maxDistance)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x89F8C10", Offset = "0x89F7410", VA = "0x1889F8C10")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x89F9990", Offset = "0x89F8190", VA = "0x1889F9990")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x89F9B70", Offset = "0x89F8370", VA = "0x1889F9B70")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x89F7B20", Offset = "0x89F6320", VA = "0x1889F7B20")]
		public void AddShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x89F9140", Offset = "0x89F7940", VA = "0x1889F9140")]
		public void RemoveShouldHaveUnityRigidbodyToken(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x89F7F20", Offset = "0x89F6720", VA = "0x1889F7F20")]
		public void ApplyForceVelocityChange(RbexImpulseType impulseType, Vector3 impulseDirection, float impulseSpeed, float impulseDirectionMaxSpeed = 8f, float impulseReflectiveRestitution = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x89F7E20", Offset = "0x89F6620", VA = "0x1889F7E20")]
		public void ApplyAngularVelocityChange(RbexRotationType rotationType, Vector3 newAngularVelocity, float maxAngularSpeed = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x89F7FE0", Offset = "0x89F67E0", VA = "0x1889F7FE0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(RbexRotationType rotationType, Vector3 rotation, float maxSpeed = 7f, float multiplyingFactor = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x89F7D50", Offset = "0x89F6550", VA = "0x1889F7D50")]
		public bool AllowedScaleChange(float scaleFactor)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x89F7C80", Offset = "0x89F6480", VA = "0x1889F7C80")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx parentOverride, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x89F91B0", Offset = "0x89F79B0", VA = "0x1889F91B0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x89F8610", Offset = "0x89F6E10", VA = "0x1889F8610", Slot = "13")]
		private void GBFJPAATHLO(WQKTEDFFTLA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x89F9D60", Offset = "0x89F8560", VA = "0x1889F9D60")]
		public RigidbodyEx()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1217C70", Offset = "0x1216470", VA = "0x181217C70", Slot = "4")]
		private GameObject KGPSGMEOCQH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xACB290", Offset = "0xAC9A90", VA = "0x180ACB290", Slot = "10")]
		private bool DRKPYICDKEI()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal static class IGLVXCQXUAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x89F2C20", Offset = "0x89F1420", VA = "0x1889F2C20")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public LKKROKFZAWP UEIEJSDGUZF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x89F75F0", Offset = "0x89F5DF0", VA = "0x1889F75F0", Slot = "7")]
		public void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x89F7420", Offset = "0x89F5C20", VA = "0x1889F7420", Slot = "6")]
		public FLAXIIDFDDM EIXMERDYXEB(RigidbodyEx a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x89F53E0", Offset = "0x89F3BE0", VA = "0x1889F53E0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x89F5460", Offset = "0x89F3C60", VA = "0x1889F5460")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x89F5400", Offset = "0x89F3C00", VA = "0x1889F5400")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string message, [Optional] UnityEngine.Object context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x89F5550", Offset = "0x89F3D50", VA = "0x1889F5550")]
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
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "7")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAAF430", Offset = "0xAADC30", VA = "0x180AAF430", Slot = "4")]
			public Vector3 PEGDFRBXTAK()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAAF430", Offset = "0xAADC30", VA = "0x180AAF430", Slot = "5")]
			public Vector3 IHVZXTDRDNH()
			{
				return default(Vector3);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "6")]
			public bool XASGAWYFNAQ(float a, float b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public AHBOTGTGLEL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static ZMTWMPCAWEU FUULMSDNKLE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x89F02C0", Offset = "0x89EEAC0", VA = "0x1889F02C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "22")]
			get
			{
				return default(ObjectLocalId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public MPIPBSKHYUA WDUYFRVXQCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xBB29C0", Offset = "0xBB11C0", VA = "0x180BB29C0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xBB1AB0", Offset = "0xBB02B0", VA = "0x180BB1AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GameObject GQVQNJZVHPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xAA9D50", Offset = "0xAA8550", VA = "0x180AA9D50", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAA9D10", Offset = "0xAA8510", VA = "0x180AA9D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Transform YTQQQFYHIEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xC37940", Offset = "0xC36140", VA = "0x180C37940", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xD10010", Offset = "0xD0E810", VA = "0x180D10010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public Rigidbody BGOHCCWKOGX
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x8A01FA0", Offset = "0x8A007A0", VA = "0x188A01FA0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public FLAXIIDFDDM KYXHYZREABR
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8A00470", Offset = "0x89FEC70", VA = "0x188A00470", Slot = "27")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8A035A0", Offset = "0x8A01DA0", VA = "0x188A035A0", Slot = "28")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int DINRXQBFBGC
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x89FF2F0", Offset = "0x89FDAF0", VA = "0x1889FF2F0", Slot = "31")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public FLAXIIDFDDM XQVYPEOBNLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8A01640", Offset = "0x89FFE40", VA = "0x188A01640", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool MDJGMOLRPTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x89FEF30", Offset = "0x89FD730", VA = "0x1889FEF30", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool KHFMOKTPUJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8A03440", Offset = "0x8A01C40", VA = "0x188A03440", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool EHUTLADODAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8A00090", Offset = "0x89FE890", VA = "0x188A00090", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public ZMTWMPCAWEU EWXOLEHLJQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8A007C0", Offset = "0x89FEFC0", VA = "0x188A007C0", Slot = "35")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8A01810", Offset = "0x8A00010", VA = "0x188A01810", Slot = "36")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public RTQGHSHOPHZ XIHZDOJZUOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x89FD3D0", Offset = "0x89FBBD0", VA = "0x1889FD3D0", Slot = "37")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x89FE790", Offset = "0x89FCF90", VA = "0x1889FE790", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public float FNDQULDQCMQ
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x89FF410", Offset = "0x89FDC10", VA = "0x1889FF410", Slot = "39")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8A02490", Offset = "0x8A00C90", VA = "0x188A02490", Slot = "40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 WBDPTOWQUSF
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8A006E0", Offset = "0x89FEEE0", VA = "0x188A006E0", Slot = "41")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x8A02A10", Offset = "0x8A01210", VA = "0x188A02A10", Slot = "42")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 GHLUXTSNDMP
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8A01060", Offset = "0x89FF860", VA = "0x188A01060", Slot = "43")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8A01FF0", Offset = "0x8A007F0", VA = "0x188A01FF0", Slot = "44")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 FITKFMCGXGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x8A00520", Offset = "0x89FED20", VA = "0x188A00520", Slot = "45")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8A023B0", Offset = "0x8A00BB0", VA = "0x188A023B0", Slot = "46")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 IGQBUSPCNOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x89FF850", Offset = "0x89FE050", VA = "0x1889FF850", Slot = "47")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x89FD2F0", Offset = "0x89FBAF0", VA = "0x1889FD2F0", Slot = "48")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool VVHPMWWZGDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8A033F0", Offset = "0x8A01BF0", VA = "0x188A033F0", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool THYCZDLZSXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x8A02DF0", Offset = "0x8A015F0", VA = "0x188A02DF0", Slot = "50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool HONUZQFNXYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x89FDE70", Offset = "0x89FC670", VA = "0x1889FDE70", Slot = "51")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool NYZKQSIKQLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x89FF1C0", Offset = "0x89FD9C0", VA = "0x1889FF1C0", Slot = "52")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public Vector3 JIEBZKHYMFC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x89FF460", Offset = "0x89FDC60", VA = "0x1889FF460", Slot = "53")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Vector3 JZAYFVJXHHW
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x89FF210", Offset = "0x89FDA10", VA = "0x1889FF210", Slot = "54")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector3 WBMMJBJGBHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x8A028E0", Offset = "0x8A010E0", VA = "0x188A028E0", Slot = "55")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8A016F0", Offset = "0x89FFEF0", VA = "0x188A016F0", Slot = "56")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector3 BODXQJLKRUB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8A01A30", Offset = "0x8A00230", VA = "0x188A01A30", Slot = "57")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public float JTOZPLOYRVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x89FE950", Offset = "0x89FD150", VA = "0x1889FE950", Slot = "58")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public float NNIRLUFQVOE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x89FE320", Offset = "0x89FCB20", VA = "0x1889FE320", Slot = "59")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x89FD480", Offset = "0x89FBC80", VA = "0x1889FD480", Slot = "60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector3 BWAHXXTTQNA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8A00B40", Offset = "0x89FF340", VA = "0x188A00B40", Slot = "61")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Quaternion OEVTXFXHXNS
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8A022A0", Offset = "0x8A00AA0", VA = "0x188A022A0", Slot = "62")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public float KIZNHPRTSWF
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x8A026C0", Offset = "0x8A00EC0", VA = "0x188A026C0", Slot = "64")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x89FE6D0", Offset = "0x89FCED0", VA = "0x1889FE6D0", Slot = "65")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public float KPDYGHQRDQJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x8A03780", Offset = "0x8A01F80", VA = "0x188A03780", Slot = "66")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x8A03490", Offset = "0x8A01C90", VA = "0x188A03490", Slot = "67")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool KYJNNQJYWLC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x8A009F0", Offset = "0x89FF1F0", VA = "0x188A009F0", Slot = "68")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x8A00990", Offset = "0x89FF190", VA = "0x188A00990", Slot = "69")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public TransformTrackRate UKACRFWZOII
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x8A036C0", Offset = "0x8A01EC0", VA = "0x188A036C0", Slot = "70")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x8A02710", Offset = "0x8A00F10", VA = "0x188A02710", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool PSMKSNHRWPK
		{
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x89FE7F0", Offset = "0x89FCFF0", VA = "0x1889FE7F0", Slot = "72")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Transform SIWRJIGIFJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xC37940", Offset = "0xC36140", VA = "0x180C37940", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector3 QMBEDJTHAPA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x8A001E0", Offset = "0x89FE9E0", VA = "0x188A001E0", Slot = "74")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x8A008E0", Offset = "0x89FF0E0", VA = "0x188A008E0", Slot = "75")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float DFKTCQSGONC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x8A02D30", Offset = "0x8A01530", VA = "0x188A02D30", Slot = "76")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8A027D0", Offset = "0x8A00FD0", VA = "0x188A027D0", Slot = "77")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float KGIUASCOKEX
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x8A02C60", Offset = "0x8A01460", VA = "0x188A02C60", Slot = "78")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x89FD930", Offset = "0x89FC130", VA = "0x1889FD930", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Quaternion OZAVPLTBBCL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x89FFC30", Offset = "0x89FE430", VA = "0x1889FFC30", Slot = "80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x89FE030", Offset = "0x89FC830", VA = "0x1889FE030", Slot = "81")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector3 YDDTOFVMNHD
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x8A017D0", Offset = "0x89FFFD0", VA = "0x188A017D0", Slot = "82")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x89FEE90", Offset = "0x89FD690", VA = "0x1889FEE90", Slot = "83")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Quaternion HKVUIACYTTW
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x8A01F60", Offset = "0x8A00760", VA = "0x188A01F60", Slot = "84")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x8A01900", Offset = "0x8A00100", VA = "0x188A01900", Slot = "85")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public RigidbodyConstraints VHDDUGYFSQJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x8A02130", Offset = "0x8A00930", VA = "0x188A02130", Slot = "86")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x89FE730", Offset = "0x89FCF30", VA = "0x1889FE730", Slot = "87")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool GTXRIZMIKHU
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8A01200", Offset = "0x89FFA00", VA = "0x188A01200", Slot = "88")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x89FED50", Offset = "0x89FD550", VA = "0x1889FED50", Slot = "89")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public CollisionDetectionMode UWKYBWBMPLV
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x89FE2D0", Offset = "0x89FCAD0", VA = "0x1889FE2D0", Slot = "90")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x89FFBD0", Offset = "0x89FE3D0", VA = "0x1889FFBD0", Slot = "91")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool GBCQTREPYTA
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x8A01C10", Offset = "0x8A00410", VA = "0x188A01C10", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool RGJPKLDBPPH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x89FFA50", Offset = "0x89FE250", VA = "0x1889FFA50", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event RbexAction TPHRZPYKYMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x89FF360", Offset = "0x89FDB60", VA = "0x1889FF360", Slot = "4")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8A020D0", Offset = "0x8A008D0", VA = "0x188A020D0", Slot = "5")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event RbexAction BUHZDFMKFIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8A02BA0", Offset = "0x8A013A0", VA = "0x188A02BA0", Slot = "6")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8A02240", Offset = "0x8A00A40", VA = "0x188A02240", Slot = "7")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event RbexParentChangeAction BOMWDECCPLX
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8A02AF0", Offset = "0x8A012F0", VA = "0x188A02AF0", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8A01F00", Offset = "0x8A00700", VA = "0x188A01F00", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event RbexAction CCLOKUJHAJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8A02660", Offset = "0x8A00E60", VA = "0x188A02660", Slot = "8")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8A02600", Offset = "0x8A00E00", VA = "0x188A02600", Slot = "9")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event RbexAction NIKMCVBLYZB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x8A02D90", Offset = "0x8A01590", VA = "0x188A02D90", Slot = "14")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x8A00030", Offset = "0x89FE830", VA = "0x188A00030", Slot = "15")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event RbexAction OTUPUUBHMDM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x89FD420", Offset = "0x89FBC20", VA = "0x1889FD420", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x89FE170", Offset = "0x89FC970", VA = "0x1889FE170", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<UpdateLOD, UpdateLOD> EHNWSTRYUOF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x8A02770", Offset = "0x8A00F70", VA = "0x188A02770", Slot = "20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x89FD290", Offset = "0x89FBA90", VA = "0x1889FD290", Slot = "21")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event RbexAction SOFVDXQITKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x89FE9A0", Offset = "0x89FD1A0", VA = "0x1889FE9A0", Slot = "12")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x89FE110", Offset = "0x89FC910", VA = "0x1889FE110", Slot = "13")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event RbexAction ITVOCFFSDDD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x89FFEB0", Offset = "0x89FE6B0", VA = "0x1889FFEB0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x89FD710", Offset = "0x89FBF10", VA = "0x1889FD710", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8A03940", Offset = "0x8A02140", VA = "0x188A03940")]
		public TMFOVSNWHWZ(GameObject a, RigidbodyEx b, LVGTUOGKEEX c, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8A02E50", Offset = "0x8A01650", VA = "0x188A02E50", Slot = "139")]
		protected virtual void YDKCNNDQEKT(LVGTUOGKEEX a, RigidbodyExData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x89FE1D0", Offset = "0x89FC9D0", VA = "0x1889FE1D0", Slot = "140")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x89FD4E0", Offset = "0x89FBCE0", VA = "0x1889FD4E0", Slot = "93")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8A015B0", Offset = "0x89FFDB0", VA = "0x188A015B0", Slot = "94")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8A01500", Offset = "0x89FFD00", VA = "0x188A01500", Slot = "95")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8A014E0", Offset = "0x89FFCE0", VA = "0x188A014E0", Slot = "96")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x89FDB00", Offset = "0x89FC300", VA = "0x1889FDB00")]
		private void CXFMMMVEQTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8A02860", Offset = "0x8A01060", VA = "0x188A02860")]
		private void VSZCNDHGSXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x89FDA30", Offset = "0x89FC230", VA = "0x1889FDA30")]
		private void CGJURPXSKBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8A01250", Offset = "0x89FFA50", VA = "0x188A01250", Slot = "30")]
		public FLAXIIDFDDM OORXWWIMDMR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8A02180", Offset = "0x8A00980", VA = "0x188A02180", Slot = "98")]
		public void SetParent(FLAXIIDFDDM value, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8A02C00", Offset = "0x8A01400", VA = "0x188A02C00", Slot = "99")]
		public void WKZFPRWTMYK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8A011A0", Offset = "0x89FF9A0", VA = "0x188A011A0", Slot = "100")]
		public void OAPHFDHNVUZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8A00A40", Offset = "0x89FF240", VA = "0x188A00A40", Slot = "101")]
		public Vector3 NIOYPYEQKWQ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x89FE5D0", Offset = "0x89FCDD0", VA = "0x1889FE5D0", Slot = "102")]
		public Vector3 ELLRGFOLSLU(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8A02B50", Offset = "0x8A01350", VA = "0x188A02B50", Slot = "103")]
		public void WDLTQJCFAFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x89FF170", Offset = "0x89FD970", VA = "0x1889FF170", Slot = "104")]
		public void GOUKBDOZGZQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8A002E0", Offset = "0x89FEAE0", VA = "0x188A002E0", Slot = "105")]
		public void KRGSPSWJWCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x89FDD80", Offset = "0x89FC580", VA = "0x1889FDD80", Slot = "106")]
		public void CZIRHLUKVQH(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x89FD620", Offset = "0x89FBE20", VA = "0x1889FD620", Slot = "107")]
		public void BGBOOAVERTQ(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8A00600", Offset = "0x89FEE00", VA = "0x188A00600", Slot = "108")]
		public void LRKHYJRZYNR(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8A03600", Offset = "0x8A01E00", VA = "0x188A03600", Slot = "109")]
		public void ZNUBIDZFUEL(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8A01930", Offset = "0x8A00130", VA = "0x188A01930", Slot = "110")]
		public void RJBOBMTNCPE(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x89FEF90", Offset = "0x89FD790", VA = "0x1889FEF90", Slot = "111")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void GMGTXVVWBAV(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8A032F0", Offset = "0x8A01AF0", VA = "0x188A032F0", Slot = "112")]
		public Vector3 YGKWEEYFHPK(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8A01B10", Offset = "0x8A00310", VA = "0x188A01B10", Slot = "113")]
		public Vector3 RLOSZECUKFO(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8A02CE0", Offset = "0x8A014E0", VA = "0x188A02CE0", Slot = "114")]
		public void XKQXRAVLLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8A02C70", Offset = "0x8A01470", VA = "0x188A02C70", Slot = "115")]
		public void WSQQGLUCVKP(FLAXIIDFDDM a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8A01EA0", Offset = "0x8A006A0", VA = "0x188A01EA0", Slot = "116")]
		public void SBAFROQWRGY(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x89FDF50", Offset = "0x89FC750", VA = "0x1889FDF50", Slot = "63")]
		public void DJVGOIHFCUE((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x89FD8E0", Offset = "0x89FC0E0", VA = "0x1889FD8E0", Slot = "117")]
		public void BWIMOVRHZTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8A02D40", Offset = "0x8A01540", VA = "0x188A02D40", Slot = "118")]
		public void XVKONZDITXB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8A00290", Offset = "0x89FEA90", VA = "0x188A00290", Slot = "119")]
		public void KHMNBOKGZJY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8A029C0", Offset = "0x8A011C0", VA = "0x188A029C0", Slot = "120")]
		public bool VZRYQKTJZDM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8A021F0", Offset = "0x8A009F0", VA = "0x188A021F0", Slot = "97")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x89FDA90", Offset = "0x89FC290", VA = "0x1889FDA90", Slot = "121")]
		public void CSIVDQEXQWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x89FE570", Offset = "0x89FCD70", VA = "0x1889FE570", Slot = "122")]
		public void EHRMZIGLHUP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8A01690", Offset = "0x89FFE90", VA = "0x188A01690", Slot = "123")]
		public void PTXZWXHRDJK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8A03710", Offset = "0x8A01F10", VA = "0x188A03710", Slot = "124")]
		public void ZWMPMWMKJUO(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x89FE370", Offset = "0x89FCB70", VA = "0x1889FE370", Slot = "125")]
		public void EHFYBMOAIES(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8A013B0", Offset = "0x89FFBB0", VA = "0x188A013B0", Slot = "126")]
		public void OXMDDROJNKK(Vector3 a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x89FF3C0", Offset = "0x89FDBC0", VA = "0x1889FF3C0", Slot = "127")]
		public bool HPJZVLREOYZ(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8A01140", Offset = "0x89FF940", VA = "0x188A01140", Slot = "128")]
		public void NSPEYYRNIAS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8A004C0", Offset = "0x89FECC0", VA = "0x188A004C0", Slot = "129")]
		public void LKKPBETUOBJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x89FEED0", Offset = "0x89FD6D0", VA = "0x1889FEED0", Slot = "130")]
		public void GJPYSWLQTCE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8A00330", Offset = "0x89FEB30", VA = "0x188A00330", Slot = "131")]
		public void KVFFGSXRTDB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x89FEDB0", Offset = "0x89FD5B0", VA = "0x1889FEDB0", Slot = "132")]
		public void FYMUGNLOQGB(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x89FE840", Offset = "0x89FD040", VA = "0x1889FE840", Slot = "133")]
		public void FAHMGMBFGJJ(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8A012D0", Offset = "0x89FFAD0", VA = "0x188A012D0", Slot = "134")]
		public void ORBAMLWUUBS(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8A00390", Offset = "0x89FEB90", VA = "0x188A00390", Slot = "135")]
		public void LEUZHWFIWEU(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8A000E0", Offset = "0x89FE8E0", VA = "0x188A000E0", Slot = "136")]
		public bool JYAJLSHIFHT(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8A01560", Offset = "0x89FFD60", VA = "0x188A01560", Slot = "137")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8A02370", Offset = "0x8A00B70", VA = "0x188A02370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x89FFF60", Offset = "0x89FE760", VA = "0x1889FFF60")]
		private void JHSJIJJYFWD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8A024F0", Offset = "0x8A00CF0", VA = "0x188A024F0")]
		private void URWLYLASINP(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x89FFCD0", Offset = "0x89FE4D0", VA = "0x1889FFCD0")]
		private void IZYZCTKGHDA(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8A034F0", Offset = "0x8A01CF0", VA = "0x188A034F0")]
		private void ZKLLSDRBKDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x89FD7C0", Offset = "0x89FBFC0", VA = "0x1889FD7C0")]
		private void BVRRWFXEDOQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8A03140", Offset = "0x8A01940", VA = "0x188A03140")]
		private void YGKGGDYZMNU(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x89FF0A0", Offset = "0x89FD8A0", VA = "0x1889FF0A0")]
		private void GMLMPTPRJDD(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8A00810", Offset = "0x89FF010", VA = "0x188A00810")]
		private void MMRWLDTBIUN(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8A01D50", Offset = "0x8A00550", VA = "0x188A01D50")]
		private void RXDFCKOMKTC(MPIPBSKHYUA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8A00C20", Offset = "0x89FF420", VA = "0x188A00C20", Slot = "142")]
		protected virtual void NLRBFCGOFCF(MPIPBSKHYUA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x89FF530", Offset = "0x89FDD30", VA = "0x1889FF530")]
		protected void IBQGSYWTTEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x89FEA00", Offset = "0x89FD200", VA = "0x1889FEA00")]
		protected void FOHMUILLKIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x89FF930", Offset = "0x89FE130", VA = "0x1889FF930")]
		private void IMBCTFITRWF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8A037D0", Offset = "0x8A01FD0", VA = "0x188A037D0")]
		private void ZXJZNPUHDKQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal static class CXJAAGTVQRF
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x89F04E0", Offset = "0x89EECE0", VA = "0x1889F04E0")]
		public static FLAXIIDFDDM NVABNPJHAGQ(this FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x89F05A0", Offset = "0x89EEDA0", VA = "0x1889F05A0")]
		public static bool WXPRPKYFALN(this FLAXIIDFDDM a, FLAXIIDFDDM b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x89F0440", Offset = "0x89EEC40", VA = "0x1889F0440")]
		public static bool NSYVWGVSOAN(this FLAXIIDFDDM a, FLAXIIDFDDM b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x89F03F0", Offset = "0x89EEBF0", VA = "0x1889F03F0")]
		public static MPIPBSKHYUA GPAQUCNVSLX(this FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x89F0380", Offset = "0x89EEB80", VA = "0x1889F0380")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A04AE0", Offset = "0x8A032E0", VA = "0x188A04AE0", Slot = "19")]
		public FLAXIIDFDDM EIXMERDYXEB(RigidbodyEx a, RigidbodyExData b, LVGTUOGKEEX c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "4")]
		public KCMFVCQXRWS AGKELJEYDWO(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "5")]
		public ADQTVWKPJFC GHHNEVLNTRW(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "6")]
		public TKDKXZQKCER QWJAEOHOEJL(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "7")]
		public BJLDBBWNAOS CNJNSJGHUZQ(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "8")]
		public IMTJMUAGWWG NZIASXSWIHA(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "9")]
		public OFAILNGDQYV TVVWQAKQNCB(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "10")]
		public LTSLVRFELFC QMSBCYLSWCY(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "11")]
		public SEUTCTARQZA CDIIVCWKQEW(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "12")]
		public YPRXVLQAWAI FWKSLCZEVXS(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "13")]
		public CXWEJHDDATZ TUNQPXTMRDZ(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0")]
		public GSTISZZNMWT NSHNSFRDTNF(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0")]
		public YXGCDGIWJWJ IRISATZYHZP(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0")]
		public OHVJDROOUGD YWLDUFFCHOL(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0")]
		public YETDUGNTKHL RUGBDILHSOR(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0")]
		public ZBZZLINQTMF BZLMIMVZUUV(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public WDSDLHDRQBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "14")]
		private GSTISZZNMWT EQOAJOXWDGP(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "15")]
		private YXGCDGIWJWJ FWNGOTWDJMF(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "16")]
		private OHVJDROOUGD HNOKAZSOIZF(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "17")]
		private YETDUGNTKHL LKUNRPMVPQN(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0x89F1B80", Offset = "0x89F0380", VA = "0x1889F1B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x89F2080", Offset = "0x89F0880", VA = "0x1889F2080", Slot = "20")]
		public void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x89F18F0", Offset = "0x89F00F0", VA = "0x1889F18F0", Slot = "4")]
		public KCMFVCQXRWS AGKELJEYDWO(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x89F1F30", Offset = "0x89F0730", VA = "0x1889F1F30", Slot = "5")]
		public ADQTVWKPJFC GHHNEVLNTRW(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x89F22C0", Offset = "0x89F0AC0", VA = "0x1889F22C0", Slot = "6")]
		public TKDKXZQKCER QWJAEOHOEJL(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x89F1AE0", Offset = "0x89F02E0", VA = "0x1889F1AE0", Slot = "7")]
		public BJLDBBWNAOS CNJNSJGHUZQ(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x89F2180", Offset = "0x89F0980", VA = "0x1889F2180", Slot = "8")]
		public IMTJMUAGWWG NZIASXSWIHA(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x89F2400", Offset = "0x89F0C00", VA = "0x1889F2400", Slot = "9")]
		public OFAILNGDQYV TVVWQAKQNCB(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x89F2220", Offset = "0x89F0A20", VA = "0x1889F2220", Slot = "10")]
		public LTSLVRFELFC QMSBCYLSWCY(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x89F1A40", Offset = "0x89F0240", VA = "0x1889F1A40", Slot = "11")]
		public SEUTCTARQZA CDIIVCWKQEW(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x89F1DE0", Offset = "0x89F05E0", VA = "0x1889F1DE0", Slot = "12")]
		public YPRXVLQAWAI FWKSLCZEVXS(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x89F2360", Offset = "0x89F0B60", VA = "0x1889F2360", Slot = "13")]
		public CXWEJHDDATZ TUNQPXTMRDZ(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x89F1D30", Offset = "0x89F0530", VA = "0x1889F1D30")]
		public GSTISZZNMWT NSHNSFRDTNF(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x89F1E80", Offset = "0x89F0680", VA = "0x1889F1E80")]
		public YXGCDGIWJWJ IRISATZYHZP(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x89F1FD0", Offset = "0x89F07D0", VA = "0x1889F1FD0")]
		public OHVJDROOUGD YWLDUFFCHOL(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x89F20D0", Offset = "0x89F08D0", VA = "0x1889F20D0")]
		public YETDUGNTKHL RUGBDILHSOR(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x89F1990", Offset = "0x89F0190", VA = "0x1889F1990")]
		public ZBZZLINQTMF BZLMIMVZUUV(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x89F1BE0", Offset = "0x89F03E0", VA = "0x1889F1BE0", Slot = "19")]
		public FLAXIIDFDDM EIXMERDYXEB(RigidbodyEx a, RigidbodyExData b, LVGTUOGKEEX c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x89F24A0", Offset = "0x89F0CA0", VA = "0x1889F24A0")]
		public GTETPMZYZEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x89F1D30", Offset = "0x89F0530", VA = "0x1889F1D30", Slot = "14")]
		private GSTISZZNMWT EQOAJOXWDGP(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x89F1E80", Offset = "0x89F0680", VA = "0x1889F1E80", Slot = "15")]
		private YXGCDGIWJWJ FWNGOTWDJMF(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x89F1FD0", Offset = "0x89F07D0", VA = "0x1889F1FD0", Slot = "16")]
		private OHVJDROOUGD HNOKAZSOIZF(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x89F20D0", Offset = "0x89F08D0", VA = "0x1889F20D0", Slot = "17")]
		private YETDUGNTKHL LKUNRPMVPQN(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x89F1990", Offset = "0x89F0190", VA = "0x1889F1990", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0x89FD230", Offset = "0x89FBA30", VA = "0x1889FD230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public CollisionDetectionMode UWKYBWBMPLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x89FCDA0", Offset = "0x89FB5A0", VA = "0x1889FCDA0", Slot = "4")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x89FCEB0", Offset = "0x89FB6B0", VA = "0x1889FCEB0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x89F41F0", Offset = "0x89F29F0", VA = "0x1889F41F0")]
		public SRLNTUBRUQR(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x89FCC90", Offset = "0x89FB490", VA = "0x1889FCC90", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x89FD1B0", Offset = "0x89FB9B0", VA = "0x1889FD1B0", Slot = "9")]
		public void MYVGUYFYLGS(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x89FD080", Offset = "0x89FB880", VA = "0x1889FD080", Slot = "7")]
		public void LGTBLRGOYZX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x89FD280", Offset = "0x89FBA80", VA = "0x1889FD280", Slot = "8")]
		public void ZZDMRWJOTIQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x89FCF20", Offset = "0x89FB720", VA = "0x1889FCF20", Slot = "10")]
		public bool JYAJLSHIFHT(Vector3 a, [Out] RaycastHit b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x89FD090", Offset = "0x89FB890", VA = "0x1889FD090")]
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
			[Cpp2IlInjected.Address(RVA = "0x89F2A50", Offset = "0x89F1250", VA = "0x1889F2A50", Slot = "6")]
			get
			{
				return default(TransformTrackRate);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x89F28D0", Offset = "0x89F10D0", VA = "0x1889F28D0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		private Transform CCJDXPXRUFF
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x89F2860", Offset = "0x89F1060", VA = "0x1889F2860", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<UpdateLOD, UpdateLOD> EHNWSTRYUOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x89F29A0", Offset = "0x89F11A0", VA = "0x1889F29A0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x89F2540", Offset = "0x89F0D40", VA = "0x1889F2540", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x89F2B90", Offset = "0x89F1390", VA = "0x1889F2B90")]
		public HPYJFACIVJM(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x89F25F0", Offset = "0x89F0DF0", VA = "0x1889F25F0", Slot = "8")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x89F2880", Offset = "0x89F1080", VA = "0x1889F2880", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x10E9000", Offset = "0x10E7800", VA = "0x1810E9000", Slot = "11")]
		private void NKKTYLINKYM(UpdateLOD a, UpdateLOD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "12")]
		private void XCYYSXNOBKU(bool a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class WDSDLHDRQBO : LKKROKFZAWP
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8A04800", Offset = "0x8A03000", VA = "0x188A04800", Slot = "4")]
		public KCMFVCQXRWS AGKELJEYDWO(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8A05010", Offset = "0x8A03810", VA = "0x188A05010", Slot = "5")]
		public ADQTVWKPJFC GHHNEVLNTRW(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8A05590", Offset = "0x8A03D90", VA = "0x188A05590", Slot = "6")]
		public TKDKXZQKCER QWJAEOHOEJL(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8A04A70", Offset = "0x8A03270", VA = "0x188A04A70", Slot = "7")]
		public BJLDBBWNAOS CNJNSJGHUZQ(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x8A053C0", Offset = "0x8A03BC0", VA = "0x188A053C0", Slot = "8")]
		public IMTJMUAGWWG NZIASXSWIHA(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8A05770", Offset = "0x8A03F70", VA = "0x188A05770", Slot = "9")]
		public OFAILNGDQYV TVVWQAKQNCB(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8A05480", Offset = "0x8A03C80", VA = "0x188A05480", Slot = "10")]
		public LTSLVRFELFC QMSBCYLSWCY(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8A049B0", Offset = "0x8A031B0", VA = "0x188A049B0", Slot = "11")]
		public SEUTCTARQZA CDIIVCWKQEW(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x8A04DD0", Offset = "0x8A035D0", VA = "0x188A04DD0", Slot = "12")]
		public YPRXVLQAWAI FWKSLCZEVXS(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x8A056B0", Offset = "0x8A03EB0", VA = "0x188A056B0", Slot = "13")]
		public CXWEJHDDATZ TUNQPXTMRDZ(FLAXIIDFDDM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8A04CB0", Offset = "0x8A034B0", VA = "0x188A04CB0")]
		public GSTISZZNMWT NSHNSFRDTNF(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8A04E90", Offset = "0x8A03690", VA = "0x188A04E90")]
		public YXGCDGIWJWJ IRISATZYHZP(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8A05120", Offset = "0x8A03920", VA = "0x188A05120")]
		public OHVJDROOUGD YWLDUFFCHOL(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8A05240", Offset = "0x8A03A40", VA = "0x188A05240")]
		public YETDUGNTKHL RUGBDILHSOR(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8A048E0", Offset = "0x8A030E0", VA = "0x188A048E0")]
		public ZBZZLINQTMF BZLMIMVZUUV(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8A04B70", Offset = "0x8A03370", VA = "0x188A04B70", Slot = "19")]
		public FLAXIIDFDDM EIXMERDYXEB(RigidbodyEx a, RigidbodyExData b, LVGTUOGKEEX c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public WDSDLHDRQBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8A04CB0", Offset = "0x8A034B0", VA = "0x188A04CB0", Slot = "14")]
		private GSTISZZNMWT EQOAJOXWDGP(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8A04E90", Offset = "0x8A03690", VA = "0x188A04E90", Slot = "15")]
		private YXGCDGIWJWJ FWNGOTWDJMF(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8A05120", Offset = "0x8A03920", VA = "0x188A05120", Slot = "16")]
		private OHVJDROOUGD HNOKAZSOIZF(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8A05240", Offset = "0x8A03A40", VA = "0x188A05240", Slot = "17")]
		private YETDUGNTKHL LKUNRPMVPQN(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8A048E0", Offset = "0x8A030E0", VA = "0x188A048E0", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0x89FD230", Offset = "0x89FBA30", VA = "0x1889FD230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private bool PSMKSNHRWPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x8A03AF0", Offset = "0x8A022F0", VA = "0x188A03AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		private bool MDJGMOLRPTX
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x89EC8A0", Offset = "0x89EB0A0", VA = "0x1889EC8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		private FLAXIIDFDDM KYXHYZREABR
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x8A04180", Offset = "0x8A02980", VA = "0x188A04180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x89F41F0", Offset = "0x89F29F0", VA = "0x1889F41F0")]
		public VYMECNCZQBD(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x8A03DC0", Offset = "0x8A025C0", VA = "0x188A03DC0", Slot = "4")]
		public void FYMUGNLOQGB(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x8A045A0", Offset = "0x8A02DA0", VA = "0x188A045A0")]
		private void WTMSKMWCWAY(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8A03B40", Offset = "0x8A02340", VA = "0x188A03B40", Slot = "5")]
		public void FAHMGMBFGJJ(Vector3 a, Vector3 b, ForceMode c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x8A041E0", Offset = "0x8A029E0", VA = "0x188A041E0", Slot = "6")]
		public void ORBAMLWUUBS(Vector3 a, ForceMode b = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8A04340", Offset = "0x8A02B40", VA = "0x188A04340")]
		private void RDIFXOYHBBR(Vector3 a, ForceMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8A03F20", Offset = "0x8A02720", VA = "0x188A03F20", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xBE0F00", Offset = "0xBDF700", VA = "0x180BE0F00", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x89F40E0", Offset = "0x89F28E0", VA = "0x1889F40E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x89F41F0", Offset = "0x89F29F0", VA = "0x1889F41F0")]
		public KTUQHXTNXUI(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x89F40B0", Offset = "0x89F28B0", VA = "0x1889F40B0", Slot = "6")]
		public void MYVGUYFYLGS(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x89F4040", Offset = "0x89F2840", VA = "0x1889F4040", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x89F5910", Offset = "0x89F4110", VA = "0x1889F5910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public FLAXIIDFDDM KYXHYZREABR
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0xA9E130", Offset = "0xA9C930", VA = "0x180A9E130", Slot = "28")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x89F7360", Offset = "0x89F5B60", VA = "0x1889F7360", Slot = "29")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public FLAXIIDFDDM XQVYPEOBNLV
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9C980", VA = "0x180A9E180", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public IReadOnlyList<FLAXIIDFDDM> POFFWQKAIPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9C970", VA = "0x180A9E170", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000021")]
		public event RbexAction TPHRZPYKYMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x89F5A20", Offset = "0x89F4220", VA = "0x1889F5A20", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x89F6700", Offset = "0x89F4F00", VA = "0x1889F6700", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000022")]
		public event RbexAction BUHZDFMKFIV
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x89F72C0", Offset = "0x89F5AC0", VA = "0x1889F72C0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x89F6DB0", Offset = "0x89F55B0", VA = "0x1889F6DB0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000023")]
		public event RbexParentChangeAction BOMWDECCPLX
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x89F7220", Offset = "0x89F5A20", VA = "0x1889F7220", Slot = "12")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x89F65B0", Offset = "0x89F4DB0", VA = "0x1889F65B0", Slot = "13")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000024")]
		public event Action WWNVFWCCRLS
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x89F7180", Offset = "0x89F5980", VA = "0x1889F7180", Slot = "14")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x89F61E0", Offset = "0x89F49E0", VA = "0x1889F61E0", Slot = "15")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000025")]
		public event Action WKXUIJHWHSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x89F6280", Offset = "0x89F4A80", VA = "0x1889F6280", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x89F55A0", Offset = "0x89F3DA0", VA = "0x1889F55A0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000026")]
		public event Action<FLAXIIDFDDM> UJNELIJHYQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x89F6500", Offset = "0x89F4D00", VA = "0x1889F6500", Slot = "18")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x89F70D0", Offset = "0x89F58D0", VA = "0x1889F70D0", Slot = "19")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000027")]
		public event Action<FLAXIIDFDDM> MQCMUSECIZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x89F6320", Offset = "0x89F4B20", VA = "0x1889F6320", Slot = "20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x89F6650", Offset = "0x89F4E50", VA = "0x1889F6650", Slot = "21")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000028")]
		public event Action NPBZNEWFXSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x89F5730", Offset = "0x89F3F30", VA = "0x1889F5730", Slot = "22")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x89F5870", Offset = "0x89F4070", VA = "0x1889F5870", Slot = "23")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000029")]
		public event Action<FLAXIIDFDDM> KSZMLQJGEJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x89F5970", Offset = "0x89F4170", VA = "0x1889F5970", Slot = "24")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x89F5680", Offset = "0x89F3E80", VA = "0x1889F5680", Slot = "25")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x89F7370", Offset = "0x89F5B70", VA = "0x1889F7370")]
		public RbexHierarchy(FLAXIIDFDDM rbex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x89F57D0", Offset = "0x89F3FD0", VA = "0x1889F57D0", Slot = "31")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x89F67A0", Offset = "0x89F4FA0", VA = "0x1889F67A0", Slot = "30")]
		public void SetParent(FLAXIIDFDDM newParent, bool isPhysicallyDetachedOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x89F5C80", Offset = "0x89F4480", VA = "0x1889F5C80", Slot = "6")]
		public void IOZMECBOEKG(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x89F6E50", Offset = "0x89F5650", VA = "0x1889F6E50", Slot = "7")]
		public void VQCEJMBNPUT(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x89F5FB0", Offset = "0x89F47B0", VA = "0x1889F5FB0", Slot = "4")]
		public void JHPMQEXBLAQ(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x89F5AC0", Offset = "0x89F42C0", VA = "0x1889F5AC0", Slot = "5")]
		public void HSJKUHOTIDJ(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x89F6D10", Offset = "0x89F5510", VA = "0x1889F6D10")]
		private void TAPWDQGXPOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x89F5640", Offset = "0x89F3E40", VA = "0x1889F5640")]
		private void BDKIITRPAWV(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x89F60A0", Offset = "0x89F48A0", VA = "0x1889F60A0")]
		private void KNXOUHEPIWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x89F63D0", Offset = "0x89F4BD0", VA = "0x1889F63D0")]
		private void PLWRCWWUMZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x89F5B60", Offset = "0x89F4360", VA = "0x1889F5B60")]
		private void IOSXZUHFOMX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x89F5EF0", Offset = "0x89F46F0", VA = "0x1889F5EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A05830", Offset = "0x8A04030", VA = "0x188A05830")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 JIEBZKHYMFC
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x89F0CE0", Offset = "0x89EF4E0", VA = "0x1889F0CE0", Slot = "6")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 JZAYFVJXHHW
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x89F09E0", Offset = "0x89EF1E0", VA = "0x1889F09E0", Slot = "7")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		private Vector3 FITKFMCGXGG
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x89F0DC0", Offset = "0x89EF5C0", VA = "0x1889F0DC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public FLAXIIDFDDM TJTCNDRUGZR
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x89F0D10", Offset = "0x89EF510", VA = "0x1889F0D10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x89F1310", Offset = "0x89EFB10", VA = "0x1889F1310")]
		public GEKRHZYGGOS(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x89F1240", Offset = "0x89EFA40", VA = "0x1889F1240", Slot = "8")]
		public void ULVFIXJDPVQ(FLAXIIDFDDM a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x89F12B0", Offset = "0x89EFAB0", VA = "0x1889F12B0", Slot = "9")]
		public void XUZZTJUGMUX(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x89F0640", Offset = "0x89EEE40", VA = "0x1889F0640")]
		private Vector3 CNWOFOQUDOK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x89F0EA0", Offset = "0x89EF6A0", VA = "0x1889F0EA0")]
		private void UGOJQEGZOVZ(FLAXIIDFDDM a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal static class LMLLHXMFGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x89F4280", Offset = "0x89F2A80", VA = "0x1889F4280")]
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
			[Cpp2IlInjected.Address(RVA = "0x1CB9950", Offset = "0x1CB8150", VA = "0x181CB9950", Slot = "7")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x8A06D90", Offset = "0x8A05590", VA = "0x188A06D90", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Vector3 BODXQJLKRUB
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x8A06E40", Offset = "0x8A05640", VA = "0x188A06E40", Slot = "9")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public float JTOZPLOYRVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0xAF0590", Offset = "0xAEED90", VA = "0x180AF0590", Slot = "10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x8A05FB0", Offset = "0x8A047B0", VA = "0x188A05FB0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public float NNIRLUFQVOE
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xAF05A0", Offset = "0xAEEDA0", VA = "0x180AF05A0", Slot = "11")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x8A05A10", Offset = "0x8A04210", VA = "0x188A05A10", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public Vector3 BWAHXXTTQNA
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x8A06740", Offset = "0x8A04F40", VA = "0x188A06740", Slot = "13")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Quaternion OEVTXFXHXNS
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x8A06F60", Offset = "0x8A05760", VA = "0x188A06F60", Slot = "14")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		private Rigidbody BGOHCCWKOGX
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x89F3550", Offset = "0x89F1D50", VA = "0x1889F3550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002A")]
		public event RbexAction QBJCGGCHEAR
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8A060C0", Offset = "0x8A048C0", VA = "0x188A060C0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0x8A07F50", Offset = "0x8A06750", VA = "0x188A07F50", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x8A080D0", Offset = "0x8A068D0", VA = "0x188A080D0")]
		public XDGGMVWADDS(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x8A05AC0", Offset = "0x8A042C0", VA = "0x188A05AC0", Slot = "17")]
		public void BWIMOVRHZTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x8A07FF0", Offset = "0x8A067F0", VA = "0x188A07FF0", Slot = "16")]
		public void XVKONZDITXB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8A06660", Offset = "0x8A04E60", VA = "0x188A06660", Slot = "19")]
		public void MYVGUYFYLGS(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8A06300", Offset = "0x8A04B00", VA = "0x188A06300", Slot = "20")]
		public void LEEORNZPXDZ(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x8A06160", Offset = "0x8A04960", VA = "0x188A06160", Slot = "18")]
		public void KHMNBOKGZJY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x8A068D0", Offset = "0x8A050D0", VA = "0x188A068D0", Slot = "21")]
		public void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x8A06D90", Offset = "0x8A05590", VA = "0x188A06D90")]
		private void ZGSMLWBXDGA(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x8A058F0", Offset = "0x8A040F0", VA = "0x188A058F0")]
		[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
		private Vector3 AUKKLZWCLLJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x8A05FB0", Offset = "0x8A047B0", VA = "0x188A05FB0")]
		private void GYJEESPYGNL(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8A05A10", Offset = "0x8A04210", VA = "0x188A05A10")]
		private void BRFDKABIRDQ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x8A05BE0", Offset = "0x8A043E0", VA = "0x188A05BE0")]
		private Vector3 DEPONVOEGOU()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x8A05D80", Offset = "0x8A04580", VA = "0x188A05D80", Slot = "15")]
		public void DJVGOIHFCUE((Quaternion rot, Vector3 moments) tensor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x8A064E0", Offset = "0x8A04CE0", VA = "0x188A064E0")]
		private Quaternion MJNWUPDXLQK()
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8A07E80", Offset = "0x8A06680", VA = "0x188A07E80")]
		public void XSWSNMHLISL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8A070E0", Offset = "0x8A058E0", VA = "0x188A070E0", Slot = "4")]
		public (float, Vector3) XSWSNMHLISL(Rigidbody a)
		{
			return default((float, Vector3));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal static class XODFLAIUMOK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8A08230", Offset = "0x8A06A30", VA = "0x188A08230")]
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
			[Cpp2IlInjected.Address(RVA = "0x183FC10", Offset = "0x183E410", VA = "0x18183FC10", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public RbexInterpolationMode FZFJHADPKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xAB0800", Offset = "0xAAF000", VA = "0x180AB0800", Slot = "11")]
			get
			{
				return default(RbexInterpolationMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F50", Offset = "0x89F2750", VA = "0x1889F3F50")]
		public KGFOFVETLGE(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x89F3940", Offset = "0x89F2140", VA = "0x1889F3940", Slot = "4")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x89F3B20", Offset = "0x89F2320", VA = "0x1889F3B20")]
		private bool JOOERGUDDNG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x89F3BC0", Offset = "0x89F23C0", VA = "0x1889F3BC0", Slot = "5")]
		public void KAIOZASSZTW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x89F3BF0", Offset = "0x89F23F0", VA = "0x1889F3BF0", Slot = "6")]
		public void TPBJKNPKSIL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x89F3C20", Offset = "0x89F2420", VA = "0x1889F3C20", Slot = "9")]
		public void XJJWUULXQRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x89F3A10", Offset = "0x89F2210", VA = "0x1889F3A10")]
		private void HZMAHMPDOPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x89F3D90", Offset = "0x89F2590", VA = "0x1889F3D90")]
		private void YJGHQLHTEMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F10", Offset = "0x89F2710", VA = "0x1889F3F10", Slot = "8")]
		public void YNAATAGMNHI(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x89F3D50", Offset = "0x89F2550", VA = "0x1889F3D50", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x89F14B0", Offset = "0x89EFCB0", VA = "0x1889F14B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002B")]
		public event RbexAction SOFVDXQITKE
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x89F1560", Offset = "0x89EFD60", VA = "0x1889F1560", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x89F1400", Offset = "0x89EFC00", VA = "0x1889F1400", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x89F1810", Offset = "0x89F0010", VA = "0x1889F1810")]
		public GJWDBJDOIVR(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x89F14A0", Offset = "0x89EFCA0", VA = "0x1889F14A0", Slot = "7")]
		public void EHRMZIGLHUP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x89F16B0", Offset = "0x89EFEB0", VA = "0x1889F16B0", Slot = "8")]
		public void PTXZWXHRDJK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x89F1700", Offset = "0x89EFF00", VA = "0x1889F1700", Slot = "9")]
		public void ZWMPMWMKJUO(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x89F16C0", Offset = "0x89EFEC0", VA = "0x1889F16C0", Slot = "12")]
		public void QYUUGTSGDGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x89F1630", Offset = "0x89EFE30", VA = "0x1889F1630", Slot = "10")]
		public void MYVGUYFYLGS(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x89F1600", Offset = "0x89EFE00", VA = "0x1889F1600", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool KHFMOKTPUJX
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x89F4FB0", Offset = "0x89F37B0", VA = "0x1889F4FB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool EHUTLADODAR
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xC9BBE0", Offset = "0xC9A3E0", VA = "0x180C9BBE0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002C")]
		public event RbexAction CCLOKUJHAJY
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x89F4DC0", Offset = "0x89F35C0", VA = "0x1889F4DC0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x89F4AB0", Offset = "0x89F32B0", VA = "0x1889F4AB0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x89F4FC0", Offset = "0x89F37C0", VA = "0x1889F4FC0")]
		public MZQZQQKGMBI(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x89F4440", Offset = "0x89F2C40", VA = "0x1889F4440", Slot = "9")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x89F4570", Offset = "0x89F2D70", VA = "0x1889F4570", Slot = "12")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x89F47D0", Offset = "0x89F2FD0", VA = "0x1889F47D0", Slot = "10")]
		public void GMLMPTPRJDD(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x89F4940", Offset = "0x89F3140", VA = "0x1889F4940", Slot = "11")]
		public void MMRWLDTBIUN(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x89F4660", Offset = "0x89F2E60", VA = "0x1889F4660")]
		private void FWPIMNXLUSL(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x89F4E60", Offset = "0x89F3660", VA = "0x1889F4E60")]
		private void VPQMHEPOSER(MPIPBSKHYUA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x89F4B50", Offset = "0x89F3350", VA = "0x1889F4B50")]
		private void UYHZUPZGVUK(RRNetworkView a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal static class UROMTEGXKUY
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8A03A30", Offset = "0x8A02230", VA = "0x188A03A30")]
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
			[Cpp2IlInjected.Address(RVA = "0xBEB590", Offset = "0xBE9D90", VA = "0x180BEB590", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0xBEAE00", Offset = "0xBE9600", VA = "0x180BEAE00", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool IZVNTIZYRSZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xBEB100", Offset = "0xBE9900", VA = "0x180BEB100", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xBEB2D0", Offset = "0xBE9AD0", VA = "0x180BEB2D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public RigidbodyConstraints VHDDUGYFSQJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xAA3180", Offset = "0xAA1980", VA = "0x180AA3180", Slot = "7")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x8A082F0", Offset = "0x8A06AF0", VA = "0x188A082F0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8A08480", Offset = "0x8A06C80", VA = "0x188A08480")]
		public YZJWTUYKLCQ(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8A08450", Offset = "0x8A06C50", VA = "0x188A08450", Slot = "9")]
		public void MYVGUYFYLGS(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8A08420", Offset = "0x8A06C20", VA = "0x188A08420", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0xAEF770", Offset = "0xAEDF70", VA = "0x180AEF770", Slot = "4")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x89F5110", Offset = "0x89F3910", VA = "0x1889F5110", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public float KPDYGHQRDQJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0xAEF760", Offset = "0xAEDF60", VA = "0x180AEF760", Slot = "6")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x89F52D0", Offset = "0x89F3AD0", VA = "0x1889F52D0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x89F53A0", Offset = "0x89F3BA0", VA = "0x1889F53A0")]
		public OQRNFMMYUCL(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x89F5280", Offset = "0x89F3A80", VA = "0x1889F5280", Slot = "8")]
		public void MYVGUYFYLGS(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x89F51E0", Offset = "0x89F39E0", VA = "0x1889F51E0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x89F3550", Offset = "0x89F1D50", VA = "0x1889F3550")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		private bool GBCQTREPYTA
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x89F3530", Offset = "0x89F1D30", VA = "0x1889F3530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		private FLAXIIDFDDM KYXHYZREABR
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x89F34D0", Offset = "0x89F1CD0", VA = "0x1889F34D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		private bool MDJGMOLRPTX
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x89F32B0", Offset = "0x89F1AB0", VA = "0x1889F32B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400002D")]
		public event RbexAction OTUPUUBHMDM
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x89F2C90", Offset = "0x89F1490", VA = "0x1889F2C90", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x89F3210", Offset = "0x89F1A10", VA = "0x1889F3210", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x89F38B0", Offset = "0x89F20B0", VA = "0x1889F38B0")]
		public IPUOQTSTQLL(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x89F2D30", Offset = "0x89F1530", VA = "0x1889F2D30", Slot = "6")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x89F3200", Offset = "0x89F1A00", VA = "0x1889F3200", Slot = "8")]
		public void DUDNTVVQNOY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x89F3670", Offset = "0x89F1E70", VA = "0x1889F3670", Slot = "7")]
		public bool VZRYQKTJZDM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x89F35A0", Offset = "0x89F1DA0", VA = "0x1889F35A0", Slot = "9")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x89F3040", Offset = "0x89F1840", VA = "0x1889F3040", Slot = "13")]
		public void CSIVDQEXQWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x89F30E0", Offset = "0x89F18E0", VA = "0x1889F30E0", Slot = "12")]
		public void CXFMMMVEQTX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x89F37C0", Offset = "0x89F1FC0", VA = "0x1889F37C0", Slot = "10")]
		public bool WLGTIHGCVPE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x89F2DC0", Offset = "0x89F15C0", VA = "0x1889F2DC0", Slot = "11")]
		public bool CGJURPXSKBZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x89F3310", Offset = "0x89F1B10", VA = "0x1889F3310")]
		private bool HNEVTEQTWEJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x89F2EB0", Offset = "0x89F16B0", VA = "0x1889F2EB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xAA1370", Offset = "0xA9FB70", VA = "0x180AA1370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		private bool MDJGMOLRPTX
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x89EC8A0", Offset = "0x89EB0A0", VA = "0x1889EC8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool GZBCAOAWTCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x183FC10", Offset = "0x183E410", VA = "0x18183FC10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x89ECB20", Offset = "0x89EB320", VA = "0x1889ECB20")]
		public AWKTAZORFVM(FLAXIIDFDDM a, [In] RigidbodyExData data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x89EC650", Offset = "0x89EAE50", VA = "0x1889EC650", Slot = "5")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x89EC870", Offset = "0x89EB070", VA = "0x1889EC870", Slot = "7")]
		public void GJPYSWLQTCE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x89EC900", Offset = "0x89EB100", VA = "0x1889EC900", Slot = "8")]
		public void KVFFGSXRTDB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x89EC320", Offset = "0x89EAB20", VA = "0x1889EC320", Slot = "9")]
		public void AMVTNASUVAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x89EC930", Offset = "0x89EB130", VA = "0x1889EC930", Slot = "10")]
		public void OFTZSGVHOUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x89EC6F0", Offset = "0x89EAEF0", VA = "0x1889EC6F0", Slot = "11")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA15F0", Offset = "0xA9FDF0", VA = "0x180AA15F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0xAA1380", Offset = "0xA9FB80", VA = "0x180AA1380", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public RTQGHSHOPHZ XIHZDOJZUOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xAA1630", Offset = "0xA9FE30", VA = "0x180AA1630", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xAA1600", Offset = "0xA9FE00", VA = "0x180AA1600", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Vector3 FITKFMCGXGG
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x89EEC00", Offset = "0x89ED400", VA = "0x1889EEC00", Slot = "8")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x89EF950", Offset = "0x89EE150", VA = "0x1889EF950", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3 WBDPTOWQUSF
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x89EEF50", Offset = "0x89ED750", VA = "0x1889EEF50", Slot = "10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x89EFA10", Offset = "0x89EE210", VA = "0x1889EFA10", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 IGQBUSPCNOC
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x89EE6B0", Offset = "0x89ECEB0", VA = "0x1889EE6B0", Slot = "12")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x89ECC20", Offset = "0x89EB420", VA = "0x1889ECC20", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public Vector3 GHLUXTSNDMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x89EF3E0", Offset = "0x89EDBE0", VA = "0x1889EF3E0", Slot = "14")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x89EF810", Offset = "0x89EE010", VA = "0x1889EF810", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float FNDQULDQCMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xAEF5C0", Offset = "0xAEDDC0", VA = "0x180AEF5C0", Slot = "16")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x89EF840", Offset = "0x89EE040", VA = "0x1889EF840", Slot = "17")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool NYZKQSIKQLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x22FEFD0", Offset = "0x22FD7D0", VA = "0x1822FEFD0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		private SEUTCTARQZA HGYUYITXBZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x7F71BD0", Offset = "0x7F703D0", VA = "0x187F71BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		private bool GBCQTREPYTA
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x89EF7F0", Offset = "0x89EDFF0", VA = "0x1889EF7F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x89F01E0", Offset = "0x89EE9E0", VA = "0x1889F01E0")]
		public CAKSKMFSCCR(FLAXIIDFDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x89ECCE0", Offset = "0x89EB4E0", VA = "0x1889ECCE0", Slot = "19")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x89ED9B0", Offset = "0x89EC1B0", VA = "0x1889ED9B0", Slot = "36")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x89EF0D0", Offset = "0x89ED8D0", VA = "0x1889EF0D0", Slot = "28")]
		public void MYVGUYFYLGS(Rigidbody a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x160C3A0", Offset = "0x160ABA0", VA = "0x18160C3A0", Slot = "20")]
		public void LWDNNATHMNS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x160DEB0", Offset = "0x160C6B0", VA = "0x18160DEB0", Slot = "30")]
		public void OLZDBQUXTQP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x89EF200", Offset = "0x89EDA00", VA = "0x1889EF200", Slot = "35")]
		public Vector3 NIOYPYEQKWQ(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x89EDA10", Offset = "0x89EC210", VA = "0x1889EDA10", Slot = "34")]
		public Vector3 ELLRGFOLSLU(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x89ECCE0", Offset = "0x89EB4E0", VA = "0x1889ECCE0", Slot = "27")]
		public void WDLTQJCFAFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x89EE1D0", Offset = "0x89EC9D0", VA = "0x1889EE1D0", Slot = "25")]
		public void GOUKBDOZGZQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x89EEA00", Offset = "0x89ED200", VA = "0x1889EEA00", Slot = "24")]
		public void KRGSPSWJWCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x89ED2F0", Offset = "0x89EBAF0", VA = "0x1889ED2F0", Slot = "33")]
		public void CZIRHLUKVQH(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x89ED1E0", Offset = "0x89EB9E0", VA = "0x1889ED1E0", Slot = "32")]
		public void BGBOOAVERTQ(Vector3 a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x89EEDB0", Offset = "0x89ED5B0", VA = "0x1889EEDB0", Slot = "31")]
		public void LRKHYJRZYNR(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x89EFCB0", Offset = "0x89EE4B0", VA = "0x1889EFCB0", Slot = "22")]
		public void ZNUBIDZFUEL(RbexImpulseType a, Vector3 b, float c, float d = 8f, float e = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x89EF570", Offset = "0x89EDD70", VA = "0x1889EF570", Slot = "21")]
		public void RJBOBMTNCPE(RbexRotationType a, Vector3 b, float c = 1f / 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x89EDD50", Offset = "0x89EC550", VA = "0x1889EDD50", Slot = "23")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void GMGTXVVWBAV(RbexRotationType a, Vector3 b, float c = 7f, float d = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x17462B0", Offset = "0x1744AB0", VA = "0x1817462B0")]
		private static void JGRDAPUCRGH(Vector3 a, Vector3 b, [Out] Vector3 c, [Out] Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x89EFBD0", Offset = "0x89EE3D0", VA = "0x1889EFBD0", Slot = "29")]
		public Vector3 YGKWEEYFHPK(Vector3 a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x89EFA40", Offset = "0x89EE240", VA = "0x1889EFA40", Slot = "26")]
		public void XKQXRAVLLDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x89EF840", Offset = "0x89EE040", VA = "0x1889EF840")]
		private void TQRYALWWXCO(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x89EEA60", Offset = "0x89ED260", VA = "0x1889EEA60")]
		private void LNYSDVPPYVK(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x89EDBD0", Offset = "0x89EC3D0", VA = "0x1889EDBD0")]
		private Vector3 FJJRIBAMUOX()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x89ED530", Offset = "0x89EBD30", VA = "0x1889ED530")]
		private void DFTCKAQXDRB(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x89EE870", Offset = "0x89ED070", VA = "0x1889EE870")]
		private Vector3 IHVZXTDRDNH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x89EE230", Offset = "0x89ECA30", VA = "0x1889EE230")]
		private void HJPKZUFDEPT(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x89ECD80", Offset = "0x89EB580", VA = "0x1889ECD80")]
		private void BEMASCDJHWK(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x89ED240", Offset = "0x89EBA40", VA = "0x1889ED240")]
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
