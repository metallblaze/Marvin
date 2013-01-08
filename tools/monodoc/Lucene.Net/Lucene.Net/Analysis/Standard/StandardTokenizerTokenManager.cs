/*
 * Copyright 2004 The Apache Software Foundation
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
/* Generated By:JavaCC: Do not edit this line. StandardTokenizerTokenManager.java */
using System;
namespace Monodoc.Lucene.Net.Analysis.Standard
{
	
	public class StandardTokenizerTokenManager : StandardTokenizerConstants
	{
		private void  InitBlock()
		{
			System.IO.StreamWriter temp_writer;
			temp_writer = new System.IO.StreamWriter(System.Console.OpenStandardOutput(), System.Console.Out.Encoding);
			temp_writer.AutoFlush = true;
			debugStream = temp_writer;
		}
		public System.IO.StreamWriter debugStream;
		public virtual void  SetDebugStream(System.IO.StreamWriter ds)
		{
			debugStream = ds;
		}
		private int JjMoveStringLiteralDfa0_0()
		{
			return JjMoveNfa_0(0, 0);
		}
		private void  JjCheckNAdd(int state)
		{
			if (jjrounds[state] != jjround)
			{
				jjstateSet[jjnewStateCnt++] = state;
				jjrounds[state] = jjround;
			}
		}
		private void  JjAddStates(int start, int end)
		{
			do 
			{
				jjstateSet[jjnewStateCnt++] = jjnextStates[start];
			}
			while (start++ != end);
		}
		private void  JjCheckNAddTwoStates(int state1, int state2)
		{
			JjCheckNAdd(state1);
			JjCheckNAdd(state2);
		}
		private void  JjCheckNAddStates(int start, int end)
		{
			do 
			{
				JjCheckNAdd(jjnextStates[start]);
			}
			while (start++ != end);
		}
		private void  JjCheckNAddStates(int start)
		{
			JjCheckNAdd(jjnextStates[start]);
			JjCheckNAdd(jjnextStates[start + 1]);
		}
		internal static readonly ulong[] jjbitVec0 = new ulong[]{0x1ff0000000000000L, 0xffffffffffffc000L, 0xffffffffL, 0x600000000000000L};
		internal static readonly ulong[] jjbitVec2 = new ulong[]{0x0L, 0xffffffffffffffffL, 0xffffffffffffffffL, 0xffffffffffffffffL};
		internal static readonly ulong[] jjbitVec3 = new ulong[]{0xffffffffffffffffL, 0xffffffffffffffffL, 0xffffL, 0x0L};
		internal static readonly ulong[] jjbitVec4 = new ulong[]{0xffffffffffffffffL, 0xffffffffffffffffL, 0x0L, 0x0L};
		internal static readonly ulong[] jjbitVec5 = new ulong[]{0x3fffffffffffL, 0x0L, 0x0L, 0x0L};
		internal static readonly ulong[] jjbitVec6 = new ulong[]{0x1600L, 0x0L, 0x0L, 0x0L};
		internal static readonly ulong[] jjbitVec7 = new ulong[]{0x0L, 0xffc000000000L, 0x0L, 0xffc000000000L};
		internal static readonly ulong[] jjbitVec8 = new ulong[]{0x0L, 0x3ff00000000L, 0x0L, 0x3ff000000000000L};
		internal static readonly ulong[] jjbitVec9 = new ulong[]{0x0L, 0xffc000000000L, 0x0L, 0xff8000000000L};
		internal static readonly ulong[] jjbitVec10 = new ulong[]{0x0L, 0xffc000000000L, 0x0L, 0x0L};
		internal static readonly ulong[] jjbitVec11 = new ulong[]{0x0L, 0x3ff0000L, 0x0L, 0x3ff0000L};
		internal static readonly ulong[] jjbitVec12 = new ulong[]{0x0L, 0x3ffL, 0x0L, 0x0L};
		internal static readonly ulong[] jjbitVec13 = new ulong[]{0xfffffffeL, 0x0L, 0x0L, 0x0L};
		internal static readonly ulong[] jjbitVec14 = new ulong[]{0x0L, 0x0L, 0x0L, 0xff7fffffff7fffffL};
		private int JjMoveNfa_0(int startState, int curPos)
		{
			int startsAt = 0;
			jjnewStateCnt = 73;
			int ii = 1;
			jjstateSet[0] = startState;
			int kind = 0x7fffffff;
			for (; ; )
			{
				if (++jjround == 0x7fffffff)
					ReInitRounds();
				if (curChar < 64)
				{
					ulong l = ((ulong) 1L) << curChar;
					do 
					{
						switch (jjstateSet[--ii])
						{
							
							case 0: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
								{
									if (kind > 1)
										kind = 1;
									JjCheckNAddStates(0, 17);
								}
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddStates(18, 23);
								break;
							
							case 1: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddStates(18, 23);
								break;
							
							case 2: 
							case 39: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(2, 3);
								break;
							
							case 3: 
								if ((0xf00000000000L & l) != (ulong) 0L)
									JjCheckNAdd(4);
								break;
							
							case 4: 
								if ((0x3ff000000000000L & l) == (ulong) 0L)
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAdd(4);
								break;
							
							case 5: 
							case 48: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(5, 6);
								break;
							
							case 6: 
								if ((0xf00000000000L & l) != (ulong) 0L)
									JjCheckNAdd(7);
								break;
							
							case 7: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(7, 8);
								break;
							
							case 8: 
								if ((0xf00000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(9, 10);
								break;
							
							case 9: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(9, 10);
								break;
							
							case 10: 
							case 11: 
								if ((0x3ff000000000000L & l) == (ulong) 0L)
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAddTwoStates(6, 11);
								break;
							
							case 12: 
							case 61: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(12, 13);
								break;
							
							case 13: 
								if ((0xf00000000000L & l) != (ulong) 0L)
									JjCheckNAdd(14);
								break;
							
							case 14: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(14, 15);
								break;
							
							case 15: 
								if ((0xf00000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(16, 17);
								break;
							
							case 16: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(16, 17);
								break;
							
							case 17: 
							case 18: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(18, 19);
								break;
							
							case 19: 
								if ((0xf00000000000L & l) != (ulong) 0L)
									JjCheckNAdd(20);
								break;
							
							case 20: 
								if ((0x3ff000000000000L & l) == (ulong) 0L)
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAddTwoStates(15, 20);
								break;
							
							case 21: 
								if ((0x3ff000000000000L & l) == (ulong) 0L)
									break;
								if (kind > 1)
									kind = 1;
								JjCheckNAddStates(0, 17);
								break;
							
							case 22: 
								if ((0x3ff000000000000L & l) == (ulong) 0L)
									break;
								if (kind > 1)
									kind = 1;
								JjCheckNAdd(22);
								break;
							
							case 23: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddStates(24, 26);
								break;
							
							case 24: 
								if ((0x600000000000L & l) != (ulong) 0L)
									JjCheckNAdd(25);
								break;
							
							case 25: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddStates(27, 29);
								break;
							
							case 27: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(27, 28);
								break;
							
							case 28: 
								if ((0x600000000000L & l) != (ulong) 0L)
									JjCheckNAdd(29);
								break;
							
							case 29: 
								if ((0x3ff000000000000L & l) == (ulong) 0L)
									break;
								if (kind > 5)
									kind = 5;
								JjCheckNAddTwoStates(28, 29);
								break;
							
							case 30: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(30, 31);
								break;
							
							case 31: 
								if (curChar == 46)
									JjCheckNAdd(32);
								break;
							
							case 32: 
								if ((0x3ff000000000000L & l) == (ulong) 0L)
									break;
								if (kind > 6)
									kind = 6;
								JjCheckNAddTwoStates(31, 32);
								break;
							
							case 33: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(33, 34);
								break;
							
							case 34: 
								if ((0xf00000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(35, 36);
								break;
							
							case 35: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(35, 36);
								break;
							
							case 36: 
							case 37: 
								if ((0x3ff000000000000L & l) == (ulong) 0L)
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAdd(37);
								break;
							
							case 38: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(38, 39);
								break;
							
							case 40: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(40, 41);
								break;
							
							case 41: 
								if ((0xf00000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(42, 43);
								break;
							
							case 42: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(42, 43);
								break;
							
							case 43: 
							case 44: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(44, 45);
								break;
							
							case 45: 
								if ((0xf00000000000L & l) != (ulong) 0L)
									JjCheckNAdd(46);
								break;
							
							case 46: 
								if ((0x3ff000000000000L & l) == (ulong) 0L)
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAddTwoStates(41, 46);
								break;
							
							case 47: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(47, 48);
								break;
							
							case 49: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(49, 50);
								break;
							
							case 50: 
								if ((0xf00000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(51, 52);
								break;
							
							case 51: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(51, 52);
								break;
							
							case 52: 
							case 53: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(53, 54);
								break;
							
							case 54: 
								if ((0xf00000000000L & l) != (ulong) 0L)
									JjCheckNAdd(55);
								break;
							
							case 55: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(55, 56);
								break;
							
							case 56: 
								if ((0xf00000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(57, 58);
								break;
							
							case 57: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(57, 58);
								break;
							
							case 58: 
							case 59: 
								if ((0x3ff000000000000L & l) == (ulong) 0L)
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAddTwoStates(54, 59);
								break;
							
							case 60: 
								if ((0x3ff000000000000L & l) != (ulong) 0L)
									JjCheckNAddTwoStates(60, 61);
								break;
							
							case 64: 
								if (curChar == 39)
									jjstateSet[jjnewStateCnt++] = 65;
								break;
							
							case 67: 
								if (curChar == 46)
									JjCheckNAdd(68);
								break;
							
							case 69: 
								if (curChar != 46)
									break;
								if (kind > 3)
									kind = 3;
								JjCheckNAdd(68);
								break;
							
							case 71: 
								if (curChar == 38)
									jjstateSet[jjnewStateCnt++] = 72;
								break;
							
							default:  break;
							
						}
					}
					while (ii != startsAt);
				}
				else if (curChar < 128)
				{
					ulong l = ((ulong) 1L) << (curChar & 63);
					do 
					{
						switch (jjstateSet[--ii])
						{
							
							case 0: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddStates(30, 35);
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
								{
									if (kind > 1)
										kind = 1;
									JjCheckNAddStates(0, 17);
								}
								break;
							
							case 2: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjAddStates(36, 37);
								break;
							
							case 3: 
								if (curChar == 95)
									JjCheckNAdd(4);
								break;
							
							case 4: 
								if ((0x7fffffe07fffffeL & l) == (ulong) 0L)
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAdd(4);
								break;
							
							case 5: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(5, 6);
								break;
							
							case 6: 
								if (curChar == 95)
									JjCheckNAdd(7);
								break;
							
							case 7: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(7, 8);
								break;
							
							case 8: 
								if (curChar == 95)
									JjCheckNAddTwoStates(9, 10);
								break;
							
							case 9: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(9, 10);
								break;
							
							case 11: 
								if ((0x7fffffe07fffffeL & l) == (ulong) 0L)
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAddTwoStates(6, 11);
								break;
							
							case 12: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjAddStates(38, 39);
								break;
							
							case 13: 
								if (curChar == 95)
									JjCheckNAdd(14);
								break;
							
							case 14: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(14, 15);
								break;
							
							case 15: 
								if (curChar == 95)
									JjCheckNAddTwoStates(16, 17);
								break;
							
							case 16: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(16, 17);
								break;
							
							case 18: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjAddStates(40, 41);
								break;
							
							case 19: 
								if (curChar == 95)
									JjCheckNAdd(20);
								break;
							
							case 20: 
								if ((0x7fffffe07fffffeL & l) == (ulong) 0L)
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAddTwoStates(15, 20);
								break;
							
							case 21: 
								if ((0x7fffffe07fffffeL & l) == (ulong) 0L)
									break;
								if (kind > 1)
									kind = 1;
								JjCheckNAddStates(0, 17);
								break;
							
							case 22: 
								if ((0x7fffffe07fffffeL & l) == (ulong) 0L)
									break;
								if (kind > 1)
									kind = 1;
								JjCheckNAdd(22);
								break;
							
							case 23: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddStates(24, 26);
								break;
							
							case 24: 
								if (curChar == 95)
									JjCheckNAdd(25);
								break;
							
							case 25: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddStates(27, 29);
								break;
							
							case 26: 
								if (curChar == 64)
									JjCheckNAdd(27);
								break;
							
							case 27: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(27, 28);
								break;
							
							case 29: 
								if ((0x7fffffe07fffffeL & l) == (ulong) 0L)
									break;
								if (kind > 5)
									kind = 5;
								JjCheckNAddTwoStates(28, 29);
								break;
							
							case 30: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(30, 31);
								break;
							
							case 32: 
								if ((0x7fffffe07fffffeL & l) == (ulong) 0L)
									break;
								if (kind > 6)
									kind = 6;
								JjCheckNAddTwoStates(31, 32);
								break;
							
							case 33: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(33, 34);
								break;
							
							case 34: 
								if (curChar == 95)
									JjCheckNAddTwoStates(35, 36);
								break;
							
							case 35: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(35, 36);
								break;
							
							case 37: 
								if ((0x7fffffe07fffffeL & l) == (ulong) 0L)
									break;
								if (kind > 7)
									kind = 7;
								jjstateSet[jjnewStateCnt++] = 37;
								break;
							
							case 38: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(38, 39);
								break;
							
							case 40: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(40, 41);
								break;
							
							case 41: 
								if (curChar == 95)
									JjCheckNAddTwoStates(42, 43);
								break;
							
							case 42: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(42, 43);
								break;
							
							case 44: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjAddStates(42, 43);
								break;
							
							case 45: 
								if (curChar == 95)
									JjCheckNAdd(46);
								break;
							
							case 46: 
								if ((0x7fffffe07fffffeL & l) == (ulong) 0L)
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAddTwoStates(41, 46);
								break;
							
							case 47: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(47, 48);
								break;
							
							case 49: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(49, 50);
								break;
							
							case 50: 
								if (curChar == 95)
									JjCheckNAddTwoStates(51, 52);
								break;
							
							case 51: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(51, 52);
								break;
							
							case 53: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(53, 54);
								break;
							
							case 54: 
								if (curChar == 95)
									JjCheckNAdd(55);
								break;
							
							case 55: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(55, 56);
								break;
							
							case 56: 
								if (curChar == 95)
									JjCheckNAddTwoStates(57, 58);
								break;
							
							case 57: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(57, 58);
								break;
							
							case 59: 
								if ((0x7fffffe07fffffeL & l) == (ulong) 0L)
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAddTwoStates(54, 59);
								break;
							
							case 60: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(60, 61);
								break;
							
							case 62: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddStates(30, 35);
								break;
							
							case 63: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(63, 64);
								break;
							
							case 65: 
								if ((0x7fffffe07fffffeL & l) == (ulong) 0L)
									break;
								if (kind > 2)
									kind = 2;
								JjCheckNAddTwoStates(64, 65);
								break;
							
							case 66: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(66, 67);
								break;
							
							case 68: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjAddStates(44, 45);
								break;
							
							case 70: 
								if ((0x7fffffe07fffffeL & l) != (ulong) 0L)
									JjCheckNAddTwoStates(70, 71);
								break;
							
							case 71: 
								if (curChar == 64)
									JjCheckNAdd(72);
								break;
							
							case 72: 
								if ((0x7fffffe07fffffeL & l) == (ulong) 0L)
									break;
								if (kind > 4)
									kind = 4;
								JjCheckNAdd(72);
								break;
							
							default:  break;
							
						}
					}
					while (ii != startsAt);
				}
				else
				{
					int hiByte = (int) (curChar >> 8);
					int i1 = hiByte >> 6;
					ulong l1 = ((ulong) 1L) << (hiByte & 63);
					int i2 = (curChar & 0xff) >> 6;
					ulong l2 = ((ulong) 1L) << (curChar & 63);
					do 
					{
						switch (jjstateSet[--ii])
						{
							
							case 0: 
								if (jjCanMove_0(hiByte, i1, i2, (ulong) l1, (ulong) l2))
								{
									if (kind > 12)
										kind = 12;
								}
								if (jjCanMove_1(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddStates(18, 23);
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
								{
									if (kind > 1)
										kind = 1;
									JjCheckNAddStates(0, 17);
								}
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddStates(30, 35);
								break;
							
							case 1: 
								if (jjCanMove_1(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddStates(18, 23);
								break;
							
							case 2: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(2, 3);
								break;
							
							case 4: 
								if (!jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									break;
								if (kind > 7)
									kind = 7;
								jjstateSet[jjnewStateCnt++] = 4;
								break;
							
							case 5: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(5, 6);
								break;
							
							case 7: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjAddStates(46, 47);
								break;
							
							case 9: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjAddStates(48, 49);
								break;
							
							case 10: 
								if (!jjCanMove_1(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAddTwoStates(6, 11);
								break;
							
							case 11: 
								if (!jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAddTwoStates(6, 11);
								break;
							
							case 12: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(12, 13);
								break;
							
							case 14: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(14, 15);
								break;
							
							case 16: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjAddStates(50, 51);
								break;
							
							case 17: 
								if (jjCanMove_1(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(18, 19);
								break;
							
							case 18: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(18, 19);
								break;
							
							case 20: 
								if (!jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAddTwoStates(15, 20);
								break;
							
							case 21: 
								if (!jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									break;
								if (kind > 1)
									kind = 1;
								JjCheckNAddStates(0, 17);
								break;
							
							case 22: 
								if (!jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									break;
								if (kind > 1)
									kind = 1;
								JjCheckNAdd(22);
								break;
							
							case 23: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddStates(24, 26);
								break;
							
							case 25: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddStates(27, 29);
								break;
							
							case 27: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(27, 28);
								break;
							
							case 29: 
								if (!jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									break;
								if (kind > 5)
									kind = 5;
								JjCheckNAddTwoStates(28, 29);
								break;
							
							case 30: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(30, 31);
								break;
							
							case 32: 
								if (!jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									break;
								if (kind > 6)
									kind = 6;
								JjCheckNAddTwoStates(31, 32);
								break;
							
							case 33: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(33, 34);
								break;
							
							case 35: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjAddStates(52, 53);
								break;
							
							case 36: 
								if (!jjCanMove_1(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAdd(37);
								break;
							
							case 37: 
								if (!jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAdd(37);
								break;
							
							case 38: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(38, 39);
								break;
							
							case 39: 
								if (jjCanMove_1(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(2, 3);
								break;
							
							case 40: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(40, 41);
								break;
							
							case 42: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjAddStates(54, 55);
								break;
							
							case 43: 
								if (jjCanMove_1(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(44, 45);
								break;
							
							case 44: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(44, 45);
								break;
							
							case 46: 
								if (!jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAddTwoStates(41, 46);
								break;
							
							case 47: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(47, 48);
								break;
							
							case 48: 
								if (jjCanMove_1(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(5, 6);
								break;
							
							case 49: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(49, 50);
								break;
							
							case 51: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjAddStates(56, 57);
								break;
							
							case 52: 
								if (jjCanMove_1(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(53, 54);
								break;
							
							case 53: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(53, 54);
								break;
							
							case 55: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjAddStates(58, 59);
								break;
							
							case 57: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjAddStates(60, 61);
								break;
							
							case 58: 
								if (!jjCanMove_1(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAddTwoStates(54, 59);
								break;
							
							case 59: 
								if (!jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									break;
								if (kind > 7)
									kind = 7;
								JjCheckNAddTwoStates(54, 59);
								break;
							
							case 60: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(60, 61);
								break;
							
							case 61: 
								if (jjCanMove_1(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(12, 13);
								break;
							
							case 62: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddStates(30, 35);
								break;
							
							case 63: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(63, 64);
								break;
							
							case 65: 
								if (!jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									break;
								if (kind > 2)
									kind = 2;
								JjCheckNAddTwoStates(64, 65);
								break;
							
							case 66: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(66, 67);
								break;
							
							case 68: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjAddStates(44, 45);
								break;
							
							case 70: 
								if (jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									JjCheckNAddTwoStates(70, 71);
								break;
							
							case 72: 
								if (!jjCanMove_2(hiByte, i1, i2, (ulong) l1, (ulong) l2))
									break;
								if (kind > 4)
									kind = 4;
								jjstateSet[jjnewStateCnt++] = 72;
								break;
							
							default:  break;
							
						}
					}
					while (ii != startsAt);
				}
				if (kind != 0x7fffffff)
				{
					jjmatchedKind = kind;
					jjmatchedPos = curPos;
					kind = 0x7fffffff;
				}
				++curPos;
				if ((ii = jjnewStateCnt) == (startsAt = 73 - (jjnewStateCnt = startsAt)))
					return curPos;
				try
				{
					curChar = input_stream.ReadChar();
				}
				catch (System.IO.IOException)
				{
					return curPos;
				}
			}
		}
		internal static readonly int[] jjnextStates = new int[]{22, 23, 24, 26, 30, 31, 33, 34, 38, 39, 40, 41, 47, 48, 49, 50, 60, 61, 2, 3, 5, 6, 12, 13, 23, 24, 26, 24, 25, 26, 63, 64, 66, 67, 70, 71, 2, 3, 12, 13, 18, 19, 44, 45, 68, 69, 7, 8, 9, 10, 16, 17, 35, 36, 42, 43, 51, 52, 55, 56, 57, 58};
		private static bool jjCanMove_0(int hiByte, int i1, int i2, ulong l1, ulong l2)
		{
			switch (hiByte)
			{
				
				case 48: 
					return ((jjbitVec2[i2] & l2) != (ulong) 0L);
				
				case 49: 
					return ((jjbitVec3[i2] & l2) != (ulong) 0L);
				
				case 51: 
					return ((jjbitVec4[i2] & l2) != (ulong) 0L);
				
				case 61: 
					return ((jjbitVec5[i2] & l2) != (ulong) 0L);
				
				default: 
					if ((jjbitVec0[i1] & l1) != (ulong) 0L)
						return true;
					return false;
				
			}
		}
		private static bool jjCanMove_1(int hiByte, int i1, int i2, ulong l1, ulong l2)
		{
			switch (hiByte)
			{
				
				case 6: 
					return ((jjbitVec8[i2] & l2) != (ulong) 0L);
				
				case 11: 
					return ((jjbitVec9[i2] & l2) != (ulong) 0L);
				
				case 13: 
					return ((jjbitVec10[i2] & l2) != (ulong) 0L);
				
				case 14: 
					return ((jjbitVec11[i2] & l2) != (ulong) 0L);
				
				case 16: 
					return ((jjbitVec12[i2] & l2) != (ulong) 0L);
				
				default: 
					if ((jjbitVec6[i1] & l1) != (ulong) 0L)
						if ((jjbitVec7[i2] & l2) == (ulong) 0L)
							return false;
						else
							return true;
					return false;
				
			}
		}
		private static bool jjCanMove_2(int hiByte, int i1, int i2, ulong l1, ulong l2)
		{
			switch (hiByte)
			{
				
				case 0: 
					return ((jjbitVec14[i2] & l2) != (ulong) 0L);
				
				default: 
					if ((jjbitVec13[i1] & l1) != (ulong) 0L)
						return true;
					return false;
				
			}
		}
		public static readonly System.String[] jjstrLiteralImages = new System.String[]{"", null, null, null, null, null, null, null, null, null, null, null, null, null, null};
		public static readonly System.String[] lexStateNames = new System.String[]{"DEFAULT"};
		internal static readonly long[] jjtoToken = new long[]{0x10ffL};
		internal static readonly long[] jjtoSkip = new long[]{0x4000L};
		protected internal CharStream input_stream;
		private uint[] jjrounds = new uint[73];
		private int[] jjstateSet = new int[146];
		protected internal char curChar;
		public StandardTokenizerTokenManager(CharStream stream)
		{
			InitBlock();
			input_stream = stream;
		}
		public StandardTokenizerTokenManager(CharStream stream, int lexState):this(stream)
		{
			SwitchTo(lexState);
		}
		public virtual void  ReInit(CharStream stream)
		{
			jjmatchedPos = jjnewStateCnt = 0;
			curLexState = defaultLexState;
			input_stream = stream;
			ReInitRounds();
		}
		private void  ReInitRounds()
		{
			int i;
			jjround = 0x80000001;
			for (i = 73; i-- > 0; )
				jjrounds[i] = 0x80000000;
		}
		public virtual void  ReInit(CharStream stream, int lexState)
		{
			ReInit(stream);
			SwitchTo(lexState);
		}
		public virtual void  SwitchTo(int lexState)
		{
			if (lexState >= 1 || lexState < 0)
				throw new TokenMgrError("Error: Ignoring invalid lexical state : " + lexState + ". State unchanged.", TokenMgrError.INVALID_LEXICAL_STATE);
			else
				curLexState = lexState;
		}
		
		protected internal virtual Token JjFillToken()
		{
			Token t = Token.NewToken(jjmatchedKind);
			t.kind = jjmatchedKind;
			System.String im = jjstrLiteralImages[jjmatchedKind];
			t.image = (im == null) ? input_stream.GetImage() : im;
			t.beginLine = input_stream.GetBeginLine();
			t.beginColumn = input_stream.GetBeginColumn();
			t.endLine = input_stream.GetEndLine();
			t.endColumn = input_stream.GetEndColumn();
			return t;
		}
		
		internal int curLexState = 0;
		internal int defaultLexState = 0;
		internal int jjnewStateCnt;
		internal uint jjround;
		internal int jjmatchedPos;
		internal int jjmatchedKind;
		
		public virtual Token GetNextToken()
		{
			Token matchedToken;
			int curPos = 0;
			
			for (; ; )
			{
				try
				{
					curChar = input_stream.BeginToken();
				}
				catch (System.IO.IOException)
				{
					jjmatchedKind = 0;
					matchedToken = JjFillToken();
					return matchedToken;
				}
				
				jjmatchedKind = 0x7fffffff;
				jjmatchedPos = 0;
				curPos = JjMoveStringLiteralDfa0_0();
				if (jjmatchedPos == 0 && jjmatchedKind > 14)
				{
					jjmatchedKind = 14;
				}
				if (jjmatchedKind != 0x7fffffff)
				{
					if (jjmatchedPos + 1 < curPos)
						input_stream.Backup(curPos - jjmatchedPos - 1);
					if ((jjtoToken[jjmatchedKind >> 6] & (1L << (jjmatchedKind & 63))) != 0L)
					{
						matchedToken = JjFillToken();
						return matchedToken;
					}
					else
					{
						goto EOFLoop;
					}
				}
				int error_line = input_stream.GetEndLine();
				int error_column = input_stream.GetEndColumn();
				System.String error_after = null;
				bool EOFSeen = false;
				try
				{
					input_stream.ReadChar(); input_stream.Backup(1);
				}
				catch (System.IO.IOException)
				{
					EOFSeen = true;
					error_after = curPos <= 1?"":input_stream.GetImage();
					if (curChar == '\n' || curChar == '\r')
					{
						error_line++;
						error_column = 0;
					}
					else
						error_column++;
				}
				if (!EOFSeen)
				{
					input_stream.Backup(1);
					error_after = curPos <= 1?"":input_stream.GetImage();
				}
				throw new TokenMgrError(EOFSeen, curLexState, error_line, error_column, error_after, curChar, TokenMgrError.LEXICAL_ERROR);

EOFLoop: ;
			}
		}
	}
}