using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using RecNet;
using RecRoom.AssetIds;
using RecRoom.Attributes;
using RecRoom.Avatars.Data;
using RecRoom.Avatars.Face;
using RecRoom.Avatars.Serialization;
using RecRoom.Core.DataStructures.Tokens;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Debugging;
using RecRoom.Experiments;
using RecRoom.Initialization;
using RecRoom.JsonSerialization;
using RecRoom.Logger;
using RecRoom.MathUtils;
using RecRoom.MathUtils.Springs;
using RecRoom.NoEngine.Common;
using RecRoom.ObjectModel;
using RecRoom.Protobuf;
using RecRoom.Protobuf.Core;
using RootMotion.FinalIK;
using UJect;
using UJect.Injection;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x80C2C60", Offset = "0x80C2060", VA = "0x1880C2C60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_AvatarSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80C2D80", Offset = "0x80C2180", VA = "0x1880C2D80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x273B290", Offset = "0x273A690", VA = "0x18273B290")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Tested]
	internal class HMJJFSCPYJI : YUWHFKRRNYL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private struct <>c__DisplayClass6_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public HMJJFSCPYJI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public AvatarConfiguration avatarConfiguration;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly WHVFOKNWMEV BZHYURTVPWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly VEMKINSQYNP DRLAEVBJJLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly JIYMDLBEXSB NTZPOWASGTO;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x80C08D0", Offset = "0x80BFCD0", VA = "0x1880C08D0")]
		[JKCTBFVRGVY.Root.GameOnly]
		[UsedImplicitly]
		internal static void NSUOAVSKGXC(NAWAUUZVKFS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x80C0A60", Offset = "0x80BFE60", VA = "0x1880C0A60")]
		[RecRoom.NoEngine.Common.Preserve]
		internal HMJJFSCPYJI([Inject(null)] WHVFOKNWMEV avatarDataMigrations, [Inject(null)] VEMKINSQYNP avatarDataSerializerProvider, [Inject(null)] JIYMDLBEXSB outfitManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80BFF10", Offset = "0x80BF310", VA = "0x1880BFF10", Slot = "5")]
		public AvatarData NIYADTPOSLU(AvatarBodyType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x80BF410", Offset = "0x80BE810", VA = "0x1880BF410", Slot = "4")]
		public AvatarData JVZWYSDBVJK(AvatarBodyType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x80BF300", Offset = "0x80BE700", VA = "0x1880BF300", Slot = "6")]
		public OutfitDTO HXYDDEYJFMT(AvatarData a, int b, string? name, string? previewImageName, UgcAccessibility c, List<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80C0940", Offset = "0x80BFD40", VA = "0x1880C0940", Slot = "7")]
		public bool PUATOTBALKZ(TRPBDUGQTSH a, [Out] AvatarData? avatarData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80C07F0", Offset = "0x80BFBF0", VA = "0x1880C07F0", Slot = "8")]
		public bool NLFVZNVTFSR(OutfitDTO a, [Out] AvatarData? avatarData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80C09D0", Offset = "0x80BFDD0", VA = "0x1880C09D0", Slot = "9")]
		public bool UNZSLYPISWQ(OutfitDTO a, [Out] AFRVCIQNWZA? outfitData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x36D14F0", Offset = "0x36D08F0", VA = "0x1836D14F0")]
		private bool WWNKKFYPTXU<a, b>(a a, ZTCHIMEXVIZ<a, b> b, [Out] b? result) where b : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x80BEF80", Offset = "0x80BE380", VA = "0x1880BEF80")]
		[CompilerGenerated]
		private ANZIUZYUWAB APADFEWPCZY(FaceFeatureType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80BF120", Offset = "0x80BE520", VA = "0x1880BF120")]
		[CompilerGenerated]
		private ANZIUZYUWAB CSHAOLBUCGZ(FaceFeatureType a, <>c__DisplayClass6_0 b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[Tested]
	internal class JACIPFSWQEC : WHVFOKNWMEV
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private delegate void MigrationFunc<in TData>(TData avatarData, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class RIOAGJYRBFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public RangeDataType BYLOSXCZMXR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public AvatarVersion PDHNILRWBQV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public AvatarVersion AXZMKUPFESY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public RangeMigration? ASGOPCJACIE;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public RIOAGJYRBFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x80C2CE0", Offset = "0x80C20E0", VA = "0x1880C2CE0")]
			internal bool EMORFOSIRTC(RangeMigration a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x80C2D00", Offset = "0x80C2100", VA = "0x1880C2D00")]
			internal bool EMTYCVMGBEL(RangeMigration a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly JIYMDLBEXSB NTZPOWASGTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SCJJWEQKEBO CSXMYKLCRWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly MigrationFunc<AvatarData>?[] BZHYURTVPWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly MigrationFunc<AFRVCIQNWZA>?[] WZPFJGOESHC;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80C2390", Offset = "0x80C1790", VA = "0x1880C2390")]
		[JKCTBFVRGVY.Root.GameOnly]
		[UsedImplicitly]
		internal static void NSUOAVSKGXC(NAWAUUZVKFS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x80C2770", Offset = "0x80C1B70", VA = "0x1880C2770")]
		[RecRoom.NoEngine.Common.Preserve]
		internal JACIPFSWQEC([Inject(null)] JIYMDLBEXSB outfitManager, [Inject(null)] SCJJWEQKEBO debugLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x80C1DD0", Offset = "0x80C11D0", VA = "0x1880C1DD0", Slot = "4")]
		public bool KOMNZJHFLCY(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x80C1ED0", Offset = "0x80C12D0", VA = "0x1880C1ED0", Slot = "5")]
		public bool KOMNZJHFLCY(AFRVCIQNWZA a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x80C0BD0", Offset = "0x80BFFD0", VA = "0x1880C0BD0")]
		private void AHOQDRCVDJV(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x80C1BB0", Offset = "0x80C0FB0", VA = "0x1880C1BB0")]
		private void JMKGVSXIGHF(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80C2400", Offset = "0x80C1800", VA = "0x1880C2400")]
		private void OFLAYNVOPXW(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x80C2570", Offset = "0x80C1970", VA = "0x1880C2570")]
		private void YIWQJQAKLNU(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x80C24A0", Offset = "0x80C18A0", VA = "0x1880C24A0")]
		private void XBCMBIHJAEX(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x80C1770", Offset = "0x80C0B70", VA = "0x1880C1770")]
		private void BUQHQBZSYCC(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x80C1820", Offset = "0x80C0C20", VA = "0x1880C1820")]
		private void CQSMOWJRNGU(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x80C2760", Offset = "0x80C1B60", VA = "0x1880C2760")]
		private void ZZDDPYCSTNJ(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x80C2430", Offset = "0x80C1830", VA = "0x1880C2430")]
		private void OMIUIDXWTIK(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80C2310", Offset = "0x80C1710", VA = "0x1880C2310")]
		private void MHDQEMPHKLH(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x80C2030", Offset = "0x80C1430", VA = "0x1880C2030")]
		private void LLZQOIXEIRZ(AvatarData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x80C18D0", Offset = "0x80C0CD0", VA = "0x1880C18D0")]
		private AvatarData DSWBOYBQTNM(AvatarData a, List<RangeMigration> b, AvatarVersion c, AvatarVersion d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x80C2460", Offset = "0x80C1860", VA = "0x1880C2460")]
		private float QYLNTBJNRRE(float a, Vector2 b, Vector2 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x80C25A0", Offset = "0x80C19A0", VA = "0x1880C25A0")]
		private (RangeMigration?, RangeMigration?) ZQSHWFUVOCC(List<RangeMigration> a, RangeDataType b, AvatarVersion c, AvatarVersion d)
		{
			return default((RangeMigration?, RangeMigration?));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface WHVFOKNWMEV
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool KOMNZJHFLCY(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool KOMNZJHFLCY(AFRVCIQNWZA a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AnimationPoseSetting
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[TooltipAttribute("Type of pose")]
		public AnimationPoseType AnimationPoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[TooltipAttribute("Blend in time")]
		public float BlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[TooltipAttribute("How much of the head movement is applied to the hand movement")]
		public float HeadMovementWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[TooltipAttribute("Weight between IK hand and Animated hand for position")]
		public float HandAnimationPosWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[TooltipAttribute("Weight between IK hand and Animated hand for rotation")]
		public float HandAnimationRotWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[TooltipAttribute("Weight between shoulders facing forward and alignment with hands")]
		public float ShoulderFollowWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[TooltipAttribute("How much the aim follows direction of feet vs head (0 = head, 1 = feet)")]
		public float FeetFollowWeight;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x80BCA20", Offset = "0x80BBE20", VA = "0x1880BCA20")]
		public void EACECCEMXNK(AnimationPoseSetting a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x80BCB50", Offset = "0x80BBF50", VA = "0x1880BCB50")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[TooltipAttribute("If the child bone is provided, this is used to draw the handle towards that child")]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[TooltipAttribute("If no Child Bone is provided, then use this value as the length of the bone")]
		private float boneFakeLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private Color boneColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private float boneWidthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private float boneBloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private float axisHandleSize;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x80BD440", Offset = "0x80BC840", VA = "0x1880BD440")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x80BD400", Offset = "0x80BC800", VA = "0x1880BD400")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x80BCB70", Offset = "0x80BBF70", VA = "0x1880BCB70")]
		private void EQYKQJVBWPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x802F2A0", Offset = "0x802E6A0", VA = "0x18802F2A0", Slot = "4")]
		public void SetEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x80BD470", Offset = "0x80BC870", VA = "0x1880BD470")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarFootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[TooltipAttribute("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[TooltipAttribute("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[TooltipAttribute("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[TooltipAttribute("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[TooltipAttribute("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[TooltipAttribute("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[TooltipAttribute("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[TooltipAttribute("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x80BD4B0", Offset = "0x80BC8B0", VA = "0x1880BD4B0")]
		public AvatarFootSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum IKHandleType
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private IKHandleType handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x80BDB30", Offset = "0x80BCF30", VA = "0x1880BDB30")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x80BDAF0", Offset = "0x80BCEF0", VA = "0x1880BDAF0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x80BD4F0", Offset = "0x80BC8F0", VA = "0x1880BD4F0")]
		private void EQYKQJVBWPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x802F2A0", Offset = "0x802E6A0", VA = "0x18802F2A0", Slot = "4")]
		public void SetEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x80BDB60", Offset = "0x80BCF60", VA = "0x1880BDB60")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, AAWFWYFJRSI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Header("Configuration")]
		[SerializeField]
		private AvatarBodyType avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		protected AvatarModernBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[Autofill(AutofillType.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Header("Configuration")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private AssetReference torsoModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private AssetReference legsModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private AssetReference torsoValidationAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private GameObject allBodyMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private Material modestyAndValidationMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		[FormerlySerializedAs("BodyMaterial")]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Texture2D BodyEmissiveSkinMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Header("Facial Animation")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		[FormerlySerializedAs("HeadTweakBone")]
		private Transform HeadSizeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Header("Watch")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Header("Equipment Slots")]
		[SerializeField]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TOKANZQHBOJ YZDFZOTWMEH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TOKANZQHBOJ AISWAYDEXSK
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xC97CA0", Offset = "0xC970A0", VA = "0x180C97CA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform JZKVZISWKPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x80BEA50", Offset = "0x80BDE50", VA = "0x1880BEA50", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x80BDB90", Offset = "0x80BCF90", VA = "0x1880BDB90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x80BE910", Offset = "0x80BDD10", VA = "0x1880BE910")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x80BE8C0", Offset = "0x80BDCC0", VA = "0x1880BE8C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x80BE850", Offset = "0x80BDC50", VA = "0x1880BE850")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x80BDB90", Offset = "0x80BCF90", VA = "0x1880BDB90", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x80BDFF0", Offset = "0x80BD3F0", VA = "0x1880BDFF0", Slot = "6")]
		public TOKANZQHBOJ CreateAvatarSystem(string identifier)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x80BE850", Offset = "0x80BDC50", VA = "0x1880BE850", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x80BDC50", Offset = "0x80BD050", VA = "0x1880BDC50", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x80BE960", Offset = "0x80BDD60", VA = "0x1880BE960", Slot = "9")]
		public void UpdatePostIKAnimControllers(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class AvatarModernBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Header("Turning")]
		[TooltipAttribute("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[TooltipAttribute("The number of seconds it takes for a rotational follow to catch up when steering performing slow locomotion states.")]
		public float SlowSteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[TooltipAttribute("The number of seconds it takes for a rotational follow to catch up when steering based on velocity.")]
		public AnimationCurve SteeringRotationalFollowTimeAt180;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[TooltipAttribute("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[TooltipAttribute("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[TooltipAttribute("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[TooltipAttribute("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x254")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[TooltipAttribute("Lower than 1 makes the head bob less.")]
		public float BeanHeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[TooltipAttribute("Numbers under 1 = uses a slower locomotion animation. Above = faster.")]
		public float BeanLocomotionAnimationSelectionScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[TooltipAttribute("Numbers under 1 = plays the locomotion animations at a slower speed. Above = faster.")]
		public float BeanLocomotionAnimationSpeedScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[TooltipAttribute("Forward offset applied to bean animations.")]
		public float BeanHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[TooltipAttribute("Straighten the back by moving the pelvis instead of leaning towards the head.")]
		public float BeanStraightBackFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[TooltipAttribute("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[TooltipAttribute("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[TooltipAttribute("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[TooltipAttribute("Offset for the hip when prone using a bean body.")]
		public float VerticalHipOffsetWhenProneForBeans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Header("Head Objects Placement")]
		[TooltipAttribute("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Header("Hand Placement")]
		[TooltipAttribute("Offsets applied to transforms on the players left hand")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[TooltipAttribute("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Header("Hand Animation")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public AvatarHandDisplaySettings AvatarHandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public float ClassicBeanHandSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[Header("Watch")]
		[TooltipAttribute("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[TooltipAttribute("The local uniform scale to apply to the clock face to match the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3EC")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[TooltipAttribute("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[TooltipAttribute("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3FC")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Header("Performance Tuning")]
		[TooltipAttribute("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[TooltipAttribute("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x404")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[TooltipAttribute("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x405")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[TooltipAttribute("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Header("Leaning")]
		[TooltipAttribute("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40C")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[TooltipAttribute("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[TooltipAttribute("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x414")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[TooltipAttribute("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[TooltipAttribute("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[TooltipAttribute("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Header("Hand Blending")]
		[TooltipAttribute("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[TooltipAttribute("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x428")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[TooltipAttribute("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42C")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[TooltipAttribute("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x430")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[TooltipAttribute("Speed for blending in screens animations.")]
		public float ScreensHandIkBlendInSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x434")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[TooltipAttribute("Speed for blending in screens animations when idle.")]
		public float ScreensHandIkBlendInToIdleSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x438")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[TooltipAttribute("Speed for blending out screens animations.")]
		public float ScreensHandIkBlendOutSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x43C")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Header("Body Twisting")]
		[TooltipAttribute("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x440")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[TooltipAttribute("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x444")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[TooltipAttribute("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x448")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[TooltipAttribute("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44C")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[TooltipAttribute("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x450")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[TooltipAttribute("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x454")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[TooltipAttribute("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x458")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[TooltipAttribute("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45C")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[TooltipAttribute("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x460")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[TooltipAttribute("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x464")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[TooltipAttribute("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x468")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Header("Seated animation settings")]
		[TooltipAttribute("How much to twist shoulders when seated.")]
		public float SeatedShoulderTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46C")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[TooltipAttribute("Min/max value for vertical offset between animated and game head.")]
		public Vector2 SeatedLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x474")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[TooltipAttribute("Pelvis weight used at the min and max limit based on the head offset. Pin on low to not sink through the seat, and allow to stand up when high.")]
		public Vector2 PelvisWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x47C")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[TooltipAttribute("Head weight used at the min and max limit based on the head offset.")]
		public Vector2 HeadWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x484")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Header("Hand Snapping")]
		[TooltipAttribute("Distance between game and physical hand that will allow a snap")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x488")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[TooltipAttribute("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[TooltipAttribute("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x490")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[TooltipAttribute("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x498")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[Header("Hand Poses")]
		[FormerlySerializedAs("HandPoseSettings")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[TooltipAttribute("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A4")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[TooltipAttribute("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Header("Foot Pinning")]
		[TooltipAttribute("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B8")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[TooltipAttribute("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[TooltipAttribute("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C4")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[TooltipAttribute("Velocity threshold where feet are blended in local space to avoid stretching")]
		public float LocalBlendVelocityThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C8")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[TooltipAttribute("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4CC")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[TooltipAttribute("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[TooltipAttribute("How much the hips are locked to the pinned feet direction vs the desired body direction")]
		public float FootPinHipLockFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D4")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[TooltipAttribute("Max spine twist when locking feet")]
		public float FootPinMaxSpineTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AvatarFootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AvatarFootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4E8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[Header("Shoe Settings")]
		[TooltipAttribute("Local offset from pelvis to foot center")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F4")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[TooltipAttribute("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4F8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[TooltipAttribute("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4FC")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[TooltipAttribute("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x500")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[TooltipAttribute("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x508")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[TooltipAttribute("Amount of movement applied to the hips based on head offset")]
		public AnimationCurve HipBalanceCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x510")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[TooltipAttribute("Constant scalar for the hip balance curve")]
		public float HipBalanceFactor;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x80BEA70", Offset = "0x80BDE70", VA = "0x1880BEA70")]
		public AnimationPoseSetting GetAnimationPoseSetting(AnimationPoseType animationPoseType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x80BEAA0", Offset = "0x80BDEA0", VA = "0x1880BEAA0")]
		public void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x80BEAE0", Offset = "0x80BDEE0", VA = "0x1880BEAE0")]
		public AvatarModernBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class AISWAYDEXSK : TOKANZQHBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal class XANJFHMEZWK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private Vector3 GTXCDSTGQKZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private Quaternion PZHNWEWLKDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private Vector3 BKQKRGCQXUY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private Transform LWOZGOVWUMA;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public Vector3 BPXMKIRFGUL
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0xC297A0", Offset = "0xC28BA0", VA = "0x180C297A0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60000E4")]
				[Cpp2IlInjected.Address(RVA = "0x80CD530", Offset = "0x80CC930", VA = "0x1880CD530")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public Quaternion LBEWJFRRUHC
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x1D25D50", Offset = "0x1D25150", VA = "0x181D25D50")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x60000E6")]
				[Cpp2IlInjected.Address(RVA = "0x1D259F0", Offset = "0x1D24DF0", VA = "0x181D259F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public float ZBCGECLLILL
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0xFF1570", Offset = "0xFF0970", VA = "0x180FF1570")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x17B6110", Offset = "0x17B5510", VA = "0x1817B6110")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public bool MMCQKIQFZAU
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAAF030", Offset = "0xAAE430", VA = "0x180AAF030")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0xAAE7E0", Offset = "0xAADBE0", VA = "0x180AAE7E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool FNBJOMYZBLQ
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAAE8A0", Offset = "0xAADCA0", VA = "0x180AAE8A0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0xAAF010", Offset = "0xAAE410", VA = "0x180AAF010")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool GMVCJOALNCV
			{
				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0xAAEFE0", Offset = "0xAAE3E0", VA = "0x180AAEFE0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0xAAE8E0", Offset = "0xAADCE0", VA = "0x180AAE8E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public float TSPGARTGCUW
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0xB496A0", Offset = "0xB48AA0", VA = "0x180B496A0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0xB4A440", Offset = "0xB49840", VA = "0x180B4A440")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x80CD790", Offset = "0x80CCB90", VA = "0x1880CD790")]
			public void WLHJITVMRQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x80CDE70", Offset = "0x80CD270", VA = "0x1880CDE70")]
			public void XIRFLQVKGGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x80CD320", Offset = "0x80CC720", VA = "0x1880CD320")]
			public float ISHSHZLTFJC(Vector3 a, Quaternion b, [In] AvatarFootSettings footSettings, float c)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x80CD7A0", Offset = "0x80CCBA0", VA = "0x1880CD7A0")]
			public void WYAKJHUKBBG(Vector3 a, Quaternion b, Transform c, float d, bool e, bool f, float g, float h, Transform i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x80CD0D0", Offset = "0x80CC4D0", VA = "0x1880CD0D0")]
			public void DVOXTCNYZVZ(Transform a, Transform b, bool c, bool d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x80CD540", Offset = "0x80CC940", VA = "0x1880CD540")]
			private void MMRCGHIKSKR(Transform a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x80CD640", Offset = "0x80CCA40", VA = "0x1880CD640")]
			public bool QXWOLVTKBDE(Transform a, AvatarModernBodyConfiguration b, Vector3 c, float d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x80CD300", Offset = "0x80CC700", VA = "0x1880CD300")]
			public void HQDJROVECDP(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x80CDE80", Offset = "0x80CD280", VA = "0x1880CDE80")]
			public XANJFHMEZWK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private class CFHOPXIMQSA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public float LCYYEYIJNNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private bool XKVHQDHIJGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public AnimationPoseSetting LIWRNAGRZOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private float HJYUSCOHLQP;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x80C58C0", Offset = "0x80C4CC0", VA = "0x1880C58C0")]
			public void ODRNVAWUGEH(IKSolverVR.Arm a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x80C58F0", Offset = "0x80C4CF0", VA = "0x1880C58F0")]
			public void OYXIENUJFYC(IKSolverVR.Arm a, float b, bool c, AvatarModernBodyConfiguration d, float e, bool f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x80C4DE0", Offset = "0x80C41E0", VA = "0x1880C4DE0")]
			private void BPFJFZNJDCV(IKSolverVR.Arm a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x80C5980", Offset = "0x80C4D80", VA = "0x1880C5980")]
			public void QBOFPIZMJES(IKSolverVR.Arm a, Transform b, Transform c, Quaternion d, Vector3 e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x80C5EA0", Offset = "0x80C52A0", VA = "0x1880C5EA0")]
			private (Vector3, Quaternion) WQVIITBJISP(ICSLTVAWTTX a, Quaternion b, Vector3 c)
			{
				return default((Vector3, Quaternion));
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x80C6330", Offset = "0x80C5730", VA = "0x1880C6330")]
			public void YYUPWWCWCJD(ICSLTVAWTTX a, IKSolverVR.Arm b, Quaternion c, Vector3 d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x80C4E20", Offset = "0x80C4220", VA = "0x1880C4E20")]
			public void CHIYIUNWLSC(ICSLTVAWTTX a, IKSolverVR.Arm b, Quaternion c, Vector3 d, [In] AvatarModernBodyConfiguration config, [In] AvatarSystemUpdateState state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x80C5D60", Offset = "0x80C5160", VA = "0x1880C5D60")]
			public void STEXZTXNBJY(AnimationPoseType a, AvatarModernBodyConfiguration b, AvatarSystemUpdateState c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x80C5420", Offset = "0x80C4820", VA = "0x1880C5420")]
			public void LKEAZXVRJOD(IKSolverVR.Arm a, Transform b, Vector3 c, float d, Quaternion e, Vector3 f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x80C6490", Offset = "0x80C5890", VA = "0x1880C6490")]
			public CFHOPXIMQSA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private enum MovementUpdateMode
		{
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			Smooth,
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			BalancedBasedOnDeadzones,
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			ForceSnapIntoPlace
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <>c__DisplayClass271_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public float strideScale;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private struct <>c__DisplayClass271_1
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public Transform pelvis;
		}

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private static readonly int OSPCUCIIFTT;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private static readonly int PWZGTEAJPRQ;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private static readonly int QKVLCQJFRFB;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static readonly int QFOYMZXYPQJ;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private static readonly int HPDFAIWNTKI;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private static readonly int QMWJGPPUOXO;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private static readonly int JWWLDDTTEDE;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly int OMTSEZEKNTR;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private static readonly int DXEBUQUQUKL;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static readonly int YWKXKPEGZKZ;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private static readonly int LPCGFWOGSKW;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private static readonly int EYZHWFCIQCU;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private static readonly int GETKLVYEPJM;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static readonly int OTXFHAFOMCT;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static readonly int LEMGWFGYUFB;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static readonly int FCFDAYFRVIS;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static readonly int XPWPWALPQVM;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly int MNNTTQIFXKK;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly int BYRFAMPYFHY;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly int MUOZLBXUBAQ;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly int TIAEPXNNYBG;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly int MHBWGILHZXL;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly int ZYKGZMGNKNV;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly int GSJUAQKQREH;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly int WCNKBEIPUQA;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly int JDOPEBHVHGZ;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly int SFVFODDTLKF;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly int RNIMCNBGDBP;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private static readonly int UGUFVPQHZNP;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly int RCCHGXJANZI;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly int HWWPTRTXJXY;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly int IUUQHNTFLBP;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Vector3 HECNDZCRFFA;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly int VOPLGQUZIQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool FTINZKLWMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private bool KLLXTNTFCYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool EYHGQTPOHWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private bool DSPIMNHFNXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private bool GWYPSUOUHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private bool RMYZHUOTJPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private Vector3 LLBGQTUYSZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private string BSCMDFJQAQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private AvatarSystemInitState? YWPKKZCSQOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private AvatarSystemPlayerSetupState? NCUQBRWMOBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private AvatarDisplaySystem TTWTYALCEAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private OJPSNQCNPOR SLQQZQUOBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private ICSLTVAWTTX BVDMABZPJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private ICSLTVAWTTX XIHVMAPRCRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private bool PGYTGAMPSNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x299")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private bool HSWROMKFCCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly HRCRDJYJUPQ FIDLYLCUTQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly VSLNXUMEEDH ARYSIRGIJYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int ATUXTZTWARC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private float KFIEGBABCQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private GameObject AVFITWVQOUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private Transform YXGPPOHQEJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private Transform FYLIOEKJXHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private Transform IVYBGEUBCRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private Transform MCETOJNELLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private float SEVVXULRBKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private float RBRCDMAJBED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private Vector3 RBQGLVHGBAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F4")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private Quaternion YUVBWQRSXYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private Transform CFKKPLDUZNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private Transform CRFUTFYKLEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private Transform CDXWKBZLMUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private SLUJDPOYLND EERSHYMRLDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private TLGWYONTLVW<ObscuredFloat> FWIDRCUASXZ;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ProfilerMarker DJXMOADXNUV;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly ProfilerMarker NLISXIBKEVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private ProfilerMarker CIWDEHDAAJN;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private static readonly ProfilerMarker OLZHIYNIIJA;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly ProfilerMarker DPMZZQJXJBE;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly ProfilerMarker XUFNJYEIQXL;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private static readonly List<AISWAYDEXSK> WHUKYRULZGJ;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private static int RIBONMCQFTB;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> NYGBAPHKOKO;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private static int RTHXVXFQUQD;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static int FGWCEEMFZVK;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static int DKAJLDQPKHH;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static int HUAKLPBVEXE;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private static float BCBAIFREUYM;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private static int NLIFUCBNMYF;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private static float SJDFIEIKLQK;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static float ESDPNQNYKWN;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static float CGPGSASJRVT;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private static float ATFAHYQKKLO;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static TGTLHRYURCL XZDREJSUAPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private float HIELIGDASOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private bool JFEKBYSYJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private float OYBHBOIUNUT;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly int OMYCKYMLGCJ;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static readonly int GGMNLIJZWJU;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static readonly int RFQQHABXBSY;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private static readonly int GQWGCHZCAMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private XANJFHMEZWK DVETZQCPDKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private XANJFHMEZWK OSRWXQLJPFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private float VERCSAGDAYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Vector3 PKRQAJNOQXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private Vector3 OIDGJNUPOOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private bool OQPXPRGTMPP;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly Quaternion KRPRNAWAHBK;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly Quaternion KDXTCGYMMXN;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private static readonly Vector3 RWCQAQVIYCK;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private static readonly Vector3 YFTPDRTOSNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private float GROMPEYGCLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private float WOLUPAELIIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private CFHOPXIMQSA FHYNOVMBTCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private CFHOPXIMQSA XBGPALLKFJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private ZAVKKXRRDTQ BMJEPYQCHZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private NCMHTDTHAVH IWUADIZZKDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly UACLKAMWDXJ AUYGQRNNDIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private float CYPHYYYHQUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private float LZLQQFWDIQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly NCMHTDTHAVH BVVUGPZAHXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Vector3 VXXMTIAPSIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Vector3 YHWJUWLESZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private float TYWXBRVWBUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private float PRVYMESJTRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private readonly NCMHTDTHAVH MIOWHTIRFJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private readonly ZAVKKXRRDTQ DTCSAXBWXUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private readonly NCMHTDTHAVH PIEKKVDKGSL;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public OAGBKHNZSHS HFYMVXBEILH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public OAGBKHNZSHS OTCFXPYOSAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public AvatarConfiguration MSJPNEESOIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x80B7730", Offset = "0x80B6B30", VA = "0x1880B7730", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AvatarBodyType YUINGQCADHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x80A5C20", Offset = "0x80A5020", VA = "0x1880A5C20", Slot = "24")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AvatarModernBodyConfiguration GURQDOHQQEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x80AAD40", Offset = "0x80AA140", VA = "0x1880AAD40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Transform MHBQDZSCUQN
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x80B3250", Offset = "0x80B2650", VA = "0x1880B3250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Transform FDHUYARSSKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x80B7850", Offset = "0x80B6C50", VA = "0x1880B7850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private SkinnedMeshRenderer NZDYZOINDIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x80A60C0", Offset = "0x80A54C0", VA = "0x1880A60C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Renderer[] NOVXFGUSTAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x80ABAC0", Offset = "0x80AAEC0", VA = "0x1880ABAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private GameObject[] JVGOXDFBGZV
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x80B1720", Offset = "0x80B0B20", VA = "0x1880B1720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Animator HUGAPRQEKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x80B68C0", Offset = "0x80B5CC0", VA = "0x1880B68C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private VRIK UTJQZHYGSWC
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x80B2740", Offset = "0x80B1B40", VA = "0x1880B2740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private BEEMHMBSIMZ UXSFXOGIZEV
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x80B9860", Offset = "0x80B8C60", VA = "0x1880B9860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private BEEMHMBSIMZ DLVOYSBGKVE
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x80B1200", Offset = "0x80B0600", VA = "0x1880B1200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private BEEMHMBSIMZ AENODEUPTEL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x80B3E30", Offset = "0x80B3230", VA = "0x1880B3E30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private BEEMHMBSIMZ IBCAESOHRNZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x80A6D80", Offset = "0x80A6180", VA = "0x1880A6D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private BEEMHMBSIMZ ZCFQZCSMGFI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x80BB970", Offset = "0x80BAD70", VA = "0x1880BB970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private BEEMHMBSIMZ XCWZPQBYWGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x80B9780", Offset = "0x80B8B80", VA = "0x1880B9780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private BEEMHMBSIMZ HYUKVPUOPKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x80A5B40", Offset = "0x80A4F40", VA = "0x1880A5B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private BEEMHMBSIMZ DHQOIBSWLXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x80AE520", Offset = "0x80AD920", VA = "0x1880AE520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public AvatarSystemPlayerSetupState IZEJASXVGSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x80B9940", Offset = "0x80B8D40", VA = "0x1880B9940", Slot = "16")]
			get
			{
				return default(AvatarSystemPlayerSetupState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public RPZVEHTUHZJ NJQXPBRTXVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1785260", Offset = "0x1784660", VA = "0x181785260", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public KSXTJUIEJRK ZIKDVJOFSLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xE59620", Offset = "0xE58A20", VA = "0x180E59620", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public TFCKNALADDO JFMCNWLNMVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x80B82B0", Offset = "0x80B76B0", VA = "0x1880B82B0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public TFCKNALADDO RFRLSUMPUKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x136D990", Offset = "0x136CD90", VA = "0x18136D990", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public string HOTJOSUEJSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAA9AA0", Offset = "0xAA8EA0", VA = "0x180AA9AA0", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private Transform DNUWXLIJMSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x80AA500", Offset = "0x80A9900", VA = "0x1880AA500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Transform SWQNHVYSPTO
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x80A3580", Offset = "0x80A2980", VA = "0x1880A3580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Transform SPTNRUBWHCS
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x80B3220", Offset = "0x80B2620", VA = "0x1880B3220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private Transform TNUWQQPAPAC
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x80A9120", Offset = "0x80A8520", VA = "0x1880A9120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private Transform OSNPYSDAEIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x80BA8A0", Offset = "0x80B9CA0", VA = "0x1880BA8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private bool NMYJLOWWJTM
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x80AA550", Offset = "0x80A9950", VA = "0x1880AA550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private bool YHYYNEULNOW
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x80AA550", Offset = "0x80A9950", VA = "0x1880AA550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private bool AFWCIZZRXWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x80B9A50", Offset = "0x80B8E50", VA = "0x1880B9A50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Transform LNHTRGFSHGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x80B0330", Offset = "0x80AF730", VA = "0x1880B0330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public GameObject PSSUFNRMXMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x80B7610", Offset = "0x80B6A10", VA = "0x1880B7610", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public HeadLogicOffsets MTCDHNPPVWE
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x80B76B0", Offset = "0x80B6AB0", VA = "0x1880B76B0", Slot = "34")]
			get
			{
				return default(HeadLogicOffsets);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Transform CACZEOMGAZK
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1CFACF0", Offset = "0x1CFA0F0", VA = "0x181CFACF0", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Transform XKORQRZVXJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xBA1660", Offset = "0xBA0A60", VA = "0x180BA1660", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Transform DEFCDHCIDDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1CFAF20", Offset = "0x1CFA320", VA = "0x181CFAF20", Slot = "37")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Transform JGJCCNJIDMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x136E1D0", Offset = "0x136D5D0", VA = "0x18136E1D0", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 NWGDHIDDYPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x80A50C0", Offset = "0x80A44C0", VA = "0x1880A50C0", Slot = "39")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float EOVPBFLCNTQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x80B6240", Offset = "0x80B5640", VA = "0x1880B6240", Slot = "40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Transform CZSROFRBGHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x80AACE0", Offset = "0x80AA0E0", VA = "0x1880AACE0", Slot = "41")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Transform NFHZVXXQDHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x1E1F0E0", Offset = "0x1E1E4E0", VA = "0x181E1F0E0", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Transform FWLIOETUSUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2213130", Offset = "0x2212530", VA = "0x182213130", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Transform DGQOMVCBOBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x24C3680", Offset = "0x24C2A80", VA = "0x1824C3680", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool QGNVOZIWARG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x80B6390", Offset = "0x80B5790", VA = "0x1880B6390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public JQSJODDDNWT<TOKANZQHBOJ.FootEvent> TYRSXYBLTRD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x1E14AE0", Offset = "0x1E13EE0", VA = "0x181E14AE0", Slot = "46")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool DHROKRRHNNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x80B16A0", Offset = "0x80B0AA0", VA = "0x1880B16A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		private bool ALUNPEYEOAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x80B6A70", Offset = "0x80B5E70", VA = "0x1880B6A70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x80A34E0", Offset = "0x80A28E0", VA = "0x1880A34E0")]
		private float BOCPUFMUGJR(AvatarStance a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x80B3F10", Offset = "0x80B3310", VA = "0x1880B3F10")]
		private void QNBHOISZPOJ([In] AvatarSystemUpdateState systemUpdateState, [In] AvatarModernBodyConfiguration config, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x80A9660", Offset = "0x80A8A60", VA = "0x1880A9660")]
		private float HFLYUACCQHF([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x80A2A40", Offset = "0x80A1E40", VA = "0x1880A2A40")]
		private float ADGTWRYAWZR([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x80BB3B0", Offset = "0x80BA7B0", VA = "0x1880BB3B0")]
		private void YTPRBCDWIXV(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x80A70E0", Offset = "0x80A64E0", VA = "0x1880A70E0")]
		private void GPDCYDPJQFL([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x80AE780", Offset = "0x80ADB80", VA = "0x1880AE780")]
		private void LRHSJMSVFCU([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x80BC560", Offset = "0x80BB960", VA = "0x1880BC560")]
		public AISWAYDEXSK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x80B69A0", Offset = "0x80B5DA0", VA = "0x1880B69A0", Slot = "47")]
		public void THAMNNJZNND(float a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x80A7060", Offset = "0x80A6460", VA = "0x1880A7060", Slot = "48")]
		public void GGAGREDPNXC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x80AF600", Offset = "0x80AEA00", VA = "0x1880AF600", Slot = "13")]
		public void MPMZPOWSTZH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x80A96F0", Offset = "0x80A8AF0", VA = "0x1880A96F0", Slot = "14")]
		public void HIKQQKMLNWM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x80B1A90", Offset = "0x80B0E90", VA = "0x1880B1A90", Slot = "15")]
		public void OXRZJLMQOCX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x80B8DE0", Offset = "0x80B81E0", VA = "0x1880B8DE0", Slot = "26")]
		public Transform WMYMVNCTEIO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x80B1490", Offset = "0x80B0890", VA = "0x1880B1490", Slot = "27")]
		public Vector3? OGOGQZDDQZR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x80B9E60", Offset = "0x80B9260", VA = "0x1880B9E60", Slot = "7")]
		public void XXNUOPDPXUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x80B7AB0", Offset = "0x80B6EB0", VA = "0x1880B7AB0")]
		private void VMUAJCWCXAK(AvatarModernBodyConfiguration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x80A5D00", Offset = "0x80A5100", VA = "0x1880A5D00", Slot = "8")]
		public void ENUPLGDATWS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x80B6290", Offset = "0x80B5690", VA = "0x1880B6290")]
		private void SGBRFRCUGBT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x80B7930", Offset = "0x80B6D30", VA = "0x1880B7930")]
		private Vector3 VMIWESVKLFT([In] AvatarSystemUpdateState state)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x80A2D50", Offset = "0x80A2150", VA = "0x1880A2D50", Slot = "6")]
		public void ANWGYYBKAZJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x80A3E00", Offset = "0x80A3200", VA = "0x1880A3E00")]
		private void DBGLHICOIHP(bool a, MovementUpdateMode b, AvatarModernBodyConfiguration c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x80BB0B0", Offset = "0x80BA4B0", VA = "0x1880BB0B0", Slot = "9")]
		public void YPNVNNOAVJF(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x80AA880", Offset = "0x80A9C80", VA = "0x1880AA880")]
		private void ISGJSQTSSWA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x80AC090", Offset = "0x80AB490", VA = "0x1880AC090", Slot = "4")]
		public void LKNFATEFBOQ(string a, AvatarSystemInitState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x80AE0A0", Offset = "0x80AD4A0", VA = "0x1880AE0A0", Slot = "5")]
		public void LLKQFBSEXFA(AvatarSystemPlayerSetupState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x80A5F70", Offset = "0x80A5370", VA = "0x1880A5F70", Slot = "12")]
		public void FBCPUCTOFUP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x80BAD20", Offset = "0x80BA120", VA = "0x1880BAD20", Slot = "25")]
		public void YLDTBPAUPQY([Out] Vector3 a, [Out] Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x80A5F40", Offset = "0x80A5340", VA = "0x1880A5F40")]
		private void EPBFABCVJQZ([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x80AB510", Offset = "0x80AA910", VA = "0x1880AB510", Slot = "28")]
		public void KBQDDBYWJKN(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x80BB540", Offset = "0x80BA940", VA = "0x1880BB540", Slot = "29")]
		public void ZEVIKRKLHYK(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x80B9730", Offset = "0x80B8B30", VA = "0x1880B9730", Slot = "49")]
		public void WWAMBUTCFFT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x80ABD70", Offset = "0x80AB170", VA = "0x1880ABD70", Slot = "30")]
		public void LHQEDHIZDOH(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x80B1FB0", Offset = "0x80B13B0", VA = "0x1880B1FB0", Slot = "31")]
		public HandLogicOffsets OZKMGKVOLJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x80B8680", Offset = "0x80B7A80", VA = "0x1880B8680", Slot = "32")]
		public PlatformSpecificPlayerHandOffsets VUZUBFEDNWL()
		{
			return default(PlatformSpecificPlayerHandOffsets);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x80A2F40", Offset = "0x80A2340", VA = "0x1880A2F40")]
		private void BBMGQVFLJZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x80B1080", Offset = "0x80B0480", VA = "0x1880B1080")]
		private void NITDJSEAIHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x80AA8D0", Offset = "0x80A9CD0", VA = "0x1880AA8D0")]
		private void IYTETEABVKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x80AA5A0", Offset = "0x80A99A0", VA = "0x1880AA5A0")]
		private void ILFGRMYBDBW(HUFBFJCMRYV a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x80AE600", Offset = "0x80ADA00", VA = "0x1880AE600")]
		private void LNMSLBMPPZE(HUFBFJCMRYV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x80A7010", Offset = "0x80A6410", VA = "0x1880A7010", Slot = "33")]
		public Vector3 GFVNKMTNVTF()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x80A9160", Offset = "0x80A8560", VA = "0x1880A9160")]
		private void GSDIUNSRNFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x80A70C0", Offset = "0x80A64C0", VA = "0x1880A70C0")]
		private void GOPGQXDZXPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x80B2000", Offset = "0x80B1400", VA = "0x1880B2000")]
		private void PCNSKXSSXJS(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x80A2F70", Offset = "0x80A2370", VA = "0x1880A2F70")]
		private float BIMNBFYYBWR([In] AvatarSystemUpdateState state)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x80BB890", Offset = "0x80BAC90", VA = "0x1880BB890")]
		private int ZMFQOBNNNFA([In] AvatarSystemUpdateRateState updateRateState)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x80B5D20", Offset = "0x80B5120", VA = "0x1880B5D20")]
		private void SBTTBQAGNWB(AvatarSystemUpdateState a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x80B6670", Offset = "0x80B5A70", VA = "0x1880B6670")]
		private static void SVOKNXRWPGX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x80B0410", Offset = "0x80AF810", VA = "0x1880B0410")]
		private static void NHMXDWUEDVW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x80AB8F0", Offset = "0x80AACF0", VA = "0x1880AB8F0")]
		private float KYJNPKPPJUQ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x80AE880", Offset = "0x80ADC80", VA = "0x1880AE880")]
		private static int LYFMGHYXEWW(AISWAYDEXSK a, AISWAYDEXSK b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x80A35C0", Offset = "0x80A29C0", VA = "0x1880A35C0", Slot = "42")]
		public AvatarSystemUpdateState CODFNIYLJRS()
		{
			return default(AvatarSystemUpdateState);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x80B26A0", Offset = "0x80B1AA0", VA = "0x1880B26A0")]
		private bool PJEGBJESACK(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x80A3500", Offset = "0x80A2900", VA = "0x1880A3500")]
		public void CEAXIEOSFNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x80ABBA0", Offset = "0x80AAFA0", VA = "0x1880ABBA0")]
		private (bool, bool) LEIBLXMCVSK()
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x80A9A90", Offset = "0x80A8E90", VA = "0x1880A9A90")]
		private (float, float) HPFHVSDIXKJ([In] AvatarSystemUpdateState state)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x80A74D0", Offset = "0x80A68D0", VA = "0x1880A74D0")]
		private void GRXYIRMZMKQ([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x80B9B40", Offset = "0x80B8F40", VA = "0x1880B9B40")]
		private void XVCQWAABOII([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x80AE8B0", Offset = "0x80ADCB0", VA = "0x1880AE8B0")]
		private void MAEGOINXQRB([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config, AvatarFootSettings a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x80B1620", Offset = "0x80B0A20", VA = "0x1880B1620")]
		private float OJZQNYJXBKV()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x80A61A0", Offset = "0x80A55A0", VA = "0x1880A61A0")]
		private void FMWGRPHOVMX(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x80B6870", Offset = "0x80B5C70", VA = "0x1880B6870")]
		private float TAMSHNSMKME()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x80B7150", Offset = "0x80B6550", VA = "0x1880B7150")]
		private void UKQKNISBIJY([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x80B3330", Offset = "0x80B2730", VA = "0x1880B3330")]
		private void QBOFPIZMJES([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x80A30F0", Offset = "0x80A24F0", VA = "0x1880A30F0")]
		private void BLLGTYCKJNU([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x80B1800", Offset = "0x80B0C00", VA = "0x1880B1800")]
		private void OWXFQYNNVEW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x80B5950", Offset = "0x80B4D50", VA = "0x1880B5950")]
		private void ROZAQHCWWNQ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x80AB130", Offset = "0x80AA530", VA = "0x1880AB130")]
		private void JNNIKUPFKLR([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x80BB120", Offset = "0x80BA520", VA = "0x1880BB120")]
		private void YTHJLFUJTWW(ICSLTVAWTTX a, IKSolverVR.Arm b, Transform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x80B2B70", Offset = "0x80B1F70", VA = "0x1880B2B70")]
		private void PPZIMEBXPCB(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x80B80E0", Offset = "0x80B74E0", VA = "0x1880B80E0")]
		private void VQNMIJVYZPW(HandGestureType a, TFCKNALADDO b, IKSolverVR.Arm c, float d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x80A9450", Offset = "0x80A8850", VA = "0x1880A9450")]
		private void HFAINDXBHNQ([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x80B8740", Offset = "0x80B7B40", VA = "0x1880B8740")]
		private void WFNFLESGRIP([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x80B82C0", Offset = "0x80B76C0", VA = "0x1880B82C0")]
		protected void VUEFYJKIFXH([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x80B2820", Offset = "0x80B1C20", VA = "0x1880B2820")]
		private void PPCKOUCRNTV([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x80AB2C0", Offset = "0x80AA6C0", VA = "0x1880AB2C0")]
		protected void JVGWWIVVFBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x80B3610", Offset = "0x80B2A10", VA = "0x1880B3610")]
		private void QBQCCOBGUWX([In] AvatarSystemUpdateState state, [In] MovementUpdateMode movementUpdateMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x80B12E0", Offset = "0x80B06E0", VA = "0x1880B12E0")]
		private void OGJUGGAERIU(AvatarSystemUpdateState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x80B7810", Offset = "0x80B6C10", VA = "0x1880B7810")]
		private void VDFPQCDNDFR([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x80B6C40", Offset = "0x80B6040", VA = "0x1880B6C40")]
		private Vector3 TYYDLUZGZMP([In] AvatarSystemUpdateState state)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x80AA430", Offset = "0x80A9830", VA = "0x1880AA430")]
		private void HSSEKFJGSWY([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x80B1B60", Offset = "0x80B0F60", VA = "0x1880B1B60")]
		private float OZFUZBTJONZ(float a, [In] AvatarSystemUpdateState state)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x80B6AF0", Offset = "0x80B5EF0", VA = "0x1880B6AF0")]
		private void TPVGKXNRJKQ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x80A3710", Offset = "0x80A2B10", VA = "0x1880A3710")]
		private void CUACROSPIEZ([In] AvatarSystemUpdateState state, MovementUpdateMode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x80B8F30", Offset = "0x80B8330", VA = "0x1880B8F30")]
		private float WVSZDDUQZES([In] AvatarSystemUpdateState systemUpdateState)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x80AFB40", Offset = "0x80AEF40", VA = "0x1880AFB40")]
		private void MSXBOADDACL(AvatarSystemUpdateState a, MovementUpdateMode b, Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x80A6E60", Offset = "0x80A6260", VA = "0x1880A6E60")]
		private static void FTYWSGLRURE(Transform a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x80ABDC0", Offset = "0x80AB1C0", VA = "0x1880ABDC0")]
		private void LIZAFGLPXZJ([In] AvatarSystemUpdateState updateState, [In] AvatarSystemUpdateRateState updateRateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x80BA130", Offset = "0x80B9530", VA = "0x1880BA130")]
		private void YAKQNKEMBUG([In] AvatarSystemUpdateState updateState, [In] AvatarSystemUpdateRateState updateRateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x80B6480", Offset = "0x80B5880", VA = "0x1880B6480")]
		private void SMRFLTTLGBK(float a, [In] AvatarSystemUpdateState systemUpdateState, float b = 0.6f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x80A9C70", Offset = "0x80A9070", VA = "0x1880A9C70")]
		private float HRGNIDYGNPZ([In] AvatarSystemUpdateState systemUpdateState, [In] AvatarModernBodyConfiguration config)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x80B2F30", Offset = "0x80B2330", VA = "0x1880B2F30")]
		private void PRIIYHWWMMR([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x80A46B0", Offset = "0x80A3AB0", VA = "0x1880A46B0")]
		private void DCSDYUEUAZO([In] AvatarSystemUpdateState systemUpdateState, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x80AB520", Offset = "0x80AA920", VA = "0x1880AB520")]
		private void KPYBBKFAOIS([In] AvatarSystemUpdateState systemUpdateState, float a, float b, Vector3 c, float d = 0.6f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x80A5150", Offset = "0x80A4550", VA = "0x1880A5150")]
		private void DKOUSLPEDOI(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x80A2AC0", Offset = "0x80A1EC0", VA = "0x1880A2AC0")]
		private void AGFVDNMRQAG(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x80AF140", Offset = "0x80AE540", VA = "0x1880AF140")]
		private void MJKZZHJLBAA(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x80AECD0", Offset = "0x80AE0D0", VA = "0x1880AECD0")]
		public void MCIIJICSKCB([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x80AADD0", Offset = "0x80AA1D0", VA = "0x1880AADD0")]
		public void JKVCPNRLTUL([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x80AEFA0", Offset = "0x80AE3A0", VA = "0x1880AEFA0")]
		[CompilerGenerated]
		internal static void MJEAKTOKMMI(Transform a, IKSolverVR.Arm b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x80BBA50", Offset = "0x80BAE50", VA = "0x1880BBA50")]
		[CompilerGenerated]
		internal static void ZYFRNONIHLT(Vector3 a, Vector3 b, <>c__DisplayClass271_0 c, <>c__DisplayClass271_1 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x80B8D40", Offset = "0x80B8140", VA = "0x1880B8D40")]
		[CompilerGenerated]
		internal static void WJWHZTXCJYS(XANJFHMEZWK a, XANJFHMEZWK b, Vector3 c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x80AEE90", Offset = "0x80AE290", VA = "0x1880AEE90")]
		[CompilerGenerated]
		internal static bool MIIEILIOTJF(IKSolverVR.Arm a, ROWDSYFMYCF b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x80BA8E0", Offset = "0x80B9CE0", VA = "0x1880BA8E0")]
		[CompilerGenerated]
		internal static float YEXXXNIQKMT(Vector3 a, Vector3 b, Vector3 c, AvatarSystemUpdateState d, AvatarModernBodyConfiguration e, float f)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class AvatarSystemManager : XEIWJSHEEGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private Dictionary<string, TOKANZQHBOJ> IAFPRPDXDIA;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x80C3EE0", Offset = "0x80C32E0", VA = "0x1880C3EE0")]
		[JKCTBFVRGVY.Root]
		internal static void QCCNEJZQAZI(NAWAUUZVKFS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x80C3CC0", Offset = "0x80C30C0", VA = "0x1880C3CC0", Slot = "4")]
		public TOKANZQHBOJ QCAGELMRFTR(string a, AvatarSystemConfiguration b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x80C3F50", Offset = "0x80C3350", VA = "0x1880C3F50", Slot = "5")]
		public void VUUXOKVUUAX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x80C3B90", Offset = "0x80C2F90", VA = "0x1880C3B90", Slot = "6")]
		public string EQCYLRGZBTI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x80C3B20", Offset = "0x80C2F20", VA = "0x1880C3B20")]
		private string BYGWIZKASQI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x80C4130", Offset = "0x80C3530", VA = "0x1880C4130")]
		public AvatarSystemManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ExecuteAlways]
	public class AvatarVRIKSimpleController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class XVYZBBDIIFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private Dictionary<string, Transform> JCOGACCJXXJ;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool SIBPRYIZIOH
			{
				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x80CDEE0", Offset = "0x80CD2E0", VA = "0x1880CDEE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x80CDF20", Offset = "0x80CD320", VA = "0x1880CDF20")]
			public void TWCRGZAOMNC(VRIK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			public void MUDFQMZRAYD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x80CDE90", Offset = "0x80CD290", VA = "0x1880CDE90")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x80CE050", Offset = "0x80CD450", VA = "0x1880CE050")]
			public XVYZBBDIIFK()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		[AutofillOptional(AutofillType.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		[Autofill(AutofillType.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private readonly XVYZBBDIIFK TJBJCFRKLJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private AAWFWYFJRSI MXZMUENGMFP;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x80C4240", Offset = "0x80C3640", VA = "0x1880C4240")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x80C41B0", Offset = "0x80C35B0", VA = "0x1880C41B0")]
		private bool BKPUUMLZLMY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x80C4520", Offset = "0x80C3920", VA = "0x1880C4520")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x80C4590", Offset = "0x80C3990", VA = "0x1880C4590")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x80C4530", Offset = "0x80C3930", VA = "0x1880C4530")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x80C4840", Offset = "0x80C3C40", VA = "0x1880C4840")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class HandPoseSettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private struct HandsOpenCloseAmount
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000166")]
			public float LeftHand;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000167")]
			public float RightHand;

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x80C7780", Offset = "0x80C6B80", VA = "0x1880C7780")]
			public (float, float) EMVQNCMBUHV(float a)
			{
				return default((float, float));
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000168")]
			[TooltipAttribute("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			[TooltipAttribute("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			private int MOJYIQQFCFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			[TooltipAttribute("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			[TooltipAttribute("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400016E")]
			[TooltipAttribute("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			[TooltipAttribute("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x600011F")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0xAA3BB0", Offset = "0xAA2FB0", VA = "0x180AA3BB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x80C6E80", Offset = "0x80C6280", VA = "0x1880C6E80")]
			public void HGSJECSPXBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x80C6F60", Offset = "0x80C6360", VA = "0x1880C6F60")]
			public (float, float) QSLQIETVYBB(Animator a, AnimatorStateInfo b)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly int RAVEMPYATPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private Dictionary<int, HandPoseSetting> VJNQFIGEVVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private HandsOpenCloseAmount[] IdleStanceHandOpenCloseAmount;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x80C72E0", Offset = "0x80C66E0", VA = "0x1880C72E0")]
		public void HGSJECSPXBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x80C70A0", Offset = "0x80C64A0", VA = "0x1880C70A0")]
		public (float, float) EYETGZUZSTV(Animator a, AvatarStance b, float c)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x80C74C0", Offset = "0x80C68C0", VA = "0x1880C74C0")]
		private (float, float) IVTEXECJZWD(Animator a, AnimatorStateInfo b, AvatarStance c, float d)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x80C7770", Offset = "0x80C6B70", VA = "0x1880C7770")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[TooltipAttribute("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[TooltipAttribute("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[TooltipAttribute("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x80C9EC0", Offset = "0x80C92C0", VA = "0x1880C9EC0", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x80CA020", Offset = "0x80C9420", VA = "0x1880CA020")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
namespace RecRoom.Avatars.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal abstract class CTUCVCHAEUS<a, b> : ZTCHIMEXVIZ<a, b> where b : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		protected readonly SCJJWEQKEBO CSXMYKLCRWF;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3CFAC70", Offset = "0x3CFA070", VA = "0x183CFAC70")]
		protected CTUCVCHAEUS(SCJJWEQKEBO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract b Deserialize(a input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x3CFABD0", Offset = "0x3CF9FD0", VA = "0x183CFABD0", Slot = "5")]
		public bool WWNKKFYPTXU(a a, [Out] b? result, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[Tested]
	public static class CJRMPTLERIK
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly Regex PXFCSKWMSHP;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x80C6660", Offset = "0x80C5A60", VA = "0x1880C6660")]
		public static IWSVOGOANRV OLKGUDVBPZD(AvatarItemId a, CombinationId b, Guid? c, Color? d, AvatarBodyPart e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x80C6500", Offset = "0x80C5900", VA = "0x1880C6500")]
		public static AvatarItemDesc AQWBAHCAAYA(IWSVOGOANRV a)
		{
			return default(AvatarItemDesc);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x34720E0", Offset = "0x34714E0", VA = "0x1834720E0")]
		internal static a? EBIEBDFFIFA<a>(string? input, MXXRWDUUDZY<a> a, SCJJWEQKEBO b, InvalidGuidHandling c, a d) where a : struct, IFKWYZGXWDF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3472D40", Offset = "0x3472140", VA = "0x183472D40")]
		internal static JRNUZQLPYLV ZFQKUEYSCMD<b>(string? input, MXXRWDUUDZY<b> a, SCJJWEQKEBO b, InvalidGuidHandling c, b d) where b : struct, IFKWYZGXWDF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x80C6860", Offset = "0x80C5C60", VA = "0x1880C6860")]
		internal static List<CustomAvatarItemVisualData> RRRYXGFOSTX(IEnumerable<OutfitSelectionDTO>? selections)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x3472890", Offset = "0x3471C90", VA = "0x183472890")]
		internal static string JPIRWOWONRI<c>(c a, MXXRWDUUDZY<c> b, SCJJWEQKEBO c) where c : IFKWYZGXWDF
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal class PNMROUJBRCO : VEMKINSQYNP
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public ZTCHIMEXVIZ<TRPBDUGQTSH, AvatarData> EFVZDGBPOMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public ZTCHIMEXVIZ<OutfitDTO, AFRVCIQNWZA> UPBJRGXWMWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public ZTCHIMEXVIZ<OutfitDTO, AFRVCIQNWZA> LRZHRZKNMFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public SQEJULCRPML IRDIOJFNYGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public ZVVMDGKUSRC YOBVKJCYEYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x80CA190", Offset = "0x80C9590", VA = "0x1880CA190")]
		[JKCTBFVRGVY.Root.GameOnly]
		[UsedImplicitly]
		internal static void NSUOAVSKGXC(NAWAUUZVKFS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x80CA200", Offset = "0x80C9600", VA = "0x1880CA200")]
		[RecRoom.NoEngine.Common.Preserve]
		internal PNMROUJBRCO([Inject("UnitySerialization")] ERMPGIWIKCM jsonSerializationService, [Inject(null)] INRUDBWYVKL runtimeMapperProvider, [Inject(null)] SCJJWEQKEBO debugLogger)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum AvatarParseErrorCode
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		InvalidJsonOutfitSelectionsFormat,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		InvalidLegacyOutfitSelectionsFormat,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		InvalidBodyPart,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		InvalidGuid,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		ModernGuidMappingFailed,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		LegacyGuidMappingFailed,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		InvalidJsonAvatarData,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		MissingLegacyData
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarParseException : InvalidOperationException
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x80C3A90", Offset = "0x80C2E90", VA = "0x1880C3A90")]
		public AvatarParseException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x80C3AF0", Offset = "0x80C2EF0", VA = "0x1880C3AF0")]
		public AvatarParseException(string message, Exception innerException)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x80C3AC0", Offset = "0x80C2EC0", VA = "0x1880C3AC0")]
		public AvatarParseException(AvatarParseErrorCode code, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x80C3A50", Offset = "0x80C2E50", VA = "0x1880C3A50")]
		public AvatarParseException(AvatarParseErrorCode code, string message, Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal abstract class KJHHTVBMIUP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly ERMPGIWIKCM GPYOIYZHJTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly INRUDBWYVKL BLCQYKXWDLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly SCJJWEQKEBO CSXMYKLCRWF;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x80C95B0", Offset = "0x80C89B0", VA = "0x1880C95B0")]
		protected KJHHTVBMIUP(ERMPGIWIKCM a, INRUDBWYVKL b, SCJJWEQKEBO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x80C82E0", Offset = "0x80C76E0", VA = "0x1880C82E0")]
		protected string WQMHMMLWMEE(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x80C7DE0", Offset = "0x80C71E0", VA = "0x1880C7DE0")]
		protected string FVEZBYBMYNC(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x80C7FB0", Offset = "0x80C73B0", VA = "0x1880C7FB0")]
		private AvatarOutfitSelectionData OLKGUDVBPZD(IWSVOGOANRV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x80C7CA0", Offset = "0x80C70A0", VA = "0x1880C7CA0")]
		private static AvatarCustomizationSettingsData.AnchorParams EZHISIJPUFQ(NJBSAPCDQLT? a)
		{
			return default(AvatarCustomizationSettingsData.AnchorParams);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface ZTCHIMEXVIZ<in a, b> where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b Deserialize(a input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool WWNKKFYPTXU(a a, [Out] b? result, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface VEMKINSQYNP
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		ZTCHIMEXVIZ<TRPBDUGQTSH, AvatarData> EFVZDGBPOMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		ZTCHIMEXVIZ<OutfitDTO, AFRVCIQNWZA> LRZHRZKNMFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		SQEJULCRPML IRDIOJFNYGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	internal enum InvalidGuidHandling
	{
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		UseNull,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		UseEmpty,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		Throw
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface ZVVMDGKUSRC
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LegacyOutfitDataDTO MFMKHXDBDDO(AvatarData a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface SQEJULCRPML
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		OutfitDTO MFMKHXDBDDO(AvatarData a, int b, string? name, string? previewImageName, UgcAccessibility c, List<CustomAvatarItemVisualData>? customAvatarItems);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[Tested]
	internal class EFVZDGBPOMW : CTUCVCHAEUS<TRPBDUGQTSH, AvatarData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private readonly INRUDBWYVKL BLCQYKXWDLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private readonly UPBJRGXWMWQ OUHGAKAGAKI;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x80C6CC0", Offset = "0x80C60C0", VA = "0x1880C6CC0")]
		public EFVZDGBPOMW(ERMPGIWIKCM a, INRUDBWYVKL b, SCJJWEQKEBO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x80C6A20", Offset = "0x80C5E20", VA = "0x1880C6A20", Slot = "6")]
		public override AvatarData Deserialize(TRPBDUGQTSH input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class OutfitNewtonsoftJsonSerializer : ERMPGIWIKCM
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private class UUNSOFXZDCZ : JsonConverter<JRNUZQLPYLV>
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x80CCFF0", Offset = "0x80CC3F0", VA = "0x1880CCFF0", Slot = "9")]
			public override void WriteJson(JsonWriter writer, JRNUZQLPYLV? value, JsonSerializer serializer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x80CCEE0", Offset = "0x80CC2E0", VA = "0x1880CCEE0", Slot = "10")]
			public override JRNUZQLPYLV ReadJson(JsonReader reader, Type objectType, JRNUZQLPYLV? existingValue, bool hasExistingValue, JsonSerializer serializer)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x80CD090", Offset = "0x80CC490", VA = "0x1880CD090")]
			public UUNSOFXZDCZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class BPUUNNTDNNH : JsonConverter
		{
			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override bool CanRead
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x80C4CB0", Offset = "0x80C40B0", VA = "0x1880C4CB0", Slot = "5")]
			public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x80C4910", Offset = "0x80C3D10", VA = "0x1880C4910", Slot = "6")]
			public override bool CanConvert(Type objectType)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x80C4D00", Offset = "0x80C4100", VA = "0x1880C4D00", Slot = "4")]
			public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x80C4AD0", Offset = "0x80C3ED0", VA = "0x1880C4AD0")]
			private static bool OZXOXGNXHFU(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
			public BPUUNNTDNNH()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private readonly JsonSerializerSettings TBSHHTPKPTN;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x80CA040", Offset = "0x80C9440", VA = "0x1880CA040")]
		internal OutfitNewtonsoftJsonSerializer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x38BA580", Offset = "0x38B9980", VA = "0x1838BA580", Slot = "4")]
		public string JEQCKKYOKRF<a>(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x38BA6D0", Offset = "0x38B9AD0", VA = "0x1838BA6D0", Slot = "5")]
		public b NOTRAGRKNMS<b>(string a)
		{
			return (b)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class OutfitUtf8JsonSerializer : ERMPGIWIKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x38BAA80", Offset = "0x38B9E80", VA = "0x1838BAA80", Slot = "4")]
		public string JEQCKKYOKRF<a>(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x38BABD0", Offset = "0x38B9FD0", VA = "0x1838BABD0", Slot = "5")]
		public b NOTRAGRKNMS<b>(string a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public OutfitUtf8JsonSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[Tested]
	internal class UPBJRGXWMWQ : CTUCVCHAEUS<OutfitDTO, AFRVCIQNWZA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private readonly ERMPGIWIKCM GPYOIYZHJTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private readonly INRUDBWYVKL BLCQYKXWDLA;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x80CCDB0", Offset = "0x80CC1B0", VA = "0x1880CCDB0")]
		public UPBJRGXWMWQ(ERMPGIWIKCM a, INRUDBWYVKL b, SCJJWEQKEBO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x80CAB80", Offset = "0x80C9F80", VA = "0x1880CAB80", Slot = "6")]
		public override AFRVCIQNWZA Deserialize(OutfitDTO input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x80CAA30", Offset = "0x80C9E30", VA = "0x1880CAA30")]
		internal void DFCYIHYSBZZ(string a, AvatarData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x80CB190", Offset = "0x80CA590", VA = "0x1880CB190")]
		public IEnumerable<IWSVOGOANRV> HJWQBKYCGQV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x80CC9D0", Offset = "0x80CBDD0", VA = "0x1880CC9D0")]
		private IEnumerable<IWSVOGOANRV> WOIUHFBPTZP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x80CC2B0", Offset = "0x80CB6B0", VA = "0x1880CC2B0")]
		internal IEnumerable<IWSVOGOANRV> TCEHJFSLQHD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x80CB570", Offset = "0x80CA970", VA = "0x1880CB570")]
		private IWSVOGOANRV INVEAQOBUZV(AvatarOutfitSelectionData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x80CB8E0", Offset = "0x80CACE0", VA = "0x1880CB8E0")]
		private void KIRXDIEIXIT(AvatarCustomizationSettingsData a, AvatarData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x80CB250", Offset = "0x80CA650", VA = "0x1880CB250")]
		private IWSVOGOANRV INVEAQOBUZV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x80CC6E0", Offset = "0x80CBAE0", VA = "0x1880CC6E0")]
		internal static (AvatarBodyPart, string, string) VBCNVRWHOPF(string a, SCJJWEQKEBO b)
		{
			return default((AvatarBodyPart, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x80CAF90", Offset = "0x80CA390", VA = "0x1880CAF90")]
		private ANZIUZYUWAB? EPBMXAYAGCH(string? a, Vector2 b, float c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x80CC150", Offset = "0x80CB550", VA = "0x1880CC150")]
		private static NJBSAPCDQLT PBROAGXNXHT(AvatarCustomizationSettingsData.AnchorParams a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Tested]
	internal class YOBVKJCYEYH : KJHHTVBMIUP, ZVVMDGKUSRC
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x80C95B0", Offset = "0x80C89B0", VA = "0x1880C95B0")]
		public YOBVKJCYEYH(ERMPGIWIKCM a, INRUDBWYVKL b, SCJJWEQKEBO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x80CE3F0", Offset = "0x80CD7F0", VA = "0x1880CE3F0", Slot = "4")]
		public LegacyOutfitDataDTO MFMKHXDBDDO(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x80CE0D0", Offset = "0x80CD4D0", VA = "0x1880CE0D0")]
		private string BTKIDCUJWSD(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x80CE1C0", Offset = "0x80CD5C0", VA = "0x1880CE1C0")]
		private string ECIVWXCCWYM(IWSVOGOANRV a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[Tested]
	internal class LRZHRZKNMFV : CTUCVCHAEUS<OutfitDTO, AFRVCIQNWZA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly ERMPGIWIKCM GPYOIYZHJTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly ZTCHIMEXVIZ<OutfitDTO, AFRVCIQNWZA> FOOUPJPRKNQ;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x80C9B40", Offset = "0x80C8F40", VA = "0x1880C9B40")]
		public LRZHRZKNMFV(ZTCHIMEXVIZ<OutfitDTO, AFRVCIQNWZA> a, SCJJWEQKEBO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x80C9720", Offset = "0x80C8B20", VA = "0x1880C9720", Slot = "6")]
		public override AFRVCIQNWZA Deserialize(OutfitDTO input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[Tested]
	internal class IRDIOJFNYGI : SQEJULCRPML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly ERMPGIWIKCM GPYOIYZHJTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private readonly ZVVMDGKUSRC BEWWXLYGNAY;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x80C7BC0", Offset = "0x80C6FC0", VA = "0x1880C7BC0")]
		public IRDIOJFNYGI(ZVVMDGKUSRC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x80C7840", Offset = "0x80C6C40", VA = "0x1880C7840", Slot = "4")]
		public OutfitDTO MFMKHXDBDDO(AvatarData a, int b, string? name, string? previewImageName, UgcAccessibility c, List<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct PlayState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x80C3150", Offset = "0x80C2550", VA = "0x1880C3150")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
		public AnimatorDebugUtil()
		{
		}
	}
}
namespace RecRoom.Avatars.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class MXCGXAQHNDR
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x80C9C30", Offset = "0x80C9030", VA = "0x1880C9C30")]
		public static AvatarItemDesc Deserialize(this LLWDNBERNPM data)
		{
			return default(AvatarItemDesc);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x80C9D40", Offset = "0x80C9140", VA = "0x1880C9D40")]
		public static LLWDNBERNPM MFMKHXDBDDO(this AvatarItemDesc a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x80C9E60", Offset = "0x80C9260", VA = "0x1880C9E60")]
		public static bool OAEBSDCMCNO(this AvatarItemDesc a)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		internal struct AnchorParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x644F2D0", Offset = "0x644E6D0", VA = "0x18644F2D0")]
			public AnchorParams(Vector2 normalizedPosition, Vector3 hemisphereOffsets, Vector3 hemisphereRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x80C30A0", Offset = "0x80C24A0", VA = "0x1880C30A0")]
			internal NJBSAPCDQLT MFMKHXDBDDO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private HelmetHairState useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		internal static AnchorParams QWOOBNGSHNB
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x80C35D0", Offset = "0x80C29D0", VA = "0x1880C35D0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BB0", Offset = "0xAA2FB0", VA = "0x180AA3BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x15F8C90", Offset = "0x15F8090", VA = "0x1815F8C90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xB525C0", Offset = "0xB519C0", VA = "0x180B525C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xDF1E50", Offset = "0xDF1250", VA = "0x180DF1E50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x110A890", Offset = "0x1109C90", VA = "0x18110A890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BD0", Offset = "0xAA2FD0", VA = "0x180AA3BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x80C39C0", Offset = "0x80C2DC0", VA = "0x1880C39C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAA9900", Offset = "0xAA8D00", VA = "0x180AA9900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xAF3810", Offset = "0xAF2C10", VA = "0x180AF3810")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x1A24970", Offset = "0x1A23D70", VA = "0x181A24970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8C0", Offset = "0xAADCC0", VA = "0x180AAE8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x27E7500", Offset = "0x27E6900", VA = "0x1827E7500")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xCF94B0", Offset = "0xCF88B0", VA = "0x180CF94B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xFF1540", Offset = "0xFF0940", VA = "0x180FF1540")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x11BE8C0", Offset = "0x11BDCC0", VA = "0x1811BE8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xAA68C0", Offset = "0xAA5CC0", VA = "0x180AA68C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xAA6640", Offset = "0xAA5A40", VA = "0x180AA6640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x2195EB0", Offset = "0x21952B0", VA = "0x182195EB0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xD156A0", Offset = "0xD14AA0", VA = "0x180D156A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xABE040", Offset = "0xABD440", VA = "0x180ABE040")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xACDC70", Offset = "0xACD070", VA = "0x180ACDC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xAAFA60", Offset = "0xAAEE60", VA = "0x180AAFA60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xAAFA50", Offset = "0xAAEE50", VA = "0x180AAFA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xAAFB50", Offset = "0xAAEF50", VA = "0x180AAFB50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xAAFAB0", Offset = "0xAAEEB0", VA = "0x180AAFAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xAB0180", Offset = "0xAAF580", VA = "0x180AB0180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xAAFB70", Offset = "0xAAEF70", VA = "0x180AAFB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD22F0", VA = "0x180AD2EF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xCE08E0", Offset = "0xCDFCE0", VA = "0x180CE08E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xAAFB60", Offset = "0xAAEF60", VA = "0x180AAFB60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xAB0190", Offset = "0xAAF590", VA = "0x180AB0190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xBB52C0", Offset = "0xBB46C0", VA = "0x180BB52C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xBB4530", Offset = "0xBB3930", VA = "0x180BB4530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xAA46D0", Offset = "0xAA3AD0", VA = "0x180AA46D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xAA46E0", Offset = "0xAA3AE0", VA = "0x180AA46E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xC461E0", Offset = "0xC455E0", VA = "0x180C461E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xD1B620", Offset = "0xD1AA20", VA = "0x180D1B620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xC45EC0", Offset = "0xC452C0", VA = "0x180C45EC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xC44470", Offset = "0xC43870", VA = "0x180C44470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public HelmetHairState UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xDFCC30", Offset = "0xDFC030", VA = "0x180DFCC30")]
			get
			{
				return default(HelmetHairState);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xDFCBD0", Offset = "0xDFBFD0", VA = "0x180DFCBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xB3D050", Offset = "0xB3C450", VA = "0x180B3D050")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xB3D370", Offset = "0xB3C770", VA = "0x180B3D370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x80C39E0", Offset = "0x80C2DE0", VA = "0x1880C39E0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x80C3A00", Offset = "0x80C2E00", VA = "0x1880C3A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x80C3670", Offset = "0x80C2A70", VA = "0x1880C3670")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public AvatarBodyPart BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private MaterialCombinationId? PLABWSMEFKE;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x80C3A20", Offset = "0x80C2E20", VA = "0x1880C3A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public AvatarUgcOutfitData()
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
