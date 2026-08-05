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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8078210", Offset = "0x8076E10", VA = "0x188078210")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
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
		[Cpp2IlInjected.Address(RVA = "0x8078290", Offset = "0x8076E90", VA = "0x188078290", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2721D10", Offset = "0x2720910", VA = "0x182721D10")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Tested]
	internal class JVTXUMNULZX : NBIXIQVPBCS
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private struct <>c__DisplayClass6_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public JVTXUMNULZX <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public AvatarConfiguration avatarConfiguration;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly YWCPYWKMVEG PRRGVGGZFJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly MALTQBYOEZM FMPEJNFNKXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly WBOJOCIYQOA ZAJETUXUHPF;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8077500", Offset = "0x8076100", VA = "0x188077500")]
		[YLZSHGPPZTN.Root.GameOnly]
		[UsedImplicitly]
		internal static void XMPESWYAWUT(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x80780A0", Offset = "0x8076CA0", VA = "0x1880780A0")]
		[RecRoom.NoEngine.Common.Preserve]
		internal JVTXUMNULZX([Inject(null)] YWCPYWKMVEG avatarDataMigrations, [Inject(null)] MALTQBYOEZM avatarDataSerializerProvider, [Inject(null)] WBOJOCIYQOA outfitManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8076B20", Offset = "0x8075720", VA = "0x188076B20", Slot = "5")]
		public AvatarData SLMSRJZZFLR(AvatarBodyType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8077570", Offset = "0x8076170", VA = "0x188077570", Slot = "4")]
		public AvatarData ZEWUYLZUUTZ(AvatarBodyType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8076A10", Offset = "0x8075610", VA = "0x188076A10", Slot = "6")]
		public OutfitDTO RNVRKIATCEO(AvatarData a, int b, string? name, string? previewImageName, UgcAccessibility c, List<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80768F0", Offset = "0x80754F0", VA = "0x1880768F0", Slot = "7")]
		public bool OKZOVFKDGYY(MUZUGHZKOHG a, [Out] AvatarData? avatarData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8077420", Offset = "0x8076020", VA = "0x188077420", Slot = "8")]
		public bool SQEWJVYIMJI(OutfitDTO a, [Out] AvatarData? avatarData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8076980", Offset = "0x8075580", VA = "0x188076980", Slot = "9")]
		public bool ONOQTVFCDGB(OutfitDTO a, [Out] AYEBDMFCMGR? outfitData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x37256C0", Offset = "0x37242C0", VA = "0x1837256C0")]
		private bool DKESBADTYOL<a, b>(a a, RTGPQGZNOXM<a, b> b, [Out] b? result) where b : class
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8076750", Offset = "0x8075350", VA = "0x188076750")]
		[CompilerGenerated]
		private LYBUUUDLTOE IANEBQJLBRJ(FaceFeatureType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8076570", Offset = "0x8075170", VA = "0x188076570")]
		[CompilerGenerated]
		private LYBUUUDLTOE DQIBJYJTEHO(FaceFeatureType a, <>c__DisplayClass6_0 b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[Tested]
	internal class HRGQPBICNWH : YWCPYWKMVEG
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private delegate void MigrationFunc<in TData>(TData avatarData, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class HSAGEGZXRUB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public RangeDataType QKTYFFTUVHS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public AvatarVersion OTIKUVDTTUS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public AvatarVersion OJSVPYQYGXB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public RangeMigration? PZWGFCAWCTJ;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public HSAGEGZXRUB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8076550", Offset = "0x8075150", VA = "0x188076550")]
			internal bool NDPDGTUIZDV(RangeMigration a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x80764D0", Offset = "0x80750D0", VA = "0x1880764D0")]
			internal bool NDJWJNALPSM(RangeMigration a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly WBOJOCIYQOA ZAJETUXUHPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly YMWLTMFTDAZ TLUYFXKMIRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly MigrationFunc<AvatarData>?[] PRRGVGGZFJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly MigrationFunc<AYEBDMFCMGR>?[] CLTDTFYJFZP;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8075D10", Offset = "0x8074910", VA = "0x188075D10")]
		[YLZSHGPPZTN.Root.GameOnly]
		[UsedImplicitly]
		internal static void XMPESWYAWUT(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8075FE0", Offset = "0x8074BE0", VA = "0x188075FE0")]
		[RecRoom.NoEngine.Common.Preserve]
		internal HRGQPBICNWH([Inject(null)] WBOJOCIYQOA outfitManager, [Inject(null)] YMWLTMFTDAZ debugLogger)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8075EE0", Offset = "0x8074AE0", VA = "0x188075EE0", Slot = "4")]
		public bool XWCMIYUIWWF(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8075D80", Offset = "0x8074980", VA = "0x188075D80", Slot = "5")]
		public bool XWCMIYUIWWF(AYEBDMFCMGR a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x80749E0", Offset = "0x80735E0", VA = "0x1880749E0")]
		private void RHGTTOWZRCS(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8074780", Offset = "0x8073380", VA = "0x188074780")]
		private void NDIIQGJSXGW(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8074750", Offset = "0x8073350", VA = "0x188074750")]
		private void MMOQWXPVCID(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8074420", Offset = "0x8073020", VA = "0x188074420")]
		private void AIXCLHYJZMT(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8075B50", Offset = "0x8074750", VA = "0x188075B50")]
		private void XFVQCVVZJLW(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8075C20", Offset = "0x8074820", VA = "0x188075C20")]
		private void XIPKADFVTLD(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8074450", Offset = "0x8073050", VA = "0x188074450")]
		private void FZJYNVHTURB(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8074500", Offset = "0x8073100", VA = "0x188074500")]
		private void ILOPMZTAATM(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x80749B0", Offset = "0x80735B0", VA = "0x1880749B0")]
		private void OSSWRASPNJJ(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80746D0", Offset = "0x80732D0", VA = "0x1880746D0")]
		private void KPTHIYKIOTU(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8075590", Offset = "0x8074190", VA = "0x188075590")]
		private void SQWTWLHXWAW(AvatarData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8075870", Offset = "0x8074470", VA = "0x188075870")]
		private AvatarData SZGKXIFIAZV(AvatarData a, List<RangeMigration> b, AvatarVersion c, AvatarVersion d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8075CD0", Offset = "0x80748D0", VA = "0x188075CD0")]
		private float XKBPBGPODNV(float a, Vector2 b, Vector2 c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8074510", Offset = "0x8073110", VA = "0x188074510")]
		private (RangeMigration?, RangeMigration?) JJNCZWEJKRD(List<RangeMigration> a, RangeDataType b, AvatarVersion c, AvatarVersion d)
		{
			return default((RangeMigration?, RangeMigration?));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface YWCPYWKMVEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XWCMIYUIWWF(AvatarData a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool XWCMIYUIWWF(AYEBDMFCMGR a, IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);
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
		[Cpp2IlInjected.Address(RVA = "0x8057C10", Offset = "0x8056810", VA = "0x188057C10")]
		public void LKACLIOAVTR(AnimationPoseSetting a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8057D40", Offset = "0x8056940", VA = "0x188057D40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8058650", Offset = "0x8057250", VA = "0x188058650")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8058610", Offset = "0x8057210", VA = "0x188058610")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8057D60", Offset = "0x8056960", VA = "0x188057D60")]
		private void LLGAZKZLPZR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3370", Offset = "0x7FE1F70", VA = "0x187FE3370", Slot = "4")]
		public void SetEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8058680", Offset = "0x8057280", VA = "0x188058680")]
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
		[Cpp2IlInjected.Address(RVA = "0x80586C0", Offset = "0x80572C0", VA = "0x1880586C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8058D60", Offset = "0x8057960", VA = "0x188058D60")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8058D20", Offset = "0x8057920", VA = "0x188058D20")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8058700", Offset = "0x8057300", VA = "0x188058700")]
		private void LLGAZKZLPZR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7FE3370", Offset = "0x7FE1F70", VA = "0x187FE3370", Slot = "4")]
		public void SetEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8058D90", Offset = "0x8057990", VA = "0x188058D90")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, JMHKNJEMXOB
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
		private VENVHUECCSW PJGIMUXCVRS;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public VENVHUECCSW BYCQWWIJHJB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xC66780", Offset = "0xC65380", VA = "0x180C66780", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform KWCJDDOIFSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8059C80", Offset = "0x8058880", VA = "0x188059C80", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8058DC0", Offset = "0x80579C0", VA = "0x188058DC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8059B40", Offset = "0x8058740", VA = "0x188059B40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8059AF0", Offset = "0x80586F0", VA = "0x188059AF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8059A80", Offset = "0x8058680", VA = "0x188059A80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8058DC0", Offset = "0x80579C0", VA = "0x188058DC0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8059220", Offset = "0x8057E20", VA = "0x188059220", Slot = "6")]
		public VENVHUECCSW CreateAvatarSystem(string identifier)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8059A80", Offset = "0x8058680", VA = "0x188059A80", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8058E80", Offset = "0x8057A80", VA = "0x188058E80", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8059B90", Offset = "0x8058790", VA = "0x188059B90", Slot = "9")]
		public void UpdatePostIKAnimControllers(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA96140", Offset = "0xA94D40", VA = "0x180A96140")]
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
		[Cpp2IlInjected.Address(RVA = "0x8059CA0", Offset = "0x80588A0", VA = "0x188059CA0")]
		public AnimationPoseSetting GetAnimationPoseSetting(AnimationPoseType animationPoseType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8059CD0", Offset = "0x80588D0", VA = "0x188059CD0")]
		public void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8059D10", Offset = "0x8058910", VA = "0x188059D10")]
		public AvatarModernBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class BYCQWWIJHJB : VENVHUECCSW
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal class CPNZYAQMEQL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private Vector3 BNBWJMCHKHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private Quaternion UGMSXLJKMZH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private Vector3 ZCXRGSPOZFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private Transform IDPDTZPKSIL;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			public Vector3 TPGOEWEDJYC
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0xBF7330", Offset = "0xBF5F30", VA = "0x180BF7330")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Cpp2IlInjected.Token(Token = "0x60000E4")]
				[Cpp2IlInjected.Address(RVA = "0x807BC60", Offset = "0x807A860", VA = "0x18807BC60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public Quaternion CTLKNTRXZAN
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x1CE03D0", Offset = "0x1CDEFD0", VA = "0x181CE03D0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Cpp2IlInjected.Token(Token = "0x60000E6")]
				[Cpp2IlInjected.Address(RVA = "0x1CE0230", Offset = "0x1CDEE30", VA = "0x181CE0230")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public float YLRLQRUOXTA
			{
				[Cpp2IlInjected.Token(Token = "0x60000E7")]
				[Cpp2IlInjected.Address(RVA = "0xFC10B0", Offset = "0xFBFCB0", VA = "0x180FC10B0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x177BC80", Offset = "0x177A880", VA = "0x18177BC80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public bool VYANYRTYYSB
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BF0", Offset = "0xA9F7F0", VA = "0x180AA0BF0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0xAA0AD0", Offset = "0xA9F6D0", VA = "0x180AA0AD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public bool LHBARJTMSQT
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAA0B90", Offset = "0xA9F790", VA = "0x180AA0B90")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60000EC")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BD0", Offset = "0xA9F7D0", VA = "0x180AA0BD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool PNQEIJLTEVW
			{
				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F7E0", VA = "0x180AA0BE0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F7A0", VA = "0x180AA0BA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public float DRWOKGMWCUP
			{
				[Cpp2IlInjected.Token(Token = "0x60000EF")]
				[Cpp2IlInjected.Address(RVA = "0xAFBA50", Offset = "0xAFA650", VA = "0x180AFBA50")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0xAFD030", Offset = "0xAFBC30", VA = "0x180AFD030")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x807C330", Offset = "0x807AF30", VA = "0x18807C330")]
			public void ZDYUPEVSXPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x807C0F0", Offset = "0x807ACF0", VA = "0x18807C0F0")]
			public void VPSYPDAMHOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x807BD90", Offset = "0x807A990", VA = "0x18807BD90")]
			public float TJEBUBUCULX(Vector3 a, Quaternion b, [In] AvatarFootSettings footSettings, float c)
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x807B580", Offset = "0x807A180", VA = "0x18807B580")]
			public void BCXXLFHCNHN(Vector3 a, Quaternion b, Transform c, float d, bool e, bool f, float g, float h, Transform i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x807C100", Offset = "0x807AD00", VA = "0x18807C100")]
			public void WMBQDPPEHMG(Transform a, Transform b, bool c, bool d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x807BC70", Offset = "0x807A870", VA = "0x18807BC70")]
			private void OWZXYDLRVMO(Transform a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x807BFA0", Offset = "0x807ABA0", VA = "0x18807BFA0")]
			public bool UJENOJWPOZR(Transform a, AvatarModernBodyConfiguration b, Vector3 c, float d)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x807BD70", Offset = "0x807A970", VA = "0x18807BD70")]
			public void RIXIGHZMVTO(float a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x807C340", Offset = "0x807AF40", VA = "0x18807C340")]
			public CPNZYAQMEQL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private class BNHHQMYMMYP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public float MFUYDXDHWLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			private bool PXIUZBYPEIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public AnimationPoseSetting QYTCWKJUNCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private float FNOWZGVEEPG;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x807A470", Offset = "0x8079070", VA = "0x18807A470")]
			public void JHODESJECME(IKSolverVR.Arm a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8079FC0", Offset = "0x8078BC0", VA = "0x188079FC0")]
			public void DMURQOTQMCL(IKSolverVR.Arm a, float b, bool c, AvatarModernBodyConfiguration d, float e, bool f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x807A050", Offset = "0x8078C50", VA = "0x18807A050")]
			private void DWNENSBVBQE(IKSolverVR.Arm a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x807A090", Offset = "0x8078C90", VA = "0x18807A090")]
			public void GWSKGOTLTZX(IKSolverVR.Arm a, Transform b, Transform c, Quaternion d, Vector3 e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x807ABE0", Offset = "0x80797E0", VA = "0x18807ABE0")]
			private (Vector3, Quaternion) WZHYKEUWZIA(HIEZQWSWLGS a, Quaternion b, Vector3 c)
			{
				return default((Vector3, Quaternion));
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8079E60", Offset = "0x8078A60", VA = "0x188079E60")]
			public void AKCSBDSJCWU(HIEZQWSWLGS a, IKSolverVR.Arm b, Quaternion c, Vector3 d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x807A4A0", Offset = "0x80790A0", VA = "0x18807A4A0")]
			public void KBNKMNITGAZ(HIEZQWSWLGS a, IKSolverVR.Arm b, Quaternion c, Vector3 d, [In] AvatarModernBodyConfiguration config, [In] AvatarSystemUpdateState state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x807AAA0", Offset = "0x80796A0", VA = "0x18807AAA0")]
			public void WYCGNEFMZYT(AnimationPoseType a, AvatarModernBodyConfiguration b, AvatarSystemUpdateState c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x807B070", Offset = "0x8079C70", VA = "0x18807B070")]
			public void XYOPEKVEPVU(IKSolverVR.Arm a, Transform b, Vector3 c, float d, Quaternion e, Vector3 f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x807B510", Offset = "0x807A110", VA = "0x18807B510")]
			public BNHHQMYMMYP()
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
		private static readonly int HIUZQBVOETM;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private static readonly int XYLWHRUAIZJ;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private static readonly int SOBTWVDESZQ;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static readonly int CVAUXLBGROU;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private static readonly int OIRPROKETXB;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private static readonly int UWYEEMBNXOP;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private static readonly int TOKQAIKBBMD;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private static readonly int OBFUBQGJHVE;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private static readonly int CPLUJVLOUBE;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static readonly int AHHRWNQOVOU;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private static readonly int OZXKXXWNVTH;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private static readonly int IMUKPZKZZPB;

		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private static readonly int VHDSJAOLCBF;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static readonly int CULXGTFYWJO;

		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static readonly int MVVZRYDRFWU;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static readonly int BFCRYXKSBYV;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static readonly int LKAWBHFQRKL;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly int UOGJHJQMWKL;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly int NLMVSBPJCPD;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly int TNPWLHENVBF;

		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private static readonly int FAVOVUAVKRL;

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private static readonly int KIEGGSOQWOW;

		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static readonly int ZOVJVVGMFWC;

		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private static readonly int QYQPULVUNXO;

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static readonly int PDXPBFUAQEJ;

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static readonly int RQGQHQSHWXS;

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static readonly int QPOFWCOKBNE;

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static readonly int MVKBJQNBSWM;

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private static readonly int IAQOCQPUZPI;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private static readonly int LDHIINERYTN;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly int PJHWIHOIOMP;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly int HMBBBAOXIRE;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Vector3 XYYQXVOFKCX;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly int TMFXPZEAELR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool QJSTJZCQFXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private bool CYGHVMXJCOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool QBYTRRPPDZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private bool PFKANAPNONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private bool MYCXJKHRZGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private bool PPGLTMGNOYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private Vector3 GXEHAHUQMDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private string XMTSMNIQRPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private AvatarSystemInitState? WPGNRPJNTFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private AvatarSystemPlayerSetupState? BJKOUWANEXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private AvatarDisplaySystem EDYFWZVBVAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private UNKCDECNAXA SCXSTEZVBKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private HIEZQWSWLGS LIYGUUZDODV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private HIEZQWSWLGS OHNRSPWJDZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private bool YTIZATERGJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x299")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private bool QDQZGDZXQFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly CBDHIEXHZDJ JRJISEYMKNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly AMHAPAQULFG DTINWEYTGRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int BWFAROTJBDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private float HCPUAIFTNVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private GameObject ITIWOIODNDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private Transform GSJBASHGONU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private Transform HBGCVNNRJMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private Transform NPSHGGUENPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private Transform OERZCXMATKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private float YBPLJJHKLSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private float RFTNQDAKYQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private Vector3 XDIEBJSGRIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F4")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private Quaternion YBDKOUDBNJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private Transform HYIFVJWWWAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private Transform LBGLXVMPCDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private Transform ITSTQHKAUUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private VSKVJPYRCXE JDRLYJDVPVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private OCPOFDLOIGJ<ObscuredFloat> NOEAWRETXME;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ProfilerMarker WTNMNBTYHZO;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly ProfilerMarker NSCPAUTKWEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private ProfilerMarker PWIQCAUTDQS;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private static readonly ProfilerMarker KDSLQPRFWLF;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly ProfilerMarker JHXQDGXQORV;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private static readonly ProfilerMarker HQDSPONYEME;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private static readonly List<BYCQWWIJHJB> WCWCTZMWRCA;

		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private static int TZSRJKQDFUC;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> GTUTKAUHNSL;

		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private static int UJJATSOHFQQ;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static int JVWBIHACEPX;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static int LZQSBCCYNKG;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static int PPFAGKHBJYT;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private static float UTFUZZSASEH;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private static int FSHLRFDZWVY;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private static float GZKCHCJNPQZ;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static float WULGRTBMXDW;

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static float GMJBBKZDSSM;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private static float USHILAKXZGP;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static JVSXPMFNVOA CANOIVIQEUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private float GNTYZJSVZPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private bool RKEDWIVHZGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private float NWPKURRJJSK;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private static readonly int POQUGIJTARA;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static readonly int FDMCYGXGDQZ;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static readonly int BTXITIVEQIN;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private static readonly int ZSVFRHBBFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private CPNZYAQMEQL QJGWOEYDEUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private CPNZYAQMEQL RXDMTGWTOGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private float SBQQGFRPBIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Vector3 FADGPMEUDAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private Vector3 EJEPFNDUDYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private bool ZIPYYXGUALO;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly Quaternion NCKSIXMRDBP;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private static readonly Quaternion JPTELDPELMA;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private static readonly Vector3 KCXIKUJWEIJ;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private static readonly Vector3 OSAKVVRUBOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private float CNQVLKMCJXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private float HLXZZUFZULP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private BNHHQMYMMYP HBAMWIQLEEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private BNHHQMYMMYP OOQETGOASLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private DXWKJPHKBXV WCERUJTLPNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private NSYNWHAWPES CLEJJGWPADT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly XCQDGKDFWCC TPUNHHALMVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private float UEWAIHFOJBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private float GWMXQPWQFWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly NSYNWHAWPES DCAPEQVZTXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Vector3 KTDRKZYZBBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Vector3 OOTYAHXVXSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private float IPIUHFBAKZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private float WECXQRAZFOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private readonly NSYNWHAWPES MYSVBGPXCQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private readonly DXWKJPHKBXV RWRIJWGASUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private readonly NSYNWHAWPES TVEVLQBGYPA;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ANFWHCNXABV XSAWVHSKQMC
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public ANFWHCNXABV MHKXKFDOOBD
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public AvatarConfiguration NIJHUAUTONV
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8071720", Offset = "0x8070320", VA = "0x188071720", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AvatarBodyType QSQAIZWDRTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x806F850", Offset = "0x806E450", VA = "0x18806F850", Slot = "24")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public AvatarModernBodyConfiguration BNACWDAPYMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x806BB60", Offset = "0x806A760", VA = "0x18806BB60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private Transform EBHWLASZETG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8069FF0", Offset = "0x8068BF0", VA = "0x188069FF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private Transform GYDNJKHMQHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x805DDE0", Offset = "0x805C9E0", VA = "0x18805DDE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private SkinnedMeshRenderer PSNXYOLTFJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x80629F0", Offset = "0x80615F0", VA = "0x1880629F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Renderer[] VPNQNHYXPPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8062590", Offset = "0x8061190", VA = "0x188062590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private GameObject[] XYZNCHHAAPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x806B950", Offset = "0x806A550", VA = "0x18806B950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Animator OMUHPCRQJFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x806DEE0", Offset = "0x806CAE0", VA = "0x18806DEE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private VRIK FNBWPRIFEQL
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x805E910", Offset = "0x805D510", VA = "0x18805E910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private TZCVGCKVWLM RLNJXPTSPKE
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8071270", Offset = "0x806FE70", VA = "0x188071270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private TZCVGCKVWLM HPZVXCCGSVV
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8071350", Offset = "0x806FF50", VA = "0x188071350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private TZCVGCKVWLM YSUZCLZJJDI
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x805B5C0", Offset = "0x805A1C0", VA = "0x18805B5C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private TZCVGCKVWLM RQYUZEXFJVG
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x805FBB0", Offset = "0x805E7B0", VA = "0x18805FBB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private TZCVGCKVWLM LVAZJMNDZCF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x806C6F0", Offset = "0x806B2F0", VA = "0x18806C6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private TZCVGCKVWLM KHXDRTMKHJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x806BA80", Offset = "0x806A680", VA = "0x18806BA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private TZCVGCKVWLM RIBHAOBFZYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8063240", Offset = "0x8061E40", VA = "0x188063240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private TZCVGCKVWLM WFHENNHHAEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x805BC70", Offset = "0x805A870", VA = "0x18805BC70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public AvatarSystemPlayerSetupState RIATPTSCSPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x806B120", Offset = "0x8069D20", VA = "0x18806B120", Slot = "16")]
			get
			{
				return default(AvatarSystemPlayerSetupState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public MCZVCSKIEAC RAJRGZIVOBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x17755A0", Offset = "0x17741A0", VA = "0x1817755A0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public TRNIGYVQMJP WXOILGEQJQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xE24700", Offset = "0xE23300", VA = "0x180E24700", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IUWAFEQDJIN LYALZAZADUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x80733C0", Offset = "0x8071FC0", VA = "0x1880733C0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public IUWAFEQDJIN OWUHCNQEXFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x13434A0", Offset = "0x13420A0", VA = "0x1813434A0", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public string QVFKYLVNLHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA98620", Offset = "0xA97220", VA = "0x180A98620", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private Transform NVTENITZXSJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x806BBF0", Offset = "0x806A7F0", VA = "0x18806BBF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Transform CHZVQADCVZP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x80731B0", Offset = "0x8071DB0", VA = "0x1880731B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Transform FWBOATKLVYL
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x805B870", Offset = "0x805A470", VA = "0x18805B870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private Transform AHADYEOEMXR
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x805BD50", Offset = "0x805A950", VA = "0x18805BD50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private Transform DYRHTMGYYLM
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x806B910", Offset = "0x806A510", VA = "0x18806B910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private bool QZHYKGAKFVZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x806BA30", Offset = "0x806A630", VA = "0x18806BA30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private bool ZKEJUMVCKQL
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x806BA30", Offset = "0x806A630", VA = "0x18806BA30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private bool SXMLWQESEBV
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x80624A0", Offset = "0x80610A0", VA = "0x1880624A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private Transform ACYNIQETIZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x806DFC0", Offset = "0x806CBC0", VA = "0x18806DFC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public GameObject LZGHZUQQYJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8070DB0", Offset = "0x806F9B0", VA = "0x188070DB0", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public HeadLogicOffsets CMDXXHRLPZF
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x80733D0", Offset = "0x8071FD0", VA = "0x1880733D0", Slot = "34")]
			get
			{
				return default(HeadLogicOffsets);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Transform PKILZKVBIET
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1CD44B0", Offset = "0x1CD30B0", VA = "0x181CD44B0", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Transform WFCXESLPSAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xB6E2F0", Offset = "0xB6CEF0", VA = "0x180B6E2F0", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Transform QBIWSLATYHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1CD46E0", Offset = "0x1CD32E0", VA = "0x181CD46E0", Slot = "37")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Transform ZQDDOIWGYWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1343CF0", Offset = "0x13428F0", VA = "0x181343CF0", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 USYAWDQWECQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x805E3C0", Offset = "0x805CFC0", VA = "0x18805E3C0", Slot = "39")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float MQDFVRTWAOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x806F600", Offset = "0x806E200", VA = "0x18806F600", Slot = "40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Transform RHLYYAXLLGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8061760", Offset = "0x8060360", VA = "0x188061760", Slot = "41")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Transform BKLHKMWZEVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x1DC6690", Offset = "0x1DC5290", VA = "0x181DC6690", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Transform PCMGKHOPZHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x21D22A0", Offset = "0x21D0EA0", VA = "0x1821D22A0", Slot = "44")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Transform CCWASLOGLSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2481AA0", Offset = "0x24806A0", VA = "0x182481AA0", Slot = "45")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool XKMPHXLBVIV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x806D560", Offset = "0x806C160", VA = "0x18806D560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public NWSEZICLNSM<VENVHUECCSW.FootEvent> XRJAULVLKDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x1DB76D0", Offset = "0x1DB62D0", VA = "0x181DB76D0", Slot = "46")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool ZRWFSNEZRTA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x805D720", Offset = "0x805C320", VA = "0x18805D720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		private bool OUMBTMUHEVH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x805DEC0", Offset = "0x805CAC0", VA = "0x18805DEC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8071970", Offset = "0x8070570", VA = "0x188071970")]
		private float YPNSRPTXZXY(AvatarStance a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x805FC90", Offset = "0x805E890", VA = "0x18805FC90")]
		private void HGLQXDSVUQM([In] AvatarSystemUpdateState systemUpdateState, [In] AvatarModernBodyConfiguration config, bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8063320", Offset = "0x8061F20", VA = "0x188063320")]
		private float JJBKSBLVIPI([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x806F650", Offset = "0x806E250", VA = "0x18806F650")]
		private float UCFQIFEJJPI([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x805D020", Offset = "0x805BC20", VA = "0x18805D020")]
		private void DQZQAJVVRJS(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x806D650", Offset = "0x806C250", VA = "0x18806D650")]
		private void ROOOSRTCUQI([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x805D300", Offset = "0x805BF00", VA = "0x18805D300")]
		private void DVKKFDMAMGV([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8073F60", Offset = "0x8072B60", VA = "0x188073F60")]
		public BYCQWWIJHJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x80711A0", Offset = "0x806FDA0", VA = "0x1880711A0", Slot = "47")]
		public void WPJKVHJQDNS(float a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x806B0C0", Offset = "0x8069CC0", VA = "0x18806B0C0", Slot = "48")]
		public void NXLQJCTLXXB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x80697B0", Offset = "0x80683B0", VA = "0x1880697B0", Slot = "13")]
		public void MUWSWNSGTKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x806EDB0", Offset = "0x806D9B0", VA = "0x18806EDB0", Slot = "14")]
		public void TSEDWXXWSET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x805CF20", Offset = "0x805BB20", VA = "0x18805CF20", Slot = "15")]
		public void DELANVYLOAO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x80628A0", Offset = "0x80614A0", VA = "0x1880628A0", Slot = "26")]
		public Transform ILALNGRBILH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8070450", Offset = "0x806F050", VA = "0x188070450", Slot = "27")]
		public Vector3? VSCQJNTTDXE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8069D20", Offset = "0x8068920", VA = "0x188069D20", Slot = "7")]
		public void NEGULOBMZRP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x806A790", Offset = "0x8069390", VA = "0x18806A790")]
		private void NSACPXVZAAZ(AvatarModernBodyConfiguration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x805E630", Offset = "0x805D230", VA = "0x18805E630", Slot = "8")]
		public void FVPRBUUKQCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x806C300", Offset = "0x806AF00", VA = "0x18806C300")]
		private void QLCUYLPDMAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x805D7A0", Offset = "0x805C3A0", VA = "0x18805D7A0")]
		private Vector3 ERGXUWUHFOK([In] AvatarSystemUpdateState state)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x805EC40", Offset = "0x805D840", VA = "0x18805EC40", Slot = "6")]
		public void GRDKRDEJUVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x805EE30", Offset = "0x805DA30", VA = "0x18805EE30")]
		private void GUFYJDUPGMO(bool a, MovementUpdateMode b, AvatarModernBodyConfiguration c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x806ADC0", Offset = "0x80699C0", VA = "0x18806ADC0", Slot = "9")]
		public void NVVINAMNXEG(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x806E890", Offset = "0x806D490", VA = "0x18806E890")]
		private void TJSXWKYKZOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x80641F0", Offset = "0x8062DF0", VA = "0x1880641F0", Slot = "4")]
		public void KFXKJFEJMXL(string a, AvatarSystemInitState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x806B490", Offset = "0x806A090", VA = "0x18806B490", Slot = "5")]
		public void OFGFCSPYDZH(AvatarSystemPlayerSetupState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x805D1B0", Offset = "0x805BDB0", VA = "0x18805D1B0", Slot = "12")]
		public void DUANCFYVNMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x805E030", Offset = "0x805CC30", VA = "0x18805E030", Slot = "25")]
		public void FCWPQJMISVH([Out] Vector3 a, [Out] Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x805CFF0", Offset = "0x805BBF0", VA = "0x18805CFF0")]
		private void DEVUXCZBCQC([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x806EDA0", Offset = "0x806D9A0", VA = "0x18806EDA0", Slot = "28")]
		public void TPGSZKBTYDM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x806DA40", Offset = "0x806C640", VA = "0x18806DA40", Slot = "29")]
		public void RXHWOFUFCYT(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8069760", Offset = "0x8068360", VA = "0x188069760", Slot = "49")]
		public void MUOCNQOBTFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8071850", Offset = "0x8070450", VA = "0x188071850", Slot = "30")]
		public void YDYQNXPRRAE(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8066380", Offset = "0x8064F80", VA = "0x188066380", Slot = "31")]
		public HandLogicOffsets KTVZOJBTQLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8068C30", Offset = "0x8067830", VA = "0x188068C30", Slot = "32")]
		public PlatformSpecificPlayerHandOffsets LRXIRTFMFUE()
		{
			return default(PlatformSpecificPlayerHandOffsets);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8069CF0", Offset = "0x80688F0", VA = "0x188069CF0")]
		private void MXSYQSRZEUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x806F6D0", Offset = "0x806E2D0", VA = "0x18806F6D0")]
		private void UDEIAUEFVGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8069340", Offset = "0x8067F40", VA = "0x188069340")]
		private void MGUWGLITJBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x806A0D0", Offset = "0x8068CD0", VA = "0x18806A0D0")]
		private void NGAJTXJYWGF(CWNISIFRCSI a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8066200", Offset = "0x8064E00", VA = "0x188066200")]
		private void KRSMEKHJHPN(CWNISIFRCSI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x806FF90", Offset = "0x806EB90", VA = "0x18806FF90", Slot = "33")]
		public Vector3 UUSQBPVLANA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x806C400", Offset = "0x806B000", VA = "0x18806C400")]
		private void QPHVQMYGLLZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x805B5A0", Offset = "0x805A1A0", VA = "0x18805B5A0")]
		private void AKJQRIUJEPQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x806CEC0", Offset = "0x806BAC0", VA = "0x18806CEC0")]
		private void RAZHRYMWPGB(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x805CC10", Offset = "0x805B810", VA = "0x18805CC10")]
		private float CTTEWPSWPGG([In] AvatarSystemUpdateState state)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8069260", Offset = "0x8067E60", VA = "0x188069260")]
		private int MFKKSSJCWUT([In] AvatarSystemUpdateRateState updateRateState)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x805AD90", Offset = "0x8059990", VA = "0x18805AD90")]
		private void AIWSULKZDUC(AvatarSystemUpdateState a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x806F3E0", Offset = "0x806DFE0", VA = "0x18806F3E0")]
		private static void UADRAICXVXK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x80617C0", Offset = "0x80603C0", VA = "0x1880617C0")]
		private static void HWSVMKDNUGT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x80731F0", Offset = "0x8071DF0", VA = "0x1880731F0")]
		private float ZNITYIOZQHH()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x805BD90", Offset = "0x805A990", VA = "0x18805BD90")]
		private static int CCWNISLCAWR(BYCQWWIJHJB a, BYCQWWIJHJB b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x806B230", Offset = "0x8069E30", VA = "0x18806B230", Slot = "42")]
		public AvatarSystemUpdateState ODYZRDLEHPT()
		{
			return default(AvatarSystemUpdateState);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x805DF80", Offset = "0x805CB80", VA = "0x18805DF80")]
		private bool EZLLNDHOPWB(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8062820", Offset = "0x8061420", VA = "0x188062820")]
		public void IEENFEKBWRS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x805E450", Offset = "0x805D050", VA = "0x18805E450")]
		private (bool, bool) FRBJRRSLOXH()
		{
			return default((bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x805F6E0", Offset = "0x805E2E0", VA = "0x18805F6E0")]
		private (float, float) GUITSMIXXGW([In] AvatarSystemUpdateState state)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8066FD0", Offset = "0x8065BD0", VA = "0x188066FD0")]
		private void LHIXNYPSMMP([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x805D400", Offset = "0x805C000", VA = "0x18805D400")]
		private void EJDOALXPART([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8071990", Offset = "0x8070590", VA = "0x188071990")]
		private void YPSRPDTFKCE([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config, AvatarFootSettings a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8072DD0", Offset = "0x80719D0", VA = "0x188072DD0")]
		private float YYAPUPWPUUQ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x805A1B0", Offset = "0x8058DB0", VA = "0x18805A1B0")]
		private void AHYOMSNWUCU(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8071800", Offset = "0x8070400", VA = "0x188071800")]
		private float XXWXQIAUBFX()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x805D920", Offset = "0x805C520", VA = "0x18805D920")]
		private void ERYIUYMFDDX([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x805F8C0", Offset = "0x805E4C0", VA = "0x18805F8C0")]
		private void GWSKGOTLTZX([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8066BD0", Offset = "0x80657D0", VA = "0x188066BD0")]
		private void LDEXFVOSQWL([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x806AE30", Offset = "0x8069A30", VA = "0x18806AE30")]
		private void NVXZEFEXDTR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x806A3B0", Offset = "0x8068FB0", VA = "0x18806A3B0")]
		private void NIKXYRLLMKD(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x805CD90", Offset = "0x805B990", VA = "0x18805CD90")]
		private void DEAOAJEQRNC([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x806F150", Offset = "0x806DD50", VA = "0x18806F150")]
		private void TTJTUXRWWAD(HIEZQWSWLGS a, IKSolverVR.Arm b, Transform c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8070090", Offset = "0x806EC90", VA = "0x188070090")]
		private void VOFYJILNUIY(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x805B6A0", Offset = "0x805A2A0", VA = "0x18805B6A0")]
		private void BIOBKUZIDBN(HandGestureType a, IUWAFEQDJIN b, IKSolverVR.Arm c, float d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x805B8A0", Offset = "0x805A4A0", VA = "0x18805B8A0")]
		private void BJTLTXDVDIL([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x806E0A0", Offset = "0x806CCA0", VA = "0x18806E0A0")]
		private void TDKTBGFKXNY([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8068CF0", Offset = "0x80678F0", VA = "0x188068CF0")]
		protected void LTQCRLUNGTS([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8070E50", Offset = "0x806FA50", VA = "0x188070E50")]
		private void WNTIGVMMCTM([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x805E9F0", Offset = "0x805D5F0", VA = "0x18805E9F0")]
		protected void GGGQBTJIBTF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x80725B0", Offset = "0x80711B0", VA = "0x1880725B0")]
		private void YTSRUMIJMAA([In] AvatarSystemUpdateState state, [In] MovementUpdateMode movementUpdateMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8062670", Offset = "0x8061270", VA = "0x188062670")]
		private void ICYHNYNWDXV(AvatarSystemUpdateState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x805DF40", Offset = "0x805CB40", VA = "0x18805DF40")]
		private void EWIAYMBSNDY([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x806BDE0", Offset = "0x806A9E0", VA = "0x18806BDE0")]
		private Vector3 QERYJTDBJNU([In] AvatarSystemUpdateState state)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x80718A0", Offset = "0x80704A0", VA = "0x1880718A0")]
		private void YMITBIBFSPR([In] AvatarSystemUpdateState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x80633B0", Offset = "0x8061FB0", VA = "0x1880633B0")]
		private float JKLVJCGOREK(float a, [In] AvatarSystemUpdateState state)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x806DD90", Offset = "0x806C990", VA = "0x18806DD90")]
		private void RXPQFFHSPNH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x806C7D0", Offset = "0x806B3D0", VA = "0x18806C7D0")]
		private void RAAETZVDPLC([In] AvatarSystemUpdateState state, MovementUpdateMode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8071DB0", Offset = "0x80709B0", VA = "0x188071DB0")]
		private float YSEVPIJQIXB([In] AvatarSystemUpdateState systemUpdateState)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x80663D0", Offset = "0x8064FD0", VA = "0x1880663D0")]
		private void LBIJBWBRVCI(AvatarSystemUpdateState a, MovementUpdateMode b, Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x80690B0", Offset = "0x8067CB0", VA = "0x1880690B0")]
		private static void LVKSBYRZVYZ(Transform a, Quaternion b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x805B2C0", Offset = "0x8059EC0", VA = "0x18805B2C0")]
		private void AKJEVNBBXQE([In] AvatarSystemUpdateState updateState, [In] AvatarSystemUpdateRateState updateRateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8062AD0", Offset = "0x80616D0", VA = "0x188062AD0")]
		private void IUXPYYAVYCL([In] AvatarSystemUpdateState updateState, [In] AvatarSystemUpdateRateState updateRateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x806E6A0", Offset = "0x806D2A0", VA = "0x18806E6A0")]
		private void THDFWZURDZT(float a, [In] AvatarSystemUpdateState systemUpdateState, float b = 0.6f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x80705F0", Offset = "0x806F1F0", VA = "0x1880705F0")]
		private float VTBMCAZFQBS([In] AvatarSystemUpdateState systemUpdateState, [In] AvatarModernBodyConfiguration config)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8071430", Offset = "0x8070030", VA = "0x188071430")]
		private void XMDGVAYTUXG([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x805C200", Offset = "0x805AE00", VA = "0x18805C200")]
		private void CJDMMYNMHAL([In] AvatarSystemUpdateState systemUpdateState, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x806F930", Offset = "0x806E530", VA = "0x18806F930")]
		private void UHMLNDLACML([In] AvatarSystemUpdateState systemUpdateState, float a, float b, Vector3 c, float d = 0.6f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8063800", Offset = "0x8062400", VA = "0x188063800")]
		private void JUXXBQWDDMZ(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x806FD00", Offset = "0x806E900", VA = "0x18806FD00")]
		private void UTPCZZWMQRD(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x806E8E0", Offset = "0x806D4E0", VA = "0x18806E8E0")]
		private void TOFNMYQXAKL(AvatarSystemUpdateState a, AvatarModernBodyConfiguration b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x805BAB0", Offset = "0x805A6B0", VA = "0x18805BAB0")]
		public void BJXSTZKZQRE([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8072E50", Offset = "0x8071A50", VA = "0x188072E50")]
		public void ZEIEOMZWYLM([In] AvatarSystemUpdateState state, [In] AvatarModernBodyConfiguration config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x806BC40", Offset = "0x806A840", VA = "0x18806BC40")]
		[CompilerGenerated]
		internal static void PSJPGUOLGAV(Transform a, IKSolverVR.Arm b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x806FFE0", Offset = "0x806EBE0", VA = "0x18806FFE0")]
		[CompilerGenerated]
		internal static void VGBCNSFZARA(Vector3 a, Vector3 b, <>c__DisplayClass271_0 c, <>c__DisplayClass271_1 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x805E870", Offset = "0x805D470", VA = "0x18805E870")]
		[CompilerGenerated]
		internal static void FXHXZFGTFEX(CPNZYAQMEQL a, CPNZYAQMEQL b, Vector3 c, float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x806B380", Offset = "0x8069F80", VA = "0x18806B380")]
		[CompilerGenerated]
		internal static bool OEHATJDOYMG(IKSolverVR.Arm a, FTXLTZCYWFA b, float c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x805BDC0", Offset = "0x805A9C0", VA = "0x18805BDC0")]
		[CompilerGenerated]
		internal static float CENWGHMWPRU(Vector3 a, Vector3 b, Vector3 c, AvatarSystemUpdateState d, AvatarModernBodyConfiguration e, float f)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class AvatarSystemManager : PUANZVDCFLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private Dictionary<string, VENVHUECCSW> HJAGQCTSOQR;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8079070", Offset = "0x8077C70", VA = "0x188079070")]
		[YLZSHGPPZTN.Root]
		internal static void DSSFTEURBIJ(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8079150", Offset = "0x8077D50", VA = "0x188079150", Slot = "4")]
		public VENVHUECCSW NBTOTMSQPAI(string a, AvatarSystemConfiguration b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8079370", Offset = "0x8077F70", VA = "0x188079370", Slot = "5")]
		public void PXWCGWWUXQW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8079550", Offset = "0x8078150", VA = "0x188079550", Slot = "6")]
		public string VDZZJYWUUMB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x80790E0", Offset = "0x8077CE0", VA = "0x1880790E0")]
		private string KDGRHXEGOBT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8079680", Offset = "0x8078280", VA = "0x188079680")]
		public AvatarSystemManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ExecuteAlways]
	public class AvatarVRIKSimpleController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class FCUNTDPRSVZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private Dictionary<string, Transform> TTRQRDALLWI;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool XIYOMFQFIIA
			{
				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x807C4D0", Offset = "0x807B0D0", VA = "0x18807C4D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x807C350", Offset = "0x807AF50", VA = "0x18807C350")]
			public void CLYXFNAEEET(VRIK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
			public void ZYMYGVQSJPW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x807C480", Offset = "0x807B080", VA = "0x18807C480")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x807C510", Offset = "0x807B110", VA = "0x18807C510")]
			public FCUNTDPRSVZ()
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
		private readonly FCUNTDPRSVZ CAWRKYJFTCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private JMHKNJEMXOB NZOXZCVAXNY;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8079700", Offset = "0x8078300", VA = "0x188079700")]
		private void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x80799E0", Offset = "0x80785E0", VA = "0x1880799E0")]
		private bool KLZYXFVQYVB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8079A70", Offset = "0x8078670", VA = "0x188079A70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8079AE0", Offset = "0x80786E0", VA = "0x188079AE0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8079A80", Offset = "0x8078680", VA = "0x188079A80")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8079D90", Offset = "0x8078990", VA = "0x188079D90")]
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
			[Cpp2IlInjected.Address(RVA = "0x807DC10", Offset = "0x807C810", VA = "0x18807DC10")]
			public (float, float) LYZCLOGRIXM(float a)
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
			private int RYUJWTHQUEK;

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
				[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000120")]
				[Cpp2IlInjected.Address(RVA = "0xA98600", Offset = "0xA97200", VA = "0x180A98600")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x807D450", Offset = "0x807C050", VA = "0x18807D450")]
			public void NXLLWCOSNCZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x807D310", Offset = "0x807BF10", VA = "0x18807D310")]
			public (float, float) DOSYDZDQRHY(Animator a, AnimatorStateInfo b)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly int IILYUILIANX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private Dictionary<int, HandPoseSetting> WOYFAYMOOOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private HandsOpenCloseAmount[] IdleStanceHandOpenCloseAmount;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x807D790", Offset = "0x807C390", VA = "0x18807D790")]
		public void NXLLWCOSNCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x807D970", Offset = "0x807C570", VA = "0x18807D970")]
		public (float, float) VGWJUPIPUXK(Animator a, AvatarStance b, float c)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x807D530", Offset = "0x807C130", VA = "0x18807D530")]
		private (float, float) BISWPPQNRSY(Animator a, AnimatorStateInfo b, AvatarStance c, float d)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x807DC00", Offset = "0x807C800", VA = "0x18807DC00")]
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
		[Cpp2IlInjected.Address(RVA = "0x80809A0", Offset = "0x807F5A0", VA = "0x1880809A0", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8080B10", Offset = "0x807F710", VA = "0x188080B10")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
namespace RecRoom.Avatars.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal abstract class UKKFUGOPQEP<a, b> : RTGPQGZNOXM<a, b> where b : class
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		protected readonly YMWLTMFTDAZ TLUYFXKMIRA;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x602EB40", Offset = "0x602D740", VA = "0x18602EB40")]
		protected UKKFUGOPQEP(YMWLTMFTDAZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract b Deserialize(a input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x602EAA0", Offset = "0x602D6A0", VA = "0x18602EAA0", Slot = "5")]
		public bool DKESBADTYOL(a a, [Out] b? result, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[Tested]
	public static class FOLLHLFSNTF
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly Regex WLRQCPVDFDI;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x807C830", Offset = "0x807B430", VA = "0x18807C830")]
		public static XTAVVOIJGEE XUKYBKDXEAQ(AvatarItemId a, CombinationId b, Guid? c, Color? d, AvatarBodyPart e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x807C590", Offset = "0x807B190", VA = "0x18807C590")]
		public static AvatarItemDesc JBRBAQBOVXN(XTAVVOIJGEE a)
		{
			return default(AvatarItemDesc);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x367DC50", Offset = "0x367C850", VA = "0x18367DC50")]
		internal static a? IQEIGRDBTCV<a>(string? input, ZHDXWBIYBGP<a> a, YMWLTMFTDAZ b, InvalidGuidHandling c, a d) where a : struct, QLZKOHPYUWG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x367E400", Offset = "0x367D000", VA = "0x18367E400")]
		internal static FRJVAZTPOGW KWIGLOLGZXO<b>(string? input, ZHDXWBIYBGP<b> a, YMWLTMFTDAZ b, InvalidGuidHandling c, b d) where b : struct, QLZKOHPYUWG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x807C6F0", Offset = "0x807B2F0", VA = "0x18807C6F0")]
		internal static List<CustomAvatarItemVisualData> XLVNWDGQVIA(IEnumerable<OutfitSelectionDTO>? selections)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x367E7F0", Offset = "0x367D3F0", VA = "0x18367E7F0")]
		internal static string NRGFIMWCTUJ<c>(c a, ZHDXWBIYBGP<c> b, YMWLTMFTDAZ c) where c : QLZKOHPYUWG
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal class SSMUERFDCXR : MALTQBYOEZM
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public RTGPQGZNOXM<MUZUGHZKOHG, AvatarData> OWOGKEMMUOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public RTGPQGZNOXM<OutfitDTO, AYEBDMFCMGR> JTHQCNFVJWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public RTGPQGZNOXM<OutfitDTO, AYEBDMFCMGR> KJMMSKOXOSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public VQZWPQUKHMA NYAIZPDWGWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xA98640", Offset = "0xA97240", VA = "0x180A98640", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public DGOTBQEXQPR HKLKEGGMFRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xA98610", Offset = "0xA97210", VA = "0x180A98610", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8081740", Offset = "0x8080340", VA = "0x188081740")]
		[YLZSHGPPZTN.Root.GameOnly]
		[UsedImplicitly]
		internal static void XMPESWYAWUT(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x80817B0", Offset = "0x80803B0", VA = "0x1880817B0")]
		[RecRoom.NoEngine.Common.Preserve]
		internal SSMUERFDCXR([Inject("UnitySerialization")] OSECJHAZBUP jsonSerializationService, [Inject(null)] IJDIHDHKFZU runtimeMapperProvider, [Inject(null)] YMWLTMFTDAZ debugLogger)
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
		[Cpp2IlInjected.Address(RVA = "0x8078FE0", Offset = "0x8077BE0", VA = "0x188078FE0")]
		public AvatarParseException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8079040", Offset = "0x8077C40", VA = "0x188079040")]
		public AvatarParseException(string message, Exception innerException)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8079010", Offset = "0x8077C10", VA = "0x188079010")]
		public AvatarParseException(AvatarParseErrorCode code, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8078FA0", Offset = "0x8077BA0", VA = "0x188078FA0")]
		public AvatarParseException(AvatarParseErrorCode code, string message, Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal abstract class TTKCAIBRXIW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly OSECJHAZBUP CZADWRECVBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly IJDIHDHKFZU EFHNTPKWOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly YMWLTMFTDAZ TLUYFXKMIRA;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x807D1A0", Offset = "0x807BDA0", VA = "0x18807D1A0")]
		protected TTKCAIBRXIW(OSECJHAZBUP a, IJDIHDHKFZU b, YMWLTMFTDAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8081E10", Offset = "0x8080A10", VA = "0x188081E10")]
		protected string SLANZCELZTL(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8083450", Offset = "0x8082050", VA = "0x188083450")]
		protected string ZRANLNLFEVJ(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8083120", Offset = "0x8081D20", VA = "0x188083120")]
		private AvatarOutfitSelectionData XUKYBKDXEAQ(XTAVVOIJGEE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8081CD0", Offset = "0x80808D0", VA = "0x188081CD0")]
		private static AvatarCustomizationSettingsData.AnchorParams MYHGITHAUVZ(WMJDIYNPHFG? a)
		{
			return default(AvatarCustomizationSettingsData.AnchorParams);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface RTGPQGZNOXM<in a, b> where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b Deserialize(a input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool DKESBADTYOL(a a, [Out] b? result, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface MALTQBYOEZM
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		RTGPQGZNOXM<MUZUGHZKOHG, AvatarData> OWOGKEMMUOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		RTGPQGZNOXM<OutfitDTO, AYEBDMFCMGR> KJMMSKOXOSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		VQZWPQUKHMA NYAIZPDWGWF
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
	public interface DGOTBQEXQPR
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LegacyOutfitDataDTO DKWNNTIDYNZ(AvatarData a);
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface VQZWPQUKHMA
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		OutfitDTO DKWNNTIDYNZ(AvatarData a, int b, string? name, string? previewImageName, UgcAccessibility c, List<CustomAvatarItemVisualData>? customAvatarItems);
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[Tested]
	internal class OWOGKEMMUOD : UKKFUGOPQEP<MUZUGHZKOHG, AvatarData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private readonly IJDIHDHKFZU EFHNTPKWOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private readonly JTHQCNFVJWJ JMOHKKRSILD;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8081240", Offset = "0x807FE40", VA = "0x188081240")]
		public OWOGKEMMUOD(OSECJHAZBUP a, IJDIHDHKFZU b, YMWLTMFTDAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8080F90", Offset = "0x807FB90", VA = "0x188080F90", Slot = "6")]
		public override AvatarData Deserialize(MUZUGHZKOHG input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class OutfitNewtonsoftJsonSerializer : OSECJHAZBUP
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private class RDRCACTBIXM : JsonConverter<FRJVAZTPOGW>
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8081660", Offset = "0x8080260", VA = "0x188081660", Slot = "9")]
			public override void WriteJson(JsonWriter writer, FRJVAZTPOGW? value, JsonSerializer serializer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x8081550", Offset = "0x8080150", VA = "0x188081550", Slot = "10")]
			public override FRJVAZTPOGW ReadJson(JsonReader reader, Type objectType, FRJVAZTPOGW? existingValue, bool hasExistingValue, JsonSerializer serializer)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8081700", Offset = "0x8080300", VA = "0x188081700")]
			public RDRCACTBIXM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private class TVWQWYENREQ : JsonConverter
		{
			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override bool CanRead
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x80839D0", Offset = "0x80825D0", VA = "0x1880839D0", Slot = "5")]
			public override object ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x8083620", Offset = "0x8082220", VA = "0x188083620", Slot = "6")]
			public override bool CanConvert(Type objectType)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x8083A20", Offset = "0x8082620", VA = "0x188083A20", Slot = "4")]
			public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x80837F0", Offset = "0x80823F0", VA = "0x1880837F0")]
			private static bool JAZXIBAHGEP(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
			public TVWQWYENREQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private readonly JsonSerializerSettings CFAUHHSRCRQ;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8081400", Offset = "0x8080000", VA = "0x188081400")]
		internal OutfitNewtonsoftJsonSerializer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x38B6310", Offset = "0x38B4F10", VA = "0x1838B6310", Slot = "4")]
		public string KMFFBFGXSII<a>(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x38B6460", Offset = "0x38B5060", VA = "0x1838B6460", Slot = "5")]
		public b RFRWQDQRUJP<b>(string a)
		{
			return (b)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[RecRoom.NoEngine.Common.Preserve]
	internal class OutfitUtf8JsonSerializer : OSECJHAZBUP
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x38B6820", Offset = "0x38B5420", VA = "0x1838B6820", Slot = "4")]
		public string KMFFBFGXSII<a>(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x38B69C0", Offset = "0x38B55C0", VA = "0x1838B69C0", Slot = "5")]
		public b RFRWQDQRUJP<b>(string a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public OutfitUtf8JsonSerializer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[Tested]
	internal class JTHQCNFVJWJ : UKKFUGOPQEP<OutfitDTO, AYEBDMFCMGR>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private readonly OSECJHAZBUP CZADWRECVBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private readonly IJDIHDHKFZU EFHNTPKWOIJ;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x80800D0", Offset = "0x807ECD0", VA = "0x1880800D0")]
		public JTHQCNFVJWJ(OSECJHAZBUP a, IJDIHDHKFZU b, YMWLTMFTDAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x807E0D0", Offset = "0x807CCD0", VA = "0x18807E0D0", Slot = "6")]
		public override AYEBDMFCMGR Deserialize(OutfitDTO input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x807F490", Offset = "0x807E090", VA = "0x18807F490")]
		internal void SKXQMDXTIQC(string a, AvatarData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x807F3D0", Offset = "0x807DFD0", VA = "0x18807F3D0")]
		public IEnumerable<XTAVVOIJGEE> PCJPORJSZBE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x807DCD0", Offset = "0x807C8D0", VA = "0x18807DCD0")]
		private IEnumerable<XTAVVOIJGEE> DRUQMYVXIQM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x807ED80", Offset = "0x807D980", VA = "0x18807ED80")]
		internal IEnumerable<XTAVVOIJGEE> HILOOGLSDQQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x807FD50", Offset = "0x807E950", VA = "0x18807FD50")]
		private XTAVVOIJGEE YOSPKKNYJTY(AvatarOutfitSelectionData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x807E4F0", Offset = "0x807D0F0", VA = "0x18807E4F0")]
		private void GNTVQDQRVDQ(AvatarCustomizationSettingsData a, AvatarData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x807FA30", Offset = "0x807E630", VA = "0x18807FA30")]
		private XTAVVOIJGEE YOSPKKNYJTY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x807F740", Offset = "0x807E340", VA = "0x18807F740")]
		internal static (AvatarBodyPart, string, string) WPLGNLASVBM(string a, YMWLTMFTDAZ b)
		{
			return default((AvatarBodyPart, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x807F1D0", Offset = "0x807DDD0", VA = "0x18807F1D0")]
		private LYBUUUDLTOE? LJWBIBSEHZE(string? a, Vector2 b, float c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x807F5E0", Offset = "0x807E1E0", VA = "0x18807F5E0")]
		private static WMJDIYNPHFG UDRXOBEIVVC(AvatarCustomizationSettingsData.AnchorParams a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Tested]
	internal class HKLKEGGMFRA : TTKCAIBRXIW, DGOTBQEXQPR
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x807D1A0", Offset = "0x807BDA0", VA = "0x18807D1A0")]
		public HKLKEGGMFRA(OSECJHAZBUP a, IJDIHDHKFZU b, YMWLTMFTDAZ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x807CAC0", Offset = "0x807B6C0", VA = "0x18807CAC0", Slot = "4")]
		public LegacyOutfitDataDTO DKWNNTIDYNZ(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x807CE80", Offset = "0x807BA80", VA = "0x18807CE80")]
		private string JSVYWXRIRJC(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x807CF70", Offset = "0x807BB70", VA = "0x18807CF70")]
		private string WZDDBKUAUJL(XTAVVOIJGEE a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[Tested]
	internal class KJMMSKOXOSS : UKKFUGOPQEP<OutfitDTO, AYEBDMFCMGR>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private readonly OSECJHAZBUP CZADWRECVBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private readonly RTGPQGZNOXM<OutfitDTO, AYEBDMFCMGR> WPTBOLPTXZR;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8080620", Offset = "0x807F220", VA = "0x188080620")]
		public KJMMSKOXOSS(RTGPQGZNOXM<OutfitDTO, AYEBDMFCMGR> a, YMWLTMFTDAZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8080200", Offset = "0x807EE00", VA = "0x188080200", Slot = "6")]
		public override AYEBDMFCMGR Deserialize(OutfitDTO input, [Out] IReadOnlyList<CustomAvatarItemVisualData>? customAvatarItems)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[Tested]
	internal class NYAIZPDWGWF : VQZWPQUKHMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private readonly OSECJHAZBUP CZADWRECVBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private readonly DGOTBQEXQPR DSVOMPBLCCN;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8080EB0", Offset = "0x807FAB0", VA = "0x188080EB0")]
		public NYAIZPDWGWF(DGOTBQEXQPR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8080B30", Offset = "0x807F730", VA = "0x188080B30", Slot = "4")]
		public OutfitDTO DKWNNTIDYNZ(AvatarData a, int b, string? name, string? previewImageName, UgcAccessibility c, List<CustomAvatarItemVisualData>? customAvatarItems)
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
		[Cpp2IlInjected.Address(RVA = "0x8078660", Offset = "0x8077260", VA = "0x188078660")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA96140", Offset = "0xA94D40", VA = "0x180A96140")]
		public AnimatorDebugUtil()
		{
		}
	}
}
namespace RecRoom.Avatars.Extensions
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class LBLDCKRGJJE
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8080830", Offset = "0x807F430", VA = "0x188080830")]
		public static AvatarItemDesc Deserialize(this EZHEVMAZQFH data)
		{
			return default(AvatarItemDesc);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8080710", Offset = "0x807F310", VA = "0x188080710")]
		public static EZHEVMAZQFH DKWNNTIDYNZ(this AvatarItemDesc a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8080940", Offset = "0x807F540", VA = "0x188080940")]
		public static bool NQDKVZWULTH(this AvatarItemDesc a)
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
			[Cpp2IlInjected.Address(RVA = "0x633C830", Offset = "0x633B430", VA = "0x18633C830")]
			public AnchorParams(Vector2 normalizedPosition, Vector3 hemisphereOffsets, Vector3 hemisphereRotations)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x80785B0", Offset = "0x80771B0", VA = "0x1880785B0")]
			internal WMJDIYNPHFG DKWNNTIDYNZ()
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
		internal static AnchorParams UGRJLOCCXZE
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x8078AE0", Offset = "0x80776E0", VA = "0x188078AE0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xA98600", Offset = "0xA97200", VA = "0x180A98600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x15E31C0", Offset = "0x15E1DC0", VA = "0x1815E31C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xB24570", Offset = "0xB23170", VA = "0x180B24570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xDBE310", Offset = "0xDBCF10", VA = "0x180DBE310")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x10F91C0", Offset = "0x10F7DC0", VA = "0x1810F91C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA98610", Offset = "0xA97210", VA = "0x180A98610")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xA9F8D0", Offset = "0xA9E4D0", VA = "0x180A9F8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8078F10", Offset = "0x8077B10", VA = "0x188078F10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAA3D30", Offset = "0xAA2930", VA = "0x180AA3D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xAE6BF0", Offset = "0xAE57F0", VA = "0x180AE6BF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x19ED070", Offset = "0x19EBC70", VA = "0x1819ED070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xA988D0", Offset = "0xA974D0", VA = "0x180A988D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xA988A0", Offset = "0xA974A0", VA = "0x180A988A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x27CEA80", Offset = "0x27CD680", VA = "0x1827CEA80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xCC4FE0", Offset = "0xCC3BE0", VA = "0x180CC4FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xFC1080", Offset = "0xFBFC80", VA = "0x180FC1080")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x1190A30", Offset = "0x118F630", VA = "0x181190A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA9A590", Offset = "0xA99190", VA = "0x180A9A590")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA9A570", Offset = "0xA99170", VA = "0x180A9A570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x2154440", Offset = "0x2153040", VA = "0x182154440")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xCE38B0", Offset = "0xCE24B0", VA = "0x180CE38B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xAB0E70", Offset = "0xAAFA70", VA = "0x180AB0E70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F00", Offset = "0xABFB00", VA = "0x180AC0F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA9D870", Offset = "0xA9C470", VA = "0x180A9D870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA9D130", Offset = "0xA9BD30", VA = "0x180A9D130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA9D860", Offset = "0xA9C460", VA = "0x180A9D860")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA9D200", Offset = "0xA9BE00", VA = "0x180A9D200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA9D1D0", Offset = "0xA9BDD0", VA = "0x180A9D1D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xA9D160", Offset = "0xA9BD60", VA = "0x180A9D160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xAC5C70", Offset = "0xAC4870", VA = "0x180AC5C70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xCAD0A0", Offset = "0xCABCA0", VA = "0x180CAD0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA9D810", Offset = "0xA9C410", VA = "0x180A9D810")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA9D820", Offset = "0xA9C420", VA = "0x180A9D820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xB82670", Offset = "0xB81270", VA = "0x180B82670")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xB81D90", Offset = "0xB80990", VA = "0x180B81D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xA96C10", Offset = "0xA95810", VA = "0x180A96C10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xA96EF0", Offset = "0xA95AF0", VA = "0x180A96EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xC33090", Offset = "0xC31C90", VA = "0x180C33090")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xCE42B0", Offset = "0xCE2EB0", VA = "0x180CE42B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xC32D70", Offset = "0xC31970", VA = "0x180C32D70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xC30370", Offset = "0xC2EF70", VA = "0x180C30370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public HelmetHairState UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xDC68F0", Offset = "0xDC54F0", VA = "0x180DC68F0")]
			get
			{
				return default(HelmetHairState);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xDC7C00", Offset = "0xDC6800", VA = "0x180DC7C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xB0B120", Offset = "0xB09D20", VA = "0x180B0B120")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xB0B440", Offset = "0xB0A040", VA = "0x180B0B440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x8078F30", Offset = "0x8077B30", VA = "0x188078F30")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x8078F50", Offset = "0x8077B50", VA = "0x188078F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8078B90", Offset = "0x8077790", VA = "0x188078B90")]
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
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
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
		private MaterialCombinationId? MQAKKIBBNCJ;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x8078F70", Offset = "0x8077B70", VA = "0x188078F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
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
