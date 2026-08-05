using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.RecRoom.Api;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using RecRoom.Core.Studio.StudioFunctions;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8FA5980", Offset = "0x8FA4780", VA = "0x188FA5980")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC7F30", Offset = "0xAC6D30", VA = "0x180AC7F30")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Studio_Common_Base_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8FA3D30", Offset = "0x8FA2B30", VA = "0x188FA3D30", Slot = "4")]
		public override void IPFDCTVTWHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Core.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct RotatedBounds
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public enum FaceType
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			Top,
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			Bottom,
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			Front,
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Back,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Right,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			Left
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct Face
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public Vector3 center;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public Quaternion rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public Vector3 halfSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public FaceType faceType;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Vector3 XALFOAOPQNO
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x8FA3750", Offset = "0x8FA2550", VA = "0x188FA3750")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public Vector3 WSIUTDLEAAL
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x8FA36C0", Offset = "0x8FA24C0", VA = "0x188FA36C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public Vector3 LAMNAOHZGVI
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x8FA3630", Offset = "0x8FA2430", VA = "0x188FA3630")]
				get
				{
					return default(Vector3);
				}
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public Vector3 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Vector3 halfSize;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Vector3 WSIUTDLEAAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8FA36C0", Offset = "0x8FA24C0", VA = "0x188FA36C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Vector3 LAMNAOHZGVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8FA3630", Offset = "0x8FA2430", VA = "0x188FA3630")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Vector3 AHXEQIYRVSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8FA3750", Offset = "0x8FA2550", VA = "0x188FA3750")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Vector3 ELJWKEBKPCY
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8FAA5B0", Offset = "0x8FA93B0", VA = "0x188FAA5B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8FAA770", Offset = "0x8FA9570", VA = "0x188FAA770")]
		public bool Contains([In] RotatedBounds other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8FAA660", Offset = "0x8FA9460", VA = "0x188FAA660")]
		public bool Contains(Vector3 point)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8FAB6A0", Offset = "0x8FAA4A0", VA = "0x188FAB6A0")]
		public bool RQOLVTGJRRG(Collider a, Bounds b, bool c, bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8FAB260", Offset = "0x8FAA060", VA = "0x188FAB260")]
		public bool JXKPESMOANZ(Collider a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8FAAD00", Offset = "0x8FA9B00", VA = "0x188FAAD00")]
		public bool EMHVKEBEFLW(Collider a, bool b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC460", Offset = "0x8FAB260", VA = "0x188FAC460")]
		public void UUXAMLCWQEG(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC750", Offset = "0x8FAB550", VA = "0x188FAC750")]
		public void XLNIWDMPHOA(RotatedBounds a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD050", Offset = "0x8FABE50", VA = "0x188FAD050")]
		public void XLNIWDMPHOA(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8FAAC80", Offset = "0x8FA9A80", VA = "0x188FAAC80")]
		private static void EARWAZOZUMM(Vector3 a, Vector3 b, Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8FAB300", Offset = "0x8FAA100", VA = "0x188FAB300")]
		public static RotatedBounds OLSRTMVDERG(GameObject a, Quaternion b, bool c, bool d, bool e = false, bool f = false, bool g = false)
		{
			return default(RotatedBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8FAB280", Offset = "0x8FAA080", VA = "0x188FAB280")]
		public Face KDOLNIIYOSH(Vector3 a)
		{
			return default(Face);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8FABE10", Offset = "0x8FAAC10", VA = "0x188FABE10")]
		public Face UIRLXARGPZK(FaceType a)
		{
			return default(Face);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8FABBD0", Offset = "0x8FAA9D0", VA = "0x188FABBD0")]
		private FaceType RTOPDNGQXEH(Vector3 a)
		{
			return default(FaceType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC0C0", Offset = "0x8FAAEC0", VA = "0x188FAC0C0")]
		private static Quaternion UKDPOJIQFZH(FaceType a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC510", Offset = "0x8FAB310", VA = "0x188FAC510")]
		public static RotatedBounds XLNIWDMPHOA(IEnumerable<RotatedBounds> a)
		{
			return default(RotatedBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8FABD30", Offset = "0x8FAAB30", VA = "0x188FABD30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[Obfuscation(Exclude = true, ApplyToMembers = true)]
	public enum AssetBundleType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		WindowsDesktop,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		MobileIOS,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		MobileAndroid,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[Obsolete("Quest bundles are Obsolete.  Use MobileAndroid instead", true)]
		OculusQuest,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		XboxOne,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Playstation4,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Playstation5,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Obsolete("SwitchLZMA should not be used.  Use Switch instead", true)]
		SwitchLZMA,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Switch
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum AssetBundleVersion
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Obsolete]
		InitialRelease_Unity_2019_4_26f1 = 0,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[Obsolete]
		Unity_2020_3_33f1 = 1,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[Obsolete]
		Unity_2021_3_19f1 = 2,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Unity_2021_3_29f1 = 3,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Unity_2021_3_29f1_AvatarItemMaterialBundle = 4,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Unity_6000_0_27f1 = 5,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Unity_6000_0_27f1_AvatarItemMaterialBundle = 6,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Current = 5,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		CurrentMaterial = 6
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class UTWKQTNMPHE
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string JZCYSGHNXQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8FAEA40", Offset = "0x8FAD840", VA = "0x188FAEA40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static string USUHHJRGGYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8FAEAA0", Offset = "0x8FAD8A0", VA = "0x188FAEAA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static string ODBPSFRJZWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8FAEA70", Offset = "0x8FAD870", VA = "0x188FAEA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE990", Offset = "0x8FAD790", VA = "0x188FAE990")]
		public static AssetBundleVersion CIMWQDDJTDV(this AssetBundleVersion a)
		{
			return default(AssetBundleVersion);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE990", Offset = "0x8FAD790", VA = "0x188FAE990")]
		public static int CIMWQDDJTDV(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface QYGUDNVBQQX
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		AudioMixerGroup PWSFDZDNYDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		IReadOnlyList<QYGUDNVBQQX> GMWEVQQOKDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		string VTVZRHPQXJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class VUWABQEKZDJ
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		private class Group : QYGUDNVBQQX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			internal readonly List<QYGUDNVBQQX> VVZIEWRJTKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			internal readonly Group JMPYHJSVEGS;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AudioMixerGroup PWSFDZDNYDV
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<QYGUDNVBQQX> GMWEVQQOKDC
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public string VTVZRHPQXJS
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8FA38C0", Offset = "0x8FA26C0", VA = "0x188FA38C0")]
			internal Group(AudioMixerGroup group, Group parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public QYGUDNVBQQX IWRWIZZEVDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public AudioMixer ZMIBHRMGJAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x8FAEFD0", Offset = "0x8FADDD0", VA = "0x188FAEFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		private VUWABQEKZDJ(Group a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8FAED10", Offset = "0x8FADB10", VA = "0x188FAED10")]
		public static VUWABQEKZDJ BKFZUOOYKBS(AudioMixer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF0B0", Offset = "0x8FADEB0", VA = "0x188FAF0B0")]
		public QYGUDNVBQQX TCNAASENHZG(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF030", Offset = "0x8FADE30", VA = "0x188FAF030")]
		private static int SVVGLUSGARS(string a, int b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[Obfuscation(Exclude = true, ApplyToMembers = true)]
	public interface IStudioUnityAssetRegistrationEntry
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		Guid UniqueId
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		Guid UnityAssetId
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		IEnumerable<Guid> ReferencedUnityAssetIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "4")]
		IStudioUnityAssetRegistrationEntry ToUnityAssetRegistrationEntry();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class MaterialMapAssetBase<TMaterialMapAsset> : RecRoomStudioAutoGeneratedAsset<TMaterialMapAsset> where TMaterialMapAsset : MaterialMapAssetBase<TMaterialMapAsset>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private MaterialEntry[] entries;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public MaterialEntry[] MVNMARVVPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool OFAJOYFSKKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BB0", Offset = "0xA9F9B0", VA = "0x180AA0BB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAA0940", Offset = "0xA9F740", VA = "0x180AA0940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x59FD0F0", Offset = "0x59FBEF0", VA = "0x1859FD0F0")]
		public MaterialEntry TryFindEntry(Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x59FD0C0", Offset = "0x59FBEC0", VA = "0x1859FD0C0")]
		public void ClearEntries()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x59FD1C0", Offset = "0x59FBFC0", VA = "0x1859FD1C0")]
		public MaterialMapAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class MaterialMapBase<TMaterialMapAsset> : RecRoomUnitySceneSystemBase where TMaterialMapAsset : MaterialMapAssetBase<TMaterialMapAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static MaterialMapBase<TMaterialMapAsset> YKIIEGGLVSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		[HideInInspector]
		private MaterialEntry[] entries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private TMaterialMapAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static MaterialMapBase<TMaterialMapAsset> VDCQJFYBFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x59FD6C0", Offset = "0x59FC4C0", VA = "0x1859FD6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public MaterialEntry[] MVNMARVVPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x59FD640", Offset = "0x59FC440", VA = "0x1859FD640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x59FD1D0", Offset = "0x59FBFD0", VA = "0x1859FD1D0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x59FD550", Offset = "0x59FC350", VA = "0x1859FD550")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x59FD460", Offset = "0x59FC260", VA = "0x1859FD460")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x59FD3E0", Offset = "0x59FC1E0", VA = "0x1859FD3E0")]
		public void ClearSceneMaterials()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xABA530", Offset = "0xAB9330", VA = "0x180ABA530")]
		protected MaterialMapBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class TextureProperty : IEquatable<TextureProperty>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Texture value;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE430", Offset = "0x8FAD230", VA = "0x188FAE430", Slot = "4")]
		public bool Equals(TextureProperty other)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class FloatProperty : IEquatable<FloatProperty>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8FA3860", Offset = "0x8FA2660", VA = "0x188FA3860", Slot = "4")]
		public bool Equals(FloatProperty other)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class VectorProperty : IEquatable<VectorProperty>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector4 value;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF550", Offset = "0x8FAE350", VA = "0x188FAF550", Slot = "4")]
		public bool Equals(VectorProperty other)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class ColorProperty : IEquatable<ColorProperty>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Color value;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1F30", Offset = "0x8FA0D30", VA = "0x188FA1F30", Slot = "4")]
		public bool Equals(ColorProperty other)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class MaterialEntry : IEquatable<MaterialEntry>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public string shaderName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public MaterialGlobalIlluminationFlags globalIlluminationFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int renderQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public bool doubleSidedGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public TextureProperty[] texProps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public FloatProperty[] floatProps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public VectorProperty[] vecProps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public ColorProperty[] colorProps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Dictionary<string, float> WFQAYJCDJRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Dictionary<int, float> SERXZKIVTAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Dictionary<int, Texture> XYOOKWPHQAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Dictionary<int, Vector4> QUUQFSASGYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<int, Color> EFBBZAXGELI;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8FA3E10", Offset = "0x8FA2C10", VA = "0x188FA3E10")]
		public void DAHDAPTEEOS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4460", Offset = "0x8FA3260", VA = "0x188FA4460")]
		public float ZBRXOSQDDKJ(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4360", Offset = "0x8FA3160", VA = "0x188FA4360")]
		public Texture GetTexture(int propertyId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8FA43B0", Offset = "0x8FA31B0", VA = "0x188FA43B0")]
		public Vector4 OWFYXPAEHPU(int a)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4180", Offset = "0x8FA2F80", VA = "0x188FA4180")]
		public Color EQMCHJAPUDW(int a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4200", Offset = "0x8FA3000", VA = "0x188FA4200", Slot = "4")]
		public bool Equals(MaterialEntry other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class RecRoomAudioClipRegistryAssetBase<TAudioClipRegistryAsset> : RecRoomStudioAutoCreatedAsset<TAudioClipRegistryAsset> where TAudioClipRegistryAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		internal RecRoomAudioClipEntry[] clips;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public IReadOnlyList<RecRoomAudioClipEntry> PLEKRUGDFIS
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5F6A4F0", Offset = "0x5F692F0", VA = "0x185F6A4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xDAF380", Offset = "0xDAE180", VA = "0x180DAF380")]
		public RecRoomAudioClipRegistryAssetBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class RecRoomAudioClipEntry : IStudioUnityAssetRegistrationEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public AudioClip Clip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public SerializedGuid UnityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public SerializedGuid[] ReferencedUnityAssetIds;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Guid UnityAssetIdGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8FA6550", Offset = "0x8FA5350", VA = "0x188FA6550")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8FA6660", Offset = "0x8FA5460", VA = "0x188FA6660", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Guid ASXZFJAMNSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x8FA6520", Offset = "0x8FA5320", VA = "0x188FA6520", Slot = "5")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Guid PQVMQEAAVCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8FA6550", Offset = "0x8FA5350", VA = "0x188FA6550", Slot = "6")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private IEnumerable<Guid> YXLEFJRNHRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8FA63E0", Offset = "0x8FA51E0", VA = "0x188FA63E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8FA65C0", Offset = "0x8FA53C0", VA = "0x188FA65C0", Slot = "8")]
		public IStudioUnityAssetRegistrationEntry ToUnityAssetRegistrationEntry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public RecRoomAudioClipEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[AddComponentMenu("/")]
	public abstract class RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> : RecRoomUnitySceneSystemBase where TAudioClipRegistryAsset : RecRoomAudioClipRegistryAssetBase<TAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> YKIIEGGLVSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		[ReadOnlyField]
		private TAudioClipRegistryAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> VDCQJFYBFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x59FD6C0", Offset = "0x59FC4C0", VA = "0x1859FD6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public TAudioClipRegistryAsset MVNMARVVPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RecRoomAudioClipEntry> PLEKRUGDFIS
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5F6A7F0", Offset = "0x5F695F0", VA = "0x185F6A7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5F6A540", Offset = "0x5F69340", VA = "0x185F6A540")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5F6A670", Offset = "0x5F69470", VA = "0x185F6A670")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xABA530", Offset = "0xAB9330", VA = "0x180ABA530")]
		protected RecRoomAudioClipRegistryBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class QASWGQDRYAL
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[Obfuscation(Exclude = true, ApplyToMembers = true)]
		public enum AudioMixerGroupType
		{
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			Ambience,
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			Music,
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			Sounds,
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			Voice,
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			Voice_LowPitch,
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			Voice_HighPitch,
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			Voice_Radio,
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			Voice_Radio_LowPitch,
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			Voice_Radio_HighPitch
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly RecRoomAudioMixerRegistryBase.MixerVersion version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly AudioMixer BPCWXNHYYXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly AudioMixer HJXNSVXYEQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly AudioMixer RHZMOBZEYAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly AudioMixer OOWRSDYMEXZ;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly Dictionary<AudioMixerGroupType, string> DLRMIXKKWMJ;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public const string OSXUBPKYWIR = "Music";

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public const string ZTPWAMWCIZW = "Ambience";

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public const string HCQOMSGEDPK = "Sounds";

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private const string UKUQRHKLZJT = "Assets";

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private const string RYPLGZLGXTD = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private const string HPWZCFUOSIE = "Audio";

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly string ZGCZBNBTHSR;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly string AYTGKSKKSDI;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public AudioMixer NRJLOFJHJGS
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7714BA0", Offset = "0x77139A0", VA = "0x187714BA0")]
		public QASWGQDRYAL(RecRoomAudioMixerRegistryBase.MixerVersion a, AudioMixer b, AudioMixer c, AudioMixer d, AudioMixer e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8FA5CA0", Offset = "0x8FA4AA0", VA = "0x188FA5CA0")]
		public static string CFAFFOBNWVB(AudioMixerGroupType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8FA5E60", Offset = "0x8FA4C60", VA = "0x188FA5E60")]
		public AudioMixerGroup GPZOPBIZFFL(AudioMixerGroupType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8FA5DC0", Offset = "0x8FA4BC0", VA = "0x188FA5DC0")]
		private static AudioMixerGroup GMJRLETQZKO(AudioMixer a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class RecRoomAudioMixerRegistryAssetBase : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		[ReadOnlyField]
		private RecRoomAudioMixerRegistryBase.MixerVersion version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		[IntConditionallyVisibleField("version", 0, false)]
		private AudioMixer music;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		[IntConditionallyVisibleField("version", 0, false)]
		private AudioMixer ambience;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		[IntConditionallyVisibleField("version", 0, false)]
		private AudioMixer sounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		[IntConditionallyVisibleField("version", 1, false)]
		private AudioMixer studioMixer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private QASWGQDRYAL mixerData;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public QASWGQDRYAL DNONLWOONYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8FA66E0", Offset = "0x8FA54E0", VA = "0x188FA66E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RecRoomAudioMixerRegistryBase.MixerVersion SMFKXVOEEAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA9ED10", Offset = "0xA9DB10", VA = "0x180A9ED10")]
			get
			{
				return default(RecRoomAudioMixerRegistryBase.MixerVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public AudioMixer NRJLOFJHJGS
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAA0930", Offset = "0xA9F730", VA = "0x180AA0930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public AudioMixer MATAZZOTYKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public AudioMixer WCGIWRFDMVY
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public AudioMixer CBOMODXAIOD
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xDAF380", Offset = "0xDAE180", VA = "0x180DAF380")]
		public RecRoomAudioMixerRegistryAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class RecRoomAudioMixerRegistryBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[Obfuscation(Exclude = true, ApplyToMembers = true)]
		public enum MixerVersion
		{
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			SeparateMixers,
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			SingleMixer
		}

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static RecRoomAudioMixerRegistryBase YKIIEGGLVSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		[ReadOnlyField]
		private MixerVersion version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SerializeField]
		[IntConditionallyVisibleField("version", 0, false)]
		private AudioMixer music;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[SerializeField]
		[IntConditionallyVisibleField("version", 0, false)]
		private AudioMixer ambience;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		[IntConditionallyVisibleField("version", 0, false)]
		private AudioMixer sounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		[IntConditionallyVisibleField("version", 1, false)]
		private AudioMixer studioMixer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private QASWGQDRYAL UDXMVDLWMUE;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static RecRoomAudioMixerRegistryBase VDCQJFYBFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8FA69C0", Offset = "0x8FA57C0", VA = "0x188FA69C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public QASWGQDRYAL DNONLWOONYI
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8FA6B40", Offset = "0x8FA5940", VA = "0x188FA6B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public MixerVersion SMFKXVOEEAB
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAAF580", Offset = "0xAAE380", VA = "0x180AAF580")]
			get
			{
				return default(MixerVersion);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8FA6C10", Offset = "0x8FA5A10", VA = "0x188FA6C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool VYSVOJOJAYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8FA6A00", Offset = "0x8FA5800", VA = "0x188FA6A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8FA67B0", Offset = "0x8FA55B0", VA = "0x188FA67B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8FA68A0", Offset = "0x8FA56A0", VA = "0x188FA68A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		protected RecRoomAudioMixerRegistryBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class RecRoomBuiltInObjectBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		[HideInInspector]
		private SerializedGuid prefabId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		[HideInInspector]
		private byte[] spawnableTemplateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		[HideInInspector]
		private byte[] spawnableTemplateDataR2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		[HideInInspector]
		private Transform deformationTransform;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Guid IYONDJAAZTK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8FA7030", Offset = "0x8FA5E30", VA = "0x188FA7030")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8FA70A0", Offset = "0x8FA5EA0", VA = "0x188FA70A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool APVJVZRBFYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8FA6FE0", Offset = "0x8FA5DE0", VA = "0x188FA6FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Transform GHRYMYCKFSF
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAA0930", Offset = "0xA9F730", VA = "0x180AA0930")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BF0", Offset = "0xA9F9F0", VA = "0x180AA0BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8FA6E50", Offset = "0x8FA5C50", VA = "0x188FA6E50")]
		public bool HasSpawnableTemplateData(int ugcVersion)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8FA6DA0", Offset = "0x8FA5BA0", VA = "0x188FA6DA0")]
		public byte[] GetSpawnableTemplateData(int ugcVersion)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8FA6F20", Offset = "0x8FA5D20", VA = "0x188FA6F20")]
		public void SetSpawnableTemplateData(int ugcVersion, byte[] value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8FA6CD0", Offset = "0x8FA5AD0", VA = "0x188FA6CD0")]
		public void ClearSpawnableTemplateData(int ugcVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		protected RecRoomBuiltInObjectBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class RecRoomBuiltInObjectDataBase<TRecRoomBuiltInObject> : ScriptableObject where TRecRoomBuiltInObject : RecRoomBuiltInObjectBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private TRecRoomBuiltInObject[] builtInObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		private byte[] omPrefabData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private int omPrefabDataVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private string omTypeInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private Dictionary<Guid, TRecRoomBuiltInObject> lookup;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private Dictionary<Guid, TRecRoomBuiltInObject> YSZFMYJTTYV
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5F6A8A0", Offset = "0x5F696A0", VA = "0x185F6A8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public byte[] CGQUODCXZSB
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xAA0560", Offset = "0xA9F360", VA = "0x180AA0560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int XWKAIWZANUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xAA7120", Offset = "0xAA5F20", VA = "0x180AA7120")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xAA7140", Offset = "0xAA5F40", VA = "0x180AA7140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public string HSLVFZGLVLR
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAA58C0", Offset = "0xAA46C0", VA = "0x180AA58C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IReadOnlyDictionary<Guid, TRecRoomBuiltInObject> RQBYRMOBVYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5F6AB90", Offset = "0x5F69990", VA = "0x185F6AB90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5F6AAD0", Offset = "0x5F698D0", VA = "0x185F6AAD0")]
		public void SetBuiltInObjects(IEnumerable<TRecRoomBuiltInObject> builtInObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5F6AB20", Offset = "0x5F69920", VA = "0x185F6AB20")]
		public bool TryGetValue(Guid prefabId, [Out] TRecRoomBuiltInObject builtInObject)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xDAF380", Offset = "0xDAE180", VA = "0x180DAF380")]
		protected RecRoomBuiltInObjectDataBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class TWCNBAAHRNL
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private static readonly Dictionary<Guid, string> IEFTIKUZIWS;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public static IReadOnlyDictionary<Guid, string> SQSXDWRINRI
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8FADEB0", Offset = "0x8FACCB0", VA = "0x188FADEB0")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class IKLBFCRPSGB
	{
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private static readonly Dictionary<Guid, string> FAZCTCQNHPQ;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static IReadOnlyDictionary<Guid, string> WCWJDSSUZEO
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8FA3A20", Offset = "0x8FA2820", VA = "0x188FA3A20")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public abstract class RecRoomObjectBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class XYFZVVXMOLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public bool IEYQMEXZWTG;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public XYFZVVXMOLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8FAF7F0", Offset = "0x8FAE5F0", VA = "0x188FAF7F0")]
			internal bool USAKRULBBRD(NamedUnityEventBase a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class LACTLWAXKYN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public float IEYQMEXZWTG;

			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public LACTLWAXKYN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8FA3D00", Offset = "0x8FA2B00", VA = "0x188FA3D00")]
			internal bool USAKRULBBRD(NamedUnityEventBase a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class XURRCIAFBBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public int IEYQMEXZWTG;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public XURRCIAFBBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8FAF7C0", Offset = "0x8FAE5C0", VA = "0x188FAF7C0")]
			internal bool USAKRULBBRD(NamedUnityEventBase a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class CVBAJCCUCCD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public string IEYQMEXZWTG;

			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public CVBAJCCUCCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8F9EF80", Offset = "0x8F9DD80", VA = "0x188F9EF80")]
			internal bool USAKRULBBRD(NamedUnityEventBase a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class CVWKLCMSFJK : IEnumerable<NamedUnityEventBase>, IEnumerable, IEnumerator<NamedUnityEventBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private NamedUnityEventBase KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private int SNADUNBHBXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public RecRoomObjectBase SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private string BUXAGZQZAPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public string QPXNGQTEQVR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private NamedUnityEventBase[] RSQQLXOAUXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			private int RSVXJEHYEIO;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			private NamedUnityEventBase QYOCOEILZUL
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xB50450", Offset = "0xB4F250", VA = "0x180B50450")]
			[DebuggerHidden]
			public CVWKLCMSFJK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "7")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8F9F0B0", Offset = "0x8F9DEB0", VA = "0x188F9F0B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8F9F070", Offset = "0x8F9DE70", VA = "0x188F9F070", Slot = "10")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x8F9EFC0", Offset = "0x8F9DDC0", VA = "0x188F9EFC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NamedUnityEventBase> BRTWOGGFTUI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8F9EFC0", Offset = "0x8F9DDC0", VA = "0x188F9EFC0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WAAULASRGHE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private RecRoomObjectConfiguration defaultConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		[HideInInspector]
		internal RecRoomObjectProperty[] properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeReference]
		[HideInInspector]
		[Obfuscation(Exclude = true)]
		internal NamedUnityEventBase[] unityEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private Dictionary<string, RecRoomObjectProperty> OWZLGSAAMRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		[HideInInspector]
		private StudioFunctionList studioFunctions;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public RecRoomObjectProperty[] DZDMQGNNMJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public NamedUnityEventBase[] CWHLGGMVELP
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAA0930", Offset = "0xA9F730", VA = "0x180AA0930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public RecRoomObjectConfiguration FGUBXCSIXWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8FA7DB0", Offset = "0x8FA6BB0", VA = "0x188FA7DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public IReadOnlyList<StudioFunction> UFMLIRFGNKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC80", Offset = "0xA9DA80", VA = "0x180A9EC80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<RecRoomObjectBase, string> WQPMHBDTFSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8FA7D00", Offset = "0x8FA6B00", VA = "0x188FA7D00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8FA7E20", Offset = "0x8FA6C20", VA = "0x188FA7E20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8FA73C0", Offset = "0x8FA61C0", VA = "0x188FA73C0")]
		public bool TryGetProperty(string propertyName, [Out] RecRoomObjectProperty property)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8FA73A0", Offset = "0x8FA61A0", VA = "0x188FA73A0")]
		public void SendCircuitsEvent(string eventName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8FA7580", Offset = "0x8FA6380", VA = "0x188FA7580")]
		public bool TryRaiseUnityEvent(string eventName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7E80", Offset = "0x3CC6C80", VA = "0x183CC7E80")]
		private bool WGMAUBYMKPR<b, c, a>(string a, b b, c c) where a : UnityEvent<b, c>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8FA7B20", Offset = "0x8FA6920", VA = "0x188FA7B20")]
		public bool TryRaiseUnityEvent(string eventName, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8FA7A50", Offset = "0x8FA6850", VA = "0x188FA7A50")]
		public bool TryRaiseUnityEvent(string eventName, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA78A0", Offset = "0x8FA66A0", VA = "0x188FA78A0")]
		public bool TryRaiseUnityEvent(string eventName, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8FA7760", Offset = "0x8FA6560", VA = "0x188FA7760")]
		public bool TryRaiseUnityEvent(string eventName, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8FA7970", Offset = "0x8FA6770", VA = "0x188FA7970")]
		public bool TryRaiseUnityEvent(string eventName, string value0, bool value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8FA7BF0", Offset = "0x8FA69F0", VA = "0x188FA7BF0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, float value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8FA7830", Offset = "0x8FA6630", VA = "0x188FA7830")]
		public bool TryRaiseUnityEvent(string eventName, string value0, int value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8FA79E0", Offset = "0x8FA67E0", VA = "0x188FA79E0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, string value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8FA7110", Offset = "0x8FA5F10", VA = "0x188FA7110")]
		[IteratorStateMachine(typeof(CVWKLCMSFJK))]
		private IEnumerable<NamedUnityEventBase> ERDDDQXDHMP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8FA71A0", Offset = "0x8FA5FA0", VA = "0x188FA71A0")]
		private bool KQXITXBAIZS(string a, Func<NamedUnityEventBase, bool> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8FA7C60", Offset = "0x8FA6A60", VA = "0x188FA7C60")]
		protected RecRoomObjectBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEAD0", Offset = "0x8FAD8D0", VA = "0x188FAEAD0")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEB10", Offset = "0x8FAD910", VA = "0x188FAEB10")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEB50", Offset = "0x8FAD950", VA = "0x188FAEB50")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEC10", Offset = "0x8FADA10", VA = "0x188FAEC10")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEBD0", Offset = "0x8FAD9D0", VA = "0x188FAEBD0")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEC90", Offset = "0x8FADA90", VA = "0x188FAEC90")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEC50", Offset = "0x8FADA50", VA = "0x188FAEC50")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8FAECD0", Offset = "0x8FADAD0", VA = "0x188FAECD0")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public abstract class NamedUnityEventBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private string eventName;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void IWQIOLIFVGF();

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "5")]
		public virtual bool FDZWUVWSTDO(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "6")]
		public virtual bool FDZWUVWSTDO(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "7")]
		public virtual bool FDZWUVWSTDO(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "8")]
		public virtual bool FDZWUVWSTDO(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public abstract class NamedUnityEventBase<TUnityEvent> : NamedUnityEventBase where TUnityEvent : UnityEventBase, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private TUnityEvent unityEvent;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public TUnityEvent Event
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5A42FC0", Offset = "0x5A41DC0", VA = "0x185A42FC0")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityParameterlessEventBase : NamedUnityEventBase<UnityEvent>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			Hide
		}

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4B70", Offset = "0x8FA3970", VA = "0x188FA4B70", Slot = "4")]
		public override void IWQIOLIFVGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4C40", Offset = "0x8FA3A40", VA = "0x188FA4C40")]
		protected NamedUnityParameterlessEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class OneParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			HideParam
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0ED90", Offset = "0x5C0DB90", VA = "0x185C0ED90")]
		protected OneParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class TwoParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			HideParam1,
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			HideBothParams
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		protected string defaultValue1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0ED90", Offset = "0x5C0DB90", VA = "0x185C0ED90")]
		protected TwoParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityBooleanEventBase : OneParamNamedUnityEvent<UnityBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private bool defaultValue;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4520", Offset = "0x8FA3320", VA = "0x188FA4520", Slot = "4")]
		public override void IWQIOLIFVGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8FA44B0", Offset = "0x8FA32B0", VA = "0x188FA44B0", Slot = "5")]
		public override bool FDZWUVWSTDO(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8FA46B0", Offset = "0x8FA34B0", VA = "0x188FA46B0")]
		protected NamedUnityBooleanEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityFloatEventBase : OneParamNamedUnityEvent<UnityFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private float defaultValue;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4760", Offset = "0x8FA3560", VA = "0x188FA4760", Slot = "4")]
		public override void IWQIOLIFVGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8FA46F0", Offset = "0x8FA34F0", VA = "0x188FA46F0", Slot = "6")]
		public override bool FDZWUVWSTDO(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8FA48F0", Offset = "0x8FA36F0", VA = "0x188FA48F0")]
		protected NamedUnityFloatEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityIntEventBase : OneParamNamedUnityEvent<UnityIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private int defaultValue;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8FA49A0", Offset = "0x8FA37A0", VA = "0x188FA49A0", Slot = "4")]
		public override void IWQIOLIFVGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4930", Offset = "0x8FA3730", VA = "0x188FA4930", Slot = "7")]
		public override bool FDZWUVWSTDO(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4B30", Offset = "0x8FA3930", VA = "0x188FA4B30")]
		protected NamedUnityIntEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityStringEventBase : OneParamNamedUnityEvent<UnityStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private string defaultValue;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4FA0", Offset = "0x8FA3DA0", VA = "0x188FA4FA0", Slot = "4")]
		public override void IWQIOLIFVGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4F30", Offset = "0x8FA3D30", VA = "0x188FA4F30", Slot = "8")]
		public override bool FDZWUVWSTDO(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8FA5130", Offset = "0x8FA3F30", VA = "0x188FA5130")]
		protected NamedUnityStringEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityStringBooleanEventBase : TwoParamNamedUnityEvent<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private bool defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4CF0", Offset = "0x8FA3AF0", VA = "0x188FA4CF0", Slot = "4")]
		public override void IWQIOLIFVGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4C80", Offset = "0x8FA3A80", VA = "0x188FA4C80", Slot = "5")]
		public override bool FDZWUVWSTDO(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4EF0", Offset = "0x8FA3CF0", VA = "0x188FA4EF0")]
		protected NamedUnityStringBooleanEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityStringFloatEventBase : TwoParamNamedUnityEvent<UnityStringFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		private float defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8FA51E0", Offset = "0x8FA3FE0", VA = "0x188FA51E0", Slot = "4")]
		public override void IWQIOLIFVGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8FA5170", Offset = "0x8FA3F70", VA = "0x188FA5170", Slot = "6")]
		public override bool FDZWUVWSTDO(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8FA53E0", Offset = "0x8FA41E0", VA = "0x188FA53E0")]
		protected NamedUnityStringFloatEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityStringIntEventBase : TwoParamNamedUnityEvent<UnityStringIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private int defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8FA5490", Offset = "0x8FA4290", VA = "0x188FA5490", Slot = "4")]
		public override void IWQIOLIFVGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8FA5420", Offset = "0x8FA4220", VA = "0x188FA5420", Slot = "7")]
		public override bool FDZWUVWSTDO(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8FA5690", Offset = "0x8FA4490", VA = "0x188FA5690")]
		protected NamedUnityStringIntEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityStringStringEventBase : TwoParamNamedUnityEvent<UnityStringStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private string defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8FA5740", Offset = "0x8FA4540", VA = "0x188FA5740", Slot = "4")]
		public override void IWQIOLIFVGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8FA56D0", Offset = "0x8FA44D0", VA = "0x188FA56D0", Slot = "8")]
		public override bool FDZWUVWSTDO(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8FA5940", Offset = "0x8FA4740", VA = "0x188FA5940")]
		protected NamedUnityStringStringEventBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class RecRoomObjectPrefabRegistryAssetBase<TPrefabRegistryAsset, TPrefabEntry, TRecRoomObject> : RecRoomStudioAutoGeneratedAsset<TPrefabRegistryAsset> where TPrefabRegistryAsset : RecRoomObjectPrefabRegistryAssetBase<TPrefabRegistryAsset, TPrefabEntry, TRecRoomObject> where TPrefabEntry : RecRoomObjectPrefabEntryBase<TRecRoomObject> where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private TPrefabEntry[] prefabs;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public TPrefabEntry[] DSELJGUOJFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xDAF380", Offset = "0xDAE180", VA = "0x180DAF380")]
		public RecRoomObjectPrefabRegistryAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> : RecRoomUnitySceneSystemBase where TPrefabAsset : RecRoomObjectPrefabRegistryAssetBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> where TPrefabEntry : RecRoomObjectPrefabEntryBase<TRecRoomObject>, new() where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private static RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> YKIIEGGLVSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		[HideInInspector]
		private TPrefabEntry[] prefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		private TPrefabAsset prefabsAsset;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public static RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> VDCQJFYBFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x59FD6C0", Offset = "0x59FC4C0", VA = "0x1859FD6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public IReadOnlyList<TPrefabEntry> WQDHRSOBKJX
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x5F6B520", Offset = "0x5F6A320", VA = "0x185F6B520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5F6B270", Offset = "0x5F6A070", VA = "0x185F6B270")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5F6B3A0", Offset = "0x5F6A1A0", VA = "0x185F6B3A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xABA530", Offset = "0xAB9330", VA = "0x180ABA530")]
		protected RecRoomObjectPrefabRegistryBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public abstract class RecRoomObjectPrefabEntryBase<TRecRoomObject> : IStudioUnityAssetRegistrationEntry, IEquatable<RecRoomObjectPrefabEntryBase<TRecRoomObject>> where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[SerializeField]
		private TRecRoomObject Prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public SerializedGuid UnityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public SerializedGuid[] ReferencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[SerializeField]
		private GameObject prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[SerializeField]
		private RecRoomObjectPrefabObjectBoardTemplate objectBoardTemplate;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public Guid UnityAssetIdGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x5F6B030", Offset = "0x5F69E30", VA = "0x185F6B030")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public GameObject PrefabRoot
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x5F6B190", Offset = "0x5F69F90", VA = "0x185F6B190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x5F6B240", Offset = "0x5F6A040", VA = "0x185F6B240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public RecRoomObjectPrefabObjectBoardTemplate ObjectBoardTemplate
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAA0930", Offset = "0xA9F730", VA = "0x180AA0930")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BF0", Offset = "0xA9F9F0", VA = "0x180AA0BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool HasObjectBoardData
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x5F6B0B0", Offset = "0x5F69EB0", VA = "0x185F6B0B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x5F6B110", Offset = "0x5F69F10", VA = "0x185F6B110", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private Guid ASXZFJAMNSO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x5F6B000", Offset = "0x5F69E00", VA = "0x185F6B000", Slot = "5")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		private Guid PQVMQEAAVCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x5F6B030", Offset = "0x5F69E30", VA = "0x185F6B030", Slot = "6")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private IEnumerable<Guid> YXLEFJRNHRI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x5F6ABF0", Offset = "0x5F699F0", VA = "0x185F6ABF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5F6ABA0", Offset = "0x5F699A0", VA = "0x185F6ABA0")]
		public bool CDEYXXRSKTI(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5F6ADB0", Offset = "0x5F69BB0", VA = "0x185F6ADB0", Slot = "9")]
		public bool Equals(RecRoomObjectPrefabEntryBase<TRecRoomObject> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5F6AF30", Offset = "0x5F69D30", VA = "0x185F6AF30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5F6AFE0", Offset = "0x5F69DE0", VA = "0x185F6AFE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "10")]
		[Obfuscation(Exclude = true)]
		public abstract IStudioUnityAssetRegistrationEntry ToUnityAssetRegistrationEntry();

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		protected RecRoomObjectPrefabEntryBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class RecRoomObjectPrefabObjectBoardTemplate : IEquatable<RecRoomObjectPrefabObjectBoardTemplate>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[SerializeField]
		private string signature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[SerializeField]
		private byte[] objectBoard;

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string Signature
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public byte[] ObjectBoard
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x8FA8020", Offset = "0x8FA6E20", VA = "0x188FA8020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xAA5770", Offset = "0xAA4570", VA = "0x180AA5770")]
		public RecRoomObjectPrefabObjectBoardTemplate(string signature, byte[] objectBoard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8FA7EE0", Offset = "0x8FA6CE0", VA = "0x188FA7EE0", Slot = "4")]
		public bool Equals(RecRoomObjectPrefabObjectBoardTemplate other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA7FA0", Offset = "0x8FA6DA0", VA = "0x188FA7FA0")]
		private static bool IALJLKQVBUX(byte[] a, byte[] b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[RequireComponent(typeof(ParticleSystem))]
	public abstract class RecRoomParticleVfxBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[SerializeField]
		private float minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[SerializeField]
		private float maxScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[SerializeField]
		private float minSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[SerializeField]
		private float maxSpeed;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float YMXAZHAOQGR
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0xAF9180", Offset = "0xAF7F80", VA = "0x180AF9180")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float PQLLADKWUNV
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xAFFA60", Offset = "0xAFE860", VA = "0x180AFFA60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float JJLHDOXMNPK
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x1119700", Offset = "0x1118500", VA = "0x181119700")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float PLNMGAUWEVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xEDD920", Offset = "0xEDC720", VA = "0x180EDD920")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8FA83F0", Offset = "0x8FA71F0", VA = "0x188FA83F0")]
		protected RecRoomParticleVfxBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class RecRoomParticleVfxRegistryAssetBase<TParticleVfxRegistryAsset> : RecRoomStudioAutoCreatedAsset<TParticleVfxRegistryAsset> where TParticleVfxRegistryAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		internal RecRoomParticleVfxEntry[] particleEffects;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public IReadOnlyList<RecRoomParticleVfxEntry> YAWDCGJHDCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x5F6B5C0", Offset = "0x5F6A3C0", VA = "0x185F6B5C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xDAF380", Offset = "0xDAE180", VA = "0x180DAF380")]
		public RecRoomParticleVfxRegistryAssetBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class RecRoomParticleVfxEntry : IStudioUnityAssetRegistrationEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public GameObject ParticleVfxPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public SerializedGuid UnityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public SerializedGuid[] ReferencedUnityAssetIds;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Guid UnityAssetIdGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8FA8550", Offset = "0x8FA7350", VA = "0x188FA8550")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8FA8660", Offset = "0x8FA7460", VA = "0x188FA8660", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		private Guid ASXZFJAMNSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8FA6520", Offset = "0x8FA5320", VA = "0x188FA6520", Slot = "5")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		private Guid PQVMQEAAVCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8FA8550", Offset = "0x8FA7350", VA = "0x188FA8550", Slot = "6")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private IEnumerable<Guid> YXLEFJRNHRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x8FA8410", Offset = "0x8FA7210", VA = "0x188FA8410", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8FA85C0", Offset = "0x8FA73C0", VA = "0x188FA85C0", Slot = "8")]
		public IStudioUnityAssetRegistrationEntry ToUnityAssetRegistrationEntry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public RecRoomParticleVfxEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[AddComponentMenu(null)]
	public abstract class RecRoomParticleVfxRegistryBase<TParticleVfxRegistryAsset> : RecRoomUnitySceneSystemBase where TParticleVfxRegistryAsset : RecRoomParticleVfxRegistryAssetBase<TParticleVfxRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static RecRoomParticleVfxRegistryBase<TParticleVfxRegistryAsset> YKIIEGGLVSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		[ReadOnlyField]
		private TParticleVfxRegistryAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public static RecRoomParticleVfxRegistryBase<TParticleVfxRegistryAsset> VDCQJFYBFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x59FD6C0", Offset = "0x59FC4C0", VA = "0x1859FD6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public TParticleVfxRegistryAsset MVNMARVVPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public IReadOnlyList<RecRoomParticleVfxEntry> YAWDCGJHDCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5F6B8E0", Offset = "0x5F6A6E0", VA = "0x185F6B8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5F6B610", Offset = "0x5F6A410", VA = "0x185F6B610")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5F6B750", Offset = "0x5F6A550", VA = "0x185F6B750")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xABA530", Offset = "0xAB9330", VA = "0x180ABA530")]
		protected RecRoomParticleVfxRegistryBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public abstract class RecRoomProjectileBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		[Range(0.0001f, 1f)]
		private float colliderRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private Transform colliderTransform;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public float ZIEBWTVJRQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xAF9180", Offset = "0xAF7F80", VA = "0x180AF9180")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public Transform ZIVBRQPHMBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8FA8830", Offset = "0x8FA7630", VA = "0x188FA8830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8FA8820", Offset = "0x8FA7620", VA = "0x188FA8820")]
		protected RecRoomProjectileBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class RecRoomProjectileRegistryAssetBase<TProjectileRegistryAsset> : RecRoomStudioAutoCreatedAsset<TProjectileRegistryAsset> where TProjectileRegistryAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		internal RecRoomProjectileEntry[] projectiles;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public IReadOnlyList<RecRoomProjectileEntry> BIVFXNGBSNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x5F6B990", Offset = "0x5F6A790", VA = "0x185F6B990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xDAF380", Offset = "0xDAE180", VA = "0x180DAF380")]
		public RecRoomProjectileRegistryAssetBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class RecRoomProjectileEntry : IStudioUnityAssetRegistrationEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public GameObject ProjectilePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public SerializedGuid UnityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public SerializedGuid[] ReferencedUnityAssetIds;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public Guid UnityAssetIdGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x8FA89F0", Offset = "0x8FA77F0", VA = "0x188FA89F0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x8FA8B00", Offset = "0x8FA7900", VA = "0x188FA8B00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		private Guid ASXZFJAMNSO
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x8FA6520", Offset = "0x8FA5320", VA = "0x188FA6520", Slot = "5")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		private Guid PQVMQEAAVCC
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8FA89F0", Offset = "0x8FA77F0", VA = "0x188FA89F0", Slot = "6")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		private IEnumerable<Guid> YXLEFJRNHRI
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8FA88B0", Offset = "0x8FA76B0", VA = "0x188FA88B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8FA8A60", Offset = "0x8FA7860", VA = "0x188FA8A60", Slot = "8")]
		public IStudioUnityAssetRegistrationEntry ToUnityAssetRegistrationEntry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public RecRoomProjectileEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[AddComponentMenu(null)]
	public abstract class RecRoomProjectileRegistryBase<TProjectileRegistryAsset> : RecRoomUnitySceneSystemBase where TProjectileRegistryAsset : RecRoomProjectileRegistryAssetBase<TProjectileRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private static RecRoomProjectileRegistryBase<TProjectileRegistryAsset> YKIIEGGLVSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[SerializeField]
		[ReadOnlyField]
		private TProjectileRegistryAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public static RecRoomProjectileRegistryBase<TProjectileRegistryAsset> VDCQJFYBFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x59FD6C0", Offset = "0x59FC4C0", VA = "0x1859FD6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public TProjectileRegistryAsset MVNMARVVPMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public IReadOnlyList<RecRoomProjectileEntry> BIVFXNGBSNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x5F6BCB0", Offset = "0x5F6AAB0", VA = "0x185F6BCB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5F6B9E0", Offset = "0x5F6A7E0", VA = "0x185F6B9E0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5F6BB20", Offset = "0x5F6A920", VA = "0x185F6BB20")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xABA530", Offset = "0xAB9330", VA = "0x180ABA530")]
		protected RecRoomProjectileRegistryBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public abstract class RecRoomStudioAnimatorSynchronizerBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public interface DNEFBOERPEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void SetBoolParameterFromScript(string name, bool val);

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void SetIntegerParameterFromScript(string name, int val);

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void SetFloatParameterFromScript(string name, float val);

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void SetTriggerParameterFromScript(string name);
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public DNEFBOERPEF OCMYQWPCOIM
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xAA0560", Offset = "0xA9F360", VA = "0x180AA0560")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8FA8CC0", Offset = "0x8FA7AC0", VA = "0x188FA8CC0")]
		public Animator GetControlledAnimator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA8D00", Offset = "0x8FA7B00", VA = "0x188FA8D00")]
		public void SetBoolParameter(string name, bool val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8FA8E90", Offset = "0x8FA7C90", VA = "0x188FA8E90")]
		public void SetIntegerParameter(string name, int val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8FA8DC0", Offset = "0x8FA7BC0", VA = "0x188FA8DC0")]
		public void SetFloatParameter(string name, float val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8FA8F60", Offset = "0x8FA7D60", VA = "0x188FA8F60")]
		public void SetTriggerParameter(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		protected RecRoomStudioAnimatorSynchronizerBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public abstract class RecRoomStudioAudioSourceSynchronizerBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public interface ZTXDOTDVTEX
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void PlayFromScript(float time);

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void PauseFromScript();

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void UnPauseFromScript();

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void StopFromScript();

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void SetLoopFromScript(bool loop);

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void SetPitchFromScript(float pitch);
		}

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public const float MinPitch = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public const float MaxPitch = 10f;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public ZTXDOTDVTEX UPNINUZTVGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xAA0560", Offset = "0xA9F360", VA = "0x180AA0560")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8FA9020", Offset = "0x8FA7E20", VA = "0x188FA9020")]
		public AudioSource GetControlledAudioSource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8FA90B0", Offset = "0x8FA7EB0", VA = "0x188FA90B0")]
		public void Play(float playAtTimeSeconds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8FA9060", Offset = "0x8FA7E60", VA = "0x188FA9060")]
		public void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8FA9280", Offset = "0x8FA8080", VA = "0x188FA9280")]
		public void UnPause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8FA9230", Offset = "0x8FA8030", VA = "0x188FA9230")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA9110", Offset = "0x8FA7F10", VA = "0x188FA9110")]
		public void SetLoop(bool loop)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8FA91D0", Offset = "0x8FA7FD0", VA = "0x188FA91D0")]
		public void SetPitch(float pitch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		protected RecRoomStudioAudioSourceSynchronizerBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class RecRoomStudioBillboardBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[SerializeField]
		[Tooltip("If true, the object can turn left/right to face the player (y-axis rotation)")]
		private bool yawRotationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[SerializeField]
		[Tooltip("If true, the object can look up/down to face the player (x-axis rotation)")]
		private bool pitchRotationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[SerializeField]
		[Tooltip("If true, the object can rotate clockwise/counter-clockwise to match the players rotation (z-axis rotation)")]
		private bool rollRotationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[SerializeField]
		[Tooltip("If true, makes the player \"look through\" the object rather than \"look at\" the object to accomadate Unity UI expectations")]
		private bool faceAwayFromCamera;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public bool SYCHARNKNYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BB0", Offset = "0xA9F9B0", VA = "0x180AA0BB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0xAA0940", Offset = "0xA9F740", VA = "0x180AA0940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public bool QUNWTXYFRDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x163F330", Offset = "0x163E130", VA = "0x18163F330")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x163F160", Offset = "0x163DF60", VA = "0x18163F160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool QSWISFHGJNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x1BAE980", Offset = "0x1BAD780", VA = "0x181BAE980")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x1DF5AC0", Offset = "0x1DF48C0", VA = "0x181DF5AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool THKEONUCJNV
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x1BBFFB0", Offset = "0x1BBEDB0", VA = "0x181BBFFB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x50B1E70", Offset = "0x50B0C70", VA = "0x1850B1E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8FA92D0", Offset = "0x8FA80D0", VA = "0x188FA92D0")]
		protected RecRoomStudioBillboardBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class RecRoomStudioCanvasInteractionBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[Obfuscation(Exclude = true, ApplyToMembers = true)]
		public enum AttachmentMode
		{
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			[Tooltip("For screens and mobile players, moves the camera to frame the canvas.")]
			FrameScreensCanvas,
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			[Tooltip("For screens and mobile players, moves the canvas and anchors it onto the camera.")]
			AnchorCanvasAsMenu
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[Obfuscation(Exclude = true, ApplyToMembers = true)]
		public enum ControlPromptBehaviorType
		{
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			[Tooltip("Let Rec Room decide whether or not to show control prompts for this UI.")]
			Default,
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			[Tooltip("Ensure all platforms see control prompts when looking at this UI.")]
			ForceOnAllPlatforms,
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			[Tooltip("No platforms will ever see control prompts when looking at this UI")]
			ForceSuppressAllPlatforms
		}

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public bool isAnchored;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[SerializeField]
		[Tooltip("Allows the player to interact with elements on the canvas directly")]
		private bool isInteractable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		[Tooltip("Allows the canvas to be anchored and framed to the screen")]
		private bool canBeAnchored;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SerializeField]
		[ConditionallyVisibleField("canBeAnchored", true, false)]
		[Tooltip("The way in which the menu frames up on screen")]
		private AttachmentMode anchorAttachmentMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[SerializeField]
		[ConditionallyVisibleField("isInteractable", true, false)]
		[Tooltip("Optionally overwrite Rec Room's default behavior of when we show control hints while the cursor is over UI.")]
		private ControlPromptBehaviorType controlPromptBehaviorOverride;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool AKFBUNMNPEP
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BB0", Offset = "0xA9F9B0", VA = "0x180AA0BB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool BONWUTGBYFP
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x163F330", Offset = "0x163E130", VA = "0x18163F330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool GGKGWCEQLKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x1BAE980", Offset = "0x1BAD780", VA = "0x181BAE980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public AttachmentMode YHYHVVPVLKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xAC5E20", Offset = "0xAC4C20", VA = "0x180AC5E20")]
			get
			{
				return default(AttachmentMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public ControlPromptBehaviorType EUMGLSFFGKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xAA7120", Offset = "0xAA5F20", VA = "0x180AA7120")]
			get
			{
				return default(ControlPromptBehaviorType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<AttachmentMode> DIITXLHJEED
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x8FA9320", Offset = "0x8FA8120", VA = "0x188FA9320")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x8FA9470", Offset = "0x8FA8270", VA = "0x188FA9470")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action SJZRFRJDTGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x8FA93D0", Offset = "0x8FA81D0", VA = "0x188FA93D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x8FA9520", Offset = "0x8FA8320", VA = "0x188FA9520")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8FA92E0", Offset = "0x8FA80E0", VA = "0x188FA92E0")]
		public void AnchorCanvas()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8FA9300", Offset = "0x8FA8100", VA = "0x188FA9300")]
		public void DetachCanvas()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		protected RecRoomStudioCanvasInteractionBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public abstract class RecRoomStudioDisableRenderInShareCamPhotoBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[Obfuscation(Exclude = true, ApplyToMembers = true)]
		public enum DisableRenderOptions
		{
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			NeverRender,
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			OnlyDisableForJunior
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[SerializeField]
		private DisableRenderOptions renderOptions;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool AWGQILKBDBR
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x140A4C0", Offset = "0x14092C0", VA = "0x18140A4C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		protected RecRoomStudioDisableRenderInShareCamPhotoBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public abstract class RecRoomStudioHudCanvasBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		protected RecRoomStudioHudCanvasBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[Obfuscation(Exclude = true, ApplyToMembers = true)]
	public abstract class RecRoomStudioInstanceRecolorBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[SerializeField]
		[HideInInspector]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[SerializeField]
		private MeshRenderer[] renderers;

		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private static readonly int instanceColorID;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public IReadOnlyList<MeshRenderer> Renderers
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xF29BE0", Offset = "0xF289E0", VA = "0x180F29BE0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x8FA98E0", Offset = "0x8FA86E0", VA = "0x188FA98E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8FA95C0", Offset = "0x8FA83C0", VA = "0x188FA95C0")]
		private void ApplyColor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8FA9790", Offset = "0x8FA8590", VA = "0x188FA9790")]
		private void ClearColor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8FA9730", Offset = "0x8FA8530", VA = "0x188FA9730")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		protected RecRoomStudioInstanceRecolorBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[Obfuscation(Exclude = true, ApplyToMembers = true)]
	public abstract class RecRoomStudioPlatformTextFilterBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[SerializeField]
		private TMP_Text textMeshPro;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private string lastText;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public TMP_Text TextMeshPro
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Action<string> SanitizeAndSetTextAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xAA0570", Offset = "0xA9F370", VA = "0x180AA0570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8FAA150", Offset = "0x8FA8F50", VA = "0x188FAA150")]
		public void SetText(string text)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		protected RecRoomStudioPlatformTextFilterBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public abstract class RecRoomStudioRecNetImageBase : RawImage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[SerializeField]
		[Tooltip("If true, the image will be automatically cropped into a square.")]
		private bool cropSquare;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private RNKMHAUVSEM DWCDRDQAFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private IIIGUMXALWM WAWMOOHJLRK;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public IIIGUMXALWM UODYJOGPAPT
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xB078F0", Offset = "0xB066F0", VA = "0x180B078F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xB07950", Offset = "0xB06750", VA = "0x180B07950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public RNKMHAUVSEM GDHSASIRFKU
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xB0C120", Offset = "0xB0AF20", VA = "0x180B0C120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8FAA260", Offset = "0x8FA9060", VA = "0x188FAA260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool CXPWNDHDKIG
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xC9CFF0", Offset = "0xC9BDF0", VA = "0x180C9CFF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8FAA1F0", Offset = "0x8FA8FF0", VA = "0x188FAA1F0", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8FAA250", Offset = "0x8FA9050", VA = "0x188FAA250")]
		protected RecRoomStudioRecNetImageBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public abstract class RecRoomUnitySceneSystemBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		protected RecRoomUnitySceneSystemBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public abstract class RecRoomVisualPostProcessingBase : RecRoomUnitySceneSystemBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[SerializeField]
		[ReadOnlyField]
		public VolumeProfile PostProcessingProfile;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static RecRoomVisualPostProcessingBase YKIIEGGLVSM;

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public static RecRoomVisualPostProcessingBase VDCQJFYBFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x8FAA570", Offset = "0x8FA9370", VA = "0x188FAA570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8FAA340", Offset = "0x8FA9140", VA = "0x188FAA340")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8FAA430", Offset = "0x8FA9230", VA = "0x188FAA430")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		protected RecRoomVisualPostProcessingBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	[Obfuscation(Exclude = true)]
	public class ConditionallyEnabledFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2C80", Offset = "0x8FA1A80", VA = "0x188FA2C80")]
		public ConditionallyEnabledFieldAttribute(string propertyName, bool propertyValue, string disabledTooltip)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public abstract class ConditionallyVisibleFieldAttributeBase : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2CE0", Offset = "0x8FA1AE0", VA = "0x188FA2CE0")]
		protected ConditionallyVisibleFieldAttributeBase(string propertyName, bool isReadOnly)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	[Obfuscation(Exclude = true)]
	public class ConditionallyVisibleFieldAttribute : ConditionallyVisibleFieldAttributeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2D30", Offset = "0x8FA1B30", VA = "0x188FA2D30")]
		public ConditionallyVisibleFieldAttribute(string propertyName, bool propertyValue, bool isReadOnly = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	[Obfuscation(Exclude = true)]
	public class IntConditionallyVisibleFieldAttribute : ConditionallyVisibleFieldAttributeBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8FA3C60", Offset = "0x8FA2A60", VA = "0x188FA3C60")]
		public IntConditionallyVisibleFieldAttribute(string propertyName, int propertyValue, bool isReadOnly = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class YZCZKEHGWKG
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		private interface WOEQMCZBBYW
		{
			[Cpp2IlInjected.Token(Token = "0x1700007A")]
			string GIGZRKSKPQZ
			{
				[Cpp2IlInjected.Token(Token = "0x600018B")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700007B")]
			string EAPQJRDFXSQ
			{
				[Cpp2IlInjected.Token(Token = "0x600018C")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700007C")]
			bool TWDQGRZEGWP
			{
				[Cpp2IlInjected.Token(Token = "0x600018D")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700007D")]
			string? ZJEBEMEWANB
			{
				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(Slot = "3")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public sealed class BRBQHXIDDZB : WOEQMCZBBYW
		{
			[Cpp2IlInjected.Token(Token = "0x1700007E")]
			public static string GIGZRKSKPQZ
			{
				[Cpp2IlInjected.Token(Token = "0x600018F")]
				[Cpp2IlInjected.Address(RVA = "0x8F9EB10", Offset = "0x8F9D910", VA = "0x188F9EB10")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			private string HMVPYEEUTUH
			{
				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x8F9EB10", Offset = "0x8F9D910", VA = "0x188F9EB10", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			private string UDCBFJIHEQK
			{
				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0x8F9EB40", Offset = "0x8F9D940", VA = "0x188F9EB40", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			private bool RUYPFYXCAFD
			{
				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			private string? PRPWHAIKQVX
			{
				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public BRBQHXIDDZB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public sealed class MKRWTFDSSDP : WOEQMCZBBYW
		{
			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public static string GIGZRKSKPQZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0x8FA3DB0", Offset = "0x8FA2BB0", VA = "0x188FA3DB0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			private string HMVPYEEUTUH
			{
				[Cpp2IlInjected.Token(Token = "0x6000196")]
				[Cpp2IlInjected.Address(RVA = "0x8FA3DB0", Offset = "0x8FA2BB0", VA = "0x188FA3DB0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			private string UDCBFJIHEQK
			{
				[Cpp2IlInjected.Token(Token = "0x6000197")]
				[Cpp2IlInjected.Address(RVA = "0x8FA3DE0", Offset = "0x8FA2BE0", VA = "0x188FA3DE0", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			private bool RUYPFYXCAFD
			{
				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			private string? PRPWHAIKQVX
			{
				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public MKRWTFDSSDP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public sealed class WJRFDWTUZIV : WOEQMCZBBYW
		{
			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public static string GIGZRKSKPQZ
			{
				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x8FAF730", Offset = "0x8FAE530", VA = "0x188FAF730")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			private string HMVPYEEUTUH
			{
				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x8FAF730", Offset = "0x8FAE530", VA = "0x188FAF730", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			private string UDCBFJIHEQK
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x8FAF760", Offset = "0x8FAE560", VA = "0x188FAF760", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			private bool RUYPFYXCAFD
			{
				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			private string? PRPWHAIKQVX
			{
				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x8FAF790", Offset = "0x8FAE590", VA = "0x188FAF790", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public WJRFDWTUZIV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly IReadOnlyList<string> QHRGVMYZSDE;

		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly IReadOnlyList<string> RALBTWNTKYR;

		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public static readonly IReadOnlyList<bool> BQFGPJANMKP;

		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public static readonly IReadOnlyList<string?> LFLBAMARLUU;

		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private static readonly IReadOnlyList<WOEQMCZBBYW> VCZVVXYRPQJ;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF830", Offset = "0x8FAE630", VA = "0x188FAF830")]
		static YZCZKEHGWKG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public interface IIIGUMXALWM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OZUVFPKRKXL();

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void YHEXIZYAVBN(RNKMHAUVSEM a);
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public interface NUZMQFKAXRM<a>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AttachMarkupComponent(a markupComponent, int componentIndex, bool isObjectReset);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class RecRoomObjectConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[SerializeField]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[SerializeField]
		[ConditionallyEnabledField("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[SerializeField]
		[ConditionallyEnabledField("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
		private bool isClimbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[SerializeField]
		private bool supportsWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[SerializeField]
		private bool supportsClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[SerializeField]
		private RecRoomObjectPhysicsMode physicsMode;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8FA7ED0", Offset = "0x8FA6CD0", VA = "0x188FA7ED0")]
		public RecRoomObjectConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[Obfuscation(Exclude = true, ApplyToMembers = true)]
	public enum RecRoomObjectPhysicsMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		Physical = 4
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class RecRoomObjectProperty
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			Hide
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		private string propertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[SerializeField]
		private RecRoomObjectPropertyAccessor propertyAccessor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		private BoardConfig boardConfig;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3CC88C0", Offset = "0x3CC76C0", VA = "0x183CC88C0")]
		public bool HHYTRHIEAWJ<a>([Out] a a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8FA8240", Offset = "0x8FA7040", VA = "0x188FA8240")]
		public static string JBBHPMQQXBE(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public RecRoomObjectProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class RecRoomObjectPropertyAccessor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public string targetAssemblyTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public string propertyMethodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private MethodInfo GWKLLSSKKTT;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		private string YAIYJHWZWFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8FA80E0", Offset = "0x8FA6EE0", VA = "0x188FA80E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8FA8070", Offset = "0x8FA6E70", VA = "0x188FA8070")]
		public MethodInfo IPOHFGKFDZM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8FA8150", Offset = "0x8FA6F50", VA = "0x188FA8150")]
		public string QWZSRQKABWZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public RecRoomObjectPropertyAccessor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public abstract class RecRoomStudioAutoCreatedAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xDAF380", Offset = "0xDAE180", VA = "0x180DAF380")]
		protected RecRoomStudioAutoCreatedAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class RecRoomStudioAutoGeneratedAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xDAF380", Offset = "0xDAE180", VA = "0x180DAF380")]
		public RecRoomStudioAutoGeneratedAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[Obfuscation(Exclude = true, ApplyToMembers = true)]
	public abstract class RecRoomStudioNavMeshCutBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public const float MINIMUM_WIDTH = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		[HideInInspector]
		[Obsolete]
		private float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		[HideInInspector]
		[Obsolete]
		private float height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[Comment("When using a Nav Mesh Cut, you may also want to set NavMesh Generation Mode to Ignore in the configure menu so the associated Rec Room Object won't bake into the navmesh on its own.")]
		[SerializeField]
		private Vector3 size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private Vector3 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[Header("Optimization")]
		[SerializeField]
		[Comment("Ignoring rotation leads to better performance, but ignoring rotation also means that the box must be aligned with the X, Y, and Z axes.")]
		private bool ignoreRotationAndScale;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		[Obsolete]
		public float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8FA9CB0", Offset = "0x8FA8AB0", VA = "0x188FA9CB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x8FA9FD0", Offset = "0x8FA8DD0", VA = "0x188FA9FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[Obsolete]
		public float Height
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0xEDD920", Offset = "0xEDC720", VA = "0x180EDD920")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x8FA9F30", Offset = "0x8FA8D30", VA = "0x188FA9F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public bool IgnoreRotationAndScale
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xFCD270", Offset = "0xFCC070", VA = "0x180FCD270")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8FA9FB0", Offset = "0x8FA8DB0", VA = "0x188FA9FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public Vector3 Size
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xF25070", Offset = "0xF23E70", VA = "0x180F25070")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x8FAA050", Offset = "0x8FA8E50", VA = "0x188FAA050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public float HeightSizeY
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0xEDD920", Offset = "0xEDC720", VA = "0x180EDD920")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x8FA9F30", Offset = "0x8FA8D30", VA = "0x188FA9F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public float XZUniformSquareSize
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x8FAA0D0", Offset = "0x8FA8ED0", VA = "0x188FAA0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public Vector3 Center
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xF25090", Offset = "0xF23E90", VA = "0x180F25090")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x8FA9EB0", Offset = "0x8FA8CB0", VA = "0x188FA9EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action OnSettingsChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x8FA9C10", Offset = "0x8FA8A10", VA = "0x188FA9C10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x8FA9E10", Offset = "0x8FA8C10", VA = "0x188FA9E10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action OnForceUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x8FA9B70", Offset = "0x8FA8970", VA = "0x188FA9B70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x8FA9D70", Offset = "0x8FA8B70", VA = "0x188FA9D70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<bool> OnEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x8FA9AC0", Offset = "0x8FA88C0", VA = "0x188FA9AC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x8FA9CC0", Offset = "0x8FA8AC0", VA = "0x188FA9CC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8FA9960", Offset = "0x8FA8760", VA = "0x188FA9960")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x10F2A70", Offset = "0x10F1870", VA = "0x1810F2A70")]
		[Obsolete]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x10F2A70", Offset = "0x10F1870", VA = "0x1810F2A70")]
		public void ForceQueueUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8FA9A50", Offset = "0x8FA8850", VA = "0x188FA9A50")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8FA9A50", Offset = "0x8FA8850", VA = "0x188FA9A50")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8FA9A90", Offset = "0x8FA8890", VA = "0x188FA9A90")]
		protected RecRoomStudioNavMeshCutBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public struct RoomData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public byte[] Payload;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xF3B1C0", Offset = "0xF39FC0", VA = "0x180F3B1C0")]
		public RoomData(byte[] payload)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public struct SubRoomData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public byte[] Payload;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xF3B1C0", Offset = "0xF39FC0", VA = "0x180F3B1C0")]
		public SubRoomData(byte[] payload)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public static class FHDIRAKZSAS
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2D90", Offset = "0x8FA1B90", VA = "0x188FA2D90")]
		public static (RoomData, SubRoomData, IReadOnlyCollection<Guid>) TZDDWKUNLKC(Stream a)
		{
			return default((RoomData, SubRoomData, IReadOnlyCollection<Guid>));
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8FA31C0", Offset = "0x8FA1FC0", VA = "0x188FA31C0")]
		public static void ZWNBQDSDCQT(Stream a, RoomData b, SubRoomData c, IReadOnlyCollection<Guid> d)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private Guid KPJUPYHRTCJ;

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x2DA4D80", Offset = "0x2DA3B80", VA = "0x182DA4D80")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8443D60", Offset = "0x8442B60", VA = "0x188443D60")]
		public SerializedGuid([In] Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8443D30", Offset = "0x8442B30", VA = "0x188443D30", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD300", Offset = "0x8FAC100", VA = "0x188FAD300", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8443A90", Offset = "0x8442890", VA = "0x188443A90", Slot = "7")]
		public bool Equals(SerializedGuid other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD270", Offset = "0x8FAC070", VA = "0x188FAD270", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8443B60", Offset = "0x8442960", VA = "0x188443B60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8443A60", Offset = "0x8442860", VA = "0x188443A60", Slot = "6")]
		public int CompareTo(SerializedGuid other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD380", Offset = "0x8FAC180", VA = "0x188FAD380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[AttributeUsage(AttributeTargets.Class)]
	[Obfuscation(Exclude = true)]
	public class SerializedTypeNameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
		public SerializedTypeNameAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public static class OMOOTYHAIIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly Log KXFATLZJKYV;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly Log MPPEZYITRVJ;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly Log BTOJNDYMQCR;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly Log CZHLQKSGJNM;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly Log VSEBRCUQBLD;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly Log UOZYIEVGCHS;
	}
}
namespace RecRoom.Core.Studio.StudioFunctions
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Argument
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly Argument Void;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeReference]
		private Parameter binding;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public Parameter Binding
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public abstract Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public abstract object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public Argument()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		public Argument(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8F9EA40", Offset = "0x8F9D840", VA = "0x188F9EA40")]
		public object XXXGISASWOM(object[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8F9E9D0", Offset = "0x8F9D7D0", VA = "0x188F9E9D0")]
		internal void TIONUOCBHSL(IReadOnlyList<Parameter> a)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Argument<T> : Argument
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		protected T defaultValue;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x58D5780", Offset = "0x58D4580", VA = "0x1858D5780", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x58D52B0", Offset = "0x58D40B0", VA = "0x1858D52B0")]
		protected Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[UnityEngine.Scripting.Preserve]
	public sealed class VoidArgument : Argument
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly VoidArgument Instance;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x8FA5C60", Offset = "0x8FA4A60", VA = "0x188FA5C60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF6B0", Offset = "0x8FAE4B0", VA = "0x188FAF6B0")]
		private VoidArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ValueArgument<T> : Argument<T>
	{
		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x433FA40", Offset = "0x433E840", VA = "0x18433FA40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6422F70", Offset = "0x6421D70", VA = "0x186422F70")]
		protected ValueArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ClassArgument<T> : Argument<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		protected string valueTypeAssemblyQualifiedName;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Type BSDCMPXOVNG;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x407BE10", Offset = "0x407AC10", VA = "0x18407BE10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x407B7B0", Offset = "0x407A5B0", VA = "0x18407B7B0")]
		private Type EOMKXKTZREB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x407BD50", Offset = "0x407AB50", VA = "0x18407BD50")]
		protected ClassArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[UnityEngine.Scripting.Preserve]
	public sealed class BoolArgument : ValueArgument<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8F9EB70", Offset = "0x8F9D970", VA = "0x188F9EB70")]
		public BoolArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ColorArgument : ValueArgument<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1EB0", Offset = "0x8FA0CB0", VA = "0x188FA1EB0")]
		public ColorArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Color32Argument : ValueArgument<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1E30", Offset = "0x8FA0C30", VA = "0x188FA1E30")]
		public Color32Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[UnityEngine.Scripting.Preserve]
	public sealed class GuidArgument : ValueArgument<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8FA39E0", Offset = "0x8FA27E0", VA = "0x188FA39E0")]
		public GuidArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[UnityEngine.Scripting.Preserve]
	public sealed class FloatArgument : ValueArgument<float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8FA37E0", Offset = "0x8FA25E0", VA = "0x188FA37E0")]
		public FloatArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[UnityEngine.Scripting.Preserve]
	public sealed class IntArgument : ValueArgument<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8FA3C20", Offset = "0x8FA2A20", VA = "0x188FA3C20")]
		public IntArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ShortArgument : ValueArgument<short>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD390", Offset = "0x8FAC190", VA = "0x188FAD390")]
		public ShortArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StringArgument : ValueArgument<string>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD3D0", Offset = "0x8FAC1D0", VA = "0x188FAD3D0")]
		public StringArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UIntArgument : ValueArgument<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE910", Offset = "0x8FAD710", VA = "0x188FAE910")]
		public UIntArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UShortArgument : ValueArgument<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE950", Offset = "0x8FAD750", VA = "0x188FAE950")]
		public UShortArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector2Argument : ValueArgument<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF450", Offset = "0x8FAE250", VA = "0x188FAF450")]
		public Vector2Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector3Argument : ValueArgument<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF4D0", Offset = "0x8FAE2D0", VA = "0x188FAF4D0")]
		public Vector3Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[UnityEngine.Scripting.Preserve]
	public sealed class QuaternionArgument : ValueArgument<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8FA62E0", Offset = "0x8FA50E0", VA = "0x188FA62E0")]
		public QuaternionArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UnityObjectArgument : ClassArgument<UnityEngine.Object>
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8FAEB90", Offset = "0x8FAD990", VA = "0x188FAEB90")]
		public UnityObjectArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[UnityEngine.Scripting.Preserve]
	public sealed class RecNetImageArgument : ValueArgument<RNKMHAUVSEM>
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x8FA6360", Offset = "0x8FA5160", VA = "0x188FA6360")]
		public RecNetImageArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void Invoke(string functionName, object[] parameterValues, object[] resultValues);

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected internal abstract void LDFACOZCMDS(IReadOnlyList<Parameter> a, IReadOnlyList<Parameter> b);

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		protected Instruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[UnityEngine.Scripting.Preserve]
	public sealed class PlaceholderInstruction : Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "4")]
		public override void Invoke(string functionName, object[] parameterValues, object[] resultValues)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
		protected internal override void LDFACOZCMDS(IReadOnlyList<Parameter> a, IReadOnlyList<Parameter> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public PlaceholderInstruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[UnityEngine.Scripting.Preserve]
	public sealed class CallInstruction : Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		private delegate void Optimization(UnityEngine.Object target, MethodInfo methodInfo, object[] argumentValues);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[SerializeReference]
		private Argument[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[SerializeReference]
		private Argument result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private MethodInfo TZHWGAECUTG;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly MethodInfo InvalidMethodInfo;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private static object[][] ZQUPZCWIWDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private Optimization ISEPPVUYICK;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static readonly MethodInfo RFBLEIGIUVV;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private static readonly MethodInfo BNELOKOIXPL;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private static readonly MethodInfo RMNEZYNBCOD;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private static readonly MethodInfo OACOYMHTVRP;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly MethodInfo XLGUWLDFZQP;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private static readonly MethodInfo DNOQMSZHGSB;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly MethodInfo NOYIXUFHVNB;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly MethodInfo YMIYEMXUPON;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private static readonly Dictionary<MethodInfo, Optimization> EIMYKJUFKMP;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private static readonly Dictionary<string, int> ISGOFDHTHYG;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1DC0", Offset = "0x8FA0BC0", VA = "0x188FA1DC0")]
		public CallInstruction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8F9F9E0", Offset = "0x8F9E7E0", VA = "0x188F9F9E0", Slot = "4")]
		public override void Invoke(string functionName, object[] parameterValues, object[] resultValues)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0630", Offset = "0x8F9F430", VA = "0x188FA0630")]
		private void QBTVOLGDJLR(object[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0410", Offset = "0x8F9F210", VA = "0x188FA0410")]
		private void OPRZMAPQKFK(object[] a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8FA01C0", Offset = "0x8F9EFC0", VA = "0x188FA01C0", Slot = "5")]
		protected internal override void LDFACOZCMDS(IReadOnlyList<Parameter> a, IReadOnlyList<Parameter> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0B50", Offset = "0x8F9F950", VA = "0x188FA0B50")]
		[UnityEngine.Scripting.Preserve]
		private static void UEQYMZZKFSD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0080", Offset = "0x8F9EE80", VA = "0x188FA0080")]
		private MethodInfo KVNBLKHKKAQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x8F9FFF0", Offset = "0x8F9EDF0", VA = "0x188F9FFF0")]
		internal MethodInfo KNWLTIDZIYF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8FA06E0", Offset = "0x8F9F4E0", VA = "0x188FA06E0")]
		internal static bool TGRXTUDKRBU(UnityEngine.Object a, string b, Argument[] c, [Out] MethodInfo d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0D10", Offset = "0x8F9FB10", VA = "0x188FA0D10")]
		private static bool XQHXQGDOZVE(MethodInfo a, Type[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8F9F1A0", Offset = "0x8F9DFA0", VA = "0x188F9F1A0")]
		private static object[] APRINKWAPZK(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0BA0", Offset = "0x8F9F9A0", VA = "0x188FA0BA0")]
		private object[] WDXHVPKRTOY(object[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8FA05D0", Offset = "0x8F9F3D0", VA = "0x188FA05D0")]
		private void PCMRDZDHHGJ(object[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x8FA04B0", Offset = "0x8F9F2B0", VA = "0x188FA04B0")]
		private static void OULEUCQICXH(UnityEngine.Object a, MethodInfo b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x8F9F3F0", Offset = "0x8F9E1F0", VA = "0x188F9F3F0")]
		private static void CSHNDOCMLHL(UnityEngine.Object a, MethodInfo b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x8F9F8C0", Offset = "0x8F9E6C0", VA = "0x188F9F8C0")]
		private static void FYLDKCNMBQF(UnityEngine.Object a, MethodInfo b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8FA02F0", Offset = "0x8F9F0F0", VA = "0x188FA02F0")]
		private static void LWLIYJQAEUV(UnityEngine.Object a, MethodInfo b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8F9F600", Offset = "0x8F9E400", VA = "0x188F9F600")]
		private static MethodInfo FTOLLLUSMLF(Type a, string b, params Type[] parameterTypes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8F9F510", Offset = "0x8F9E310", VA = "0x188F9F510")]
		private static int DFVVNPFEVQQ(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8F9F370", Offset = "0x8F9E170", VA = "0x188F9F370")]
		public static void BEANDEZXTVV()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ConditionalInstruction : Instruction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeReference]
		private Parameter binding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		private Condition[] conditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[SerializeReference]
		private Instruction[] @default;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2C00", Offset = "0x8FA1A00", VA = "0x188FA2C00")]
		public ConditionalInstruction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x8FA24E0", Offset = "0x8FA12E0", VA = "0x188FA24E0", Slot = "4")]
		public override void Invoke(string functionName, object[] parameterValues, object[] resultValues)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2900", Offset = "0x8FA1700", VA = "0x188FA2900", Slot = "5")]
		protected internal override void LDFACOZCMDS(IReadOnlyList<Parameter> a, IReadOnlyList<Parameter> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2B90", Offset = "0x8FA1990", VA = "0x188FA2B90")]
		private void TIONUOCBHSL(IReadOnlyList<Parameter> a)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Condition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeReference]
		private Instruction[] instructions;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public IReadOnlyList<Instruction> Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x8FA2490", Offset = "0x8FA1290", VA = "0x188FA2490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2420", Offset = "0x8FA1220", VA = "0x188FA2420")]
		public Condition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2320", Offset = "0x8FA1120", VA = "0x188FA2320")]
		public static bool QYGWLGATXHR(string a, [Out] bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2130", Offset = "0x8FA0F30", VA = "0x188FA2130")]
		public static bool JXHFBPDZMQI(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2210", Offset = "0x8FA1010", VA = "0x188FA2210")]
		public bool KQHTGRINBHC(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1FC0", Offset = "0x8FA0DC0", VA = "0x188FA1FC0")]
		public bool AFSBHSDSTER(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2400", Offset = "0x8FA1200", VA = "0x188FA2400")]
		public bool VRTTAVNCSSB(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA20A0", Offset = "0x8FA0EA0", VA = "0x188FA20A0")]
		public void Invoke(string functionName, object[] parameterValues, object[] resultValues)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Parameter
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private int VEJGVBBERIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		protected string name;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xA9D110", Offset = "0xA9BF10", VA = "0x180A9D110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public abstract Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x16B2390", Offset = "0x16B1190", VA = "0x1816B2390")]
		public Parameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8FA5B90", Offset = "0x8FA4990", VA = "0x188FA5B90")]
		internal void CPEOVIWLUWG(int a)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[UnityEngine.Scripting.Preserve]
	public sealed class PlaceholderParameter : Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x8FA5C60", Offset = "0x8FA4A60", VA = "0x188FA5C60", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Parameter<T> : Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x5CB2F60", Offset = "0x5CB1D60", VA = "0x185CB2F60")]
		protected Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ValueParameter<T> : Parameter<T>
	{
		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x433FA40", Offset = "0x433E840", VA = "0x18433FA40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x64A4310", Offset = "0x64A3110", VA = "0x1864A4310")]
		protected ValueParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ClassParameter<T> : Parameter<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		private string valueTypeFullName;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private Type BSDCMPXOVNG;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x407BF20", Offset = "0x407AD20", VA = "0x18407BF20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x407BE60", Offset = "0x407AC60", VA = "0x18407BE60")]
		private Type EOMKXKTZREB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x407BF00", Offset = "0x407AD00", VA = "0x18407BF00")]
		protected ClassParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[UnityEngine.Scripting.Preserve]
	public sealed class BoolParameter : ValueParameter<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x8F9EBB0", Offset = "0x8F9D9B0", VA = "0x188F9EBB0")]
		public BoolParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ColorParameter : ValueParameter<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1EF0", Offset = "0x8FA0CF0", VA = "0x188FA1EF0")]
		public ColorParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Color32Parameter : ValueParameter<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1E70", Offset = "0x8FA0C70", VA = "0x188FA1E70")]
		public Color32Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[UnityEngine.Scripting.Preserve]
	public sealed class FloatParameter : ValueParameter<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA3820", Offset = "0x8FA2620", VA = "0x188FA3820")]
		public FloatParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[UnityEngine.Scripting.Preserve]
	public sealed class IntParameter : ValueParameter<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8FA3CC0", Offset = "0x8FA2AC0", VA = "0x188FA3CC0")]
		public IntParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StringParameter : ValueParameter<string>
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD410", Offset = "0x8FAC210", VA = "0x188FAD410")]
		public StringParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector2Parameter : ValueParameter<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF490", Offset = "0x8FAE290", VA = "0x188FAF490")]
		public Vector2Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector3Parameter : ValueParameter<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF510", Offset = "0x8FAE310", VA = "0x188FAF510")]
		public Vector3Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[UnityEngine.Scripting.Preserve]
	public sealed class QuaternionParameter : ValueParameter<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8FA6320", Offset = "0x8FA5120", VA = "0x188FA6320")]
		public QuaternionParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[UnityEngine.Scripting.Preserve]
	public sealed class RecNetImageParameter : ValueParameter<RNKMHAUVSEM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8FA63A0", Offset = "0x8FA51A0", VA = "0x188FA63A0")]
		public RecNetImageParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StudioFunction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeReference]
		private Parameter[] parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeReference]
		private Parameter[] results;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeReference]
		private Instruction[] instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private bool NPBEBHTTLSL;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8FADDF0", Offset = "0x8FACBF0", VA = "0x188FADDF0")]
		public StudioFunction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD750", Offset = "0x8FAC550", VA = "0x188FAD750")]
		public void Invoke(object[] parameterValues, object[] resultValues)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD9B0", Offset = "0x8FAC7B0", VA = "0x188FAD9B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8FADCB0", Offset = "0x8FACAB0", VA = "0x188FADCB0")]
		private void ZNOMVAWCAEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD940", Offset = "0x8FAC740", VA = "0x188FAD940")]
		private void LDFACOZCMDS()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[UnityEngine.Scripting.Preserve]
	public class StudioFunctionList : IReadOnlyList<StudioFunction>, IEnumerable<StudioFunction>, IEnumerable, IReadOnlyCollection<StudioFunction>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		[HideInInspector]
		private StudioFunction[] array;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		private IReadOnlyList<StudioFunction> EVHHTKGISOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x8FAD4D0", Offset = "0x8FAC2D0", VA = "0x188FAD4D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x8FAD5F0", Offset = "0x8FAC3F0", VA = "0x188FAD5F0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public StudioFunction this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x8FAD670", Offset = "0x8FAC470", VA = "0x188FAD670", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD450", Offset = "0x8FAC250", VA = "0x188FAD450", Slot = "6")]
		public IEnumerator<StudioFunction> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD520", Offset = "0x8FAC320", VA = "0x188FAD520", Slot = "7")]
		private IEnumerator WAAULASRGHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD5A0", Offset = "0x8FAC3A0", VA = "0x188FAD5A0")]
		public StudioFunctionList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public static class CBZXZTFKBFD
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8F9EBF0", Offset = "0x8F9D9F0", VA = "0x188F9EBF0")]
		public static string WMJXMBVUTLH(this Type a)
		{
			return null;
		}
	}
}
namespace RecRoom.Core.Studio.AvatarItems
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public abstract class RecRoomStudioAvatarItemBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		protected RecRoomStudioAvatarItemBase()
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
