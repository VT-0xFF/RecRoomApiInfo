using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.RecRoom.Api;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using RecRoom.Core.Studio.StudioFunctions;
using RecRoom.DataLayer;
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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA39AAD0", Offset = "0xA3994D0", VA = "0x18A39AAD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD007A0", Offset = "0xCFF1A0", VA = "0x180D007A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD007E0", Offset = "0xCFF1E0", VA = "0x180D007E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA398A60", Offset = "0xA397460", VA = "0x18A398A60", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
			public Vector3 YVYXPYDOESB
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0xA396640", Offset = "0xA395040", VA = "0x18A396640")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public Vector3 PIUPQIUGLOU
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0xA3966D0", Offset = "0xA3950D0", VA = "0x18A3966D0")]
				get
				{
					return default(Vector3);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public Vector3 SHIPMFFJHJN
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xA396760", Offset = "0xA395160", VA = "0x18A396760")]
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
		public Vector3 PIUPQIUGLOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA3966D0", Offset = "0xA3950D0", VA = "0x18A3966D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Vector3 SHIPMFFJHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA396760", Offset = "0xA395160", VA = "0x18A396760")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Vector3 UCNQMYKXCSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA396640", Offset = "0xA395040", VA = "0x18A396640")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Vector3 JPYXSETPNLL
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA3A46E0", Offset = "0xA3A30E0", VA = "0x18A3A46E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA3A26C0", Offset = "0xA3A10C0", VA = "0x18A3A26C0")]
		public bool Contains([In] RotatedBounds other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA3A25B0", Offset = "0xA3A0FB0", VA = "0x18A3A25B0")]
		public bool Contains(Vector3 point)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA3A1CE0", Offset = "0xA3A06E0", VA = "0x18A3A1CE0")]
		public bool BZHUCESJCKP(Collider a, Bounds b, bool c, bool d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA3A4790", Offset = "0xA3A3190", VA = "0x18A3A4790")]
		public bool XGZDNGBSHIG(Collider a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA3A4020", Offset = "0xA3A2A20", VA = "0x18A3A4020")]
		public bool QOTQJALXGEN(Collider a, bool b, bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA3A2F70", Offset = "0xA3A1970", VA = "0x18A3A2F70")]
		public void HDARYMLCLHD(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA3A3500", Offset = "0xA3A1F00", VA = "0x18A3A3500")]
		public void OLASWQVZCXF(RotatedBounds a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA3A3E00", Offset = "0xA3A2800", VA = "0x18A3A3E00")]
		public void OLASWQVZCXF(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA3A47B0", Offset = "0xA3A31B0", VA = "0x18A3A47B0")]
		private static void ZKDHSIFPPFH(Vector3 a, Vector3 b, Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA3A2210", Offset = "0xA3A0C10", VA = "0x18A3A2210")]
		public static RotatedBounds CAYJQBWQNYF(GameObject a, Quaternion b, bool c, bool d, bool e = false, bool f = false, bool g = false)
		{
			return default(RotatedBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA3A4580", Offset = "0xA3A2F80", VA = "0x18A3A4580")]
		public Face SAQDAJPKTPS(Vector3 a)
		{
			return default(Face);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA3A3020", Offset = "0xA3A1A20", VA = "0x18A3A3020")]
		public Face NCCVBHLGJIX(FaceType a)
		{
			return default(Face);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA3A1B80", Offset = "0xA3A0580", VA = "0x18A3A1B80")]
		private FaceType BYVVEDOWAZC(Vector3 a)
		{
			return default(FaceType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA3A2BD0", Offset = "0xA3A15D0", VA = "0x18A3A2BD0")]
		private static Quaternion EFCTZTSMHMU(FaceType a)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA3A32D0", Offset = "0xA3A1CD0", VA = "0x18A3A32D0")]
		public static RotatedBounds OLASWQVZCXF(IEnumerable<RotatedBounds> a)
		{
			return default(RotatedBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA3A4600", Offset = "0xA3A3000", VA = "0x18A3A4600", Slot = "3")]
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
	public static class TUBEPKJAEGL
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static string JNFYKAEHSRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA3AAC40", Offset = "0xA3A9640", VA = "0x18A3AAC40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static string UMGSPEJJWEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA3AACA0", Offset = "0xA3A96A0", VA = "0x18A3AACA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static string TQAZCWRSTXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA3AAC70", Offset = "0xA3A9670", VA = "0x18A3AAC70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA3AACD0", Offset = "0xA3A96D0", VA = "0x18A3AACD0")]
		public static AssetBundleVersion XEWKADEKUCU(this AssetBundleVersion a)
		{
			return default(AssetBundleVersion);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA3AACD0", Offset = "0xA3A96D0", VA = "0x18A3AACD0")]
		public static int XEWKADEKUCU(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface ARGGITWDYNK
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		AudioMixerGroup OBTLXWBWRSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		IReadOnlyList<ARGGITWDYNK> HHXLXBPRSRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		string CEZWGVWVPKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class JBYYMWHGEYE
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		private class Group : ARGGITWDYNK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			internal readonly List<ARGGITWDYNK> DROCMCVIKWA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			internal readonly Group DRCZZDLRJIX;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public AudioMixerGroup OBTLXWBWRSA
			{
				[Cpp2IlInjected.Token(Token = "0x600002D")]
				[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public IReadOnlyList<ARGGITWDYNK> HHXLXBPRSRH
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public string CEZWGVWVPKV
			{
				[Cpp2IlInjected.Token(Token = "0x600002F")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xA396950", Offset = "0xA395350", VA = "0x18A396950")]
			internal Group(AudioMixerGroup group, Group parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ARGGITWDYNK ZWXFAOBWWYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public AudioMixer MODHEQOJTGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA397560", Offset = "0xA395F60", VA = "0x18A397560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		private JBYYMWHGEYE(Group a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA397220", Offset = "0xA395C20", VA = "0x18A397220")]
		public static JBYYMWHGEYE QHTPTPPWGAN(AudioMixer a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA396E80", Offset = "0xA395880", VA = "0x18A396E80")]
		public ARGGITWDYNK OWZJFNRQLVT(string a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA3974E0", Offset = "0xA395EE0", VA = "0x18A3974E0")]
		private static int WTRVMUZNXWT(string a, int b)
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
		public MaterialEntry[] HPEKGIKJKYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool AQIQDFJMOFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xCD7520", Offset = "0xCD5F20", VA = "0x180CD7520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C40", Offset = "0xCD5640", VA = "0x180CD6C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7088560", Offset = "0x7086F60", VA = "0x187088560")]
		public MaterialEntry TryFindEntry(Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7088530", Offset = "0x7086F30", VA = "0x187088530")]
		public void ClearEntries()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7088630", Offset = "0x7087030", VA = "0x187088630")]
		public MaterialMapAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class MaterialMapBase<TMaterialMapAsset> : RecRoomUnitySceneSystemBase where TMaterialMapAsset : MaterialMapAssetBase<TMaterialMapAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static MaterialMapBase<TMaterialMapAsset> GMMEYIOKMTD;

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
		public static MaterialMapBase<TMaterialMapAsset> LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7088B40", Offset = "0x7087540", VA = "0x187088B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public MaterialEntry[] HPEKGIKJKYW
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7088AC0", Offset = "0x70874C0", VA = "0x187088AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7088650", Offset = "0x7087050", VA = "0x187088650")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x70889D0", Offset = "0x70873D0", VA = "0x1870889D0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x70888E0", Offset = "0x70872E0", VA = "0x1870888E0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7088860", Offset = "0x7087260", VA = "0x187088860")]
		public void ClearSceneMaterials()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xCF27E0", Offset = "0xCF11E0", VA = "0x180CF27E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3AAD80", Offset = "0xA3A9780", VA = "0x18A3AAD80", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3968B0", Offset = "0xA3952B0", VA = "0x18A3968B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3AC4B0", Offset = "0xA3AAEB0", VA = "0x18A3AC4B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3956C0", Offset = "0xA3940C0", VA = "0x18A3956C0", Slot = "4")]
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
		private Dictionary<string, float> MEFOSQQQFSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Dictionary<int, float> DOHVGQGKRLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Dictionary<int, Texture> TUSXTVWXQVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Dictionary<int, Vector4> HFFCBPUEECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<int, Color> BXLISYNBCYN;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA398E50", Offset = "0xA397850", VA = "0x18A398E50")]
		public void GCVAWOPHXZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA399210", Offset = "0xA397C10", VA = "0x18A399210")]
		public float JGCNNUQWZNK(int a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA3991C0", Offset = "0xA397BC0", VA = "0x18A3991C0")]
		public Texture GetTexture(int propertyId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA399260", Offset = "0xA397C60", VA = "0x18A399260")]
		public Vector4 YTXVBVXSGQB(int a)
		{
			return default(Vector4);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA399310", Offset = "0xA397D10", VA = "0x18A399310")]
		public Color ZKOACEFRXRX(int a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA398CF0", Offset = "0xA3976F0", VA = "0x18A398CF0", Slot = "4")]
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
		public IReadOnlyList<RecRoomAudioClipEntry> GQARRLYTPWZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x79316B0", Offset = "0x79300B0", VA = "0x1879316B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xD6AE70", Offset = "0xD69870", VA = "0x180D6AE70")]
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
			[Cpp2IlInjected.Address(RVA = "0xA39B730", Offset = "0xA39A130", VA = "0x18A39B730")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA39B870", Offset = "0xA39A270", VA = "0x18A39B870", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private Guid ARJBHFQJFQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA39B840", Offset = "0xA39A240", VA = "0x18A39B840", Slot = "5")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private Guid GDJPBGBRZKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA39B730", Offset = "0xA39A130", VA = "0x18A39B730", Slot = "6")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private IEnumerable<Guid> AOMUBPFDPOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA39B5F0", Offset = "0xA399FF0", VA = "0x18A39B5F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA39B7A0", Offset = "0xA39A1A0", VA = "0x18A39B7A0", Slot = "8")]
		public IStudioUnityAssetRegistrationEntry ToUnityAssetRegistrationEntry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public RecRoomAudioClipEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[AddComponentMenu("/")]
	public abstract class RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> : RecRoomUnitySceneSystemBase where TAudioClipRegistryAsset : RecRoomAudioClipRegistryAssetBase<TAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private static RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> GMMEYIOKMTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		[ReadOnlyField]
		private TAudioClipRegistryAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static RecRoomAudioClipRegistryBase<TAudioClipRegistryAsset> LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7088B40", Offset = "0x7087540", VA = "0x187088B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public TAudioClipRegistryAsset HPEKGIKJKYW
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public IReadOnlyList<RecRoomAudioClipEntry> GQARRLYTPWZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x79319B0", Offset = "0x79303B0", VA = "0x1879319B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7931700", Offset = "0x7930100", VA = "0x187931700")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7931830", Offset = "0x7930230", VA = "0x187931830")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xCF27E0", Offset = "0xCF11E0", VA = "0x180CF27E0")]
		protected RecRoomAudioClipRegistryBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class LSHRIKVZZZO
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
		private readonly AudioMixer ZQUVNVUDAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly AudioMixer WAWIRDUWIRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly AudioMixer XLYWZEQHFJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly AudioMixer WACGBKDKORQ;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly Dictionary<AudioMixerGroupType, string> QIKSSRIIGPG;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public const string MGOBMHKYDLE = "Music";

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public const string VLCFOZVIAUJ = "Ambience";

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public const string TJSIGISIBAF = "Sounds";

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private const string XGVSPOESQKS = "Assets";

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private const string FXPPAODREWW = "RecRoomStudio";

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private const string WMPMODVIMEH = "Audio";

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly string XKJBIGRCHCI;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly string WZVIZNUPSST;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public AudioMixer DLYKJYKPFYR
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8AF5C10", Offset = "0x8AF4610", VA = "0x188AF5C10")]
		public LSHRIKVZZZO(RecRoomAudioMixerRegistryBase.MixerVersion a, AudioMixer b, AudioMixer c, AudioMixer d, AudioMixer e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA398600", Offset = "0xA397000", VA = "0x18A398600")]
		public static string QQOGIHYTGDK(AudioMixerGroupType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA398420", Offset = "0xA396E20", VA = "0x18A398420")]
		public AudioMixerGroup ECHHYKKNITM(AudioMixerGroupType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA398720", Offset = "0xA397120", VA = "0x18A398720")]
		private static AudioMixerGroup TAQSIXSTTKL(AudioMixer a)
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
		private LSHRIKVZZZO mixerData;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public LSHRIKVZZZO NJPJLBEEVMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA39B8F0", Offset = "0xA39A2F0", VA = "0x18A39B8F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public RecRoomAudioMixerRegistryBase.MixerVersion VQEKOCBEAXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30")]
			get
			{
				return default(RecRoomAudioMixerRegistryBase.MixerVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public AudioMixer DLYKJYKPFYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C20", Offset = "0xCD5620", VA = "0x180CD6C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public AudioMixer LRTTIIVDDVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public AudioMixer HOBLULTRKUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public AudioMixer ZPNKWREFBIG
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xD6AE70", Offset = "0xD69870", VA = "0x180D6AE70")]
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
		private static RecRoomAudioMixerRegistryBase GMMEYIOKMTD;

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
		private LSHRIKVZZZO QDNOZEPSFSX;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static RecRoomAudioMixerRegistryBase LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA39BBD0", Offset = "0xA39A5D0", VA = "0x18A39BBD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public LSHRIKVZZZO NJPJLBEEVMT
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA39BD50", Offset = "0xA39A750", VA = "0x18A39BD50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public MixerVersion VQEKOCBEAXU
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550")]
			get
			{
				return default(MixerVersion);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA39BE20", Offset = "0xA39A820", VA = "0x18A39BE20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool GVLREYKWGTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA39BC10", Offset = "0xA39A610", VA = "0x18A39BC10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA39B9C0", Offset = "0xA39A3C0", VA = "0x18A39B9C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA39BAB0", Offset = "0xA39A4B0", VA = "0x18A39BAB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
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
		private Transform deformationTransform;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Guid MVLUMMSLOSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA39BF30", Offset = "0xA39A930", VA = "0x18A39BF30")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA39BFA0", Offset = "0xA39A9A0", VA = "0x18A39BFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool MCXRSKWZUII
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA39BEE0", Offset = "0xA39A8E0", VA = "0x18A39BEE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Transform MHKAQXUPVQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCD8620", Offset = "0xCD7020", VA = "0x180CD8620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		protected RecRoomBuiltInObjectBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public abstract class RecRoomBuiltInObjectDataBase<TRecRoomBuiltInObject, TRecRoomBuiltInObjectEntry> : ScriptableObject where TRecRoomBuiltInObject : RecRoomBuiltInObjectBase where TRecRoomBuiltInObjectEntry : RecRoomBuiltInObjectEntryBase<TRecRoomBuiltInObject>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private TRecRoomBuiltInObjectEntry[] builtInObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		private byte[] omPrefabData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private int omPrefabDataVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		private string omTypeInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private Dictionary<Guid, TRecRoomBuiltInObjectEntry> lookup;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private Dictionary<Guid, TRecRoomBuiltInObjectEntry> EOSNTFNMAEQ
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7931A60", Offset = "0x7930460", VA = "0x187931A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public byte[] ZLGVPWNHGEA
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xCD8610", Offset = "0xCD7010", VA = "0x180CD8610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int JXLFMSOZEHG
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xCDD3A0", Offset = "0xCDBDA0", VA = "0x180CDD3A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCDD390", Offset = "0xCDBD90", VA = "0x180CDD390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public string TJEMXLNIBFU
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xCDF4B0", Offset = "0xCDDEB0", VA = "0x180CDF4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IReadOnlyDictionary<Guid, TRecRoomBuiltInObjectEntry> CXQCWFFSGRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7931D60", Offset = "0x7930760", VA = "0x187931D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7931CA0", Offset = "0x79306A0", VA = "0x187931CA0")]
		public void SetBuiltInObjects(IEnumerable<TRecRoomBuiltInObjectEntry> builtInObjects)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7931CF0", Offset = "0x79306F0", VA = "0x187931CF0")]
		public bool TryGetValue(Guid prefabId, [Out] TRecRoomBuiltInObjectEntry builtInObject)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xD6AE70", Offset = "0xD69870", VA = "0x180D6AE70")]
		protected RecRoomBuiltInObjectDataBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class RecRoomBuiltInObjectEntryBase<TRecRoomBuiltInObject> where TRecRoomBuiltInObject : RecRoomBuiltInObjectBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		private TRecRoomBuiltInObject prefab;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TRecRoomBuiltInObject Prefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public RecRoomBuiltInObjectEntryBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class ORIARLSUJDA
	{
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static readonly Dictionary<Guid, string> TALFFUYECHR;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static IReadOnlyDictionary<Guid, string> QRXJZIEBCQP
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA39AB50", Offset = "0xA399550", VA = "0x18A39AB50")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class JGTNPFPSMOC
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private static readonly Dictionary<Guid, string> JOWLRSCDMUH;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static IReadOnlyDictionary<Guid, string> NLRKRZNHJXV
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA3975C0", Offset = "0xA395FC0", VA = "0x18A3975C0")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public abstract class RecRoomGripOptionsBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public enum GripAnimationType
		{
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			GrabSphere,
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			GrabFrisbee,
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			GrabCylinder,
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			GrabMug,
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			GrabFist,
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			GrabTrigger,
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			GrabCamera,
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			GrabPinch,
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			GrabSword
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private GripAnimationType gripAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private float gripAnimationBlend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private Vector3 leftHandGripPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private Quaternion leftHandGripRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private Vector3 rightHandGripPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		private Quaternion rightHandGripRotation;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal const string ONRHNVBVDRT = "gripAnimation";

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		internal const string BMFOINXRWRQ = "gripAnimationBlend";

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		internal const string TXGSWUVANZO = "leftHandGripPosition";

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal const string TYAYYFUIUTP = "leftHandGripRotation";

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		internal const string XRHHMXNNUTZ = "rightHandGripPosition";

		[Cpp2IlInjected.Token(Token = "0x400008D")]
		internal const string TLGORKVLBUK = "rightHandGripRotation";

		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private static readonly Dictionary<GripAnimationType, int> KGZFOVETGLM;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public GripAnimationType AGUWUQJYGYQ
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550")]
			get
			{
				return default(GripAnimationType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float FKNAWDMRAZB
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xD28D70", Offset = "0xD27770", VA = "0x180D28D70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Vector3 ARQHIBZININ
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xEA9E80", Offset = "0xEA8880", VA = "0x180EA9E80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Quaternion PUZEOHASTZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xEB4060", Offset = "0xEB2A60", VA = "0x180EB4060")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Vector3 XKONQJYPDHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x63F0640", Offset = "0x63EF040", VA = "0x1863F0640")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Quaternion XLLCYNLSPBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xF21AA0", Offset = "0xF204A0", VA = "0x180F21AA0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA39C010", Offset = "0xA39AA10", VA = "0x18A39C010")]
		public static IReadOnlyDictionary<GripAnimationType, int> GetGripAnimationStates()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA39C060", Offset = "0xA39AA60", VA = "0x18A39C060")]
		public (Vector3, Quaternion) GetGripTransform(HandType handType)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA39C100", Offset = "0xA39AB00", VA = "0x18A39C100")]
		public void SetGripTransform(HandType handType, Vector3 position, Quaternion rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA39C3D0", Offset = "0xA39ADD0", VA = "0x18A39C3D0")]
		protected RecRoomGripOptionsBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public abstract class RecRoomObjectBase : RecRoomStudioFunctionContainerBase
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class JLGJIUGGAQO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public bool PBBCXWXIUEP;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public JLGJIUGGAQO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA3977C0", Offset = "0xA3961C0", VA = "0x18A3977C0")]
			internal bool EPTFWKXQMAY(NamedUnityEventBase a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class ERUNCPORURX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public float PBBCXWXIUEP;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public ERUNCPORURX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xA3965B0", Offset = "0xA394FB0", VA = "0x18A3965B0")]
			internal bool EPTFWKXQMAY(NamedUnityEventBase a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class ZYNVIXGRUKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int PBBCXWXIUEP;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public ZYNVIXGRUKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xA3AC650", Offset = "0xA3AB050", VA = "0x18A3AC650")]
			internal bool EPTFWKXQMAY(NamedUnityEventBase a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class NXKJPKTRAET
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string PBBCXWXIUEP;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public NXKJPKTRAET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA399580", Offset = "0xA397F80", VA = "0x18A399580")]
			internal bool EPTFWKXQMAY(NamedUnityEventBase a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class IHMVLSEGBAB : IEnumerable<NamedUnityEventBase>, IEnumerable, IEnumerator<NamedUnityEventBase>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private NamedUnityEventBase BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int YTKXRPSSEMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public RecRoomObjectBase IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private string QCQNGDNMTJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public string IMTIEVEZFXU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private NamedUnityEventBase[] MXGZQBRVDOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private int MXBSSUXXUCX;

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			private NamedUnityEventBase EUXSKBJMCOE
			{
				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60000C0")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public IHMVLSEGBAB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xA396BF0", Offset = "0xA3955F0", VA = "0x18A396BF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xA396CE0", Offset = "0xA3956E0", VA = "0x18A396CE0", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xA396B40", Offset = "0xA395540", VA = "0x18A396B40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<NamedUnityEventBase> DFWNNHCYIBN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xA396B40", Offset = "0xA395540", VA = "0x18A396B40", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private RecRoomObjectConfiguration defaultConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Header("Player Events")]
		[SerializeField]
		[Tooltip("Event called when this Studio Object is picked up by the local player")]
		private UnityEvent onPickup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		[Tooltip("Event called when this Studio Object is released by the local player")]
		private UnityEvent onRelease;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		[HideInInspector]
		internal RecRoomObjectProperty[] properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeReference]
		[HideInInspector]
		[Obfuscation(Exclude = true)]
		internal NamedUnityEventBase[] unityEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private Dictionary<string, RecRoomObjectProperty> FGZNOHWRRQR;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public RecRoomObjectProperty[] OCPMTNNRQSX
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DC0", Offset = "0xCD57C0", VA = "0x180CD6DC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public NamedUnityEventBase[] AZXZQEKTNGG
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xCD7530", Offset = "0xCD5F30", VA = "0x180CD7530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public RecRoomObjectConfiguration AJYNPDPTEHV
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA39D190", Offset = "0xA39BB90", VA = "0x18A39D190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool KETMQYWOJBF
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<RecRoomObjectBase, string> HHMLAMHWAVR
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xA39D0E0", Offset = "0xA39BAE0", VA = "0x18A39D0E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xA39D200", Offset = "0xA39BC00", VA = "0x18A39D200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA39C730", Offset = "0xA39B130", VA = "0x18A39C730")]
		public bool TryGetProperty(string propertyName, [Out] RecRoomObjectProperty property)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA39C520", Offset = "0xA39AF20", VA = "0x18A39C520")]
		public void SendCircuitsEvent(string eventName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA39C8F0", Offset = "0xA39B2F0", VA = "0x18A39C8F0")]
		public bool TryRaiseUnityEvent(string eventName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3EB06A0", Offset = "0x3EAF0A0", VA = "0x183EB06A0")]
		private bool AQOAACUBJWC<b, c, a>(string a, b b, c c) where a : UnityEvent<b, c>, new()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA39CE90", Offset = "0xA39B890", VA = "0x18A39CE90")]
		public bool TryRaiseUnityEvent(string eventName, bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA39CDC0", Offset = "0xA39B7C0", VA = "0x18A39CDC0")]
		public bool TryRaiseUnityEvent(string eventName, float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA39CC10", Offset = "0xA39B610", VA = "0x18A39CC10")]
		public bool TryRaiseUnityEvent(string eventName, int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xA39CAD0", Offset = "0xA39B4D0", VA = "0x18A39CAD0")]
		public bool TryRaiseUnityEvent(string eventName, string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA39CCE0", Offset = "0xA39B6E0", VA = "0x18A39CCE0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, bool value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA39CF60", Offset = "0xA39B960", VA = "0x18A39CF60")]
		public bool TryRaiseUnityEvent(string eventName, string value0, float value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA39CBA0", Offset = "0xA39B5A0", VA = "0x18A39CBA0")]
		public bool TryRaiseUnityEvent(string eventName, string value0, int value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xA39CD50", Offset = "0xA39B750", VA = "0x18A39CD50")]
		public bool TryRaiseUnityEvent(string eventName, string value0, string value1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA39C4E0", Offset = "0xA39AEE0", VA = "0x18A39C4E0")]
		public void RaiseOnPickup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA39C500", Offset = "0xA39AF00", VA = "0x18A39C500")]
		public void RaiseOnRelease()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA39C450", Offset = "0xA39AE50", VA = "0x18A39C450")]
		[IteratorStateMachine(typeof(IHMVLSEGBAB))]
		private IEnumerable<NamedUnityEventBase> HSJYWLBHDDK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA39C540", Offset = "0xA39AF40", VA = "0x18A39C540")]
		private bool TXQQZVFSWGZ(string a, Func<NamedUnityEventBase, bool> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA39CFD0", Offset = "0xA39B9D0", VA = "0x18A39CFD0")]
		protected RecRoomObjectBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class UnityBooleanEvent : UnityEvent<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA3ABB20", Offset = "0xA3AA520", VA = "0x18A3ABB20")]
		public UnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class UnityFloatEvent : UnityEvent<float>
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA3ABB60", Offset = "0xA3AA560", VA = "0x18A3ABB60")]
		public UnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class UnityIntEvent : UnityEvent<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA3ABBA0", Offset = "0xA3AA5A0", VA = "0x18A3ABBA0")]
		public UnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class UnityStringEvent : UnityEvent<string>
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA3ABC60", Offset = "0xA3AA660", VA = "0x18A3ABC60")]
		public UnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class UnityStringBooleanEvent : UnityEvent<string, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA3ABC20", Offset = "0xA3AA620", VA = "0x18A3ABC20")]
		public UnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class UnityStringIntEvent : UnityEvent<string, int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA3ABCE0", Offset = "0xA3AA6E0", VA = "0x18A3ABCE0")]
		public UnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class UnityStringFloatEvent : UnityEvent<string, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA3ABCA0", Offset = "0xA3AA6A0", VA = "0x18A3ABCA0")]
		public UnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public sealed class UnityStringStringEvent : UnityEvent<string, string>
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA3ABD20", Offset = "0xA3AA720", VA = "0x18A3ABD20")]
		public UnityStringStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public abstract class NamedUnityEventBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private string eventName;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string EventName
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void GODDDASESJA();

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "5")]
		public virtual bool XWJMKPCXDNX(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "6")]
		public virtual bool XWJMKPCXDNX(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "7")]
		public virtual bool XWJMKPCXDNX(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "8")]
		public virtual bool XWJMKPCXDNX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public abstract class NamedUnityEventBase<TUnityEvent> : NamedUnityEventBase where TUnityEvent : UnityEventBase, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private TUnityEvent unityEvent;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public TUnityEvent Event
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7281580", Offset = "0x727FF80", VA = "0x187281580")]
		protected NamedUnityEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityParameterlessEventBase : NamedUnityEventBase<UnityEvent>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			Hide
		}

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA399C80", Offset = "0xA398680", VA = "0x18A399C80", Slot = "4")]
		public override void GODDDASESJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA399D50", Offset = "0xA398750", VA = "0x18A399D50")]
		protected NamedUnityParameterlessEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class OneParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			HideParam
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x74D7380", Offset = "0x74D5D80", VA = "0x1874D7380")]
		protected OneParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class TwoParamNamedUnityEvent<TUnityEvent> : NamedUnityEventBase<TUnityEvent> where TUnityEvent : UnityEventBase, new()
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			Hide,
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			HideParam1,
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			HideBothParams
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		protected string defaultValue1;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x74D7380", Offset = "0x74D5D80", VA = "0x1874D7380")]
		protected TwoParamNamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityBooleanEventBase : OneParamNamedUnityEvent<UnityBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[SerializeField]
		private bool defaultValue;

		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA3995C0", Offset = "0xA397FC0", VA = "0x18A3995C0", Slot = "4")]
		public override void GODDDASESJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA399620", Offset = "0xA398020", VA = "0x18A399620", Slot = "5")]
		public override bool XWJMKPCXDNX(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA3997C0", Offset = "0xA3981C0", VA = "0x18A3997C0")]
		protected NamedUnityBooleanEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityFloatEventBase : OneParamNamedUnityEvent<UnityFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[SerializeField]
		private float defaultValue;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA399800", Offset = "0xA398200", VA = "0x18A399800", Slot = "4")]
		public override void GODDDASESJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA399860", Offset = "0xA398260", VA = "0x18A399860", Slot = "6")]
		public override bool XWJMKPCXDNX(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA399A00", Offset = "0xA398400", VA = "0x18A399A00")]
		protected NamedUnityFloatEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityIntEventBase : OneParamNamedUnityEvent<UnityIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[SerializeField]
		private int defaultValue;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA399A40", Offset = "0xA398440", VA = "0x18A399A40", Slot = "4")]
		public override void GODDDASESJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA399AA0", Offset = "0xA3984A0", VA = "0x18A399AA0", Slot = "7")]
		public override bool XWJMKPCXDNX(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA399C40", Offset = "0xA398640", VA = "0x18A399C40")]
		protected NamedUnityIntEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityStringEventBase : OneParamNamedUnityEvent<UnityStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[SerializeField]
		private string defaultValue;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA39A050", Offset = "0xA398A50", VA = "0x18A39A050", Slot = "4")]
		public override void GODDDASESJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA39A0B0", Offset = "0xA398AB0", VA = "0x18A39A0B0", Slot = "8")]
		public override bool XWJMKPCXDNX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA39A250", Offset = "0xA398C50", VA = "0x18A39A250")]
		protected NamedUnityStringEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityStringBooleanEventBase : TwoParamNamedUnityEvent<UnityStringBooleanEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[SerializeField]
		private bool defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA399D90", Offset = "0xA398790", VA = "0x18A399D90", Slot = "4")]
		public override void GODDDASESJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA399DF0", Offset = "0xA3987F0", VA = "0x18A399DF0", Slot = "5")]
		public override bool XWJMKPCXDNX(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA39A010", Offset = "0xA398A10", VA = "0x18A39A010")]
		protected NamedUnityStringBooleanEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityStringFloatEventBase : TwoParamNamedUnityEvent<UnityStringFloatEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		private float defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA39A290", Offset = "0xA398C90", VA = "0x18A39A290", Slot = "4")]
		public override void GODDDASESJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA39A2F0", Offset = "0xA398CF0", VA = "0x18A39A2F0", Slot = "6")]
		public override bool XWJMKPCXDNX(float a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA39A510", Offset = "0xA398F10", VA = "0x18A39A510")]
		protected NamedUnityStringFloatEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityStringIntEventBase : TwoParamNamedUnityEvent<UnityStringIntEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[SerializeField]
		private int defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA39A550", Offset = "0xA398F50", VA = "0x18A39A550", Slot = "4")]
		public override void GODDDASESJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA39A5B0", Offset = "0xA398FB0", VA = "0x18A39A5B0", Slot = "7")]
		public override bool XWJMKPCXDNX(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA39A7D0", Offset = "0xA3991D0", VA = "0x18A39A7D0")]
		protected NamedUnityStringIntEventBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[SerializedTypeName]
	[UnityEngine.Scripting.Preserve]
	public abstract class NamedUnityStringStringEventBase : TwoParamNamedUnityEvent<UnityStringStringEvent>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[SerializeField]
		private string defaultValue2;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public static readonly IReadOnlyList<Type> ClassInputTypes;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA39A810", Offset = "0xA399210", VA = "0x18A39A810", Slot = "4")]
		public override void GODDDASESJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA39A870", Offset = "0xA399270", VA = "0x18A39A870", Slot = "8")]
		public override bool XWJMKPCXDNX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA39AA90", Offset = "0xA399490", VA = "0x18A39AA90")]
		protected NamedUnityStringStringEventBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class RecRoomObjectPrefabRegistryAssetBase<TPrefabRegistryAsset, TPrefabEntry, TRecRoomObject> : RecRoomStudioAutoGeneratedAsset<TPrefabRegistryAsset> where TPrefabRegistryAsset : RecRoomObjectPrefabRegistryAssetBase<TPrefabRegistryAsset, TPrefabEntry, TRecRoomObject> where TPrefabEntry : RecRoomObjectPrefabEntryBase<TRecRoomObject> where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[SerializeField]
		private TPrefabEntry[] prefabs;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public TPrefabEntry[] VKNXSVQVUJT
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xD6AE70", Offset = "0xD69870", VA = "0x180D6AE70")]
		public RecRoomObjectPrefabRegistryAssetBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> : RecRoomUnitySceneSystemBase where TPrefabAsset : RecRoomObjectPrefabRegistryAssetBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> where TPrefabEntry : RecRoomObjectPrefabEntryBase<TRecRoomObject>, new() where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> GMMEYIOKMTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		[HideInInspector]
		private TPrefabEntry[] prefabs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		private TPrefabAsset prefabsAsset;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public static RecRoomObjectPrefabRegistryBase<TPrefabAsset, TPrefabEntry, TRecRoomObject> LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7088B40", Offset = "0x7087540", VA = "0x187088B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public IReadOnlyList<TPrefabEntry> VGKUUMFTWJW
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7932780", Offset = "0x7931180", VA = "0x187932780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x79324D0", Offset = "0x7930ED0", VA = "0x1879324D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7932600", Offset = "0x7931000", VA = "0x187932600")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xCF27E0", Offset = "0xCF11E0", VA = "0x180CF27E0")]
		protected RecRoomObjectPrefabRegistryBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public abstract class RecRoomObjectPrefabEntryBase<TRecRoomObject> : IStudioUnityAssetRegistrationEntry, IEquatable<RecRoomObjectPrefabEntryBase<TRecRoomObject>> where TRecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private TRecRoomObject Prefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public SerializedGuid UnityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public SerializedGuid[] ReferencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		private GameObject prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private RecRoomObjectPrefabObjectBoardTemplate objectBoardTemplate;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Guid UnityAssetIdGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x7932210", Offset = "0x7930C10", VA = "0x187932210")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public GameObject PrefabRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x79323F0", Offset = "0x7930DF0", VA = "0x1879323F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x79324A0", Offset = "0x7930EA0", VA = "0x1879324A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public RecRoomObjectPrefabObjectBoardTemplate ObjectBoardTemplate
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C20", Offset = "0xCD5620", VA = "0x180CD6C20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E40", Offset = "0xCD5840", VA = "0x180CD6E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool HasObjectBoardData
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7932310", Offset = "0x7930D10", VA = "0x187932310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x7932370", Offset = "0x7930D70", VA = "0x187932370", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		private Guid ARJBHFQJFQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7932290", Offset = "0x7930C90", VA = "0x187932290", Slot = "5")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		private Guid GDJPBGBRZKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7932210", Offset = "0x7930C10", VA = "0x187932210", Slot = "6")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		private IEnumerable<Guid> AOMUBPFDPOD
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7931D80", Offset = "0x7930780", VA = "0x187931D80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x79322C0", Offset = "0x7930CC0", VA = "0x1879322C0")]
		public bool UTWDYCRLGDN(Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7931F50", Offset = "0x7930950", VA = "0x187931F50", Slot = "9")]
		public bool Equals(RecRoomObjectPrefabEntryBase<TRecRoomObject> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7932140", Offset = "0x7930B40", VA = "0x187932140", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x79321F0", Offset = "0x7930BF0", VA = "0x1879321F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		[Obfuscation(Exclude = true)]
		public abstract IStudioUnityAssetRegistrationEntry ToUnityAssetRegistrationEntry();

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		protected RecRoomObjectPrefabEntryBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public sealed class RecRoomObjectPrefabObjectBoardTemplate : IEquatable<RecRoomObjectPrefabObjectBoardTemplate>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		private string signature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[SerializeField]
		private byte[] objectBoard;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public string Signature
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public byte[] ObjectBoard
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA39D340", Offset = "0xA39BD40", VA = "0x18A39D340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xCDD200", Offset = "0xCDBC00", VA = "0x180CDD200")]
		public RecRoomObjectPrefabObjectBoardTemplate(string signature, byte[] objectBoard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA39D2C0", Offset = "0xA39BCC0", VA = "0x18A39D2C0", Slot = "4")]
		public bool Equals(RecRoomObjectPrefabObjectBoardTemplate other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[RequireComponent(typeof(ParticleSystem))]
	public abstract class RecRoomParticleVfxBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[SerializeField]
		private float minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		private float maxScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[SerializeField]
		private float minSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[SerializeField]
		private float maxSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public float NZVVWPJCCEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xD2E370", Offset = "0xD2CD70", VA = "0x180D2E370")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public float PBBVHWIBDOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xD28D70", Offset = "0xD27770", VA = "0x180D28D70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public float NFMCZQZMMUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x10AA980", Offset = "0x10A9380", VA = "0x1810AA980")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public float XCVCOSHBTUX
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xE60CA0", Offset = "0xE5F6A0", VA = "0x180E60CA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA39D770", Offset = "0xA39C170", VA = "0x18A39D770")]
		protected RecRoomParticleVfxBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class RecRoomParticleVfxRegistryAssetBase<TParticleVfxRegistryAsset> : RecRoomStudioAutoCreatedAsset<TParticleVfxRegistryAsset> where TParticleVfxRegistryAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[SerializeField]
		internal RecRoomParticleVfxEntry[] particleEffects;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public IReadOnlyList<RecRoomParticleVfxEntry> XJGLBDYUDIC
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7932820", Offset = "0x7931220", VA = "0x187932820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xD6AE70", Offset = "0xD69870", VA = "0x180D6AE70")]
		public RecRoomParticleVfxRegistryAssetBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class RecRoomParticleVfxEntry : IStudioUnityAssetRegistrationEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public GameObject ParticleVfxPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public SerializedGuid UnityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public SerializedGuid[] ReferencedUnityAssetIds;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public Guid UnityAssetIdGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xA39D8D0", Offset = "0xA39C2D0", VA = "0x18A39D8D0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xA39D9E0", Offset = "0xA39C3E0", VA = "0x18A39D9E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private Guid ARJBHFQJFQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xA39B840", Offset = "0xA39A240", VA = "0x18A39B840", Slot = "5")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		private Guid GDJPBGBRZKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xA39D8D0", Offset = "0xA39C2D0", VA = "0x18A39D8D0", Slot = "6")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		private IEnumerable<Guid> AOMUBPFDPOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA39D790", Offset = "0xA39C190", VA = "0x18A39D790", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA39D940", Offset = "0xA39C340", VA = "0x18A39D940", Slot = "8")]
		public IStudioUnityAssetRegistrationEntry ToUnityAssetRegistrationEntry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public RecRoomParticleVfxEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[AddComponentMenu(null)]
	public abstract class RecRoomParticleVfxRegistryBase<TParticleVfxRegistryAsset> : RecRoomUnitySceneSystemBase where TParticleVfxRegistryAsset : RecRoomParticleVfxRegistryAssetBase<TParticleVfxRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private static RecRoomParticleVfxRegistryBase<TParticleVfxRegistryAsset> GMMEYIOKMTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[SerializeField]
		[ReadOnlyField]
		private TParticleVfxRegistryAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public static RecRoomParticleVfxRegistryBase<TParticleVfxRegistryAsset> LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7088B40", Offset = "0x7087540", VA = "0x187088B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public TParticleVfxRegistryAsset HPEKGIKJKYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public IReadOnlyList<RecRoomParticleVfxEntry> XJGLBDYUDIC
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7932B40", Offset = "0x7931540", VA = "0x187932B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7932870", Offset = "0x7931270", VA = "0x187932870")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x79329B0", Offset = "0x79313B0", VA = "0x1879329B0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xCF27E0", Offset = "0xCF11E0", VA = "0x180CF27E0")]
		protected RecRoomParticleVfxRegistryBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class RecRoomPlayerAnimation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		[RecRoomPlayerAnimationId]
		private SerializedGuid Animation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[Header("Fade Durations")]
		public float FadeInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public float FadeOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public float LoopFadeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[Header("Play Speed")]
		public float PlaySpeed;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public Guid AnimationId
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xA39DBD0", Offset = "0xA39C5D0", VA = "0x18A39DBD0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA39DBA0", Offset = "0xA39C5A0", VA = "0x18A39DBA0")]
		public RecRoomPlayerAnimation()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public sealed class RecRoomPlayerAnimationIdAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x22654E0", Offset = "0x2263EE0", VA = "0x1822654E0")]
		public RecRoomPlayerAnimationIdAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public abstract class RecRoomPlayerCollisionHandlerBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[SerializeField]
		private float playerForceMagnitude;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[SerializeField]
		private float liftAngleDegrees;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[SerializeField]
		private Transform visuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[SerializeField]
		private Transform collision;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[SerializeField]
		private bool isAvailable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[SerializeField]
		[Header("Events")]
		private UnityEvent onPlayerHit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[SerializeField]
		private UnityEvent onNonPlayerHit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private float TNFEDRLRHOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private float JLRZZMQMJRD;

		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private const float NERZBFXBVSD = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public Transform CYJVDGXLYWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Transform HVRPYHVWGSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public float YMZWQNUVMEU
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xD2E370", Offset = "0xD2CD70", VA = "0x180D2E370")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public float LCKNFFLDPFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xD28D70", Offset = "0xD27770", VA = "0x180D28D70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public bool DIJEUKABNLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xD03640", Offset = "0xD02040", VA = "0x180D03640")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xA39DE80", Offset = "0xA39C880", VA = "0x18A39DE80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		private bool BNSNKUUTHFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xA39DCF0", Offset = "0xA39C6F0", VA = "0x18A39DCF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		private bool ZIBPCRGUICP
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x1ABB330", Offset = "0x1AB9D30", VA = "0x181ABB330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action AFKYBBWMURE
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xA39DD40", Offset = "0xA39C740", VA = "0x18A39DD40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xA39DDE0", Offset = "0xA39C7E0", VA = "0x18A39DDE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA39DC90", Offset = "0xA39C690", VA = "0x18A39DC90")]
		public void InvokePlayerHit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA39DC40", Offset = "0xA39C640", VA = "0x18A39DC40")]
		public void InvokeNonPlayerHit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA39DD20", Offset = "0xA39C720", VA = "0x18A39DD20")]
		protected RecRoomPlayerCollisionHandlerBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public abstract class RecRoomProjectileBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[SerializeField]
		[Range(0.0001f, 1f)]
		private float colliderRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[SerializeField]
		private Transform colliderTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public float IGQWMSDIPLK
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xD2E370", Offset = "0xD2CD70", VA = "0x180D2E370")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Transform TAECSLFNVWG
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xA39DEB0", Offset = "0xA39C8B0", VA = "0x18A39DEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA39DEA0", Offset = "0xA39C8A0", VA = "0x18A39DEA0")]
		protected RecRoomProjectileBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class RecRoomProjectileRegistryAssetBase<TProjectileRegistryAsset> : RecRoomStudioAutoCreatedAsset<TProjectileRegistryAsset> where TProjectileRegistryAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[SerializeField]
		internal RecRoomProjectileEntry[] projectiles;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public IReadOnlyList<RecRoomProjectileEntry> MMZOXEIBSTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x7932BF0", Offset = "0x79315F0", VA = "0x187932BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xD6AE70", Offset = "0xD69870", VA = "0x180D6AE70")]
		public RecRoomProjectileRegistryAssetBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class RecRoomProjectileEntry : IStudioUnityAssetRegistrationEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public GameObject ProjectilePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public SerializedGuid UnityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public SerializedGuid[] ReferencedUnityAssetIds;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Guid UnityAssetIdGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0xA39E070", Offset = "0xA39CA70", VA = "0x18A39E070")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xA39E180", Offset = "0xA39CB80", VA = "0x18A39E180", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private Guid ARJBHFQJFQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xA39B840", Offset = "0xA39A240", VA = "0x18A39B840", Slot = "5")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private Guid GDJPBGBRZKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xA39E070", Offset = "0xA39CA70", VA = "0x18A39E070", Slot = "6")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private IEnumerable<Guid> AOMUBPFDPOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xA39DF30", Offset = "0xA39C930", VA = "0x18A39DF30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA39E0E0", Offset = "0xA39CAE0", VA = "0x18A39E0E0", Slot = "8")]
		public IStudioUnityAssetRegistrationEntry ToUnityAssetRegistrationEntry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public RecRoomProjectileEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[AddComponentMenu(null)]
	public abstract class RecRoomProjectileRegistryBase<TProjectileRegistryAsset> : RecRoomUnitySceneSystemBase where TProjectileRegistryAsset : RecRoomProjectileRegistryAssetBase<TProjectileRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static RecRoomProjectileRegistryBase<TProjectileRegistryAsset> GMMEYIOKMTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[SerializeField]
		[ReadOnlyField]
		private TProjectileRegistryAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public static RecRoomProjectileRegistryBase<TProjectileRegistryAsset> LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x7088B40", Offset = "0x7087540", VA = "0x187088B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public TProjectileRegistryAsset HPEKGIKJKYW
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public IReadOnlyList<RecRoomProjectileEntry> MMZOXEIBSTU
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x7932F10", Offset = "0x7931910", VA = "0x187932F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7932C40", Offset = "0x7931640", VA = "0x187932C40")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7932D80", Offset = "0x7931780", VA = "0x187932D80")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xCF27E0", Offset = "0xCF11E0", VA = "0x180CF27E0")]
		protected RecRoomProjectileRegistryBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class RecRoomStudioAnimatorSynchronizerBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public interface KAPBRESJAKW
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void SetBoolParameterFromScript(string name, bool val);

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void SetIntegerParameterFromScript(string name, int val);

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void SetFloatParameterFromScript(string name, float val);

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void SetTriggerParameterFromScript(string name);
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public KAPBRESJAKW NVWEURIBKSR
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xCD8610", Offset = "0xCD7010", VA = "0x180CD8610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA39E340", Offset = "0xA39CD40", VA = "0x18A39E340")]
		public Animator GetControlledAnimator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA39E380", Offset = "0xA39CD80", VA = "0x18A39E380")]
		public void SetBoolParameter(string name, bool val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA39E510", Offset = "0xA39CF10", VA = "0x18A39E510")]
		public void SetIntegerParameter(string name, int val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA39E440", Offset = "0xA39CE40", VA = "0x18A39E440")]
		public void SetFloatParameter(string name, float val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA39E5D0", Offset = "0xA39CFD0", VA = "0x18A39E5D0")]
		public void SetTriggerParameter(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		protected RecRoomStudioAnimatorSynchronizerBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public abstract class RecRoomStudioAudioSourceSynchronizerBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public interface NYQHIHNJASG
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void PlayFromScript(float time);

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void PauseFromScript();

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			void UnPauseFromScript();

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			void StopFromScript();

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void SetLoopFromScript(bool loop);

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(Slot = "5")]
			void SetPitchFromScript(float pitch);
		}

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public const float MinPitch = 0.01f;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public const float MaxPitch = 10f;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public NYQHIHNJASG KOZPBXNHWOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xCD8610", Offset = "0xCD7010", VA = "0x180CD8610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA39E680", Offset = "0xA39D080", VA = "0x18A39E680")]
		public AudioSource GetControlledAudioSource()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA39E710", Offset = "0xA39D110", VA = "0x18A39E710")]
		public void Play(float playAtTimeSeconds)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA39E6C0", Offset = "0xA39D0C0", VA = "0x18A39E6C0")]
		public void Pause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA39E8D0", Offset = "0xA39D2D0", VA = "0x18A39E8D0")]
		public void UnPause()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA39E880", Offset = "0xA39D280", VA = "0x18A39E880")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA39E770", Offset = "0xA39D170", VA = "0x18A39E770")]
		public void SetLoop(bool loop)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA39E820", Offset = "0xA39D220", VA = "0x18A39E820")]
		public void SetPitch(float pitch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		protected RecRoomStudioAudioSourceSynchronizerBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public abstract class RecRoomStudioBillboardBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[SerializeField]
		[Tooltip("If true, the object can turn left/right to face the player (y-axis rotation)")]
		private bool yawRotationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[SerializeField]
		[Tooltip("If true, the object can look up/down to face the player (x-axis rotation)")]
		private bool pitchRotationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[SerializeField]
		[Tooltip("If true, the object can rotate clockwise/counter-clockwise to match the players rotation (z-axis rotation)")]
		private bool rollRotationEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[SerializeField]
		[Tooltip("If true, makes the player \"look through\" the object rather than \"look at\" the object to accomadate Unity UI expectations")]
		private bool faceAwayFromCamera;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool GUEMGRTGQOU
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xCD7520", Offset = "0xCD5F20", VA = "0x180CD7520")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C40", Offset = "0xCD5640", VA = "0x180CD6C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool XIHJHVTLFPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x15EBE20", Offset = "0x15EA820", VA = "0x1815EBE20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x15EB260", Offset = "0x15E9C60", VA = "0x1815EB260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public bool ZIMAGWMMARG
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x1BA1400", Offset = "0x1B9FE00", VA = "0x181BA1400")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x1DE8930", Offset = "0x1DE7330", VA = "0x181DE8930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public bool PUJYAFYHRIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x1BA9610", Offset = "0x1BA8010", VA = "0x181BA9610")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x29AAD20", Offset = "0x29A9720", VA = "0x1829AAD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA39E920", Offset = "0xA39D320", VA = "0x18A39E920")]
		protected RecRoomStudioBillboardBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public abstract class RecRoomStudioCanvasInteractionBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[Obfuscation(Exclude = true, ApplyToMembers = true)]
		public enum AttachmentMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			[Tooltip("For screens and mobile players, moves the camera to frame the canvas.")]
			FrameScreensCanvas,
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			[Tooltip("For screens and mobile players, moves the canvas and anchors it onto the camera.")]
			AnchorCanvasAsMenu
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[Obfuscation(Exclude = true, ApplyToMembers = true)]
		public enum ControlPromptBehaviorType
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			[Tooltip("Let Rec Room decide whether or not to show control prompts for this UI.")]
			Default,
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			[Tooltip("Ensure all platforms see control prompts when looking at this UI.")]
			ForceOnAllPlatforms,
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			[Tooltip("No platforms will ever see control prompts when looking at this UI")]
			ForceSuppressAllPlatforms
		}

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public bool isAnchored;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[SerializeField]
		[Tooltip("Allows the player to interact with elements on the canvas directly")]
		private bool isInteractable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[SerializeField]
		[Tooltip("Allows the canvas to be anchored and framed to the screen")]
		private bool canBeAnchored;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[SerializeField]
		[ConditionallyVisibleField("canBeAnchored", true, false)]
		[Tooltip("The way in which the menu frames up on screen")]
		private AttachmentMode anchorAttachmentMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[SerializeField]
		[ConditionallyVisibleField("isInteractable", true, false)]
		[Tooltip("Optionally overwrite Rec Room's default behavior of when we show control hints while the cursor is over UI.")]
		private ControlPromptBehaviorType controlPromptBehaviorOverride;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool KZPYLRVOVJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xCD7520", Offset = "0xCD5F20", VA = "0x180CD7520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool EFOMVCNWUHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x15EBE20", Offset = "0x15EA820", VA = "0x1815EBE20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public bool AQUYDKZEIHH
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x1BA1400", Offset = "0x1B9FE00", VA = "0x181BA1400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public AttachmentMode ZXMBLRUSIAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xCFE110", Offset = "0xCFCB10", VA = "0x180CFE110")]
			get
			{
				return default(AttachmentMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public ControlPromptBehaviorType QPQDYRTMBGL
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xCDD3A0", Offset = "0xCDBDA0", VA = "0x180CDD3A0")]
			get
			{
				return default(ControlPromptBehaviorType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<AttachmentMode> GPAAURPCCRY
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xA39E970", Offset = "0xA39D370", VA = "0x18A39E970")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA39EAC0", Offset = "0xA39D4C0", VA = "0x18A39EAC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action MVQCYIAXOAU
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xA39EA20", Offset = "0xA39D420", VA = "0x18A39EA20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xA39EB70", Offset = "0xA39D570", VA = "0x18A39EB70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA39E930", Offset = "0xA39D330", VA = "0x18A39E930")]
		public void AnchorCanvas()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA39E950", Offset = "0xA39D350", VA = "0x18A39E950")]
		public void DetachCanvas()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		protected RecRoomStudioCanvasInteractionBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public abstract class RecRoomStudioConsumableItemBase : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public enum DespawnModeValue
		{
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			Manual,
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			AutomaticAfterConsume,
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			AutomaticAfterLeftAlone
		}

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		protected static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[Header("Configuration")]
		[SerializeField]
		[Tooltip("Determines if screen players pick this up in their dominant hand or off hand. Dual-wield objects are held in the dominant hand, and support picking up two dual-wield objects at once.")]
		private PreferredHandedness screenPlayerPreferredHand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[SerializeField]
		[Tooltip("Determines if this consumable should be automatically consumed when first picked up. If this is false, the consumable must manually call Consume via a Unity Event or Studio Function to consume.")]
		private bool consumeAutomatically;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[SerializeField]
		[Tooltip("Determines when this consumable is despawned. If set to Manual, the consumable must manually call Despawn via a Unity Event or Studio Function to despawn.")]
		private DespawnModeValue despawnMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		[Tooltip("When Despawn Mode is AutomaticAfterConsume, the number of seconds to wait before despawning this consumable *after* it's been Consumed.")]
		[IntConditionallyVisibleField("despawnMode", 1, false)]
		private float despawnAfterConsumeDelayInSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[SerializeField]
		[Tooltip("When Despawn Mode is AutomaticAfterLeftAlone, the number of seconds to wait before despawning this consumable *after* it's been dropped and no players are near it.")]
		[IntConditionallyVisibleField("despawnMode", 2, false)]
		private float despawnAfterLeftAloneDelayInSeconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		[Obsolete]
		[HideInInspector]
		private bool despawnAutomatically;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		[Obsolete]
		[HideInInspector]
		private float automaticDespawnDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[Header("Player Events")]
		[SerializeField]
		[Tooltip("Event called when this Consumable is picked up by the local player")]
		private UnityEvent onPickup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		[Tooltip("Event called when this Consumable is released by the local player")]
		private UnityEvent onRelease;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool VHHAUANOAZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xEC8BA0", Offset = "0xEC75A0", VA = "0x180EC8BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public DespawnModeValue HXFTADETXTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xCDD3A0", Offset = "0xCDBDA0", VA = "0x180CDD3A0")]
			get
			{
				return default(DespawnModeValue);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float BAGNLZDJAME
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA39F0A0", Offset = "0xA39DAA0", VA = "0x18A39F0A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public PreferredHandedness JAFIRWILGKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xCE7550", Offset = "0xCE5F50", VA = "0x180CE7550")]
			get
			{
				return default(PreferredHandedness);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action BNDZDNFCGWE
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xA39EF60", Offset = "0xA39D960", VA = "0x18A39EF60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA39F170", Offset = "0xA39DB70", VA = "0x18A39F170")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action UJLVUTCZLQQ
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA39F000", Offset = "0xA39DA00", VA = "0x18A39F000")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xA39F210", Offset = "0xA39DC10", VA = "0x18A39F210")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x10828B0", Offset = "0x10812B0", VA = "0x1810828B0")]
		public void Consume()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x1081990", Offset = "0x1080390", VA = "0x181081990")]
		public void Despawn()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8A54DE0", Offset = "0x8A537E0", VA = "0x188A54DE0")]
		public void RaiseOnPickup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA39EEA0", Offset = "0xA39D8A0", VA = "0x18A39EEA0")]
		public void RaiseOnRelease()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA39EC10", Offset = "0xA39D610", VA = "0x18A39EC10", Slot = "5")]
		private void HDQANKIEEQM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
		private void CKFKUGGCSWA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA39EF40", Offset = "0xA39D940", VA = "0x18A39EF40")]
		protected RecRoomStudioConsumableItemBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class RecRoomStudioConsumableItemRegistryAssetBase<TConsumableItemRegistryAsset> : RecRoomStudioAutoCreatedAsset<TConsumableItemRegistryAsset> where TConsumableItemRegistryAsset : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		internal RecRoomStudioConsumableItemEntry[] consumableItems;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public IReadOnlyList<RecRoomStudioConsumableItemEntry> QOEALBIGTYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7932FC0", Offset = "0x79319C0", VA = "0x187932FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xD6AE70", Offset = "0xD69870", VA = "0x180D6AE70")]
		public RecRoomStudioConsumableItemRegistryAssetBase()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class RecRoomStudioConsumableItemEntry : IStudioUnityAssetRegistrationEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public GameObject ConsumableItemPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public SerializedGuid UniqueId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public SerializedGuid UnityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public SerializedGuid[] ReferencedUnityAssetIds;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Guid UnityAssetIdGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA39F3F0", Offset = "0xA39DDF0", VA = "0x18A39F3F0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA39F500", Offset = "0xA39DF00", VA = "0x18A39F500", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		private Guid ARJBHFQJFQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA39B840", Offset = "0xA39A240", VA = "0x18A39B840", Slot = "5")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		private Guid GDJPBGBRZKV
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xA39F3F0", Offset = "0xA39DDF0", VA = "0x18A39F3F0", Slot = "6")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		private IEnumerable<Guid> AOMUBPFDPOD
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA39F2B0", Offset = "0xA39DCB0", VA = "0x18A39F2B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA39F460", Offset = "0xA39DE60", VA = "0x18A39F460", Slot = "8")]
		public IStudioUnityAssetRegistrationEntry ToUnityAssetRegistrationEntry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public RecRoomStudioConsumableItemEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[AddComponentMenu(null)]
	public abstract class RecRoomStudioConsumableItemRegistryBase<TConsumableItemRegistryAsset> : RecRoomUnitySceneSystemBase where TConsumableItemRegistryAsset : RecRoomStudioConsumableItemRegistryAssetBase<TConsumableItemRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private static RecRoomStudioConsumableItemRegistryBase<TConsumableItemRegistryAsset> GMMEYIOKMTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		[ReadOnlyField]
		private TConsumableItemRegistryAsset entriesAsset;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public static RecRoomStudioConsumableItemRegistryBase<TConsumableItemRegistryAsset> LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x7088B40", Offset = "0x7087540", VA = "0x187088B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public TConsumableItemRegistryAsset HPEKGIKJKYW
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public IReadOnlyList<RecRoomStudioConsumableItemEntry> QOEALBIGTYT
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x79332E0", Offset = "0x7931CE0", VA = "0x1879332E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7933010", Offset = "0x7931A10", VA = "0x187933010")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7933150", Offset = "0x7931B50", VA = "0x187933150")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xCF27E0", Offset = "0xCF11E0", VA = "0x180CF27E0")]
		protected RecRoomStudioConsumableItemRegistryBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public abstract class RecRoomStudioDisableRenderInShareCamPhotoBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[Obfuscation(Exclude = true, ApplyToMembers = true)]
		public enum DisableRenderOptions
		{
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			NeverRender,
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			OnlyDisableForJunior
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private DisableRenderOptions renderOptions;

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public bool GYWLMDGWJXW
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x13C3780", Offset = "0x13C2180", VA = "0x1813C3780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		protected RecRoomStudioDisableRenderInShareCamPhotoBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public abstract class RecRoomStudioFunctionContainerBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		[HideInInspector]
		private StudioFunctionList studioFunctions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		[HideInInspector]
		private StudioPropertyList studioProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private IReadOnlyList<HOXGJBGBYOU> QHWTLQKRRTR;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public const string InputPortLabel = "Input Port";

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public const string InputParameterLabel = "Parameter";

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public const string OutputPortLabel = "Output Port";

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public const string OutputParameterLabel = "Return Value";

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public const string LocalVariablesLabel = "Local Variables";

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public const string LocalVariableLabel = "Local Variable";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private bool ZIVTGAAZWCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private ILookup<string, StudioFunction> FBYPUEPKEVL;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public IReadOnlyList<StudioFunction> OLKMJGIEIQN
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xA3A03B0", Offset = "0xA39EDB0", VA = "0x18A3A03B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public IReadOnlyList<StudioProperty> JCXSJMBMHZT
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xA3A03D0", Offset = "0xA39EDD0", VA = "0x18A3A03D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public IReadOnlyList<HOXGJBGBYOU> INPERPCZLNF
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public virtual bool KETMQYWOJBF
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public string DKESUQNEMHV
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0xA3A02D0", Offset = "0xA39ECD0", VA = "0x18A3A02D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public string EHAAOAIBPGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA3A0340", Offset = "0xA39ED40", VA = "0x18A3A0340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		private ILookup<string, StudioFunction> JDCXAMQKRLL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xA3A0190", Offset = "0xA39EB90", VA = "0x18A3A0190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA39F580", Offset = "0xA39DF80", VA = "0x18A39F580")]
		public void CallStudioFunction(string functionName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA39FCF0", Offset = "0xA39E6F0", VA = "0x18A39FCF0")]
		private void JVHCWXTLILU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA39FB10", Offset = "0xA39E510", VA = "0x18A39FB10")]
		public void InitializeValueStorage(IReadOnlyList<HOXGJBGBYOU> valueStorages)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA39F8F0", Offset = "0xA39E2F0", VA = "0x18A39F8F0")]
		public StudioFunction FindMatchingStudioFunction(QUSRARTNWPJ signature)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA39CFD0", Offset = "0xA39B9D0", VA = "0x18A39CFD0")]
		protected RecRoomStudioFunctionContainerBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public abstract class RecRoomStudioFunctionContainerListBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private RecRoomStudioFunctionContainerBase[] containerList;

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public IReadOnlyList<RecRoomStudioFunctionContainerBase> XSYJFDGDVRL
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xA3A0A10", Offset = "0xA39F410", VA = "0x18A3A0A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public int VFLTWDCSHJS
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xA3A0990", Offset = "0xA39F390", VA = "0x18A3A0990")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA3A07A0", Offset = "0xA39F1A0", VA = "0x18A3A07A0")]
		public IEnumerable<StudioFunction> GetSupportedStudioFunctions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA3A03F0", Offset = "0xA39EDF0", VA = "0x18A3A03F0")]
		public IReadOnlyDictionary<StudioFunction, IReadOnlyList<int>> GetStudioFunctionElementSupportMap()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		protected RecRoomStudioFunctionContainerListBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA3A0920", Offset = "0xA39F320", VA = "0x18A3A0920")]
		[CompilerGenerated]
		private bool JUASREHNCUP(KeyValuePair<StudioFunction, IReadOnlyList<int>> a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public abstract class RecRoomStudioHudCanvasBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		protected RecRoomStudioHudCanvasBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[Obfuscation(Exclude = true, ApplyToMembers = true)]
	public abstract class RecRoomStudioInstanceRecolorBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		[HideInInspector]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private MeshRenderer[] renderers;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly int instanceColorID;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public IReadOnlyList<MeshRenderer> Renderers
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xECCF90", Offset = "0xECB990", VA = "0x180ECCF90")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xA3A0D80", Offset = "0xA39F780", VA = "0x18A3A0D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA3A0A60", Offset = "0xA39F460", VA = "0x18A3A0A60")]
		private void ApplyColor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA3A0C30", Offset = "0xA39F630", VA = "0x18A3A0C30")]
		private void ClearColor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA3A0BD0", Offset = "0xA39F5D0", VA = "0x18A3A0BD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		protected RecRoomStudioInstanceRecolorBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class RecRoomStudioInteractionHandlerBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[Header("Settings")]
		[SerializeField]
		[Tooltip("On non-VR devices, determines if the button for this action is shown at all (actions must be supported and available in order to function on all platforms)")]
		private bool isSupported;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		[Tooltip("On non-VR devices, determines if the interaction button is shown as enabled or disabled (actions must be supported and available in order to function on all platforms)")]
		private bool isAvailable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		[Tooltip("Label for this interaction on non-VR, non-mobile platforms")]
		private string controlPrompt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		[Tooltip("Sprite for this interaction's button on mobile platforms")]
		private Sprite controlSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[Header("Events")]
		[SerializeField]
		[Tooltip("Event called when the action button first becomes pressed by the local player holding this object (note: actions must be supported and available in order for onActionPressed to be called)")]
		private UnityEvent onActionPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		[Tooltip("Event called when the action button becomes released by the local player holding this object (note: onActionReleased is always called if onActionPressed was originally called when the button first became pressed)")]
		private UnityEvent onActionReleased;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[Header("Screens Player Animations")]
		[SerializeField]
		[Tooltip("Animation that plays on a loop when this item is being held idly by a Screens player")]
		private RecRoomPlayerAnimation idleAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		[Tooltip("Animation that plays one time when the primary action is pressed")]
		private RecRoomPlayerAnimation pressedAnimation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		[Tooltip("Animation that plays one time when the primary action is released")]
		private RecRoomPlayerAnimation releasedAnimation;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public RecRoomPlayerAnimation CTYULZNRAKS
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public RecRoomPlayerAnimation VQFIAWMJOPU
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DE0", Offset = "0xCD57E0", VA = "0x180CD6DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public RecRoomPlayerAnimation QKMVXRXQXSJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C10", Offset = "0xCD5610", VA = "0x180CD6C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public bool CTJXZBRPUXC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xCD7520", Offset = "0xCD5F20", VA = "0x180CD7520")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C40", Offset = "0xCD5640", VA = "0x180CD6C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public bool DIJEUKABNLP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x15EBE20", Offset = "0x15EA820", VA = "0x1815EBE20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x15EB260", Offset = "0x15E9C60", VA = "0x1815EB260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public string WYXODQNJDKR
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xCD8620", Offset = "0xCD7020", VA = "0x180CD8620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Sprite SOAVRQCXYPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xCDF4B0", Offset = "0xCDDEB0", VA = "0x180CDF4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action FJEUVFRWZZK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xA3A0E50", Offset = "0xA39F850", VA = "0x18A3A0E50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xA3A0EF0", Offset = "0xA39F8F0", VA = "0x18A3A0EF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA3A0E00", Offset = "0xA39F800", VA = "0x18A3A0E00")]
		public void RaiseOnActionPressed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8A54DE0", Offset = "0x8A537E0", VA = "0x188A54DE0")]
		public void RaiseOnActionReleased()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA3A0E40", Offset = "0xA39F840", VA = "0x18A3A0E40")]
		protected RecRoomStudioInteractionHandlerBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[Obfuscation(Exclude = true, ApplyToMembers = true)]
	public abstract class RecRoomStudioPlatformTextFilterBase : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		private TMP_Text textMeshPro;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private string lastText;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public TMP_Text TextMeshPro
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public Action<string> SanitizeAndSetTextAction
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0xCD8620", Offset = "0xCD7020", VA = "0x180CD8620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA3A1780", Offset = "0xA3A0180", VA = "0x18A3A1780")]
		public void SetText(string text)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		protected RecRoomStudioPlatformTextFilterBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public abstract class RecRoomStudioRecNetImageBase : RawImage
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		[Tooltip("If true, the image will be automatically cropped into a square.")]
		private bool cropSquare;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private LSTNUJPDQVX QXNFNBYKYIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private WUSDBYRSNUV SCNSCTOWPHD;

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public WUSDBYRSNUV YGWTEAVAHFA
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xF4EB20", Offset = "0xF4D520", VA = "0x180F4EB20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x1718810", Offset = "0x1717210", VA = "0x181718810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public LSTNUJPDQVX MVRGWIALGAL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xEFA370", Offset = "0xEF8D70", VA = "0x180EFA370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0xA3A1890", Offset = "0xA3A0290", VA = "0x18A3A1890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public bool XVBIDFCIZBZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x109B4D0", Offset = "0x1099ED0", VA = "0x18109B4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA3A1820", Offset = "0xA3A0220", VA = "0x18A3A1820", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xA3A1880", Offset = "0xA3A0280", VA = "0x18A3A1880")]
		protected RecRoomStudioRecNetImageBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public abstract class RecRoomUnitySceneSystemBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		protected RecRoomUnitySceneSystemBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public abstract class RecRoomVisualPostProcessingBase : RecRoomUnitySceneSystemBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		[ReadOnlyField]
		public VolumeProfile PostProcessingProfile;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static RecRoomVisualPostProcessingBase GMMEYIOKMTD;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public static RecRoomVisualPostProcessingBase LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xA3A1B40", Offset = "0xA3A0540", VA = "0x18A3A1B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA3A1910", Offset = "0xA3A0310", VA = "0x18A3A1910")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA3A1A00", Offset = "0xA3A0400", VA = "0x18A3A1A00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		protected RecRoomVisualPostProcessingBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	internal static class DUBRMBNLJLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x38D4200", Offset = "0x38D2C00", VA = "0x1838D4200")]
		public static bool XSDWTJNRFEW<a>(a[] a, a[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x38D4170", Offset = "0x38D2B70", VA = "0x1838D4170")]
		public static bool XSDWTJNRFEW<b>(b[] a, b[] b, IEqualityComparer<b> c)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public static class LBHYBRYLOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3BC9560", Offset = "0x3BC7F60", VA = "0x183BC9560")]
		public static void Remove<TKey, TValue>(this IDictionary<TKey, TValue> self, TKey key, bool logErrorIfNotPresent, [Optional] Log? customLog) where TKey : notnull where TValue : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	[Obfuscation(Exclude = true)]
	public class ConditionallyEnabledFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA3964A0", Offset = "0xA394EA0", VA = "0x18A3964A0")]
		public ConditionallyEnabledFieldAttribute(string propertyName, bool propertyValue, string disabledTooltip)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public abstract class ConditionallyVisibleFieldAttributeBase : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA396500", Offset = "0xA394F00", VA = "0x18A396500")]
		protected ConditionallyVisibleFieldAttributeBase(string propertyName, bool isReadOnly)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	[Obfuscation(Exclude = true)]
	public class ConditionallyVisibleFieldAttribute : ConditionallyVisibleFieldAttributeBase
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA396550", Offset = "0xA394F50", VA = "0x18A396550")]
		public ConditionallyVisibleFieldAttribute(string propertyName, bool propertyValue, bool isReadOnly = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	[Obfuscation(Exclude = true)]
	public class IntConditionallyVisibleFieldAttribute : ConditionallyVisibleFieldAttributeBase
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA396D60", Offset = "0xA395760", VA = "0x18A396D60")]
		public IntConditionallyVisibleFieldAttribute(string propertyName, int propertyValue, bool isReadOnly = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public static class UCJZRHAXSSX
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		private interface BHVASEHYCFB
		{
			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			string MOZLNGURGUI
			{
				[Cpp2IlInjected.Token(Token = "0x60001F9")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			string POZLKPTCVSH
			{
				[Cpp2IlInjected.Token(Token = "0x60001FA")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000A8")]
			bool MMIVEYVCBVC
			{
				[Cpp2IlInjected.Token(Token = "0x60001FB")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000A9")]
			string? NYDUCPLAQTU
			{
				[Cpp2IlInjected.Token(Token = "0x60001FC")]
				[Cpp2IlInjected.Address(Slot = "3")]
				get;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		public sealed class NHWYKPXQXXU : BHVASEHYCFB
		{
			[Cpp2IlInjected.Token(Token = "0x170000AA")]
			public static string MOZLNGURGUI
			{
				[Cpp2IlInjected.Token(Token = "0x60001FD")]
				[Cpp2IlInjected.Address(RVA = "0xA399390", Offset = "0xA397D90", VA = "0x18A399390")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AB")]
			private string EPWWBDNVFSC
			{
				[Cpp2IlInjected.Token(Token = "0x60001FE")]
				[Cpp2IlInjected.Address(RVA = "0xA399390", Offset = "0xA397D90", VA = "0x18A399390", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AC")]
			private string BXAQBJOYFNX
			{
				[Cpp2IlInjected.Token(Token = "0x60001FF")]
				[Cpp2IlInjected.Address(RVA = "0xA3993C0", Offset = "0xA397DC0", VA = "0x18A3993C0", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AD")]
			private bool JGMZWIEYXMS
			{
				[Cpp2IlInjected.Token(Token = "0x6000200")]
				[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000AE")]
			private string? HYKDOAVIROM
			{
				[Cpp2IlInjected.Token(Token = "0x6000201")]
				[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public NHWYKPXQXXU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007F")]
		public sealed class FWDEDRCTKZU : BHVASEHYCFB
		{
			[Cpp2IlInjected.Token(Token = "0x170000AF")]
			public static string MOZLNGURGUI
			{
				[Cpp2IlInjected.Token(Token = "0x6000203")]
				[Cpp2IlInjected.Address(RVA = "0xA3965E0", Offset = "0xA394FE0", VA = "0x18A3965E0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B0")]
			private string EPWWBDNVFSC
			{
				[Cpp2IlInjected.Token(Token = "0x6000204")]
				[Cpp2IlInjected.Address(RVA = "0xA3965E0", Offset = "0xA394FE0", VA = "0x18A3965E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			private string BXAQBJOYFNX
			{
				[Cpp2IlInjected.Token(Token = "0x6000205")]
				[Cpp2IlInjected.Address(RVA = "0xA396610", Offset = "0xA395010", VA = "0x18A396610", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			private bool JGMZWIEYXMS
			{
				[Cpp2IlInjected.Token(Token = "0x6000206")]
				[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B3")]
			private string? HYKDOAVIROM
			{
				[Cpp2IlInjected.Token(Token = "0x6000207")]
				[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public FWDEDRCTKZU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000080")]
		public sealed class HLPSPSLMJHI : BHVASEHYCFB
		{
			[Cpp2IlInjected.Token(Token = "0x170000B4")]
			public static string MOZLNGURGUI
			{
				[Cpp2IlInjected.Token(Token = "0x6000209")]
				[Cpp2IlInjected.Address(RVA = "0xA396AE0", Offset = "0xA3954E0", VA = "0x18A396AE0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B5")]
			private string EPWWBDNVFSC
			{
				[Cpp2IlInjected.Token(Token = "0x600020A")]
				[Cpp2IlInjected.Address(RVA = "0xA396AE0", Offset = "0xA3954E0", VA = "0x18A396AE0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B6")]
			private string BXAQBJOYFNX
			{
				[Cpp2IlInjected.Token(Token = "0x600020B")]
				[Cpp2IlInjected.Address(RVA = "0xA396B10", Offset = "0xA395510", VA = "0x18A396B10", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B7")]
			private bool JGMZWIEYXMS
			{
				[Cpp2IlInjected.Token(Token = "0x600020C")]
				[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B8")]
			private string? HYKDOAVIROM
			{
				[Cpp2IlInjected.Token(Token = "0x600020D")]
				[Cpp2IlInjected.Address(RVA = "0xA396AB0", Offset = "0xA3954B0", VA = "0x18A396AB0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public HLPSPSLMJHI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly IReadOnlyList<string> SBXIFVFEQNX;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public static readonly IReadOnlyList<string> BUGUWOYHGVC;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public static readonly IReadOnlyList<bool> LGGIOCZDBRI;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public static readonly IReadOnlyList<string?> WGVCQCLXWEL;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static readonly IReadOnlyList<BHVASEHYCFB> QXSDRYTOOMG;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA3AB5D0", Offset = "0xA3A9FD0", VA = "0x18A3AB5D0")]
		static UCJZRHAXSSX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public interface WUSDBYRSNUV
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IHJQDRTXECW();

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CCGDTZMBOXI(LSTNUJPDQVX a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public interface EOJXYFKIYUL<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AttachMarkupComponent(a markupComponent, int componentIndex, bool isObjectReset);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class RecRoomObjectConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private bool isFrozen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		[ConditionallyEnabledField("isClimbable", false, "Is Grabbable can only be enabled if Is Climbable is not enabled")]
		private bool isGrabbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		[ConditionallyEnabledField("isGrabbable", false, "Is Climbable can only be enabled if Is Grabbable is not enabled")]
		private bool isClimbable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		private bool supportsWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		private bool supportsClambering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private RecRoomObjectPhysicsMode physicsMode;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xA39D2B0", Offset = "0xA39BCB0", VA = "0x18A39D2B0")]
		public RecRoomObjectConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[Obfuscation(Exclude = true, ApplyToMembers = true)]
	public enum RecRoomObjectPhysicsMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		Environment = 0,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		Decoration = 1,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		Physical = 4
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class RecRoomObjectProperty
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		private enum BoardConfig
		{
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			Show,
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			Hide
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		private string propertyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		private RecRoomObjectPropertyAccessor propertyAccessor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[SerializeField]
		private BoardConfig boardConfig;

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public string PropertyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3EB10A0", Offset = "0x3EAFAA0", VA = "0x183EB10A0")]
		public bool RRJZBUUOGPY<a>([Out] a a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA39D5B0", Offset = "0xA39BFB0", VA = "0x18A39D5B0")]
		public static string RVJFOOTHZGB(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public RecRoomObjectProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class RecRoomObjectPropertyAccessor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public string targetAssemblyTypeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public string propertyMethodName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private MethodInfo TQFMWJVPOLO;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		private string WWWJEMOTGBK
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0xA39D4D0", Offset = "0xA39BED0", VA = "0x18A39D4D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA39D540", Offset = "0xA39BF40", VA = "0x18A39D540")]
		public MethodInfo QLBCQEYMWOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA39D3E0", Offset = "0xA39BDE0", VA = "0x18A39D3E0")]
		public string CAHDACRYIOW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public RecRoomObjectPropertyAccessor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public abstract class RecRoomStudioAutoCreatedAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0xD6AE70", Offset = "0xD69870", VA = "0x180D6AE70")]
		protected RecRoomStudioAutoCreatedAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public class RecRoomStudioAutoGeneratedAsset<AssetType> : ScriptableObject where AssetType : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xD6AE70", Offset = "0xD69870", VA = "0x180D6AE70")]
		public RecRoomStudioAutoGeneratedAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[Obfuscation(Exclude = true, ApplyToMembers = true)]
	public abstract class RecRoomStudioNavMeshCutBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public const float MINIMUM_WIDTH = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		[HideInInspector]
		[Obsolete]
		private float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		[HideInInspector]
		[Obsolete]
		private float height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[Comment("When using a Nav Mesh Cut, you may also want to set NavMesh Generation Mode to Ignore in the configure menu so the associated Rec Room Object won't bake into the navmesh on its own.")]
		[SerializeField]
		private Vector3 size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[SerializeField]
		private Vector3 center;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[Header("Optimization")]
		[SerializeField]
		[Comment("Ignoring rotation leads to better performance, but ignoring rotation also means that the box must be aligned with the X, Y, and Z axes.")]
		private bool ignoreRotationAndScale;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		[Obsolete]
		public float Radius
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0xA3A12E0", Offset = "0xA39FCE0", VA = "0x18A3A12E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0xA3A1600", Offset = "0xA3A0000", VA = "0x18A3A1600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		[Obsolete]
		public float Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xE60CA0", Offset = "0xE5F6A0", VA = "0x180E60CA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0xA3A1560", Offset = "0xA39FF60", VA = "0x18A3A1560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public bool IgnoreRotationAndScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xF54E40", Offset = "0xF53840", VA = "0x180F54E40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0xA3A15E0", Offset = "0xA39FFE0", VA = "0x18A3A15E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3 Size
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0xEA9E80", Offset = "0xEA8880", VA = "0x180EA9E80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xA3A1680", Offset = "0xA3A0080", VA = "0x18A3A1680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public float HeightSizeY
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0xE60CA0", Offset = "0xE5F6A0", VA = "0x180E60CA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0xA3A1560", Offset = "0xA39FF60", VA = "0x18A3A1560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public float XZUniformSquareSize
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xA3A1700", Offset = "0xA3A0100", VA = "0x18A3A1700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public Vector3 Center
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xEA9EA0", Offset = "0xEA88A0", VA = "0x180EA9EA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0xA3A14E0", Offset = "0xA39FEE0", VA = "0x18A3A14E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action OnSettingsChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xA3A1240", Offset = "0xA39FC40", VA = "0x18A3A1240")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xA3A1440", Offset = "0xA39FE40", VA = "0x18A3A1440")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action OnForceUpdate
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xA3A11A0", Offset = "0xA39FBA0", VA = "0x18A3A11A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xA3A13A0", Offset = "0xA39FDA0", VA = "0x18A3A13A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<bool> OnEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xA3A10F0", Offset = "0xA39FAF0", VA = "0x18A3A10F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xA3A12F0", Offset = "0xA39FCF0", VA = "0x18A3A12F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xA3A0F90", Offset = "0xA39F990", VA = "0x18A3A0F90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x10828B0", Offset = "0x10812B0", VA = "0x1810828B0")]
		[Obsolete]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x10828B0", Offset = "0x10812B0", VA = "0x1810828B0")]
		public void ForceQueueUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xA3A1080", Offset = "0xA39FA80", VA = "0x18A3A1080")]
		public void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xA3A1080", Offset = "0xA39FA80", VA = "0x18A3A1080")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xA3A10C0", Offset = "0xA39FAC0", VA = "0x18A3A10C0")]
		protected RecRoomStudioNavMeshCutBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public struct RoomData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public byte[] Payload;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xEC0C30", Offset = "0xEBF630", VA = "0x180EC0C30")]
		public RoomData(byte[] payload)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public struct SubRoomData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public byte[] Payload;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0xEC0C30", Offset = "0xEBF630", VA = "0x180EC0C30")]
		public SubRoomData(byte[] payload)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public static class KRZKZIXMTQT
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0xA397C70", Offset = "0xA396670", VA = "0x18A397C70")]
		public static (RoomData, SubRoomData, IReadOnlyCollection<Guid>) LPJCANPNMLB(Stream a)
		{
			return default((RoomData, SubRoomData, IReadOnlyCollection<Guid>));
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xA397800", Offset = "0xA396200", VA = "0x18A397800")]
		public static void GSFSQTOIDPS(Stream a, RoomData b, SubRoomData c, IReadOnlyCollection<Guid> d)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private Guid OBUKYMDCNTG;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x2E05180", Offset = "0x2E03B80", VA = "0x182E05180")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x74B8BF0", Offset = "0x74B75F0", VA = "0x1874B8BF0")]
		public SerializedGuid([In] Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x98172F0", Offset = "0x9815CF0", VA = "0x1898172F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0xA3A4F10", Offset = "0xA3A3910", VA = "0x18A3A4F10", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x9817050", Offset = "0x9815A50", VA = "0x189817050", Slot = "7")]
		public bool Equals(SerializedGuid other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0xA3A4E80", Offset = "0xA3A3880", VA = "0x18A3A4E80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x9817120", Offset = "0x9815B20", VA = "0x189817120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x9817020", Offset = "0x9815A20", VA = "0x189817020", Slot = "6")]
		public int CompareTo(SerializedGuid other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xA3A4F90", Offset = "0xA3A3990", VA = "0x18A3A4F90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[AttributeUsage(AttributeTargets.Class)]
	[Obfuscation(Exclude = true)]
	public class SerializedTypeNameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
		public SerializedTypeNameAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public static class TMVMPGPYQVR<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		public struct ArrayHandle : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public readonly a[] Array;

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xEC0C30", Offset = "0xEBF630", VA = "0x180EC0C30")]
			public ArrayHandle(a[] array)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x7562860", Offset = "0x7561260", VA = "0x187562860", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly ConcurrentDictionary<int, ConcurrentStack<a[]>> XYHOSHONOQV;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x7B54610", Offset = "0x7B53010", VA = "0x187B54610")]
		public static void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x7B54400", Offset = "0x7B52E00", VA = "0x187B54400")]
		public static ArrayHandle BYGHRXBYCRB(int a)
		{
			return default(ArrayHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x7B54BC0", Offset = "0x7B535C0", VA = "0x187B54BC0")]
		private static void Release(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public static class NNCWRPIOLZZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public static readonly Log WARJEEODAWQ;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public static readonly Log QLQAXOGQTYM;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public static readonly Log KTJIOOTJFNS;

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public static readonly Log FWVORDFDFHR;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public static readonly Log KZJRFUPOCIW;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public static readonly Log XOLPZGPHHFV;
	}
}
namespace RecRoom.Core.Studio.StudioFunctions
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Argument
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeReference]
		private Variable binding;

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public Variable Binding
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public abstract Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public abstract object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public Argument()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		public Argument(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA3910F0", Offset = "0xA38FAF0", VA = "0x18A3910F0")]
		public object UCUWYVGIJCN(VAORNXAUWIV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xA391040", Offset = "0xA38FA40", VA = "0x18A391040")]
		internal void PFBLMABROUA(IReadOnlyList<Variable> a, IReadOnlyList<Variable> b, IReadOnlyList<Variable> c)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Argument<T> : Argument
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		protected T defaultValue;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x7560510", Offset = "0x755EF10", VA = "0x187560510", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
		protected Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[UnityEngine.Scripting.Preserve]
	public sealed class VoidArgument : Argument
	{
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public static readonly VoidArgument Instance;

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0xA39B3A0", Offset = "0xA399DA0", VA = "0x18A39B3A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0xA3AC5F0", Offset = "0xA3AAFF0", VA = "0x18A3AC5F0")]
		private VoidArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ValueArgument<T> : Argument<T>
	{
		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x53D2890", Offset = "0x53D1290", VA = "0x1853D2890", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7C92610", Offset = "0x7C91010", VA = "0x187C92610")]
		protected ValueArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ClassArgument<T> : Argument<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		protected string valueTypeAssemblyQualifiedName;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private Type AUOGZUOIXEL;

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x5062F70", Offset = "0x5061970", VA = "0x185062F70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5062C00", Offset = "0x5061600", VA = "0x185062C00")]
		private Type JFBGCSSQIMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5062EA0", Offset = "0x50618A0", VA = "0x185062EA0")]
		protected ClassArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ObjectArgument : ClassArgument<object>
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xA39B360", Offset = "0xA399D60", VA = "0x18A39B360")]
		public ObjectArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[UnityEngine.Scripting.Preserve]
	public sealed class BoolArgument : ValueArgument<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA391690", Offset = "0xA390090", VA = "0x18A391690")]
		public BoolArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ColorArgument : ValueArgument<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xA395600", Offset = "0xA394000", VA = "0x18A395600")]
		public ColorArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Color32Argument : ValueArgument<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xA395500", Offset = "0xA393F00", VA = "0x18A395500")]
		public Color32Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[UnityEngine.Scripting.Preserve]
	public sealed class GuidArgument : ValueArgument<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xA396A70", Offset = "0xA395470", VA = "0x18A396A70")]
		public GuidArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[UnityEngine.Scripting.Preserve]
	public sealed class FloatArgument : ValueArgument<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xA3967F0", Offset = "0xA3951F0", VA = "0x18A3967F0")]
		public FloatArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[UnityEngine.Scripting.Preserve]
	public sealed class IntArgument : ValueArgument<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA396D20", Offset = "0xA395720", VA = "0x18A396D20")]
		public IntArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ShortArgument : ValueArgument<short>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xA3A4FA0", Offset = "0xA3A39A0", VA = "0x18A3A4FA0")]
		public ShortArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StringArgument : ValueArgument<string>
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xA3A4FE0", Offset = "0xA3A39E0", VA = "0x18A3A4FE0")]
		public StringArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UIntArgument : ValueArgument<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xA3ABAA0", Offset = "0xA3AA4A0", VA = "0x18A3ABAA0")]
		public UIntArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UShortArgument : ValueArgument<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xA3ABAE0", Offset = "0xA3AA4E0", VA = "0x18A3ABAE0")]
		public UShortArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector2Argument : ValueArgument<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xA3AC2B0", Offset = "0xA3AACB0", VA = "0x18A3AC2B0")]
		public Vector2Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector3Argument : ValueArgument<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA3AC3B0", Offset = "0xA3AADB0", VA = "0x18A3AC3B0")]
		public Vector3Argument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[UnityEngine.Scripting.Preserve]
	public sealed class QuaternionArgument : ValueArgument<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA39B3E0", Offset = "0xA399DE0", VA = "0x18A39B3E0")]
		public QuaternionArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[UnityEngine.Scripting.Preserve]
	public sealed class UnityObjectArgument : ClassArgument<UnityEngine.Object>
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0xA3ABBE0", Offset = "0xA3AA5E0", VA = "0x18A3ABBE0")]
		public UnityObjectArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[UnityEngine.Scripting.Preserve]
	public sealed class RecNetImageArgument : ValueArgument<LSTNUJPDQVX>
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xA39B4F0", Offset = "0xA399EF0", VA = "0x18A39B4F0")]
		public RecNetImageArgument()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void Invoke(string functionName, VAORNXAUWIV variableStorage);

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected internal abstract void URLOBUZRBSB(IReadOnlyList<Variable> a, IReadOnlyList<Variable> b, IReadOnlyList<Variable> c, IReadOnlyList<Variable> d);

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		protected Instruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[UnityEngine.Scripting.Preserve]
	public sealed class PlaceholderInstruction : Instruction
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
		public override void Invoke(string functionName, VAORNXAUWIV variableStorage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
		protected internal override void URLOBUZRBSB(IReadOnlyList<Variable> a, IReadOnlyList<Variable> b, IReadOnlyList<Variable> c, IReadOnlyList<Variable> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public PlaceholderInstruction()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[UnityEngine.Scripting.Preserve]
	public sealed class CallInstruction : Instruction, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x20000AE")]
		private enum CallInstructionVersion
		{
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			Initial = 0,
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			UpgradeToIdentifyingNameAndMultipleReturns = 1,
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			LatestPlusOne = 2,
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			Latest = 1
		}

		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		private delegate void Optimization(UnityEngine.Object target, OXQNDYHMBWH methodInfo, object[] argumentValues);

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private UnityEngine.Object target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		[HideInInspector]
		private CallInstructionVersion version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private string identifyingName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeReference]
		private Argument[] arguments;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeReference]
		[Obsolete("Multiple results are supported, and a single `result` is now stored in the `results` array as of version UpgradeToIdentifyingNameAndMultipleReturns")]
		private Argument result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeReference]
		private Argument[] results;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private OXQNDYHMBWH GWIWGBIAACL;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public static readonly OXQNDYHMBWH InvalidMethodInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private Optimization SFSLTYNRTOT;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private static readonly OXQNDYHMBWH EWOFCTVHWCE;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private static readonly OXQNDYHMBWH DEKIRLHJOZY;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private static readonly OXQNDYHMBWH NQYOQRJHMXQ;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private static readonly OXQNDYHMBWH EMWXBPRXVSE;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private static readonly OXQNDYHMBWH INUAIXPIUYQ;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private static readonly OXQNDYHMBWH PNECIOOMEXE;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private static readonly OXQNDYHMBWH ILYKOVLSRSG;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static readonly OXQNDYHMBWH LMXONKNPFVW;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private static readonly Dictionary<OXQNDYHMBWH, Optimization> PURGBIUOFHW;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private static readonly Dictionary<string, int> VDUUMDDXDUR;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA395470", Offset = "0xA393E70", VA = "0x18A395470")]
		public CallInstruction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xA391DD0", Offset = "0xA3907D0", VA = "0x18A391DD0", Slot = "4")]
		public override void Invoke(string functionName, VAORNXAUWIV variableStorage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA393F50", Offset = "0xA392950", VA = "0x18A393F50")]
		private void RUTWEIJAOOK(VAORNXAUWIV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xA393A50", Offset = "0xA392450", VA = "0x18A393A50")]
		private void QENZZGRMVVB(VAORNXAUWIV a, object[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA394020", Offset = "0xA392A20", VA = "0x18A394020", Slot = "5")]
		protected internal override void URLOBUZRBSB(IReadOnlyList<Variable> a, IReadOnlyList<Variable> b, IReadOnlyList<Variable> c, IReadOnlyList<Variable> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA393DE0", Offset = "0xA3927E0", VA = "0x18A393DE0")]
		[UnityEngine.Scripting.Preserve]
		private static void RJBFSIESJOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xA393C30", Offset = "0xA392630", VA = "0x18A393C30")]
		private OXQNDYHMBWH RGFGNLQQNNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xA394110", Offset = "0xA392B10", VA = "0x18A394110")]
		internal OXQNDYHMBWH XEVPGZISLEQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xA392D10", Offset = "0xA391710", VA = "0x18A392D10")]
		internal static bool ODWQBZRPXUB(UnityEngine.Object a, string b, Argument[] c, Argument[] d, [Out] OXQNDYHMBWH e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA392700", Offset = "0xA391100", VA = "0x18A392700")]
		private static bool MPNYXTUNZFX(StudioFunction a, Type[] b, int c, Argument[] d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA392A90", Offset = "0xA391490", VA = "0x18A392A90")]
		private static bool MPNYXTUNZFX(MethodInfo a, Type[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xA392BA0", Offset = "0xA3915A0", VA = "0x18A392BA0")]
		private TMVMPGPYQVR<object>.ArrayHandle NRLRBHXPKXJ(VAORNXAUWIV a)
		{
			return default(TMVMPGPYQVR<object>.ArrayHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xA393E30", Offset = "0xA392830", VA = "0x18A393E30")]
		private static void RSTQELPMEXO(UnityEngine.Object a, OXQNDYHMBWH b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA391CB0", Offset = "0xA3906B0", VA = "0x18A391CB0")]
		private static void HKIIZLJWUDU(UnityEngine.Object a, OXQNDYHMBWH b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA391B90", Offset = "0xA390590", VA = "0x18A391B90")]
		private static void ELWXOKPAPWE(UnityEngine.Object a, OXQNDYHMBWH b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA393B10", Offset = "0xA392510", VA = "0x18A393B10")]
		private static void QFUJCALOZOC(UnityEngine.Object a, OXQNDYHMBWH b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA3941B0", Offset = "0xA392BB0", VA = "0x18A3941B0")]
		private static OXQNDYHMBWH XKXSPKUVLXO(Type a, string b, params Type[] parameterTypes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xA393790", Offset = "0xA392190", VA = "0x18A393790")]
		private static int OVSIKSFXADH(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xA392680", Offset = "0xA391080", VA = "0x18A392680")]
		public static void MOQLRLHEZYO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "6")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xA393880", Offset = "0xA392280", VA = "0x18A393880", Slot = "7")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ConditionalInstruction : Instruction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeReference]
		private Variable binding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private Condition[] conditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeReference]
		private Instruction[] @default;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA396420", Offset = "0xA394E20", VA = "0x18A396420")]
		public ConditionalInstruction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA395CA0", Offset = "0xA3946A0", VA = "0x18A395CA0", Slot = "4")]
		public override void Invoke(string functionName, VAORNXAUWIV variableStorage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA396140", Offset = "0xA394B40", VA = "0x18A396140", Slot = "5")]
		protected internal override void URLOBUZRBSB(IReadOnlyList<Variable> a, IReadOnlyList<Variable> b, IReadOnlyList<Variable> c, IReadOnlyList<Variable> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xA396090", Offset = "0xA394A90", VA = "0x18A396090")]
		private void PFBLMABROUA(IReadOnlyList<Variable> a, IReadOnlyList<Variable> b, IReadOnlyList<Variable> c)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Condition
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeReference]
		private Instruction[] instructions;

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public IReadOnlyList<Instruction> Instructions
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0xA395C50", Offset = "0xA394650", VA = "0x18A395C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA395BE0", Offset = "0xA3945E0", VA = "0x18A395BE0")]
		public Condition()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xA395B00", Offset = "0xA394500", VA = "0x18A395B00")]
		public static bool SCRXJAEFGVM(string a, [Out] bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA395A00", Offset = "0xA394400", VA = "0x18A395A00")]
		public static bool PIIAJDIZKNZ(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA395870", Offset = "0xA394270", VA = "0x18A395870")]
		public bool FZTTDMSSFGT(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xA395790", Offset = "0xA394190", VA = "0x18A395790")]
		public bool BDRFDJOJMKM(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xA395AE0", Offset = "0xA3944E0", VA = "0x18A395AE0")]
		public bool QSABULZXRXQ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xA395980", Offset = "0xA394380", VA = "0x18A395980")]
		public void Invoke(string functionName, VAORNXAUWIV variableStorage)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public interface QUSRARTNWPJ
	{
		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		IReadOnlyList<Parameter> Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		IReadOnlyList<Parameter> Results
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public enum LateBoundMethodCategory
	{
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		PropertyGetter,
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		PropertySetter,
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		Method,
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		StudioFunction
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public abstract class OXQNDYHMBWH
	{
		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		private sealed class LQDTFSYTFHY : OXQNDYHMBWH
		{
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			private const string JEFCSJHWHOM = "get_";

			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			private const string PXFZLINTBOI = "set_";

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			private readonly MethodInfo MOQOOIBITHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			private readonly string MCSZYZZCRNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			private readonly LateBoundMethodCategory GSLCWCNGNUS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			private JAQVJLHBCVU[]? FANVKXYHELA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			private JAQVJLHBCVU[]? XVTAKJJJNQI;

			[Cpp2IlInjected.Token(Token = "0x170000D0")]
			public override string EREWIERIFZH
			{
				[Cpp2IlInjected.Token(Token = "0x60002B3")]
				[Cpp2IlInjected.Address(RVA = "0x99A92D0", Offset = "0x99A7CD0", VA = "0x1899A92D0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xA398110", Offset = "0xA396B10", VA = "0x18A398110", Slot = "5")]
			public override TMVMPGPYQVR<object?>.ArrayHandle Invoke(object? target, object[]? args)
			{
				return default(TMVMPGPYQVR<object>.ArrayHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0xA3980A0", Offset = "0xA396AA0", VA = "0x18A3980A0", Slot = "6")]
			protected override bool HARMWTBCOVG(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x2B78810", Offset = "0x2B77210", VA = "0x182B78810", Slot = "7")]
			protected override int QYWXBQSNYGM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0xA398290", Offset = "0xA396C90", VA = "0x18A398290")]
			public LQDTFSYTFHY(MethodInfo a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private static readonly ConditionalWeakTable<MethodInfo, LQDTFSYTFHY> ZDDAYXVXSFG;

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public abstract string EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract TMVMPGPYQVR<object?>.ArrayHandle Invoke(object? target, object[]? args);

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract bool HARMWTBCOVG(object a);

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract int QYWXBQSNYGM();

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xA39B260", Offset = "0xA399C60", VA = "0x18A39B260")]
		public static bool VPGVCSNEDTU(OXQNDYHMBWH a, OXQNDYHMBWH b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xA39B0D0", Offset = "0xA399AD0", VA = "0x18A39B0D0")]
		public static bool AIMXGJJQCKF(OXQNDYHMBWH a, OXQNDYHMBWH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x87FBC80", Offset = "0x87FA680", VA = "0x1887FBC80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x88D2980", Offset = "0x88D1380", VA = "0x1888D2980", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xA39B140", Offset = "0xA399B40", VA = "0x18A39B140")]
		public static OXQNDYHMBWH SRUOIPIWJST(MethodInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		protected OXQNDYHMBWH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public abstract class JAQVJLHBCVU
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		protected JAQVJLHBCVU()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StudioFunction : QUSRARTNWPJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		private abstract class KKQFKOGSCGK<a> : OXQNDYHMBWH where a : notnull, QUSRARTNWPJ
		{
			[Cpp2IlInjected.Token(Token = "0x20000BA")]
			private sealed class STSBSIVQTEY : JAQVJLHBCVU
			{
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			private readonly a GQPTTQJULRW;

			[Cpp2IlInjected.Token(Token = "0x170000D8")]
			protected a IBCGGOLDXAI
			{
				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D9")]
			public override string EREWIERIFZH
			{
				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x65ECC40", Offset = "0x65EB640", VA = "0x1865ECC40", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x68034C0", Offset = "0x6801EC0", VA = "0x1868034C0")]
			protected KKQFKOGSCGK(a a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x6803080", Offset = "0x6801A80", VA = "0x186803080")]
			private static string JCRPYLYDFUS(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x68033E0", Offset = "0x6801DE0", VA = "0x1868033E0", Slot = "8")]
			protected virtual string ZBEOBVALZDD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x6802F30", Offset = "0x6801930", VA = "0x186802F30", Slot = "6")]
			protected override bool HARMWTBCOVG(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x68030C0", Offset = "0x6801AC0", VA = "0x1868030C0", Slot = "7")]
			protected override int QYWXBQSNYGM()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		private sealed class SONCIKDAKCN : KKQFKOGSCGK<StudioFunction>
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4E30", Offset = "0xA3A3830", VA = "0x18A3A4E30")]
			public SONCIKDAKCN(StudioFunction a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4D20", Offset = "0xA3A3720", VA = "0x18A3A4D20", Slot = "5")]
			public override TMVMPGPYQVR<object?>.ArrayHandle Invoke(object? target, object[]? args)
			{
				return default(TMVMPGPYQVR<object>.ArrayHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		private sealed class SIAFCSGGBHA : KKQFKOGSCGK<QUSRARTNWPJ>
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4CD0", Offset = "0xA3A36D0", VA = "0x18A3A4CD0")]
			public SIAFCSGGBHA(QUSRARTNWPJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4C00", Offset = "0xA3A3600", VA = "0x18A3A4C00")]
			private static string JCRPYLYDFUS(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4C40", Offset = "0xA3A3640", VA = "0x18A3A4C40", Slot = "8")]
			protected override string ZBEOBVALZDD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4860", Offset = "0xA3A3260", VA = "0x18A3A4860", Slot = "5")]
			public override TMVMPGPYQVR<object?>.ArrayHandle Invoke(object? target, object[]? args)
			{
				return default(TMVMPGPYQVR<object>.ArrayHandle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		private sealed class BCKHGKHNUCN : KKQFKOGSCGK<QUSRARTNWPJ>
		{
			[Cpp2IlInjected.Token(Token = "0x20000BE")]
			private class PZVGPVGZQDX : JAQVJLHBCVU
			{
				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
				public PZVGPVGZQDX()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0xA391640", Offset = "0xA390040", VA = "0x18A391640")]
			public BCKHGKHNUCN(QUSRARTNWPJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xA391570", Offset = "0xA38FF70", VA = "0x18A391570")]
			private static string JCRPYLYDFUS(string a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0xA3915B0", Offset = "0xA38FFB0", VA = "0x18A3915B0", Slot = "8")]
			protected override string ZBEOBVALZDD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xA391140", Offset = "0xA38FB40", VA = "0x18A391140", Slot = "5")]
			public override TMVMPGPYQVR<object?>.ArrayHandle Invoke(object? target, object[]? args)
			{
				return default(TMVMPGPYQVR<object>.ArrayHandle);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private OXQNDYHMBWH? VQGRTVCCDIZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private OXQNDYHMBWH? OSHYNZOEJMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private OXQNDYHMBWH? HCXKWHDYXKX;

		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private static bool BSINXRIUESJ;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private static int NITYMQOQHAD;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private static int RONBYFWGOHZ;

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public const int MaximumStackDepth = 100;

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private const int XWGDWELTGAN = 10000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[SerializeField]
		private string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[SerializeReference]
		private Parameter[] parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[SerializeReference]
		private Parameter[] results;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[SerializeReference]
		private LocalVariable[] localVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		[SerializeReference]
		private Instruction[] instructions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private bool PQHREOUSGYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private RecRoomStudioFunctionContainerBase GDRCJLXUCSC;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public OXQNDYHMBWH Method
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0xA3AA710", Offset = "0xA3A9110", VA = "0x18A3AA710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public OXQNDYHMBWH ListAtIndexMethod
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xA3AA5A0", Offset = "0xA3A8FA0", VA = "0x18A3AA5A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public OXQNDYHMBWH ListForEachMethod
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xA3AA630", Offset = "0xA3A9030", VA = "0x18A3AA630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x88CDBD0", Offset = "0x88CC5D0", VA = "0x1888CDBD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public IReadOnlyList<Parameter> Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xA3AA7A0", Offset = "0xA3A91A0", VA = "0x18A3AA7A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public IReadOnlyList<Parameter> Results
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xA3AA7F0", Offset = "0xA3A91F0", VA = "0x18A3AA7F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public IReadOnlyList<LocalVariable> LocalVariables
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xA3AA6C0", Offset = "0xA3A90C0", VA = "0x18A3AA6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA3AA4C0", Offset = "0xA3A8EC0", VA = "0x18A3AA4C0")]
		public StudioFunction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xA3A9170", Offset = "0xA3A7B70", VA = "0x18A3A9170")]
		public static void ELKBGTGXCPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xA3A9250", Offset = "0xA3A7C50", VA = "0x18A3A9250")]
		public void FXAPFBHUXPB(RecRoomStudioFunctionContainerBase a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA3A9A70", Offset = "0xA3A8470", VA = "0x18A3A9A70")]
		public void Invoke(object[] parameterValues, object[] resultValues)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xA3AA0C0", Offset = "0xA3A8AC0", VA = "0x18A3AA0C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xA3A9320", Offset = "0xA3A7D20", VA = "0x18A3A9320")]
		private void IUONXWBSXPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xA3AA3C0", Offset = "0xA3A8DC0", VA = "0x18A3AA3C0")]
		private void URLOBUZRBSB()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[UnityEngine.Scripting.Preserve]
	public abstract class LocalVariable : Variable
	{
		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public abstract object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x166B830", Offset = "0x166A230", VA = "0x18166B830")]
		protected LocalVariable()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[UnityEngine.Scripting.Preserve]
	public sealed class PlaceholderLocalVariable : LocalVariable
	{
		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xA39B3A0", Offset = "0xA399DA0", VA = "0x18A39B3A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "5")]
			get
			{
				return null;
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[UnityEngine.Scripting.Preserve]
	public abstract class LocalVariable<T> : LocalVariable
	{
		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x6FF7850", Offset = "0x6FF6250", VA = "0x186FF7850", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7690", Offset = "0x6FF6090", VA = "0x186FF7690")]
		protected LocalVariable()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ValueLocalVariable<T> : LocalVariable<T>
	{
		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x53D2890", Offset = "0x53D1290", VA = "0x1853D2890", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8042CB0", Offset = "0x80416B0", VA = "0x188042CB0")]
		protected ValueLocalVariable()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ClassLocalVariable<T> : LocalVariable<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[SerializeField]
		private string valueTypeFullName;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private Type AUOGZUOIXEL;

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x5063090", Offset = "0x5061A90", VA = "0x185063090", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x5062FC0", Offset = "0x50619C0", VA = "0x185062FC0")]
		private Type JFBGCSSQIMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x5063070", Offset = "0x5061A70", VA = "0x185063070")]
		protected ClassLocalVariable()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[UnityEngine.Scripting.Preserve]
	public sealed class BoolLocalVariable : ValueLocalVariable<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA3916D0", Offset = "0xA3900D0", VA = "0x18A3916D0")]
		public BoolLocalVariable()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ColorLocalVariable : ValueLocalVariable<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA395640", Offset = "0xA394040", VA = "0x18A395640")]
		public ColorLocalVariable()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Color32LocalVariable : ValueLocalVariable<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA395540", Offset = "0xA393F40", VA = "0x18A395540")]
		public Color32LocalVariable()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[UnityEngine.Scripting.Preserve]
	public sealed class FloatLocalVariable : ValueLocalVariable<float>
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA396830", Offset = "0xA395230", VA = "0x18A396830")]
		public FloatLocalVariable()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[UnityEngine.Scripting.Preserve]
	public sealed class IntLocalVariable : ValueLocalVariable<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA396DC0", Offset = "0xA3957C0", VA = "0x18A396DC0")]
		public IntLocalVariable()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StringLocalVariable : ValueLocalVariable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5020", Offset = "0xA3A3A20", VA = "0x18A3A5020")]
		public StringLocalVariable()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector2LocalVariable : ValueLocalVariable<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xA3AC2F0", Offset = "0xA3AACF0", VA = "0x18A3AC2F0")]
		public Vector2LocalVariable()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector3LocalVariable : ValueLocalVariable<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xA3AC3F0", Offset = "0xA3AADF0", VA = "0x18A3AC3F0")]
		public Vector3LocalVariable()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[UnityEngine.Scripting.Preserve]
	public sealed class QuaternionLocalVariable : ValueLocalVariable<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA39B420", Offset = "0xA399E20", VA = "0x18A39B420")]
		public QuaternionLocalVariable()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[UnityEngine.Scripting.Preserve]
	public sealed class RecNetImageLocalVariable : ValueLocalVariable<LSTNUJPDQVX>
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA39B530", Offset = "0xA399F30", VA = "0x18A39B530")]
		public RecNetImageLocalVariable()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Parameter : Variable
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private bool QEPFMAKSFVF;

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public bool IsOutput
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0xCD7520", Offset = "0xCD5F20", VA = "0x180CD7520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x166B830", Offset = "0x166A230", VA = "0x18166B830")]
		protected Parameter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xCD6C40", Offset = "0xCD5640", VA = "0x180CD6C40")]
		internal void ZQCEFSGXENJ(bool a)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[UnityEngine.Scripting.Preserve]
	public sealed class PlaceholderParameter : Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0xA39B3A0", Offset = "0xA399DA0", VA = "0x18A39B3A0", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Parameter<T> : Parameter
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6FF7690", Offset = "0x6FF6090", VA = "0x186FF7690")]
		protected Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ValueParameter<T> : Parameter<T>
	{
		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x53D2890", Offset = "0x53D1290", VA = "0x1853D2890", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8042CB0", Offset = "0x80416B0", VA = "0x188042CB0")]
		protected ValueParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ClassParameter<T> : Parameter<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[SerializeField]
		private string valueTypeFullName;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private Type AUOGZUOIXEL;

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x50631A0", Offset = "0x5061BA0", VA = "0x1850631A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x50630F0", Offset = "0x5061AF0", VA = "0x1850630F0")]
		private Type JFBGCSSQIMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x5063070", Offset = "0x5061A70", VA = "0x185063070")]
		protected ClassParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[UnityEngine.Scripting.Preserve]
	public sealed class BoolParameter : ValueParameter<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA391710", Offset = "0xA390110", VA = "0x18A391710")]
		public BoolParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ColorParameter : ValueParameter<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA395680", Offset = "0xA394080", VA = "0x18A395680")]
		public ColorParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Color32Parameter : ValueParameter<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA395580", Offset = "0xA393F80", VA = "0x18A395580")]
		public Color32Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[UnityEngine.Scripting.Preserve]
	public sealed class FloatParameter : ValueParameter<float>
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA396870", Offset = "0xA395270", VA = "0x18A396870")]
		public FloatParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[UnityEngine.Scripting.Preserve]
	public sealed class IntParameter : ValueParameter<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA396E00", Offset = "0xA395800", VA = "0x18A396E00")]
		public IntParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StringParameter : ValueParameter<string>
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5060", Offset = "0xA3A3A60", VA = "0x18A3A5060")]
		public StringParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector2Parameter : ValueParameter<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA3AC330", Offset = "0xA3AAD30", VA = "0x18A3AC330")]
		public Vector2Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector3Parameter : ValueParameter<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA3AC430", Offset = "0xA3AAE30", VA = "0x18A3AC430")]
		public Vector3Parameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[UnityEngine.Scripting.Preserve]
	public sealed class QuaternionParameter : ValueParameter<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA39B460", Offset = "0xA399E60", VA = "0x18A39B460")]
		public QuaternionParameter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[UnityEngine.Scripting.Preserve]
	public sealed class RecNetImageParameter : ValueParameter<LSTNUJPDQVX>
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA39B570", Offset = "0xA399F70", VA = "0x18A39B570")]
		public RecNetImageParameter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public class StudioFunctionStackOverflowException : StudioFunctionCircuitsException
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5950", Offset = "0xA3A4350", VA = "0x18A3A5950")]
		public StudioFunctionStackOverflowException()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public class StudioFunctionCircuitsException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA3A50E0", Offset = "0xA3A3AE0", VA = "0x18A3A50E0")]
		public StudioFunctionCircuitsException(string message)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[UnityEngine.Scripting.Preserve]
	public class StudioFunctionList : IReadOnlyList<StudioFunction>, IEnumerable<StudioFunction>, IEnumerable, IReadOnlyCollection<StudioFunction>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		[HideInInspector]
		private StudioFunction[] array;

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		private IReadOnlyList<StudioFunction> XAHGXRUFPNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0xA3A5140", Offset = "0xA3A3B40", VA = "0x18A3A5140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xA3A52E0", Offset = "0xA3A3CE0", VA = "0x18A3A52E0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public StudioFunction this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0xA3A5360", Offset = "0xA3A3D60", VA = "0x18A3A5360", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5190", Offset = "0xA3A3B90", VA = "0x18A3A5190", Slot = "6")]
		public IEnumerator<StudioFunction> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5210", Offset = "0xA3A3C10", VA = "0x18A3A5210", Slot = "7")]
		private IEnumerator SJAOULXGYMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5290", Offset = "0xA3A3C90", VA = "0x18A3A5290")]
		public StudioFunctionList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public class StudioFunctionMethodCallSignatureComparer : EqualityComparer<QUSRARTNWPJ>
	{
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public static readonly StudioFunctionMethodCallSignatureComparer Instance;

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5440", Offset = "0xA3A3E40", VA = "0x18A3A5440", Slot = "8")]
		public override bool Equals(QUSRARTNWPJ x, QUSRARTNWPJ y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5810", Offset = "0xA3A4210", VA = "0x18A3A5810", Slot = "9")]
		public override int GetHashCode(QUSRARTNWPJ obj)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5910", Offset = "0xA3A4310", VA = "0x18A3A5910")]
		public StudioFunctionMethodCallSignatureComparer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class StudioFunctionUtilities : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class RIRGYXHBSOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public string JBAKNZTCTOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public object TCHMYDYNYNI;

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public RIRGYXHBSOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0xA39B4E0", Offset = "0xA399EE0", VA = "0x18A39B4E0")]
			internal string DTILITYMDEO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class MPFKSSPNMPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public string JBAKNZTCTOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public object TCHMYDYNYNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public object TCMTVKSLHYR;

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public MPFKSSPNMPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0xA398B20", Offset = "0xA397520", VA = "0x18A398B20")]
			internal string DTILITYMDEO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class SFRBPKQQBUX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public string JBAKNZTCTOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public object TCHMYDYNYNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			public object TCMTVKSLHYR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public object TBWZDQKTFQQ;

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public SFRBPKQQBUX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0xA3A4830", Offset = "0xA3A3230", VA = "0x18A3A4830")]
			internal string DTILITYMDEO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[CompilerGenerated]
		private sealed class MSTTMGMUZZA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public string JBAKNZTCTOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public object TCHMYDYNYNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public object TCMTVKSLHYR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public object TBWZDQKTFQQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public object TCCGAXEQPBZ;

			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public MSTTMGMUZZA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0xA398B40", Offset = "0xA397540", VA = "0x18A398B40")]
			internal string DTILITYMDEO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E6")]
		[CompilerGenerated]
		private sealed class ARQHSTZUFTH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public string JBAKNZTCTOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			public object TCHMYDYNYNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public object TCMTVKSLHYR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public object TBWZDQKTFQQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			public object TCCGAXEQPBZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			public object TBMLJCWYMTY;

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public ARQHSTZUFTH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0xA390E40", Offset = "0xA38F840", VA = "0x18A390E40")]
			internal string DTILITYMDEO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x13FC9E0", Offset = "0x13FB3E0", VA = "0x1813FC9E0")]
		public bool AssignValue(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xD3BC30", Offset = "0xD3A630", VA = "0x180D3BC30")]
		public int AssignValue(int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xF09E20", Offset = "0xF08820", VA = "0x180F09E20")]
		public float AssignValue(float value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xD3BAF0", Offset = "0xD3A4F0", VA = "0x180D3BAF0")]
		public Vector2 AssignValue(Vector2 value)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x10524F0", Offset = "0x1050EF0", VA = "0x1810524F0")]
		public Vector3 AssignValue(Vector3 value)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x12AA260", Offset = "0x12A8C60", VA = "0x1812AA260")]
		public Quaternion AssignValue(Quaternion value)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x12AA260", Offset = "0x12A8C60", VA = "0x1812AA260")]
		public Color AssignValue(Color value)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xD3BC30", Offset = "0xD3A630", VA = "0x180D3BC30")]
		public Color32 AssignValue(Color32 value)
		{
			return default(Color32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xD3BAF0", Offset = "0xD3A4F0", VA = "0x180D3BAF0")]
		public string AssignValue(string value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xD3BAF0", Offset = "0xD3A4F0", VA = "0x180D3BAF0")]
		public LSTNUJPDQVX AssignValue(LSTNUJPDQVX value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5A60", Offset = "0xA3A4460", VA = "0x18A3A5A60")]
		public int Abs(int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5A00", Offset = "0xA3A4400", VA = "0x18A3A5A00")]
		public float Abs(float value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5AB0", Offset = "0xA3A44B0", VA = "0x18A3A5AB0")]
		public float Acos(float value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x312CF20", Offset = "0x312B920", VA = "0x18312CF20")]
		public int Add(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x312D370", Offset = "0x312BD70", VA = "0x18312D370")]
		public float Add(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5B10", Offset = "0xA3A4510", VA = "0x18A3A5B10")]
		public Vector3 Add(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5B60", Offset = "0xA3A4560", VA = "0x18A3A5B60")]
		public float Asin(float value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5C30", Offset = "0xA3A4630", VA = "0x18A3A5C30")]
		public float Atan(float value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5BC0", Offset = "0xA3A45C0", VA = "0x18A3A5BC0")]
		public float Atan2(float y, float x)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5D00", Offset = "0xA3A4700", VA = "0x18A3A5D00")]
		public int BitAnd(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5D10", Offset = "0xA3A4710", VA = "0x18A3A5D10")]
		public int BitLeadingZeros(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5D20", Offset = "0xA3A4720", VA = "0x18A3A5D20")]
		public int BitNand(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5D30", Offset = "0xA3A4730", VA = "0x18A3A5D30")]
		public int BitNot(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xF7FF10", Offset = "0xF7E910", VA = "0x180F7FF10")]
		public int BitOr(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5D40", Offset = "0xA3A4740", VA = "0x18A3A5D40")]
		public int BitPopCount(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5D50", Offset = "0xA3A4750", VA = "0x18A3A5D50")]
		public int BitRotateLeft(int a, int shift)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5D60", Offset = "0xA3A4760", VA = "0x18A3A5D60")]
		public int BitRotateRight(int a, int shift)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5D70", Offset = "0xA3A4770", VA = "0x18A3A5D70")]
		public int BitShiftLeft(int a, int shift)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5D80", Offset = "0xA3A4780", VA = "0x18A3A5D80")]
		public int BitShiftRight(int a, int shift)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5D90", Offset = "0xA3A4790", VA = "0x18A3A5D90")]
		public int BitTrailingZeros(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5DA0", Offset = "0xA3A47A0", VA = "0x18A3A5DA0")]
		public int BitXor(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5E10", Offset = "0xA3A4810", VA = "0x18A3A5E10")]
		public float Ceil(float value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5DB0", Offset = "0xA3A47B0", VA = "0x18A3A5DB0")]
		public int CeilToInt(float value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5E70", Offset = "0xA3A4870", VA = "0x18A3A5E70")]
		public int Clamp(int value, int min, int max)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5E90", Offset = "0xA3A4890", VA = "0x18A3A5E90")]
		public float Clamp(float value, float min, float max)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5EB0", Offset = "0xA3A48B0", VA = "0x18A3A5EB0")]
		public float Cos(float value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5F10", Offset = "0xA3A4910", VA = "0x18A3A5F10")]
		public float Distance(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6000", Offset = "0xA3A4A00", VA = "0x18A3A6000")]
		public int Divide(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6030", Offset = "0xA3A4A30", VA = "0x18A3A6030")]
		public float Divide(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6260", Offset = "0xA3A4C60", VA = "0x18A3A6260")]
		public float Floor(float value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6200", Offset = "0xA3A4C00", VA = "0x18A3A6200")]
		public int FloorToInt(float value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x26C3810", Offset = "0x26C2210", VA = "0x1826C3810")]
		public float IntToFloat(int value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6460", Offset = "0xA3A4E60", VA = "0x18A3A6460")]
		public float InverseLerp(float a, float b, float value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA3A64E0", Offset = "0xA3A4EE0", VA = "0x18A3A64E0")]
		public float InverseLerp(Vector3 a, Vector3 b, Vector3 value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6590", Offset = "0xA3A4F90", VA = "0x18A3A6590")]
		public float InverseLerp(Color a, Color b, Color value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA3A63E0", Offset = "0xA3A4DE0", VA = "0x18A3A63E0")]
		public float InverseLerpUnclamped(float a, float b, float value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6330", Offset = "0xA3A4D30", VA = "0x18A3A6330")]
		public float InverseLerpUnclamped(Vector3 a, Vector3 b, Vector3 value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA3A62C0", Offset = "0xA3A4CC0", VA = "0x18A3A62C0")]
		public float InverseLerpUnclamped(Color a, Color b, Color value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA3A68A0", Offset = "0xA3A52A0", VA = "0x18A3A68A0")]
		public float Lerp(float a, float b, float value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x1A62A80", Offset = "0x1A61480", VA = "0x181A62A80")]
		public Vector3 Lerp(Vector3 a, Vector3 b, float value)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6920", Offset = "0xA3A5320", VA = "0x18A3A6920")]
		public Quaternion Lerp(Quaternion a, Quaternion b, float value)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x9814840", Offset = "0x9813240", VA = "0x189814840")]
		public Color Lerp(Color a, Color b, float value)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA3A67D0", Offset = "0xA3A51D0", VA = "0x18A3A67D0")]
		public float LerpUnclamped(float a, float b, float value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6760", Offset = "0xA3A5160", VA = "0x18A3A6760")]
		public Vector3 LerpUnclamped(Vector3 a, Vector3 b, float value)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6850", Offset = "0xA3A5250", VA = "0x18A3A6850")]
		public Quaternion LerpUnclamped(Quaternion a, Quaternion b, float value)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xA3A66C0", Offset = "0xA3A50C0", VA = "0x18A3A66C0")]
		public Color LerpUnclamped(Color a, Color b, float value)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6970", Offset = "0xA3A5370", VA = "0x18A3A6970")]
		public float Logarithm(float value, float baseValue)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xA3A69E0", Offset = "0xA3A53E0", VA = "0x18A3A69E0")]
		public int Max(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6A40", Offset = "0xA3A5440", VA = "0x18A3A6A40")]
		public float Max(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6B20", Offset = "0xA3A5520", VA = "0x18A3A6B20")]
		public int Min(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6AB0", Offset = "0xA3A54B0", VA = "0x18A3A6AB0")]
		public float Min(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6C10", Offset = "0xA3A5610", VA = "0x18A3A6C10")]
		public int Modulo(int numerator, int divisor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6B80", Offset = "0xA3A5580", VA = "0x18A3A6B80")]
		public float Modulo(float numerator, float divisor)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6E90", Offset = "0xA3A5890", VA = "0x18A3A6E90")]
		public int Multiply(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x99165D0", Offset = "0x9914FD0", VA = "0x1899165D0")]
		public float Multiply(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6E50", Offset = "0xA3A5850", VA = "0x18A3A6E50")]
		public Vector3 Multiply(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6E20", Offset = "0xA3A5820", VA = "0x18A3A6E20")]
		public Vector3 Multiply(Vector3 a, float b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6EA0", Offset = "0xA3A58A0", VA = "0x18A3A6EA0")]
		public Vector3 Multiply(Vector3 a, int b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6CB0", Offset = "0xA3A56B0", VA = "0x18A3A6CB0")]
		public Quaternion Multiply(Quaternion a, Quaternion b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6EF0", Offset = "0xA3A58F0", VA = "0x18A3A6EF0")]
		public float Noise(Vector3 point)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7150", Offset = "0xA3A5B50", VA = "0x18A3A7150")]
		public int Power(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xA3A71C0", Offset = "0xA3A5BC0", VA = "0x18A3A71C0")]
		public float Power(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7400", Offset = "0xA3A5E00", VA = "0x18A3A7400")]
		public Quaternion QuaternionCreate(float x, float y, float z, float w)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7230", Offset = "0xA3A5C30", VA = "0x18A3A7230")]
		public Quaternion QuaternionCreateAngleAxis(float angle, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7270", Offset = "0xA3A5C70", VA = "0x18A3A7270")]
		public Quaternion QuaternionCreateEulerAngles(float x, float y, float z)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xA3A72D0", Offset = "0xA3A5CD0", VA = "0x18A3A72D0")]
		public Quaternion QuaternionCreateEulerAngles(Vector3 eulerAngles)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7340", Offset = "0xA3A5D40", VA = "0x18A3A7340")]
		public Quaternion QuaternionCreateFromTo(Vector3 from, Vector3 to)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xA3A73A0", Offset = "0xA3A5DA0", VA = "0x18A3A73A0")]
		public Quaternion QuaternionCreateLook(Vector3 forward, Vector3 upwards)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7430", Offset = "0xA3A5E30", VA = "0x18A3A7430")]
		public float QuaternionDot(Quaternion a, Quaternion b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7480", Offset = "0xA3A5E80", VA = "0x18A3A7480")]
		public Vector3 QuaternionEulerAngles(Quaternion rotation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7510", Offset = "0xA3A5F10", VA = "0x18A3A7510")]
		public float QuaternionGetAngle(Quaternion quaternion)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7560", Offset = "0xA3A5F60", VA = "0x18A3A7560")]
		public Vector3 QuaternionGetAxis(Quaternion quaternion)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xA3A75A0", Offset = "0xA3A5FA0", VA = "0x18A3A75A0")]
		public Quaternion QuaternionInverse(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xA3A75E0", Offset = "0xA3A5FE0", VA = "0x18A3A75E0")]
		public Quaternion QuaternionNormalize(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7720", Offset = "0xA3A6120", VA = "0x18A3A7720")]
		public float RandomFloat(float minInclusive, float maxInclusive)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7840", Offset = "0xA3A6240", VA = "0x18A3A7840")]
		public int RandomInt(int minInclusive, int maxInclusive)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7950", Offset = "0xA3A6350", VA = "0x18A3A7950")]
		public int Remainder(int numerator, int divisor)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6B80", Offset = "0xA3A5580", VA = "0x18A3A6B80")]
		public float Remainder(float numerator, float divisor)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xA3A79E0", Offset = "0xA3A63E0", VA = "0x18A3A79E0")]
		public float Root(float value, float root)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7A10", Offset = "0xA3A6410", VA = "0x18A3A7A10")]
		public Vector3 RotateVector(Quaternion rotation, Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7BB0", Offset = "0xA3A65B0", VA = "0x18A3A7BB0")]
		public float Round(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7B50", Offset = "0xA3A6550", VA = "0x18A3A7B50")]
		public float RoundToInt(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7A70", Offset = "0xA3A6470", VA = "0x18A3A7A70")]
		public float RoundToDecimalPlace(float value, int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7C10", Offset = "0xA3A6610", VA = "0x18A3A7C10")]
		public float Sin(float value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7C70", Offset = "0xA3A6670", VA = "0x18A3A7C70")]
		public Vector3 Slerp(Vector3 a, Vector3 b, float value)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x1A64210", Offset = "0x1A62C10", VA = "0x181A64210")]
		public Quaternion Slerp(Quaternion a, Quaternion b, float value)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x312CF30", Offset = "0x312B930", VA = "0x18312CF30")]
		public int Subtract(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x1F42530", Offset = "0x1F40F30", VA = "0x181F42530")]
		public float Subtract(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8420", Offset = "0xA3A6E20", VA = "0x18A3A8420")]
		public Vector3 Subtract(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8460", Offset = "0xA3A6E60", VA = "0x18A3A8460")]
		public float Tan(float value)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8540", Offset = "0xA3A6F40", VA = "0x18A3A8540")]
		public float TruncateToDecimalPlace(float value, int decimals)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xA3A89D0", Offset = "0xA3A73D0", VA = "0x18A3A89D0")]
		public float Vector3GetMagnitude(Vector3 vector)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8610", Offset = "0xA3A7010", VA = "0x18A3A8610")]
		public float Vector3Angle(Vector3 from, Vector3 to)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8650", Offset = "0xA3A7050", VA = "0x18A3A8650")]
		public Vector3 Vector3ClampMagnitude(Vector3 vector, float magnitude)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA3A87F0", Offset = "0xA3A71F0", VA = "0x18A3A87F0")]
		public Vector3 Vector3ClosestPointOnPlane(Vector3 position, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xA3A88E0", Offset = "0xA3A72E0", VA = "0x18A3A88E0")]
		public Vector3 Vector3Create(float x, float y, float z)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8900", Offset = "0xA3A7300", VA = "0x18A3A8900")]
		public Vector3 Vector3Cross(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8990", Offset = "0xA3A7390", VA = "0x18A3A8990")]
		public float Vector3Dot(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8B40", Offset = "0xA3A7540", VA = "0x18A3A8B40")]
		public Vector3 Vector3Inverse(Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8A80", Offset = "0xA3A7480", VA = "0x18A3A8A80")]
		public Vector3 Vector3InverseTransform(Vector3 worldPoint, Vector3 worldOrigin, Quaternion worldOrientation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8B80", Offset = "0xA3A7580", VA = "0x18A3A8B80")]
		public Vector3 Vector3Mask(Vector3 value, bool keepX, bool keepY, bool keepZ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8BD0", Offset = "0xA3A75D0", VA = "0x18A3A8BD0")]
		public Vector3 Vector3MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8D80", Offset = "0xA3A7780", VA = "0x18A3A8D80")]
		public Vector3 Vector3Normalize(Vector3 vector)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8F10", Offset = "0xA3A7910", VA = "0x18A3A8F10")]
		public Vector3 Vector3Project(Vector3 vector, Vector3 onNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8DD0", Offset = "0xA3A77D0", VA = "0x18A3A8DD0")]
		public Vector3 Vector3ProjectOnPlane(Vector3 vector, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA3A90A0", Offset = "0xA3A7AA0", VA = "0x18A3A90A0")]
		public Vector3 Vector3Scale(Vector3 vector, float scalar)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA3A9050", Offset = "0xA3A7A50", VA = "0x18A3A9050")]
		public Vector3 Vector3Scale(Vector3 vector, int scalar)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA3A90E0", Offset = "0xA3A7AE0", VA = "0x18A3A90E0")]
		public Vector3 Vector3Transform(Vector3 localPoint, Vector3 worldOrigin, Quaternion worldOrientation)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6600", Offset = "0xA3A5000", VA = "0x18A3A6600")]
		private float LNKITHMBWCH(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5B50", Offset = "0xA3A4550", VA = "0x18A3A5B50")]
		public bool And(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6190", Offset = "0xA3A4B90", VA = "0x18A3A6190")]
		public bool Equals(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6110", Offset = "0xA3A4B10", VA = "0x18A3A6110")]
		public bool Equals(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xA3A61F0", Offset = "0xA3A4BF0", VA = "0x18A3A61F0")]
		public bool Equals(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA3A61A0", Offset = "0xA3A4BA0", VA = "0x18A3A61A0")]
		public bool Equals(Vector2 a, Vector2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xA3A60B0", Offset = "0xA3A4AB0", VA = "0x18A3A60B0")]
		public bool Equals(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6050", Offset = "0xA3A4A50", VA = "0x18A3A6050")]
		public bool Equals(Quaternion a, Quaternion b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6120", Offset = "0xA3A4B20", VA = "0x18A3A6120")]
		public bool Equals(Color a, Color b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x887A6F0", Offset = "0x88790F0", VA = "0x18887A6F0")]
		public bool Equals(string a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x2EE5590", Offset = "0x2EE3F90", VA = "0x182EE5590")]
		public bool GreaterThan(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x2EE5720", Offset = "0x2EE4120", VA = "0x182EE5720")]
		public bool GreaterThan(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x2EE58B0", Offset = "0x2EE42B0", VA = "0x182EE58B0")]
		public bool GreaterOrEqual(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x2EE59C0", Offset = "0x2EE43C0", VA = "0x182EE59C0")]
		public bool GreaterOrEqual(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x2F128F0", Offset = "0x2F112F0", VA = "0x182F128F0")]
		public bool LessThan(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x1F82A10", Offset = "0x1F81410", VA = "0x181F82A10")]
		public bool LessThan(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x2F12C00", Offset = "0x2F11600", VA = "0x182F12C00")]
		public bool LessOrEqual(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x1F82A20", Offset = "0x1F81420", VA = "0x181F82A20")]
		public bool LessOrEqual(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6EE0", Offset = "0xA3A58E0", VA = "0x18A3A6EE0")]
		public bool Nand(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6F60", Offset = "0xA3A5960", VA = "0x18A3A6F60")]
		public bool Nor(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x13369B0", Offset = "0x13353B0", VA = "0x1813369B0")]
		public bool Not(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7010", Offset = "0xA3A5A10", VA = "0x18A3A7010")]
		public bool NotEquals(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7080", Offset = "0xA3A5A80", VA = "0x18A3A7080")]
		public bool NotEquals(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7000", Offset = "0xA3A5A00", VA = "0x18A3A7000")]
		public bool NotEquals(float a, float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA3A70F0", Offset = "0xA3A5AF0", VA = "0x18A3A70F0")]
		public bool NotEquals(Vector2 a, Vector2 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7090", Offset = "0xA3A5A90", VA = "0x18A3A7090")]
		public bool NotEquals(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7020", Offset = "0xA3A5A20", VA = "0x18A3A7020")]
		public bool NotEquals(Quaternion a, Quaternion b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6F70", Offset = "0xA3A5970", VA = "0x18A3A6F70")]
		public bool NotEquals(Color a, Color b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xA3A6FE0", Offset = "0xA3A59E0", VA = "0x18A3A6FE0")]
		public bool NotEquals(string a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7140", Offset = "0xA3A5B40", VA = "0x18A3A7140")]
		public bool Or(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7010", Offset = "0xA3A5A10", VA = "0x18A3A7010")]
		public bool Xor(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7CE0", Offset = "0xA3A66E0", VA = "0x18A3A7CE0")]
		public string StringConcat(string a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7D20", Offset = "0xA3A6720", VA = "0x18A3A7D20")]
		public bool StringContains(string a, string sequence)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7E60", Offset = "0xA3A6860", VA = "0x18A3A7E60")]
		public string StringFormat(string formatString, object arg0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8060", Offset = "0xA3A6A60", VA = "0x18A3A8060")]
		public string StringFormat(string formatString, object arg0, object arg1)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8150", Offset = "0xA3A6B50", VA = "0x18A3A8150")]
		public string StringFormat(string formatString, object arg0, object arg1, object arg2)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7D50", Offset = "0xA3A6750", VA = "0x18A3A7D50")]
		public string StringFormat(string formatString, object arg0, object arg1, object arg2, object arg3)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7F30", Offset = "0xA3A6930", VA = "0x18A3A7F30")]
		public string StringFormat(string formatString, object arg0, object arg1, object arg2, object arg3, object arg4)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8250", Offset = "0xA3A6C50", VA = "0x18A3A8250")]
		public int StringIndexOf(string a, string sequence)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8280", Offset = "0xA3A6C80", VA = "0x18A3A8280")]
		public int StringLength(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8290", Offset = "0xA3A6C90", VA = "0x18A3A8290")]
		public string StringReplace(string a, string oldValue, string newValue)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA3A82C0", Offset = "0xA3A6CC0", VA = "0x18A3A82C0")]
		public string StringSubstring(string a, int startIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8300", Offset = "0xA3A6D00", VA = "0x18A3A8300")]
		public string StringSubstring(string a, int startIndex, int length)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8360", Offset = "0xA3A6D60", VA = "0x18A3A8360")]
		public string StringToLower(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xA3A83A0", Offset = "0xA3A6DA0", VA = "0x18A3A83A0")]
		public string StringToUpper(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA3A83E0", Offset = "0xA3A6DE0", VA = "0x18A3A83E0")]
		public string StringTrim(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x9C674D0", Offset = "0x9C65ED0", VA = "0x189C674D0")]
		public string ToString(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x1610750", Offset = "0x160F150", VA = "0x181610750")]
		public string ToString(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x1610630", Offset = "0x160F030", VA = "0x181610630")]
		public string ToString(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8520", Offset = "0xA3A6F20", VA = "0x18A3A8520")]
		public string ToString(Vector2 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xA3A84E0", Offset = "0xA3A6EE0", VA = "0x18A3A84E0")]
		public string ToString(Vector3 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xA3A8500", Offset = "0xA3A6F00", VA = "0x18A3A8500")]
		public string ToString(Quaternion a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA3A84C0", Offset = "0xA3A6EC0", VA = "0x18A3A84C0")]
		public string ToString(Color a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA3A5C90", Offset = "0xA3A4690", VA = "0x18A3A5C90")]
		private static string BVDUHUSTZZW(Func<string> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xD6AE70", Offset = "0xD69870", VA = "0x180D6AE70")]
		public StudioFunctionUtilities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x1348FC0", Offset = "0x13479C0", VA = "0x181348FC0")]
		[CompilerGenerated]
		internal static int SMZXNIQNUSM(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x1348FE0", Offset = "0x13479E0", VA = "0x181348FE0")]
		[CompilerGenerated]
		internal static float XGLTTNICARD(float a, float b)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class VAORNXAUWIV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private readonly object[] ECMPVMADDRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private readonly object[] VVZYJTKUGOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private readonly object[] OWYKQEHJEEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private readonly IReadOnlyList<HOXGJBGBYOU> CTYCYFHHUYB;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public IReadOnlyList<HOXGJBGBYOU> HADRCOHGVCB
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x10FC420", Offset = "0x10FAE20", VA = "0x1810FC420")]
		public VAORNXAUWIV(object[] a, object[] b, object[] c, IReadOnlyList<HOXGJBGBYOU> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xA3AC000", Offset = "0xA3AAA00", VA = "0x18A3AC000")]
		public object VSWVGZQYENZ(Variable a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA3ABD60", Offset = "0xA3AA760", VA = "0x18A3ABD60")]
		public void CCJTOXJVQPR(Variable a, object b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public interface HOXGJBGBYOU
	{
		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		object FCAQLXAUMLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[UnityEngine.Scripting.Preserve]
	public abstract class StudioProperty : Variable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private bool isSynced;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeReference]
		private Instruction[] onInitializedOrChanged;

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool IsSynced
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0xCD7520", Offset = "0xCD5F20", VA = "0x180CD7520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public abstract object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA3AAB40", Offset = "0xA3A9540", VA = "0x18A3AAB40")]
		public void GVIWWDTBGBG(VAORNXAUWIV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA3AABE0", Offset = "0xA3A95E0", VA = "0x18A3AABE0")]
		protected StudioProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[UnityEngine.Scripting.Preserve]
	public abstract class StudioProperty<T> : StudioProperty
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7AF28F0", Offset = "0x7AF12F0", VA = "0x187AF28F0")]
		protected StudioProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[UnityEngine.Scripting.Preserve]
	public abstract class ValueProperty<T> : StudioProperty<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		protected T typedDefaultValue;

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		public override Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x53D2890", Offset = "0x53D1290", VA = "0x1853D2890", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		public override object DefaultValue
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x8042D50", Offset = "0x8041750", VA = "0x188042D50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8042CD0", Offset = "0x80416D0", VA = "0x188042CD0")]
		protected ValueProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[UnityEngine.Scripting.Preserve]
	public sealed class BoolProperty : ValueProperty<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xA391750", Offset = "0xA390150", VA = "0x18A391750")]
		public BoolProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[UnityEngine.Scripting.Preserve]
	public sealed class ColorProperty : ValueProperty<Color>
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA395750", Offset = "0xA394150", VA = "0x18A395750")]
		public ColorProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Color32Property : ValueProperty<Color32>
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA3955C0", Offset = "0xA393FC0", VA = "0x18A3955C0")]
		public Color32Property()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[UnityEngine.Scripting.Preserve]
	public sealed class FloatProperty : ValueProperty<float>
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xA396910", Offset = "0xA395310", VA = "0x18A396910")]
		public FloatProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[UnityEngine.Scripting.Preserve]
	public sealed class IntProperty : ValueProperty<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xA396E40", Offset = "0xA395840", VA = "0x18A396E40")]
		public IntProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[UnityEngine.Scripting.Preserve]
	public sealed class StringProperty : ValueProperty<string>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xA3A50A0", Offset = "0xA3A3AA0", VA = "0x18A3A50A0")]
		public StringProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector2Property : ValueProperty<Vector2>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xA3AC370", Offset = "0xA3AAD70", VA = "0x18A3AC370")]
		public Vector2Property()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[UnityEngine.Scripting.Preserve]
	public sealed class Vector3Property : ValueProperty<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xA3AC470", Offset = "0xA3AAE70", VA = "0x18A3AC470")]
		public Vector3Property()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[UnityEngine.Scripting.Preserve]
	public sealed class QuaternionProperty : ValueProperty<Quaternion>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xA39B4A0", Offset = "0xA399EA0", VA = "0x18A39B4A0")]
		public QuaternionProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[UnityEngine.Scripting.Preserve]
	public sealed class RecNetImageProperty : ValueProperty<LSTNUJPDQVX>
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xA39B5B0", Offset = "0xA399FB0", VA = "0x18A39B5B0")]
		public RecNetImageProperty()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	[UnityEngine.Scripting.Preserve]
	public class StudioPropertyList : IReadOnlyList<StudioProperty>, IEnumerable<StudioProperty>, IEnumerable, IReadOnlyCollection<StudioProperty>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeReference]
		[HideInInspector]
		private StudioProperty[] array;

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		private IReadOnlyList<StudioProperty> XAHGXRUFPNK
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0xA3AA840", Offset = "0xA3A9240", VA = "0x18A3AA840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0xA3AA9E0", Offset = "0xA3A93E0", VA = "0x18A3AA9E0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		public StudioProperty this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0xA3AAA60", Offset = "0xA3A9460", VA = "0x18A3AAA60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xA3AA890", Offset = "0xA3A9290", VA = "0x18A3AA890", Slot = "6")]
		public IEnumerator<StudioProperty> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xA3AA910", Offset = "0xA3A9310", VA = "0x18A3AA910", Slot = "7")]
		private IEnumerator SJAOULXGYMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xA3AA990", Offset = "0xA3A9390", VA = "0x18A3AA990")]
		public StudioPropertyList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public static class CQDTZQPQADW
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xA391790", Offset = "0xA390190", VA = "0x18A391790")]
		public static string EZIYZIUTVNY(this Type a)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[UnityEngine.Scripting.Preserve]
	public abstract class Variable
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private int ONJFVMMXRGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		protected string name;

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0xCD5110", Offset = "0xCD3B10", VA = "0x180CD5110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		public abstract Type ValueType
		{
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x166B830", Offset = "0x166A230", VA = "0x18166B830")]
		public Variable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xA3AC1E0", Offset = "0xA3AABE0", VA = "0x18A3AC1E0")]
		internal void SMJNVFURFQJ(int a)
		{
		}
	}
}
namespace RecRoom.Core.Studio.AvatarItems
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public abstract class RecRoomStudioAvatarItemBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
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
