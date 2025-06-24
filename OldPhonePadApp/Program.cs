// See https://aka.ms/new-console-template for more information
using OldPhonePadApp.Test;

OldPhonePadTest oldPhonePadTest = new OldPhonePadTest();

oldPhonePadTest.Decode_ShouldReturnExpectedText("8*88#", "U");
oldPhonePadTest.Decode_ShouldReturnExpectedText("4433555 555666096667775553", "HELLO WORLD");
oldPhonePadTest.Decode_ShouldReturnExpectedText("222 666 6660", "COO ");
oldPhonePadTest.Decode_ShouldReturnExpectedText("33#", "E");
oldPhonePadTest.Decode_ShouldReturnExpectedText("227*#", "B");
oldPhonePadTest.Decode_ShouldReturnExpectedText("4433555 555666#", "HELLO");
oldPhonePadTest.Decode_ShouldReturnExpectedText("8 88777444666*664#", "TURINNG");
