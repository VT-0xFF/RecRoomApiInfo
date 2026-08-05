using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet.Events;
using RecNet.Rooms;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.DataStructures.ResourceHandles;
using RecRoom.Initialization;
using RecRoom.NoEngine.Common;
using RecRoom.Utils.Image;
using RecRoom.Utils.Image.Caching;
using UJect;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x7711440", Offset = "0x7710840", VA = "0x187711440")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecNet_Images
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7712D60", Offset = "0x7712160", VA = "0x187712D60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x26F2710", Offset = "0x26F1B10", VA = "0x1826F2710")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface UOWVLFOLFMV
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		FSJCTOPLDTG<Texture2D> SLJUTVBXSQP(string a, [Optional] uint? b, bool c = false, TextureLoadOptions d = TextureLoadOptions.Default);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FSJCTOPLDTG<Texture2D> QJRWVZTQZDM(RoomDTO a);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		FSJCTOPLDTG<Texture2D> JTLXSAMTLPD(Invention a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		FSJCTOPLDTG<Texture2D> NZNBGMMMGEG(PlayerEvent a);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		FSJCTOPLDTG<Texture2D> LDKFXJCJEDU(Account a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		FSJCTOPLDTG<Texture2D> PODMFMHHVSG(AnnouncementDTO a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal class KPSDYQYXXMO : UOWVLFOLFMV
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private readonly struct ImageId : IEquatable<ImageId>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public readonly string ImageName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public readonly uint? ResizeWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public readonly bool CropSquare;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x645E7B0", Offset = "0x645DBB0", VA = "0x18645E7B0")]
			public ImageId(string imageName, uint? resizeWidth, bool cropSquare)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x770FFD0", Offset = "0x770F3D0", VA = "0x18770FFD0", Slot = "4")]
			public bool Equals(ImageId other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x770FF30", Offset = "0x770F330", VA = "0x18770FF30", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7710090", Offset = "0x770F490", VA = "0x187710090", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7710110", Offset = "0x770F510", VA = "0x187710110", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct <DownloadImage>d__16 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public AsyncTaskMethodBuilder<byte[]> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public ImageId imageId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private TaskAwaiter<byte[]> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x77114C0", Offset = "0x77108C0", VA = "0x1877114C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7711760", Offset = "0x7710B60", VA = "0x187711760", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private struct <GetAccountImageInternal>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public AsyncTaskMethodBuilder<FSJCTOPLDTG<Texture2D>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Account account;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public KPSDYQYXXMO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private TaskAwaiter<FSJCTOPLDTG<Texture2D>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x77117D0", Offset = "0x7710BD0", VA = "0x1877117D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7711B00", Offset = "0x7710F00", VA = "0x187711B00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct <GetAnnouncementImageInternal>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<FSJCTOPLDTG<Texture2D>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public AnnouncementDTO announcement;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public KPSDYQYXXMO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<FSJCTOPLDTG<Texture2D>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7711B70", Offset = "0x7710F70", VA = "0x187711B70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7711E20", Offset = "0x7711220", VA = "0x187711E20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct <GetImageInternal>d__17 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncTaskMethodBuilder<FSJCTOPLDTG<Texture2D>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public string imageName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public uint? resizeWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public bool cropSquare;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public KPSDYQYXXMO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public TextureLoadOptions textureLoadOptions;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7711E90", Offset = "0x7711290", VA = "0x187711E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7712070", Offset = "0x7711470", VA = "0x187712070", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct <GetInventionImageInternal>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public AsyncTaskMethodBuilder<FSJCTOPLDTG<Texture2D>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Invention invention;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public KPSDYQYXXMO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TaskAwaiter<FSJCTOPLDTG<Texture2D>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x77120E0", Offset = "0x77114E0", VA = "0x1877120E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7712400", Offset = "0x7711800", VA = "0x187712400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct <GetPlayerEventImageInternal>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AsyncTaskMethodBuilder<FSJCTOPLDTG<Texture2D>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public PlayerEvent playerEvent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public KPSDYQYXXMO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<RoomDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<FSJCTOPLDTG<Texture2D>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7712470", Offset = "0x7711870", VA = "0x187712470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x77128F0", Offset = "0x7711CF0", VA = "0x1877128F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct <GetRoomImageInternal>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public AsyncTaskMethodBuilder<FSJCTOPLDTG<Texture2D>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RoomDTO room;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public KPSDYQYXXMO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private TaskAwaiter<FSJCTOPLDTG<Texture2D>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7712960", Offset = "0x7711D60", VA = "0x187712960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7712C80", Offset = "0x7712080", VA = "0x187712C80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly FITPEUADUOY.Resolution MAWJWAZDVEA;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly FITPEUADUOY.Resolution SZRDUPDXPMU;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly FITPEUADUOY.Resolution CXPSQZITTHZ;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly FITPEUADUOY.Resolution GABIIUAZAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly OIUKJKQTRQA<ImageId> STOXXBEGWOO;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7710460", Offset = "0x770F860", VA = "0x187710460")]
		[CVOOPLRRRUK.Root.GameOnly]
		internal static void CYELLWXHWON(XRSJVGYQFTW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x77112B0", Offset = "0x77106B0", VA = "0x1877112B0")]
		[RecRoom.NoEngine.Common.Preserve]
		internal KPSDYQYXXMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7710EF0", Offset = "0x77102F0", VA = "0x187710EF0", Slot = "4")]
		public FSJCTOPLDTG<Texture2D> SLJUTVBXSQP(string a, [Optional] uint? b, bool c = false, TextureLoadOptions d = TextureLoadOptions.Default)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7710DB0", Offset = "0x77101B0", VA = "0x187710DB0", Slot = "5")]
		public FSJCTOPLDTG<Texture2D> QJRWVZTQZDM(RoomDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7710660", Offset = "0x770FA60", VA = "0x187710660", Slot = "6")]
		public FSJCTOPLDTG<Texture2D> JTLXSAMTLPD(Invention a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7710B20", Offset = "0x770FF20", VA = "0x187710B20", Slot = "7")]
		public FSJCTOPLDTG<Texture2D> NZNBGMMMGEG(PlayerEvent a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x77107A0", Offset = "0x770FBA0", VA = "0x1877107A0", Slot = "8")]
		public FSJCTOPLDTG<Texture2D> LDKFXJCJEDU(Account a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7710C70", Offset = "0x7710070", VA = "0x187710C70", Slot = "9")]
		public FSJCTOPLDTG<Texture2D> PODMFMHHVSG(AnnouncementDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x77109F0", Offset = "0x770FDF0", VA = "0x1877109F0")]
		[AsyncStateMachine(typeof(<DownloadImage>d__16))]
		private Task<byte[]> NKHVQEJEJFV(ImageId a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7710F80", Offset = "0x7710380", VA = "0x187710F80")]
		[AsyncStateMachine(typeof(<GetImageInternal>d__17))]
		private Task<FSJCTOPLDTG<Texture2D>> UQCCPESNSFE(string a, [Optional] uint? b, bool c = false, TextureLoadOptions d = TextureLoadOptions.Default)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7710550", Offset = "0x770F950", VA = "0x187710550")]
		[AsyncStateMachine(typeof(<GetRoomImageInternal>d__18))]
		private Task<FSJCTOPLDTG<Texture2D>> ECFKUGSLJWL(RoomDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x77108E0", Offset = "0x770FCE0", VA = "0x1877108E0")]
		[AsyncStateMachine(typeof(<GetInventionImageInternal>d__19))]
		private Task<FSJCTOPLDTG<Texture2D>> MUFJPBAWGZW(Invention a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7710340", Offset = "0x770F740", VA = "0x187710340")]
		[AsyncStateMachine(typeof(<GetPlayerEventImageInternal>d__20))]
		private Task<FSJCTOPLDTG<Texture2D>> CXFOSSESSJZ(PlayerEvent a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7710230", Offset = "0x770F630", VA = "0x187710230")]
		[AsyncStateMachine(typeof(<GetAccountImageInternal>d__21))]
		private Task<FSJCTOPLDTG<Texture2D>> AIDIUVTKARN(Account a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x77110E0", Offset = "0x77104E0", VA = "0x1877110E0")]
		[AsyncStateMachine(typeof(<GetAnnouncementImageInternal>d__22))]
		private Task<FSJCTOPLDTG<Texture2D>> VQQZAHAOGZZ(AnnouncementDTO a)
		{
			return null;
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
