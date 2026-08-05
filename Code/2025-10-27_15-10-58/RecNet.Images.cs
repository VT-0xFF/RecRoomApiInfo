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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BA9910", Offset = "0x7BA8910", VA = "0x187BA9910")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BAB230", Offset = "0x7BAA230", VA = "0x187BAB230", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29F5B20", Offset = "0x29F4B20", VA = "0x1829F5B20")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface MBOTXHKKRXC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		DGREXUOKJBX<Texture2D> ZPAKPUMWCQQ(string a, [Optional] uint? b, bool c = false, TextureLoadOptions d = TextureLoadOptions.Default);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DGREXUOKJBX<Texture2D> FJPXPOUMMUZ(RoomDTO a);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DGREXUOKJBX<Texture2D> MFILKGIVKZG(Invention a);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		DGREXUOKJBX<Texture2D> HWKHRZNLGYD(PlayerEvent a);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		DGREXUOKJBX<Texture2D> YRLUNXBNCTN(Account a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		DGREXUOKJBX<Texture2D> ZUXETFVTXPT(AnnouncementDTO a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal class HUTVDKLSOJD : MBOTXHKKRXC
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
			[Cpp2IlInjected.Address(RVA = "0x68F7B20", Offset = "0x68F6B20", VA = "0x1868F7B20")]
			public ImageId(string imageName, uint? resizeWidth, bool cropSquare)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7BA96B0", Offset = "0x7BA86B0", VA = "0x187BA96B0", Slot = "4")]
			public bool Equals(ImageId other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7BA9600", Offset = "0x7BA8600", VA = "0x187BA9600", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7BA9770", Offset = "0x7BA8770", VA = "0x187BA9770", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7BA97F0", Offset = "0x7BA87F0", VA = "0x187BA97F0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BA9990", Offset = "0x7BA8990", VA = "0x187BA9990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7BA9C30", Offset = "0x7BA8C30", VA = "0x187BA9C30", Slot = "5")]
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
			public AsyncTaskMethodBuilder<DGREXUOKJBX<Texture2D>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public Account account;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public HUTVDKLSOJD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private TaskAwaiter<DGREXUOKJBX<Texture2D>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7BA9CA0", Offset = "0x7BA8CA0", VA = "0x187BA9CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7BA9FD0", Offset = "0x7BA8FD0", VA = "0x187BA9FD0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<DGREXUOKJBX<Texture2D>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public AnnouncementDTO announcement;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public HUTVDKLSOJD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<DGREXUOKJBX<Texture2D>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7BAA040", Offset = "0x7BA9040", VA = "0x187BAA040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7BAA2F0", Offset = "0x7BA92F0", VA = "0x187BAA2F0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<DGREXUOKJBX<Texture2D>> <>t__builder;

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
			public HUTVDKLSOJD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public TextureLoadOptions textureLoadOptions;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7BAA360", Offset = "0x7BA9360", VA = "0x187BAA360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7BAA540", Offset = "0x7BA9540", VA = "0x187BAA540", Slot = "5")]
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
			public AsyncTaskMethodBuilder<DGREXUOKJBX<Texture2D>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Invention invention;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HUTVDKLSOJD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TaskAwaiter<DGREXUOKJBX<Texture2D>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7BAA5B0", Offset = "0x7BA95B0", VA = "0x187BAA5B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7BAA8D0", Offset = "0x7BA98D0", VA = "0x187BAA8D0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<DGREXUOKJBX<Texture2D>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public PlayerEvent playerEvent;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public HUTVDKLSOJD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<RoomDTO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<DGREXUOKJBX<Texture2D>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7BAA940", Offset = "0x7BA9940", VA = "0x187BAA940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7BAADC0", Offset = "0x7BA9DC0", VA = "0x187BAADC0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<DGREXUOKJBX<Texture2D>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public RoomDTO room;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public HUTVDKLSOJD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private TaskAwaiter<DGREXUOKJBX<Texture2D>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7BAAE30", Offset = "0x7BA9E30", VA = "0x187BAAE30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7BAB150", Offset = "0x7BAA150", VA = "0x187BAB150", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ZIXDNYUFXLB.Resolution QXCHAPJFBTN;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly ZIXDNYUFXLB.Resolution ZKCUIYCLXDX;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ZIXDNYUFXLB.Resolution UKPOEFOAFBW;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ZIXDNYUFXLB.Resolution KMCNFELFJSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly TZTMGIPHCHR<ImageId> LMSGDJAVHPZ;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8F80", Offset = "0x7BA7F80", VA = "0x187BA8F80")]
		[OKVIBKJHYHD.Root.GameOnly]
		internal static void XPITZMPMBWE(QXIJOLGHAIZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9460", Offset = "0x7BA8460", VA = "0x187BA9460")]
		[RecRoom.NoEngine.Common.Preserve]
		internal HUTVDKLSOJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7BA91B0", Offset = "0x7BA81B0", VA = "0x187BA91B0", Slot = "4")]
		public DGREXUOKJBX<Texture2D> ZPAKPUMWCQQ(string a, [Optional] uint? b, bool c = false, TextureLoadOptions d = TextureLoadOptions.Default)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7BA84F0", Offset = "0x7BA74F0", VA = "0x187BA84F0", Slot = "5")]
		public DGREXUOKJBX<Texture2D> FJPXPOUMMUZ(RoomDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8780", Offset = "0x7BA7780", VA = "0x187BA8780", Slot = "6")]
		public DGREXUOKJBX<Texture2D> MFILKGIVKZG(Invention a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8630", Offset = "0x7BA7630", VA = "0x187BA8630", Slot = "7")]
		public DGREXUOKJBX<Texture2D> HWKHRZNLGYD(PlayerEvent a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9070", Offset = "0x7BA8070", VA = "0x187BA9070", Slot = "8")]
		public DGREXUOKJBX<Texture2D> YRLUNXBNCTN(Account a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7BA9240", Offset = "0x7BA8240", VA = "0x187BA9240", Slot = "9")]
		public DGREXUOKJBX<Texture2D> ZUXETFVTXPT(AnnouncementDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BA83C0", Offset = "0x7BA73C0", VA = "0x187BA83C0")]
		[AsyncStateMachine(typeof(<DownloadImage>d__16))]
		private Task<byte[]> BNKHMQUZNQW(ImageId a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8D10", Offset = "0x7BA7D10", VA = "0x187BA8D10")]
		[AsyncStateMachine(typeof(<GetImageInternal>d__17))]
		private Task<DGREXUOKJBX<Texture2D>> UOZUJKVJXCB(string a, [Optional] uint? b, bool c = false, TextureLoadOptions d = TextureLoadOptions.Default)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8AF0", Offset = "0x7BA7AF0", VA = "0x187BA8AF0")]
		[AsyncStateMachine(typeof(<GetRoomImageInternal>d__18))]
		private Task<DGREXUOKJBX<Texture2D>> TDWJFWNTGSA(RoomDTO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7BA89E0", Offset = "0x7BA79E0", VA = "0x187BA89E0")]
		[AsyncStateMachine(typeof(<GetInventionImageInternal>d__19))]
		private Task<DGREXUOKJBX<Texture2D>> QMDVAHEDVPP(Invention a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7BA88C0", Offset = "0x7BA78C0", VA = "0x187BA88C0")]
		[AsyncStateMachine(typeof(<GetPlayerEventImageInternal>d__20))]
		private Task<DGREXUOKJBX<Texture2D>> MOZJZNOLMZQ(PlayerEvent a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8E70", Offset = "0x7BA7E70", VA = "0x187BA8E70")]
		[AsyncStateMachine(typeof(<GetAccountImageInternal>d__21))]
		private Task<DGREXUOKJBX<Texture2D>> XHBSTIXWKSO(Account a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7BA8C00", Offset = "0x7BA7C00", VA = "0x187BA8C00")]
		[AsyncStateMachine(typeof(<GetAnnouncementImageInternal>d__22))]
		private Task<DGREXUOKJBX<Texture2D>> UBWNWDIESBW(AnnouncementDTO a)
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
